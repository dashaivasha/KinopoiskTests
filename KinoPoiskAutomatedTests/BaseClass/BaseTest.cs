using System;
using KinoPoiskAutomatedTests.PageObjects;
using KinoPoiskAutomatedTests.TestCases;
using KinoPoiskAutomatedTests.TestData;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace KinoPoiskAutomatedTests.BaseClass
{
    public class BaseTest
    {
        public IWebDriver driver;

        [OneTimeSetUp]
        public void Open()
        {
            driver = new ChromeDriver("/Users/dasha_ivasha/Downloads/");
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://hd.kinopoisk.ru/");
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
            passwordPage.SignIn.Click();
            PageFactory.InitElements(driver, homePage);
        }

        [OneTimeTearDown]
        public void Close()
        {
            driver.Quit();
        }
    }
}
