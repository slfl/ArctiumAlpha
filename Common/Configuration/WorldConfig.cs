using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Logging;

namespace Common.Configuration
{
    public static class WorldConfig
    {
        static Config config = new Config("./Configs/WorldServer.conf");

        public static string CharDBHost = config.Read("CharDB.Host", "");
        public static int CharDBPort = config.Read("CharDB.Port", 3306);
        public static string CharDBUser = config.Read("CharDB.User", "");
        public static string CharDBPassword = config.Read("CharDB.Password", "");
        public static string CharDBDataBase = config.Read("CharDB.Database", "");

        public static string WorldDBHost = config.Read("WorldDB.Host", "");
        public static int WorldDBPort = config.Read("WorldDB.Port", 3306);
        public static string WorldDBUser = config.Read("WorldDB.User", "");
        public static string WorldDBPassword = config.Read("WorldDB.Password", "");
        public static string WorldDBDataBase = config.Read("WorldDB.Database", "");

        public static uint RealmId = config.Read("RealmId", 1u);

        public static string BindIP = config.Read("Bind.IP", "0.0.0.0");
        public static uint BindPort = config.Read<uint>("Bind.Port", 8100);

        public static string DataPath = config.Read("DataPath", "./Data/");

        public static string GMCommandStart = config.Read("GM.Command.Start", "!");

        public static bool MySqlPooling = config.Read("MySql.Pooling", false);
        public static int MySqlMinPoolSize = config.Read("MySql.MinPoolSize", 5);
        public static int MySqlMaxPoolSize = config.Read("MySql.MaxPoolSize", 150);

        public static LogType LogLevel = (LogType)config.Read<uint>("LogLevel", 0, true);
    }
}

