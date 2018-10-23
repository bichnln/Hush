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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePINForm));
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
            this.OldPassLabel.BackColor = System.Drawing.Color.Transparent;
            this.OldPassLabel.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OldPassLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.OldPassLabel.Location = new System.Drawing.Point(41, 55);
            this.OldPassLabel.Name = "OldPassLabel";
            this.OldPassLabel.Size = new System.Drawing.Size(106, 17);
            this.OldPassLabel.TabIndex = 0;
            this.OldPassLabel.Text = "Current Password";
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.BackColor = System.Drawing.Color.Transparent;
            this.PassLabel.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.PassLabel.Location = new System.Drawing.Point(59, 92);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(88, 17);
            this.PassLabel.TabIndex = 1;
            this.PassLabel.Text = "New Password";
            // 
            // PassTextBox
            // 
            this.PassTextBox.Location = new System.Drawing.Point(155, 91);
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.Size = new System.Drawing.Size(161, 20);
            this.PassTextBox.TabIndex = 20;
            this.PassTextBox.UseSystemPasswordChar = true;
            this.PassTextBox.TextChanged += new System.EventHandler(this.PassTextBox_TextChanged);
            // 
            // OldPassTextBox
            // 
            this.OldPassTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.OldPassTextBox.Location = new System.Drawing.Point(155, 54);
            this.OldPassTextBox.Name = "OldPassTextBox";
            this.OldPassTextBox.Size = new System.Drawing.Size(161, 20);
            this.OldPassTextBox.TabIndex = 19;
            this.OldPassTextBox.UseSystemPasswordChar = true;
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.Lavender;
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.SaveBtn.Location = new System.Drawing.Point(155, 166);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(68, 23);
            this.SaveBtn.TabIndex = 22;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.Lavender;
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.CancelBtn.Location = new System.Drawing.Point(248, 166);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(68, 23);
            this.CancelBtn.TabIndex = 21;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // RetypePassLabel
            // 
            this.RetypePassLabel.AutoSize = true;
            this.RetypePassLabel.BackColor = System.Drawing.Color.Transparent;
            this.RetypePassLabel.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RetypePassLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.RetypePassLabel.Location = new System.Drawing.Point(38, 128);
            this.RetypePassLabel.Name = "RetypePassLabel";
            this.RetypePassLabel.Size = new System.Drawing.Size(109, 17);
            this.RetypePassLabel.TabIndex = 23;
            this.RetypePassLabel.Text = "Confirm Password";
            this.RetypePassLabel.Click += new System.EventHandler(this.RetypePassLabel_Click);
            // 
            // RetypePassTextBox
            // 
            this.RetypePassTextBox.Location = new System.Drawing.Point(155, 127);
            this.RetypePassTextBox.Name = "RetypePassTextBox";
            this.RetypePassTextBox.Size = new System.Drawing.Size(161, 20);
            this.RetypePassTextBox.TabIndex = 24;
            this.RetypePassTextBox.UseSystemPasswordChar = true;
            // 
            // ChangePINForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hush.Properties.Resources.ws_Minimal_Gray_to_White_Gradient_1920x1200;
            this.ClientSize = new System.Drawing.Size(369, 222);
            this.Controls.Add(this.RetypePassTextBox);
            this.Controls.Add(this.RetypePassLabel);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.PassTextBox);
            this.Controls.Add(this.OldPassTextBox);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.OldPassLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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