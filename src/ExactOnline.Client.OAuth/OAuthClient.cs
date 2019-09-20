using System;
using DotNetOpenAuth.OAuth2;
using DotNetOpenAuth.Messaging;

namespace ExactOnline.Client.OAuth
{
	public class OAuthClient : UserAgentClient
	{
		private readonly Uri _redirectUri;

		#region Constructor

		public OAuthClient(AuthorizationServerDescription serverDescription, string clientId, string clientSecret, Uri redirectUri)
			: base(serverDescription, clientId, clientSecret)
		{
			_redirectUri = redirectUri;
			ClientCredentialApplicator = ClientCredentialApplicator.PostParameter(clientSecret);
		}

        #endregion

        #region Public methods

        public void Authorize(ref IAuthorizationState authorization, string refreshToken)
        {
            Authorize(ref authorization, refreshToken, false);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="authorization"></param>
        /// <param name="refreshToken"></param>
        /// <param name="throwExceptionIfNotAuthorized">Indicates if an exception should be thrown when not authorized. When
        /// this value is true an exception is thrown if not authorized, when false a login dialog is shown to allow a user to login.</param>
        public void Authorize(ref IAuthorizationState authorization, string refreshToken, bool throwExceptionIfNotAuthorized)
		{
			if ((authorization == null))
			{
                authorization = new AuthorizationState();
			}

            authorization.Callback = _redirectUri;
            authorization.RefreshToken = refreshToken;

            bool refreshFailed = false;
			if (AccessTokenHasToBeRefreshed(authorization))
			{
				try
				{
					refreshFailed = !RefreshAuthorization(authorization);
				}
				catch (ProtocolException)
				{
					//The refreshtoken is not valid anymore
				}
			}

			if (authorization.AccessToken == null || refreshFailed)
			{
                throw new UnauthorizedAccessException("Not authorized to use Exact Online API.");
			}
		}

		#endregion

		#region Private methods

		private static bool AccessTokenHasToBeRefreshed(IAuthorizationState authorization)
		{
			if (authorization.AccessToken == null && authorization.RefreshToken != null)
			{
				return true;
			}

			if (authorization.AccessTokenExpirationUtc != null)
			{
				TimeSpan timeToExpire = authorization.AccessTokenExpirationUtc.Value.Subtract(DateTime.UtcNow);
				return (timeToExpire.Minutes < 1);
			}
			return false;
		}

		private Uri GetAuthorizationUri(IAuthorizationState authorization)
		{
			var baseUri = RequestUserAuthorization(authorization);

			var authorizationUriBuilder = new UriBuilder(baseUri)
			{
				Query = baseUri.Query.Substring(1) + "&force_login=1"
			};

			return authorizationUriBuilder.Uri;
		}

		#endregion

	}

}