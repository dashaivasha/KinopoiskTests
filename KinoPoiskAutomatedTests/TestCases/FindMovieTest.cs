using KinoPoiskAutomatedTests.BaseClass;
using KinoPoiskAutomatedTests.PageObjects;
using KinoPoiskAutomatedTests.TestData;
using NUnit.Framework;
using SeleniumExtras.PageObjects;

namespace KinoPoiskAutomatedTests.TestCases
{
    [TestFixture]
    public class FindMovieTest : BaseTest
    {
        [Test]
        public void FindMovie()
        {
            var homePage = new HomePage();
            PageFactory.InitElements(driver, homePage);
            homePage.SearchButton.Click();  
            homePage.SearchInput.SendKeys(JsonManager.GetMovieName());
            homePage.SelectFilm.Click();
        }
    }
}
