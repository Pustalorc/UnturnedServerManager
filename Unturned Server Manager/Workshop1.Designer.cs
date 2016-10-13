namespace Unturned_Server_Manager
{
    partial class Workshop1
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
            this.DirectoryDesc = new System.Windows.Forms.Label();
            this.WorkshopLocation = new System.Windows.Forms.TextBox();
            this.AvailableItems = new System.Windows.Forms.CheckedListBox();
            this.Search = new System.Windows.Forms.Button();
            this.SaveExit = new System.Windows.Forms.Button();
            this.ContentLocation = new System.Windows.Forms.RadioButton();
            this.MapsLocation = new System.Windows.Forms.RadioButton();
            this.SelTyp = new System.Windows.Forms.Label();
            this.AvailableDesc = new System.Windows.Forms.Label();
            this.AlreadyInstalledDesc = new System.Windows.Forms.Label();
            this.AlreadyInstalled = new System.Windows.Forms.CheckedListBox();
            this.DeleteAll = new System.Windows.Forms.Button();
            this.Install = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DirectoryDesc
            // 
            this.DirectoryDesc.AutoSize = true;
            this.DirectoryDesc.Location = new System.Drawing.Point(12, 17);
            this.DirectoryDesc.Name = "DirectoryDesc";
            this.DirectoryDesc.Size = new System.Drawing.Size(141, 13);
            this.DirectoryDesc.TabIndex = 0;
            this.DirectoryDesc.Text = "Workshop Folders Directory:";
            // 
            // WorkshopLocation
            // 
            this.WorkshopLocation.Location = new System.Drawing.Point(159, 14);
            this.WorkshopLocation.Name = "WorkshopLocation";
            this.WorkshopLocation.Size = new System.Drawing.Size(341, 20);
            this.WorkshopLocation.TabIndex = 1;
            this.WorkshopLocation.Text = "C:\\Program Files (x86)\\Steam\\steamapps\\workshop\\content\\304930";
            // 
            // AvailableItems
            // 
            this.AvailableItems.CheckOnClick = true;
            this.AvailableItems.FormattingEnabled = true;
            this.AvailableItems.Location = new System.Drawing.Point(15, 56);
            this.AvailableItems.Name = "AvailableItems";
            this.AvailableItems.Size = new System.Drawing.Size(485, 274);
            this.AvailableItems.TabIndex = 2;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(506, 12);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(143, 23);
            this.Search.TabIndex = 3;
            this.Search.Text = "Search for workshop items";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // SaveExit
            // 
            this.SaveExit.Location = new System.Drawing.Point(655, 12);
            this.SaveExit.Name = "SaveExit";
            this.SaveExit.Size = new System.Drawing.Size(82, 23);
            this.SaveExit.TabIndex = 4;
            this.SaveExit.Text = "Save and Exit";
            this.SaveExit.UseVisualStyleBackColor = true;
            this.SaveExit.Click += new System.EventHandler(this.SaveExit_Click);
            // 
            // ContentLocation
            // 
            this.ContentLocation.AutoSize = true;
            this.ContentLocation.Checked = true;
            this.ContentLocation.Location = new System.Drawing.Point(510, 67);
            this.ContentLocation.Name = "ContentLocation";
            this.ContentLocation.Size = new System.Drawing.Size(143, 17);
            this.ContentLocation.TabIndex = 5;
            this.ContentLocation.TabStop = true;
            this.ContentLocation.Text = "Content (Items and such)";
            this.ContentLocation.UseVisualStyleBackColor = true;
            this.ContentLocation.CheckedChanged += new System.EventHandler(this.ContentLocation_CheckedChanged);
            // 
            // MapsLocation
            // 
            this.MapsLocation.AutoSize = true;
            this.MapsLocation.Location = new System.Drawing.Point(510, 90);
            this.MapsLocation.Name = "MapsLocation";
            this.MapsLocation.Size = new System.Drawing.Size(51, 17);
            this.MapsLocation.TabIndex = 6;
            this.MapsLocation.Text = "Maps";
            this.MapsLocation.UseVisualStyleBackColor = true;
            this.MapsLocation.CheckedChanged += new System.EventHandler(this.MapsLocation_CheckedChanged);
            // 
            // SelTyp
            // 
            this.SelTyp.AutoSize = true;
            this.SelTyp.Location = new System.Drawing.Point(503, 51);
            this.SelTyp.Name = "SelTyp";
            this.SelTyp.Size = new System.Drawing.Size(245, 13);
            this.SelTyp.TabIndex = 7;
            this.SelTyp.Text = "Select type of workshop items that will be installed:";
            // 
            // AvailableDesc
            // 
            this.AvailableDesc.AutoSize = true;
            this.AvailableDesc.Location = new System.Drawing.Point(12, 41);
            this.AvailableDesc.Name = "AvailableDesc";
            this.AvailableDesc.Size = new System.Drawing.Size(133, 13);
            this.AvailableDesc.TabIndex = 8;
            this.AvailableDesc.Text = "Available Workshop Items:";
            // 
            // AlreadyInstalledDesc
            // 
            this.AlreadyInstalledDesc.AutoSize = true;
            this.AlreadyInstalledDesc.Location = new System.Drawing.Point(507, 115);
            this.AlreadyInstalledDesc.Name = "AlreadyInstalledDesc";
            this.AlreadyInstalledDesc.Size = new System.Drawing.Size(167, 13);
            this.AlreadyInstalledDesc.TabIndex = 9;
            this.AlreadyInstalledDesc.Text = "Workshop Items Already Installed:";
            // 
            // AlreadyInstalled
            // 
            this.AlreadyInstalled.Enabled = false;
            this.AlreadyInstalled.FormattingEnabled = true;
            this.AlreadyInstalled.Location = new System.Drawing.Point(510, 131);
            this.AlreadyInstalled.Name = "AlreadyInstalled";
            this.AlreadyInstalled.Size = new System.Drawing.Size(231, 199);
            this.AlreadyInstalled.TabIndex = 10;
            // 
            // DeleteAll
            // 
            this.DeleteAll.Location = new System.Drawing.Point(510, 336);
            this.DeleteAll.Name = "DeleteAll";
            this.DeleteAll.Size = new System.Drawing.Size(231, 23);
            this.DeleteAll.TabIndex = 11;
            this.DeleteAll.Text = "Delete ALL Installed Workshop Items";
            this.DeleteAll.UseVisualStyleBackColor = true;
            this.DeleteAll.Click += new System.EventHandler(this.DeleteAll_Click);
            // 
            // Install
            // 
            this.Install.Location = new System.Drawing.Point(12, 336);
            this.Install.Name = "Install";
            this.Install.Size = new System.Drawing.Size(117, 23);
            this.Install.TabIndex = 12;
            this.Install.Text = "Install Selected Items";
            this.Install.UseVisualStyleBackColor = true;
            this.Install.Click += new System.EventHandler(this.Install_Click);
            // 
            // Workshop1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 374);
            this.Controls.Add(this.Install);
            this.Controls.Add(this.DeleteAll);
            this.Controls.Add(this.AlreadyInstalled);
            this.Controls.Add(this.AlreadyInstalledDesc);
            this.Controls.Add(this.AvailableDesc);
            this.Controls.Add(this.SelTyp);
            this.Controls.Add(this.MapsLocation);
            this.Controls.Add(this.ContentLocation);
            this.Controls.Add(this.SaveExit);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.AvailableItems);
            this.Controls.Add(this.WorkshopLocation);
            this.Controls.Add(this.DirectoryDesc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Workshop1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Available Workshop Items For Server 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DirectoryDesc;
        private System.Windows.Forms.TextBox WorkshopLocation;
        private System.Windows.Forms.CheckedListBox AvailableItems;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button SaveExit;
        private System.Windows.Forms.RadioButton ContentLocation;
        private System.Windows.Forms.RadioButton MapsLocation;
        private System.Windows.Forms.Label SelTyp;
        private System.Windows.Forms.Label AvailableDesc;
        private System.Windows.Forms.Label AlreadyInstalledDesc;
        private System.Windows.Forms.CheckedListBox AlreadyInstalled;
        private System.Windows.Forms.Button DeleteAll;
        private System.Windows.Forms.Button Install;
    }
}