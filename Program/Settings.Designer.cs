namespace USM
{
    partial class Settings
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
            this.Red = new System.Windows.Forms.NumericUpDown();
            this.Green = new System.Windows.Forms.NumericUpDown();
            this.Desc3 = new System.Windows.Forms.Label();
            this.Blue = new System.Windows.Forms.NumericUpDown();
            this.Desc4 = new System.Windows.Forms.Label();
            this.UnturnedInstallLocationFinder = new System.Windows.Forms.FolderBrowserDialog();
            this.NewDir = new System.Windows.Forms.Button();
            this.Desc5 = new System.Windows.Forms.Label();
            this.Desc6 = new System.Windows.Forms.Label();
            this.Desc7 = new System.Windows.Forms.Label();
            this.Desc8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Blue)).BeginInit();
            this.SuspendLayout();
            // 
            // Desc1
            // 
            this.Desc1.AutoSize = true;
            this.Desc1.Location = new System.Drawing.Point(12, 9);
            this.Desc1.Name = "Desc1";
            this.Desc1.Size = new System.Drawing.Size(150, 13);
            this.Desc1.TabIndex = 0;
            this.Desc1.Text = "Background Application Color:";
            // 
            // Desc2
            // 
            this.Desc2.AutoSize = true;
            this.Desc2.Location = new System.Drawing.Point(12, 36);
            this.Desc2.Name = "Desc2";
            this.Desc2.Size = new System.Drawing.Size(18, 13);
            this.Desc2.TabIndex = 1;
            this.Desc2.Text = "R:";
            // 
            // Red
            // 
            this.Red.Location = new System.Drawing.Point(36, 34);
            this.Red.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(40, 20);
            this.Red.TabIndex = 2;
            this.Red.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Red.ValueChanged += new System.EventHandler(this.Red_ValueChanged);
            // 
            // Green
            // 
            this.Green.Location = new System.Drawing.Point(106, 34);
            this.Green.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(40, 20);
            this.Green.TabIndex = 4;
            this.Green.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.Green.ValueChanged += new System.EventHandler(this.Green_ValueChanged);
            // 
            // Desc3
            // 
            this.Desc3.AutoSize = true;
            this.Desc3.Location = new System.Drawing.Point(82, 36);
            this.Desc3.Name = "Desc3";
            this.Desc3.Size = new System.Drawing.Size(18, 13);
            this.Desc3.TabIndex = 3;
            this.Desc3.Text = "G:";
            // 
            // Blue
            // 
            this.Blue.Location = new System.Drawing.Point(176, 34);
            this.Blue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(40, 20);
            this.Blue.TabIndex = 6;
            this.Blue.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.Blue.ValueChanged += new System.EventHandler(this.Blue_ValueChanged);
            // 
            // Desc4
            // 
            this.Desc4.AutoSize = true;
            this.Desc4.Location = new System.Drawing.Point(152, 36);
            this.Desc4.Name = "Desc4";
            this.Desc4.Size = new System.Drawing.Size(17, 13);
            this.Desc4.TabIndex = 5;
            this.Desc4.Text = "B:";
            // 
            // NewDir
            // 
            this.NewDir.Location = new System.Drawing.Point(15, 113);
            this.NewDir.Name = "NewDir";
            this.NewDir.Size = new System.Drawing.Size(115, 23);
            this.NewDir.TabIndex = 7;
            this.NewDir.Text = "Select New Directory";
            this.NewDir.UseVisualStyleBackColor = true;
            this.NewDir.Click += new System.EventHandler(this.NewDir_Click);
            // 
            // Desc5
            // 
            this.Desc5.AutoSize = true;
            this.Desc5.Location = new System.Drawing.Point(12, 66);
            this.Desc5.Name = "Desc5";
            this.Desc5.Size = new System.Drawing.Size(105, 13);
            this.Desc5.TabIndex = 8;
            this.Desc5.Text = "Unturned Data Path:";
            // 
            // Desc6
            // 
            this.Desc6.AutoSize = true;
            this.Desc6.Location = new System.Drawing.Point(12, 88);
            this.Desc6.Name = "Desc6";
            this.Desc6.Size = new System.Drawing.Size(150, 13);
            this.Desc6.TabIndex = 9;
            this.Desc6.Text = "C:\\Unturned_Manager\\Server";
            // 
            // Desc7
            // 
            this.Desc7.AutoSize = true;
            this.Desc7.Location = new System.Drawing.Point(233, 9);
            this.Desc7.Name = "Desc7";
            this.Desc7.Size = new System.Drawing.Size(184, 13);
            this.Desc7.TabIndex = 10;
            this.Desc7.Text = "Unturned Server Manager Data Path:";
            // 
            // Desc8
            // 
            this.Desc8.AutoSize = true;
            this.Desc8.Location = new System.Drawing.Point(233, 31);
            this.Desc8.Name = "Desc8";
            this.Desc8.Size = new System.Drawing.Size(119, 13);
            this.Desc8.TabIndex = 11;
            this.Desc8.Text = "C:\\Unturned_Manager\\";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Setup Auto Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 148);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Desc8);
            this.Controls.Add(this.Desc7);
            this.Controls.Add(this.Desc6);
            this.Controls.Add(this.Desc5);
            this.Controls.Add(this.NewDir);
            this.Controls.Add(this.Blue);
            this.Controls.Add(this.Desc4);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.Desc3);
            this.Controls.Add(this.Red);
            this.Controls.Add(this.Desc2);
            this.Controls.Add(this.Desc1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Blue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Desc1;
        private System.Windows.Forms.Label Desc2;
        private System.Windows.Forms.NumericUpDown Red;
        private System.Windows.Forms.NumericUpDown Green;
        private System.Windows.Forms.Label Desc3;
        private System.Windows.Forms.NumericUpDown Blue;
        private System.Windows.Forms.Label Desc4;
        private System.Windows.Forms.FolderBrowserDialog UnturnedInstallLocationFinder;
        private System.Windows.Forms.Button NewDir;
        private System.Windows.Forms.Label Desc5;
        private System.Windows.Forms.Label Desc6;
        private System.Windows.Forms.Label Desc7;
        private System.Windows.Forms.Label Desc8;
        private System.Windows.Forms.Button button1;
    }
}