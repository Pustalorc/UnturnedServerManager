using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USM
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
            UpdateBackColor();
        }

        private async void UpdateBackColor()
        {
            Logger.Log("Enabled infinite loop to check on changes with the background color options.", "Manager");
            int c = 0;
            while (c < 10)
            {
                BackColor = Color.FromArgb(Variables.Red, Variables.Green, Variables.Blue);
                await Task.Delay(1);
            }
        }

        private void USMSettings_Click(object sender, EventArgs e)
        {
            Logger.Log("Displaying settings menu of USM.", "Manager");
            new Settings().ShowDialog();
            Logger.Log("Closed settings menu of USM.", "Manager");
        }

        private void RedditLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.reddit.com/r/unturned/comments/546y67/unturned_server_manager/");
            Logger.Log("Opening public reddit post.", "Manager");
        }

        private void GithubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/persiafighter/UnturnedServerManager/");
            Logger.Log("Opening public github repository.", "Manager");
        }

        private void LinkMe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://keybase.io/persiafighter");
            Logger.Log("Opening keybase profile.", "Manager");
        }

        private void Updater_Click(object sender, EventArgs e)
        {
            new Updater().ShowDialog();
        }
    }
}
