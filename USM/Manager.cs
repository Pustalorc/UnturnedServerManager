﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USM
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
            CheckLatestVersion();
            Notifier.Visible = true;
            if (File.Exists(Comms.DataPath + "Server_ID_1_Config.dat"))
            {
                Comms.LoadServerConfig(1);
                Comms.ConfigExists = true;
                UpdateGUI();
                VAC.Checked = Comms.VAC;
                Console.Checked = Comms.Console;
                Graphics.Checked = Comms.Graphics;
                LocalFold.Text = Comms.LocalName;
            }
            else
            {
                Comms.ConfigExists = false;
            }
            Desc4.Text = "Currently Editing Server With ID: 1";
            Save(false);
        }

        private void CheckLatestVersion()
        {
            Downloader.GetReady();

            if (File.Exists(Comms.DataPath + "Versions.dat") == true)
            {
                File.Delete(Comms.DataPath + "Versions.dat");
            }
            Downloader.Download("https://github.com/persiafighter/UnturnedServerManager/raw/master/Data/Versions.dat", "Versions.dat");
            Downloader.MoveFiles("Versions.dat", Comms.DataPath + "Versions.dat");
            Downloader.ShutOff();
            string LatestVersion = File.ReadAllLines(Comms.DataPath + "Versions.dat")[0];
            if (LatestVersion != "3.0.0.0")
            {
                Notifier.ShowBalloonTip(5000, "New Version", "A new version for Unturned Server Manager is available! Head over to the github page for more information. Your version: 3.0.0.0, Latest Version: " + LatestVersion + ".", ToolTipIcon.None);
            }
        }

        private void RedditLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.reddit.com/r/unturned/comments/546y67/unturned_server_manager/");
        }

        private void GithubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/persiafighter/UnturnedServerManager/");
        }

        private void LinkMe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://persiafighter.github.io/");
        }

        private async void EditServer_ValueChanged(object sender, EventArgs e)
        {
            Save(true);
            EditServer.Enabled = false;
            await Task.Delay(1);
            if (Convert.ToInt32(EditServer.Value) > Convert.ToInt32(Servers2Run.Value))
            {
                EditServer.Value = Servers2Run.Value;
            }
            Desc4.Text = "Currently Editing Server With ID: " + EditServer.Value;
            await Task.Delay(100);
            if (File.Exists(@"C:\Unturned_Manager\Server_ID_" + EditServer.Value + "_Config.dat"))
            {
                Comms.LoadServerConfig(Convert.ToInt32(EditServer.Value));
                Comms.ConfigExists = true;
                LocalFold.Text = Comms.LocalName;
                VAC.Checked = Comms.VAC;
                Graphics.Checked = Comms.Graphics;
                Console.Checked = Comms.Console;
                UpdateGUI();
            }
            else
            {
                Comms.ConfigExists = false;
                LocalFold.Text = "";
                VAC.Checked = true;
                Graphics.Checked = true;
                Console.Checked = true;
            }
            if (Comms.RunningID[(Convert.ToInt32(EditServer.Value) - 1)] == Convert.ToInt32(EditServer.Value))
            {
                EnableItems(false);
            }
            else
            {
                EnableItems(true);
            }
            EditServer.Enabled = true;
        }

        private void AdvancedConfig_Click(object sender, EventArgs e)
        {
            ConstConfig f = new ConstConfig();
            f.ShowDialog();
            Comms.SaveServerConfig(Convert.ToInt32(EditServer.Value));
        }

        private void Start_Click(object sender, EventArgs e)
        {
            bool ConfigSuccess = Comms.CreateServerConfig(LocalFold.Text, SerPath.Text);
            if (ConfigSuccess == true)
            {
                bool Success = Running.Run(Convert.ToInt32(EditServer.Value), LocalFold.Text, Console.Checked, VAC.Checked, Graphics.Checked, SerPath.Text);
                if (Success == true)
                {
                    EnableItems(false);
                    Save(true);
                    Notifier.ShowBalloonTip(5000, "Successful Start", "Server " + LocalFold.Text + " with ID " + EditServer.Value + " has been successfully started.", ToolTipIcon.None);
                }
            }
            else
            {
                MessageBox.Show("There was an error creating the configuration for the server, please try again later.");
            }
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            bool Success = Reboot.RebootSer(Convert.ToInt32(EditServer.Value), LocalFold.Text, Console.Checked, VAC.Checked, Graphics.Checked, SerPath.Text);
            if (Success == true)
            {
                EnableItems(false);
                Notifier.ShowBalloonTip(5000, "Successful Restart", "Server " + LocalFold.Text + " with ID " + EditServer.Value + " has been successfully restarted.", ToolTipIcon.None);
            }
        }

        private void Shutdown_Click(object sender, EventArgs e)
        {
            bool Success = ShutdownS.ShutdownSer(Convert.ToInt32(EditServer.Value), LocalFold.Text);
            if (Success == true)
            {
                EnableItems(true);
                Notifier.ShowBalloonTip(5000, "Successful Shutdown", "Server " + LocalFold.Text + " with ID " + EditServer.Value + " has been successfully stopped.", ToolTipIcon.None);
            }
        }

        private void UpdateGUI()
        {
            if (Comms.VAC == true)
            {
                VAC.Checked = true;
            }
            else if (Comms.VAC == false)
            {
                VAC.Checked = false;
            }

            if (Comms.Console == true)
            {
                Console.Checked = true;
            }
            else if (Comms.Console == false)
            {
                Console.Checked = false;
            }

            if (Comms.Graphics == true)
            {
                Graphics.Checked = true;
            }
            else if (Comms.Graphics == false)
            {
                Graphics.Checked = false;
            }

            LocalFold.Text = Comms.LocalName;
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            if (File.Exists(Comms.DataPath + "GUI.dat") == true)
            {
                SaveGUIStatus.LoadGUI();
                Servers2Run.Value = Convert.ToDecimal(SaveGUIStatus.MaxSerS);
                SerPath.Text = SaveGUIStatus.CurrDirS;
            }
        }

        private async void Save(bool Forced)
        {
            if (Forced == true)
            {
                Comms.LocalName = LocalFold.Text;
                Comms.VAC = VAC.Checked;
                Comms.Console = Console.Checked;
                Comms.Graphics = Graphics.Checked;
                Comms.SaveServerConfig(Convert.ToInt32(EditServer.Value));
            }
            else if (Forced == false)
            {
                int c = 0;
                while (c < 50)
                {
                    Comms.LocalName = LocalFold.Text;
                    Comms.VAC = VAC.Checked;
                    Comms.Console = Console.Checked;
                    Comms.Graphics = Graphics.Checked;
                    Comms.SaveServerConfig(Convert.ToInt32(EditServer.Value));
                    await Task.Delay(60000);
                }
            }
        }

        private void EnableItems(bool Inverse)
        {
            if (Inverse == false)
            {
                Start.Enabled = false;
                Shutdown.Enabled = true;
                Restart.Enabled = true;
                LocalFold.Enabled = false;
                AdvancedConfig.Enabled = false;
                Workshop.Enabled = false;
                Plugin.Enabled = false;
                VAC.Enabled = false;
                Graphics.Enabled = false;
                Console.Enabled = false;
            }
            else if (Inverse == true)
            {
                Start.Enabled = true;
                Shutdown.Enabled = false;
                Restart.Enabled = false;
                LocalFold.Enabled = true;
                AdvancedConfig.Enabled = true;
                Workshop.Enabled = true;
                Plugin.Enabled = true;
                VAC.Enabled = true;
                Graphics.Enabled = true;
                Console.Enabled = true;
            }
        }

        private void Manager_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveGUIStatus.SaveGUI(Convert.ToInt32(Servers2Run.Value), SerPath.Text);
        }

        private async void Servers2Run_ValueChanged(object sender, EventArgs e)
        {
            await Task.Delay(1);
            if (Convert.ToInt32(Servers2Run.Value) < Convert.ToInt32(EditServer.Value))
            {
                Servers2Run.Value = EditServer.Value;
            }
        }

        private void Updater_Click(object sender, EventArgs e)
        {
            Updater f = new Updater();
            f.ShowDialog();
        }

        private void Workshop_Click(object sender, EventArgs e)
        {
            if (LocalFold.Text == "")
            {
                MessageBox.Show("No name was set for the local server folder.");
            }
            else if (SerPath.Text == "")
            {
                MessageBox.Show("No server path was set.");
            }
            else
            {
                Comms.LocalName = LocalFold.Text;
                Comms.UnturnedPath = SerPath.Text;
                Workshop f = new Workshop();
                f.ShowDialog();
            }
        }

        private void Plugin_Click(object sender, EventArgs e)
        {
            if (LocalFold.Text == "")
            {
                MessageBox.Show("No name was set for the local server folder.");
            }
            else if (SerPath.Text == "")
            {
                MessageBox.Show("No server path was set.");
            }
            else
            {
                Comms.LocalName = LocalFold.Text;
                Comms.UnturnedPath = SerPath.Text;
                Plugin f = new Plugin();
                f.ShowDialog();
            }
        }
    }
}