using System;
using System.IO;
using System.Threading.Tasks;
using ExactOnline.Client.Sdk.Interfaces;

namespace ExactOnline.Client.Sdk.UnitTests.MockObjects
{

	/// <summary>
	/// Simulates APIConnector class
	/// </summary>
	public class ApiConnectorMock : IApiConnector
	{
		public String Data { get; set; }

		public string DoCleanRequest(string uri)
		{
			return "";
		}

        public Task<string> DoCleanRequestAsync(string uri)
        {
            return Task.FromResult(DoCleanRequest(uri));
        }

        public string DoCleanRequest(string uri, string oDataQuery)
		{
			return "";
		}

        public Task<string> DoCleanRequestAsync(string uri, string oDataQuery)
        {
            return Task.FromResult(DoCleanRequest(uri,oDataQuery));
        }

        public int Count()
		{
			return 0;
		}

        public Task<int> CountAsync()
        {
            return Task.FromResult(Count());
        }

        #region IAPIConnector Members

        public string DoGetRequest(string endpoint, string parameters)
		{
			return string.Empty;
		}

        public Task<string> DoGetRequestAsync(string endpoint, string parameters)
        {
            return Task.FromResult(DoGetRequest(endpoint,parameters));
        }

        public string DoPostRequest(string endpoint, string postdata)
		{
			Data = postdata;
			return string.Empty;
		}

        public Task<string> DoPostRequestAsync(string endpoint, string postdata)
        {
            return Task.FromResult(DoPostRequest(endpoint,postdata));
        }

        public string DoPutRequest(string endpoint, string putData)
		{
			return string.Empty;
		}

        public Task<string> DoPutRequestAsync(string endpoint, string putData)
        {
            return Task.FromResult(DoPutRequest(endpoint,putData));
        }

        public string DoDeleteRequest(string endpoint)
		{
			return string.Empty;
		}

        public Task<string> DoDeleteRequestAsync(string endpoint)
        {
            return Task.FromResult(DoDeleteRequest(endpoint));
        }

        public int GetCurrentDivision(string website)
		{
			return -1;
		}

        public Task<int> GetCurrentDivisionAsync(string website)
        {
            return Task.FromResult(GetCurrentDivision(website));
        }

        public Stream DoGetFileRequest(string endpointy)
	    {
	        return Stream.Null;
	    }

        public Task<Stream> DoGetFileRequestAsync(string endpointy)
        {
            return Task.FromResult(DoGetFileRequest(endpointy));
        }

        #endregion
    }
}