namespace Installer
{
    partial class OneTime
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
            this.Next = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.Option1 = new System.Windows.Forms.RadioButton();
            this.Option2 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(12, 226);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Next
            // 
            this.Next.Enabled = false;
            this.Next.Location = new System.Drawing.Point(397, 226);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 3;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Title.Location = new System.Drawing.Point(111, 41);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(259, 24);
            this.Title.TabIndex = 5;
            this.Title.Text = "Select a level of configuration:";
            // 
            // Option1
            // 
            this.Option1.AutoSize = true;
            this.Option1.Location = new System.Drawing.Point(171, 106);
            this.Option1.Name = "Option1";
            this.Option1.Size = new System.Drawing.Size(86, 17);
            this.Option1.TabIndex = 6;
            this.Option1.TabStop = true;
            this.Option1.Text = "Option1 Text";
            this.Option1.UseVisualStyleBackColor = true;
            this.Option1.CheckedChanged += new System.EventHandler(this.RServer_CheckedChanged);
            // 
            // Option2
            // 
            this.Option2.AutoSize = true;
            this.Option2.Location = new System.Drawing.Point(171, 129);
            this.Option2.Name = "Option2";
            this.Option2.Size = new System.Drawing.Size(86, 17);
            this.Option2.TabIndex = 7;
            this.Option2.TabStop = true;
            this.Option2.Text = "Option2 Text";
            this.Option2.UseVisualStyleBackColor = true;
            this.Option2.CheckedChanged += new System.EventHandler(this.VServer_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(171, 152);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // OneTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Option2);
            this.Controls.Add(this.Option1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Next);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "OneTime";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "One Time Run";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.RadioButton Option1;
        private System.Windows.Forms.RadioButton Option2;
        private System.Windows.Forms.TextBox textBox1;
    }
}