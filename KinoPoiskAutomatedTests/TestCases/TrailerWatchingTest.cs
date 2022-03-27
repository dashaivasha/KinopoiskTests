using KinoPoiskAutomatedTests.BaseClass;
using KinoPoiskAutomatedTests.PageObjects;
using NUnit.Framework;

namespace KinoPoiskAutomatedTests.TestCases
{
    [TestFixture]
    public class TrailerWatchingTest : BaseTest
    {
        FilmPage film = new FilmPage();

        [SetUp]
        public void Start()
        {
            driver.Navigate().GoToUrl("https://www.kinopoisk.ru/film/427198/");
        }

        [Test]
        public void TrailerWatching()
        {
            film.PlayTrailer(driver);
            film.CloseTrailer(driver);
        }
    }
}
