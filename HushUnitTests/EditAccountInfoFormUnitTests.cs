using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hush;
using NUnit.Framework;
using NUnit.Extensions.Forms;

namespace HushUnitTests
{
    class EditAccountInfoFormUnitTests : NUnitFormTest
    {
        private EditAccountInfoForm _editAccountForm;

        public override void Setup()
        {
            base.Setup();
            _editAccountForm = new EditAccountInfoForm();
            _editAccountForm.Show();
        }

        [Test]
        public void TestUsernameLabel()
        {
            LabelTester unameLabel = new LabelTester("UsernameLabel");
            Assert.IsNotNull(unameLabel.Text);
            Assert.AreEqual("Username", unameLabel.Text);
        }

        [Test]
        public void TestPasswrdLabel()
        {
            LabelTester passwordLabel = new LabelTester("PasswrdLabel");
            Assert.IsNotNull(passwordLabel.Text);
            Assert.AreEqual("New Password", passwordLabel.Text);
        }

        [Test]
        public void TestServiceLabel()
        {
            LabelTester serviceLabel = new LabelTester("ServiceLabel");
            Assert.IsNotNull(serviceLabel.Text);
            Assert.AreEqual("Service", serviceLabel.Text);
        }

        [Test]
        public void TestEmailLabel()
        {
            LabelTester emailLabel = new LabelTester("EmailLabel");
            Assert.IsNotNull(emailLabel.Text);
            Assert.AreEqual("Email Registration", emailLabel.Text);
        }

        [Test]
        public void TestPNumberLabel()
        {
            LabelTester phoneNoLabel = new LabelTester("PNumberLabel");
            Assert.IsNotNull(phoneNoLabel.Text);
            Assert.AreEqual("New Phone Number", phoneNoLabel.Text);
        }

        [Test]
        public void TestSaveBtn()
        {
            ButtonTester saveButton = new ButtonTester("SaveBtn");
            Assert.IsNotNull(saveButton.Text);
            Assert.AreEqual("Save", saveButton.Text);
        }

        [Test]
        public void TestCancelBtn()
        {
            ButtonTester cancelButton = new ButtonTester("CancelBtn");
            Assert.IsNotNull(cancelButton.Text);
            Assert.AreEqual("Cancel", cancelButton.Text);
        }

        [Test]
        public void TestClickCancelButton()
        {
            ButtonTester cancelButton = new ButtonTester("CancelBtn");
            cancelButton.Click();
            Assert.AreEqual(DialogResult.Cancel, _editAccountForm.DialogResult);
        }
    }
}
