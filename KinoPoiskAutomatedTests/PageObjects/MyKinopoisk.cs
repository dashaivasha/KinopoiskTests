using KinoPoiskAutomatedTests.WebDriver;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace KinoPoiskAutomatedTests.PageObjects
{
    public class MyKinopoiskPage : DefaultPage
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
            return driver.GetWait().Until(d => driver.FindElement(By.XPath($"//div[@class='info'/a[contains(@href,'{GetFilmId()}')]]")).Enabled);
        }

        public void DeleteFilm()
        {
            Actions actions = new Actions(driver);
            var _deleteButton = By.XPath($"//*[@id='{GetFilmId()}']/a");
            actions.MoveToElement(driver.FindElement(_deleteButton)).Build().Perform();
            WebDriverExtensions.FindElement(driver,_deleteButton,10).Click();
        }
    }
}
