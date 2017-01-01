using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USM
{
    class Boot
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (File.Exists(Comms.DataPath + "Logger.log") == true)
            {
                Logger.DeleteLogFile();
            }
            Logger.CreateLogFile();
            Logger.Log("Created log file.");
            StartApp();
        }
        private static void StartApp()
        {
            if (File.Exists(Comms.DataPath + "USM.lock") == false)
            {
                try
                {
                    File.Create(Comms.DataPath + "USM.lock").Close();
                    Logger.Log("Created lock file.");
                }
                catch(DirectoryNotFoundException)
                {
                    Directory.CreateDirectory(Comms.DataPath);
                    Logger.Log("Created data directory.");
                    File.Create(Comms.DataPath + "USM.lock").Close();
                    Logger.Log("Created lock file.");
                }
                File.SetAttributes(Comms.DataPath + "USM.lock", FileAttributes.Hidden);
                Logger.Log("Hidden lock file.");
                try
                {
                    Logger.Log("Started main application.");
                    Application.Run(new Manager());
                    File.Delete(Comms.DataPath + "USM.lock");
                    Logger.Log("Deleted lock file.");
                }
                catch (Exception e)
                {
                    MessageBox.Show("An Internal Exception Was Thrown. Rebooting Application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    File.WriteAllText(Comms.DataPath + "Error.txt", Convert.ToString(e));
                    Logger.Log("Created error file.");
                    File.Delete(Comms.DataPath + "USM.lock");
                    Logger.Log("Deleted lock file.");
                    MessageBox.Show("Please send an issue report in our github page, with the details of what happened and the error file located at \"C:\\Unturned_Manager\\Error.txt\", then we can fix the error as soon as possible.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Logger.Log("Restarted program.");
                    StartApp();
                }
            }
            else if (File.Exists(Comms.DataPath + "USM.lock") == true)
            {
                Logger.Log("Lock file was found again.");
                MessageBox.Show("Cannot Run Unturned Server Manager, Another Instance Is Already Running!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Logger.Log("Exited program.");
                Application.Exit();
            }
        }
    }
}
