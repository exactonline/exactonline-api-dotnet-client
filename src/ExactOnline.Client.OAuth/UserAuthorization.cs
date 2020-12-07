using DotNetOpenAuth.OAuth2;

namespace ExactOnline.Client.OAuth
{
    public class UserAuthorization

    {

        public delegate void ChangedRefreshEventHandler(UserAuthorization sender);

        public event ChangedRefreshEventHandler RefreshTokenEvent;



        public string AccessToken
        {
            get
            {
                return AuthorizationState.AccessToken;
            }
        }

        private string mRefreshToken;


        public string RefreshToken
        {
            get
            {
                return mRefreshToken;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {

                    // "" change to null
                    mRefreshToken = null;
                }
                else
                {

                    mRefreshToken = value;
                }

                RefreshTokenEvent?.Invoke(this);

            }

        }

        private IAuthorizationState mAuthorizationState;

        public IAuthorizationState AuthorizationState
        {
            get
            {
                return mAuthorizationState;
            }

            set
            {

                RefreshToken = value.RefreshToken;
                mAuthorizationState = value;

            }


        }
    }
}
