namespace ATORTTeam.UnturnedServerManager.GUI
{
    internal sealed partial class SteamLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SteamLogin));
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.User_TXT = new System.Windows.Forms.Label();
            this.Pass_TXT = new System.Windows.Forms.Label();
            this.Note = new System.Windows.Forms.Label();
            this.Github = new System.Windows.Forms.LinkLabel();
            this.LogonSteam = new System.Windows.Forms.Button();
            this.Remember = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(76, 15);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(100, 20);
            this.Username.TabIndex = 0;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(76, 41);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '•';
            this.Password.Size = new System.Drawing.Size(100, 20);
            this.Password.TabIndex = 1;
            this.Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Password_KeyPress);
            // 
            // User_TXT
            // 
            this.User_TXT.AutoSize = true;
            this.User_TXT.Location = new System.Drawing.Point(12, 18);
            this.User_TXT.Name = "User_TXT";
            this.User_TXT.Size = new System.Drawing.Size(58, 13);
            this.User_TXT.TabIndex = 2;
            this.User_TXT.Text = "Username:";
            // 
            // Pass_TXT
            // 
            this.Pass_TXT.AutoSize = true;
            this.Pass_TXT.Location = new System.Drawing.Point(14, 44);
            this.Pass_TXT.Name = "Pass_TXT";
            this.Pass_TXT.Size = new System.Drawing.Size(56, 13);
            this.Pass_TXT.TabIndex = 3;
            this.Pass_TXT.Text = "Password:";
            // 
            // Note
            // 
            this.Note.AutoSize = true;
            this.Note.Location = new System.Drawing.Point(12, 99);
            this.Note.Name = "Note";
            this.Note.Size = new System.Drawing.Size(366, 26);
            this.Note.TabIndex = 5;
            this.Note.Text = "This software doesn\'t store or use your account details for any evil purposes.\nFo" +
    "r more information on what it does, you can see our source code here:";
            // 
            // Github
            // 
            this.Github.AutoSize = true;
            this.Github.Location = new System.Drawing.Point(357, 112);
            this.Github.Name = "Github";
            this.Github.Size = new System.Drawing.Size(38, 13);
            this.Github.TabIndex = 6;
            this.Github.TabStop = true;
            this.Github.Text = "Github";
            this.Github.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Github_LinkClicked);
            // 
            // LogonSteam
            // 
            this.LogonSteam.Location = new System.Drawing.Point(101, 67);
            this.LogonSteam.Name = "LogonSteam";
            this.LogonSteam.Size = new System.Drawing.Size(75, 23);
            this.LogonSteam.TabIndex = 7;
            this.LogonSteam.Text = "Login";
            this.LogonSteam.UseVisualStyleBackColor = true;
            this.LogonSteam.Click += new System.EventHandler(this.LogonSteam_Click);
            // 
            // Remember
            // 
            this.Remember.AutoSize = true;
            this.Remember.Location = new System.Drawing.Point(205, 70);
            this.Remember.Name = "Remember";
            this.Remember.Size = new System.Drawing.Size(191, 17);
            this.Remember.TabIndex = 8;
            this.Remember.Text = "Remember account for this session";
            this.Remember.UseVisualStyleBackColor = true;
            // 
            // SteamLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 138);
            this.Controls.Add(this.Remember);
            this.Controls.Add(this.LogonSteam);
            this.Controls.Add(this.Github);
            this.Controls.Add(this.Note);
            this.Controls.Add(this.Pass_TXT);
            this.Controls.Add(this.User_TXT);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SteamLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Steam Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SteamLogin_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label User_TXT;
        private System.Windows.Forms.Label Pass_TXT;
        private System.Windows.Forms.Label Note;
        private System.Windows.Forms.LinkLabel Github;
        private System.Windows.Forms.Button LogonSteam;
        internal System.Windows.Forms.TextBox Username;
        internal System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.CheckBox Remember;
    }
}