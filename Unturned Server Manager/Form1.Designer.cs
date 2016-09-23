namespace Unturned_Server_Manager
{
    partial class Manager
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
            this.CreditsMin1 = new System.Windows.Forms.Label();
            this.CreditsMin2 = new System.Windows.Forms.Label();
            this.Run = new System.Windows.Forms.Button();
            this.ExecPath = new System.Windows.Forms.TextBox();
            this.ExecDesc = new System.Windows.Forms.Label();
            this.Servers2Run = new System.Windows.Forms.ComboBox();
            this.ServerNum = new System.Windows.Forms.Label();
            this.Server1 = new System.Windows.Forms.Label();
            this.Server2 = new System.Windows.Forms.Label();
            this.Server3 = new System.Windows.Forms.Label();
            this.Server4 = new System.Windows.Forms.Label();
            this.VACCheck1 = new System.Windows.Forms.CheckBox();
            this.OptionsDesc1 = new System.Windows.Forms.Label();
            this.BatchCheck1 = new System.Windows.Forms.CheckBox();
            this.NoGraphicsCheck1 = new System.Windows.Forms.CheckBox();
            this.ServerName1 = new System.Windows.Forms.TextBox();
            this.NameDesc1 = new System.Windows.Forms.Label();
            this.NameDesc2 = new System.Windows.Forms.Label();
            this.ServerName2 = new System.Windows.Forms.TextBox();
            this.NoGraphicsCheck2 = new System.Windows.Forms.CheckBox();
            this.BatchCheck2 = new System.Windows.Forms.CheckBox();
            this.OptionsDesc2 = new System.Windows.Forms.Label();
            this.VACCheck2 = new System.Windows.Forms.CheckBox();
            this.NameDesc4 = new System.Windows.Forms.Label();
            this.ServerName4 = new System.Windows.Forms.TextBox();
            this.NoGraphicsCheck4 = new System.Windows.Forms.CheckBox();
            this.BatchCheck4 = new System.Windows.Forms.CheckBox();
            this.OptionsDesc4 = new System.Windows.Forms.Label();
            this.VACCheck4 = new System.Windows.Forms.CheckBox();
            this.NameDesc3 = new System.Windows.Forms.Label();
            this.ServerName3 = new System.Windows.Forms.TextBox();
            this.NoGraphicsCheck3 = new System.Windows.Forms.CheckBox();
            this.BatchCheck3 = new System.Windows.Forms.CheckBox();
            this.OptionsDesc3 = new System.Windows.Forms.Label();
            this.VACCheck3 = new System.Windows.Forms.CheckBox();
            this.AdvancedOptions1 = new System.Windows.Forms.Button();
            this.AdvancedOptions2 = new System.Windows.Forms.Button();
            this.AdvancedOptions3 = new System.Windows.Forms.Button();
            this.AdvancedOptions4 = new System.Windows.Forms.Button();
            this.Shutdown = new System.Windows.Forms.Button();
            this.Restart = new System.Windows.Forms.Button();
            this.GithubLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // CreditsMin1
            // 
            this.CreditsMin1.AutoSize = true;
            this.CreditsMin1.Location = new System.Drawing.Point(610, 340);
            this.CreditsMin1.Name = "CreditsMin1";
            this.CreditsMin1.Size = new System.Drawing.Size(151, 13);
            this.CreditsMin1.TabIndex = 0;
            this.CreditsMin1.Text = "Designed and programmed by:";
            // 
            // CreditsMin2
            // 
            this.CreditsMin2.AutoSize = true;
            this.CreditsMin2.Location = new System.Drawing.Point(758, 340);
            this.CreditsMin2.Name = "CreditsMin2";
            this.CreditsMin2.Size = new System.Drawing.Size(64, 13);
            this.CreditsMin2.TabIndex = 1;
            this.CreditsMin2.Text = "persiafighter";
            // 
            // Run
            // 
            this.Run.Location = new System.Drawing.Point(738, 304);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(84, 23);
            this.Run.TabIndex = 2;
            this.Run.Text = "Start Server(s)";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // ExecPath
            // 
            this.ExecPath.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ExecPath.Location = new System.Drawing.Point(476, 12);
            this.ExecPath.Name = "ExecPath";
            this.ExecPath.Size = new System.Drawing.Size(346, 20);
            this.ExecPath.TabIndex = 3;
            // 
            // ExecDesc
            // 
            this.ExecDesc.AutoSize = true;
            this.ExecDesc.Location = new System.Drawing.Point(382, 15);
            this.ExecDesc.Name = "ExecDesc";
            this.ExecDesc.Size = new System.Drawing.Size(88, 13);
            this.ExecDesc.TabIndex = 4;
            this.ExecDesc.Text = "Executable Path:";
            // 
            // Servers2Run
            // 
            this.Servers2Run.FormattingEnabled = true;
            this.Servers2Run.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.Servers2Run.Location = new System.Drawing.Point(151, 12);
            this.Servers2Run.Name = "Servers2Run";
            this.Servers2Run.Size = new System.Drawing.Size(112, 21);
            this.Servers2Run.TabIndex = 5;
            this.Servers2Run.Text = "1";
            this.Servers2Run.DropDown += new System.EventHandler(this.Servers2Run_DropDown);
            this.Servers2Run.SelectedIndexChanged += new System.EventHandler(this.Servers2Run_SelectedIndexChanged);
            // 
            // ServerNum
            // 
            this.ServerNum.AutoSize = true;
            this.ServerNum.Location = new System.Drawing.Point(12, 15);
            this.ServerNum.Name = "ServerNum";
            this.ServerNum.Size = new System.Drawing.Size(133, 13);
            this.ServerNum.TabIndex = 6;
            this.ServerNum.Text = "Ammount of servers to run:";
            // 
            // Server1
            // 
            this.Server1.AutoSize = true;
            this.Server1.Location = new System.Drawing.Point(42, 101);
            this.Server1.Name = "Server1";
            this.Server1.Size = new System.Drawing.Size(54, 13);
            this.Server1.TabIndex = 11;
            this.Server1.Text = "Server #1";
            // 
            // Server2
            // 
            this.Server2.AutoSize = true;
            this.Server2.Location = new System.Drawing.Point(253, 101);
            this.Server2.Name = "Server2";
            this.Server2.Size = new System.Drawing.Size(54, 13);
            this.Server2.TabIndex = 12;
            this.Server2.Text = "Server #2";
            // 
            // Server3
            // 
            this.Server3.AutoSize = true;
            this.Server3.Location = new System.Drawing.Point(461, 101);
            this.Server3.Name = "Server3";
            this.Server3.Size = new System.Drawing.Size(54, 13);
            this.Server3.TabIndex = 13;
            this.Server3.Text = "Server #3";
            // 
            // Server4
            // 
            this.Server4.AutoSize = true;
            this.Server4.Location = new System.Drawing.Point(670, 101);
            this.Server4.Name = "Server4";
            this.Server4.Size = new System.Drawing.Size(54, 13);
            this.Server4.TabIndex = 14;
            this.Server4.Text = "Server #4";
            // 
            // VACCheck1
            // 
            this.VACCheck1.AutoSize = true;
            this.VACCheck1.Location = new System.Drawing.Point(12, 158);
            this.VACCheck1.Name = "VACCheck1";
            this.VACCheck1.Size = new System.Drawing.Size(84, 17);
            this.VACCheck1.TabIndex = 15;
            this.VACCheck1.Text = "VAC Secure";
            this.VACCheck1.UseVisualStyleBackColor = true;
            // 
            // OptionsDesc1
            // 
            this.OptionsDesc1.AutoSize = true;
            this.OptionsDesc1.Location = new System.Drawing.Point(9, 135);
            this.OptionsDesc1.Name = "OptionsDesc1";
            this.OptionsDesc1.Size = new System.Drawing.Size(113, 13);
            this.OptionsDesc1.TabIndex = 16;
            this.OptionsDesc1.Text = "Server startup options:";
            // 
            // BatchCheck1
            // 
            this.BatchCheck1.AutoSize = true;
            this.BatchCheck1.Location = new System.Drawing.Point(12, 181);
            this.BatchCheck1.Name = "BatchCheck1";
            this.BatchCheck1.Size = new System.Drawing.Size(84, 17);
            this.BatchCheck1.TabIndex = 17;
            this.BatchCheck1.Text = "Batch Mode";
            this.BatchCheck1.UseVisualStyleBackColor = true;
            // 
            // NoGraphicsCheck1
            // 
            this.NoGraphicsCheck1.AutoSize = true;
            this.NoGraphicsCheck1.Location = new System.Drawing.Point(12, 206);
            this.NoGraphicsCheck1.Name = "NoGraphicsCheck1";
            this.NoGraphicsCheck1.Size = new System.Drawing.Size(85, 17);
            this.NoGraphicsCheck1.TabIndex = 18;
            this.NoGraphicsCheck1.Text = "No Graphics";
            this.NoGraphicsCheck1.UseVisualStyleBackColor = true;
            // 
            // ServerName1
            // 
            this.ServerName1.Location = new System.Drawing.Point(12, 229);
            this.ServerName1.Name = "ServerName1";
            this.ServerName1.Size = new System.Drawing.Size(100, 20);
            this.ServerName1.TabIndex = 19;
            // 
            // NameDesc1
            // 
            this.NameDesc1.AutoSize = true;
            this.NameDesc1.Location = new System.Drawing.Point(118, 232);
            this.NameDesc1.Name = "NameDesc1";
            this.NameDesc1.Size = new System.Drawing.Size(79, 13);
            this.NameDesc1.TabIndex = 20;
            this.NameDesc1.Text = "Name of server";
            // 
            // NameDesc2
            // 
            this.NameDesc2.AutoSize = true;
            this.NameDesc2.Location = new System.Drawing.Point(328, 232);
            this.NameDesc2.Name = "NameDesc2";
            this.NameDesc2.Size = new System.Drawing.Size(79, 13);
            this.NameDesc2.TabIndex = 26;
            this.NameDesc2.Text = "Name of server";
            // 
            // ServerName2
            // 
            this.ServerName2.Location = new System.Drawing.Point(222, 229);
            this.ServerName2.Name = "ServerName2";
            this.ServerName2.Size = new System.Drawing.Size(100, 20);
            this.ServerName2.TabIndex = 25;
            // 
            // NoGraphicsCheck2
            // 
            this.NoGraphicsCheck2.AutoSize = true;
            this.NoGraphicsCheck2.Location = new System.Drawing.Point(222, 205);
            this.NoGraphicsCheck2.Name = "NoGraphicsCheck2";
            this.NoGraphicsCheck2.Size = new System.Drawing.Size(85, 17);
            this.NoGraphicsCheck2.TabIndex = 24;
            this.NoGraphicsCheck2.Text = "No Graphics";
            this.NoGraphicsCheck2.UseVisualStyleBackColor = true;
            // 
            // BatchCheck2
            // 
            this.BatchCheck2.AutoSize = true;
            this.BatchCheck2.Location = new System.Drawing.Point(222, 181);
            this.BatchCheck2.Name = "BatchCheck2";
            this.BatchCheck2.Size = new System.Drawing.Size(84, 17);
            this.BatchCheck2.TabIndex = 23;
            this.BatchCheck2.Text = "Batch Mode";
            this.BatchCheck2.UseVisualStyleBackColor = true;
            // 
            // OptionsDesc2
            // 
            this.OptionsDesc2.AutoSize = true;
            this.OptionsDesc2.Location = new System.Drawing.Point(219, 135);
            this.OptionsDesc2.Name = "OptionsDesc2";
            this.OptionsDesc2.Size = new System.Drawing.Size(113, 13);
            this.OptionsDesc2.TabIndex = 22;
            this.OptionsDesc2.Text = "Server startup options:";
            // 
            // VACCheck2
            // 
            this.VACCheck2.AutoSize = true;
            this.VACCheck2.Location = new System.Drawing.Point(222, 158);
            this.VACCheck2.Name = "VACCheck2";
            this.VACCheck2.Size = new System.Drawing.Size(84, 17);
            this.VACCheck2.TabIndex = 21;
            this.VACCheck2.Text = "VAC Secure";
            this.VACCheck2.UseVisualStyleBackColor = true;
            // 
            // NameDesc4
            // 
            this.NameDesc4.AutoSize = true;
            this.NameDesc4.Location = new System.Drawing.Point(746, 232);
            this.NameDesc4.Name = "NameDesc4";
            this.NameDesc4.Size = new System.Drawing.Size(79, 13);
            this.NameDesc4.TabIndex = 32;
            this.NameDesc4.Text = "Name of server";
            // 
            // ServerName4
            // 
            this.ServerName4.Location = new System.Drawing.Point(640, 229);
            this.ServerName4.Name = "ServerName4";
            this.ServerName4.Size = new System.Drawing.Size(100, 20);
            this.ServerName4.TabIndex = 31;
            // 
            // NoGraphicsCheck4
            // 
            this.NoGraphicsCheck4.AutoSize = true;
            this.NoGraphicsCheck4.Location = new System.Drawing.Point(640, 204);
            this.NoGraphicsCheck4.Name = "NoGraphicsCheck4";
            this.NoGraphicsCheck4.Size = new System.Drawing.Size(85, 17);
            this.NoGraphicsCheck4.TabIndex = 30;
            this.NoGraphicsCheck4.Text = "No Graphics";
            this.NoGraphicsCheck4.UseVisualStyleBackColor = true;
            // 
            // BatchCheck4
            // 
            this.BatchCheck4.AutoSize = true;
            this.BatchCheck4.Location = new System.Drawing.Point(640, 181);
            this.BatchCheck4.Name = "BatchCheck4";
            this.BatchCheck4.Size = new System.Drawing.Size(84, 17);
            this.BatchCheck4.TabIndex = 29;
            this.BatchCheck4.Text = "Batch Mode";
            this.BatchCheck4.UseVisualStyleBackColor = true;
            // 
            // OptionsDesc4
            // 
            this.OptionsDesc4.AutoSize = true;
            this.OptionsDesc4.Location = new System.Drawing.Point(637, 135);
            this.OptionsDesc4.Name = "OptionsDesc4";
            this.OptionsDesc4.Size = new System.Drawing.Size(113, 13);
            this.OptionsDesc4.TabIndex = 28;
            this.OptionsDesc4.Text = "Server startup options:";
            // 
            // VACCheck4
            // 
            this.VACCheck4.AutoSize = true;
            this.VACCheck4.Location = new System.Drawing.Point(640, 158);
            this.VACCheck4.Name = "VACCheck4";
            this.VACCheck4.Size = new System.Drawing.Size(84, 17);
            this.VACCheck4.TabIndex = 27;
            this.VACCheck4.Text = "VAC Secure";
            this.VACCheck4.UseVisualStyleBackColor = true;
            // 
            // NameDesc3
            // 
            this.NameDesc3.AutoSize = true;
            this.NameDesc3.Location = new System.Drawing.Point(537, 232);
            this.NameDesc3.Name = "NameDesc3";
            this.NameDesc3.Size = new System.Drawing.Size(79, 13);
            this.NameDesc3.TabIndex = 38;
            this.NameDesc3.Text = "Name of server";
            // 
            // ServerName3
            // 
            this.ServerName3.Location = new System.Drawing.Point(431, 229);
            this.ServerName3.Name = "ServerName3";
            this.ServerName3.Size = new System.Drawing.Size(100, 20);
            this.ServerName3.TabIndex = 37;
            // 
            // NoGraphicsCheck3
            // 
            this.NoGraphicsCheck3.AutoSize = true;
            this.NoGraphicsCheck3.Location = new System.Drawing.Point(431, 204);
            this.NoGraphicsCheck3.Name = "NoGraphicsCheck3";
            this.NoGraphicsCheck3.Size = new System.Drawing.Size(85, 17);
            this.NoGraphicsCheck3.TabIndex = 36;
            this.NoGraphicsCheck3.Text = "No Graphics";
            this.NoGraphicsCheck3.UseVisualStyleBackColor = true;
            // 
            // BatchCheck3
            // 
            this.BatchCheck3.AutoSize = true;
            this.BatchCheck3.Location = new System.Drawing.Point(431, 181);
            this.BatchCheck3.Name = "BatchCheck3";
            this.BatchCheck3.Size = new System.Drawing.Size(84, 17);
            this.BatchCheck3.TabIndex = 35;
            this.BatchCheck3.Text = "Batch Mode";
            this.BatchCheck3.UseVisualStyleBackColor = true;
            // 
            // OptionsDesc3
            // 
            this.OptionsDesc3.AutoSize = true;
            this.OptionsDesc3.Location = new System.Drawing.Point(428, 135);
            this.OptionsDesc3.Name = "OptionsDesc3";
            this.OptionsDesc3.Size = new System.Drawing.Size(113, 13);
            this.OptionsDesc3.TabIndex = 34;
            this.OptionsDesc3.Text = "Server startup options:";
            // 
            // VACCheck3
            // 
            this.VACCheck3.AutoSize = true;
            this.VACCheck3.Location = new System.Drawing.Point(431, 158);
            this.VACCheck3.Name = "VACCheck3";
            this.VACCheck3.Size = new System.Drawing.Size(84, 17);
            this.VACCheck3.TabIndex = 33;
            this.VACCheck3.Text = "VAC Secure";
            this.VACCheck3.UseVisualStyleBackColor = true;
            // 
            // AdvancedOptions1
            // 
            this.AdvancedOptions1.Location = new System.Drawing.Point(12, 256);
            this.AdvancedOptions1.Name = "AdvancedOptions1";
            this.AdvancedOptions1.Size = new System.Drawing.Size(100, 23);
            this.AdvancedOptions1.TabIndex = 39;
            this.AdvancedOptions1.Text = "Advanced Config";
            this.AdvancedOptions1.UseVisualStyleBackColor = true;
            this.AdvancedOptions1.Click += new System.EventHandler(this.AdvancedOptions1_Click);
            // 
            // AdvancedOptions2
            // 
            this.AdvancedOptions2.Location = new System.Drawing.Point(222, 256);
            this.AdvancedOptions2.Name = "AdvancedOptions2";
            this.AdvancedOptions2.Size = new System.Drawing.Size(100, 23);
            this.AdvancedOptions2.TabIndex = 40;
            this.AdvancedOptions2.Text = "Advanced Config";
            this.AdvancedOptions2.UseVisualStyleBackColor = true;
            this.AdvancedOptions2.Click += new System.EventHandler(this.AdvancedOptions2_Click);
            // 
            // AdvancedOptions3
            // 
            this.AdvancedOptions3.Location = new System.Drawing.Point(431, 256);
            this.AdvancedOptions3.Name = "AdvancedOptions3";
            this.AdvancedOptions3.Size = new System.Drawing.Size(100, 23);
            this.AdvancedOptions3.TabIndex = 41;
            this.AdvancedOptions3.Text = "Advanced Config";
            this.AdvancedOptions3.UseVisualStyleBackColor = true;
            this.AdvancedOptions3.Click += new System.EventHandler(this.AdvancedOptions3_Click);
            // 
            // AdvancedOptions4
            // 
            this.AdvancedOptions4.Location = new System.Drawing.Point(640, 256);
            this.AdvancedOptions4.Name = "AdvancedOptions4";
            this.AdvancedOptions4.Size = new System.Drawing.Size(100, 23);
            this.AdvancedOptions4.TabIndex = 42;
            this.AdvancedOptions4.Text = "Advanced Config";
            this.AdvancedOptions4.UseVisualStyleBackColor = true;
            this.AdvancedOptions4.Click += new System.EventHandler(this.AdvancedOptions4_Click);
            // 
            // Shutdown
            // 
            this.Shutdown.Location = new System.Drawing.Point(613, 304);
            this.Shutdown.Name = "Shutdown";
            this.Shutdown.Size = new System.Drawing.Size(108, 23);
            this.Shutdown.TabIndex = 43;
            this.Shutdown.Text = "Shutdown Server(s)";
            this.Shutdown.UseVisualStyleBackColor = true;
            this.Shutdown.Click += new System.EventHandler(this.Shutdown_Click);
            // 
            // Restart
            // 
            this.Restart.Location = new System.Drawing.Point(727, 304);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(95, 23);
            this.Restart.TabIndex = 44;
            this.Restart.Text = "Restart Server(s)";
            this.Restart.UseVisualStyleBackColor = true;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // GithubLink
            // 
            this.GithubLink.AutoSize = true;
            this.GithubLink.Location = new System.Drawing.Point(13, 337);
            this.GithubLink.Name = "GithubLink";
            this.GithubLink.Size = new System.Drawing.Size(133, 13);
            this.GithubLink.TabIndex = 45;
            this.GithubLink.TabStop = true;
            this.GithubLink.Text = "Github Post (Source Code)";
            this.GithubLink.VisitedLinkColor = System.Drawing.Color.Black;
            this.GithubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GithubLink_LinkClicked);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 362);
            this.Controls.Add(this.GithubLink);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.Shutdown);
            this.Controls.Add(this.AdvancedOptions4);
            this.Controls.Add(this.AdvancedOptions3);
            this.Controls.Add(this.AdvancedOptions2);
            this.Controls.Add(this.AdvancedOptions1);
            this.Controls.Add(this.NameDesc3);
            this.Controls.Add(this.ServerName3);
            this.Controls.Add(this.NoGraphicsCheck3);
            this.Controls.Add(this.BatchCheck3);
            this.Controls.Add(this.OptionsDesc3);
            this.Controls.Add(this.VACCheck3);
            this.Controls.Add(this.NameDesc4);
            this.Controls.Add(this.ServerName4);
            this.Controls.Add(this.NoGraphicsCheck4);
            this.Controls.Add(this.BatchCheck4);
            this.Controls.Add(this.OptionsDesc4);
            this.Controls.Add(this.VACCheck4);
            this.Controls.Add(this.NameDesc2);
            this.Controls.Add(this.ServerName2);
            this.Controls.Add(this.NoGraphicsCheck2);
            this.Controls.Add(this.BatchCheck2);
            this.Controls.Add(this.OptionsDesc2);
            this.Controls.Add(this.VACCheck2);
            this.Controls.Add(this.NameDesc1);
            this.Controls.Add(this.ServerName1);
            this.Controls.Add(this.NoGraphicsCheck1);
            this.Controls.Add(this.BatchCheck1);
            this.Controls.Add(this.OptionsDesc1);
            this.Controls.Add(this.VACCheck1);
            this.Controls.Add(this.Server4);
            this.Controls.Add(this.Server3);
            this.Controls.Add(this.Server2);
            this.Controls.Add(this.Server1);
            this.Controls.Add(this.ServerNum);
            this.Controls.Add(this.Servers2Run);
            this.Controls.Add(this.ExecDesc);
            this.Controls.Add(this.ExecPath);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.CreditsMin2);
            this.Controls.Add(this.CreditsMin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CreditsMin1;
        private System.Windows.Forms.Label CreditsMin2;
        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.TextBox ExecPath;
        private System.Windows.Forms.Label ExecDesc;
        private System.Windows.Forms.ComboBox Servers2Run;
        private System.Windows.Forms.Label ServerNum;
        private System.Windows.Forms.Label Server1;
        private System.Windows.Forms.Label Server2;
        private System.Windows.Forms.Label Server3;
        private System.Windows.Forms.Label Server4;
        private System.Windows.Forms.CheckBox VACCheck1;
        private System.Windows.Forms.Label OptionsDesc1;
        private System.Windows.Forms.CheckBox BatchCheck1;
        private System.Windows.Forms.CheckBox NoGraphicsCheck1;
        private System.Windows.Forms.TextBox ServerName1;
        private System.Windows.Forms.Label NameDesc1;
        private System.Windows.Forms.Label NameDesc2;
        private System.Windows.Forms.TextBox ServerName2;
        private System.Windows.Forms.CheckBox NoGraphicsCheck2;
        private System.Windows.Forms.CheckBox BatchCheck2;
        private System.Windows.Forms.Label OptionsDesc2;
        private System.Windows.Forms.CheckBox VACCheck2;
        private System.Windows.Forms.Label NameDesc4;
        private System.Windows.Forms.TextBox ServerName4;
        private System.Windows.Forms.CheckBox NoGraphicsCheck4;
        private System.Windows.Forms.CheckBox BatchCheck4;
        private System.Windows.Forms.Label OptionsDesc4;
        private System.Windows.Forms.CheckBox VACCheck4;
        private System.Windows.Forms.Label NameDesc3;
        private System.Windows.Forms.TextBox ServerName3;
        private System.Windows.Forms.CheckBox NoGraphicsCheck3;
        private System.Windows.Forms.CheckBox BatchCheck3;
        private System.Windows.Forms.Label OptionsDesc3;
        private System.Windows.Forms.CheckBox VACCheck3;
        private System.Windows.Forms.Button AdvancedOptions1;
        private System.Windows.Forms.Button AdvancedOptions2;
        private System.Windows.Forms.Button AdvancedOptions3;
        private System.Windows.Forms.Button AdvancedOptions4;
        private System.Windows.Forms.Button Shutdown;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.LinkLabel GithubLink;
    }
}

