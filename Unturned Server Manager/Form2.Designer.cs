namespace Unturned_Server_Manager
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.NameDesc = new System.Windows.Forms.Label();
            this.NameSel = new System.Windows.Forms.TextBox();
            this.PortDesc = new System.Windows.Forms.Label();
            this.PortSel = new System.Windows.Forms.TextBox();
            this.PvPValue = new System.Windows.Forms.ComboBox();
            this.PvPDesc = new System.Windows.Forms.Label();
            this.FirstDesc = new System.Windows.Forms.Label();
            this.FirstPerson = new System.Windows.Forms.ComboBox();
            this.MaxDesc = new System.Windows.Forms.Label();
            this.MaxPlayersVal1 = new System.Windows.Forms.RadioButton();
            this.MaxPlayersVal2 = new System.Windows.Forms.RadioButton();
            this.MaxPlayersVal3 = new System.Windows.Forms.RadioButton();
            this.MaxPlayersVal4 = new System.Windows.Forms.RadioButton();
            this.Exit = new System.Windows.Forms.Button();
            this.MapDesc = new System.Windows.Forms.Label();
            this.MapSel = new System.Windows.Forms.TextBox();
            this.DifficultyDesc = new System.Windows.Forms.Label();
            this.DiffSel = new System.Windows.Forms.ComboBox();
            this.CheatsDesc = new System.Windows.Forms.Label();
            this.CheatsSel = new System.Windows.Forms.ComboBox();
            this.PasswordDesc = new System.Windows.Forms.Label();
            this.QueueDesc = new System.Windows.Forms.Label();
            this.QueueSize1 = new System.Windows.Forms.RadioButton();
            this.QueueSize2 = new System.Windows.Forms.RadioButton();
            this.QueueSize3 = new System.Windows.Forms.RadioButton();
            this.QueueSize4 = new System.Windows.Forms.RadioButton();
            this.PasswordSel = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.QueueSizeCustom = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MaxPlayersCustom = new System.Windows.Forms.TextBox();
            this.OwnerDesc = new System.Windows.Forms.Label();
            this.OwnerSel = new System.Windows.Forms.TextBox();
            this.MessageDesc = new System.Windows.Forms.Label();
            this.MessageSel = new System.Windows.Forms.TextBox();
            this.SyncSel = new System.Windows.Forms.ComboBox();
            this.SyncDesc = new System.Windows.Forms.Label();
            this.LoadoutDesc = new System.Windows.Forms.Label();
            this.LoadoutSel = new System.Windows.Forms.TextBox();
            this.HideSel = new System.Windows.Forms.ComboBox();
            this.HideDesc = new System.Windows.Forms.Label();
            this.IPDesc = new System.Windows.Forms.Label();
            this.IPSel = new System.Windows.Forms.TextBox();
            this.FilterDesc = new System.Windows.Forms.Label();
            this.CycleDesc = new System.Windows.Forms.Label();
            this.RateDesc = new System.Windows.Forms.Label();
            this.FilterSel = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CycleCustom = new System.Windows.Forms.TextBox();
            this.Cycle1 = new System.Windows.Forms.RadioButton();
            this.Cycle2 = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.RateCustom = new System.Windows.Forms.TextBox();
            this.Rate1 = new System.Windows.Forms.RadioButton();
            this.Rate2 = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameDesc
            // 
            this.NameDesc.AutoSize = true;
            this.NameDesc.Location = new System.Drawing.Point(12, 13);
            this.NameDesc.Name = "NameDesc";
            this.NameDesc.Size = new System.Drawing.Size(72, 13);
            this.NameDesc.TabIndex = 0;
            this.NameDesc.Text = "Server Name:";
            // 
            // NameSel
            // 
            this.NameSel.Location = new System.Drawing.Point(92, 10);
            this.NameSel.MaxLength = 50;
            this.NameSel.Name = "NameSel";
            this.NameSel.Size = new System.Drawing.Size(280, 20);
            this.NameSel.TabIndex = 1;
            this.NameSel.Text = "Test Server";
            // 
            // PortDesc
            // 
            this.PortDesc.AutoSize = true;
            this.PortDesc.Location = new System.Drawing.Point(12, 43);
            this.PortDesc.Name = "PortDesc";
            this.PortDesc.Size = new System.Drawing.Size(63, 13);
            this.PortDesc.TabIndex = 2;
            this.PortDesc.Text = "Server Port:";
            // 
            // PortSel
            // 
            this.PortSel.Location = new System.Drawing.Point(92, 40);
            this.PortSel.MaxLength = 5;
            this.PortSel.Name = "PortSel";
            this.PortSel.Size = new System.Drawing.Size(280, 20);
            this.PortSel.TabIndex = 3;
            this.PortSel.Text = "27015";
            // 
            // PvPValue
            // 
            this.PvPValue.FormattingEnabled = true;
            this.PvPValue.Items.AddRange(new object[] {
            "On",
            "Off"});
            this.PvPValue.Location = new System.Drawing.Point(92, 67);
            this.PvPValue.Name = "PvPValue";
            this.PvPValue.Size = new System.Drawing.Size(280, 21);
            this.PvPValue.TabIndex = 4;
            this.PvPValue.Text = "On";
            this.PvPValue.DropDown += new System.EventHandler(this.PvPValue_DropDown);
            this.PvPValue.SelectedIndexChanged += new System.EventHandler(this.PvPValue_SelectedIndexChanged);
            // 
            // PvPDesc
            // 
            this.PvPDesc.AutoSize = true;
            this.PvPDesc.Location = new System.Drawing.Point(12, 70);
            this.PvPDesc.Name = "PvPDesc";
            this.PvPDesc.Size = new System.Drawing.Size(30, 13);
            this.PvPDesc.TabIndex = 5;
            this.PvPDesc.Text = "PvP:";
            // 
            // FirstDesc
            // 
            this.FirstDesc.AutoSize = true;
            this.FirstDesc.Location = new System.Drawing.Point(12, 96);
            this.FirstDesc.Name = "FirstDesc";
            this.FirstDesc.Size = new System.Drawing.Size(66, 13);
            this.FirstDesc.TabIndex = 6;
            this.FirstDesc.Text = "Perspective:";
            // 
            // FirstPerson
            // 
            this.FirstPerson.FormattingEnabled = true;
            this.FirstPerson.Items.AddRange(new object[] {
            "First Person Only",
            "Both"});
            this.FirstPerson.Location = new System.Drawing.Point(92, 93);
            this.FirstPerson.Name = "FirstPerson";
            this.FirstPerson.Size = new System.Drawing.Size(280, 21);
            this.FirstPerson.TabIndex = 7;
            this.FirstPerson.Text = "Both";
            this.FirstPerson.DropDown += new System.EventHandler(this.FirstPerson_DropDown);
            this.FirstPerson.SelectedIndexChanged += new System.EventHandler(this.FirstPerson_SelectedIndexChanged);
            // 
            // MaxDesc
            // 
            this.MaxDesc.AutoSize = true;
            this.MaxDesc.Location = new System.Drawing.Point(12, 121);
            this.MaxDesc.Name = "MaxDesc";
            this.MaxDesc.Size = new System.Drawing.Size(67, 13);
            this.MaxDesc.TabIndex = 8;
            this.MaxDesc.Text = "Max Players:";
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
            this.MaxPlayersVal1.CheckedChanged += new System.EventHandler(this.MaxPlayersVal1_CheckedChanged);
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
            this.MaxPlayersVal2.CheckedChanged += new System.EventHandler(this.MaxPlayersVal2_CheckedChanged);
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
            this.MaxPlayersVal3.CheckedChanged += new System.EventHandler(this.MaxPlayersVal3_CheckedChanged);
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
            this.MaxPlayersVal4.CheckedChanged += new System.EventHandler(this.MaxPlayers4_CheckedChanged);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(291, 523);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(81, 23);
            this.Exit.TabIndex = 14;
            this.Exit.Text = "Save and Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // MapDesc
            // 
            this.MapDesc.AutoSize = true;
            this.MapDesc.Location = new System.Drawing.Point(12, 148);
            this.MapDesc.Name = "MapDesc";
            this.MapDesc.Size = new System.Drawing.Size(65, 13);
            this.MapDesc.TabIndex = 15;
            this.MapDesc.Text = "Server Map:";
            // 
            // MapSel
            // 
            this.MapSel.Location = new System.Drawing.Point(92, 145);
            this.MapSel.Name = "MapSel";
            this.MapSel.Size = new System.Drawing.Size(280, 20);
            this.MapSel.TabIndex = 16;
            this.MapSel.Text = "Washington";
            // 
            // DifficultyDesc
            // 
            this.DifficultyDesc.AutoSize = true;
            this.DifficultyDesc.Location = new System.Drawing.Point(12, 174);
            this.DifficultyDesc.Name = "DifficultyDesc";
            this.DifficultyDesc.Size = new System.Drawing.Size(50, 13);
            this.DifficultyDesc.TabIndex = 17;
            this.DifficultyDesc.Text = "Difficulty:";
            // 
            // DiffSel
            // 
            this.DiffSel.FormattingEnabled = true;
            this.DiffSel.Items.AddRange(new object[] {
            "Easy",
            "Normal",
            "Hard",
            "Gold"});
            this.DiffSel.Location = new System.Drawing.Point(92, 171);
            this.DiffSel.Name = "DiffSel";
            this.DiffSel.Size = new System.Drawing.Size(280, 21);
            this.DiffSel.TabIndex = 18;
            this.DiffSel.Text = "Normal";
            this.DiffSel.DropDown += new System.EventHandler(this.DiffSel_DropDown);
            this.DiffSel.SelectedIndexChanged += new System.EventHandler(this.DiffSel_SelectedIndexChanged);
            // 
            // CheatsDesc
            // 
            this.CheatsDesc.AutoSize = true;
            this.CheatsDesc.Location = new System.Drawing.Point(12, 201);
            this.CheatsDesc.Name = "CheatsDesc";
            this.CheatsDesc.Size = new System.Drawing.Size(43, 13);
            this.CheatsDesc.TabIndex = 19;
            this.CheatsDesc.Text = "Cheats:";
            // 
            // CheatsSel
            // 
            this.CheatsSel.FormattingEnabled = true;
            this.CheatsSel.Items.AddRange(new object[] {
            "Off",
            "On"});
            this.CheatsSel.Location = new System.Drawing.Point(92, 198);
            this.CheatsSel.Name = "CheatsSel";
            this.CheatsSel.Size = new System.Drawing.Size(280, 21);
            this.CheatsSel.TabIndex = 20;
            this.CheatsSel.Text = "Off";
            this.CheatsSel.DropDown += new System.EventHandler(this.CheatsSel_DropDown);
            this.CheatsSel.SelectedIndexChanged += new System.EventHandler(this.CheatsSel_SelectedIndexChanged);
            // 
            // PasswordDesc
            // 
            this.PasswordDesc.AutoSize = true;
            this.PasswordDesc.Location = new System.Drawing.Point(12, 228);
            this.PasswordDesc.Name = "PasswordDesc";
            this.PasswordDesc.Size = new System.Drawing.Size(56, 13);
            this.PasswordDesc.TabIndex = 22;
            this.PasswordDesc.Text = "Password:";
            // 
            // QueueDesc
            // 
            this.QueueDesc.AutoSize = true;
            this.QueueDesc.Location = new System.Drawing.Point(12, 254);
            this.QueueDesc.Name = "QueueDesc";
            this.QueueDesc.Size = new System.Drawing.Size(65, 13);
            this.QueueDesc.TabIndex = 24;
            this.QueueDesc.Text = "Queue Size:";
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
            this.QueueSize1.CheckedChanged += new System.EventHandler(this.QueueSize1_CheckedChanged);
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
            this.QueueSize2.CheckedChanged += new System.EventHandler(this.QueueSize2_CheckedChanged);
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
            this.QueueSize3.CheckedChanged += new System.EventHandler(this.QueueSize3_CheckedChanged);
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
            this.QueueSize4.CheckedChanged += new System.EventHandler(this.QueueSize4_CheckedChanged);
            // 
            // PasswordSel
            // 
            this.PasswordSel.Location = new System.Drawing.Point(92, 225);
            this.PasswordSel.MaxLength = 50;
            this.PasswordSel.Name = "PasswordSel";
            this.PasswordSel.Size = new System.Drawing.Size(280, 20);
            this.PasswordSel.TabIndex = 31;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.QueueSizeCustom);
            this.panel1.Controls.Add(this.QueueSize1);
            this.panel1.Controls.Add(this.QueueSize3);
            this.panel1.Controls.Add(this.QueueSize4);
            this.panel1.Controls.Add(this.QueueSize2);
            this.panel1.Location = new System.Drawing.Point(83, 251);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 23);
            this.panel1.TabIndex = 32;
            // 
            // QueueSizeCustom
            // 
            this.QueueSizeCustom.Location = new System.Drawing.Point(186, 2);
            this.QueueSizeCustom.MaxLength = 3;
            this.QueueSizeCustom.Name = "QueueSizeCustom";
            this.QueueSizeCustom.ReadOnly = true;
            this.QueueSizeCustom.Size = new System.Drawing.Size(103, 20);
            this.QueueSizeCustom.TabIndex = 29;
            this.QueueSizeCustom.Text = "1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.MaxPlayersCustom);
            this.panel2.Controls.Add(this.MaxPlayersVal4);
            this.panel2.Controls.Add(this.MaxPlayersVal1);
            this.panel2.Controls.Add(this.MaxPlayersVal2);
            this.panel2.Controls.Add(this.MaxPlayersVal3);
            this.panel2.Location = new System.Drawing.Point(83, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 23);
            this.panel2.TabIndex = 33;
            // 
            // MaxPlayersCustom
            // 
            this.MaxPlayersCustom.Location = new System.Drawing.Point(186, 2);
            this.MaxPlayersCustom.MaxLength = 3;
            this.MaxPlayersCustom.Name = "MaxPlayersCustom";
            this.MaxPlayersCustom.ReadOnly = true;
            this.MaxPlayersCustom.Size = new System.Drawing.Size(103, 20);
            this.MaxPlayersCustom.TabIndex = 34;
            this.MaxPlayersCustom.Text = "23";
            // 
            // OwnerDesc
            // 
            this.OwnerDesc.AutoSize = true;
            this.OwnerDesc.Location = new System.Drawing.Point(12, 283);
            this.OwnerDesc.Name = "OwnerDesc";
            this.OwnerDesc.Size = new System.Drawing.Size(41, 13);
            this.OwnerDesc.TabIndex = 34;
            this.OwnerDesc.Text = "Owner:";
            // 
            // OwnerSel
            // 
            this.OwnerSel.Location = new System.Drawing.Point(92, 280);
            this.OwnerSel.MaxLength = 17;
            this.OwnerSel.Name = "OwnerSel";
            this.OwnerSel.Size = new System.Drawing.Size(280, 20);
            this.OwnerSel.TabIndex = 35;
            // 
            // MessageDesc
            // 
            this.MessageDesc.AutoSize = true;
            this.MessageDesc.Location = new System.Drawing.Point(12, 309);
            this.MessageDesc.Name = "MessageDesc";
            this.MessageDesc.Size = new System.Drawing.Size(82, 13);
            this.MessageDesc.TabIndex = 36;
            this.MessageDesc.Text = "Login Message:";
            // 
            // MessageSel
            // 
            this.MessageSel.Location = new System.Drawing.Point(92, 306);
            this.MessageSel.Name = "MessageSel";
            this.MessageSel.Size = new System.Drawing.Size(280, 20);
            this.MessageSel.TabIndex = 37;
            // 
            // SyncSel
            // 
            this.SyncSel.FormattingEnabled = true;
            this.SyncSel.Items.AddRange(new object[] {
            "Off",
            "On"});
            this.SyncSel.Location = new System.Drawing.Point(92, 332);
            this.SyncSel.Name = "SyncSel";
            this.SyncSel.Size = new System.Drawing.Size(280, 21);
            this.SyncSel.TabIndex = 38;
            this.SyncSel.Text = "Off";
            this.SyncSel.DropDown += new System.EventHandler(this.SyncSel_DropDown);
            this.SyncSel.SelectedIndexChanged += new System.EventHandler(this.SyncSel_SelectedIndexChanged);
            // 
            // SyncDesc
            // 
            this.SyncDesc.AutoSize = true;
            this.SyncDesc.Location = new System.Drawing.Point(12, 335);
            this.SyncDesc.Name = "SyncDesc";
            this.SyncDesc.Size = new System.Drawing.Size(34, 13);
            this.SyncDesc.TabIndex = 39;
            this.SyncDesc.Text = "Sync:";
            // 
            // LoadoutDesc
            // 
            this.LoadoutDesc.AutoSize = true;
            this.LoadoutDesc.Location = new System.Drawing.Point(12, 362);
            this.LoadoutDesc.Name = "LoadoutDesc";
            this.LoadoutDesc.Size = new System.Drawing.Size(49, 13);
            this.LoadoutDesc.TabIndex = 40;
            this.LoadoutDesc.Text = "Loadout:";
            // 
            // LoadoutSel
            // 
            this.LoadoutSel.Location = new System.Drawing.Point(92, 359);
            this.LoadoutSel.Name = "LoadoutSel";
            this.LoadoutSel.Size = new System.Drawing.Size(280, 20);
            this.LoadoutSel.TabIndex = 41;
            // 
            // HideSel
            // 
            this.HideSel.FormattingEnabled = true;
            this.HideSel.Items.AddRange(new object[] {
            "False",
            "True"});
            this.HideSel.Location = new System.Drawing.Point(92, 385);
            this.HideSel.Name = "HideSel";
            this.HideSel.Size = new System.Drawing.Size(280, 21);
            this.HideSel.TabIndex = 42;
            this.HideSel.Text = "False";
            this.HideSel.DropDown += new System.EventHandler(this.HideSel_DropDown);
            this.HideSel.SelectedIndexChanged += new System.EventHandler(this.HideSel_SelectedIndexChanged);
            // 
            // HideDesc
            // 
            this.HideDesc.AutoSize = true;
            this.HideDesc.Location = new System.Drawing.Point(12, 388);
            this.HideDesc.Name = "HideDesc";
            this.HideDesc.Size = new System.Drawing.Size(69, 13);
            this.HideDesc.TabIndex = 43;
            this.HideDesc.Text = "Hide Admins:";
            // 
            // IPDesc
            // 
            this.IPDesc.AutoSize = true;
            this.IPDesc.Location = new System.Drawing.Point(12, 416);
            this.IPDesc.Name = "IPDesc";
            this.IPDesc.Size = new System.Drawing.Size(50, 13);
            this.IPDesc.TabIndex = 44;
            this.IPDesc.Text = "Bind (IP):";
            // 
            // IPSel
            // 
            this.IPSel.Location = new System.Drawing.Point(92, 412);
            this.IPSel.MaxLength = 15;
            this.IPSel.Name = "IPSel";
            this.IPSel.Size = new System.Drawing.Size(280, 20);
            this.IPSel.TabIndex = 45;
            this.IPSel.Text = "0.0.0.0";
            // 
            // FilterDesc
            // 
            this.FilterDesc.AutoSize = true;
            this.FilterDesc.Location = new System.Drawing.Point(12, 441);
            this.FilterDesc.Name = "FilterDesc";
            this.FilterDesc.Size = new System.Drawing.Size(32, 13);
            this.FilterDesc.TabIndex = 47;
            this.FilterDesc.Text = "Filter:";
            // 
            // CycleDesc
            // 
            this.CycleDesc.AutoSize = true;
            this.CycleDesc.Location = new System.Drawing.Point(12, 470);
            this.CycleDesc.Name = "CycleDesc";
            this.CycleDesc.Size = new System.Drawing.Size(36, 13);
            this.CycleDesc.TabIndex = 48;
            this.CycleDesc.Text = "Cycle:";
            // 
            // RateDesc
            // 
            this.RateDesc.AutoSize = true;
            this.RateDesc.Location = new System.Drawing.Point(12, 499);
            this.RateDesc.Name = "RateDesc";
            this.RateDesc.Size = new System.Drawing.Size(58, 13);
            this.RateDesc.TabIndex = 49;
            this.RateDesc.Text = "Chat Rate:";
            // 
            // FilterSel
            // 
            this.FilterSel.FormattingEnabled = true;
            this.FilterSel.Items.AddRange(new object[] {
            "Off",
            "On"});
            this.FilterSel.Location = new System.Drawing.Point(92, 438);
            this.FilterSel.Name = "FilterSel";
            this.FilterSel.Size = new System.Drawing.Size(280, 21);
            this.FilterSel.TabIndex = 51;
            this.FilterSel.Text = "Off";
            this.FilterSel.DropDown += new System.EventHandler(this.FilterSel_DropDown);
            this.FilterSel.SelectedIndexChanged += new System.EventHandler(this.FilterSel_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.CycleCustom);
            this.panel3.Controls.Add(this.Cycle1);
            this.panel3.Controls.Add(this.Cycle2);
            this.panel3.Location = new System.Drawing.Point(83, 465);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(289, 23);
            this.panel3.TabIndex = 33;
            // 
            // CycleCustom
            // 
            this.CycleCustom.Location = new System.Drawing.Point(170, 2);
            this.CycleCustom.MaxLength = 9;
            this.CycleCustom.Name = "CycleCustom";
            this.CycleCustom.ReadOnly = true;
            this.CycleCustom.Size = new System.Drawing.Size(119, 20);
            this.CycleCustom.TabIndex = 29;
            this.CycleCustom.Text = "10800";
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
            this.Cycle1.CheckedChanged += new System.EventHandler(this.Cycle1_CheckedChanged);
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
            this.Cycle2.CheckedChanged += new System.EventHandler(this.Cycle2_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.RateCustom);
            this.panel4.Controls.Add(this.Rate1);
            this.panel4.Controls.Add(this.Rate2);
            this.panel4.Location = new System.Drawing.Point(83, 494);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(289, 23);
            this.panel4.TabIndex = 34;
            // 
            // RateCustom
            // 
            this.RateCustom.Location = new System.Drawing.Point(146, 2);
            this.RateCustom.MaxLength = 9;
            this.RateCustom.Name = "RateCustom";
            this.RateCustom.ReadOnly = true;
            this.RateCustom.Size = new System.Drawing.Size(143, 20);
            this.RateCustom.TabIndex = 29;
            this.RateCustom.Text = "5";
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
            this.Rate1.CheckedChanged += new System.EventHandler(this.Rate1_CheckedChanged);
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
            this.Rate2.CheckedChanged += new System.EventHandler(this.Rate2_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 555);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.FilterSel);
            this.Controls.Add(this.RateDesc);
            this.Controls.Add(this.CycleDesc);
            this.Controls.Add(this.FilterDesc);
            this.Controls.Add(this.IPSel);
            this.Controls.Add(this.IPDesc);
            this.Controls.Add(this.HideDesc);
            this.Controls.Add(this.HideSel);
            this.Controls.Add(this.LoadoutSel);
            this.Controls.Add(this.LoadoutDesc);
            this.Controls.Add(this.SyncDesc);
            this.Controls.Add(this.SyncSel);
            this.Controls.Add(this.MessageSel);
            this.Controls.Add(this.MessageDesc);
            this.Controls.Add(this.OwnerSel);
            this.Controls.Add(this.OwnerDesc);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PasswordSel);
            this.Controls.Add(this.QueueDesc);
            this.Controls.Add(this.PasswordDesc);
            this.Controls.Add(this.CheatsSel);
            this.Controls.Add(this.CheatsDesc);
            this.Controls.Add(this.DiffSel);
            this.Controls.Add(this.DifficultyDesc);
            this.Controls.Add(this.MapSel);
            this.Controls.Add(this.MapDesc);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.MaxDesc);
            this.Controls.Add(this.FirstPerson);
            this.Controls.Add(this.FirstDesc);
            this.Controls.Add(this.PvPDesc);
            this.Controls.Add(this.PvPValue);
            this.Controls.Add(this.PortSel);
            this.Controls.Add(this.PortDesc);
            this.Controls.Add(this.NameSel);
            this.Controls.Add(this.NameDesc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form2";
            this.Text = "Server 1 Advanced Options";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameDesc;
        private System.Windows.Forms.TextBox NameSel;
        private System.Windows.Forms.Label PortDesc;
        private System.Windows.Forms.TextBox PortSel;
        private System.Windows.Forms.ComboBox PvPValue;
        private System.Windows.Forms.Label PvPDesc;
        private System.Windows.Forms.Label FirstDesc;
        private System.Windows.Forms.ComboBox FirstPerson;
        private System.Windows.Forms.Label MaxDesc;
        private System.Windows.Forms.RadioButton MaxPlayersVal1;
        private System.Windows.Forms.RadioButton MaxPlayersVal2;
        private System.Windows.Forms.RadioButton MaxPlayersVal3;
        private System.Windows.Forms.RadioButton MaxPlayersVal4;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label MapDesc;
        private System.Windows.Forms.TextBox MapSel;
        private System.Windows.Forms.Label DifficultyDesc;
        private System.Windows.Forms.ComboBox DiffSel;
        private System.Windows.Forms.Label CheatsDesc;
        private System.Windows.Forms.ComboBox CheatsSel;
        private System.Windows.Forms.Label PasswordDesc;
        private System.Windows.Forms.Label QueueDesc;
        private System.Windows.Forms.RadioButton QueueSize1;
        private System.Windows.Forms.RadioButton QueueSize2;
        private System.Windows.Forms.RadioButton QueueSize3;
        private System.Windows.Forms.RadioButton QueueSize4;
        private System.Windows.Forms.TextBox PasswordSel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox QueueSizeCustom;
        private System.Windows.Forms.TextBox MaxPlayersCustom;
        private System.Windows.Forms.Label OwnerDesc;
        private System.Windows.Forms.TextBox OwnerSel;
        private System.Windows.Forms.Label MessageDesc;
        private System.Windows.Forms.TextBox MessageSel;
        private System.Windows.Forms.ComboBox SyncSel;
        private System.Windows.Forms.Label SyncDesc;
        private System.Windows.Forms.Label LoadoutDesc;
        private System.Windows.Forms.TextBox LoadoutSel;
        private System.Windows.Forms.ComboBox HideSel;
        private System.Windows.Forms.Label HideDesc;
        private System.Windows.Forms.Label IPDesc;
        private System.Windows.Forms.TextBox IPSel;
        private System.Windows.Forms.Label FilterDesc;
        private System.Windows.Forms.Label CycleDesc;
        private System.Windows.Forms.Label RateDesc;
        private System.Windows.Forms.ComboBox FilterSel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox CycleCustom;
        private System.Windows.Forms.RadioButton Cycle1;
        private System.Windows.Forms.RadioButton Cycle2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox RateCustom;
        private System.Windows.Forms.RadioButton Rate1;
        private System.Windows.Forms.RadioButton Rate2;
    }
}