using System.ComponentModel;
using System.Windows.Forms;

namespace Pustalorc.Applications.USM.GUI
{
    internal sealed partial class ConfigForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Rate2 = new System.Windows.Forms.RadioButton();
            this.Cycle1 = new System.Windows.Forms.RadioButton();
            this.Cycle2 = new System.Windows.Forms.RadioButton();
            this.Rate1 = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.GoldFalse = new System.Windows.Forms.RadioButton();
            this.GoldTrue = new System.Windows.Forms.RadioButton();
            this.GoldDesc = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ChatRate = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Cycle = new System.Windows.Forms.NumericUpDown();
            this.RateDesc = new System.Windows.Forms.Label();
            this.CycleDesc = new System.Windows.Forms.Label();
            this.FilterDesc = new System.Windows.Forms.Label();
            this.IPDesc = new System.Windows.Forms.Label();
            this.HideDesc = new System.Windows.Forms.Label();
            this.LoadoutSel = new System.Windows.Forms.TextBox();
            this.LoadoutDesc = new System.Windows.Forms.Label();
            this.SyncDesc = new System.Windows.Forms.Label();
            this.MessageSel = new System.Windows.Forms.TextBox();
            this.MessageDesc = new System.Windows.Forms.Label();
            this.OwnerDesc = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MaxPlayers = new System.Windows.Forms.NumericUpDown();
            this.MaxPlayersVal4 = new System.Windows.Forms.RadioButton();
            this.MaxPlayersVal1 = new System.Windows.Forms.RadioButton();
            this.MaxPlayersVal2 = new System.Windows.Forms.RadioButton();
            this.MaxPlayersVal3 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Queue = new System.Windows.Forms.NumericUpDown();
            this.QueueSize1 = new System.Windows.Forms.RadioButton();
            this.QueueSize3 = new System.Windows.Forms.RadioButton();
            this.QueueSize4 = new System.Windows.Forms.RadioButton();
            this.QueueSize2 = new System.Windows.Forms.RadioButton();
            this.PasswordSel = new System.Windows.Forms.TextBox();
            this.QueueDesc = new System.Windows.Forms.Label();
            this.PasswordDesc = new System.Windows.Forms.Label();
            this.CheatsDesc = new System.Windows.Forms.Label();
            this.DifficultyDesc = new System.Windows.Forms.Label();
            this.MapDesc = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.MaxDesc = new System.Windows.Forms.Label();
            this.FirstDesc = new System.Windows.Forms.Label();
            this.PvPDesc = new System.Windows.Forms.Label();
            this.PortDesc = new System.Windows.Forms.Label();
            this.NameSel = new System.Windows.Forms.TextBox();
            this.NameDesc = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.PvPOff = new System.Windows.Forms.RadioButton();
            this.PvPOn = new System.Windows.Forms.RadioButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.PerspFirstPer = new System.Windows.Forms.RadioButton();
            this.PerspBoth = new System.Windows.Forms.RadioButton();
            this.panel8 = new System.Windows.Forms.Panel();
            this.DiffNormal = new System.Windows.Forms.RadioButton();
            this.DiffEasy = new System.Windows.Forms.RadioButton();
            this.DiffHard = new System.Windows.Forms.RadioButton();
            this.panel9 = new System.Windows.Forms.Panel();
            this.CheatsOff = new System.Windows.Forms.RadioButton();
            this.CheatsOn = new System.Windows.Forms.RadioButton();
            this.panel10 = new System.Windows.Forms.Panel();
            this.SyncOff = new System.Windows.Forms.RadioButton();
            this.SyncOn = new System.Windows.Forms.RadioButton();
            this.panel11 = new System.Windows.Forms.Panel();
            this.HideAdFalse = new System.Windows.Forms.RadioButton();
            this.HideAdTrue = new System.Windows.Forms.RadioButton();
            this.panel12 = new System.Windows.Forms.Panel();
            this.FilterOff = new System.Windows.Forms.RadioButton();
            this.FilterOn = new System.Windows.Forms.RadioButton();
            this.OwnerID = new System.Windows.Forms.NumericUpDown();
            this.IPField4 = new System.Windows.Forms.NumericUpDown();
            this.IPField3 = new System.Windows.Forms.NumericUpDown();
            this.IPField2 = new System.Windows.Forms.NumericUpDown();
            this.IPField1 = new System.Windows.Forms.NumericUpDown();
            this.IPDot1 = new System.Windows.Forms.Label();
            this.IPDot3 = new System.Windows.Forms.Label();
            this.IPDot2 = new System.Windows.Forms.Label();
            this.Port = new System.Windows.Forms.NumericUpDown();
            this.Maps = new System.Windows.Forms.ComboBox();
            this.btn_config = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChatRate)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cycle)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxPlayers)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Queue)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OwnerID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IPField4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IPField3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IPField2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IPField1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Port)).BeginInit();
            this.SuspendLayout();
            // 
            // Rate2
            // 
            this.Rate2.AutoSize = true;
            this.Rate2.Location = new System.Drawing.Point(86, 3);
            this.Rate2.Name = "Rate2";
            this.Rate2.Size = new System.Drawing.Size(54, 17);
            this.Rate2.TabIndex = 28;
            this.Rate2.Tag = "Queue";
            this.Rate2.Text = "Other:";
            this.Rate2.UseVisualStyleBackColor = true;
            this.Rate2.CheckedChanged += new System.EventHandler(this.Rate_CheckedChanged);
            // 
            // Cycle1
            // 
            this.Cycle1.AutoSize = true;
            this.Cycle1.Checked = true;
            this.Cycle1.Location = new System.Drawing.Point(9, 3);
            this.Cycle1.Name = "Cycle1";
            this.Cycle1.Size = new System.Drawing.Size(95, 17);
            this.Cycle1.TabIndex = 25;
            this.Cycle1.TabStop = true;
            this.Cycle1.Tag = "Queue";
            this.Cycle1.Text = "Default: 43200";
            this.Cycle1.UseVisualStyleBackColor = true;
            this.Cycle1.CheckedChanged += new System.EventHandler(this.Cycle_CheckedChanged);
            // 
            // Cycle2
            // 
            this.Cycle2.AutoSize = true;
            this.Cycle2.Location = new System.Drawing.Point(110, 3);
            this.Cycle2.Name = "Cycle2";
            this.Cycle2.Size = new System.Drawing.Size(54, 17);
            this.Cycle2.TabIndex = 28;
            this.Cycle2.Tag = "Queue";
            this.Cycle2.Text = "Other:";
            this.Cycle2.UseVisualStyleBackColor = true;
            this.Cycle2.CheckedChanged += new System.EventHandler(this.Cycle_CheckedChanged);
            // 
            // Rate1
            // 
            this.Rate1.AutoSize = true;
            this.Rate1.Checked = true;
            this.Rate1.Location = new System.Drawing.Point(9, 3);
            this.Rate1.Name = "Rate1";
            this.Rate1.Size = new System.Drawing.Size(71, 17);
            this.Rate1.TabIndex = 25;
            this.Rate1.TabStop = true;
            this.Rate1.Tag = "Queue";
            this.Rate1.Text = "Default: 0";
            this.Rate1.UseVisualStyleBackColor = true;
            this.Rate1.CheckedChanged += new System.EventHandler(this.Rate_CheckedChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.GoldFalse);
            this.panel5.Controls.Add(this.GoldTrue);
            this.panel5.Location = new System.Drawing.Point(83, 197);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(289, 23);
            this.panel5.TabIndex = 78;
            // 
            // GoldFalse
            // 
            this.GoldFalse.AutoSize = true;
            this.GoldFalse.Checked = true;
            this.GoldFalse.Location = new System.Drawing.Point(9, 3);
            this.GoldFalse.Name = "GoldFalse";
            this.GoldFalse.Size = new System.Drawing.Size(66, 17);
            this.GoldFalse.TabIndex = 25;
            this.GoldFalse.TabStop = true;
            this.GoldFalse.Tag = "Queue";
            this.GoldFalse.Text = "Disabled";
            this.GoldFalse.UseVisualStyleBackColor = true;
            // 
            // GoldTrue
            // 
            this.GoldTrue.AutoSize = true;
            this.GoldTrue.Location = new System.Drawing.Point(222, 3);
            this.GoldTrue.Name = "GoldTrue";
            this.GoldTrue.Size = new System.Drawing.Size(64, 17);
            this.GoldTrue.TabIndex = 28;
            this.GoldTrue.Tag = "Queue";
            this.GoldTrue.Text = "Enabled";
            this.GoldTrue.UseVisualStyleBackColor = true;
            // 
            // GoldDesc
            // 
            this.GoldDesc.AutoSize = true;
            this.GoldDesc.Location = new System.Drawing.Point(12, 202);
            this.GoldDesc.Name = "GoldDesc";
            this.GoldDesc.Size = new System.Drawing.Size(32, 13);
            this.GoldDesc.TabIndex = 93;
            this.GoldDesc.Text = "Gold:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ChatRate);
            this.panel4.Controls.Add(this.Rate1);
            this.panel4.Controls.Add(this.Rate2);
            this.panel4.Location = new System.Drawing.Point(83, 522);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(289, 23);
            this.panel4.TabIndex = 75;
            // 
            // ChatRate
            // 
            this.ChatRate.Enabled = false;
            this.ChatRate.Location = new System.Drawing.Point(145, 3);
            this.ChatRate.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.ChatRate.Name = "ChatRate";
            this.ChatRate.Size = new System.Drawing.Size(144, 20);
            this.ChatRate.TabIndex = 30;
            this.ChatRate.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Cycle);
            this.panel3.Controls.Add(this.Cycle1);
            this.panel3.Controls.Add(this.Cycle2);
            this.panel3.Location = new System.Drawing.Point(83, 493);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(289, 23);
            this.panel3.TabIndex = 74;
            // 
            // Cycle
            // 
            this.Cycle.Enabled = false;
            this.Cycle.Location = new System.Drawing.Point(169, 3);
            this.Cycle.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.Cycle.Name = "Cycle";
            this.Cycle.Size = new System.Drawing.Size(120, 20);
            this.Cycle.TabIndex = 30;
            // 
            // RateDesc
            // 
            this.RateDesc.AutoSize = true;
            this.RateDesc.Location = new System.Drawing.Point(12, 527);
            this.RateDesc.Name = "RateDesc";
            this.RateDesc.Size = new System.Drawing.Size(58, 13);
            this.RateDesc.TabIndex = 91;
            this.RateDesc.Text = "Chat Rate:";
            // 
            // CycleDesc
            // 
            this.CycleDesc.AutoSize = true;
            this.CycleDesc.Location = new System.Drawing.Point(12, 498);
            this.CycleDesc.Name = "CycleDesc";
            this.CycleDesc.Size = new System.Drawing.Size(36, 13);
            this.CycleDesc.TabIndex = 90;
            this.CycleDesc.Text = "Cycle:";
            // 
            // FilterDesc
            // 
            this.FilterDesc.AutoSize = true;
            this.FilterDesc.Location = new System.Drawing.Point(12, 469);
            this.FilterDesc.Name = "FilterDesc";
            this.FilterDesc.Size = new System.Drawing.Size(32, 13);
            this.FilterDesc.TabIndex = 89;
            this.FilterDesc.Text = "Filter:";
            // 
            // IPDesc
            // 
            this.IPDesc.AutoSize = true;
            this.IPDesc.Location = new System.Drawing.Point(12, 444);
            this.IPDesc.Name = "IPDesc";
            this.IPDesc.Size = new System.Drawing.Size(50, 13);
            this.IPDesc.TabIndex = 87;
            this.IPDesc.Text = "Bind (IP):";
            // 
            // HideDesc
            // 
            this.HideDesc.AutoSize = true;
            this.HideDesc.Location = new System.Drawing.Point(12, 416);
            this.HideDesc.Name = "HideDesc";
            this.HideDesc.Size = new System.Drawing.Size(69, 13);
            this.HideDesc.TabIndex = 86;
            this.HideDesc.Text = "Hide Admins:";
            // 
            // LoadoutSel
            // 
            this.LoadoutSel.Location = new System.Drawing.Point(92, 387);
            this.LoadoutSel.Name = "LoadoutSel";
            this.LoadoutSel.Size = new System.Drawing.Size(280, 20);
            this.LoadoutSel.TabIndex = 84;
            // 
            // LoadoutDesc
            // 
            this.LoadoutDesc.AutoSize = true;
            this.LoadoutDesc.Location = new System.Drawing.Point(12, 390);
            this.LoadoutDesc.Name = "LoadoutDesc";
            this.LoadoutDesc.Size = new System.Drawing.Size(49, 13);
            this.LoadoutDesc.TabIndex = 83;
            this.LoadoutDesc.Text = "Loadout:";
            // 
            // SyncDesc
            // 
            this.SyncDesc.AutoSize = true;
            this.SyncDesc.Location = new System.Drawing.Point(12, 363);
            this.SyncDesc.Name = "SyncDesc";
            this.SyncDesc.Size = new System.Drawing.Size(34, 13);
            this.SyncDesc.TabIndex = 82;
            this.SyncDesc.Text = "Sync:";
            // 
            // MessageSel
            // 
            this.MessageSel.Location = new System.Drawing.Point(92, 334);
            this.MessageSel.Name = "MessageSel";
            this.MessageSel.Size = new System.Drawing.Size(280, 20);
            this.MessageSel.TabIndex = 80;
            // 
            // MessageDesc
            // 
            this.MessageDesc.AutoSize = true;
            this.MessageDesc.Location = new System.Drawing.Point(12, 337);
            this.MessageDesc.Name = "MessageDesc";
            this.MessageDesc.Size = new System.Drawing.Size(82, 13);
            this.MessageDesc.TabIndex = 79;
            this.MessageDesc.Text = "Login Message:";
            // 
            // OwnerDesc
            // 
            this.OwnerDesc.AutoSize = true;
            this.OwnerDesc.Location = new System.Drawing.Point(12, 311);
            this.OwnerDesc.Name = "OwnerDesc";
            this.OwnerDesc.Size = new System.Drawing.Size(41, 13);
            this.OwnerDesc.TabIndex = 76;
            this.OwnerDesc.Text = "Owner:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.MaxPlayers);
            this.panel2.Controls.Add(this.MaxPlayersVal4);
            this.panel2.Controls.Add(this.MaxPlayersVal1);
            this.panel2.Controls.Add(this.MaxPlayersVal2);
            this.panel2.Controls.Add(this.MaxPlayersVal3);
            this.panel2.Location = new System.Drawing.Point(83, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 23);
            this.panel2.TabIndex = 73;
            // 
            // MaxPlayers
            // 
            this.MaxPlayers.Enabled = false;
            this.MaxPlayers.Location = new System.Drawing.Point(192, 1);
            this.MaxPlayers.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.MaxPlayers.Name = "MaxPlayers";
            this.MaxPlayers.Size = new System.Drawing.Size(97, 20);
            this.MaxPlayers.TabIndex = 13;
            this.MaxPlayers.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // MaxPlayersVal4
            // 
            this.MaxPlayersVal4.AutoSize = true;
            this.MaxPlayersVal4.Location = new System.Drawing.Point(132, 3);
            this.MaxPlayersVal4.Name = "MaxPlayersVal4";
            this.MaxPlayersVal4.Size = new System.Drawing.Size(54, 17);
            this.MaxPlayersVal4.TabIndex = 12;
            this.MaxPlayersVal4.Text = "Other:";
            this.MaxPlayersVal4.UseVisualStyleBackColor = true;
            this.MaxPlayersVal4.CheckedChanged += new System.EventHandler(this.MaxPlayers_CheckedChanged);
            // 
            // MaxPlayersVal1
            // 
            this.MaxPlayersVal1.AutoSize = true;
            this.MaxPlayersVal1.Location = new System.Drawing.Point(9, 3);
            this.MaxPlayersVal1.Name = "MaxPlayersVal1";
            this.MaxPlayersVal1.Size = new System.Drawing.Size(31, 17);
            this.MaxPlayersVal1.TabIndex = 9;
            this.MaxPlayersVal1.Text = "8";
            this.MaxPlayersVal1.UseVisualStyleBackColor = true;
            this.MaxPlayersVal1.CheckedChanged += new System.EventHandler(this.MaxPlayers_CheckedChanged);
            // 
            // MaxPlayersVal2
            // 
            this.MaxPlayersVal2.AutoSize = true;
            this.MaxPlayersVal2.Location = new System.Drawing.Point(46, 3);
            this.MaxPlayersVal2.Name = "MaxPlayersVal2";
            this.MaxPlayersVal2.Size = new System.Drawing.Size(37, 17);
            this.MaxPlayersVal2.TabIndex = 10;
            this.MaxPlayersVal2.Text = "16";
            this.MaxPlayersVal2.UseVisualStyleBackColor = true;
            this.MaxPlayersVal2.CheckedChanged += new System.EventHandler(this.MaxPlayers_CheckedChanged);
            // 
            // MaxPlayersVal3
            // 
            this.MaxPlayersVal3.AutoSize = true;
            this.MaxPlayersVal3.Checked = true;
            this.MaxPlayersVal3.Location = new System.Drawing.Point(89, 3);
            this.MaxPlayersVal3.Name = "MaxPlayersVal3";
            this.MaxPlayersVal3.Size = new System.Drawing.Size(37, 17);
            this.MaxPlayersVal3.TabIndex = 11;
            this.MaxPlayersVal3.TabStop = true;
            this.MaxPlayersVal3.Text = "24";
            this.MaxPlayersVal3.UseVisualStyleBackColor = true;
            this.MaxPlayersVal3.CheckedChanged += new System.EventHandler(this.MaxPlayers_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Queue);
            this.panel1.Controls.Add(this.QueueSize1);
            this.panel1.Controls.Add(this.QueueSize3);
            this.panel1.Controls.Add(this.QueueSize4);
            this.panel1.Controls.Add(this.QueueSize2);
            this.panel1.Location = new System.Drawing.Point(83, 279);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 23);
            this.panel1.TabIndex = 72;
            // 
            // Queue
            // 
            this.Queue.Enabled = false;
            this.Queue.Location = new System.Drawing.Point(192, 3);
            this.Queue.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.Queue.Name = "Queue";
            this.Queue.Size = new System.Drawing.Size(97, 20);
            this.Queue.TabIndex = 95;
            this.Queue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // QueueSize1
            // 
            this.QueueSize1.AutoSize = true;
            this.QueueSize1.Checked = true;
            this.QueueSize1.Location = new System.Drawing.Point(9, 3);
            this.QueueSize1.Name = "QueueSize1";
            this.QueueSize1.Size = new System.Drawing.Size(31, 17);
            this.QueueSize1.TabIndex = 25;
            this.QueueSize1.TabStop = true;
            this.QueueSize1.Tag = "Queue";
            this.QueueSize1.Text = "8";
            this.QueueSize1.UseVisualStyleBackColor = true;
            this.QueueSize1.CheckedChanged += new System.EventHandler(this.QueueSize_CheckedChanged);
            // 
            // QueueSize3
            // 
            this.QueueSize3.AutoSize = true;
            this.QueueSize3.Location = new System.Drawing.Point(89, 3);
            this.QueueSize3.Name = "QueueSize3";
            this.QueueSize3.Size = new System.Drawing.Size(37, 17);
            this.QueueSize3.TabIndex = 27;
            this.QueueSize3.Tag = "Queue";
            this.QueueSize3.Text = "24";
            this.QueueSize3.UseVisualStyleBackColor = true;
            this.QueueSize3.CheckedChanged += new System.EventHandler(this.QueueSize_CheckedChanged);
            // 
            // QueueSize4
            // 
            this.QueueSize4.AutoSize = true;
            this.QueueSize4.Location = new System.Drawing.Point(132, 3);
            this.QueueSize4.Name = "QueueSize4";
            this.QueueSize4.Size = new System.Drawing.Size(54, 17);
            this.QueueSize4.TabIndex = 28;
            this.QueueSize4.Tag = "Queue";
            this.QueueSize4.Text = "Other:";
            this.QueueSize4.UseVisualStyleBackColor = true;
            this.QueueSize4.CheckedChanged += new System.EventHandler(this.QueueSize_CheckedChanged);
            // 
            // QueueSize2
            // 
            this.QueueSize2.AutoSize = true;
            this.QueueSize2.Location = new System.Drawing.Point(46, 3);
            this.QueueSize2.Name = "QueueSize2";
            this.QueueSize2.Size = new System.Drawing.Size(37, 17);
            this.QueueSize2.TabIndex = 26;
            this.QueueSize2.Tag = "Queue";
            this.QueueSize2.Text = "16";
            this.QueueSize2.UseVisualStyleBackColor = true;
            this.QueueSize2.CheckedChanged += new System.EventHandler(this.QueueSize_CheckedChanged);
            // 
            // PasswordSel
            // 
            this.PasswordSel.Location = new System.Drawing.Point(92, 253);
            this.PasswordSel.MaxLength = 50;
            this.PasswordSel.Name = "PasswordSel";
            this.PasswordSel.Size = new System.Drawing.Size(280, 20);
            this.PasswordSel.TabIndex = 71;
            // 
            // QueueDesc
            // 
            this.QueueDesc.AutoSize = true;
            this.QueueDesc.Location = new System.Drawing.Point(12, 282);
            this.QueueDesc.Name = "QueueDesc";
            this.QueueDesc.Size = new System.Drawing.Size(65, 13);
            this.QueueDesc.TabIndex = 70;
            this.QueueDesc.Text = "Queue Size:";
            // 
            // PasswordDesc
            // 
            this.PasswordDesc.AutoSize = true;
            this.PasswordDesc.Location = new System.Drawing.Point(12, 256);
            this.PasswordDesc.Name = "PasswordDesc";
            this.PasswordDesc.Size = new System.Drawing.Size(56, 13);
            this.PasswordDesc.TabIndex = 69;
            this.PasswordDesc.Text = "Password:";
            // 
            // CheatsDesc
            // 
            this.CheatsDesc.AutoSize = true;
            this.CheatsDesc.Location = new System.Drawing.Point(12, 229);
            this.CheatsDesc.Name = "CheatsDesc";
            this.CheatsDesc.Size = new System.Drawing.Size(43, 13);
            this.CheatsDesc.TabIndex = 67;
            this.CheatsDesc.Text = "Cheats:";
            // 
            // DifficultyDesc
            // 
            this.DifficultyDesc.AutoSize = true;
            this.DifficultyDesc.Location = new System.Drawing.Point(12, 175);
            this.DifficultyDesc.Name = "DifficultyDesc";
            this.DifficultyDesc.Size = new System.Drawing.Size(50, 13);
            this.DifficultyDesc.TabIndex = 65;
            this.DifficultyDesc.Text = "Difficulty:";
            // 
            // MapDesc
            // 
            this.MapDesc.AutoSize = true;
            this.MapDesc.Location = new System.Drawing.Point(12, 149);
            this.MapDesc.Name = "MapDesc";
            this.MapDesc.Size = new System.Drawing.Size(65, 13);
            this.MapDesc.TabIndex = 63;
            this.MapDesc.Text = "Server Map:";
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(291, 551);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(81, 23);
            this.Exit.TabIndex = 62;
            this.Exit.Text = "Save and Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MaxDesc
            // 
            this.MaxDesc.AutoSize = true;
            this.MaxDesc.Location = new System.Drawing.Point(12, 122);
            this.MaxDesc.Name = "MaxDesc";
            this.MaxDesc.Size = new System.Drawing.Size(67, 13);
            this.MaxDesc.TabIndex = 61;
            this.MaxDesc.Text = "Max Players:";
            // 
            // FirstDesc
            // 
            this.FirstDesc.AutoSize = true;
            this.FirstDesc.Location = new System.Drawing.Point(12, 97);
            this.FirstDesc.Name = "FirstDesc";
            this.FirstDesc.Size = new System.Drawing.Size(66, 13);
            this.FirstDesc.TabIndex = 59;
            this.FirstDesc.Text = "Perspective:";
            // 
            // PvPDesc
            // 
            this.PvPDesc.AutoSize = true;
            this.PvPDesc.Location = new System.Drawing.Point(12, 71);
            this.PvPDesc.Name = "PvPDesc";
            this.PvPDesc.Size = new System.Drawing.Size(30, 13);
            this.PvPDesc.TabIndex = 58;
            this.PvPDesc.Text = "PvP:";
            // 
            // PortDesc
            // 
            this.PortDesc.AutoSize = true;
            this.PortDesc.Location = new System.Drawing.Point(12, 44);
            this.PortDesc.Name = "PortDesc";
            this.PortDesc.Size = new System.Drawing.Size(63, 13);
            this.PortDesc.TabIndex = 55;
            this.PortDesc.Text = "Server Port:";
            // 
            // NameSel
            // 
            this.NameSel.Location = new System.Drawing.Point(92, 11);
            this.NameSel.MaxLength = 50;
            this.NameSel.Name = "NameSel";
            this.NameSel.Size = new System.Drawing.Size(280, 20);
            this.NameSel.TabIndex = 54;
            this.NameSel.Text = "Test Server";
            // 
            // NameDesc
            // 
            this.NameDesc.AutoSize = true;
            this.NameDesc.Location = new System.Drawing.Point(12, 14);
            this.NameDesc.Name = "NameDesc";
            this.NameDesc.Size = new System.Drawing.Size(72, 13);
            this.NameDesc.TabIndex = 53;
            this.NameDesc.Text = "Server Name:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.PvPOff);
            this.panel6.Controls.Add(this.PvPOn);
            this.panel6.Location = new System.Drawing.Point(83, 67);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(289, 23);
            this.panel6.TabIndex = 79;
            // 
            // PvPOff
            // 
            this.PvPOff.AutoSize = true;
            this.PvPOff.Location = new System.Drawing.Point(9, 3);
            this.PvPOff.Name = "PvPOff";
            this.PvPOff.Size = new System.Drawing.Size(66, 17);
            this.PvPOff.TabIndex = 25;
            this.PvPOff.Tag = "Queue";
            this.PvPOff.Text = "Disabled";
            this.PvPOff.UseVisualStyleBackColor = true;
            // 
            // PvPOn
            // 
            this.PvPOn.AutoSize = true;
            this.PvPOn.Checked = true;
            this.PvPOn.Location = new System.Drawing.Point(222, 3);
            this.PvPOn.Name = "PvPOn";
            this.PvPOn.Size = new System.Drawing.Size(64, 17);
            this.PvPOn.TabIndex = 28;
            this.PvPOn.TabStop = true;
            this.PvPOn.Tag = "Queue";
            this.PvPOn.Text = "Enabled";
            this.PvPOn.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.PerspFirstPer);
            this.panel7.Controls.Add(this.PerspBoth);
            this.panel7.Location = new System.Drawing.Point(83, 93);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(289, 23);
            this.panel7.TabIndex = 80;
            // 
            // PerspFirstPer
            // 
            this.PerspFirstPer.AutoSize = true;
            this.PerspFirstPer.Location = new System.Drawing.Point(9, 3);
            this.PerspFirstPer.Name = "PerspFirstPer";
            this.PerspFirstPer.Size = new System.Drawing.Size(80, 17);
            this.PerspFirstPer.TabIndex = 25;
            this.PerspFirstPer.Tag = "Queue";
            this.PerspFirstPer.Text = "First Person";
            this.PerspFirstPer.UseVisualStyleBackColor = true;
            // 
            // PerspBoth
            // 
            this.PerspBoth.AutoSize = true;
            this.PerspBoth.Checked = true;
            this.PerspBoth.Location = new System.Drawing.Point(239, 3);
            this.PerspBoth.Name = "PerspBoth";
            this.PerspBoth.Size = new System.Drawing.Size(47, 17);
            this.PerspBoth.TabIndex = 28;
            this.PerspBoth.TabStop = true;
            this.PerspBoth.Tag = "Queue";
            this.PerspBoth.Text = "Both";
            this.PerspBoth.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.DiffNormal);
            this.panel8.Controls.Add(this.DiffEasy);
            this.panel8.Controls.Add(this.DiffHard);
            this.panel8.Location = new System.Drawing.Point(83, 171);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(289, 23);
            this.panel8.TabIndex = 81;
            // 
            // DiffNormal
            // 
            this.DiffNormal.AutoSize = true;
            this.DiffNormal.Checked = true;
            this.DiffNormal.Location = new System.Drawing.Point(110, 4);
            this.DiffNormal.Name = "DiffNormal";
            this.DiffNormal.Size = new System.Drawing.Size(58, 17);
            this.DiffNormal.TabIndex = 29;
            this.DiffNormal.TabStop = true;
            this.DiffNormal.Tag = "Queue";
            this.DiffNormal.Text = "Normal";
            this.DiffNormal.UseVisualStyleBackColor = true;
            // 
            // DiffEasy
            // 
            this.DiffEasy.AutoSize = true;
            this.DiffEasy.Location = new System.Drawing.Point(9, 3);
            this.DiffEasy.Name = "DiffEasy";
            this.DiffEasy.Size = new System.Drawing.Size(48, 17);
            this.DiffEasy.TabIndex = 25;
            this.DiffEasy.Tag = "Queue";
            this.DiffEasy.Text = "Easy";
            this.DiffEasy.UseVisualStyleBackColor = true;
            // 
            // DiffHard
            // 
            this.DiffHard.AutoSize = true;
            this.DiffHard.Location = new System.Drawing.Point(239, 3);
            this.DiffHard.Name = "DiffHard";
            this.DiffHard.Size = new System.Drawing.Size(48, 17);
            this.DiffHard.TabIndex = 28;
            this.DiffHard.Tag = "Queue";
            this.DiffHard.Text = "Hard";
            this.DiffHard.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.CheatsOff);
            this.panel9.Controls.Add(this.CheatsOn);
            this.panel9.Location = new System.Drawing.Point(83, 226);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(289, 23);
            this.panel9.TabIndex = 79;
            // 
            // CheatsOff
            // 
            this.CheatsOff.AutoSize = true;
            this.CheatsOff.Checked = true;
            this.CheatsOff.Location = new System.Drawing.Point(9, 3);
            this.CheatsOff.Name = "CheatsOff";
            this.CheatsOff.Size = new System.Drawing.Size(66, 17);
            this.CheatsOff.TabIndex = 25;
            this.CheatsOff.TabStop = true;
            this.CheatsOff.Tag = "Queue";
            this.CheatsOff.Text = "Disabled";
            this.CheatsOff.UseVisualStyleBackColor = true;
            // 
            // CheatsOn
            // 
            this.CheatsOn.AutoSize = true;
            this.CheatsOn.Location = new System.Drawing.Point(222, 3);
            this.CheatsOn.Name = "CheatsOn";
            this.CheatsOn.Size = new System.Drawing.Size(64, 17);
            this.CheatsOn.TabIndex = 28;
            this.CheatsOn.Tag = "Queue";
            this.CheatsOn.Text = "Enabled";
            this.CheatsOn.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.SyncOff);
            this.panel10.Controls.Add(this.SyncOn);
            this.panel10.Location = new System.Drawing.Point(83, 360);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(289, 23);
            this.panel10.TabIndex = 80;
            // 
            // SyncOff
            // 
            this.SyncOff.AutoSize = true;
            this.SyncOff.Checked = true;
            this.SyncOff.Location = new System.Drawing.Point(9, 3);
            this.SyncOff.Name = "SyncOff";
            this.SyncOff.Size = new System.Drawing.Size(66, 17);
            this.SyncOff.TabIndex = 25;
            this.SyncOff.TabStop = true;
            this.SyncOff.Tag = "Queue";
            this.SyncOff.Text = "Disabled";
            this.SyncOff.UseVisualStyleBackColor = true;
            // 
            // SyncOn
            // 
            this.SyncOn.AutoSize = true;
            this.SyncOn.Location = new System.Drawing.Point(222, 3);
            this.SyncOn.Name = "SyncOn";
            this.SyncOn.Size = new System.Drawing.Size(64, 17);
            this.SyncOn.TabIndex = 28;
            this.SyncOn.Tag = "Queue";
            this.SyncOn.Text = "Enabled";
            this.SyncOn.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.HideAdFalse);
            this.panel11.Controls.Add(this.HideAdTrue);
            this.panel11.Location = new System.Drawing.Point(83, 413);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(289, 23);
            this.panel11.TabIndex = 80;
            // 
            // HideAdFalse
            // 
            this.HideAdFalse.AutoSize = true;
            this.HideAdFalse.Checked = true;
            this.HideAdFalse.Location = new System.Drawing.Point(9, 3);
            this.HideAdFalse.Name = "HideAdFalse";
            this.HideAdFalse.Size = new System.Drawing.Size(66, 17);
            this.HideAdFalse.TabIndex = 25;
            this.HideAdFalse.TabStop = true;
            this.HideAdFalse.Tag = "Queue";
            this.HideAdFalse.Text = "Disabled";
            this.HideAdFalse.UseVisualStyleBackColor = true;
            // 
            // HideAdTrue
            // 
            this.HideAdTrue.AutoSize = true;
            this.HideAdTrue.Location = new System.Drawing.Point(222, 3);
            this.HideAdTrue.Name = "HideAdTrue";
            this.HideAdTrue.Size = new System.Drawing.Size(64, 17);
            this.HideAdTrue.TabIndex = 28;
            this.HideAdTrue.Tag = "Queue";
            this.HideAdTrue.Text = "Enabled";
            this.HideAdTrue.UseVisualStyleBackColor = true;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.FilterOff);
            this.panel12.Controls.Add(this.FilterOn);
            this.panel12.Location = new System.Drawing.Point(83, 464);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(289, 23);
            this.panel12.TabIndex = 80;
            // 
            // FilterOff
            // 
            this.FilterOff.AutoSize = true;
            this.FilterOff.Checked = true;
            this.FilterOff.Location = new System.Drawing.Point(9, 3);
            this.FilterOff.Name = "FilterOff";
            this.FilterOff.Size = new System.Drawing.Size(66, 17);
            this.FilterOff.TabIndex = 25;
            this.FilterOff.TabStop = true;
            this.FilterOff.Tag = "Queue";
            this.FilterOff.Text = "Disabled";
            this.FilterOff.UseVisualStyleBackColor = true;
            // 
            // FilterOn
            // 
            this.FilterOn.AutoSize = true;
            this.FilterOn.Location = new System.Drawing.Point(222, 3);
            this.FilterOn.Name = "FilterOn";
            this.FilterOn.Size = new System.Drawing.Size(64, 17);
            this.FilterOn.TabIndex = 28;
            this.FilterOn.Tag = "Queue";
            this.FilterOn.Text = "Enabled";
            this.FilterOn.UseVisualStyleBackColor = true;
            // 
            // OwnerID
            // 
            this.OwnerID.Location = new System.Drawing.Point(92, 309);
            this.OwnerID.Maximum = new decimal(new int[] {
            -1,
            17825793,
            0,
            0});
            this.OwnerID.Minimum = new decimal(new int[] {
            0,
            17825793,
            0,
            0});
            this.OwnerID.Name = "OwnerID";
            this.OwnerID.Size = new System.Drawing.Size(280, 20);
            this.OwnerID.TabIndex = 94;
            this.OwnerID.Value = new decimal(new int[] {
            0,
            17825793,
            0,
            0});
            // 
            // IPField4
            // 
            this.IPField4.Location = new System.Drawing.Point(330, 442);
            this.IPField4.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.IPField4.Name = "IPField4";
            this.IPField4.Size = new System.Drawing.Size(42, 20);
            this.IPField4.TabIndex = 95;
            // 
            // IPField3
            // 
            this.IPField3.Location = new System.Drawing.Point(266, 442);
            this.IPField3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.IPField3.Name = "IPField3";
            this.IPField3.Size = new System.Drawing.Size(42, 20);
            this.IPField3.TabIndex = 96;
            // 
            // IPField2
            // 
            this.IPField2.Location = new System.Drawing.Point(202, 442);
            this.IPField2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.IPField2.Name = "IPField2";
            this.IPField2.Size = new System.Drawing.Size(42, 20);
            this.IPField2.TabIndex = 97;
            // 
            // IPField1
            // 
            this.IPField1.Location = new System.Drawing.Point(138, 442);
            this.IPField1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.IPField1.Name = "IPField1";
            this.IPField1.Size = new System.Drawing.Size(42, 20);
            this.IPField1.TabIndex = 98;
            // 
            // IPDot1
            // 
            this.IPDot1.AutoSize = true;
            this.IPDot1.Location = new System.Drawing.Point(186, 444);
            this.IPDot1.Name = "IPDot1";
            this.IPDot1.Size = new System.Drawing.Size(10, 13);
            this.IPDot1.TabIndex = 99;
            this.IPDot1.Text = ".";
            // 
            // IPDot3
            // 
            this.IPDot3.AutoSize = true;
            this.IPDot3.Location = new System.Drawing.Point(314, 444);
            this.IPDot3.Name = "IPDot3";
            this.IPDot3.Size = new System.Drawing.Size(10, 13);
            this.IPDot3.TabIndex = 100;
            this.IPDot3.Text = ".";
            // 
            // IPDot2
            // 
            this.IPDot2.AutoSize = true;
            this.IPDot2.Location = new System.Drawing.Point(250, 444);
            this.IPDot2.Name = "IPDot2";
            this.IPDot2.Size = new System.Drawing.Size(10, 13);
            this.IPDot2.TabIndex = 101;
            this.IPDot2.Text = ".";
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(92, 37);
            this.Port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(280, 20);
            this.Port.TabIndex = 102;
            this.Port.Value = new decimal(new int[] {
            27015,
            0,
            0,
            0});
            // 
            // Maps
            // 
            this.Maps.FormattingEnabled = true;
            this.Maps.Location = new System.Drawing.Point(92, 146);
            this.Maps.Name = "Maps";
            this.Maps.Size = new System.Drawing.Size(280, 21);
            this.Maps.TabIndex = 103;
            // 
            // btn_config
            // 
            this.btn_config.Location = new System.Drawing.Point(42, 551);
            this.btn_config.Name = "btn_config";
            this.btn_config.Size = new System.Drawing.Size(81, 23);
            this.btn_config.TabIndex = 104;
            this.btn_config.Text = "Open Config";
            this.btn_config.UseVisualStyleBackColor = true;
            this.btn_config.Click += new System.EventHandler(this.btn_config_Click);
            // 
            // ConstConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(384, 585);
            this.Controls.Add(this.btn_config);
            this.Controls.Add(this.Maps);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.IPDot2);
            this.Controls.Add(this.IPDot3);
            this.Controls.Add(this.IPDot1);
            this.Controls.Add(this.IPField1);
            this.Controls.Add(this.IPField2);
            this.Controls.Add(this.IPField3);
            this.Controls.Add(this.IPField4);
            this.Controls.Add(this.OwnerID);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.GoldDesc);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.RateDesc);
            this.Controls.Add(this.CycleDesc);
            this.Controls.Add(this.FilterDesc);
            this.Controls.Add(this.IPDesc);
            this.Controls.Add(this.HideDesc);
            this.Controls.Add(this.LoadoutSel);
            this.Controls.Add(this.LoadoutDesc);
            this.Controls.Add(this.SyncDesc);
            this.Controls.Add(this.MessageSel);
            this.Controls.Add(this.MessageDesc);
            this.Controls.Add(this.OwnerDesc);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PasswordSel);
            this.Controls.Add(this.QueueDesc);
            this.Controls.Add(this.PasswordDesc);
            this.Controls.Add(this.CheatsDesc);
            this.Controls.Add(this.DifficultyDesc);
            this.Controls.Add(this.MapDesc);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.MaxDesc);
            this.Controls.Add(this.FirstDesc);
            this.Controls.Add(this.PvPDesc);
            this.Controls.Add(this.PortDesc);
            this.Controls.Add(this.NameSel);
            this.Controls.Add(this.NameDesc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConstConfig";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server\'s Settings";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChatRate)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cycle)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxPlayers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Queue)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OwnerID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IPField4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IPField3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IPField2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IPField1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RadioButton Rate2;
        private RadioButton Cycle1;
        private RadioButton Cycle2;
        private RadioButton Rate1;
        private Panel panel5;
        private RadioButton GoldFalse;
        private RadioButton GoldTrue;
        private Label GoldDesc;
        private Panel panel4;
        private Panel panel3;
        private Label RateDesc;
        private Label CycleDesc;
        private Label FilterDesc;
        private Label IPDesc;
        private Label HideDesc;
        private TextBox LoadoutSel;
        private Label LoadoutDesc;
        private Label SyncDesc;
        private TextBox MessageSel;
        private Label MessageDesc;
        private Label OwnerDesc;
        private Panel panel2;
        private RadioButton MaxPlayersVal4;
        private RadioButton MaxPlayersVal1;
        private RadioButton MaxPlayersVal2;
        private RadioButton MaxPlayersVal3;
        private Panel panel1;
        private RadioButton QueueSize1;
        private RadioButton QueueSize3;
        private RadioButton QueueSize4;
        private RadioButton QueueSize2;
        private TextBox PasswordSel;
        private Label QueueDesc;
        private Label PasswordDesc;
        private Label CheatsDesc;
        private Label DifficultyDesc;
        private Label MapDesc;
        private Button Exit;
        private Label MaxDesc;
        private Label FirstDesc;
        private Label PvPDesc;
        private Label PortDesc;
        private TextBox NameSel;
        private Label NameDesc;
        private Panel panel6;
        private RadioButton PvPOff;
        private RadioButton PvPOn;
        private Panel panel7;
        private RadioButton PerspFirstPer;
        private RadioButton PerspBoth;
        private Panel panel8;
        private RadioButton DiffNormal;
        private RadioButton DiffEasy;
        private RadioButton DiffHard;
        private Panel panel9;
        private RadioButton CheatsOff;
        private RadioButton CheatsOn;
        private Panel panel10;
        private RadioButton SyncOff;
        private RadioButton SyncOn;
        private Panel panel11;
        private RadioButton HideAdFalse;
        private RadioButton HideAdTrue;
        private Panel panel12;
        private RadioButton FilterOff;
        private RadioButton FilterOn;
        private NumericUpDown OwnerID;
        private NumericUpDown ChatRate;
        private NumericUpDown Cycle;
        private NumericUpDown Queue;
        private NumericUpDown IPField4;
        private NumericUpDown IPField3;
        private NumericUpDown IPField2;
        private NumericUpDown IPField1;
        private Label IPDot1;
        private Label IPDot3;
        private Label IPDot2;
        private NumericUpDown MaxPlayers;
        private NumericUpDown Port;
        private ComboBox Maps;
        private Button btn_config;
    }
}