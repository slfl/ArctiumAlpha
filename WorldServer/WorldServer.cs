using System;
using Common.Commands;
using Common.Database.ObjectDatabase;
using Common.Logging;
using WorldServer.Game.Commands;
using WorldServer.Network;
using WorldServer.Packets;

namespace WorldServer
{
    class WorldServer
    {
        static void Main()
        {
            Log.Message(LogType.INIT, "Flame-WoW alpha WoW Core");
            Log.Message(LogType.INIT, "WoW 0.5.3.3368");
            Log.Message(LogType.INIT, "By Flame-WoW Team");
            Log.Message();

            Log.Message(LogType.NORMAL, "Starting WoW Alpha WorldServer...");

            ODB.Characters.Init("Characters");
            ODB.Realms.Init("Realms");

            RealmManager.RealmSession = new RealmSocket();
            WorldManager.WorldSession = new WorldSocket();

            if (WorldManager.WorldSession.Start() && RealmManager.RealmSession.Start())
            {
                RealmManager.RealmSession.StartRealmThread();
                RealmManager.RealmSession.StartProxyThread();
                Log.Message(LogType.NORMAL, "RealmProxy listening on {0} port {1}/{2}.", "127.0.0.1", 9090, 9100);
                Log.Message(LogType.NORMAL, "RealmProxy successfully started!");

                WorldManager.WorldSession.StartConnectionThread();
                Log.Message(LogType.NORMAL, "WorldServer listening on {0} port {1}.", "127.0.0.1", 8100);
                Log.Message(LogType.NORMAL, "WorldServer successfully started!");
                Log.Message();

                HandlerDefinitions.InitializePacketHandler();
            }
            else
            {
                Log.Message(LogType.ERROR, "WorldServer couldn't be started: ");
                Log.Message();
            }

            // Free memory...
            GC.Collect();
            Log.Message(LogType.NORMAL, "Total Memory: {0}", GC.GetTotalMemory(false));

            // Init Command handlers...
            CommandDefinitions.LoadCommandDefinitions();
            ConsoleManager.InitCommands();
        }
    }
}
