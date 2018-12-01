using System;
using System.Diagnostics;
using System.Windows.Forms;
using ATORTTeam.UnturnedServerManager.SteamCMD_Manager;

namespace ATORTTeam.UnturnedServerManager.GUI
{
    internal partial class SteamLogin : Form
    {
        public SteamLogin()
        {
            InitializeComponent();
        }

        private void LogonSteam_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
                Close();
        }

        private void SteamLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Remember.Checked) return;

            SteamCmd.Username = Username.Text;
            SteamCmd.Password = Password.Text;
        }

        private void Github_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/persiafighter/UnturnedServerManager/wiki");
        }
    }
}