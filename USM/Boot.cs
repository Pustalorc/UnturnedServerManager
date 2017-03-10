using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
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
            new TickTimer();
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
            string appGuid = ((GuidAttribute)Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(GuidAttribute), false).GetValue(0)).Value.ToString();
            string mutexId = string.Format("Global\\{{{0}}}", appGuid);
            var allowEveryoneRule = new MutexAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), MutexRights.FullControl, AccessControlType.Allow);
            var securitySettings = new MutexSecurity();
            securitySettings.AddAccessRule(allowEveryoneRule);
            try
            {
                bool createdNew;
                using (var mutex = new Mutex(false, mutexId, out createdNew, securitySettings))
                {
                    var hasHandle = false;
                    try
                    {
                        try
                        {
                            hasHandle = mutex.WaitOne(0, false);
                            if (hasHandle == false)
                            {
                                MessageBox.Show("Another instance of unturned server manager is already running!", "Unturned Server Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                        }
                        catch (AbandonedMutexException)
                        {
                            hasHandle = true;
                        }
                        Logger.Log("Started main application.");
                        Application.Run(new Manager());
                        Logger.Log("Main application was closed.");
                    }
                    finally
                    {
                        if (hasHandle)
                        {
                            mutex.ReleaseMutex();
                        }
                    }
                }
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

    public class TickTimer
    {
        public System.Windows.Forms.Timer Timer;
        public static decimal ProgramTime = 0.00M;
        public TickTimer()
        {
            Timer = new System.Windows.Forms.Timer();
            Timer.Interval = 10;
            Timer.Tick += new EventHandler(Timer_tick);
            Timer.Start();
            Logger.Log("Started timer to keep the program time.");
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
            {
                return;
            }
            Timer.Dispose();
            disposed = true;
        }

        private void Timer_tick(object Sender, EventArgs e)
        {
            ProgramTime += 0.01M;
        }
    }
}
