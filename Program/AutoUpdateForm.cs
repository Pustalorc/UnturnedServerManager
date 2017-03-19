using System;
using System.Drawing;
using System.Windows.Forms;

namespace USM
{
    public partial class AutoUpdateForm : Form
    {
        public AutoUpdateForm()
        {
            InitializeComponent();
            BackColor = Color.FromArgb(Variables.Red, Variables.Green, Variables.Blue);
            Logger.Log("Loaded background color.", "Auto Update");
            Everything.Value = Variables.UpdateAll;
            Rocket.Value = Variables.UpdateRocket;
            Unturned.Value = Variables.UpdateUnturned;
            PI.Value = Variables.UpdatePI;
            Logger.Log("Loaded auto update values.", "Auto Update");
        }

        private void AutoUpdateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Variables.UpdateAll = Convert.ToInt32(Everything.Value);
            Variables.UpdateRocket = Convert.ToInt32(Rocket.Value);
            Variables.UpdateUnturned = Convert.ToInt32(Unturned.Value);
            Variables.UpdatePI = Convert.ToInt32(PI.Value);
            new AutoUpdateAllTimer();
            new AutoUpdateRocketTimer();
            new AutoUpdateUnturnedTimer();
            new AutoUpdatePluginIntegrityTimer();
            Logger.Log("Stored auto update values.", "Auto Update");
        }
    }
}
