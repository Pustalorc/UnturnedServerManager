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
            bool RunSucc = Running.Run(ID, Name, Batch, VAC, Graphics, Path);
            if (ShutSucc == true && RunSucc == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
