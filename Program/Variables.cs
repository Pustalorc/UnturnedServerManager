using System;
using System.IO;

namespace USM
{
    class Variables
    {
        public static bool AServerIsRunning = false;
        public static int[] PID = new int[100];
        public static string[] StoredName = new string[100];
        public static int[] RunningID = new int[100];
        public static string DataPath = Path.GetFullPath(Path.GetPathRoot(Environment.SystemDirectory) + @"\Unturned_Manager");
        public static string UnturnedPath = Path.GetFullPath(DataPath + @"\Server");
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
        public static short Red = 230;
        public static short Green = 230;
        public static short Blue = 230;
        public static int UpdateAll = 0;
        public static int UpdateRocket = 0;
        public static int UpdateUnturned = 0;
        public static int UpdatePI = 0;

        public void VariableDefaults()
        {
            Logger.Log("Setting all variables to default.", "Variables");
            AServerIsRunning = false;
            PID = new int[100];
            StoredName = new string[100];
            RunningID = new int[100];
            DataPath = Path.GetFullPath(Path.GetPathRoot(Environment.SystemDirectory) + @"\Unturned_Manager");
            UnturnedPath = Path.GetFullPath(DataPath + @"\Server");
            LocalName = null;
            VAC = true;
            Console = true;
            Graphics = true;
            PublicName = "Test Server";
            Port = 27015;
            PVP = true;
            Perspective = "Both";
            MaxPlayers = 24;
            Map = "Washington";
            Difficulty = "Normal";
            GoldMode = false;
            Cheats = false;
            Password = null;
            QueueSize = 8;
            Owner = 0;
            LoginMessage = null;
            Sync = false;
            Loadout = null;
            HideAdmins = false;
            IP = "0.0.0.0";
            Filter = false;
            Cycle = 43200;
            ChatRate = 0;
            Red = 255;
            Green = 16;
            Blue = 16;
            UpdateAll = 0;
            UpdateRocket = 0;
            UpdateUnturned = 0;
            UpdatePI = 0;
        }

        public void SerConfigDefault()
        {
            Logger.Log("Setting server configuration variables to default.", "Variables");
            PublicName = "Test Server";
            Port = 27015;
            PVP = true;
            Perspective = "Both";
            MaxPlayers = 24;
            Map = "Washington";
            Difficulty = "Normal";
            GoldMode = false;
            Cheats = false;
            Password = null;
            QueueSize = 8;
            Owner = 0;
            LoginMessage = null;
            Sync = false;
            Loadout = null;
            HideAdmins = false;
            IP = "0.0.0.0";
            Filter = false;
            Cycle = 43200;
            ChatRate = 0;
        }
    }
}
