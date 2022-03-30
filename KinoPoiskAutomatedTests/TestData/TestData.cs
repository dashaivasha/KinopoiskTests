namespace KinoPoiskAutomatedTests.TestData
{
    public class TestDetails
    {
        public string HomePageUrl;
        public string FilmName;
        public string FilmPage;
        public string Login;
        public string Password;
        public double Rating;

        public TestDetails(string homePageUrl, string filmName, string filmPage, string login, string password, double rating)
        {
            HomePageUrl = homePageUrl;
            FilmName = filmName;
            FilmPage = filmPage;
            Login = login;
            Password = password;
            Rating = rating;
        }
    }
}
