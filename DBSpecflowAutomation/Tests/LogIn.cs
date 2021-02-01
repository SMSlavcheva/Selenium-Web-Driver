using BasicSelenium.Steps.Actions;
using BasicSelenium.Steps.Hooks;
using BasicSelenium.UIComponents;
using NUnit.Framework;
using System;
using System.Linq;

namespace BasicSelenium.Tests
{
    [TestFixture]
    class LogIn : BaseTest
    {
        [SetUp]
        public void SetUp() => _user = new BaseUserActions();

        [Test]
        public void Test()
        {
            _user.StartsApplication();
            _user.TypesInto(LoginForm.EMIAL_FIELD, "username137@gmail.com");
            _user.TypesInto(LoginForm.PASSWORD_FIELD, TestData.Password);
            _user.ClicksOn(LoginForm.LOGIN_BUTTON);


            var userName = LoginForm.EMIAL_FIELD.ToString()
               + RegistrationForm.SIR_NAME_FIELD.ToString();


            var email ="username137@gmail.com";

            var text = _user.ReadsTextFrom(UserHomepageForm.EMAIL_LINK);

            var emailTextAsList = text.Split(new char[] { ':'}, StringSplitOptions
              .RemoveEmptyEntries).ToList();            

            var emailText = emailTextAsList[1].TrimStart().TrimEnd();

            Assert.AreEqual(email, emailText);


        }
    }
}
