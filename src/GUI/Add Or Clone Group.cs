using System.Windows.Forms;

namespace ATORTTeam.UnturnedServerManager.GUI
{
    public partial class AddOrCloneGroup : Form
    {
        private bool Accepted = false;
        public string ID = "";

        public AddOrCloneGroup()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, System.EventArgs e)
        {
            Accepted = true;
            Close();
        }
        private void Cancel_Click(object sender, System.EventArgs e) => Close();
        private void ServerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Accepted = true;
                Close();
            }
        }
        private void AddOrCloneGroup_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Accepted)
                ID = GroupID.Text;
        }
    }
}
