using KinoPoiskAutomatedTests.PageObjects;
using KinoPoiskAutomatedTests.TestData;
using KinoPoiskAutomatedTests.Tests;
using KinoPoiskAutomatedTests.WebDriver;
using NUnit.Framework;

namespace KinoPoiskAutomatedTests.BaseClass
{
    public class BaseTest 
    {
        public TestDetails Data = JsonManager.GetTestData();
        internal HomePage homePage = new HomePage();
        internal LoginPage loginPage = new LoginPage();
        internal PasswordPage passwordPage = new PasswordPage();
        internal FilmPage filmPage = new FilmPage();
        internal MyKinopoiskPage myKinopoisk = new MyKinopoiskPage();

        [SetUp]
        public void Authorization()
        {
            homePage.PressLogInButton();
            loginPage.EnterLoginAndSubmit(Data.Login);
            passwordPage.EnterPasswordAndEnter(Data.Password);
        }

        [OneTimeSetUp]
        public void Open()
        {
            var driver = DriverFactory.GetDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(Data.HomePageUrl);
        }

        [OneTimeTearDown]
        public void Close()
        {
            var driver = DriverFactory.GetDriver();
            driver.Quit();
        }
    }
}
