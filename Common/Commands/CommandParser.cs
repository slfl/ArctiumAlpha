using System;
using Common.Logging;

namespace Common.Commands
{
    public class CommandParser
    {
        public static T ReadN<T>(string[] args, int index)
        {
            try
            {
                return (T)Convert.ChangeType(args[index], typeof(T));
            }
            catch
            {
                Log.Message(LogType.Error, "Wrong Name");
            }

            return default(T);
        }

        public static T ReadP<T>(string[] args, int index)
        {
            try
            {
                return (T)Convert.ChangeType(args[index], typeof(T));
            }
            catch
            {
                Log.Message(LogType.Error, "Wrong Password");
            }

            return default(T);
        }

    }
}
