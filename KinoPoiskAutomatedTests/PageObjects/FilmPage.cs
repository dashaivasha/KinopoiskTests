using System;
using KinoPoiskAutomatedTests.WebDriver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace KinoPoiskAutomatedTests.PageObjects
{
    public class FilmPage
    {
        private By _rating = By.XPath("//span[contains(@class,'rating')][1]");
        private By _traillerButton = By.XPath("//button[text()='Трейлер']/..");
        private By _trailerEnded = By.XPath("//div[contains(@class,'autoplay__Cancel')]");
        private By _closeTrailler = By.XPath("//button[@class='discovery-trailers-closer']");

        public double GetRating()
        {
            var driver = DriverFactory.GetDriver();
            var rating = driver.FindElement(_rating).GetAttribute("textContent");

            return Convert.ToDouble(rating);
        }

        public void PlayTrailer()
        {
            var driver = DriverFactory.GetDriver();
            driver.FindElement(_traillerButton).Click();
        }

        public void CloseTrailer()
        {
            var driver = DriverFactory.GetDriver();
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(125));
            wait.Until(driver => driver.FindElement(_trailerEnded));
            driver.FindElement(_closeTrailler).Click();
        }
    }
}
