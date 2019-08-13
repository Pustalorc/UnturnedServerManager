using System;
using System.IO;
using Newtonsoft.Json;

namespace Pustalorc.Applications.USM.Configuration
{
    /// <summary>
    /// Configuration for where to locate the server installation.
    /// </summary>
    public sealed class Installation
    {
        [JsonIgnore] private static string FilePath => @"config/Installation.json";

        public string InstallationPath { get; set; } = AppContext.BaseDirectory;

        public void SaveJson()
        {
            var file = Path.Combine(AppContext.BaseDirectory, FilePath);
            File.WriteAllText(file, ToJson());

            if (!Directory.Exists(InstallationPath))
                Directory.CreateDirectory(InstallationPath);
        }

        private string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        private static void EnsureExists()
        {
            var file = Path.Combine(AppContext.BaseDirectory, FilePath);
            if (File.Exists(file)) return;

            var path = Path.GetDirectoryName(file);
            if (!Directory.Exists(path))
                if (path != null)
                    Directory.CreateDirectory(path);

            var config = new Installation();
            config.SaveJson();
        }

        public static Installation Load()
        {
            var file = Path.Combine(AppContext.BaseDirectory, FilePath);

            EnsureExists();

            return JsonConvert.DeserializeObject<Installation>(File.ReadAllText(file));
        }

        public static bool Exists()
        {
            var file = Path.Combine(AppContext.BaseDirectory, FilePath);
            return File.Exists(file);
        }
    }
}