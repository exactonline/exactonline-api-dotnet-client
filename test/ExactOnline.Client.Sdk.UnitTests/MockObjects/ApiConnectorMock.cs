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

		public string DoCleanRequest(string uri, string oDataQuery)
		{
			return "";
		}

		public int Count()
		{
			return 0;
		}

        #region IAPIConnector Members
        public Task<string> DoGetRequestAsync(string endpoint, string parameters)
        {
            throw new NotImplementedException();
        }
        public string DoGetRequest(string endpoint, string parameters)
		{
			return string.Empty;
		}

		public string DoPostRequest(string endpoint, string postdata)
		{
			Data = postdata;
			return string.Empty;
		}

		public string DoPutRequest(string endpoint, string putData)
		{
			return string.Empty;
		}

		public string DoDeleteRequest(string endpoint)
		{
			return string.Empty;
		}

		public int GetCurrentDivision(string website)
		{
			return -1;
		}

	    public Stream DoGetFileRequest(string endpointy)
	    {
	        return Stream.Null;
	    }

        public Task<Stream> DoGetFileRequestAsync(string endpoint)
        {
            throw new NotImplementedException();
        }

        public Task<string> DoPostRequestAsync(string endpoint, string postdata)
        {
            throw new NotImplementedException();
        }

        public Task<string> DoPutRequestAsync(string endpoint, string putData)
        {
            throw new NotImplementedException();
        }

        public Task<string> DoDeleteRequestAsync(string endpoint)
        {
            throw new NotImplementedException();
        }

        public Task<string> DoCleanRequestAsync(string uri)
        {
            throw new NotImplementedException();
        }

        public Task<string> DoCleanRequestAsync(string uri, string oDataQuery)
        {
            throw new NotImplementedException();
        }



        #endregion
    }
}