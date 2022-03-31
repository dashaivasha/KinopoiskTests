using System;
using KinoPoiskAutomatedTests.WebDriver;
using OpenQA.Selenium;

namespace KinoPoiskAutomatedTests.PageObjects
{
    public class FilmPage : DefaultPage
    {
        private IWebElement _rating => driver.FindElement(By.XPath("//span[contains(@class,'rating')][1]"));
        private IWebElement _traillerButton => driver.FindElement(By.XPath("//button[text()='Трейлер']/.."));
        private By _trailerEnded => By.XPath("//div[contains(@class,'autoplay')][1]");
        private IWebElement _toWatchButton => driver.FindElement(By.XPath("//button[contains(@class,'ToWatch')]"));
        private IWebElement _userFolders => driver.FindElement(By.XPath("//div[contains(@class,'userFolders')]/a"));

        public double GetRating()
        {
            var rating = _rating.GetAttribute("textContent");

            return Convert.ToDouble(rating);
        }

        public void PlayTrailer()
        {
            driver.GetWait().Until(d => _traillerButton.Enabled);
            _traillerButton.Click();
        }

        public bool TrailEnded()
        {
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[contains(@src,'trailer')]")));
            return driver.GetWait().Until(d => driver.FindElement(_trailerEnded).Enabled);
        }

        public void AddMovieToFavorites()
        {
            driver.GetWait().Until(d => _toWatchButton.Displayed);
            _toWatchButton.Click();
        }

        public void GotoUserFolders()
        {
            driver.GetWait().Until(d => _userFolders.Enabled);
            _userFolders.Click();
        }
    }
}
