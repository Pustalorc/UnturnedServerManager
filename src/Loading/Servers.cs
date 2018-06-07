using ATORTTeam.UnturnedServerManager.Constants;
using ATORTTeam.UnturnedServerManager.FileControl;
using ATORTTeam.UnturnedServerManager.ServerInstance;
using ATORTTeam.UnturnedServerManager.Updating;
using System.IO;

namespace ATORTTeam.UnturnedServerManager.Loading
{
    public static class Servers
    {
        public static void Load()
        {
            if (Memory.Servers.Value.Count > 0)
                return;

            while(!FileActions.VerifyFile(Path.Combine(VanillaServerPath.Value, "Unturned.exe")) || !FileActions.VerifyFile(Path.Combine(RocketmodServerPath.Value, "Unturned.exe")))
                Updater.UpdateAll();

            var RocketmodDirectory = Path.Combine(RocketmodServerPath.Value, "Servers");
            FileActions.VerifyPath(RocketmodDirectory, true);

            var RocketmodDirectoryInfo = new DirectoryInfo(RocketmodDirectory);
            foreach (var rocketserver in RocketmodDirectoryInfo.GetDirectories())
                Memory.Servers.Value.Add(Server.Create(rocketserver.Name, ServerType.RocketMod));

            var VanillaDirectory = Path.Combine(VanillaServerPath.Value, "Servers");
            FileActions.VerifyPath(VanillaDirectory, true);

            var VanillaDirectoryInfo = new DirectoryInfo(VanillaDirectory);
            foreach (var vanillaserver in VanillaDirectoryInfo.GetDirectories())
                Memory.Servers.Value.Add(Server.Create(vanillaserver.Name, ServerType.Vanilla));
        }
        public static void Unload()
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
