using KinoPoiskAutomatedTests.TestData;
using KinoPoiskAutomatedTests.WebDriver;
using OpenQA.Selenium;

namespace KinoPoiskAutomatedTests.PageObjects
{
    public class BasePage
    {
        internal IWebDriver driver = DriverFactory.Driver;
        internal TestDetails Data = JsonManager.GetTestData();
    }
}
