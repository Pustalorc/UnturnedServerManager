using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unturned_Server_Manager
{
    public partial class Plugins1 : Form
    {
        #region Variables
        private List<string> PublicPlugins;
        public bool Error = false;
        private string AntiCombatLogDownload = "https://ci.dev.rocketmod.net/job/AntiCombatLog/77//artifact/bin/Release/AntiCombatLog.zip";
        private string AutoShutdownDownload = "https://dev.rocketmod.net/wp-content/uploads/AutoShutdown2-0.6.1.zip";
        private string AdminHelpDownload = "https://dev.rocketmod.net/wp-content/uploads/AdminHelp-5.zip";
        private string AirdropManagerDownload = "https://dev.rocketmod.net/wp-content/uploads/AirdropManager-6.zip";
        private string BackinBlackDownload = "https://dev.rocketmod.net/wp-content/uploads/BackInBlack2.zip";
        private string CarKickDownload = "https://dev.rocketmod.net/wp-content/uploads/carkick.zip";
        private string ChatControlDownload = "https://ci.rocketmod.net/job/ChatControl/294//artifact/bin/Release/ChatControl.zip";
        private string DeathManagerDownload = "https://dev.rocketmod.net/wp-content/uploads/Death-Manager-1.3.3.2.zip";
        private string DutyDownload = "https://dev.rocketmod.net/wp-content/uploads/Duty-7.zip";
        private string EasyAmmoDownload = "https://ci.dev.rocketmod.net/job/EasyAmmo/144//artifact/bin/Release/EasyAmmo.zip";
        private string FreeFallDownload = "https://dev.rocketmod.net/wp-content/uploads/freefall.zip";
        private string FeexRanksDownload = "https://ci.dev.rocketmod.net/job/FeexRanks/31//artifact/bin/Release/FeexRanks.zip";
        private string FeexHitmanDownload = "https://ci.dev.rocketmod.net/job/FeexHitman/31//artifact/bin/Release/FeexHitman.zip";
        private string FeexLimiterDownload = "https://ci.dev.rocketmod.net/job/FeexLimiter/32//artifact/bin/Release/FeexLimiter.zip";
        private string FeexGeoBlockDownload = "https://ci.dev.rocketmod.net/job/FeexGeoBlock/33//artifact/bin/Release/FeexGeoBlock.zip";
        private string FeexExpDownload = "https://ci.dev.rocketmod.net/job/FeexExp/33//artifact/bin/Release/FeexExp.zip";
        private string FeexAfkDownload = "https://ci.dev.rocketmod.net/job/FeexAFK/31//artifact/bin/Release/FeexAFK.zip";
        private string GlobalBanDownload = "https://ci.rocketmod.net/job/GlobalBan/335//artifact/bin/Release/GlobalBan.zip";
        private string IsAbusingDownload = "https://dev.rocketmod.net/wp-content/uploads/IsAbusing-7.zip";
        private string ItemRestrictionsDownload = "https://dev.rocketmod.net/wp-content/uploads/RocketMod_ItemRestrictions-1.zip";
        private string JailTimeDownload = "https://dev.rocketmod.net/wp-content/uploads/JailTimeFree-1.zip";
        private string JoinLeaveMessagesDownload = "https://dev.rocketmod.net/wp-content/uploads/JoinLeaveMessages-4.zip";
        private string KillDownload = "https://dev.rocketmod.net/wp-content/uploads/Kill.zip";
        private string KeepInventoryDownload = "https://dev.rocketmod.net/wp-content/uploads/KeepInventory.zip";
        private string KitsDownload = "https://ci.rocketmod.net/job/Kits/330//artifact/bin/Release/Kits.zip";
        private string LPXDownload = "https://dev.rocketmod.net/wp-content/uploads/LPX-68.zip";
        private string MOTDDownload = "https://dev.rocketmod.net/wp-content/uploads/MOTD-3.zip";
        private string AnnouncerDownload = "https://ci.rocketmod.net/job/MessageAnnouncer/313//artifact/bin/Release/MessageAnnouncer.zip";
        private string MOTDgdDownload = "https://dev.rocketmod.net/wp-content/uploads/MOTDgd-1.zip";
        private string ObservatoryDownload = "https://ci.dev.rocketmod.net/job/Observatory/47//artifact/Release/Observatory.zip";
        private string PMDownload = "https://dev.rocketmod.net/wp-content/uploads/PrivateMessage-6.zip";
        private string RegionsDownload = "https://dev.rocketmod.net/wp-content/uploads/RocketRegions-6.zip";
        private string ReputationDownload = "https://dev.rocketmod.net/wp-content/uploads/Reputation-7.zip";
        private string ReservedSlotsDownload = "https://ci.dev.rocketmod.net/job/ReservedSlots/80//artifact/bin/Release/ReservedSlots.zip";
        private string SpyAllDownload = "https://dev.rocketmod.net/wp-content/uploads/SpyAll-1.zip";
        private string BackupDownload = "https://dev.rocketmod.net/wp-content/uploads/SplashBackup-6.zip";
        private string StatsDownload = "https://ci.dev.rocketmod.net/job/StatKeeper/96//artifact/bin/Release/StatKeeper.zip";
        private string TPSDownload = "https://dev.rocketmod.net/wp-content/uploads/FPSCap-6.zip";
        private string TPADownload = "https://ci.dev.rocketmod.net/job/TPA/77//artifact/bin/Release/TPA.zip";
        private string UessentialsDownload = "https://dev.rocketmod.net/wp-content/uploads/uEssentials-1.2.9.0-1.zip";
        private string UconomyDownload = "https://ci.rocketmod.net/job/Uconomy/321//artifact/bin/Release/Uconomy.zip";
        private string VehicleEventsDownload = "https://dev.rocketmod.net/wp-content/uploads/VehicleEvents-5.zip";
        private string WreckingBallDownload = "https://dev.rocketmod.net/wp-content/uploads/WreckingBall-47.zip";
        private string WarpsDownload = "https://dev.rocketmod.net/wp-content/uploads/Warps-9.zip";
        private string ZaupHomeDownload = "https://ci.dev.rocketmod.net/job/ZaupHomeCommand/78//artifact/bin/Release/ZaupHomeCommand.zip";
        private string ZaupFeastDownload = "https://ci.dev.rocketmod.net/job/ZaupFeast/85//artifact/bin/Release/ZaupFeast.zip";
        private string ZaupClearInvDownload = "https://ci.dev.rocketmod.net/job/ZaupClearInventoryLib/77//artifact/bin/Release/ZaupClearInventoryLib.zip";
        private string ZaupUconomyDownload = "https://ci.dev.rocketmod.net/job/ZaupUconomyEssentials/77//artifact/bin/Release/ZaupUconomyEssentials.zip";
        private string ZaupShopDownload = "https://ci.dev.rocketmod.net/job/ZaupShop/79//artifact/bin/Release/ZaupShop.zip";
        #endregion
        public Plugins1()
        {
            InitializeComponent();
            InstallLibraries();
            LoadAvailablePlugins();
            DisplayAvailablePlugins();
            LoadInstalledPlugins();
        }

        private void InstallLibraries()
        {
            string destination2 = DataContainer.ServerPath + @"\Servers\" + DataContainer.FolderName1 + @"\Rocket\Libraries";
            if (DataContainer.ModInstallFirst1 == false)
            {
                // Ignore. Install Already Complete.
            }
            else if (DataContainer.ModInstallFirst1 == true)
            {
                try
                {
                    Directory.CreateDirectory(@"Temp");
                    using (var client = new WebClient())
                    {
                        client.DownloadFile("https://dl.dropboxusercontent.com/s/15zhjfvm3wufiv4/Unturned_Rocket_Libraries.zip?dl=0", @"Temp\Libraries.zip");
                    }
                }
                catch (WebException)
                {
                    MessageBox.Show("Something went wrong on the installation for the libraries that all plugins use. Please retry again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (File.Exists(@"Temp\Libraries.zip") == true)
                {
                    string Library1 = @"" + destination2 + @"\EngineIoClientDotNet.dll";
                    string Library2 = @"" + destination2 + @"\GeoIP.dat";
                    string Library3 = @"" + destination2 + @"\I18N.dll";
                    string Library4 = @"" + destination2 + @"\I18N.West.dll";
                    string Library5 = @"" + destination2 + @"\MySql.Data.dll";
                    string Library6 = @"" + destination2 + @"\Newtonsoft.Json.dll";
                    string Library7 = @"" + destination2 + @"\ObservatoryLibrary.dll";
                    string Library8 = @"" + destination2 + @"\SocketIoClientDotNet.dll";
                    string Library9 = @"" + destination2 + @"\System.Data.dll";
                    string Library10 = @"" + destination2 + @"\System.Management.dll";
                    string Library11 = @"" + destination2 + @"\System.Threading.Tasks.NET35.dll";
                    string Library12 = @"" + destination2 + @"\System.Transactions.dll";
                    string Library13 = @"" + destination2 + @"\WebSocket4Net.dll";
                    if (File.Exists(Library1) == true)
                    {
                        File.Delete(Library1);
                    }
                    if (File.Exists(Library2) == true)
                    {
                        File.Delete(Library2);
                    }
                    if (File.Exists(Library3) == true)
                    {
                        File.Delete(Library3);
                    }
                    if (File.Exists(Library4) == true)
                    {
                        File.Delete(Library4);
                    }
                    if (File.Exists(Library5) == true)
                    {
                        File.Delete(Library5);
                    }
                    if (File.Exists(Library6) == true)
                    {
                        File.Delete(Library6);
                    }
                    if (File.Exists(Library7) == true)
                    {
                        File.Delete(Library7);
                    }
                    if (File.Exists(Library8) == true)
                    {
                        File.Delete(Library8);
                    }
                    if (File.Exists(Library9) == true)
                    {
                        File.Delete(Library9);
                    }
                    if (File.Exists(Library10) == true)
                    {
                        File.Delete(Library10);
                    }
                    if (File.Exists(Library11) == true)
                    {
                        File.Delete(Library11);
                    }
                    if (File.Exists(Library12) == true)
                    {
                        File.Delete(Library12);
                    }
                    if (File.Exists(Library13) == true)
                    {
                        File.Delete(Library13);
                    }
                    if (File.Exists(Library1) == false && File.Exists(Library2) == false && File.Exists(Library3) == false && File.Exists(Library4) == false && File.Exists(Library5) == false && File.Exists(Library6) == false && File.Exists(Library7) == false && File.Exists(Library8) == false && File.Exists(Library9) == false && File.Exists(Library10) == false && File.Exists(Library11) == false && File.Exists(Library12) == false && File.Exists(Library13) == false)
                    {
                        try
                        {
                            ZipFile.ExtractToDirectory(@"Temp\Libraries.zip", destination2 + @"\");
                        }
                        catch (InvalidDataException)
                        {
                            MessageBox.Show("Something went wrong on the installation for the libraries that all plugins use. Please retry again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        if (File.Exists(Library1) == true && File.Exists(Library2) == true && File.Exists(Library3) == true && File.Exists(Library4) == true && File.Exists(Library5) == true && File.Exists(Library6) == true && File.Exists(Library7) == true && File.Exists(Library8) == true && File.Exists(Library9) == true && File.Exists(Library10) == true && File.Exists(Library11) == true && File.Exists(Library12) == true && File.Exists(Library13) == true)
                        {
                            MessageBox.Show("Installation of the libraries was successful. This is a 1 time only operation.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            File.Delete(@"Temp\Libraries.zip");
                            Directory.Delete(@"Temp");
                            DataContainer.ModInstallFirst1 = false;
                        }
                        else
                        {
                            MessageBox.Show("Something went wrong on the installation for the libraries that all plugins use. Please retry again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Something went wrong on the installation for the libraries that all plugins use. Please retry again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Directory.Delete("Temp");
                }
            }
        }

        private void LoadAvailablePlugins()
        {
            PublicPlugins = new List<string>
            {
                "Anti-CombatLog",
                "Auto Shutdown 2",
                "Admin Help",
                "Airdrop Manager",
                "Back in Black",
                "Car Kick",
                "Chat Control",
                "Death Manager",
                "Duty",
                "Easy Ammo",
                "Free Fall",
                "Feex Ranks",
                "Feex Hitman",
                "Feex Limiter",
                "Feex Geo(graphic) Block",
                "Feex Exp",
                "Feex Afk",
                "Global Ban",
                "Is Abusing",
                "Item Restrictions",
                "Jail Time",
                "Join/Leave Messages",
                "Kill",
                "Kepp Inventory",
                "Kits",
                "Light Permissions",
                "Message Of The Day (MOTD)",
                "Message Announcer",
                "MOTDgd - Advertisements",
                "Observatory",
                "Private Messages",
                "Regions",
                "Reputation",
                "Reserved Slots",
                "Spy All",
                "Splash Backup",
                "Stat Keeper",
                "Ticks Per Second Cap",
                "TPA",
                "UEssentials",
                "UConomy",
                "Vehicle Events",
                "Wrecking Ball",
                "Warps",
                "Zaup Home",
                "Zaup Feast",
                "Zaup Clear Inventory",
                "Zaup Uconomy Essentials",
                "Zaup Shop"
            };
        }

        private void DisplayAvailablePlugins()
        {
            int Length = PublicPlugins.Count;
            for (int i = 0; i <= Length -1; i++)
            {
                Plugins.Items.Add(PublicPlugins[i]);
            }
        }

        private void LoadInstalledPlugins()
        {
            try
            {
                string destination = DataContainer.ServerPath + @"\Servers\" + DataContainer.FolderName1 + @"\Rocket\Plugins";
                string pathtoremove = DataContainer.ServerPath + @"\Servers\" + DataContainer.FolderName1 + @"\Rocket\Plugins\";
                string[] Files = Directory.GetFiles(destination);
                string[] FilesTrim = new string[Files.Length];
                for (int i = 0; i <= Files.Length - 1; i++)
                {
                    FilesTrim[i] = Files[i].Replace(pathtoremove, "");
                    ChangeFromNormalToCustom(FilesTrim[i]);
                }
            }
            catch(DirectoryNotFoundException)
            {
                AlreadyInstalled.Items.Clear();
                //Ignore, Nothing Exists.
            }
        }

        private void ChangeFromNormalToCustom(string Plugin)
        {
            if (Plugin == "AntiCombatLog.dll")
            {
                Plugin = "Anti-CombatLog";
                AlreadyInstalled.Items.Add(Plugin);
            }
            else if (Plugin == "AutoShutdown2 - 0.6.1.dll")
            {
                Plugin = "Auto Shutdown 2";
                AlreadyInstalled.Items.Add(Plugin);
            }
            else if (Plugin == "AdminHelp.dll")
            {
                Plugin = "Admin Help";
                AlreadyInstalled.Items.Add(Plugin);
            }
            else if (Plugin == "AirdropManager.dll")
            {
                Plugin = "Airdrop Manager";
                AlreadyInstalled.Items.Add(Plugin);
            }
            else if (Plugin == "BackInBlack2.dll")
            {
                Plugin = "Back in Black";
                AlreadyInstalled.Items.Add(Plugin);
            }
            else if (Plugin == "carkick.dll")
            {
                Plugin = "Car Kick";
                AlreadyInstalled.Items.Add(Plugin);
            }
            else if (Plugin == "ChatControl.dll")
            {
                Plugin = "Chat Control";
                AlreadyInstalled.Items.Add(Plugin);
            }
            else if (Plugin == "DeathManager.dll")
            {
                Plugin = "Death Manager";
                AlreadyInstalled.Items.Add(Plugin);
            }
            else if (Plugin == "Duty.dll")
            {
                Plugin = "Duty";
                AlreadyInstalled.Items.Add(Plugin);
            }
            else if (Plugin == "EasyAmmo.dll")
            {
                Plugin = "Easy Ammo";
                AlreadyInstalled.Items.Add(Plugin);
            }
            else if (Plugin == "freefall.dll")
            {
                Plugin = "Free Fall";
                AlreadyInstalled.Items.Add(Plugin);
            }
            else if (Plugin == "FeexRanks.dll")
            {
                Plugin = "Feex Ranks";
                AlreadyInstalled.Items.Add(Plugin);
            }
            else if (Plugin == "FeexHitman.dll")
            {
                Plugin = "Feex Hitman";
                AlreadyInstalled.Items.Add(Plugin);
            }
            else if (Plugin == "FeexLimiter.dll")
            {
                Plugin = "Feex Limiter";
                AlreadyInstalled.Items.Add(Plugin);
            }
            else if (Plugin == "FeexGeoBlock.dll")
            {
                Plugin = "Feex Geo(graphic) Block";
                AlreadyInstalled.Items.Add(Plugin);
            }
            else if (Plugin == "FeexExp.dll")
            {
                Plugin = "Feex Exp";
                AlreadyInstalled.Items.Add(Plugin);
            }
            else if (Plugin == "FeexAFK.dll")
            {
                Plugin = "Feex Afk";
                AlreadyInstalled.Items.Add(Plugin);
            }
            else if (Plugin == "GlobalBan.dll")
            {
                Plugin = "Global Ban";
                AlreadyInstalled.Items.Add(Plugin);
            }
            else if (Plugin == "IsAbusing.dll")
            {
                Plugin = "Is Abusing";
                AlreadyInstalled.Items.Add(Plugin);
            }
            else if (Plugin == "RocketMod_ItemRestrictions.dll")
            {
                Plugin = "Item Restrictions";
                AlreadyInstalled.Items.Add(Plugin);
            }
            else if (Plugin == "JailTimeFree.dll")
            {
                Plugin = "Jail Time";
                AlreadyInstalled.Items.Add(Plugin);
            }
            else if (Plugin == "JoinLeaveMessages.dll")
            {
                Plugin = "Join/Leave Messages";
                AlreadyInstalled.Items.Add(Plugin);
            }
            else if (Plugin == "Kill.dll")
            {
                Plugin = "Kill";
                AlreadyInstalled.Items.Add(Plugin);
            }
            else if (Plugin == "")
            {
                Plugin = "Keep Inventory";
                AlreadyInstalled.Items.Add(Plugin);
            }
            else if (Plugin == "Kits.dll")
            {
                Plugin = "Kits";
                AlreadyInstalled.Items.Add(Plugin);
            }
            else if (Plugin == "LPX.dll")
            {
                Plugin = "Light Permissions";
                AlreadyInstalled.Items.Add(Plugin);
            }
            else if (Plugin == "MOTD.dll")
            {
                Plugin = "Message Of The Day (MOTD)";
                AlreadyInstalled.Items.Add(Plugin);
            }
            else if (Plugin == "MessageAnnouncer.dll")
            {
                Plugin = "Message Announcer";
                AlreadyInstalled.Items.Add(Plugin);
            }
            else if (Plugin == "")
            {
                Plugin = "MOTDgd - Advertisements";
                AlreadyInstalled.Items.Add(Plugin);
            }
            else if (Plugin == "")
            {
                Plugin = "Observatory";
                AlreadyInstalled.Items.Add(Plugin);
            }
            else if (Plugin == "PrivateMessage.dll")
            {
                Plugin = "Private Messages";
                AlreadyInstalled.Items.Add(Plugin);
            }
            else if (Plugin == "RocketRegions.dll")
            {
                Plugin = "Regions";
                AlreadyInstalled.Items.Add(Plugin);
            }
            else if (Plugin == "Reputation.dll")
            {
                Plugin = "Reputation";
                AlreadyInstalled.Items.Add(Plugin);
            }
            else if (Plugin == "")
            {
                Plugin = "Reserved Slots";
                AlreadyInstalled.Items.Add(Plugin);
            }
            else if (Plugin == "SpyAll.dll")
            {
                Plugin = "Spy All";
                AlreadyInstalled.Items.Add(Plugin);
            }
            else if (Plugin == "SplashBackup.dll")
            {
                Plugin = "Splash Backup";
                AlreadyInstalled.Items.Add(Plugin);
            }
            else if (Plugin == "StatKeeper.dll")
            {
                Plugin = "Stat Keeper";
                AlreadyInstalled.Items.Add(Plugin);
            }
            else if (Plugin == "")
            {
                Plugin = "Ticks Per Second Cap";
                AlreadyInstalled.Items.Add(Plugin);
            }
            else if (Plugin == "RocketMod_TPA.dll")
            {
                Plugin = "TPA";
                AlreadyInstalled.Items.Add(Plugin);
            }
            else if (Plugin == "")
            {
                Plugin = "UEssentials";
                AlreadyInstalled.Items.Add(Plugin);
            }
            else if (Plugin == "Uconomy.dll")
            {
                Plugin = "UConomy";
                AlreadyInstalled.Items.Add(Plugin);
            }
            else if (Plugin == "VehicleEvents.dll")
            {
                Plugin = "Vehicle Events";
                AlreadyInstalled.Items.Add(Plugin);
            }
            else if (Plugin == "WreckingBall.dll")
            {
                Plugin = "Wrecking Ball";
                AlreadyInstalled.Items.Add(Plugin);
            }
            else if (Plugin == "Warps.dll")
            {
                Plugin = "Warps";
                AlreadyInstalled.Items.Add(Plugin);
            }
            else if (Plugin == "ZaupHomeCommand.dll")
            {
                Plugin = "Zaup Home";
                AlreadyInstalled.Items.Add(Plugin);
            }
            else if (Plugin == "ZaupFeast.dll")
            {
                Plugin = "Zaup Feast";
                AlreadyInstalled.Items.Add(Plugin);
            }
            else if (Plugin == "ZaupClearInventoryLib.dll")
            {
                Plugin = "Zaup Clear Inventory";
                AlreadyInstalled.Items.Add(Plugin);
            }
            else if (Plugin == "ZaupUconomyEssentials.dll")
            {
                Plugin = "Zaup Uconomy Essentials";
                AlreadyInstalled.Items.Add(Plugin);
            }
            else if (Plugin == "ZaupShop.dll")
            {
                Plugin = "Zaup Shop";
                AlreadyInstalled.Items.Add(Plugin);
            }
            else
            {
                // Ignore. Unwanted entry or unknown plugin
            }
        }

        private void RefreshOptions()
        {
            AlreadyInstalled.Items.Clear();
            LoadInstalledPlugins();
        }

        private void CleanUp(string TempDirectory, string PluginDirectory)
        {
            DeleteDirectory(TempDirectory);
            try
            {
                File.Move(PluginDirectory + @"\LPX\LPX.dll", PluginDirectory);
            }
            catch(IOException)
            {
                //Ignore, file doesnt exist.
            }
            try
            {
                File.Move(PluginDirectory + @"\Plugins\MOTDgd.dll", PluginDirectory);
            }
            catch(IOException)
            {
                //Ignore, file doesnt exist.
            }
            try
            {
                File.Move(PluginDirectory + @"\Plugins\Observatory.dll", PluginDirectory);
            }
            catch (IOException)
            {
                //Ignore, file doesnt exist.
            }
            try
            {
                File.Move(PluginDirectory + @"\Plugins\uEssentials.dll", PluginDirectory);
            }
            catch (IOException)
            {
                //Ignore, file doesnt exist.
            }
            Directory.CreateDirectory(PluginDirectory + @"\MOTDgd");
            try
            {
                File.Move(PluginDirectory + @"\Plugins\MOTDgd\MOTDgd.configuration.xml", PluginDirectory + @"\MOTDgd");
            }
            catch (IOException)
            {
                //Ignore, file doesnt exist.
            }
            try
            {
                File.Move(PluginDirectory + @"\Plugins\MOTDgd\MOTDgd.en.translation.xml", PluginDirectory + @"\MOTDgd");
            }
            catch (IOException)
            {
                //Ignore, file doesnt exist.
            }
            try
            {
                File.Delete(PluginDirectory + @"\CHANGELOG.txt");
            }
            catch (IOException)
            {
                //Ignore, file doesnt exist.
            }
            try
            {
                File.Delete(PluginDirectory + @"\LICENSE");
            }
            catch (IOException)
            {
                //Ignore, file doesnt exist.
            }
            try
            {
                File.Delete(PluginDirectory + @"README.md");
            }
            catch (IOException)
            {
                //Ignore, file doesnt exist.
            }
            try
            {
                File.Delete(PluginDirectory + @"README.txt");
            }
            catch (IOException)
            {
                //Ignore, file doesnt exist.
            }
            DeleteDirectory(PluginDirectory + @"\Plugins");
            DeleteDirectory(PluginDirectory + @"\LPX");
        }

        private void DownloadPlugin(string Plugin)
        {
            try
            {
                if (Plugin == "Anti-CombatLog")
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile(AntiCombatLogDownload, @"Temp\AntiCombat.zip");
                    }
                }
                else if (Plugin == "Auto Shutdown 2")
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile(AutoShutdownDownload, @"Temp\AutoShutdown.zip");
                    }
                }
                else if (Plugin == "Admin Help")
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile(AdminHelpDownload, @"Temp\AdminHelp.zip");
                    }
                }
                else if (Plugin == "Airdrop Manager")
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile(AirdropManagerDownload, @"Temp\Airdrops.zip");
                    }
                }
                else if (Plugin == "Back in Black")
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile(BackinBlackDownload, @"Temp\BackinBlack.zip");
                    }
                }
                else if (Plugin == "Car Kick")
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile(CarKickDownload, @"Temp\CarKick.zip");
                    }
                }
                else if (Plugin == "Chat Control")
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile(ChatControlDownload, @"Temp\CC.zip");
                    }
                }
                else if (Plugin == "Death Manager")
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile(DeathManagerDownload, @"Temp\DeathManager.zip");
                    }
                }
                else if (Plugin == "Duty")
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile(DutyDownload, @"Temp\Duty.zip");
                    }
                }
                else if (Plugin == "Easy Ammo")
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile(EasyAmmoDownload, @"Temp\EzAmmo.zip");
                    }
                }
                else if (Plugin == "Free Fall")
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile(FreeFallDownload, @"Temp\Fall.zip");
                    }
                }
                else if (Plugin == "Feex Ranks")
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile(FeexRanksDownload, @"Temp\FeexRanks.zip");
                    }
                }
                else if (Plugin == "Feex Hitman")
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile(FeexHitmanDownload, @"Temp\FeexHitman.zip");
                    }
                }
                else if (Plugin == "Feex Limiter")
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile(FeexLimiterDownload, @"Temp\FeexLimiter.zip");
                    }
                }
                else if (Plugin == "Feex Geo(graphic) Block")
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile(FeexGeoBlockDownload, @"Temp\FeexGeoBlock.zip");
                    }
                }
                else if (Plugin == "Feex Exp")
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile(FeexExpDownload, @"Temp\FeexExp.zip");
                    }
                }
                else if (Plugin == "Feex Afk")
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile(FeexAfkDownload, @"Temp\FeexAfk.zip");
                    }
                }
                else if (Plugin == "Global Ban")
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile(GlobalBanDownload, @"Temp\GlobalBan.zip");
                    }
                }
                else if (Plugin == "Is Abusing")
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile(IsAbusingDownload, @"Temp\IsAbusing.zip");
                    }
                }
                else if (Plugin == "Item Restrictions")
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile(ItemRestrictionsDownload, @"Temp\ItemRest.zip");
                    }
                }
                else if (Plugin == "Jail Time")
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile(JailTimeDownload, @"Temp\JailTime.zip");
                    }
                }
                else if (Plugin == "Join/Leave Messages")
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile(JoinLeaveMessagesDownload, @"Temp\JoinLeave.zip");
                    }
                }
                else if (Plugin == "Kill")
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile(KillDownload, @"Temp\Kill.zip");
                    }
                }
                else if (Plugin == "Keep Inventory")
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile(KeepInventoryDownload, @"Temp\KeepInventory.zip");
                    }
                }
                else if (Plugin == "Kits")
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile(KitsDownload, @"Temp\Kits.zip");
                    }
                }
                else if (Plugin == "Light Permissions")
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile(LPXDownload, @"Temp\LPX.zip");
                    }
                }
                else if (Plugin == "Message Of The Day (MOTD)")
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile(MOTDDownload, @"Temp\MOTD.zip");
                    }
                }
                else if (Plugin == "Message Announcer")
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile(AnnouncerDownload, @"Temp\Announcer.zip");
                    }
                }
                else if (Plugin == "MOTDgd - Advertisements")
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile(MOTDgdDownload, @"Temp\MOTDgd.zip");
                    }
                }
                else if (Plugin == "Observatory")
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile(ObservatoryDownload, @"Temp\Observatory.zip");
                    }
                }
                else if (Plugin == "Private Messages")
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile(PMDownload, @"Temp\PM.zip");
                    }
                }
                else if (Plugin == "Regions")
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile(RegionsDownload, @"Temp\Regions.zip");
                    }
                }
                else if (Plugin == "Reputation")
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile(ReputationDownload, @"Temp\Rep.zip");
                    }
                }
                else if (Plugin == "Reserverd Slots")
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile(ReservedSlotsDownload, @"Temp\ReservedSlots.zip");
                    }
                }
                else if (Plugin == "Spy All")
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile(SpyAllDownload, @"Temp\SpyAll.zip");
                    }
                }
                else if (Plugin == "Splash Backup")
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile(BackupDownload, @"Temp\Backup.zip");
                    }
                }
                else if (Plugin == "Stat Keeper")
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile(StatsDownload, @"Temp\Stats.zip");
                    }
                }
                else if (Plugin == "Ticks Per Second Cap")
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile(TPSDownload, @"Temp\TPS.zip");
                    }
                }
                else if (Plugin == "TPA")
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile(TPADownload, @"Temp\TPA.zip");
                    }
                }
                else if (Plugin == "UEssentials")
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile(UessentialsDownload, @"Temp\UEssentials.zip");
                    }
                }
                else if (Plugin == "UConomy")
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile(UconomyDownload, @"Temp\UConomy.zip");
                    }
                }
                else if (Plugin == "Vehicle Events")
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile(VehicleEventsDownload, @"Temp\VehicleEvents.zip");
                    }
                }
                else if (Plugin == "Wrecking Ball")
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile(WreckingBallDownload, @"Temp\WreckingBall.zip");
                    }
                }
                else if (Plugin == "Warps")
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile(WarpsDownload, @"Temp\Warps.zip");
                    }
                }
                else if (Plugin == "Zaup Home")
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile(ZaupHomeDownload, @"Temp\ZHome.zip");
                    }
                }
                else if (Plugin == "Zaup Feast")
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile(ZaupFeastDownload, @"Temp\ZFeast.zip");
                    }
                }
                else if (Plugin == "Zaup Clear Inventory")
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile(ZaupClearInvDownload, @"Temp\ZClearInv.zip");
                    }
                }
                else if (Plugin == "Zaup Uconomy Essentials")
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile(ZaupUconomyDownload, @"Temp\ZUconomyEss.zip");
                    }
                }
                else if (Plugin == "Zaup Shop")
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile(ZaupShopDownload, @"Temp\ZShop.zip");
                    }
                }
            }
            catch(WebException)
            {
                MessageBox.Show("Error occured during download of the plugin " + Plugin + ". Please manually download them from http://dev.rocketmod.net", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                Error = true;
            }
        }

        private void ClearCloneLibFolder(string Destination)
        {
            Destination = "" + Destination + @"\Libraries";
            if (!Directory.Exists(Destination))
            {
                // Ignore, doesn't exist
            }
            else
            {
                DeleteDirectory(Destination);
            }
        }

        private void ExtractPlugin(string Plugin)
        {
            string destination = DataContainer.ServerPath + @"\Servers\" + DataContainer.FolderName1 + @"\Rocket\Plugins";
            try
            {
                if (Plugin == "Anti-CombatLog")
                {
                    ZipFile.ExtractToDirectory(@"Temp\AntiCombat.zip", destination);
                    ClearCloneLibFolder(destination);
                }
                else if (Plugin == "Auto Shutdown 2")
                {
                    ZipFile.ExtractToDirectory(@"Temp\AutoShutdown.zip", destination);
                    ClearCloneLibFolder(destination);
                }
                else if (Plugin == "Admin Help")
                {
                    ZipFile.ExtractToDirectory(@"Temp\AdminHelp.zip", destination);
                    ClearCloneLibFolder(destination);
                }
                else if (Plugin == "Airdrop Manager")
                {
                    ZipFile.ExtractToDirectory(@"Temp\Airdrops.zip", destination);
                    ClearCloneLibFolder(destination);
                }
                else if (Plugin == "Back in Black")
                {
                    ZipFile.ExtractToDirectory(@"Temp\BackinBlack.zip", destination);
                    ClearCloneLibFolder(destination);
                }
                else if (Plugin == "Car Kick")
                {
                    ZipFile.ExtractToDirectory(@"Temp\CarKick.zip", destination);
                    ClearCloneLibFolder(destination);
                }
                else if (Plugin == "Chat Control")
                {
                    ZipFile.ExtractToDirectory(@"Temp\CC.zip", destination);
                    ClearCloneLibFolder(destination);
                }
                else if (Plugin == "Death Manager")
                {
                    ZipFile.ExtractToDirectory(@"Temp\DeathManager.zip", destination);
                    ClearCloneLibFolder(destination);
                }
                else if (Plugin == "Duty")
                {
                    ZipFile.ExtractToDirectory(@"Temp\Duty.zip", destination);
                    ClearCloneLibFolder(destination);
                }
                else if (Plugin == "Easy Ammo")
                {
                    ZipFile.ExtractToDirectory(@"Temp\EzAmmo.zip", destination);
                    ClearCloneLibFolder(destination);
                }
                else if (Plugin == "Free Fall")
                {
                    ZipFile.ExtractToDirectory(@"Temp\Fall.zip", destination);
                    ClearCloneLibFolder(destination);
                }
                else if (Plugin == "Feex Ranks")
                {
                    ZipFile.ExtractToDirectory(@"Temp\FeexRanks.zip", destination);
                    ClearCloneLibFolder(destination);
                }
                else if (Plugin == "Feex Hitman")
                {
                    ZipFile.ExtractToDirectory(@"Temp\FeexHitman.zip", destination);
                    ClearCloneLibFolder(destination);
                }
                else if (Plugin == "Feex Limiter")
                {
                    ZipFile.ExtractToDirectory(@"Temp\FeexLimiter.zip", destination);
                    ClearCloneLibFolder(destination);
                }
                else if (Plugin == "Feex Geo(graphic) Block")
                {
                    ZipFile.ExtractToDirectory(@"Temp\FeexGeoBlock.zip", destination);
                    ClearCloneLibFolder(destination);
                }
                else if (Plugin == "Feex Exp")
                {
                    ZipFile.ExtractToDirectory(@"Temp\FeexExp.zip", destination);
                    ClearCloneLibFolder(destination);
                }
                else if (Plugin == "Feex Afk")
                {
                    ZipFile.ExtractToDirectory(@"Temp\FeexAfk.zip", destination);
                    ClearCloneLibFolder(destination);
                }
                else if (Plugin == "Global Ban")
                {
                    ZipFile.ExtractToDirectory(@"Temp\GlobalBan.zip", destination);
                    ClearCloneLibFolder(destination);
                }
                else if (Plugin == "Is Abusing")
                {
                    ZipFile.ExtractToDirectory(@"Temp\IsAbusing.zip", destination);
                    ClearCloneLibFolder(destination);
                }
                else if (Plugin == "Item Restrictions")
                {
                    ZipFile.ExtractToDirectory(@"Temp\ItemRest.zip", destination);
                    ClearCloneLibFolder(destination);
                }
                else if (Plugin == "Jail Time")
                {
                    ZipFile.ExtractToDirectory(@"Temp\JailTime.zip", destination);
                    ClearCloneLibFolder(destination);
                }
                else if (Plugin == "Join/Leave Messages")
                {
                    ZipFile.ExtractToDirectory(@"Temp\JoinLeave.zip", destination);
                    ClearCloneLibFolder(destination);
                }
                else if (Plugin == "Kill")
                {
                    ZipFile.ExtractToDirectory(@"Temp\Kill.zip", destination);
                    ClearCloneLibFolder(destination);
                }
                else if (Plugin == "Keep Inventory")
                {
                    ZipFile.ExtractToDirectory(@"Temp\KeepInventory.zip", destination);
                    ClearCloneLibFolder(destination);
                }
                else if (Plugin == "Kits")
                {
                    ZipFile.ExtractToDirectory(@"Temp\Kits.zip", destination);
                    ClearCloneLibFolder(destination);
                }
                else if (Plugin == "Light Permissions")
                {
                    ZipFile.ExtractToDirectory(@"Temp\LPX.zip", destination);
                    ClearCloneLibFolder(destination);
                }
                else if (Plugin == "Message Of The Day (MOTD)")
                {
                    ZipFile.ExtractToDirectory(@"Temp\MOTD.zip", destination);
                    ClearCloneLibFolder(destination);
                }
                else if (Plugin == "Message Announcer")
                {
                    ZipFile.ExtractToDirectory(@"Temp\Announcer.zip", destination);
                    ClearCloneLibFolder(destination);
                }
                else if (Plugin == "MOTDgd - Advertisements")
                {
                    ZipFile.ExtractToDirectory(@"Temp\MOTDgd.zip", destination);
                    ClearCloneLibFolder(destination);
                }
                else if (Plugin == "Observatory")
                {
                    ZipFile.ExtractToDirectory(@"Temp\Observatory.zip", destination);
                    ClearCloneLibFolder(destination);
                }
                else if (Plugin == "Private Messages")
                {
                    ZipFile.ExtractToDirectory(@"Temp\PM.zip", destination);
                    ClearCloneLibFolder(destination);
                }
                else if (Plugin == "Regions")
                {
                    ZipFile.ExtractToDirectory(@"Temp\Regions.zip", destination);
                    ClearCloneLibFolder(destination);
                }
                else if (Plugin == "Reputation")
                {
                    ZipFile.ExtractToDirectory(@"Temp\Rep.zip", destination);
                    ClearCloneLibFolder(destination);
                }
                else if (Plugin == "Reserverd Slots")
                {
                    ZipFile.ExtractToDirectory(@"Temp\ReservedSlots.zip", destination);
                    ClearCloneLibFolder(destination);
                }
                else if (Plugin == "Spy All")
                {
                    ZipFile.ExtractToDirectory(@"Temp\SpyAll.zip", destination);
                    ClearCloneLibFolder(destination);
                }
                else if (Plugin == "Splash Backup")
                {
                    ZipFile.ExtractToDirectory(@"Temp\Backup.zip", destination);
                    ClearCloneLibFolder(destination);
                }
                else if (Plugin == "Stat Keeper")
                {
                    ZipFile.ExtractToDirectory(@"Temp\Stats.zip", destination);
                    ClearCloneLibFolder(destination);
                }
                else if (Plugin == "Ticks Per Second Cap")
                {
                    ZipFile.ExtractToDirectory(@"Temp\TPS.zip", destination);
                    ClearCloneLibFolder(destination);
                }
                else if (Plugin == "TPA")
                {
                    ZipFile.ExtractToDirectory(@"Temp\TPA.zip", destination);
                    ClearCloneLibFolder(destination);
                }
                else if (Plugin == "UEssentials")
                {
                    ZipFile.ExtractToDirectory(@"Temp\UEssentials.zip", destination);
                    ClearCloneLibFolder(destination);
                }
                else if (Plugin == "UConomy")
                {
                    ZipFile.ExtractToDirectory(@"Temp\UConomy.zip", destination);
                    ClearCloneLibFolder(destination);
                }
                else if (Plugin == "Vehicle Events")
                {
                    ZipFile.ExtractToDirectory(@"Temp\VehicleEvents.zip", destination);
                    ClearCloneLibFolder(destination);
                }
                else if (Plugin == "Wrecking Ball")
                {
                    ZipFile.ExtractToDirectory(@"Temp\WreckingBall.zip", destination);
                    ClearCloneLibFolder(destination);
                }
                else if (Plugin == "Warps")
                {
                    ZipFile.ExtractToDirectory(@"Temp\Warps.zip", destination);
                    ClearCloneLibFolder(destination);
                }
                else if (Plugin == "Zaup Home")
                {
                    ZipFile.ExtractToDirectory(@"Temp\ZHome.zip", destination);
                    ClearCloneLibFolder(destination);
                }
                else if (Plugin == "Zaup Feast")
                {
                    ZipFile.ExtractToDirectory(@"Temp\ZFeast.zip", destination);
                    ClearCloneLibFolder(destination);
                }
                else if (Plugin == "Zaup Clear Inventory")
                {
                    ZipFile.ExtractToDirectory(@"Temp\ZClearInv.zip", destination);
                    ClearCloneLibFolder(destination);
                }
                else if (Plugin == "Zaup Uconomy Essentials")
                {
                    ZipFile.ExtractToDirectory(@"Temp\ZUconomyEss.zip", destination);
                    ClearCloneLibFolder(destination);
                }
                else if (Plugin == "Zaup Shop")
                {
                    ZipFile.ExtractToDirectory(@"Temp\ZShop.zip", destination);
                    ClearCloneLibFolder(destination);
                }
            }
            catch(InvalidDataException)
            {
                MessageBox.Show("Unknown Error Happened In The Download Of " + Plugin + ". Please Manually Download And Install The Plugin.");
            }
        }

        private void DeletePlugin(string Source, string Plugin)
        {
            string temppath = Path.Combine(Source, Plugin);
            File.Delete(temppath);
        }

        private void DeleteDirectory(string Destination)
        {
            DirectoryInfo dir = new DirectoryInfo(Destination);
            DirectoryInfo[] dirs = dir.GetDirectories();
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                if (file.Name != file.Name)
                {
                    // Ignore, doesnt exist
                }
                else
                {
                    string temppath = Path.Combine(Destination, file.Name);
                    File.Delete(temppath);
                }
            }
            foreach (DirectoryInfo subdir in dirs)
            {
                string temppath = Path.Combine(Destination, subdir.Name);
                DeleteDirectory(subdir.FullName);
            }
            if (Directory.Exists(Destination))
            {
                Directory.Delete(Destination);
            }
        }

        private void Uninstall_Click(object sender, EventArgs e)
        {
            int Length = AlreadyInstalled.CheckedItems.Count;
            if (Length == 0)
            {
                MessageBox.Show("No plugins selected to remove.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Length > 0)
            {
                for (int i = 0; i <= Length - 1; i++)
                {
                    DeletePlugin(@"" + DataContainer.ServerPath + @"\Servers\" + DataContainer.FolderName1 + @"\Rocket\Plugins\", Convert.ToString(AlreadyInstalled.CheckedItems[i]));
                }
                RefreshOptions();
            }
        }

        private void SaveAndExit_Click(object sender, EventArgs e)
        {
            string[] SelectedItems = new string[Plugins.CheckedItems.Count];
            string destination = DataContainer.ServerPath + @"\Servers\" + DataContainer.FolderName1 + @"\Rocket\Plugins";
            MessageBox.Show(destination);
            if (SelectedItems.Length == 0)
            {
                Close();
            }
            else if (SelectedItems.Length > 0)
            {
                MessageBox.Show("Please do not touch any keys during download process. Selecting all plugins takes up to 1 minute in normal internet speed to download.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Directory.CreateDirectory(@"Temp");
                for (int i = 0; i <= Plugins.CheckedIndices.Count - 1; i++)
                {
                    SelectedItems[i] = Convert.ToString(Plugins.CheckedItems[i]);
                    DownloadPlugin(SelectedItems[i]);
                    if (Error == true)
                    {
                        // Ignore, error occured
                    }
                    else if (Error == false)
                    {
                        ExtractPlugin(SelectedItems[i]);
                    }
                }
                if (Error == true)
                {
                    Close();
                }
                else if (Error == false)
                {
                    CleanUp(@"Temp", destination);
                    Close();
                }
            }
        }

        private void SelectAll_Click(object sender, EventArgs e)
        {
            if (Plugins.CheckedItems.Count > 0)
            {
                for (int i = 0; i <= Plugins.Items.Count - 1; i++)
                {
                    Plugins.SetItemChecked(i, false);
                }
            }
            else if (Plugins.CheckedItems.Count == 0)
            {
                for (int i = 0; i <= Plugins.Items.Count - 1; i++)
                {
                    Plugins.SetItemChecked(i, true);
                }
            }
        }

        private void SelectAll2_Click(object sender, EventArgs e)
        {
            if (AlreadyInstalled.CheckedItems.Count > 0)
            {
                for (int i = 0; i <= AlreadyInstalled.Items.Count - 1; i++)
                {
                    AlreadyInstalled.SetItemChecked(i, false);
                }
            }
            else if (AlreadyInstalled.CheckedItems.Count == 0)
            {
                for (int i = 0; i <= AlreadyInstalled.Items.Count - 1; i++)
                {
                    AlreadyInstalled.SetItemChecked(i, true);
                }
            }
        }
    }
}
