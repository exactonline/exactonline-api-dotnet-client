using DotNetOpenAuth.OAuth2;
using System;

namespace ExactOnline.Client.OAuth
{
    public static class UserAuthorizations
    {
        private static AuthorizationServerDescription _serverDescription;

        public static void Authorize(UserAuthorization authorization, string website, string clientId, string clientSecret, string username, string password, Uri redirectUri)
        {
            if (_serverDescription == null)
            {
                _serverDescription = new AuthorizationServerDescription
                {
                    AuthorizationEndpoint = new Uri(string.Format("{0}/api/oauth2/auth", website)),
                    TokenEndpoint = new Uri(string.Format("{0}/api/oauth2/token", website))
                };
            }

            OAuthClient oAuthClient;
            if (string.IsNullOrWhiteSpace(username) && string.IsNullOrWhiteSpace(password))
            {
                oAuthClient = new OAuthClient(_serverDescription, clientId, clientSecret, redirectUri);
            }
            else
            {
                oAuthClient = new OAuthClient(_serverDescription, clientId, clientSecret, username, password, redirectUri);
            }

            var authorizationState = authorization.AuthorizationState;
            oAuthClient.Authorize(ref authorizationState, authorization.RefreshToken);
            authorization.AuthorizationState = authorizationState;
        }
    }
}