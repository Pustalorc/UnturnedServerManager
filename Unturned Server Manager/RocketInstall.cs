using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;

namespace Unturned_Server_Manager
{
    public partial class RocketInstall : Form
    {
        public RocketInstall()
        {
            InitializeComponent();
            StartDownload();
        }

        private async void StartDownload()
        {
            await Task.Delay(500);
            Step1.Enabled = true;
            
            Completion.Value = 1;
            DetailsFull.Text += "\r\nDownloading latest version of rocket...";
            try
            {
                Directory.CreateDirectory(@"Temp");
                using (var client = new WebClient())
                {
                    client.DownloadFile("https://dl.dropboxusercontent.com/s/ylqkv0qziggce5z/Rocket_Latest.zip?dl=0", @"Temp\Rocket_Latest.zip");
                }
                for (float i=0; i<=10; i++)
                {
                    await Task.Delay(200);
                    DetailsFull.Text += string.Format("\rDownload {0}% Completed", i*10);
                    Completion.Value = Convert.ToInt32(i*2.5);
                }
            }
            catch (WebException)
            {
                MessageBox.Show("Possible Network Error. Please Download Latest Version Manually From Here: https://rocketmod.net/get-rocket and place it in a folder named 'Temp' where this program is located.", "Unspecified Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            if (File.Exists(@"Temp\Rocket_Latest.zip") == true)
            {
                Step1.Enabled = false;
                Step1.Checked = true;
                DetailsFull.Text += "\r\n\r\nExtracting files to server directory...";
                StartExtracting();
            }
            else
            {
                MessageBox.Show("Possible Network Error. Please Download Latest Version Manually From Here: https://rocketmod.net/get-rocket and place it in a folder named 'Temp' where this program is located.", "Unspecified Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Directory.Delete("Temp");
                Close();
            }
        }

        private async void StartExtracting()
        {
            bool FailedRocketMod = false;
            Completion.Value = 51;
            Step3.Enabled = true;
            string License = @"" + DataContainer.ServerPath + @"\Unturned_Data\Managed\LICENSE";
            string Readme = @"" + DataContainer.ServerPath + @"\Unturned_Data\Managed\README";
            string Assembly = @"" + DataContainer.ServerPath + @"\Unturned_Data\Managed\Assembly-CSharp.dll";
            string RAPI = @"" + DataContainer.ServerPath + @"\Unturned_Data\Managed\Rocket.API.dll";
            string RCore = @"" + DataContainer.ServerPath + @"\Unturned_Data\Managed\Rocket.Core.dll";
            string RUnturned = @"" + DataContainer.ServerPath + @"\Unturned_Data\Managed\Rocket.Unturned.dll";
            string ScriptsFolder = @"" + DataContainer.ServerPath + @"\Unturned_Data\Managed\Scripts";
            string Scripts1 = @"" + DataContainer.ServerPath + @"\Unturned_Data\Managed\Scripts\MyFirstRocketServer.bat";
            string Scripts2 = @"" + DataContainer.ServerPath + @"\Unturned_Data\Managed\Scripts\start.bat";
            string Scripts3 = @"" + DataContainer.ServerPath + @"\Unturned_Data\Managed\Scripts\update.bat";
            
            if (File.Exists(License) == true)
            {
                File.Delete(License);
            }
            if (File.Exists(Readme) == true)
            {
                File.Delete(Readme);
            }
            if (File.Exists(Assembly) == true)
            {
                File.Delete(Assembly);
            }
            if (File.Exists(RAPI) == true)
            {
                File.Delete(RAPI);
            }
            if (File.Exists(RCore) == true)
            {
                File.Delete(RCore);
            }
            if (File.Exists(RUnturned) == true)
            {
                File.Delete(RUnturned);
            }
            if (File.Exists(Scripts1) == true)
            {
                File.Delete(Scripts1);
            }
            if (File.Exists(Scripts2) == true)
            {
                File.Delete(Scripts2);
            }
            if (File.Exists(Scripts3) == true)
            {
                File.Delete(Scripts3);
            }
            if (Directory.Exists(ScriptsFolder) == true)
            {
                Directory.Delete(ScriptsFolder);
            }
            if (File.Exists(License) == false && File.Exists(Readme) == false && File.Exists(Assembly) == false && File.Exists(RAPI) == false && File.Exists(RCore) == false && File.Exists(RUnturned) == false && File.Exists(Scripts1) == false && File.Exists(Scripts2) == false && File.Exists(Scripts3) == false && Directory.Exists(ScriptsFolder) == false)
            {
                try
                {
                    ZipFile.ExtractToDirectory(@"Temp\Rocket_Latest.zip", @"" + DataContainer.ServerPath + @"\Unturned_Data\Managed\");
                }
                catch(InvalidDataException)
                {
                    MessageBox.Show("Critical exception was thrown. Most likely it is a corrupt download. Please manually download and install rocket.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    FailedRocketMod = true;
                }
                if (FailedRocketMod == true)
                {
                    Close();
                }
                else
                {
                    for (int i = 0; i <= 20; i++)
                    {
                        await Task.Delay(250);
                        DetailsFull.Text += string.Format("\rExtracting {0}% Completed", i * 5);
                        Completion.Value = 50 + Convert.ToInt32(i * 1.25);
                    }
                    DetailsFull.Text += "\r\n\r\nExtraction complete, starting install...";
                    await Task.Delay(1000);
                    for (int i = 0; i <= 20; i++)
                    {
                        await Task.Delay(100);
                        DetailsFull.Text += string.Format("\rInstalling {0}% Completed", i * 5);
                        Completion.Value = 75 + Convert.ToInt32(i * 1.25);
                    }
                    await Task.Delay(1000);
                    if (File.Exists(License) == true && File.Exists(Readme) == true && File.Exists(Assembly) == true && File.Exists(RAPI) == true && File.Exists(RCore) == true && File.Exists(RUnturned) == true)
                    {
                        DetailsFull.Text += "\r\nInstallation of rocket was successful.";
                        File.Delete(@"Temp\Rocket_Latest.zip");
                    }
                    else
                    {
                        DetailsFull.Text += "\r\nError in the installation of rocket.";
                        File.Delete(@"Temp\Rocket_Latest.zip");
                    }
                    if (File.Exists(License) == true && File.Exists(Readme) == true && File.Exists(Assembly) == true && File.Exists(RAPI) == true && File.Exists(RCore) == true && File.Exists(RUnturned) == true)
                    {
                        Step3.Enabled = false;
                        Step3.Checked = true;
                        DetailsFull.Text += "\r\nFull Installation was successful!";
                        Directory.Delete("Temp");
                        await Task.Delay(3000);
                        Close();
                    }
                    else
                    {
                        Step3.Enabled = false;
                        Step3.Checked = Convert.ToBoolean(null);
                        DetailsFull.Text += "\r\nInstallation failed somewhere or had an error. Please manually fix this issue.";
                        Directory.Delete("Temp");
                        await Task.Delay(6000);
                        Close();
                    }
                }
            }
        }

        private void DetailsFull_TextChanged(object sender, EventArgs e)
        {
            DetailsFull.SelectionStart = DetailsFull.Text.Length;
            DetailsFull.ScrollToCaret();
        }
    }
}
