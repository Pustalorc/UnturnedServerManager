using ATORTTeam.UnturnedServerManager.Updating;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace ATORTTeam.UnturnedServerManager.Configuration
{
    public class Installation
    {
        [JsonIgnore]
        private static string FilePath => @"config\Installation.json";

        public string InstallationPath { get; set; } = AppContext.BaseDirectory;

        public void SaveJson()
        {
            string file = Path.Combine(AppContext.BaseDirectory, FilePath);
            File.WriteAllText(file, ToJson());

            if (!Directory.Exists(InstallationPath))
                Directory.CreateDirectory(InstallationPath);
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

                var config = new Installation();
                config.SaveJson();
            }
        }
        public static Installation Load()
        {
            string file = Path.Combine(AppContext.BaseDirectory, FilePath);

            EnsureExists();

            return JsonConvert.DeserializeObject<Installation>(File.ReadAllText(file));
        }
        public static bool Exists()
        {
            string file = Path.Combine(AppContext.BaseDirectory, FilePath);
            return File.Exists(file);
        }
    }
}
