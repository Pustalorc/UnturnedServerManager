namespace ATORTTeam.UnturnedServerManager.GUI
{
    partial class AddPermission
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
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.PermissionName = new System.Windows.Forms.TextBox();
            this.Instructions = new System.Windows.Forms.Label();
            this.CooldownValue = new System.Windows.Forms.NumericUpDown();
            this.Cooldown_TXT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CooldownValue)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(141, 77);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 8;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(60, 77);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 7;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // PermissionName
            // 
            this.PermissionName.Location = new System.Drawing.Point(12, 25);
            this.PermissionName.Name = "PermissionName";
            this.PermissionName.Size = new System.Drawing.Size(204, 20);
            this.PermissionName.TabIndex = 6;
            this.PermissionName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ServerName_KeyPress);
            // 
            // Instructions
            // 
            this.Instructions.AutoSize = true;
            this.Instructions.Location = new System.Drawing.Point(12, 9);
            this.Instructions.Name = "Instructions";
            this.Instructions.Size = new System.Drawing.Size(135, 13);
            this.Instructions.TabIndex = 5;
            this.Instructions.Text = "Please type the permission:";
            // 
            // CooldownValue
            // 
            this.CooldownValue.Location = new System.Drawing.Point(73, 51);
            this.CooldownValue.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.CooldownValue.Name = "CooldownValue";
            this.CooldownValue.Size = new System.Drawing.Size(143, 20);
            this.CooldownValue.TabIndex = 34;
            // 
            // Cooldown_TXT
            // 
            this.Cooldown_TXT.AutoSize = true;
            this.Cooldown_TXT.Location = new System.Drawing.Point(10, 53);
            this.Cooldown_TXT.Name = "Cooldown_TXT";
            this.Cooldown_TXT.Size = new System.Drawing.Size(57, 13);
            this.Cooldown_TXT.TabIndex = 33;
            this.Cooldown_TXT.Text = "Cooldown:";
            // 
            // AddPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 113);
            this.Controls.Add(this.CooldownValue);
            this.Controls.Add(this.Cooldown_TXT);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.PermissionName);
            this.Controls.Add(this.Instructions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddPermission";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adding a new permission...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddPermission_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.CooldownValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.TextBox PermissionName;
        private System.Windows.Forms.Label Instructions;
        private System.Windows.Forms.NumericUpDown CooldownValue;
        private System.Windows.Forms.Label Cooldown_TXT;
    }
}