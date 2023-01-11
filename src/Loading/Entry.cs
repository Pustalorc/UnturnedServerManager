using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;
using Pustalorc.Applications.USM.Configuration;
using Pustalorc.Applications.USM.GUI;

// ReSharper disable UnusedParameter.Global

namespace Pustalorc.Applications.USM.Loading
{
    /// <summary>
    ///     Entry point for UnturnedServerManager.
    /// </summary>
    internal static class Entry
    {
        /// <summary>
        ///     Verifies if another instance of USM is running. Returns false if there isn't, true if there is.
        /// </summary>
        private static bool IsSecondInstance
        {
            get
            {
                var appGuid = ((GuidAttribute) Assembly.GetExecutingAssembly()
                    .GetCustomAttributes(typeof(GuidAttribute), false).GetValue(0)).Value;
                var mutexId = $"Global\\{{{appGuid}}}";
                var allowEveryoneRule = new MutexAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null),
                    MutexRights.FullControl, AccessControlType.Allow);
                var securitySettings = new MutexSecurity();
                securitySettings.AddAccessRule(allowEveryoneRule);

                // ReSharper disable UnusedVariable
                using (var mutex = new Mutex(false, mutexId, out var createdNew, securitySettings))
                    // ReSharper restore UnusedVariable
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

        /// <summary>
        ///     Entry point.
        /// </summary>
        /// <param name="args">Arguments supplied by console or startup options.</param>
        [STAThread]
        public static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            if (IsSecondInstance)
                return;

            if (!Installation.Exists())
              //  Application.Run(new FirstStart());

            Servers.Load();

            Application.Run(new Manager());
        }
    }
}