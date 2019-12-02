using System;
using System.IO;
using Newtonsoft.Json;

namespace Pustalorc.Applications.USM.Configuration
{
    /// <summary>
    /// Configuration to save the version or time that the last update was done for either one.
    /// </summary>
    public sealed class LocalVersions
    {
        [JsonIgnore] private static string FilePath => @"config/Versions.json";

        public DateTime LastUnturnedUpdate { get; set; } = DateTime.Now;

        public void SaveJson()
        {
            var file = Path.Combine(AppContext.BaseDirectory, FilePath);
            File.WriteAllText(file, ToJson());
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

            var config = new LocalVersions();
            config.SaveJson();
        }

        public static LocalVersions Load()
        {
            var file = Path.Combine(AppContext.BaseDirectory, FilePath);

            EnsureExists();

            return JsonConvert.DeserializeObject<LocalVersions>(File.ReadAllText(file));
        }
    }
}