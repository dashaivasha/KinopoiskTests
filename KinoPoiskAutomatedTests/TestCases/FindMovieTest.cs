using KinoPoiskAutomatedTests.BaseClass;
using KinoPoiskAutomatedTests.PageObjects;
using NUnit.Framework;

namespace KinoPoiskAutomatedTests.TestCases
{
    [TestFixture]
    public class FindMovieTest : BaseTest
    {
        HomePage home = new HomePage();
        FilmPage filmPage = new FilmPage();

        [Test]
        public void FindMovie()
        {
            home.EnterFilmName(driver, Data.FilmName);
            home.SelectFilm(driver);
            Assert.True(Data.Rating < filmPage.GetRating(driver));
        }
    }
}
