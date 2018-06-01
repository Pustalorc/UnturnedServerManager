using ATORTTeam.UnturnedServerManager.Configuration;
using ATORTTeam.UnturnedServerManager.Updating;
using ATORTTeam.UnturnedServerManager.Versions;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace ATORTTeam.UnturnedServerManager.GUI
{
    public partial class UpdateMenu : Form
    {
        public UpdateMenu()
        {
            InitializeComponent();

            LUVer.Text = UnturnedBuild.Value;
            LRVer.Text = RocketBuild.Value;
            // Get latest manager version with github.

            var InstalledVesions = LocalVersions.Load();
            CUVer.Text = InstalledVesions.UnturnedVersion;
            CRVer.Text = InstalledVesions.RocketModVersion;
        }
        
        // Form Events
        private void UUnturned_Click(object sender, EventArgs e)
        {
            Hide();
            
            Updater.UpdateUnturned();

            Show();
        }
        private void URocket_Click(object sender, EventArgs e)
        {
            Hide();
            
            Updater.UpdateRocket();

            Show();
        }
        private void UAll_Click(object sender, EventArgs e)
        {
            Hide();
            
            Updater.UpdateAll();

            Show();
        }
    }
}
