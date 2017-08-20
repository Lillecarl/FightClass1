using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using robotManager;
using robotManager.FiniteStateMachine;
using robotManager.Helpful;
using wManager.Wow.Class;
using wManager.Wow.Helpers;
using wManager.Wow.ObjectManager;
using wManager.Wow.Bot.States;
using Timer = robotManager.Helpful.Timer;
using wManager.Wow.Enums;
using SpellWork;
using WoWDB;
using WoWDB.Entities;
using WoWAPI;
using System.Diagnostics;

namespace FightClass1.FightClasses
{
    class Druid_Feral : FighterBase
    {
        CSpell shadowmeld = new CSpell("Shadowmeld");
        CSpell regrowth = new CSpell("Regrowth");
        CSpell prowl = new CSpell("Prowl");
        CSpell catform = new CSpell(768);
        CSpell motw = new CSpell("Mark of the Wild");
        CSpell thorns = new CSpell("Thorns");
        CSpell rejuvenation = new CSpell("Rejuvenation");
        CSpell claw = new CSpell("Claw");
        CSpell ferociousbite = new CSpell("Ferocious Bite");
        CSpell faeriefireferal = new CSpell("Faerie Fire (Feral)");
        CSpell faeriefire = new CSpell("Faerie Fire");
        CSpell manglecat = new CSpell("Mangle (Cat)");
        CSpell rake = new CSpell("Rake");
        CSpell aquaticform = new CSpell("Aquatic Form");
        CSpell travelform = new CSpell("Travel Form");
        CSpell innervate = new CSpell("Innervate");
        CSpell attack = new CSpell("Attack");

        WoWLocalPlayer player = null;
        WoWUnit target = null;

        DateTime _LastRunOnInterval = DateTime.Now.AddDays(-1);

        Int64 basemana = 0;

        int _RunOnInterval = 2;
        DateTime lastupdate = DateTime.Now;

        public override void Init()
        {
        }

        public override void Update()
        {
            if ((DateTime.Now - lastupdate).TotalMilliseconds < 500)
                return;

            lastupdate = DateTime.Now;

            DateTime start = DateTime.Now;

            player = WoWAPI.WoWAPI.Player;
            target = WoWAPI.WoWAPI.Target;

            if (player.IsDead)
                return;

            Heal();

            /*if (!player.InCombat && !player.HaveBuff("Prowl") && SpellManager.KnowSpell("Pounce") && WoWAPI.WoWAPI.GetDistance(player, target) < target.AggroDistance + 5)
                prowl.LaunchUsable();*/

            if (player.InCombat)
            {
                if (target != null)
                {
                    if (!player.HaveBuff("Cat Form") && target.IsAttackable && WoWAPI.WoWAPI.GetDistance(player, target) < target.AggroDistance + 10)
                        catform.LaunchUsable();

                    if (target.HaveBuff("Mangle (Cat)") && !target.HaveBuff("Rake"))
                        rake.LaunchUsable();

                    if (!target.HaveBuff("Mangle (Cat)") && target.HaveBuff("Rake"))
                        manglecat.LaunchUsable();

                    if (player.ComboPoint < 5)
                    {
                        manglecat.LaunchUsable();
                        claw.LaunchUsable();
                    }
                    else if (player.ComboPoint == 5)
                        ferociousbite.LaunchUsable();
                }
            }
            else if (!player.IsMounted)
            {
                if (player.IsSwimming && !player.HaveBuff("Aquatic Form"))
                    aquaticform.LaunchUsable();
                /*if (player.GetMove && WoWAPI.WoWAPI.GetDistance(player.Position, MovementManager.CurrentPath.LastOrDefault()) > 50)
                    travelform.LaunchUsable();*/

            }

            if (target != null && target.IsAttackable && !target.HaveBuff("Faerie Fire") && !target.HaveBuff("Faerie Fire (Feral)") && !player.HaveBuff("Prowl"))
            {
                if (player.HaveBuff("Cat Form") || player.HaveBuff("Bear Form") || player.HaveBuff("Dire Bear Form"))
                {
                    if (WoWAPI.WoWAPI.GetDistance(player, target) < faeriefireferal.MaxRange)
                    {
                        // For some reason this spell is bugged and can't be cast like other spells...
                        Lua.RunMacroText("/cast Faerie Fire (Feral)(Rank 5)");
                        Lua.RunMacroText("/cast Faerie Fire (Feral)(Rank 4)");
                        Lua.RunMacroText("/cast Faerie Fire (Feral)(Rank 3)");
                        Lua.RunMacroText("/cast Faerie Fire (Feral)(Rank 2)");
                        Lua.RunMacroText("/cast Faerie Fire (Feral)(Rank 1)");
                    }
                }
                else
                    faeriefire.LaunchUsable(true);
            }

            if (player.ManaPercentage < 20)
                innervate.LaunchUsable(true, false);

            RunOnInterval();

            if (player.Level == 70)
            {
                try
                {
                    foreach (Process proc in Process.GetProcessesByName("wow"))
                    {
                        proc.Kill();
                    }
                }
                catch
                {
                }
            }

            Logging.WriteDebug(string.Format("FightClass update took {0} ms", (DateTime.Now - start).TotalMilliseconds));
        }

        public void RunOnInterval()
        {
            if (DateTime.Now > _LastRunOnInterval.AddSeconds(_RunOnInterval) && !player.IsMounted)
            {
                basemana = Database.ExecuteScalar<long>("SELECT basemana FROM player_classlevelstats WHERE Class = @Class AND level = @Level LIMIT 1", new { Class = player.WowClass.ToUInt32(), Level = player.Level });

                Buff();
                RemoveItems();

                _LastRunOnInterval = DateTime.Now;
            }
        }

        public void Buff()
        {
            if (player.IsMounted || player.InCombat)
                return;

            var players = new List<WoWPlayer>() { player };

            foreach (var i in Party.GetParty())
                players.Add(i);

            foreach (var i in Party.GetRaidMembers())
                players.Add(i);

            foreach (var i in ObjectManager.GetObjectWoWPlayer())
                if (!i.IsAttackable)
                    players.Add(i);

            foreach (var i in players)
            {
                if (i.IsDead)
                    continue;

                if (!i.HaveBuff("Mark of the Wild") && !i.HaveBuff("Gift of the Wild"))
                    motw.LaunchUsable(i.Name, true);

                if (!i.HaveBuff("Thorns"))
                    thorns.LaunchUsable(i.Name, true);
            }
        }

        public void Heal()
        {
            if (player.IsMounted)
                return;

            var players = new List<WoWPlayer>() { player };

            foreach (var i in Party.GetParty())
                players.Add(i);

            foreach (var i in Party.GetRaidMembers())
                players.Add(i);

            foreach (var i in players)
            {
                if (i.IsDead)
                    continue;

                long manacost = regrowth.RealManaCost(player.MaxMana);
                if (player.HaveBuff("Cat Form"))
                    manacost += catform.RealManaCost(basemana);

                if (i.MaxHealth - i.Health > 1500 && player.Mana > manacost && !i.HaveBuff("Regrowth") && !player.IsCast)
                    regrowth.LaunchUsable(i.Name, true);
            }
        }

        public void RemoveItems()
        {
            if (player.InCombat)
                return;

            foreach (var i in EquippedItems.GetEquippedItems())
            {
            }

            foreach (var i in Bag.GetBagItem())
            {
                var item = Database.Get<item_template, int>(i.Entry);

                bool remove = true;

                if (item.entry == 6948 || item.name.ToLower().Contains("hearthstone"))
                    remove = false;

                if (!((item.Quality == 0/* || item.Quality == 1*/) && item.bonding != 4 && item.spellid_1 == 0 && item.spellid_2 == 0 && item.spellid_3 == 0 && item.spellid_4 == 0 && item.spellid_5 == 0))
                    remove = false;

                if (remove)
                    RemoveItem(item);
            }
        }

        public void RemoveItem(string name)
        {
            Logging.WriteDebug(string.Format("Removing item {0}", name));
            Lua.RunMacroText(string.Format("/run for b=0,4 do for s=1,36 do n=GetContainerItemLink(b,s);if n and string.find(n,\"{0}\") then PickupContainerItem(b,s);DeleteCursorItem();end;end;end;", name));
        }

        public void RemoveItem(int entry)
        {
            Logging.WriteDebug(string.Format("Removing item {0}", entry));
            Lua.RunMacroText(string.Format("/run for b=0,4 do for s=1,36 do n=GetContainerItemLink(b,s);if n and string.find(n,\"{0}\") then PickupContainerItem(b,s);DeleteCursorItem();end;end;end;", entry));
        }

        public void RemoveItem(item_template item)
        {
            Logging.WriteDebug(string.Format("Removing item {0} {1}", item.name, item.entry));
            Lua.RunMacroText(string.Format("/run for b=0,4 do for s=1,36 do n=GetContainerItemLink(b,s);if n and string.find(n,\"{0}\") then PickupContainerItem(b,s);DeleteCursorItem();end;end;end;", item.entry));
        }
    }
}
