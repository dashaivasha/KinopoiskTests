using System;
using KinoPoiskAutomatedTests.WebDriver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace KinoPoiskAutomatedTests.PageObjects
{
    public class FilmPage : DefaultPage
    {
        private IWebElement _rating => driver.FindElement(By.XPath("//span[contains(@class,'rating')][1]"));
        private IWebElement _traillerButton => driver.FindElement(By.XPath("//button[text()='Трейлер']/.."));
        private By _trailerEnded => By.XPath("//div[contains(@class,'autoplay')]");
        private IWebElement _closeTrailler => driver.FindElement(By.XPath("//button[@class='discovery-trailers-closer']"));
        private IWebElement _toWatchButton => driver.FindElement(By.XPath("//button[contains(@class,'ToWatch')]"));
        private IWebElement _userFolders => driver.FindElement(By.XPath("//div[contains(@class,'userFolders')]/a"));

        public double GetRating()
        {
            var rating = _rating.GetAttribute("textContent");

            return Convert.ToDouble(rating);
        }

        public void PlayTrailer()
        {
            _traillerButton.Click();
        }

        public void CloseTrailer()
        {
            WebDriverExtensions.FindElement(driver, _trailerEnded, 125);
            _closeTrailler.Click();
        }

        public void AddMovieToFavorites()
        {
            driver.GetWait().Until(d => _toWatchButton.Enabled);
            _toWatchButton.Click();
        }

        public void GotoUserFolders()
        {
            _userFolders.Click();
        }
    }
}
