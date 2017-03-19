using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
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
            if (!Directory.Exists(Variables.DataPath))
            {
                Directory.CreateDirectory(Variables.DataPath);
            }
            new ApplicationTimer();
            Logger.Log("Created log file.", "Boot");
            StartApp();
        }

        private static void StartApp()
        {
            string appGuid = "2d1dcd0a-9719-44f5-8f0e-2fd79d918fb5";
            try
            {
                using (Mutex mutex = new Mutex(false, "Global\\" + appGuid))
                {
                    if (!mutex.WaitOne(0, false))
                    {
                        MessageBox.Show("Another instance of unturned server manager is already running!", "Unturned Server Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                Logger.Log("Started main application.", "Boot");
                Application.Run(new Manager());
                Logger.Log("Main application was closed.", "Boot");
            }
            catch (Exception e)
            {
                MessageBox.Show("An Internal Exception Was Thrown. Rebooting Application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                File.WriteAllText(Path.GetFullPath(Variables.DataPath + @"\Error.txt"), Convert.ToString(e));
                Logger.Log("Created error file.", "Boot");
                MessageBox.Show("Please send an issue report in our github page, with the details of what happened and the error file located at \"C:\\Unturned_Manager\\Error.txt\", then we can fix the error as soon as possible.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Logger.Log("Restarted program.", "Boot");
                StartApp();
            }
        }
    }
}
