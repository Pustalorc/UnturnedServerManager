using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unturned_Server_Manager1
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
            string appGuid = "2d1dcd0a-9719-44f5-8f0e-2fd79d918fb5";
            using (Mutex mutex = new Mutex(false, "Global\\" + appGuid))
            {
                if (!mutex.WaitOne(0, false))
                {
                    MessageBox.Show("Another instance of unturned server manager is already running!", "Unturned Server Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            Application.Run(Form1Control.Application);
        }
    }
}
