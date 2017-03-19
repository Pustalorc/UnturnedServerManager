using System;
using System.Drawing;
using System.Windows.Forms;

namespace USM
{
    public partial class Settings : Form
    {
        private bool Loading = true;

        public Settings()
        {
            InitializeComponent();
            Red.Value = Variables.Red;
            Green.Value = Variables.Green;
            Blue.Value = Variables.Blue;
            Loading = false;
            Logger.Log("Loaded RGB colors from storage.", "Settings");
            Desc6.Text = Variables.UnturnedPath;
            Logger.Log("Loaded path to unturned data from storage.", "Settings");
            UpdateBackColor();
        }

        private void UpdateBackColor()
        {
            if (!Loading)
            {
                Variables.Red = Convert.ToInt16(Red.Value);
                Variables.Green = Convert.ToInt16(Green.Value);
                Variables.Blue = Convert.ToInt16(Blue.Value);
                BackColor = Color.FromArgb(Variables.Red, Variables.Green, Variables.Blue);
            }
        }

        private void Red_ValueChanged(object sender, EventArgs e)
        {
            UpdateBackColor();
        }

        private void Green_ValueChanged(object sender, EventArgs e)
        {
            UpdateBackColor();
        }

        private void Blue_ValueChanged(object sender, EventArgs e)
        {
            UpdateBackColor();
        }

        private void NewDir_Click(object sender, EventArgs e)
        {
            Logger.Log("Changing unturned directory.", "Settings");
            UnturnedInstallLocationFinder.RootFolder = Environment.SpecialFolder.Desktop;
            UnturnedInstallLocationFinder.ShowDialog();
            if (UnturnedInstallLocationFinder.SelectedPath != null && UnturnedInstallLocationFinder.SelectedPath != "")
            {
                Variables.UnturnedPath = UnturnedInstallLocationFinder.SelectedPath;
                Desc6.Text = Variables.UnturnedPath;
                Logger.Log("Unturned directory changed.", "Settings");
                return;
            }
            Logger.Log("Unturned directory change was cancelled, leaving variables the same.", "Settings");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Logger.Log("Opening auto-update settings.", "Settings");
            new AutoUpdateForm().ShowDialog();
            Logger.Log("Closed auto-update settings.", "Settings");
        }
    }
}
