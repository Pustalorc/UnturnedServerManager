using ATORTTeam.UnturnedServerManager.Configuration;
using ATORTTeam.UnturnedServerManager.Constants;
using ATORTTeam.UnturnedServerManager.FileControl;
using ATORTTeam.UnturnedServerManager.Memory;
using ATORTTeam.UnturnedServerManager.ServerInstance;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ATORTTeam.UnturnedServerManager.GUI
{
    public partial class ConstConfig : Form
    {
        private string TargetServer;

        public ConstConfig(string ServerName)
        {
            InitializeComponent();

            TargetServer = ServerName;

            LoadMaps();
            LoadSaved();
        }

        // Custom Methods
        private void LoadMaps()
        {
            var server = Servers.Value.Find(k => k.Name == TargetServer);
            if (server.Type == ServerType.RocketMod)
            {
                var Dir = Path.Combine(RocketmodServerPath.Value, "Maps");
                FileActions.VerifyPath(Dir, true);

                var RocketmodDirectoryInfo = new DirectoryInfo(Dir);
                foreach (var rocketserver in RocketmodDirectoryInfo.GetDirectories())
                    Maps.Items.Add(rocketserver.Name);
            }
            else
            {
                var Dir = Path.Combine(RocketmodServerPath.Value, "Maps");
                FileActions.VerifyPath(Dir, true);

                var VanillaDirectoryInfo = new DirectoryInfo(Dir);
                foreach (var rocketserver in VanillaDirectoryInfo.GetDirectories())
                    Maps.Items.Add(rocketserver.Name);
            }

            var WorkshopMaps = Path.Combine(server.Folder, "Workshop", "Maps");
            FileActions.VerifyPath(WorkshopMaps, true);

            var Fldr = new DirectoryInfo(WorkshopMaps);
            var Content = Fldr.GetDirectories();
            foreach (var folder in Content)
                foreach (var MapName in folder.GetDirectories())
                    Maps.Items.Add(MapName.Name);
        }
        private void Save()
        {
            var conf = CommandsDotDat.Load(TargetServer);
            conf.PublicName = NameSel.Text.Length < 5 ? "Unturned" : NameSel.Text;
            conf.Port = (int)Port.Value;
            conf.PVP = PvPOn.Checked;
            conf.Perspective = PerspFirstPer.Checked ? "First" : "Both";
            conf.MaxPlayers = MaxPlayersVal1.Checked ? 8 : MaxPlayersVal2.Checked ? 16 : MaxPlayersVal3.Checked ? 24 : (int)MaxPlayers.Value;
            conf.Map = (string)Maps.SelectedItem;
            conf.Difficulty = DiffEasy.Checked ? "Easy" : DiffNormal.Checked ? "Normal" : "Hard";
            conf.GoldMode = GoldTrue.Checked;
            conf.Cheats = CheatsOn.Checked;
            conf.Password = PasswordSel.Text;
            conf.QueueSize = QueueSize1.Checked ? 8 : QueueSize2.Checked ? 16 : QueueSize3.Checked ? 24 : (int)Queue.Value;
            conf.Owner = (long)OwnerID.Value;
            conf.LoginMessage = MessageSel.Text;
            conf.Sync = SyncOn.Checked;
            conf.Loadout = LoadoutSel.Text;
            conf.HideAdmins = HideAdTrue.Checked;
            conf.Bind = string.Join(".", new byte[] { (byte)IPField1.Value, (byte)IPField2.Value, (byte)IPField3.Value, (byte)IPField4.Value });
            conf.Filter = FilterOn.Checked;
            conf.Cycle = Cycle1.Checked ? 43200 : (int)Cycle.Value;
            conf.ChatRate = Rate1.Checked ? 0 : (int)ChatRate.Value;
            conf.SaveJson();
            Close();
        }
        private void LoadSaved()
        {
            var conf = CommandsDotDat.Load(TargetServer);

            var BindBytes = conf.Bind.Split('.').ToList().ConvertAll(k =>
            {
                if (byte.TryParse(k, out byte r))
                    return r;
                else
                    return (byte)0;
            });
            IPField1.Value = BindBytes[0];
            IPField2.Value = BindBytes[1];
            IPField3.Value = BindBytes[2];
            IPField4.Value = BindBytes[3];

            NameSel.Text = conf.PublicName;
            Port.Value = conf.Port;

            if (string.IsNullOrEmpty(conf.Map))
                Maps.SelectedIndex = 0;
            else
                Maps.SelectedIndex = Maps.Items.IndexOf(conf.Map);

            PasswordSel.Text = conf.Password;
            OwnerID.Value = conf.Owner;
            MessageSel.Text = conf.LoginMessage;
            LoadoutSel.Text = conf.Loadout;

            if (conf.PVP)
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

            if (conf.Perspective == "First")
                PerspFirstPer.Checked = true;
            else if (conf.Perspective == "Both")
                PerspBoth.Checked = true;
            
            if (conf.Difficulty == "Easy")
                DiffEasy.Checked = true;
            else if (conf.Difficulty == "Normal")
                DiffNormal.Checked = true;
            else if (conf.Difficulty == "Hard")
                DiffHard.Checked = true;
            
            if (conf.Cycle == 43200)
                Cycle1.Checked = true;
            else
            {
                Cycle2.Checked = true;
                Cycle.Enabled = true;
                Cycle.Value = conf.Cycle;
            }
            
            if (conf.ChatRate == 0)
                Rate1.Checked = true;
            else
            {
                Rate2.Checked = true;
                ChatRate.Enabled = true;
                ChatRate.Value = conf.ChatRate;
            }

            if (conf.QueueSize == 8)
                QueueSize1.Checked = true;
            else if (conf.QueueSize == 16)
                QueueSize2.Checked = true;
            else if (conf.QueueSize == 24)
                QueueSize3.Checked = true;
            else
            {
                QueueSize4.Checked = true;
                Queue.Enabled = true;
                Queue.Value = conf.QueueSize;
            }

            if (conf.MaxPlayers == 8)
                MaxPlayersVal1.Checked = true;
            else if (conf.MaxPlayers == 16)
                MaxPlayersVal2.Checked = true;
            else if (conf.MaxPlayers == 24)
                MaxPlayersVal3.Checked = true;
            else
            {
                MaxPlayersVal4.Checked = true;
                MaxPlayers.Enabled = true;
                MaxPlayers.Value = conf.MaxPlayers;
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
            else if (Cycle2.Checked == true)
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
        private void Exit_Click(object sender, EventArgs e) => Save();
        private void MaxPlayers_CheckedChanged(object sender, EventArgs e) => MaxPlayersChange();
        private void QueueSize_CheckedChanged(object sender, EventArgs e) => QueueChange();
        private void Rate_CheckedChanged(object sender, EventArgs e) => ChatChange();
        private void Cycle_CheckedChanged(object sender, EventArgs e) => CycleChange();
    }
}
