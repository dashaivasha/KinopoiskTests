using System;
namespace KinoPoiskAutomatedTests.PageObjects
{
    public class MyKinopoiskPage : DefaultPage
    {

        public void DeleteFilmFromFolder()
        {
            var url = driver.Url;
            int idx = url.LastIndexOf('/');
            var filmId = url.Substring(idx+1,idx);
            Console.WriteLine(filmId);
        }

    }
}
