using System;
using KinoPoiskAutomatedTests.TestData;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace KinoPoiskAutomatedTests.PageObjects
{
    public class HomePage 
    {
        public TestDetails Data = JsonManager.GetTestData();
        private By _myAccountButton = By.XPath("//button[contains(@class,'login')]");
        private By _exitButton = By.XPath("//*[text()='Выйти']");
        private By _searchButton = By.XPath("//div[contains(@class,'search')]/button");
        private By _searchInput = By.XPath("//input[contains(@class,'search')]");

        public void PressLogInButton(IWebDriver driver)
        {
            driver.FindElement(_myAccountButton).Click();
        }

        public bool IsExitExist(IWebDriver driver)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(driver => driver.FindElement(_exitButton));
            return driver.FindElement(_exitButton).Enabled;
        }

        public void EnterFilmName(IWebDriver driver, string filmName)
        {
            driver.FindElement(_searchInput).SendKeys(filmName);
        }

        public void FindFilm(IWebDriver driver)
        {
            driver.FindElement(_searchButton).Click();
        }

        public void SelectFilm(IWebDriver driver)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            By _rightFilm = By.XPath($"//h4[text()='{Data.FilmName}']//ancestor::div[contains(@class,'suggest-group')]");
            wait.Until(driver => driver.FindElement(_rightFilm).Enabled);
            driver.FindElement(_rightFilm).Click();
        }
    }
}
