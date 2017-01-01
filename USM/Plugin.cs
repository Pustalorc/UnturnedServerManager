using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USM
{
    public partial class Plugin : Form
    {
        private DirectoryInfo ServerDirectory;
        private FileInfo[] InstalledPlugins;
        private string[] DownloadLinks;
        private string[] PluginNames;
        private string[] PluginWebLink;
        private string[] SelectedItems;
        private bool Error = false;

        public Plugin()
        {
            InitializeComponent();
            SearchInstalledItems();
        }

        private void SearchInstalledItems()
        {
            Logger.Log("Loading plugin integrity files...");
            try
            {
                DownloadLinks = File.ReadAllLines(Comms.DataPath + @"PluginLinks.dat");
                PluginNames = File.ReadAllLines(Comms.DataPath + @"Plugins.dat");
                PluginWebLink = File.ReadAllLines(Comms.DataPath + @"PluginPages.dat");
            }
            catch (Exception)
            {
                Logger.Log("Loading of files was unsuccessful, telling player to download the latest version.");
                MessageBox.Show("An error has occured during initalization of the plugin installer. Make sure you have the latest updated integrity files.");
                Error = true;
                Logger.Log("Turning program off.");
                ShutOff();
            }
            if (Error == false)
            {
                Logger.Log("Plugin integrity files loaded.");
                UpdateOptions();
            }
        }

        private async void ShutOff()
        {
            await Task.Delay(50);
            Logger.Log("Closing form.");
            Close();
        }

        private void UpdateOptions()
        {
            Logger.Log("Searching for installed plugins.");
            ServerDirectory = new DirectoryInfo(Comms.UnturnedPath + @"\Servers\" + Comms.LocalName + @"\Rocket\Plugins");
            try
            {
                InstalledPlugins = ServerDirectory.GetFiles();
                Logger.Log("Acquired installed plugins.");
            }
            catch (DirectoryNotFoundException)
            {
                Logger.Log("No installed plugins were found.");
            }
            AvailableItems.Items.Clear();
            AlreadyInstalled.Items.Clear();
            Logger.Log("Cleared display of both lists.");
            if (Directory.Exists(Comms.UnturnedPath + @"\Servers\" + Comms.LocalName + @"\Rocket\Plugins"))
            {
                Logger.Log("Displaying every already installed plugin.");
                foreach (FileInfo File in InstalledPlugins)
                {
                    AlreadyInstalled.Items.Add(File.Name);
                    Logger.Log("Displayed the installed plugin " + File.Name);
                }
            }
            Logger.Log("Displaying available plugins.");
            foreach (string Files in PluginNames)
            {
                AvailableItems.Items.Add(Files);
                Logger.Log("Displayed the plugin " + Files);
            }
        }

        private void Install_Click(object sender, EventArgs e)
        {
            if (AvailableItems.CheckedIndices.Count == 0)
            {
                MessageBox.Show("No plugins were selected.");
                Logger.Log("User attempted to install plugins, but no plugins were selected.");
            }
            else if (AvailableItems.CheckedIndices.Count > 0)
            {
                Logger.Log("Installing selected plugins.");
                GetSelectedItems();
                InstallItems();
                UpdateOptions();
            }
        }

        private void Documentation_Click(object sender, EventArgs e)
        {
            if (AvailableItems.CheckedIndices.Count == 0)
            {
                MessageBox.Show("No plugins were selected.");
                Logger.Log("User attempted to get the documentation of plugins, but no plugins were selected.");
            }
            else if (AvailableItems.CheckedIndices.Count > 0)
            {
                Logger.Log("Displaying documentation of user selected plugins");
                GetSelectedItems();
                OpenWebsite();
                UpdateOptions();
            }
        }

        private void DeleteAll_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Comms.UnturnedPath + @"\Servers\" + Comms.LocalName + @"\Rocket\Plugins") == true)
            {
                Logger.Log("Plugins were found to be installed, user decided to delete all. Deleting folder.");
                Directory.Delete(Comms.UnturnedPath + @"\Servers\" + Comms.LocalName + @"\Rocket\Plugins", true);
                UpdateOptions();
            }
            else
            {
                MessageBox.Show("You have not installed any plugins yet.");
                Logger.Log("User attempted to delete all plugins, but no plugins are installed.");
            }
        }

        private void Configuration_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Comms.UnturnedPath + @"\Servers\" + Comms.LocalName + @"\Rocket\Plugins") == true)
            {
                Process.Start(Comms.UnturnedPath + @"\Servers\" + Comms.LocalName + @"\Rocket\Plugins");
                Logger.Log("Plugins were found to be installed, user decided to open the folder. Opening folder.");
            }
            else
            {
                MessageBox.Show("You have not installed any plugins yet.");
                Logger.Log("User attempted to open the folder of plugins, but no plugins are installed.");
            }
        }

        private void SaveExit_Click(object sender, EventArgs e)
        {
            if (AvailableItems.CheckedIndices.Count > 0)
            {
                Logger.Log("Plugins were selected before exit, installing.");
                GetSelectedItems();
                InstallItems();
            }
            Logger.Log("Closing form.");
            Close();
        }

        private void OpenWebsite()
        {
            for (int i = 0; i < SelectedItems.Length; i++)
            {
                for (int u = 0; u < PluginNames.Length; u++)
                {
                    if (SelectedItems[i] == PluginNames[u])
                    {
                        Process.Start(PluginWebLink[u]);
                    }
                }
            }
        }
        
        private void InstallItems()
        {
            for (int i = 0; i < SelectedItems.Length; i++)
            {
                for (int u = 0; u < PluginNames.Length; u++)
                {
                    if (SelectedItems[i] == PluginNames[u])
                    {
                        Downloader.GetReady();
                        Downloader.Download(DownloadLinks[u], SelectedItems[i]);
                        if (Directory.Exists(Comms.UnturnedPath + @"\Servers\" + Comms.LocalName + @"\Rocket\Plugins") == false)
                        {
                            Directory.CreateDirectory(Comms.UnturnedPath + @"\Servers\" + Comms.LocalName + @"\Rocket\Plugins");
                        }
                        Downloader.Extract(SelectedItems[i], Comms.UnturnedPath + @"\Servers\" + Comms.LocalName + @"\Rocket\Plugins");
                    }
                }
            }
            if (Directory.Exists(Comms.UnturnedPath + @"\Servers\" + Comms.LocalName + @"\Rocket\Plugins\Libraries") == true)
            {
                if (Directory.Exists(Comms.UnturnedPath + @"\Servers\" + Comms.LocalName + @"\Rocket\Libraries") == true)
                {
                    Directory.Delete(Comms.UnturnedPath + @"\Servers\" + Comms.LocalName + @"\Rocket\Libraries", true);
                }
                Directory.Move(Comms.UnturnedPath + @"\Servers\" + Comms.LocalName + @"\Rocket\Plugins\Libraries", Comms.UnturnedPath + @"\Servers\" + Comms.LocalName + @"\Rocket\Libraries");
            }
        }

        private void GetSelectedItems()
        {
            SelectedItems = new string[AvailableItems.CheckedIndices.Count];
            for (int i = 0; i < AvailableItems.CheckedIndices.Count; i++)
            {
                SelectedItems[i] = Convert.ToString(AvailableItems.CheckedItems[i]);
            }
        }
    }
}
