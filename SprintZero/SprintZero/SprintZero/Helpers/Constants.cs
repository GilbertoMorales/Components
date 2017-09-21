namespace SprintZero.Helpers
{
    public static class Constants
    {
        public static string AppName = "SprintZero";
        
        public static string iOSClientId = "<insert IOS client ID here>";
        public static string AndroidClientId = "178832173871-uvbmlnq8i4l1r63e7bcn5hciboh968un.apps.googleusercontent.com";

        public static string Scope = "https://www.googleapis.com/auth/userinfo.email";
        public static string AuthorizeUrl = "https://accounts.google.com/o/oauth2/auth";
        public static string AccessTokenUrl = "https://www.googleapis.com/oauth2/v4/token";
        public static string UserInfoUrl = "https://www.googleapis.com/oauth2/v2/userinfo";

        // Set these to reversed iOS/Android client ids, with :/oauth2redirect appended
        public static string iOSRedirectUrl = "<insert IOS redirect URL here>:/oauth2redirect";
        public static string AndroidRedirectUrl = "https://www.youtube.com";
    }
}
