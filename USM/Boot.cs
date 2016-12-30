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
            StartApp();
        }
        private static void StartApp()
        {
            if (File.Exists(Comms.DataPath + "USM.lock") == false)
            {
                try
                {
                    File.Create(Comms.DataPath + "USM.lock").Close();
                }
                catch(DirectoryNotFoundException)
                {
                    Directory.CreateDirectory(Comms.DataPath);
                    File.Create(Comms.DataPath + "USM.lock").Close();
                }
                File.SetAttributes(Comms.DataPath + "USM.lock", FileAttributes.Hidden);
                try
                {
                    Application.Run(new Manager());
                    File.Delete(Comms.DataPath + "USM.lock");
                }
                catch (Exception e)
                {
                    MessageBox.Show("An Internal Exception Was Thrown. Rebooting Application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    File.WriteAllText(Comms.DataPath + "Error.txt", Convert.ToString(e));
                    File.Delete(Comms.DataPath + "USM.lock");
                    MessageBox.Show("Please send an issue report in our github page, with the details of what happened and the error file located at \"C:\\Unturned_Manager\\Error.txt\", then we can fix the error as soon as possible.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    StartApp();
                }
            }
            else if (File.Exists(Comms.DataPath + "USM.lock") == true)
            {
                MessageBox.Show("Cannot Run Unturned Server Manager, Another Instance Is Already Running!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }
    }
}
