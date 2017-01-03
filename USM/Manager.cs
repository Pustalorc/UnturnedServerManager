using System;
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
            BuildNotifyMenu();
            CheckLatestVersion();
            Notifier.Visible = true;
            Logger.Log("Enabled tray icon.");
            if (File.Exists(Comms.DataPath + "Server_ID_1_Config.dat"))
            {
                Logger.Log("Config file for server id 1 found, loading data.");
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
                Logger.Log("No config file for server id 1 was found, setting default data.");
            }
            Desc4.Text = "Currently Editing Server With ID: 1";
            Logger.Log("Set Desc4's text to \"Currently Editing Server With ID: 1\".");
            Save(false);
            Logger.Log("Enabled auto-save every 60 seconds.");
            CheckRocket();
            EditServer.Maximum = Servers2Run.Value;
            DisablePathSetting();
            CheckIfAServerIsRunning();
        }

        private async void DisablePathSetting()
        {
            int c = 0;
            while (c < 500)
            {
                if (Comms.AServerIsRunning == true)
                {
                    SerPath.ReadOnly = false;
                    SerPath.Enabled = false;
                }
                else if (Comms.AServerIsRunning == false)
                {
                    SerPath.ReadOnly = true;
                    SerPath.Enabled = true;
                }
                await Task.Delay(1);
            }
        }

        private async void CheckIfAServerIsRunning()
        {
            int c = 0;
            while (c < 500)
            {
                foreach (int id in Comms.RunningID)
                {
                    if (id != 0)
                    {
                        Comms.AServerIsRunning = true;
                        break;
                    }
                    else if (id == 0)
                    {
                        Comms.AServerIsRunning = false;
                    }
                }
                await Task.Delay(1);
            }
        }

        private void BuildNotifyMenu()
        {
            ContextMenu Menu = new ContextMenu();
            MenuItem Exit = new MenuItem();
            MenuItem Github = new MenuItem();
            MenuItem Reddit = new MenuItem();
            MenuItem Issues = new MenuItem();
            IContainer Components = new Container();
            Menu.MenuItems.AddRange( new MenuItem[] { Exit, Github, Reddit, Issues });
            Exit.Index = 0;
            Exit.Text = "Exit";
            Exit.Click += new EventHandler(Exit_Click);
            Github.Index = 0;
            Github.Text = "Github";
            Github.Click += new EventHandler(Github_Click);
            Reddit.Index = 0;
            Reddit.Text = "Reddit";
            Reddit.Click += new EventHandler(Reddit_Click);
            Issues.Index = 0;
            Issues.Text = "Issues And Suggestions";
            Issues.Click += new EventHandler(Issues_Click);
            Notifier.ContextMenu = Menu;
            Logger.Log("Tray icon menu successfully set.");
        }

        private void Notifier_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Comms.FormEnabled == false)
            {
                Show();
                Comms.FormEnabled = true;
                Logger.Log("Displayed the form.");
            }
            else if (Comms.FormEnabled == true)
            {
                Hide();
                Comms.FormEnabled = false;
                Logger.Log("Hid the form.");
            }
        }

        private void Exit_Click(object Sender, EventArgs e)
        {
            Logger.Log("Closed application.");
            Application.Exit();
        }

        private void Github_Click(object Sender, EventArgs e)
        {
            Process.Start("https://github.com/persiafighter/UnturnedServerManager/");
            Logger.Log("Opening website \"https://github.com/persiafighter/UnturnedServerManager/\".");
        }

        private void Issues_Click(object Sender, EventArgs e)
        {
            Process.Start("https://github.com/persiafighter/UnturnedServerManager/issues");
            Logger.Log("Opening website \"https://github.com/persiafighter/UnturnedServerManager/issues\".");
        }

        private void Reddit_Click(object Sender, EventArgs e)
        {
            Process.Start("https://www.reddit.com/r/unturned/comments/546y67/unturned_server_manager/");
            Logger.Log("Opening website \"https://www.reddit.com/r/unturned/comments/546y67/unturned_server_manager/\".");
        }

        private async void CheckRocket()
        {
            Logger.Log("Started loop to check if rocket is installed.");
            int c = 0;
            while (c < 500)
            {
                if (Comms.RunningID[(Convert.ToInt32(EditServer.Value) - 1)] == Convert.ToInt32(EditServer.Value))
                {

                }
                else
                {
                    Comms.UnturnedPath = SerPath.Text;
                    if (Directory.Exists(Comms.UnturnedPath + @"\Modules") == false || File.Exists(Comms.UnturnedPath + @"\Modules\Rocket.Unturned\English.dat") == false || File.Exists(Comms.UnturnedPath + @"\Modules\Rocket.Unturned\Icon.png") == false || File.Exists(Comms.UnturnedPath + @"\Modules\Rocket.Unturned\LICENSE") == false || File.Exists(Comms.UnturnedPath + @"\Modules\Rocket.Unturned\README") == false || File.Exists(Comms.UnturnedPath + @"\Modules\Rocket.Unturned\Rocket.API.dll") == false || File.Exists(Comms.UnturnedPath + @"\Modules\Rocket.Unturned\Rocket.Core.dll") == false || File.Exists(Comms.UnturnedPath + @"\Modules\Rocket.Unturned\Rocket.Unturned.dll") == false || File.Exists(Comms.UnturnedPath + @"\Modules\Rocket.Unturned\Rocket.Unturned.module") == false)
                    {
                        Plugin.Enabled = false;
                    }
                    else if (Directory.Exists(Comms.UnturnedPath + @"\Modules") == true && File.Exists(Comms.UnturnedPath + @"\Modules\Rocket.Unturned\English.dat") == true && File.Exists(Comms.UnturnedPath + @"\Modules\Rocket.Unturned\Icon.png") == true && File.Exists(Comms.UnturnedPath + @"\Modules\Rocket.Unturned\LICENSE") == true && File.Exists(Comms.UnturnedPath + @"\Modules\Rocket.Unturned\README") == true && File.Exists(Comms.UnturnedPath + @"\Modules\Rocket.Unturned\Rocket.API.dll") == true && File.Exists(Comms.UnturnedPath + @"\Modules\Rocket.Unturned\Rocket.Core.dll") == true && File.Exists(Comms.UnturnedPath + @"\Modules\Rocket.Unturned\Rocket.Unturned.dll") == true && File.Exists(Comms.UnturnedPath + @"\Modules\Rocket.Unturned\Rocket.Unturned.module") == true)
                    {
                        Plugin.Enabled = true;
                    }
                }
                await Task.Delay(1);
            }
        }

        private void CheckLatestVersion()
        {
            Logger.Log("Checking latest version for USM.");
            try
            {
                Downloader.GetReady();
                Logger.Log("Created temp download folder.");
                Downloader.Download("https://github.com/persiafighter/UnturnedServerManager/raw/master/Data/USMVer.dat", "USM.dat");
                Logger.Log("Downloaded latest version file for USM.");
                string LatestVersion = File.ReadAllLines(Downloader.Temp + @"\USM.dat")[0];
                Logger.Log("Read data from latest USM version.");
                if (LatestVersion != "3.0.0.5")
                {
                    Logger.Log("Version of the program is different than the latest one. Opened notification of a new update.");
                    Notifier.ShowBalloonTip(5000, "New Version", "A new version for Unturned Server Manager is available! Head over to the github page for more information. Your version: 3.0.0.5, Latest Version: " + LatestVersion + ".", ToolTipIcon.None);
                }
                Downloader.ShutOff();
                Logger.Log("Deleted temp download folder.");
            }
            catch (Exception)
            {
                // Ignore, offline mode or unable to retrieve version file.
                Logger.Log("Unable to check for latest version, starting program.");
            }
        }

        private void RedditLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.reddit.com/r/unturned/comments/546y67/unturned_server_manager/");
            Logger.Log("Opening website \"https://www.reddit.com/r/unturned/comments/546y67/unturned_server_manager/\".");
        }

        private void GithubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/persiafighter/UnturnedServerManager/");
            Logger.Log("Opening website \"https://github.com/persiafighter/UnturnedServerManager/\".");
        }

        private void LinkMe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://persiafighter.github.io/");
            Logger.Log("Opening website \"https://persiafighter.github.io/\".");
        }

        private void EditServer_ValueChanged(object sender, EventArgs e)
        {
            Logger.Log("Selected server for edit was changed to " + EditServer.Value);
            EditServer.Enabled = false;
            Servers2Run.Minimum = EditServer.Value;
            Desc4.Text = "Currently Editing Server With ID: " + EditServer.Value;
            if (File.Exists(@"C:\Unturned_Manager\Server_ID_" + EditServer.Value + "_Config.dat"))
            {
                Logger.Log("Configuration file was found for server with id " + EditServer.Value + ", loading data.");
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
                Logger.Log("No configuration file was found for server with id " + EditServer.Value + ", using default values.");
                Comms.ConfigExists = false;
                LocalFold.Text = "";
                VAC.Checked = true;
                Graphics.Checked = true;
                Console.Checked = true;
            }
            if (Comms.RunningID[(Convert.ToInt32(EditServer.Value) - 1)] == Convert.ToInt32(EditServer.Value))
            {
                EnableItems(false);
                Logger.Log("Server is already running, disabling buttons.");
            }
            else
            {
                EnableItems(true);
                Logger.Log("Server is not running, enabling buttons.");
            }
            EditServer.Enabled = true;
        }

        private void AdvancedConfig_Click(object sender, EventArgs e)
        {
            ConstConfig f = new ConstConfig();
            Logger.Log("Starting server config editor.");
            f.ShowDialog();
            Comms.SaveServerConfig(Convert.ToInt32(EditServer.Value));
            Logger.Log("Saving server config.");
            Save(true);
            Logger.Log("Forcing a global save.");
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Logger.Log("Trying to initiate the server...");
            bool ConfigSuccess = Comms.CreateServerConfig(LocalFold.Text, SerPath.Text);
            if (ConfigSuccess == true)
            {
                Logger.Log("Config was successfully created. Trying to start server.");
                bool Success = Running.Run(Convert.ToInt32(EditServer.Value), LocalFold.Text, Console.Checked, VAC.Checked, Graphics.Checked, SerPath.Text);
                if (Success == true)
                {
                    Logger.Log("Server was successfully started.");
                    EnableItems(false);
                    Logger.Log("Disabling buttons.");
                    Save(true);
                    Logger.Log("Forcing a global save.");
                    Notifier.ShowBalloonTip(5000, "Successful Start", "Server " + LocalFold.Text + " with ID " + EditServer.Value + " has been successfully started.", ToolTipIcon.None);
                    Logger.Log("Sent notification to user.");
                }
                else
                {
                    MessageBox.Show("There was an error starting the server.");
                    Logger.Log("Server wasn't started. An error was encountered.");
                }
            }
            else
            {
                MessageBox.Show("There was an error creating the configuration for the server, please try again later.");
                Logger.Log("Forcing a global save.");
            }
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            Logger.Log("Attempting to restart server...");
            bool Success = Reboot.RebootSer(Convert.ToInt32(EditServer.Value), LocalFold.Text, Console.Checked, VAC.Checked, Graphics.Checked, SerPath.Text);
            if (Success == true)
            {
                Logger.Log("Server was successfully restarted.");
                EnableItems(false);
                Logger.Log("Disabling buttons.");
                Notifier.ShowBalloonTip(5000, "Successful Restart", "Server " + LocalFold.Text + " with ID " + EditServer.Value + " has been successfully restarted.", ToolTipIcon.None);
                Logger.Log("Sent notification to user.");
            }
            else
            {
                MessageBox.Show("There was an error during the restart of the server.");
                Logger.Log("Restarting of server failed.");
                EnableItems(true);
                Logger.Log("Enabling buttons.");
            }
        }

        private void Shutdown_Click(object sender, EventArgs e)
        {
            Logger.Log("Attempting to shut the server off.");
            bool Success = ShutdownS.ShutdownSer(Convert.ToInt32(EditServer.Value), LocalFold.Text);
            if (Success == true)
            {
                EnableItems(true);
                Logger.Log("Enabling buttons.");
                Notifier.ShowBalloonTip(5000, "Successful Shutdown", "Server " + LocalFold.Text + " with ID " + EditServer.Value + " has been successfully stopped.", ToolTipIcon.None);
                Logger.Log("Notifying user.");
            }
            else
            {
                MessageBox.Show("There was an error during the shutdown of the server.");
                Logger.Log("Shutdown of server failed.");
                EnableItems(true);
                Logger.Log("Enabling buttons.");
            }
        }

        private void UpdateGUI()
        {
            Logger.Log("Updating GUI items from local loaded data.");
            if (Comms.VAC == true)
            {
                VAC.Checked = true;
                Logger.Log("Checked VAC checkbox.");
            }
            else if (Comms.VAC == false)
            {
                VAC.Checked = false;
                Logger.Log("Unchecked VAC checkbox.");
            }

            if (Comms.Console == true)
            {
                Console.Checked = true;
                Logger.Log("Checked Console checkbox.");
            }
            else if (Comms.Console == false)
            {
                Console.Checked = false;
                Logger.Log("Unchecked Console checkbox.");
            }

            if (Comms.Graphics == true)
            {
                Graphics.Checked = true;
                Logger.Log("Checked Graphics checkbox.");
            }
            else if (Comms.Graphics == false)
            {
                Graphics.Checked = false;
                Logger.Log("Unchecked Graphics checkbox.");
            }

            LocalFold.Text = Comms.LocalName;
            Logger.Log("Set local folder text.");
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            if (File.Exists(Comms.DataPath + "GUI.dat") == true)
            {
                Logger.Log("Old GUI data was found, loading.");
                SaveGUIStatus.LoadGUI();
                Servers2Run.Value = Convert.ToDecimal(SaveGUIStatus.MaxSerS);
                Logger.Log("Loaded last maximum servers value.");
                SerPath.Text = SaveGUIStatus.CurrDirS;
                Logger.Log("Loaded server path to textbox.");
            }
        }

        private async void Save(bool Forced)
        {
            if (Forced == true)
            {
                Logger.Log("A save was forced, saving data.");
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
                    Logger.Log("Periodic timeout for save is over. Saving data.");
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
            Logger.Log("Saving latest GUI data.");
            SaveGUIStatus.SaveGUI(Convert.ToInt32(Servers2Run.Value), SerPath.Text);
        }

        private void Servers2Run_ValueChanged(object sender, EventArgs e)
        {
            Save(true);
            Logger.Log("Forcing save of data.");
            EditServer.Maximum = Servers2Run.Value;
        }

        private void Updater_Click(object sender, EventArgs e)
        {
            Logger.Log("Attempting to run the update tool...");
            if (SerPath.Text == "")
            {
                MessageBox.Show("No server path was set.");
                Logger.Log("Unable to run the update tool, no path was set.");
            }
            else
            {
                Comms.UnturnedPath = SerPath.Text;
                Updater f = new Updater();
                Logger.Log("Displaying the update tool.");
                f.ShowDialog();
            }
        }

        private void Workshop_Click(object sender, EventArgs e)
        {
            Logger.Log("Attempting to run the workshop installer tool...");
            if (LocalFold.Text == "")
            {
                MessageBox.Show("No name was set for the local server folder.");
                Logger.Log("Unable to run the workshop installer tool, no name for the server was set.");
            }
            else if (SerPath.Text == "")
            {
                MessageBox.Show("No server path was set.");
                Logger.Log("Unable to run the workshop installer tool, no path was set.");
            }
            else
            {
                Comms.LocalName = LocalFold.Text;
                Comms.UnturnedPath = SerPath.Text;
                Workshop f = new Workshop();
                Logger.Log("Displaying the workshop installer tool.");
                f.ShowDialog();
            }
        }

        private void Plugin_Click(object sender, EventArgs e)
        {
            Logger.Log("Attempting to run the plugin installer tool...");
            if (LocalFold.Text == "")
            {
                MessageBox.Show("No name was set for the local server folder.");
                Logger.Log("Unable to run the plugin installer tool, no server name was set.");
            }
            else if (SerPath.Text == "")
            {
                MessageBox.Show("No server path was set.");
                Logger.Log("Unable to run the plugin installer tool, no path was set.");
            }
            else
            {
                Comms.LocalName = LocalFold.Text;
                Comms.UnturnedPath = SerPath.Text;
                Plugin f = new Plugin();
                Logger.Log("Displaying the plugin installer tool.");
                f.ShowDialog();
            }
        }

        private void LocalFold_TextChanged(object sender, EventArgs e)
        {
            Save(true);
            Logger.Log("Forcing save of data.");
        }

        private void Console_CheckedChanged(object sender, EventArgs e)
        {
            Save(true);
            Logger.Log("Forcing save of data.");
        }

        private void Graphics_CheckedChanged(object sender, EventArgs e)
        {
            Save(true);
            Logger.Log("Forcing save of data.");
        }

        private void VAC_CheckedChanged(object sender, EventArgs e)
        {
            Save(true);
            Logger.Log("Forcing save of data.");
        }
    }
}
