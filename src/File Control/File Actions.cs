using System.IO;
using System.IO.Compression;
using System.Net;

namespace ATORTTeam.UnturnedServerManager.FileControl
{
    public static class FileActions
    {
        /// <summary>
        /// Downloads a file into the destination folder.
        /// </summary>
        /// <param name="URL">Uniform Resource Locator for the file.</param>
        /// <param name="Destination">Full path to destination including desired filename.</param>
        /// <returns>True if no exceptions occur during download, false otherwise.</returns>
        public static bool Download(string URL, string Destination)
        {
            VerifyPath(Destination, true);

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

        /// <summary>
        /// Extracts all the contents of a .Zip file to its destination, overwriting the files if necessary.
        /// </summary>
        /// <param name="Zip">The full path to the zip file, filename and extension included.</param>
        /// <param name="Destination">The destination folder for all the contents of the .Zip file to be extracted to.</param>
        /// <returns>False if the file doesn't exist or if an issue occurs during the entire process of extraction (Ignoring issues when overwriting individual files). Returns true otherwise.</returns>
        public static bool Extract(string Zip, string Destination)
        {
            try
            {
                VerifyPath(Destination, true);

                if (!VerifyFile(Zip))
                    return false;

                foreach (ZipArchiveEntry Entry in new ZipArchive(File.OpenRead(Zip)).Entries)
                {
                    try
                    {
                        string dir = Path.GetFullPath(Path.Combine(Destination, Entry.FullName));

                        VerifyFilePath(dir, true);

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
        public static bool VerifyFilePath(string File, bool Create) => VerifyPath(Path.GetDirectoryName(File), Create);
        public static bool VerifyPath(string Folder, bool Create)
        {
            if (!Directory.Exists(Folder))
            {
                if (Create)
                    Directory.CreateDirectory(Folder);

                return false;
            }
            else
                return true;
        }
        public static void DeleteDirectory(string Folder)
        {
            if (VerifyPath(Folder, false))
            {
                try
                {
                    Directory.Delete(Folder, true);
                }
                catch { }
            }
        }
        public static void CopyDirectory(string Folder, string Destination)
        {
            if (VerifyPath(Folder, false))
            {
                VerifyPath(Destination, true);
                foreach (string dirPath in Directory.GetDirectories(Folder, "*", SearchOption.AllDirectories))
                    Directory.CreateDirectory(dirPath.Replace(Folder, Destination));

                foreach (string newPath in Directory.GetFiles(Folder, "*.*", SearchOption.AllDirectories))
                    File.Copy(newPath, newPath.Replace(Folder, Destination), true);
            }
        }
    }
}
