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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NewPinTBox = new System.Windows.Forms.TextBox();
            this.OldPinTBox = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Old PIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "New PIN";
            // 
            // NewPinTBox
            // 
            this.NewPinTBox.Location = new System.Drawing.Point(114, 120);
            this.NewPinTBox.Name = "NewPinTBox";
            this.NewPinTBox.Size = new System.Drawing.Size(286, 20);
            this.NewPinTBox.TabIndex = 20;
            // 
            // OldPinTBox
            // 
            this.OldPinTBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.OldPinTBox.Enabled = false;
            this.OldPinTBox.Location = new System.Drawing.Point(114, 71);
            this.OldPinTBox.Name = "OldPinTBox";
            this.OldPinTBox.Size = new System.Drawing.Size(286, 20);
            this.OldPinTBox.TabIndex = 19;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(210, 209);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 22;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
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
            // ChangePINForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 299);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.NewPinTBox);
            this.Controls.Add(this.OldPinTBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChangePINForm";
            this.Text = "ChangePINForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NewPinTBox;
        private System.Windows.Forms.TextBox OldPinTBox;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}