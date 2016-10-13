namespace Unturned_Server_Manager
{
    partial class Plugins1
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
            this.Instructions = new System.Windows.Forms.Label();
            this.Plugins = new System.Windows.Forms.CheckedListBox();
            this.SaveAndExit = new System.Windows.Forms.Button();
            this.AlreadyInstalled = new System.Windows.Forms.CheckedListBox();
            this.InstalledDesc = new System.Windows.Forms.Label();
            this.Uninstall = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.InfoClick = new System.Windows.Forms.Button();
            this.SelectAll2 = new System.Windows.Forms.Button();
            this.SelectAll = new System.Windows.Forms.Button();
            this.OpenConfig = new System.Windows.Forms.Button();
            this.CustomInstall = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Instructions
            // 
            this.Instructions.AutoSize = true;
            this.Instructions.Location = new System.Drawing.Point(12, 9);
            this.Instructions.Name = "Instructions";
            this.Instructions.Size = new System.Drawing.Size(380, 13);
            this.Instructions.TabIndex = 0;
            this.Instructions.Text = "Select the plugins you wish to download and install, and press \"Save and Exit\".";
            // 
            // Plugins
            // 
            this.Plugins.CheckOnClick = true;
            this.Plugins.FormattingEnabled = true;
            this.Plugins.Location = new System.Drawing.Point(12, 55);
            this.Plugins.Name = "Plugins";
            this.Plugins.Size = new System.Drawing.Size(381, 289);
            this.Plugins.TabIndex = 1;
            // 
            // SaveAndExit
            // 
            this.SaveAndExit.Location = new System.Drawing.Point(12, 351);
            this.SaveAndExit.Name = "SaveAndExit";
            this.SaveAndExit.Size = new System.Drawing.Size(86, 23);
            this.SaveAndExit.TabIndex = 2;
            this.SaveAndExit.Text = "Save and Exit";
            this.SaveAndExit.UseVisualStyleBackColor = true;
            this.SaveAndExit.Click += new System.EventHandler(this.SaveAndExit_Click);
            // 
            // AlreadyInstalled
            // 
            this.AlreadyInstalled.CheckOnClick = true;
            this.AlreadyInstalled.FormattingEnabled = true;
            this.AlreadyInstalled.Location = new System.Drawing.Point(399, 55);
            this.AlreadyInstalled.Name = "AlreadyInstalled";
            this.AlreadyInstalled.Size = new System.Drawing.Size(285, 289);
            this.AlreadyInstalled.TabIndex = 3;
            // 
            // InstalledDesc
            // 
            this.InstalledDesc.AutoSize = true;
            this.InstalledDesc.Location = new System.Drawing.Point(398, 34);
            this.InstalledDesc.Name = "InstalledDesc";
            this.InstalledDesc.Size = new System.Drawing.Size(124, 13);
            this.InstalledDesc.TabIndex = 4;
            this.InstalledDesc.Text = "Already Installed Plugins:";
            // 
            // Uninstall
            // 
            this.Uninstall.Location = new System.Drawing.Point(545, 351);
            this.Uninstall.Name = "Uninstall";
            this.Uninstall.Size = new System.Drawing.Size(139, 23);
            this.Uninstall.TabIndex = 5;
            this.Uninstall.Text = "Remove Selected Plugins";
            this.Uninstall.UseVisualStyleBackColor = true;
            this.Uninstall.Click += new System.EventHandler(this.Uninstall_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Available Plugins:";
            // 
            // InfoClick
            // 
            this.InfoClick.Location = new System.Drawing.Point(134, 351);
            this.InfoClick.Name = "InfoClick";
            this.InfoClick.Size = new System.Drawing.Size(120, 23);
            this.InfoClick.TabIndex = 7;
            this.InfoClick.Text = "Open Documentation";
            this.InfoClick.UseVisualStyleBackColor = true;
            // 
            // SelectAll2
            // 
            this.SelectAll2.Location = new System.Drawing.Point(578, 29);
            this.SelectAll2.Name = "SelectAll2";
            this.SelectAll2.Size = new System.Drawing.Size(106, 23);
            this.SelectAll2.TabIndex = 8;
            this.SelectAll2.Text = "Select/Unselect All";
            this.SelectAll2.UseVisualStyleBackColor = true;
            this.SelectAll2.Click += new System.EventHandler(this.SelectAll2_Click);
            // 
            // SelectAll
            // 
            this.SelectAll.Location = new System.Drawing.Point(286, 29);
            this.SelectAll.Name = "SelectAll";
            this.SelectAll.Size = new System.Drawing.Size(106, 23);
            this.SelectAll.TabIndex = 9;
            this.SelectAll.Text = "Select/Unselect All";
            this.SelectAll.UseVisualStyleBackColor = true;
            this.SelectAll.Click += new System.EventHandler(this.SelectAll_Click);
            // 
            // OpenConfig
            // 
            this.OpenConfig.Location = new System.Drawing.Point(399, 351);
            this.OpenConfig.Name = "OpenConfig";
            this.OpenConfig.Size = new System.Drawing.Size(123, 23);
            this.OpenConfig.TabIndex = 10;
            this.OpenConfig.Text = "Configurate Selected";
            this.OpenConfig.UseVisualStyleBackColor = true;
            // 
            // CustomInstall
            // 
            this.CustomInstall.Location = new System.Drawing.Point(278, 351);
            this.CustomInstall.Name = "CustomInstall";
            this.CustomInstall.Size = new System.Drawing.Size(114, 23);
            this.CustomInstall.TabIndex = 11;
            this.CustomInstall.Text = "Install Custom Plugin";
            this.CustomInstall.UseVisualStyleBackColor = true;
            // 
            // Plugins1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 386);
            this.Controls.Add(this.CustomInstall);
            this.Controls.Add(this.OpenConfig);
            this.Controls.Add(this.SelectAll);
            this.Controls.Add(this.SelectAll2);
            this.Controls.Add(this.InfoClick);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Uninstall);
            this.Controls.Add(this.InstalledDesc);
            this.Controls.Add(this.AlreadyInstalled);
            this.Controls.Add(this.SaveAndExit);
            this.Controls.Add(this.Plugins);
            this.Controls.Add(this.Instructions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Plugins1";
            this.ShowInTaskbar = false;
            this.Text = "Plugins available";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Instructions;
        private System.Windows.Forms.CheckedListBox Plugins;
        private System.Windows.Forms.Button SaveAndExit;
        private System.Windows.Forms.CheckedListBox AlreadyInstalled;
        private System.Windows.Forms.Label InstalledDesc;
        private System.Windows.Forms.Button Uninstall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button InfoClick;
        private System.Windows.Forms.Button SelectAll2;
        private System.Windows.Forms.Button SelectAll;
        private System.Windows.Forms.Button OpenConfig;
        private System.Windows.Forms.Button CustomInstall;
    }
}