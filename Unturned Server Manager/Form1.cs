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
        public Manager()
        {
            InitializeComponent();
            Startup();
            Hide1 = false;
        }

        private void Startup()
        { 
            Shutdown.Visible = false;
            Restart.Visible = false;
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
            VACCheck1.Checked = true;
            BatchCheck1.Checked = true;
            NoGraphicsCheck1.Checked = true;
            LoadConfigGlobal();
            LoadConfigAdvanced();
            ServerName1.Text = "Server";
            ExecPath.Text = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Unturned";
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

        private void TerminateProcesses()
        {
            foreach (var process in Process.GetProcessesByName("Unturned"))
            {
                process.Kill();
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
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = @"" + Path + "\\Unturned.exe";
                startInfo.Arguments = @"" + Arguments + "/" + ServerName1.Text + "";
                startInfo.WorkingDirectory = @"" + ExecPath.Text + "";
                Process.Start(startInfo);
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
                TerminateProcesses();
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
                ProcessStartInfo startInfo2 = new ProcessStartInfo();
                startInfo2.FileName = @"" + Path + "\\Unturned.exe";
                startInfo2.Arguments = @"" + Arguments2 + "/" + ServerName2.Text + "";
                startInfo2.WorkingDirectory = @"" + ExecPath.Text + "";
                Process.Start(startInfo2);
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
                TerminateProcesses();
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
                TerminateProcesses();
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
                ProcessStartInfo startInfo3 = new ProcessStartInfo();
                startInfo3.FileName = @"" + Path + "\\Unturned.exe";
                startInfo3.Arguments = @"" + Arguments3 + "/" + ServerName3.Text + "";
                startInfo3.WorkingDirectory = @"" + ExecPath.Text + "";
                Process.Start(startInfo3);
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
                TerminateProcesses();
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
                TerminateProcesses();
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
                ProcessStartInfo startInfo4 = new ProcessStartInfo();
                startInfo4.FileName = @"" + Path + "\\Unturned.exe";
                startInfo4.Arguments = @"" + Arguments4 + "/" + ServerName4.Text + "";
                startInfo4.WorkingDirectory = @"" + ExecPath.Text + "";
                Process.Start(startInfo4);
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
                TerminateProcesses();
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

        private void CreateConfigGlobal()
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
                    RefreshSelection();
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
            Path = ExecPath.Text;
            Arguments = "";
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
                CreateConfigGlobal();
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
                    CreateConfigGlobal();
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
                    CreateConfigGlobal();
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
                    CreateConfigGlobal();
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
            }
            TerminateProcesses();
            if (Servers == 1)
            {
                CreateConfigGlobal();
                CreateConfig1();
                StartServer1();
            }
            else if (Servers == 2)
            {
                CreateConfigGlobal();
                CreateConfig1();
                CreateConfig2();
                StartServer1();
                StartServer2();
            }
            else if (Servers == 3)
            {
                CreateConfigGlobal();
                CreateConfig1();
                CreateConfig2();
                CreateConfig3();
                StartServer1();
                StartServer2();
                StartServer3();
            }
            else if (Servers == 4)
            {
                CreateConfigGlobal();
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
            RefreshSelection();
            TerminateProcesses();
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
        public static int OwnerSer1;
        public static int OwnerSer2;
        public static int OwnerSer3;
        public static int OwnerSer4;
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
    }
}
