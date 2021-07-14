using ExactOnline.Client.Models.CRM;
using ExactOnline.Client.Sdk.Controllers;
using ExactOnline.Client.Sdk.Helpers;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace ConsoleApplication
{
    class Program
	{
        /// <summary>
        /// This is a sample console application that recommends you how to use ExactOnline.Client.Sdk
        /// Please use this code as an example and you can design Connector class as you like
        /// </summary>
        /// <param name="args"></param>
		[STAThread]
		static void Main(string[] args)
		{
			// To make this work set the authorisation properties of your test app in the testapp.config.
			var testApp = new TestApp();

            //When you initialize your Connector class, always reuse it and do not create it again and again.
            //Otwerwise your calls will be rejected as you should reuse your existing token
			var connector = new Connector(testApp.ClientId.ToString(), testApp.ClientSecret, testApp.CallbackUrl);

            // Pass function with all required properties as delegate to ExactOnlineClient class
            var client1 = new ExactOnlineClient(connector.EndPoint, connector.GetAccessToken);

            // Call with client 1

            // Get the Code and Name of a random account in the administration.
            var fields = new[] { "Code", "Name" };

            var account = client1.For<Account>().Top(1).Select(fields).Get().FirstOrDefault();

            Debug.WriteLine(String.Format("Account {0} - {1}", account.Code.TrimStart(), account.Name));
            Debug.WriteLine(String.Format("X-RateLimit-Limit:  {0} - X-RateLimit-Remaining: {1} - X-RateLimit-Reset: {2}",
                client1.EolResponseHeader.RateLimit.Limit, client1.EolResponseHeader.RateLimit.Remaining, client1.EolResponseHeader.RateLimit.Reset));

            //Now if you would like to create another ExactOnlineClient, you should reuse existing Connector class that you created
            //Othwerise if you create new Connector class, it is going to request for a new token
            //and your call will be rejected as your old token has not been expired
            var client2 = new ExactOnlineClient(connector.EndPoint, connector.GetAccessToken);

            // Call with client 2 and reusing existing token

            //This is an example of how to use skipToken for paging.
            string skipToken = string.Empty;

            var accounts = client2.For<Account>().Select(fields).Get(ref skipToken);

            Debug.WriteLine(String.Format("skipToken {0}", skipToken));
            Debug.WriteLine(String.Format("X-RateLimit-Limit:  {0} - X-RateLimit-Remaining: {1} - X-RateLimit-Reset: {2}",
                client2.EolResponseHeader.RateLimit.Limit, client2.EolResponseHeader.RateLimit.Remaining, client2.EolResponseHeader.RateLimit.Reset));

            //Now application is going to wait until token is expired 

            // Token expires after 9 mins and 30 seconds (570 seconds in total) and after that time the token has to be refreshed

            var tokenExpiresInSeconds = 570;

            Debug.WriteLine($"Application is going to sleep for {tokenExpiresInSeconds} seconds");

            Thread.Sleep(tokenExpiresInSeconds * 1000);

            //Call with client1 and token will be refreshed before making a request

            //Now I can use the skip token to get the first record from the next page.
            var nextAccount = client1.For<Account>().Top(1).Select(fields).Get(ref skipToken).FirstOrDefault();

            Debug.WriteLine(String.Format("Account {0} - {1}", nextAccount.Code.TrimStart(), nextAccount.Name));
            Debug.WriteLine(String.Format("X-RateLimit-Limit:  {0} - X-RateLimit-Remaining: {1} - X-RateLimit-Reset: {2}",
                client1.EolResponseHeader.RateLimit.Limit, client1.EolResponseHeader.RateLimit.Remaining, client1.EolResponseHeader.RateLimit.Reset));
        }
    }
}
