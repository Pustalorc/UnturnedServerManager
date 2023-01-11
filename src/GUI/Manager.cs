using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Pustalorc.Applications.USM.Configuration;
using Pustalorc.Applications.USM.File_Control;

namespace Pustalorc.Applications.USM.GUI
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
            menu.MenuItems.AddRange(new[] {exit, wiki, issues});
            exit.Index = 0;
            exit.Text = @"Exit";
            exit.Click += Exit_Click;
            wiki.Index = 0;
            wiki.Text = @"Wiki";
            issues.Index = 0;
            issues.Text = @"Issues And Suggestions";
            Notifier.ContextMenu = menu;
        }

        private void LoadServers()
        {
            _reloaded = true;

            Servers.Items.Clear();

            foreach (var s in Loading.Servers.RegisteredServers)
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
            Reset.Enabled = status;
            Workshop.Enabled = status;
            Plugin.Enabled = status;
            DeleteServer.Enabled = status;
            CloneServer.Enabled = status;
            // Restart Server Button is not visible
            Restart.Visible = false;
            // Stop Server Button is not visible
            btn_stop_server.Visible = false;
        }

        private void LoadServerDetails()
        {
            ServerSettings.Text = GameConfiguration.Load(_selectedServer).ToString();

            var server = Loading.Servers.RegisteredServers.Find(k => k.Name == _selectedServer);
            if (server == null) return;

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

        private void Settings_Click(object sender, EventArgs e)
        {
            _otherGuiOpen = true;
            Hide();

            var f = new ConfigForm(_selectedServer);
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
            var server = Loading.Servers.RegisteredServers.Find(k => k.Name == _selectedServer);
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
            var server = Loading.Servers.RegisteredServers.Find(k => k.Name == _selectedServer);
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
            var server = Loading.Servers.RegisteredServers.Find(k => k.Name == _selectedServer);
            server?.Restart();
        }

        private void Toggle_Click(object sender, EventArgs e)
        {
            var server = Loading.Servers.RegisteredServers.Find(k => k.Name == _selectedServer);
            if (server == null) return;
            else
            {
                server.Start();
            }
            Toggle.Visible = false;
            Restart.Visible = true;
            btn_stop_server.Visible = true;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            var server = Loading.Servers.RegisteredServers.Find(k => k.Name == _selectedServer);
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
            var server = Loading.Servers.RegisteredServers.Find(k => k.Name == _selectedServer);
            if (server != null)
                Process.Start(server.Folder);
        }

        private void CloneServer_Click(object sender, EventArgs e)
        {
            var server = Loading.Servers.RegisteredServers.Find(k => k.Name == _selectedServer);
            if (server == null) return;

            _otherGuiOpen = true;
            Hide();

            var f = new AddServer(server.Folder);
            f.ShowDialog();

            GameConfiguration.Clone(server.Name, f.ServerName.Text);

            Show();
            _otherGuiOpen = false;
            LoadServers();
        }

        private void DeleteServer_Click(object sender, EventArgs e)
        {
            var server = Loading.Servers.RegisteredServers.Find(k => k.Name == _selectedServer);
            if (server?.IsRunning == true)
                server.Shutdown();

            server?.Delete();

            LoadServers();
        }

        private void Servers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_reloaded) return;

            _selectedServer = (string) Servers.SelectedItem;
            Settings_TXT.Text = $"Your server: {_selectedServer}";
            LoadServerDetails();
        }

        private void Mngmnt_TXT_Click(object sender, EventArgs e)
        {

        }

        private void List_TXT_Click(object sender, EventArgs e)
        {

        }

        private void Settings_TXT_Click(object sender, EventArgs e)
        {

        }

        private void ServerSettings_TextChanged(object sender, EventArgs e)
        {

        }

        private void ctrl_TXT_Click(object sender, EventArgs e)
        {

        }

        private void tn_stop_server_Click(object sender, EventArgs e)
        {

            var server = Loading.Servers.RegisteredServers.Find(k => k.Name == _selectedServer);
            if (server == null) return;
            else if (server.IsRunning)
            {
                server.Shutdown();
            }
            Toggle.Visible = true;
            Restart.Visible = false;
            btn_stop_server.Visible = false;
        }
    }
}