using System.IO;
using ATORTTeam.UnturnedServerManager.Constants;
using ATORTTeam.UnturnedServerManager.File_Control;
using ATORTTeam.UnturnedServerManager.Server_Instance;
using ATORTTeam.UnturnedServerManager.Updating;

namespace ATORTTeam.UnturnedServerManager.Loading
{
    internal static class Servers
    {
        public static void Load()
        {
            if (Memory.Servers.Value.Count > 0)
                return;

            while (!FileActions.VerifyFile(Path.Combine(RocketModServerPath.Value, "Unturned.exe")))
                Updater.UpdateAll();

            var rocketModDirectory = Path.Combine(RocketModServerPath.Value, "Servers");
            FileActions.VerifyPath(rocketModDirectory, true);

            var rocketModDirectoryInfo = new DirectoryInfo(rocketModDirectory);
            foreach (var rocketServer in rocketModDirectoryInfo.GetDirectories())
                Memory.Servers.Value.Add(Server.Create(rocketServer.Name));
        }

        private static void Unload()
        {
            if (Memory.Servers.Value.Count == 0)
                return;

            Memory.Servers.Value.Clear();
        }

        public static void Reload()
        {
            Unload();
            Load();
        }
    }
}