using ExactOnline.Client.Models.CRM;
using ExactOnline.Client.Sdk.Controllers;
using ExactOnline.Client.Sdk.Helpers;
using System;
using System.Diagnostics;
using System.Linq;

namespace ConsoleApplication
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            // To make this work set the authorisation properties of your test app in the testapp.config.

            var client = new ExactOnlineClient(Connector.EndPoint, Connector.GetAccessToken);

            // Get the Code and Name of a random account in the administration.
            var fields = new[] { "Code", "Name" };
            var account = client.For<Account>().Top(1).Select(fields).Get().FirstOrDefault();
            Debug.WriteLine(String.Format("Account {0} - {1}", account.Code.TrimStart(), account.Name));
            Debug.WriteLine(String.Format("X-RateLimit-Limit:  {0} - X-RateLimit-Remaining: {1} - X-RateLimit-Reset: {2}",
                client.EolResponseHeader.RateLimit.Limit, client.EolResponseHeader.RateLimit.Remaining, client.EolResponseHeader.RateLimit.Reset));

            //This is an example of how to use skipToken for paging.
            string skipToken = string.Empty;
            var accounts = client.For<Account>().Select(fields).Get(ref skipToken);
            Debug.WriteLine(String.Format("skipToken {0}", skipToken));
            Debug.WriteLine(String.Format("X-RateLimit-Limit:  {0} - X-RateLimit-Remaining: {1} - X-RateLimit-Reset: {2}",
                client.EolResponseHeader.RateLimit.Limit, client.EolResponseHeader.RateLimit.Remaining, client.EolResponseHeader.RateLimit.Reset));

            //Now I can use the skip token to get the first record from the next page.
            var nextAccount = client.For<Account>().Top(1).Select(fields).Get(ref skipToken).FirstOrDefault();
            Debug.WriteLine(String.Format("Account {0} - {1}", nextAccount.Code.TrimStart(), nextAccount.Name));
            Debug.WriteLine(String.Format("X-RateLimit-Limit:  {0} - X-RateLimit-Remaining: {1} - X-RateLimit-Reset: {2}",
                client.EolResponseHeader.RateLimit.Limit, client.EolResponseHeader.RateLimit.Remaining, client.EolResponseHeader.RateLimit.Reset));

        }
    }
}
