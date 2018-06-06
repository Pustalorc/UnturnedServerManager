using ATORTTeam.UnturnedServerManager.Configuration;
using ATORTTeam.UnturnedServerManager.Constants;
using ATORTTeam.UnturnedServerManager.SteamCMDManager;
using ATORTTeam.UnturnedServerManager.Versions;
using System.IO;
using System.IO.Compression;
using System.Net;

namespace ATORTTeam.UnturnedServerManager.Updating
{
    public static class Updater
    {
        /// <summary>
        /// Downloads and installs SteamCMD in order to install Unturned.
        /// </summary>
        public static void UpdateUnturned()
        {
            SteamCMD.RunCommand($"+force_install_dir \"{RocketmodServerPath.Value}\" +app_update 304930 validate +exit");
            SteamCMD.RunCommand($"+force_install_dir \"{VanillaServerPath.Value}\" +app_update 304930 validate +exit");
        }

        /// <summary>
        /// Downloads and installs RocketMod.
        /// </summary>
        public static void UpdateRocket()
        {
            var tempzip = Path.Combine(Path.GetTempPath(), Path.GetTempFileName());
            bool Error = false;
            
            // Download rocket
            using (var client = new WebClient())
                client.DownloadFile(RocketUpdate.Value, tempzip);
            
            // Extract and install rocket
            foreach (ZipArchiveEntry Entry in new ZipArchive(File.OpenRead(tempzip)).Entries)
            {
                try
                {
                    string dir = Path.GetFullPath(Path.Combine(RocketmodServerPath.Value, Entry.FullName));

                    if (!Directory.Exists(Path.GetDirectoryName(dir)))
                        Directory.CreateDirectory(dir);

                    if (Entry.Name != "")
                        Entry.ExtractToFile(dir, true);
                }
                // Catch any exception when extracting the file and keep moving.
                catch
                {
                    Error = true;
                }
            }

            if (!Error)
            {
                var local = LocalVersions.Load();
                local.UnturnedVersion = UnturnedBuild.Value;
                local.SaveJson();
            }
        }

        /// <summary>
        /// Downloads and installs Rocketmod + Unturned.
        /// </summary>
        public static void UpdateAll()
        {
            UpdateUnturned();
            UpdateRocket();
        }
    }
}
