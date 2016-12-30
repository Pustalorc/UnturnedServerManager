#pragma warning disable CS0168
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USM
{
    static class Comms
    {
        public static int[] PID = new int[100];
        public static string[] StoredName = new string[100];
        public static int[] RunningID = new int[100];
        public static string DataPath = @"C:\Unturned_Manager\";
        public static string UnturnedPath;
        public static string LocalName = null;
        public static bool VAC = true;
        public static bool Console = true;
        public static bool Graphics = true;
        public static string PublicName = "Test Server";
        public static int Port = 27015;
        public static bool PVP = true;
        public static string Perspective = "Both";
        public static int MaxPlayers = 24;
        public static string Map = "Washington";
        public static string Difficulty = "Normal";
        public static bool GoldMode = false;
        public static bool Cheats = false;
        public static string Password = null;
        public static int QueueSize = 8;
        public static long Owner = 0;
        public static string LoginMessage = null;
        public static bool Sync = false;
        public static string Loadout = null;
        public static bool HideAdmins = false;
        public static string IP = "0.0.0.0";
        public static bool Filter = false;
        public static int Cycle = 43200;
        public static int ChatRate = 0;
        public static bool ConfigExists = false;
        private static bool NoErrors = true;
        private static string FinMap;
        private static string FinPubName;
        private static string FinIP;
        private static string FinDiff;
        private static string FinLoadout;
        private static string FinPass;
        private static string FinLogMes;
        private static string FinMaxPlayers;
        private static string FinChatRate;
        private static string FinCheat;
        private static string FinCycle;
        private static string FinFilter;
        private static string FinPerspective;
        private static string FinHideAd;
        private static string FinOwner;
        private static string FinPort;
        private static string FinPvP;
        private static string FinQue;
        private static string FinSync;
        private static string FinGold;

        public static void SaveServerConfig(int id)
        {
            List<string> ServConfig = new List<string>
            {
                LocalName,
                Convert.ToString(VAC),
                Convert.ToString(Console),
                Convert.ToString(Graphics),
                PublicName,
                Convert.ToString(Port),
                Convert.ToString(PVP),
                Perspective,
                Convert.ToString(MaxPlayers),
                Map,
                Difficulty,
                Convert.ToString(GoldMode),
                Convert.ToString(Cheats),
                Password,
                Convert.ToString(QueueSize),
                Convert.ToString(Owner),
                LoginMessage,
                Convert.ToString(Sync),
                Loadout,
                Convert.ToString(HideAdmins),
                IP,
                Convert.ToString(Filter),
                Convert.ToString(Cycle),
                Convert.ToString(ChatRate)
            };
            try
            {
                File.WriteAllLines(@"C:\Unturned_Manager\Server_ID_" + id + "_Config.dat", ServConfig);
            }
            catch (DirectoryNotFoundException)
            {
                Directory.CreateDirectory(@"C:\Unturned_Manager");
                File.WriteAllLines(@"C:\Unturned_Manager\Server_ID_" + id + "_Config.dat", ServConfig);
            }
        }

        public static void LoadServerConfig(int id)
        {
            try
            {
                string[] SaveFile = File.ReadAllLines(@"C:\Unturned_Manager\Server_ID_" + id + "_Config.dat");
                LocalName = SaveFile[0];
                VAC = Convert.ToBoolean(SaveFile[1]);
                Console = Convert.ToBoolean(SaveFile[2]);
                Graphics = Convert.ToBoolean(SaveFile[3]);
                PublicName = SaveFile[4];
                Port = Convert.ToInt32(SaveFile[5]);
                PVP = Convert.ToBoolean(SaveFile[6]);
                Perspective = SaveFile[7];
                MaxPlayers = Convert.ToInt32(SaveFile[8]);
                Map = SaveFile[9];
                Difficulty = SaveFile[10];
                GoldMode = Convert.ToBoolean(SaveFile[11]);
                Cheats = Convert.ToBoolean(SaveFile[12]);
                Password = SaveFile[13];
                QueueSize = Convert.ToInt32(SaveFile[14]);
                Owner = Convert.ToInt64(SaveFile[15]);
                LoginMessage = SaveFile[16];
                Sync = Convert.ToBoolean(SaveFile[17]);
                Loadout = SaveFile[18];
                HideAdmins = Convert.ToBoolean(SaveFile[19]);
                IP = SaveFile[20];
                Filter = Convert.ToBoolean(SaveFile[21]);
                Cycle = Convert.ToInt32(SaveFile[22]);
                ChatRate = Convert.ToInt32(SaveFile[23]);
            }
            catch (Exception e)
            {
                MessageBox.Show("The save file for server with ID " + id + " seems to be corrupt. Please delete the save file and create the values again.");
            }
        }

        public static bool CreateServerConfig(string LocalFoldNam, string Path)
        {
            FinMap = Map;
            FinPubName = PublicName;
            FinIP = IP;
            FinDiff = Difficulty;
            FinLoadout = Loadout;
            FinPass = Password;
            FinLogMes = LoginMessage;
            try
            {
                FinMaxPlayers = Convert.ToString(MaxPlayers);
                FinChatRate = Convert.ToString(ChatRate);
                FinCheat = Convert.ToString(Cheats);
                FinCycle = Convert.ToString(Cycle);
                FinFilter = Convert.ToString(Filter);
                FinPerspective = Convert.ToString(Perspective);
                FinHideAd = Convert.ToString(HideAdmins);
                FinOwner = Convert.ToString(Owner);
                FinPort = Convert.ToString(Port);
                FinPvP = Convert.ToString(PVP);
                FinQue = Convert.ToString(QueueSize);
                FinSync = Convert.ToString(Sync);
                FinGold = Convert.ToString(GoldMode);
                NoErrors = true;
            }
            catch (FormatException)
            {
                NoErrors = false;
            }
            if (NoErrors == false)
            {
                return false;
            }
            else if (NoErrors == true)
            {
                try
                {
                    if (FinCheat == "True")
                    {
                        FinCheat = "Cheats";
                    }
                    else if (FinCheat == "False")
                    {
                        FinCheat = "";
                    }
                    if (FinFilter == "True")
                    {
                        FinFilter = "Filter";
                    }
                    else if (FinFilter == "False")
                    {
                        FinFilter = "";
                    }
                    if (FinPerspective == "True")
                    {
                        FinPerspective = "First";
                    }
                    else if (FinPerspective == "False")
                    {
                        FinPerspective = "Both";
                    }
                    if (FinHideAd == "True")
                    {
                        FinHideAd = "hide_admins";
                    }
                    else if (FinHideAd == "False")
                    {
                        FinHideAd = "";
                    }
                    if (FinPvP == "True")
                    {
                        FinPvP = "";
                    }
                    else if (FinPvP == "False")
                    {
                        FinPvP = "PvE";
                    }
                    if (FinSync == "True")
                    {
                        FinSync = "Sync";
                    }
                    else if (FinSync == "False")
                    {
                        FinSync = "";
                    }
                    if (FinGold == "True")
                    {
                        FinGold = "gold";
                    }
                    else if (FinGold == "False")
                    {
                        FinGold = "";
                    }
                    if (NoErrors == true)
                    {
                        List<string> Config = new List<string>
                    {
                        "Map " + FinMap,
                        "MaxPlayers " + FinMaxPlayers,
                        "ChatRate " + FinChatRate,
                        FinCheat,
                        "Cycle " + FinCycle,
                        FinFilter,
                        "Perspective " + FinPerspective,
                        FinHideAd,
                        "Owner " + FinOwner,
                        "Port " + FinPort,
                        FinPvP,
                        "Queue_Size " + FinQue,
                        FinSync,
                        "Name " + FinPubName,
                        "Bind " + FinIP,
                        "Mode " + FinDiff,
                        "Loadout 255/" + FinLoadout,
                        "Password " + FinPass,
                        "Welcome " + FinLogMes,
                        FinGold
                    };
                        try
                        {
                            File.WriteAllLines(Path + "\\Servers\\" + LocalFoldNam + "\\Server\\Commands.dat", Config);
                            return true;
                        }
                        catch (DirectoryNotFoundException)
                        {
                            Directory.CreateDirectory(Path + "\\Servers\\" + LocalFoldNam + "\\Server");
                            File.WriteAllLines(Path + "\\Servers\\" + LocalFoldNam + "\\Server\\Commands.dat", Config);
                            return true;
                        }
                    }
                }
                catch(Exception)
                {
                    return false;
                }
            }
            return false;
        }
    }
}
