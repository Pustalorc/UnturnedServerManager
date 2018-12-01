using System;
using System.Collections.Generic;
using System.IO;
using ATORTTeam.UnturnedServerManager.File_Control;
using Newtonsoft.Json;

namespace ATORTTeam.UnturnedServerManager.Configuration
{
    public sealed class CommandsDotDat
    {
        [JsonIgnore] private static string _filePath;

        public string Bind = "0.0.0.0";
        public int ChatRate = 0;
        public bool Cheats = false;
        public int Cycle = 43200;
        public string Difficulty = "Normal";
        public bool Filter = false;
        public bool GoldMode = false;
        public bool HideAdmins = false;
        public string Loadout = "";
        public string LoginMessage = "";
        public string Map = "Washington";
        public int MaxPlayers = 24;
        public long Owner = 76561197960265728;
        public string Password = "";
        public string Perspective = "Both";
        public int Port = 27015;

        public string PublicName = "Test Server";
        public bool Pvp = true;
        public int QueueSize = 8;
        public bool Sync = false;

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

            var config = new CommandsDotDat();
            config.SaveJson();
        }

        public static CommandsDotDat Load(string serverName)
        {
            _filePath = $@"config\Server_{serverName}_commands.json";

            var file = Path.Combine(AppContext.BaseDirectory, _filePath);

            EnsureExists();

            return JsonConvert.DeserializeObject<CommandsDotDat>(File.ReadAllText(file));
        }

        public static void Delete(string serverName)
        {
            _filePath = $@"config\Server_{serverName}_commands.json";
            if (FileActions.VerifyFile(_filePath))
                File.Delete(_filePath);
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