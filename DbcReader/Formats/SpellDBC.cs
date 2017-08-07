using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbcReader;

using uint32 = System.UInt32;
using int32 = System.Int32;

namespace DbcReader.Formats
{
    public class SpellDBC
    {
        [DbcRecordPosition(0)]
        public uint32 Id;                                       // 0        m_ID
        [DbcRecordPosition(1)]
        public uint32 Category;                                 // 1        m_category
        // uint32     castUI                                // 2 not used
        [DbcRecordPosition(3)]
        public uint32 Dispel;                                   // 3        m_dispelType
        [DbcRecordPosition(4)]
        public uint32 Mechanic;                                 // 4        m_mechanic
        [DbcRecordPosition(5)]
        public uint32 Attributes;                               // 5        m_attributes
        [DbcRecordPosition(6)]
        public uint32 AttributesEx;                             // 6        m_attributesEx
        [DbcRecordPosition(7)]
        public uint32 AttributesEx2;                            // 7        m_attributesExB
        [DbcRecordPosition(8)]
        public uint32 AttributesEx3;                            // 8        m_attributesExC
        [DbcRecordPosition(9)]
        public uint32 AttributesEx4;                            // 9        m_attributesExD
        [DbcRecordPosition(10)]
        public uint32 AttributesEx5;                            // 10       m_attributesExE
        [DbcRecordPosition(11)]
        public uint32 AttributesEx6;                            // 11       m_attributesExF
        [DbcRecordPosition(12)]
        public uint32 Stances;                                  // 12       m_shapeshiftMask
        [DbcRecordPosition(13)]
        public uint32 StancesNot;                               // 13       m_shapeshiftExclude
        [DbcRecordPosition(14)]
        public uint32 Targets;                                  // 14       m_targets
        [DbcRecordPosition(15)]
        public uint32 TargetCreatureType;                       // 15       m_targetCreatureType
        [DbcRecordPosition(16)]
        public uint32 RequiresSpellFocus;                       // 16       m_requiresSpellFocus
        [DbcRecordPosition(17)]
        public uint32 FacingCasterFlags;                        // 17       m_facingCasterFlags
        [DbcRecordPosition(18)]
        public uint32 CasterAuraState;                          // 18       m_casterAuraState
        [DbcRecordPosition(19)]
        public uint32 TargetAuraState;                          // 19       m_targetAuraState
        [DbcRecordPosition(20)]
        public uint32 CasterAuraStateNot;                       // 20       m_excludeCasterAuraState
        [DbcRecordPosition(21)]
        public uint32 TargetAuraStateNot;                       // 21       m_excludeTargetAuraState
        [DbcRecordPosition(22)]
        public uint32 CastingTimeIndex;                         // 22       m_castingTimeIndex
        [DbcRecordPosition(23)]
        public uint32 RecoveryTime;                             // 23       m_recoveryTime
        [DbcRecordPosition(24)]
        public uint32 CategoryRecoveryTime;                     // 24       m_categoryRecoveryTime
        [DbcRecordPosition(25)]
        public uint32 InterruptFlags;                           // 25       m_interruptFlags
        [DbcRecordPosition(26)]
        public uint32 AuraInterruptFlags;                       // 26       m_auraInterruptFlags
        [DbcRecordPosition(27)]
        public uint32 ChannelInterruptFlags;                    // 27       m_channelInterruptFlags
        [DbcRecordPosition(28)]
        public uint32 procFlags;                                // 28       m_procTypeMask
        [DbcRecordPosition(29)]
        public uint32 procChance;                               // 29       m_procChance
        [DbcRecordPosition(30)]
        public uint32 procCharges;                              // 30       m_procCharges
        [DbcRecordPosition(31)]
        public uint32 maxLevel;                                 // 31       m_maxLevel
        [DbcRecordPosition(32)]
        public uint32 baseLevel;                                // 32       m_baseLevel
        [DbcRecordPosition(33)]
        public uint32 spellLevel;                               // 33       m_spellLevel
        [DbcRecordPosition(34)]
        public uint32 DurationIndex;                            // 34       m_durationIndex
        [DbcRecordPosition(35)]
        public uint32 powerType;                                // 35       m_powerType
        [DbcRecordPosition(36)]
        public uint32 manaCost;                                 // 36       m_manaCost
        [DbcRecordPosition(37)]
        public uint32 manaCostPerlevel;                         // 37       m_manaCostPerLevel
        [DbcRecordPosition(38)]
        public uint32 manaPerSecond;                            // 38       m_manaPerSecond
        [DbcRecordPosition(39)]
        public uint32 manaPerSecondPerLevel;                    // 39       m_manaPerSecondPerLevel
        [DbcRecordPosition(40)]
        public uint32 rangeIndex;                               // 40       m_rangeIndex
        [DbcRecordPosition(41)]
        public float speed;                                    // 41       m_speed
        [DbcRecordPosition(42)]
        public uint32 modalNextSpell;                        // 42       m_modalNextSpell not used
        [DbcRecordPosition(43)]
        public uint32 StackAmount;                              // 43       m_cumulativeAura
        [DbcRecordPosition(44)]
        public uint32 Totem1;                  // 44-45    m_totem
        [DbcRecordPosition(45)]
        public uint32 Totem2;                  // 44-45    m_totem
        //int32 Reagent[8];              // 46-53    m_reagent
        //uint32 ReagentCount[8];         // 54-61    m_reagentCount
        [DbcRecordPosition(62)]
        public int32 EquippedItemClass;                        // 62       m_equippedItemClass (value)
        [DbcRecordPosition(63)]
        public int32 EquippedItemSubClassMask;                 // 63       m_equippedItemSubclass (mask)
        [DbcRecordPosition(64)]
        public int32 EquippedItemInventoryTypeMask;            // 64       m_equippedItemInvTypes (mask)
        [DbcRecordPosition(65)]
        public uint32 Effect1;                 // 65-67    m_effect
        [DbcRecordPosition(66)]
        public uint32 Effect2;                 // 65-67    m_effect
        [DbcRecordPosition(67)]
        public uint32 Effect3;                 // 65-67    m_effect
        //int32 EffectDieSides[MAX_EFFECT_INDEX];         // 68-70    m_effectDieSides
        //uint32 EffectBaseDice[MAX_EFFECT_INDEX];         // 71-73
        //float EffectDicePerLevel[MAX_EFFECT_INDEX];     // 74-76
        //float EffectRealPointsPerLevel[MAX_EFFECT_INDEX];   // 77-79    m_effectRealPointsPerLevel
        //int32 EffectBasePoints[MAX_EFFECT_INDEX];       // 80-82    m_effectBasePoints (don't must be used in spell/auras explicitly, must be used cached Spell::m_currentBasePoints)
        //uint32 EffectMechanic[MAX_EFFECT_INDEX];         // 83-85    m_effectMechanic
        //uint32 EffectImplicitTargetA[MAX_EFFECT_INDEX];  // 86-88    m_implicitTargetA
        //uint32 EffectImplicitTargetB[MAX_EFFECT_INDEX];  // 89-91    m_implicitTargetB
        //uint32 EffectRadiusIndex[MAX_EFFECT_INDEX];      // 92-94    m_effectRadiusIndex - spellradius.dbc
        //uint32 EffectApplyAuraName[MAX_EFFECT_INDEX];    // 95-97    m_effectAura
        //uint32 EffectAmplitude[MAX_EFFECT_INDEX];        // 98-100   m_effectAuraPeriod
        //float EffectMultipleValue[MAX_EFFECT_INDEX];    // 101-103  m_effectAmplitude
        //uint32 EffectChainTarget[MAX_EFFECT_INDEX];      // 104-106  m_effectChainTargets
        //uint32 EffectItemType[MAX_EFFECT_INDEX];         // 107-109  m_effectItemType
        //int32 EffectMiscValue[MAX_EFFECT_INDEX];        // 110-112  m_effectMiscValue
        //int32 EffectMiscValueB[MAX_EFFECT_INDEX];       // 113-115  m_effectMiscValueB
        //uint32 EffectTriggerSpell[MAX_EFFECT_INDEX];     // 116-118  m_effectTriggerSpell
        //float EffectPointsPerComboPoint[MAX_EFFECT_INDEX];  // 119-121  m_effectPointsPerCombo
        [DbcRecordPosition(122)]
        public uint32 SpellVisual;                              // 122      m_spellVisualID
        // uint32    SpellVisual2;                          // 123 not used
        [DbcRecordPosition(124)]
        public uint32 SpellIconID;                              // 124      m_spellIconID
        [DbcRecordPosition(125)]
        public uint32 activeIconID;                             // 125      m_activeIconID
        [DbcRecordPosition(126)]
        public uint32 spellPriority;                            // 126      m_spellPriority not used
        [DbcRecordPosition(127)]
        public DbcStringReference SpellName;                            // 127-142  m_name_lang
        // uint32    SpellNameFlag;                         // 143      m_name_flag not used
        [DbcRecordPosition(144)]
        public DbcStringReference Rank;                                 // 144-159  m_nameSubtext_lang
        // uint32    RankFlags;                             // 160      m_nameSubtext_flag not used
        // char*     Description[16];                       // 161-176  m_description_lang not used
        // uint32    DescriptionFlags;                      // 177      m_description_flag not used
        // char*     ToolTip[16];                           // 178-193  m_auraDescription_lang not used
        // uint32    ToolTipFlags;                          // 194      m_auraDescription_flag not used
        [DbcRecordPosition(195)]
        public uint32 ManaCostPercentage;                       // 195      m_manaCostPct
        [DbcRecordPosition(196)]
        public uint32 StartRecoveryCategory;                    // 196      m_startRecoveryCategory
        [DbcRecordPosition(197)]
        public uint32 StartRecoveryTime;                        // 197      m_startRecoveryTime
        [DbcRecordPosition(198)]
        public uint32 MaxTargetLevel;                           // 198      m_maxTargetLevel
        [DbcRecordPosition(199)]
        public uint32 SpellFamilyName;                          // 199      m_spellClassSet
        //ClassFamilyMask SpellFamilyFlags;                   // 200-201  m_spellClassMask
        [DbcRecordPosition(202)]
        public uint32 MaxAffectedTargets;                       // 202      m_maxTargets
        [DbcRecordPosition(203)]
        public uint32 DmgClass;                                 // 203      m_defenseType
        [DbcRecordPosition(204)]
        public uint32 PreventionType;                           // 204      m_preventionType
        // uint32    StanceBarOrder;                        // 205      m_stanceBarOrder not used
        //float DmgMultiplier[MAX_EFFECT_INDEX];          // 206-208  m_effectChainAmplitude
        // uint32    MinFactionId;                          // 209      m_minFactionID not used
        // uint32    MinReputation;                         // 210      m_minReputation not used
        // uint32    RequiredAuraVision;                    // 211      m_requiredAuraVision not used
        //uint32 TotemCategory[MAX_SPELL_TOTEM_CATEGORIES];// 212-213  m_requiredTotemCategoryID
        [DbcRecordPosition(214)]
        public uint32 AreaId;                                   // 214
        [DbcRecordPosition(215)]
        public uint32 SchoolMask;                               // 215      m_schoolMask
    }
}
