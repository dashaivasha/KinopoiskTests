using System.Text;

namespace KinoPoiskAutomatedTests.TestData
{
    public class JsonManager
    {
        public static string GetLogin()
        {
            var loginData = new DataParams();
            loginData = DataSerializer.JsonDeserialize(typeof(DataParams), Globals.LoginPath) as DataParams;
            StringBuilder stringBuilder = new StringBuilder();

            foreach (string value in loginData.Str)
            {
                stringBuilder.Append(value);
            }

            var login = stringBuilder.ToString();

            return login;
        }

        public static string GetPassword()
        {
            var passwordData = new DataParams();
            passwordData = DataSerializer.JsonDeserialize(typeof(DataParams), Globals.PasswordPath) as DataParams;
            StringBuilder stringBuilder = new StringBuilder();

            foreach (string value in passwordData.Str)
            {
                stringBuilder.Append(value);
            }

            var password = stringBuilder.ToString();

            return password;
        }

        public static string GetMovieName()
        {
            var movieData = new DataParams();
            movieData = DataSerializer.JsonDeserialize(typeof(DataParams), Globals.PasswordPath) as DataParams;
            StringBuilder stringBuilder = new StringBuilder();

            foreach (string value in movieData.Str)
            {
                stringBuilder.Append(value);
            }

            var movie = stringBuilder.ToString();

            return movie;
        }
    }
}
