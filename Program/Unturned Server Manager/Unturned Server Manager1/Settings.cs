using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unturned_Server_Manager1
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void Save()
        {
            if (Properties.Settings.Default.ServerPath != string.Empty)
            {
                Properties.Settings.Default.ServerPath = tbPath.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.ServerPath = tbPath.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            tbPath.Text = Properties.Settings.Default["ServerPath"].ToString(); //Loading Settings on form load
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //Getting Server Path and displaying to textbox
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string[] files = Directory.GetFiles(folderBrowserDialog1.SelectedPath);
                tbPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Fixed the form not closing after clicking save (pressing x after saving is an annoyance), your choice though.
            Save(); //Save settings (Server Path)
            Close();
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 ss = new Form1();
            ss.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
