using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicSelenium.UIComponents
{
    static class UserHomepageForm
    {

        public static readonly By CONTAINER = By.XPath("//div[@class='container']//h1");
        public static readonly By EMAIL_LINK = By.XPath("//li[@class='dropdown']/a");
            //("//*[@id=\"navbar\"]/ul[2]/li/a");

        public static readonly By HELLO_USER_TEXT= By.XPath("//div[@class='jumbotron']/h1");

       

    }
}
