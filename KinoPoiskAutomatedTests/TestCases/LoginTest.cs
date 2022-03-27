using KinoPoiskAutomatedTests.BaseClass;
using KinoPoiskAutomatedTests.PageObjects;
using NUnit.Framework;

namespace KinoPoiskAutomatedTests.TestCases
{
    [TestFixture]
    public class LoginTest : BaseTest
    {
        HomePage homePage = new HomePage();
        LoginPage loginPage = new LoginPage();
        PasswordPage passwordPage = new PasswordPage();

        [Test]
        public void Login()
        {
            homePage.PressLogInButton(driver);
            loginPage.EnterLoginAndSubmit(driver, Data.Login);
            passwordPage.EnterPasswordAndEnter(driver, Data.Password);
            Assert.True(homePage.IsExitExist(driver));
        }


    }
}
