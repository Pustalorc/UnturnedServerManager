using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#pragma warning disable CS0168

namespace USM
{
    public partial class ConstConfig : Form
    {
        public ConstConfig()
        {
            InitializeComponent();
            if (Comms.ConfigExists == true)
            {
                LoadS();
            }
        }

        private bool Save()
        {
            // Server Name

            if (NameSel.Text.Length < 5)
            {
                MessageBox.Show("Public Name cannot be smaller than 5 letters!");
                return false;
            }
            else
            {
                Comms.PublicName = NameSel.Text;
            }

            // Port

            try
            {
                Comms.Port = Convert.ToInt32(PortSel.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Port is not a number!");
                return false;
            }

            // PVP ON/OFF

            if (PvPOn.Checked == true)
            {
                Comms.PVP = true;
            }
            else if (PvPOff.Checked == true)
            {
                Comms.PVP = false;
            }
            
            // Perspective
            
            if (PerspFirstPer.Checked == true)
            {
                Comms.Perspective = "First";
            }
            else if (PerspBoth.Checked == true)
            {
                Comms.Perspective = "Both";
            }

            // Max Players

            if (MaxPlayersVal1.Checked == true)
            {
                Comms.MaxPlayers = 8;
            }
            else if (MaxPlayersVal2.Checked == true)
            {
                Comms.MaxPlayers = 16;
            }
            else if (MaxPlayersVal3.Checked == true)
            {
                Comms.MaxPlayers = 24;
            }
            else if (MaxPlayersVal4.Checked == true)
            {
                try
                {
                    Comms.MaxPlayers = Convert.ToInt32(MaxPlayersCustom.Text);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Max Players is not a number!");
                    return false;
                }
            }

            // Map

            Comms.Map = MapSel.Text;
            
            // Difficulty

            if (DiffEasy.Checked == true)
            {
                Comms.Difficulty = "Easy";
            }
            else if (DiffNormal.Checked == true)
            {
                Comms.Difficulty = "Normal";
            }
            else if (DiffHard.Checked == true)
            {
                Comms.Difficulty = "Hard";
            }
            
            // Gold Mode

            if (GoldTrue.Checked == true)
            {
                Comms.GoldMode = true;
            }
            else if (GoldFalse.Checked == true)
            {
                Comms.GoldMode = false;
            }

            // Cheats

            if (CheatsOn.Checked == true)
            {
                Comms.Cheats = true;
            }
            else if (CheatsOff.Checked == true)
            {
                Comms.Cheats = false;
            }

            // Password

            Comms.Password = PasswordSel.Text;

            // Queue Size

            if (QueueSize1.Checked == true)
            {
                Comms.QueueSize = 8;
            }
            else if (QueueSize2.Checked == true)
            {
                Comms.QueueSize = 16;
            }
            else if (QueueSize3.Checked == true)
            {
                Comms.QueueSize = 24;
            }
            else if (QueueSize4.Checked == true)
            {
                try
                {
                    Comms.QueueSize = Convert.ToInt32(QueueSizeCustom.Text);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Queue Size is not a number!");
                    return false;
                }
            }

            // Owner

            if (OwnerSel.Text == "")
            {
                Comms.Owner = 0;
            }
            else
            {
                try
                {
                    Comms.Owner = Convert.ToInt64(OwnerSel.Text);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Owner is not a Steam64ID!");
                    return false;
                }
            }

            // Login Message

            Comms.LoginMessage = MessageSel.Text;
            
            // Sync

            if (SyncOn.Checked == true)
            {
                Comms.Sync = true;
            }
            else if (SyncOff.Checked == true)
            {
                Comms.Sync = false;
            }

            // Loadout

            Comms.Loadout = LoadoutSel.Text;

            // Hide Admins

            if (HideAdTrue.Checked == true)
            {
                Comms.HideAdmins = true;
            }
            else if (HideAdFalse.Checked == true)
            {
                Comms.HideAdmins = false;
            }

            // Bind

            Comms.IP = IPSel.Text;

            // Filter

            if (FilterOn.Checked == true)
            {
                Comms.Filter = true;
            }
            else if (FilterOff.Checked == true)
            {
                Comms.Filter = false;
            }

            // Cycle

            if (Cycle1.Checked == true)
            {
                Comms.Cycle = 43200;
            }
            else if (Cycle2.Checked == true)
            {
                try
                {
                    Comms.Cycle = Convert.ToInt32(CycleCustom.Text);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Cycle is not a number!");
                    return false;
                }
            }

            // Chat Rate

            if (Rate1.Checked == true)
            {
                Comms.ChatRate = 0;
            }
            else if (Rate2.Checked == true)
            {
                try
                {
                    Comms.ChatRate = Convert.ToInt32(RateCustom.Text);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Chat Rate is not a number!");
                    return false;
                }
            }
            
            return true;
        }

        private void LoadS()
        {
            // Server Name

            NameSel.Text = Comms.PublicName;

            // Port

            PortSel.Text = Convert.ToString(Comms.Port);

            // PVP ON/OFF

            if (Comms.PVP == true)
            {
                PvPOn.Checked = true;
            }
            else if (Comms.PVP == false)
            {
                PvPOff.Checked = true;
            }

            // Perspective

            if (Comms.Perspective == "First")
            {
                PerspFirstPer.Checked = true;
            }
            else if (Comms.Perspective == "Both")
            {
                PerspBoth.Checked = true;
            }

            // Max Players

            if (Comms.MaxPlayers == 8)
            {
                MaxPlayersVal1.Checked = true;
            }
            else if (Comms.MaxPlayers == 16)
            {
                MaxPlayersVal2.Checked = true;
            }
            else if (Comms.MaxPlayers == 24)
            {
                MaxPlayersVal3.Checked = true;
            }
            else
            {
                MaxPlayersVal4.Checked = true;
                MaxPlayersCustom.Text = Convert.ToString(Comms.MaxPlayers);
            }

            // Map

            MapSel.Text = Comms.Map;

            // Difficulty

            if (Comms.Difficulty == "Easy")
            {
                DiffEasy.Checked = true;
            }
            else if (Comms.Difficulty == "Normal")
            {
                DiffNormal.Checked = true;
            }
            else if (Comms.Difficulty == "Hard")
            {
                DiffHard.Checked = true;
            }

            // Gold Mode

            if (Comms.GoldMode == true)
            {
                GoldTrue.Checked = true;
            }
            else if (Comms.GoldMode == false)
            {
                GoldFalse.Checked = true;
            }

            // Cheats

            if (Comms.Cheats == true)
            {
                CheatsOn.Checked = true;
            }
            else if (Comms.Cheats == false)
            {
                CheatsOff.Checked = true;
            }

            // Password

            PasswordSel.Text = Comms.Password;

            // Queue Size

            if (Comms.QueueSize == 8)
            {
                QueueSize1.Checked = true;
            }
            else if (Comms.QueueSize == 16)
            {
                QueueSize2.Checked = true;
            }
            else if (Comms.QueueSize == 24)
            {
                QueueSize3.Checked = true;
            }
            else
            {
                QueueSize4.Checked = true;
                QueueSizeCustom.Text = Convert.ToString(Comms.QueueSize);
            }

            // Owner

            if (Comms.Owner == 0)
            {
                OwnerSel.Text = "";
            }
            else
            {
                OwnerSel.Text = Convert.ToString(Comms.Owner);
            }

            // Login Message

            MessageSel.Text = Comms.LoginMessage;

            // Sync

            if (Comms.Sync == true)
            {
                SyncOn.Checked = true;
            }
            else if (Comms.Sync == false)
            {
                SyncOff.Checked = true;
            }

            // Loadout

            LoadoutSel.Text = Comms.Loadout;

            // Hide Admins

            if (Comms.HideAdmins == true)
            {
                HideAdTrue.Checked = true;
            }
            else if (Comms.HideAdmins == false)
            {
                HideAdFalse.Checked = true;
            }

            // Bind

            IPSel.Text = Comms.IP;

            // Filter

            if (Comms.Filter == true)
            {
                FilterOn.Checked = true;
            }
            else if (Comms.Filter == false)
            {
                FilterOff.Checked = true;
            }

            // Cycle

            if (Comms.Cycle == 43200)
            {
                Cycle1.Checked = true;
            }
            else
            {
                Cycle2.Checked = true;
                CycleCustom.Text = Convert.ToString(Comms.Cycle);
            }

            // Chat Rate

            if (Comms.ChatRate == 0)
            {
                Rate1.Checked = true;
            }
            else
            {
                Rate2.Checked = true;
                RateCustom.Text = Convert.ToString(Comms.ChatRate);
            }
        }

        private void QueueChange()
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

        private void CyclChange()
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

        private void MaxPlChange()
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

        private void ChatChange()
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

        private void Exit_Click(object sender, EventArgs e)
        {
            bool Success = Save();
            if(Success == true)
            {
                Comms.ConfigExists = true;
                Close();
            }
        }

        private void MaxPlayersVal4_CheckedChanged(object sender, EventArgs e)
        {
            MaxPlChange();
        }

        private void MaxPlayersVal3_CheckedChanged(object sender, EventArgs e)
        {
            MaxPlChange();
        }

        private void MaxPlayersVal2_CheckedChanged(object sender, EventArgs e)
        {
            MaxPlChange();
        }

        private void MaxPlayersVal1_CheckedChanged(object sender, EventArgs e)
        {
            MaxPlChange();
        }

        private void QueueSize4_CheckedChanged(object sender, EventArgs e)
        {
            QueueChange();
        }

        private void QueueSize3_CheckedChanged(object sender, EventArgs e)
        {
            QueueChange();
        }

        private void QueueSize2_CheckedChanged(object sender, EventArgs e)
        {
            QueueChange();
        }

        private void QueueSize1_CheckedChanged(object sender, EventArgs e)
        {
            QueueChange();
        }

        private void Rate2_CheckedChanged(object sender, EventArgs e)
        {
            ChatChange();
        }

        private void Rate1_CheckedChanged(object sender, EventArgs e)
        {
            ChatChange();
        }

        private void Cycle2_CheckedChanged(object sender, EventArgs e)
        {
            CyclChange();
        }

        private void Cycle1_CheckedChanged(object sender, EventArgs e)
        {
            CyclChange();
        }
    }
}
