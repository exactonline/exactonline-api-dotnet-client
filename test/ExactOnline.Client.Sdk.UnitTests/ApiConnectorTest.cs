using ExactOnline.Client.Sdk.Helpers;
using ExactOnline.Client.Sdk.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;

namespace ExactOnline.Client.Sdk.UnitTests
{
	[TestClass]
	public class ApiConnectorTest
	{
		IApiConnector _connector;
		
		private static string GetAccessToken()
		{
			return "accessToken";
		}
		
		[TestInitialize]
		public void Setup()
		{
			_connector = new ApiConnector(GetAccessToken, null);
		}

		
		[TestMethod]
		[TestCategory("Unit Test"), ExpectedException(typeof(ArgumentException))]
		public void ApiConnector_Constructor_WithoutDelegate_Fails()
		{
			var connector = new ApiConnector(null, null);
		}

		[TestMethod]
		[TestCategory("Unit Test")]
		public void ApiConnector_Constructor_WithDelegate_Succeeds()
		{
			var connector = new ApiConnector(GetAccessToken, null);
		}

		[TestMethod]
		[TestCategory("Unit Test"), ExpectedException(typeof(ArgumentException))]
		public void ApiConnector_DoDeleteRequest_With_EmptyValues_Fails()
		{
			_connector.DoDeleteRequest(string.Empty);
		}

        [TestMethod]
        [TestCategory( "Unit Test" ), ExpectedException( typeof( ArgumentException ) )]
        public async Task ApiConnector_DoDeleteRequest_With_EmptyValues_FailsAsync()
        {
            await _connector.DoDeleteRequestAsync( string.Empty ).ConfigureAwait(false);
        }



    }
}
