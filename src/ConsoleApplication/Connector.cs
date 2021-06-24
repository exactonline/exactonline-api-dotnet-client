using ExactOnline.Client.OAuth;
using ExactOnline.Client.Sdk.Helpers;
using System;

namespace ConsoleApplication
{
    public static class Connector
    {
        private static string _clientId;
        private static string _clientSecret;
        private static Uri _callbackUrl;
        private static UserAuthorization _authorization;

        public static string EndPoint
        {
            get
            {
                return "https://start.exactonline.nl";
            }
        }

        static Connector()
        {
            var testApp = new TestApp();
            _clientId = Convert.ToString(testApp.ClientId);
            _clientSecret = testApp.ClientSecret;
            _callbackUrl = testApp.CallbackUrl;
            _authorization = new UserAuthorization();
        }

        public static string GetAccessToken()
        {
            UserAuthorizations.Authorize(_authorization, EndPoint, _clientId, _clientSecret, _callbackUrl);

            return _authorization.AccessToken;
        }

    }
}
