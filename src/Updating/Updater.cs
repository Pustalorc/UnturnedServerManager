using ATORTTeam.UnturnedServerManager.Configuration;
using ATORTTeam.UnturnedServerManager.Constants;
using ATORTTeam.UnturnedServerManager.FileControl;
using ATORTTeam.UnturnedServerManager.SteamCMDManager;
using ATORTTeam.UnturnedServerManager.Versions;
using System.IO;

namespace ATORTTeam.UnturnedServerManager.Updating
{
    public static class Updater
    {
        /// <summary>
        /// Installs the latest version of Unturned.
        /// </summary>
        public static void UpdateUnturned()
        {
            SteamCMD.RunCommand($"+force_install_dir \"{RocketmodServerPath.Value}\" +app_update 304930 +exit");
            SteamCMD.RunCommand($"+force_install_dir \"{VanillaServerPath.Value}\" +app_update 304930 +exit");

            var InstalledVersions = LocalVersions.Load();
            InstalledVersions.UnturnedVersion = UnturnedBuild.Value;
            InstalledVersions.SaveJson();
        }

        /// <summary>
        /// Validates and Installs the latest version of Unturned.
        /// </summary>
        public static void ValidateUnturned()
        {
            SteamCMD.RunCommand($"+force_install_dir \"{RocketmodServerPath.Value}\" +app_update 304930 validate +exit");
            SteamCMD.RunCommand($"+force_install_dir \"{VanillaServerPath.Value}\" +app_update 304930 validate +exit");

            var InstalledVersions = LocalVersions.Load();
            InstalledVersions.UnturnedVersion = UnturnedBuild.Value;
            InstalledVersions.SaveJson();
        }

        /// <summary>
        /// Downloads and installs RocketMod.
        /// </summary>
        public static void UpdateRocket()
        {
            var tempzip = Path.Combine(Path.GetTempPath(), Path.GetTempFileName());

            FileActions.Download(RocketUpdate.Value, tempzip);
            FileActions.ExtractZip(tempzip, RocketmodServerPath.Value);

            var local = LocalVersions.Load();
            local.RocketModVersion = RocketBuild.Value;
            local.SaveJson();
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
