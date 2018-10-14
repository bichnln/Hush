namespace Hush
{
    partial class ChangePINForm
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
            this.OldPassLabel = new System.Windows.Forms.Label();
            this.PassLabel = new System.Windows.Forms.Label();
            this.PassTextBox = new System.Windows.Forms.TextBox();
            this.OldPassTextBox = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.RetypePassLabel = new System.Windows.Forms.Label();
            this.RetypePassTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OldPassLabel
            // 
            this.OldPassLabel.AutoSize = true;
            this.OldPassLabel.Location = new System.Drawing.Point(12, 71);
            this.OldPassLabel.Name = "OldPassLabel";
            this.OldPassLabel.Size = new System.Drawing.Size(72, 13);
            this.OldPassLabel.TabIndex = 0;
            this.OldPassLabel.Text = "Old Password";
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Location = new System.Drawing.Point(12, 120);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(78, 13);
            this.PassLabel.TabIndex = 1;
            this.PassLabel.Text = "New Password";
            // 
            // PassTextBox
            // 
            this.PassTextBox.Location = new System.Drawing.Point(160, 120);
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.Size = new System.Drawing.Size(240, 20);
            this.PassTextBox.TabIndex = 20;
            this.PassTextBox.UseSystemPasswordChar = true;
            // 
            // OldPassTextBox
            // 
            this.OldPassTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.OldPassTextBox.Location = new System.Drawing.Point(160, 71);
            this.OldPassTextBox.Name = "OldPassTextBox";
            this.OldPassTextBox.Size = new System.Drawing.Size(240, 20);
            this.OldPassTextBox.TabIndex = 19;
            this.OldPassTextBox.UseSystemPasswordChar = true;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(210, 209);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 22;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(325, 209);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 21;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // RetypePassLabel
            // 
            this.RetypePassLabel.AutoSize = true;
            this.RetypePassLabel.Location = new System.Drawing.Point(12, 170);
            this.RetypePassLabel.Name = "RetypePassLabel";
            this.RetypePassLabel.Size = new System.Drawing.Size(115, 13);
            this.RetypePassLabel.TabIndex = 23;
            this.RetypePassLabel.Text = "Retype New Password";
            this.RetypePassLabel.Click += new System.EventHandler(this.RetypePassLabel_Click);
            // 
            // RetypePassTextBox
            // 
            this.RetypePassTextBox.Location = new System.Drawing.Point(160, 167);
            this.RetypePassTextBox.Name = "RetypePassTextBox";
            this.RetypePassTextBox.Size = new System.Drawing.Size(240, 20);
            this.RetypePassTextBox.TabIndex = 24;
            this.RetypePassTextBox.UseSystemPasswordChar = true;
            // 
            // ChangePINForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 299);
            this.Controls.Add(this.RetypePassTextBox);
            this.Controls.Add(this.RetypePassLabel);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.PassTextBox);
            this.Controls.Add(this.OldPassTextBox);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.OldPassLabel);
            this.Name = "ChangePINForm";
            this.Text = "ChangePINForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OldPassLabel;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.TextBox PassTextBox;
        private System.Windows.Forms.TextBox OldPassTextBox;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label RetypePassLabel;
        private System.Windows.Forms.TextBox RetypePassTextBox;
    }
}