namespace Common.Commands.WorldServer
{
    public class CommandDefinitions
    {
        public static void LoadCommandDefinitions()
        {
            ConsoleManager.DefineCommand("create", ConsoleCommands.CreateAccount);
            ConsoleManager.DefineCommand("exit", ConsoleCommands.Exit);
            ConsoleManager.DefineCommand("help", ConsoleCommands.Help);
        }

    }
}
