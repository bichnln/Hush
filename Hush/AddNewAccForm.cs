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
        const int PNUMBER_TBOX_MAXLENGTH = 14;
        private string _username, _password, _service, _email, _phonenumber;
        public AddNewAccForm()
        {
            InitializeComponent();
            ServiceTBox.MaxLength = TBOX_MAXLENGTH;
            UsrnameTBox.MaxLength = TBOX_MAXLENGTH;
            EmailTBox.MaxLength = TBOX_MAXLENGTH;
            PNumberTBox.MaxLength = PNUMBER_TBOX_MAXLENGTH;
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
            _username = UsrnameTBox.Text;
            _password = PasswrdTBox.Text;
            _service = ServiceTBox.Text;
            _email = EmailTBox.Text;
            _phonenumber = PNumberTBox.Text;

            DialogResult = DialogResult.None;

            //check if information entered valid
                        
            msg += Validation.EmptyCheck(_username, "Username");
            msg += Validation.EmptyCheck(_password, "Password");
            msg += Validation.EmptyCheck(_service, "Service");
            msg += Validation.EmailCheck(_email);
            msg += Validation.PhoneNumberCheck(_phonenumber);
         
            if (msg != "")
            {
                MessageBox.Show(msg);
                HighlightTB(UsrnameTBox, UsrnameWarning);
                HighlightTB(PasswrdTBox, PasswordToggle);
                HighlightTB(ServiceTBox, ServiceWarning);
                HighlightTB(EmailTBox, EmailWarning);
                HighlightTB(PNumberTBox, PNumberWarning);
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

        //LABEL Clicked
        private void UsernameLabel_Click(object sender, EventArgs e)
        {
            UsrnameTBox.Focus();
        }
        private void PasswrdLabel_Click(object sender, EventArgs e)
        {
            PasswrdTBox.Focus();
        }
        private void ServiceLabel_Click(object sender, EventArgs e)
        {
            ServiceTBox.Focus();
        }
        private void EmailLabel_Click(object sender, EventArgs e)
        {
            EmailTBox.Focus();
        }
        private void PNumberLabel_Click(object sender, EventArgs e)
        {
            PNumberTBox.Focus();
        }

        //TEXTBOX Entered
        private void UsrnameTBox_Enter(object sender, EventArgs e)
        {
            UsrnameWarning.Text = "Username cannot exceed 50 characters";
            TextBoxOnFocus(UsrnameTBox, UsrnameWarning);
        }

        private void PasswrdTBox_Enter(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(PasswrdTBox.Text))
            {
                this.PasswordToggle.Text = "";
            }
            TextBoxOnFocus(PasswrdTBox, PasswordToggle);
        }

        private void ServiceTBox_Enter(object sender, EventArgs e)
        {
            ServiceWarning.Text = "Service name cannot exceed 50 characters";
            TextBoxOnFocus(ServiceTBox, ServiceWarning);
        }

        private void EmailTBox_Enter(object sender, EventArgs e)
        {
            EmailWarning.Text = "Email cannot exceed 50 characters";
            TextBoxOnFocus(EmailTBox, EmailWarning);
        }

        private void PNumberTBox_Enter(object sender, EventArgs e)
        {
            PNumberWarning.Text = "Enter Phone Number in this format: +00 0000000000";
            TextBoxOnFocus(PNumberTBox, PNumberWarning);
        }

        //TEXTBOX Leave

        private void UsrnameTBox_Leave(object sender, EventArgs e)
        {
            ControlLeaveTextBox(UsrnameTBox, UsrnameWarning);
        }

        private void PasswrdTBox_Leave(object sender, EventArgs e)
        {
            ControlLeaveTextBox(PasswrdTBox, PasswordToggle);
            PasswrdTBox.UseSystemPasswordChar = true;
            PasswordToggle.Text = "Reveal Password";
        }

        private void ServiceTBox_Leave(object sender, EventArgs e)
        {
            ControlLeaveTextBox(ServiceTBox, ServiceWarning);
        }

        private void EmailTBox_Leave(object sender, EventArgs e)
        {
            ControlLeaveTextBox(EmailTBox, EmailWarning);
        }

        private void PNumberTBox_Leave(object sender, EventArgs e)
        {
            ControlLeaveTextBox(PNumberTBox, PNumberWarning);
        }

        //TEXTBOX Text Changed
        private void UsrnameTBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void PasswrdTBox_TextChanged(object sender, EventArgs e)
        {
            PasswrdTBox.UseSystemPasswordChar = true;
            PasswordToggle.Text = "Reveal Password";
        }
        private void ServiceTBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void EmailTBox_TextChanged(object sender, EventArgs e)
        {
            if (!Validation.IsValidEmail(EmailTBox.Text))
            {
                EmailWarning.Text = "Email is invalid!";
                EmailWarning.ForeColor = Color.Red;
            }
            else
            {
                EmailWarning.Text = "Email must not exceed 50 characters";
                EmailWarning.ForeColor = Color.Blue;
            }
        }
        private void PNumberTBox_TextChanged(object sender, EventArgs e)
        {
            if (!Validation.IsValidPhoneNumber(PNumberTBox.Text))
            {
                PNumberWarning.Text = "Wrong format!";
                PNumberWarning.ForeColor = Color.Red;
                PNumberWarning.Visible = true;
            }
            else
            {
                PNumberWarning.Visible = false;
            }
        }

        //WARNING TEXT Clicked Events
        private void UsrnameWarning_Click(object sender, EventArgs e)
        {

        }

        private void PasswordToggle_Click(object sender, EventArgs e)
        {
            if ((PasswrdTBox.UseSystemPasswordChar == true))
            {
                PasswrdTBox.UseSystemPasswordChar = false;
                PasswordToggle.Text = "HIDE Password";
            }
            else
            {
                PasswrdTBox.UseSystemPasswordChar = true;
                PasswordToggle.Text = "Reveal Password";
            }
        }

        private void ServiceWarning_Click(object sender, EventArgs e)
        {

        }

        private void EmailWarning_Click(object sender, EventArgs e)
        {

        }

        private void PNumberWarning_Click(object sender, EventArgs e)
        {

        }

        private void AddNewAccForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hushDatabaseDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.hushDatabaseDataSet.Table);

        }

        //Change TextBox and Labels appearances
                
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
        private void HighlightTB(TextBox tb, Label label)
        {
            label.ForeColor = Color.Red;
            label.Text = "*";
            label.Visible = true;
            tb.BackColor = Color.Yellow;
        }
    }
}
