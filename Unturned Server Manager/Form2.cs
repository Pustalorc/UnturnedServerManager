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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            if (DataContainer.SavedState1 == true)
            {
                LoadSave();
            }
        }

        private void SaveVariables()
        {
            // Activate Past Saved State

            DataContainer.SavedState1 = true;

            // Server Name

            if (NameSel.Text == "")
            {
                DataContainer.NameSer1 = "Server";
            }
            else
            {
                DataContainer.NameSer1 = NameSel.Text;
            }

            // Server Port

            if (PortSel.Text == "")
            {
                DataContainer.Port1 = 27015;
            }
            else
            {
                try
                {
                    DataContainer.Port1 = Convert.ToInt32(PortSel.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("ERROR: PORT IS NOT A NUMBER! SETTING VALUE TO DEFAULT 27015", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataContainer.Port1 = 27015;
                }
            }

            // PvP or PvE

            if (PvPValue.Text == "On")
            {
                DataContainer.PVPSer1 = true;
            }
            else if (PvPValue.Text == "Off")
            {
                DataContainer.PVPSer1 = false;
            }

            // First person only or Both

            if (FirstPerson.Text == "First Person Only")
            {
                DataContainer.FiPerOnly1 = true;
            }
            else if (FirstPerson.Text == "Both")
            {
                DataContainer.FiPerOnly1 = false;
            }

            // Max Players

            if (MaxPlayersVal1.Checked == true)
            {
                DataContainer.MaxPlayers1 = 8;
            }
            else if (MaxPlayersVal2.Checked == true)
            {
                DataContainer.MaxPlayers1 = 16;
            }
            else if (MaxPlayersVal3.Checked == true)
            {
                DataContainer.MaxPlayers1 = 24;
            }
            else if (MaxPlayersVal4.Checked == true)
            {
                try
                {
                    DataContainer.MaxPlayers1 = Convert.ToInt32(MaxPlayersCustom.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("ERROR: MAX PLAYERS IS NOT A NUMBER! SETTING VALUE TO DEFAULT 24", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataContainer.MaxPlayers1 = 24;
                }
            }

            // Map

            if (MapSel.Text == "")
            {
                DataContainer.MapSer1 = "Washington";
            }
            else
            {
                DataContainer.MapSer1 = MapSel.Text;
            }

            // Difficulty

            if (DiffSel.Text == "Easy")
            {
                DataContainer.DiffSer1 = "Easy";
            }
            else if (DiffSel.Text == "Normal")
            {
                DataContainer.DiffSer1 = "Normal";
            }
            else if (DiffSel.Text == "Hard")
            {
                DataContainer.DiffSer1 = "Hard";
            }
            else if (DiffSel.Text == "Gold")
            {
                DataContainer.DiffSer1 = "Gold";
            }

            // Cheats

            if (CheatsSel.Text == "Off")
            {
                DataContainer.CheatSer1 = false;
            }
            else if (CheatsSel.Text == "On")
            {
                DataContainer.CheatSer1 = true;
            }

            // Password

            if (PasswordSel.Text != "")
            {
                DataContainer.PassSer1 = PasswordSel.Text;
            }
            else
            {
                DataContainer.PassSer1 = "";
            }

            // Queue

            if (QueueSize1.Checked == true)
            {
                DataContainer.QueueSer1 = 8;
            }
            else if (QueueSize2.Checked == true)
            {
                DataContainer.QueueSer1 = 16;
            }
            else if (QueueSize3.Checked == true)
            {
                DataContainer.QueueSer1 = 24;
            }
            else if (QueueSize4.Checked == true)
            {
                try
                {
                    DataContainer.QueueSer1 = Convert.ToInt32(QueueSizeCustom.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("ERROR: QUEUE SIZE IS NOT A NUMBER! SETTING VALUE TO DEFAULT 8", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataContainer.QueueSer1 = 8;
                }
            }

            // Owner
            
            if (OwnerSel.Text == "")
            {
                DataContainer.OwnerSer1 = 0;
            }
            else
            {
                try
                {
                    DataContainer.OwnerSer1 = Convert.ToInt64(OwnerSel.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("ERROR: OWNER IS NOT IN STEAM64ID FORMAT (NUMBER)! SETTING VALUE TO 0", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataContainer.OwnerSer1 = 0;
                }
            }

            // Welcome Message

            if (MessageSel.Text == "")
            {
                DataContainer.WelcomeSer1 = "";
            }
            else
            {
                DataContainer.WelcomeSer1 = MessageSel.Text;
            }

            // Sync
            
            if (SyncSel.Text == "Off")
            {
                DataContainer.SyncSer1 = false;
            }
            else if (SyncSel.Text == "On")
            {
                DataContainer.SyncSer1 = true;
            }

            // Loadout

            if (LoadoutSel.Text == "")
            {
                DataContainer.LoadoutSer1 = "";
            }
            else
            {
                DataContainer.LoadoutSer1 = LoadoutSel.Text;
            }

            // Hide Admins

            if (HideSel.Text == "False")
            {
                DataContainer.HideAdminSer1 = false;
            }
            else if (HideSel.Text == "True")
            {
                DataContainer.HideAdminSer1 = true;
            }

            // Bind to IP

            if (IPSel.Text == "")
            {
                DataContainer.BindSer1 = "0.0.0.0";
            }
            else if (IPSel.Text == "0.0.0.0")
            {
                DataContainer.BindSer1 = "0.0.0.0";
            }
            else
            {
                DataContainer.BindSer1 = IPSel.Text;
            }

            // Filter

            if (FilterSel.Text == "On")
            {
                DataContainer.FilterSer1 = true;
            }
            else if (FilterSel.Text == "Off")
            {
                DataContainer.FilterSer1 = false;
            }

            // Cycle
            
            if (Cycle1.Checked == true)
            {
                DataContainer.CycleSer1 = 43200;
            }
            else if (Cycle2.Checked == true)
            {
                try
                {
                    DataContainer.CycleSer1 = Convert.ToInt32(CycleCustom.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("ERROR: CYCLE IS NOT A NUMBER! SETTING VALUE TO 43200", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataContainer.CycleSer1 = 43200;
                }
            }

            // Chat Rate

            if (Rate1.Checked == true)
            {
                DataContainer.ChatSer1 = 0;
            }
            else if (Rate2.Checked == true)
            {
                try
                {
                    DataContainer.ChatSer1 = Convert.ToInt32(RateCustom.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("ERROR: CHAT RATE IS NOT A NUMBER! SETTING VALUE TO 0", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataContainer.CycleSer1 = 0;
                }
            }

        }

        private void LoadSave()
        {
            // Server Name

            NameSel.Text = DataContainer.NameSer1;

            // Server Port

            PortSel.Text = Convert.ToString(DataContainer.Port1);

            // PvP or PvE

            if (DataContainer.PVPSer1 == true)
            {
                PvPValue.Text = "On";
            }
            else if (DataContainer.PVPSer1 == false)
            {
                PvPValue.Text = "Off";
            }

            // First person only or Both

            if (DataContainer.FiPerOnly1 == true)
            {
                FirstPerson.Text = "First Person Only";
            }
            else if (DataContainer.FiPerOnly1 == false)
            {
                FirstPerson.Text = "Both";
            }

            // Max Players

            if (DataContainer.MaxPlayers1 == 8)
            {
                MaxPlayersVal1.Checked = true;
            }
            else if (DataContainer.MaxPlayers1 == 16)
            {
                MaxPlayersVal2.Checked = true;
            }
            else if (DataContainer.MaxPlayers1 == 24)
            {
                MaxPlayersVal3.Checked = true;
            }
            else if (DataContainer.MaxPlayers1 >=0)
            {
                MaxPlayersVal4.Checked = true;
                MaxPlayersCustom.Text = Convert.ToString(DataContainer.MaxPlayers1);
            }

            // Map

            MapSel.Text = DataContainer.MapSer1;

            // Difficulty

            if (DataContainer.DiffSer1 == "Easy")
            {
                DiffSel.Text = "Easy";
            }
            else if (DataContainer.DiffSer1 == "Normal")
            {
                DiffSel.Text = "Normal";
            }
            else if (DataContainer.DiffSer1 == "Hard")
            {
                DiffSel.Text = "Hard";
            }
            else if (DataContainer.DiffSer1 == "Gold")
            {
                DiffSel.Text = "Gold";
            }

            // Cheats

            if (DataContainer.CheatSer1 == false)
            {
                CheatsSel.Text = "Off";
            }
            else if (DataContainer.CheatSer1 == true)
            {
                CheatsSel.Text = "On";
            }

            // Password

            PasswordSel.Text = DataContainer.PassSer1;

            // Queue

            if (DataContainer.QueueSer1 == 8)
            {
                QueueSize1.Checked = true;
            }
            else if (DataContainer.QueueSer1 == 16)
            {
                QueueSize2.Checked = true;
            }
            else if (DataContainer.QueueSer1 == 24)
            {
                QueueSize3.Checked = true;
            }
            else if (DataContainer.QueueSer1 >= 0)
            {
                QueueSize4.Checked = true;
                QueueSizeCustom.Text = Convert.ToString(DataContainer.QueueSer1);
            }

            // Owner

            if (DataContainer.OwnerSer1 == 0)
            {
                OwnerSel.Text = "";
            }
            else
            {
                OwnerSel.Text = Convert.ToString(DataContainer.OwnerSer1);
            }

            // Welcome Message

            MessageSel.Text = DataContainer.WelcomeSer1;

            // Sync

            if (DataContainer.SyncSer1 == false)
            {
                SyncSel.Text = "Off";
            }
            else if (DataContainer.SyncSer1 == true)
            {
                SyncSel.Text = "On";
            }

            // Loadout

            LoadoutSel.Text = DataContainer.LoadoutSer1;

            // Hide Admins

            if (DataContainer.HideAdminSer1 == false)
            {
                HideSel.Text = "False";
            }
            else if (DataContainer.HideAdminSer1 == true)
            {
                HideSel.Text = "True";
            }

            // Bind to IP

            if (DataContainer.BindSer1 == "0.0.0.0")
            {
                IPSel.Text = "0.0.0.0";
            }
            else
            {
                IPSel.Text = DataContainer.BindSer1;
            }

            // Filter

            if (DataContainer.FilterSer1 == true)
            {
                FilterSel.Text = "On";
            }
            else if (DataContainer.FilterSer1 == false)
            {
                FilterSel.Text = "Off";
            }

            // Cycle

            if (DataContainer.CycleSer1 == 43200)
            {
                Cycle1.Checked = true;
            }
            else if (DataContainer.CycleSer1 <43200 && DataContainer.CycleSer1 >43200)
            {
                Cycle2.Checked = true;
                CycleCustom.Text = Convert.ToString(DataContainer.CycleSer1);
            }

            // Chat Rate

            if (DataContainer.ChatSer1 == 0)
            {
                Rate1.Checked = true;
            }
            else if (DataContainer.ChatSer1 > 0)
            {
                Rate2.Checked = true;
                RateCustom.Text = Convert.ToString(DataContainer.ChatSer1);
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
