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
            string[] a = new string[] { "[" + TickTimer.ProgramTime + "s] - " + Message };
            File.AppendAllLines(Comms.DataPath + "Log.txt", a);
        }

        public static void DeleteLogFile()
        {
            File.Delete(Comms.DataPath + "Log.txt");
        }
    }
}
