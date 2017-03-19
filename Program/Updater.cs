using System;
using System.IO;
using System.Windows.Forms;

namespace USM
{
    public partial class Updater : Form
    {
        private string[] CurrentVersions;
        private string[] LatestVersions;

        public Updater()
        {
            InitializeComponent();
            if (File.Exists(Path.GetFullPath(Variables.DataPath + @"\Installed.dat")))
            {
                CurrentVersions = File.ReadAllLines(Path.GetFullPath(Variables.DataPath + @"\Installed.dat"));
            }
            if (File.Exists(Path.GetFullPath(Variables.DataPath + @"\Versions.dat")))
            {
                File.Delete(Path.GetFullPath(Variables.DataPath + @"\Versions.dat"));
            }

        }

        private void UpdateGUI()
        {
            CUVer.Text = CurrentVersions[0];
            CRVer.Text = CurrentVersions[1];
            CPIVer.Text = CurrentVersions[2];
            CMVer.Text = "3.1.0.0";
            LUVer.Text = LatestVersions[0];
            LRVer.Text = LatestVersions[1];
            LPIVer.Text = LatestVersions[2];
            LMVer.Text = LatestVersions[3];
        }

        private void AutoUpdate_Click(object sender, EventArgs e)
        {
            Logger.Log("Opening auto-update settings.", "Settings");
            new AutoUpdateForm().ShowDialog();
            Logger.Log("Closed auto-update settings.", "Settings");
        }

        private void URocket_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(Path.GetFullPath(Variables.DataPath + @"\Temp"));
            FileDownloaderVariables.Download = "Rocket Mod";
            new FileDownloader().ShowDialog();
            if (FileDownloaderVariables.Error)
            {
                MessageBox.Show("An error has occured during the download of rocket, please check your internet connection and your connection to the rocket servers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!FileDownloaderVariables.Error)
            {
                // Extract ZIP Data
            }
            Directory.Delete(Path.GetFullPath(Variables.DataPath + @"\Temp"), true);
        }

        private void UUnturned_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(Path.GetFullPath(Variables.DataPath + @"\Temp"));
            FileDownloaderVariables.Download = "Steam Console";
            new FileDownloader().ShowDialog();
            if (FileDownloaderVariables.Error)
            {
                MessageBox.Show("An error has occured during the download of steam cmd, please check your internet connection and your connection to the steam servers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!FileDownloaderVariables.Error)
            {
                // Extract ZIP Data
                // Run SteamCMD And Update Unturned
            }
            Directory.Delete(Path.GetFullPath(Variables.DataPath + @"\Temp"), true);
        }

        private void UPI_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(Path.GetFullPath(Variables.DataPath + @"\Temp"));
            FileDownloaderVariables.Download = "Plugin Integrity";
            new FileDownloader().ShowDialog();
            if (FileDownloaderVariables.Error)
            {
                MessageBox.Show("An error has occured during the download of the plugin integrity, please check your internet connection and your connection to github page.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!FileDownloaderVariables.Error)
            {
                // Extract ZIP Data
            }
            Directory.Delete(Path.GetFullPath(Variables.DataPath + @"\Temp"), true);
        }

        private void USM_Click(object sender, EventArgs e)
        {
            // Open Link To Latest Release
        }

        private void UAll_Click(object sender, EventArgs e)
        {

        }
    }
}
