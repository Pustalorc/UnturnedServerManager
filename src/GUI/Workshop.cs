using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using ATORTTeam.UnturnedServerManager.File_Control;
using ATORTTeam.UnturnedServerManager.SteamCMD_Manager;

// ReSharper disable UnusedVariable

namespace ATORTTeam.UnturnedServerManager.GUI
{
    internal sealed partial class Workshop : Form
    {
        private readonly string _server;
        private bool _controlChange;
        private string _itemId = "";

        public Workshop(string serverPath)
        {
            InitializeComponent();
            _server = serverPath;
            LoadInstalled();
        }

        // Custom Methods
        private void LoadInstalled()
        {
            AlreadyInstalled.Items.Clear();
            var workshopLocation = Path.Combine(_server, "Workshop", "Content");
            FileActions.VerifyPath(workshopLocation, true);

            var folder = new DirectoryInfo(workshopLocation);
            var content = folder.GetDirectories();
            foreach (var item in content)
                AlreadyInstalled.Items.Add(item.Name);

            workshopLocation = Path.Combine(_server, "Workshop", "Maps");
            FileActions.VerifyPath(workshopLocation, true);

            folder = new DirectoryInfo(workshopLocation);
            content = folder.GetDirectories();
            foreach (var item in content)
                AlreadyInstalled.Items.Add(item.Name);

            if (AlreadyInstalled.Items.Count == 0)
            {
                Delete.Enabled = false;
                View.Enabled = false;
                UpdateAll.Enabled = false;
                DeleteAll.Enabled = false;
                _itemId = "";
            }
            else
            {
                AlreadyInstalled.SelectedIndex = 0;
                UpdateAll.Enabled = true;
                DeleteAll.Enabled = true;
            }
        }

        // Control Events
        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DeleteAll_Click(object sender, EventArgs e)
        {
            FileActions.DeleteDirectory(Path.Combine(_server, "Workshop"));
            LoadInstalled();
        }

        private void View_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_itemId))
                Process.Start($"https://steamcommunity.com/workshop/filedetails/?id={_itemId}");
        }

        private void UpdateAll_Click(object sender, EventArgs e)
        {
            Hide();
            if (AlreadyInstalled.Items.Count > 0)
                foreach (string s in AlreadyInstalled.Items)
                {
                    SteamCmd.RunCommand($"+workshop_download_item 304930 {s} +quit");
                    SteamCmd.MoveWorkshopFolder(s, Path.Combine(_server, "Workshop"));
                }

            LoadInstalled();
            Show();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_itemId))
            {
                FileActions.DeleteDirectory(Path.Combine(_server, "Workshop", "Content", _itemId));
                FileActions.DeleteDirectory(Path.Combine(_server, "Workshop", "Maps", _itemId));
            }

            LoadInstalled();
        }

        private void InstallID_Click(object sender, EventArgs e)
        {
            Hide();
            if (!string.IsNullOrEmpty(ID.Text))
            {
                SteamCmd.RunCommand($"+workshop_download_item 304930 {ID.Text} +quit");
                SteamCmd.MoveWorkshopFolder(ID.Text, Path.Combine(_server, "Workshop"));
            }

            LoadInstalled();
            Show();
        }

        private void AlreadyInstalled_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AlreadyInstalled.SelectedItem != null)
            {
                Delete.Enabled = true;
                View.Enabled = true;
                _itemId = (string) AlreadyInstalled.SelectedItem;
            }
            else
            {
                Delete.Enabled = false;
                View.Enabled = false;
                _itemId = "";
            }
        }

        private void ID_TextChanged(object sender, EventArgs e)
        {
            if (!_controlChange)
                Link.Text = $@"http://steamcommunity.com/sharedfiles/filedetails/?id={ID.Text}";
        }

        private void Link_TextChanged(object sender, EventArgs e)
        {
            _controlChange = true;
            ID.Text = "";

            if (Link.Text.StartsWith("https://steamcommunity.com/sharedfiles/filedetails/?id=",
                StringComparison.Ordinal))
            {
                var id = Link.Text.Substring("https://steamcommunity.com/sharedfiles/filedetails/?id=".Length);

                var iid = "";
                foreach (var c in id)
                    if (ulong.TryParse("" + c, out var n))
                        iid += c;
                    else
                        break;

                if (ulong.TryParse(iid, out var uid))
                    ID.Text = iid;
            }
            else if (Link.Text.StartsWith("https://steamcommunity.com/workshop/filedetails/?id=",
                StringComparison.Ordinal))
            {
                var id = Link.Text.Substring("https://steamcommunity.com/workshop/filedetails/?id=".Length);

                var iid = "";
                foreach (var c in id)
                    if (ulong.TryParse("" + c, out var n))
                        iid += c;
                    else
                        break;

                if (ulong.TryParse(iid, out var uid))
                    ID.Text = iid;
            }

            _controlChange = false;
        }
    }
}