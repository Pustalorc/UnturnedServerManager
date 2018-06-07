namespace ATORTTeam.UnturnedServerManager.GUI
{
    partial class Plugin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Plugin));
            this.DeleteAll = new System.Windows.Forms.Button();
            this.AlreadyInstalledDesc = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.Configuration = new System.Windows.Forms.Button();
            this.AlreadyInstalled = new System.Windows.Forms.ListBox();
            this.Delete = new System.Windows.Forms.Button();
            this.Install = new System.Windows.Forms.Button();
            this.OpenZip = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // DeleteAll
            // 
            this.DeleteAll.Location = new System.Drawing.Point(15, 334);
            this.DeleteAll.Name = "DeleteAll";
            this.DeleteAll.Size = new System.Drawing.Size(61, 23);
            this.DeleteAll.TabIndex = 37;
            this.DeleteAll.Text = "Delete All";
            this.DeleteAll.UseVisualStyleBackColor = true;
            this.DeleteAll.Click += new System.EventHandler(this.DeleteAll_Click);
            // 
            // AlreadyInstalledDesc
            // 
            this.AlreadyInstalledDesc.AutoSize = true;
            this.AlreadyInstalledDesc.Location = new System.Drawing.Point(12, 9);
            this.AlreadyInstalledDesc.Name = "AlreadyInstalledDesc";
            this.AlreadyInstalledDesc.Size = new System.Drawing.Size(124, 13);
            this.AlreadyInstalledDesc.TabIndex = 35;
            this.AlreadyInstalledDesc.Text = "Plugins Already Installed:";
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(386, 334);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(37, 23);
            this.Exit.TabIndex = 30;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Configuration
            // 
            this.Configuration.Location = new System.Drawing.Point(272, 334);
            this.Configuration.Name = "Configuration";
            this.Configuration.Size = new System.Drawing.Size(108, 23);
            this.Configuration.TabIndex = 39;
            this.Configuration.Text = "Open Configuration";
            this.Configuration.UseVisualStyleBackColor = true;
            this.Configuration.Click += new System.EventHandler(this.Configuration_Click);
            // 
            // AlreadyInstalled
            // 
            this.AlreadyInstalled.FormattingEnabled = true;
            this.AlreadyInstalled.Location = new System.Drawing.Point(15, 25);
            this.AlreadyInstalled.Name = "AlreadyInstalled";
            this.AlreadyInstalled.Size = new System.Drawing.Size(408, 303);
            this.AlreadyInstalled.TabIndex = 40;
            this.AlreadyInstalled.SelectedIndexChanged += new System.EventHandler(this.AlreadyInstalled_SelectedIndexChanged);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(82, 334);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(92, 23);
            this.Delete.TabIndex = 41;
            this.Delete.Text = "Delete Selected";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Install
            // 
            this.Install.Location = new System.Drawing.Point(180, 334);
            this.Install.Name = "Install";
            this.Install.Size = new System.Drawing.Size(86, 23);
            this.Install.TabIndex = 42;
            this.Install.Text = "Install From Zip";
            this.Install.UseVisualStyleBackColor = true;
            this.Install.Click += new System.EventHandler(this.Install_Click);
            // 
            // OpenZip
            // 
            this.OpenZip.DefaultExt = "dll";
            this.OpenZip.Filter = "\"Compressed (zipped) Folder\" (*.zip)|*.zip";
            this.OpenZip.RestoreDirectory = true;
            // 
            // Plugin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(441, 374);
            this.Controls.Add(this.Install);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.AlreadyInstalled);
            this.Controls.Add(this.Configuration);
            this.Controls.Add(this.DeleteAll);
            this.Controls.Add(this.AlreadyInstalledDesc);
            this.Controls.Add(this.Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Plugin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plugin Installer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button DeleteAll;
        private System.Windows.Forms.Label AlreadyInstalledDesc;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Configuration;
        private System.Windows.Forms.ListBox AlreadyInstalled;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Install;
        private System.Windows.Forms.OpenFileDialog OpenZip;
    }
}