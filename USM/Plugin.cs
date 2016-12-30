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
            try
            {
                DownloadLinks = File.ReadAllLines(Comms.DataPath + @"PluginLinks.dat");
                PluginNames = File.ReadAllLines(Comms.DataPath + @"Plugins.dat");
                PluginWebLink = File.ReadAllLines(Comms.DataPath + @"PluginPages.dat");
            }
            catch (Exception)
            {
                MessageBox.Show("An error has occured during initalization of the plugin installer. Make sure you have the latest updated integrity files.");
                Error = true;
                ShutOff();
            }
            if (Error == false)
            {
                UpdateOptions();
            }
        }

        private async void ShutOff()
        {
            await Task.Delay(50);
            Close();
        }

        private void UpdateOptions()
        {
            ServerDirectory = new DirectoryInfo(Comms.UnturnedPath + @"\Servers\" + Comms.LocalName + @"\Rocket\Plugins");
            try
            {
                InstalledPlugins = ServerDirectory.GetFiles();
            }
            catch (DirectoryNotFoundException)
            {
                // Ignore, no current files installed
            }
            AvailableItems.Items.Clear();
            AlreadyInstalled.Items.Clear();
            if (Directory.Exists(Comms.UnturnedPath + @"\Servers\" + Comms.LocalName + @"\Rocket\Plugins"))
            {
                foreach (FileInfo File in InstalledPlugins)
                {
                    AlreadyInstalled.Items.Add(File.Name);
                }
            }
            foreach (string Files in PluginNames)
            {
                AvailableItems.Items.Add(Files);
            }
        }

        private void Install_Click(object sender, EventArgs e)
        {
            if (AvailableItems.CheckedIndices.Count == 0)
            {
                MessageBox.Show("No plugins were selected.");
            }
            else if (AvailableItems.CheckedIndices.Count > 0)
            {
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
            }
            else if (AvailableItems.CheckedIndices.Count > 0)
            {
                GetSelectedItems();
                OpenWebsite();
                UpdateOptions();
            }
        }

        private void DeleteAll_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Comms.UnturnedPath + @"\Servers\" + Comms.LocalName + @"\Rocket\Plugins") == true)
            {
                Directory.Delete(Comms.UnturnedPath + @"\Servers\" + Comms.LocalName + @"\Rocket\Plugins", true);
                UpdateOptions();
            }
            else
            {
                MessageBox.Show("You have not installed any plugins yet.");
            }
        }

        private void Configuration_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Comms.UnturnedPath + @"\Servers\" + Comms.LocalName + @"\Rocket\Plugins") == true)
            {
                Process.Start(Comms.UnturnedPath + @"\Servers\" + Comms.LocalName + @"\Rocket\Plugins");
            }
            else
            {
                MessageBox.Show("You have not installed any plugins yet.");
            }
        }

        private void SaveExit_Click(object sender, EventArgs e)
        {
            if (AvailableItems.CheckedIndices.Count > 0)
            {
                GetSelectedItems();
                InstallItems();
            }
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
