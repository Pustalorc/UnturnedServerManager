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
    public partial class Workshop : Form
    {
        private DirectoryInfo WorkshopDirectory;
        private DirectoryInfo[] WorkshopItems;
        private DirectoryInfo[] ContentInstalled;
        private DirectoryInfo[] MapsInstalled;
        private string[] SelectedItems;
        public Workshop()
        {
            InitializeComponent();

            WorkshopDirectory = new DirectoryInfo(WorkshopLocation.Text);
            SearchDownloadedItems();
        }

        private void SearchDownloadedItems()
        {
            try
            {
                WorkshopItems = WorkshopDirectory.GetDirectories();
                UpdateOptions();
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("Selected location has no mods or does not exist.");
            }
        }

        private void UpdateOptions()
        {
            foreach (DirectoryInfo folder in WorkshopItems)
            {
                AvailableItems.Items.Add(folder.Name);
            }
            // Check for Already Installed Mods In Content Folder
            RefreshInstalledContent();
        }

        private void RefreshInstalledContent()
        {
            AlreadyInstalled.Enabled = true;
            if (ContentLocation.Checked == true)
            {
                try
                {
                    DirectoryInfo Contents = new DirectoryInfo(Comms.UnturnedPath + @"\Servers\" + Comms.LocalName + @"\Workshop\Content");
                    ContentInstalled = Contents.GetDirectories();
                    // Check For Installed Content
                    AlreadyInstalled.Items.Clear();
                    foreach (DirectoryInfo folder in ContentInstalled)
                    {
                        AlreadyInstalled.Items.Add(folder.Name);
                    }
                }
                catch (DirectoryNotFoundException)
                {
                    AlreadyInstalled.Items.Clear();
                    // No current mods. Ignore but remove already placed items;
                }
            }
            else if (MapsLocation.Checked == true)
            {
                // Check for already installed mods in the "maps" folder
                try
                {
                    DirectoryInfo Maps = new DirectoryInfo(Comms.UnturnedPath + @"\Servers\" + Comms.LocalName + @"\Workshop\Maps");
                    MapsInstalled = Maps.GetDirectories();
                    // Check For Installed Maps
                    AlreadyInstalled.Items.Clear();
                    foreach (DirectoryInfo folder in MapsInstalled)
                    {
                        AlreadyInstalled.Items.Add(folder.Name);
                    }
                }
                catch (DirectoryNotFoundException)
                {
                    AlreadyInstalled.Items.Clear();
                    // No current mods. Ignore but remove already placed items.
                }
            }
            AlreadyInstalled.Enabled = false;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            AvailableItems.Items.Clear();
            WorkshopDirectory = new DirectoryInfo(WorkshopLocation.Text);
            SearchDownloadedItems();
        }

        private void CopyDirectory(string Source, string Destination, bool Subdirectories)
        {
            DirectoryInfo dir = new DirectoryInfo(Source);
            DirectoryInfo[] dirs = dir.GetDirectories();

            if (!Directory.Exists(Destination))
            {
                Directory.CreateDirectory(Destination);
            }

            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                if (!File.Exists(Destination))
                {
                    //
                }
                else
                {
                    string temppath = Path.Combine(Destination, file.Name);
                    file.CopyTo(temppath, false);
                }
            }

            if (Subdirectories)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(Destination, subdir.Name);
                    CopyDirectory(subdir.FullName, temppath, Subdirectories);
                }
            }
        }

        private void SaveExit_Click(object sender, EventArgs e)
        {
            SelectedItems = new string[AvailableItems.CheckedIndices.Count];
            if (ContentLocation.Checked == true)
            {
                for (int i = 0; i <= AvailableItems.CheckedIndices.Count - 1; i++)
                {
                    SelectedItems[i] = Convert.ToString(AvailableItems.CheckedItems[i]);
                }
                foreach (string file in SelectedItems)
                {
                    CopyDirectory(@"" + WorkshopDirectory.FullName + @"\" + file, @"" + Comms.UnturnedPath + @"\Servers\" + Comms.LocalName + @"\Workshop\Content\" + file, true);
                }
            }
            else if (MapsLocation.Checked == true)
            {
                for (int i = 0; i <= AvailableItems.CheckedIndices.Count - 1; i++)
                {
                    SelectedItems[i] = Convert.ToString(AvailableItems.CheckedItems[i]);
                }
                foreach (string file in SelectedItems)
                {
                    CopyDirectory(@"" + WorkshopDirectory.FullName + @"\" + file, @"" + Comms.UnturnedPath + @"\Servers\" + Comms.LocalName + @"\Workshop\Maps\" + file, true);
                }
            }
            Close();
        }

        private void Install_Click(object sender, EventArgs e)
        {
            SelectedItems = new string[AvailableItems.CheckedIndices.Count];
            if (AvailableItems.CheckedItems.Count == 0)
            {
                MessageBox.Show("No Items Are Selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (AvailableItems.CheckedItems.Count > 0)
            {
                if (ContentLocation.Checked == true)
                {
                    for (int i = 0; i <= AvailableItems.CheckedIndices.Count - 1; i++)
                    {
                        SelectedItems[i] = Convert.ToString(AvailableItems.CheckedItems[i]);
                    }
                    foreach (string file in SelectedItems)
                    {
                        CopyDirectory(@"" + WorkshopDirectory.FullName + @"\" + file, @"" + Comms.UnturnedPath + @"\Servers\" + Comms.LocalName + @"\Workshop\Content\" + file, true);
                    }
                }
                else if (MapsLocation.Checked == true)
                {
                    for (int i = 0; i <= AvailableItems.CheckedIndices.Count - 1; i++)
                    {
                        SelectedItems[i] = Convert.ToString(AvailableItems.CheckedItems[i]);
                    }
                    foreach (string file in SelectedItems)
                    {
                        CopyDirectory(@"" + WorkshopDirectory.FullName + @"\" + file, @"" + Comms.UnturnedPath + @"\Servers\" + Comms.LocalName + @"\Workshop\Maps\" + file, true);
                    }
                }
                AvailableItems.Items.Clear();
                WorkshopDirectory = new DirectoryInfo(WorkshopLocation.Text);
                SearchDownloadedItems();
            }
        }

        private void DeleteAll_Click(object sender, EventArgs e)
        {
            Directory.Delete(@"" + Comms.UnturnedPath + @"\Servers\" + Comms.LocalName + @"\Workshop", true);
            RefreshInstalledContent();
        }

        private void ContentLocation_CheckedChanged(object sender, EventArgs e)
        {
            RefreshInstalledContent();
        }

        private void MapsLocation_CheckedChanged(object sender, EventArgs e)
        {
            RefreshInstalledContent();
        }

        private void OpenMods_Click(object sender, EventArgs e)
        {
            SelectedItems = new string[AvailableItems.CheckedIndices.Count];
            if (AvailableItems.CheckedItems.Count == 0)
            {
                MessageBox.Show("No Items Are Selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (AvailableItems.CheckedItems.Count > 0)
            {
                for (int i = 0; i <= AvailableItems.CheckedIndices.Count - 1; i++)
                {
                    SelectedItems[i] = Convert.ToString(AvailableItems.CheckedItems[i]);
                }
                foreach (string file in SelectedItems)
                {
                    Process.Start("http://steamcommunity.com/sharedfiles/filedetails/?id=" + file);
                }
            }
        }
    }
}
