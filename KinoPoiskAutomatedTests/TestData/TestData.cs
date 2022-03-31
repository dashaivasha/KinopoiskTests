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
        public int WaitTime;

        public TestDetails(string homePageUrl, string filmName, string filmPage, string login, string password, double rating, int waitTime)
        {
            HomePageUrl = homePageUrl;
            FilmName = filmName;
            FilmPage = filmPage;
            Login = login;
            Password = password;
            Rating = rating;
            WaitTime = waitTime;
        }
    }
}
