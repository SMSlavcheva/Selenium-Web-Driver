using BasicSelenium.Steps.Actions;
using BasicSelenium.Steps.Hooks;
using BasicSelenium.UIComponents;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Linq;

namespace BasicSelenium.Tests
{
    [TestFixture]
    class Register : BaseTest
    {
        public static readonly By NAME = By.XPath("//div[@class='jumbotron']/h1");       
               
        [SetUp]
        public void SetUp() => _user = new BaseUserActions();
        
        [Test]
       
        public void UserRegisterSuccessfullyTest()
        {
            _user.StartsApplication();
            _user.ClicksOn(LoginForm.REGISTER_BUTTON);
            _user.TypesInto(RegistrationForm.FIRST_NAME_FIELD, TestData.FirstName);
            _user.TypesInto(RegistrationForm.SIR_NAME_FIELD, TestData.SirName);
            _user.TypesInto(RegistrationForm.EMAIL_FIELD, TestData.Email);
            _user.TypesInto(RegistrationForm.PASSWORD_FIELD, TestData.Password);
            _user.TypesInto(RegistrationForm.COUNTRY_FIELD, TestData.Country);
            _user.TypesInto(RegistrationForm.CITY_FIELD, TestData.City);
            _user.ClicksOn(RegistrationForm.CHECKBOX);
            _user.ClicksOn(RegistrationForm.REGISTER_BUTTON);

            var userName = RegistrationForm.FIRST_NAME_FIELD.ToString()
                + RegistrationForm.SIR_NAME_FIELD.ToString();


            var fullName = TestData.FirstName +" "+TestData.SirName;

            var text= _user.ReadsTextFrom(UserHomepageForm.HELLO_USER_TEXT);

            var textName = text.Split(new char[] { ',', '.' },StringSplitOptions
                .RemoveEmptyEntries).ToList();

            var name = textName[2].TrimStart().TrimEnd();
                
            Assert.AreEqual(fullName,name);       

        }

    }
 }

