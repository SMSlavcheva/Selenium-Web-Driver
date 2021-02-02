using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicSelenium.UIComponents
{
    class RegistrationForm
    {
        public static readonly By FIRST_NAME_FIELD = By.Name("first_name");

        public static readonly By SIR_NAME_FIELD = By.Name("sir_name");

        public static readonly By EMAIL_FIELD = By.Name("email");

        public static readonly By PASSWORD_FIELD = By.Name("pass");

        public static readonly By COUNTRY_FIELD = By.Name("country");

        public static readonly By CITY_FIELD = By.Name("city");

        public static readonly By CHECKBOX = By.CssSelector("#TOS");

        public static readonly By REGISTER_BUTTON = By.Id("reg");




    }
}
