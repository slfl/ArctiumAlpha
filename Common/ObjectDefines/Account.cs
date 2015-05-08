using System;
using Common.Database.ObjectDatabase;
using Common.Structs;
using Db4objects.Db4o.Linq;

namespace Common.ObjectDefines
{
    public class Account
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string IP { get; set; }
        public byte GMLevel { get; set; }
        public string Language { get; set; }

        public static Account GetAccountByName(string name)
        {
            Account acc = null;
            var conn = DB.Realms.Connection;
            var account = from Account a in conn where a.Name == name select a;

            foreach (Account a in account)
                acc = a;

            return acc;
        }
    }
}
