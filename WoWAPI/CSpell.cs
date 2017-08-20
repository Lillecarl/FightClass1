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
using System.Runtime.InteropServices;
using WoWDB.Entities;
using WoWDB;

namespace WoWAPI
{
    public class CSpell : Spell
    {
        public static CSpell GetHighestSpellById(uint spellId)
        {
            var spell = new CSpell(spellId);
            spell = new CSpell(spell.GetHighestKnownSpell());
            return spell;
        }

        public CSpell(string spellNameEnglish) : base(spellNameEnglish) { Init(); }
        public CSpell(int spellId) : base(spellId) { Init(); }
        public CSpell(uint spellId) : base(spellId) { Init(); }
        public CSpell(string spellNameEnglish, bool showLog) : base(spellNameEnglish, showLog) { Init(); }

        public CSpell Init()
        {
            SpellEntry = DBC.Spell[GetHighestKnownSpell()];
            return this;
        }

        public SpellInfo SpellInfo { get { return SpellManager.GetSpellInfo(this.Id); } }

        public SpellEntry SpellEntry { get; private set; }

        public bool CanCast(bool checkrange = false)
        {
            bool inrange = !checkrange;

            if (!inrange && WoWAPI.Target != null)
                inrange = WoWAPI.GetDistance(WoWAPI.Player, WoWAPI.Target) < MaxRange;

            if (inrange && !ObjectManager.Me.IsCast && IsSpellUsable && !WoWAPI.Player.HaveBuff("Drink") && !WoWAPI.Player.HaveBuff("Food"))
                return true;

            return false;
        }

        public void LaunchUsable(bool self = false, bool checkrange = false)
        {
            bool inrange = !checkrange;

            if (!inrange && WoWAPI.Target != null)
                inrange = WoWAPI.GetDistance(WoWAPI.Player, WoWAPI.Target) < MaxRange;

            if (inrange && !ObjectManager.Me.IsCast && IsSpellUsable && !WoWAPI.Player.HaveBuff("Drink") && !WoWAPI.Player.HaveBuff("Food"))
            {
                if (self)
                    Lua.RunMacroText(string.Format("/cast [@player] {0}", this.NameInGame));
                else
                    Lua.RunMacroText(string.Format("/cast {0}", this.NameInGame));
            }
        }

        public void LaunchUsable(string targetname, bool checkrange = false)
        {
            WoWUnit target = null;

            foreach (var i in ObjectManager.GetObjectWoWPlayer())
                if (i.Name.ToLower() == targetname.ToLower())
                    target = i;

            if (ObjectManager.Me.Name.ToLower() == targetname.ToLower())
                target = ObjectManager.Me;

            bool inrange = !checkrange;

            if (!inrange && target != null)
                inrange = WoWAPI.GetDistance(ObjectManager.Me, target) < MaxRange;

            Logging.WriteDebug(string.Format("Casting {0} on {1} ({2}", NameInGame, targetname, target.Guid));

            if (target != null && inrange && !ObjectManager.Me.IsCast && IsSpellUsable && !ObjectManager.Me.HaveBuff("Drink") && !ObjectManager.Me.HaveBuff("Food"))
            {
                string luastring = string.Format("/cast [target={0}] {1}", targetname, this.NameInGame);
                Lua.RunMacroText(luastring);
                Logging.WriteDebug(luastring);
            }
        }

        public List<uint> GetKnownSpellIds()
        {
            return Ids.Where(SpellManager.KnowSpell).OrderBy(i => i).Distinct().ToList();
        }

        public uint GetHighestKnownSpell()
        {
            return Ids.Where(SpellManager.KnowSpell).OrderByDescending(i => i).FirstOrDefault();
        }

        public long RealManaCost(long basemana)
        {
            long manacost = ManaCost;

            if (ManaCostPercentage != 0)
                manacost += basemana * ManaCostPercentage / 100;

            return manacost;
        }

        // Wrapper or smth...
        public uint ID { get { return SpellEntry.ID; } }
        public uint Category { get { return SpellEntry.Category; } }
        public uint CastUI { get { return SpellEntry.CastUI; } }
        public uint Dispel { get { return SpellEntry.Dispel; } }
        public uint Mechanic { get { return SpellEntry.Mechanic; } }
        public uint Attributes { get { return SpellEntry.Attributes; } }
        public uint AttributesEx { get { return SpellEntry.AttributesEx; } }
        public uint AttributesEx2 { get { return SpellEntry.AttributesEx2; } }
        public uint AttributesEx3 { get { return SpellEntry.AttributesEx3; } }
        public uint AttributesEx4 { get { return SpellEntry.AttributesEx4; } }
        public uint AttributesEx5 { get { return SpellEntry.AttributesEx5; } }
        public uint AttributesEx6 { get { return SpellEntry.AttributesEx6; } }
        public uint Stances { get { return SpellEntry.Stances; } }
        public uint StancesNot { get { return SpellEntry.StancesNot; } }
        public uint Targets { get { return SpellEntry.Targets; } }
        public uint TargetCreatureType { get { return SpellEntry.TargetCreatureType; } }
        public uint RequiresSpellFocus { get { return SpellEntry.RequiresSpellFocus; } }
        public uint FacingCasterFlags { get { return SpellEntry.FacingCasterFlags; } }
        public uint CasterAuraState { get { return SpellEntry.CasterAuraState; } }
        public uint TargetAuraState { get { return SpellEntry.TargetAuraState; } }
        public uint CasterAuraStateNot { get { return SpellEntry.CasterAuraStateNot; } }
        public uint TargetAuraStateNot { get { return SpellEntry.TargetAuraStateNot; } }
        public uint CastingTimeIndex { get { return SpellEntry.CastingTimeIndex; } }
        public uint RecoveryTime { get { return SpellEntry.RecoveryTime; } }
        public uint CategoryRecoveryTime { get { return SpellEntry.CategoryRecoveryTime; } }
        public uint InterruptFlags { get { return SpellEntry.InterruptFlags; } }
        public uint AuraInterruptFlags { get { return SpellEntry.AuraInterruptFlags; } }
        public uint ChannelInterruptFlags { get { return SpellEntry.ChannelInterruptFlags; } }
        public uint ProcFlags { get { return SpellEntry.ProcFlags; } }
        public uint ProcChance { get { return SpellEntry.ProcChance; } }
        public uint ProcCharges { get { return SpellEntry.ProcCharges; } }
        public uint MaxLevel { get { return SpellEntry.MaxLevel; } }
        public uint BaseLevel { get { return SpellEntry.BaseLevel; } }
        public uint SpellLevel { get { return SpellEntry.SpellLevel; } }
        public uint DurationIndex { get { return SpellEntry.DurationIndex; } }
        public uint PowerType { get { return SpellEntry.PowerType; } }
        public uint ManaCost { get { return SpellEntry.ManaCost; } }
        public uint ManaCostPerlevel { get { return SpellEntry.ManaCostPerlevel; } }
        public uint ManaPerSecond { get { return SpellEntry.ManaPerSecond; } }
        public uint ManaPerSecondPerLevel { get { return SpellEntry.ManaPerSecondPerLevel; } }
        public uint RangeIndex { get { return SpellEntry.RangeIndex; } }
        public float Speed { get { return SpellEntry.Speed; } }
        public uint ModalNextSpell { get { return SpellEntry.ModalNextSpell; } }
        public uint StackAmount { get { return SpellEntry.StackAmount; } }
        public uint[] Totem { get { return SpellEntry.Totem; } }
        public int[] Reagent { get { return SpellEntry.Reagent; } }
        public uint[] ReagentCount { get { return SpellEntry.ReagentCount; } }
        public int EquippedItemClass { get { return SpellEntry.EquippedItemClass; } }
        public int EquippedItemSubClassMask { get { return SpellEntry.EquippedItemSubClassMask; } }
        public int EquippedItemInventoryTypeMask { get { return SpellEntry.EquippedItemInventoryTypeMask; } }
        public uint[] Effect { get { return SpellEntry.Effect; } }
        public int[] EffectDieSides { get { return SpellEntry.EffectDieSides; } }
        public uint[] EffectBaseDice { get { return SpellEntry.EffectBaseDice; } }
        public float[] EffectDicePerLevel { get { return SpellEntry.EffectDicePerLevel; } }
        public float[] EffectRealPointsPerLevel { get { return SpellEntry.EffectRealPointsPerLevel; } }
        public int[] EffectBasePoints { get { return SpellEntry.EffectBasePoints; } }
        public uint[] EffectMechanic { get { return SpellEntry.EffectMechanic; } }
        public uint[] EffectImplicitTargetA { get { return SpellEntry.EffectImplicitTargetA; } }
        public uint[] EffectImplicitTargetB { get { return SpellEntry.EffectImplicitTargetB; } }
        public uint[] EffectRadiusIndex { get { return SpellEntry.EffectRadiusIndex; } }
        public uint[] EffectApplyAuraName { get { return SpellEntry.EffectApplyAuraName; } }
        public uint[] EffectAmplitude { get { return SpellEntry.EffectAmplitude; } }
        public float[] EffectMultipleValue { get { return SpellEntry.EffectMultipleValue; } }
        public uint[] EffectChainTarget { get { return SpellEntry.EffectChainTarget; } }
        public uint[] EffectItemType { get { return SpellEntry.EffectItemType; } }
        public int[] EffectMiscValue { get { return SpellEntry.EffectMiscValue; } }
        public int[] EffectMiscValueB { get { return SpellEntry.EffectMiscValueB; } }
        public uint[] EffectTriggerSpell { get { return SpellEntry.EffectTriggerSpell; } }
        public float[] EffectPointsPerComboPoint { get { return SpellEntry.EffectPointsPerComboPoint; } }
        public uint[] SpellVisual { get { return SpellEntry.SpellVisual; } }
        public uint SpellIconID { get { return SpellEntry.SpellIconID; } }
        public uint ActiveIconID { get { return SpellEntry.ActiveIconID; } }
        public uint SpellPriority { get { return SpellEntry.SpellPriority; } }
        public uint SpellNameFlag { get { return SpellEntry.SpellNameFlag; } }
        public uint RankFlags { get { return SpellEntry.RankFlags; } }
        public uint DescriptionFlags { get { return SpellEntry.DescriptionFlags; } }
        public uint ToolTipFlags { get { return SpellEntry.ToolTipFlags; } }
        public uint ManaCostPercentage { get { return SpellEntry.ManaCostPercentage; } }
        public uint StartRecoveryCategory { get { return SpellEntry.StartRecoveryCategory; } }
        public uint StartRecoveryTime { get { return SpellEntry.StartRecoveryTime; } }
        public uint MaxTargetLevel { get { return SpellEntry.MaxTargetLevel; } }
        public uint SpellFamilyName { get { return SpellEntry.SpellFamilyName; } }
        public uint[] SpellFamilyFlags { get { return SpellEntry.SpellFamilyFlags; } }
        public uint MaxAffectedTargets { get { return SpellEntry.MaxAffectedTargets; } }
        public uint DmgClass { get { return SpellEntry.DmgClass; } }
        public uint PreventionType { get { return SpellEntry.PreventionType; } }
        public uint StanceBarOrder { get { return SpellEntry.StanceBarOrder; } }
        public float[] DmgMultiplier { get { return SpellEntry.DmgMultiplier; } }
        public uint MinFactionId { get { return SpellEntry.MinFactionId; } }
        public uint MinReputation { get { return SpellEntry.MinReputation; } }
        public uint RequiredAuraVision { get { return SpellEntry.RequiredAuraVision; } }
        public uint[] TotemCategory { get { return SpellEntry.TotemCategory; } }
        public int AreaGroupId { get { return SpellEntry.AreaGroupId; } }
        public uint SchoolMask { get { return SpellEntry.SchoolMask; } }
    }
}
