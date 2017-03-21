namespace Installer
{
    partial class InstallType
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
            this.Welcome = new System.Windows.Forms.Label();
            this.Next = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Desc = new System.Windows.Forms.Label();
            this.OntTimeInst = new System.Windows.Forms.RadioButton();
            this.FullInst = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Welcome.Location = new System.Drawing.Point(33, 28);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(417, 20);
            this.Welcome.TabIndex = 0;
            this.Welcome.Text = "Welcome to the installer for Unturned Server Manager!";
            // 
            // Next
            // 
            this.Next.Enabled = false;
            this.Next.Location = new System.Drawing.Point(397, 226);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 1;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(12, 226);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Back_Click);
            // 
            // Desc
            // 
            this.Desc.AutoSize = true;
            this.Desc.Location = new System.Drawing.Point(179, 95);
            this.Desc.Name = "Desc";
            this.Desc.Size = new System.Drawing.Size(115, 13);
            this.Desc.TabIndex = 3;
            this.Desc.Text = "Chose Method Of Use:";
            // 
            // OntTimeInst
            // 
            this.OntTimeInst.AutoSize = true;
            this.OntTimeInst.Location = new System.Drawing.Point(182, 120);
            this.OntTimeInst.Name = "OntTimeInst";
            this.OntTimeInst.Size = new System.Drawing.Size(95, 17);
            this.OntTimeInst.TabIndex = 4;
            this.OntTimeInst.Text = "One Time Only";
            this.OntTimeInst.UseVisualStyleBackColor = true;
            this.OntTimeInst.CheckedChanged += new System.EventHandler(this.OntTimeInst_CheckedChanged);
            // 
            // FullInst
            // 
            this.FullInst.AutoSize = true;
            this.FullInst.Location = new System.Drawing.Point(182, 143);
            this.FullInst.Name = "FullInst";
            this.FullInst.Size = new System.Drawing.Size(71, 17);
            this.FullInst.TabIndex = 5;
            this.FullInst.Text = "Full Install";
            this.FullInst.UseVisualStyleBackColor = true;
            this.FullInst.CheckedChanged += new System.EventHandler(this.FullInst_CheckedChanged);
            // 
            // InstallType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.FullInst);
            this.Controls.Add(this.OntTimeInst);
            this.Controls.Add(this.Desc);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Welcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "InstallType";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unturned Server Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label Desc;
        private System.Windows.Forms.RadioButton OntTimeInst;
        private System.Windows.Forms.RadioButton FullInst;
    }
}

