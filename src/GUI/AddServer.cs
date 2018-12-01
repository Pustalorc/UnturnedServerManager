using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ATORTTeam.UnturnedServerManager.Memory;
using ATORTTeam.UnturnedServerManager.Server_Instance;

namespace ATORTTeam.UnturnedServerManager.GUI
{
    internal sealed partial class AddServer : Form
    {
        private readonly string _clone;
        private bool _accepted;

        public AddServer(string cloneServer = null)
        {
            InitializeComponent();

            _clone = cloneServer;
        }

        private void ServerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char) Keys.Enter) return;

            _accepted = true;
            Close();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            _accepted = true;
            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            var illegalName =
                new Regex(
                    "(^(PRN|AUX|NUL|CON|COM[1-9]|LPT[1-9]|(\\.+)$)(\\..*)?$)|(([\\x00-\\x1f\\\\?*:\";‌​|/<>])+)|([\\. ]+)",
                    RegexOptions.IgnoreCase);

            if (!_accepted || illegalName.IsMatch(ServerName.Text) || string.IsNullOrEmpty(ServerName.Text)) return;

            if (!Servers.Value.Exists(k => k.Name == ServerName.Text))
                Servers.Value.Add(Server.Create(ServerName.Text, _clone));
        }
    }
}