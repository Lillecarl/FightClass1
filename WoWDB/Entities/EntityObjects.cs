using System;
using Dapper;
using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace WoWDB.Entities
{
    [Table ("areatrigger_involvedrelation")]
    public partial class areatrigger_involvedrelation
    {
        [Key]
        public long id { get; set; }

        public long quest { get; set; }

    }
    [Table("areatrigger_tavern")]
    public partial class areatrigger_tavern
    {
        [Key]
        public long id { get; set; }

        public string name { get; set; }

    }
    [Table("areatrigger_teleport")]
    public partial class areatrigger_teleport
    {
        [Key]
        public long id { get; set; }

        public string name { get; set; }

        public long required_level { get; set; }

        public long required_item { get; set; }

        public long required_item2 { get; set; }

        public long heroic_key { get; set; }

        public long heroic_key2 { get; set; }

        public long required_quest_done { get; set; }

        public long required_quest_done_heroic { get; set; }

        public long target_map { get; set; }

        public double target_position_x { get; set; }

        public double target_position_y { get; set; }

        public double target_position_z { get; set; }

        public double target_orientation { get; set; }

        public long condition_id { get; set; }

        public long status { get; set; }

        public string status_failed_text { get; set; }

    }
    [Table("battleground_events")]
    public partial class battleground_events
    {
        [Key]
        public long map { get; set; }
        [Key]
        public long event1 { get; set; }
        [Key]
        public long event2 { get; set; }

        public string description { get; set; }

    }
    [Table("battleground_template")]
    public partial class battleground_template
    {
        [Key]
        public long id { get; set; }

        public long MinPlayersPerTeam { get; set; }

        public long MaxPlayersPerTeam { get; set; }

        public long MinLvl { get; set; }

        public long MaxLvl { get; set; }

        public long AllianceStartLoc { get; set; }

        public double AllianceStartO { get; set; }

        public long HordeStartLoc { get; set; }

        public double HordeStartO { get; set; }

        public double StartMaxDist { get; set; }

    }
    [Table("battlemaster_entry")]
    public partial class battlemaster_entry
    {
        [Key]
        public long entry { get; set; }

        public long bg_template { get; set; }

    }
    [Table("command")]
    public partial class command
    {
        [Key]
        public string name { get; set; }

        public long security { get; set; }

        public string help { get; set; }

    }
    [Table("conditions")]
    public partial class conditions
    {
        [Key]
        public long condition_entry { get; set; }

        public long type { get; set; }

        public long value1 { get; set; }

        public long value2 { get; set; }

    }
    [Table("sqlite_sequence")]
    public partial class sqlite_sequence
    {
        public string name { get; set; }

        public long? seq { get; set; }

    }
    [Table("creature")]
    public partial class creature
    {
        [Key]
        public long guid { get; set; }

        public long id { get; set; }

        public long map { get; set; }

        public long spawnMask { get; set; }

        public long modelid { get; set; }

        public long equipment_id { get; set; }

        public double position_x { get; set; }

        public double position_y { get; set; }

        public double position_z { get; set; }

        public double orientation { get; set; }

        public long spawntimesecsmin { get; set; }

        public long spawntimesecsmax { get; set; }

        public double spawndist { get; set; }

        public long currentwaypoint { get; set; }

        public long curhealth { get; set; }

        public long curmana { get; set; }

        public long DeathState { get; set; }

        public long MovementType { get; set; }

    }
    [Table("creature_addon")]
    public partial class creature_addon
    {
        [Key]
        public long guid { get; set; }

        public long mount { get; set; }

        public long bytes1 { get; set; }

        public long b2_0_sheath { get; set; }

        public long b2_1_flags { get; set; }

        public long emote { get; set; }

        public long moveflags { get; set; }

        public string auras { get; set; }

    }
    [Table("creature_ai_scripts")]
    public partial class creature_ai_scripts
    {
        [Key]
        public long id { get; set; }

        public long creature_id { get; set; }

        public long event_type { get; set; }

        public long event_inverse_phase_mask { get; set; }

        public long event_chance { get; set; }

        public long event_flags { get; set; }

        public long event_param1 { get; set; }

        public long event_param2 { get; set; }

        public long event_param3 { get; set; }

        public long event_param4 { get; set; }

        public long action1_type { get; set; }

        public long action1_param1 { get; set; }

        public long action1_param2 { get; set; }

        public long action1_param3 { get; set; }

        public long action2_type { get; set; }

        public long action2_param1 { get; set; }

        public long action2_param2 { get; set; }

        public long action2_param3 { get; set; }

        public long action3_type { get; set; }

        public long action3_param1 { get; set; }

        public long action3_param2 { get; set; }

        public long action3_param3 { get; set; }

        public string comment { get; set; }

    }
    [Table("creature_ai_summons")]
    public partial class creature_ai_summons
    {
        [Key]
        public long id { get; set; }

        public double position_x { get; set; }

        public double position_y { get; set; }

        public double position_z { get; set; }

        public double orientation { get; set; }

        public long spawntimesecs { get; set; }

        public string comment { get; set; }

    }
    [Table("creature_ai_texts")]
    public partial class creature_ai_texts
    {
        [Key]
        public long entry { get; set; }

        public string content_default { get; set; }

        public string content_loc1 { get; set; }

        public string content_loc2 { get; set; }

        public string content_loc3 { get; set; }

        public string content_loc4 { get; set; }

        public string content_loc5 { get; set; }

        public string content_loc6 { get; set; }

        public string content_loc7 { get; set; }

        public string content_loc8 { get; set; }

        public long sound { get; set; }

        public long type { get; set; }

        public long language { get; set; }

        public long emote { get; set; }

        public string comment { get; set; }

    }
    [Table("creature_battleground")]
    public partial class creature_battleground
    {
        [Key]
        public long guid { get; set; }

        public long event1 { get; set; }

        public long event2 { get; set; }

    }
    [Table("creature_equip_template")]
    public partial class creature_equip_template
    {
        [Key]
        public long entry { get; set; }

        public long equipentry1 { get; set; }

        public long equipentry2 { get; set; }

        public long equipentry3 { get; set; }

    }
    [Table("creature_equip_template_raw")]
    public partial class creature_equip_template_raw
    {
        [Key]
        public long entry { get; set; }

        public long equipmodel1 { get; set; }

        public long equipmodel2 { get; set; }

        public long equipmodel3 { get; set; }

        public long equipinfo1 { get; set; }

        public long equipinfo2 { get; set; }

        public long equipinfo3 { get; set; }

        public long equipslot1 { get; set; }

        public long equipslot2 { get; set; }

        public long equipslot3 { get; set; }

    }
    [Table("creature_involvedrelation")]
    public partial class creature_involvedrelation
    {
        [Key]
        public long id { get; set; }

        public long quest { get; set; }

    }
    [Table("creature_linking")]
    public partial class creature_linking
    {
        public long guid { get; set; }

        public long master_guid { get; set; }

        public long flag { get; set; }

    }
    [Table("creature_linking_template")]
    public partial class creature_linking_template
    {
        [Key]
        public long entry { get; set; }
        [Key]
        public long map { get; set; }

        public long master_entry { get; set; }

        public long flag { get; set; }

        public long search_range { get; set; }

    }
    [Table("creature_loot_template")]
    public partial class creature_loot_template
    {
        [Key]
        public long entry { get; set; }

        public long item { get; set; }

        public double ChanceOrQuestChance { get; set; }

        public long groupid { get; set; }

        public long mincountOrRef { get; set; }

        public long maxcount { get; set; }

        public long condition_id { get; set; }

        public string comments { get; set; }

    }
    [Table("creature_model_info")]
    public partial class creature_model_info
    {
        [Key]
        public long modelid { get; set; }

        public double bounding_radius { get; set; }

        public double combat_reach { get; set; }

        public long gender { get; set; }

        public long modelid_other_gender { get; set; }

        public long modelid_alternative { get; set; }

    }
    [Table("creature_model_race")]
    public partial class creature_model_race
    {
        [Key]
        public long modelid { get; set; }

        public long racemask { get; set; }

        public long creature_entry { get; set; }

        public long modelid_racial { get; set; }

    }
    [Table("creature_movement")]
    public partial class creature_movement
    {
        [Key]
        public long id { get; set; }
        [Key]
        public long point { get; set; }

        public double position_x { get; set; }

        public double position_y { get; set; }

        public double position_z { get; set; }

        public long waittime { get; set; }

        public long script_id { get; set; }

        public long textid1 { get; set; }

        public long textid2 { get; set; }

        public long textid3 { get; set; }

        public long textid4 { get; set; }

        public long textid5 { get; set; }

        public long emote { get; set; }

        public long spell { get; set; }

        public double orientation { get; set; }

        public long model1 { get; set; }

        public long model2 { get; set; }

    }
    [Table("creature_movement_template")]
    public partial class creature_movement_template
    {
        [Key]
        public long entry { get; set; }
        [Key]
        public long pathId { get; set; }
        [Key]
        public long point { get; set; }

        public double position_x { get; set; }

        public double position_y { get; set; }

        public double position_z { get; set; }

        public long waittime { get; set; }

        public long script_id { get; set; }

        public long textid1 { get; set; }

        public long textid2 { get; set; }

        public long textid3 { get; set; }

        public long textid4 { get; set; }

        public long textid5 { get; set; }

        public long emote { get; set; }

        public long spell { get; set; }

        public double orientation { get; set; }

        public long model1 { get; set; }

        public long model2 { get; set; }

    }
    [Table("creature_onkill_reputation")]
    public partial class creature_onkill_reputation
    {
        [Key]
        public long creature_id { get; set; }

        public long RewOnKillRepFaction1 { get; set; }

        public long RewOnKillRepFaction2 { get; set; }

        public long MaxStanding1 { get; set; }

        public long IsTeamAward1 { get; set; }

        public long RewOnKillRepValue1 { get; set; }

        public long MaxStanding2 { get; set; }

        public long IsTeamAward2 { get; set; }

        public long RewOnKillRepValue2 { get; set; }

        public long TeamDependent { get; set; }

    }
    [Table("creature_questrelation")]
    public partial class creature_questrelation
    {
        [Key]
        public long id { get; set; }

        public long quest { get; set; }

    }
    [Table("creature_template")]
    public partial class creature_template
    {
        [Key]
        public long Entry { get; set; }

        public string Name { get; set; }

        public string SubName { get; set; }

        public string IconName { get; set; }

        public long MinLevel { get; set; }

        public long MaxLevel { get; set; }

        public long HeroicEntry { get; set; }

        public long ModelId1 { get; set; }

        public long ModelId2 { get; set; }

        public long ModelId3 { get; set; }

        public long ModelId4 { get; set; }

        public long FactionAlliance { get; set; }

        public long FactionHorde { get; set; }

        public double Scale { get; set; }

        public long Family { get; set; }

        public long CreatureType { get; set; }

        public long InhabitType { get; set; }

        public long RegenerateStats { get; set; }

        public long RacialLeader { get; set; }

        public long NpcFlags { get; set; }

        public long UnitFlags { get; set; }

        public long DynamicFlags { get; set; }

        public long ExtraFlags { get; set; }

        public long CreatureTypeFlags { get; set; }

        public double SpeedWalk { get; set; }

        public double SpeedRun { get; set; }

        public long UnitClass { get; set; }

        public long Rank { get; set; }

        public long Expansion { get; set; }

        public double HealthMultiplier { get; set; }

        public double PowerMultiplier { get; set; }

        public double DamageMultiplier { get; set; }

        public double DamageVariance { get; set; }

        public double ArmorMultiplier { get; set; }

        public double ExperienceMultiplier { get; set; }

        public long MinLevelHealth { get; set; }

        public long MaxLevelHealth { get; set; }

        public long MinLevelMana { get; set; }

        public long MaxLevelMana { get; set; }

        public double MinMeleeDmg { get; set; }

        public double MaxMeleeDmg { get; set; }

        public double MinRangedDmg { get; set; }

        public double MaxRangedDmg { get; set; }

        public long Armor { get; set; }

        public long MeleeAttackPower { get; set; }

        public long RangedAttackPower { get; set; }

        public long MeleeBaseAttackTime { get; set; }

        public long RangedBaseAttackTime { get; set; }

        public long DamageSchool { get; set; }

        public long MinLootGold { get; set; }

        public long MaxLootGold { get; set; }

        public long LootId { get; set; }

        public long PickpocketLootId { get; set; }

        public long SkinningLootId { get; set; }

        public long KillCredit1 { get; set; }

        public long KillCredit2 { get; set; }

        public long MechanicImmuneMask { get; set; }

        public long SchoolImmuneMask { get; set; }

        public long ResistanceHoly { get; set; }

        public long ResistanceFire { get; set; }

        public long ResistanceNature { get; set; }

        public long ResistanceFrost { get; set; }

        public long ResistanceShadow { get; set; }

        public long ResistanceArcane { get; set; }

        public long PetSpellDataId { get; set; }

        public long MovementType { get; set; }

        public long TrainerType { get; set; }

        public long TrainerSpell { get; set; }

        public long TrainerClass { get; set; }

        public long TrainerRace { get; set; }

        public long TrainerTemplateId { get; set; }

        public long VendorTemplateId { get; set; }

        public long EquipmentTemplateId { get; set; }

        public long GossipMenuId { get; set; }

        public string AIName { get; set; }

        public string ScriptName { get; set; }

    }
    [Table("creature_template_addon")]
    public partial class creature_template_addon
    {
        [Key]
        public long entry { get; set; }

        public long mount { get; set; }

        public long bytes1 { get; set; }

        public long b2_0_sheath { get; set; }

        public long b2_1_flags { get; set; }

        public long emote { get; set; }

        public long moveflags { get; set; }

        public string auras { get; set; }

    }
    [Table("creature_template_classlevelstats")]
    public partial class creature_template_classlevelstats
    {
        [Key]
        public long Level { get; set; }
        [Key]
        public long Class { get; set; }

        public long BaseHealthExp0 { get; set; }

        public long BaseHealthExp1 { get; set; }

        public long BaseMana { get; set; }

        public double BaseDamageExp0 { get; set; }

        public double BaseDamageExp1 { get; set; }

        public double BaseMeleeAttackPower { get; set; }

        public double BaseRangedAttackPower { get; set; }

        public long BaseArmor { get; set; }

    }
    [Table("creature_template_spells")]
    public partial class creature_template_spells
    {
        [Key]
        public long entry { get; set; }

        public long spell1 { get; set; }

        public long spell2 { get; set; }

        public long spell3 { get; set; }

        public long spell4 { get; set; }

    }
    [Table("custom_texts")]
    public partial class custom_texts
    {
        [Key]
        public long entry { get; set; }

        public string content_default { get; set; }

        public string content_loc1 { get; set; }

        public string content_loc2 { get; set; }

        public string content_loc3 { get; set; }

        public string content_loc4 { get; set; }

        public string content_loc5 { get; set; }

        public string content_loc6 { get; set; }

        public string content_loc7 { get; set; }

        public string content_loc8 { get; set; }

        public long sound { get; set; }

        public long type { get; set; }

        public long language { get; set; }

        public long emote { get; set; }

        public string comment { get; set; }

    }
    [Table("db_script_string")]
    public partial class db_script_string
    {
        [Key]
        public long entry { get; set; }

        public string content_default { get; set; }

        public string content_loc1 { get; set; }

        public string content_loc2 { get; set; }

        public string content_loc3 { get; set; }

        public string content_loc4 { get; set; }

        public string content_loc5 { get; set; }

        public string content_loc6 { get; set; }

        public string content_loc7 { get; set; }

        public string content_loc8 { get; set; }

        public long sound { get; set; }

        public long type { get; set; }

        public long language { get; set; }

        public long emote { get; set; }

        public string comment { get; set; }

    }
    [Table("db_version")]
    public partial class db_version
    {
        public string version { get; set; }

        public string creature_ai_version { get; set; }

        public Boolean? required_s2353_01_mangos_spell_affect { get; set; }

    }
    [Table("dbscript_string_template")]
    public partial class dbscript_string_template
    {
        [Key]
        public long id { get; set; }

        public long string_id { get; set; }

    }
    [Table("dbscripts_on_creature_death")]
    public partial class dbscripts_on_creature_death
    {
        [Key]
        public long id { get; set; }

        public long delay { get; set; }

        public long command { get; set; }

        public long datalong { get; set; }

        public long datalong2 { get; set; }

        public long datalong3 { get; set; }

        public long buddy_entry { get; set; }

        public long search_radius { get; set; }

        public long data_flags { get; set; }

        public long dataint { get; set; }

        public long dataint2 { get; set; }

        public long dataint3 { get; set; }

        public long dataint4 { get; set; }

        public double x { get; set; }

        public double y { get; set; }

        public double z { get; set; }

        public double o { get; set; }

        public string comments { get; set; }

    }
    [Table("dbscripts_on_creature_movement")]
    public partial class dbscripts_on_creature_movement
    {
        [Key]
        public long id { get; set; }

        public long delay { get; set; }

        public long command { get; set; }

        public long datalong { get; set; }

        public long datalong2 { get; set; }

        public long datalong3 { get; set; }

        public long buddy_entry { get; set; }

        public long search_radius { get; set; }

        public long data_flags { get; set; }

        public long dataint { get; set; }

        public long dataint2 { get; set; }

        public long dataint3 { get; set; }

        public long dataint4 { get; set; }

        public double x { get; set; }

        public double y { get; set; }

        public double z { get; set; }

        public double o { get; set; }

        public string comments { get; set; }

    }
    [Table("dbscripts_on_event")]
    public partial class dbscripts_on_event
    {
        [Key]
        public long id { get; set; }

        public long delay { get; set; }

        public long command { get; set; }

        public long datalong { get; set; }

        public long datalong2 { get; set; }

        public long datalong3 { get; set; }

        public long buddy_entry { get; set; }

        public long search_radius { get; set; }

        public long data_flags { get; set; }

        public long dataint { get; set; }

        public long dataint2 { get; set; }

        public long dataint3 { get; set; }

        public long dataint4 { get; set; }

        public double x { get; set; }

        public double y { get; set; }

        public double z { get; set; }

        public double o { get; set; }

        public string comments { get; set; }

    }
    [Table("dbscripts_on_go_template_use")]
    public partial class dbscripts_on_go_template_use
    {
        [Key]
        public long id { get; set; }

        public long delay { get; set; }

        public long command { get; set; }

        public long datalong { get; set; }

        public long datalong2 { get; set; }

        public long datalong3 { get; set; }

        public long buddy_entry { get; set; }

        public long search_radius { get; set; }

        public long data_flags { get; set; }

        public long dataint { get; set; }

        public long dataint2 { get; set; }

        public long dataint3 { get; set; }

        public long dataint4 { get; set; }

        public double x { get; set; }

        public double y { get; set; }

        public double z { get; set; }

        public double o { get; set; }

        public string comments { get; set; }

    }
    [Table("dbscripts_on_go_use")]
    public partial class dbscripts_on_go_use
    {
        [Key]
        public long id { get; set; }

        public long delay { get; set; }

        public long command { get; set; }

        public long datalong { get; set; }

        public long datalong2 { get; set; }

        public long datalong3 { get; set; }

        public long buddy_entry { get; set; }

        public long search_radius { get; set; }

        public long data_flags { get; set; }

        public long dataint { get; set; }

        public long dataint2 { get; set; }

        public long dataint3 { get; set; }

        public long dataint4 { get; set; }

        public double x { get; set; }

        public double y { get; set; }

        public double z { get; set; }

        public double o { get; set; }

        public string comments { get; set; }

    }
    [Table("dbscripts_on_gossip")]
    public partial class dbscripts_on_gossip
    {
        [Key]
        public long id { get; set; }

        public long delay { get; set; }

        public long command { get; set; }

        public long datalong { get; set; }

        public long datalong2 { get; set; }

        public long datalong3 { get; set; }

        public long buddy_entry { get; set; }

        public long search_radius { get; set; }

        public long data_flags { get; set; }

        public long dataint { get; set; }

        public long dataint2 { get; set; }

        public long dataint3 { get; set; }

        public long dataint4 { get; set; }

        public double x { get; set; }

        public double y { get; set; }

        public double z { get; set; }

        public double o { get; set; }

        public string comments { get; set; }

    }
    [Table("dbscripts_on_quest_end")]
    public partial class dbscripts_on_quest_end
    {
        [Key]
        public long id { get; set; }

        public long delay { get; set; }

        public long command { get; set; }

        public long datalong { get; set; }

        public long datalong2 { get; set; }

        public long datalong3 { get; set; }

        public long buddy_entry { get; set; }

        public long search_radius { get; set; }

        public long data_flags { get; set; }

        public long dataint { get; set; }

        public long dataint2 { get; set; }

        public long dataint3 { get; set; }

        public long dataint4 { get; set; }

        public double x { get; set; }

        public double y { get; set; }

        public double z { get; set; }

        public double o { get; set; }

        public string comments { get; set; }

    }
    [Table("dbscripts_on_quest_start")]
    public partial class dbscripts_on_quest_start
    {
        [Key]
        public long id { get; set; }

        public long delay { get; set; }

        public long command { get; set; }

        public long datalong { get; set; }

        public long datalong2 { get; set; }

        public long datalong3 { get; set; }

        public long buddy_entry { get; set; }

        public long search_radius { get; set; }

        public long data_flags { get; set; }

        public long dataint { get; set; }

        public long dataint2 { get; set; }

        public long dataint3 { get; set; }

        public long dataint4 { get; set; }

        public double x { get; set; }

        public double y { get; set; }

        public double z { get; set; }

        public double o { get; set; }

        public string comments { get; set; }

    }
    [Table("dbscripts_on_spell")]
    public partial class dbscripts_on_spell
    {
        [Key]
        public long id { get; set; }

        public long delay { get; set; }

        public long command { get; set; }

        public long datalong { get; set; }

        public long datalong2 { get; set; }

        public long datalong3 { get; set; }

        public long buddy_entry { get; set; }

        public long search_radius { get; set; }

        public long data_flags { get; set; }

        public long dataint { get; set; }

        public long dataint2 { get; set; }

        public long dataint3 { get; set; }

        public long dataint4 { get; set; }

        public double x { get; set; }

        public double y { get; set; }

        public double z { get; set; }

        public double o { get; set; }

        public string comments { get; set; }

    }
    [Table("disenchant_loot_template")]
    public partial class disenchant_loot_template
    {
        [Key]
        public long entry { get; set; }

        public long item { get; set; }

        public double ChanceOrQuestChance { get; set; }

        public long groupid { get; set; }

        public long mincountOrRef { get; set; }

        public long maxcount { get; set; }

        public long condition_id { get; set; }

        public string comments { get; set; }

    }
    [Table("exploration_basexp")]
    public partial class exploration_basexp
    {
        [Key]
        public long level { get; set; }

        public long basexp { get; set; }

    }
    [Table("fishing_loot_template")]
    public partial class fishing_loot_template
    {
        [Key]
        public long entry { get; set; }

        public long item { get; set; }

        public double ChanceOrQuestChance { get; set; }

        public long groupid { get; set; }

        public long mincountOrRef { get; set; }

        public long maxcount { get; set; }

        public long condition_id { get; set; }

        public string comments { get; set; }

    }
    [Table("game_event")]
    public partial class game_event
    {
        [Key]
        public long entry { get; set; }

        public DateTime start_time { get; set; }

        public DateTime end_time { get; set; }

        public long occurence { get; set; }

        public long length { get; set; }

        public long holiday { get; set; }

        public long linkedTo { get; set; }

        public string description { get; set; }

    }
    [Table("game_event_creature")]
    public partial class game_event_creature
    {
        [Key]
        public long guid { get; set; }

        public long event_ { get; set; }

    }
    [Table("game_event_creature_data")]
    public partial class game_event_creature_data
    {
        [Key]
        public long guid { get; set; }

        public long entry_id { get; set; }

        public long modelid { get; set; }

        public long equipment_id { get; set; }

        public long vendor_id { get; set; }

        public long spell_start { get; set; }

        public long spell_end { get; set; }

        public long event_ { get; set; }

    }
    [Table("game_event_gameobject")]
    public partial class game_event_gameobject
    {
        [Key]
        public long guid { get; set; }

        public long event_ { get; set; }

    }
    [Table("game_event_mail")]
    public partial class game_event_mail
    {
        [Key]
        public long event_ { get; set; }

        public long raceMask { get; set; }

        public long quest { get; set; }

        public long mailTemplateId { get; set; }

        public long senderEntry { get; set; }

    }
    [Table("game_event_quest")]
    public partial class game_event_quest
    {
        [Key]
        public long quest { get; set; }

        public long event_ { get; set; }

    }
    [Table("game_graveyard_zone")]
    public partial class game_graveyard_zone
    {
        [Key]
        public long id { get; set; }

        public long ghost_zone { get; set; }

        public long faction { get; set; }

    }
    [Table("game_tele")]
    public partial class game_tele
    {
        [Key]
        public long id { get; set; }

        public double position_x { get; set; }

        public double position_y { get; set; }

        public double position_z { get; set; }

        public double orientation { get; set; }

        public long map { get; set; }

        public string name { get; set; }

    }
    [Table("game_weather")]
    public partial class game_weather
    {
        [Key]
        public long zone { get; set; }

        public long spring_rain_chance { get; set; }

        public long spring_snow_chance { get; set; }

        public long spring_storm_chance { get; set; }

        public long summer_rain_chance { get; set; }

        public long summer_snow_chance { get; set; }

        public long summer_storm_chance { get; set; }

        public long fall_rain_chance { get; set; }

        public long fall_snow_chance { get; set; }

        public long fall_storm_chance { get; set; }

        public long winter_rain_chance { get; set; }

        public long winter_snow_chance { get; set; }

        public long winter_storm_chance { get; set; }

    }
    [Table("gameobject")]
    public partial class gameobject
    {
        [Key]
        public long guid { get; set; }

        public long id { get; set; }

        public long map { get; set; }

        public long spawnMask { get; set; }

        public double position_x { get; set; }

        public double position_y { get; set; }

        public double position_z { get; set; }

        public double orientation { get; set; }

        public double rotation0 { get; set; }

        public double rotation1 { get; set; }

        public double rotation2 { get; set; }

        public double rotation3 { get; set; }

        public long spawntimesecsmin { get; set; }

        public long spawntimesecsmax { get; set; }

        public long animprogress { get; set; }

        public long state { get; set; }

    }
    [Table("gameobject_battleground")]
    public partial class gameobject_battleground
    {
        [Key]
        public long guid { get; set; }

        public long event1 { get; set; }

        public long event2 { get; set; }

    }
    [Table("gameobject_involvedrelation")]
    public partial class gameobject_involvedrelation
    {
        [Key]
        public long id { get; set; }

        public long quest { get; set; }

    }
    [Table("gameobject_loot_template")]
    public partial class gameobject_loot_template
    {
        [Key]
        public long entry { get; set; }

        public long item { get; set; }

        public double ChanceOrQuestChance { get; set; }

        public long groupid { get; set; }

        public long mincountOrRef { get; set; }

        public long maxcount { get; set; }

        public long condition_id { get; set; }

        public string comments { get; set; }

    }
    [Table("gameobject_questrelation")]
    public partial class gameobject_questrelation
    {
        [Key]
        public long id { get; set; }

        public long quest { get; set; }

    }
    [Table("gameobject_template")]
    public partial class gameobject_template
    {
        [Key]
        public long entry { get; set; }

        public long type { get; set; }

        public long displayId { get; set; }

        public string name { get; set; }

        public string IconName { get; set; }

        public string castBarCaption { get; set; }

        public long faction { get; set; }

        public long flags { get; set; }

        public long ExtraFlags { get; set; }

        public double size { get; set; }

        public long data0 { get; set; }

        public long data1 { get; set; }

        public long data2 { get; set; }

        public long data3 { get; set; }

        public long data4 { get; set; }

        public long data5 { get; set; }

        public long data6 { get; set; }

        public long data7 { get; set; }

        public long data8 { get; set; }

        public long data9 { get; set; }

        public long data10 { get; set; }

        public long data11 { get; set; }

        public long data12 { get; set; }

        public long data13 { get; set; }

        public long data14 { get; set; }

        public long data15 { get; set; }

        public long data16 { get; set; }

        public long data17 { get; set; }

        public long data18 { get; set; }

        public long data19 { get; set; }

        public long data20 { get; set; }

        public long data21 { get; set; }

        public long data22 { get; set; }

        public long data23 { get; set; }

        public long CustomData1 { get; set; }

        public long mingold { get; set; }

        public long maxgold { get; set; }

        public string ScriptName { get; set; }

    }
    [Table("gossip_menu")]
    public partial class gossip_menu
    {
        [Key]
        public long entry { get; set; }

        public long text_id { get; set; }

        public long script_id { get; set; }

        public long condition_id { get; set; }

    }
    [Table("gossip_menu_option")]
    public partial class gossip_menu_option
    {
        [Key]
        public long menu_id { get; set; }

        public long id { get; set; }

        public long option_icon { get; set; }

        public string option_text { get; set; }

        public long option_id { get; set; }

        public long npc_option_npcflag { get; set; }

        public long action_menu_id { get; set; }

        public long action_poi_id { get; set; }

        public long action_script_id { get; set; }

        public long box_coded { get; set; }

        public long box_money { get; set; }

        public string box_text { get; set; }

        public long condition_id { get; set; }

    }
    [Table("gossip_texts")]
    public partial class gossip_texts
    {
        [Key]
        public long entry { get; set; }

        public string content_default { get; set; }

        public string content_loc1 { get; set; }

        public string content_loc2 { get; set; }

        public string content_loc3 { get; set; }

        public string content_loc4 { get; set; }

        public string content_loc5 { get; set; }

        public string content_loc6 { get; set; }

        public string content_loc7 { get; set; }

        public string content_loc8 { get; set; }

        public string comment { get; set; }

    }
    [Table("instance_dungeon_encounters")]
    public partial class instance_dungeon_encounters
    {
        [Key]
        public long Id { get; set; }

        public long MapId { get; set; }

        public long Difficulty { get; set; }

        public long EncounterData { get; set; }

        public long EncounterIndex { get; set; }

        public string EncounterName { get; set; }

        public string EncounterName2 { get; set; }

        public string EncounterName3 { get; set; }

        public string EncounterName4 { get; set; }

        public string EncounterName5 { get; set; }

        public string EncounterName6 { get; set; }

        public string EncounterName7 { get; set; }

        public string EncounterName8 { get; set; }

        public string EncounterName9 { get; set; }

        public string EncounterName10 { get; set; }

        public string EncounterName11 { get; set; }

        public string EncounterName12 { get; set; }

        public string EncounterName13 { get; set; }

        public string EncounterName14 { get; set; }

        public string EncounterName15 { get; set; }

        public string EncounterName16 { get; set; }

        public long NameLangFlags { get; set; }

        public long SpellIconID { get; set; }

    }
    [Table("instance_encounters")]
    public partial class instance_encounters
    {
        [Key]
        public long entry { get; set; }

        public long creditType { get; set; }

        public long creditEntry { get; set; }

        public long lastEncounterDungeon { get; set; }

    }
    [Table("instance_template")]
    public partial class instance_template
    {
        [Key]
        public long map { get; set; }

        public long parent { get; set; }

        public long levelMin { get; set; }

        public long levelMax { get; set; }

        public long maxPlayers { get; set; }

        public long reset_delay { get; set; }

        public string ScriptName { get; set; }

        public long mountAllowed { get; set; }

    }
    [Table("item_enchantment_template")]
    public partial class item_enchantment_template
    {
        [Key]
        public long entry { get; set; }

        public long ench { get; set; }

        public double chance { get; set; }

    }
    [Table("item_loot_template")]
    public partial class item_loot_template
    {
        [Key]
        public long entry { get; set; }

        public long item { get; set; }

        public double ChanceOrQuestChance { get; set; }

        public long groupid { get; set; }

        public long mincountOrRef { get; set; }

        public long maxcount { get; set; }

        public long condition_id { get; set; }

        public string comments { get; set; }

    }
    [Table("item_required_target")]
    public partial class item_required_target
    {
        [Key]
        public long entry { get; set; }

        public long type { get; set; }

        public long targetEntry { get; set; }

    }
    [Table("item_template")]
    public partial class item_template
    {
        [Key]
        public long entry { get; set; }

        public long class_ { get; set; }

        public long subclass { get; set; }

        public long unk0 { get; set; }

        public string name { get; set; }

        public long displayid { get; set; }

        public long Quality { get; set; }

        public long Flags { get; set; }

        public long BuyCount { get; set; }

        public long BuyPrice { get; set; }

        public long SellPrice { get; set; }

        public long InventoryType { get; set; }

        public long AllowableClass { get; set; }

        public long AllowableRace { get; set; }

        public long ItemLevel { get; set; }

        public long RequiredLevel { get; set; }

        public long RequiredSkill { get; set; }

        public long RequiredSkillRank { get; set; }

        public long requiredspell { get; set; }

        public long requiredhonorrank { get; set; }

        public long RequiredCityRank { get; set; }

        public long RequiredReputationFaction { get; set; }

        public long RequiredReputationRank { get; set; }

        public long maxcount { get; set; }

        public long stackable { get; set; }

        public long ContainerSlots { get; set; }

        public long stat_type1 { get; set; }

        public long stat_value1 { get; set; }

        public long stat_type2 { get; set; }

        public long stat_value2 { get; set; }

        public long stat_type3 { get; set; }

        public long stat_value3 { get; set; }

        public long stat_type4 { get; set; }

        public long stat_value4 { get; set; }

        public long stat_type5 { get; set; }

        public long stat_value5 { get; set; }

        public long stat_type6 { get; set; }

        public long stat_value6 { get; set; }

        public long stat_type7 { get; set; }

        public long stat_value7 { get; set; }

        public long stat_type8 { get; set; }

        public long stat_value8 { get; set; }

        public long stat_type9 { get; set; }

        public long stat_value9 { get; set; }

        public long stat_type10 { get; set; }

        public long stat_value10 { get; set; }

        public double dmg_min1 { get; set; }

        public double dmg_max1 { get; set; }

        public long dmg_type1 { get; set; }

        public double dmg_min2 { get; set; }

        public double dmg_max2 { get; set; }

        public long dmg_type2 { get; set; }

        public double dmg_min3 { get; set; }

        public double dmg_max3 { get; set; }

        public long dmg_type3 { get; set; }

        public double dmg_min4 { get; set; }

        public double dmg_max4 { get; set; }

        public long dmg_type4 { get; set; }

        public double dmg_min5 { get; set; }

        public double dmg_max5 { get; set; }

        public long dmg_type5 { get; set; }

        public long armor { get; set; }

        public long holy_res { get; set; }

        public long fire_res { get; set; }

        public long nature_res { get; set; }

        public long frost_res { get; set; }

        public long shadow_res { get; set; }

        public long arcane_res { get; set; }

        public long delay { get; set; }

        public long ammo_type { get; set; }

        public double RangedModRange { get; set; }

        public long spellid_1 { get; set; }

        public long spelltrigger_1 { get; set; }

        public long spellcharges_1 { get; set; }

        public double spellppmRate_1 { get; set; }

        public long spellcooldown_1 { get; set; }

        public long spellcategory_1 { get; set; }

        public long spellcategorycooldown_1 { get; set; }

        public long spellid_2 { get; set; }

        public long spelltrigger_2 { get; set; }

        public long spellcharges_2 { get; set; }

        public double spellppmRate_2 { get; set; }

        public long spellcooldown_2 { get; set; }

        public long spellcategory_2 { get; set; }

        public long spellcategorycooldown_2 { get; set; }

        public long spellid_3 { get; set; }

        public long spelltrigger_3 { get; set; }

        public long spellcharges_3 { get; set; }

        public double spellppmRate_3 { get; set; }

        public long spellcooldown_3 { get; set; }

        public long spellcategory_3 { get; set; }

        public long spellcategorycooldown_3 { get; set; }

        public long spellid_4 { get; set; }

        public long spelltrigger_4 { get; set; }

        public long spellcharges_4 { get; set; }

        public double spellppmRate_4 { get; set; }

        public long spellcooldown_4 { get; set; }

        public long spellcategory_4 { get; set; }

        public long spellcategorycooldown_4 { get; set; }

        public long spellid_5 { get; set; }

        public long spelltrigger_5 { get; set; }

        public long spellcharges_5 { get; set; }

        public double spellppmRate_5 { get; set; }

        public long spellcooldown_5 { get; set; }

        public long spellcategory_5 { get; set; }

        public long spellcategorycooldown_5 { get; set; }

        public long bonding { get; set; }

        public string description { get; set; }

        public long PageText { get; set; }

        public long LanguageID { get; set; }

        public long PageMaterial { get; set; }

        public long startquest { get; set; }

        public long lockid { get; set; }

        public long Material { get; set; }

        public long sheath { get; set; }

        public long RandomProperty { get; set; }

        public long RandomSuffix { get; set; }

        public long block { get; set; }

        public long itemset { get; set; }

        public long MaxDurability { get; set; }

        public long area { get; set; }

        public long Map { get; set; }

        public long BagFamily { get; set; }

        public long TotemCategory { get; set; }

        public long socketColor_1 { get; set; }

        public long socketContent_1 { get; set; }

        public long socketColor_2 { get; set; }

        public long socketContent_2 { get; set; }

        public long socketColor_3 { get; set; }

        public long socketContent_3 { get; set; }

        public long socketBonus { get; set; }

        public long GemProperties { get; set; }

        public long RequiredDisenchantSkill { get; set; }

        public double ArmorDamageModifier { get; set; }

        public string ScriptName { get; set; }

        public long DisenchantID { get; set; }

        public long FoodType { get; set; }

        public long minMoneyLoot { get; set; }

        public long maxMoneyLoot { get; set; }

        public long Duration { get; set; }

        public long ExtraFlags { get; set; }

    }
    [Table("locales_creature")]
    public partial class locales_creature
    {
        [Key]
        public long entry { get; set; }

        public string name_loc1 { get; set; }

        public string name_loc2 { get; set; }

        public string name_loc3 { get; set; }

        public string name_loc4 { get; set; }

        public string name_loc5 { get; set; }

        public string name_loc6 { get; set; }

        public string name_loc7 { get; set; }

        public string name_loc8 { get; set; }

        public string subname_loc1 { get; set; }

        public string subname_loc2 { get; set; }

        public string subname_loc3 { get; set; }

        public string subname_loc4 { get; set; }

        public string subname_loc5 { get; set; }

        public string subname_loc6 { get; set; }

        public string subname_loc7 { get; set; }

        public string subname_loc8 { get; set; }

    }
    [Table("locales_gameobject")]
    public partial class locales_gameobject
    {
        [Key]
        public long entry { get; set; }

        public string name_loc1 { get; set; }

        public string name_loc2 { get; set; }

        public string name_loc3 { get; set; }

        public string name_loc4 { get; set; }

        public string name_loc5 { get; set; }

        public string name_loc6 { get; set; }

        public string name_loc7 { get; set; }

        public string name_loc8 { get; set; }

        public string castbarcaption_loc1 { get; set; }

        public string castbarcaption_loc2 { get; set; }

        public string castbarcaption_loc3 { get; set; }

        public string castbarcaption_loc4 { get; set; }

        public string castbarcaption_loc5 { get; set; }

        public string castbarcaption_loc6 { get; set; }

        public string castbarcaption_loc7 { get; set; }

        public string castbarcaption_loc8 { get; set; }

    }
    [Table("locales_gossip_menu_option")]
    public partial class locales_gossip_menu_option
    {
        [Key]
        public long menu_id { get; set; }

        public long id { get; set; }

        public string option_text_loc1 { get; set; }

        public string option_text_loc2 { get; set; }

        public string option_text_loc3 { get; set; }

        public string option_text_loc4 { get; set; }

        public string option_text_loc5 { get; set; }

        public string option_text_loc6 { get; set; }

        public string option_text_loc7 { get; set; }

        public string option_text_loc8 { get; set; }

        public string box_text_loc1 { get; set; }

        public string box_text_loc2 { get; set; }

        public string box_text_loc3 { get; set; }

        public string box_text_loc4 { get; set; }

        public string box_text_loc5 { get; set; }

        public string box_text_loc6 { get; set; }

        public string box_text_loc7 { get; set; }

        public string box_text_loc8 { get; set; }

    }
    [Table("locales_item")]
    public partial class locales_item
    {
        [Key]
        public long entry { get; set; }

        public string name_loc1 { get; set; }

        public string name_loc2 { get; set; }

        public string name_loc3 { get; set; }

        public string name_loc4 { get; set; }

        public string name_loc5 { get; set; }

        public string name_loc6 { get; set; }

        public string name_loc7 { get; set; }

        public string name_loc8 { get; set; }

        public string description_loc1 { get; set; }

        public string description_loc2 { get; set; }

        public string description_loc3 { get; set; }

        public string description_loc4 { get; set; }

        public string description_loc5 { get; set; }

        public string description_loc6 { get; set; }

        public string description_loc7 { get; set; }

        public string description_loc8 { get; set; }

    }
    [Table("locales_npc_text")]
    public partial class locales_npc_text
    {
        [Key]
        public long entry { get; set; }

        public string Text0_0_loc1 { get; set; }

        public string Text0_0_loc2 { get; set; }

        public string Text0_0_loc3 { get; set; }

        public string Text0_0_loc4 { get; set; }

        public string Text0_0_loc5 { get; set; }

        public string Text0_0_loc6 { get; set; }

        public string Text0_0_loc7 { get; set; }

        public string Text0_0_loc8 { get; set; }

        public string Text0_1_loc1 { get; set; }

        public string Text0_1_loc2 { get; set; }

        public string Text0_1_loc3 { get; set; }

        public string Text0_1_loc4 { get; set; }

        public string Text0_1_loc5 { get; set; }

        public string Text0_1_loc6 { get; set; }

        public string Text0_1_loc7 { get; set; }

        public string Text0_1_loc8 { get; set; }

        public string Text1_0_loc1 { get; set; }

        public string Text1_0_loc2 { get; set; }

        public string Text1_0_loc3 { get; set; }

        public string Text1_0_loc4 { get; set; }

        public string Text1_0_loc5 { get; set; }

        public string Text1_0_loc6 { get; set; }

        public string Text1_0_loc7 { get; set; }

        public string Text1_0_loc8 { get; set; }

        public string Text1_1_loc1 { get; set; }

        public string Text1_1_loc2 { get; set; }

        public string Text1_1_loc3 { get; set; }

        public string Text1_1_loc4 { get; set; }

        public string Text1_1_loc5 { get; set; }

        public string Text1_1_loc6 { get; set; }

        public string Text1_1_loc7 { get; set; }

        public string Text1_1_loc8 { get; set; }

        public string Text2_0_loc1 { get; set; }

        public string Text2_0_loc2 { get; set; }

        public string Text2_0_loc3 { get; set; }

        public string Text2_0_loc4 { get; set; }

        public string Text2_0_loc5 { get; set; }

        public string Text2_0_loc6 { get; set; }

        public string Text2_0_loc7 { get; set; }

        public string Text2_0_loc8 { get; set; }

        public string Text2_1_loc1 { get; set; }

        public string Text2_1_loc2 { get; set; }

        public string Text2_1_loc3 { get; set; }

        public string Text2_1_loc4 { get; set; }

        public string Text2_1_loc5 { get; set; }

        public string Text2_1_loc6 { get; set; }

        public string Text2_1_loc7 { get; set; }

        public string Text2_1_loc8 { get; set; }

        public string Text3_0_loc1 { get; set; }

        public string Text3_0_loc2 { get; set; }

        public string Text3_0_loc3 { get; set; }

        public string Text3_0_loc4 { get; set; }

        public string Text3_0_loc5 { get; set; }

        public string Text3_0_loc6 { get; set; }

        public string Text3_0_loc7 { get; set; }

        public string Text3_0_loc8 { get; set; }

        public string Text3_1_loc1 { get; set; }

        public string Text3_1_loc2 { get; set; }

        public string Text3_1_loc3 { get; set; }

        public string Text3_1_loc4 { get; set; }

        public string Text3_1_loc5 { get; set; }

        public string Text3_1_loc6 { get; set; }

        public string Text3_1_loc7 { get; set; }

        public string Text3_1_loc8 { get; set; }

        public string Text4_0_loc1 { get; set; }

        public string Text4_0_loc2 { get; set; }

        public string Text4_0_loc3 { get; set; }

        public string Text4_0_loc4 { get; set; }

        public string Text4_0_loc5 { get; set; }

        public string Text4_0_loc6 { get; set; }

        public string Text4_0_loc7 { get; set; }

        public string Text4_0_loc8 { get; set; }

        public string Text4_1_loc1 { get; set; }

        public string Text4_1_loc2 { get; set; }

        public string Text4_1_loc3 { get; set; }

        public string Text4_1_loc4 { get; set; }

        public string Text4_1_loc5 { get; set; }

        public string Text4_1_loc6 { get; set; }

        public string Text4_1_loc7 { get; set; }

        public string Text4_1_loc8 { get; set; }

        public string Text5_0_loc1 { get; set; }

        public string Text5_0_loc2 { get; set; }

        public string Text5_0_loc3 { get; set; }

        public string Text5_0_loc4 { get; set; }

        public string Text5_0_loc5 { get; set; }

        public string Text5_0_loc6 { get; set; }

        public string Text5_0_loc7 { get; set; }

        public string Text5_0_loc8 { get; set; }

        public string Text5_1_loc1 { get; set; }

        public string Text5_1_loc2 { get; set; }

        public string Text5_1_loc3 { get; set; }

        public string Text5_1_loc4 { get; set; }

        public string Text5_1_loc5 { get; set; }

        public string Text5_1_loc6 { get; set; }

        public string Text5_1_loc7 { get; set; }

        public string Text5_1_loc8 { get; set; }

        public string Text6_0_loc1 { get; set; }

        public string Text6_0_loc2 { get; set; }

        public string Text6_0_loc3 { get; set; }

        public string Text6_0_loc4 { get; set; }

        public string Text6_0_loc5 { get; set; }

        public string Text6_0_loc6 { get; set; }

        public string Text6_0_loc7 { get; set; }

        public string Text6_0_loc8 { get; set; }

        public string Text6_1_loc1 { get; set; }

        public string Text6_1_loc2 { get; set; }

        public string Text6_1_loc3 { get; set; }

        public string Text6_1_loc4 { get; set; }

        public string Text6_1_loc5 { get; set; }

        public string Text6_1_loc6 { get; set; }

        public string Text6_1_loc7 { get; set; }

        public string Text6_1_loc8 { get; set; }

        public string Text7_0_loc1 { get; set; }

        public string Text7_0_loc2 { get; set; }

        public string Text7_0_loc3 { get; set; }

        public string Text7_0_loc4 { get; set; }

        public string Text7_0_loc5 { get; set; }

        public string Text7_0_loc6 { get; set; }

        public string Text7_0_loc7 { get; set; }

        public string Text7_0_loc8 { get; set; }

        public string Text7_1_loc1 { get; set; }

        public string Text7_1_loc2 { get; set; }

        public string Text7_1_loc3 { get; set; }

        public string Text7_1_loc4 { get; set; }

        public string Text7_1_loc5 { get; set; }

        public string Text7_1_loc6 { get; set; }

        public string Text7_1_loc7 { get; set; }

        public string Text7_1_loc8 { get; set; }

    }
    [Table("locales_page_text")]
    public partial class locales_page_text
    {
        [Key]
        public long entry { get; set; }

        public string Text_loc1 { get; set; }

        public string Text_loc2 { get; set; }

        public string Text_loc3 { get; set; }

        public string Text_loc4 { get; set; }

        public string Text_loc5 { get; set; }

        public string Text_loc6 { get; set; }

        public string Text_loc7 { get; set; }

        public string Text_loc8 { get; set; }

    }
    [Table("locales_points_of_interest")]
    public partial class locales_points_of_interest
    {
        [Key]
        public long entry { get; set; }

        public string icon_name_loc1 { get; set; }

        public string icon_name_loc2 { get; set; }

        public string icon_name_loc3 { get; set; }

        public string icon_name_loc4 { get; set; }

        public string icon_name_loc5 { get; set; }

        public string icon_name_loc6 { get; set; }

        public string icon_name_loc7 { get; set; }

        public string icon_name_loc8 { get; set; }

    }
    [Table("locales_quest")]
    public partial class locales_quest
    {
        [Key]
        public long entry { get; set; }

        public string Title_loc1 { get; set; }

        public string Title_loc2 { get; set; }

        public string Title_loc3 { get; set; }

        public string Title_loc4 { get; set; }

        public string Title_loc5 { get; set; }

        public string Title_loc6 { get; set; }

        public string Title_loc7 { get; set; }

        public string Title_loc8 { get; set; }

        public string Details_loc1 { get; set; }

        public string Details_loc2 { get; set; }

        public string Details_loc3 { get; set; }

        public string Details_loc4 { get; set; }

        public string Details_loc5 { get; set; }

        public string Details_loc6 { get; set; }

        public string Details_loc7 { get; set; }

        public string Details_loc8 { get; set; }

        public string Objectives_loc1 { get; set; }

        public string Objectives_loc2 { get; set; }

        public string Objectives_loc3 { get; set; }

        public string Objectives_loc4 { get; set; }

        public string Objectives_loc5 { get; set; }

        public string Objectives_loc6 { get; set; }

        public string Objectives_loc7 { get; set; }

        public string Objectives_loc8 { get; set; }

        public string OfferRewardText_loc1 { get; set; }

        public string OfferRewardText_loc2 { get; set; }

        public string OfferRewardText_loc3 { get; set; }

        public string OfferRewardText_loc4 { get; set; }

        public string OfferRewardText_loc5 { get; set; }

        public string OfferRewardText_loc6 { get; set; }

        public string OfferRewardText_loc7 { get; set; }

        public string OfferRewardText_loc8 { get; set; }

        public string RequestItemsText_loc1 { get; set; }

        public string RequestItemsText_loc2 { get; set; }

        public string RequestItemsText_loc3 { get; set; }

        public string RequestItemsText_loc4 { get; set; }

        public string RequestItemsText_loc5 { get; set; }

        public string RequestItemsText_loc6 { get; set; }

        public string RequestItemsText_loc7 { get; set; }

        public string RequestItemsText_loc8 { get; set; }

        public string EndText_loc1 { get; set; }

        public string EndText_loc2 { get; set; }

        public string EndText_loc3 { get; set; }

        public string EndText_loc4 { get; set; }

        public string EndText_loc5 { get; set; }

        public string EndText_loc6 { get; set; }

        public string EndText_loc7 { get; set; }

        public string EndText_loc8 { get; set; }

        public string ObjectiveText1_loc1 { get; set; }

        public string ObjectiveText1_loc2 { get; set; }

        public string ObjectiveText1_loc3 { get; set; }

        public string ObjectiveText1_loc4 { get; set; }

        public string ObjectiveText1_loc5 { get; set; }

        public string ObjectiveText1_loc6 { get; set; }

        public string ObjectiveText1_loc7 { get; set; }

        public string ObjectiveText1_loc8 { get; set; }

        public string ObjectiveText2_loc1 { get; set; }

        public string ObjectiveText2_loc2 { get; set; }

        public string ObjectiveText2_loc3 { get; set; }

        public string ObjectiveText2_loc4 { get; set; }

        public string ObjectiveText2_loc5 { get; set; }

        public string ObjectiveText2_loc6 { get; set; }

        public string ObjectiveText2_loc7 { get; set; }

        public string ObjectiveText2_loc8 { get; set; }

        public string ObjectiveText3_loc1 { get; set; }

        public string ObjectiveText3_loc2 { get; set; }

        public string ObjectiveText3_loc3 { get; set; }

        public string ObjectiveText3_loc4 { get; set; }

        public string ObjectiveText3_loc5 { get; set; }

        public string ObjectiveText3_loc6 { get; set; }

        public string ObjectiveText3_loc7 { get; set; }

        public string ObjectiveText3_loc8 { get; set; }

        public string ObjectiveText4_loc1 { get; set; }

        public string ObjectiveText4_loc2 { get; set; }

        public string ObjectiveText4_loc3 { get; set; }

        public string ObjectiveText4_loc4 { get; set; }

        public string ObjectiveText4_loc5 { get; set; }

        public string ObjectiveText4_loc6 { get; set; }

        public string ObjectiveText4_loc7 { get; set; }

        public string ObjectiveText4_loc8 { get; set; }

    }
    [Table("mail_level_reward")]
    public partial class mail_level_reward
    {
        [Key]
        public long level { get; set; }

        public long raceMask { get; set; }

        public long mailTemplateId { get; set; }

        public long senderEntry { get; set; }

    }
    [Table("mail_loot_template")]
    public partial class mail_loot_template
    {
        [Key]
        public long entry { get; set; }

        public long item { get; set; }

        public double ChanceOrQuestChance { get; set; }

        public long groupid { get; set; }

        public long mincountOrRef { get; set; }

        public long maxcount { get; set; }

        public long condition_id { get; set; }

    }
    [Table("mangos_string")]
    public partial class mangos_string
    {
        [Key]
        public long entry { get; set; }

        public string content_default { get; set; }

        public string content_loc1 { get; set; }

        public string content_loc2 { get; set; }

        public string content_loc3 { get; set; }

        public string content_loc4 { get; set; }

        public string content_loc5 { get; set; }

        public string content_loc6 { get; set; }

        public string content_loc7 { get; set; }

        public string content_loc8 { get; set; }

    }
    [Table("npc_gossip")]
    public partial class npc_gossip
    {
        [Key]
        public long npc_guid { get; set; }

        public long textid { get; set; }

    }
    [Table("npc_text")]
    public partial class npc_text
    {
        [Key]
        public long ID { get; set; }

        public string text0_0 { get; set; }

        public string text0_1 { get; set; }

        public long lang0 { get; set; }

        public double prob0 { get; set; }

        public long em0_0 { get; set; }

        public long em0_1 { get; set; }

        public long em0_2 { get; set; }

        public long em0_3 { get; set; }

        public long em0_4 { get; set; }

        public long em0_5 { get; set; }

        public string text1_0 { get; set; }

        public string text1_1 { get; set; }

        public long lang1 { get; set; }

        public double prob1 { get; set; }

        public long em1_0 { get; set; }

        public long em1_1 { get; set; }

        public long em1_2 { get; set; }

        public long em1_3 { get; set; }

        public long em1_4 { get; set; }

        public long em1_5 { get; set; }

        public string text2_0 { get; set; }

        public string text2_1 { get; set; }

        public long lang2 { get; set; }

        public double prob2 { get; set; }

        public long em2_0 { get; set; }

        public long em2_1 { get; set; }

        public long em2_2 { get; set; }

        public long em2_3 { get; set; }

        public long em2_4 { get; set; }

        public long em2_5 { get; set; }

        public string text3_0 { get; set; }

        public string text3_1 { get; set; }

        public long lang3 { get; set; }

        public double prob3 { get; set; }

        public long em3_0 { get; set; }

        public long em3_1 { get; set; }

        public long em3_2 { get; set; }

        public long em3_3 { get; set; }

        public long em3_4 { get; set; }

        public long em3_5 { get; set; }

        public string text4_0 { get; set; }

        public string text4_1 { get; set; }

        public long lang4 { get; set; }

        public double prob4 { get; set; }

        public long em4_0 { get; set; }

        public long em4_1 { get; set; }

        public long em4_2 { get; set; }

        public long em4_3 { get; set; }

        public long em4_4 { get; set; }

        public long em4_5 { get; set; }

        public string text5_0 { get; set; }

        public string text5_1 { get; set; }

        public long lang5 { get; set; }

        public double prob5 { get; set; }

        public long em5_0 { get; set; }

        public long em5_1 { get; set; }

        public long em5_2 { get; set; }

        public long em5_3 { get; set; }

        public long em5_4 { get; set; }

        public long em5_5 { get; set; }

        public string text6_0 { get; set; }

        public string text6_1 { get; set; }

        public long lang6 { get; set; }

        public double prob6 { get; set; }

        public long em6_0 { get; set; }

        public long em6_1 { get; set; }

        public long em6_2 { get; set; }

        public long em6_3 { get; set; }

        public long em6_4 { get; set; }

        public long em6_5 { get; set; }

        public string text7_0 { get; set; }

        public string text7_1 { get; set; }

        public long lang7 { get; set; }

        public double prob7 { get; set; }

        public long em7_0 { get; set; }

        public long em7_1 { get; set; }

        public long em7_2 { get; set; }

        public long em7_3 { get; set; }

        public long em7_4 { get; set; }

        public long em7_5 { get; set; }

    }
    [Table("npc_trainer")]
    public partial class npc_trainer
    {
        [Key]
        public long entry { get; set; }

        public long spell { get; set; }

        public long spellcost { get; set; }

        public long reqskill { get; set; }

        public long reqskillvalue { get; set; }

        public long reqlevel { get; set; }

        public long condition_id { get; set; }

    }
    [Table("npc_trainer_template")]
    public partial class npc_trainer_template
    {
        [Key]
        public long entry { get; set; }

        public long spell { get; set; }

        public long spellcost { get; set; }

        public long reqskill { get; set; }

        public long reqskillvalue { get; set; }

        public long reqlevel { get; set; }

        public long condition_id { get; set; }

    }
    [Table("npc_vendor")]
    public partial class npc_vendor
    {
        [Key]
        public long entry { get; set; }
        [Key]
        public long item { get; set; }

        public long maxcount { get; set; }

        public long incrtime { get; set; }

        public long ExtendedCost { get; set; }

        public long condition_id { get; set; }

        public string comments { get; set; }

    }
    [Table("npc_vendor_template")]
    public partial class npc_vendor_template
    {
        [Key]
        public long entry { get; set; }
        [Key]
        public long item { get; set; }

        public long maxcount { get; set; }

        public long incrtime { get; set; }

        public long ExtendedCost { get; set; }

        public long condition_id { get; set; }

        public string comments { get; set; }

    }
    [Table("page_text")]
    public partial class page_text
    {
        [Key]
        public long entry { get; set; }

        public string text { get; set; }

        public long next_page { get; set; }

    }
    [Table("pet_familystats")]
    public partial class pet_familystats
    {
        [Key]
        public long family { get; set; }

        public double healthModifier { get; set; }

        public double damageModifier { get; set; }

        public double armorModifier { get; set; }

    }
    [Table("pet_levelstats")]
    public partial class pet_levelstats
    {
        [Key]
        public long creature_entry { get; set; }
        [Key]
        public long level { get; set; }

        public long hp { get; set; }

        public long mana { get; set; }

        public long armor { get; set; }

        public long str { get; set; }

        public long agi { get; set; }

        public long sta { get; set; }

        public long inte { get; set; }

        public long spi { get; set; }

    }
    [Table("pet_name_generation")]
    public partial class pet_name_generation
    {
        [Key]
        public long id { get; set; }

        public string word { get; set; }

        public long entry { get; set; }

        public long half { get; set; }

    }
    [Table("petcreateinfo_spell")]
    public partial class petcreateinfo_spell
    {
        [Key]
        public long entry { get; set; }

        public long Spell1 { get; set; }

        public long Spell2 { get; set; }

        public long Spell3 { get; set; }

        public long Spell4 { get; set; }

    }
    [Table("pickpocketing_loot_template")]
    public partial class pickpocketing_loot_template
    {
        [Key]
        public long entry { get; set; }
        [Key]
        public long item { get; set; }

        public double ChanceOrQuestChance { get; set; }

        public long groupid { get; set; }

        public long mincountOrRef { get; set; }

        public long maxcount { get; set; }

        public long condition_id { get; set; }

    }
    [Table("player_classlevelstats")]
    public partial class player_classlevelstats
    {
        [Key]
        public long Class { get; set; }
        [Key]
        public long level { get; set; }

        public long basehp { get; set; }

        public long basemana { get; set; }

    }
    [Table("player_levelstats")]
    public partial class player_levelstats
    {
        [Key]
        public long race { get; set; }
        [Key]
        public long Class { get; set; }
        [Key]
        public long level { get; set; }

        public long str { get; set; }

        public long agi { get; set; }

        public long sta { get; set; }

        public long inte { get; set; }

        public long spi { get; set; }

    }
    [Table("player_xp_for_level")]
    public partial class player_xp_for_level
    {
        [Key]
        public long lvl { get; set; }

        public long xp_for_next_level { get; set; }

    }
    [Table("playercreateinfo")]
    public partial class playercreateinfo
    {
        [Key]
        public long race { get; set; }
        [Key]
        public long Class { get; set; }

        public long map { get; set; }

        public long zone { get; set; }

        public double position_x { get; set; }

        public double position_y { get; set; }

        public double position_z { get; set; }

        public double orientation { get; set; }

    }
    [Table("playercreateinfo_action")]
    public partial class playercreateinfo_action
    {
        [Key]
        public long race { get; set; }
        [Key]
        public long Class { get; set; }

        public long button { get; set; }

        public long action { get; set; }

        public long type { get; set; }

    }
    [Table("playercreateinfo_item")]
    public partial class playercreateinfo_item
    {
        [Key]
        public long race { get; set; }
        [Key]
        public long Class { get; set; }

        public long itemid { get; set; }

        public long amount { get; set; }

    }
    [Table("playercreateinfo_spell")]
    public partial class playercreateinfo_spell
    {
        [Key]
        public long race { get; set; }
        [Key]
        public long Class { get; set; }

        public long Spell { get; set; }

        public string Note { get; set; }

    }
    [Table("points_of_interest")]
    public partial class points_of_interest
    {
        [Key]
        public long entry { get; set; }

        public double x { get; set; }

        public double y { get; set; }

        public long icon { get; set; }

        public long flags { get; set; }

        public long data { get; set; }

        public string icon_name { get; set; }

    }
    [Table("pool_creature")]
    public partial class pool_creature
    {
        [Key]
        public long guid { get; set; }

        public long pool_entry { get; set; }

        public double chance { get; set; }

        public string description { get; set; }

    }
    [Table("pool_creature_template")]
    public partial class pool_creature_template
    {
        [Key]
        public long id { get; set; }

        public long pool_entry { get; set; }

        public double chance { get; set; }

        public string description { get; set; }

    }
    [Table("pool_gameobject")]
    public partial class pool_gameobject
    {
        [Key]
        public long guid { get; set; }

        public long pool_entry { get; set; }

        public double chance { get; set; }

        public string description { get; set; }

    }
    [Table("pool_gameobject_template")]
    public partial class pool_gameobject_template
    {
        [Key]
        public long id { get; set; }

        public long pool_entry { get; set; }

        public double chance { get; set; }

        public string description { get; set; }

    }
    [Table("pool_pool")]
    public partial class pool_pool
    {
        [Key]
        public long pool_id { get; set; }

        public long mother_pool { get; set; }

        public double chance { get; set; }

        public string description { get; set; }

    }
    [Table("pool_template")]
    public partial class pool_template
    {
        [Key]
        public long entry { get; set; }

        public long max_limit { get; set; }

        public string description { get; set; }

    }
    [Table("prospecting_loot_template")]
    public partial class prospecting_loot_template
    {
        [Key]
        public long entry { get; set; }

        public long item { get; set; }

        public double ChanceOrQuestChance { get; set; }

        public long groupid { get; set; }

        public long mincountOrRef { get; set; }

        public long maxcount { get; set; }

        public long condition_id { get; set; }

        public string comments { get; set; }

    }
    [Table("quest_template")]
    public partial class quest_template
    {
        [Key]
        public long entry { get; set; }

        public long Method { get; set; }

        public long ZoneOrSort { get; set; }

        public long MinLevel { get; set; }

        public long QuestLevel { get; set; }

        public long Type { get; set; }

        public long RequiredClasses { get; set; }

        public long RequiredRaces { get; set; }

        public long RequiredSkill { get; set; }

        public long RequiredSkillValue { get; set; }

        public long RequiredCondition { get; set; }

        public long RepObjectiveFaction { get; set; }

        public long RepObjectiveValue { get; set; }

        public long RequiredMinRepFaction { get; set; }

        public long RequiredMinRepValue { get; set; }

        public long RequiredMaxRepFaction { get; set; }

        public long RequiredMaxRepValue { get; set; }

        public long SuggestedPlayers { get; set; }

        public long LimitTime { get; set; }

        public long QuestFlags { get; set; }

        public long SpecialFlags { get; set; }

        public long CharTitleId { get; set; }

        public long PrevQuestId { get; set; }

        public long NextQuestId { get; set; }

        public long ExclusiveGroup { get; set; }

        public long NextQuestInChain { get; set; }

        public long SrcItemId { get; set; }

        public long SrcItemCount { get; set; }

        public long SrcSpell { get; set; }

        public string Title { get; set; }

        public string Details { get; set; }

        public string Objectives { get; set; }

        public string OfferRewardText { get; set; }

        public string RequestItemsText { get; set; }

        public string EndText { get; set; }

        public string ObjectiveText1 { get; set; }

        public string ObjectiveText2 { get; set; }

        public string ObjectiveText3 { get; set; }

        public string ObjectiveText4 { get; set; }

        public long ReqItemId1 { get; set; }

        public long ReqItemId2 { get; set; }

        public long ReqItemId3 { get; set; }

        public long ReqItemId4 { get; set; }

        public long ReqItemCount1 { get; set; }

        public long ReqItemCount2 { get; set; }

        public long ReqItemCount3 { get; set; }

        public long ReqItemCount4 { get; set; }

        public long ReqSourceId1 { get; set; }

        public long ReqSourceId2 { get; set; }

        public long ReqSourceId3 { get; set; }

        public long ReqSourceId4 { get; set; }

        public long ReqSourceCount1 { get; set; }

        public long ReqSourceCount2 { get; set; }

        public long ReqSourceCount3 { get; set; }

        public long ReqSourceCount4 { get; set; }

        public long ReqCreatureOrGOId1 { get; set; }

        public long ReqCreatureOrGOId2 { get; set; }

        public long ReqCreatureOrGOId3 { get; set; }

        public long ReqCreatureOrGOId4 { get; set; }

        public long ReqCreatureOrGOCount1 { get; set; }

        public long ReqCreatureOrGOCount2 { get; set; }

        public long ReqCreatureOrGOCount3 { get; set; }

        public long ReqCreatureOrGOCount4 { get; set; }

        public long ReqSpellCast1 { get; set; }

        public long ReqSpellCast2 { get; set; }

        public long ReqSpellCast3 { get; set; }

        public long ReqSpellCast4 { get; set; }

        public long RewChoiceItemId1 { get; set; }

        public long RewChoiceItemId2 { get; set; }

        public long RewChoiceItemId3 { get; set; }

        public long RewChoiceItemId4 { get; set; }

        public long RewChoiceItemId5 { get; set; }

        public long RewChoiceItemId6 { get; set; }

        public long RewChoiceItemCount1 { get; set; }

        public long RewChoiceItemCount2 { get; set; }

        public long RewChoiceItemCount3 { get; set; }

        public long RewChoiceItemCount4 { get; set; }

        public long RewChoiceItemCount5 { get; set; }

        public long RewChoiceItemCount6 { get; set; }

        public long RewItemId1 { get; set; }

        public long RewItemId2 { get; set; }

        public long RewItemId3 { get; set; }

        public long RewItemId4 { get; set; }

        public long RewItemCount1 { get; set; }

        public long RewItemCount2 { get; set; }

        public long RewItemCount3 { get; set; }

        public long RewItemCount4 { get; set; }

        public long RewRepFaction1 { get; set; }

        public long RewRepFaction2 { get; set; }

        public long RewRepFaction3 { get; set; }

        public long RewRepFaction4 { get; set; }

        public long RewRepFaction5 { get; set; }

        public long RewRepValue1 { get; set; }

        public long RewRepValue2 { get; set; }

        public long RewRepValue3 { get; set; }

        public long RewRepValue4 { get; set; }

        public long RewRepValue5 { get; set; }

        public long RewMaxRepValue1 { get; set; }

        public long RewMaxRepValue2 { get; set; }

        public long RewMaxRepValue3 { get; set; }

        public long RewMaxRepValue4 { get; set; }

        public long RewMaxRepValue5 { get; set; }

        public long RewHonorableKills { get; set; }

        public long RewOrReqMoney { get; set; }

        public long RewMoneyMaxLevel { get; set; }

        public long RewSpell { get; set; }

        public long RewSpellCast { get; set; }

        public long RewMailTemplateId { get; set; }

        public long RewMailDelaySecs { get; set; }

        public long PointMapId { get; set; }

        public double PointX { get; set; }

        public double PointY { get; set; }

        public long PointOpt { get; set; }

        public long DetailsEmote1 { get; set; }

        public long DetailsEmote2 { get; set; }

        public long DetailsEmote3 { get; set; }

        public long DetailsEmote4 { get; set; }

        public long DetailsEmoteDelay1 { get; set; }

        public long DetailsEmoteDelay2 { get; set; }

        public long DetailsEmoteDelay3 { get; set; }

        public long DetailsEmoteDelay4 { get; set; }

        public long IncompleteEmote { get; set; }

        public long CompleteEmote { get; set; }

        public long OfferRewardEmote1 { get; set; }

        public long OfferRewardEmote2 { get; set; }

        public long OfferRewardEmote3 { get; set; }

        public long OfferRewardEmote4 { get; set; }

        public long OfferRewardEmoteDelay1 { get; set; }

        public long OfferRewardEmoteDelay2 { get; set; }

        public long OfferRewardEmoteDelay3 { get; set; }

        public long OfferRewardEmoteDelay4 { get; set; }

        public long StartScript { get; set; }

        public long CompleteScript { get; set; }

    }
    [Table("reference_loot_template")]
    public partial class reference_loot_template
    {
        [Key]
        public long entry { get; set; }

        public long item { get; set; }

        public double ChanceOrQuestChance { get; set; }

        public long groupid { get; set; }

        public long mincountOrRef { get; set; }

        public long maxcount { get; set; }

        public long condition_id { get; set; }

        public string comments { get; set; }

    }
    [Table("reference_loot_template_names")]
    public partial class reference_loot_template_names
    {
        [Key]
        public long entry { get; set; }

        public string name { get; set; }

    }
    [Table("reputation_reward_rate")]
    public partial class reputation_reward_rate
    {
        [Key]
        public long faction { get; set; }

        public double quest_rate { get; set; }

        public double creature_rate { get; set; }

        public double spell_rate { get; set; }

    }
    [Table("reputation_spillover_template")]
    public partial class reputation_spillover_template
    {
        [Key]
        public long faction { get; set; }

        public long faction1 { get; set; }

        public double rate_1 { get; set; }

        public long rank_1 { get; set; }

        public long faction2 { get; set; }

        public double rate_2 { get; set; }

        public long rank_2 { get; set; }

        public long faction3 { get; set; }

        public double rate_3 { get; set; }

        public long rank_3 { get; set; }

        public long faction4 { get; set; }

        public double rate_4 { get; set; }

        public long rank_4 { get; set; }

    }
    [Table("reserved_name")]
    public partial class reserved_name
    {
        public string name { get; set; }

    }
    [Table("script_texts")]
    public partial class script_texts
    {
        [Key]
        public long entry { get; set; }

        public string content_default { get; set; }

        public string content_loc1 { get; set; }

        public string content_loc2 { get; set; }

        public string content_loc3 { get; set; }

        public string content_loc4 { get; set; }

        public string content_loc5 { get; set; }

        public string content_loc6 { get; set; }

        public string content_loc7 { get; set; }

        public string content_loc8 { get; set; }

        public long sound { get; set; }

        public long type { get; set; }

        public long language { get; set; }

        public long emote { get; set; }

        public string comment { get; set; }

    }
    [Table("script_waypoint")]
    public partial class script_waypoint
    {
        [Key]
        public long entry { get; set; }

        public long pointid { get; set; }

        public double location_x { get; set; }

        public double location_y { get; set; }

        public double location_z { get; set; }

        public long waittime { get; set; }

        public string point_comment { get; set; }

    }
    [Table("scripted_areatrigger")]
    public partial class scripted_areatrigger
    {
        [Key]
        public long entry { get; set; }

        public string ScriptName { get; set; }

    }
    [Table("scripted_event_id")]
    public partial class scripted_event_id
    {
        [Key]
        public long id { get; set; }

        public string ScriptName { get; set; }

    }
    [Table("skill_discovery_template")]
    public partial class skill_discovery_template
    {
        [Key]
        public long spellId { get; set; }

        public long reqSpell { get; set; }

        public double chance { get; set; }

    }
    [Table("skill_extra_item_template")]
    public partial class skill_extra_item_template
    {
        [Key]
        public long spellId { get; set; }

        public long requiredSpecialization { get; set; }

        public double additionalCreateChance { get; set; }

        public long additionalMaxNum { get; set; }

    }
    [Table("skill_fishing_base_level")]
    public partial class skill_fishing_base_level
    {
        [Key]
        public long entry { get; set; }

        public long skill { get; set; }

    }
    [Table("skinning_loot_template")]
    public partial class skinning_loot_template
    {
        [Key]
        public long entry { get; set; }

        public long item { get; set; }

        public double ChanceOrQuestChance { get; set; }

        public long groupid { get; set; }

        public long mincountOrRef { get; set; }

        public long maxcount { get; set; }

        public long condition_id { get; set; }

        public string comments { get; set; }

    }
    [Table("spell_affect")]
    public partial class spell_affect
    {
        [Key]
        public long entry { get; set; }

        public long effectId { get; set; }

        public long SpellFamilyMask { get; set; }

    }
    [Table("spell_area")]
    public partial class spell_area
    {
        [Key]
        public long spell { get; set; }

        public long area { get; set; }

        public long quest_start { get; set; }

        public long quest_start_active { get; set; }

        public long quest_end { get; set; }

        public long condition_id { get; set; }

        public long aura_spell { get; set; }

        public long racemask { get; set; }

        public long gender { get; set; }

        public long autocast { get; set; }

    }
    [Table("spell_bonus_data")]
    public partial class spell_bonus_data
    {
        [Key]
        public long entry { get; set; }

        public double direct_bonus { get; set; }

        public double dot_bonus { get; set; }

        public double ap_bonus { get; set; }

        public double ap_dot_bonus { get; set; }

        public string comments { get; set; }

    }
    [Table("spell_chain")]
    public partial class spell_chain
    {
        [Key]
        public long spell_id { get; set; }

        public long prev_spell { get; set; }

        public long first_spell { get; set; }

        public long rank { get; set; }

        public long req_spell { get; set; }

    }
    [Table("spell_elixir")]
    public partial class spell_elixir
    {
        [Key]
        public long entry { get; set; }

        public long mask { get; set; }

    }
    [Table("spell_facing")]
    public partial class spell_facing
    {
        [Key]
        public long entry { get; set; }

        public long facingcasterflag { get; set; }

    }
    [Table("spell_learn_spell")]
    public partial class spell_learn_spell
    {
        [Key]
        public long entry { get; set; }

        public long SpellID { get; set; }

        public long Active { get; set; }

    }
    [Table("spell_pet_auras")]
    public partial class spell_pet_auras
    {
        [Key]
        public long spell { get; set; }

        public long pet { get; set; }

        public long aura { get; set; }

    }
    [Table("spell_proc_event")]
    public partial class spell_proc_event
    {
        [Key]
        public long entry { get; set; }

        public long SchoolMask { get; set; }

        public long SpellFamilyName { get; set; }

        public long SpellFamilyMask0 { get; set; }

        public long SpellFamilyMask1 { get; set; }

        public long SpellFamilyMask2 { get; set; }

        public long procFlags { get; set; }

        public long procEx { get; set; }

        public double ppmRate { get; set; }

        public double CustomChance { get; set; }

        public long Cooldown { get; set; }

    }
    [Table("spell_proc_item_enchant")]
    public partial class spell_proc_item_enchant
    {
        [Key]
        public long entry { get; set; }

        public double ppmRate { get; set; }

    }
    [Table("spell_script_target")]
    public partial class spell_script_target
    {
        [Key]
        public long entry { get; set; }

        public long type { get; set; }

        public long targetEntry { get; set; }

        public long inverseEffectMask { get; set; }

    }
    [Table("spell_target_position")]
    public partial class spell_target_position
    {
        [Key]
        public long id { get; set; }

        public long target_map { get; set; }

        public double target_position_x { get; set; }

        public double target_position_y { get; set; }

        public double target_position_z { get; set; }

        public double target_orientation { get; set; }

    }
    [Table("spell_template")]
    public partial class spell_template
    {
        [Key]
        public long Id { get; set; }

        public long Category { get; set; }

        public long Dispel { get; set; }

        public long Mechanic { get; set; }

        public long Attributes { get; set; }

        public long AttributesEx { get; set; }

        public long AttributesEx2 { get; set; }

        public long AttributesEx3 { get; set; }

        public long AttributesEx4 { get; set; }

        public long AttributesEx5 { get; set; }

        public long AttributesEx6 { get; set; }

        public long Stances { get; set; }

        public long StancesNot { get; set; }

        public long Targets { get; set; }

        public long TargetCreatureType { get; set; }

        public long RequiresSpellFocus { get; set; }

        public long FacingCasterFlags { get; set; }

        public long CasterAuraState { get; set; }

        public long TargetAuraState { get; set; }

        public long CasterAuraStateNot { get; set; }

        public long TargetAuraStateNot { get; set; }

        public long CastingTimeIndex { get; set; }

        public long RecoveryTime { get; set; }

        public long CategoryRecoveryTime { get; set; }

        public long InterruptFlags { get; set; }

        public long AuraInterruptFlags { get; set; }

        public long ChannelInterruptFlags { get; set; }

        public long ProcFlags { get; set; }

        public long ProcChance { get; set; }

        public long ProcCharges { get; set; }

        public long MaxLevel { get; set; }

        public long BaseLevel { get; set; }

        public long SpellLevel { get; set; }

        public long DurationIndex { get; set; }

        public long PowerType { get; set; }

        public long ManaCost { get; set; }

        public long ManaCostPerlevel { get; set; }

        public long ManaPerSecond { get; set; }

        public long ManaPerSecondPerLevel { get; set; }

        public long RangeIndex { get; set; }

        public double Speed { get; set; }

        public long StackAmount { get; set; }

        public long Totem1 { get; set; }

        public long Totem2 { get; set; }

        public long Reagent1 { get; set; }

        public long Reagent2 { get; set; }

        public long Reagent3 { get; set; }

        public long Reagent4 { get; set; }

        public long Reagent5 { get; set; }

        public long Reagent6 { get; set; }

        public long Reagent7 { get; set; }

        public long Reagent8 { get; set; }

        public long ReagentCount1 { get; set; }

        public long ReagentCount2 { get; set; }

        public long ReagentCount3 { get; set; }

        public long ReagentCount4 { get; set; }

        public long ReagentCount5 { get; set; }

        public long ReagentCount6 { get; set; }

        public long ReagentCount7 { get; set; }

        public long ReagentCount8 { get; set; }

        public long EquippedItemClass { get; set; }

        public long EquippedItemSubClassMask { get; set; }

        public long EquippedItemInventoryTypeMask { get; set; }

        public long Effect1 { get; set; }

        public long Effect2 { get; set; }

        public long Effect3 { get; set; }

        public long EffectDieSides1 { get; set; }

        public long EffectDieSides2 { get; set; }

        public long EffectDieSides3 { get; set; }

        public long EffectBaseDice1 { get; set; }

        public long EffectBaseDice2 { get; set; }

        public long EffectBaseDice3 { get; set; }

        public double EffectDicePerLevel1 { get; set; }

        public double EffectDicePerLevel2 { get; set; }

        public double EffectDicePerLevel3 { get; set; }

        public double EffectRealPointsPerLevel1 { get; set; }

        public double EffectRealPointsPerLevel2 { get; set; }

        public double EffectRealPointsPerLevel3 { get; set; }

        public long EffectBasePoints1 { get; set; }

        public long EffectBasePoints2 { get; set; }

        public long EffectBasePoints3 { get; set; }

        public long EffectMechanic1 { get; set; }

        public long EffectMechanic2 { get; set; }

        public long EffectMechanic3 { get; set; }

        public long EffectImplicitTargetA1 { get; set; }

        public long EffectImplicitTargetA2 { get; set; }

        public long EffectImplicitTargetA3 { get; set; }

        public long EffectImplicitTargetB1 { get; set; }

        public long EffectImplicitTargetB2 { get; set; }

        public long EffectImplicitTargetB3 { get; set; }

        public long EffectRadiusIndex1 { get; set; }

        public long EffectRadiusIndex2 { get; set; }

        public long EffectRadiusIndex3 { get; set; }

        public long EffectApplyAuraName1 { get; set; }

        public long EffectApplyAuraName2 { get; set; }

        public long EffectApplyAuraName3 { get; set; }

        public long EffectAmplitude1 { get; set; }

        public long EffectAmplitude2 { get; set; }

        public long EffectAmplitude3 { get; set; }

        public double EffectMultipleValue1 { get; set; }

        public double EffectMultipleValue2 { get; set; }

        public double EffectMultipleValue3 { get; set; }

        public long EffectChainTarget1 { get; set; }

        public long EffectChainTarget2 { get; set; }

        public long EffectChainTarget3 { get; set; }

        public long EffectItemType1 { get; set; }

        public long EffectItemType2 { get; set; }

        public long EffectItemType3 { get; set; }

        public long EffectMiscValue1 { get; set; }

        public long EffectMiscValue2 { get; set; }

        public long EffectMiscValue3 { get; set; }

        public long EffectMiscValueB1 { get; set; }

        public long EffectMiscValueB2 { get; set; }

        public long EffectMiscValueB3 { get; set; }

        public long EffectTriggerSpell1 { get; set; }

        public long EffectTriggerSpell2 { get; set; }

        public long EffectTriggerSpell3 { get; set; }

        public double EffectPointsPerComboPoint1 { get; set; }

        public double EffectPointsPerComboPoint2 { get; set; }

        public double EffectPointsPerComboPoint3 { get; set; }

        public long SpellVisual { get; set; }

        public long SpellIconID { get; set; }

        public long ActiveIconID { get; set; }

        public long SpellPriority { get; set; }

        public string SpellName { get; set; }

        public string SpellName2 { get; set; }

        public string SpellName3 { get; set; }

        public string SpellName4 { get; set; }

        public string SpellName5 { get; set; }

        public string SpellName6 { get; set; }

        public string SpellName7 { get; set; }

        public string SpellName8 { get; set; }

        public string SpellName9 { get; set; }

        public string SpellName10 { get; set; }

        public string SpellName11 { get; set; }

        public string SpellName12 { get; set; }

        public string SpellName13 { get; set; }

        public string SpellName14 { get; set; }

        public string SpellName15 { get; set; }

        public string SpellName16 { get; set; }

        public string Rank { get; set; }

        public string Rank2 { get; set; }

        public string Rank3 { get; set; }

        public string Rank4 { get; set; }

        public string Rank5 { get; set; }

        public string Rank6 { get; set; }

        public string Rank7 { get; set; }

        public string Rank8 { get; set; }

        public string Rank9 { get; set; }

        public string Rank10 { get; set; }

        public string Rank11 { get; set; }

        public string Rank12 { get; set; }

        public string Rank13 { get; set; }

        public string Rank14 { get; set; }

        public string Rank15 { get; set; }

        public string Rank16 { get; set; }

        public long ManaCostPercentage { get; set; }

        public long StartRecoveryCategory { get; set; }

        public long StartRecoveryTime { get; set; }

        public long MaxTargetLevel { get; set; }

        public long SpellFamilyName { get; set; }

        public long SpellFamilyFlags { get; set; }

        public long MaxAffectedTargets { get; set; }

        public long DmgClass { get; set; }

        public long PreventionType { get; set; }

        public double DmgMultiplier1 { get; set; }

        public double DmgMultiplier2 { get; set; }

        public double DmgMultiplier3 { get; set; }

        public long TotemCategory1 { get; set; }

        public long TotemCategory2 { get; set; }

        public long AreaId { get; set; }

        public long SchoolMask { get; set; }

        public long IsServerSide { get; set; }

    }
    [Table("spell_threat")]
    public partial class spell_threat
    {
        [Key]
        public long entry { get; set; }

        public long Threat { get; set; }

        public double multiplier { get; set; }

        public double ap_bonus { get; set; }

    }
    [Table("transports")]
    public partial class transports
    {
        [Key]
        public long entry { get; set; }

        public string name { get; set; }

        public long period { get; set; }

    }
    [Table("world_template")]
    public partial class world_template
    {
        [Key]
        public long map { get; set; }

        public string ScriptName { get; set; }

    }

}
