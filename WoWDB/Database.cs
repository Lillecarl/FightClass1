using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using Dapper;
using Dapper.Contrib.Extensions;
using System.Data;

namespace WoWDB
{
    public static class Database
    {
        static Database()
        {
        }

        public static void Init(IDbConnection conn)
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

        public static IDbTransaction BeginTransaction()
        {
            return dbconn.BeginTransaction();
        }

        public static IEnumerable<T> Query<T>(string sql, object param = null, IDbTransaction transaction = null, bool buffered = true)
        {
            return dbconn.Query<T>(sql, param, transaction, buffered);
        }

        public static int Execute(string sql, object param = null, IDbTransaction transaction = null)
        {
            return dbconn.Execute(sql, param, transaction);
        }

        public static T ExecuteScalar<T>(string sql, object param = null, IDbTransaction transaction = null, bool buffered = true)
        {
            return dbconn.Query<T>(sql, param, transaction, buffered).FirstOrDefault();
        }

        public static long Insert<T>(T entityToInsert, IDbTransaction transaction = null, int? commandTimeout = null) where T : class
        {
            return dbconn.Insert(entityToInsert, transaction, commandTimeout);
        }

        public static bool Update<T>(T entityToUpdate, IDbTransaction transaction = null, int? commandTimeout = null) where T : class
        {
            return dbconn.Update(entityToUpdate, transaction, commandTimeout);
        }

        public static bool Delete<T>(T entityToDelete, IDbTransaction transaction = null, int? commandTimeout = null) where T : class
        {
            return dbconn.Update(entityToDelete, transaction, commandTimeout);
        }

        public static bool DeleteAll<T>(IDbTransaction transaction = null, int? commandTimeout = null) where T : class
        {
            return dbconn.DeleteAll<T>(transaction, commandTimeout);
        }

        public static T Get<T, U>(U id, IDbTransaction transaction = null, int? commandTimeout = null) where T : class
        {
            return dbconn.Get<T>(id, transaction, commandTimeout);
        }

        public static IEnumerable<T> GetAll<T>(IDbTransaction transaction = null, int? commandTimeout = null) where T : class
        {
            return dbconn.GetAll<T>(transaction, commandTimeout);
        }


        private static IDbConnection dbconn = null;
    }

}
