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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            if (DataContainer.SavedState2 == true)
            {
                LoadSave();
            }
        }

        private void SaveVariables()
        {
            // Activate Past Saved State

            DataContainer.SavedState2 = true;

            // Server Name

            if (NameSel.Text == "")
            {
                DataContainer.NameSer2 = "Server";
            }
            else
            {
                DataContainer.NameSer2 = NameSel.Text;
            }

            // Server Port

            if (PortSel.Text == "")
            {
                DataContainer.Port2 = 27015;
            }
            else
            {
                try
                {
                    DataContainer.Port2 = Convert.ToInt32(PortSel.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("ERROR: PORT IS NOT A NUMBER! SETTING VALUE TO DEFAULT 27015", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataContainer.Port2 = 27015;
                }
            }

            // PvP or PvE

            if (PvPValue.Text == "On")
            {
                DataContainer.PVPSer2 = true;
            }
            else if (PvPValue.Text == "Off")
            {
                DataContainer.PVPSer2 = false;
            }

            // First person only or Both

            if (FirstPerson.Text == "First Person Only")
            {
                DataContainer.FiPerOnly2 = true;
            }
            else if (FirstPerson.Text == "Both")
            {
                DataContainer.FiPerOnly2 = false;
            }

            // Max Players

            if (MaxPlayersVal1.Checked == true)
            {
                DataContainer.MaxPlayers2 = 8;
            }
            else if (MaxPlayersVal2.Checked == true)
            {
                DataContainer.MaxPlayers2 = 16;
            }
            else if (MaxPlayersVal3.Checked == true)
            {
                DataContainer.MaxPlayers2 = 24;
            }
            else if (MaxPlayersVal4.Checked == true)
            {
                try
                {
                    DataContainer.MaxPlayers2 = Convert.ToInt32(MaxPlayersCustom.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("ERROR: MAX PLAYERS IS NOT A NUMBER! SETTING VALUE TO DEFAULT 24", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataContainer.MaxPlayers2 = 24;
                }
            }

            // Map

            if (MapSel.Text == "")
            {
                DataContainer.MapSer2 = "Washington";
            }
            else
            {
                DataContainer.MapSer2 = MapSel.Text;
            }

            // Difficulty

            if (DiffSel.Text == "Easy")
            {
                DataContainer.DiffSer2 = "Easy";
            }
            else if (DiffSel.Text == "Normal")
            {
                DataContainer.DiffSer2 = "Normal";
            }
            else if (DiffSel.Text == "Hard")
            {
                DataContainer.DiffSer2 = "Hard";
            }
            else if (DiffSel.Text == "Gold")
            {
                DataContainer.DiffSer2 = "Gold";
            }

            // Cheats

            if (CheatsSel.Text == "Off")
            {
                DataContainer.CheatSer2 = false;
            }
            else if (CheatsSel.Text == "On")
            {
                DataContainer.CheatSer2 = true;
            }

            // Password

            if (PasswordSel.Text != "")
            {
                DataContainer.PassSer2 = PasswordSel.Text;
            }
            else
            {
                DataContainer.PassSer2 = "";
            }

            // Queue

            if (QueueSize1.Checked == true)
            {
                DataContainer.QueueSer2 = 8;
            }
            else if (QueueSize2.Checked == true)
            {
                DataContainer.QueueSer2 = 16;
            }
            else if (QueueSize3.Checked == true)
            {
                DataContainer.QueueSer2 = 24;
            }
            else if (QueueSize4.Checked == true)
            {
                try
                {
                    DataContainer.QueueSer2 = Convert.ToInt32(QueueSizeCustom.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("ERROR: QUEUE SIZE IS NOT A NUMBER! SETTING VALUE TO DEFAULT 8", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataContainer.QueueSer2 = 8;
                }
            }

            // Owner
            
            if (OwnerSel.Text == "")
            {
                DataContainer.OwnerSer2 = 0;
            }
            else
            {
                try
                {
                    DataContainer.OwnerSer2 = Convert.ToInt32(OwnerSel.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("ERROR: OWNER IS NOT IN STEAM64ID FORMAT (NUMBER)! SETTING VALUE TO 0", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataContainer.OwnerSer2 = 0;
                }
            }

            // Welcome Message

            if (MessageSel.Text == "")
            {
                DataContainer.WelcomeSer2 = "";
            }
            else
            {
                DataContainer.WelcomeSer2 = MessageSel.Text;
            }

            // Sync
            
            if (SyncSel.Text == "Off")
            {
                DataContainer.SyncSer2 = false;
            }
            else if (SyncSel.Text == "On")
            {
                DataContainer.SyncSer2 = true;
            }

            // Loadout

            if (LoadoutSel.Text == "")
            {
                DataContainer.LoadoutSer2 = "";
            }
            else
            {
                DataContainer.LoadoutSer2 = LoadoutSel.Text;
            }

            // Hide Admins

            if (HideSel.Text == "False")
            {
                DataContainer.HideAdminSer2 = false;
            }
            else if (HideSel.Text == "True")
            {
                DataContainer.HideAdminSer2 = true;
            }

            // Bind to IP

            if (IPSel.Text == "")
            {
                DataContainer.BindSer2 = "0.0.0.0";
            }
            else if (IPSel.Text == "0.0.0.0")
            {
                DataContainer.BindSer2 = "0.0.0.0";
            }
            else
            {
                DataContainer.BindSer2 = IPSel.Text;
            }

            // Filter

            if (FilterSel.Text == "On")
            {
                DataContainer.FilterSer2 = true;
            }
            else if (FilterSel.Text == "Off")
            {
                DataContainer.FilterSer2 = false;
            }

            // Cycle
            
            if (Cycle1.Checked == true)
            {
                DataContainer.CycleSer2 = 43200;
            }
            else if (Cycle2.Checked == true)
            {
                try
                {
                    DataContainer.CycleSer2 = Convert.ToInt32(CycleCustom.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("ERROR: CYCLE IS NOT A NUMBER! SETTING VALUE TO 43200", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataContainer.CycleSer2 = 43200;
                }
            }

            // Chat Rate

            if (Rate1.Checked == true)
            {
                DataContainer.ChatSer2 = 0;
            }
            else if (Rate2.Checked == true)
            {
                try
                {
                    DataContainer.ChatSer2 = Convert.ToInt32(RateCustom.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("ERROR: CHAT RATE IS NOT A NUMBER! SETTING VALUE TO 0", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataContainer.CycleSer2 = 0;
                }
            }

        }

        private void LoadSave()
        {
            // Server Name

            NameSel.Text = DataContainer.NameSer2;

            // Server Port

            PortSel.Text = Convert.ToString(DataContainer.Port2);

            // PvP or PvE

            if (DataContainer.PVPSer2 == true)
            {
                PvPValue.Text = "On";
            }
            else if (DataContainer.PVPSer2 == false)
            {
                PvPValue.Text = "Off";
            }

            // First person only or Both

            if (DataContainer.FiPerOnly2 == true)
            {
                FirstPerson.Text = "First Person Only";
            }
            else if (DataContainer.FiPerOnly2 == false)
            {
                FirstPerson.Text = "Both";
            }

            // Max Players

            if (DataContainer.MaxPlayers2 == 8)
            {
                MaxPlayersVal1.Checked = true;
            }
            else if (DataContainer.MaxPlayers2 == 16)
            {
                MaxPlayersVal2.Checked = true;
            }
            else if (DataContainer.MaxPlayers2 == 24)
            {
                MaxPlayersVal3.Checked = true;
            }
            else if (DataContainer.MaxPlayers2 >=0)
            {
                MaxPlayersVal4.Checked = true;
                MaxPlayersCustom.Text = Convert.ToString(DataContainer.MaxPlayers2);
            }

            // Map

            MapSel.Text = DataContainer.MapSer2;

            // Difficulty

            if (DataContainer.DiffSer2 == "Easy")
            {
                DiffSel.Text = "Easy";
            }
            else if (DataContainer.DiffSer2 == "Normal")
            {
                DiffSel.Text = "Normal";
            }
            else if (DataContainer.DiffSer2 == "Hard")
            {
                DiffSel.Text = "Hard";
            }
            else if (DataContainer.DiffSer2 == "Gold")
            {
                DiffSel.Text = "Gold";
            }

            // Cheats

            if (DataContainer.CheatSer2 == false)
            {
                CheatsSel.Text = "Off";
            }
            else if (DataContainer.CheatSer2 == true)
            {
                CheatsSel.Text = "On";
            }

            // Password

            PasswordSel.Text = DataContainer.PassSer2;

            // Queue

            if (DataContainer.QueueSer2 == 8)
            {
                QueueSize1.Checked = true;
            }
            else if (DataContainer.QueueSer2 == 16)
            {
                QueueSize2.Checked = true;
            }
            else if (DataContainer.QueueSer2 == 24)
            {
                QueueSize3.Checked = true;
            }
            else if (DataContainer.QueueSer2 >= 0)
            {
                QueueSize4.Checked = true;
                QueueSizeCustom.Text = Convert.ToString(DataContainer.QueueSer2);
            }

            // Owner

            if (DataContainer.OwnerSer2 == 0)
            {
                OwnerSel.Text = "";
            }
            else
            {
                OwnerSel.Text = Convert.ToString(DataContainer.OwnerSer2);
            }

            // Welcome Message

            MessageSel.Text = DataContainer.WelcomeSer2;

            // Sync

            if (DataContainer.SyncSer2 == false)
            {
                SyncSel.Text = "Off";
            }
            else if (DataContainer.SyncSer2 == true)
            {
                SyncSel.Text = "On";
            }

            // Loadout

            LoadoutSel.Text = DataContainer.LoadoutSer2;

            // Hide Admins

            if (DataContainer.HideAdminSer2 == false)
            {
                HideSel.Text = "False";
            }
            else if (DataContainer.HideAdminSer2 == true)
            {
                HideSel.Text = "True";
            }

            // Bind to IP

            if (DataContainer.BindSer2 == "0.0.0.0")
            {
                IPSel.Text = "0.0.0.0";
            }
            else
            {
                IPSel.Text = DataContainer.BindSer2;
            }

            // Filter

            if (DataContainer.FilterSer2 == true)
            {
                FilterSel.Text = "On";
            }
            else if (DataContainer.FilterSer2 == false)
            {
                FilterSel.Text = "Off";
            }

            // Cycle

            if (DataContainer.CycleSer2 == 43200)
            {
                Cycle1.Checked = true;
            }
            else if (DataContainer.CycleSer2 <43200 && DataContainer.CycleSer2 >43200)
            {
                Cycle2.Checked = true;
                CycleCustom.Text = Convert.ToString(DataContainer.CycleSer2);
            }

            // Chat Rate

            if (DataContainer.ChatSer2 == 0)
            {
                Rate1.Checked = true;
            }
            else if (DataContainer.ChatSer2 > 0)
            {
                Rate2.Checked = true;
                RateCustom.Text = Convert.ToString(DataContainer.ChatSer2);
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
