namespace ATORTTeam.UnturnedServerManager.GUI
{
    partial class UpdateMenu
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
            this.UAll = new System.Windows.Forms.Button();
            this.LRVer = new System.Windows.Forms.Label();
            this.LRVerDesc = new System.Windows.Forms.Label();
            this.CRVer = new System.Windows.Forms.Label();
            this.CRVerDesc = new System.Windows.Forms.Label();
            this.URocket = new System.Windows.Forms.Button();
            this.LUVer = new System.Windows.Forms.Label();
            this.LUVerDesc = new System.Windows.Forms.Label();
            this.CUVer = new System.Windows.Forms.Label();
            this.CUVerDesc = new System.Windows.Forms.Label();
            this.UUnturned = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UAll
            // 
            this.UAll.Location = new System.Drawing.Point(12, 69);
            this.UAll.Name = "UAll";
            this.UAll.Size = new System.Drawing.Size(130, 23);
            this.UAll.TabIndex = 47;
            this.UAll.Text = "Update All";
            this.UAll.UseVisualStyleBackColor = true;
            this.UAll.Click += new System.EventHandler(this.UAll_Click);
            // 
            // LRVer
            // 
            this.LRVer.AutoSize = true;
            this.LRVer.Location = new System.Drawing.Point(487, 45);
            this.LRVer.Name = "LRVer";
            this.LRVer.Size = new System.Drawing.Size(27, 13);
            this.LRVer.TabIndex = 36;
            this.LRVer.Text = "N/A";
            // 
            // LRVerDesc
            // 
            this.LRVerDesc.AutoSize = true;
            this.LRVerDesc.Location = new System.Drawing.Point(357, 45);
            this.LRVerDesc.Name = "LRVerDesc";
            this.LRVerDesc.Size = new System.Drawing.Size(115, 13);
            this.LRVerDesc.TabIndex = 35;
            this.LRVerDesc.Text = "Latest Rocket Version:";
            // 
            // CRVer
            // 
            this.CRVer.AutoSize = true;
            this.CRVer.Location = new System.Drawing.Point(294, 45);
            this.CRVer.Name = "CRVer";
            this.CRVer.Size = new System.Drawing.Size(27, 13);
            this.CRVer.TabIndex = 34;
            this.CRVer.Text = "N/A";
            // 
            // CRVerDesc
            // 
            this.CRVerDesc.AutoSize = true;
            this.CRVerDesc.Location = new System.Drawing.Point(159, 45);
            this.CRVerDesc.Name = "CRVerDesc";
            this.CRVerDesc.Size = new System.Drawing.Size(120, 13);
            this.CRVerDesc.TabIndex = 33;
            this.CRVerDesc.Text = "Current Rocket Version:";
            // 
            // URocket
            // 
            this.URocket.Location = new System.Drawing.Point(12, 40);
            this.URocket.Name = "URocket";
            this.URocket.Size = new System.Drawing.Size(130, 23);
            this.URocket.TabIndex = 32;
            this.URocket.Text = "Update Rocket";
            this.URocket.UseVisualStyleBackColor = true;
            this.URocket.Click += new System.EventHandler(this.URocket_Click);
            // 
            // LUVer
            // 
            this.LUVer.AutoSize = true;
            this.LUVer.Location = new System.Drawing.Point(487, 16);
            this.LUVer.Name = "LUVer";
            this.LUVer.Size = new System.Drawing.Size(27, 13);
            this.LUVer.TabIndex = 29;
            this.LUVer.Text = "N/A";
            // 
            // LUVerDesc
            // 
            this.LUVerDesc.AutoSize = true;
            this.LUVerDesc.Location = new System.Drawing.Point(357, 16);
            this.LUVerDesc.Name = "LUVerDesc";
            this.LUVerDesc.Size = new System.Drawing.Size(112, 13);
            this.LUVerDesc.TabIndex = 28;
            this.LUVerDesc.Text = "Latest Unturned Build:";
            // 
            // CUVer
            // 
            this.CUVer.AutoSize = true;
            this.CUVer.Location = new System.Drawing.Point(294, 16);
            this.CUVer.Name = "CUVer";
            this.CUVer.Size = new System.Drawing.Size(27, 13);
            this.CUVer.TabIndex = 27;
            this.CUVer.Text = "N/A";
            // 
            // CUVerDesc
            // 
            this.CUVerDesc.AutoSize = true;
            this.CUVerDesc.Location = new System.Drawing.Point(159, 16);
            this.CUVerDesc.Name = "CUVerDesc";
            this.CUVerDesc.Size = new System.Drawing.Size(129, 13);
            this.CUVerDesc.TabIndex = 26;
            this.CUVerDesc.Text = "Current Unturned Version:";
            // 
            // UUnturned
            // 
            this.UUnturned.Location = new System.Drawing.Point(12, 11);
            this.UUnturned.Name = "UUnturned";
            this.UUnturned.Size = new System.Drawing.Size(130, 23);
            this.UUnturned.TabIndex = 25;
            this.UUnturned.Text = "Update Unturned";
            this.UUnturned.UseVisualStyleBackColor = true;
            this.UUnturned.Click += new System.EventHandler(this.UUnturned_Click);
            // 
            // UpdateMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(569, 103);
            this.Controls.Add(this.UAll);
            this.Controls.Add(this.LRVer);
            this.Controls.Add(this.LRVerDesc);
            this.Controls.Add(this.CRVer);
            this.Controls.Add(this.CRVerDesc);
            this.Controls.Add(this.URocket);
            this.Controls.Add(this.LUVer);
            this.Controls.Add(this.LUVerDesc);
            this.Controls.Add(this.CUVer);
            this.Controls.Add(this.CUVerDesc);
            this.Controls.Add(this.UUnturned);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateMenu";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Updater";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button UAll;
        private System.Windows.Forms.Label LRVer;
        private System.Windows.Forms.Label LRVerDesc;
        private System.Windows.Forms.Label CRVer;
        private System.Windows.Forms.Label CRVerDesc;
        private System.Windows.Forms.Button URocket;
        private System.Windows.Forms.Label LUVer;
        private System.Windows.Forms.Label LUVerDesc;
        private System.Windows.Forms.Label CUVer;
        private System.Windows.Forms.Label CUVerDesc;
        private System.Windows.Forms.Button UUnturned;
    }
}