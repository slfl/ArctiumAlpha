using System;

namespace Common.Logging
{
    public class Log
    {
        static public void Message()
        {
            SetLogger(LogType.Default, "");
        }

        static public void Message(LogType type, string text, params object[] args)
        {
            SetLogger(type, text, args);
        }

        static void SetLogger(LogType type, string text, params object[] args)
        {
            switch (type)
            {
                case LogType.Normal:
                    Console.ForegroundColor = ConsoleColor.Green;
                    text = text.Insert(0, "System: ");
                    break;
                case LogType.Error:
                    Console.ForegroundColor = ConsoleColor.Red;
                    text = text.Insert(0, "Error: ");
                    break;
                case LogType.Dump:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case LogType.Init:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case LogType.Cmd:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case LogType.Debug:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
                default:
                    break;
            }

            if (type.Equals(LogType.Init) | type.Equals(LogType.Default))
                Console.WriteLine(text, args);
            else if (type.Equals(LogType.Dump) || type.Equals(LogType.Cmd))
                Console.Write(text, args);
            else
                Console.WriteLine("[" + DateTime.Now.ToLongTimeString() + "] " + text, args);
        }
    }
}
