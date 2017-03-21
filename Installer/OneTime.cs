using System.Windows.Forms;

namespace Installer
{
    public partial class OneTime : Form
    {
        public bool Increase;
        public int Stage
        {
            get { return Stage; }
            set
            {
                Stage = value;
                // If's will use stage + 1's value since the next value is set FIRST.
                if (Stage == 1)
                {
                    if (Increase)
                    {
                        if (Option2.Checked)
                        {
                            Var.SType = 1;
                        }
                        else if (Option1.Checked)
                        {
                            Var.SType = 2;
                        }
                    }
                }
            }
        }
        int IType = 0; // 1 is quick, 2 is advanced.
        //int Stage = 0; 0 is IType, 1 is Var.ServerDataLocation, 2 is Var.SType, 3 is Var.Strings 
        // 0 and 1, 4 is port, 5 is maxplayers, 6 is map, 7 is difficulty, 8 is password, 9 is login
        // Message, 10 is Cheats, 11 is perspective, 12 is queue size, 13 is Owner, 14 is bind ip, 15
        // is chat rate, 16 is cycle, 17 PVP, 18 Gold, 19 Loadout, 20 Hide admins

        public OneTime()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, System.EventArgs e)
        {
            if (Stage == 0)
            {
                Close();
            }
            else
            {
                Stage--;
            }
        }

        private void RServer_CheckedChanged(object sender, System.EventArgs e)
        {
            Next.Enabled = true;
        }

        private void VServer_CheckedChanged(object sender, System.EventArgs e)
        {
            Next.Enabled = true;
        }

        private void Next_Click(object sender, System.EventArgs e)
        {    
            Stage++;
        }
    }
}
