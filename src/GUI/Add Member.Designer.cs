namespace ATORTTeam.UnturnedServerManager.GUI
{
    partial class AddMember
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
            this.Instructions = new System.Windows.Forms.Label();
            this.OwnerID = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.OwnerID)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(144, 61);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 12;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(63, 61);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 11;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Instructions
            // 
            this.Instructions.AutoSize = true;
            this.Instructions.Location = new System.Drawing.Point(12, 9);
            this.Instructions.Name = "Instructions";
            this.Instructions.Size = new System.Drawing.Size(200, 13);
            this.Instructions.TabIndex = 9;
            this.Instructions.Text = "Please type the Steam64ID of the player:";
            // 
            // OwnerID
            // 
            this.OwnerID.Location = new System.Drawing.Point(12, 35);
            this.OwnerID.Maximum = new decimal(new int[] {
            -1,
            17825793,
            0,
            0});
            this.OwnerID.Minimum = new decimal(new int[] {
            0,
            17825793,
            0,
            0});
            this.OwnerID.Name = "OwnerID";
            this.OwnerID.Size = new System.Drawing.Size(207, 20);
            this.OwnerID.TabIndex = 95;
            this.OwnerID.Value = new decimal(new int[] {
            0,
            17825793,
            0,
            0});
            this.OwnerID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OwnerID_KeyPress);
            // 
            // AddMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 97);
            this.Controls.Add(this.OwnerID);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Instructions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddMember";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adding a new member...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddMember_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.OwnerID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Label Instructions;
        private System.Windows.Forms.NumericUpDown OwnerID;
    }
}