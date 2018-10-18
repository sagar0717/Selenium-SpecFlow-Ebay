

namespace AutoTestFramework
{
   public static class Config
    {
        public static string BaseUrl = "http://testing.todvachev.com/";

        public static class Credentials
        {
            public static class Valid
            {
                public static string Username = "ValidUser";
                public static string Password = "asdf1234!";
                public static string RepeatPassword = "asdf1234!";
                public static string Email = "example@example.com";
            }

            public static class InValid
            {

            }

        }
    }
}
