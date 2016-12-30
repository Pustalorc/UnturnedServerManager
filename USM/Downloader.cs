#pragma warning disable CS0168
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace USM
{
    static class Downloader
    {
        public const string Temp = @"C:\Unturned_Manager\TempDownload";
        public const string RocketDownload = "https://github.com/persiafighter/UnturnedServerManager/raw/master/Data/Rocket_Latest.zip";
        public const string VersionsDownload = "https://github.com/persiafighter/UnturnedServerManager/raw/master/Data/Versions.dat";
        public const string PluginList1 = "https://github.com/persiafighter/UnturnedServerManager/raw/master/Data/Plugins.dat";
        public const string PluginList2 = "https://github.com/persiafighter/UnturnedServerManager/raw/master/Data/PluginsDl.dat";
        public const string PluginList3 = "https://github.com/persiafighter/UnturnedServerManager/raw/master/Data/PluginsPage.dat";
        public static string Translation;
        public static string Icon;
        public static string License;
        public static string Readme;
        public static string RAPI;
        public static string RCore;
        public static string RUnturned;
        public static string Module;
        public static string ScriptsFolder;

        public static void GetReady()
        {
            if (Directory.Exists(Temp) == false)
            {
                Directory.CreateDirectory(Temp);
            }
        }

        public static bool Download(string URL, string FinalName)
        {
            try
            {
                using (var client = new WebClient())
                {
                    client.DownloadFile(URL, Temp + "\\" + FinalName);
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static bool Extract(string Name, string Dest)
        {
            try
            {
                ZipFile.ExtractToDirectory(Temp + "\\" + Name, Dest);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static bool MoveFiles(string Name, string Dest)
        {
            try
            {
                File.Move(Temp + "\\" + Name, Dest);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static bool PrepareRocketInstall()
        {
            try
            {
                if (File.Exists(Translation) == true)
                {
                    File.Delete(Translation);
                }
                if (File.Exists(Icon) == true)
                {
                    File.Delete(Icon);
                }
                if (File.Exists(License) == true)
                {
                    File.Delete(License);
                }
                if (File.Exists(Readme) == true)
                {
                    File.Delete(Readme);
                }
                if (File.Exists(RAPI) == true)
                {
                    File.Delete(RAPI);
                }
                if (File.Exists(RCore) == true)
                {
                    File.Delete(RCore);
                }
                if (File.Exists(RUnturned) == true)
                {
                    File.Delete(RUnturned);
                }
                if (File.Exists(Module) == true)
                {
                    File.Delete(Module);
                }
                if (Directory.Exists(ScriptsFolder) == true)
                {
                    Directory.Delete(ScriptsFolder, true);
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        
        public static bool PrepareUnturnedInstall()
        {
            try
            {
                if (Directory.Exists(Comms.UnturnedPath) == true)
                {
                    Directory.Delete(Comms.UnturnedPath, true);
                }
                Directory.CreateDirectory(Comms.UnturnedPath);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static bool PrepareIntegrityUpdate()
        {
            try
            {
                if (File.Exists(Comms.DataPath + "Plugins.dat"))
                {
                    File.Delete(Comms.DataPath + "Plugins.dat");
                }
                if (File.Exists(Comms.DataPath + "PluginLinks.dat"))
                {
                    File.Delete(Comms.DataPath + "PluginLinks.dat");
                }
                if (File.Exists(Comms.DataPath + "PluginPages.dat"))
                {
                    File.Delete(Comms.DataPath + "PluginPages.dat");
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static bool InstallRocket()
        {
            Translation = @"" + Comms.UnturnedPath + @"\Modules\Rocket.Unturned\English.dat";
            Icon = @"" + Comms.UnturnedPath + @"\Modules\Rocket.Unturned\Icon.png";
            License = @"" + Comms.UnturnedPath + @"\Modules\Rocket.Unturned\LICENSE";
            Readme = @"" + Comms.UnturnedPath + @"\Modules\Rocket.Unturned\README";
            RAPI = @"" + Comms.UnturnedPath + @"\Modules\Rocket.Unturned\Rocket.API.dll";
            RCore = @"" + Comms.UnturnedPath + @"\Modules\Rocket.Unturned\Rocket.Core.dll";
            RUnturned = @"" + Comms.UnturnedPath + @"\Modules\Rocket.Unturned\Rocket.Unturned.dll";
            Module = @"" + Comms.UnturnedPath + @"\Modules\Rocket.Unturned\Rocket.Unturned.module";
            ScriptsFolder = @"" + Comms.UnturnedPath + @"\Scripts";

            bool SuccessDownload = Download(RocketDownload, "Rocket.zip");
            if (SuccessDownload == false)
            {
                return false;
            }

            bool SuccessFolderPrepare = PrepareRocketInstall();
            if (SuccessDownload == false)
            {
                return false;
            }

            bool SuccessExtract = Extract("Rocket.zip", Comms.UnturnedPath);
            if (SuccessExtract == false)
            {
                return false;
            }
            return true;
        }

        public static bool InstallUnturned()
        {
            // Use steam cmd to download unturned locally
            /*if (SuccessDownload == false)
            {
                return false;
            }*/

            bool SuccessPrepare = PrepareUnturnedInstall();
            if (SuccessPrepare == false)
            {
                return false;
            }

            bool SuccessExtract = Extract("Unturned.zip", Comms.UnturnedPath);
            if (SuccessExtract == false)
            {
                return false;
            }
            return true;
        }

        public static bool InstallIntegrity()
        {
            bool SuccessDownload1 = Download(PluginList1, "Plugins.dat");
            if (SuccessDownload1 == false)
            {
                return false;
            }

            bool SuccessDownload2 = Download(PluginList2, "PluginLinks.dat");
            if (SuccessDownload2 == false)
            {
                return false;
            }

            bool SuccessDownload3 = Download(PluginList3, "PluginsPages.dat");
            if (SuccessDownload3 == false)
            {
                return false;
            }

            bool SuccessPrepare = PrepareIntegrityUpdate();
            if (SuccessPrepare == false)
            {
                return false;
            }

            bool SuccessMove1 = MoveFiles("Plugins.dat", Comms.DataPath + "Plugins.dat");
            if (SuccessMove1 == false)
            {
                return false;
            }

            bool SuccessMove2 = MoveFiles("PluginLinks.dat", Comms.DataPath + "PluginLinks.dat");
            if (SuccessMove2 == false)
            {
                return false;
            }

            bool SuccessMove3 = MoveFiles("PluginsPages.dat", Comms.DataPath + "PluginsPages.dat");
            if (SuccessMove3 == false)
            {
                return false;
            }
            return true;
        }

        public static void ShutOff()
        {
            if (Directory.Exists(Temp) == true)
            {
                Directory.Delete(Temp, true);
            }
        }
    }
}
