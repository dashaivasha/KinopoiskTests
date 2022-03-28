using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace KinoPoiskAutomatedTests.WebDriver
{
    public class DriverFactory
    {
        public static IWebDriver GetDriver()
        {
            IWebDriver webDriver;
            webDriver = new ChromeDriver();

            return webDriver;
        }
    }  
}
