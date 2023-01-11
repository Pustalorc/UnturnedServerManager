using System.ComponentModel;
using System.Windows.Forms;

namespace Pustalorc.Applications.USM.GUI
{
    internal sealed partial class Manager
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
            this.components = new System.ComponentModel.Container();
            this.Settings = new System.Windows.Forms.Button();
            this.Workshop = new System.Windows.Forms.Button();
            this.Plugin = new System.Windows.Forms.Button();
            this.Toggle = new System.Windows.Forms.Button();
            this.Updater = new System.Windows.Forms.Button();
            this.Notifier = new System.Windows.Forms.NotifyIcon(this.components);
            this.Servers = new System.Windows.Forms.ListBox();
            this.NewServer = new System.Windows.Forms.Button();
            this.DeleteServer = new System.Windows.Forms.Button();
            this.CloneServer = new System.Windows.Forms.Button();
            this.ServerSettings = new System.Windows.Forms.RichTextBox();
            this.Settings_TXT = new System.Windows.Forms.Label();
            this.Restart = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.OpenLocal = new System.Windows.Forms.Button();
            this.btn_stop_server = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.DarkGreen;
            this.Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings.ForeColor = System.Drawing.SystemColors.Control;
            this.Settings.Location = new System.Drawing.Point(732, 362);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(245, 47);
            this.Settings.TabIndex = 7;
            this.Settings.Text = " Server Settings";
            this.Settings.UseVisualStyleBackColor = false;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // Workshop
            // 
            this.Workshop.BackColor = System.Drawing.Color.DarkGreen;
            this.Workshop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Workshop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Workshop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Workshop.ForeColor = System.Drawing.SystemColors.Control;
            this.Workshop.Location = new System.Drawing.Point(706, 124);
            this.Workshop.Name = "Workshop";
            this.Workshop.Size = new System.Drawing.Size(245, 42);
            this.Workshop.TabIndex = 16;
            this.Workshop.Text = "Workshop Content";
            this.Workshop.UseVisualStyleBackColor = false;
            this.Workshop.Click += new System.EventHandler(this.Workshop_Click);
            // 
            // Plugin
            // 
            this.Plugin.BackColor = System.Drawing.Color.DarkGreen;
            this.Plugin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Plugin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Plugin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plugin.ForeColor = System.Drawing.SystemColors.Control;
            this.Plugin.Location = new System.Drawing.Point(563, 479);
            this.Plugin.Name = "Plugin";
            this.Plugin.Size = new System.Drawing.Size(245, 39);
            this.Plugin.TabIndex = 17;
            this.Plugin.Text = "Rocket Plugins";
            this.Plugin.UseVisualStyleBackColor = false;
            this.Plugin.Click += new System.EventHandler(this.Plugin_Click);
            // 
            // Toggle
            // 
            this.Toggle.BackColor = System.Drawing.Color.LimeGreen;
            this.Toggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Toggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Toggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Toggle.ForeColor = System.Drawing.SystemColors.Control;
            this.Toggle.Location = new System.Drawing.Point(341, 381);
            this.Toggle.Name = "Toggle";
            this.Toggle.Size = new System.Drawing.Size(333, 44);
            this.Toggle.TabIndex = 18;
            this.Toggle.Text = "Start Server";
            this.Toggle.UseVisualStyleBackColor = false;
            this.Toggle.Click += new System.EventHandler(this.Toggle_Click);
            // 
            // Updater
            // 
            this.Updater.BackColor = System.Drawing.Color.DarkGreen;
            this.Updater.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Updater.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Updater.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updater.ForeColor = System.Drawing.SystemColors.Control;
            this.Updater.Location = new System.Drawing.Point(814, 479);
            this.Updater.Name = "Updater";
            this.Updater.Size = new System.Drawing.Size(163, 38);
            this.Updater.TabIndex = 22;
            this.Updater.Text = "Update Tool";
            this.Updater.UseVisualStyleBackColor = false;
            this.Updater.Click += new System.EventHandler(this.Updater_Click);
            // 
            // Notifier
            // 
            this.Notifier.BalloonTipText = "Unturned Server Manager";
            this.Notifier.BalloonTipTitle = "Unturned Server Manager";
            this.Notifier.Text = "Unturned Server Manager";
            this.Notifier.Visible = true;
            this.Notifier.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Notifier_MouseDoubleClick);
            // 
            // Servers
            // 
            this.Servers.BackColor = System.Drawing.Color.Green;
            this.Servers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Servers.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.Servers.FormattingEnabled = true;
            this.Servers.ItemHeight = 25;
            this.Servers.Location = new System.Drawing.Point(12, 96);
            this.Servers.Name = "Servers";
            this.Servers.Size = new System.Drawing.Size(328, 279);
            this.Servers.TabIndex = 27;
            this.Servers.SelectedIndexChanged += new System.EventHandler(this.Servers_SelectedIndexChanged);
            // 
            // NewServer
            // 
            this.NewServer.BackColor = System.Drawing.Color.LimeGreen;
            this.NewServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewServer.ForeColor = System.Drawing.SystemColors.Control;
            this.NewServer.Location = new System.Drawing.Point(12, 390);
            this.NewServer.Name = "NewServer";
            this.NewServer.Size = new System.Drawing.Size(148, 38);
            this.NewServer.TabIndex = 28;
            this.NewServer.Text = "New";
            this.NewServer.UseVisualStyleBackColor = false;
            this.NewServer.Click += new System.EventHandler(this.NewServer_Click);
            // 
            // DeleteServer
            // 
            this.DeleteServer.BackColor = System.Drawing.Color.Red;
            this.DeleteServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteServer.ForeColor = System.Drawing.SystemColors.Control;
            this.DeleteServer.Location = new System.Drawing.Point(12, 475);
            this.DeleteServer.Name = "DeleteServer";
            this.DeleteServer.Size = new System.Drawing.Size(148, 38);
            this.DeleteServer.TabIndex = 29;
            this.DeleteServer.Text = "Delete";
            this.DeleteServer.UseVisualStyleBackColor = false;
            this.DeleteServer.Click += new System.EventHandler(this.DeleteServer_Click);
            // 
            // CloneServer
            // 
            this.CloneServer.BackColor = System.Drawing.Color.Gold;
            this.CloneServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloneServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloneServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloneServer.ForeColor = System.Drawing.Color.Black;
            this.CloneServer.Location = new System.Drawing.Point(12, 431);
            this.CloneServer.Name = "CloneServer";
            this.CloneServer.Size = new System.Drawing.Size(148, 38);
            this.CloneServer.TabIndex = 30;
            this.CloneServer.Text = "Clone";
            this.CloneServer.UseVisualStyleBackColor = false;
            this.CloneServer.Click += new System.EventHandler(this.CloneServer_Click);
            // 
            // ServerSettings
            // 
            this.ServerSettings.BackColor = System.Drawing.Color.ForestGreen;
            this.ServerSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerSettings.ForeColor = System.Drawing.SystemColors.Window;
            this.ServerSettings.Location = new System.Drawing.Point(346, 96);
            this.ServerSettings.Name = "ServerSettings";
            this.ServerSettings.ReadOnly = true;
            this.ServerSettings.Size = new System.Drawing.Size(328, 279);
            this.ServerSettings.TabIndex = 32;
            this.ServerSettings.Text = "";
            this.ServerSettings.TextChanged += new System.EventHandler(this.ServerSettings_TextChanged);
            // 
            // Settings_TXT
            // 
            this.Settings_TXT.AutoSize = true;
            this.Settings_TXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings_TXT.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Settings_TXT.Location = new System.Drawing.Point(12, 32);
            this.Settings_TXT.Name = "Settings_TXT";
            this.Settings_TXT.Size = new System.Drawing.Size(159, 31);
            this.Settings_TXT.TabIndex = 33;
            this.Settings_TXT.Text = "You Server";
            this.Settings_TXT.Click += new System.EventHandler(this.Settings_TXT_Click);
            // 
            // Restart
            // 
            this.Restart.BackColor = System.Drawing.Color.DarkRed;
            this.Restart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Restart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Restart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Restart.Location = new System.Drawing.Point(341, 424);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(333, 45);
            this.Restart.TabIndex = 20;
            this.Restart.Text = "Restart Server";
            this.Restart.UseVisualStyleBackColor = false;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.DarkGreen;
            this.Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.ForeColor = System.Drawing.SystemColors.Control;
            this.Reset.Location = new System.Drawing.Point(706, 172);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(245, 67);
            this.Reset.TabIndex = 39;
            this.Reset.Text = "Clear Map and User Data";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // OpenLocal
            // 
            this.OpenLocal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenLocal.ForeColor = System.Drawing.SystemColors.Control;
            this.OpenLocal.Location = new System.Drawing.Point(732, 415);
            this.OpenLocal.Name = "OpenLocal";
            this.OpenLocal.Size = new System.Drawing.Size(245, 45);
            this.OpenLocal.TabIndex = 40;
            this.OpenLocal.Text = "Open Local Folder";
            this.OpenLocal.UseVisualStyleBackColor = true;
            this.OpenLocal.Click += new System.EventHandler(this.OpenLocal_Click);
            // 
            // btn_stop_server
            // 
            this.btn_stop_server.BackColor = System.Drawing.Color.Red;
            this.btn_stop_server.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_stop_server.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stop_server.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stop_server.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_stop_server.Location = new System.Drawing.Point(341, 381);
            this.btn_stop_server.Name = "btn_stop_server";
            this.btn_stop_server.Size = new System.Drawing.Size(333, 44);
            this.btn_stop_server.TabIndex = 41;
            this.btn_stop_server.Text = "Stop Server";
            this.btn_stop_server.UseVisualStyleBackColor = false;
            this.btn_stop_server.Click += new System.EventHandler(this.tn_stop_server_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(989, 529);
            this.Controls.Add(this.OpenLocal);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Settings_TXT);
            this.Controls.Add(this.ServerSettings);
            this.Controls.Add(this.CloneServer);
            this.Controls.Add(this.DeleteServer);
            this.Controls.Add(this.NewServer);
            this.Controls.Add(this.Servers);
            this.Controls.Add(this.Updater);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.Toggle);
            this.Controls.Add(this.Plugin);
            this.Controls.Add(this.Workshop);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.btn_stop_server);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unturned Server Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button Settings;
        private Button Workshop;
        private Button Plugin;
        private Button Toggle;
        private Button Updater;
        public NotifyIcon Notifier;
        private ListBox Servers;
        private Button NewServer;
        private Button DeleteServer;
        private Button CloneServer;
        private RichTextBox ServerSettings;
        private Label Settings_TXT;
        private Button Restart;
        private Button Reset;
        private Button OpenLocal;
        private Button btn_stop_server;
    }
}