using KinoPoiskAutomatedTests.BaseClass;
using NUnit.Framework;

namespace KinoPoiskAutomatedTests.Tests
{
    [TestFixture]
    public class TrailerWatchingTest : BaseTest
    {
        [Test]
        public void TrailerWatching()
        {
            homePage.EnterFilmName(Data.FilmName);
            homePage.SelectFilm();
            filmPage.PlayTrailer();
            Assert.IsTrue(filmPage.TrailEnded());
        }
    }
}
