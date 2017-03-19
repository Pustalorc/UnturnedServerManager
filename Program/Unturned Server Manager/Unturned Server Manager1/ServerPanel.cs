using ICSharpCode.SharpZipLib.Zip;
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

namespace Unturned_Server_Manager1
{
    public partial class ServerPanel : Form
    {
        public ServerPanel()
        {
            InitializeComponent();
        }

        private void ServerPanel_Load(object sender, EventArgs e)
        {
            label3.Text = Database.serverName + " Settings";
            GetInfo();
            GetMaps();
        }

        private void GetMaps()
        {
            maps.Items.Clear();
            // Fixed path getting in case user inputed wrong server path.
            DirectoryInfo[] directories = new DirectoryInfo(Path.GetFullPath(Properties.Settings.Default.ServerPath + "\\Maps\\")).GetDirectories();
            for (int i = 0; i < directories.Length; i++)
            {
                FileSystemInfo fileSystemInfo = directories[i];
                maps.Items.Add(fileSystemInfo.Name);
            }
            // Added workshop directory installed maps.
            directories = new DirectoryInfo(Path.GetFullPath(Properties.Settings.Default.ServerPath + "\\Servers\\" + /* Insert here local server name */ "\\Workshop\\Maps")).GetDirectories();
            foreach (DirectoryInfo a in directories)
            {
                // Find map name
            }
            maps.SelectedIndex = 0;
        }

        private void bunifuMetroTextbox9_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tbPercentage_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel19_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GetInfo()
        {
            foreach (string readLine in System.IO.File.ReadLines(Properties.Settings.Default.ServerPath + "//Servers//" + Database.serverName + "//Server/Commands.dat"))
            {
                if (readLine.Contains("name"))
                    this.tbServerName.Text = readLine.Remove(0, 5);
                if (readLine.Contains("Map"))
                    this.maps.Text = readLine.Remove(0, 4);
                if (readLine.Contains("maxplayers"))
                    this.tbPlayers.Text = readLine.Remove(0, 11);
                if (readLine.Contains("Port"))
                    this.tbPort.Text = readLine.Remove(0, 5);
                if (readLine.Contains("Password"))
                    this.tbPassword.Text = readLine.Remove(0, 9);
                if (readLine.Contains("Welcome"))
                    this.tbWelcome.Text = readLine.Remove(0, 7);
                if (readLine.Contains("Cycle"))
                    this.tbCycle.Text = readLine.Remove(0, 5);
                if (readLine.Contains("owner"))
                    this.tbOwner.Text = readLine.Remove(0, 6);
                if (readLine.Contains("queue_size"))
                    this.tbQueueSize.Text = readLine.Remove(0, 11);
                if (readLine.Contains("Bind"))
                    this.tbIP.Text = readLine.Remove(0, 5);
                if (readLine.Contains("Sync"))
                    this.tbKey.Text = readLine.Remove(0, 5);
                if (readLine.Contains("timeout"))
                    this.tbTimeOut.Text = readLine.Remove(0, 8);
            }
        }
 

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            // Fixed path.
            // Checking if directory exists before we even start writing anything.
            string DirLocation = Path.GetFullPath(Properties.Settings.Default.ServerPath + "//Servers//" + Database.serverName + "//Server");
            string FilLocation = Path.GetFullPath(Properties.Settings.Default.ServerPath + "//Servers//" + Database.serverName + "//Server/Commands.dat");
            if (!Directory.Exists(DirLocation))
            {
                Directory.CreateDirectory(DirLocation);
            }
            StreamWriter sw = new StreamWriter(FilLocation); // Writting Settings To Commands.dat
            #region Settings
            sw.WriteLine("name " + tbServerName.Text); //Setting  server name (Commands.dat)
            sw.WriteLine("Welcome " + tbWelcome.Text); // Setting welcome message (Commands.dat)
            sw.WriteLine("Map " + maps.Text); // Setting map (Commands.dat)
            sw.WriteLine("Port " + tbPort.Text); // Setting port (Commands.dat)
            sw.WriteLine("timeout " + tbTimeOut.Text); //Setting timeout (Commands.dat)
            sw.WriteLine("Sync " + tbKey.Text); // Setting sync key (Commands.dat)
            sw.WriteLine("queue_size " + tbQueueSize.Text); // Setting queue_size (Commands.dat)
            sw.WriteLine("maxplayers " + tbPlayers.Text); // Setting max players (Commands.dat)
            sw.WriteLine("Cycle " + tbCycle.Text); // Setting Cycle (Commands.dat)
            sw.WriteLine("owner " + tbOwner.Text); // Setting owner (Steam ID) (Commands.dat)
            sw.WriteLine("Password " + tbPassword.Text); // Setting password (Commands.dat)
            sw.WriteLine("Bind " + tbIP.Text); // Setting IP Bind (Not Public)
            //Setting gamemode to Easy if Easy is checked
            if(tbEasy.Checked)
            {
                sw.WriteLine("Mode Easy");
            }
            //Setting gamemode to Normal if Normal is checked
            if (tbNormal.Checked)
            {
                sw.WriteLine("Mode Normal");
            }
            //Setting gamemode to Hard if Hard is checked
            if (tbHard.Checked)
            {
                sw.WriteLine("Mode Hard");
            }
            //Setting game to PvP if PvP is checked
            if (tbPvP.Checked)
            {
                sw.WriteLine("PvP");
            }
            //Setting game to PvE if PvE is checked
            if (tbPvE.Checked)
            {
                sw.WriteLine("PvE");
            }
            //Setting perspective to First
            if(tbFirst.Checked)
            {
                sw.WriteLine("Perspective First");
            }
            //Setting perspective to Both
            if(tbBoth.Checked)
            {
                sw.WriteLine("Perspective Both");
            }
            //Setting perspective to Vehicle
            if (tbVehicle.Checked)
            {
                sw.WriteLine("Perspective Vehicle");
            }
            //Setting perspective to Third
            if(tbThird.Checked)
            {
                sw.WriteLine("Perspective Third");
            }
            //Setting up Votify (Kick Vote)
            // Check if votify is enabled by user first.
            if (tbEnabled.Checked)
            {
                sw.WriteLine("votify Y/" + tbPassCooldown.Text + "/" + tbFailCooldown.Text + "/" + tbVoteDuration.Text + "/" + tbPercentage.Text + "/" + tbMinplayers.Text);
            }

            sw.Close(); //Closing Writer to avoid errors
        }
        #endregion

        private void ServerPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1Control.Application.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void File()
        {
            //new FastZip
            //{
            //}.ExtractZip(textBox2.Text + "\\rocket.zip", textBox2.Text, "");
        }
    }
}