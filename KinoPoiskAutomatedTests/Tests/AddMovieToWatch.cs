using KinoPoiskAutomatedTests.BaseClass;
using NUnit.Framework;

namespace KinoPoiskAutomatedTests.Tests
{
    [TestFixture]
    public class AddMovieToWatchAndDelete : BaseTest
    {
        [Test]
        public void AddFilmToWarchLaterAndDelete()
        {
            homePage.EnterFilmName(Data.FilmName);
            homePage.SelectFilm();
            filmPage.AddMovieToFavorites();
            filmPage.GotoUserFolders();
            myKinopoisk.DeleteFilm();
            Assert.IsFalse(myKinopoisk.IsFilmAddded());
        }
    }
}
