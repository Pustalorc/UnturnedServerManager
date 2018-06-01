using System;
using System.Windows.Forms;

namespace ATORTTeam.UnturnedServerManager.GUI
{
    public partial class AddMember : Form
    {
        private bool Accepted = false;
        public ulong ID = 0;

        public AddMember()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            Accepted = true;
            Close();
        }
        private void Cancel_Click(object sender, EventArgs e) => Close();
        private void AddMember_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Accepted)
                ID = (ulong)OwnerID.Value;
        }
        private void OwnerID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Accepted = true;
                Close();
            }
        }
    }
}
