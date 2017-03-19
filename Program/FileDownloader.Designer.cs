namespace USM
{
    partial class FileDownloader
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
            this.Desc1 = new System.Windows.Forms.Label();
            this.Desc2 = new System.Windows.Forms.Label();
            this.Desc3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Desc4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Desc1
            // 
            this.Desc1.AutoSize = true;
            this.Desc1.Location = new System.Drawing.Point(12, 9);
            this.Desc1.Name = "Desc1";
            this.Desc1.Size = new System.Drawing.Size(72, 13);
            this.Desc1.TabIndex = 0;
            this.Desc1.Text = "Downloading:";
            // 
            // Desc2
            // 
            this.Desc2.AutoSize = true;
            this.Desc2.Location = new System.Drawing.Point(90, 9);
            this.Desc2.Name = "Desc2";
            this.Desc2.Size = new System.Drawing.Size(66, 13);
            this.Desc2.TabIndex = 1;
            this.Desc2.Text = "Rocket Mod";
            // 
            // Desc3
            // 
            this.Desc3.AutoSize = true;
            this.Desc3.Location = new System.Drawing.Point(12, 53);
            this.Desc3.Name = "Desc3";
            this.Desc3.Size = new System.Drawing.Size(51, 13);
            this.Desc3.TabIndex = 2;
            this.Desc3.Text = "Progress:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 78);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(260, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // Desc4
            // 
            this.Desc4.AutoSize = true;
            this.Desc4.Location = new System.Drawing.Point(176, 53);
            this.Desc4.Name = "Desc4";
            this.Desc4.Size = new System.Drawing.Size(96, 13);
            this.Desc4.TabIndex = 4;
            this.Desc4.Text = "1000000/1000000";
            // 
            // FileDownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 114);
            this.Controls.Add(this.Desc4);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Desc3);
            this.Controls.Add(this.Desc2);
            this.Controls.Add(this.Desc1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FileDownloader";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "File Downloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Desc1;
        private System.Windows.Forms.Label Desc2;
        private System.Windows.Forms.Label Desc3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label Desc4;
    }
}