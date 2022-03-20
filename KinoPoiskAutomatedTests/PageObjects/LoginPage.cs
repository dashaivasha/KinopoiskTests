using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace KinoPoiskAutomatedTests.PageObjects
{
    public class LoginPage
    {
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//div[@class='AuthLoginInputToggle-type'][2]/button")]
        [CacheLookup]
        public IWebElement EmailChoose { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='passp-field-login']")]
        [CacheLookup]
        public IWebElement UserID { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='passp:sign-in']")]
        [CacheLookup]
        public IWebElement Submit { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='passp-field-passwd']")]
        [CacheLookup]
        public IWebElement Password { get; set; }

        public bool IsEmailChooseExist()
        {
            if (EmailChoose == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
