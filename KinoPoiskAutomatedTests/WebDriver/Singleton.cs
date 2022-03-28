using OpenQA.Selenium;

namespace KinoPoiskAutomatedTests.WebDriver
{
    public class Singleton
    {
        private static Singleton _instance;
        private static IWebDriver _webDriver;

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }

            return _instance;
        }

        public IWebDriver CreateDriver()
        {
            if (_webDriver == null)
            {
                _webDriver = DriverFactory.GetDriver();
            }

            return _webDriver = DriverFactory.GetDriver();
        }
    }
}
