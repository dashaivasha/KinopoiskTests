
using System;
using KinoPoiskAutomatedTests.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;

namespace KinoPoiskAutomatedTests.TestCases
{
    public class LoginTest
    { 
        [Test]
        public void Test()
        {
            IWebDriver driver = new ChromeDriver(@"/Users/dasha_ivasha/Downloads");
            driver.Navigate().GoToUrl("https://hd.kinopoisk.ru/");

            var homePage = new HomePage();
            PageFactory.InitElements(driver, homePage);
            homePage.MyAccount.Click();

            var loginPage = new LoginPage();
            PageFactory.InitElements(driver, loginPage);
            if (loginPage.IsEmailChooseExist())
            {
                loginPage.EmailChoose.Click();
                loginPage.UserID.SendKeys("internshiptestovitch");
                loginPage.Submit.Click();
            }
            else 
            {
                loginPage.UserID.SendKeys("internshiptestovitch");
                loginPage.Submit.Click();
            }
            var passwordPage = new PasswordPage();
            PageFactory.InitElements(driver, passwordPage);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            passwordPage.Password.SendKeys("testpasstest");
            passwordPage.SignIn.Submit();

        }
    }
}

