#pragma warning disable CS0168
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USM
{
    static class Downloader
    {
        public const string Temp = @"C:\Unturned_Manager\TempDownload";
        public const string RocketDownload = "https://github.com/persiafighter/UnturnedServerManager/raw/master/Data/Rocket_Latest.zip";
        public const string PluginList1 = "https://github.com/persiafighter/UnturnedServerManager/raw/master/Data/Plugins.dat";
        public const string PluginList2 = "https://github.com/persiafighter/UnturnedServerManager/raw/master/Data/PluginsDl.dat";
        public const string PluginList3 = "https://github.com/persiafighter/UnturnedServerManager/raw/master/Data/PluginsPage.dat";
        public static string RocketFolder;
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
                if (Directory.Exists(RocketFolder) == true)
                {
                    Directory.Delete(RocketFolder, true);
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
            RocketFolder = @"" + Comms.UnturnedPath + @"\Modules\Rocket.Unturned";
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

            bool SuccessExtract = Extract("Rocket.zip", Temp);
            if (SuccessExtract == false)
            {
                return false;
            }

            int Strikes = 0;
            try
            {
                Directory.Move(Temp + @"\Modules\Rocket.Unturned", Comms.UnturnedPath + @"\Modules\Rocket.Unturned");
            }
            catch(Exception)
            {
                Strikes += 1;
            }
            try
            {
                Directory.Move(Temp + @"\Scripts", Comms.UnturnedPath + @"\Scripts");
            }
            catch(Exception)
            {
                Strikes += 1;
            }
            if (Strikes > 0)
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

            bool SuccessDownload3 = Download(PluginList3, "PluginPages.dat");
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

            bool SuccessMove3 = MoveFiles("PluginPages.dat", Comms.DataPath + "PluginPages.dat");
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
