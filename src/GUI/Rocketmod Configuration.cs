using ATORTTeam.UnturnedServerManager.FileControl;
using Rocket.Core;
using Rocket.Core.Serialization;
using Rocket.Unturned.Serialisation;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ATORTTeam.UnturnedServerManager.GUI
{
    public partial class RocketmodConfiguration : Form
    {
        private string RocketConfigsDirectory = "";

        public RocketmodConfiguration(string Directory)
        {
            InitializeComponent();

            RocketConfigsDirectory = Directory;
            LoadSaved();
        }

        // Custom Methods
        private void LoadSaved()
        {
            // Load RocketSettings
            var file = Path.Combine(RocketConfigsDirectory, Environment.SettingsFile);
            if (FileActions.VerifyFile(file))
                using (StreamReader reader = new StreamReader(file))
                {
                    var Serialiser = new XmlSerializer(typeof(RocketSettings));
                    var Settings = Serialiser.Deserialize(reader) as RocketSettings;

                    var Rcon = Settings.RCON;
                    RCON.Checked = Rcon.Enabled;
                    Port.Value = Rcon.Port;
                    Password.Text = Rcon.Password;
                    EnableMaxGlobalConnections.Checked = Rcon.EnableMaxGlobalConnections;
                    MaxGlobalConn.Value = Rcon.MaxGlobalConnections;
                    EnableMaxLocalConn.Checked = Rcon.EnableMaxLocalConnections;
                    MaxLocalConn.Value = Rcon.MaxLocalConnections;

                    var AutoShutdowns = Settings.AutomaticShutdown;
                    AutoShutdown.Checked = AutoShutdowns.Enabled;
                    Time.Value = AutoShutdowns.Interval;

                    var WebConfigs = Settings.WebConfigurations;
                    WebConfig.Checked = WebConfigs.Enabled;
                    WebConfigURL.Text = WebConfigs.Url;

                    var WebPerm = Settings.WebPermissions;
                    WebPerms.Checked = WebPerm.Enabled;
                    WebPermsURL.Text = WebPerm.Url;
                    WebPermRefresh.Value = WebPerm.Interval;

                    Language.Text = Settings.LanguageCode;
                    TPS.Value = Settings.MaxFrames;
                }

            // Load UnturnedSettings
            file = Path.Combine(RocketConfigsDirectory, Rocket.Unturned.Environment.SettingsFile);
            if (FileActions.VerifyFile(file))
                using (StreamReader reader = new StreamReader(file))
            {
                var Serialiser = new XmlSerializer(typeof(UnturnedSettings));
                var Settings = Serialiser.Deserialize(reader) as UnturnedSettings;

                var AutoSaves = Settings.AutomaticSave;
                AutoSave.Checked = AutoSaves.Enabled;
                SaveInterval.Value = AutoSaves.Interval;

                var Observatory = Settings.RocketModObservatory;
                CommunityBans.Checked = Observatory.CommunityBans;
                SteamLimitedAccounts.Checked = Observatory.KickLimitedAccounts;
                KickYoungAccounts.Checked = Observatory.KickTooYoungAccounts;
                YoungRange.Value = Observatory.MinimumAge;

                ValidateName.Checked = Settings.CharacterNameValidation;
                Validation.Text = Settings.CharacterNameValidationRule;
                LogMovement.Checked = Settings.LogSuspiciousPlayerMovement;
                ItemSpawnBlacklist.Checked = Settings.EnableItemBlacklist;
                EnableItemSpawnLimit.Checked = Settings.EnableItemSpawnLimit;
                MaxSpawn.Value = Settings.MaxSpawnAmount;
                VehicleBlacklist.Checked = Settings.EnableVehicleBlacklist;
            }
        }
        
        // Control Events
        private void EnableMaxGlobalConnections_CheckedChanged(object sender, System.EventArgs e) => MaxGlobalConn.Enabled = EnableMaxGlobalConnections.Checked;
        private void EnableItemSpawnLimit_CheckedChanged(object sender, System.EventArgs e) => MaxSpawn.Enabled = EnableItemSpawnLimit.Checked;
        private void EnableMaxLocalConn_CheckedChanged(object sender, System.EventArgs e) => MaxLocalConn.Enabled = EnableMaxLocalConn.Checked;
        private void KickYoungAccounts_CheckedChanged(object sender, System.EventArgs e) => YoungRange.Enabled = KickYoungAccounts.Checked;
        private void ValidateName_CheckedChanged(object sender, System.EventArgs e) => Validation.Enabled = ValidateName.Checked;
        private void WebConfig_CheckedChanged(object sender, System.EventArgs e) => WebConfigURL.Enabled = WebConfig.Checked;
        private void AutoShutdown_CheckedChanged(object sender, System.EventArgs e) => Time.Enabled = AutoShutdown.Checked;
        private void AutoSave_CheckedChanged(object sender, System.EventArgs e) => SaveInterval.Enabled = AutoSave.Checked;
        private void Exit_Click(object sender, System.EventArgs e) => Close();
        private void WebPerms_CheckedChanged(object sender, System.EventArgs e)
        {
            WebPermsURL.Enabled = WebPerms.Checked;
            WebPermRefresh.Enabled = WebPerms.Checked;
        }
        private void RCON_CheckedChanged(object sender, System.EventArgs e)
        {
            Port.Enabled = RCON.Checked;
            Password.Enabled = RCON.Checked;
            EnableMaxLocalConn.Enabled = RCON.Checked;
            MaxLocalConn.Enabled = RCON.Checked && EnableMaxLocalConn.Checked;
            EnableMaxGlobalConnections.Enabled = RCON.Checked;
            MaxGlobalConn.Enabled = RCON.Checked && EnableMaxGlobalConnections.Checked;
        }
        private void RocketmodConfiguration_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Construct RocketSettings Instance
            var RSInstance = new RocketSettings()
            {
                AutomaticShutdown = new AutomaticShutdown()
                {
                    Enabled = AutoShutdown.Checked,
                    Interval = (int)Time.Value
                },
                LanguageCode = Language.Text,
                MaxFrames = (int)TPS.Value,
                RCON = new RemoteConsole()
                {
                    Enabled = RCON.Checked,
                    EnableMaxGlobalConnections = EnableMaxGlobalConnections.Checked,
                    EnableMaxLocalConnections = EnableMaxLocalConn.Checked,
                    MaxGlobalConnections = (ushort)MaxGlobalConn.Value,
                    MaxLocalConnections = (ushort)MaxLocalConn.Value,
                    Password = Password.Text,
                    Port = (ushort)Port.Value
                },
                WebConfigurations = new WebConfigurations()
                {
                    Enabled = WebConfig.Checked,
                    Url = WebConfigURL.Text
                },
                WebPermissions = new WebPermissions()
                {
                    Enabled = WebPerms.Checked,
                    Interval = (int)WebPermRefresh.Value,
                    Url = WebPermsURL.Text
                }
            };

            // Write to file
            var file = Path.Combine(RocketConfigsDirectory, Environment.SettingsFile);
            FileActions.VerifyFilePath(file);
            using (StreamWriter reader = new StreamWriter(file))
            {
                var Serialiser = new XmlSerializer(typeof(RocketSettings));
                Serialiser.Serialize(reader, RSInstance);
            }

            // Construct UnturnedSettings Instance
            var USInstance = new UnturnedSettings()
            {
                AutomaticSave = new AutomaticSaveSettings()
                {
                    Enabled = AutoSave.Checked,
                    Interval = (int)SaveInterval.Value
                },
                CharacterNameValidation = ValidateName.Checked,
                CharacterNameValidationRule = Validation.Text,
                EnableItemBlacklist = ItemSpawnBlacklist.Checked,
                EnableItemSpawnLimit = EnableItemSpawnLimit.Checked,
                EnableVehicleBlacklist = VehicleBlacklist.Checked,
                LogSuspiciousPlayerMovement = LogMovement.Checked,
                MaxSpawnAmount = (int)MaxSpawn.Value,
                RocketModObservatory = new RocketModObservatorySettings()
                {
                    CommunityBans = CommunityBans.Checked,
                    KickLimitedAccounts = SteamLimitedAccounts.Checked,
                    KickTooYoungAccounts = KickYoungAccounts.Checked,
                    MinimumAge = (long)YoungRange.Value
                }
            };

            // Write UnturnedSettings Instance to file
            file = Path.Combine(RocketConfigsDirectory, Rocket.Unturned.Environment.SettingsFile);
            FileActions.VerifyFilePath(file);
            using (StreamWriter reader = new StreamWriter(file))
            {
                var Serialiser = new XmlSerializer(typeof(UnturnedSettings));
                Serialiser.Serialize(reader, USInstance);
            }
        }
    }
}
