using DotNetOpenAuth.OAuth2;
using System;

namespace ExactOnline.Client.OAuth
{
    public static class UserAuthorizations
    {
        private static AuthorizationServerDescription _serverDescription;

        public static void Authorize(UserAuthorization authorization, string website, string clientId, string clientSecret, Uri redirectUri)
        {
            Authorize(authorization, website, clientId, clientSecret, redirectUri, false);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="authorization"></param>
        /// <param name="website"></param>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <param name="redirectUri"></param>
        /// <param name="throwExceptionIfNotAuthorized">Indicates if an exception should be thrown when not authorized. When
        /// this value is true an exception is thrown if not authorized, when false a login dialog is shown to allow a user to login.</param>
        public static void Authorize(UserAuthorization authorization, string website, string clientId, string clientSecret, Uri redirectUri, bool throwExceptionIfNotAuthorized)
        {

            if (_serverDescription == null)
            {
                _serverDescription = new AuthorizationServerDescription
                {
                    AuthorizationEndpoint = new Uri(string.Format("{0}/api/oauth2/auth", website)),
                    TokenEndpoint = new Uri(string.Format("{0}/api/oauth2/token", website))
                };
            }
            var oAuthClient = new OAuthClient(_serverDescription, clientId, clientSecret, redirectUri);

            var authorizationState = authorization.AuthorizationState;
            oAuthClient.Authorize(ref authorizationState, authorization.RefreshToken, throwExceptionIfNotAuthorized);
            authorization.AuthorizationState = authorizationState;
        }
    }
}