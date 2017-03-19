using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unturned_Server_Manager1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetServers();

            if (lvServers.Items.Count > 0)
            {
                lvServers.Items[0].Selected = true;
                lvServers.Select();
            }


            richTextBox1.Text = System.IO.File.ReadAllText(Properties.Settings.Default.ServerPath + "\\Servers\\" + label3.Text + @"\Server\Commands.dat");

        }

        private void GetServers()
        {
            DirectoryInfo di = new DirectoryInfo(@"C:\Program Files (x86)\Steam\steamapps\common\Unturned\Servers");
            // first list sub-directories
            DirectoryInfo[] dirs = di.GetDirectories();
            foreach (DirectoryInfo dir in dirs)
            {
                lvServers.Items.Add(dir.Name);

            }
        }

        private void lvServers_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            label3.Text = e.Item.Text;
        }

        private void btnServerPanel_Click(object sender, EventArgs e)
        {
            Database.serverName = label3.Text;
            ServerPanel ss = new ServerPanel();
            ss.Show();
            Hide();
        }

        private void HideConsole()
        {
            // Code copied from USO (I believe it is)
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = @"C:\USOServerFiles\steamcmd.exe";
            start.WindowStyle = ProcessWindowStyle.Hidden;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            new Settings().Show();
            this.Hide();
        }

        private void btnCreateServer_Click(object sender, EventArgs e)
        {
            // Fixed crash when directory doesn't exist.
            // Fixed problem with invalid filesystem path.
            string dir = Path.GetFullPath(Properties.Settings.Default.ServerPath + "\\Servers\\" + label3.Text);
            if (Directory.Exists(dir))
            {
                Directory.Delete(dir, true);
                Application.Restart();
            }
        }

        private void lvServers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvServers_Click(object sender, EventArgs e)
        {
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            new CreateServer().Show();
            this.Hide();
        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = Properties.Settings.Default.ServerPath + "/Unturned.exe";
            p.StartInfo.Arguments = "-nographics -batchmode +secureserver/" + this.label3.Text.ToString();
            p.Start();
        }

        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        void ActivateApp(string processName)
        {
            Process[] p = Process.GetProcessesByName(label3.Text.ToString());

            // Activate the first application we find with this name
            if (p.Count() > 0)
                SetForegroundWindow(p[0].MainWindowHandle);

            SendKeys.SendWait("shutdown{ENTER}");
        }

        //[DllImport("User32.dll")]
        //private static extern IntPtr FindWindow(string className, string windowName);

        private void btnStop_Click(object sender, EventArgs e)
        {
            foreach (var process in Process.GetProcessesByName("Unturned"))
            {
                process.Kill();
            }
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}