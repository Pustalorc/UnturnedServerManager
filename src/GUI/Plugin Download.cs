using ATORTTeam.UnturnedServerManager.Constants;
using ATORTTeam.UnturnedServerManager.FileControl;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace ATORTTeam.UnturnedServerManager.GUI
{
    public partial class Plugin : Form
    {
        private string Server;
        private string ItemID = "";

        public Plugin(string ServerPath)
        {
            InitializeComponent();
            Server = ServerPath;
            LoadInstalled();
        }

        // Custom Methods
        private void LoadInstalled()
        {
            AlreadyInstalled.Items.Clear();
            var pluginlocation = Path.Combine(Server, "Rocket", "Plugins");
            FileActions.VerifyPath(pluginlocation, true);

            DirectoryInfo Fldr = new DirectoryInfo(pluginlocation);
            FileInfo[] Content = Fldr.GetFiles("*.dll", SearchOption.TopDirectoryOnly);
            foreach (var file in Content)
                AlreadyInstalled.Items.Add(file.Name.Substring(0, file.Name.Length - 4));
            
            if (AlreadyInstalled.Items.Count == 0)
            {
                Delete.Enabled = false;
                DeleteAll.Enabled = false;
                Configuration.Enabled = false;
                ItemID = "";
            }
            else
            {
                AlreadyInstalled.SelectedIndex = 0;
                Delete.Enabled = true;
                DeleteAll.Enabled = true;
                Configuration.Enabled = true;
            }
        }

        // Control Events
        private void Exit_Click(object sender, System.EventArgs e) => Close();
        private void AlreadyInstalled_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (AlreadyInstalled.SelectedItem != null)
            {
                Delete.Enabled = true;
                Configuration.Enabled = true;
                ItemID = (string)AlreadyInstalled.SelectedItem;
            }
            else
            {
                Delete.Enabled = false;
                Configuration.Enabled = true;
                ItemID = "";
            }
        }
        private void DeleteAll_Click(object sender, System.EventArgs e)
        {
            var pluginlocation = Path.Combine(Server, "Rocket", "Plugins");
            var librarieslocation = Path.Combine(Server, "Rocket", "Libraries");

            FileActions.DeleteDirectory(pluginlocation);
            FileActions.DeleteDirectory(librarieslocation);

            LoadInstalled();
        }
        private void Delete_Click(object sender, System.EventArgs e)
        {
            var pluginlocation = Path.Combine(Server, "Rocket", "Plugins", ItemID);

            FileActions.DeleteDirectory(pluginlocation);
            File.Delete($"{pluginlocation}.dll");

            LoadInstalled();
        }
        private void Install_Click(object sender, System.EventArgs e)
        {
            Hide();
            var pluginlocation = Path.Combine(Server, "Rocket", "Plugins");
            var librarieslocation = Path.Combine(Server, "Rocket", "Libraries");
            var modulelocation = Path.Combine(RocketmodServerPath.Value, "Modules");

            var tempname = Path.GetTempFileName();
            var templocation = Path.Combine(Path.GetTempPath(), tempname.Substring(0, tempname.Length - 4));

            var result = OpenZip.ShowDialog();
            if (result == DialogResult.OK)
            {
                FileStream stream = (FileStream)OpenZip.OpenFile();
                FileActions.ExtractZip(stream.Name, templocation);

                var tempLibraries = Path.Combine(templocation, "Libraries");
                if (FileActions.VerifyPath(tempLibraries, false))
                {
                    DirectoryInfo Fldr = new DirectoryInfo(tempLibraries);
                    FileInfo[] Content = Fldr.GetFiles("*.dll", SearchOption.TopDirectoryOnly);
                    foreach (var file in Content)
                    {
                        var dest = Path.Combine(librarieslocation, file.Name);
                        
                        if (File.Exists(dest))
                            File.Delete(dest);

                        FileActions.VerifyFilePath(dest, true);
                        file.MoveTo(dest);
                    }
                }

                var tempPlugins = Path.Combine(templocation, "Plugins");
                if (FileActions.VerifyPath(tempPlugins, false))
                {
                    DirectoryInfo Fldr = new DirectoryInfo(tempPlugins);
                    FileInfo[] Content = Fldr.GetFiles("*.dll", SearchOption.TopDirectoryOnly);
                    foreach (var file in Content)
                    {
                        var dest = Path.Combine(pluginlocation, file.Name);

                        if (File.Exists(dest))
                            File.Delete(dest);

                        FileActions.VerifyFilePath(dest, true);
                        file.MoveTo(dest);
                    }
                }

                var tempModules = Path.Combine(templocation, "Modules");
                if (FileActions.VerifyPath(tempModules, false))
                {
                    DirectoryInfo Fldr = new DirectoryInfo(tempModules);
                    FileInfo[] Content = Fldr.GetFiles("*.dll", SearchOption.TopDirectoryOnly);
                    foreach (var file in Content)
                    {
                        var dest = Path.Combine(modulelocation, file.Name);

                        if (File.Exists(dest))
                            File.Delete(dest);

                        FileActions.VerifyFilePath(dest, true);
                        file.MoveTo(dest);
                    }
                }
            }

            LoadInstalled();
            Show();
        }
        private void Configuration_Click(object sender, System.EventArgs e)
        {
            var pluginlocation = Path.Combine(Server, "Rocket", "Plugins", ItemID);

            if (FileActions.VerifyPath(pluginlocation, false))
                Process.Start(pluginlocation);
        }
    }
}
