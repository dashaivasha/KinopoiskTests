using System;
using KinoPoiskAutomatedTests.TestData;
using KinoPoiskAutomatedTests.WebDriver;
using OpenQA.Selenium;

namespace KinoPoiskAutomatedTests.PageObjects
{
    public class DefaultPage
    {
        internal IWebDriver driver = DriverFactory.GetDriver();
        internal TestDetails Data = JsonManager.GetTestData();
    }
}
