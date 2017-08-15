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
        }
    }
}
