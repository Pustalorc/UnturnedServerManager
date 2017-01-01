namespace USM
{
    partial class Updater
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
            this.LPIVer = new System.Windows.Forms.Label();
            this.LPIVerDesc = new System.Windows.Forms.Label();
            this.CPIVer = new System.Windows.Forms.Label();
            this.CPIVerDesc = new System.Windows.Forms.Label();
            this.UPI = new System.Windows.Forms.Button();
            this.LMVer = new System.Windows.Forms.Label();
            this.LMVerDesc = new System.Windows.Forms.Label();
            this.CMVer = new System.Windows.Forms.Label();
            this.CMVerDesc = new System.Windows.Forms.Label();
            this.USM = new System.Windows.Forms.Button();
            this.LRVer = new System.Windows.Forms.Label();
            this.LRVerDesc = new System.Windows.Forms.Label();
            this.CRVer = new System.Windows.Forms.Label();
            this.CRVerDesc = new System.Windows.Forms.Label();
            this.URocket = new System.Windows.Forms.Button();
            this.Note2 = new System.Windows.Forms.Label();
            this.Note1 = new System.Windows.Forms.Label();
            this.LUVer = new System.Windows.Forms.Label();
            this.LUVerDesc = new System.Windows.Forms.Label();
            this.CUVer = new System.Windows.Forms.Label();
            this.CUVerDesc = new System.Windows.Forms.Label();
            this.UUnturned = new System.Windows.Forms.Button();
            this.Note3 = new System.Windows.Forms.Label();
            this.Note4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UAll
            // 
            this.UAll.Location = new System.Drawing.Point(458, 213);
            this.UAll.Name = "UAll";
            this.UAll.Size = new System.Drawing.Size(75, 23);
            this.UAll.TabIndex = 47;
            this.UAll.Text = "Update All";
            this.UAll.UseVisualStyleBackColor = true;
            this.UAll.Click += new System.EventHandler(this.UAll_Click);
            // 
            // LPIVer
            // 
            this.LPIVer.AutoSize = true;
            this.LPIVer.Location = new System.Drawing.Point(487, 103);
            this.LPIVer.Name = "LPIVer";
            this.LPIVer.Size = new System.Drawing.Size(13, 13);
            this.LPIVer.TabIndex = 46;
            this.LPIVer.Text = "1";
            // 
            // LPIVerDesc
            // 
            this.LPIVerDesc.AutoSize = true;
            this.LPIVerDesc.Location = new System.Drawing.Point(357, 103);
            this.LPIVerDesc.Name = "LPIVerDesc";
            this.LPIVerDesc.Size = new System.Drawing.Size(96, 13);
            this.LPIVerDesc.TabIndex = 45;
            this.LPIVerDesc.Text = "Latest P.I. Version:";
            // 
            // CPIVer
            // 
            this.CPIVer.AutoSize = true;
            this.CPIVer.Location = new System.Drawing.Point(294, 103);
            this.CPIVer.Name = "CPIVer";
            this.CPIVer.Size = new System.Drawing.Size(27, 13);
            this.CPIVer.TabIndex = 44;
            this.CPIVer.Text = "N/A";
            // 
            // CPIVerDesc
            // 
            this.CPIVerDesc.AutoSize = true;
            this.CPIVerDesc.Location = new System.Drawing.Point(159, 103);
            this.CPIVerDesc.Name = "CPIVerDesc";
            this.CPIVerDesc.Size = new System.Drawing.Size(101, 13);
            this.CPIVerDesc.TabIndex = 43;
            this.CPIVerDesc.Text = "Current P.I. Version:";
            // 
            // UPI
            // 
            this.UPI.Location = new System.Drawing.Point(12, 98);
            this.UPI.Name = "UPI";
            this.UPI.Size = new System.Drawing.Size(130, 23);
            this.UPI.TabIndex = 42;
            this.UPI.Text = "Update Plugin Integrity";
            this.UPI.UseVisualStyleBackColor = true;
            this.UPI.Click += new System.EventHandler(this.UPI_Click);
            // 
            // LMVer
            // 
            this.LMVer.AutoSize = true;
            this.LMVer.Location = new System.Drawing.Point(487, 74);
            this.LMVer.Name = "LMVer";
            this.LMVer.Size = new System.Drawing.Size(40, 13);
            this.LMVer.TabIndex = 41;
            this.LMVer.Text = "3.0.0.4";
            // 
            // LMVerDesc
            // 
            this.LMVerDesc.AutoSize = true;
            this.LMVerDesc.Location = new System.Drawing.Point(357, 74);
            this.LMVerDesc.Name = "LMVerDesc";
            this.LMVerDesc.Size = new System.Drawing.Size(122, 13);
            this.LMVerDesc.TabIndex = 40;
            this.LMVerDesc.Text = "Latest Manager Version:";
            // 
            // CMVer
            // 
            this.CMVer.AutoSize = true;
            this.CMVer.Location = new System.Drawing.Point(294, 74);
            this.CMVer.Name = "CMVer";
            this.CMVer.Size = new System.Drawing.Size(40, 13);
            this.CMVer.TabIndex = 39;
            this.CMVer.Text = "3.0.0.4";
            // 
            // CMVerDesc
            // 
            this.CMVerDesc.AutoSize = true;
            this.CMVerDesc.Location = new System.Drawing.Point(159, 74);
            this.CMVerDesc.Name = "CMVerDesc";
            this.CMVerDesc.Size = new System.Drawing.Size(127, 13);
            this.CMVerDesc.TabIndex = 38;
            this.CMVerDesc.Text = "Current Manager Version:";
            // 
            // USM
            // 
            this.USM.Location = new System.Drawing.Point(12, 69);
            this.USM.Name = "USM";
            this.USM.Size = new System.Drawing.Size(130, 23);
            this.USM.TabIndex = 37;
            this.USM.Text = "Update Server Manager";
            this.USM.UseVisualStyleBackColor = true;
            this.USM.Click += new System.EventHandler(this.USM_Click);
            // 
            // LRVer
            // 
            this.LRVer.AutoSize = true;
            this.LRVer.Location = new System.Drawing.Point(487, 45);
            this.LRVer.Name = "LRVer";
            this.LRVer.Size = new System.Drawing.Size(31, 13);
            this.LRVer.TabIndex = 36;
            this.LRVer.Text = "1131";
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
            // Note2
            // 
            this.Note2.AutoSize = true;
            this.Note2.Location = new System.Drawing.Point(9, 174);
            this.Note2.Name = "Note2";
            this.Note2.Size = new System.Drawing.Size(363, 13);
            this.Note2.TabIndex = 31;
            this.Note2.Text = "\'Custom\' version means that the version was not updated ever with this tool.";
            // 
            // Note1
            // 
            this.Note1.AutoSize = true;
            this.Note1.Location = new System.Drawing.Point(9, 152);
            this.Note1.Name = "Note1";
            this.Note1.Size = new System.Drawing.Size(33, 13);
            this.Note1.TabIndex = 30;
            this.Note1.Text = "Note:";
            // 
            // LUVer
            // 
            this.LUVer.AutoSize = true;
            this.LUVer.Location = new System.Drawing.Point(487, 16);
            this.LUVer.Name = "LUVer";
            this.LUVer.Size = new System.Drawing.Size(52, 13);
            this.LUVer.TabIndex = 29;
            this.LUVer.Text = "3.17.10.0";
            // 
            // LUVerDesc
            // 
            this.LUVerDesc.AutoSize = true;
            this.LUVerDesc.Location = new System.Drawing.Point(357, 16);
            this.LUVerDesc.Name = "LUVerDesc";
            this.LUVerDesc.Size = new System.Drawing.Size(124, 13);
            this.LUVerDesc.TabIndex = 28;
            this.LUVerDesc.Text = "Latest Unturned Version:";
            // 
            // CUVer
            // 
            this.CUVer.AutoSize = true;
            this.CUVer.Location = new System.Drawing.Point(294, 16);
            this.CUVer.Name = "CUVer";
            this.CUVer.Size = new System.Drawing.Size(42, 13);
            this.CUVer.TabIndex = 27;
            this.CUVer.Text = "Custom";
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
            // Note3
            // 
            this.Note3.AutoSize = true;
            this.Note3.Location = new System.Drawing.Point(9, 196);
            this.Note3.Name = "Note3";
            this.Note3.Size = new System.Drawing.Size(379, 13);
            this.Note3.TabIndex = 48;
            this.Note3.Text = "The server manager updater only redirects you to the download of the program.";
            // 
            // Note4
            // 
            this.Note4.AutoSize = true;
            this.Note4.Location = new System.Drawing.Point(9, 218);
            this.Note4.Name = "Note4";
            this.Note4.Size = new System.Drawing.Size(399, 13);
            this.Note4.TabIndex = 49;
            this.Note4.Text = "Update to Unturned has been disabled until a method with steam gets programmed.";
            // 
            // Updater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(545, 248);
            this.Controls.Add(this.Note4);
            this.Controls.Add(this.Note3);
            this.Controls.Add(this.UAll);
            this.Controls.Add(this.LPIVer);
            this.Controls.Add(this.LPIVerDesc);
            this.Controls.Add(this.CPIVer);
            this.Controls.Add(this.CPIVerDesc);
            this.Controls.Add(this.UPI);
            this.Controls.Add(this.LMVer);
            this.Controls.Add(this.LMVerDesc);
            this.Controls.Add(this.CMVer);
            this.Controls.Add(this.CMVerDesc);
            this.Controls.Add(this.USM);
            this.Controls.Add(this.LRVer);
            this.Controls.Add(this.LRVerDesc);
            this.Controls.Add(this.CRVer);
            this.Controls.Add(this.CRVerDesc);
            this.Controls.Add(this.URocket);
            this.Controls.Add(this.Note2);
            this.Controls.Add(this.Note1);
            this.Controls.Add(this.LUVer);
            this.Controls.Add(this.LUVerDesc);
            this.Controls.Add(this.CUVer);
            this.Controls.Add(this.CUVerDesc);
            this.Controls.Add(this.UUnturned);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Updater";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Updater";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Updater_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button UAll;
        private System.Windows.Forms.Label LPIVer;
        private System.Windows.Forms.Label LPIVerDesc;
        private System.Windows.Forms.Label CPIVer;
        private System.Windows.Forms.Label CPIVerDesc;
        private System.Windows.Forms.Button UPI;
        private System.Windows.Forms.Label LMVer;
        private System.Windows.Forms.Label LMVerDesc;
        private System.Windows.Forms.Label CMVer;
        private System.Windows.Forms.Label CMVerDesc;
        private System.Windows.Forms.Button USM;
        private System.Windows.Forms.Label LRVer;
        private System.Windows.Forms.Label LRVerDesc;
        private System.Windows.Forms.Label CRVer;
        private System.Windows.Forms.Label CRVerDesc;
        private System.Windows.Forms.Button URocket;
        private System.Windows.Forms.Label Note2;
        private System.Windows.Forms.Label Note1;
        private System.Windows.Forms.Label LUVer;
        private System.Windows.Forms.Label LUVerDesc;
        private System.Windows.Forms.Label CUVer;
        private System.Windows.Forms.Label CUVerDesc;
        private System.Windows.Forms.Button UUnturned;
        private System.Windows.Forms.Label Note3;
        private System.Windows.Forms.Label Note4;
    }
}