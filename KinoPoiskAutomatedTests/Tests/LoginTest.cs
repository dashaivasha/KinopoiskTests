using KinoPoiskAutomatedTests.BaseClass;
using NUnit.Framework;

namespace KinoPoiskAutomatedTests.Tests
{
    [TestFixture]
    public class LoginTest : BaseTest
    {
        [SetUp]
        public void Start()
        {
            homePage.PressLogOutButton();
        }

        [Test]
        public void Login()
        {
            homePage.PressLogInButton();
            passwordPage.EnterPasswordAndEnter(Data.Password);
            Assert.True(homePage.IsExitExist());
        }
    }
}
