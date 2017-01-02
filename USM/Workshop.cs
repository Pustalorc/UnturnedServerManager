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
        }

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                WorkshopDirectory = new DirectoryInfo(WorkshopLocation.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("The path set is not a directory path.");
                return;
            }
            AvailableItems.Items.Clear();
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
            if (Directory.Exists(Comms.UnturnedPath + @"\Servers\" + Comms.LocalName + @"\Workshop") == false)
            {
                MessageBox.Show("You haven't installed any workshop mods yet.");
                return;
            }
            else
            {
                Directory.Delete(@"" + Comms.UnturnedPath + @"\Servers\" + Comms.LocalName + @"\Workshop", true);
                RefreshInstalledContent();
            }
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

        private void ID_TextChanged(object sender, EventArgs e)
        {
            if (ID.Text == "")
            {
                Link.Text = "";
            }
        }

        private void Link_TextChanged(object sender, EventArgs e)
        {
            char[] LettersAndSymbols = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '.', '/', ':', '=', '?'};
            string post1 = Link.Text.TrimStart(LettersAndSymbols);
            ID.Text = post1.TrimEnd(LettersAndSymbols);
        }

        private void InstallID_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Comms.DataPath + "SteamCMD") == false)
            {
                Directory.CreateDirectory(Comms.DataPath + "SteamCMD");
            }
            try
            {
                if (File.Exists(Comms.DataPath + @"SteamCMD\steamcmd.exe") == false)
                {
                    Downloader.Download("https://steamcdn-a.akamaihd.net/client/installer/steamcmd.zip", "steamcmd.zip");
                    Downloader.Extract("steamcmd.zip", Comms.DataPath + @"SteamCMD\");
                }
                Process SteamCMD = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = Comms.DataPath + @"SteamCMD\steamcmd.exe";
                startInfo.Arguments = " +login unturnedrocksupdate force_update +workshop_download_item 304930 " + ID.Text + " +quit";
                SteamCMD.StartInfo = startInfo;
                SteamCMD.Start();
                SteamCMD.WaitForExit();
                if (MapsLocation.Checked == true)
                {
                    Directory.Move(Comms.DataPath + @"SteamCMD\steamapps\workshop\content\304930\" + ID.Text, Comms.UnturnedPath + @"\Servers\" + Comms.LocalName + @"\Workshop\Maps\" + ID.Text);
                }
                else if (ContentLocation.Checked == true)
                {
                    Directory.Move(Comms.DataPath + @"SteamCMD\steamapps\workshop\content\304930\" + ID.Text, Comms.UnturnedPath + @"\Servers\" + Comms.LocalName + @"\Workshop\Content\" + ID.Text);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error has been encountered during the download of the item.");
            }
        }

        private void UpdateAll_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Comms.UnturnedPath + @"\Servers\" + Comms.LocalName + @"\Workshop") == false)
            {
                MessageBox.Show("There are no workshop items installed.");
                return;
            }
            else if (Directory.Exists(Comms.UnturnedPath + @"\Servers\" + Comms.LocalName + @"\Workshop") == true)
            {
                if (Directory.Exists(Comms.DataPath + "SteamCMD") == false)
                {
                    Directory.CreateDirectory(Comms.DataPath + "SteamCMD");
                }
                try
                {
                    if (File.Exists(Comms.DataPath + @"SteamCMD\steamcmd.exe") == false)
                    {
                        Downloader.Download("https://steamcdn-a.akamaihd.net/client/installer/steamcmd.zip", "steamcmd.zip");
                        Downloader.Extract("steamcmd.zip", Comms.DataPath + @"SteamCMD\");
                    }
                    DirectoryInfo Contents = new DirectoryInfo(Comms.UnturnedPath + @"\Servers\" + Comms.LocalName + @"\Workshop\Content");
                    DirectoryInfo Maps = new DirectoryInfo(Comms.UnturnedPath + @"\Servers\" + Comms.LocalName + @"\Workshop\Maps");
                    ContentInstalled = Contents.GetDirectories();
                    MapsInstalled = Maps.GetDirectories();
                    foreach (DirectoryInfo folder in ContentInstalled)
                    {
                        Process SteamCMD = new Process();
                        ProcessStartInfo startInfo = new ProcessStartInfo();
                        startInfo.FileName = Comms.DataPath + @"SteamCMD\steamcmd.exe";
                        startInfo.Arguments = " +login unturnedrocksupdate force_update +workshop_download_item 304930 " + folder.Name + " +exit";
                        SteamCMD.StartInfo = startInfo;
                        SteamCMD.Start();
                        SteamCMD.WaitForExit();
                        Directory.Move(Comms.DataPath + @"SteamCMD\steamapps\workshop\content\304930\" + folder.Name, Comms.UnturnedPath + @"\Servers\" + Comms.LocalName + @"\Workshop\Content\" + folder.Name);
                    }
                    foreach (DirectoryInfo folder in MapsInstalled)
                    {
                        Process SteamCMD = new Process();
                        ProcessStartInfo startInfo = new ProcessStartInfo();
                        startInfo.FileName = Comms.DataPath + @"SteamCMD\steamcmd.exe";
                        startInfo.Arguments = " +login unturnedrocksupdate force_update +workshop_download_item 304930 " + folder.Name + " +exit";
                        SteamCMD.StartInfo = startInfo;
                        SteamCMD.Start();
                        SteamCMD.WaitForExit();
                        Directory.Move(Comms.DataPath + @"SteamCMD\steamapps\workshop\content\304930\" + folder.Name, Comms.UnturnedPath + @"\Servers\" + Comms.LocalName + @"\Workshop\Maps\" + folder.Name);
                    }
                    RefreshInstalledContent();
                }
                catch (Exception)
                {
                    MessageBox.Show("An error has been encountered during the download of the item.");
                }
            }
        }
    }
}
