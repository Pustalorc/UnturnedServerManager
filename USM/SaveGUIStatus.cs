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
    static class SaveGUIStatus
    {
        public static int MaxSerS;
        public static string CurrDirS;

        public static void SaveGUI(int MaxSer, string CurrDir)
        {
            List<string> GUI = new List<string>
            {
                Convert.ToString(MaxSer),
                CurrDir
            };
            try
            {
                File.WriteAllLines(@"C:\Unturned_Manager\GUI.dat", GUI);
            }
            catch (DirectoryNotFoundException)
            {
                Directory.CreateDirectory(@"C:\Unturned_Manager");
                File.WriteAllLines(@"C:\Unturned_Manager\GUI.dat", GUI);
            }
        }

        public static void LoadGUI()
        {
            try
            {
                string[] SaveFile = File.ReadAllLines(@"C:\Unturned_Manager\GUI.dat");
                MaxSerS = Convert.ToInt32(SaveFile[0]);
                CurrDirS = SaveFile[1];
            }
            catch (Exception e)
            {
                MessageBox.Show("The local save data for the GUI seems corrupt. Please delete GUI.dat file and try again.");
            }
        }
    }
}
