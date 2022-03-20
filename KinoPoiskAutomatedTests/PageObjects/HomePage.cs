using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace KinoPoiskAutomatedTests.PageObjects
{
    public class HomePage
    {
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//a[contains(@href,'passport.yandex.ru/auth?')]")]
        [CacheLookup]
        public IWebElement MyAccount { get; set; }
    
    }
}
