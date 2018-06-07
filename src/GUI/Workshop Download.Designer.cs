namespace ATORTTeam.UnturnedServerManager.GUI
{
    partial class Workshop
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
            this.DeleteAll = new System.Windows.Forms.Button();
            this.AlreadyInstalledDesc = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.Desc1 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.Desc2 = new System.Windows.Forms.Label();
            this.Desc3 = new System.Windows.Forms.Label();
            this.Desc4 = new System.Windows.Forms.Label();
            this.Link = new System.Windows.Forms.TextBox();
            this.InstallID = new System.Windows.Forms.Button();
            this.UpdateAll = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.View = new System.Windows.Forms.Button();
            this.AlreadyInstalled = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // DeleteAll
            // 
            this.DeleteAll.Enabled = false;
            this.DeleteAll.Location = new System.Drawing.Point(12, 306);
            this.DeleteAll.Name = "DeleteAll";
            this.DeleteAll.Size = new System.Drawing.Size(62, 23);
            this.DeleteAll.TabIndex = 24;
            this.DeleteAll.Text = "Delete All";
            this.DeleteAll.UseVisualStyleBackColor = true;
            this.DeleteAll.Click += new System.EventHandler(this.DeleteAll_Click);
            // 
            // AlreadyInstalledDesc
            // 
            this.AlreadyInstalledDesc.AutoSize = true;
            this.AlreadyInstalledDesc.Location = new System.Drawing.Point(12, 9);
            this.AlreadyInstalledDesc.Name = "AlreadyInstalledDesc";
            this.AlreadyInstalledDesc.Size = new System.Drawing.Size(129, 13);
            this.AlreadyInstalledDesc.TabIndex = 22;
            this.AlreadyInstalledDesc.Text = "Installed Workshop Items:";
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(493, 306);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(38, 23);
            this.Exit.TabIndex = 17;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Desc1
            // 
            this.Desc1.AutoSize = true;
            this.Desc1.Location = new System.Drawing.Point(342, 9);
            this.Desc1.Name = "Desc1";
            this.Desc1.Size = new System.Drawing.Size(189, 13);
            this.Desc1.TabIndex = 27;
            this.Desc1.Text = "Install By ID or link to steam workshop:";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(378, 37);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(153, 20);
            this.ID.TabIndex = 28;
            this.ID.TextChanged += new System.EventHandler(this.ID_TextChanged);
            // 
            // Desc2
            // 
            this.Desc2.AutoSize = true;
            this.Desc2.Location = new System.Drawing.Point(342, 40);
            this.Desc2.Name = "Desc2";
            this.Desc2.Size = new System.Drawing.Size(21, 13);
            this.Desc2.TabIndex = 29;
            this.Desc2.Text = "ID:";
            // 
            // Desc3
            // 
            this.Desc3.AutoSize = true;
            this.Desc3.Location = new System.Drawing.Point(342, 72);
            this.Desc3.Name = "Desc3";
            this.Desc3.Size = new System.Drawing.Size(23, 13);
            this.Desc3.TabIndex = 30;
            this.Desc3.Text = "OR";
            // 
            // Desc4
            // 
            this.Desc4.AutoSize = true;
            this.Desc4.Location = new System.Drawing.Point(342, 103);
            this.Desc4.Name = "Desc4";
            this.Desc4.Size = new System.Drawing.Size(30, 13);
            this.Desc4.TabIndex = 31;
            this.Desc4.Text = "Link:";
            // 
            // Link
            // 
            this.Link.Location = new System.Drawing.Point(378, 100);
            this.Link.Name = "Link";
            this.Link.Size = new System.Drawing.Size(153, 20);
            this.Link.TabIndex = 32;
            this.Link.TextChanged += new System.EventHandler(this.Link_TextChanged);
            // 
            // InstallID
            // 
            this.InstallID.Location = new System.Drawing.Point(432, 126);
            this.InstallID.Name = "InstallID";
            this.InstallID.Size = new System.Drawing.Size(99, 23);
            this.InstallID.TabIndex = 33;
            this.InstallID.Text = "Install by id or link";
            this.InstallID.UseVisualStyleBackColor = true;
            this.InstallID.Click += new System.EventHandler(this.InstallID_Click);
            // 
            // UpdateAll
            // 
            this.UpdateAll.Enabled = false;
            this.UpdateAll.Location = new System.Drawing.Point(80, 306);
            this.UpdateAll.Name = "UpdateAll";
            this.UpdateAll.Size = new System.Drawing.Size(65, 23);
            this.UpdateAll.TabIndex = 34;
            this.UpdateAll.Text = "Update All";
            this.UpdateAll.UseVisualStyleBackColor = true;
            this.UpdateAll.Click += new System.EventHandler(this.UpdateAll_Click);
            // 
            // Delete
            // 
            this.Delete.Enabled = false;
            this.Delete.Location = new System.Drawing.Point(151, 306);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(92, 23);
            this.Delete.TabIndex = 35;
            this.Delete.Text = "Delete Selected";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // View
            // 
            this.View.Enabled = false;
            this.View.Location = new System.Drawing.Point(249, 306);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(87, 23);
            this.View.TabIndex = 36;
            this.View.Text = "View on Steam";
            this.View.UseVisualStyleBackColor = true;
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // AlreadyInstalled
            // 
            this.AlreadyInstalled.FormattingEnabled = true;
            this.AlreadyInstalled.Location = new System.Drawing.Point(12, 25);
            this.AlreadyInstalled.Name = "AlreadyInstalled";
            this.AlreadyInstalled.Size = new System.Drawing.Size(324, 277);
            this.AlreadyInstalled.TabIndex = 37;
            this.AlreadyInstalled.SelectedIndexChanged += new System.EventHandler(this.AlreadyInstalled_SelectedIndexChanged);
            // 
            // Workshop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(543, 341);
            this.Controls.Add(this.AlreadyInstalled);
            this.Controls.Add(this.View);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.UpdateAll);
            this.Controls.Add(this.InstallID);
            this.Controls.Add(this.Link);
            this.Controls.Add(this.Desc4);
            this.Controls.Add(this.Desc3);
            this.Controls.Add(this.Desc2);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Desc1);
            this.Controls.Add(this.DeleteAll);
            this.Controls.Add(this.AlreadyInstalledDesc);
            this.Controls.Add(this.Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Workshop";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Managing Workshop Items";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button DeleteAll;
        private System.Windows.Forms.Label AlreadyInstalledDesc;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label Desc1;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label Desc2;
        private System.Windows.Forms.Label Desc3;
        private System.Windows.Forms.Label Desc4;
        private System.Windows.Forms.TextBox Link;
        private System.Windows.Forms.Button InstallID;
        private System.Windows.Forms.Button UpdateAll;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button View;
        private System.Windows.Forms.ListBox AlreadyInstalled;
    }
}