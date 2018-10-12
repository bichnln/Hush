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
    public partial class AddNewAccForm : Form
    {
        public AddNewAccForm()
        {
            InitializeComponent();
        }
        private string _username, _password, _service, _email, _phonenumber;
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public string Service
        {
            get { return _service; }
            set { _service = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string PhoneNumber
        {
            get { return _phonenumber; }
            set { _phonenumber = value; }
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string msg = "";
            _username = UsrnameTBox.Text;
            _password = PasswrdTBox.Text;
            _service = ServiceTBox.Text;
            _email = EmailTBox.Text;
            _phonenumber = PNumberTBox.Text;

            DialogResult = DialogResult.None;

            //check if information entered valid
            if (_username.Length == 0)
            {
                msg += "Please enter Username!\n"; 
                
            }
            if (_password.Length == 0)
            {
                msg += "Please enter Password!\n";
            }
            if (_service.Length == 0)
            {
                msg += "Please enter Service! \n";
            }
            if (IsValidEmail(_email) == false)
            {
                msg += "Email entered is not valid\n";
            }

            if (msg != "")
            {
                MessageBox.Show(msg);
            }
            else
            {
                MessageBox.Show("Account Information added!");
                DialogResult = DialogResult.OK;
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
           
        }

        private void PasswrdLabel_Click(object sender, EventArgs e)
        {

        }

        private void UsrnameTBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailLabel_Click(object sender, EventArgs e)
        {

        }

        private void PNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void UsernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void ServiceLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddNewAccForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hushDatabaseDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.hushDatabaseDataSet.Table);

        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
