namespace USM
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
            this.Install = new System.Windows.Forms.Button();
            this.DeleteAll = new System.Windows.Forms.Button();
            this.AlreadyInstalled = new System.Windows.Forms.CheckedListBox();
            this.AlreadyInstalledDesc = new System.Windows.Forms.Label();
            this.AvailableDesc = new System.Windows.Forms.Label();
            this.SaveExit = new System.Windows.Forms.Button();
            this.AvailableItems = new System.Windows.Forms.CheckedListBox();
            this.Configuration = new System.Windows.Forms.Button();
            this.Documentation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Install
            // 
            this.Install.Location = new System.Drawing.Point(12, 339);
            this.Install.Name = "Install";
            this.Install.Size = new System.Drawing.Size(117, 23);
            this.Install.TabIndex = 38;
            this.Install.Text = "Install Selected Items";
            this.Install.UseVisualStyleBackColor = true;
            this.Install.Click += new System.EventHandler(this.Install_Click);
            // 
            // DeleteAll
            // 
            this.DeleteAll.Location = new System.Drawing.Point(381, 339);
            this.DeleteAll.Name = "DeleteAll";
            this.DeleteAll.Size = new System.Drawing.Size(73, 23);
            this.DeleteAll.TabIndex = 37;
            this.DeleteAll.Text = "Delete All";
            this.DeleteAll.UseVisualStyleBackColor = true;
            this.DeleteAll.Click += new System.EventHandler(this.DeleteAll_Click);
            // 
            // AlreadyInstalled
            // 
            this.AlreadyInstalled.FormattingEnabled = true;
            this.AlreadyInstalled.Location = new System.Drawing.Point(381, 25);
            this.AlreadyInstalled.Name = "AlreadyInstalled";
            this.AlreadyInstalled.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.AlreadyInstalled.Size = new System.Drawing.Size(360, 304);
            this.AlreadyInstalled.TabIndex = 36;
            // 
            // AlreadyInstalledDesc
            // 
            this.AlreadyInstalledDesc.AutoSize = true;
            this.AlreadyInstalledDesc.Location = new System.Drawing.Point(378, 9);
            this.AlreadyInstalledDesc.Name = "AlreadyInstalledDesc";
            this.AlreadyInstalledDesc.Size = new System.Drawing.Size(124, 13);
            this.AlreadyInstalledDesc.TabIndex = 35;
            this.AlreadyInstalledDesc.Text = "Plugins Already Installed:";
            // 
            // AvailableDesc
            // 
            this.AvailableDesc.AutoSize = true;
            this.AvailableDesc.Location = new System.Drawing.Point(12, 9);
            this.AvailableDesc.Name = "AvailableDesc";
            this.AvailableDesc.Size = new System.Drawing.Size(138, 13);
            this.AvailableDesc.TabIndex = 34;
            this.AvailableDesc.Text = "Available Plugins For Install:";
            // 
            // SaveExit
            // 
            this.SaveExit.Location = new System.Drawing.Point(655, 339);
            this.SaveExit.Name = "SaveExit";
            this.SaveExit.Size = new System.Drawing.Size(82, 23);
            this.SaveExit.TabIndex = 30;
            this.SaveExit.Text = "Save and Exit";
            this.SaveExit.UseVisualStyleBackColor = true;
            this.SaveExit.Click += new System.EventHandler(this.SaveExit_Click);
            // 
            // AvailableItems
            // 
            this.AvailableItems.CheckOnClick = true;
            this.AvailableItems.FormattingEnabled = true;
            this.AvailableItems.Location = new System.Drawing.Point(15, 24);
            this.AvailableItems.Name = "AvailableItems";
            this.AvailableItems.Size = new System.Drawing.Size(360, 304);
            this.AvailableItems.Sorted = true;
            this.AvailableItems.TabIndex = 28;
            // 
            // Configuration
            // 
            this.Configuration.Location = new System.Drawing.Point(501, 339);
            this.Configuration.Name = "Configuration";
            this.Configuration.Size = new System.Drawing.Size(108, 23);
            this.Configuration.TabIndex = 39;
            this.Configuration.Text = "Open Configuration";
            this.Configuration.UseVisualStyleBackColor = true;
            this.Configuration.Click += new System.EventHandler(this.Configuration_Click);
            // 
            // Documentation
            // 
            this.Documentation.Location = new System.Drawing.Point(169, 339);
            this.Documentation.Name = "Documentation";
            this.Documentation.Size = new System.Drawing.Size(206, 23);
            this.Documentation.TabIndex = 40;
            this.Documentation.Text = "Open Documentation On Selected Items";
            this.Documentation.UseVisualStyleBackColor = true;
            this.Documentation.Click += new System.EventHandler(this.Documentation_Click);
            // 
            // Plugin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 374);
            this.Controls.Add(this.Documentation);
            this.Controls.Add(this.Configuration);
            this.Controls.Add(this.Install);
            this.Controls.Add(this.DeleteAll);
            this.Controls.Add(this.AlreadyInstalled);
            this.Controls.Add(this.AlreadyInstalledDesc);
            this.Controls.Add(this.AvailableDesc);
            this.Controls.Add(this.SaveExit);
            this.Controls.Add(this.AvailableItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Plugin";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Plugin Installer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Install;
        private System.Windows.Forms.Button DeleteAll;
        private System.Windows.Forms.CheckedListBox AlreadyInstalled;
        private System.Windows.Forms.Label AlreadyInstalledDesc;
        private System.Windows.Forms.Label AvailableDesc;
        private System.Windows.Forms.Button SaveExit;
        private System.Windows.Forms.CheckedListBox AvailableItems;
        private System.Windows.Forms.Button Configuration;
        private System.Windows.Forms.Button Documentation;
    }
}