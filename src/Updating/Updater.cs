using System.IO;
using ATORTTeam.UnturnedServerManager.Configuration;
using ATORTTeam.UnturnedServerManager.Constants;
using ATORTTeam.UnturnedServerManager.File_Control;
using ATORTTeam.UnturnedServerManager.SteamCMD_Manager;
using ATORTTeam.UnturnedServerManager.Versions;

namespace ATORTTeam.UnturnedServerManager.Updating
{
    internal static class Updater
    {
        /// <summary>
        ///     Installs the latest version of Unturned.
        /// </summary>
        public static void UpdateUnturned()
        {
            SteamCmd.RunCommand($"+force_install_dir \"{RocketModServerPath.Value}\" +app_update 304930 +exit");

            var installedVersions = LocalVersions.Load();
            installedVersions.UnturnedVersion = UnturnedBuild.Value;
            installedVersions.SaveJson();
        }

        /// <summary>
        ///     Validates and Installs the latest version of Unturned.
        /// </summary>
        public static void ValidateUnturned()
        {
            SteamCmd.RunCommand(
                $"+force_install_dir \"{RocketModServerPath.Value}\" +app_update 304930 validate +exit");

            var installedVersions = LocalVersions.Load();
            installedVersions.UnturnedVersion = UnturnedBuild.Value;
            installedVersions.SaveJson();
        }

        /// <summary>
        ///     Downloads and installs RocketMod.
        /// </summary>
        public static void UpdateRocket()
        {
            var tempZip = Path.Combine(Path.GetTempPath(), Path.GetTempFileName());

            FileActions.Download(RocketUpdate.Value, tempZip);
            FileActions.ExtractZip(tempZip, RocketModServerPath.Value);

            var local = LocalVersions.Load();
            local.RocketModVersion = RocketBuild.Value;
            local.SaveJson();
        }

        /// <summary>
        ///     Downloads and installs RocketMod + Unturned.
        /// </summary>
        public static void UpdateAll()
        {
            UpdateUnturned();
            UpdateRocket();
        }
    }
}