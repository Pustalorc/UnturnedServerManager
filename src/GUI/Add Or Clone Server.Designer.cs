using System.ComponentModel;
using System.Windows.Forms;

namespace Pustalorc.Applications.USM.GUI
{
    internal sealed partial class AddServer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.Instructions = new System.Windows.Forms.Label();
            this.ServerName = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Instructions
            // 
            this.Instructions.AutoSize = true;
            this.Instructions.Location = new System.Drawing.Point(13, 13);
            this.Instructions.Name = "Instructions";
            this.Instructions.Size = new System.Drawing.Size(202, 13);
            this.Instructions.TabIndex = 0;
            this.Instructions.Text = "Please type the local name for the server:";
            // 
            // ServerName
            // 
            this.ServerName.Location = new System.Drawing.Point(12, 39);
            this.ServerName.Name = "ServerName";
            this.ServerName.Size = new System.Drawing.Size(203, 20);
            this.ServerName.TabIndex = 1;
            this.ServerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ServerName_KeyPress);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(59, 65);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 2;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(140, 65);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // AddServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 99);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.ServerName);
            this.Controls.Add(this.Instructions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddServer";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adding a new server...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddServer_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Instructions;
        public TextBox ServerName;
        private Button OK;
        private Button Cancel;
    }
}