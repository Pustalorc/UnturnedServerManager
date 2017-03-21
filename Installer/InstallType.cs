using System.Windows.Forms;

namespace Installer
{
    public partial class InstallType : Form
    {
        public InstallType()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void Next_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void OntTimeInst_CheckedChanged(object sender, System.EventArgs e)
        {
            Next.Enabled = true;
            Var.Type = 1;
        }

        private void FullInst_CheckedChanged(object sender, System.EventArgs e)
        {
            Next.Enabled = true;
            Var.Type = 2;
        }
    }
}
