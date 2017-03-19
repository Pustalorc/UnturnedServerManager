using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Removed "this." -- Not required in latest versions of .net

namespace Unturned_Server_Manager1
{
    public partial class CreateServer : Form
    {
        public CreateServer()
        {
            InitializeComponent();
        }

        private void CreateServer_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (tbServerName.Text == "")
            {
                // Removed "int num1 = (int)" since it serves no purpose in the entire code.
                MessageBox.Show("Please enter a server name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (tbServerName.Text.Length <= 5)
            {
                MessageBox.Show("Server name must be longer than five(5) characters!", "Server Name", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (Directory.Exists(Path.GetFullPath(Properties.Settings.Default.ServerPath + "//Servers//" + tbServerName.Text)))
            {
                MessageBox.Show("There is already a server with this name, please choose something else!", "Duplicate Server", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                // Fixed issue if user selects wrong server path.
                Directory.CreateDirectory(Path.GetFullPath(Properties.Settings.Default.ServerPath + "//Servers//" + tbServerName.Text));
                Directory.CreateDirectory(Path.GetFullPath(Properties.Settings.Default.ServerPath + "//Servers//" + tbServerName.Text + "\\Server"));
                File.Create(Path.GetFullPath(Properties.Settings.Default.ServerPath + "//Servers//" + tbServerName.Text + "\\Server\\Commands.dat")).Close();
                string file = Path.GetFullPath(Properties.Settings.Default.ServerPath + "//Servers//" + tbServerName.Text + "\\Server\\Commands.dat");
                Close();
            }
        }

        private void CreateServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 ss = new Form1();
            ss.Show();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
