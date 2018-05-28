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
            this.Install = new System.Windows.Forms.Button();
            this.DeleteAll = new System.Windows.Forms.Button();
            this.AlreadyInstalled = new System.Windows.Forms.CheckedListBox();
            this.AlreadyInstalledDesc = new System.Windows.Forms.Label();
            this.AvailableDesc = new System.Windows.Forms.Label();
            this.SelTyp = new System.Windows.Forms.Label();
            this.MapsLocation = new System.Windows.Forms.RadioButton();
            this.ContentLocation = new System.Windows.Forms.RadioButton();
            this.SaveExit = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.AvailableItems = new System.Windows.Forms.CheckedListBox();
            this.WorkshopLocation = new System.Windows.Forms.TextBox();
            this.DirectoryDesc = new System.Windows.Forms.Label();
            this.OpenMods = new System.Windows.Forms.Button();
            this.Desc1 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.Desc2 = new System.Windows.Forms.Label();
            this.Desc3 = new System.Windows.Forms.Label();
            this.Desc4 = new System.Windows.Forms.Label();
            this.Link = new System.Windows.Forms.TextBox();
            this.InstallID = new System.Windows.Forms.Button();
            this.UpdateAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Install
            // 
            this.Install.Location = new System.Drawing.Point(8, 338);
            this.Install.Name = "Install";
            this.Install.Size = new System.Drawing.Size(117, 23);
            this.Install.TabIndex = 25;
            this.Install.Text = "Install Selected Items";
            this.Install.UseVisualStyleBackColor = true;
            //this.Install.Click += new System.EventHandler(this.Install_Click);
            // 
            // DeleteAll
            // 
            this.DeleteAll.Location = new System.Drawing.Point(262, 339);
            this.DeleteAll.Name = "DeleteAll";
            this.DeleteAll.Size = new System.Drawing.Size(231, 23);
            this.DeleteAll.TabIndex = 24;
            this.DeleteAll.Text = "Delete ALL Installed Workshop Items";
            this.DeleteAll.UseVisualStyleBackColor = true;
            //this.DeleteAll.Click += new System.EventHandler(this.DeleteAll_Click);
            // 
            // AlreadyInstalled
            // 
            this.AlreadyInstalled.BackColor = System.Drawing.SystemColors.Window;
            this.AlreadyInstalled.FormattingEnabled = true;
            this.AlreadyInstalled.Location = new System.Drawing.Point(253, 59);
            this.AlreadyInstalled.Name = "AlreadyInstalled";
            this.AlreadyInstalled.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.AlreadyInstalled.Size = new System.Drawing.Size(240, 274);
            this.AlreadyInstalled.Sorted = true;
            this.AlreadyInstalled.TabIndex = 23;
            // 
            // AlreadyInstalledDesc
            // 
            this.AlreadyInstalledDesc.AutoSize = true;
            this.AlreadyInstalledDesc.Location = new System.Drawing.Point(250, 43);
            this.AlreadyInstalledDesc.Name = "AlreadyInstalledDesc";
            this.AlreadyInstalledDesc.Size = new System.Drawing.Size(167, 13);
            this.AlreadyInstalledDesc.TabIndex = 22;
            this.AlreadyInstalledDesc.Text = "Workshop Items Already Installed:";
            // 
            // AvailableDesc
            // 
            this.AvailableDesc.AutoSize = true;
            this.AvailableDesc.Location = new System.Drawing.Point(8, 43);
            this.AvailableDesc.Name = "AvailableDesc";
            this.AvailableDesc.Size = new System.Drawing.Size(133, 13);
            this.AvailableDesc.TabIndex = 21;
            this.AvailableDesc.Text = "Available Workshop Items:";
            // 
            // SelTyp
            // 
            this.SelTyp.AutoSize = true;
            this.SelTyp.Location = new System.Drawing.Point(499, 53);
            this.SelTyp.Name = "SelTyp";
            this.SelTyp.Size = new System.Drawing.Size(245, 13);
            this.SelTyp.TabIndex = 20;
            this.SelTyp.Text = "Select type of workshop items that will be installed:";
            // 
            // MapsLocation
            // 
            this.MapsLocation.AutoSize = true;
            this.MapsLocation.Location = new System.Drawing.Point(502, 101);
            this.MapsLocation.Name = "MapsLocation";
            this.MapsLocation.Size = new System.Drawing.Size(51, 17);
            this.MapsLocation.TabIndex = 19;
            this.MapsLocation.Text = "Maps";
            this.MapsLocation.UseVisualStyleBackColor = true;
            //this.MapsLocation.CheckedChanged += new System.EventHandler(this.MapsLocation_CheckedChanged);
            // 
            // ContentLocation
            // 
            this.ContentLocation.AutoSize = true;
            this.ContentLocation.Checked = true;
            this.ContentLocation.Location = new System.Drawing.Point(502, 78);
            this.ContentLocation.Name = "ContentLocation";
            this.ContentLocation.Size = new System.Drawing.Size(200, 17);
            this.ContentLocation.TabIndex = 18;
            this.ContentLocation.TabStop = true;
            this.ContentLocation.Text = "Content (Items, NPC\'s, Recipes, etc.)";
            this.ContentLocation.UseVisualStyleBackColor = true;
            //this.ContentLocation.CheckedChanged += new System.EventHandler(this.ContentLocation_CheckedChanged);
            // 
            // SaveExit
            // 
            this.SaveExit.Location = new System.Drawing.Point(651, 14);
            this.SaveExit.Name = "SaveExit";
            this.SaveExit.Size = new System.Drawing.Size(82, 23);
            this.SaveExit.TabIndex = 17;
            this.SaveExit.Text = "Save and Exit";
            this.SaveExit.UseVisualStyleBackColor = true;
            //this.SaveExit.Click += new System.EventHandler(this.SaveExit_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(502, 14);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(143, 23);
            this.Search.TabIndex = 16;
            this.Search.Text = "Search for workshop items";
            this.Search.UseVisualStyleBackColor = true;
            //this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // AvailableItems
            // 
            this.AvailableItems.BackColor = System.Drawing.SystemColors.Window;
            this.AvailableItems.CheckOnClick = true;
            this.AvailableItems.FormattingEnabled = true;
            this.AvailableItems.Location = new System.Drawing.Point(8, 59);
            this.AvailableItems.Name = "AvailableItems";
            this.AvailableItems.Size = new System.Drawing.Size(239, 274);
            this.AvailableItems.Sorted = true;
            this.AvailableItems.TabIndex = 15;
            // 
            // WorkshopLocation
            // 
            this.WorkshopLocation.Location = new System.Drawing.Point(155, 16);
            this.WorkshopLocation.Name = "WorkshopLocation";
            this.WorkshopLocation.Size = new System.Drawing.Size(341, 20);
            this.WorkshopLocation.TabIndex = 14;
            this.WorkshopLocation.Text = "C:\\Program Files (x86)\\Steam\\steamapps\\workshop\\content\\304930";
            // 
            // DirectoryDesc
            // 
            this.DirectoryDesc.AutoSize = true;
            this.DirectoryDesc.Location = new System.Drawing.Point(8, 19);
            this.DirectoryDesc.Name = "DirectoryDesc";
            this.DirectoryDesc.Size = new System.Drawing.Size(141, 13);
            this.DirectoryDesc.TabIndex = 13;
            this.DirectoryDesc.Text = "Workshop Folders Directory:";
            // 
            // OpenMods
            // 
            this.OpenMods.Location = new System.Drawing.Point(145, 339);
            this.OpenMods.Name = "OpenMods";
            this.OpenMods.Size = new System.Drawing.Size(102, 23);
            this.OpenMods.TabIndex = 26;
            this.OpenMods.Text = "Open In Browser";
            this.OpenMods.UseVisualStyleBackColor = true;
            //this.OpenMods.Click += new System.EventHandler(this.OpenMods_Click);
            // 
            // Desc1
            // 
            this.Desc1.AutoSize = true;
            this.Desc1.Location = new System.Drawing.Point(502, 222);
            this.Desc1.Name = "Desc1";
            this.Desc1.Size = new System.Drawing.Size(189, 13);
            this.Desc1.TabIndex = 27;
            this.Desc1.Text = "Install By ID or link to steam workshop:";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(538, 250);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(100, 20);
            this.ID.TabIndex = 28;
            //this.ID.TextChanged += new System.EventHandler(this.ID_TextChanged);
            // 
            // Desc2
            // 
            this.Desc2.AutoSize = true;
            this.Desc2.Location = new System.Drawing.Point(502, 253);
            this.Desc2.Name = "Desc2";
            this.Desc2.Size = new System.Drawing.Size(21, 13);
            this.Desc2.TabIndex = 29;
            this.Desc2.Text = "ID:";
            // 
            // Desc3
            // 
            this.Desc3.AutoSize = true;
            this.Desc3.Location = new System.Drawing.Point(502, 285);
            this.Desc3.Name = "Desc3";
            this.Desc3.Size = new System.Drawing.Size(23, 13);
            this.Desc3.TabIndex = 30;
            this.Desc3.Text = "OR";
            // 
            // Desc4
            // 
            this.Desc4.AutoSize = true;
            this.Desc4.Location = new System.Drawing.Point(502, 316);
            this.Desc4.Name = "Desc4";
            this.Desc4.Size = new System.Drawing.Size(30, 13);
            this.Desc4.TabIndex = 31;
            this.Desc4.Text = "Link:";
            // 
            // Link
            // 
            this.Link.Location = new System.Drawing.Point(538, 313);
            this.Link.Name = "Link";
            this.Link.Size = new System.Drawing.Size(206, 20);
            this.Link.TabIndex = 32;
            //this.Link.TextChanged += new System.EventHandler(this.Link_TextChanged);
            // 
            // InstallID
            // 
            this.InstallID.Location = new System.Drawing.Point(571, 339);
            this.InstallID.Name = "InstallID";
            this.InstallID.Size = new System.Drawing.Size(99, 23);
            this.InstallID.TabIndex = 33;
            this.InstallID.Text = "Install by id or link";
            this.InstallID.UseVisualStyleBackColor = true;
            //this.InstallID.Click += new System.EventHandler(this.InstallID_Click);
            // 
            // UpdateAll
            // 
            this.UpdateAll.Location = new System.Drawing.Point(499, 124);
            this.UpdateAll.Name = "UpdateAll";
            this.UpdateAll.Size = new System.Drawing.Size(75, 23);
            this.UpdateAll.TabIndex = 34;
            this.UpdateAll.Text = "Update All";
            this.UpdateAll.UseVisualStyleBackColor = true;
            //this.UpdateAll.Click += new System.EventHandler(this.UpdateAll_Click);
            // 
            // Workshop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(753, 374);
            this.Controls.Add(this.UpdateAll);
            this.Controls.Add(this.InstallID);
            this.Controls.Add(this.Link);
            this.Controls.Add(this.Desc4);
            this.Controls.Add(this.Desc3);
            this.Controls.Add(this.Desc2);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Desc1);
            this.Controls.Add(this.OpenMods);
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
            this.Name = "Workshop";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Managing Workshop Items";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Install;
        private System.Windows.Forms.Button DeleteAll;
        private System.Windows.Forms.CheckedListBox AlreadyInstalled;
        private System.Windows.Forms.Label AlreadyInstalledDesc;
        private System.Windows.Forms.Label AvailableDesc;
        private System.Windows.Forms.Label SelTyp;
        private System.Windows.Forms.RadioButton MapsLocation;
        private System.Windows.Forms.RadioButton ContentLocation;
        private System.Windows.Forms.Button SaveExit;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.CheckedListBox AvailableItems;
        private System.Windows.Forms.TextBox WorkshopLocation;
        private System.Windows.Forms.Label DirectoryDesc;
        private System.Windows.Forms.Button OpenMods;
        private System.Windows.Forms.Label Desc1;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label Desc2;
        private System.Windows.Forms.Label Desc3;
        private System.Windows.Forms.Label Desc4;
        private System.Windows.Forms.TextBox Link;
        private System.Windows.Forms.Button InstallID;
        private System.Windows.Forms.Button UpdateAll;
    }
}