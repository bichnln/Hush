namespace Hush
{
    partial class Form1
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
            this.ShowAllBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hushDBDataSet = new Hush.HushDBDataSet();
            this.accountTableAdapter = new Hush.HushDBDataSetTableAdapters.AccountTableAdapter();
            this.AddNewBtn = new System.Windows.Forms.Button();
            this.ChangePINBtn = new System.Windows.Forms.Button();
            this.LockAppBtn = new System.Windows.Forms.Button();
            this.testEditForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hushDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowAllBtn
            // 
            this.ShowAllBtn.Location = new System.Drawing.Point(2, 48);
            this.ShowAllBtn.Name = "ShowAllBtn";
            this.ShowAllBtn.Size = new System.Drawing.Size(172, 81);
            this.ShowAllBtn.TabIndex = 0;
            this.ShowAllBtn.Text = "Show All Accounts";
            this.ShowAllBtn.UseVisualStyleBackColor = true;
            this.ShowAllBtn.Click += new System.EventHandler(this.ShowAllBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.serviceDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.accountBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(180, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(549, 310);
            this.dataGridView1.TabIndex = 1;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // serviceDataGridViewTextBoxColumn
            // 
            this.serviceDataGridViewTextBoxColumn.DataPropertyName = "Service";
            this.serviceDataGridViewTextBoxColumn.HeaderText = "Service";
            this.serviceDataGridViewTextBoxColumn.Name = "serviceDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataMember = "Account";
            this.accountBindingSource.DataSource = this.hushDBDataSet;
            // 
            // hushDBDataSet
            // 
            this.hushDBDataSet.DataSetName = "HushDBDataSet";
            this.hushDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountTableAdapter
            // 
            this.accountTableAdapter.ClearBeforeFill = true;
            // 
            // AddNewBtn
            // 
            this.AddNewBtn.Location = new System.Drawing.Point(2, 124);
            this.AddNewBtn.Name = "AddNewBtn";
            this.AddNewBtn.Size = new System.Drawing.Size(172, 81);
            this.AddNewBtn.TabIndex = 2;
            this.AddNewBtn.Text = "Add new account";
            this.AddNewBtn.UseVisualStyleBackColor = true;
            this.AddNewBtn.Click += new System.EventHandler(this.AddNewBtn_Click);
            // 
            // ChangePINBtn
            // 
            this.ChangePINBtn.Location = new System.Drawing.Point(2, 201);
            this.ChangePINBtn.Name = "ChangePINBtn";
            this.ChangePINBtn.Size = new System.Drawing.Size(172, 81);
            this.ChangePINBtn.TabIndex = 3;
            this.ChangePINBtn.Text = "Change PIN Code";
            this.ChangePINBtn.UseVisualStyleBackColor = true;
            this.ChangePINBtn.Click += new System.EventHandler(this.ChangePINBtn_Click);
            // 
            // LockAppBtn
            // 
            this.LockAppBtn.Location = new System.Drawing.Point(2, 277);
            this.LockAppBtn.Name = "LockAppBtn";
            this.LockAppBtn.Size = new System.Drawing.Size(172, 81);
            this.LockAppBtn.TabIndex = 4;
            this.LockAppBtn.Text = "Lock App";
            this.LockAppBtn.UseVisualStyleBackColor = true;
            this.LockAppBtn.Click += new System.EventHandler(this.LockAppBtn_Click);
            // 
            // testEditForm
            // 
            this.testEditForm.Location = new System.Drawing.Point(189, 379);
            this.testEditForm.Name = "testEditForm";
            this.testEditForm.Size = new System.Drawing.Size(172, 50);
            this.testEditForm.TabIndex = 5;
            this.testEditForm.Text = "test Edit Form";
            this.testEditForm.UseVisualStyleBackColor = true;
            this.testEditForm.Click += new System.EventHandler(this.testEditForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.testEditForm);
            this.Controls.Add(this.LockAppBtn);
            this.Controls.Add(this.ChangePINBtn);
            this.Controls.Add(this.AddNewBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ShowAllBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hushDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ShowAllBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private HushDBDataSet hushDBDataSet;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private HushDBDataSetTableAdapters.AccountTableAdapter accountTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button AddNewBtn;
        private System.Windows.Forms.Button ChangePINBtn;
        private System.Windows.Forms.Button LockAppBtn;
        private System.Windows.Forms.Button testEditForm;
    }
}

