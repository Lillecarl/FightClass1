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

namespace FightClass1.FightClasses
{
    class Druid_Feral : FighterBase
    {
        CSpell shadowmeld = new CSpell("Shadowmeld", false);
        CSpell regrowth = new CSpell("Regrowth", false);
        CSpell prowl = new CSpell("Prowl", false);
        CSpell catform = new CSpell("Cat Form", false);
        CSpell motw = new CSpell("Mark of the Wild", false);
        CSpell thorns = new CSpell("Thorns", false);
        CSpell rejuvenation = new CSpell("Rejuvenation", false);
        CSpell claw = new CSpell("Claw", false);
        CSpell ferociousbite = new CSpell("Ferocious Bite", false);

        public override void Init()
        {
        }

        public override void Update()
        {
            var player = ObjectManager.Me;
            var target = ObjectManager.Target;

            if (!player.InCombat)
            {
                if (!player.HaveBuff("Mark of the Wild"))
                    motw.LaunchUsable(false, true, true, true);

                if (!player.HaveBuff("Thorns"))
                    thorns.LaunchUsable(false, true, true, true);
            }
            else
            {
                if (target != null)
                {
                    if (!player.HaveBuff("Cat Form") && target.IsAttackable && GetRange(player, target) < target.AggroDistance + 10)
                        catform.LaunchUsable(false, true, false, true);

                    if (!player.InCombat && !player.HaveBuff("Prowl") && SpellManager.KnowSpell("Pounce") && GetRange(player, target) < target.AggroDistance + 5)
                        prowl.LaunchUsable(false, true, false, true);

                    uint manacost = regrowth.ManaCost;
                    if (player.HaveBuff("Cat Form"))
                        manacost += catform.ManaCost;

                    if (player.MaxHealth - player.Health > 400 && !player.HaveBuff("Regrowth") && player.Mana >= manacost)
                        regrowth.LaunchUsable(false, true, false, true);

                    if (player.ComboPoint < 5)
                        claw.Launch(false, true, false, false);
                    else if (player.ComboPoint == 5)
                        ferociousbite.LaunchUsable(false, true, false, false);
                }
            }
        }
    }
}
