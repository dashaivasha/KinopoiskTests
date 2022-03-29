using KinoPoiskAutomatedTests.TestData;
using KinoPoiskAutomatedTests.WebDriver;
using NUnit.Framework;

namespace KinoPoiskAutomatedTests.BaseClass
{
    public class BaseTest 
    {
        public TestDetails Data = JsonManager.GetTestData();

        [SetUp]
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
