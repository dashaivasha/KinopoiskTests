using System;
using KinoPoiskAutomatedTests.WebDriver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace KinoPoiskAutomatedTests.PageObjects
{
    public class HomePage : BasePage
    {
        private IWebElement _myAccountButton => driver.FindElement(By.XPath("//button[contains(@class,'login')]"));
        private By _exitButton = By.XPath("//*[text()='Выйти']");
        private By _avatar = By.XPath("//div[contains(@class,'avatar')][1]");
        private IWebElement _searchButton => driver.FindElement(By.XPath("//div[contains(@class,'search')]/button"));
        private By _searchInput =  By.XPath("//input[contains(@class,'search')]");

        public void PressLogInButton()
        {
            _myAccountButton.Click();
        }

        public void PressLogOutButton()
        {
            WebDriverExtensions.FindElement(driver, _avatar, Data.WaitTime).Click();
            WebDriverExtensions.FindElement(driver,_exitButton,Data.WaitTime).Click();
        }

        public bool IsExitExist()
        {
            return driver.GetWait().Until(d => driver.FindElement(_exitButton).Enabled);
        }

        public void EnterFilmName(string filmName)
        {
            WebDriverExtensions.FindElement(driver, _searchInput, 60);
            var input = driver.FindElement(_searchInput);
            input.SendKeys(filmName);
        }

        public void FindFilm()
        {
            _searchButton.Click();
        }

        public void SelectFilm()
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            By _rightFilm = By.XPath($"//h4[text()='{Data.FilmName}']//ancestor::div[contains(@class,'suggest-group')]");
            wait.Until(driver => driver.FindElement(_rightFilm).Enabled);
            driver.FindElement(_rightFilm).Click();
        }
    }
}
