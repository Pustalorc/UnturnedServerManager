using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USM
{
    static class Logger
    {
        public static void CreateLogFile()
        {
            File.Create(Comms.DataPath + "Log.txt").Close();
        }

        public static void Log(string Message)
        {
            File.AppendAllText(Comms.DataPath + "Log.txt", Message);
        }

        public static void DeleteLogFile()
        {
            File.Delete(Comms.DataPath + "Log.txt");
        }
    }
}
