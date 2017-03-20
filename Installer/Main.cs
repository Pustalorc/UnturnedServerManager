using System.Windows.Forms;

namespace Installer
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
        {
            Next.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, System.EventArgs e)
        {
            Next.Enabled = true;
        }
    }
}
