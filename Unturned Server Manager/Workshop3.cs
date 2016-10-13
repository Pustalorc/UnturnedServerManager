using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unturned_Server_Manager
{
    public partial class Workshop3 : Form
    {
        private string WorkshopDirectory;
        private string[] WorkshopItems;
        private string[] ContentInstalled;
        private string[] MapsInstalled;
        private string[] SelectedItems;
        public Workshop3()
        {
            InitializeComponent();
            WorkshopDirectory = WorkshopLocation.Text;
            SearchDownloadedItems();
        }

        private void SearchDownloadedItems()
        {
            try
            {
                WorkshopItems = Directory.GetDirectories(WorkshopDirectory);
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("Current Selected location has no mods or does not exist.");
            }
            UpdateOptions();
        }

        private void UpdateOptions()
        {
            int AmmountOfItems = WorkshopItems.Length;
            char[] Characters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', ':', ' ', '(', '8', '6', ')', '\\', '#', '@', '!', '$', '%', '^', '&', '*', '-', '_', '=', '+', ';', ':', '\'', '\"', '|', '`', '~', ',', '<', '.', '>', '/', '?'};
            char[] Characters2 = { '3', '0', '4', '9'};
            char[] Characters3 = { '\\' };
            string[] WorkshopItemsTrim1 = new string[WorkshopItems.Length];
            string[] WorkshopItemsTrim2 = new string[WorkshopItems.Length];
            for (int i = 0; i <= AmmountOfItems - 1; i++)
            {
                WorkshopItemsTrim1[i] = WorkshopItems[i].TrimStart(Characters);
            }
            for (int i = 0; i <= AmmountOfItems - 1; i++)
            {
                WorkshopItemsTrim2[i] = WorkshopItemsTrim1[i].TrimStart(Characters2);
            }
            for (int i = 0; i <= AmmountOfItems - 1; i++)
            {
                AvailableItems.Items.Add(WorkshopItemsTrim2[i].TrimStart(Characters3));
            }
            // Check for Already Installed Mods In Content Folder
            RefreshInstalledContent();
        }

        private void RefreshInstalledContent()
        {
            AlreadyInstalled.Enabled = true;
            char[] Characters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', ':', ' ', '(', '8', '6', ')', '\\', '#', '@', '!', '$', '%', '^', '&', '*', '-', '_', '=', '+', ';', ':', '\'', '\"', '|', '`', '~', ',', '<', '.', '>', '/', '?' };
            char[] Characters2 = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            char[] Characters3 = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', ':', ' ', '(', ')', '\\', '#', '@', '!', '$', '%', '^', '&', '*', '-', '_', '=', '+', ';', ':', '\'', '\"', '|', '`', '~', ',', '<', '.', '>', '/', '?' };
            if (ContentLocation.Checked == true)
            {
                try
                {
                    ContentInstalled = Directory.GetDirectories(DataContainer.ServerPath + @"\Servers\" + DataContainer.FolderName3+ @"\Workshop\Content");
                    string[] ContentInstalledTrim = new string[ContentInstalled.Length];
                    string[] ContentInstalledTrim2 = new string[ContentInstalledTrim.Length];
                    string[] ContentInstalledTrim3 = new string[ContentInstalledTrim2.Length];
                    int LengthContent = ContentInstalled.Length;
                    // Check For Installed Content
                    try
                    {
                        for (int i = 0; i <= LengthContent - 1; i++)
                        {
                            ContentInstalledTrim[i] = ContentInstalled[i].TrimStart(Characters);
                        }
                        for (int i = 0; i <= LengthContent - 1; i++)
                        {
                            ContentInstalledTrim2[i] = ContentInstalledTrim[i].TrimStart(Characters2);
                        }
                        for (int i = 0; i <= LengthContent - 1; i++)
                        {
                            ContentInstalledTrim3[i] = ContentInstalledTrim2[i].TrimStart(Characters3);
                        }
                        AlreadyInstalled.Items.Clear();
                        for (int i = 0; i <= LengthContent - 1; i++)
                        {
                            AlreadyInstalled.Items.Add(ContentInstalledTrim3[i]);
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {
                        // Ignore. No items.
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
                    MapsInstalled = Directory.GetDirectories(DataContainer.ServerPath + @"\Servers\" + DataContainer.FolderName3 + @"\Workshop\Maps");
                    string[] MapsInstalledTrim = new string[MapsInstalled.Length];
                    string[] MapsInstalledTrim2 = new string[MapsInstalledTrim.Length];
                    string[] MapsInstalledTrim3 = new string[MapsInstalledTrim2.Length];
                    int LengthMaps = MapsInstalled.Length;
                    // Check For Installed Maps
                    try
                    {
                        for (int i = 0; i <= LengthMaps - 1; i++)
                        {
                            MapsInstalledTrim[i] = MapsInstalled[i].TrimStart(Characters);
                        }
                        for (int i = 0; i <= LengthMaps - 1; i++)
                        {
                            MapsInstalledTrim2[i] = MapsInstalledTrim[i].TrimStart(Characters2);
                        }
                        for (int i = 0; i <= LengthMaps - 1; i++)
                        {
                            MapsInstalledTrim3[i] = MapsInstalledTrim2[i].TrimStart(Characters3);
                        }
                        AlreadyInstalled.Items.Clear();
                        for (int i = 0; i <= LengthMaps - 1; i++)
                        {
                            AlreadyInstalled.Items.Add(MapsInstalledTrim3[i]);
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {
                        // Ignore. No items.
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
            WorkshopDirectory = WorkshopLocation.Text;
            SearchDownloadedItems();
        }

        private void CopyDirectory (string Source, string Destination, bool Subdirectories)
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
        private void DeleteDirectory(string Destination)
        {
            DirectoryInfo dir = new DirectoryInfo(Destination);
            DirectoryInfo[] dirs = dir.GetDirectories();
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
                    File.Delete(temppath);
                }
            }
            foreach (DirectoryInfo subdir in dirs)
            {
                string temppath = Path.Combine(Destination, subdir.Name);
                DeleteDirectory(subdir.FullName);
            }
            if (Directory.Exists(Destination))
            {
                Directory.Delete(Destination);
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
                    CopyDirectory(@"" + WorkshopDirectory + @"\" + file, @"" + DataContainer.ServerPath + @"\Servers\" + DataContainer.FolderName3 + @"\Workshop\Content\" + file, true);
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
                    CopyDirectory(@"" + WorkshopDirectory + @"\" + file, @"" + DataContainer.ServerPath + @"\Servers\" + DataContainer.FolderName3 + @"\Workshop\Maps\" + file, true);
                }
            }
            Close();
        }

        private void ContentLocation_CheckedChanged(object sender, EventArgs e)
        {
            RefreshInstalledContent();
        }

        private void MapsLocation_CheckedChanged(object sender, EventArgs e)
        {
            RefreshInstalledContent();
        }

        private void DeleteAll_Click(object sender, EventArgs e)
        {
            DeleteDirectory(@"" + DataContainer.ServerPath + @"\Servers\" + DataContainer.FolderName3 + @"\Workshop");
            RefreshInstalledContent();
        }

        private void Install_Click(object sender, EventArgs e)
        {
            SelectedItems = new string[AvailableItems.CheckedIndices.Count];
            if (AvailableItems.CheckedItems.Count == 0)
            {
                MessageBox.Show("No Selected Items.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (AvailableItems.CheckedItems.Count > 0 )
            {
                if (ContentLocation.Checked == true)
                {
                    for (int i = 0; i <= AvailableItems.CheckedIndices.Count - 1; i++)
                    {
                        SelectedItems[i] = Convert.ToString(AvailableItems.CheckedItems[i]);
                    }
                    foreach (string file in SelectedItems)
                    {
                        CopyDirectory(@"" + WorkshopDirectory + @"\" + file, @"" + DataContainer.ServerPath + @"\Servers\" + DataContainer.FolderName3 + @"\Workshop\Content\" + file, true);
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
                        CopyDirectory(@"" + WorkshopDirectory + @"\" + file, @"" + DataContainer.ServerPath + @"\Servers\" + DataContainer.FolderName3 + @"\Workshop\Maps\" + file, true);
                    }
                }
                AvailableItems.Items.Clear();
                WorkshopDirectory = WorkshopLocation.Text;
                SearchDownloadedItems();
            }
        }
    }
}
