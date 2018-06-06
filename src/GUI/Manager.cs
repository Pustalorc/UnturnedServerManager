using ATORTTeam.UnturnedServerManager.Configuration;
using ATORTTeam.UnturnedServerManager.Constants;
using ATORTTeam.UnturnedServerManager.FileControl;
using ATORTTeam.UnturnedServerManager.ServerInstance;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace ATORTTeam.UnturnedServerManager.GUI
{
    public partial class Manager : Form
    {
        private bool OtherGUIOpen = false;
        private string SelectedServer = "";
        private bool Reloaded = false;

        public Manager()
        {
            InitializeComponent();

            BuildNotifyMenu();
            Notifier.Visible = true;

            LoadServers();
        }

        // Custom methods.
        private void BuildNotifyMenu()
        {
            ContextMenu Menu = new ContextMenu();
            MenuItem Exit = new MenuItem();
            MenuItem Wiki = new MenuItem();
            MenuItem Issues = new MenuItem();
            IContainer Components = new Container();
            Menu.MenuItems.AddRange( new MenuItem[] { Exit, Wiki, Issues });
            Exit.Index = 0;
            Exit.Text = "Exit";
            Exit.Click += new EventHandler(Exit_Click);
            Wiki.Index = 0;
            Wiki.Text = "Wiki";
            Wiki.Click += new EventHandler(Github_Click);
            Issues.Index = 0;
            Issues.Text = "Issues And Suggestions";
            Issues.Click += new EventHandler(Issues_Click);
            Notifier.ContextMenu = Menu;
        }
        private void LoadServers()
        {
            Reloaded = true;

            Servers.Items.Clear();

            foreach (var s in Memory.Servers.Value)
            {
                if (s.Type == ServerType.RocketMod)
                    Servers.Items.Add(s.Name + RocketmodPrefix.Value);
                else
                    Servers.Items.Add(s.Name + VanillaPrefix.Value);
            }

            if (Servers.Items.Count == 0)
            {
                ToggleServerElements(false);
                ServerSettings.Text = "";
            }
            else
            {
                ToggleServerElements(true);
                Servers.SelectedIndex = 0;

                var s = (string)Servers.SelectedItem;
                if (s.EndsWith(RocketmodPrefix.Value))
                    SelectedServer = s.Substring(0, s.Length - RocketmodPrefix.Value.Length);
                else if (s.EndsWith(VanillaPrefix.Value))
                    SelectedServer = s.Substring(0, s.Length - VanillaPrefix.Value.Length);

                LoadServerDetails();
            }

            Reloaded = false;
        }
        private void ToggleServerElements(bool Status)
        {
            Settings.Enabled = Status;
            ServerSettings.Enabled = Status;
            Toggle.Enabled = Status;
            OpenLocal.Enabled = Status;
            Restart.Enabled = false;
            Reset.Enabled = Status;
            Workshop.Enabled = Status;
            Plugin.Enabled = Status;
            DeleteServer.Enabled = Status;
            CloneServer.Enabled = Status;
        }
        private void LoadServerDetails()
        {
            ServerSettings.Text = CommandsDotDat.Load(SelectedServer).ToString();

            var server = Memory.Servers.Value.Find(k => k.Name == SelectedServer);
            if (server != null)
            {
                if (server.IsRunning)
                    Restart.Enabled = true;
                else
                    Restart.Enabled = false;
            }
        }

        // Notification tray actions.
        private void Notifier_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!OtherGUIOpen)
            {
                if (Visible)
                    Hide();
                else
                    Show();
            }
        }
        private void Exit_Click(object Sender, EventArgs e) => Application.Exit();
        private void Github_Click(object Sender, EventArgs e) => Process.Start("https://github.com/persiafighter/UnturnedServerManager/wiki");
        private void Issues_Click(object Sender, EventArgs e) => Process.Start("https://github.com/persiafighter/UnturnedServerManager/issues");

        // Form events.
        private void GithubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("https://github.com/persiafighter/UnturnedServerManager/");
        private void LinkMe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("https://persiafighter.github.io/");
        private void Settings_Click(object sender, EventArgs e)
        {
            OtherGUIOpen = true;
            Hide();

            ConstConfig f = new ConstConfig(SelectedServer);
            f.ShowDialog();

            Show();
            OtherGUIOpen = false;
            LoadServerDetails();
        }
        private void Updater_Click(object sender, EventArgs e)
        {
            OtherGUIOpen = true;
            Hide();

            UpdateMenu f = new UpdateMenu();
            f.ShowDialog();

            Show();
            OtherGUIOpen = false;
        }
        private void Workshop_Click(object sender, EventArgs e)
        {
            var server = Memory.Servers.Value.Find(k => k.Name == SelectedServer);
            if (server != null)
            {
                OtherGUIOpen = true;
                Hide();

                Workshop f = new Workshop(server.Folder);
                f.ShowDialog();

                Show();
                OtherGUIOpen = false;
            }
        }
        private void Plugin_Click(object sender, EventArgs e)
        {
            OtherGUIOpen = true;
            Hide();

            Plugin f = new Plugin();
            f.ShowDialog();

            Show();
            OtherGUIOpen = false;
        }
        private void Restart_Click(object sender, EventArgs e)
        {
            var server = Memory.Servers.Value.Find(k => k.Name == SelectedServer);
            if (server != null)
                server.Restart();
        }
        private void Toggle_Click(object sender, EventArgs e)
        {
            var server = Memory.Servers.Value.Find(k => k.Name == SelectedServer);
            if (server != null)
            {
                if (server.IsRunning)
                {
                    Restart.Enabled = false;
                    server.Shutdown();
                }
                else
                {
                    Restart.Enabled = true;
                    server.Start();
                }
            }
        }
        private void Reset_Click(object sender, EventArgs e)
        {
            var server = Memory.Servers.Value.Find(k => k.Name == SelectedServer);
            if (server != null)
            {
                FileActions.DeleteDirectory(Path.Combine(server.Folder, "Players"));
                FileActions.DeleteDirectory(Path.Combine(server.Folder, "Level"));
            }
        }
        private void NewServer_Click(object sender, EventArgs e)
        {
            OtherGUIOpen = true;
            Hide();

            var f = new AddServer();
            f.ShowDialog();

            Show();
            OtherGUIOpen = false;
            LoadServers();
        }
        private void OpenLocal_Click(object sender, EventArgs e)
        {
            var server = Memory.Servers.Value.Find(k => k.Name == SelectedServer);
            if (server != null)
                Process.Start(server.Folder);
        }
        private void CloneServer_Click(object sender, EventArgs e)
        {
            var server = Memory.Servers.Value.Find(k => k.Name == SelectedServer);
            if (server != null)
            {
                OtherGUIOpen = true;
                Hide();

                var f = new AddServer(server.Folder);
                f.ShowDialog();

                Show();
                OtherGUIOpen = false;
                LoadServers();
            }
        }
        private void DeleteServer_Click(object sender, EventArgs e)
        {
            var server = Memory.Servers.Value.Find(k => k.Name == SelectedServer);
            if (server != null)
            {
                if (server.IsRunning)
                    server.Shutdown();

                server.Delete();
            }

            LoadServers();
        }
        private void Servers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Reloaded)
            {
                var s = (string)Servers.SelectedItem;
                if (s.EndsWith(RocketmodPrefix.Value))
                    SelectedServer = s.Substring(0, s.Length - RocketmodPrefix.Value.Length);
                else if (s.EndsWith(VanillaPrefix.Value))
                    SelectedServer = s.Substring(0, s.Length - VanillaPrefix.Value.Length);

                LoadServerDetails();
            }
        }
    }
}
