using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace Hush
{
    public partial class AddNewAccForm : Form
    {
        const int TBOX_MAXLENGTH = 50;
        const int PNUMBER_TBOX_MAXLENGTH = 20;

        private string _username, _password, _service, _email, _phonenumber;
        public AddNewAccForm()
        {
            InitializeComponent();
            this.ServiceTBox.MaxLength = TBOX_MAXLENGTH;
            this.UsrnameTBox.MaxLength = TBOX_MAXLENGTH;
            this.EmailTBox.MaxLength = TBOX_MAXLENGTH;
            this.PNumberTBox.MaxLength = PNUMBER_TBOX_MAXLENGTH;
            
        }
        
        
        public string Username
        {
            get { return _username; }
        }
        public string Password
        {
            get { return _password; }
        }
        public string Service
        {
            get { return _service; }
        }
        public string Email
        {
            get { return _email; }
        }
        public string PhoneNumber
        {
            get { return _phonenumber; }
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string msg = "";
            _username = this.UsrnameTBox.Text;
            _password = PasswrdTBox.Text;
            _service = ServiceTBox.Text;
            _email = EmailTBox.Text;
            _phonenumber = PNumberTBox.Text;

            DialogResult = DialogResult.None;

            //check if information entered valid
            if (String.IsNullOrWhiteSpace(_username))
            {
                msg += "Please enter Username!\n"; 
            }
            if (String.IsNullOrWhiteSpace(_password))
            {
                msg += "Please enter Password!\n";
            }
            if (String.IsNullOrWhiteSpace(_service))
            {
                msg += "Please enter Service!\n";
            }
            if (String.IsNullOrWhiteSpace(_email))
            {
                msg += "Please enter Email!\n";
            }
            if (!IsValidEmail(_email))
            {
                msg += "Email is invalid!\n";
            }
            if ((!String.IsNullOrWhiteSpace(_phonenumber)) && !(IsValidPhoneNumber(_phonenumber)))
            {
                msg += "Phone Number is invalid!\n";
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
        //LABEL Clicked Events
        private void UsernameLabel_Click(object sender, EventArgs e)
        {
            this.UsrnameTBox.Focus();
        }
        private void PasswrdLabel_Click(object sender, EventArgs e)
        {
            this.PasswrdTBox.Focus();
        }
        private void ServiceLabel_Click(object sender, EventArgs e)
        {
            this.ServiceTBox.Focus();
        }
        private void EmailLabel_Click(object sender, EventArgs e)
        {
            this.EmailTBox.Focus();
        }
        private void PNumberLabel_Click(object sender, EventArgs e)
        {
            this.PNumberLabel.Focus();      
        }

        //TEXTBOX Entered Events
        private void UsrnameTBox_Enter(object sender, EventArgs e)
        {
            this.UsernameWarningText.Text = "Username cannot exceed 50 characters";
            TextBoxOnFocus(UsrnameTBox, UsernameWarningText);
        }

        private void PasswrdTBox_Enter(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(PasswrdTBox.Text))
            {
                this.ClickToSeePassword.Text = "";
            }
            TextBoxOnFocus(PasswrdTBox, ClickToSeePassword);
        }

        private void ServiceTBox_Enter(object sender, EventArgs e)
        {
            this.ServiceWarningText.Text = "Service name cannot exceed 50 characters";
            TextBoxOnFocus(ServiceTBox, ServiceWarningText);
        }

        private void EmailTBox_Enter(object sender, EventArgs e)
        {
            this.EmailWarningText.Text = "Email cannot exceed 50 characters";
            TextBoxOnFocus(EmailTBox, EmailWarningText);
        }
        private void PNumberTBox_Enter(object sender, EventArgs e)
        {
            this.PNumberWarningText.Text = "Phone number must be entered in right format: +xx yyyyyyyyyy";
            TextBoxOnFocus(PNumberTBox, PNumberWarningText);
        }

        //TEXTBOX Leave Events
        private void UsrnameTBox_Leave(object sender, EventArgs e)
        {
            ControlLeaveTextBox(UsrnameTBox, UsernameWarningText);
        }
        private void PasswrdTBox_Leave(object sender, EventArgs e)
        {
            ControlLeaveTextBox(PasswrdTBox, ClickToSeePassword);
        }
        private void ServiceTBox_Leave(object sender, EventArgs e)
        {
            ControlLeaveTextBox(ServiceTBox, ServiceWarningText);
        }
        private void EmailTBox_Leave(object sender, EventArgs e)
        {
            ControlLeaveTextBox(EmailTBox, EmailWarningText);
        }
        private void PNumberTBox_Leave(object sender, EventArgs e)
        {
            ControlLeaveTextBox(PNumberTBox, PNumberWarningText);
        }

        //TEXTBOX TextChanged Events
        private void UsrnameTBox_TextChanged(object sender, EventArgs e)
        {
                      
        }
        private void PasswrdTBox_TextChanged(object sender, EventArgs e)
        {
            this.PasswrdTBox.UseSystemPasswordChar = true;
            this.ClickToSeePassword.Text = "Reveal Password";
        }
        private void ServiceTBox_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void EmailTBox_TextChanged(object sender, EventArgs e)
        {
            if (!IsValidEmail(EmailTBox.Text))
            {
                EmailWarningText.Text = "Email is invalid!";
                EmailWarningText.ForeColor = Color.Red;
            }
            else
            {
                EmailWarningText.Text = "Email must not exceed 50 characters";
                EmailWarningText.ForeColor = Color.Blue;
            }
        }                   
        private void PNumberTBox_TextChanged(object sender, EventArgs e)
        {
            if (!IsValidPhoneNumber(PNumberTBox.Text))
            {
                this.PNumberWarningText.Text = "Wrong format!";
                this.PNumberWarningText.ForeColor = Color.Red;
                this.PNumberWarningText.Visible = true;
            }
            else
            {
                this.PNumberWarningText.Visible = false;
            }
        }
        //Warning Text Clicked Events
        private void UsernameWarningText_Click(object sender, EventArgs e)
        {

        }                           
        private void ClickToSeePassword_Click(object sender, EventArgs e)
        {
            if ((this.PasswrdTBox.UseSystemPasswordChar == true))
            {
                this.PasswrdTBox.UseSystemPasswordChar = false;
                this.ClickToSeePassword.Text = "HIDE Password";
            }
            else
            {
                this.PasswrdTBox.UseSystemPasswordChar = true;
                this.ClickToSeePassword.Text = "Reveal Password";
            }
        }

        
        private void UsrnameTBox_MouseClick(object sender, MouseEventArgs e)
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
        private bool IsValidPhoneNumber(string number)
        {
            Regex phoneNumberPattern = new Regex(@"[\+]{1}[0-9]{2}[\ ]{1}[0-9]{10}$");
            if (phoneNumberPattern.IsMatch(number))
            {
                return true;
            }
            else return false;
        }
        private void TextBoxOnFocus(TextBox tb, Label label)
        {
            tb.Focus();
            tb.BackColor = Color.LightGray;
            tb.ForeColor = Color.Blue;

            label.ForeColor = Color.Green;
            label.Visible = true;

        }
        private void ControlLeaveTextBox(TextBox tb, Label label)
        {
            tb.BackColor = Color.White;
            label.Visible = false;
        }
     
    }
}
