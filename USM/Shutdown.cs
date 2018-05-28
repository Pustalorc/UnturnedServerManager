#pragma warning disable CS0168
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USM
{
    static class ShutdownS
    {
        public static bool ShutdownSer(int ID, string Name)
        {
            if (Comms.StoredName[ID - 1] == Name)
            {
                Comms.StoredName[ID - 1] = null;
                try
                {
                    Process.GetProcessById(Comms.PID[ID - 1]).Kill();
                }
                catch (Exception e)
                {
                    // Ignore, Server already offline.
                }
                Comms.PID[ID - 1] = 0;
                Comms.RunningID[ID - 1] = 0;
                return true;
            }
            else
            {
                try
                {
                    Process.GetProcessById(Comms.PID[ID - 1]).Kill();
                    return true;
                }
                catch (Exception e)
                {
                    // Server already offline, delete data from storage
                    Comms.PID[ID - 1] = 0;
                    Comms.RunningID[ID - 1] = 0;
                    Comms.StoredName[ID - 1] = null;
                    return false;
                }
            }
        }
    }
}