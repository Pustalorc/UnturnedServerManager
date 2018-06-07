using ATORTTeam.UnturnedServerManager.FileControl;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace ATORTTeam.UnturnedServerManager.Configuration
{
    public class CommandsDotDat
    {
        [JsonIgnore]
        private static string FilePath;

        public string PublicName = "Test Server";
        public int Port = 27015;
        public bool PVP = true;
        public string Perspective = "Both";
        public int MaxPlayers = 24;
        public string Map = "Washington";
        public string Difficulty = "Normal";
        public bool GoldMode = false;
        public bool Cheats = false;
        public string Password = "";
        public int QueueSize = 8;
        public long Owner = 76561197960265728;
        public string LoginMessage = "";
        public bool Sync = false;
        public string Loadout = "";
        public bool HideAdmins = false;
        public string Bind = "0.0.0.0";
        public bool Filter = false;
        public int Cycle = 43200;
        public int ChatRate = 0;

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

                var config = new CommandsDotDat();
                config.SaveJson();
            }
        }
        public static CommandsDotDat Load(string ServerName)
        {
            FilePath = $@"config\Server_{ServerName}_commands.json";

            string file = Path.Combine(AppContext.BaseDirectory, FilePath);

            EnsureExists();

            return JsonConvert.DeserializeObject<CommandsDotDat>(File.ReadAllText(file));
        }
        public static void Delete(string ServerName)
        {
            FilePath = $@"config\Server_{ServerName}_commands.json";
            if (FileActions.VerifyFile(FilePath))
                File.Delete(FilePath);
        }

        public override string ToString() =>
            $"Public Name: {PublicName}" +
            $"\nPort: {Port}" +
            $"\nPvP: {PVP}" +
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
        public List<string> ToNelson =>
            new List<string>()
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
                PVP ? "" : "PvE",
                Sync ? "Sync" : "",
                Cheats ? "Cheats" : "",
                Filter ? "Filter" : "",
                GoldMode ? "Gold" : "",
                HideAdmins ? "hide_admins" : ""
            };
    }
}
