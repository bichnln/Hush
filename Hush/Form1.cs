using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            // TODO: This line of code loads data into the 'hushDBDataSet.Account' table. You can move, or remove it, as needed.
            this.accountTableAdapter.Fill(this.hushDBDataSet.Account);

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
            f.Show();
        }

        private void LockAppBtn_Click(object sender, EventArgs e)
        {

        }

        private void testEditForm_Click(object sender, EventArgs e)
        {
            EditAccountInfoForm f = new EditAccountInfoForm();
            f.Show();
        }
    }
}
