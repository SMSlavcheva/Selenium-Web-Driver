using BasicSelenium.Steps.Actions;
using BasicSelenium.Steps.Hooks;
using BasicSelenium.UIComponents;
using NUnit.Framework;

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
            _user.TypesInto(LoginForm.EMIAL_FIELD, "some");
        }
    }
}
