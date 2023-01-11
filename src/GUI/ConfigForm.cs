using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Pustalorc.Applications.USM.Configuration;
using Pustalorc.Applications.USM.Constants;
using Pustalorc.Applications.USM.File_Control;
using Pustalorc.Applications.USM.Loading;

namespace Pustalorc.Applications.USM.GUI
{
    internal sealed partial class ConfigForm : Form
    {
        private readonly string _targetServer;

        public ConfigForm(string serverName)
        {
            InitializeComponent();

            _targetServer = serverName;

            LoadMaps();
            LoadSaved();
        }

        // Custom Methods
        private void LoadMaps()
        {
            var server = Servers.RegisteredServers.Find(k => k.Name == _targetServer);
            var dir = Path.Combine(ServerPath.Value, "Maps");
            FileActions.VerifyPath(dir, true);

            var rocketModDirectoryInfo = new DirectoryInfo(dir);
            foreach (var rocketServer in rocketModDirectoryInfo.GetDirectories())
                Maps.Items.Add(rocketServer.Name);

            var workshopMaps = Path.Combine(server.Folder, "Workshop", "Maps");
            FileActions.VerifyPath(workshopMaps, true);

            var folder = new DirectoryInfo(workshopMaps);
            var content = folder.GetDirectories();
            foreach (var mapName in content.SelectMany(item => item.GetDirectories()))
                Maps.Items.Add(mapName.Name);
        }

        private void Save()
        {
            var conf = GameConfiguration.Load(_targetServer);
            conf.PublicName = NameSel.Text.Length < 5 ? "Unturned" : NameSel.Text;
            conf.Port = (int) Port.Value;
            conf.Pvp = PvPOn.Checked;
            conf.Perspective = PerspFirstPer.Checked ? "First" : "Both";
            conf.MaxPlayers = MaxPlayersVal1.Checked ? 8 :
                MaxPlayersVal2.Checked ? 16 :
                MaxPlayersVal3.Checked ? 24 : (int) MaxPlayers.Value;
            conf.Map = (string) Maps.SelectedItem;
            conf.Difficulty = DiffEasy.Checked ? "Easy" : DiffNormal.Checked ? "Normal" : "Hard";
            conf.GoldMode = GoldTrue.Checked;
            conf.Cheats = CheatsOn.Checked;
            conf.Password = PasswordSel.Text;
            conf.QueueSize = QueueSize1.Checked ? 8 :
                QueueSize2.Checked ? 16 :
                QueueSize3.Checked ? 24 : (int) Queue.Value;
            conf.Owner = (long) OwnerID.Value;
            conf.LoginMessage = MessageSel.Text;
            conf.Sync = SyncOn.Checked;
            conf.Loadout = LoadoutSel.Text;
            conf.HideAdmins = HideAdTrue.Checked;
            conf.Bind = string.Join(".",
                new[] {(byte) IPField1.Value, (byte) IPField2.Value, (byte) IPField3.Value, (byte) IPField4.Value});
            conf.Filter = FilterOn.Checked;
            conf.Cycle = Cycle1.Checked ? 43200 : (int) Cycle.Value;
            conf.ChatRate = Rate1.Checked ? 0 : (int) ChatRate.Value;
            conf.SaveJson();

            var commandsDat = Path.Combine(ServerPath.Value, "Servers", _targetServer, "Server", "Commands.dat");
            FileActions.VerifyFilePath(commandsDat, true);
            File.WriteAllLines(commandsDat, conf.ToNelson);

            Close();
        }

        private void LoadSaved()
        {
            var conf = GameConfiguration.Load(_targetServer);

            var bindBytes = conf.Bind.Split('.').ToList().ConvertAll(k =>
            {
                if (byte.TryParse(k, out var r))
                    return r;

                return (byte) 0;
            });
            IPField1.Value = bindBytes[0];
            IPField2.Value = bindBytes[1];
            IPField3.Value = bindBytes[2];
            IPField4.Value = bindBytes[3];

            NameSel.Text = conf.PublicName;
            Port.Value = conf.Port;

            Maps.SelectedIndex = string.IsNullOrEmpty(conf.Map) ? 0 : Maps.Items.IndexOf(conf.Map);

            PasswordSel.Text = conf.Password;
            OwnerID.Value = conf.Owner;
            MessageSel.Text = conf.LoginMessage;
            LoadoutSel.Text = conf.Loadout;

            if (conf.Pvp)
                PvPOn.Checked = true;
            else
                PvPOff.Checked = true;

            if (conf.GoldMode)
                GoldTrue.Checked = true;
            else
                GoldFalse.Checked = true;

            if (conf.Cheats)
                CheatsOn.Checked = true;
            else
                CheatsOff.Checked = true;

            if (conf.Sync)
                SyncOn.Checked = true;
            else
                SyncOff.Checked = true;

            if (conf.HideAdmins)
                HideAdTrue.Checked = true;
            else
                HideAdFalse.Checked = true;

            if (conf.Filter)
                FilterOn.Checked = true;
            else
                FilterOff.Checked = true;

            switch (conf.Perspective)
            {
                case "First":
                    PerspFirstPer.Checked = true;
                    break;
                case "Both":
                    PerspBoth.Checked = true;
                    break;
                default:
                    PerspBoth.Checked = true;
                    break;
            }

            switch (conf.Difficulty)
            {
                case "Easy":
                    DiffEasy.Checked = true;
                    break;
                case "Normal":
                    DiffNormal.Checked = true;
                    break;
                case "Hard":
                    DiffHard.Checked = true;
                    break;
                default:
                    DiffNormal.Checked = true;
                    break;
            }

            if (conf.Cycle == 43200)
            {
                Cycle1.Checked = true;
            }
            else
            {
                Cycle2.Checked = true;
                Cycle.Enabled = true;
                Cycle.Value = conf.Cycle;
            }

            if (conf.ChatRate == 0)
            {
                Rate1.Checked = true;
            }
            else
            {
                Rate2.Checked = true;
                ChatRate.Enabled = true;
                ChatRate.Value = conf.ChatRate;
            }

            switch (conf.QueueSize)
            {
                case 8:
                    QueueSize1.Checked = true;
                    break;
                case 16:
                    QueueSize2.Checked = true;
                    break;
                case 24:
                    QueueSize3.Checked = true;
                    break;
                default:
                    QueueSize4.Checked = true;
                    Queue.Enabled = true;
                    Queue.Value = conf.QueueSize;
                    break;
            }

            switch (conf.MaxPlayers)
            {
                case 8:
                    MaxPlayersVal1.Checked = true;
                    break;
                case 16:
                    MaxPlayersVal2.Checked = true;
                    break;
                case 24:
                    MaxPlayersVal3.Checked = true;
                    break;
                default:
                    MaxPlayersVal4.Checked = true;
                    MaxPlayers.Enabled = true;
                    MaxPlayers.Value = conf.MaxPlayers;
                    break;
            }
        }

        // Control Update Methods
        private void QueueChange()
        {
            if (QueueSize1.Checked || QueueSize2.Checked || QueueSize3.Checked)
                Queue.Enabled = false;
            else if (QueueSize4.Checked)
                Queue.Enabled = true;
        }

        private void CycleChange()
        {
            if (Cycle1.Checked)
                Cycle.Enabled = false;
            else if (Cycle2.Checked)
                Cycle.Enabled = true;
        }

        private void MaxPlayersChange()
        {
            if (MaxPlayersVal1.Checked || MaxPlayersVal2.Checked || MaxPlayersVal3.Checked)
                MaxPlayers.Enabled = false;
            else if (MaxPlayersVal4.Checked)
                MaxPlayers.Enabled = true;
        }

        private void ChatChange()
        {
            if (Rate1.Checked)
                ChatRate.Enabled = false;
            else if (Rate2.Checked)
                ChatRate.Enabled = true;
        }

        // Control Events
        private void Exit_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void MaxPlayers_CheckedChanged(object sender, EventArgs e)
        {
            MaxPlayersChange();
        }

        private void QueueSize_CheckedChanged(object sender, EventArgs e)
        {
            QueueChange();
        }

        private void Rate_CheckedChanged(object sender, EventArgs e)
        {
            ChatChange();
        }

        private void Cycle_CheckedChanged(object sender, EventArgs e)
        {
            CycleChange();
        }

        private void btn_config_Click(object sender, EventArgs e)
        {
            var server = Loading.Servers.RegisteredServers.Find(k => k.Name == _targetServer);
            if (server != null)
            {


                Process.Start("notepad.exe", server.Folder + @"\Config.json");
            }
        }
    }
}