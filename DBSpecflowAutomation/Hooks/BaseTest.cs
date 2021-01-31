using BasicSelenium.Steps.Actions;
using BasicSelenium.Utils;
using NUnit.Framework;
using OpenQA.Selenium;

namespace BasicSelenium.Steps.Hooks
{
    [SetUpFixture]
    class BaseTest
    {
        protected BaseUserActions _user;

        [SetUp]
        public void InitScenario()
        {
            WebDriverProvider.InitDriver();
        }

        [TearDown]
        public void TearDownScenario()
        {
            IWebDriver driver = WebDriverProvider.GetPreparedDriver();
            if (driver != null)
            {
               // driver.Quit();
            }
        }
    }
}
