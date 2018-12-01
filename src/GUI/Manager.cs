using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using ATORTTeam.UnturnedServerManager.Configuration;
using ATORTTeam.UnturnedServerManager.File_Control;

namespace ATORTTeam.UnturnedServerManager.GUI
{
    internal sealed partial class Manager : Form
    {
        private bool _otherGuiOpen;
        private bool _reloaded;
        private string _selectedServer = "";

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
            var menu = new ContextMenu();
            var exit = new MenuItem();
            var wiki = new MenuItem();
            var issues = new MenuItem();
            IContainer components = new Container();
            menu.MenuItems.AddRange(new[] {exit, wiki, issues});
            exit.Index = 0;
            exit.Text = @"Exit";
            exit.Click += Exit_Click;
            wiki.Index = 0;
            wiki.Text = @"Wiki";
            wiki.Click += Github_Click;
            issues.Index = 0;
            issues.Text = @"Issues And Suggestions";
            issues.Click += Issues_Click;
            Notifier.ContextMenu = menu;
        }

        private void LoadServers()
        {
            _reloaded = true;

            Servers.Items.Clear();

            foreach (var s in Memory.Servers.Value)
                Servers.Items.Add(s.Name);

            if (Servers.Items.Count == 0)
            {
                ToggleServerElements(false);
                ServerSettings.Text = "";
            }
            else
            {
                ToggleServerElements(true);
                Servers.SelectedIndex = 0;

                _selectedServer = (string) Servers.SelectedItem;

                LoadServerDetails();
            }

            _reloaded = false;
        }

        private void ToggleServerElements(bool status)
        {
            Settings.Enabled = status;
            ServerSettings.Enabled = status;
            Toggle.Enabled = status;
            OpenLocal.Enabled = status;
            Restart.Enabled = false;
            Reset.Enabled = status;
            Workshop.Enabled = status;
            Plugin.Enabled = status;
            DeleteServer.Enabled = status;
            CloneServer.Enabled = status;
        }

        private void LoadServerDetails()
        {
            ServerSettings.Text = CommandsDotDat.Load(_selectedServer).ToString();

            var server = Memory.Servers.Value.Find(k => k.Name == _selectedServer);
            if (server == null) return;

            Restart.Enabled = server.IsRunning;
        }

        // Notification tray actions.
        private void Notifier_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (_otherGuiOpen) return;

            if (Visible)
                Hide();
            else
                Show();
        }

        private static void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private static void Github_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/persiafighter/UnturnedServerManager/wiki");
        }

        private static void Issues_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/persiafighter/UnturnedServerManager/issues");
        }

        // Form events.
        private void GithubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/persiafighter/UnturnedServerManager/");
        }

        private void LinkMe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://persiafighter.github.io/");
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            _otherGuiOpen = true;
            Hide();

            var f = new ConstConfig(_selectedServer);
            f.ShowDialog();

            Show();
            _otherGuiOpen = false;
            LoadServerDetails();
        }

        private void Updater_Click(object sender, EventArgs e)
        {
            _otherGuiOpen = true;
            Hide();

            var f = new UpdateMenu();
            f.ShowDialog();

            Show();
            _otherGuiOpen = false;
        }

        private void Workshop_Click(object sender, EventArgs e)
        {
            var server = Memory.Servers.Value.Find(k => k.Name == _selectedServer);
            if (server == null) return;

            _otherGuiOpen = true;
            Hide();

            var f = new Workshop(server.Folder);
            f.ShowDialog();

            Show();
            _otherGuiOpen = false;
        }

        private void Plugin_Click(object sender, EventArgs e)
        {
            var server = Memory.Servers.Value.Find(k => k.Name == _selectedServer);
            if (server == null) return;

            _otherGuiOpen = true;
            Hide();

            var f = new Plugin(server.Folder);
            f.ShowDialog();

            Show();
            _otherGuiOpen = false;
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            var server = Memory.Servers.Value.Find(k => k.Name == _selectedServer);
            server?.Restart();
        }

        private void Toggle_Click(object sender, EventArgs e)
        {
            var server = Memory.Servers.Value.Find(k => k.Name == _selectedServer);
            if (server == null) return;

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

        private void Reset_Click(object sender, EventArgs e)
        {
            var server = Memory.Servers.Value.Find(k => k.Name == _selectedServer);
            if (server == null) return;

            FileActions.DeleteDirectory(Path.Combine(server.Folder, "Players"));
            FileActions.DeleteDirectory(Path.Combine(server.Folder, "Level"));
        }

        private void NewServer_Click(object sender, EventArgs e)
        {
            _otherGuiOpen = true;
            Hide();

            var f = new AddServer();
            f.ShowDialog();

            Show();
            _otherGuiOpen = false;
            LoadServers();
        }

        private void OpenLocal_Click(object sender, EventArgs e)
        {
            var server = Memory.Servers.Value.Find(k => k.Name == _selectedServer);
            if (server != null)
                Process.Start(server.Folder);
        }

        private void CloneServer_Click(object sender, EventArgs e)
        {
            var server = Memory.Servers.Value.Find(k => k.Name == _selectedServer);
            if (server == null) return;

            _otherGuiOpen = true;
            Hide();

            var f = new AddServer(server.Folder);
            f.ShowDialog();

            Show();
            _otherGuiOpen = false;
            LoadServers();
        }

        private void DeleteServer_Click(object sender, EventArgs e)
        {
            var server = Memory.Servers.Value.Find(k => k.Name == _selectedServer);
            if (server?.IsRunning == true)
                server.Shutdown();

            server?.Delete();

            LoadServers();
        }

        private void Servers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_reloaded) return;

            _selectedServer = (string) Servers.SelectedItem;

            LoadServerDetails();
        }
    }
}