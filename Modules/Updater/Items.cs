using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;

namespace Updater
{
    static public class Items
    {
        public static bool Rocket(string dir)
        {
            try
            {
                string ZipTarget = dir + "\\Rocket_Latest.zip";
                string RocTarget = dir + "\\Modules\\Rocket.Unturned";
                string ScrTarget = dir + "\\Scripts";
                if (Directory.Exists(Path.GetFullPath(RocTarget)))
                {
                    Directory.Delete(Path.GetFullPath(RocTarget), true);
                }
                if (Directory.Exists(Path.GetFullPath(ScrTarget)))
                {
                    Directory.Delete(Path.GetFullPath(ScrTarget), true);
                }
                ZipFile.ExtractToDirectory(Path.GetFullPath(ZipTarget), Path.GetFullPath(dir));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Unturned(string dir)
        {
            try
            {
                string ExeTarget = dir + "\\SteamCMD\\steamcmd.exe";
                if (!File.Exists(Path.GetFullPath(ExeTarget)))
                {
                    return false;
                }
                string UntTarget = Path.GetFullPath(dir);
                Process SteamCMD = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = Path.GetFullPath(ExeTarget);
                startInfo.Arguments = " +login unturnedrocksupdate force_update +force_install_dir \"" + UntTarget + "\" +app_update 304930 +exit";
                SteamCMD.StartInfo = startInfo;
                SteamCMD.Start();
                SteamCMD.WaitForExit();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
