using robotManager.Helpful;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wManager.Wow.Enums;
using wManager.Wow.ObjectManager;
using wManager.Wow.Patchables;
using SpellWork;
using WoWDB;
using WoWDB.Entities;

namespace WoWAPI
{
    public static class WoWAPI
    {
        public static WoWLocalPlayer Player { get { return ObjectManager.Me; } }
        public static WoWUnit Target { get { return ObjectManager.Target; } }
        public static WoWUnit Pet { get { return ObjectManager.Pet; } }

        public static double GetDistance(Vector3 p1, Vector3 p2)
        {
            return System.Math.Sqrt(System.Math.Pow(p1.X - p2.X, 2) + System.Math.Pow(p1.Y - p2.Y, 2));
        }

        public static double GetDistance(WoWUnit p1, WoWUnit p2)
        {
            return GetRange(p1.Position, p2.Position);
        }

        public static bool CanCast(uint spellid)
        {
            try
            {
                return CanCast(DBC.Spell.Where(m => m.Value.ID == spellid).First().Value);
            }
            catch
            {
                Logging.WriteError(string.Format("Could not cast spell {0}", spellid));
            }

            return false;
        }

        public static bool CanCast(string spellname)
        {
            try
            {
                return CanCast(DBC.Spell.Where(m => m.Value.SpellName.ToLower() == spellname.ToLower()).First().Value);
            }
            catch
            {
                Logging.WriteError(string.Format("Could not cast spell {0}", spellname));
            }

            return false;
        }

        public static bool CanCast(SpellEntry spell)
        {
            if (WoWAPI.Target != null)
            {
                var range = DBC.SpellRange[spell.RangeIndex];

                if (range.MinRange > GetDistance(WoWAPI.Player, WoWAPI.Target))
                    return false;

                if (range.MaxRange < GetDistance(WoWAPI.Player, WoWAPI.Target))
                    return false;
            }

            return true;
        }
    }
}
