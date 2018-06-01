namespace ATORTTeam.UnturnedServerManager.GUI
{
    partial class RocketmodConfiguration
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
            this.VehicleBlacklist = new System.Windows.Forms.CheckBox();
            this.EnableItemSpawnLimit = new System.Windows.Forms.CheckBox();
            this.ItemSpawnBlacklist = new System.Windows.Forms.CheckBox();
            this.LogMovement = new System.Windows.Forms.CheckBox();
            this.ValidateName = new System.Windows.Forms.CheckBox();
            this.AutoSave = new System.Windows.Forms.CheckBox();
            this.CommunityBans = new System.Windows.Forms.CheckBox();
            this.SteamLimitedAccounts = new System.Windows.Forms.CheckBox();
            this.KickYoungAccounts = new System.Windows.Forms.CheckBox();
            this.WebPerms = new System.Windows.Forms.CheckBox();
            this.WebConfig = new System.Windows.Forms.CheckBox();
            this.AutoShutdown = new System.Windows.Forms.CheckBox();
            this.RCON = new System.Windows.Forms.CheckBox();
            this.Password_TXT = new System.Windows.Forms.Label();
            this.Port_TXT = new System.Windows.Forms.Label();
            this.Port = new System.Windows.Forms.NumericUpDown();
            this.Password = new System.Windows.Forms.TextBox();
            this.EnableMaxGlobalConnections = new System.Windows.Forms.CheckBox();
            this.GlobalConn_TXT = new System.Windows.Forms.Label();
            this.MaxGlobalConn = new System.Windows.Forms.NumericUpDown();
            this.MaxLocalConn = new System.Windows.Forms.NumericUpDown();
            this.LocalConn_TXT = new System.Windows.Forms.Label();
            this.EnableMaxLocalConn = new System.Windows.Forms.CheckBox();
            this.Time_TXT = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.NumericUpDown();
            this.URL = new System.Windows.Forms.Label();
            this.WebConfigURL = new System.Windows.Forms.TextBox();
            this.WebPermsURL = new System.Windows.Forms.TextBox();
            this.URL2 = new System.Windows.Forms.Label();
            this.WebPermRefresh = new System.Windows.Forms.NumericUpDown();
            this.Refresh_TXT = new System.Windows.Forms.Label();
            this.Language_TXT = new System.Windows.Forms.Label();
            this.Language = new System.Windows.Forms.TextBox();
            this.TPS = new System.Windows.Forms.NumericUpDown();
            this.TPS_TXT = new System.Windows.Forms.Label();
            this.YoungRange = new System.Windows.Forms.NumericUpDown();
            this.YoungRange_TXT = new System.Windows.Forms.Label();
            this.SaveInterval = new System.Windows.Forms.NumericUpDown();
            this.Save_TXT = new System.Windows.Forms.Label();
            this.Validation = new System.Windows.Forms.TextBox();
            this.REGEX_TXT = new System.Windows.Forms.Label();
            this.MaxSpawn = new System.Windows.Forms.NumericUpDown();
            this.MaxSpawn_TXT = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Port)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxGlobalConn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxLocalConn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Time)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WebPermRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TPS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YoungRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaveInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxSpawn)).BeginInit();
            this.SuspendLayout();
            // 
            // VehicleBlacklist
            // 
            this.VehicleBlacklist.AutoSize = true;
            this.VehicleBlacklist.Location = new System.Drawing.Point(284, 304);
            this.VehicleBlacklist.Name = "VehicleBlacklist";
            this.VehicleBlacklist.Size = new System.Drawing.Size(103, 17);
            this.VehicleBlacklist.TabIndex = 0;
            this.VehicleBlacklist.Text = "Vehicle Blacklist";
            this.VehicleBlacklist.UseVisualStyleBackColor = true;
            // 
            // EnableItemSpawnLimit
            // 
            this.EnableItemSpawnLimit.AutoSize = true;
            this.EnableItemSpawnLimit.Location = new System.Drawing.Point(284, 255);
            this.EnableItemSpawnLimit.Name = "EnableItemSpawnLimit";
            this.EnableItemSpawnLimit.Size = new System.Drawing.Size(106, 17);
            this.EnableItemSpawnLimit.TabIndex = 1;
            this.EnableItemSpawnLimit.Text = "Item Spawn Limit";
            this.EnableItemSpawnLimit.UseVisualStyleBackColor = true;
            this.EnableItemSpawnLimit.CheckedChanged += new System.EventHandler(this.EnableItemSpawnLimit_CheckedChanged);
            // 
            // ItemSpawnBlacklist
            // 
            this.ItemSpawnBlacklist.AutoSize = true;
            this.ItemSpawnBlacklist.Location = new System.Drawing.Point(284, 232);
            this.ItemSpawnBlacklist.Name = "ItemSpawnBlacklist";
            this.ItemSpawnBlacklist.Size = new System.Drawing.Size(124, 17);
            this.ItemSpawnBlacklist.TabIndex = 2;
            this.ItemSpawnBlacklist.Text = "Item Spawn Blacklist";
            this.ItemSpawnBlacklist.UseVisualStyleBackColor = true;
            // 
            // LogMovement
            // 
            this.LogMovement.AutoSize = true;
            this.LogMovement.Checked = true;
            this.LogMovement.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LogMovement.Location = new System.Drawing.Point(284, 209);
            this.LogMovement.Name = "LogMovement";
            this.LogMovement.Size = new System.Drawing.Size(183, 17);
            this.LogMovement.TabIndex = 3;
            this.LogMovement.Text = "Log Suspicious Player Movement";
            this.LogMovement.UseVisualStyleBackColor = true;
            // 
            // ValidateName
            // 
            this.ValidateName.AutoSize = true;
            this.ValidateName.Checked = true;
            this.ValidateName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ValidateName.Location = new System.Drawing.Point(284, 160);
            this.ValidateName.Name = "ValidateName";
            this.ValidateName.Size = new System.Drawing.Size(152, 17);
            this.ValidateName.TabIndex = 4;
            this.ValidateName.Text = "Character Name Validation";
            this.ValidateName.UseVisualStyleBackColor = true;
            this.ValidateName.CheckedChanged += new System.EventHandler(this.ValidateName_CheckedChanged);
            // 
            // AutoSave
            // 
            this.AutoSave.AutoSize = true;
            this.AutoSave.Checked = true;
            this.AutoSave.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutoSave.Location = new System.Drawing.Point(284, 110);
            this.AutoSave.Name = "AutoSave";
            this.AutoSave.Size = new System.Drawing.Size(101, 17);
            this.AutoSave.TabIndex = 5;
            this.AutoSave.Text = "Automatic Save";
            this.AutoSave.UseVisualStyleBackColor = true;
            this.AutoSave.CheckedChanged += new System.EventHandler(this.AutoSave_CheckedChanged);
            // 
            // CommunityBans
            // 
            this.CommunityBans.AutoSize = true;
            this.CommunityBans.Checked = true;
            this.CommunityBans.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CommunityBans.Location = new System.Drawing.Point(284, 12);
            this.CommunityBans.Name = "CommunityBans";
            this.CommunityBans.Size = new System.Drawing.Size(104, 17);
            this.CommunityBans.TabIndex = 6;
            this.CommunityBans.Text = "Community Bans";
            this.CommunityBans.UseVisualStyleBackColor = true;
            // 
            // SteamLimitedAccounts
            // 
            this.SteamLimitedAccounts.AutoSize = true;
            this.SteamLimitedAccounts.Checked = true;
            this.SteamLimitedAccounts.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SteamLimitedAccounts.Location = new System.Drawing.Point(284, 36);
            this.SteamLimitedAccounts.Name = "SteamLimitedAccounts";
            this.SteamLimitedAccounts.Size = new System.Drawing.Size(164, 17);
            this.SteamLimitedAccounts.TabIndex = 7;
            this.SteamLimitedAccounts.Text = "Kick Steam Limited Accounts";
            this.SteamLimitedAccounts.UseVisualStyleBackColor = true;
            // 
            // KickYoungAccounts
            // 
            this.KickYoungAccounts.AutoSize = true;
            this.KickYoungAccounts.Checked = true;
            this.KickYoungAccounts.CheckState = System.Windows.Forms.CheckState.Checked;
            this.KickYoungAccounts.Location = new System.Drawing.Point(284, 63);
            this.KickYoungAccounts.Name = "KickYoungAccounts";
            this.KickYoungAccounts.Size = new System.Drawing.Size(151, 17);
            this.KickYoungAccounts.TabIndex = 8;
            this.KickYoungAccounts.Text = "Kick Too Young Accounts";
            this.KickYoungAccounts.UseVisualStyleBackColor = true;
            this.KickYoungAccounts.CheckedChanged += new System.EventHandler(this.KickYoungAccounts_CheckedChanged);
            // 
            // WebPerms
            // 
            this.WebPerms.AutoSize = true;
            this.WebPerms.Location = new System.Drawing.Point(12, 282);
            this.WebPerms.Name = "WebPerms";
            this.WebPerms.Size = new System.Drawing.Size(107, 17);
            this.WebPerms.TabIndex = 9;
            this.WebPerms.Text = "Web Permissions";
            this.WebPerms.UseVisualStyleBackColor = true;
            this.WebPerms.CheckedChanged += new System.EventHandler(this.WebPerms_CheckedChanged);
            // 
            // WebConfig
            // 
            this.WebConfig.AutoSize = true;
            this.WebConfig.Location = new System.Drawing.Point(12, 233);
            this.WebConfig.Name = "WebConfig";
            this.WebConfig.Size = new System.Drawing.Size(119, 17);
            this.WebConfig.TabIndex = 10;
            this.WebConfig.Text = "Web Configurations";
            this.WebConfig.UseVisualStyleBackColor = true;
            this.WebConfig.CheckedChanged += new System.EventHandler(this.WebConfig_CheckedChanged);
            // 
            // AutoShutdown
            // 
            this.AutoShutdown.AutoSize = true;
            this.AutoShutdown.Location = new System.Drawing.Point(12, 184);
            this.AutoShutdown.Name = "AutoShutdown";
            this.AutoShutdown.Size = new System.Drawing.Size(124, 17);
            this.AutoShutdown.TabIndex = 11;
            this.AutoShutdown.Text = "Automatic Shutdown";
            this.AutoShutdown.UseVisualStyleBackColor = true;
            this.AutoShutdown.CheckedChanged += new System.EventHandler(this.AutoShutdown_CheckedChanged);
            // 
            // RCON
            // 
            this.RCON.AutoSize = true;
            this.RCON.Location = new System.Drawing.Point(12, 12);
            this.RCON.Name = "RCON";
            this.RCON.Size = new System.Drawing.Size(144, 17);
            this.RCON.TabIndex = 12;
            this.RCON.Text = "Remote Console (RCON)";
            this.RCON.UseVisualStyleBackColor = true;
            this.RCON.CheckedChanged += new System.EventHandler(this.RCON_CheckedChanged);
            // 
            // Password_TXT
            // 
            this.Password_TXT.AutoSize = true;
            this.Password_TXT.Location = new System.Drawing.Point(31, 64);
            this.Password_TXT.Name = "Password_TXT";
            this.Password_TXT.Size = new System.Drawing.Size(90, 13);
            this.Password_TXT.TabIndex = 13;
            this.Password_TXT.Text = "RCON Password:";
            // 
            // Port_TXT
            // 
            this.Port_TXT.AutoSize = true;
            this.Port_TXT.Location = new System.Drawing.Point(31, 37);
            this.Port_TXT.Name = "Port_TXT";
            this.Port_TXT.Size = new System.Drawing.Size(63, 13);
            this.Port_TXT.TabIndex = 14;
            this.Port_TXT.Text = "RCON Port:";
            // 
            // Port
            // 
            this.Port.Enabled = false;
            this.Port.Location = new System.Drawing.Point(100, 35);
            this.Port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(52, 20);
            this.Port.TabIndex = 15;
            this.Port.Value = new decimal(new int[] {
            27115,
            0,
            0,
            0});
            // 
            // Password
            // 
            this.Password.Enabled = false;
            this.Password.Location = new System.Drawing.Point(127, 61);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(100, 20);
            this.Password.TabIndex = 16;
            this.Password.Text = "changeme";
            // 
            // EnableMaxGlobalConnections
            // 
            this.EnableMaxGlobalConnections.AutoSize = true;
            this.EnableMaxGlobalConnections.Checked = true;
            this.EnableMaxGlobalConnections.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EnableMaxGlobalConnections.Enabled = false;
            this.EnableMaxGlobalConnections.Location = new System.Drawing.Point(34, 87);
            this.EnableMaxGlobalConnections.Name = "EnableMaxGlobalConnections";
            this.EnableMaxGlobalConnections.Size = new System.Drawing.Size(162, 17);
            this.EnableMaxGlobalConnections.TabIndex = 17;
            this.EnableMaxGlobalConnections.Text = "Maximize Gobal Connections";
            this.EnableMaxGlobalConnections.UseVisualStyleBackColor = true;
            this.EnableMaxGlobalConnections.CheckedChanged += new System.EventHandler(this.EnableMaxGlobalConnections_CheckedChanged);
            // 
            // GlobalConn_TXT
            // 
            this.GlobalConn_TXT.AutoSize = true;
            this.GlobalConn_TXT.Location = new System.Drawing.Point(31, 111);
            this.GlobalConn_TXT.Name = "GlobalConn_TXT";
            this.GlobalConn_TXT.Size = new System.Drawing.Size(149, 13);
            this.GlobalConn_TXT.TabIndex = 18;
            this.GlobalConn_TXT.Text = "Maximum Global Connections:";
            // 
            // MaxGlobalConn
            // 
            this.MaxGlobalConn.Enabled = false;
            this.MaxGlobalConn.Location = new System.Drawing.Point(186, 109);
            this.MaxGlobalConn.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.MaxGlobalConn.Name = "MaxGlobalConn";
            this.MaxGlobalConn.Size = new System.Drawing.Size(52, 20);
            this.MaxGlobalConn.TabIndex = 19;
            this.MaxGlobalConn.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // MaxLocalConn
            // 
            this.MaxLocalConn.Enabled = false;
            this.MaxLocalConn.Location = new System.Drawing.Point(182, 157);
            this.MaxLocalConn.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.MaxLocalConn.Name = "MaxLocalConn";
            this.MaxLocalConn.Size = new System.Drawing.Size(52, 20);
            this.MaxLocalConn.TabIndex = 22;
            this.MaxLocalConn.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // LocalConn_TXT
            // 
            this.LocalConn_TXT.AutoSize = true;
            this.LocalConn_TXT.Location = new System.Drawing.Point(31, 159);
            this.LocalConn_TXT.Name = "LocalConn_TXT";
            this.LocalConn_TXT.Size = new System.Drawing.Size(145, 13);
            this.LocalConn_TXT.TabIndex = 21;
            this.LocalConn_TXT.Text = "Maximum Local Connections:";
            // 
            // EnableMaxLocalConn
            // 
            this.EnableMaxLocalConn.AutoSize = true;
            this.EnableMaxLocalConn.Checked = true;
            this.EnableMaxLocalConn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EnableMaxLocalConn.Enabled = false;
            this.EnableMaxLocalConn.Location = new System.Drawing.Point(34, 135);
            this.EnableMaxLocalConn.Name = "EnableMaxLocalConn";
            this.EnableMaxLocalConn.Size = new System.Drawing.Size(160, 17);
            this.EnableMaxLocalConn.TabIndex = 20;
            this.EnableMaxLocalConn.Text = "Maximize Local Connections";
            this.EnableMaxLocalConn.UseVisualStyleBackColor = true;
            this.EnableMaxLocalConn.CheckedChanged += new System.EventHandler(this.EnableMaxLocalConn_CheckedChanged);
            // 
            // Time_TXT
            // 
            this.Time_TXT.AutoSize = true;
            this.Time_TXT.Location = new System.Drawing.Point(31, 208);
            this.Time_TXT.Name = "Time_TXT";
            this.Time_TXT.Size = new System.Drawing.Size(135, 13);
            this.Time_TXT.TabIndex = 23;
            this.Time_TXT.Text = "Shutdown Time (Seconds):";
            // 
            // Time
            // 
            this.Time.Enabled = false;
            this.Time.Location = new System.Drawing.Point(172, 206);
            this.Time.Maximum = new decimal(new int[] {
            31536000,
            0,
            0,
            0});
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(69, 20);
            this.Time.TabIndex = 24;
            this.Time.Value = new decimal(new int[] {
            86400,
            0,
            0,
            0});
            // 
            // URL
            // 
            this.URL.AutoSize = true;
            this.URL.Location = new System.Drawing.Point(31, 259);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(32, 13);
            this.URL.TabIndex = 25;
            this.URL.Text = "URL:";
            // 
            // WebConfigURL
            // 
            this.WebConfigURL.Enabled = false;
            this.WebConfigURL.Location = new System.Drawing.Point(69, 256);
            this.WebConfigURL.Name = "WebConfigURL";
            this.WebConfigURL.Size = new System.Drawing.Size(172, 20);
            this.WebConfigURL.TabIndex = 26;
            // 
            // WebPermsURL
            // 
            this.WebPermsURL.Enabled = false;
            this.WebPermsURL.Location = new System.Drawing.Point(69, 305);
            this.WebPermsURL.Name = "WebPermsURL";
            this.WebPermsURL.Size = new System.Drawing.Size(172, 20);
            this.WebPermsURL.TabIndex = 28;
            // 
            // URL2
            // 
            this.URL2.AutoSize = true;
            this.URL2.Location = new System.Drawing.Point(31, 308);
            this.URL2.Name = "URL2";
            this.URL2.Size = new System.Drawing.Size(32, 13);
            this.URL2.TabIndex = 27;
            this.URL2.Text = "URL:";
            // 
            // WebPermRefresh
            // 
            this.WebPermRefresh.Enabled = false;
            this.WebPermRefresh.Location = new System.Drawing.Point(122, 331);
            this.WebPermRefresh.Maximum = new decimal(new int[] {
            31536000,
            0,
            0,
            0});
            this.WebPermRefresh.Name = "WebPermRefresh";
            this.WebPermRefresh.Size = new System.Drawing.Size(69, 20);
            this.WebPermRefresh.TabIndex = 30;
            this.WebPermRefresh.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // Refresh_TXT
            // 
            this.Refresh_TXT.AutoSize = true;
            this.Refresh_TXT.Location = new System.Drawing.Point(31, 333);
            this.Refresh_TXT.Name = "Refresh_TXT";
            this.Refresh_TXT.Size = new System.Drawing.Size(85, 13);
            this.Refresh_TXT.TabIndex = 29;
            this.Refresh_TXT.Text = "Refresh Interval:";
            // 
            // Language_TXT
            // 
            this.Language_TXT.AutoSize = true;
            this.Language_TXT.Location = new System.Drawing.Point(12, 383);
            this.Language_TXT.Name = "Language_TXT";
            this.Language_TXT.Size = new System.Drawing.Size(86, 13);
            this.Language_TXT.TabIndex = 31;
            this.Language_TXT.Text = "Language Code:";
            // 
            // Language
            // 
            this.Language.Location = new System.Drawing.Point(104, 380);
            this.Language.Name = "Language";
            this.Language.Size = new System.Drawing.Size(100, 20);
            this.Language.TabIndex = 32;
            this.Language.Text = "EN";
            // 
            // TPS
            // 
            this.TPS.Location = new System.Drawing.Point(384, 381);
            this.TPS.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.TPS.Name = "TPS";
            this.TPS.Size = new System.Drawing.Size(40, 20);
            this.TPS.TabIndex = 34;
            this.TPS.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // TPS_TXT
            // 
            this.TPS_TXT.AutoSize = true;
            this.TPS_TXT.Location = new System.Drawing.Point(281, 383);
            this.TPS_TXT.Name = "TPS_TXT";
            this.TPS_TXT.Size = new System.Drawing.Size(97, 13);
            this.TPS_TXT.TabIndex = 33;
            this.TPS_TXT.Text = "Max Frames (TPS):";
            // 
            // YoungRange
            // 
            this.YoungRange.Enabled = false;
            this.YoungRange.Location = new System.Drawing.Point(429, 86);
            this.YoungRange.Maximum = new decimal(new int[] {
            31536000,
            0,
            0,
            0});
            this.YoungRange.Name = "YoungRange";
            this.YoungRange.Size = new System.Drawing.Size(69, 20);
            this.YoungRange.TabIndex = 36;
            this.YoungRange.Value = new decimal(new int[] {
            604800,
            0,
            0,
            0});
            // 
            // YoungRange_TXT
            // 
            this.YoungRange_TXT.AutoSize = true;
            this.YoungRange_TXT.Location = new System.Drawing.Point(300, 88);
            this.YoungRange_TXT.Name = "YoungRange_TXT";
            this.YoungRange_TXT.Size = new System.Drawing.Size(123, 13);
            this.YoungRange_TXT.TabIndex = 35;
            this.YoungRange_TXT.Text = "Maximum Age For Kicks:";
            // 
            // SaveInterval
            // 
            this.SaveInterval.Enabled = false;
            this.SaveInterval.Location = new System.Drawing.Point(379, 134);
            this.SaveInterval.Maximum = new decimal(new int[] {
            31536000,
            0,
            0,
            0});
            this.SaveInterval.Name = "SaveInterval";
            this.SaveInterval.Size = new System.Drawing.Size(69, 20);
            this.SaveInterval.TabIndex = 38;
            this.SaveInterval.Value = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            // 
            // Save_TXT
            // 
            this.Save_TXT.AutoSize = true;
            this.Save_TXT.Location = new System.Drawing.Point(300, 136);
            this.Save_TXT.Name = "Save_TXT";
            this.Save_TXT.Size = new System.Drawing.Size(73, 13);
            this.Save_TXT.TabIndex = 37;
            this.Save_TXT.Text = "Save Interval:";
            // 
            // Validation
            // 
            this.Validation.Enabled = false;
            this.Validation.Location = new System.Drawing.Point(387, 183);
            this.Validation.Name = "Validation";
            this.Validation.Size = new System.Drawing.Size(172, 20);
            this.Validation.TabIndex = 40;
            this.Validation.Text = "([\\x00-\\xAA]|[\\w_\\ \\.\\+\\-])+";
            // 
            // REGEX_TXT
            // 
            this.REGEX_TXT.AutoSize = true;
            this.REGEX_TXT.Location = new System.Drawing.Point(300, 186);
            this.REGEX_TXT.Name = "REGEX_TXT";
            this.REGEX_TXT.Size = new System.Drawing.Size(81, 13);
            this.REGEX_TXT.TabIndex = 39;
            this.REGEX_TXT.Text = "Validation Rule:";
            // 
            // MaxSpawn
            // 
            this.MaxSpawn.Enabled = false;
            this.MaxSpawn.Location = new System.Drawing.Point(435, 278);
            this.MaxSpawn.Maximum = new decimal(new int[] {
            31536000,
            0,
            0,
            0});
            this.MaxSpawn.Name = "MaxSpawn";
            this.MaxSpawn.Size = new System.Drawing.Size(69, 20);
            this.MaxSpawn.TabIndex = 42;
            this.MaxSpawn.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // MaxSpawn_TXT
            // 
            this.MaxSpawn_TXT.AutoSize = true;
            this.MaxSpawn_TXT.Location = new System.Drawing.Point(300, 280);
            this.MaxSpawn_TXT.Name = "MaxSpawn_TXT";
            this.MaxSpawn_TXT.Size = new System.Drawing.Size(129, 13);
            this.MaxSpawn_TXT.TabIndex = 41;
            this.MaxSpawn_TXT.Text = "Maximum Spawn Amount:";
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(476, 389);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(84, 23);
            this.Exit.TabIndex = 43;
            this.Exit.Text = "Save And Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // RocketmodConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 424);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.MaxSpawn);
            this.Controls.Add(this.MaxSpawn_TXT);
            this.Controls.Add(this.Validation);
            this.Controls.Add(this.REGEX_TXT);
            this.Controls.Add(this.SaveInterval);
            this.Controls.Add(this.Save_TXT);
            this.Controls.Add(this.YoungRange);
            this.Controls.Add(this.YoungRange_TXT);
            this.Controls.Add(this.TPS);
            this.Controls.Add(this.TPS_TXT);
            this.Controls.Add(this.Language);
            this.Controls.Add(this.Language_TXT);
            this.Controls.Add(this.WebPermRefresh);
            this.Controls.Add(this.Refresh_TXT);
            this.Controls.Add(this.WebPermsURL);
            this.Controls.Add(this.URL2);
            this.Controls.Add(this.WebConfigURL);
            this.Controls.Add(this.URL);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Time_TXT);
            this.Controls.Add(this.MaxLocalConn);
            this.Controls.Add(this.LocalConn_TXT);
            this.Controls.Add(this.EnableMaxLocalConn);
            this.Controls.Add(this.MaxGlobalConn);
            this.Controls.Add(this.GlobalConn_TXT);
            this.Controls.Add(this.EnableMaxGlobalConnections);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.Port_TXT);
            this.Controls.Add(this.Password_TXT);
            this.Controls.Add(this.RCON);
            this.Controls.Add(this.AutoShutdown);
            this.Controls.Add(this.WebConfig);
            this.Controls.Add(this.WebPerms);
            this.Controls.Add(this.KickYoungAccounts);
            this.Controls.Add(this.SteamLimitedAccounts);
            this.Controls.Add(this.CommunityBans);
            this.Controls.Add(this.AutoSave);
            this.Controls.Add(this.ValidateName);
            this.Controls.Add(this.LogMovement);
            this.Controls.Add(this.ItemSpawnBlacklist);
            this.Controls.Add(this.EnableItemSpawnLimit);
            this.Controls.Add(this.VehicleBlacklist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RocketmodConfiguration";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rocketmod Configuration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RocketmodConfiguration_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Port)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxGlobalConn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxLocalConn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Time)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WebPermRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TPS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YoungRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaveInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxSpawn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox VehicleBlacklist;
        private System.Windows.Forms.CheckBox EnableItemSpawnLimit;
        private System.Windows.Forms.CheckBox ItemSpawnBlacklist;
        private System.Windows.Forms.CheckBox LogMovement;
        private System.Windows.Forms.CheckBox ValidateName;
        private System.Windows.Forms.CheckBox AutoSave;
        private System.Windows.Forms.CheckBox CommunityBans;
        private System.Windows.Forms.CheckBox SteamLimitedAccounts;
        private System.Windows.Forms.CheckBox KickYoungAccounts;
        private System.Windows.Forms.CheckBox WebPerms;
        private System.Windows.Forms.CheckBox WebConfig;
        private System.Windows.Forms.CheckBox AutoShutdown;
        private System.Windows.Forms.CheckBox RCON;
        private System.Windows.Forms.Label Password_TXT;
        private System.Windows.Forms.Label Port_TXT;
        private System.Windows.Forms.NumericUpDown Port;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.CheckBox EnableMaxGlobalConnections;
        private System.Windows.Forms.Label GlobalConn_TXT;
        private System.Windows.Forms.NumericUpDown MaxGlobalConn;
        private System.Windows.Forms.NumericUpDown MaxLocalConn;
        private System.Windows.Forms.Label LocalConn_TXT;
        private System.Windows.Forms.CheckBox EnableMaxLocalConn;
        private System.Windows.Forms.Label Time_TXT;
        private System.Windows.Forms.NumericUpDown Time;
        private System.Windows.Forms.Label URL;
        private System.Windows.Forms.TextBox WebConfigURL;
        private System.Windows.Forms.TextBox WebPermsURL;
        private System.Windows.Forms.Label URL2;
        private System.Windows.Forms.NumericUpDown WebPermRefresh;
        private System.Windows.Forms.Label Refresh_TXT;
        private System.Windows.Forms.Label Language_TXT;
        private System.Windows.Forms.TextBox Language;
        private System.Windows.Forms.NumericUpDown TPS;
        private System.Windows.Forms.Label TPS_TXT;
        private System.Windows.Forms.NumericUpDown YoungRange;
        private System.Windows.Forms.Label YoungRange_TXT;
        private System.Windows.Forms.NumericUpDown SaveInterval;
        private System.Windows.Forms.Label Save_TXT;
        private System.Windows.Forms.TextBox Validation;
        private System.Windows.Forms.Label REGEX_TXT;
        private System.Windows.Forms.NumericUpDown MaxSpawn;
        private System.Windows.Forms.Label MaxSpawn_TXT;
        private System.Windows.Forms.Button Exit;
    }
}