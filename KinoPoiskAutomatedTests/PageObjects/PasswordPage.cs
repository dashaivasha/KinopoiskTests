using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace KinoPoiskAutomatedTests.PageObjects
{
    public class PasswordPage
    {
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//*[@id='passp-field-passwd']")]
        [CacheLookup]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='passp:sign-in']")]
        [CacheLookup]
        public IWebElement SignIn { get; set; }       
    }
}
