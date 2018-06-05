namespace ATORTTeam.UnturnedServerManager.GUI
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
            this.Settings = new System.Windows.Forms.Button();
            this.Workshop = new System.Windows.Forms.Button();
            this.Plugin = new System.Windows.Forms.Button();
            this.Toggle = new System.Windows.Forms.Button();
            this.Updater = new System.Windows.Forms.Button();
            this.GithubLink = new System.Windows.Forms.LinkLabel();
            this.Desc9 = new System.Windows.Forms.Label();
            this.LinkMe = new System.Windows.Forms.LinkLabel();
            this.Notifier = new System.Windows.Forms.NotifyIcon(this.components);
            this.Servers = new System.Windows.Forms.ListBox();
            this.NewServer = new System.Windows.Forms.Button();
            this.DeleteServer = new System.Windows.Forms.Button();
            this.CloneServer = new System.Windows.Forms.Button();
            this.List_TXT = new System.Windows.Forms.Label();
            this.ServerSettings = new System.Windows.Forms.RichTextBox();
            this.Settings_TXT = new System.Windows.Forms.Label();
            this.Restart = new System.Windows.Forms.Button();
            this.Mngmnt_TXT = new System.Windows.Forms.Label();
            this.ctrl_TXT = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Button();
            this.OpenLocal = new System.Windows.Forms.Button();
            this.XMLEditor = new System.Windows.Forms.Button();
            this.JSONEditor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Settings
            // 
            this.Settings.Location = new System.Drawing.Point(255, 12);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(130, 23);
            this.Settings.TabIndex = 7;
            this.Settings.Text = "Change Server Settings";
            this.Settings.UseVisualStyleBackColor = true;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // Workshop
            // 
            this.Workshop.Location = new System.Drawing.Point(391, 57);
            this.Workshop.Name = "Workshop";
            this.Workshop.Size = new System.Drawing.Size(139, 23);
            this.Workshop.TabIndex = 16;
            this.Workshop.Text = "Workshop Content";
            this.Workshop.UseVisualStyleBackColor = true;
            this.Workshop.Click += new System.EventHandler(this.Workshop_Click);
            // 
            // Plugin
            // 
            this.Plugin.Location = new System.Drawing.Point(391, 86);
            this.Plugin.Name = "Plugin";
            this.Plugin.Size = new System.Drawing.Size(139, 23);
            this.Plugin.TabIndex = 17;
            this.Plugin.Text = "Rocket Plugins";
            this.Plugin.UseVisualStyleBackColor = true;
            this.Plugin.Click += new System.EventHandler(this.Plugin_Click);
            // 
            // Toggle
            // 
            this.Toggle.Location = new System.Drawing.Point(388, 230);
            this.Toggle.Name = "Toggle";
            this.Toggle.Size = new System.Drawing.Size(142, 23);
            this.Toggle.TabIndex = 18;
            this.Toggle.Text = "Start/Stop Server";
            this.Toggle.UseVisualStyleBackColor = true;
            this.Toggle.Click += new System.EventHandler(this.Toggle_Click);
            // 
            // Updater
            // 
            this.Updater.Location = new System.Drawing.Point(12, 402);
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
            this.GithubLink.Location = new System.Drawing.Point(167, 407);
            this.GithubLink.Name = "GithubLink";
            this.GithubLink.Size = new System.Drawing.Size(38, 13);
            this.GithubLink.TabIndex = 23;
            this.GithubLink.TabStop = true;
            this.GithubLink.Text = "Github";
            this.GithubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GithubLink_LinkClicked);
            // 
            // Desc9
            // 
            this.Desc9.AutoSize = true;
            this.Desc9.Location = new System.Drawing.Point(335, 407);
            this.Desc9.Name = "Desc9";
            this.Desc9.Size = new System.Drawing.Size(152, 13);
            this.Desc9.TabIndex = 25;
            this.Desc9.Text = "Programmed and Designed by:";
            // 
            // LinkMe
            // 
            this.LinkMe.AutoSize = true;
            this.LinkMe.Location = new System.Drawing.Point(483, 407);
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
            this.Notifier.BalloonTipTitle = "Unturned Server Manager";
            this.Notifier.Icon = ((System.Drawing.Icon)(resources.GetObject("Notifier.Icon")));
            this.Notifier.Text = "Unturned Server Manager";
            this.Notifier.Visible = true;
            this.Notifier.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Notifier_MouseDoubleClick);
            // 
            // Servers
            // 
            this.Servers.FormattingEnabled = true;
            this.Servers.Location = new System.Drawing.Point(11, 36);
            this.Servers.Name = "Servers";
            this.Servers.Size = new System.Drawing.Size(153, 290);
            this.Servers.TabIndex = 27;
            this.Servers.SelectedIndexChanged += new System.EventHandler(this.Servers_SelectedIndexChanged);
            // 
            // NewServer
            // 
            this.NewServer.Location = new System.Drawing.Point(11, 332);
            this.NewServer.Name = "NewServer";
            this.NewServer.Size = new System.Drawing.Size(49, 23);
            this.NewServer.TabIndex = 28;
            this.NewServer.Text = "New";
            this.NewServer.UseVisualStyleBackColor = true;
            this.NewServer.Click += new System.EventHandler(this.NewServer_Click);
            // 
            // DeleteServer
            // 
            this.DeleteServer.Location = new System.Drawing.Point(117, 332);
            this.DeleteServer.Name = "DeleteServer";
            this.DeleteServer.Size = new System.Drawing.Size(47, 23);
            this.DeleteServer.TabIndex = 29;
            this.DeleteServer.Text = "Delete";
            this.DeleteServer.UseVisualStyleBackColor = true;
            this.DeleteServer.Click += new System.EventHandler(this.DeleteServer_Click);
            // 
            // CloneServer
            // 
            this.CloneServer.Location = new System.Drawing.Point(66, 332);
            this.CloneServer.Name = "CloneServer";
            this.CloneServer.Size = new System.Drawing.Size(45, 23);
            this.CloneServer.TabIndex = 30;
            this.CloneServer.Text = "Clone";
            this.CloneServer.UseVisualStyleBackColor = true;
            this.CloneServer.Click += new System.EventHandler(this.CloneServer_Click);
            // 
            // List_TXT
            // 
            this.List_TXT.AutoSize = true;
            this.List_TXT.Location = new System.Drawing.Point(12, 17);
            this.List_TXT.Name = "List_TXT";
            this.List_TXT.Size = new System.Drawing.Size(75, 13);
            this.List_TXT.TabIndex = 31;
            this.List_TXT.Text = "Local Servers:";
            // 
            // ServerSettings
            // 
            this.ServerSettings.Location = new System.Drawing.Point(170, 41);
            this.ServerSettings.Name = "ServerSettings";
            this.ServerSettings.ReadOnly = true;
            this.ServerSettings.Size = new System.Drawing.Size(215, 285);
            this.ServerSettings.TabIndex = 32;
            this.ServerSettings.Text = "";
            // 
            // Settings_TXT
            // 
            this.Settings_TXT.AutoSize = true;
            this.Settings_TXT.Location = new System.Drawing.Point(167, 17);
            this.Settings_TXT.Name = "Settings_TXT";
            this.Settings_TXT.Size = new System.Drawing.Size(82, 13);
            this.Settings_TXT.TabIndex = 33;
            this.Settings_TXT.Text = "Server Settings:";
            // 
            // Restart
            // 
            this.Restart.Enabled = false;
            this.Restart.Location = new System.Drawing.Point(388, 259);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(142, 23);
            this.Restart.TabIndex = 20;
            this.Restart.Text = "Restart Server";
            this.Restart.UseVisualStyleBackColor = true;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // Mngmnt_TXT
            // 
            this.Mngmnt_TXT.AutoSize = true;
            this.Mngmnt_TXT.Location = new System.Drawing.Point(391, 41);
            this.Mngmnt_TXT.Name = "Mngmnt_TXT";
            this.Mngmnt_TXT.Size = new System.Drawing.Size(72, 13);
            this.Mngmnt_TXT.TabIndex = 35;
            this.Mngmnt_TXT.Text = "Management:";
            // 
            // ctrl_TXT
            // 
            this.ctrl_TXT.AutoSize = true;
            this.ctrl_TXT.Location = new System.Drawing.Point(391, 211);
            this.ctrl_TXT.Name = "ctrl_TXT";
            this.ctrl_TXT.Size = new System.Drawing.Size(43, 13);
            this.ctrl_TXT.TabIndex = 37;
            this.ctrl_TXT.Text = "Control:";
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(391, 115);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(139, 23);
            this.Reset.TabIndex = 39;
            this.Reset.Text = "Clear Map and User Data";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // OpenLocal
            // 
            this.OpenLocal.Location = new System.Drawing.Point(388, 288);
            this.OpenLocal.Name = "OpenLocal";
            this.OpenLocal.Size = new System.Drawing.Size(142, 23);
            this.OpenLocal.TabIndex = 40;
            this.OpenLocal.Text = "Open Local Folder";
            this.OpenLocal.UseVisualStyleBackColor = true;
            this.OpenLocal.Click += new System.EventHandler(this.OpenLocal_Click);
            // 
            // XMLEditor
            // 
            this.XMLEditor.Location = new System.Drawing.Point(391, 144);
            this.XMLEditor.Name = "XMLEditor";
            this.XMLEditor.Size = new System.Drawing.Size(139, 23);
            this.XMLEditor.TabIndex = 41;
            this.XMLEditor.Text = "XML Editor";
            this.XMLEditor.UseVisualStyleBackColor = true;
            this.XMLEditor.Click += new System.EventHandler(this.XMLEditor_Click);
            // 
            // JSONEditor
            // 
            this.JSONEditor.Location = new System.Drawing.Point(391, 173);
            this.JSONEditor.Name = "JSONEditor";
            this.JSONEditor.Size = new System.Drawing.Size(139, 23);
            this.JSONEditor.TabIndex = 42;
            this.JSONEditor.Text = "JSON Editor";
            this.JSONEditor.UseVisualStyleBackColor = true;
            this.JSONEditor.Click += new System.EventHandler(this.JSONEditor_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(559, 437);
            this.Controls.Add(this.JSONEditor);
            this.Controls.Add(this.XMLEditor);
            this.Controls.Add(this.OpenLocal);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.ctrl_TXT);
            this.Controls.Add(this.Mngmnt_TXT);
            this.Controls.Add(this.Settings_TXT);
            this.Controls.Add(this.ServerSettings);
            this.Controls.Add(this.List_TXT);
            this.Controls.Add(this.CloneServer);
            this.Controls.Add(this.DeleteServer);
            this.Controls.Add(this.NewServer);
            this.Controls.Add(this.Servers);
            this.Controls.Add(this.LinkMe);
            this.Controls.Add(this.Desc9);
            this.Controls.Add(this.GithubLink);
            this.Controls.Add(this.Updater);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.Toggle);
            this.Controls.Add(this.Plugin);
            this.Controls.Add(this.Workshop);
            this.Controls.Add(this.Settings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unturned Server Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Button Workshop;
        private System.Windows.Forms.Button Plugin;
        private System.Windows.Forms.Button Toggle;
        private System.Windows.Forms.Button Updater;
        private System.Windows.Forms.LinkLabel GithubLink;
        private System.Windows.Forms.Label Desc9;
        private System.Windows.Forms.LinkLabel LinkMe;
        public System.Windows.Forms.NotifyIcon Notifier;
        private System.Windows.Forms.ListBox Servers;
        private System.Windows.Forms.Button NewServer;
        private System.Windows.Forms.Button DeleteServer;
        private System.Windows.Forms.Button CloneServer;
        private System.Windows.Forms.Label List_TXT;
        private System.Windows.Forms.RichTextBox ServerSettings;
        private System.Windows.Forms.Label Settings_TXT;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.Label Mngmnt_TXT;
        private System.Windows.Forms.Label ctrl_TXT;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button OpenLocal;
        private System.Windows.Forms.Button XMLEditor;
        private System.Windows.Forms.Button JSONEditor;
    }
}