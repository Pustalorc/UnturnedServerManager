using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;

namespace Unturned_Server_Manager
{
    public partial class Manager : Form
    {
        #region Variables
        private bool Server1Off;
        private bool Server2Off;
        private bool Server3Off;
        private bool Server4Off;
        private string SavedState1;
        private string SavedState2;
        private string SavedState3;
        private string SavedState4;
        private bool Continue1;
        private bool Continue2;
        private bool Continue3;
        private bool Continue4;
        private string MapSer1;
        private string MapSer2;
        private string MapSer3;
        private string MapSer4;
        private string PVPSer1;
        private string PVPSer2;
        private string PVPSer3;
        private string PVPSer4;
        private string FiPerOnly1;
        private string FiPerOnly2;
        private string FiPerOnly3;
        private string FiPerOnly4;
        private string MaxPlayers1;
        private string MaxPlayers2;
        private string MaxPlayers3;
        private string MaxPlayers4;
        private string Port1;
        private string Port2;
        private string Port3;
        private string Port4;
        private string NameSer1;
        private string NameSer2;
        private string NameSer3;
        private string NameSer4;
        private string DiffSer1;
        private string DiffSer2;
        private string DiffSer3;
        private string DiffSer4;
        private string CheatSer1;
        private string CheatSer2;
        private string CheatSer3;
        private string CheatSer4;
        private string PassSer1;
        private string PassSer2;
        private string PassSer3;
        private string PassSer4;
        private string QueueSer1;
        private string QueueSer2;
        private string QueueSer3;
        private string QueueSer4;
        private string OwnerSer1;
        private string OwnerSer2;
        private string OwnerSer3;
        private string OwnerSer4;
        private string WelcomeSer1;
        private string WelcomeSer2;
        private string WelcomeSer3;
        private string WelcomeSer4;
        private string SyncSer1;
        private string SyncSer2;
        private string SyncSer3;
        private string SyncSer4;
        private string LoadoutSer1;
        private string LoadoutSer2;
        private string LoadoutSer3;
        private string LoadoutSer4;
        private string HideAdminSer1;
        private string HideAdminSer2;
        private string HideAdminSer3;
        private string HideAdminSer4;
        private string BindSer1;
        private string BindSer2;
        private string BindSer3;
        private string BindSer4;
        private string FilterSer1;
        private string FilterSer2;
        private string FilterSer3;
        private string FilterSer4;
        private string CycleSer1;
        private string CycleSer2;
        private string CycleSer3;
        private string CycleSer4;
        private string ChatSer1;
        private string ChatSer2;
        private string ChatSer3;
        private string ChatSer4;
        private int PIDSer1;
        private int PIDSer2;
        private int PIDSer3;
        private int PIDSer4;
        private bool Hide1;
        private string Path;
        private int Servers;
        private string Arguments;
        private string Arguments2;
        private string Arguments3;
        private string Arguments4;
        private bool IsVisible;
        private bool IsVisible2;
        private string value;
        private int valueint;
        private bool AcceptedDebugPlugins;
        #endregion
        public Manager()
        {
            InitializeComponent();
            Startup();
            LoadConfigGlobal();
            LoadConfigAdvanced();
            LoopCheckRocket();
            LoopSaveGlobal();
            DefaultConfig();
            Hide1 = false;
        }

        private void Startup()
        { 
            Shutdown.Visible = false;
            Restart.Visible = false;
            ShutdownSer1.Visible = false;
            ShutdownSer2.Visible = false;
            ShutdownSer3.Visible = false;
            ShutdownSer4.Visible = false;
            Server2.Visible = false;
            Server3.Visible = false;
            Server4.Visible = false;
            OptionsDesc2.Visible = false;
            OptionsDesc3.Visible = false;
            OptionsDesc4.Visible = false;
            VACCheck2.Visible = false;
            VACCheck3.Visible = false;
            VACCheck4.Visible = false;
            BatchCheck2.Visible = false;
            BatchCheck3.Visible = false;
            BatchCheck4.Visible = false;
            NoGraphicsCheck2.Visible = false;
            NoGraphicsCheck3.Visible = false;
            NoGraphicsCheck4.Visible = false;
            ServerName2.Visible = false;
            ServerName3.Visible = false;
            ServerName4.Visible = false;
            NameDesc2.Visible = false;
            NameDesc3.Visible = false;
            NameDesc4.Visible = false;
            AdvancedOptions2.Visible = false;
            AdvancedOptions3.Visible = false;
            AdvancedOptions4.Visible = false;
            WorkshopInstall2.Visible = false;
            WorkshopInstall3.Visible = false;
            WorkshopInstall4.Visible = false;
            PluginInstall2.Visible = false;
            PluginInstall3.Visible = false;
            PluginInstall4.Visible = false;
            RestartSer1.Visible = false;
            RestartSer2.Visible = false;
            RestartSer3.Visible = false;
            RestartSer4.Visible = false;
            StartSer1.Visible = true;
            StartSer2.Visible = false;
            StartSer3.Visible = false;
            StartSer4.Visible = false;
            VACCheck1.Checked = true;
            BatchCheck1.Checked = true;
            NoGraphicsCheck1.Checked = true;
            VACCheck2.Checked = true;
            BatchCheck2.Checked = true;
            NoGraphicsCheck2.Checked = true;
            VACCheck3.Checked = true;
            BatchCheck3.Checked = true;
            NoGraphicsCheck3.Checked = true;
            VACCheck4.Checked = true;
            BatchCheck4.Checked = true;
            NoGraphicsCheck4.Checked = true;
            Server1Off = true;
            Server2Off = true;
            Server3Off = true;
            Server4Off = true;
            ServerName1.Text = "Server 1";
            ServerName2.Text = "Server 2";
            ServerName3.Text = "Server 3";
            ServerName4.Text = "Server 4";
            ExecPath.Text = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Unturned";
            PluginInstall1.Enabled = false;
            PluginInstall2.Enabled = false;
            PluginInstall3.Enabled = false;
            PluginInstall4.Enabled = false;
            PluginInstall1.Text = "Disabled";
            PluginInstall2.Text = "Disabled";
            PluginInstall3.Text = "Disabled";
            PluginInstall4.Text = "Disabled";
        }

        private async void LoopCheckRocket()
        {
            string Assembly = @"" + ExecPath.Text + @"\Unturned_Data\Managed\Assembly-CSharp.dll";
            string RAPI = @"" + ExecPath.Text + @"\Unturned_Data\Managed\Rocket.API.dll";
            string RCore = @"" + ExecPath.Text + @"\Unturned_Data\Managed\Rocket.Core.dll";
            string RUnturned = @"" + ExecPath.Text + @"\Unturned_Data\Managed\Rocket.Unturned.dll";
            int kys = 0;
            while (kys < 5)
            {
                if (File.Exists(Assembly) == true && File.Exists(RAPI) == true && File.Exists(RCore) == true && File.Exists(RUnturned) == true)
                {
                    RocketInstall.Enabled = false; // Rocket IS installed
                    RocketInstall.Text = "Rocket Is Already Installed!";
                }
                else
                {
                    RocketInstall.Enabled = true; // Rocket ISNT installed Or installation is CORRUPT.
                    RocketInstall.Text = "Install Rocket (Global)";
                }
                await Task.Delay(100);
            }
        }

        private void DefaultConfig()
        {
            DataContainer.MapSer1 = "Washington";
            DataContainer.MapSer2 = "Washington";
            DataContainer.MapSer3 = "Washington";
            DataContainer.MapSer4 = "Washington";
            DataContainer.PVPSer1 = true;
            DataContainer.PVPSer2 = true;
            DataContainer.PVPSer3 = true;
            DataContainer.PVPSer4 = true;
            DataContainer.FiPerOnly1 = false;
            DataContainer.FiPerOnly2 = false;
            DataContainer.FiPerOnly3 = false;
            DataContainer.FiPerOnly4 = false;
            DataContainer.MaxPlayers1 = 24;
            DataContainer.MaxPlayers2 = 24;
            DataContainer.MaxPlayers3 = 24;
            DataContainer.MaxPlayers4 = 24;
            DataContainer.Port1 = 27012;
            DataContainer.Port2 = 27015;
            DataContainer.Port3 = 27018;
            DataContainer.Port4 = 27021;
            DataContainer.NameSer1 = "Test Server #1";
            DataContainer.NameSer2 = "Test Server #2";
            DataContainer.NameSer3 = "Test Server #3";
            DataContainer.NameSer4 = "Test Server #4";
            DataContainer.DiffSer1 = "Normal";
            DataContainer.DiffSer2 = "Normal";
            DataContainer.DiffSer3 = "Normal";
            DataContainer.DiffSer4 = "Normal";
            DataContainer.CheatSer1 = false;
            DataContainer.CheatSer2 = false;
            DataContainer.CheatSer3 = false;
            DataContainer.CheatSer4 = false;
            DataContainer.PassSer1 = "";
            DataContainer.PassSer2 = "";
            DataContainer.PassSer3 = "";
            DataContainer.PassSer4 = "";
            DataContainer.QueueSer1 = 8;
            DataContainer.QueueSer2 = 8;
            DataContainer.QueueSer3 = 8;
            DataContainer.QueueSer4 = 8;
            DataContainer.OwnerSer1 = 0;
            DataContainer.OwnerSer2 = 0;
            DataContainer.OwnerSer3 = 0;
            DataContainer.OwnerSer4 = 0;
            DataContainer.WelcomeSer1 = "";
            DataContainer.WelcomeSer2 = "";
            DataContainer.WelcomeSer3 = "";
            DataContainer.WelcomeSer4 = "";
            DataContainer.SyncSer1 = false;
            DataContainer.SyncSer2 = false;
            DataContainer.SyncSer3 = false;
            DataContainer.SyncSer4 = false;
            DataContainer.LoadoutSer1 = "";
            DataContainer.LoadoutSer2 = "";
            DataContainer.LoadoutSer3 = "";
            DataContainer.LoadoutSer4 = "";
            DataContainer.HideAdminSer1 = false;
            DataContainer.HideAdminSer2 = false;
            DataContainer.HideAdminSer3 = false;
            DataContainer.HideAdminSer4 = false;
            DataContainer.BindSer1 = "0.0.0.0";
            DataContainer.BindSer2 = "0.0.0.0";
            DataContainer.BindSer3 = "0.0.0.0";
            DataContainer.BindSer4 = "0.0.0.0";
            DataContainer.FilterSer1 = false;
            DataContainer.FilterSer2 = false;
            DataContainer.FilterSer3 = false;
            DataContainer.FilterSer4 = false;
            DataContainer.CycleSer1 = 43200;
            DataContainer.CycleSer2 = 43200;
            DataContainer.CycleSer3 = 43200;
            DataContainer.CycleSer4 = 43200;
            DataContainer.ChatSer1 = 0;
            DataContainer.ChatSer2 = 0;
            DataContainer.ChatSer3 = 0;
            DataContainer.ChatSer4 = 0;
        }

        private void Server1Vis()
        {
            Server1.Visible = IsVisible;
            Server2.Visible = IsVisible2;
            Server3.Visible = IsVisible2;
            Server4.Visible = IsVisible2;
            OptionsDesc1.Visible = IsVisible;
            OptionsDesc2.Visible = IsVisible2;
            OptionsDesc3.Visible = IsVisible2;
            OptionsDesc4.Visible = IsVisible2;
            VACCheck1.Visible = IsVisible;
            VACCheck2.Visible = IsVisible2;
            VACCheck3.Visible = IsVisible2;
            VACCheck4.Visible = IsVisible2;
            BatchCheck1.Visible = IsVisible;
            BatchCheck2.Visible = IsVisible2;
            BatchCheck3.Visible = IsVisible2;
            BatchCheck4.Visible = IsVisible2;
            NoGraphicsCheck1.Visible = IsVisible;
            NoGraphicsCheck2.Visible = IsVisible2;
            NoGraphicsCheck3.Visible = IsVisible2;
            NoGraphicsCheck4.Visible = IsVisible2;
            ServerName1.Visible = IsVisible;
            ServerName2.Visible = IsVisible2;
            ServerName3.Visible = IsVisible2;
            ServerName4.Visible = IsVisible2;
            NameDesc1.Visible = IsVisible;
            NameDesc2.Visible = IsVisible2;
            NameDesc3.Visible = IsVisible2;
            NameDesc4.Visible = IsVisible2;
            AdvancedOptions1.Visible = IsVisible;
            AdvancedOptions2.Visible = IsVisible2;
            AdvancedOptions3.Visible = IsVisible2;
            AdvancedOptions4.Visible = IsVisible2;
            WorkshopInstall1.Visible = IsVisible;
            WorkshopInstall2.Visible = IsVisible2;
            WorkshopInstall3.Visible = IsVisible2;
            WorkshopInstall4.Visible = IsVisible2;
            PluginInstall1.Visible = IsVisible;
            PluginInstall2.Visible = IsVisible2;
            PluginInstall3.Visible = IsVisible2;
            PluginInstall4.Visible = IsVisible2;
            StartSer1.Visible = IsVisible;
            StartSer2.Visible = IsVisible2;
            StartSer3.Visible = IsVisible2;
            StartSer4.Visible = IsVisible2;
        }

        private void Server2Vis()
        {
            Server1.Visible = IsVisible;
            Server2.Visible = IsVisible;
            Server3.Visible = IsVisible2;
            Server4.Visible = IsVisible2;
            OptionsDesc1.Visible = IsVisible;
            OptionsDesc2.Visible = IsVisible;
            OptionsDesc3.Visible = IsVisible2;
            OptionsDesc4.Visible = IsVisible2;
            VACCheck1.Visible = IsVisible;
            VACCheck2.Visible = IsVisible;
            VACCheck3.Visible = IsVisible2;
            VACCheck4.Visible = IsVisible2;
            BatchCheck1.Visible = IsVisible;
            BatchCheck2.Visible = IsVisible;
            BatchCheck3.Visible = IsVisible2;
            BatchCheck4.Visible = IsVisible2;
            NoGraphicsCheck1.Visible = IsVisible;
            NoGraphicsCheck2.Visible = IsVisible;
            NoGraphicsCheck3.Visible = IsVisible2;
            NoGraphicsCheck4.Visible = IsVisible2;
            ServerName1.Visible = IsVisible;
            ServerName2.Visible = IsVisible;
            ServerName3.Visible = IsVisible2;
            ServerName4.Visible = IsVisible2;
            NameDesc1.Visible = IsVisible;
            NameDesc2.Visible = IsVisible;
            NameDesc3.Visible = IsVisible2;
            NameDesc4.Visible = IsVisible2;
            AdvancedOptions1.Visible = IsVisible;
            AdvancedOptions2.Visible = IsVisible;
            AdvancedOptions3.Visible = IsVisible2;
            AdvancedOptions4.Visible = IsVisible2;
            WorkshopInstall1.Visible = IsVisible;
            WorkshopInstall2.Visible = IsVisible;
            WorkshopInstall3.Visible = IsVisible2;
            WorkshopInstall4.Visible = IsVisible2;
            PluginInstall1.Visible = IsVisible;
            PluginInstall2.Visible = IsVisible;
            PluginInstall3.Visible = IsVisible2;
            PluginInstall4.Visible = IsVisible2;
            StartSer1.Visible = IsVisible;
            StartSer2.Visible = IsVisible;
            StartSer3.Visible = IsVisible2;
            StartSer4.Visible = IsVisible2;
        }

        private void Server3Vis()
        {
            Server1.Visible = IsVisible;
            Server2.Visible = IsVisible;
            Server3.Visible = IsVisible;
            Server4.Visible = IsVisible2;
            OptionsDesc1.Visible = IsVisible;
            OptionsDesc2.Visible = IsVisible;
            OptionsDesc3.Visible = IsVisible;
            OptionsDesc4.Visible = IsVisible2;
            VACCheck1.Visible = IsVisible;
            VACCheck2.Visible = IsVisible;
            VACCheck3.Visible = IsVisible;
            VACCheck4.Visible = IsVisible2;
            BatchCheck1.Visible = IsVisible;
            BatchCheck2.Visible = IsVisible;
            BatchCheck3.Visible = IsVisible;
            BatchCheck4.Visible = IsVisible2;
            NoGraphicsCheck1.Visible = IsVisible;
            NoGraphicsCheck2.Visible = IsVisible;
            NoGraphicsCheck3.Visible = IsVisible;
            NoGraphicsCheck4.Visible = IsVisible2;
            ServerName1.Visible = IsVisible;
            ServerName2.Visible = IsVisible;
            ServerName3.Visible = IsVisible;
            ServerName4.Visible = IsVisible2;
            NameDesc1.Visible = IsVisible;
            NameDesc2.Visible = IsVisible;
            NameDesc3.Visible = IsVisible;
            NameDesc4.Visible = IsVisible2;
            AdvancedOptions1.Visible = IsVisible;
            AdvancedOptions2.Visible = IsVisible;
            AdvancedOptions3.Visible = IsVisible;
            AdvancedOptions4.Visible = IsVisible2;
            WorkshopInstall1.Visible = IsVisible;
            WorkshopInstall2.Visible = IsVisible;
            WorkshopInstall3.Visible = IsVisible;
            WorkshopInstall4.Visible = IsVisible2;
            PluginInstall1.Visible = IsVisible;
            PluginInstall2.Visible = IsVisible;
            PluginInstall3.Visible = IsVisible;
            PluginInstall4.Visible = IsVisible2;
            StartSer1.Visible = IsVisible;
            StartSer2.Visible = IsVisible;
            StartSer3.Visible = IsVisible;
            StartSer4.Visible = IsVisible2;
        }

        private void Server4Vis()
        {
            Server1.Visible = IsVisible;
            Server2.Visible = IsVisible;
            Server3.Visible = IsVisible;
            Server4.Visible = IsVisible;
            OptionsDesc1.Visible = IsVisible;
            OptionsDesc2.Visible = IsVisible;
            OptionsDesc3.Visible = IsVisible;
            OptionsDesc4.Visible = IsVisible;
            VACCheck1.Visible = IsVisible;
            VACCheck2.Visible = IsVisible;
            VACCheck3.Visible = IsVisible;
            VACCheck4.Visible = IsVisible;
            BatchCheck1.Visible = IsVisible;
            BatchCheck2.Visible = IsVisible;
            BatchCheck3.Visible = IsVisible;
            BatchCheck4.Visible = IsVisible;
            NoGraphicsCheck1.Visible = IsVisible;
            NoGraphicsCheck2.Visible = IsVisible;
            NoGraphicsCheck3.Visible = IsVisible;
            NoGraphicsCheck4.Visible = IsVisible;
            ServerName1.Visible = IsVisible;
            ServerName2.Visible = IsVisible;
            ServerName3.Visible = IsVisible;
            ServerName4.Visible = IsVisible;
            NameDesc1.Visible = IsVisible;
            NameDesc2.Visible = IsVisible;
            NameDesc3.Visible = IsVisible;
            NameDesc4.Visible = IsVisible;
            AdvancedOptions1.Visible = IsVisible;
            AdvancedOptions2.Visible = IsVisible;
            AdvancedOptions3.Visible = IsVisible;
            AdvancedOptions4.Visible = IsVisible;
            WorkshopInstall1.Visible = IsVisible;
            WorkshopInstall2.Visible = IsVisible;
            WorkshopInstall3.Visible = IsVisible;
            WorkshopInstall4.Visible = IsVisible;
            PluginInstall1.Visible = IsVisible;
            PluginInstall2.Visible = IsVisible;
            PluginInstall3.Visible = IsVisible;
            PluginInstall4.Visible = IsVisible;
            StartSer1.Visible = IsVisible;
            StartSer2.Visible = IsVisible;
            StartSer3.Visible = IsVisible;
            StartSer4.Visible = IsVisible;
        }

        private void RefreshSelection()
        {
            value = Servers2Run.Text;
            try
            {
                valueint = Convert.ToInt32(value);
            }
            catch(FormatException)
            {
                MessageBox.Show("VALUE FOR SERVERS TO RUN IS NOT A NUMBER (how the fuck did you do that???)", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (valueint == 1)
            {
                IsVisible = true;
                IsVisible2 = false;
                Server1Vis();
            }
            else if (valueint == 2)
            {
                IsVisible = true;
                IsVisible2 = false;
                Server2Vis();
            }
            else if (valueint == 3)
            {
                IsVisible = true;
                IsVisible2 = false;
                Server3Vis();
            }
            else if (valueint == 4)
            {
                IsVisible = true;
                IsVisible2 = false;
                Server4Vis();
            }
        }

        private void TerminateProcessesGlobal()
        {
            try
            {
                try
                {
                    Process p = Process.GetProcessById(PIDSer1);
                    p.Kill();
                }
                catch (ArgumentException)
                {
                    // Ignore. Servers not running.
                }
                try
                {
                    Process p2 = Process.GetProcessById(PIDSer2);
                    p2.Kill();
                }
                catch (ArgumentException)
                {
                    // Ignore. Servers not running.
                }
                try
                {
                    Process p3 = Process.GetProcessById(PIDSer3);
                    p3.Kill();
                }
                catch (ArgumentException)
                {
                    // Ignore. Servers not running.
                }
                try
                {
                    Process p4 = Process.GetProcessById(PIDSer4);
                    p4.Kill();
                }
                catch (ArgumentException)
                {
                    // Ignore. Servers not running.
                }
            }
            catch(Win32Exception)
            {
                // Ignore. Useless Error.
            }
        }

        private void TerminateServer1()
        {
            try
            {
                Process.GetProcessById(PIDSer1).Kill();
            }
            catch(ArgumentException)
            {
                // Ignore, Server already offline.
            }
        }

        private void TerminateServer2()
        {
            try
            {
                Process.GetProcessById(PIDSer2).Kill();
            }
            catch (ArgumentException)
            {
                // Ignore, Server already offline.
            }
        }

        private void TerminateServer3()
        {
            try
            {
                Process.GetProcessById(PIDSer3).Kill();
            }
            catch (ArgumentException)
            {
                // Ignore, Server already offline.
            }
        }

        private void TerminateServer4()
        {
            try
            {
                Process.GetProcessById(PIDSer4).Kill();
            }
            catch (ArgumentException)
            {
                // Ignore, Server already offline.
            }
        }

        private async void StartServer1()
        {
            Arguments = "";
            if (ServerName1.Text == "")
            {
                MessageBox.Show("Error: no server name inserted for server #1.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ServerName1.Text != "")
            {
                if (BatchCheck1.Checked == true)
                {
                    Arguments = "" + Arguments + " -batchmode";
                }
                else if (BatchCheck1.Checked == false)
                {
                    Arguments = "" + Arguments + "";
                }
                if (NoGraphicsCheck1.Checked == true)
                {
                    Arguments = "" + Arguments + " -nographics";
                }
                else if (NoGraphicsCheck1.Checked == false)
                {
                    Arguments = "" + Arguments + "";
                }
                if (VACCheck1.Checked == true)
                {
                    Arguments = "" + Arguments + " +secureserver";
                }
                else if (VACCheck1.Checked == false)
                {
                    Arguments = "" + Arguments + " +insecureserver";
                }
                var Server1ID = new Process();
                Server1ID.StartInfo.FileName = @"" + Path + "\\Unturned.exe";
                Server1ID.StartInfo.Arguments = @"" + Arguments + "/" + ServerName1.Text + "";
                Server1ID.StartInfo.WorkingDirectory = @"" + ExecPath.Text + "";
                Server1ID.Start();
                PIDSer1 = Server1ID.Id;
                ShutdownSer1.Visible = true;
                RestartSer1.Visible = true;
                VACCheck1.Enabled = false;
                NoGraphicsCheck1.Enabled = false;
                BatchCheck1.Enabled = false;
                Server1Off = false;
            }
            else
            {
                MessageBox.Show("Unknown error for server #1.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                await Task.Delay(1000);
            }
        }

        private async void StartServer2()
        {
            Arguments2 = "";
            if (ServerName2.Text == "")
            {
                MessageBox.Show("Error: no server name inserted for server #2.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Restart.Visible = false;
                Shutdown.Visible = false;
                Run.Visible = true;
                AdvancedOptions1.Visible = true;
                AdvancedOptions2.Visible = true;
                AdvancedOptions3.Visible = true;
                AdvancedOptions4.Visible = true;
                await Task.Delay(5000);
                TerminateProcessesGlobal();
            }
            else if (ServerName2.Text != "")
            {
                if (BatchCheck2.Checked == true)
                {
                    Arguments2 = "" + Arguments2 + " -batchmode";
                }
                else if (BatchCheck2.Checked == false)
                {
                    Arguments2 = "" + Arguments2 + "";
                }
                if (NoGraphicsCheck2.Checked == true)
                {
                    Arguments2 = "" + Arguments2 + " -nographics";
                }
                else if (NoGraphicsCheck2.Checked == false)
                {
                    Arguments2 = "" + Arguments2 + "";
                }
                if (VACCheck2.Checked == true)
                {
                    Arguments2 = "" + Arguments2 + " +secureserver";
                }
                else if (VACCheck2.Checked == false)
                {
                    Arguments2 = "" + Arguments2 + " +insecureserver";
                }
                var Server2ID = new Process();
                Server2ID.StartInfo.FileName = @"" + Path + "\\Unturned.exe";
                Server2ID.StartInfo.Arguments = @"" + Arguments2 + "/" + ServerName2.Text + "";
                Server2ID.StartInfo.WorkingDirectory = @"" + ExecPath.Text + "";
                Server2ID.Start();
                PIDSer2 = Server2ID.Id;
                ShutdownSer2.Visible = true;
                RestartSer2.Visible = true;
                VACCheck2.Enabled = false;
                NoGraphicsCheck2.Enabled = false;
                BatchCheck2.Enabled = false;
                Server2Off = false;
            }
            else
            {
                MessageBox.Show("Unknown error for server #2.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Restart.Visible = false;
                Shutdown.Visible = false;
                Run.Visible = true;
                AdvancedOptions1.Visible = true;
                AdvancedOptions2.Visible = true;
                AdvancedOptions3.Visible = true;
                AdvancedOptions4.Visible = true;
                await Task.Delay(5000);
                TerminateProcessesGlobal();
            }
        }

        private async void StartServer3()
        {
            Arguments3 = "";
            if (ServerName3.Text == "")
            {
                MessageBox.Show("Error: no server name inserted for server #3.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Restart.Visible = false;
                Shutdown.Visible = false;
                Run.Visible = true;
                AdvancedOptions1.Visible = true;
                AdvancedOptions2.Visible = true;
                AdvancedOptions3.Visible = true;
                AdvancedOptions4.Visible = true;
                await Task.Delay(5000);
                TerminateProcessesGlobal();
            }
            else if (ServerName3.Text != "")
            {
                if (BatchCheck3.Checked == true)
                {
                    Arguments3 = "" + Arguments3 + " -batchmode";
                }
                else if (BatchCheck3.Checked == false)
                {
                    Arguments3 = "" + Arguments3 + "";
                }
                if (NoGraphicsCheck3.Checked == true)
                {
                    Arguments3 = "" + Arguments3 + " -nographics";
                }
                else if (NoGraphicsCheck3.Checked == false)
                {
                    Arguments3 = "" + Arguments3 + "";
                }
                if (VACCheck3.Checked == true)
                {
                    Arguments3 = "" + Arguments3 + " +secureserver";
                }
                else if (VACCheck3.Checked == false)
                {
                    Arguments3 = "" + Arguments3 + " +insecureserver";
                }
                var Server3ID = new Process();
                Server3ID.StartInfo.FileName = @"" + Path + "\\Unturned.exe";
                Server3ID.StartInfo.Arguments = @"" + Arguments3 + "/" + ServerName3.Text + "";
                Server3ID.StartInfo.WorkingDirectory = @"" + ExecPath.Text + "";
                Server3ID.Start();
                PIDSer3 = Server3ID.Id;
                ShutdownSer3.Visible = true;
                RestartSer3.Visible = true;
                VACCheck3.Enabled = false;
                NoGraphicsCheck3.Enabled = false;
                BatchCheck3.Enabled = false;
                Server3Off = false;
            }
            else
            {
                MessageBox.Show("Unknown error for server #3.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Restart.Visible = false;
                Shutdown.Visible = false;
                Run.Visible = true;
                AdvancedOptions1.Visible = true;
                AdvancedOptions2.Visible = true;
                AdvancedOptions3.Visible = true;
                AdvancedOptions4.Visible = true;
                await Task.Delay(5000);
                TerminateProcessesGlobal();
            }
        }

        private async void StartServer4()
        {
            Arguments4 = "";
            if (ServerName4.Text == "")
            {
                MessageBox.Show("Error: no server name inserted for server #4.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Restart.Visible = false;
                Shutdown.Visible = false;
                Run.Visible = true;
                AdvancedOptions1.Visible = true;
                AdvancedOptions2.Visible = true;
                AdvancedOptions3.Visible = true;
                AdvancedOptions4.Visible = true;
                await Task.Delay(5000);
                TerminateProcessesGlobal();
            }
            else if (ServerName4.Text != "")
            {
                if (BatchCheck4.Checked == true)
                {
                    Arguments4 = "" + Arguments4 + " -batchmode";
                }
                else if (BatchCheck4.Checked == false)
                {
                    Arguments4 = "" + Arguments4 + "";
                }
                if (NoGraphicsCheck4.Checked == true)
                {
                    Arguments4 = "" + Arguments4 + " -nographics";
                }
                else if (NoGraphicsCheck4.Checked == false)
                {
                    Arguments4 = "" + Arguments4 + "";
                }
                if (VACCheck4.Checked == true)
                {
                    Arguments4 = "" + Arguments4 + " +secureserver";
                }
                else if (VACCheck4.Checked == false)
                {
                    Arguments4 = "" + Arguments4 + " +insecureserver";
                }
                var Server4ID = new Process();
                Server4ID.StartInfo.FileName = @"" + Path + "\\Unturned.exe";
                Server4ID.StartInfo.Arguments = @"" + Arguments4 + "/" + ServerName4.Text + "";
                Server4ID.StartInfo.WorkingDirectory = @"" + ExecPath.Text + "";
                Server4ID.Start();
                PIDSer4 = Server4ID.Id;
                ShutdownSer4.Visible = true;
                RestartSer4.Visible = true;
                VACCheck4.Enabled = false;
                NoGraphicsCheck4.Enabled = false;
                BatchCheck4.Enabled = false;
                Server4Off = false;
            }
            else
            {
                MessageBox.Show("Unknown error for server #4.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Restart.Visible = false;
                Shutdown.Visible = false;
                Run.Visible = true;
                AdvancedOptions1.Visible = true;
                AdvancedOptions2.Visible = true;
                AdvancedOptions3.Visible = true;
                AdvancedOptions4.Visible = true;
                await Task.Delay(5000);
                TerminateProcessesGlobal();
            }
        }

        private void HideAll()
        {
            ServerNum.Visible = Hide1;
            Servers2Run.Visible = Hide1;
            ExecDesc.Visible = Hide1;
            ExecPath.Visible = Hide1;
            Server1.Visible = Hide1;
            Server2.Visible = Hide1;
            Server3.Visible = Hide1;
            Server4.Visible = Hide1;
            OptionsDesc1.Visible = Hide1;
            OptionsDesc2.Visible = Hide1;
            OptionsDesc3.Visible = Hide1;
            OptionsDesc4.Visible = Hide1;
            VACCheck1.Visible = Hide1;
            VACCheck2.Visible = Hide1;
            VACCheck3.Visible = Hide1;
            VACCheck4.Visible = Hide1;
            BatchCheck1.Visible = Hide1;
            BatchCheck2.Visible = Hide1;
            BatchCheck3.Visible = Hide1;
            BatchCheck4.Visible = Hide1;
            NoGraphicsCheck1.Visible = Hide1;
            NoGraphicsCheck2.Visible = Hide1;
            NoGraphicsCheck3.Visible = Hide1;
            NoGraphicsCheck4.Visible = Hide1;
            ServerName1.Visible = Hide1;
            ServerName2.Visible = Hide1;
            ServerName3.Visible = Hide1;
            ServerName4.Visible = Hide1;
            NameDesc1.Visible = Hide1;
            NameDesc2.Visible = Hide1;
            NameDesc3.Visible = Hide1;
            NameDesc4.Visible = Hide1;
            AdvancedOptions1.Visible = Hide1;
            AdvancedOptions2.Visible = Hide1;
            AdvancedOptions3.Visible = Hide1;
            AdvancedOptions4.Visible = Hide1;
            Run.Visible = Hide1;
        }

        private async void LoopSaveGlobal()
        {
            int kys = 0;
            while (kys < 5)
            {
                List<string> Config = new List<string>
                {
                Servers2Run.Text,
                ExecPath.Text,
                Convert.ToString(VACCheck1.Checked),
                Convert.ToString(BatchCheck1.Checked),
                Convert.ToString(NoGraphicsCheck1.Checked),
                ServerName1.Text,
                Convert.ToString(VACCheck2.Checked),
                Convert.ToString(BatchCheck2.Checked),
                Convert.ToString(NoGraphicsCheck2.Checked),
                ServerName2.Text,
                Convert.ToString(VACCheck3.Checked),
                Convert.ToString(BatchCheck3.Checked),
                Convert.ToString(NoGraphicsCheck3.Checked),
                ServerName3.Text,
                Convert.ToString(VACCheck4.Checked),
                Convert.ToString(BatchCheck4.Checked),
                Convert.ToString(NoGraphicsCheck4.Checked),
                ServerName4.Text,
                Convert.ToString(DataContainer.ModInstallFirst1),
                Convert.ToString(DataContainer.ModInstallFirst2),
                Convert.ToString(DataContainer.ModInstallFirst3),
                Convert.ToString(DataContainer.ModInstallFirst4),
                Convert.ToString(EnablePlugin.Checked),
                Convert.ToString(PluginInstall1.Enabled),
                Convert.ToString(PluginInstall2.Enabled),
                Convert.ToString(PluginInstall3.Enabled),
                Convert.ToString(PluginInstall4.Enabled),
                PluginInstall1.Text,
                PluginInstall2.Text,
                PluginInstall3.Text,
                PluginInstall4.Text,
                Convert.ToString(AcceptedDebugPlugins)
                };
                CreateConfigSave1();
                CreateConfigSave2();
                CreateConfigSave3();
                CreateConfigSave4();
                try
                {
                    File.WriteAllLines(@"C:\Unturned_Manager\SaveConfig.dat", Config);
                }
                catch (DirectoryNotFoundException)
                {
                    Directory.CreateDirectory(@"C:\Unturned_Manager");
                    File.WriteAllLines(@"C:\Unturned_Manager\SaveConfig.dat", Config);
                }
                await Task.Delay(60000);
            }
        }

        private void CreateConfig1()
        {
            MapSer1 = DataContainer.MapSer1;
            NameSer1 = DataContainer.NameSer1;
            BindSer1 = DataContainer.BindSer1;
            DiffSer1 = DataContainer.DiffSer1;
            LoadoutSer1 = DataContainer.LoadoutSer1;
            PassSer1 = DataContainer.PassSer1;
            WelcomeSer1 = DataContainer.WelcomeSer1;
            try
            {
                MaxPlayers1 = Convert.ToString(DataContainer.MaxPlayers1);
                ChatSer1 = Convert.ToString(DataContainer.ChatSer1);
                CheatSer1 = Convert.ToString(DataContainer.CheatSer1);
                CycleSer1 = Convert.ToString(DataContainer.CycleSer1);
                FilterSer1 = Convert.ToString(DataContainer.FilterSer1);
                FiPerOnly1 = Convert.ToString(DataContainer.FiPerOnly1);
                HideAdminSer1 = Convert.ToString(DataContainer.HideAdminSer1);
                OwnerSer1 = Convert.ToString(DataContainer.OwnerSer1);
                Port1 = Convert.ToString(DataContainer.Port1);
                PVPSer1 = Convert.ToString(DataContainer.PVPSer1);
                QueueSer1 = Convert.ToString(DataContainer.QueueSer1);
                SyncSer1 = Convert.ToString(DataContainer.SyncSer1);
                Continue1 = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("ERROR: INVALID SERVER CONFIG FOR SERVER 1 (how the fuck did you edit them at that level after the first check???). SETTING TO DEFAULT VALUES!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MaxPlayers1 = "24";
                ChatSer1 = "0";
                CheatSer1 = "false";
                CycleSer1 = "43200";
                FilterSer1 = "false";
                FiPerOnly1 = "false";
                HideAdminSer1 = "false";
                OwnerSer1 = "0";
                Port1 = "27015";
                PVPSer1 = "true";
                QueueSer1 = "8";
                SyncSer1 = "false";
                Continue1 = false;
            }
            if (CheatSer1 == "True")
            {
                CheatSer1 = "Cheats";
            }
            else if (CheatSer1 == "False")
            {
                CheatSer1 = "";
            }
            if (FilterSer1 == "True")
            {
                FilterSer1 = "Filter";
            }
            else if (FilterSer1 == "False")
            {
                FilterSer1 = "";
            }
            if (FiPerOnly1 == "True")
            {
                FiPerOnly1 = "First";
            }
            else if (FiPerOnly1 == "False")
            {
                FiPerOnly1 = "Both";
            }
            if (HideAdminSer1 == "True")
            {
                HideAdminSer1 = "hide_admins";
            }
            else if (HideAdminSer1 == "False")
            {
                HideAdminSer1 = "";
            }
            if (PVPSer1 == "True")
            {
                PVPSer1 = "";
            }
            else if (PVPSer1 == "False")
            {
                PVPSer1 = "PvE";
            }
            if (SyncSer1 == "True")
            {
                SyncSer1 = "Sync";
            }
            else if (SyncSer1 == "False")
            {
                SyncSer1 = "";
            }
            if (Continue1 == true)
            {
                List<string> Config1 = new List<string>
                {
                    "Map " + MapSer1,
                    "MaxPlayers " + MaxPlayers1,
                    "ChatRate " + ChatSer1,
                    CheatSer1,
                    "Cycle " + CycleSer1,
                    FilterSer1,
                    "Perspective " + FiPerOnly1,
                    HideAdminSer1,
                    "Owner " + OwnerSer1,
                    "Port " + Port1,
                    PVPSer1,
                    "Queue_Size " + QueueSer1,
                    SyncSer1,
                    "Name " + NameSer1,
                    "Bind " + BindSer1,
                    DiffSer1,
                    "Loadout 255/" + LoadoutSer1,
                    "Password " + PassSer1,
                    "Welcome " + WelcomeSer1
                };
                foreach (string s in Config1)
                {
                    try
                    {
                        File.WriteAllLines(ExecPath.Text + "\\Servers\\" + ServerName1.Text + "\\Server\\Commands.dat", Config1);
                    }
                    catch(DirectoryNotFoundException)
                    {
                        Directory.CreateDirectory(ExecPath.Text + "\\Servers\\" + ServerName1.Text + "\\Server");
                        File.WriteAllLines(ExecPath.Text + "\\Servers\\" + ServerName1.Text + "\\Server\\Commands.dat", Config1);
                    }
                }
            }
        }

        private void CreateConfig2()
        {
            MapSer2 = DataContainer.MapSer2;
            NameSer2 = DataContainer.NameSer2;
            BindSer2 = DataContainer.BindSer2;
            DiffSer2 = DataContainer.DiffSer2;
            LoadoutSer2 = DataContainer.LoadoutSer2;
            PassSer2 = DataContainer.PassSer2;
            WelcomeSer2 = DataContainer.WelcomeSer2;
            try
            {
                MaxPlayers2 = Convert.ToString(DataContainer.MaxPlayers2);
                ChatSer2 = Convert.ToString(DataContainer.ChatSer2);
                CheatSer2 = Convert.ToString(DataContainer.CheatSer2);
                CycleSer2 = Convert.ToString(DataContainer.CycleSer2);
                FilterSer2 = Convert.ToString(DataContainer.FilterSer2);
                FiPerOnly2 = Convert.ToString(DataContainer.FiPerOnly2);
                HideAdminSer2 = Convert.ToString(DataContainer.HideAdminSer2);
                OwnerSer2 = Convert.ToString(DataContainer.OwnerSer2);
                Port2 = Convert.ToString(DataContainer.Port2);
                PVPSer2 = Convert.ToString(DataContainer.PVPSer2);
                QueueSer2 = Convert.ToString(DataContainer.QueueSer2);
                SyncSer2 = Convert.ToString(DataContainer.SyncSer2);
                Continue2 = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("ERROR: INVALID SERVER CONFIG FOR SERVER 2 (how the fuck did you edit them at that level after the first check???). SETTING TO DEFAULT VALUES!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MaxPlayers2 = "24";
                ChatSer2 = "0";
                CheatSer2 = "false";
                CycleSer2 = "43200";
                FilterSer2 = "false";
                FiPerOnly2 = "false";
                HideAdminSer2 = "false";
                OwnerSer2 = "0";
                Port2 = "27015";
                PVPSer2 = "true";
                QueueSer2 = "8";
                SyncSer2 = "false";
                Continue2 = false;
            }
            if (CheatSer2 == "True")
            {
                CheatSer2 = "Cheats";
            }
            else if (CheatSer2 == "False")
            {
                CheatSer2 = "";
            }
            if (FilterSer2 == "True")
            {
                FilterSer2 = "Filter";
            }
            else if (FilterSer2 == "False")
            {
                FilterSer2 = "";
            }
            if (FiPerOnly2 == "True")
            {
                FiPerOnly2 = "First";
            }
            else if (FiPerOnly2 == "False")
            {
                FiPerOnly2 = "Both";
            }
            if (HideAdminSer2 == "True")
            {
                HideAdminSer2 = "hide_admins";
            }
            else if (HideAdminSer2 == "False")
            {
                HideAdminSer2 = "";
            }
            if (PVPSer2 == "True")
            {
                PVPSer2 = "";
            }
            else if (PVPSer2 == "False")
            {
                PVPSer2 = "PvE";
            }
            if (SyncSer2 == "True")
            {
                SyncSer2 = "Sync";
            }
            else if (SyncSer2 == "False")
            {
                SyncSer2 = "";
            }
            if (Continue2 == true)
            {
                List<string> Config2 = new List<string>
                {
                    "Map " + MapSer2,
                    "MaxPlayers " + MaxPlayers2,
                    "ChatRate " + ChatSer2,
                    CheatSer2,
                    "Cycle " + CycleSer2,
                    FilterSer2,
                    "Perspective " + FiPerOnly2,
                    HideAdminSer2,
                    "Owner " + OwnerSer2,
                    "Port " + Port2,
                    PVPSer2,
                    "Queue_Size " + QueueSer2,
                    SyncSer2,
                    "Name " + NameSer2,
                    "Bind " + BindSer2,
                    DiffSer2,
                    "Loadout 255/" + LoadoutSer2,
                    "Password " + PassSer2,
                    "Welcome " + WelcomeSer2
                };
                foreach (string s in Config2)
                {
                    try
                    {
                        File.WriteAllLines(ExecPath.Text + "\\Servers\\" + ServerName2.Text + "\\Server\\Commands.dat", Config2);
                    }
                    catch (DirectoryNotFoundException)
                    {
                        Directory.CreateDirectory(ExecPath.Text + "\\Servers\\" + ServerName2.Text + "\\Server");
                        File.WriteAllLines(ExecPath.Text + "\\Servers\\" + ServerName2.Text + "\\Server\\Commands.dat", Config2);
                    }
                }
            }
        }

        private void CreateConfig3()
        {
            MapSer3 = DataContainer.MapSer3;
            NameSer3 = DataContainer.NameSer3;
            BindSer3 = DataContainer.BindSer3;
            DiffSer3 = DataContainer.DiffSer3;
            LoadoutSer3 = DataContainer.LoadoutSer3;
            PassSer3 = DataContainer.PassSer3;
            WelcomeSer3 = DataContainer.WelcomeSer3;
            try
            {
                MaxPlayers3 = Convert.ToString(DataContainer.MaxPlayers3);
                ChatSer3 = Convert.ToString(DataContainer.ChatSer3);
                CheatSer3 = Convert.ToString(DataContainer.CheatSer3);
                CycleSer3 = Convert.ToString(DataContainer.CycleSer3);
                FilterSer3 = Convert.ToString(DataContainer.FilterSer3);
                FiPerOnly3 = Convert.ToString(DataContainer.FiPerOnly3);
                HideAdminSer3 = Convert.ToString(DataContainer.HideAdminSer3);
                OwnerSer3 = Convert.ToString(DataContainer.OwnerSer3);
                Port3 = Convert.ToString(DataContainer.Port3);
                PVPSer3 = Convert.ToString(DataContainer.PVPSer3);
                QueueSer3 = Convert.ToString(DataContainer.QueueSer3);
                SyncSer3 = Convert.ToString(DataContainer.SyncSer3);
                Continue3 = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("ERROR: INVALID SERVER CONFIG FOR SERVER 3 (how the fuck did you edit them at that level after the first check???). SETTING TO DEFAULT VALUES!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MaxPlayers3 = "24";
                ChatSer3 = "0";
                CheatSer3 = "false";
                CycleSer3 = "43200";
                FilterSer3 = "false";
                FiPerOnly3 = "false";
                HideAdminSer3 = "false";
                OwnerSer3 = "0";
                Port3 = "27015";
                PVPSer3 = "true";
                QueueSer3 = "8";
                SyncSer3 = "false";
                Continue3 = false;
            }
            if (CheatSer3 == "True")
            {
                CheatSer3 = "Cheats";
            }
            else if (CheatSer3 == "False")
            {
                CheatSer3 = "";
            }
            if (FilterSer3 == "True")
            {
                FilterSer3 = "Filter";
            }
            else if (FilterSer3 == "False")
            {
                FilterSer3 = "";
            }
            if (FiPerOnly3 == "True")
            {
                FiPerOnly3 = "First";
            }
            else if (FiPerOnly3 == "False")
            {
                FiPerOnly3 = "Both";
            }
            if (HideAdminSer3 == "True")
            {
                HideAdminSer3 = "hide_admins";
            }
            else if (HideAdminSer3 == "False")
            {
                HideAdminSer3 = "";
            }
            if (PVPSer3 == "True")
            {
                PVPSer3 = "";
            }
            else if (PVPSer3 == "False")
            {
                PVPSer3 = "PvE";
            }
            if (SyncSer3 == "True")
            {
                SyncSer3 = "Sync";
            }
            else if (SyncSer3 == "False")
            {
                SyncSer3 = "";
            }
            if (Continue3 == true)
            {
                List<string> Config3 = new List<string>
                {
                    "Map " + MapSer3,
                    "MaxPlayers " + MaxPlayers3,
                    "ChatRate " + ChatSer3,
                    CheatSer3,
                    "Cycle " + CycleSer3,
                    FilterSer3,
                    "Perspective " + FiPerOnly3,
                    HideAdminSer3,
                    "Owner " + OwnerSer3,
                    "Port " + Port3,
                    PVPSer3,
                    "Queue_Size " + QueueSer3,
                    SyncSer3,
                    "Name " + NameSer3,
                    "Bind " + BindSer3,
                    DiffSer3,
                    "Loadout 255/" + LoadoutSer3,
                    "Password " + PassSer3,
                    "Welcome " + WelcomeSer3
                };
                foreach (string s in Config3)
                {
                    try
                    {
                        File.WriteAllLines(ExecPath.Text + "\\Servers\\" + ServerName3.Text + "\\Server\\Commands.dat", Config3);
                    }
                    catch (DirectoryNotFoundException)
                    {
                        Directory.CreateDirectory(ExecPath.Text + "\\Servers\\" + ServerName3.Text + "\\Server");
                        File.WriteAllLines(ExecPath.Text + "\\Servers\\" + ServerName3.Text + "\\Server\\Commands.dat", Config3);
                    }
                }
            }
        }

        private void CreateConfig4()
        {
            MapSer4 = DataContainer.MapSer4;
            NameSer4 = DataContainer.NameSer4;
            BindSer4 = DataContainer.BindSer4;
            DiffSer4 = DataContainer.DiffSer4;
            LoadoutSer4 = DataContainer.LoadoutSer4;
            PassSer4 = DataContainer.PassSer4;
            WelcomeSer4 = DataContainer.WelcomeSer4;
            try
            {
                MaxPlayers4 = Convert.ToString(DataContainer.MaxPlayers4);
                ChatSer4 = Convert.ToString(DataContainer.ChatSer4);
                CheatSer4 = Convert.ToString(DataContainer.CheatSer4);
                CycleSer4 = Convert.ToString(DataContainer.CycleSer4);
                FilterSer4 = Convert.ToString(DataContainer.FilterSer4);
                FiPerOnly4 = Convert.ToString(DataContainer.FiPerOnly4);
                HideAdminSer4 = Convert.ToString(DataContainer.HideAdminSer4);
                OwnerSer4 = Convert.ToString(DataContainer.OwnerSer4);
                Port4 = Convert.ToString(DataContainer.Port4);
                PVPSer4 = Convert.ToString(DataContainer.PVPSer4);
                QueueSer4 = Convert.ToString(DataContainer.QueueSer4);
                SyncSer4 = Convert.ToString(DataContainer.SyncSer4);
                Continue4 = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("ERROR: INVALID SERVER CONFIG FOR SERVER 4 (how the fuck did you edit them at that level after the first check???). SETTING TO DEFAULT VALUES!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MaxPlayers4 = "24";
                ChatSer4 = "0";
                CheatSer4 = "false";
                CycleSer4 = "43200";
                FilterSer4 = "false";
                FiPerOnly4 = "false";
                HideAdminSer4 = "false";
                OwnerSer4 = "0";
                Port4 = "27015";
                PVPSer4 = "true";
                QueueSer4 = "8";
                SyncSer4 = "false";
                Continue4 = false;
            }
            if (CheatSer4 == "True")
            {
                CheatSer4 = "Cheats";
            }
            else if (CheatSer4 == "False")
            {
                CheatSer4 = "";
            }
            if (FilterSer4 == "True")
            {
                FilterSer4 = "Filter";
            }
            else if (FilterSer4 == "False")
            {
                FilterSer4 = "";
            }
            if (FiPerOnly4 == "True")
            {
                FiPerOnly4 = "First";
            }
            else if (FiPerOnly4 == "False")
            {
                FiPerOnly4 = "Both";
            }
            if (HideAdminSer4 == "True")
            {
                HideAdminSer4 = "hide_admins";
            }
            else if (HideAdminSer4 == "False")
            {
                HideAdminSer4 = "";
            }
            if (PVPSer4 == "True")
            {
                PVPSer4 = "";
            }
            else if (PVPSer4 == "False")
            {
                PVPSer4 = "PvE";
            }
            if (SyncSer4 == "True")
            {
                SyncSer4 = "Sync";
            }
            else if (SyncSer4 == "False")
            {
                SyncSer4 = "";
            }
            if (Continue4 == true)
            {
                List<string> Config4 = new List<string>
                {
                    "Map " + MapSer4,
                    "MaxPlayers " + MaxPlayers4,
                    "ChatRate " + ChatSer4,
                    CheatSer4,
                    "Cycle " + CycleSer4,
                    FilterSer4,
                    "Perspective " + FiPerOnly4,
                    HideAdminSer4,
                    "Owner " + OwnerSer4,
                    "Port " + Port4,
                    PVPSer4,
                    "Queue_Size " + QueueSer4,
                    SyncSer4,
                    "Name " + NameSer4,
                    "Bind " + BindSer4,
                    DiffSer4,
                    "Loadout 255/" + LoadoutSer4,
                    "Password " + PassSer4,
                    "Welcome " + WelcomeSer4
                };
                foreach (string s in Config4)
                {
                    try
                    {
                        File.WriteAllLines(ExecPath.Text + "\\Servers\\" + ServerName4.Text + "\\Server\\Commands.dat", Config4);
                    }
                    catch (DirectoryNotFoundException)
                    {
                        Directory.CreateDirectory(ExecPath.Text + "\\Servers\\" + ServerName4.Text + "\\Server");
                        File.WriteAllLines(ExecPath.Text + "\\Servers\\" + ServerName4.Text + "\\Server\\Commands.dat", Config4);
                    }
                }
            }
        }

        private void CreateConfigSave1()
        {
            MapSer1 = DataContainer.MapSer1;
            NameSer1 = DataContainer.NameSer1;
            BindSer1 = DataContainer.BindSer1;
            DiffSer1 = DataContainer.DiffSer1;
            LoadoutSer1 = DataContainer.LoadoutSer1;
            PassSer1 = DataContainer.PassSer1;
            WelcomeSer1 = DataContainer.WelcomeSer1;
            try
            {
                MaxPlayers1 = Convert.ToString(DataContainer.MaxPlayers1);
                ChatSer1 = Convert.ToString(DataContainer.ChatSer1);
                CheatSer1 = Convert.ToString(DataContainer.CheatSer1);
                CycleSer1 = Convert.ToString(DataContainer.CycleSer1);
                FilterSer1 = Convert.ToString(DataContainer.FilterSer1);
                FiPerOnly1 = Convert.ToString(DataContainer.FiPerOnly1);
                HideAdminSer1 = Convert.ToString(DataContainer.HideAdminSer1);
                OwnerSer1 = Convert.ToString(DataContainer.OwnerSer1);
                Port1 = Convert.ToString(DataContainer.Port1);
                PVPSer1 = Convert.ToString(DataContainer.PVPSer1);
                QueueSer1 = Convert.ToString(DataContainer.QueueSer1);
                SyncSer1 = Convert.ToString(DataContainer.SyncSer1);
                SavedState1 = Convert.ToString(DataContainer.SavedState1);
                Continue1 = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("ERROR: INVALID SERVER CONFIG FOR SERVER 1 [BACKUP] (how the fuck did you edit them at that level after the first check???). SETTING TO DEFAULT VALUES!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MaxPlayers1 = "24";
                ChatSer1 = "0";
                CheatSer1 = "false";
                CycleSer1 = "43200";
                FilterSer1 = "false";
                FiPerOnly1 = "false";
                HideAdminSer1 = "false";
                OwnerSer1 = "0";
                Port1 = "27015";
                PVPSer1 = "true";
                QueueSer1 = "8";
                SyncSer1 = "false";
                SavedState1 = "false";
                Continue1 = false;
            }
            if (Continue1 == true)
            {
                List<string> Config1 = new List<string>
                {
                    MapSer1,
                    MaxPlayers1,
                    ChatSer1,
                    CheatSer1,
                    CycleSer1,
                    FilterSer1,
                    FiPerOnly1,
                    HideAdminSer1,
                    OwnerSer1,
                    Port1,
                    PVPSer1,
                    QueueSer1,
                    SyncSer1,
                    NameSer1,
                    BindSer1,
                    DiffSer1,
                    LoadoutSer1,
                    PassSer1,
                    WelcomeSer1,
                    SavedState1
                };
                foreach (string s in Config1)
                {
                    try
                    {
                        File.WriteAllLines(@"C:\Unturned_Manager\Server1_Advanced_Config.dat", Config1);
                    }
                    catch (DirectoryNotFoundException)
                    {
                        Directory.CreateDirectory(@"C:\Unturned_Manager");
                        File.WriteAllLines(@"C:\Unturned_Manager\Server1_Advanced_Config.dat", Config1);
                    }
                }
            }
        }

        private void CreateConfigSave2()
        {
            MapSer2 = DataContainer.MapSer2;
            NameSer2 = DataContainer.NameSer2;
            BindSer2 = DataContainer.BindSer2;
            DiffSer2 = DataContainer.DiffSer2;
            LoadoutSer2 = DataContainer.LoadoutSer2;
            PassSer2 = DataContainer.PassSer2;
            WelcomeSer2 = DataContainer.WelcomeSer2;
            try
            {
                MaxPlayers2 = Convert.ToString(DataContainer.MaxPlayers2);
                ChatSer2 = Convert.ToString(DataContainer.ChatSer2);
                CheatSer2 = Convert.ToString(DataContainer.CheatSer2);
                CycleSer2 = Convert.ToString(DataContainer.CycleSer2);
                FilterSer2 = Convert.ToString(DataContainer.FilterSer2);
                FiPerOnly2 = Convert.ToString(DataContainer.FiPerOnly2);
                HideAdminSer2 = Convert.ToString(DataContainer.HideAdminSer2);
                OwnerSer2 = Convert.ToString(DataContainer.OwnerSer2);
                Port2 = Convert.ToString(DataContainer.Port2);
                PVPSer2 = Convert.ToString(DataContainer.PVPSer2);
                QueueSer2 = Convert.ToString(DataContainer.QueueSer2);
                SyncSer2 = Convert.ToString(DataContainer.SyncSer2);
                SavedState2 = Convert.ToString(DataContainer.SavedState2);
                Continue2 = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("ERROR: INVALID SERVER CONFIG FOR SERVER 2 [BACKUP] (how the fuck did you edit them at that level after the first check???). SETTING TO DEFAULT VALUES!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MaxPlayers2 = "24";
                ChatSer2 = "0";
                CheatSer2 = "false";
                CycleSer2 = "43200";
                FilterSer2 = "false";
                FiPerOnly2 = "false";
                HideAdminSer2 = "false";
                OwnerSer2 = "0";
                Port2 = "27015";
                PVPSer2 = "true";
                QueueSer2 = "8";
                SyncSer2 = "false";
                SavedState2 = "false";
                Continue2 = false;
            }
            if (Continue2 == true)
            {
                List<string> Config2 = new List<string>
                {
                    MapSer2,
                    MaxPlayers2,
                    ChatSer2,
                    CheatSer2,
                    CycleSer2,
                    FilterSer2,
                    FiPerOnly2,
                    HideAdminSer2,
                    OwnerSer2,
                    Port2,
                    PVPSer2,
                    QueueSer2,
                    SyncSer2,
                    NameSer2,
                    BindSer2,
                    DiffSer2,
                    LoadoutSer2,
                    PassSer2,
                    WelcomeSer2,
                    SavedState2
                };
                foreach (string s in Config2)
                {
                    try
                    {
                        File.WriteAllLines(@"C:\Unturned_Manager\Server2_Advanced_Config.dat", Config2);
                    }
                    catch (DirectoryNotFoundException)
                    {
                        Directory.CreateDirectory(@"C:\Unturned_Manager");
                        File.WriteAllLines(@"C:\Unturned_Manager\Server2_Advanced_Config.dat", Config2);
                    }
                }
            }
        }

        private void CreateConfigSave3()
        {
            MapSer3 = DataContainer.MapSer3;
            NameSer3 = DataContainer.NameSer3;
            BindSer3 = DataContainer.BindSer3;
            DiffSer3 = DataContainer.DiffSer3;
            LoadoutSer3 = DataContainer.LoadoutSer3;
            PassSer3 = DataContainer.PassSer3;
            WelcomeSer3 = DataContainer.WelcomeSer3;
            try
            {
                MaxPlayers3 = Convert.ToString(DataContainer.MaxPlayers3);
                ChatSer3 = Convert.ToString(DataContainer.ChatSer3);
                CheatSer3 = Convert.ToString(DataContainer.CheatSer3);
                CycleSer3 = Convert.ToString(DataContainer.CycleSer3);
                FilterSer3 = Convert.ToString(DataContainer.FilterSer3);
                FiPerOnly3 = Convert.ToString(DataContainer.FiPerOnly3);
                HideAdminSer3 = Convert.ToString(DataContainer.HideAdminSer3);
                OwnerSer3 = Convert.ToString(DataContainer.OwnerSer3);
                Port3 = Convert.ToString(DataContainer.Port3);
                PVPSer3 = Convert.ToString(DataContainer.PVPSer3);
                QueueSer3 = Convert.ToString(DataContainer.QueueSer3);
                SyncSer3 = Convert.ToString(DataContainer.SyncSer3);
                SavedState3 = Convert.ToString(DataContainer.SavedState3);
                Continue3 = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("ERROR: INVALID SERVER CONFIG FOR SERVER 3 [BACKUP] (how the fuck did you edit them at that level after the first check???). SETTING TO DEFAULT VALUES!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MaxPlayers3 = "24";
                ChatSer3 = "0";
                CheatSer3 = "false";
                CycleSer3 = "43200";
                FilterSer3 = "false";
                FiPerOnly3 = "false";
                HideAdminSer3 = "false";
                OwnerSer3 = "0";
                Port3 = "27015";
                PVPSer3 = "true";
                QueueSer3 = "8";
                SyncSer3 = "false";
                SavedState3 = "false";
                Continue3 = false;
            }
            if (Continue3 == true)
            {
                List<string> Config3 = new List<string>
                {
                    MapSer3,
                    MaxPlayers3,
                    ChatSer3,
                    CheatSer3,
                    CycleSer3,
                    FilterSer3,
                    FiPerOnly3,
                    HideAdminSer3,
                    OwnerSer3,
                    Port3,
                    PVPSer3,
                    QueueSer3,
                    SyncSer3,
                    NameSer3,
                    BindSer3,
                    DiffSer3,
                    LoadoutSer3,
                    PassSer3,
                    WelcomeSer3,
                    SavedState3
                };
                foreach (string s in Config3)
                {
                    try
                    {
                        File.WriteAllLines(@"C:\Unturned_Manager\Server3_Advanced_Config.dat", Config3);
                    }
                    catch (DirectoryNotFoundException)
                    {
                        Directory.CreateDirectory(@"C:\Unturned_Manager");
                        File.WriteAllLines(@"C:\Unturned_Manager\Server3_Advanced_Config.dat", Config3);
                    }
                }
            }
        }

        private void CreateConfigSave4()
        {
            MapSer4 = DataContainer.MapSer4;
            NameSer4 = DataContainer.NameSer4;
            BindSer4 = DataContainer.BindSer4;
            DiffSer4 = DataContainer.DiffSer4;
            LoadoutSer4 = DataContainer.LoadoutSer4;
            PassSer4 = DataContainer.PassSer4;
            WelcomeSer4 = DataContainer.WelcomeSer4;
            try
            {
                MaxPlayers4 = Convert.ToString(DataContainer.MaxPlayers4);
                ChatSer4 = Convert.ToString(DataContainer.ChatSer4);
                CheatSer4 = Convert.ToString(DataContainer.CheatSer4);
                CycleSer4 = Convert.ToString(DataContainer.CycleSer4);
                FilterSer4 = Convert.ToString(DataContainer.FilterSer4);
                FiPerOnly4 = Convert.ToString(DataContainer.FiPerOnly4);
                HideAdminSer4 = Convert.ToString(DataContainer.HideAdminSer4);
                OwnerSer4 = Convert.ToString(DataContainer.OwnerSer4);
                Port4 = Convert.ToString(DataContainer.Port4);
                PVPSer4 = Convert.ToString(DataContainer.PVPSer4);
                QueueSer4 = Convert.ToString(DataContainer.QueueSer4);
                SyncSer4 = Convert.ToString(DataContainer.SyncSer4);
                SavedState4 = Convert.ToString(DataContainer.SavedState4);
                Continue4 = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("ERROR: INVALID SERVER CONFIG FOR SERVER 4 [BACKUP] (how the fuck did you edit them at that level after the first check???). SETTING TO DEFAULT VALUES!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MaxPlayers4 = "24";
                ChatSer4 = "0";
                CheatSer4 = "false";
                CycleSer4 = "43200";
                FilterSer4 = "false";
                FiPerOnly4 = "false";
                HideAdminSer4 = "false";
                OwnerSer4 = "0";
                Port4 = "27015";
                PVPSer4 = "true";
                QueueSer4 = "8";
                SyncSer4 = "false";
                SavedState4 = "false";
                Continue4 = false;
            }
            if (Continue4 == true)
            {
                List<string> Config4 = new List<string>
                {
                    MapSer4,
                    MaxPlayers4,
                    ChatSer4,
                    CheatSer4,
                    CycleSer4,
                    FilterSer4,
                    FiPerOnly4,
                    HideAdminSer4,
                    OwnerSer4,
                    Port4,
                    PVPSer4,
                    QueueSer4,
                    SyncSer4,
                    NameSer4,
                    BindSer4,
                    DiffSer4,
                    LoadoutSer4,
                    PassSer4,
                    WelcomeSer4,
                    SavedState4
                };
                foreach (string s in Config4)
                {
                    try
                    {
                        File.WriteAllLines(@"C:\Unturned_Manager\Server4_Advanced_Config.dat", Config4);
                    }
                    catch (DirectoryNotFoundException)
                    {
                        Directory.CreateDirectory(@"C:\Unturned_Manager");
                        File.WriteAllLines(@"C:\Unturned_Manager\Server4_Advanced_Config.dat", Config4);
                    }
                }
            }
        }

        private void LoadConfigGlobal()
        {
            try
            {
                try
                {
                    try
                    {
                        string[] lines = File.ReadAllLines(@"C:\Unturned_Manager\SaveConfig.dat");
                        // Global Stats

                        Servers2Run.Text = lines[0];
                        ExecPath.Text = lines[1];

                        // Server 1 Stats

                        try
                        {
                            VACCheck1.Checked = Convert.ToBoolean(lines[2]);
                        }
                        catch (FormatException)
                        {
                            if (lines[2] == "True")
                            {
                                VACCheck1.Checked = true;
                            }
                            else if (lines[2] == "False")
                            {
                                VACCheck1.Checked = false;
                            }
                        }
                        try
                        {
                            BatchCheck1.Checked = Convert.ToBoolean(lines[3]);
                        }
                        catch (FormatException)
                        {
                            if (lines[3] == "True")
                            {
                                BatchCheck1.Checked = true;
                            }
                            else if (lines[3] == "False")
                            {
                                BatchCheck1.Checked = false;
                            }
                        }
                        try
                        {
                            NoGraphicsCheck1.Checked = Convert.ToBoolean(lines[4]);
                        }
                        catch (FormatException)
                        {
                            if (lines[4] == "True")
                            {
                                NoGraphicsCheck1.Checked = true;
                            }
                            else if (lines[4] == "False")
                            {
                                NoGraphicsCheck1.Checked = false;
                            }
                        }
                        ServerName1.Text = lines[5];

                        // Server 2 Stats

                        try
                        {
                            VACCheck2.Checked = Convert.ToBoolean(lines[6]);
                        }
                        catch (FormatException)
                        {
                            if (lines[6] == "True")
                            {
                                VACCheck2.Checked = true;
                            }
                            else if (lines[6] == "False")
                            {
                                VACCheck2.Checked = false;
                            }
                        }
                        try
                        {
                            BatchCheck2.Checked = Convert.ToBoolean(lines[7]);
                        }
                        catch (FormatException)
                        {
                            if (lines[7] == "True")
                            {
                                BatchCheck2.Checked = true;
                            }
                            else if (lines[7] == "False")
                            {
                                BatchCheck2.Checked = false;
                            }
                        }
                        try
                        {
                            NoGraphicsCheck2.Checked = Convert.ToBoolean(lines[8]);
                        }
                        catch (FormatException)
                        {
                            if (lines[8] == "True")
                            {
                                NoGraphicsCheck2.Checked = true;
                            }
                            else if (lines[8] == "False")
                            {
                                NoGraphicsCheck2.Checked = false;
                            }
                        }
                        ServerName2.Text = lines[9];

                        // Server 3 Stats

                        try
                        {
                            VACCheck3.Checked = Convert.ToBoolean(lines[10]);
                        }
                        catch (FormatException)
                        {
                            if (lines[10] == "True")
                            {
                                VACCheck3.Checked = true;
                            }
                            else if (lines[10] == "False")
                            {
                                VACCheck3.Checked = false;
                            }
                        }
                        try
                        {
                            BatchCheck3.Checked = Convert.ToBoolean(lines[11]);
                        }
                        catch (FormatException)
                        {
                            if (lines[11] == "True")
                            {
                                BatchCheck3.Checked = true;
                            }
                            else if (lines[11] == "False")
                            {
                                BatchCheck3.Checked = false;
                            }
                        }
                        try
                        {
                            NoGraphicsCheck3.Checked = Convert.ToBoolean(lines[12]);
                        }
                        catch (FormatException)
                        {
                            if (lines[12] == "True")
                            {
                                NoGraphicsCheck3.Checked = true;
                            }
                            else if (lines[12] == "False")
                            {
                                NoGraphicsCheck3.Checked = false;
                            }
                        }
                        ServerName3.Text = lines[13];

                        // Server 4 Stats

                        try
                        {
                            VACCheck4.Checked = Convert.ToBoolean(lines[14]);
                        }
                        catch (FormatException)
                        {
                            if (lines[14] == "True")
                            {
                                VACCheck4.Checked = true;
                            }
                            else if (lines[14] == "False")
                            {
                                VACCheck4.Checked = false;
                            }
                        }
                        try
                        {
                            BatchCheck4.Checked = Convert.ToBoolean(lines[15]);
                        }
                        catch (FormatException)
                        {
                            if (lines[15] == "True")
                            {
                                BatchCheck4.Checked = true;
                            }
                            else if (lines[15] == "False")
                            {
                                BatchCheck4.Checked = false;
                            }
                        }
                        try
                        {
                            NoGraphicsCheck4.Checked = Convert.ToBoolean(lines[16]);
                        }
                        catch (FormatException)
                        {
                            if (lines[16] == "True")
                            {
                                NoGraphicsCheck4.Checked = true;
                            }
                            else if (lines[16] == "False")
                            {
                                NoGraphicsCheck4.Checked = false;
                            }
                        }
                        ServerName4.Text = lines[17];
                        try
                        {
                            DataContainer.ModInstallFirst1 = Convert.ToBoolean(lines[18]);
                        }
                        catch (FormatException)
                        {
                            if (lines[18] == "True")
                            {
                                DataContainer.ModInstallFirst1 = true;
                            }
                            else if (lines[18] == "False")
                            {
                                DataContainer.ModInstallFirst1 = false;
                            }
                        }
                        try
                        {
                            DataContainer.ModInstallFirst2 = Convert.ToBoolean(lines[19]);
                        }
                        catch (FormatException)
                        {
                            if (lines[19] == "True")
                            {
                                DataContainer.ModInstallFirst2 = true;
                            }
                            else if (lines[19] == "False")
                            {
                                DataContainer.ModInstallFirst2 = false;
                            }
                        }
                        try
                        {
                            DataContainer.ModInstallFirst3 = Convert.ToBoolean(lines[20]);
                        }
                        catch (FormatException)
                        {
                            if (lines[20] == "True")
                            {
                                DataContainer.ModInstallFirst3 = true;
                            }
                            else if (lines[20] == "False")
                            {
                                DataContainer.ModInstallFirst3 = false;
                            }
                        }
                        try
                        {
                            DataContainer.ModInstallFirst4 = Convert.ToBoolean(lines[21]);
                        }
                        catch (FormatException)
                        {
                            if (lines[21] == "True")
                            {
                                DataContainer.ModInstallFirst4 = true;
                            }
                            else if (lines[21] == "False")
                            {
                                DataContainer.ModInstallFirst4 = false;
                            }
                        }
                        try
                        {
                            AcceptedDebugPlugins = Convert.ToBoolean(lines[31]);
                        }
                        catch (FormatException)
                        {
                            if (lines[31] == "True")
                            {
                                AcceptedDebugPlugins = true;
                            }
                            else if (lines[31] == "False")
                            {
                                AcceptedDebugPlugins = false;
                            }
                        }
                        try
                        {
                            EnablePlugin.Checked = Convert.ToBoolean(lines[22]);
                        }
                        catch (FormatException)
                        {
                            if (lines[22] == "True")
                            {
                                EnablePlugin.Checked = true;
                            }
                            else if (lines[22] == "False")
                            {
                                EnablePlugin.Checked = false;
                            }
                        }
                        try
                        {
                            PluginInstall1.Enabled = Convert.ToBoolean(lines[23]);
                        }
                        catch (FormatException)
                        {
                            if (lines[23] == "True")
                            {
                                PluginInstall1.Enabled = true;
                            }
                            else if (lines[23] == "False")
                            {
                                PluginInstall1.Enabled = false;
                            }
                        }
                        try
                        {
                            PluginInstall2.Enabled = Convert.ToBoolean(lines[24]);
                        }
                        catch (FormatException)
                        {
                            if (lines[24] == "True")
                            {
                                PluginInstall2.Enabled = true;
                            }
                            else if (lines[24] == "False")
                            {
                                PluginInstall2.Enabled = false;
                            }
                        }
                        try
                        {
                            PluginInstall3.Enabled = Convert.ToBoolean(lines[25]);
                        }
                        catch (FormatException)
                        {
                            if (lines[25] == "True")
                            {
                                PluginInstall3.Enabled = true;
                            }
                            else if (lines[25] == "False")
                            {
                                PluginInstall3.Enabled = false;
                            }
                        }
                        try
                        {
                            PluginInstall4.Enabled = Convert.ToBoolean(lines[26]);
                        }
                        catch (FormatException)
                        {
                            if (lines[26] == "True")
                            {
                                PluginInstall4.Enabled = true;
                            }
                            else if (lines[26] == "False")
                            {
                                PluginInstall4.Enabled = false;
                            }
                        }
                        PluginInstall1.Text = lines[27];
                        PluginInstall2.Text = lines[28];
                        PluginInstall3.Text = lines[29];
                        PluginInstall4.Text = lines[30];
                        RefreshSelection();
                    }
                    catch (IndexOutOfRangeException)
                    {
                        DialogResult DeleteCorrupt = MessageBox.Show("The save config is corrupt. Do you want to delete the config file? Clicking \"Yes\" will simply ignore the corrupt data in the config and re-write the config.", "Corrupt", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (DeleteCorrupt == DialogResult.Yes)
                        {
                            File.Delete(@"C:\Unturned_Manager\SaveConfig.dat");
                            // Delete, but allow loaded values to continue
                        }
                        else if (DeleteCorrupt == DialogResult.No)
                        {
                            // Ignore the file but set values to default
                            Startup();
                        }
                    }
                }
                catch(FileNotFoundException)
                {

                }
            }
            catch(DirectoryNotFoundException)
            {
                
            }
        }
        
        private void LoadConfigAdvanced()
        {
            try
            {
                try
                {
                    string[] Server1 = File.ReadAllLines(@"C:\Unturned_Manager\Server1_Advanced_Config.dat");
                    DataContainer.MapSer1 = Server1[0];
                    DataContainer.MaxPlayers1 = Convert.ToInt32(Server1[1]);
                    DataContainer.ChatSer1 = Convert.ToInt32(Server1[2]);
                    DataContainer.CheatSer1 = Convert.ToBoolean(Server1[3]);
                    DataContainer.CycleSer1 = Convert.ToInt32(Server1[4]);
                    DataContainer.FilterSer1 = Convert.ToBoolean(Server1[5]);
                    DataContainer.FiPerOnly1 = Convert.ToBoolean(Server1[6]);
                    DataContainer.HideAdminSer1 = Convert.ToBoolean(Server1[7]);
                    DataContainer.OwnerSer1 = Convert.ToInt32(Server1[8]);
                    DataContainer.Port1 = Convert.ToInt32(Server1[9]);
                    DataContainer.PVPSer1 = Convert.ToBoolean(Server1[10]);
                    DataContainer.QueueSer1 = Convert.ToInt32(Server1[11]);
                    DataContainer.SyncSer1 = Convert.ToBoolean(Server1[12]);
                    DataContainer.NameSer1 = Server1[13];
                    DataContainer.BindSer1 = Server1[14];
                    DataContainer.DiffSer1 = Server1[15];
                    DataContainer.LoadoutSer1 = Server1[16];
                    DataContainer.PassSer1 = Server1[17];
                    DataContainer.WelcomeSer1 = Server1[18];
                    DataContainer.SavedState1 = Convert.ToBoolean(Server1[19]);
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("Server 1's Config File Seems To Be Corrupt Or Missing. Values Reverted To Default.", "");
                }
                try
                {
                    string[] Server2 = File.ReadAllLines(@"C:\Unturned_Manager\Server2_Advanced_Config.dat");
                    DataContainer.MapSer2 = Server2[0];
                    DataContainer.MaxPlayers2 = Convert.ToInt32(Server2[1]);
                    DataContainer.ChatSer2 = Convert.ToInt32(Server2[2]);
                    DataContainer.CheatSer2 = Convert.ToBoolean(Server2[3]);
                    DataContainer.CycleSer2 = Convert.ToInt32(Server2[4]);
                    DataContainer.FilterSer2 = Convert.ToBoolean(Server2[5]);
                    DataContainer.FiPerOnly2 = Convert.ToBoolean(Server2[6]);
                    DataContainer.HideAdminSer2 = Convert.ToBoolean(Server2[7]);
                    DataContainer.OwnerSer2 = Convert.ToInt32(Server2[8]);
                    DataContainer.Port2 = Convert.ToInt32(Server2[9]);
                    DataContainer.PVPSer2 = Convert.ToBoolean(Server2[10]);
                    DataContainer.QueueSer2 = Convert.ToInt32(Server2[11]);
                    DataContainer.SyncSer2 = Convert.ToBoolean(Server2[12]);
                    DataContainer.NameSer2 = Server2[13];
                    DataContainer.BindSer2 = Server2[14];
                    DataContainer.DiffSer2 = Server2[15];
                    DataContainer.LoadoutSer2 = Server2[16];
                    DataContainer.PassSer2 = Server2[17];
                    DataContainer.WelcomeSer2 = Server2[18];
                    DataContainer.SavedState1 = Convert.ToBoolean(Server2[19]);
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("Server 2's Config File Seems To Be Corrupt Or Missing. Values Reverted To Default.", "");
                }
                try
                {
                    string[] Server3 = File.ReadAllLines(@"C:\Unturned_Manager\Server3_Advanced_Config.dat");
                    DataContainer.MapSer3 = Server3[0];
                    DataContainer.MaxPlayers3 = Convert.ToInt32(Server3[1]);
                    DataContainer.ChatSer3 = Convert.ToInt32(Server3[2]);
                    DataContainer.CheatSer3 = Convert.ToBoolean(Server3[3]);
                    DataContainer.CycleSer3 = Convert.ToInt32(Server3[4]);
                    DataContainer.FilterSer3 = Convert.ToBoolean(Server3[5]);
                    DataContainer.FiPerOnly3 = Convert.ToBoolean(Server3[6]);
                    DataContainer.HideAdminSer3 = Convert.ToBoolean(Server3[7]);
                    DataContainer.OwnerSer3 = Convert.ToInt32(Server3[8]);
                    DataContainer.Port3 = Convert.ToInt32(Server3[9]);
                    DataContainer.PVPSer3 = Convert.ToBoolean(Server3[10]);
                    DataContainer.QueueSer3 = Convert.ToInt32(Server3[11]);
                    DataContainer.SyncSer3 = Convert.ToBoolean(Server3[12]);
                    DataContainer.NameSer3 = Server3[13];
                    DataContainer.BindSer3 = Server3[14];
                    DataContainer.DiffSer3 = Server3[15];
                    DataContainer.LoadoutSer3 = Server3[16];
                    DataContainer.PassSer3 = Server3[17];
                    DataContainer.WelcomeSer3 = Server3[18];
                    DataContainer.SavedState1 = Convert.ToBoolean(Server3[19]);
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("Server 3's Config File Seems To Be Corrupt Or Missing. Values Reverted To Default.", "");
                }
                try
                {
                    string[] Server4 = File.ReadAllLines(@"C:\Unturned_Manager\Server4_Advanced_Config.dat");
                    DataContainer.MapSer4 = Server4[0];
                    DataContainer.MaxPlayers4 = Convert.ToInt32(Server4[1]);
                    DataContainer.ChatSer4 = Convert.ToInt32(Server4[2]);
                    DataContainer.CheatSer4 = Convert.ToBoolean(Server4[3]);
                    DataContainer.CycleSer4 = Convert.ToInt32(Server4[4]);
                    DataContainer.FilterSer4 = Convert.ToBoolean(Server4[5]);
                    DataContainer.FiPerOnly4 = Convert.ToBoolean(Server4[6]);
                    DataContainer.HideAdminSer4 = Convert.ToBoolean(Server4[7]);
                    DataContainer.OwnerSer4 = Convert.ToInt32(Server4[8]);
                    DataContainer.Port4 = Convert.ToInt32(Server4[9]);
                    DataContainer.PVPSer4 = Convert.ToBoolean(Server4[10]);
                    DataContainer.QueueSer4 = Convert.ToInt32(Server4[11]);
                    DataContainer.SyncSer4 = Convert.ToBoolean(Server4[12]);
                    DataContainer.NameSer4 = Server4[13];
                    DataContainer.BindSer4 = Server4[14];
                    DataContainer.DiffSer4 = Server4[15];
                    DataContainer.LoadoutSer4 = Server4[16];
                    DataContainer.PassSer4 = Server4[17];
                    DataContainer.WelcomeSer4 = Server4[18];
                    DataContainer.SavedState1 = Convert.ToBoolean(Server4[19]);
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("Server 4's Config File Seems To Be Corrupt Or Missing. Values Reverted To Default.", "");
                }
            }
            catch (DirectoryNotFoundException)
            {

            }
        }

        private async void CheckForServersTakenOff()
        {
            while (Server1Off != true || Server2Off != true || Server3Off != true || Server4Off != true)
            {
                await Task.Delay(100);
                // Ignore
            }
            if (Server1Off == true && Server2Off == true && Server3Off == true && Server4Off == true)
            {
                Restart.Visible = false;
                Shutdown.Visible = false;
                Run.Visible = true;
                ShutdownSer1.Visible = false;
                ShutdownSer2.Visible = false;
                ShutdownSer3.Visible = false;
                ShutdownSer4.Visible = false;
                RestartSer1.Visible = false;
                RestartSer2.Visible = false;
                RestartSer3.Visible = false;
                RestartSer4.Visible = false;
                ServerName1.ReadOnly = false;
                ServerName2.ReadOnly = false;
                ServerName3.ReadOnly = false;
                ServerName4.ReadOnly = false;
                VACCheck1.Enabled = true;
                VACCheck2.Enabled = true;
                VACCheck3.Enabled = true;
                VACCheck4.Enabled = true;
                NoGraphicsCheck1.Enabled = true;
                NoGraphicsCheck2.Enabled = true;
                NoGraphicsCheck3.Enabled = true;
                NoGraphicsCheck4.Enabled = true;
                BatchCheck1.Enabled = true;
                BatchCheck2.Enabled = true;
                BatchCheck3.Enabled = true;
                BatchCheck4.Enabled = true;
                Servers2Run.Enabled = true;
                ExecPath.ReadOnly = false;
            }
        }

        private async void CheckForServersOnline()
        {
            while (Server1Off != false || Server2Off != false || Server3Off != false || Server4Off != false)
            {
                await Task.Delay(100);
                // Ignore
            }
            if (Server1Off == false && Server2Off == false && Server3Off == false && Server4Off == false)
            {
                Restart.Visible = true;
                Shutdown.Visible = true;
                Run.Visible = false;
            }
        }

        private void Servers2Run_DropDown(object sender, System.EventArgs e)
        {
            
        }

        private void Servers2Run_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshSelection();
        }

        private void Run_Click(object sender, EventArgs e)
        {
            Run.Visible = false;
            Restart.Visible = true;
            Shutdown.Visible = true;
            AdvancedOptions1.Visible = false;
            AdvancedOptions2.Visible = false;
            AdvancedOptions3.Visible = false;
            AdvancedOptions4.Visible = false;
            PluginInstall1.Visible = false;
            PluginInstall2.Visible = false;
            PluginInstall3.Visible = false;
            PluginInstall4.Visible = false;
            WorkshopInstall1.Visible = false;
            WorkshopInstall2.Visible = false;
            WorkshopInstall3.Visible = false;
            WorkshopInstall4.Visible = false;
            StartSer1.Visible = false;
            StartSer2.Visible = false;
            StartSer3.Visible = false;
            StartSer4.Visible = false;
            Servers2Run.Enabled = false;
            ExecPath.ReadOnly = true;
            Path = ExecPath.Text;
            Arguments = "";
            Arguments2 = "";
            Arguments3 = "";
            Arguments4 = "";
            try
            {
                Servers = Convert.ToInt32(Servers2Run.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("VALUE FOR SERVERS TO RUN IS NOT A NUMBER (how the fuck did you do that???)", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (Servers == 1)
            {
                ServerName1.ReadOnly = true;
                CreateConfig1();
                StartServer1();
            }
            else if (Servers == 2)
            {
                if (ServerName1.Text == ServerName2.Text)
                {
                    MessageBox.Show("ERROR: Server 1 and 2 have the same name!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Restart.Visible = false;
                    Shutdown.Visible = false;
                    Run.Visible = true;
                    AdvancedOptions1.Visible = true;
                    AdvancedOptions2.Visible = true;
                }
                else if (ServerName1.Text != ServerName2.Text)
                {
                    ServerName1.ReadOnly = true;
                    ServerName2.ReadOnly = true;
                    CreateConfig1();
                    CreateConfig2();
                    StartServer1();
                    StartServer2();
                }
            }
            else if (Servers == 3)
            {
                if (ServerName1.Text == ServerName2.Text)
                {
                    MessageBox.Show("ERROR: Server 1 and 2 have the same name!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Restart.Visible = false;
                    Shutdown.Visible = false;
                    Run.Visible = true;
                    AdvancedOptions1.Visible = true;
                    AdvancedOptions2.Visible = true;
                    AdvancedOptions3.Visible = true;
                }
                else if (ServerName1.Text == ServerName3.Text)
                {
                    MessageBox.Show("ERROR: Server 1 and 3 have the same name!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Restart.Visible = false;
                    Shutdown.Visible = false;
                    Run.Visible = true;
                    AdvancedOptions1.Visible = true;
                    AdvancedOptions2.Visible = true;
                    AdvancedOptions3.Visible = true;
                }
                else if (ServerName2.Text == ServerName3.Text)
                {
                    MessageBox.Show("ERROR: Server 2 and 3 have the same name!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Restart.Visible = false;
                    Shutdown.Visible = false;
                    Run.Visible = true;
                    AdvancedOptions1.Visible = true;
                    AdvancedOptions2.Visible = true;
                    AdvancedOptions3.Visible = true;
                }
                else if (ServerName1.Text != ServerName2.Text && ServerName1.Text != ServerName3.Text && ServerName2.Text != ServerName3.Text)
                {
                    ServerName1.ReadOnly = true;
                    ServerName2.ReadOnly = true;
                    ServerName3.ReadOnly = true;
                    CreateConfig1();
                    CreateConfig2();
                    CreateConfig3();
                    StartServer1();
                    StartServer2();
                    StartServer3();
                }
            }
            else if (Servers == 4)
            {
                if (ServerName1.Text == ServerName2.Text)
                {
                    MessageBox.Show("ERROR: Server 1 and 2 have the same name!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Restart.Visible = false;
                    Shutdown.Visible = false;
                    Run.Visible = true;
                    AdvancedOptions1.Visible = true;
                    AdvancedOptions2.Visible = true;
                    AdvancedOptions3.Visible = true;
                    AdvancedOptions4.Visible = true;
                }
                else if (ServerName1.Text == ServerName3.Text)
                {
                    MessageBox.Show("ERROR: Server 1 and 3 have the same name!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Restart.Visible = false;
                    Shutdown.Visible = false;
                    Run.Visible = true;
                    AdvancedOptions1.Visible = true;
                    AdvancedOptions2.Visible = true;
                    AdvancedOptions3.Visible = true;
                    AdvancedOptions4.Visible = true;
                }
                else if (ServerName1.Text == ServerName4.Text)
                {
                    MessageBox.Show("ERROR: Server 1 and 4 have the same name!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Restart.Visible = false;
                    Shutdown.Visible = false;
                    Run.Visible = true;
                    AdvancedOptions1.Visible = true;
                    AdvancedOptions2.Visible = true;
                    AdvancedOptions3.Visible = true;
                    AdvancedOptions4.Visible = true;
                }
                else if (ServerName2.Text == ServerName3.Text)
                {
                    MessageBox.Show("ERROR: Server 2 and 3 have the same name!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Restart.Visible = false;
                    Shutdown.Visible = false;
                    Run.Visible = true;
                    AdvancedOptions1.Visible = true;
                    AdvancedOptions2.Visible = true;
                    AdvancedOptions3.Visible = true;
                    AdvancedOptions4.Visible = true;
                }
                else if (ServerName2.Text == ServerName4.Text)
                {
                    MessageBox.Show("ERROR: Server 2 and 4 have the same name!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Restart.Visible = false;
                    Shutdown.Visible = false;
                    Run.Visible = true;
                    AdvancedOptions1.Visible = true;
                    AdvancedOptions2.Visible = true;
                    AdvancedOptions3.Visible = true;
                    AdvancedOptions4.Visible = true;
                }
                else if (ServerName3.Text == ServerName4.Text)
                {
                    MessageBox.Show("ERROR: Server 3 and 4 have the same name!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Restart.Visible = false;
                    Shutdown.Visible = false;
                    Run.Visible = true;
                    AdvancedOptions1.Visible = true;
                    AdvancedOptions2.Visible = true;
                    AdvancedOptions3.Visible = true;
                    AdvancedOptions4.Visible = true;
                }
                else if (ServerName1.Text != ServerName2.Text && ServerName1.Text != ServerName3.Text && ServerName1.Text != ServerName4.Text && ServerName2.Text != ServerName3.Text && ServerName2.Text != ServerName4.Text && ServerName3.Text != ServerName4.Text)
                {
                    ServerName1.ReadOnly = true;
                    ServerName2.ReadOnly = true;
                    ServerName3.ReadOnly = true;
                    ServerName4.ReadOnly = true;
                    CreateConfig1();
                    CreateConfig2();
                    CreateConfig3();
                    CreateConfig4();
                    StartServer1();
                    StartServer2();
                    StartServer3();
                    StartServer4();
                }
            }
            CheckForServersTakenOff();
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            try
            {
                Servers = Convert.ToInt32(Servers2Run.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("VALUE FOR SERVERS TO RUN IS NOT A NUMBER (how the fuck did you do that???)", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Servers = 1;
            }
            TerminateProcessesGlobal();
            if (Servers == 1)
            {
                CreateConfig1();
                StartServer1();
            }
            else if (Servers == 2)
            {
                CreateConfig1();
                CreateConfig2();
                StartServer1();
                StartServer2();
            }
            else if (Servers == 3)
            {
                CreateConfig1();
                CreateConfig2();
                CreateConfig3();
                StartServer1();
                StartServer2();
                StartServer3();
            }
            else if (Servers == 4)
            {
                CreateConfig1();
                CreateConfig2();
                CreateConfig3();
                CreateConfig4();
                StartServer1();
                StartServer2();
                StartServer3();
                StartServer4();
            }
        }

        private void Shutdown_Click(object sender, EventArgs e)
        {
            Restart.Visible = false;
            Shutdown.Visible = false;
            Run.Visible = true;
            StartSer1.Visible = false;
            StartSer2.Visible = false;
            StartSer3.Visible = false;
            StartSer4.Visible = false;
            ShutdownSer1.Visible = false;
            ShutdownSer2.Visible = false;
            ShutdownSer3.Visible = false;
            ShutdownSer4.Visible = false;
            RestartSer1.Visible = false;
            RestartSer2.Visible = false;
            RestartSer3.Visible = false;
            RestartSer4.Visible = false;
            ServerName1.ReadOnly = false;
            ServerName2.ReadOnly = false;
            ServerName3.ReadOnly = false;
            ServerName4.ReadOnly = false;
            VACCheck1.Enabled = true;
            VACCheck2.Enabled = true;
            VACCheck3.Enabled = true;
            VACCheck4.Enabled = true;
            NoGraphicsCheck1.Enabled = true;
            NoGraphicsCheck2.Enabled = true;
            NoGraphicsCheck3.Enabled = true;
            NoGraphicsCheck4.Enabled = true;
            BatchCheck1.Enabled = true;
            BatchCheck2.Enabled = true;
            BatchCheck3.Enabled = true;
            BatchCheck4.Enabled = true;
            Servers2Run.Enabled = true;
            ExecPath.ReadOnly = false;
            RefreshSelection();
            TerminateProcessesGlobal();
        }

        private void AdvancedOptions1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void AdvancedOptions2_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();
        }

        private void AdvancedOptions3_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.ShowDialog();
        }

        private void AdvancedOptions4_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.ShowDialog();
        }

        private void GithubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/persiafighter/UnturnedServerManager");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.reddit.com/r/unturned/comments/546y67/unturned_server_manager/");
        }

        private void RocketInstall_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please do not worry if the interface freezes. This is because it is currently downloading the required files. Thank you for your patience.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RocketInstall f = new RocketInstall();
            f.ShowDialog();
        }

        private void ExecPath_TextChanged(object sender, EventArgs e)
        {
            DataContainer.ServerPath = ExecPath.Text;
        }

        private void ShutdownSer1_Click(object sender, EventArgs e)
        {
            TerminateServer1();
            AdvancedOptions1.Visible = true;
            VACCheck1.Enabled = true;
            BatchCheck1.Enabled = true;
            NoGraphicsCheck1.Enabled = true;
            ServerName1.ReadOnly = false;
            WorkshopInstall1.Visible = true;
            PluginInstall1.Visible = true;
            ShutdownSer1.Visible = false;
            RestartSer1.Visible = false;
            StartSer1.Visible = true;
            Server1Off = true;
        }

        private void ShutdownSer2_Click(object sender, EventArgs e)
        {
            TerminateServer2();
            AdvancedOptions2.Visible = true;
            VACCheck2.Enabled = true;
            BatchCheck2.Enabled = true;
            NoGraphicsCheck2.Enabled = true;
            ServerName2.ReadOnly = false;
            WorkshopInstall2.Visible = true;
            PluginInstall2.Visible = true;
            ShutdownSer2.Visible = false;
            RestartSer2.Visible = false;
            StartSer2.Visible = true;
            Server2Off = true;
        }

        private void ShutdownSer3_Click(object sender, EventArgs e)
        {
            TerminateServer3();
            AdvancedOptions3.Visible = true;
            VACCheck3.Enabled = true;
            BatchCheck3.Enabled = true;
            NoGraphicsCheck3.Enabled = true;
            ServerName3.ReadOnly = false;
            WorkshopInstall3.Visible = true;
            PluginInstall3.Visible = true;
            ShutdownSer3.Visible = false;
            RestartSer3.Visible = false;
            StartSer3.Visible = true;
            Server3Off = true;
        }

        private void ShutdownSer4_Click(object sender, EventArgs e)
        {
            TerminateServer4();
            AdvancedOptions4.Visible = true;
            VACCheck4.Enabled = true;
            BatchCheck4.Enabled = true;
            NoGraphicsCheck4.Enabled = true;
            ServerName4.ReadOnly = false;
            WorkshopInstall4.Visible = true;
            PluginInstall4.Visible = true;
            ShutdownSer4.Visible = false;
            RestartSer4.Visible = false;
            StartSer4.Visible = true;
            Server4Off = true;
        }

        private void RestartSer1_Click(object sender, EventArgs e)
        {
            TerminateServer1();
            StartServer1();
        }

        private void RestartSer2_Click(object sender, EventArgs e)
        {
            TerminateServer2();
            StartServer2();
        }

        private void RestartSer3_Click(object sender, EventArgs e)
        {
            TerminateServer3();
            StartServer3();
        }

        private void RestartSer4_Click(object sender, EventArgs e)
        {
            TerminateServer4();
            StartServer4();
        }

        private void StartSer1_Click(object sender, EventArgs e)
        {
            ServerName1.ReadOnly = true;
            StartSer1.Visible = false;
            RestartSer1.Visible = true;
            ShutdownSer1.Visible = true;
            AdvancedOptions1.Visible = false;
            PluginInstall1.Visible = false;
            WorkshopInstall1.Visible = false;
            Servers2Run.Enabled = false;
            ExecPath.ReadOnly = true;
            Path = ExecPath.Text;
            Arguments = "";
            CreateConfig1();
            StartServer1();
            CheckForServersOnline();
            CheckForServersTakenOff();
        }

        private void StartSer2_Click(object sender, EventArgs e)
        {
            ServerName2.ReadOnly = true;
            StartSer2.Visible = false;
            RestartSer2.Visible = true;
            ShutdownSer2.Visible = true;
            AdvancedOptions2.Visible = false;
            PluginInstall2.Visible = false;
            WorkshopInstall2.Visible = false;
            Servers2Run.Enabled = false;
            ExecPath.ReadOnly = true;
            Path = ExecPath.Text;
            Arguments2 = "";
            CreateConfig2();
            StartServer2();
            CheckForServersOnline();
            CheckForServersTakenOff();
        }

        private void StartSer3_Click(object sender, EventArgs e)
        {
            ServerName3.ReadOnly = true;
            StartSer3.Visible = false;
            RestartSer3.Visible = true;
            ShutdownSer3.Visible = true;
            AdvancedOptions3.Visible = false;
            PluginInstall3.Visible = false;
            WorkshopInstall3.Visible = false;
            Servers2Run.Enabled = false;
            ExecPath.ReadOnly = true;
            Path = ExecPath.Text;
            Arguments3 = "";
            CreateConfig3();
            StartServer3();
            CheckForServersOnline();
            CheckForServersTakenOff();
        }

        private void StartSer4_Click(object sender, EventArgs e)
        {
            ServerName4.ReadOnly = true;
            StartSer4.Visible = false;
            RestartSer4.Visible = true;
            ShutdownSer4.Visible = true;
            AdvancedOptions4.Visible = false;
            PluginInstall4.Visible = false;
            WorkshopInstall4.Visible = false;
            Servers2Run.Enabled = false;
            ExecPath.ReadOnly = true;
            Path = ExecPath.Text;
            Arguments4 = "";
            CreateConfig4();
            StartServer4();
            CheckForServersOnline();
            CheckForServersTakenOff();
        }

        private void WorkshopInstall1_Click(object sender, EventArgs e)
        {
            DataContainer.FolderName1 = ServerName1.Text;
            Workshop1 f = new Workshop1();
            f.ShowDialog();
        }

        private void WorkshopInstall2_Click(object sender, EventArgs e)
        {
            DataContainer.FolderName2 = ServerName2.Text;
            Workshop2 f = new Workshop2();
            f.ShowDialog();
        }

        private void WorkshopInstall3_Click(object sender, EventArgs e)
        {
            DataContainer.FolderName3 = ServerName3.Text;
            Workshop3 f = new Workshop3();
            f.ShowDialog();
        }

        private void WorkshopInstall4_Click(object sender, EventArgs e)
        {
            DataContainer.FolderName4 = ServerName4.Text;
            Workshop4 f = new Workshop4();
            f.ShowDialog();
        }

        private void PluginInstall1_Click(object sender, EventArgs e)
        {
            if (DataContainer.ModInstallFirst1 == true)
            {
                MessageBox.Show("Since this is the first time that you are going to install mods, we are going to download all required libraries. Please wait at least a minute for the download to complete.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            DataContainer.FolderName1 = ServerName1.Text;
            Plugins1 f = new Plugins1();
            f.ShowDialog();
        }

        private void EnablePlugin_CheckedChanged(object sender, EventArgs e)
        {
            if (EnablePlugin.Checked == true)
            {
                if (AcceptedDebugPlugins == false)
                {
                    DialogResult Warning = MessageBox.Show("Enabling this feature can result in very weird and unhandled exceptions or errors. Do you still want to enable the feature?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (Warning == DialogResult.Yes)
                    {
                        PluginInstall1.Enabled = true;
                        PluginInstall2.Enabled = true;
                        PluginInstall3.Enabled = true;
                        PluginInstall4.Enabled = true;
                        PluginInstall1.Text = "Install Plugins";
                        PluginInstall2.Text = "Install Plugins";
                        PluginInstall3.Text = "Install Plugins";
                        PluginInstall4.Text = "Install Plugins";
                        AcceptedDebugPlugins = true;
                    }
                    else if (Warning == DialogResult.No)
                    {
                        EnablePlugin.Checked = false;
                    }
                }
                else if (AcceptedDebugPlugins == true)
                {
                    PluginInstall1.Enabled = true;
                    PluginInstall2.Enabled = true;
                    PluginInstall3.Enabled = true;
                    PluginInstall4.Enabled = true;
                    PluginInstall1.Text = "Install Plugins";
                    PluginInstall2.Text = "Install Plugins";
                    PluginInstall3.Text = "Install Plugins";
                    PluginInstall4.Text = "Install Plugins";
                }
            }
            else if (EnablePlugin.Checked == false)
            {
                PluginInstall1.Enabled = false;
                PluginInstall2.Enabled = false;
                PluginInstall3.Enabled = false;
                PluginInstall4.Enabled = false;
                PluginInstall1.Text = "Disabled";
                PluginInstall2.Text = "Disabled";
                PluginInstall3.Text = "Disabled";
                PluginInstall4.Text = "Disabled";
            }
        }
    }
    public static class DataContainer
    {
        /* Current Modifiers:
         * Map
         * PvP
         * First Person
         * Max Players
         * Port
         * Name
         * Difficulty
         * Cheats
         * Password
         * Queue Size
         * Owner
         * Welcome Message
         * Sync
         * Loadout
         * Hide Admins
         * Bind (to ip)
         * Filter
         * Cycle
         * Chat Rate
         * 
        /* Modifiers To Config:
         * 
        /* Modifiers to add:
         * Votify
         */
        public static string MapSer1;
        public static string MapSer2;
        public static string MapSer3;
        public static string MapSer4;
        public static bool PVPSer1;
        public static bool PVPSer2;
        public static bool PVPSer3;
        public static bool PVPSer4;
        public static bool FiPerOnly1;
        public static bool FiPerOnly2;
        public static bool FiPerOnly3;
        public static bool FiPerOnly4;
        public static int MaxPlayers1;
        public static int MaxPlayers2;
        public static int MaxPlayers3;
        public static int MaxPlayers4;
        public static int Port1;
        public static int Port2;
        public static int Port3;
        public static int Port4;
        public static string NameSer1;
        public static string NameSer2;
        public static string NameSer3;
        public static string NameSer4;
        public static string DiffSer1;
        public static string DiffSer2;
        public static string DiffSer3;
        public static string DiffSer4;
        public static bool CheatSer1;
        public static bool CheatSer2;
        public static bool CheatSer3;
        public static bool CheatSer4;
        public static string PassSer1;
        public static string PassSer2;
        public static string PassSer3;
        public static string PassSer4;
        public static int QueueSer1;
        public static int QueueSer2;
        public static int QueueSer3;
        public static int QueueSer4;
        public static long OwnerSer1;
        public static long OwnerSer2;
        public static long OwnerSer3;
        public static long OwnerSer4;
        public static string WelcomeSer1;
        public static string WelcomeSer2;
        public static string WelcomeSer3;
        public static string WelcomeSer4;
        public static bool SyncSer1;
        public static bool SyncSer2;
        public static bool SyncSer3;
        public static bool SyncSer4;
        public static string LoadoutSer1;
        public static string LoadoutSer2;
        public static string LoadoutSer3;
        public static string LoadoutSer4;
        public static bool HideAdminSer1;
        public static bool HideAdminSer2;
        public static bool HideAdminSer3;
        public static bool HideAdminSer4;
        public static string BindSer1;
        public static string BindSer2;
        public static string BindSer3;
        public static string BindSer4;
        public static bool FilterSer1;
        public static bool FilterSer2;
        public static bool FilterSer3;
        public static bool FilterSer4;
        public static int CycleSer1;
        public static int CycleSer2;
        public static int CycleSer3;
        public static int CycleSer4;
        public static int ChatSer1;
        public static int ChatSer2;
        public static int ChatSer3;
        public static int ChatSer4;
        public static bool SavedState1;
        public static bool SavedState2;
        public static bool SavedState3;
        public static bool SavedState4;
        public static string FolderName1;
        public static string FolderName2;
        public static string FolderName3;
        public static string FolderName4;
        public static string ServerPath;
        public static object[] ModdedItems;
        public static bool SavedStateWorkshop;
        public static int ServersRunning;
        public static bool ModInstallFirst1;
        public static bool ModInstallFirst2;
        public static bool ModInstallFirst3;
        public static bool ModInstallFirst4;
    }
}