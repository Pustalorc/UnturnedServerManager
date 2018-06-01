using System.IO;
using System.IO.Compression;
using System.Net;

namespace ATORTTeam.UnturnedServerManager.FileControl
{
    public static class FileActions
    {
        public static bool Download(string URL, string Destination)
        {
            try
            {
                using (var client = new WebClient())
                {
                    client.DownloadFile(URL, Destination);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool Extract(string Zip, string Destination)
        {
            try
            {
                VerifyPath(Destination);

                if (!VerifyFile(Zip))
                    return false;

                foreach (ZipArchiveEntry Entry in new ZipArchive(File.OpenRead(Zip)).Entries)
                {
                    try
                    {
                        string dir = Path.GetFullPath(Path.Combine(Destination, Entry.FullName));

                        if (!Directory.Exists(Path.GetDirectoryName(dir)))
                            Directory.CreateDirectory(dir);

                        if (Entry.Name != "")
                            Entry.ExtractToFile(Path.GetFullPath(Path.Combine(Destination, Entry.FullName)), true);
                    }
                    catch { }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool VerifyFile(string Path) => File.Exists(Path);
        public static bool VerifyFilePath(string File) => VerifyPath(Path.GetDirectoryName(File));
        public static bool VerifyPath(string Folder)
        {
            if (!Directory.Exists(Folder))
            {
                Directory.CreateDirectory(Folder);
                return false;
            }
            else
                return true;
        }
        public static void DeleteDirectory(string Folder)
        {
            VerifyPath(Folder);
            try
            {
                Directory.Delete(Folder, true);
            }
            catch { }
        }
        public static void CopyDirectory(string Folder, string Destination)
        {
            foreach (string dirPath in Directory.GetDirectories(Folder, "*", SearchOption.AllDirectories))
                Directory.CreateDirectory(dirPath.Replace(Folder, Destination));
            
            foreach (string newPath in Directory.GetFiles(Folder, "*.*", SearchOption.AllDirectories))
                File.Copy(newPath, newPath.Replace(Folder, Destination), true);
        }
    }
}
