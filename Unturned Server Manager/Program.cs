using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            StartApp();
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
