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
    public partial class Prompt : Form
    {
        private int _id;

        public int ID
        {
            get { return _id; } 
        }

        public Prompt()
        {
            InitializeComponent();
        }

        private void IDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            string input = IDTextBox.Text;

            DialogResult = DialogResult.None;

            if (input == "")
            {
                MessageBox.Show("Please enter the ID!\n");
            }
            else
            {
                if (!Int32.TryParse(input, out _id))
                {
                    MessageBox.Show("Please enter a number!\n");
                }
                else
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\TRAN QUANG LINH\Desktop\DP1 - Sem 2 2018\Hush\Hush-master\Hush-master\Hush\HushDatabase.mdf;Integrated Security=True");
                    SqlDataAdapter adt = new SqlDataAdapter("SELECT COUNT(*) FROM [TABLE] WHERE Id = '" + _id + "'", con);
                    DataTable data = new DataTable();
                    adt.Fill(data);
                    if (data.Rows[0][0].ToString() == "0")
                    {
                        MessageBox.Show("No account has this ID!\n");
                    }
                    else
                    {
                        DialogResult = DialogResult.OK;
                    }
                }
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void IDLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
