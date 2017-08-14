using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SQLite;
using WoWDB.Entities;

namespace WoWDB
{
    public static class DataMgr
    {
        static DataMgr()
        {

        }

        public static void Init()
        {
            if (Directory.Exists(@"Data\DB") && File.Exists(@"Data\DB\database.sqlite"))
            {
                Database.Init(new SQLiteConnection(string.Format(@"Data Source=Data\DB\database.sqlite;Version=3;", Path.Combine(Environment.CurrentDirectory, @"Data\DB\database.sqlite"))));
            }

            spell_template = Database.Query<spell_template>("SELECT * FROM spell_template").ToList();
            creature_template = Database.Query<creature_template>("SELECT * FROM creature_template").ToList();
            player_classlevelstats = Database.Query<player_classlevelstats>("SELECT * FROM player_classlevelstats").ToList();
            item_template = Database.Query<item_template>("SELECT * FROM item_template").ToList();
        }

        public static List<spell_template> spell_template = new List<spell_template>();
        public static List<creature_template> creature_template = new List<creature_template>();
        public static List<player_classlevelstats> player_classlevelstats = new List<player_classlevelstats>();
        public static List<item_template> item_template = new List<item_template>();
    }
}
