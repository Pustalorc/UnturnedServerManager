using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USM
{
    public partial class FileDownloader : Form
    {
        private string URI;
        private string FinalName;

        public FileDownloader()
        {
            InitializeComponent();
            FileDownloaderVariables.Error = false;
            if (FileDownloaderVariables.Download == "Rocket Mod")
            {
                URI = FileDownloaderVariables.RocketDownload;
                Desc2.Text = FileDownloaderVariables.Download;
                FinalName = FileDownloaderVariables.RocketFinalName;
                Download();
            }
            else if (FileDownloaderVariables.Download == "Plugin Integrity")
            {
                URI = FileDownloaderVariables.PIDownload;
                Desc2.Text = FileDownloaderVariables.Download;
                FinalName = FileDownloaderVariables.PIFinalName;
                Download();
            }
            else if (FileDownloaderVariables.Download == "Steam Console")
            {
                URI = FileDownloaderVariables.SteamDownload;
                Desc2.Text = FileDownloaderVariables.Download;
                FinalName = FileDownloaderVariables.SteamFinalName;
                Download();
            }
        }

        public async void Download()
        {
            Directory.CreateDirectory(Path.GetFullPath(Variables.DataPath + @"\Temp"));
            WebClient client = new WebClient();
            Desc4.Text = "0/0";
            await Task.Delay(1000);
            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
            client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
            client.DownloadFileAsync(new Uri(URI), Path.GetFullPath(Variables.DataPath + @"\Temp\" + FinalName));
        }

        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;
            Desc4.Text = e.BytesReceived + "/" + e.TotalBytesToReceive;
            progressBar1.Value = int.Parse(Math.Truncate(percentage).ToString());
        }

        async void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                Desc4.Text = "Cancelled";
                await Task.Delay(2000);
                Close();
            }
            else if (e.Error != null)
            {
                Desc4.Text = "Error";
                await Task.Delay(2000);
                FileDownloaderVariables.Error = true;
                Close();
            }
            else
            {
                Desc4.Text = "Complete";
                await Task.Delay(2000);
                Close();
            }
        }
    }
}
