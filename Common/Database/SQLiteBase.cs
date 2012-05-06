﻿using System.Data;
using System.Data.SQLite;
using System.Text;
using Common.Logging;

namespace Common.Database
{
    public class SQLiteBase
    {
        SQLiteConnection Connection;
        SQLiteDataReader SqlData;
        public int RowCount { get; set; }

        public void Init(string db)
        {
            Connection = new SQLiteConnection("Data Source=" + db + ".sqdb;Version=3");

            try
            {
                Connection.Open();
            }
            catch (SQLiteException ex)
            {
                Log.Message(LogType.ERROR, "{0}", ex.Message);
            }
        }

        public bool Execute(string sql, params object[] args)
        {
            StringBuilder sqlString = new StringBuilder();
            sqlString.AppendFormat(sql, args);

            SQLiteCommand sqlCommand = new SQLiteCommand(sqlString.ToString(), Connection);

            try
            {
                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (SQLiteException ex)
            {
                Log.Message(LogType.ERROR, "{0}", ex.Message);
                return false;
            }
        }

        public SQLResult Select(string sql, params object[] args)
        {
            SQLResult retData = new SQLResult();

            StringBuilder sqlString = new StringBuilder();
            sqlString.AppendFormat(sql, args);
            SQLiteCommand sqlCommand = new SQLiteCommand(sqlString.ToString(), Connection);
            
            try
            {
                SqlData = sqlCommand.ExecuteReader(CommandBehavior.Default);
                retData.Load(SqlData);
                retData.Count = retData.Rows.Count;
                SqlData.Close();
            }
            catch (SQLiteException ex)
            {
                Log.Message(LogType.ERROR, "{0}", ex.Message);
            }

            return retData;
        }
    }
}
