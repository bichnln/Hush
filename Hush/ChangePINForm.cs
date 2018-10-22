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
    public partial class ChangePINForm : Form
    {
        public ChangePINForm()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void RetypePassLabel_Click(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if ((PassTextBox.Text == "") || (RetypePassTextBox.Text == ""))
            {
                MessageBox.Show("Please enter new password!\n");
            }
            else
            {
                if (PassTextBox.Text != RetypePassTextBox.Text)
                {
                    MessageBox.Show("Retyped password does not match!\n");
                }
                else
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\TRAN QUANG LINH\Desktop\DP1 - Sem 2 2018\Hush\GitHub\Hush\Hush\HushDatabase.mdf;Integrated Security=True");
                    SqlDataAdapter adt = new SqlDataAdapter("SELECT COUNT(*) FROM [PASSWORD] WHERE Password = '" + OldPassTextBox.Text + "'", con);
                    DataTable data = new DataTable();
                    adt.Fill(data);
                    if (data.Rows[0][0].ToString() == "0")
                    {
                        MessageBox.Show("Wrong password!\n");
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand("UPDATE [PASSWORD] SET Password = '" + PassTextBox.Text + "' WHERE Password = '" + OldPassTextBox.Text + "'");

                        cmd.Connection = con;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Password was successfully changed.\n");
                        this.Hide();
                    }
                }
            }
        }
    }
}
