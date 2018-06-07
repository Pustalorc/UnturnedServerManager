using Newtonsoft.Json;
using System;
using System.IO;

namespace ATORTTeam.UnturnedServerManager.Configuration
{
    public class LocalVersions
    {
        [JsonIgnore]
        private static string FilePath => @"config\Versions.json";

        public string UnturnedVersion { get; set; } = "N/A";
        public string RocketModVersion { get; set; } = "N/A";
        
        public void SaveJson()
        {
            string file = Path.Combine(AppContext.BaseDirectory, FilePath);
            File.WriteAllText(file, ToJson());
        }
        public string ToJson()
            => JsonConvert.SerializeObject(this, Formatting.Indented);
        private static void EnsureExists()
        {
            string file = Path.Combine(AppContext.BaseDirectory, FilePath);
            if (!File.Exists(file))
            {
                string path = Path.GetDirectoryName(file);
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                var config = new LocalVersions();
                config.SaveJson();
            }
        }
        public static LocalVersions Load()
        {
            string file = Path.Combine(AppContext.BaseDirectory, FilePath);

            EnsureExists();

            return JsonConvert.DeserializeObject<LocalVersions>(File.ReadAllText(file));
        }
    }
}
