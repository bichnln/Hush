namespace Hush
{
    partial class AddNewAccForm
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
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.UsrnameTBox = new System.Windows.Forms.TextBox();
            this.PasswrdLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PNumberLabel = new System.Windows.Forms.Label();
            this.PasswrdTBox = new System.Windows.Forms.TextBox();
            this.ServiceTBox = new System.Windows.Forms.TextBox();
            this.EmailTBox = new System.Windows.Forms.TextBox();
            this.PNumberTBox = new System.Windows.Forms.TextBox();
            this.ServiceLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(380, 360);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 0;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(264, 360);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 1;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // UsrnameTBox
            // 
            this.UsrnameTBox.Location = new System.Drawing.Point(169, 116);
            this.UsrnameTBox.Name = "UsrnameTBox";
            this.UsrnameTBox.Size = new System.Drawing.Size(286, 20);
            this.UsrnameTBox.TabIndex = 3;
            this.UsrnameTBox.TextChanged += new System.EventHandler(this.UsrnameTBox_TextChanged);
            // 
            // PasswrdLabel
            // 
            this.PasswrdLabel.AutoSize = true;
            this.PasswrdLabel.Location = new System.Drawing.Point(89, 165);
            this.PasswrdLabel.Name = "PasswrdLabel";
            this.PasswrdLabel.Size = new System.Drawing.Size(53, 13);
            this.PasswrdLabel.TabIndex = 4;
            this.PasswrdLabel.Text = "Password";
            this.PasswrdLabel.Click += new System.EventHandler(this.PasswrdLabel_Click);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(37, 244);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(107, 13);
            this.EmailLabel.TabIndex = 6;
            this.EmailLabel.Text = "Email used to register";
            this.EmailLabel.Click += new System.EventHandler(this.EmailLabel_Click);
            // 
            // PNumberLabel
            // 
            this.PNumberLabel.AutoSize = true;
            this.PNumberLabel.Location = new System.Drawing.Point(63, 280);
            this.PNumberLabel.Name = "PNumberLabel";
            this.PNumberLabel.Size = new System.Drawing.Size(81, 13);
            this.PNumberLabel.TabIndex = 7;
            this.PNumberLabel.Text = "Phone Number ";
            this.PNumberLabel.Click += new System.EventHandler(this.PNumberLabel_Click);
            // 
            // PasswrdTBox
            // 
            this.PasswrdTBox.Location = new System.Drawing.Point(169, 165);
            this.PasswrdTBox.Name = "PasswrdTBox";
            this.PasswrdTBox.Size = new System.Drawing.Size(286, 20);
            this.PasswrdTBox.TabIndex = 8;
            // 
            // ServiceTBox
            // 
            this.ServiceTBox.Location = new System.Drawing.Point(169, 205);
            this.ServiceTBox.Name = "ServiceTBox";
            this.ServiceTBox.Size = new System.Drawing.Size(286, 20);
            this.ServiceTBox.TabIndex = 9;
            // 
            // EmailTBox
            // 
            this.EmailTBox.Location = new System.Drawing.Point(169, 244);
            this.EmailTBox.Name = "EmailTBox";
            this.EmailTBox.Size = new System.Drawing.Size(286, 20);
            this.EmailTBox.TabIndex = 10;
            // 
            // PNumberTBox
            // 
            this.PNumberTBox.Location = new System.Drawing.Point(169, 280);
            this.PNumberTBox.Name = "PNumberTBox";
            this.PNumberTBox.Size = new System.Drawing.Size(286, 20);
            this.PNumberTBox.TabIndex = 11;
            // 
            // ServiceLabel
            // 
            this.ServiceLabel.AutoSize = true;
            this.ServiceLabel.Location = new System.Drawing.Point(99, 208);
            this.ServiceLabel.Name = "ServiceLabel";
            this.ServiceLabel.Size = new System.Drawing.Size(43, 13);
            this.ServiceLabel.TabIndex = 12;
            this.ServiceLabel.Text = "Service";
            this.ServiceLabel.Click += new System.EventHandler(this.ServiceLabel_Click);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(89, 119);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(55, 13);
            this.UsernameLabel.TabIndex = 13;
            this.UsernameLabel.Text = "Username";
            this.UsernameLabel.Click += new System.EventHandler(this.UsernameLabel_Click);
            // 
            // AddNewAccForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 433);
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
            this.Name = "AddNewAccForm";
            this.Text = "AddNewAccForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TextBox UsrnameTBox;
        private System.Windows.Forms.Label PasswrdLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label PNumberLabel;
        private System.Windows.Forms.TextBox PasswrdTBox;
        private System.Windows.Forms.TextBox ServiceTBox;
        private System.Windows.Forms.TextBox EmailTBox;
        private System.Windows.Forms.TextBox PNumberTBox;
        private System.Windows.Forms.Label ServiceLabel;
        private System.Windows.Forms.Label UsernameLabel;
    }
}