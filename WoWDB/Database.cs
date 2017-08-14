using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using Dapper;

namespace WoWDB
{
    public static class Database
    {
        static Database()
        {
        }

        public static void Init(DbConnection conn)
        {
            dbconn = conn;
            dbconn.Open();
        }

        public static void Close()
        {
            try
            {
                dbconn.Close();
                dbconn.Dispose();
            }
            catch
            { }
        }

        public static DbTransaction BeginTransaction()
        {
            return dbconn.BeginTransaction();
        }

        public static IEnumerable<T> Query<T>(string sql, object param = null, DbTransaction transaction = null, bool buffered = true)
        {
            return dbconn.Query<T>(sql, param, transaction, buffered);
        }

        public static int Execute(string sql, object param = null, DbTransaction transaction = null)
        {
            return dbconn.Execute(sql, param, transaction);
        }

        public static T ExecuteScalar<T>(string sql, object param = null, DbTransaction transaction = null, bool buffered = true)
        {
            return dbconn.Query<T>(sql, param, transaction, buffered).Single();
        }

        private static DbConnection dbconn = null;
    }

}
