using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USM
{
    static class Running
    {
        public static bool Run(int ID, string Name, bool Batch, bool VAC, bool Graphics, string Path)
        {
            string Arguments = "";
            bool Success = true;
            if (Name == "")
            {
                MessageBox.Show("Error: no server name inserted for server with id " + ID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Name != "")
            {
                for (int i = 0; i < 99; i++)
                {
                    if (Comms.StoredName[i] == Name)
                    {
                        MessageBox.Show("Server name is the same as another servers name with ID " + (i + 1));
                        Success = false;
                        break;
                    }
                }
                if (Success == true)
                {
                    if (Batch == true)
                    {
                        Arguments = Arguments + " -batchmode";
                    }
                    else if (Batch == false)
                    {
                        Arguments = Arguments + "";
                    }
                    if (Graphics == true)
                    {
                        Arguments = Arguments + " -nographics";
                    }
                    else if (Graphics == false)
                    {
                        Arguments = Arguments + "";
                    }
                    if (VAC == true)
                    {
                        Arguments = Arguments + " +secureserver";
                    }
                    else if (VAC == false)
                    {
                        Arguments = Arguments + " +insecureserver";
                    }
                    var ServerID = new Process();
                    ServerID.StartInfo.FileName = @"" + Path + "\\Unturned.exe";
                    ServerID.StartInfo.Arguments = @"" + Arguments + "/" + Name + "";
                    ServerID.StartInfo.WorkingDirectory = @"" + Path + "";
                    ServerID.Start();
                    Comms.PID[ID - 1] = ServerID.Id;
                    Comms.StoredName[ID - 1] = Name;
                    Comms.RunningID[ID - 1] = ID;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Unknown error whilst starting server.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
