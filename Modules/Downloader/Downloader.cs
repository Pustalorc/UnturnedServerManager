using System;
using System.IO;
using System.IO.Compression;
using System.Net;

namespace UnturnedServerManager
{
    public enum DownloaderResults { SUCCESS, ERROR }

    public class Downloader
    {
        public DownloaderResults SteamCMD(string dir)
        {
            string DirTarget = dir;
            string ExeTarget = dir + "\\steamcmd.exe";
            string ZipTarget = dir + "\\steamcmd.zip";
            try
            {
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
                return DownloaderResults.SUCCESS;
            }
            catch (Exception)
            {
                return DownloaderResults.ERROR;
            }
        }

        public DownloaderResults Rocket(string ZipTarget)
        {
            try
            {
                using (var client = new WebClient())
                {
                    client.DownloadFile("https://ci.rocketmod.net/job/Rocket.Unturned/lastSuccessfulBuild/artifact/Rocket.Unturned/bin/Release/Rocket.zip", Path.GetFullPath(ZipTarget));
                }
                return DownloaderResults.SUCCESS;
            }
            catch (Exception)
            {
                return DownloaderResults.ERROR;
            }
        }
    }
}
