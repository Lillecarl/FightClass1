using System.Runtime.InteropServices;

namespace SpellWork
{
    public struct SpellRangeEntry
    {
        public uint ID;
        public float MinRange;
        public float MaxRange;
        public uint Flags;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public uint[] _Desc1;
        public uint Desc1Flags;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public uint[] _Desc2;
        public uint Desc2Flags;

        public string Description1
        {
            get { return DBC.SpellRangeStrings.GetValue(_Desc1[(uint)DBC.Locale]); }
        }

        public string Description2
        {
            get { return DBC.SpellRangeStrings.GetValue(_Desc2[(uint)DBC.Locale]); }
        }
    };
}
