using System;
using System.IO;
using Newtonsoft.Json;

namespace ATORTTeam.UnturnedServerManager.Configuration
{
    public sealed class LocalVersions
    {
        [JsonIgnore] private static string FilePath => @"config\Versions.json";

        public string UnturnedVersion { get; set; } = "N/A";
        public string RocketModVersion { get; set; } = "N/A";

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