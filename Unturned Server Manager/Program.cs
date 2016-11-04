using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unturned_Server_Manager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                using (var client = new WebClient())
                {
                    client.DownloadFile("https://github.com/persiafighter/UnturnedServerManager/raw/master/VLatest.dat", @"VLatest.dat");
                }
            }
            catch(WebException)
            {
                // Ignore, not implemented
            }
            if (File.Exists(@"VLatest.dat") == true)
            {
                string[] lines = File.ReadAllLines(@"VLatest.dat");
                if (lines[0] == "2.0.1.0")
                {
                    StartApp();
                }
                else if (lines[0] != "2.0.1.0")
                {
                    MessageBox.Show("Program is not using latest version/build, please go to https://github.com/persiafighter/UnturnedServerManager to download latest build.", "Update Needed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
            }
            else if (File.Exists(@"VLatest.dat") == false)
            {
                MessageBox.Show("Error when checking latest version, launching app normally.", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                StartApp();
            }
        }
        private static void StartApp()
        {
            try
            {
                Application.Run(new Manager());
            }
            catch (Exception e)
            {
                MessageBox.Show("Critical Internal Exception Was Thrown. Rebooting App.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                File.WriteAllText(@"C:\Unturned_Manager\Error_Dump.txt", Convert.ToString(e));
                StartApp();
            }
        }
    }
}
