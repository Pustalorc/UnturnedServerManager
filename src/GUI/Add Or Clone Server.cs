using ATORTTeam.UnturnedServerManager.Memory;
using ATORTTeam.UnturnedServerManager.ServerInstance;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ATORTTeam.UnturnedServerManager.GUI
{
    public partial class AddServer : Form
    {
        private bool Accepted = false;
        private string Clone = null;

        public AddServer(string CloneServer = null)
        {
            InitializeComponent();

            Clone = CloneServer;
        }

        private void ServerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Accepted = true;
                Close();
            }
        }
        private void OK_Click(object sender, EventArgs e)
        {
            Accepted = true;
            Close();
        }
        private void Cancel_Click(object sender, EventArgs e) => Close();
        private void AddServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Regex IllegalName = new Regex("(^(PRN|AUX|NUL|CON|COM[1-9]|LPT[1-9]|(\\.+)$)(\\..*)?$)|(([\\x00-\\x1f\\\\?*:\";‌​|/<>])+)|([\\. ]+)", RegexOptions.IgnoreCase);

            if (Accepted && !IllegalName.IsMatch(ServerName.Text) && !string.IsNullOrEmpty(ServerName.Text))
                if (!Servers.Value.Exists(k => k.Name == ServerName.Text))
                    Servers.Value.Add(Server.Create(ServerName.Text, IsRocketmod.Checked ? ServerType.RocketMod : ServerType.Vanilla, Clone));
        }
    }
}
