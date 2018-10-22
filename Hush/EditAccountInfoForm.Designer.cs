namespace Hush
{
    partial class EditAccountInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAccountInfoForm));
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.ServiceLabel = new System.Windows.Forms.Label();
            this.PNumberTBox = new System.Windows.Forms.TextBox();
            this.EmailTBox = new System.Windows.Forms.TextBox();
            this.ServiceTBox = new System.Windows.Forms.TextBox();
            this.PasswrdTBox = new System.Windows.Forms.TextBox();
            this.PNumberLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PasswrdLabel = new System.Windows.Forms.Label();
            this.UsrnameTBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.Lavender;
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.SaveBtn.Location = new System.Drawing.Point(166, 231);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 3;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.Lavender;
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.CancelBtn.Location = new System.Drawing.Point(285, 231);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 2;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UsernameLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UsernameLabel.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.UsernameLabel.Location = new System.Drawing.Point(82, 54);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(63, 17);
            this.UsernameLabel.TabIndex = 23;
            this.UsernameLabel.Text = "Username";
            // 
            // ServiceLabel
            // 
            this.ServiceLabel.AutoSize = true;
            this.ServiceLabel.BackColor = System.Drawing.Color.Transparent;
            this.ServiceLabel.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ServiceLabel.Location = new System.Drawing.Point(98, 125);
            this.ServiceLabel.Name = "ServiceLabel";
            this.ServiceLabel.Size = new System.Drawing.Size(47, 17);
            this.ServiceLabel.TabIndex = 22;
            this.ServiceLabel.Text = "Service";
            // 
            // PNumberTBox
            // 
            this.PNumberTBox.Location = new System.Drawing.Point(166, 195);
            this.PNumberTBox.Name = "PNumberTBox";
            this.PNumberTBox.Size = new System.Drawing.Size(194, 20);
            this.PNumberTBox.TabIndex = 21;
            this.PNumberTBox.TextChanged += new System.EventHandler(this.PNumberTBox_TextChanged);
            // 
            // EmailTBox
            // 
            this.EmailTBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.EmailTBox.Enabled = false;
            this.EmailTBox.Location = new System.Drawing.Point(166, 160);
            this.EmailTBox.Name = "EmailTBox";
            this.EmailTBox.Size = new System.Drawing.Size(194, 20);
            this.EmailTBox.TabIndex = 20;
            // 
            // ServiceTBox
            // 
            this.ServiceTBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ServiceTBox.Enabled = false;
            this.ServiceTBox.Location = new System.Drawing.Point(166, 124);
            this.ServiceTBox.Name = "ServiceTBox";
            this.ServiceTBox.Size = new System.Drawing.Size(194, 20);
            this.ServiceTBox.TabIndex = 19;
            // 
            // PasswrdTBox
            // 
            this.PasswrdTBox.Location = new System.Drawing.Point(166, 88);
            this.PasswrdTBox.Name = "PasswrdTBox";
            this.PasswrdTBox.Size = new System.Drawing.Size(194, 20);
            this.PasswrdTBox.TabIndex = 18;
            this.PasswrdTBox.TextChanged += new System.EventHandler(this.PasswrdTBox_TextChanged);
            // 
            // PNumberLabel
            // 
            this.PNumberLabel.AutoSize = true;
            this.PNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.PNumberLabel.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.PNumberLabel.Location = new System.Drawing.Point(22, 196);
            this.PNumberLabel.Name = "PNumberLabel";
            this.PNumberLabel.Size = new System.Drawing.Size(120, 17);
            this.PNumberLabel.TabIndex = 17;
            this.PNumberLabel.Text = "New Phone Number";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.BackColor = System.Drawing.Color.Transparent;
            this.EmailLabel.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.EmailLabel.Location = new System.Drawing.Point(32, 161);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(107, 17);
            this.EmailLabel.TabIndex = 16;
            this.EmailLabel.Text = "Email Registration";
            // 
            // PasswrdLabel
            // 
            this.PasswrdLabel.AutoSize = true;
            this.PasswrdLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswrdLabel.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswrdLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.PasswrdLabel.Location = new System.Drawing.Point(57, 89);
            this.PasswrdLabel.Name = "PasswrdLabel";
            this.PasswrdLabel.Size = new System.Drawing.Size(88, 17);
            this.PasswrdLabel.TabIndex = 15;
            this.PasswrdLabel.Text = "New Password";
            // 
            // UsrnameTBox
            // 
            this.UsrnameTBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.UsrnameTBox.Enabled = false;
            this.UsrnameTBox.Location = new System.Drawing.Point(166, 53);
            this.UsrnameTBox.Name = "UsrnameTBox";
            this.UsrnameTBox.Size = new System.Drawing.Size(194, 20);
            this.UsrnameTBox.TabIndex = 14;
            // 
            // EditAccountInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hush.Properties.Resources.ws_Minimal_Gray_to_White_Gradient_1920x1200;
            this.ClientSize = new System.Drawing.Size(439, 298);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.ServiceLabel);
            this.Controls.Add(this.PNumberTBox);
            this.Controls.Add(this.EmailTBox);
            this.Controls.Add(this.ServiceTBox);
            this.Controls.Add(this.PasswrdTBox);
            this.Controls.Add(this.PNumberLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.PasswrdLabel);
            this.Controls.Add(this.UsrnameTBox);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.CancelBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditAccountInfoForm";
            this.Text = "EditAccountInfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label ServiceLabel;
        private System.Windows.Forms.TextBox PNumberTBox;
        private System.Windows.Forms.TextBox EmailTBox;
        private System.Windows.Forms.TextBox ServiceTBox;
        private System.Windows.Forms.TextBox PasswrdTBox;
        private System.Windows.Forms.Label PNumberLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label PasswrdLabel;
        private System.Windows.Forms.TextBox UsrnameTBox;
    }
}