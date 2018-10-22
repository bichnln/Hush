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
    public partial class WrongPasswordForm : Form
    {
        private int _id;

        public int ID
        {
            get { return _id; } 
        }

        public WrongPasswordForm()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void WrongPasswordLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
