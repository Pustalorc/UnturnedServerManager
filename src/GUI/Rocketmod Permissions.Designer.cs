namespace ATORTTeam.UnturnedServerManager.GUI
{
    partial class RocketPermissions
    {/// <summary>
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
            this.Groups_TXT = new System.Windows.Forms.Label();
            this.Groups = new System.Windows.Forms.ListBox();
            this.Add = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.DisplayName_TXT = new System.Windows.Forms.Label();
            this.DisplayName = new System.Windows.Forms.TextBox();
            this.Prefix_TXT = new System.Windows.Forms.Label();
            this.Prefix = new System.Windows.Forms.TextBox();
            this.Suffix = new System.Windows.Forms.TextBox();
            this.Suffix_TXT = new System.Windows.Forms.Label();
            this.ChatColor_TXT = new System.Windows.Forms.Label();
            this.ParentGroup_TXT = new System.Windows.Forms.Label();
            this.Priority_TXT = new System.Windows.Forms.Label();
            this.RemPerm = new System.Windows.Forms.Button();
            this.AddPerm = new System.Windows.Forms.Button();
            this.Permissions = new System.Windows.Forms.ListBox();
            this.Permissions_TXT = new System.Windows.Forms.Label();
            this.RemMem = new System.Windows.Forms.Button();
            this.AddMem = new System.Windows.Forms.Button();
            this.Members = new System.Windows.Forms.ListBox();
            this.Members_TXT = new System.Windows.Forms.Label();
            this.SExit = new System.Windows.Forms.Button();
            this.Priority = new System.Windows.Forms.NumericUpDown();
            this.Cooldown = new System.Windows.Forms.NumericUpDown();
            this.Cooldown_TXT = new System.Windows.Forms.Label();
            this.ParentGroup = new System.Windows.Forms.ComboBox();
            this.ChatColor = new System.Windows.Forms.TextBox();
            this.Clone = new System.Windows.Forms.Button();
            this.IsDefault = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.Priority)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cooldown)).BeginInit();
            this.SuspendLayout();
            // 
            // Groups_TXT
            // 
            this.Groups_TXT.AutoSize = true;
            this.Groups_TXT.Location = new System.Drawing.Point(12, 9);
            this.Groups_TXT.Name = "Groups_TXT";
            this.Groups_TXT.Size = new System.Drawing.Size(44, 13);
            this.Groups_TXT.TabIndex = 2;
            this.Groups_TXT.Text = "Groups:";
            // 
            // Groups
            // 
            this.Groups.FormattingEnabled = true;
            this.Groups.Location = new System.Drawing.Point(12, 25);
            this.Groups.Name = "Groups";
            this.Groups.Size = new System.Drawing.Size(98, 238);
            this.Groups.Sorted = true;
            this.Groups.TabIndex = 3;
            this.Groups.SelectedIndexChanged += new System.EventHandler(this.Groups_SelectedIndexChanged);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(12, 269);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(34, 23);
            this.Add.TabIndex = 4;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(52, 269);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(58, 23);
            this.Remove.TabIndex = 5;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // DisplayName_TXT
            // 
            this.DisplayName_TXT.AutoSize = true;
            this.DisplayName_TXT.Location = new System.Drawing.Point(116, 9);
            this.DisplayName_TXT.Name = "DisplayName_TXT";
            this.DisplayName_TXT.Size = new System.Drawing.Size(75, 13);
            this.DisplayName_TXT.TabIndex = 6;
            this.DisplayName_TXT.Text = "Display Name:";
            // 
            // DisplayName
            // 
            this.DisplayName.Location = new System.Drawing.Point(116, 25);
            this.DisplayName.Name = "DisplayName";
            this.DisplayName.Size = new System.Drawing.Size(104, 20);
            this.DisplayName.TabIndex = 7;
            this.DisplayName.TextChanged += new System.EventHandler(this.DisplayName_TextChanged);
            // 
            // Prefix_TXT
            // 
            this.Prefix_TXT.AutoSize = true;
            this.Prefix_TXT.Location = new System.Drawing.Point(116, 48);
            this.Prefix_TXT.Name = "Prefix_TXT";
            this.Prefix_TXT.Size = new System.Drawing.Size(36, 13);
            this.Prefix_TXT.TabIndex = 8;
            this.Prefix_TXT.Text = "Prefix:";
            // 
            // Prefix
            // 
            this.Prefix.Location = new System.Drawing.Point(116, 64);
            this.Prefix.Name = "Prefix";
            this.Prefix.Size = new System.Drawing.Size(104, 20);
            this.Prefix.TabIndex = 9;
            this.Prefix.TextChanged += new System.EventHandler(this.Prefix_TextChanged);
            // 
            // Suffix
            // 
            this.Suffix.Location = new System.Drawing.Point(116, 103);
            this.Suffix.Name = "Suffix";
            this.Suffix.Size = new System.Drawing.Size(104, 20);
            this.Suffix.TabIndex = 11;
            this.Suffix.TextChanged += new System.EventHandler(this.Suffix_TextChanged);
            // 
            // Suffix_TXT
            // 
            this.Suffix_TXT.AutoSize = true;
            this.Suffix_TXT.Location = new System.Drawing.Point(116, 87);
            this.Suffix_TXT.Name = "Suffix_TXT";
            this.Suffix_TXT.Size = new System.Drawing.Size(36, 13);
            this.Suffix_TXT.TabIndex = 10;
            this.Suffix_TXT.Text = "Suffix:";
            // 
            // ChatColor_TXT
            // 
            this.ChatColor_TXT.AutoSize = true;
            this.ChatColor_TXT.Location = new System.Drawing.Point(116, 126);
            this.ChatColor_TXT.Name = "ChatColor_TXT";
            this.ChatColor_TXT.Size = new System.Drawing.Size(59, 13);
            this.ChatColor_TXT.TabIndex = 12;
            this.ChatColor_TXT.Text = "Chat Color:";
            // 
            // ParentGroup_TXT
            // 
            this.ParentGroup_TXT.AutoSize = true;
            this.ParentGroup_TXT.Location = new System.Drawing.Point(116, 168);
            this.ParentGroup_TXT.Name = "ParentGroup_TXT";
            this.ParentGroup_TXT.Size = new System.Drawing.Size(73, 13);
            this.ParentGroup_TXT.TabIndex = 14;
            this.ParentGroup_TXT.Text = "Parent Group:";
            // 
            // Priority_TXT
            // 
            this.Priority_TXT.AutoSize = true;
            this.Priority_TXT.Location = new System.Drawing.Point(116, 208);
            this.Priority_TXT.Name = "Priority_TXT";
            this.Priority_TXT.Size = new System.Drawing.Size(41, 13);
            this.Priority_TXT.TabIndex = 16;
            this.Priority_TXT.Text = "Priority:";
            // 
            // RemPerm
            // 
            this.RemPerm.Location = new System.Drawing.Point(346, 295);
            this.RemPerm.Name = "RemPerm";
            this.RemPerm.Size = new System.Drawing.Size(58, 23);
            this.RemPerm.TabIndex = 21;
            this.RemPerm.Text = "Remove";
            this.RemPerm.UseVisualStyleBackColor = true;
            this.RemPerm.Click += new System.EventHandler(this.RemPerm_Click);
            // 
            // AddPerm
            // 
            this.AddPerm.Location = new System.Drawing.Point(226, 295);
            this.AddPerm.Name = "AddPerm";
            this.AddPerm.Size = new System.Drawing.Size(34, 23);
            this.AddPerm.TabIndex = 20;
            this.AddPerm.Text = "Add";
            this.AddPerm.UseVisualStyleBackColor = true;
            this.AddPerm.Click += new System.EventHandler(this.AddPerm_Click);
            // 
            // Permissions
            // 
            this.Permissions.FormattingEnabled = true;
            this.Permissions.Location = new System.Drawing.Point(226, 25);
            this.Permissions.Name = "Permissions";
            this.Permissions.Size = new System.Drawing.Size(178, 238);
            this.Permissions.Sorted = true;
            this.Permissions.TabIndex = 19;
            this.Permissions.SelectedIndexChanged += new System.EventHandler(this.Permissions_SelectedIndexChanged);
            // 
            // Permissions_TXT
            // 
            this.Permissions_TXT.AutoSize = true;
            this.Permissions_TXT.Location = new System.Drawing.Point(226, 9);
            this.Permissions_TXT.Name = "Permissions_TXT";
            this.Permissions_TXT.Size = new System.Drawing.Size(65, 13);
            this.Permissions_TXT.TabIndex = 18;
            this.Permissions_TXT.Text = "Permissions:";
            // 
            // RemMem
            // 
            this.RemMem.Location = new System.Drawing.Point(513, 295);
            this.RemMem.Name = "RemMem";
            this.RemMem.Size = new System.Drawing.Size(58, 23);
            this.RemMem.TabIndex = 25;
            this.RemMem.Text = "Remove";
            this.RemMem.UseVisualStyleBackColor = true;
            this.RemMem.Click += new System.EventHandler(this.RemMem_Click);
            // 
            // AddMem
            // 
            this.AddMem.Location = new System.Drawing.Point(410, 295);
            this.AddMem.Name = "AddMem";
            this.AddMem.Size = new System.Drawing.Size(34, 23);
            this.AddMem.TabIndex = 24;
            this.AddMem.Text = "Add";
            this.AddMem.UseVisualStyleBackColor = true;
            this.AddMem.Click += new System.EventHandler(this.AddMem_Click);
            // 
            // Members
            // 
            this.Members.FormattingEnabled = true;
            this.Members.Location = new System.Drawing.Point(410, 51);
            this.Members.Name = "Members";
            this.Members.Size = new System.Drawing.Size(161, 238);
            this.Members.Sorted = true;
            this.Members.TabIndex = 23;
            this.Members.SelectedIndexChanged += new System.EventHandler(this.Members_SelectedIndexChanged);
            // 
            // Members_TXT
            // 
            this.Members_TXT.AutoSize = true;
            this.Members_TXT.Location = new System.Drawing.Point(407, 35);
            this.Members_TXT.Name = "Members_TXT";
            this.Members_TXT.Size = new System.Drawing.Size(53, 13);
            this.Members_TXT.TabIndex = 22;
            this.Members_TXT.Text = "Members:";
            // 
            // SExit
            // 
            this.SExit.Location = new System.Drawing.Point(489, 12);
            this.SExit.Name = "SExit";
            this.SExit.Size = new System.Drawing.Size(82, 23);
            this.SExit.TabIndex = 26;
            this.SExit.Text = "Save And Exit";
            this.SExit.UseVisualStyleBackColor = true;
            this.SExit.Click += new System.EventHandler(this.SExit_Click);
            // 
            // Priority
            // 
            this.Priority.Location = new System.Drawing.Point(116, 224);
            this.Priority.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.Priority.Minimum = new decimal(new int[] {
            32768,
            0,
            0,
            -2147483648});
            this.Priority.Name = "Priority";
            this.Priority.Size = new System.Drawing.Size(104, 20);
            this.Priority.TabIndex = 30;
            this.Priority.ValueChanged += new System.EventHandler(this.Priority_ValueChanged);
            // 
            // Cooldown
            // 
            this.Cooldown.Location = new System.Drawing.Point(289, 269);
            this.Cooldown.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.Cooldown.Name = "Cooldown";
            this.Cooldown.Size = new System.Drawing.Size(115, 20);
            this.Cooldown.TabIndex = 32;
            this.Cooldown.ValueChanged += new System.EventHandler(this.Cooldown_ValueChanged);
            // 
            // Cooldown_TXT
            // 
            this.Cooldown_TXT.AutoSize = true;
            this.Cooldown_TXT.Location = new System.Drawing.Point(226, 271);
            this.Cooldown_TXT.Name = "Cooldown_TXT";
            this.Cooldown_TXT.Size = new System.Drawing.Size(57, 13);
            this.Cooldown_TXT.TabIndex = 31;
            this.Cooldown_TXT.Text = "Cooldown:";
            // 
            // ParentGroup
            // 
            this.ParentGroup.FormattingEnabled = true;
            this.ParentGroup.Location = new System.Drawing.Point(116, 184);
            this.ParentGroup.Name = "ParentGroup";
            this.ParentGroup.Size = new System.Drawing.Size(104, 21);
            this.ParentGroup.TabIndex = 34;
            this.ParentGroup.SelectedIndexChanged += new System.EventHandler(this.ParentGroup_SelectedIndexChanged);
            // 
            // ChatColor
            // 
            this.ChatColor.Location = new System.Drawing.Point(116, 145);
            this.ChatColor.Name = "ChatColor";
            this.ChatColor.Size = new System.Drawing.Size(104, 20);
            this.ChatColor.TabIndex = 13;
            this.ChatColor.TextChanged += new System.EventHandler(this.ChatColor_TextChanged);
            // 
            // Clone
            // 
            this.Clone.Location = new System.Drawing.Point(12, 295);
            this.Clone.Name = "Clone";
            this.Clone.Size = new System.Drawing.Size(98, 23);
            this.Clone.TabIndex = 36;
            this.Clone.Text = "Clone";
            this.Clone.UseVisualStyleBackColor = true;
            this.Clone.Click += new System.EventHandler(this.Clone_Click);
            // 
            // IsDefault
            // 
            this.IsDefault.AutoSize = true;
            this.IsDefault.Location = new System.Drawing.Point(119, 250);
            this.IsDefault.Name = "IsDefault";
            this.IsDefault.Size = new System.Drawing.Size(102, 17);
            this.IsDefault.TabIndex = 37;
            this.IsDefault.TabStop = true;
            this.IsDefault.Text = "Is Default Group";
            this.IsDefault.UseVisualStyleBackColor = true;
            this.IsDefault.CheckedChanged += new System.EventHandler(this.IsDefault_CheckedChanged);
            // 
            // RocketPermissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 330);
            this.Controls.Add(this.IsDefault);
            this.Controls.Add(this.Clone);
            this.Controls.Add(this.ParentGroup);
            this.Controls.Add(this.Cooldown);
            this.Controls.Add(this.Cooldown_TXT);
            this.Controls.Add(this.Priority);
            this.Controls.Add(this.SExit);
            this.Controls.Add(this.RemMem);
            this.Controls.Add(this.AddMem);
            this.Controls.Add(this.Members);
            this.Controls.Add(this.Members_TXT);
            this.Controls.Add(this.RemPerm);
            this.Controls.Add(this.AddPerm);
            this.Controls.Add(this.Permissions);
            this.Controls.Add(this.Permissions_TXT);
            this.Controls.Add(this.Priority_TXT);
            this.Controls.Add(this.ParentGroup_TXT);
            this.Controls.Add(this.ChatColor);
            this.Controls.Add(this.ChatColor_TXT);
            this.Controls.Add(this.Suffix);
            this.Controls.Add(this.Suffix_TXT);
            this.Controls.Add(this.Prefix);
            this.Controls.Add(this.Prefix_TXT);
            this.Controls.Add(this.DisplayName);
            this.Controls.Add(this.DisplayName_TXT);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Groups);
            this.Controls.Add(this.Groups_TXT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RocketPermissions";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Permissions Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RocketPermissions_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Priority)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cooldown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Groups_TXT;
        private System.Windows.Forms.ListBox Groups;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Label DisplayName_TXT;
        private System.Windows.Forms.TextBox DisplayName;
        private System.Windows.Forms.Label Prefix_TXT;
        private System.Windows.Forms.TextBox Prefix;
        private System.Windows.Forms.TextBox Suffix;
        private System.Windows.Forms.Label Suffix_TXT;
        private System.Windows.Forms.Label ChatColor_TXT;
        private System.Windows.Forms.Label ParentGroup_TXT;
        private System.Windows.Forms.Label Priority_TXT;
        private System.Windows.Forms.Button RemPerm;
        private System.Windows.Forms.Button AddPerm;
        private System.Windows.Forms.ListBox Permissions;
        private System.Windows.Forms.Label Permissions_TXT;
        private System.Windows.Forms.Button RemMem;
        private System.Windows.Forms.Button AddMem;
        private System.Windows.Forms.ListBox Members;
        private System.Windows.Forms.Label Members_TXT;
        private System.Windows.Forms.Button SExit;
        private System.Windows.Forms.NumericUpDown Priority;
        private System.Windows.Forms.NumericUpDown Cooldown;
        private System.Windows.Forms.Label Cooldown_TXT;
        private System.Windows.Forms.ComboBox ParentGroup;
        private System.Windows.Forms.TextBox ChatColor;
        private System.Windows.Forms.Button Clone;
        private System.Windows.Forms.RadioButton IsDefault;
    }
}