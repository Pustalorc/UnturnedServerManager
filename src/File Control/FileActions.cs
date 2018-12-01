using System.IO;
using System.IO.Compression;
using System.Net;

namespace ATORTTeam.UnturnedServerManager.File_Control
{
    internal static class FileActions
    {
        /// <summary>
        ///     Downloads a file into the destination folder.
        /// </summary>
        /// <param name="url">Uniform Resource Locator for the file.</param>
        /// <param name="destination">Full path to destination including desired filename.</param>
        /// <returns>True if no exceptions occur during download, false otherwise.</returns>
        public static void Download(string url, string destination)
        {
            VerifyFilePath(destination, true);

            if (VerifyFile(destination))
                File.Delete(destination);

            try
            {
                using (var client = new WebClient())
                {
                    client.DownloadFile(url, destination);
                }
            }
            catch
            {
                // Ignores any exceptions when downloading the file.
            }
        }

        /// <summary>
        ///     Verifies that the file exists.
        /// </summary>
        /// <param name="path">Full path, including file name, to the file.</param>
        /// <returns>True if the file exists, false otherwise.</returns>
        public static bool VerifyFile(string path)
        {
            return File.Exists(path);
        }

        /// <summary>
        ///     Verifies that the directory in which a file is at exists.
        /// </summary>
        /// <param name="file">The full path, including file name, to the file.</param>
        /// <param name="create">If the directory should be created if it doesn't exist.</param>
        /// <returns>True if directory existed from before, false otherwise.</returns>
        public static void VerifyFilePath(string file, bool create)
        {
            VerifyPath(Path.GetDirectoryName(file), create);
        }

        /// <summary>
        ///     Verifies a path for a valid directory.
        /// </summary>
        /// <param name="folder">The full path to a specific folder.</param>
        /// <param name="create">If the directory should be created if it doesn't exist.</param>
        /// <returns>True if directory existed prior to the method calling, false otherwise.</returns>
        public static bool VerifyPath(string folder, bool create)
        {
            if (Directory.Exists(folder)) return true;

            if (create)
                Directory.CreateDirectory(folder);

            return false;
        }

        /// <summary>
        ///     Deletes an entire directory, recursively.
        /// </summary>
        /// <param name="folder">The full path to a specific folder.</param>
        public static void DeleteDirectory(string folder)
        {
            if (!VerifyPath(folder, false)) return;

            try
            {
                Directory.Delete(folder, true);
            }
            catch
            {
                // Prevents any exceptions when deleting the folder from crashing the application.
            }
        }

        /// <summary>
        ///     Copies an entire directory recursively, verifying that everything exists.
        /// </summary>
        /// <param name="folder">The full path to the target directory to copy.</param>
        /// <param name="destination">The full path to the destination directory.</param>
        public static void CopyDirectory(string folder, string destination)
        {
            if (!VerifyPath(folder, false)) return;

            VerifyPath(destination, true);
            foreach (var dirPath in Directory.GetDirectories(folder, "*", SearchOption.AllDirectories))
                Directory.CreateDirectory(dirPath.Replace(folder, destination));

            foreach (var newPath in Directory.GetFiles(folder, "*.*", SearchOption.AllDirectories))
                File.Copy(newPath, newPath.Replace(folder, destination), true);
        }

        /// <summary>
        ///     Extracts all the contents of a .Zip file into a specific folder.
        /// </summary>
        /// <param name="zipFile">The full path, including file name, to the .Zip file.</param>
        /// <param name="destination">The full path where the files should be extracted to.</param>
        public static void ExtractZip(string zipFile, string destination)
        {
            if (!VerifyFile(zipFile))
                return;

            VerifyPath(destination, true);

            foreach (var entry in new ZipArchive(File.OpenRead(zipFile)).Entries)
                try
                {
                    var dir = Path.GetFullPath(Path.Combine(destination, entry.FullName));

                    VerifyFilePath(dir, true);

                    if (entry.Name != "")
                        entry.ExtractToFile(dir, true);
                }
                catch
                {
                    // Prevents any exceptions when extracting from halting the extraction process.
                }
        }
    }
}