using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Pustalorc.Applications.USM.Constants;
using Pustalorc.Applications.USM.File_Control;
using Pustalorc.Applications.USM.Server_Instance;
using Pustalorc.Applications.USM.Updating;

namespace Pustalorc.Applications.USM.Loading
{
    internal static class Servers
    {
        public static List<Server> RegisteredServers { get; set; } = new List<Server>();

        public static void Load()
        {
            if (RegisteredServers.Count > 0)
                return;

            var unturnedExec = "Unturned.exe";
            var linux = RuntimeInformation.IsOSPlatform(OSPlatform.Linux);
            if (linux)
                Console.WriteLine(
                    "You are running USM in linux, please verify that you have SteamCMD installed and that it can be executed from bash, otherwise it will not load.");

            for (var i = 0; i <= 10; i++)
            {
                if (linux)
                {
                    unturnedExec =
                        new[] {"Unturned_Headless.x86", "Unturned.x86", "Unturned_Headless.x86_64", "Unturned.x86_64"}
                            .FirstOrDefault(exec => FileActions.VerifyFile(Path.Combine(ServerPath.Value, exec)));

                    if (string.IsNullOrEmpty(unturnedExec))
                        unturnedExec = "Unturned_Headless.x86_64";
                }


                if (FileActions.VerifyFile(Path.Combine(ServerPath.Value, unturnedExec))) break;

                if (i == 10)
                {
                    Console.WriteLine(
                        "Unable to install correctly unturned in your system. Please verify that you have met all pre-install requirements.");
                    Environment.Exit(0);
                    return;
                }

                Updater.ValidateUnturned();
            }

            var serverDirectory = Path.Combine(ServerPath.Value, "Servers");
            FileActions.VerifyPath(serverDirectory, true);

            var serverDirectoryInfo = new DirectoryInfo(serverDirectory);
            foreach (var server in serverDirectoryInfo.GetDirectories())
                RegisteredServers.Add(Server.Create(server.Name));
        }

        private static void Unload()
        {
            if (RegisteredServers.Count == 0)
                return;

            RegisteredServers.Clear();
        }

        public static void Reload()
        {
            Unload();
            Load();
        }
    }
}