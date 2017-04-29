using System;
using System.IO;
using System.IO.Compression;
using System.Net;

namespace Downloader
{
    public static class Items
    {
        public static bool SteamCMD(string dir)
        {
            string DirTarget = dir;
            string ExeTarget = dir + "\\steamcmd.exe";
            string ZipTarget = dir + "\\steamcmd.zip";
            if (!Directory.Exists(Path.GetFullPath(DirTarget)))
            {
                Directory.CreateDirectory(Path.GetFullPath(DirTarget));
            }
            if (!File.Exists(Path.GetFullPath(ExeTarget)))
            {
                using (var client = new WebClient())
                {
                    client.DownloadFile("https://steamcdn-a.akamaihd.net/client/installer/steamcmd.zip", Path.GetFullPath(ZipTarget));
                }
                ZipFile.ExtractToDirectory(Path.GetFullPath(ZipTarget), Path.GetFullPath(DirTarget));
            }
            return false;
        }

        public static bool Rocket(string ZipTarget)
        {
            try
            {
                using (var client = new WebClient())
                {
                    client.DownloadFile("https://ci.rocketmod.net/job/Rocket.Unturned/lastSuccessfulBuild/artifact/Rocket.Unturned/bin/Release/Rocket.zip", Path.GetFullPath(ZipTarget));
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
