using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unturned_Server_Manager
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            if (DataContainer.SavedState4 == true)
            {
                LoadSave();
            }
        }

        private void SaveVariables()
        {
            // Activate Past Saved State

            DataContainer.SavedState4 = true;

            // Server Name

            if (NameSel.Text == "")
            {
                DataContainer.NameSer4 = "Server";
            }
            else
            {
                DataContainer.NameSer4 = NameSel.Text;
            }

            // Server Port

            if (PortSel.Text == "")
            {
                DataContainer.Port4 = 27015;
            }
            else
            {
                try
                {
                    DataContainer.Port4 = Convert.ToInt32(PortSel.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("ERROR: PORT IS NOT A NUMBER! SETTING VALUE TO DEFAULT 27015", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataContainer.Port4 = 27015;
                }
            }

            // PvP or PvE

            if (PvPValue.Text == "On")
            {
                DataContainer.PVPSer4 = true;
            }
            else if (PvPValue.Text == "Off")
            {
                DataContainer.PVPSer4 = false;
            }

            // First person only or Both

            if (FirstPerson.Text == "First Person Only")
            {
                DataContainer.FiPerOnly4 = true;
            }
            else if (FirstPerson.Text == "Both")
            {
                DataContainer.FiPerOnly4 = false;
            }

            // Max Players

            if (MaxPlayersVal1.Checked == true)
            {
                DataContainer.MaxPlayers4 = 8;
            }
            else if (MaxPlayersVal2.Checked == true)
            {
                DataContainer.MaxPlayers4 = 16;
            }
            else if (MaxPlayersVal3.Checked == true)
            {
                DataContainer.MaxPlayers4 = 24;
            }
            else if (MaxPlayersVal4.Checked == true)
            {
                try
                {
                    DataContainer.MaxPlayers4 = Convert.ToInt32(MaxPlayersCustom.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("ERROR: MAX PLAYERS IS NOT A NUMBER! SETTING VALUE TO DEFAULT 24", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataContainer.MaxPlayers4 = 24;
                }
            }

            // Map

            if (MapSel.Text == "")
            {
                DataContainer.MapSer4 = "Washington";
            }
            else
            {
                DataContainer.MapSer4 = MapSel.Text;
            }

            // Difficulty

            if (DiffSel.Text == "Easy")
            {
                DataContainer.DiffSer4 = "Easy";
            }
            else if (DiffSel.Text == "Normal")
            {
                DataContainer.DiffSer4 = "Normal";
            }
            else if (DiffSel.Text == "Hard")
            {
                DataContainer.DiffSer4 = "Hard";
            }
            else if (DiffSel.Text == "Gold")
            {
                DataContainer.DiffSer4 = "Gold";
            }

            // Cheats

            if (CheatsSel.Text == "Off")
            {
                DataContainer.CheatSer4 = false;
            }
            else if (CheatsSel.Text == "On")
            {
                DataContainer.CheatSer4 = true;
            }

            // Password

            if (PasswordSel.Text != "")
            {
                DataContainer.PassSer4 = PasswordSel.Text;
            }
            else
            {
                DataContainer.PassSer4 = "";
            }

            // Queue

            if (QueueSize1.Checked == true)
            {
                DataContainer.QueueSer4 = 8;
            }
            else if (QueueSize2.Checked == true)
            {
                DataContainer.QueueSer4 = 16;
            }
            else if (QueueSize3.Checked == true)
            {
                DataContainer.QueueSer4 = 24;
            }
            else if (QueueSize4.Checked == true)
            {
                try
                {
                    DataContainer.QueueSer4 = Convert.ToInt32(QueueSizeCustom.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("ERROR: QUEUE SIZE IS NOT A NUMBER! SETTING VALUE TO DEFAULT 8", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataContainer.QueueSer4 = 8;
                }
            }

            // Owner
            
            if (OwnerSel.Text == "")
            {
                DataContainer.OwnerSer4 = 0;
            }
            else
            {
                try
                {
                    DataContainer.OwnerSer4 = Convert.ToInt32(OwnerSel.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("ERROR: OWNER IS NOT IN STEAM64ID FORMAT (NUMBER)! SETTING VALUE TO 0", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataContainer.OwnerSer4 = 0;
                }
            }

            // Welcome Message

            if (MessageSel.Text == "")
            {
                DataContainer.WelcomeSer4 = "";
            }
            else
            {
                DataContainer.WelcomeSer4 = MessageSel.Text;
            }

            // Sync
            
            if (SyncSel.Text == "Off")
            {
                DataContainer.SyncSer4 = false;
            }
            else if (SyncSel.Text == "On")
            {
                DataContainer.SyncSer4 = true;
            }

            // Loadout

            if (LoadoutSel.Text == "")
            {
                DataContainer.LoadoutSer4 = "";
            }
            else
            {
                DataContainer.LoadoutSer4 = LoadoutSel.Text;
            }

            // Hide Admins

            if (HideSel.Text == "False")
            {
                DataContainer.HideAdminSer4 = false;
            }
            else if (HideSel.Text == "True")
            {
                DataContainer.HideAdminSer4 = true;
            }

            // Bind to IP

            if (IPSel.Text == "")
            {
                DataContainer.BindSer4 = "0.0.0.0";
            }
            else if (IPSel.Text == "0.0.0.0")
            {
                DataContainer.BindSer4 = "0.0.0.0";
            }
            else
            {
                DataContainer.BindSer4 = IPSel.Text;
            }

            // Filter

            if (FilterSel.Text == "On")
            {
                DataContainer.FilterSer4 = true;
            }
            else if (FilterSel.Text == "Off")
            {
                DataContainer.FilterSer4 = false;
            }

            // Cycle
            
            if (Cycle1.Checked == true)
            {
                DataContainer.CycleSer4 = 43200;
            }
            else if (Cycle2.Checked == true)
            {
                try
                {
                    DataContainer.CycleSer4 = Convert.ToInt32(CycleCustom.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("ERROR: CYCLE IS NOT A NUMBER! SETTING VALUE TO 43200", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataContainer.CycleSer4 = 43200;
                }
            }

            // Chat Rate

            if (Rate1.Checked == true)
            {
                DataContainer.ChatSer4 = 0;
            }
            else if (Rate2.Checked == true)
            {
                try
                {
                    DataContainer.ChatSer4 = Convert.ToInt32(RateCustom.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("ERROR: CHAT RATE IS NOT A NUMBER! SETTING VALUE TO 0", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataContainer.CycleSer4 = 0;
                }
            }

        }

        private void LoadSave()
        {
            // Server Name

            NameSel.Text = DataContainer.NameSer4;

            // Server Port

            PortSel.Text = Convert.ToString(DataContainer.Port4);

            // PvP or PvE

            if (DataContainer.PVPSer4 == true)
            {
                PvPValue.Text = "On";
            }
            else if (DataContainer.PVPSer4 == false)
            {
                PvPValue.Text = "Off";
            }

            // First person only or Both

            if (DataContainer.FiPerOnly4 == true)
            {
                FirstPerson.Text = "First Person Only";
            }
            else if (DataContainer.FiPerOnly4 == false)
            {
                FirstPerson.Text = "Both";
            }

            // Max Players

            if (DataContainer.MaxPlayers4 == 8)
            {
                MaxPlayersVal1.Checked = true;
            }
            else if (DataContainer.MaxPlayers4 == 16)
            {
                MaxPlayersVal2.Checked = true;
            }
            else if (DataContainer.MaxPlayers4 == 24)
            {
                MaxPlayersVal3.Checked = true;
            }
            else if (DataContainer.MaxPlayers4 >=0)
            {
                MaxPlayersVal4.Checked = true;
                MaxPlayersCustom.Text = Convert.ToString(DataContainer.MaxPlayers4);
            }

            // Map

            MapSel.Text = DataContainer.MapSer4;

            // Difficulty

            if (DataContainer.DiffSer4 == "Easy")
            {
                DiffSel.Text = "Easy";
            }
            else if (DataContainer.DiffSer4 == "Normal")
            {
                DiffSel.Text = "Normal";
            }
            else if (DataContainer.DiffSer4 == "Hard")
            {
                DiffSel.Text = "Hard";
            }
            else if (DataContainer.DiffSer4 == "Gold")
            {
                DiffSel.Text = "Gold";
            }

            // Cheats

            if (DataContainer.CheatSer4 == false)
            {
                CheatsSel.Text = "Off";
            }
            else if (DataContainer.CheatSer4 == true)
            {
                CheatsSel.Text = "On";
            }

            // Password

            PasswordSel.Text = DataContainer.PassSer4;

            // Queue

            if (DataContainer.QueueSer4 == 8)
            {
                QueueSize1.Checked = true;
            }
            else if (DataContainer.QueueSer4 == 16)
            {
                QueueSize2.Checked = true;
            }
            else if (DataContainer.QueueSer4 == 24)
            {
                QueueSize3.Checked = true;
            }
            else if (DataContainer.QueueSer4 >= 0)
            {
                QueueSize4.Checked = true;
                QueueSizeCustom.Text = Convert.ToString(DataContainer.QueueSer4);
            }

            // Owner

            if (DataContainer.OwnerSer4 == 0)
            {
                OwnerSel.Text = "";
            }
            else
            {
                OwnerSel.Text = Convert.ToString(DataContainer.OwnerSer4);
            }

            // Welcome Message

            MessageSel.Text = DataContainer.WelcomeSer4;

            // Sync

            if (DataContainer.SyncSer4 == false)
            {
                SyncSel.Text = "Off";
            }
            else if (DataContainer.SyncSer4 == true)
            {
                SyncSel.Text = "On";
            }

            // Loadout

            LoadoutSel.Text = DataContainer.LoadoutSer4;

            // Hide Admins

            if (DataContainer.HideAdminSer4 == false)
            {
                HideSel.Text = "False";
            }
            else if (DataContainer.HideAdminSer4 == true)
            {
                HideSel.Text = "True";
            }

            // Bind to IP

            if (DataContainer.BindSer4 == "0.0.0.0")
            {
                IPSel.Text = "0.0.0.0";
            }
            else
            {
                IPSel.Text = DataContainer.BindSer4;
            }

            // Filter

            if (DataContainer.FilterSer4 == true)
            {
                FilterSel.Text = "On";
            }
            else if (DataContainer.FilterSer4 == false)
            {
                FilterSel.Text = "Off";
            }

            // Cycle

            if (DataContainer.CycleSer4 == 43200)
            {
                Cycle1.Checked = true;
            }
            else if (DataContainer.CycleSer4 <43200 && DataContainer.CycleSer4 >43200)
            {
                Cycle2.Checked = true;
                CycleCustom.Text = Convert.ToString(DataContainer.CycleSer4);
            }

            // Chat Rate

            if (DataContainer.ChatSer4 == 0)
            {
                Rate1.Checked = true;
            }
            else if (DataContainer.ChatSer4 > 0)
            {
                Rate2.Checked = true;
                RateCustom.Text = Convert.ToString(DataContainer.ChatSer4);
            }
        }

        private void CheckForCustom()
        {
            if (MaxPlayersVal1.Checked == true)
            {
                MaxPlayersCustom.ReadOnly = true;
            }
            else if (MaxPlayersVal2.Checked == true)
            {
                MaxPlayersCustom.ReadOnly = true;
            }
            else if (MaxPlayersVal3.Checked == true)
            {
                MaxPlayersCustom.ReadOnly = true;
            }
            else if (MaxPlayersVal4.Checked == true)
            {
                MaxPlayersCustom.ReadOnly = false;
            }
        }

        private void CheckForCustom2()
        {
            if (QueueSize1.Checked == true)
            {
                QueueSizeCustom.ReadOnly = true;
            }
            else if (QueueSize2.Checked == true)
            {
                QueueSizeCustom.ReadOnly = true;
            }
            else if (QueueSize3.Checked == true)
            {
                QueueSizeCustom.ReadOnly = true;
            }
            else if (QueueSize4.Checked == true)
            {
                QueueSizeCustom.ReadOnly = false;
            }
        }

        private void CheckForCustom3()
        {
            if (Cycle1.Checked == true)
            {
                CycleCustom.ReadOnly = true;
            }
            else if (Cycle2.Checked == true)
            {
                CycleCustom.ReadOnly = false;
            }
        }

        private void CheckForCustom4()
        {
            if (Rate1.Checked == true)
            {
                RateCustom.ReadOnly = true;
            }
            else if (Rate2.Checked == true)
            {
                RateCustom.ReadOnly = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveVariables();
            Close();
        }

        private void MaxPlayers4_CheckedChanged(object sender, EventArgs e)
        {
            CheckForCustom();
        }

        private void MaxPlayersVal3_CheckedChanged(object sender, EventArgs e)
        {
            CheckForCustom();
        }

        private void MaxPlayersVal1_CheckedChanged(object sender, EventArgs e)
        {
            CheckForCustom();
        }

        private void MaxPlayersVal2_CheckedChanged(object sender, EventArgs e)
        {
            CheckForCustom();
        }

        private void QueueSize1_CheckedChanged(object sender, EventArgs e)
        {
            CheckForCustom2();
        }

        private void QueueSize2_CheckedChanged(object sender, EventArgs e)
        {
            CheckForCustom2();
        }

        private void QueueSize3_CheckedChanged(object sender, EventArgs e)
        {
            CheckForCustom2();
        }

        private void QueueSize4_CheckedChanged(object sender, EventArgs e)
        {
            CheckForCustom2();
        }

        private void PvPValue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void PvPValue_DropDown(object sender, EventArgs e)
        {

        }

        private void FirstPerson_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FirstPerson_DropDown(object sender, EventArgs e)
        {

        }

        private void DiffSel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DiffSel_DropDown(object sender, EventArgs e)
        {

        }

        private void CheatsSel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CheatsSel_DropDown(object sender, EventArgs e)
        {

        }

        private void SyncSel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void HideSel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SyncSel_DropDown(object sender, EventArgs e)
        {

        }

        private void HideSel_DropDown(object sender, EventArgs e)
        {

        }

        private void Cycle1_CheckedChanged(object sender, EventArgs e)
        {
            CheckForCustom3();
        }

        private void Cycle2_CheckedChanged(object sender, EventArgs e)
        {
            CheckForCustom3();
        }

        private void Rate1_CheckedChanged(object sender, EventArgs e)
        {
            CheckForCustom4();
        }

        private void Rate2_CheckedChanged(object sender, EventArgs e)
        {
            CheckForCustom4();
        }

        private void FilterSel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FilterSel_DropDown(object sender, EventArgs e)
        {

        }
    }
}
