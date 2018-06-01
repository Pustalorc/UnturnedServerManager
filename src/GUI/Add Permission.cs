using System;
using System.Windows.Forms;

namespace ATORTTeam.UnturnedServerManager.GUI
{
    public partial class AddPermission : Form
    {
        private bool Accepted = false;
        public string Permission = "";
        public uint Cooldown = 0;

        public AddPermission()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            Accepted = true;
            Close();
        }
        private void Cancel_Click(object sender, EventArgs e) => Close();
        private void ServerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Accepted = true;
                Close();
            }
        }

        private void AddPermission_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Accepted)
            {
                Permission = PermissionName.Text;
                Cooldown = (uint)CooldownValue.Value;
            }
        }
    }
}
