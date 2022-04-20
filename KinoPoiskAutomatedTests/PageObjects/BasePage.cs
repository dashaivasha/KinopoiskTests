using KinoPoiskAutomatedTests.BaseClass;
using KinoPoiskAutomatedTests.TestData;
using KinoPoiskAutomatedTests.WebDriver;
using OpenQA.Selenium;

namespace KinoPoiskAutomatedTests.PageObjects
{
    public class BasePage 
    {
        protected IWebDriver driver;

        public BasePage()
        {
            DriverFactory.InitalizerDriver();
            driver = DriverFactory.Driver;
        }

        internal TestDetails Data = JsonManager.GetTestData();
    }
}
