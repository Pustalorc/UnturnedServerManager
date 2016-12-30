namespace USM
{
    partial class Manager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            this.Desc1 = new System.Windows.Forms.Label();
            this.SerPath = new System.Windows.Forms.TextBox();
            this.Desc2 = new System.Windows.Forms.Label();
            this.Servers2Run = new System.Windows.Forms.NumericUpDown();
            this.Desc3 = new System.Windows.Forms.Label();
            this.EditServer = new System.Windows.Forms.NumericUpDown();
            this.AdvancedConfig = new System.Windows.Forms.Button();
            this.Desc4 = new System.Windows.Forms.Label();
            this.Desc5 = new System.Windows.Forms.Label();
            this.VAC = new System.Windows.Forms.CheckBox();
            this.Graphics = new System.Windows.Forms.CheckBox();
            this.Console = new System.Windows.Forms.CheckBox();
            this.Desc6 = new System.Windows.Forms.Label();
            this.Desc7 = new System.Windows.Forms.Label();
            this.LocalFold = new System.Windows.Forms.TextBox();
            this.Workshop = new System.Windows.Forms.Button();
            this.Plugin = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.Desc8 = new System.Windows.Forms.Label();
            this.Restart = new System.Windows.Forms.Button();
            this.Shutdown = new System.Windows.Forms.Button();
            this.Updater = new System.Windows.Forms.Button();
            this.GithubLink = new System.Windows.Forms.LinkLabel();
            this.RedditLink = new System.Windows.Forms.LinkLabel();
            this.Desc9 = new System.Windows.Forms.Label();
            this.LinkMe = new System.Windows.Forms.LinkLabel();
            this.Notifier = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Servers2Run)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditServer)).BeginInit();
            this.SuspendLayout();
            // 
            // Desc1
            // 
            this.Desc1.AutoSize = true;
            this.Desc1.Location = new System.Drawing.Point(12, 14);
            this.Desc1.Name = "Desc1";
            this.Desc1.Size = new System.Drawing.Size(146, 13);
            this.Desc1.TabIndex = 0;
            this.Desc1.Text = "Ammount Of Servers To Run:";
            // 
            // SerPath
            // 
            this.SerPath.Location = new System.Drawing.Point(476, 12);
            this.SerPath.Name = "SerPath";
            this.SerPath.Size = new System.Drawing.Size(346, 20);
            this.SerPath.TabIndex = 2;
            this.SerPath.Text = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Unturned";
            // 
            // Desc2
            // 
            this.Desc2.AutoSize = true;
            this.Desc2.Location = new System.Drawing.Point(382, 15);
            this.Desc2.Name = "Desc2";
            this.Desc2.Size = new System.Drawing.Size(88, 13);
            this.Desc2.TabIndex = 3;
            this.Desc2.Text = "Executable Path:";
            // 
            // Servers2Run
            // 
            this.Servers2Run.Location = new System.Drawing.Point(164, 12);
            this.Servers2Run.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Servers2Run.Name = "Servers2Run";
            this.Servers2Run.ReadOnly = true;
            this.Servers2Run.Size = new System.Drawing.Size(41, 20);
            this.Servers2Run.TabIndex = 4;
            this.Servers2Run.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Servers2Run.ValueChanged += new System.EventHandler(this.Servers2Run_ValueChanged);
            // 
            // Desc3
            // 
            this.Desc3.AutoSize = true;
            this.Desc3.Location = new System.Drawing.Point(12, 167);
            this.Desc3.Name = "Desc3";
            this.Desc3.Size = new System.Drawing.Size(105, 13);
            this.Desc3.TabIndex = 5;
            this.Desc3.Text = "Editing Server By ID:";
            // 
            // EditServer
            // 
            this.EditServer.Location = new System.Drawing.Point(123, 165);
            this.EditServer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EditServer.Name = "EditServer";
            this.EditServer.ReadOnly = true;
            this.EditServer.Size = new System.Drawing.Size(39, 20);
            this.EditServer.TabIndex = 6;
            this.EditServer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EditServer.ValueChanged += new System.EventHandler(this.EditServer_ValueChanged);
            // 
            // AdvancedConfig
            // 
            this.AdvancedConfig.Location = new System.Drawing.Point(476, 121);
            this.AdvancedConfig.Name = "AdvancedConfig";
            this.AdvancedConfig.Size = new System.Drawing.Size(130, 23);
            this.AdvancedConfig.TabIndex = 7;
            this.AdvancedConfig.Text = "Change Server Settings";
            this.AdvancedConfig.UseVisualStyleBackColor = true;
            this.AdvancedConfig.Click += new System.EventHandler(this.AdvancedConfig_Click);
            // 
            // Desc4
            // 
            this.Desc4.AutoSize = true;
            this.Desc4.Location = new System.Drawing.Point(329, 59);
            this.Desc4.Name = "Desc4";
            this.Desc4.Size = new System.Drawing.Size(141, 13);
            this.Desc4.TabIndex = 8;
            this.Desc4.Text = "Currently Server With ID: {0}";
            // 
            // Desc5
            // 
            this.Desc5.AutoSize = true;
            this.Desc5.Location = new System.Drawing.Point(199, 97);
            this.Desc5.Name = "Desc5";
            this.Desc5.Size = new System.Drawing.Size(85, 13);
            this.Desc5.TabIndex = 9;
            this.Desc5.Text = "Launch Options:";
            // 
            // VAC
            // 
            this.VAC.AutoSize = true;
            this.VAC.Checked = true;
            this.VAC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.VAC.Location = new System.Drawing.Point(202, 125);
            this.VAC.Name = "VAC";
            this.VAC.Size = new System.Drawing.Size(118, 17);
            this.VAC.TabIndex = 10;
            this.VAC.Text = "VAC Secure Server";
            this.VAC.UseVisualStyleBackColor = true;
            this.VAC.CheckedChanged += new System.EventHandler(this.VAC_CheckedChanged);
            // 
            // Graphics
            // 
            this.Graphics.AutoSize = true;
            this.Graphics.Checked = true;
            this.Graphics.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Graphics.Location = new System.Drawing.Point(202, 148);
            this.Graphics.Name = "Graphics";
            this.Graphics.Size = new System.Drawing.Size(85, 17);
            this.Graphics.TabIndex = 11;
            this.Graphics.Text = "No Graphics";
            this.Graphics.UseVisualStyleBackColor = true;
            this.Graphics.CheckedChanged += new System.EventHandler(this.Graphics_CheckedChanged);
            // 
            // Console
            // 
            this.Console.AutoSize = true;
            this.Console.Checked = true;
            this.Console.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Console.Location = new System.Drawing.Point(202, 171);
            this.Console.Name = "Console";
            this.Console.Size = new System.Drawing.Size(161, 17);
            this.Console.TabIndex = 12;
            this.Console.Text = "Batch Mode (Console Mode)";
            this.Console.UseVisualStyleBackColor = true;
            this.Console.CheckedChanged += new System.EventHandler(this.Console_CheckedChanged);
            // 
            // Desc6
            // 
            this.Desc6.AutoSize = true;
            this.Desc6.Location = new System.Drawing.Point(473, 97);
            this.Desc6.Name = "Desc6";
            this.Desc6.Size = new System.Drawing.Size(98, 13);
            this.Desc6.TabIndex = 13;
            this.Desc6.Text = "Advanced Options:";
            // 
            // Desc7
            // 
            this.Desc7.AutoSize = true;
            this.Desc7.Location = new System.Drawing.Point(199, 207);
            this.Desc7.Name = "Desc7";
            this.Desc7.Size = new System.Drawing.Size(99, 13);
            this.Desc7.TabIndex = 14;
            this.Desc7.Text = "Local Folder Name:";
            // 
            // LocalFold
            // 
            this.LocalFold.Location = new System.Drawing.Point(202, 233);
            this.LocalFold.Name = "LocalFold";
            this.LocalFold.Size = new System.Drawing.Size(100, 20);
            this.LocalFold.TabIndex = 15;
            this.LocalFold.TextChanged += new System.EventHandler(this.LocalFold_TextChanged);
            // 
            // Workshop
            // 
            this.Workshop.Location = new System.Drawing.Point(476, 150);
            this.Workshop.Name = "Workshop";
            this.Workshop.Size = new System.Drawing.Size(130, 23);
            this.Workshop.TabIndex = 16;
            this.Workshop.Text = "Workshop Items";
            this.Workshop.UseVisualStyleBackColor = true;
            this.Workshop.Click += new System.EventHandler(this.Workshop_Click);
            // 
            // Plugin
            // 
            this.Plugin.Location = new System.Drawing.Point(476, 179);
            this.Plugin.Name = "Plugin";
            this.Plugin.Size = new System.Drawing.Size(130, 23);
            this.Plugin.TabIndex = 17;
            this.Plugin.Text = "Install Plugins";
            this.Plugin.UseVisualStyleBackColor = true;
            this.Plugin.Click += new System.EventHandler(this.Plugin_Click);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(476, 238);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(100, 23);
            this.Start.TabIndex = 18;
            this.Start.Text = "Start Server";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Desc8
            // 
            this.Desc8.AutoSize = true;
            this.Desc8.Location = new System.Drawing.Point(473, 216);
            this.Desc8.Name = "Desc8";
            this.Desc8.Size = new System.Drawing.Size(32, 13);
            this.Desc8.TabIndex = 19;
            this.Desc8.Text = "Boot:";
            // 
            // Restart
            // 
            this.Restart.Enabled = false;
            this.Restart.Location = new System.Drawing.Point(476, 267);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(100, 23);
            this.Restart.TabIndex = 20;
            this.Restart.Text = "Restart Server";
            this.Restart.UseVisualStyleBackColor = true;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // Shutdown
            // 
            this.Shutdown.Enabled = false;
            this.Shutdown.Location = new System.Drawing.Point(476, 296);
            this.Shutdown.Name = "Shutdown";
            this.Shutdown.Size = new System.Drawing.Size(100, 23);
            this.Shutdown.TabIndex = 21;
            this.Shutdown.Text = "Shutdown Server";
            this.Shutdown.UseVisualStyleBackColor = true;
            this.Shutdown.Click += new System.EventHandler(this.Shutdown_Click);
            // 
            // Updater
            // 
            this.Updater.Location = new System.Drawing.Point(15, 276);
            this.Updater.Name = "Updater";
            this.Updater.Size = new System.Drawing.Size(75, 23);
            this.Updater.TabIndex = 22;
            this.Updater.Text = "Update Tool";
            this.Updater.UseVisualStyleBackColor = true;
            this.Updater.Click += new System.EventHandler(this.Updater_Click);
            // 
            // GithubLink
            // 
            this.GithubLink.AutoSize = true;
            this.GithubLink.Location = new System.Drawing.Point(13, 364);
            this.GithubLink.Name = "GithubLink";
            this.GithubLink.Size = new System.Drawing.Size(224, 13);
            this.GithubLink.TabIndex = 23;
            this.GithubLink.TabStop = true;
            this.GithubLink.Text = "Github (Source Code + Issues or Suggestions)";
            this.GithubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GithubLink_LinkClicked);
            // 
            // RedditLink
            // 
            this.RedditLink.AutoSize = true;
            this.RedditLink.Location = new System.Drawing.Point(13, 340);
            this.RedditLink.Name = "RedditLink";
            this.RedditLink.Size = new System.Drawing.Size(100, 13);
            this.RedditLink.TabIndex = 24;
            this.RedditLink.TabStop = true;
            this.RedditLink.Text = "Reddit (Public Post)";
            this.RedditLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RedditLink_LinkClicked);
            // 
            // Desc9
            // 
            this.Desc9.AutoSize = true;
            this.Desc9.Location = new System.Drawing.Point(609, 367);
            this.Desc9.Name = "Desc9";
            this.Desc9.Size = new System.Drawing.Size(152, 13);
            this.Desc9.TabIndex = 25;
            this.Desc9.Text = "Programmed and Designed by:";
            // 
            // LinkMe
            // 
            this.LinkMe.AutoSize = true;
            this.LinkMe.Location = new System.Drawing.Point(757, 367);
            this.LinkMe.Name = "LinkMe";
            this.LinkMe.Size = new System.Drawing.Size(64, 13);
            this.LinkMe.TabIndex = 26;
            this.LinkMe.TabStop = true;
            this.LinkMe.Text = "persiafighter";
            this.LinkMe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkMe_LinkClicked);
            // 
            // Notifier
            // 
            this.Notifier.BalloonTipText = "Unturned Server Manager";
            this.Notifier.BalloonTipTitle = "USM";
            this.Notifier.Icon = ((System.Drawing.Icon)(resources.GetObject("Notifier.Icon")));
            this.Notifier.Text = "USM";
            this.Notifier.Visible = true;
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 389);
            this.Controls.Add(this.LinkMe);
            this.Controls.Add(this.Desc9);
            this.Controls.Add(this.RedditLink);
            this.Controls.Add(this.GithubLink);
            this.Controls.Add(this.Updater);
            this.Controls.Add(this.Shutdown);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.Desc8);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Plugin);
            this.Controls.Add(this.Workshop);
            this.Controls.Add(this.LocalFold);
            this.Controls.Add(this.Desc7);
            this.Controls.Add(this.Desc6);
            this.Controls.Add(this.Console);
            this.Controls.Add(this.Graphics);
            this.Controls.Add(this.VAC);
            this.Controls.Add(this.Desc5);
            this.Controls.Add(this.Desc4);
            this.Controls.Add(this.AdvancedConfig);
            this.Controls.Add(this.EditServer);
            this.Controls.Add(this.Desc3);
            this.Controls.Add(this.Servers2Run);
            this.Controls.Add(this.Desc2);
            this.Controls.Add(this.SerPath);
            this.Controls.Add(this.Desc1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unturned Server Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Manager_FormClosing);
            this.Load += new System.EventHandler(this.Manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Servers2Run)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditServer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Desc1;
        private System.Windows.Forms.TextBox SerPath;
        private System.Windows.Forms.Label Desc2;
        private System.Windows.Forms.NumericUpDown Servers2Run;
        private System.Windows.Forms.Label Desc3;
        private System.Windows.Forms.NumericUpDown EditServer;
        private System.Windows.Forms.Button AdvancedConfig;
        private System.Windows.Forms.Label Desc4;
        private System.Windows.Forms.Label Desc5;
        private System.Windows.Forms.CheckBox VAC;
        private System.Windows.Forms.CheckBox Graphics;
        private System.Windows.Forms.CheckBox Console;
        private System.Windows.Forms.Label Desc6;
        private System.Windows.Forms.Label Desc7;
        private System.Windows.Forms.TextBox LocalFold;
        private System.Windows.Forms.Button Workshop;
        private System.Windows.Forms.Button Plugin;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label Desc8;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.Button Shutdown;
        private System.Windows.Forms.Button Updater;
        private System.Windows.Forms.LinkLabel GithubLink;
        private System.Windows.Forms.LinkLabel RedditLink;
        private System.Windows.Forms.Label Desc9;
        private System.Windows.Forms.LinkLabel LinkMe;
        public System.Windows.Forms.NotifyIcon Notifier;
    }
}