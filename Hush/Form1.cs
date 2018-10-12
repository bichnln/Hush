﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hush
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hushDatabaseDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.hushDatabaseDataSet.Table);



        }

        private void ShowAllBtn_Click(object sender, EventArgs e)
        {

        }

        private void ChangePINBtn_Click(object sender, EventArgs e)
        {
            ChangePINForm f = new ChangePINForm();
            f.Show();
        }

        private void AddNewBtn_Click(object sender, EventArgs e)
        {
            AddNewAccForm f = new AddNewAccForm();
            f.ShowDialog();

            if (f.DialogResult == DialogResult.OK)
            {
                //create a new connection to database
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SAPPHIRE\DP1\Hush\Hush\Hush\HushDatabase.mdf;Integrated Security=True");

                //calculate the ID for the record to be saved
                int nextID = tableBindingSource.Count + 1;

                //INSERT SQL Command, used to insert data to database
                SqlCommand cmd = new SqlCommand("INSERT INTO [Table] VALUES ('" + nextID + "','" + f.Username + "','" + f.Password + "','" + f.Service + "','" + f.Email + "','" + f.PhoneNumber + "')");

                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                //update the table displayed in dataGridView
                SqlDataAdapter adapter = new SqlDataAdapter(@"SELECT * FROM [Table]", con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }

            
        }

        private void LockAppBtn_Click(object sender, EventArgs e)
        {

        }

        private void testEditForm_Click(object sender, EventArgs e)
        {
            EditAccountInfoForm f = new EditAccountInfoForm();
            f.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void hushDatabaseDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
