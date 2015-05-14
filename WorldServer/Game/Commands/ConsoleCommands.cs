using System;
using System.Security.Cryptography;
using System.Text;
using Common.Account;
using Common.Commands;
using Common.Database.ObjectDatabase;
using Common.Logging;

namespace WorldServer.Game.Commands
{
    public class ConsoleCommands : CommandParser
    {
        public static void CreateAccount(string[] args)
        {
            string Name = ReadN<string>(args, 0);
            string Password = ReadP<string>(args, 1);

            if (Name == null || Password == null)
                return;

            byte[] hash = new SHA1CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes(Password));
            string hashString = BitConverter.ToString(hash).Replace("-", "");

            Account acc = new Account();

            acc.Name = Name.ToUpper();
            acc.Password = hashString;
            acc.Language = "enUS";
            acc.GMLevel = 3;

            var result = DB.Realms.Select<Account>();
            acc.Id = (uint)DB.Realms.RowCount + 1;

            if (DB.Realms.RowCount == 0)
                DB.Realms.Save(acc);

            foreach (Account a in result)
            {
                if (a.Name != Name)
                {
                    DB.Realms.Save(acc);
                    break;
                }
            }              
        }

        public static void Exit(string[] args)
        {
            Environment.Exit(0);
        }

        public static void Help(string[] args)
        {
            Log.Message(LogType.Debug, "This Help Command!!!");
            Log.Message(LogType.Debug, "Commands:");
            Log.Message(LogType.Debug, "create <name> <password> - Create Account");
            Log.Message(LogType.Debug, "exit - Stop Server");
        }

    }
}
