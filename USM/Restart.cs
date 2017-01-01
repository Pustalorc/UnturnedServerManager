using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USM
{
    static class Reboot
    {
        public static bool RebootSer(int ID, string Name, bool Batch, bool VAC, bool Graphics, string Path)
        {
            bool ShutSucc = ShutdownS.ShutdownSer(ID, Name);
            if (ShutSucc == true)
            {
                return true;
            }
            else if (ShutSucc == false)
            {
                Logger.Log("An error was encountered when shutting the server off.");
                return false;
            }
            bool RunSucc = Running.Run(ID, Name, Batch, VAC, Graphics, Path);
            if (RunSucc == true)
            {
                return true;
            }
            else
            {
                Logger.Log("An error was encountered when turning the server back on.");
                return false;
            }
        }
    }
}
