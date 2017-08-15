using System.Runtime.InteropServices;

namespace SpellWork
{
    public struct SkillLineEntry
    {
        public uint ID;                                            // 0        m_ID
        public int CategoryId;                                    // 1        m_categoryID
        public uint SkillCostID;                                   // 2        m_skillCostsID
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public uint[] _Name;                                       // 3-18     m_displayName_lang
        public uint NameFlags;                                     // 19
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public uint[] _Description;                                // 20-35    m_description_lang
        public uint DescriptionFlags;                              // 36
        public uint SpellIcon;                                     // 37       m_spellIconID

        public string Name
        {
            get { return DBC.SkillLineStrings.GetValue(_Name[(uint)DBC.Locale]); }
        }

        public string Description
        {
            get { return DBC.SkillLineStrings.GetValue(_Description[(uint)DBC.Locale]); }
        }
    };
}
