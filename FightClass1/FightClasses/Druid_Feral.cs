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

        WoWLocalPlayer player = null;
        WoWUnit target = null;

        DateTime _LastRunOnInterval = DateTime.Now.AddDays(-1);

        Int64 basemana = 0;

        int _RunOnInterval = 2;

        public override void Init()
        {
        }

        public override void Update()
        {
            player = ObjectManager.Me;
            target = ObjectManager.Target;

            if (player.IsDead)
                return;

            long manacost = regrowth.RealManaCost(player.MaxMana);
            if (player.HaveBuff("Cat Form"))
                manacost += catform.RealManaCost(basemana);

            if (((player.MaxHealth - player.Health > 700 && !player.HaveBuff("Regrowth")) || (player.HealthPercent < 30)) && player.Mana >= manacost)
                regrowth.LaunchUsable();

            if (!player.InCombat && !player.HaveBuff("Prowl") && SpellManager.KnowSpell("Pounce") && Helper.GetRange(player, target) < target.AggroDistance + 5)
                prowl.LaunchUsable();

            if (player.InCombat)
            {
                if (target != null)
                {
                    if (!player.HaveBuff("Cat Form") && target.IsAttackable && Helper.GetRange(player, target) < target.AggroDistance + 10)
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

            if (target != null && target.IsAttackable && !target.HaveBuff("Faerie Fire") && !target.HaveBuff("Faerie Fire (Feral)") && !player.HaveBuff("Prowl"))
            {
                if (player.HaveBuff("Cat Form") || player.HaveBuff("Bear Form") || player.HaveBuff("Dire Bear Form"))
                {
                    if (Helper.GetRange(player, target) < faeriefireferal.MaxRange)
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

            RunOnInterval();
        }

        public void RunOnInterval()
        {
            if (DateTime.Now > _LastRunOnInterval.AddSeconds(_RunOnInterval) && !player.IsMounted)
            {
                basemana = DataMgr.player_classlevelstats.Where(m => m.Class == (long)player.WowClass && m.level == player.Level).Single().basemana;

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

            foreach (var i in players)
            {
                if (!i.HaveBuff("Mark of the Wild") && !i.HaveBuff("Gift of the Wild"))
                {
                    player.Target = i.Guid;
                    motw.LaunchUsable();
                }

                if (!i.HaveBuff("Thorns"))
                {
                    player.Target = i.Guid;
                    thorns.LaunchUsable();
                }
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
                var item = DataMgr.item_template.Where(m => m.entry == i.Entry).Single();

                if ((item.Quality == 0 || item.Quality == 1) && item.bonding != 4 && item.spellid_1 == 0 && item.spellid_2 == 0 && item.spellid_3 == 0 && item.spellid_4 == 0 && item.spellid_5 == 0)
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
