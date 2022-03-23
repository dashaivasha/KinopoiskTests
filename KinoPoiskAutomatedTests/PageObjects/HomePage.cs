using KinoPoiskAutomatedTests.TestData;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace KinoPoiskAutomatedTests.PageObjects
{
    public class HomePage
    {
        private static IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//a[contains(@href,'passport.yandex.ru/auth?')]")]
        [CacheLookup]
        public IWebElement MyAccount { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains( @class,'userContainer')]")]
        [CacheLookup]
        public IWebElement AuthorizedAccount { get; }

        [FindsBy(How = How.XPath, Using = "//input[@type='search']")]
        [CacheLookup]
        public IWebElement SearchInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(@class,'search')]")]
        [CacheLookup]
        public IWebElement SearchButton { get; set; }

        public IWebElement SelectFilm { get; set; }

        public bool IsLoggedIn()
        {
            if (AuthorizedAccount == null)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
