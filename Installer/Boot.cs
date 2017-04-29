using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;

namespace Installer
{
    static class Boot
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string appGuid = ((GuidAttribute)Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(GuidAttribute), false).GetValue(0)).Value.ToString();
            string mutexId = string.Format("Global\\{{{0}}}", appGuid);
            var allowEveryoneRule = new MutexAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), MutexRights.FullControl, AccessControlType.Allow);
            var securitySettings = new MutexSecurity();
            securitySettings.AddAccessRule(allowEveryoneRule);
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
                            MessageBox.Show("Another instance of the installer is already running!", "Unturned Server Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    catch (AbandonedMutexException)
                    {
                        hasHandle = true;
                    }
                    Application.Run(new Main());
                    if (Var.lang == null)
                    {
                        return;
                    }
                    Application.Run(new InstallType());
                    if (Var.Type == 1)
                    {
                        Application.Run(new OneTime());
                    }
                    else if (Var.Type == 2)
                    {
                        //Application.Run(new Full());
                    }
                    else
                    {
                        Application.Exit();
                    }
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
    }
}
