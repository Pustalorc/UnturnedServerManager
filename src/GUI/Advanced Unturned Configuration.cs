using ATORTTeam.UnturnedServerManager.FileControl;
using Newtonsoft.Json;
using SDG.Unturned;
using System.IO;
using System.Windows.Forms;

namespace ATORTTeam.UnturnedServerManager.GUI
{
    public partial class AdvancedUnturnedConfiguration : Form
    {
        private string configjson = "";

        public AdvancedUnturnedConfiguration(string file)
        {
            InitializeComponent();

            configjson = Path.Combine(file, "config.json");
            LoadDetails();
        }

        // Custom Methods
        private void LoadDetails()
        {
            var config = LoadJson();
            if (config == null)
                return;

            var browser = config.Browser;
            Icon.Text = browser.Icon;
            LongDesc.Text = browser.Desc_Full;
            ShortDesc.Text = browser.Desc_Hint;

            var server = config.Server;
            BattlEye.Checked = server.BattlEye_Secure;
            VAC.Checked = server.VAC_Secure;
            Packets.Value = (decimal)server.Max_Packets_Per_Second;
            Ping.Value = server.Max_Ping_Milliseconds;
            Queue.Value = (decimal)server.Timeout_Queue_Seconds;
            AFK.Value = (decimal)server.Timeout_Game_Seconds;
        }
        private void SaveJson(ConfigData instance) =>
            File.WriteAllText(configjson, JsonConvert.SerializeObject(instance, Formatting.Indented));
        private ConfigData LoadJson()
        {
            if (FileActions.VerifyFile(configjson))
                return JsonConvert.DeserializeObject<ConfigData>(File.ReadAllText(configjson));
            else
                return null;
        }

        // Control Events
        private void AdvancedUnturnedConfiguration_FormClosing(object sender, FormClosingEventArgs e)
        {
            var instance = new ConfigData()
            {
                Browser = new BrowserConfigData()
                {
                    Icon = Icon.Text,
                    Desc_Full = LongDesc.Text,
                    Desc_Hint = ShortDesc.Text
                },
                Server = new ServerConfigData()
                {
                    BattlEye_Secure = BattlEye.Checked,
                    VAC_Secure = VAC.Checked,
                    Max_Packets_Per_Second = (float)Packets.Value,
                    Max_Ping_Milliseconds = (uint)Ping.Value,
                    Timeout_Game_Seconds = (float)AFK.Value,
                    Timeout_Queue_Seconds = (float)Queue.Value
                }
            };
            SaveJson(instance);
        }
    }
}
