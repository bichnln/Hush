using System;
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
            this.dataGridView1.Columns[2].DefaultCellStyle.ForeColor = Color.White;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hushDatabaseDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.hushDatabaseDataSet.Table);
            this.dataGridView1.Columns[2].DefaultCellStyle.ForeColor = Color.White;
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

                //calculate the ID for the new record
                int nextID;
                SqlCommand MaxIDCommand = new SqlCommand("SELECT MAX(Id) FROM [Table]", con);
                con.Open();
                nextID = Convert.ToInt16(MaxIDCommand.ExecuteScalar()) + 1;
                con.Close();

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
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void testEditForm_Click(object sender, EventArgs e)
        {
            Prompt promptingForm = new Prompt();
            promptingForm.ShowDialog();

            if (promptingForm.DialogResult == DialogResult.OK)
            {
                EditAccountInfoForm editingForm = new EditAccountInfoForm();
                editingForm.ShowDialog();

                if (editingForm.DialogResult == DialogResult.OK)
                {
                    //create a new connection to database
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SAPPHIRE\DP1\Hush\Hush\Hush\HushDatabase.mdf;Integrated Security=True");

                    //INSERT SQL Command, used to insert data to database
                    SqlCommand cmd;
                    if (editingForm.NewPhoneNo == "")
                    {
                        cmd = new SqlCommand("UPDATE [TABLE] SET Password = '" + editingForm.NewPass + "' WHERE Id = '" + promptingForm.ID + "'");
                    }
                    else
                    {
                        cmd = new SqlCommand("UPDATE [TABLE] SET Password = '" + editingForm.NewPass + "', PhoneNumber = '" + editingForm.NewPhoneNo + "' WHERE Id = '" + promptingForm.ID + "'");
                    }

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
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void hushDatabaseDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void deletebutton1_Click(object sender, EventArgs e)
        {
            //check for comfirmation
            if(MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SAPPHIRE\DP1\Hush\Hush\Hush\HushDatabase.mdf;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                if ((dataGridView1.Rows.Count > 1) && (dataGridView1.SelectedRows[0].Index != dataGridView1.Rows.Count - 1))
                {
                    //The row of where the user clicks will be deleted from the database.
                    cmd.CommandText = ("DELETE FROM [Table] WHERE Id = " + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "");
                    cmd.ExecuteNonQuery();
                    con.Close();
                    //The row of where the user clicks will be deleted from datagridview.
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                    MessageBox.Show("Deleted successfully.");
                }
            }
            else
            {
                MessageBox.Show("Deletion has been cancelled.", "Deletion Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchTBox_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SAPPHIRE\DP1\Hush\Hush\Hush\HushDatabase.mdf;Integrated Security=True");
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(@"SELECT * FROM [Table] where Username like '" + searchTBox.Text + "%'", con);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void SearchUserLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
