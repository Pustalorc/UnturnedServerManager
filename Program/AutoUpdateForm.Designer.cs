namespace USM
{
    partial class AutoUpdateForm
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
            this.Everything = new System.Windows.Forms.NumericUpDown();
            this.Desc2 = new System.Windows.Forms.Label();
            this.Desc3 = new System.Windows.Forms.Label();
            this.Desc5 = new System.Windows.Forms.Label();
            this.Rocket = new System.Windows.Forms.NumericUpDown();
            this.Desc4 = new System.Windows.Forms.Label();
            this.Desc7 = new System.Windows.Forms.Label();
            this.Unturned = new System.Windows.Forms.NumericUpDown();
            this.Desc6 = new System.Windows.Forms.Label();
            this.Desc9 = new System.Windows.Forms.Label();
            this.PI = new System.Windows.Forms.NumericUpDown();
            this.Desc8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Everything)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rocket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Unturned)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PI)).BeginInit();
            this.SuspendLayout();
            // 
            // Desc1
            // 
            this.Desc1.AutoSize = true;
            this.Desc1.Location = new System.Drawing.Point(12, 14);
            this.Desc1.Name = "Desc1";
            this.Desc1.Size = new System.Drawing.Size(125, 13);
            this.Desc1.TabIndex = 0;
            this.Desc1.Text = "Update Everything Every";
            // 
            // Everything
            // 
            this.Everything.Location = new System.Drawing.Point(143, 12);
            this.Everything.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.Everything.Name = "Everything";
            this.Everything.Size = new System.Drawing.Size(40, 20);
            this.Everything.TabIndex = 1;
            // 
            // Desc2
            // 
            this.Desc2.AutoSize = true;
            this.Desc2.Location = new System.Drawing.Point(189, 14);
            this.Desc2.Name = "Desc2";
            this.Desc2.Size = new System.Drawing.Size(40, 13);
            this.Desc2.TabIndex = 2;
            this.Desc2.Text = "Day(s).";
            // 
            // Desc3
            // 
            this.Desc3.AutoSize = true;
            this.Desc3.Location = new System.Drawing.Point(12, 122);
            this.Desc3.Name = "Desc3";
            this.Desc3.Size = new System.Drawing.Size(297, 13);
            this.Desc3.TabIndex = 3;
            this.Desc3.Text = "Note: Set a time value to 0 to disable the kind of auto update.";
            // 
            // Desc5
            // 
            this.Desc5.AutoSize = true;
            this.Desc5.Location = new System.Drawing.Point(189, 40);
            this.Desc5.Name = "Desc5";
            this.Desc5.Size = new System.Drawing.Size(40, 13);
            this.Desc5.TabIndex = 6;
            this.Desc5.Text = "Day(s).";
            // 
            // Rocket
            // 
            this.Rocket.Location = new System.Drawing.Point(143, 38);
            this.Rocket.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.Rocket.Name = "Rocket";
            this.Rocket.Size = new System.Drawing.Size(40, 20);
            this.Rocket.TabIndex = 5;
            // 
            // Desc4
            // 
            this.Desc4.AutoSize = true;
            this.Desc4.Location = new System.Drawing.Point(12, 40);
            this.Desc4.Name = "Desc4";
            this.Desc4.Size = new System.Drawing.Size(110, 13);
            this.Desc4.TabIndex = 4;
            this.Desc4.Text = "Update Rocket Every";
            // 
            // Desc7
            // 
            this.Desc7.AutoSize = true;
            this.Desc7.Location = new System.Drawing.Point(189, 66);
            this.Desc7.Name = "Desc7";
            this.Desc7.Size = new System.Drawing.Size(40, 13);
            this.Desc7.TabIndex = 9;
            this.Desc7.Text = "Day(s).";
            // 
            // Unturned
            // 
            this.Unturned.Location = new System.Drawing.Point(143, 64);
            this.Unturned.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.Unturned.Name = "Unturned";
            this.Unturned.Size = new System.Drawing.Size(40, 20);
            this.Unturned.TabIndex = 8;
            // 
            // Desc6
            // 
            this.Desc6.AutoSize = true;
            this.Desc6.Location = new System.Drawing.Point(12, 66);
            this.Desc6.Name = "Desc6";
            this.Desc6.Size = new System.Drawing.Size(119, 13);
            this.Desc6.TabIndex = 7;
            this.Desc6.Text = "Update Unturned Every";
            // 
            // Desc9
            // 
            this.Desc9.AutoSize = true;
            this.Desc9.Location = new System.Drawing.Point(189, 92);
            this.Desc9.Name = "Desc9";
            this.Desc9.Size = new System.Drawing.Size(40, 13);
            this.Desc9.TabIndex = 12;
            this.Desc9.Text = "Day(s).";
            // 
            // PI
            // 
            this.PI.Location = new System.Drawing.Point(143, 90);
            this.PI.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.PI.Name = "PI";
            this.PI.Size = new System.Drawing.Size(40, 20);
            this.PI.TabIndex = 11;
            // 
            // Desc8
            // 
            this.Desc8.AutoSize = true;
            this.Desc8.Location = new System.Drawing.Point(12, 92);
            this.Desc8.Name = "Desc8";
            this.Desc8.Size = new System.Drawing.Size(130, 13);
            this.Desc8.TabIndex = 10;
            this.Desc8.Text = "Update Plugin Data Every";
            // 
            // AutoUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 148);
            this.Controls.Add(this.Desc9);
            this.Controls.Add(this.PI);
            this.Controls.Add(this.Desc8);
            this.Controls.Add(this.Desc7);
            this.Controls.Add(this.Unturned);
            this.Controls.Add(this.Desc6);
            this.Controls.Add(this.Desc5);
            this.Controls.Add(this.Rocket);
            this.Controls.Add(this.Desc4);
            this.Controls.Add(this.Desc3);
            this.Controls.Add(this.Desc2);
            this.Controls.Add(this.Everything);
            this.Controls.Add(this.Desc1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AutoUpdateForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Auto Update Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AutoUpdateForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Everything)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rocket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Unturned)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Desc1;
        private System.Windows.Forms.NumericUpDown Everything;
        private System.Windows.Forms.Label Desc2;
        private System.Windows.Forms.Label Desc3;
        private System.Windows.Forms.Label Desc5;
        private System.Windows.Forms.NumericUpDown Rocket;
        private System.Windows.Forms.Label Desc4;
        private System.Windows.Forms.Label Desc7;
        private System.Windows.Forms.NumericUpDown Unturned;
        private System.Windows.Forms.Label Desc6;
        private System.Windows.Forms.Label Desc9;
        private System.Windows.Forms.NumericUpDown PI;
        private System.Windows.Forms.Label Desc8;
    }
}