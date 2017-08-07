using robotManager.Helpful;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wManager.Wow.ObjectManager;

namespace FightClass1
{
    abstract class FighterBase
    {
        public abstract void Init();
        public abstract void Update();

        public static double GetRange(Vector3 p1, Vector3 p2)
        {
            return System.Math.Sqrt(System.Math.Pow(p1.X - p2.X, 2) + System.Math.Pow(p1.Y - p2.Y, 2));
        }

        public static double GetRange(WoWUnit p1, WoWUnit p2)
        {
            return GetRange(p1.Position, p2.Position);
        }
    }
}
