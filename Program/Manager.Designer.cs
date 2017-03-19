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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            this.LinkMe = new System.Windows.Forms.LinkLabel();
            this.Desc9 = new System.Windows.Forms.Label();
            this.RedditLink = new System.Windows.Forms.LinkLabel();
            this.GithubLink = new System.Windows.Forms.LinkLabel();
            this.Updater = new System.Windows.Forms.Button();
            this.Shutdown = new System.Windows.Forms.Button();
            this.Restart = new System.Windows.Forms.Button();
            this.Desc8 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.Plugin = new System.Windows.Forms.Button();
            this.Workshop = new System.Windows.Forms.Button();
            this.LocalFold = new System.Windows.Forms.TextBox();
            this.Desc7 = new System.Windows.Forms.Label();
            this.Desc6 = new System.Windows.Forms.Label();
            this.Console = new System.Windows.Forms.CheckBox();
            this.Graphics = new System.Windows.Forms.CheckBox();
            this.VAC = new System.Windows.Forms.CheckBox();
            this.Desc5 = new System.Windows.Forms.Label();
            this.Desc4 = new System.Windows.Forms.Label();
            this.AdvancedConfig = new System.Windows.Forms.Button();
            this.EditServer = new System.Windows.Forms.NumericUpDown();
            this.Desc3 = new System.Windows.Forms.Label();
            this.Desc10 = new System.Windows.Forms.Label();
            this.ConsoleView = new System.Windows.Forms.Button();
            this.Port = new System.Windows.Forms.Button();
            this.USMSettings = new System.Windows.Forms.Button();
            this.AutoRest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EditServer)).BeginInit();
            this.SuspendLayout();
            // 
            // LinkMe
            // 
            this.LinkMe.AutoSize = true;
            this.LinkMe.Location = new System.Drawing.Point(758, 367);
            this.LinkMe.Name = "LinkMe";
            this.LinkMe.Size = new System.Drawing.Size(64, 13);
            this.LinkMe.TabIndex = 48;
            this.LinkMe.TabStop = true;
            this.LinkMe.Text = "persiafighter";
            this.LinkMe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkMe_LinkClicked);
            // 
            // Desc9
            // 
            this.Desc9.AutoSize = true;
            this.Desc9.Location = new System.Drawing.Point(610, 367);
            this.Desc9.Name = "Desc9";
            this.Desc9.Size = new System.Drawing.Size(152, 13);
            this.Desc9.TabIndex = 47;
            this.Desc9.Text = "Programmed and Designed by:";
            // 
            // RedditLink
            // 
            this.RedditLink.AutoSize = true;
            this.RedditLink.Location = new System.Drawing.Point(12, 343);
            this.RedditLink.Name = "RedditLink";
            this.RedditLink.Size = new System.Drawing.Size(100, 13);
            this.RedditLink.TabIndex = 46;
            this.RedditLink.TabStop = true;
            this.RedditLink.Text = "Reddit (Public Post)";
            this.RedditLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RedditLink_LinkClicked);
            // 
            // GithubLink
            // 
            this.GithubLink.AutoSize = true;
            this.GithubLink.Location = new System.Drawing.Point(12, 367);
            this.GithubLink.Name = "GithubLink";
            this.GithubLink.Size = new System.Drawing.Size(224, 13);
            this.GithubLink.TabIndex = 45;
            this.GithubLink.TabStop = true;
            this.GithubLink.Text = "Github (Source Code + Issues or Suggestions)";
            this.GithubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GithubLink_LinkClicked);
            // 
            // Updater
            // 
            this.Updater.Location = new System.Drawing.Point(15, 308);
            this.Updater.Name = "Updater";
            this.Updater.Size = new System.Drawing.Size(75, 23);
            this.Updater.TabIndex = 44;
            this.Updater.Text = "Update Tool";
            this.Updater.UseVisualStyleBackColor = true;
            this.Updater.Click += new System.EventHandler(this.Updater_Click);
            // 
            // Shutdown
            // 
            this.Shutdown.Enabled = false;
            this.Shutdown.Location = new System.Drawing.Point(406, 234);
            this.Shutdown.Name = "Shutdown";
            this.Shutdown.Size = new System.Drawing.Size(106, 23);
            this.Shutdown.TabIndex = 43;
            this.Shutdown.Text = "Shutdown Server";
            this.Shutdown.UseVisualStyleBackColor = true;
            // 
            // Restart
            // 
            this.Restart.Enabled = false;
            this.Restart.Location = new System.Drawing.Point(406, 205);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(106, 23);
            this.Restart.TabIndex = 42;
            this.Restart.Text = "Restart Server";
            this.Restart.UseVisualStyleBackColor = true;
            // 
            // Desc8
            // 
            this.Desc8.AutoSize = true;
            this.Desc8.Location = new System.Drawing.Point(403, 123);
            this.Desc8.Name = "Desc8";
            this.Desc8.Size = new System.Drawing.Size(32, 13);
            this.Desc8.TabIndex = 41;
            this.Desc8.Text = "Boot:";
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(406, 176);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(106, 23);
            this.Start.TabIndex = 40;
            this.Start.Text = "Start Server";
            this.Start.UseVisualStyleBackColor = true;
            // 
            // Plugin
            // 
            this.Plugin.Location = new System.Drawing.Point(261, 205);
            this.Plugin.Name = "Plugin";
            this.Plugin.Size = new System.Drawing.Size(130, 23);
            this.Plugin.TabIndex = 39;
            this.Plugin.Text = "Install Plugins";
            this.Plugin.UseVisualStyleBackColor = true;
            // 
            // Workshop
            // 
            this.Workshop.Location = new System.Drawing.Point(261, 176);
            this.Workshop.Name = "Workshop";
            this.Workshop.Size = new System.Drawing.Size(130, 23);
            this.Workshop.TabIndex = 38;
            this.Workshop.Text = "Workshop Items";
            this.Workshop.UseVisualStyleBackColor = true;
            // 
            // LocalFold
            // 
            this.LocalFold.Location = new System.Drawing.Point(521, 149);
            this.LocalFold.Name = "LocalFold";
            this.LocalFold.Size = new System.Drawing.Size(100, 20);
            this.LocalFold.TabIndex = 37;
            // 
            // Desc7
            // 
            this.Desc7.AutoSize = true;
            this.Desc7.Location = new System.Drawing.Point(518, 123);
            this.Desc7.Name = "Desc7";
            this.Desc7.Size = new System.Drawing.Size(99, 13);
            this.Desc7.TabIndex = 36;
            this.Desc7.Text = "Local Folder Name:";
            // 
            // Desc6
            // 
            this.Desc6.AutoSize = true;
            this.Desc6.Location = new System.Drawing.Point(258, 123);
            this.Desc6.Name = "Desc6";
            this.Desc6.Size = new System.Drawing.Size(98, 13);
            this.Desc6.TabIndex = 35;
            this.Desc6.Text = "Advanced Options:";
            // 
            // Console
            // 
            this.Console.AutoSize = true;
            this.Console.Checked = true;
            this.Console.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Console.Location = new System.Drawing.Point(90, 193);
            this.Console.Name = "Console";
            this.Console.Size = new System.Drawing.Size(161, 17);
            this.Console.TabIndex = 34;
            this.Console.Text = "Batch Mode (Console Mode)";
            this.Console.UseVisualStyleBackColor = true;
            // 
            // Graphics
            // 
            this.Graphics.AutoSize = true;
            this.Graphics.Checked = true;
            this.Graphics.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Graphics.Location = new System.Drawing.Point(90, 170);
            this.Graphics.Name = "Graphics";
            this.Graphics.Size = new System.Drawing.Size(85, 17);
            this.Graphics.TabIndex = 33;
            this.Graphics.Text = "No Graphics";
            this.Graphics.UseVisualStyleBackColor = true;
            // 
            // VAC
            // 
            this.VAC.AutoSize = true;
            this.VAC.Checked = true;
            this.VAC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.VAC.Location = new System.Drawing.Point(90, 147);
            this.VAC.Name = "VAC";
            this.VAC.Size = new System.Drawing.Size(118, 17);
            this.VAC.TabIndex = 32;
            this.VAC.Text = "VAC Secure Server";
            this.VAC.UseVisualStyleBackColor = true;
            // 
            // Desc5
            // 
            this.Desc5.AutoSize = true;
            this.Desc5.Location = new System.Drawing.Point(87, 123);
            this.Desc5.Name = "Desc5";
            this.Desc5.Size = new System.Drawing.Size(85, 13);
            this.Desc5.TabIndex = 31;
            this.Desc5.Text = "Launch Options:";
            // 
            // Desc4
            // 
            this.Desc4.AutoSize = true;
            this.Desc4.Location = new System.Drawing.Point(355, 14);
            this.Desc4.Name = "Desc4";
            this.Desc4.Size = new System.Drawing.Size(168, 13);
            this.Desc4.TabIndex = 30;
            this.Desc4.Text = "Currently Editing Server With ID: 1";
            // 
            // AdvancedConfig
            // 
            this.AdvancedConfig.Location = new System.Drawing.Point(261, 147);
            this.AdvancedConfig.Name = "AdvancedConfig";
            this.AdvancedConfig.Size = new System.Drawing.Size(130, 23);
            this.AdvancedConfig.TabIndex = 29;
            this.AdvancedConfig.Text = "Change Server Settings";
            this.AdvancedConfig.UseVisualStyleBackColor = true;
            // 
            // EditServer
            // 
            this.EditServer.Location = new System.Drawing.Point(123, 12);
            this.EditServer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EditServer.Name = "EditServer";
            this.EditServer.ReadOnly = true;
            this.EditServer.Size = new System.Drawing.Size(39, 20);
            this.EditServer.TabIndex = 28;
            this.EditServer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Desc3
            // 
            this.Desc3.AutoSize = true;
            this.Desc3.Location = new System.Drawing.Point(12, 14);
            this.Desc3.Name = "Desc3";
            this.Desc3.Size = new System.Drawing.Size(105, 13);
            this.Desc3.TabIndex = 27;
            this.Desc3.Text = "Editing Server By ID:";
            // 
            // Desc10
            // 
            this.Desc10.AutoSize = true;
            this.Desc10.Location = new System.Drawing.Point(632, 123);
            this.Desc10.Name = "Desc10";
            this.Desc10.Size = new System.Drawing.Size(85, 13);
            this.Desc10.TabIndex = 49;
            this.Desc10.Text = "Remote Access:";
            // 
            // ConsoleView
            // 
            this.ConsoleView.Location = new System.Drawing.Point(635, 147);
            this.ConsoleView.Name = "ConsoleView";
            this.ConsoleView.Size = new System.Drawing.Size(91, 23);
            this.ConsoleView.TabIndex = 50;
            this.ConsoleView.Text = "Manage Server";
            this.ConsoleView.UseVisualStyleBackColor = true;
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(635, 176);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(91, 23);
            this.Port.TabIndex = 51;
            this.Port.Text = "Change Port";
            this.Port.UseVisualStyleBackColor = true;
            // 
            // USMSettings
            // 
            this.USMSettings.Location = new System.Drawing.Point(15, 279);
            this.USMSettings.Name = "USMSettings";
            this.USMSettings.Size = new System.Drawing.Size(75, 23);
            this.USMSettings.TabIndex = 52;
            this.USMSettings.Text = "Settings";
            this.USMSettings.UseVisualStyleBackColor = true;
            this.USMSettings.Click += new System.EventHandler(this.USMSettings_Click);
            // 
            // AutoRest
            // 
            this.AutoRest.Location = new System.Drawing.Point(406, 147);
            this.AutoRest.Name = "AutoRest";
            this.AutoRest.Size = new System.Drawing.Size(106, 23);
            this.AutoRest.TabIndex = 53;
            this.AutoRest.Text = "Setup Auto Restart";
            this.AutoRest.UseVisualStyleBackColor = true;
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 389);
            this.Controls.Add(this.AutoRest);
            this.Controls.Add(this.USMSettings);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.ConsoleView);
            this.Controls.Add(this.Desc10);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unturned Server Manager";
            ((System.ComponentModel.ISupportInitialize)(this.EditServer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel LinkMe;
        private System.Windows.Forms.Label Desc9;
        private System.Windows.Forms.LinkLabel RedditLink;
        private System.Windows.Forms.LinkLabel GithubLink;
        private System.Windows.Forms.Button Updater;
        private System.Windows.Forms.Button Shutdown;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.Label Desc8;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Plugin;
        private System.Windows.Forms.Button Workshop;
        private System.Windows.Forms.TextBox LocalFold;
        private System.Windows.Forms.Label Desc7;
        private System.Windows.Forms.Label Desc6;
        private System.Windows.Forms.CheckBox Console;
        private System.Windows.Forms.CheckBox Graphics;
        private System.Windows.Forms.CheckBox VAC;
        private System.Windows.Forms.Label Desc5;
        private System.Windows.Forms.Label Desc4;
        private System.Windows.Forms.Button AdvancedConfig;
        private System.Windows.Forms.NumericUpDown EditServer;
        private System.Windows.Forms.Label Desc3;
        private System.Windows.Forms.Label Desc10;
        private System.Windows.Forms.Button ConsoleView;
        private System.Windows.Forms.Button Port;
        private System.Windows.Forms.Button USMSettings;
        private System.Windows.Forms.Button AutoRest;
    }
}