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
    public partial class Updater : Form
    {
        public const string VersionDownload = "https://github.com/persiafighter/UnturnedServerManager/raw/master/Data/Versions.zip";
        string[] Data;
        string[] InstalledData;
        public Updater()
        {
            InitializeComponent();
            Downloader.GetReady();

            if (File.Exists(Comms.DataPath + "Versions.dat") == true)
            {
                File.Delete(Comms.DataPath + "Versions.dat");
            }
            Downloader.Download(VersionDownload, "Versions.zip");
            Downloader.Extract("Versions.zip", Path.GetFullPath(Comms.DataPath));

            Data = File.ReadAllLines(Comms.DataPath + "Versions.dat");

            if (File.Exists(Comms.DataPath + "Installed.dat"))
            {
                InstalledData = File.ReadAllLines(Comms.DataPath + "Installed.dat");
            }
            else if (!File.Exists(Comms.DataPath + "Installed.dat"))
            {
                InstalledData = new string[3];
                InstalledData[0] = "Custom";
                InstalledData[1] = "N/A";
                InstalledData[2] = "N/A";
            }
            LoadVersions();
            DisableUpdates();
        }
        
        private async void DisableUpdates()
        {
            int c = 0;
            while (c < 500)
            {
                if (Comms.AServerIsRunning == true)
                {
                    UUnturned.Enabled = false;
                    URocket.Enabled = false;
                    UAll.Enabled = false;
                }
                else if (Comms.AServerIsRunning == false)
                {
                    UUnturned.Enabled = true;
                    URocket.Enabled = true;
                    UAll.Enabled = true;
                }
                await Task.Delay(1);
            }
        }

        private void LoadVersions()
        {
            LUVer.Text = Data[0];
            LRVer.Text = Data[1];
            LMVer.Text = Data[2];
            LPIVer.Text = Data[3];
            if (File.Exists(Comms.DataPath + "Installed.dat") == true)
            {
                try
                {
                    CUVer.Text = InstalledData[0];
                    CRVer.Text = InstalledData[1];
                    CPIVer.Text = InstalledData[2];
                }
                catch (Exception e)
                {
                    MessageBox.Show("An error has occured when loading the versions from disk. An error log has been saved under \"" + Path.GetFullPath(Comms.DataPath + @"\\UVLoadError.txt") + "\", please delete the versions file or submit an issue report for help.");
                    File.WriteAllText(Path.GetFullPath(Comms.DataPath + @"\\UVLoadError.txt"), e.ToString());
                }
            }
        }

        private void UUnturned_Click(object sender, EventArgs e)
        {
            bool SuccessInstall = Downloader.InstallUnturned();
            if (SuccessInstall == false)
            {
                MessageBox.Show("An error has occured during the update of unturned. Please manually update unturned.");
            }
            else if (SuccessInstall == true)
            {
                InstalledData[0] = Data[0];
                CUVer.Text = InstalledData[0];
                MessageBox.Show("Unturned has been successfully isntalled/updated.");
            }
        }

        private void URocket_Click(object sender, EventArgs e)
        {
            bool SuccessInstall = Downloader.InstallRocket();
            if (SuccessInstall == false)
            {
                MessageBox.Show("An error has occured during the update of rocket. Please manually update rocket.");
            }
            else if (SuccessInstall == true)
            {
                InstalledData[1] = Data[1];
                CRVer.Text = InstalledData[1];
                MessageBox.Show("Rocket has been successfully isntalled/updated.");
            }
        }

        private void UPI_Click(object sender, EventArgs e)
        {
            bool SuccessInstall = Downloader.InstallIntegrity();
            if (SuccessInstall == false)
            {
                MessageBox.Show("An error has occured during the update of the plugin integrity.");
            }
            else if (SuccessInstall == true)
            {
                InstalledData[2] = Data[3];
                CPIVer.Text = InstalledData[2];
                MessageBox.Show("Plugin Integrity has been successfully isntalled/updated.");
            }
        }

        private void UAll_Click(object sender, EventArgs e)
        {
            bool SuccessInstall = Downloader.InstallUnturned();
            if (SuccessInstall == false)
            {
                MessageBox.Show("An error has occured during the update of unturned. Please manually update unturned.");
            }
            else if (SuccessInstall == true)
            {
                InstalledData[0] = Data[0];
                CUVer.Text = InstalledData[0];
            }

            bool SuccessInstall2 = Downloader.InstallRocket();
            if (SuccessInstall2 == false)
            {
                MessageBox.Show("An error has occured during the update of rocket. Please manually update rocket.");
            }
            else if (SuccessInstall2 == true)
            {
                InstalledData[1] = Data[1];
                CRVer.Text = InstalledData[1];
            }

            bool SuccessInstall3 = Downloader.InstallIntegrity();
            if (SuccessInstall3 == false)
            {
                MessageBox.Show("An error has occured during the update of the plugin integrity.");
            }
            else if (SuccessInstall3 == true)
            {
                InstalledData[2] = Data[3];
                CPIVer.Text = InstalledData[2];
            }

            Process.Start("https://github.com/persiafighter/UnturnedServerManager/releases/latest");
        }

        private void USM_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/persiafighter/UnturnedServerManager/releases/latest");
        }

        private void Updater_FormClosing(object sender, FormClosingEventArgs e)
        {
            Downloader.ShutOff();
            if (File.Exists(Comms.DataPath + "Installed.dat") == true)
            {
                File.Delete(Comms.DataPath + "Installed.dat");
            }
            File.WriteAllLines(Comms.DataPath + "Installed.dat", InstalledData);
            Close();
        }
    }
}
