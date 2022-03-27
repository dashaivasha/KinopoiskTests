using System;
using KinoPoiskAutomatedTests.PageObjects;
using KinoPoiskAutomatedTests.TestCases;
using KinoPoiskAutomatedTests.TestData;
using KinoPoiskAutomatedTests.WebDriver;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace KinoPoiskAutomatedTests.BaseClass
{
    public class BaseTest 
    {
        public TestDetails Data = JsonManager.GetTestData();
        public IWebDriver driver;

        [SetUp]
        public void Open()
        {
            driver = Singleton.GetInstance().CreateDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(Data.HomePageUrl);
        }

        [OneTimeTearDown]
        public void Close()
        {
            driver.Quit();
        }
    }
}
