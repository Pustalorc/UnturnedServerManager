using ATORTTeam.UnturnedServerManager.Configuration;
using ATORTTeam.UnturnedServerManager.GUI;
using ATORTTeam.UnturnedServerManager.Loading;
using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;

namespace ATORTTeam.UnturnedServerManager
{
    /// <summary>
    /// Entry point for UnturnedServerManager.
    /// </summary>
    public sealed class Entry
    {
        /// <summary>
        /// Entry point.
        /// </summary>
        /// <param name="args">Arguments supplied by console or startup options.</param>
        [STAThread]
        public static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            // Prevent crashing because of potato mistakes.
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            if (IsSecondInstance)
                return;

            if (!Installation.Exists())
                Application.Run(new FirstStart());

            Servers.Load();

            Application.Run(new Manager());
        }

        /// <summary>
        /// Verifies if another instance of USM is running. Returns false if there isn't, true if there is.
        /// </summary>
        private static bool IsSecondInstance
        {
            get
            {
                string appGuid = ((GuidAttribute)Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(GuidAttribute), false).GetValue(0)).Value.ToString();
                string mutexId = string.Format("Global\\{{{0}}}", appGuid);
                var allowEveryoneRule = new MutexAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), MutexRights.FullControl, AccessControlType.Allow);
                var securitySettings = new MutexSecurity();
                securitySettings.AddAccessRule(allowEveryoneRule);

                using (var mutex = new Mutex(false, mutexId, out bool createdNew, securitySettings))
                {
                    var hasHandle = false;
                    try
                    {
                        try
                        {
                            hasHandle = mutex.WaitOne(0, false);
                            if (hasHandle == false)
                                return true;
                        }
                        catch (AbandonedMutexException)
                        {
                            hasHandle = true;
                        }

                        return false;
                    }
                    finally
                    {
                        if (hasHandle)
                            mutex.ReleaseMutex();
                    }
                }
            }
        }
    }
}
