namespace Unturned_Server_Manager
{
    partial class RocketInstall
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
            this.Title = new System.Windows.Forms.Label();
            this.DetailsFull = new System.Windows.Forms.RichTextBox();
            this.Completion = new System.Windows.Forms.ProgressBar();
            this.DetailsDesc = new System.Windows.Forms.Label();
            this.Step1 = new System.Windows.Forms.CheckBox();
            this.Step3 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Title.Location = new System.Drawing.Point(12, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(219, 20);
            this.Title.TabIndex = 0;
            this.Title.Text = "Rocket Installation Progress";
            // 
            // DetailsFull
            // 
            this.DetailsFull.Location = new System.Drawing.Point(243, 32);
            this.DetailsFull.Name = "DetailsFull";
            this.DetailsFull.Size = new System.Drawing.Size(300, 189);
            this.DetailsFull.TabIndex = 1;
            this.DetailsFull.Text = "";
            this.DetailsFull.TextChanged += new System.EventHandler(this.DetailsFull_TextChanged);
            // 
            // Completion
            // 
            this.Completion.Location = new System.Drawing.Point(12, 227);
            this.Completion.Name = "Completion";
            this.Completion.Size = new System.Drawing.Size(531, 23);
            this.Completion.TabIndex = 2;
            // 
            // DetailsDesc
            // 
            this.DetailsDesc.AutoSize = true;
            this.DetailsDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.DetailsDesc.Location = new System.Drawing.Point(239, 9);
            this.DetailsDesc.Name = "DetailsDesc";
            this.DetailsDesc.Size = new System.Drawing.Size(67, 20);
            this.DetailsDesc.TabIndex = 3;
            this.DetailsDesc.Text = "Details:";
            // 
            // Step1
            // 
            this.Step1.AutoCheck = false;
            this.Step1.AutoSize = true;
            this.Step1.Enabled = false;
            this.Step1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Step1.Location = new System.Drawing.Point(16, 89);
            this.Step1.Name = "Step1";
            this.Step1.Size = new System.Drawing.Size(181, 24);
            this.Step1.TabIndex = 4;
            this.Step1.Text = "Downloading Rocket";
            this.Step1.UseVisualStyleBackColor = true;
            // 
            // Step3
            // 
            this.Step3.AutoCheck = false;
            this.Step3.AutoSize = true;
            this.Step3.Enabled = false;
            this.Step3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Step3.Location = new System.Drawing.Point(16, 119);
            this.Step3.Name = "Step3";
            this.Step3.Size = new System.Drawing.Size(151, 24);
            this.Step3.TabIndex = 6;
            this.Step3.Text = "Installing Rocket";
            this.Step3.UseVisualStyleBackColor = true;
            // 
            // RocketInstall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(555, 262);
            this.Controls.Add(this.Step3);
            this.Controls.Add(this.Step1);
            this.Controls.Add(this.DetailsDesc);
            this.Controls.Add(this.Completion);
            this.Controls.Add(this.DetailsFull);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RocketInstall";
            this.ShowInTaskbar = false;
            this.Text = "Installing Rocket...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.RichTextBox DetailsFull;
        private System.Windows.Forms.ProgressBar Completion;
        private System.Windows.Forms.Label DetailsDesc;
        private System.Windows.Forms.CheckBox Step1;
        private System.Windows.Forms.CheckBox Step3;
    }
}