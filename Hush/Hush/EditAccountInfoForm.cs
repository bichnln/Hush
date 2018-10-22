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
    public partial class EditAccountInfoForm : Form
    {
        private string _newPass, _newPhoneNo;

        public string NewPass
        {
            get { return _newPass; }
        }

        public string NewPhoneNo
        {
            get { return _newPhoneNo; }
        }

        public EditAccountInfoForm()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            _newPass = PasswrdTBox.Text;
            _newPhoneNo = PNumberTBox.Text;

            DialogResult = DialogResult.None;

            if (_newPass == "")
            {
                MessageBox.Show("Please enter new password!\n");
            }
            else
            {
                MessageBox.Show("Account was successfully updated.\n");
                DialogResult = DialogResult.OK;
            }
        }

        private void PNumberTBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswrdTBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
