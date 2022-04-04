using System;
using KinoPoiskAutomatedTests.WebDriver;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace KinoPoiskAutomatedTests.PageObjects
{
    public class MyKinopoiskPage : BasePage
    {
        private string GetFilmId()
        {
            var url = Data.FilmPage;
            int index = url.IndexOf("m/");
            var s = url.Remove(0, ++index);
            var filmId = s.Replace("/", "");

            return filmId;
        }

        public bool IsFilmAddded()
        {
            return driver.GetWait(TimeSpan.FromSeconds(Data.WaitTime), TimeSpan.FromMilliseconds(Data.WaitTime)).Until(d => driver.FindElement(By.XPath($"//li[contains(@id,'{GetFilmId()}')]")).Displayed);
        }

        public void DeleteFilm()
        {
            Actions actions = new Actions(driver);
            var _deleteButton = By.XPath($"//div[@id='{GetFilmId()}']/a");
            IWebElement _deleteDiv = driver.FindElement(By.XPath($"//li[contains(@id,'{GetFilmId()}')]"));
            actions.MoveToElement(_deleteDiv).Perform();
            actions.MoveToElement(driver.FindElement(_deleteButton)).Click().Build().Perform();
        }
    }
}
