using ATORTTeam.UnturnedServerManager.Configuration;
using ATORTTeam.UnturnedServerManager.Constants;
using ATORTTeam.UnturnedServerManager.FileControl;
using ATORTTeam.UnturnedServerManager.Memory;
using ATORTTeam.UnturnedServerManager.Versions;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;

namespace ATORTTeam.UnturnedServerManager.Updating
{
    public static class Updater
    {
        /// <summary>
        /// Downloads and installs SteamCMD in order to install Unturned to the specified directory.
        /// </summary>
        /// <param name="directory">Sets the specified directory that RocketMod will be installed to.</param>
        public static void UpdateUnturned()
        {
            var inst = Installation.Load();
            var steamcmdexe = Path.Combine(inst.InstallationPath, "steamcmd.exe");
            var login = new GUI.SteamLogin();

            try
            {
                if (string.IsNullOrEmpty(SteamLogin.Username) || string.IsNullOrEmpty(SteamLogin.Password))
                    login.ShowDialog();

                if (!File.Exists(steamcmdexe))
                {
                    var ZipTarget = Path.Combine(Path.GetTempPath(), Path.GetTempFileName());
                    FileActions.Download(SteamCMD.Value, ZipTarget);
                    FileActions.Extract(ZipTarget, inst.InstallationPath);
                }

                Process proc = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = steamcmdexe;

                if (string.IsNullOrEmpty(SteamLogin.Username) || string.IsNullOrEmpty(SteamLogin.Password))
                    startInfo.Arguments = " +login " + login.Username.Text + " " + login.Password.Text + " +force_install_dir \"" + RocketmodServerPath.Value + "\" +app_update 304930 validate +exit";
                else
                    startInfo.Arguments = " +login " + SteamLogin.Username + " " + SteamLogin.Password + " +force_install_dir \"" + RocketmodServerPath.Value + "\" +app_update 304930 validate +exit";

                proc.StartInfo = startInfo;
                proc.Start();
                proc.WaitForExit();

                if (string.IsNullOrEmpty(SteamLogin.Username) || string.IsNullOrEmpty(SteamLogin.Password))
                    startInfo.Arguments = " +login " + login.Username.Text + " " + login.Password.Text + " +force_install_dir \"" + VanillaServerPath.Value + "\" +app_update 304930 validate +exit";
                else
                    startInfo.Arguments = " +login " + SteamLogin.Username + " " + SteamLogin.Password + " +force_install_dir \"" + VanillaServerPath.Value + "\" +app_update 304930 validate +exit";

                proc.StartInfo = startInfo;
                proc.Start();
                proc.WaitForExit();

                var local = LocalVersions.Load();
                local.UnturnedVersion = UnturnedBuild.Value;
                local.SaveJson();
            }
            catch { }
        }

        /// <summary>
        /// Downloads and installs RocketMod to the specified directory.
        /// </summary>
        /// <param name="directory">Sets the specified directory that RocketMod will be installed to.</param>
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

        public static void UpdateAll()
        {
            UpdateUnturned();
            UpdateRocket();
        }
    }
}
