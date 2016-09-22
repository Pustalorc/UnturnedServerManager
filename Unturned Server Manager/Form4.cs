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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            if (DataContainer.SavedState3 == true)
            {
                LoadSave();
            }
        }

        private void SaveVariables()
        {
            // Activate Past Saved State

            DataContainer.SavedState3 = true;

            // Server Name

            if (NameSel.Text == "")
            {
                DataContainer.NameSer3 = "Server";
            }
            else
            {
                DataContainer.NameSer3 = NameSel.Text;
            }

            // Server Port

            if (PortSel.Text == "")
            {
                DataContainer.Port3 = 27015;
            }
            else
            {
                try
                {
                    DataContainer.Port3 = Convert.ToInt32(PortSel.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("ERROR: PORT IS NOT A NUMBER! SETTING VALUE TO DEFAULT 27015", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataContainer.Port3 = 27015;
                }
            }

            // PvP or PvE

            if (PvPValue.Text == "On")
            {
                DataContainer.PVPSer3 = true;
            }
            else if (PvPValue.Text == "Off")
            {
                DataContainer.PVPSer3 = false;
            }

            // First person only or Both

            if (FirstPerson.Text == "First Person Only")
            {
                DataContainer.FiPerOnly3 = true;
            }
            else if (FirstPerson.Text == "Both")
            {
                DataContainer.FiPerOnly3 = false;
            }

            // Max Players

            if (MaxPlayersVal1.Checked == true)
            {
                DataContainer.MaxPlayers3 = 8;
            }
            else if (MaxPlayersVal2.Checked == true)
            {
                DataContainer.MaxPlayers3 = 16;
            }
            else if (MaxPlayersVal3.Checked == true)
            {
                DataContainer.MaxPlayers3 = 24;
            }
            else if (MaxPlayersVal4.Checked == true)
            {
                try
                {
                    DataContainer.MaxPlayers3 = Convert.ToInt32(MaxPlayersCustom.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("ERROR: MAX PLAYERS IS NOT A NUMBER! SETTING VALUE TO DEFAULT 24", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataContainer.MaxPlayers3 = 24;
                }
            }

            // Map

            if (MapSel.Text == "")
            {
                DataContainer.MapSer3 = "Washington";
            }
            else
            {
                DataContainer.MapSer3 = MapSel.Text;
            }

            // Difficulty

            if (DiffSel.Text == "Easy")
            {
                DataContainer.DiffSer3 = "Easy";
            }
            else if (DiffSel.Text == "Normal")
            {
                DataContainer.DiffSer3 = "Normal";
            }
            else if (DiffSel.Text == "Hard")
            {
                DataContainer.DiffSer3 = "Hard";
            }
            else if (DiffSel.Text == "Gold")
            {
                DataContainer.DiffSer3 = "Gold";
            }

            // Cheats

            if (CheatsSel.Text == "Off")
            {
                DataContainer.CheatSer3 = false;
            }
            else if (CheatsSel.Text == "On")
            {
                DataContainer.CheatSer3 = true;
            }

            // Password

            if (PasswordSel.Text != "")
            {
                DataContainer.PassSer3 = PasswordSel.Text;
            }
            else
            {
                DataContainer.PassSer3 = "";
            }

            // Queue

            if (QueueSize1.Checked == true)
            {
                DataContainer.QueueSer3 = 8;
            }
            else if (QueueSize2.Checked == true)
            {
                DataContainer.QueueSer3 = 16;
            }
            else if (QueueSize3.Checked == true)
            {
                DataContainer.QueueSer3 = 24;
            }
            else if (QueueSize4.Checked == true)
            {
                try
                {
                    DataContainer.QueueSer3 = Convert.ToInt32(QueueSizeCustom.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("ERROR: QUEUE SIZE IS NOT A NUMBER! SETTING VALUE TO DEFAULT 8", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataContainer.QueueSer3 = 8;
                }
            }

            // Owner
            
            if (OwnerSel.Text == "")
            {
                DataContainer.OwnerSer3 = 0;
            }
            else
            {
                try
                {
                    DataContainer.OwnerSer3 = Convert.ToInt32(OwnerSel.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("ERROR: OWNER IS NOT IN STEAM64ID FORMAT (NUMBER)! SETTING VALUE TO 0", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataContainer.OwnerSer3 = 0;
                }
            }

            // Welcome Message

            if (MessageSel.Text == "")
            {
                DataContainer.WelcomeSer3 = "";
            }
            else
            {
                DataContainer.WelcomeSer3 = MessageSel.Text;
            }

            // Sync
            
            if (SyncSel.Text == "Off")
            {
                DataContainer.SyncSer3 = false;
            }
            else if (SyncSel.Text == "On")
            {
                DataContainer.SyncSer3 = true;
            }

            // Loadout

            if (LoadoutSel.Text == "")
            {
                DataContainer.LoadoutSer3 = "";
            }
            else
            {
                DataContainer.LoadoutSer3 = LoadoutSel.Text;
            }

            // Hide Admins

            if (HideSel.Text == "False")
            {
                DataContainer.HideAdminSer3 = false;
            }
            else if (HideSel.Text == "True")
            {
                DataContainer.HideAdminSer3 = true;
            }

            // Bind to IP

            if (IPSel.Text == "")
            {
                DataContainer.BindSer3 = "0.0.0.0";
            }
            else if (IPSel.Text == "0.0.0.0")
            {
                DataContainer.BindSer3 = "0.0.0.0";
            }
            else
            {
                DataContainer.BindSer3 = IPSel.Text;
            }

            // Filter

            if (FilterSel.Text == "On")
            {
                DataContainer.FilterSer3 = true;
            }
            else if (FilterSel.Text == "Off")
            {
                DataContainer.FilterSer3 = false;
            }

            // Cycle
            
            if (Cycle1.Checked == true)
            {
                DataContainer.CycleSer3 = 43200;
            }
            else if (Cycle2.Checked == true)
            {
                try
                {
                    DataContainer.CycleSer3 = Convert.ToInt32(CycleCustom.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("ERROR: CYCLE IS NOT A NUMBER! SETTING VALUE TO 43200", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataContainer.CycleSer3 = 43200;
                }
            }

            // Chat Rate

            if (Rate1.Checked == true)
            {
                DataContainer.ChatSer3 = 0;
            }
            else if (Rate2.Checked == true)
            {
                try
                {
                    DataContainer.ChatSer3 = Convert.ToInt32(RateCustom.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("ERROR: CHAT RATE IS NOT A NUMBER! SETTING VALUE TO 0", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataContainer.CycleSer3 = 0;
                }
            }

        }

        private void LoadSave()
        {
            // Server Name

            NameSel.Text = DataContainer.NameSer3;

            // Server Port

            PortSel.Text = Convert.ToString(DataContainer.Port3);

            // PvP or PvE

            if (DataContainer.PVPSer3 == true)
            {
                PvPValue.Text = "On";
            }
            else if (DataContainer.PVPSer3 == false)
            {
                PvPValue.Text = "Off";
            }

            // First person only or Both

            if (DataContainer.FiPerOnly3 == true)
            {
                FirstPerson.Text = "First Person Only";
            }
            else if (DataContainer.FiPerOnly3 == false)
            {
                FirstPerson.Text = "Both";
            }

            // Max Players

            if (DataContainer.MaxPlayers3 == 8)
            {
                MaxPlayersVal1.Checked = true;
            }
            else if (DataContainer.MaxPlayers3 == 16)
            {
                MaxPlayersVal2.Checked = true;
            }
            else if (DataContainer.MaxPlayers3 == 24)
            {
                MaxPlayersVal3.Checked = true;
            }
            else if (DataContainer.MaxPlayers3 >=0)
            {
                MaxPlayersVal4.Checked = true;
                MaxPlayersCustom.Text = Convert.ToString(DataContainer.MaxPlayers3);
            }

            // Map

            MapSel.Text = DataContainer.MapSer3;

            // Difficulty

            if (DataContainer.DiffSer3 == "Easy")
            {
                DiffSel.Text = "Easy";
            }
            else if (DataContainer.DiffSer3 == "Normal")
            {
                DiffSel.Text = "Normal";
            }
            else if (DataContainer.DiffSer3 == "Hard")
            {
                DiffSel.Text = "Hard";
            }
            else if (DataContainer.DiffSer3 == "Gold")
            {
                DiffSel.Text = "Gold";
            }

            // Cheats

            if (DataContainer.CheatSer3 == false)
            {
                CheatsSel.Text = "Off";
            }
            else if (DataContainer.CheatSer3 == true)
            {
                CheatsSel.Text = "On";
            }

            // Password

            PasswordSel.Text = DataContainer.PassSer3;

            // Queue

            if (DataContainer.QueueSer3 == 8)
            {
                QueueSize1.Checked = true;
            }
            else if (DataContainer.QueueSer3 == 16)
            {
                QueueSize2.Checked = true;
            }
            else if (DataContainer.QueueSer3 == 24)
            {
                QueueSize3.Checked = true;
            }
            else if (DataContainer.QueueSer3 >= 0)
            {
                QueueSize4.Checked = true;
                QueueSizeCustom.Text = Convert.ToString(DataContainer.QueueSer3);
            }

            // Owner

            if (DataContainer.OwnerSer3 == 0)
            {
                OwnerSel.Text = "";
            }
            else
            {
                OwnerSel.Text = Convert.ToString(DataContainer.OwnerSer3);
            }

            // Welcome Message

            MessageSel.Text = DataContainer.WelcomeSer3;

            // Sync

            if (DataContainer.SyncSer3 == false)
            {
                SyncSel.Text = "Off";
            }
            else if (DataContainer.SyncSer3 == true)
            {
                SyncSel.Text = "On";
            }

            // Loadout

            LoadoutSel.Text = DataContainer.LoadoutSer3;

            // Hide Admins

            if (DataContainer.HideAdminSer3 == false)
            {
                HideSel.Text = "False";
            }
            else if (DataContainer.HideAdminSer3 == true)
            {
                HideSel.Text = "True";
            }

            // Bind to IP

            if (DataContainer.BindSer3 == "0.0.0.0")
            {
                IPSel.Text = "0.0.0.0";
            }
            else
            {
                IPSel.Text = DataContainer.BindSer3;
            }

            // Filter

            if (DataContainer.FilterSer3 == true)
            {
                FilterSel.Text = "On";
            }
            else if (DataContainer.FilterSer3 == false)
            {
                FilterSel.Text = "Off";
            }

            // Cycle

            if (DataContainer.CycleSer3 == 43200)
            {
                Cycle1.Checked = true;
            }
            else if (DataContainer.CycleSer3 <43200 && DataContainer.CycleSer3 >43200)
            {
                Cycle2.Checked = true;
                CycleCustom.Text = Convert.ToString(DataContainer.CycleSer3);
            }

            // Chat Rate

            if (DataContainer.ChatSer3 == 0)
            {
                Rate1.Checked = true;
            }
            else if (DataContainer.ChatSer3 > 0)
            {
                Rate2.Checked = true;
                RateCustom.Text = Convert.ToString(DataContainer.ChatSer3);
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
