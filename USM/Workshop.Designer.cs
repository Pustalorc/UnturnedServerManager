namespace USM
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
            this.Install.Click += new System.EventHandler(this.Install_Click);
            // 
            // DeleteAll
            // 
            this.DeleteAll.Location = new System.Drawing.Point(506, 338);
            this.DeleteAll.Name = "DeleteAll";
            this.DeleteAll.Size = new System.Drawing.Size(231, 23);
            this.DeleteAll.TabIndex = 24;
            this.DeleteAll.Text = "Delete ALL Installed Workshop Items";
            this.DeleteAll.UseVisualStyleBackColor = true;
            this.DeleteAll.Click += new System.EventHandler(this.DeleteAll_Click);
            // 
            // AlreadyInstalled
            // 
            this.AlreadyInstalled.Enabled = false;
            this.AlreadyInstalled.FormattingEnabled = true;
            this.AlreadyInstalled.Location = new System.Drawing.Point(506, 133);
            this.AlreadyInstalled.Name = "AlreadyInstalled";
            this.AlreadyInstalled.Size = new System.Drawing.Size(231, 199);
            this.AlreadyInstalled.TabIndex = 23;
            // 
            // AlreadyInstalledDesc
            // 
            this.AlreadyInstalledDesc.AutoSize = true;
            this.AlreadyInstalledDesc.Location = new System.Drawing.Point(503, 117);
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
            this.MapsLocation.Location = new System.Drawing.Point(506, 92);
            this.MapsLocation.Name = "MapsLocation";
            this.MapsLocation.Size = new System.Drawing.Size(51, 17);
            this.MapsLocation.TabIndex = 19;
            this.MapsLocation.Text = "Maps";
            this.MapsLocation.UseVisualStyleBackColor = true;
            this.MapsLocation.CheckedChanged += new System.EventHandler(this.MapsLocation_CheckedChanged);
            // 
            // ContentLocation
            // 
            this.ContentLocation.AutoSize = true;
            this.ContentLocation.Checked = true;
            this.ContentLocation.Location = new System.Drawing.Point(506, 69);
            this.ContentLocation.Name = "ContentLocation";
            this.ContentLocation.Size = new System.Drawing.Size(200, 17);
            this.ContentLocation.TabIndex = 18;
            this.ContentLocation.TabStop = true;
            this.ContentLocation.Text = "Content (Items, NPC\'s, Recipes, etc.)";
            this.ContentLocation.UseVisualStyleBackColor = true;
            this.ContentLocation.CheckedChanged += new System.EventHandler(this.ContentLocation_CheckedChanged);
            // 
            // SaveExit
            // 
            this.SaveExit.Location = new System.Drawing.Point(651, 14);
            this.SaveExit.Name = "SaveExit";
            this.SaveExit.Size = new System.Drawing.Size(82, 23);
            this.SaveExit.TabIndex = 17;
            this.SaveExit.Text = "Save and Exit";
            this.SaveExit.UseVisualStyleBackColor = true;
            this.SaveExit.Click += new System.EventHandler(this.SaveExit_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(502, 14);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(143, 23);
            this.Search.TabIndex = 16;
            this.Search.Text = "Search for workshop items";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // AvailableItems
            // 
            this.AvailableItems.CheckOnClick = true;
            this.AvailableItems.FormattingEnabled = true;
            this.AvailableItems.Location = new System.Drawing.Point(11, 58);
            this.AvailableItems.Name = "AvailableItems";
            this.AvailableItems.Size = new System.Drawing.Size(485, 274);
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
            this.OpenMods.Location = new System.Drawing.Point(325, 338);
            this.OpenMods.Name = "OpenMods";
            this.OpenMods.Size = new System.Drawing.Size(171, 23);
            this.OpenMods.TabIndex = 26;
            this.OpenMods.Text = "Open Selected Items In Browser";
            this.OpenMods.UseVisualStyleBackColor = true;
            this.OpenMods.Click += new System.EventHandler(this.OpenMods_Click);
            // 
            // Workshop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 374);
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
    }
}