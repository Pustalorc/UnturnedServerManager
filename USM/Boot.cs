using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
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
            new TickTimer().Show();
            if (Directory.Exists(Comms.DataPath) == false)
            {
                Directory.CreateDirectory(Comms.DataPath);
            }
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
                Logger.Log("Started main application.");
                Application.Run(new Manager());
                Logger.Log("Main application was closed.");
            }
            catch (Exception e)
            {
                MessageBox.Show("An Internal Exception Was Thrown. Rebooting Application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                File.WriteAllText(Path.GetFullPath(Comms.DataPath + @"\Error.txt"), e.ToString());
                Logger.Log("Created error file.");
                MessageBox.Show("Please send an issue report in our github page, with the details of what happened and the error file located at \"C:\\Unturned_Manager\\Error.txt\", then we can fix the error as soon as possible.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Logger.Log("Restarted program.");
                StartApp();
            }
        }
    }

    public class TickTimer : Form
    {
        public System.ComponentModel.IContainer components;
        public System.Windows.Forms.Timer Timer;
        public static decimal ProgramTime = 0.00M;
        public TickTimer()
        {
            Opacity = 0;
            ShowInTaskbar = false;
            ShowIcon = false;
            Hide();
            components = new System.ComponentModel.Container();
            Timer = new System.Windows.Forms.Timer();
            Timer.Interval = 10;
            Timer.Tick += new EventHandler(Timer_tick);
            Timer.Start();
        }

        private void Timer_tick(object Sender, EventArgs e)
        {
            ProgramTime += 0.01M;
        }

        protected override void Dispose(bool disposing)
        {
            // Clean up any components being used.
            if (disposing)
                if (components != null)
                    components.Dispose();

            base.Dispose(disposing);
        }
    }
}
