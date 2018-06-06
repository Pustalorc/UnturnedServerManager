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
            var workshoplocation = Path.Combine(Server, @"\Workshop\Content");
            FileActions.VerifyPath(workshoplocation, true);

            DirectoryInfo Fldr = new DirectoryInfo(workshoplocation);
            DirectoryInfo[] Content = Fldr.GetDirectories();
            foreach (var folder in Content)
                AlreadyInstalled.Items.Add(folder.Name);

            Fldr = new DirectoryInfo(Path.Combine(Server, @"\Workshop\Maps"));
            Content = Fldr.GetDirectories();
            foreach (var folder in Content)
                AlreadyInstalled.Items.Add(folder.Name);
        }

        // Control Events
        private void DeleteAll_Click(object sender, EventArgs e) => FileActions.DeleteDirectory(Path.Combine(Server, "Workshop"));
        private void View_Click(object sender, EventArgs e) => Process.Start($"https://steamcommunity.com/workshop/filedetails/?id={ItemID}");
        private void Exit_Click(object sender, EventArgs e) => Close();
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
                FileActions.DeleteDirectory(Path.Combine(Server, $@"\Workshop\Content\{ItemID}"));
                FileActions.DeleteDirectory(Path.Combine(Server, $@"\Workshop\Maps\{ItemID}"));
            }
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
                ItemID = (string)AlreadyInstalled.SelectedItem;
            else
                ItemID = "";
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
            if (Link.Text.Length >= "https://steamcommunity.com/workshop/filedetails/?id=".Length)
                ID.Text = Link.Text.Substring("https://steamcommunity.com/workshop/filedetails/?id=".Length);
            ControlChange = false;
        }
    }
}
