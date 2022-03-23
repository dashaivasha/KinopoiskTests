using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace KinoPoiskAutomatedTests.BaseClass
{
    public class BaseTest
    {
        public IWebDriver driver;

        [OneTimeSetUp]
        public void Open()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://hd.kinopoisk.ru/");
        }

        [OneTimeTearDown]
        public void Close()
        {
            driver.Quit();
        }
    }
}
