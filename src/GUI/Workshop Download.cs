using ATORTTeam.UnturnedServerManager.FileControl;
using ATORTTeam.UnturnedServerManager.SteamCMDManager;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace ATORTTeam.UnturnedServerManager.GUI
{
    public partial class Workshop : Form
    {
        private string Server;
        private string ItemID = "";

        public Workshop(string ServerPath)
        {
            InitializeComponent();
            Server = ServerPath;
            LoadInstalled();
        }

        // Custom Methods
        public void LoadInstalled()
        {
            AlreadyInstalled.Items.Clear();
            var workshoplocation = Path.Combine(Server, "Workshop", "Content");
            FileActions.VerifyPath(workshoplocation, true);

            DirectoryInfo Fldr = new DirectoryInfo(workshoplocation);
            DirectoryInfo[] Content = Fldr.GetDirectories();
            foreach (var folder in Content)
                AlreadyInstalled.Items.Add(folder.Name);
            
            workshoplocation = Path.Combine(Server, "Workshop", "Maps");
            FileActions.VerifyPath(workshoplocation, true);

            Fldr = new DirectoryInfo(workshoplocation);
            Content = Fldr.GetDirectories();
            foreach (var folder in Content)
                AlreadyInstalled.Items.Add(folder.Name);
            
            if (AlreadyInstalled.Items.Count == 0)
            {
                Delete.Enabled = false;
                View.Enabled = false;
                UpdateAll.Enabled = false;
                DeleteAll.Enabled = false;
                ItemID = "";
            }
            else
            {
                AlreadyInstalled.SelectedIndex = 0;
                UpdateAll.Enabled = true;
                DeleteAll.Enabled = true;
            }
        }

        // Control Events
        private void Exit_Click(object sender, EventArgs e) => Close();
        private void DeleteAll_Click(object sender, EventArgs e)
        {
            FileActions.DeleteDirectory(Path.Combine(Server, "Workshop"));
            LoadInstalled();
        }
        private void View_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ItemID))
                Process.Start($"https://steamcommunity.com/workshop/filedetails/?id={ItemID}");
        }
        private void UpdateAll_Click(object sender, EventArgs e)
        {
            Hide();
            if (AlreadyInstalled.Items.Count > 0)
            {
                foreach (string s in AlreadyInstalled.Items)
                {
                    SteamCMD.RunCommand($"+workshop_download_item 304930 {s} +quit");
                    SteamCMD.MoveWorkshopFolder(s, Path.Combine(Server, "Workshop"));
                }
            }
            LoadInstalled();
            Show();
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ItemID))
            {
                FileActions.DeleteDirectory(Path.Combine(Server, "Workshop", "Content", ItemID));
                FileActions.DeleteDirectory(Path.Combine(Server, "Workshop", "Maps", ItemID));
            }
            LoadInstalled();
        }
        private void InstallID_Click(object sender, EventArgs e)
        {
            Hide();
            if (!string.IsNullOrEmpty(ID.Text))
            {
                SteamCMD.RunCommand($"+workshop_download_item 304930 {ID.Text} +quit");
                SteamCMD.MoveWorkshopFolder(ID.Text, Path.Combine(Server, "Workshop"));
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
                ItemID = (string)AlreadyInstalled.SelectedItem;
            }
            else
            {
                Delete.Enabled = false;
                View.Enabled = false;
                ItemID = "";
            }
        }

        private bool ControlChange = false;
        private void ID_TextChanged(object sender, EventArgs e)
        {
            if (!ControlChange)
                Link.Text = "http://steamcommunity.com/sharedfiles/filedetails/?id=" + ID.Text;
        }
        private void Link_TextChanged(object sender, EventArgs e)
        {
            ControlChange = true;
            ID.Text = "";

            if (Link.Text.StartsWith("https://steamcommunity.com/sharedfiles/filedetails/?id="))
            {
                string id = Link.Text.Substring("https://steamcommunity.com/sharedfiles/filedetails/?id=".Length);

                string iid = "";
                foreach (char c in id)
                {
                    if (ulong.TryParse("" + c, out ulong n))
                        iid += c;
                    else
                        break;
                }

                if (ulong.TryParse(iid, out ulong uid))
                    ID.Text = iid;
            }
            else if (Link.Text.StartsWith("https://steamcommunity.com/workshop/filedetails/?id="))
            {
                string id = Link.Text.Substring("https://steamcommunity.com/workshop/filedetails/?id=".Length);

                string iid = "";
                foreach (char c in id)
                {
                    if (ulong.TryParse("" + c, out ulong n))
                        iid += c;
                    else
                        break;
                }

                if (ulong.TryParse(iid, out ulong uid))
                    ID.Text = iid;
            }
            ControlChange = false;
        }
    }
}
