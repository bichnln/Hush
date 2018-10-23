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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SAPPHIRE\DP1\Hush\Hush\Hush\HushDatabase.mdf;Integrated Security=True");
            SqlDataAdapter adt = new SqlDataAdapter("SELECT COUNT(*) FROM [PASSWORD] WHERE Password = '" + PassTextBox.Text + "'", con);
            DataTable data = new DataTable();
            adt.Fill(data);
            if (data.Rows[0][0].ToString() == "0")
            {
                DialogResult = DialogResult.None;
                WrongPasswordForm wrongPasswordForm = new WrongPasswordForm();
                wrongPasswordForm.Show();
            }
            else
            {
                DialogResult = DialogResult.OK;
                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();
            }
        }

        private void PassTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
