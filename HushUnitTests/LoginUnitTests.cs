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
    public class LoginUnitTests : NUnitFormTest
    {
        private Login _loginForm;

        public override void Setup()
        {
            base.Setup();
            _loginForm = new Login();
            _loginForm.Show();
        }

        [Test]
        public void TestLoginButton()
        {
            ButtonTester loginBtn = new ButtonTester("LoginButton");
            Assert.IsNotNull(loginBtn.Text);
            Assert.AreEqual("Login", loginBtn.Text);
        }

        [Test]
        public void TestQuitButton()
        {
            ButtonTester quitBtn = new ButtonTester("QuitButton");
            Assert.IsNotNull(quitBtn.Text);
            Assert.AreEqual("Quit", quitBtn.Text);
        }

        [Test]
        public void TestPassLabel()
        {
            LabelTester passwordLabel = new LabelTester("PassLabel");
            Assert.IsNotNull(passwordLabel.Text);
            Assert.AreEqual("Please enter password to continue", passwordLabel.Text);
        }

        [Test]
        public void TestPassIsCorrect()
        {
            ButtonTester loginBtn = new ButtonTester("LoginButton");
            TextBoxTester passTextBox = new TextBoxTester("PassTextBox");
            passTextBox.Enter("12");
            loginBtn.Click();
            Assert.AreEqual(DialogResult.OK, _loginForm.DialogResult);
        }

        [Test]
        public void TestPassIsNotCorrect()
        {
            ButtonTester loginBtn = new ButtonTester("LoginButton");
            TextBoxTester passTextBox = new TextBoxTester("PassTextBox"); 
            passTextBox.Enter("1234");
            loginBtn.Click();
            Assert.AreEqual(DialogResult.None, _loginForm.DialogResult);
        }
    }
}
