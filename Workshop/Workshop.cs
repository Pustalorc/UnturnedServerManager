using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnturnedServerManager
{
    public enum WorkshopResults { NO_STEAM, SUCCESS, UNKNOWN, FAILED_COPY, FAILED_DELETE, NOT_FOUND }

    public class Workshop
    {
        public WorkshopResults DownloadWorkshopItem(uint WorkshopID, string dir)
        {
            string ExeTarget = dir + "\\SteamCMD\\steamcmd.exe";
            try
            {
                if (!File.Exists(Path.GetFullPath(ExeTarget)))
                {
                    return WorkshopResults.NO_STEAM;
                }
                Process SteamCMD = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = Path.GetFullPath(ExeTarget);
                startInfo.Arguments = " +login unturnedrocksupdate force_update +workshop_download_item 304930 " + WorkshopID + " +quit";
                SteamCMD.StartInfo = startInfo;
                SteamCMD.Start();
                SteamCMD.WaitForExit();
                return WorkshopResults.SUCCESS;
            }
            catch (Exception)
            {
                return WorkshopResults.UNKNOWN;
            }
        }

        public WorkshopResults DeleteWorkshopItemFromServer(uint WorkshopID, string ServDir)
        {
            try
            {
                string Target = ServDir + "\\" + WorkshopID;
                if (Directory.Exists(Path.GetFullPath(Target)))
                {
                    Directory.Delete(Target, true);
                    return WorkshopResults.SUCCESS;
                }
                else
                {
                    return WorkshopResults.NOT_FOUND;
                }
            }
            catch (Exception)
            {
                return WorkshopResults.FAILED_DELETE;
            }
        }

        public WorkshopResults CopyWorkshopItemToServer(uint WorkshopID, string dir, string TargetDir)
        {
            string Target = dir + "\\SteamCMD\\steamapps\\workshop\\content\\304930\\" + WorkshopID;
            string TDir = TargetDir + "\\" + WorkshopID;
            try
            {
                CopyDirectory(Path.GetFullPath(Target), Path.GetFullPath(TDir), true);
                return WorkshopResults.SUCCESS;
            }
            catch (Exception)
            {
                return WorkshopResults.FAILED_COPY;
            }
        }

        private void CopyDirectory(string Source, string Destination, bool Subdirectories)
        {
            DirectoryInfo dir = new DirectoryInfo(Source);
            DirectoryInfo[] dirs = dir.GetDirectories();
            if (Directory.Exists(Destination) == false)
            {
                Directory.CreateDirectory(Destination);
            }

            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(Destination, file.Name);
                if (File.Exists(temppath) == false)
                {
                    file.CopyTo(temppath, false);
                }
                else if (File.Exists(temppath) == true)
                {
                    file.CopyTo(temppath, true);
                }
            }

            if (Subdirectories == true)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(Destination, subdir.Name);
                    CopyDirectory(subdir.FullName, temppath, Subdirectories);
                }
            }
        }
    }
}
