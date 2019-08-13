using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Pustalorc.Applications.USM.File_Control;

namespace Pustalorc.Applications.USM.Configuration
{
    /// <summary>
    /// Configuration in json of the server configuration.
    /// </summary>
    public sealed class GameConfiguration
    {
        [JsonIgnore] private static string _filePath;

        public string Bind { get; set; } = "0.0.0.0";
        public int ChatRate { get; set; } = 0;
        public bool Cheats { get; set; } = false;
        public int Cycle { get; set; } = 43200;
        public string Difficulty { get; set; } = "Normal";
        public bool Filter { get; set; } = false;
        public bool GoldMode { get; set; } = false;
        public bool HideAdmins { get; set; } = false;
        public string Loadout { get; set; } = "";
        public string LoginMessage { get; set; } = "";
        public string Map { get; set; } = "Washington";
        public int MaxPlayers { get; set; } = 24;
        public long Owner { get; set; } = 76561197960265728;
        public string Password { get; set; } = "";
        public string Perspective { get; set; } = "Both";
        public int Port { get; set; } = 27015;
        public string PublicName { get; set; } = "Test Server";
        public bool Pvp { get; set; } = true;
        public int QueueSize { get; set; } = 8;
        public bool Sync { get; set; } = false;

        public IEnumerable<string> ToNelson =>
            new List<string>
            {
                string.IsNullOrEmpty(Map) ? "" : "Map " + Map,
                string.IsNullOrEmpty(Bind) ? "" : "Bind " + Bind,
                string.IsNullOrEmpty(Password) ? "" : "Password " + Password,
                string.IsNullOrEmpty(Difficulty) ? "" : "Mode " + Difficulty,
                string.IsNullOrEmpty(PublicName) ? "" : "Name " + PublicName,
                string.IsNullOrEmpty(Loadout) ? "" : "Loadout 255/" + Loadout,
                string.IsNullOrEmpty(LoginMessage) ? "" : "Welcome " + LoginMessage,
                string.IsNullOrEmpty(Perspective) ? "" : "Perspective " + Perspective,
                "MaxPlayers " + MaxPlayers,
                "Queue_Size " + QueueSize,
                "ChatRate " + ChatRate,
                "Cycle " + Cycle,
                "Owner " + Owner,
                "Port " + Port,
                Pvp ? "" : "PvE",
                Sync ? "Sync" : "",
                Cheats ? "Cheats" : "",
                Filter ? "Filter" : "",
                GoldMode ? "Gold" : "",
                HideAdmins ? "hide_admins" : ""
            };

        public void SaveJson()
        {
            var file = Path.Combine(AppContext.BaseDirectory, _filePath);
            File.WriteAllText(file, ToJson());
        }

        private string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        private static void EnsureExists()
        {
            var file = Path.Combine(AppContext.BaseDirectory, _filePath);
            if (File.Exists(file)) return;

            var path = Path.GetDirectoryName(file);
            if (!Directory.Exists(path))
                if (path != null)
                    Directory.CreateDirectory(path);

            var config = new GameConfiguration();
            config.SaveJson();
        }

        public static GameConfiguration Load(string serverName)
        {
            _filePath = $@"config/Server_{serverName}_commands.json";

            var file = Path.Combine(AppContext.BaseDirectory, _filePath);

            EnsureExists();

            return JsonConvert.DeserializeObject<GameConfiguration>(File.ReadAllText(file));
        }

        public static void Delete(string serverName)
        {
            _filePath = $@"config/Server_{serverName}_commands.json";
            if (FileActions.VerifyFile(_filePath))
                File.Delete(_filePath);
        }

        public static void Clone(string server1, string server2)
        {
            var config1 = $@"config/Server_{server1}_commands.json";
            _filePath = $"config/Server_{server2}_commands.json";

            if (!FileActions.VerifyFile(config1))
                return;

            if (FileActions.VerifyFile(_filePath))
                File.Delete(_filePath);

            File.Copy(config1, _filePath);
        }

        public override string ToString()
        {
            return $"Public Name: {PublicName}" +
                   $"\nPort: {Port}" +
                   $"\nPvP: {Pvp}" +
                   $"\nPerspective: {Perspective}" +
                   $"\nMaxPlayers: {MaxPlayers}" +
                   $"\nMap: {Map}" +
                   $"\nDifficulty: {Difficulty}" +
                   $"\nGold Activated: {GoldMode}" +
                   $"\nCheats Enabled: {Cheats}" +
                   $"\nServer Password: {Password}" +
                   $"\nQueue Size: {QueueSize}" +
                   $"\nOwner Steam64ID: {Owner}" +
                   $"\nLogin Message: {LoginMessage}" +
                   $"\nSync Enabled: {Sync}" +
                   $"\nLoadout: {Loadout}" +
                   $"\nHide Admins: {HideAdmins}" +
                   $"\nBind: {Bind}" +
                   $"\nFilter: {Filter}" +
                   $"\nCycle: {Cycle}" +
                   $"\nChat Rate: {ChatRate}";
        }
    }
}