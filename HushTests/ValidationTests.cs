using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hush;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hush.Tests
{
    [TestClass()]
    public class AddNewAccFormTests
    {
        [TestMethod()]
        public void EmptyCheckTest()
        {
            string Text;
            Text = "";
            Assert.AreEqual(Validation.EmptyCheck(Text, "Text"), "Text is empty!\n");
        }

        [TestMethod()]
        public void NullCheckTest()
        {
            string a;
            a = null;
            Assert.AreEqual(Validation.EmptyCheck(a, "a"), "a is empty!\n");
        }

        [TestMethod()]
        public void ValidEmailCheck()
        {
            string email = "blank_space@gmail.com";
            Assert.IsTrue(Validation.IsValidEmail(email));

            email = "bland@gmail.edu.au";
            Assert.IsTrue(Validation.IsValidEmail(email));

            email = "101668056@student.swin.edu.au";
            Assert.IsTrue(Validation.IsValidEmail(email));

            email = "bich.nln@hotmail.intra.com";
            Assert.IsTrue(Validation.IsValidEmail(email));

            email = "_ilu@telerik.kio";
            Assert.IsTrue(Validation.IsValidEmail(email));
        }
        [TestMethod()]
        public void InvalidEmailCheck()
        {
            string email = "bland@gmail";
            Assert.IsFalse(Validation.IsValidEmail(email));

            email = "_.koa.com";
            Assert.IsFalse(Validation.IsValidEmail(email));

            email = "blank space@gmail.com";
            Assert.IsFalse(Validation.IsValidEmail(email));

            email = "blank space";
            Assert.IsFalse(Validation.IsValidEmail(email));
        }
        [TestMethod()]
        public void ValidPhoneNumberCheck()
        {
            string number = "+61 0123698745";
            Assert.IsTrue(Validation.IsValidPhoneNumber(number));

            number = "+61 512387598";
            Assert.IsTrue(Validation.IsValidPhoneNumber(number));

            number = "0405625385";
            Assert.IsTrue(Validation.IsValidPhoneNumber(number));
        }

        [TestMethod()]
        public void InvalidPhoneNumberCheck()
        {
            string number = "abc"; //contains letters
            Assert.IsFalse(Validation.IsValidPhoneNumber(number));

            number = "0405 385 625"; //contains whitespaces
            Assert.IsFalse(Validation.IsValidPhoneNumber(number));

            number = "+61 15423698745"; //exceed number length and wrong format
            Assert.IsFalse(Validation.IsValidPhoneNumber(number));

            number = "+65185385642"; //wrong format
            Assert.IsFalse(Validation.IsValidPhoneNumber(number));

            number = "+65 1058385145"; //wrong format
            Assert.IsFalse(Validation.IsValidPhoneNumber(number));
        }
    }

}