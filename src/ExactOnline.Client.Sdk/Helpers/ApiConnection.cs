using System;
using System.IO;
using System.Threading.Tasks;
using ExactOnline.Client.Sdk.Interfaces;

namespace ExactOnline.Client.Sdk.Helpers
{
	/// <summary>
	/// Class for connection to a specific part of the REST API (for example: Account, Invoice, Sales, etc.)
	/// </summary>
	public class ApiConnection : IApiConnection
	{
		private readonly IApiConnector _conn;
		public IApiConnector Conn
		{
			get { return _conn; }
		}

		public string EndPoint { get; set; }

		/// <summary>
		/// Creates a new instance of APIConnection
		/// </summary>
		/// <param name="conn">Instance of APIConnector</param>
		/// <param name="endPoint">Specific endpoint of API</param>
		public ApiConnection(IApiConnector conn, string endPoint)
		{
			if (conn != null && endPoint != string.Empty)
			{
				_conn = conn;
				EndPoint = endPoint;
			}
			else
			{
				throw new ArgumentException("APIConnector and/or endPoint are required");
			}
		}

		/// <summary>
		/// Perform a GET (Read) request on the API
		/// </summary>
		/// <param name="parameters">oData Parameters</param>
		/// <returns>Json String</returns>
		public string Get(string parameters)
		{
			string response = _conn.DoGetRequest(EndPoint, parameters);
			if (response.Contains("Object moved"))
			{
				throw new Exception("Invalid Access Token");
			}
			return response;
        }

        /// <summary>
        /// Perform a GET (Read) request on the API
        /// </summary>
        /// <param name="parameters">oData Parameters</param>
        /// <returns>Json String</returns>
        public async Task<string> GetAsync(string parameters)
        {
            string response = await _conn.DoGetRequestAsync(EndPoint, parameters).ConfigureAwait(false);
            if( response.Contains( "Object moved" ) )
            {
                throw new Exception( "Invalid Access Token" );
            }
            return response;
        }

        /// <summary>
        /// Perform a GET (Read) request on the API
        /// </summary>
        /// <returns>Stream</returns>
        public Stream GetFile()
        {
            Stream response = _conn.DoGetFileRequest(EndPoint);
            return response;
        }

        /// <summary>
        /// Perform a GET (Read) request on the API
        /// </summary>
        /// <returns>Stream</returns>
        public Task<Stream> GetFileAsync()
        {
            return _conn.DoGetFileRequestAsync(EndPoint);
        }

        /// <summary>
        /// Performs a GET (Read) request on the API for one specific entity
        /// </summary>
        /// <param name="keyname">Name of the field that is the unique identifier</param>
        /// <param name="guid">Global Unique Identifier of the entity</param>
        /// <param name="parameters">Parameters</param>
        /// <returns>Json String</returns>
        public string GetEntity(string keyname, string guid, string parameters)
		{
			if (guid == string.Empty || keyname == string.Empty)
			{
				throw new Exception("guid and/or Keyname are not specified");
			}

			// Create call
			string endpoint = EndPoint;
			if (keyname.Contains("ID"))
			{
				endpoint += "(guid'" + guid + "')";
			}
			else
			{
				endpoint += "(" + guid + ")";
			}

			string response = _conn.DoGetRequest(endpoint, parameters);
			return response;
		}

        /// <summary>
        /// Performs a GET (Read) request on the API for one specific entity
        /// </summary>
        /// <param name="keyname">Name of the field that is the unique identifier</param>
        /// <param name="guid">Global Unique Identifier of the entity</param>
        /// <param name="parameters">Parameters</param>
        /// <returns>Json String</returns>
        public Task<string> GetEntityAsync(string keyname, string guid, string parameters)
        {
            if(guid == string.Empty || keyname == string.Empty)
            {
                throw new Exception("guid and/or Keyname are not specified");
            }

            // Create call
            string endpoint = EndPoint;
            if( keyname.Contains("ID") )
            {
                endpoint += "(guid'" + guid + "')";
            }
            else
            {
                endpoint += "(" + guid + ")";
            }

            return _conn.DoGetRequestAsync(endpoint, parameters);
        }

        /// <summary>
        /// Performs a POST (Create) request on the API
        /// </summary>
        /// <param name="data">Json String that representes new entity</param>
        /// <returns>Result from the API in Json Format</returns>
        public string Post(string data)
		{
			string response;
			if (data != string.Empty)
			{
				response = _conn.DoPostRequest(EndPoint, data);
			}
			else
			{
				throw new Exception("No postdata specified");
			}
			return response;
		}

        /// <summary>
        /// Performs a POST (Create) request on the API
        /// </summary>
        /// <param name="data">Json String that representes new entity</param>
        /// <returns>Result from the API in Json Format</returns>
        public async Task<string> PostAsync(string data)
        {
            string response;
            if(data != string.Empty)
            {
                response = await _conn.DoPostRequestAsync(EndPoint, data).ConfigureAwait(false);
            }
            else
            {
                throw new Exception("No postdata specified");
            }
            return response;
        }

        /// <summary>
        /// Performs a PUT Request (Update) on the API
        /// </summary>
        /// <param name="keyName">Name of key field</param>
        /// <param name="guid">Global Unique Identifier of the entity</param>
        /// <param name="data">Json String that represents the new state of the entity</param>
        /// <returns>True if succeeded</returns>
        public Boolean Put(string keyName, string guid, string data)
		{
			Boolean returnValue = false;
			if (guid != string.Empty && data != string.Empty && keyName != string.Empty)
			{
				// Create correct endpoint
				string endpoint = EndPoint;
				if (keyName.Contains("ID")) endpoint += "(guid'" + guid + "')";
				else endpoint += "(" + guid + ")";

				string response = _conn.DoPutRequest(endpoint, data);

				// Reponse is empty on success
				if (!response.Contains("error"))
				{
					returnValue = true;
				}
			}
			else
			{
				throw new Exception("No Guid, keyName or data specified");
			}
			return returnValue;
		}

        /// <summary>
        /// Performs a PUT Request (Update) on the API
        /// </summary>
        /// <param name="keyName">Name of key field</param>
        /// <param name="guid">Global Unique Identifier of the entity</param>
        /// <param name="data">Json String that represents the new state of the entity</param>
        /// <returns>True if succeeded</returns>
        public async Task<Boolean> PutAsync(string keyName, string guid, string data)
        {
            Boolean returnValue = false;
            if(guid != string.Empty && data != string.Empty && keyName != string.Empty)
            {
                // Create correct endpoint
                string endpoint = EndPoint;
                if(keyName.Contains( "ID" )) endpoint += "(guid'" + guid + "')";
                else endpoint += "(" + guid + ")";

                string response = await _conn.DoPutRequestAsync(endpoint, data).ConfigureAwait(false);

                // Reponse is empty on success
                if(!response.Contains("error"))
                {
                    returnValue = true;
                }
            }
            else
            {
                throw new Exception("No Guid, keyName or data specified");
            }
            return returnValue;
        }

        /// <summary>
        /// Performs a DELETE Request on the API
        /// </summary>
        /// <param name="keyName">Name of key field</param>
        /// <param name="guid">Global Unique Identifier of the entity</param>
        /// <returns>True if succeeded</returns>
        public Boolean Delete(string keyName, string guid)
		{
			Boolean returnValue = false;
			if (guid != string.Empty && keyName != string.Empty)
			{
				// Create correct endpoint
				string endpoint = EndPoint;
				if (keyName.Contains("ID")) endpoint += "(guid'" + guid + "')";
				else endpoint += "(" + guid + ")";

				// Create endpoint and get response
				string response = _conn.DoDeleteRequest(endpoint);

				// Reponse is empty on success
				if (response == string.Empty)
				{
					returnValue = true;
				}
			}
			else
			{
				throw new Exception("No GUID specified");
			}
			return returnValue;
		}

        /// <summary>
        /// Performs a DELETE Request on the API
        /// </summary>
        /// <param name="keyName">Name of key field</param>
        /// <param name="guid">Global Unique Identifier of the entity</param>
        /// <returns>True if succeeded</returns>
        public async Task<Boolean> DeleteAsync(string keyName, string guid)
        {
            Boolean returnValue = false;
            if(guid != string.Empty && keyName != string.Empty)
            {
                // Create correct endpoint
                string endpoint = EndPoint;
                if(keyName.Contains("ID")) endpoint += "(guid'" + guid + "')";
                else endpoint += "(" + guid + ")";

                // Create endpoint and get response
                string response = await _conn.DoDeleteRequestAsync(endpoint).ConfigureAwait(false);

                // Reponse is empty on success
                if(response == string.Empty)
                {
                    returnValue = true;
                }
            }
            else
            {
                throw new Exception("No GUID specified");
            }
            return returnValue;
        }

        /// <summary>
        /// Counts the number of resources/entities, including parameters
        /// </summary>
        /// <param name="parameters">Parameters</param>
        /// <returns></returns>
        public int Count(string parameters)
		{
			string response = _conn.DoCleanRequest(EndPoint + "/$count", parameters);
			return int.Parse(response);
		}

        /// <summary>
        /// Counts the number of resources/entities, including parameters
        /// </summary>
        /// <param name="parameters">Parameters</param>
        /// <returns></returns>
        public async Task<int> CountAsync(string parameters)
        {
            string response = await _conn.DoCleanRequestAsync(EndPoint + "/$count", parameters).ConfigureAwait(false);
            return int.Parse(response);
        }
    }
}