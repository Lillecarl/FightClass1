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

namespace FightClass1
{
    public static class Helper
    {
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
