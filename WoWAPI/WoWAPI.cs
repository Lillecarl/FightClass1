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
using wManager.Wow.Helpers;

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

        public static double GetDistance(WoWObject p1, WoWObject p2)
        {
            return GetDistance(p1.Position, p2.Position);
        }

        public static spell_template GetSpellTemplate(long spellid)
        {
            try
            {
                return Database.GetAll<spell_template>().Where(m => m.Id == spellid).First();
            }
            catch (Exception ex)
            {
                Logging.WriteError(string.Format("Could not find spell {0} {1}", spellid, ex.ToString()));
            }

            return null;
        }

        public static spell_template GetSpellTemplate(string spellname)
        {
            try
            {
                return Database.GetAll<spell_template>().Where(m => m.SpellName.ToLower().Contains(spellname.ToLower())).First();
            }
            catch (Exception ex)
            {
                Logging.WriteError(string.Format("Could not find spell {0} {1}", spellname, ex.ToString()));
            }

            return null;
        }

        public static bool CanCast(uint spellid, bool self = false)
        {
            var spell = GetSpellTemplate(spellid);

            if (spell != null)
                return CanCast(spell);

            return false;
        }

        public static bool CanCast(string spellname, bool self = false)
        {
            var spell = GetSpellTemplate(spellname);

            if (spell != null)
                return CanCast(spell);

            return false;
        }

        public static bool CanCast(spell_template spell, bool self = false)
        {
            string reason = "";
            if (WoWAPI.Target != null)
            {
                var range = DBC.SpellRange[spell.RangeIndex];

                if (range.MinRange > GetDistance(WoWAPI.Player, WoWAPI.Target))
                    reason += "MinRange ";

                if (range.MaxRange < GetDistance(WoWAPI.Player, WoWAPI.Target))
                    reason += "MaxRange ";
            }

            var usable = Lua.LuaDoString<bool>(string.Format("return IsUsableSpell(\"{0}\")", spell.SpellName));
            var cooldown = Lua.LuaDoString<int>(string.Format("return GetSpellCooldown(\"{0}\"))", spell.SpellName));

            long powercost = spell.ManaCost;

            if (spell.PowerType == 0 && powercost > Player.Mana)
                reason += "Mana ";
            if (spell.PowerType == 1 && powercost > Player.Rage)
                reason += "Rage ";
            if (spell.PowerType == 2 && powercost > Player.Focus)
                reason += "Focus ";
            if (spell.PowerType == 3 && powercost > Player.Energy)
                reason += "Energy ";
            if (spell.PowerType == 5 && powercost > Player.Runes)
                reason += "Rune ";
            if (spell.PowerType == 6 && powercost > Player.RunicPower)
                reason += "Runicpower ";
            if (spell.PowerType == 4294967294 && powercost > Player.Health)
                reason += "Health ";

            if ((spell.Stances & (long)ShapeshiftFormMask.FORM_CAT) == 0 && !Player.HaveBuff("Cat Form"))
                reason += "Cat Form";

            if ((spell.Stances & (long)ShapeshiftFormMask.FORM_BEAR) == 0 && !Player.HaveBuff("Bear Form"))
                reason += "Bear Form";

            if ((spell.Stances & (long)ShapeshiftFormMask.FORM_DIREBEAR) == 0 && !Player.HaveBuff("Dire Bear Form"))
                reason += "Dire Bear Form";

            Logging.WriteDebug(string.Format("Cancast {0} Reason {1} Usable {2} Cooldown {3}",  spell.SpellName, reason, usable, cooldown));

            if (reason.Length == 0)
                return true;
            return false;
        }
    }
}
