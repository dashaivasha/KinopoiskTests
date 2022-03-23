using System;
using KinoPoiskAutomatedTests.BaseClass;
using KinoPoiskAutomatedTests.PageObjects;
using KinoPoiskAutomatedTests.TestData;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace KinoPoiskAutomatedTests.TestCases
{
    [TestFixture]
    public class LoginTest : BaseTest
    { 
        [Test]
        public void Test()
        {
            var homePage = new HomePage();
            PageFactory.InitElements(driver, homePage);
            homePage.MyAccount.Click();
            var loginPage = new LoginPage();
            PageFactory.InitElements(driver, loginPage);

            if (loginPage.IsEmailChooseExist())
            {
                loginPage.EmailChoose.Click();
            }

            loginPage.UserID.SendKeys(JsonManager.GetLogin());
            loginPage.Submit.Click();
            var passwordPage = new PasswordPage();
            PageFactory.InitElements(driver, passwordPage);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(driver => passwordPage.Password.Displayed);
            passwordPage.Password.SendKeys(JsonManager.GetPassword());
            passwordPage.SignIn.Submit();

            Assert.True(homePage.IsLoggedIn(), "User is already registered");
        }
    }
}

