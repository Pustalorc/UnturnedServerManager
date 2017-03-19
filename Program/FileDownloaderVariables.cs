using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USM
{
    class FileDownloaderVariables
    {
        public static string Download = null;
        public const string RocketDownload = "https://ci.rocketmod.net/job/Rocket.Unturned/lastSuccessfulBuild/artifact/Rocket.Unturned/bin/Release/Rocket.zip";
        public const string PIDownload = "https://github.com/persiafighter/UnturnedServerManager/raw/master/Data/PluginData.zip";
        public const string USMVersionData = "https://github.com/persiafighter/UnturnedServerManager/raw/master/Data/USMVer.dat";
        public const string RocketVersionData = "https://github.com/persiafighter/UnturnedServerManager/raw/master/Data/RocVer.dat";
        public const string PIVersionData = "https://github.com/persiafighter/UnturnedServerManager/raw/master/Data/PIVer.dat";
        public const string UnturnedVersionData = "https://github.com/persiafighter/UnturnedServerManager/raw/master/Data/UntVer.dat";
        public const string SteamDownload = "https://steamcdn-a.akamaihd.net/client/installer/steamcmd.zip";
        public const string RocketFinalName = "Rocket.zip";
        public const string PIFinalName = "PluginIntegrity.zip";
        public const string VersionFinalName = "Versions.dat";
        public const string SteamFinalName = "Steam.zip";
        public static bool Error = false;
    }
}
