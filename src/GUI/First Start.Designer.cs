namespace ATORTTeam.UnturnedServerManager.GUI
{
    partial class FirstStart
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
            this.Msg = new System.Windows.Forms.Label();
            this.SelectedPath = new System.Windows.Forms.TextBox();
            this.Browse = new System.Windows.Forms.Button();
            this.FolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.ValidatePath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Msg
            // 
            this.Msg.AutoSize = true;
            this.Msg.Location = new System.Drawing.Point(12, 9);
            this.Msg.Name = "Msg";
            this.Msg.Size = new System.Drawing.Size(463, 39);
            this.Msg.TabIndex = 0;
            this.Msg.Text = "Welcome to Unturned Server Manager\'s first-startup configuration!\r\n\r\nPlease speci" +
    "fy the directory to which Unturned will be installed to and used for hosting the" +
    " server.\r\n";
            // 
            // SelectedPath
            // 
            this.SelectedPath.Location = new System.Drawing.Point(12, 60);
            this.SelectedPath.Name = "SelectedPath";
            this.SelectedPath.Size = new System.Drawing.Size(378, 20);
            this.SelectedPath.TabIndex = 1;
            this.SelectedPath.Text = "C:\\Servers";
            this.SelectedPath.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SelectedPath_KeyPress);
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(396, 58);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(75, 23);
            this.Browse.TabIndex = 2;
            this.Browse.Text = "Browse...";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // FolderBrowser
            // 
            this.FolderBrowser.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // ValidatePath
            // 
            this.ValidatePath.Location = new System.Drawing.Point(396, 87);
            this.ValidatePath.Name = "ValidatePath";
            this.ValidatePath.Size = new System.Drawing.Size(75, 23);
            this.ValidatePath.TabIndex = 3;
            this.ValidatePath.Text = "Accept";
            this.ValidatePath.UseVisualStyleBackColor = true;
            this.ValidatePath.Click += new System.EventHandler(this.Validate_Click);
            // 
            // FirstStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 121);
            this.Controls.Add(this.ValidatePath);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.SelectedPath);
            this.Controls.Add(this.Msg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FirstStart";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "First Startup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FirstStart_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Msg;
        private System.Windows.Forms.TextBox SelectedPath;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowser;
        private System.Windows.Forms.Button ValidatePath;
    }
}