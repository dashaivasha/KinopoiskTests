using KinoPoiskAutomatedTests.BaseClass;
using NUnit.Framework;

namespace KinoPoiskAutomatedTests.Tests
{
    [TestFixture]
    public class FindMovieTest : BaseTest
    {
        [Test]
        public void FindMovie()
        {
            homePage.EnterFilmName(Data.FilmName);
            homePage.SelectFilm();
            Assert.True(Data.Rating < filmPage.GetRating());
        }
    }
}
