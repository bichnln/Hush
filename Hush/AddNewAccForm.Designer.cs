﻿namespace Hush
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewAccForm));
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
            this.hushDatabaseDataSet = new Hush.HushDatabaseDataSet();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new Hush.HushDatabaseDataSetTableAdapters.TableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hushDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelBtn
            // 
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.CancelBtn.Location = new System.Drawing.Point(267, 263);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 0;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.SaveBtn.Location = new System.Drawing.Point(146, 263);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 1;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // UsrnameTBox
            // 
            this.UsrnameTBox.Location = new System.Drawing.Point(146, 66);
            this.UsrnameTBox.Name = "UsrnameTBox";
            this.UsrnameTBox.Size = new System.Drawing.Size(196, 20);
            this.UsrnameTBox.TabIndex = 3;
            this.UsrnameTBox.TextChanged += new System.EventHandler(this.UsrnameTBox_TextChanged);
            // 
            // PasswrdLabel
            // 
            this.PasswrdLabel.AutoSize = true;
            this.PasswrdLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswrdLabel.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswrdLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.PasswrdLabel.Location = new System.Drawing.Point(73, 105);
            this.PasswrdLabel.Name = "PasswrdLabel";
            this.PasswrdLabel.Size = new System.Drawing.Size(60, 17);
            this.PasswrdLabel.TabIndex = 4;
            this.PasswrdLabel.Text = "Password";
            this.PasswrdLabel.Click += new System.EventHandler(this.PasswrdLabel_Click);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.BackColor = System.Drawing.Color.Transparent;
            this.EmailLabel.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.EmailLabel.Location = new System.Drawing.Point(20, 184);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(107, 17);
            this.EmailLabel.TabIndex = 6;
            this.EmailLabel.Text = "Email Registration";
            this.EmailLabel.Click += new System.EventHandler(this.EmailLabel_Click);
            // 
            // PNumberLabel
            // 
            this.PNumberLabel.AutoSize = true;
            this.PNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.PNumberLabel.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.PNumberLabel.Location = new System.Drawing.Point(38, 220);
            this.PNumberLabel.Name = "PNumberLabel";
            this.PNumberLabel.Size = new System.Drawing.Size(92, 17);
            this.PNumberLabel.TabIndex = 7;
            this.PNumberLabel.Text = "Phone Number";
            this.PNumberLabel.Click += new System.EventHandler(this.PNumberLabel_Click);
            // 
            // PasswrdTBox
            // 
            this.PasswrdTBox.Location = new System.Drawing.Point(146, 104);
            this.PasswrdTBox.Name = "PasswrdTBox";
            this.PasswrdTBox.Size = new System.Drawing.Size(196, 20);
            this.PasswrdTBox.TabIndex = 8;
            // 
            // ServiceTBox
            // 
            this.ServiceTBox.Location = new System.Drawing.Point(146, 144);
            this.ServiceTBox.Name = "ServiceTBox";
            this.ServiceTBox.Size = new System.Drawing.Size(196, 20);
            this.ServiceTBox.TabIndex = 9;
            // 
            // EmailTBox
            // 
            this.EmailTBox.Location = new System.Drawing.Point(146, 183);
            this.EmailTBox.Name = "EmailTBox";
            this.EmailTBox.Size = new System.Drawing.Size(196, 20);
            this.EmailTBox.TabIndex = 10;
            // 
            // PNumberTBox
            // 
            this.PNumberTBox.Location = new System.Drawing.Point(146, 219);
            this.PNumberTBox.Name = "PNumberTBox";
            this.PNumberTBox.Size = new System.Drawing.Size(196, 20);
            this.PNumberTBox.TabIndex = 11;
            // 
            // ServiceLabel
            // 
            this.ServiceLabel.AutoSize = true;
            this.ServiceLabel.BackColor = System.Drawing.Color.Transparent;
            this.ServiceLabel.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ServiceLabel.Location = new System.Drawing.Point(86, 145);
            this.ServiceLabel.Name = "ServiceLabel";
            this.ServiceLabel.Size = new System.Drawing.Size(47, 17);
            this.ServiceLabel.TabIndex = 12;
            this.ServiceLabel.Text = "Service";
            this.ServiceLabel.Click += new System.EventHandler(this.ServiceLabel_Click);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UsernameLabel.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.UsernameLabel.Location = new System.Drawing.Point(70, 67);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(63, 17);
            this.UsernameLabel.TabIndex = 13;
            this.UsernameLabel.Text = "Username";
            this.UsernameLabel.Click += new System.EventHandler(this.UsernameLabel_Click);
            // 
            // hushDatabaseDataSet
            // 
            this.hushDatabaseDataSet.DataSetName = "HushDatabaseDataSet";
            this.hushDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.hushDatabaseDataSet;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // AddNewAccForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hush.Properties.Resources.ws_Minimal_Gray_to_White_Gradient_1920x1200;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(409, 331);
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
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddNewAccForm";
            this.Text = "AddNewAccForm";
            this.Load += new System.EventHandler(this.AddNewAccForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hushDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
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
        private HushDatabaseDataSet hushDatabaseDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private HushDatabaseDataSetTableAdapters.TableTableAdapter tableTableAdapter;
    }
}