using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace KinoPoiskAutomatedTests.WebDriver
{
    public class DriverFactory
    {
        private static IWebDriver _webDriver;

        public static IWebDriver GetDriver()
        {
            if (_webDriver == null)
            {
                _webDriver = new ChromeDriver();
            }

            return _webDriver;
        }
    }  
}
