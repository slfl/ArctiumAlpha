using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Database.ObjectDatabase
{
    public class DB
    {
        public static MySqlBase Characters = new MySqlBase();
        public static MySqlBase Realms = new MySqlBase();

        // public static ObjectBase Characters = new ObjectBase();
        // public static ObjectBase Realms = new ObjectBase();
    }
}
