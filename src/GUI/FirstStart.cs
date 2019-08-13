using System;
using System.Windows.Forms;
using Pustalorc.Applications.USM.Configuration;

namespace Pustalorc.Applications.USM.GUI
{
    internal sealed partial class FirstStart : Form
    {
        public FirstStart()
        {
            InitializeComponent();
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            var result = FolderBrowser.ShowDialog();
            if (result == DialogResult.OK)
                SelectedPath.Text = FolderBrowser.SelectedPath;
        }

        private void Validate_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SelectedPath_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter) Close();
        }

        private void FirstStart_FormClosing(object sender, FormClosingEventArgs e)
        {
            var inst = Installation.Load();
            inst.InstallationPath = SelectedPath.Text;
            inst.SaveJson();
        }
    }
}