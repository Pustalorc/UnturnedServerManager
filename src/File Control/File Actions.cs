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
            VerifyFilePath(Destination, true);

            if (VerifyFile(Destination))
                File.Delete(Destination);

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
        /// Verifies that the file exists.
        /// </summary>
        /// <param name="Path">Full path, including file name, to the file.</param>
        /// <returns>True if the file exists, false otherwise.</returns>
        public static bool VerifyFile(string Path) => File.Exists(Path);

        /// <summary>
        /// Verifies that the directory in which a file is at exists.
        /// </summary>
        /// <param name="File">The full path, including file name, to the file.</param>
        /// <param name="Create">If the directory should be created if it doesn't exist.</param>
        /// <returns>True if directory existed from before, false otherwise.</returns>
        public static bool VerifyFilePath(string File, bool Create) => VerifyPath(Path.GetDirectoryName(File), Create);

        /// <summary>
        /// Verifies a path for a valid directory.
        /// </summary>
        /// <param name="Folder">The full path to a specific folder.</param>
        /// <param name="Create">If the directory should be created if it doesn't exist.</param>
        /// <returns>True if directory existed prior to the method calling, false otherwise.</returns>
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

        /// <summary>
        /// Deletes an entire directory, recursively.
        /// </summary>
        /// <param name="Folder">The full path to a specific folder.</param>
        public static void DeleteDirectory(string Folder)
        {
            if (VerifyPath(Folder, false))
            {
                try
                {
                    // Bug, if something is using resources in the directory, said resources are not deleted.
                    Directory.Delete(Folder, true);
                }
                catch { }
            }
        }

        /// <summary>
        /// Copies an entire directory recursively, verifying that everything exists.
        /// </summary>
        /// <param name="Folder">The full path to the target directory to copy.</param>
        /// <param name="Destination">The full path to the destination directory.</param>
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

        /// <summary>
        /// Extracts all the contents of a .Zip file into a specific folder.
        /// </summary>
        /// <param name="ZipFile">The full path, including file name, to the .Zip file.</param>
        /// <param name="Destination">The full path where the files should be extracted to.</param>
        public static void ExtractZip(string ZipFile, string Destination)
        {
            if (!VerifyFile(ZipFile))
                return;

            VerifyPath(Destination, true);

            foreach (ZipArchiveEntry Entry in new ZipArchive(File.OpenRead(ZipFile)).Entries)
            {
                try
                {
                    string dir = Path.GetFullPath(Path.Combine(Destination, Entry.FullName));

                    VerifyFilePath(dir, true);

                    if (Entry.Name != "")
                        Entry.ExtractToFile(dir, true);
                }
                catch { }
            }
        }
    }
}
