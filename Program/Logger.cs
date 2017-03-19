using System.IO;

namespace USM
{
    class Logger
    {
        public static void Log(string Message, string Sector)
        {
            string[] a = new string[] { "[" + ApplicationTimer.ProgramTime + "s] (" + Sector + ") - " + Message };
            File.AppendAllLines(Path.GetFullPath(Variables.DataPath + @"\Log.txt"), a);
        }

        public static void Log(string Message)
        {
            string[] a = new string[] { "[" + ApplicationTimer.ProgramTime + "s] (Unknown) - " + Message };
            File.AppendAllLines(Path.GetFullPath(Variables.DataPath + @"\Log.txt"), a);
        }
    }
}
