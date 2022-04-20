using KinoPoiskAutomatedTests.PageObjects;
using KinoPoiskAutomatedTests.TestData;
using KinoPoiskAutomatedTests.WebDriver;
using NUnit.Framework;
using OpenQA.Selenium;

namespace KinoPoiskAutomatedTests.BaseClass
{
    public class BaseTest 
    {
        public TestDetails Data = JsonManager.GetTestData();
        public IWebDriver WebDriver => DriverFactory.Driver;
        internal HomePage homePage = new HomePage();
        internal LoginPage loginPage = new LoginPage();
        internal PasswordPage passwordPage = new PasswordPage();
        internal FilmPage filmPage = new FilmPage();
        internal MyKinopoiskPage myKinopoisk = new MyKinopoiskPage();

        [OneTimeSetUp]
        public void Open()
        {
            DriverFactory.InitalizerDriver();
            WebDriver.Manage().Window.Maximize();
            WebDriver.Navigate().GoToUrl(Data.HomePageUrl);
        }

        [SetUp]
        public void Authorization()
        {
            homePage.PressLogInButton();
            loginPage.EnterLoginAndSubmit(Data.Login);
            passwordPage.EnterPasswordAndSubmit(Data.Password);
        } 

        [OneTimeTearDown]
        public void Close()
        {
            WebDriver.Quit();
        }
    }
}
