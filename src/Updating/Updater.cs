using System;
using System.IO;
using System.Windows.Forms;
using Pustalorc.Applications.USM.Configuration;
using Pustalorc.Applications.USM.Constants;
using Pustalorc.Applications.USM.File_Control;
using Pustalorc.Applications.USM.SteamCMD_Manager;

namespace Pustalorc.Applications.USM.Updating
{
    internal static class Updater
    {
        /// <summary>
        ///     Installs the latest version of Unturned.
        /// </summary>
        public static void UpdateUnturned()
        {
            SteamCmd.RunCommand($"+force_install_dir \"{ServerPath.Value}\" +app_update 1110390 +exit");

            var installedVersions = LocalVersions.Load();
            installedVersions.LastUnturnedUpdate = DateTime.Now;
            installedVersions.SaveJson();
        }

        /// <summary>
        ///     Validates and Installs the latest version of Unturned.
        /// </summary>
        public static void ValidateUnturned()
        {
            SteamCmd.RunCommand(
                $"+force_install_dir \"{ServerPath.Value}\" +app_update 1110390 validate +exit");

            var installedVersions = LocalVersions.Load();
            installedVersions.LastUnturnedUpdate = DateTime.Now;
            installedVersions.SaveJson();
        }

        /// <summary>
        ///     Downloads and installs RocketMod.
        /// </summary>
        public static void UpdateRocket()
        {
            var tempZip = Path.Combine(Path.GetTempPath(), Path.GetTempFileName());

            if (!FileActions.Download(RocketDownloadUrl.Value, tempZip))
            {
                MessageBox.Show(
                    "An error occured during download. Please verify that you can access github.",
                    "Rocketmod download failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FileActions.ExtractZip(tempZip, ServerPath.Value);
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