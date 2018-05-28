#pragma warning disable CS0168
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        public const string RocketDownload = "https://ci.rocketmod.net/job/Rocket.Unturned/lastSuccessfulBuild/artifact/Rocket.Unturned/bin/Release/Rocket.zip";
        public const string PluginDownload = "https://github.com/persiafighter/UnturnedServerManager/raw/master/Data/Plugins.zip";
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
                if (Directory.Exists(Dest) == false)
                {
                    Directory.CreateDirectory(Dest);
                }
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

        public static bool MoveDirectory(string Name, string Dest)
        {
            try
            {
                Directory.Move(Name, Dest);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool MoveDirectoryItems(string DirName, string Dest)
        {
            try
            {
                DirectoryInfo Directory = new DirectoryInfo(DirName);
                Logger.Log("DirectoryInfo was set.");
                FileInfo[] Files = Directory.GetFiles();
                Logger.Log("FileInfo[] was set.");
                DirectoryInfo[] Folders = Directory.GetDirectories();
                Logger.Log("DirectoryInfo[] was set.");
                foreach (FileInfo s in Files)
                {
                    try
                    {
                        File.Move(s.FullName, Dest + "\\" + s.Name);
                    }
                    catch (Exception)
                    {
                        Logger.Log("Error occured during the file loop.");
                        return false;
                    }
                }
                foreach (DirectoryInfo s in Folders)
                {
                    try
                    {
                        System.IO.Directory.Move(s.FullName, Dest + "\\" + s.Name);
                    }
                    catch (Exception)
                    {
                        Logger.Log("Error occured during the folder loop.");
                        return false;
                    }
                }
                return true;
            }
            catch (Exception)
            {
                Logger.Log("Error occured before any loops could load.");
                return false;
            }
        }

        public static bool DownloadUnturned()
        {
            if (Directory.Exists(Comms.DataPath + "SteamCMD") == false)
            {
                Directory.CreateDirectory(Comms.DataPath + "SteamCMD");
            }
            try
            {
                if (File.Exists(Comms.DataPath + @"SteamCMD\steamcmd.exe") == false)
                {
                    Download("https://steamcdn-a.akamaihd.net/client/installer/steamcmd.zip", "steamcmd.zip");
                    Extract("steamcmd.zip", Comms.DataPath + @"SteamCMD\");
                }
                Process SteamCMD = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = Comms.DataPath + @"SteamCMD\steamcmd.exe";
                startInfo.Arguments = " +login unturnedrocksupdate force_update +force_install_dir \"" + Comms.UnturnedPath + "\" +app_update 304930 validate +exit";
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

        public static void CopyDirectory(string Source, string Destination, bool Subdirectories)
        {
            DirectoryInfo dir = new DirectoryInfo(Source);
            DirectoryInfo[] dirs = dir.GetDirectories();

            if (!Directory.Exists(Destination))
            {
                Directory.CreateDirectory(Destination);
            }

            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                if (!File.Exists(Destination))
                {
                    //
                }
                else
                {
                    string temppath = Path.Combine(Destination, file.Name);
                    file.CopyTo(temppath, false);
                }
            }

            if (Subdirectories)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(Destination, subdir.Name);
                    CopyDirectory(subdir.FullName, temppath, Subdirectories);
                }
            }
        }

        public static bool PrepareIntegrityUpdate()
        {
            try
            {
                if (File.Exists(Comms.DataPath + "PluginLinks.dat"))
                {
                    File.Delete(Comms.DataPath + "PluginLinks.dat");
                }
                if (File.Exists(Comms.DataPath + "PluginNames.dat"))
                {
                    File.Delete(Comms.DataPath + "PluginNames.dat");
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
            bool SuccessDownload = DownloadUnturned();
            if (SuccessDownload == false)
            {
                return false;
            }
            return true;
        }

        public static bool InstallIntegrity()
        {
            bool SuccessDownload = Download(PluginDownload, "Plugins.zip");
            if (SuccessDownload == false)
            {
                return false;
            }

            bool SuccessPrepare = PrepareIntegrityUpdate();
            if (SuccessPrepare == false)
            {
                return false;
            }

            bool SuccessExtract = Extract("Plugins.zip", Comms.DataPath);
            if (SuccessExtract == false)
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
