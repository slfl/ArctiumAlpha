using MySql.Data.MySqlClient;
using Db4objects.Db4o;
using Db4objects.Db4o.Linq;
using System;
using Common.Logging;

namespace Common.Database.ObjectDatabase
{
    public class MySqlBase
    {
        public IObjectContainer Connection;

        public int RowCount { get; set; }

        public void Init(string db)
        {
            Connection = Db4oEmbedded.OpenFile(db + ".aodb");
        }

        public bool Save(object obj)
        {
            try
            {
                Connection.Store(obj);
                Connection.Commit();

                return true;
            }
            catch (Exception ex)
            {
                Log.Message(LogType.Error, "{0}", ex.Message);
                return false;
            }
        }

        public bool Delete(object obj)
        {
            try
            {
                Connection.Delete(obj);
                Connection.Commit();

                return true;
            }
            catch (Exception ex)
            {
                Log.Message(LogType.Error, "{0}", ex.Message);
                return false;
            }
        }

        public IDb4oLinqQuery Select<T>()
        {
            var sObject = from T o in Connection select o;

            int count = 0;
            foreach (object o in sObject)
                ++count;

            RowCount = count;

            return sObject;
        }
    }
}
