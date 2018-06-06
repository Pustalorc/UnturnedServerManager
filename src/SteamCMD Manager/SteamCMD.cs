using ATORTTeam.UnturnedServerManager.Configuration;
using ATORTTeam.UnturnedServerManager.FileControl;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace ATORTTeam.UnturnedServerManager.SteamCMDManager
{
    public static class SteamCMD
    {
        internal static string Username = "";
        internal static string Password = "";

        /// <summary>
        /// Link to official steam download for SteamCMD.
        /// </summary>
        public static string DownloadLink => "https://steamcdn-a.akamaihd.net/client/installer/steamcmd.zip";

        /// <summary>
        /// Runs a command directly into SteamCMD.
        /// </summary>
        /// <param name="Command">The command to be run by SteamCMD. Must be a string such as if you were running steamcmd.exe from console yourself excluding username + password.</param>
        public static void RunCommand(string Command)
        {
            var login = new GUI.SteamLogin();
            var inst = Installation.Load();
            var steamcmdexe = Path.Combine(inst.InstallationPath, "steamcmd.exe");

            Process proc = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = steamcmdexe;

            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                login.ShowDialog();

                if (string.IsNullOrEmpty(login.Username.Text) || string.IsNullOrEmpty(login.Password.Text))
                    return;

                startInfo.Arguments = $" +login {login.Username.Text} {login.Password.Text} {Command}";
            }
            else
                startInfo.Arguments = $" +login {Username} {Password} {Command}";

            proc.StartInfo = startInfo;
            proc.Start();
            proc.WaitForExit();
        }

        /// <summary>
        /// Moves a downloaded workshop folder.
        /// </summary>
        /// <param name="ID">The ID of the workshop folder.</param>
        /// <param name="DirectoryDestination">The destination for the workshop folder.</param>
        public static void MoveWorkshopFolder(string ID, string DirectoryDestination)
        {
            var inst = Installation.Load();
            var workshopdir = Path.Combine(inst.InstallationPath, $@"\steamapps\workshop\content\304930\{ID}");
            var MapMeta = Path.Combine(workshopdir, "Map.meta");
            var MapsDir = Path.Combine(DirectoryDestination, "Maps");
            var ContentDir = Path.Combine(DirectoryDestination, "Content");

            if (FileActions.VerifyFile(MapMeta))
                FileActions.CopyDirectory(workshopdir, MapsDir);
            else
                FileActions.CopyDirectory(workshopdir, ContentDir);
        }

        private static void VerifySteam()
        {
            var inst = Installation.Load();
            var steamcmdexe = Path.Combine(inst.InstallationPath, "steamcmd.exe");

            try
            {
                if (!FileActions.VerifyFile(steamcmdexe))
                {
                    var ZipTarget = Path.Combine(Path.GetTempPath(), Path.GetTempFileName());
                    FileActions.Download(DownloadLink, ZipTarget);
                    FileActions.Extract(ZipTarget, inst.InstallationPath);
                }
            }
            catch { }
        }
    }
}
