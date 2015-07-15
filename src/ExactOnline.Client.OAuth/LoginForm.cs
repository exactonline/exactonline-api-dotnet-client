using System;
using System.Windows.Forms;

namespace ExactOnline.Client.OAuth
{
    public partial class LoginForm : Form
    {
        private readonly bool _isAutoLogin;
        private readonly string _username;
        private readonly string _password;
        private readonly Uri _redirectUri;

        #region Property

        public Uri AuthorizationUri { get; set; }

        #endregion

        #region Constructor

        public LoginForm(Uri redirectUri)
            : this()
        {
            _redirectUri = redirectUri;
        }

        public LoginForm(string username, string password, Uri redirectUri)
            : this()
        {
            _isAutoLogin = true;
            _username = username;
            _password = password;
            _redirectUri = redirectUri;
        }

        public LoginForm()
        {
            InitializeComponent();
            WebBrowser.ScriptErrorsSuppressed = true;
            WebBrowser.Navigated += WebBrowserNavigated;
        }

        #endregion

        private void LoginFormLoad(object sender, EventArgs e)
        {
            if (_isAutoLogin)
            {
                if (string.IsNullOrWhiteSpace(_username) || string.IsNullOrWhiteSpace(_password))
                {
                    throw new ArgumentException("Username and/or password cannot be null.");
                }

                var loginUrl = string.Format("{0}&UserNameField={1}&PasswordField={2}", AuthorizationUri, _username, _password);
                WebBrowser.Navigate(loginUrl);
            }
            else
            {
                WebBrowser.Navigate(AuthorizationUri);
            }
        }

        private void WebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (!_isAutoLogin)
            {
                return;
            }

            if (WebBrowser.Document == null)
            {
                throw new SystemException("WebBrowser.Document is null.");
            }

            var elementById = WebBrowser.Document.GetElementById("LoginButton");
            if (elementById == null)
            {
                throw new SystemException("WebBrowser.Document.GetElementById(\"LoginButton\") is null.");
            }

            elementById.InvokeMember("click");
        }

        #region Events

        private void WebBrowserNavigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            if (IsRedirected(e.Url))
            {
                AuthorizationUri = e.Url;
                Hide();
            }
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Tests whether two URLs are equal for purposes of detecting the conclusion of authorization.
        /// </summary>
        private bool IsRedirected(Uri uri)
        {
            var uriComponents = uri.GetComponents(UriComponents.SchemeAndServer | UriComponents.Path, UriFormat.Unescaped);
            var redirectUri = _redirectUri.ToString();
            if (uriComponents.EndsWith("/") && !redirectUri.EndsWith("/"))
            {
                redirectUri = redirectUri + "/";
            }

            return string.Equals(uriComponents, redirectUri, StringComparison.Ordinal);
        }

        #endregion


    }
}
