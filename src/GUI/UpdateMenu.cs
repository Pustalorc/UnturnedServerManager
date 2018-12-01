using System;
using System.Windows.Forms;
using ATORTTeam.UnturnedServerManager.Configuration;
using ATORTTeam.UnturnedServerManager.Updating;
using ATORTTeam.UnturnedServerManager.Versions;

namespace ATORTTeam.UnturnedServerManager.GUI
{
    public partial class UpdateMenu : Form
    {
        public UpdateMenu()
        {
            InitializeComponent();

            LUVer.Text = UnturnedBuild.Value;
            LRVer.Text = RocketBuild.Value;

            LoadVersions();
        }

        // Custom Methods
        private void LoadVersions()
        {
            var installedVersions = LocalVersions.Load();
            CUVer.Text = installedVersions.UnturnedVersion;
            CRVer.Text = installedVersions.RocketModVersion;
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