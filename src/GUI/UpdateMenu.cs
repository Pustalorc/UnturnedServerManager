using System;
using System.Windows.Forms;
using Pustalorc.Applications.USM.Configuration;
using Pustalorc.Applications.USM.Updating;

namespace Pustalorc.Applications.USM.GUI
{
    public sealed partial class UpdateMenu : Form
    {
        public UpdateMenu()
        {
            InitializeComponent();
            LoadVersions();
        }

        // Custom Methods
        private void LoadVersions()
        {
            var installedVersions = LocalVersions.Load();
            CUVer.Text = installedVersions.LastUnturnedUpdate.ToString();
        }

        // Form Events
        private void UUnturned_Click(object sender, EventArgs e)
        {
            Hide();

            Updater.UpdateUnturned();
            LoadVersions();

            Show();
        }

        private void Validate_Click(object sender, EventArgs e)
        {
            Hide();

            Updater.ValidateUnturned();
            LoadVersions();

            Show();
        }

        private void URocket_Click(object sender, EventArgs e)
        {
            Hide();

            Updater.UpdateRocket();
            LoadVersions();

            Show();
        }

        private void UAll_Click(object sender, EventArgs e)
        {
            Hide();

            Updater.UpdateAll();
            LoadVersions();

            Show();
        }
    }
}