using ExactOnline.Client.Sdk.Controllers;
using ExactOnline.Client.Sdk.Delegates;
using ExactOnline.Client.Sdk.Enums;
using ExactOnline.Client.Sdk.Exceptions;
using ExactOnline.Client.Sdk.Interfaces;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ExactOnline.Client.Sdk.Helpers
{
	/// <summary>
	/// Class for doing request to REST API
	/// </summary>
	public class ApiConnector : IApiConnector
	{
		private readonly AccessTokenManagerDelegate _accessTokenDelegate;
        private readonly ExactOnlineClient _client;

		#region Constructor

		/// <summary>
		/// Creates new instance of ApiConnector
		/// </summary>
		/// <param name="accessTokenDelegate">Valid oAuth Access Token</param>
		public ApiConnector(AccessTokenManagerDelegate accessTokenDelegate, ExactOnlineClient client)
		{
            _client = client;
			if (accessTokenDelegate == null) throw new ArgumentException("accessTokenDelegate");
			_accessTokenDelegate = accessTokenDelegate;
		}

		#endregion

		#region Public methods

		/// <summary>
		/// Read Data: Perform a GET Request on the API
		/// </summary>
		/// <param name="endpoint">{URI}/{Division}/{Resource}/{Entity}</param>
		/// <param name="oDataQuery">oData Querystring</param>
		/// <returns>String with API Response in Json Format</returns>
		public string DoGetRequest(string endpoint, string oDataQuery)
		{
			if (string.IsNullOrEmpty(endpoint)) throw new ArgumentException("Cannot perform request with empty endpoint");

			var request = CreateRequest(endpoint, oDataQuery, RequestTypeEnum.GET);

			Debug.Write("GET ");
			Debug.WriteLine(request.RequestUri);

			return GetResponse(request);
        }

        /// <summary>
        /// Read Data: Perform a GET Request on the API
        /// </summary>
        /// <param name="endpoint">{URI}/{Division}/{Resource}/{Entity}</param>
        /// <param name="oDataQuery">oData Querystring</param>
        /// <returns>String with API Response in Json Format</returns>
        public Task<string> DoGetRequestAsync(string endpoint, string oDataQuery)
        {
            if(string.IsNullOrEmpty(endpoint)) throw new ArgumentException("Cannot perform request with empty endpoint");

            var request = CreateRequest(endpoint, oDataQuery, RequestTypeEnum.GET);

            Debug.Write("GET ");
            Debug.WriteLine(request.RequestUri);

            return GetResponseAsync(request);
        }

        /// <summary>
        /// Read Data: Perform a GET Request on the API
        /// </summary>
        /// <param name="endpoint">full url</param>
        /// <returns>Stream </returns>
        public Stream DoGetFileRequest(string endpoint)
        {
            if (string.IsNullOrEmpty(endpoint)) throw new ArgumentException("Cannot perform request with empty endpoint");

            var request = CreateRequest(endpoint, null, RequestTypeEnum.GET);

            Debug.Write("GET ");
            Debug.WriteLine(request.RequestUri);

            return GetResponseFile(request);
        }

        /// <summary>
        /// Read Data: Perform a GET Request on the API
        /// </summary>
        /// <param name="endpoint">full url</param>
        /// <returns>Stream </returns>
        public Task<Stream> DoGetFileRequestAsync(string endpoint)
        {
            if(string.IsNullOrEmpty(endpoint)) throw new ArgumentException("Cannot perform request with empty endpoint");

            var request = CreateRequest(endpoint, null, RequestTypeEnum.GET);

            Debug.Write("GET ");
            Debug.WriteLine(request.RequestUri);

            return GetResponseFileAsync(request);
        }

        /// <summary>
        /// Create Data: Perform a POST Request on the API
        /// </summary>
        /// <param name="endpoint">{URI}/{Division}/{Resource}/{Entity}</param>
        /// <param name="postdata">String containing data of new entity in Json format</param>
        /// <returns>String with API Response in Json Format</returns>
        public string DoPostRequest(string endpoint, string postdata)
		{
			if (string.IsNullOrEmpty(endpoint) || string.IsNullOrEmpty(postdata)) throw new ArgumentException("Cannot perform request with empty endpoint or postdata");

			var request = CreateRequest(endpoint, null, RequestTypeEnum.POST);

			// Add POST data to the request
			if (!string.IsNullOrEmpty(postdata))
			{
				var bytes = Encoding.GetEncoding("utf-8").GetBytes(postdata);
				request.ContentLength = bytes.Length;

				using (var writeStream = request.GetRequestStream())
				{
					writeStream.Write(bytes, 0, bytes.Length);
				}
			}
			else
			{
				throw new BadRequestException(); // Post request needs data
			}

			Debug.Write("POST ");
			Debug.WriteLine(request.RequestUri);
			Debug.WriteLine(postdata);

			return GetResponse(request);
		}

        /// <summary>
        /// Create Data: Perform a POST Request on the API
        /// </summary>
        /// <param name="endpoint">{URI}/{Division}/{Resource}/{Entity}</param>
        /// <param name="postdata">String containing data of new entity in Json format</param>
        /// <returns>String with API Response in Json Format</returns>
        public async Task<string> DoPostRequestAsync(string endpoint, string postdata)
        {
            if(string.IsNullOrEmpty(endpoint) || string.IsNullOrEmpty(postdata)) throw new ArgumentException("Cannot perform request with empty endpoint or postdata");

            var request = CreateRequest(endpoint, null, RequestTypeEnum.POST);

            // Add POST data to the request
            if(!string.IsNullOrEmpty(postdata))
            {
                var bytes = Encoding.GetEncoding("utf-8").GetBytes(postdata);
                request.ContentLength = bytes.Length;

                using(var writeStream = await request.GetRequestStreamAsync().ConfigureAwait(false))
                {
                    await writeStream.WriteAsync(bytes, 0, bytes.Length).ConfigureAwait(false);
                }
            }
            else
            {
                throw new BadRequestException(); // Post request needs data
            }

            Debug.Write("POST ");
            Debug.WriteLine(request.RequestUri);
            Debug.WriteLine(postdata);

            return await GetResponseAsync(request).ConfigureAwait(false);
        }

        /// <summary>
        /// Update data: Perform a PUT Request on API
        /// </summary>
        /// <param name="endpoint">{URI}/{Division}/{Resource}/{Entity}</param>
        /// <param name="putData">String containing updated entity data in Json format</param>
        /// <returns>String with API Response in Json Format</returns>
        public string DoPutRequest(string endpoint, string putData)
		{
			if (string.IsNullOrEmpty(endpoint) || string.IsNullOrEmpty(putData)) throw new ArgumentException("Cannot perform request with empty endpoint or putData");

			var request = CreateRequest(endpoint, null, RequestTypeEnum.PUT);

			if (!string.IsNullOrEmpty(putData))
			{
				var bytes = Encoding.GetEncoding("utf-8").GetBytes(putData);
				request.ContentLength = bytes.Length;

				using (var writeStream = request.GetRequestStream())
				{
					writeStream.Write(bytes, 0, bytes.Length);
				}
			}
			else
			{
				// Post request needs data
				throw new BadRequestException();
			}

			Debug.Write("PUT ");
			Debug.WriteLine(request.RequestUri);
			Debug.WriteLine(putData);

			return GetResponse(request);
		}

        /// <summary>
        /// Update data: Perform a PUT Request on API
        /// </summary>
        /// <param name="endpoint">{URI}/{Division}/{Resource}/{Entity}</param>
        /// <param name="putData">String containing updated entity data in Json format</param>
        /// <returns>String with API Response in Json Format</returns>
        public async Task<string> DoPutRequestAsync(string endpoint, string putData)
        {
            if(string.IsNullOrEmpty(endpoint) || string.IsNullOrEmpty(putData)) throw new ArgumentException("Cannot perform request with empty endpoint or putData");

            var request = CreateRequest(endpoint, null, RequestTypeEnum.PUT);

            if(!string.IsNullOrEmpty(putData))
            {
                var bytes = Encoding.GetEncoding("utf-8").GetBytes(putData);
                request.ContentLength = bytes.Length;

                using(var writeStream = await request.GetRequestStreamAsync().ConfigureAwait(false))
                {
                    await writeStream.WriteAsync(bytes, 0, bytes.Length).ConfigureAwait(false);
                }
            }
            else
            {
                // Post request needs data
                throw new BadRequestException();
            }

            Debug.Write("PUT ");
            Debug.WriteLine(request.RequestUri);
            Debug.WriteLine(putData);

            return await GetResponseAsync(request).ConfigureAwait(false);
        }

        /// <summary>
        /// Delete entity: Perform a DELETE Request on API
        /// </summary>
        /// <param name="endpoint">{URI}/{Division}/{Resource}/{Entity}</param>
        /// <returns>String with API Response in Json Format</returns>
        public string DoDeleteRequest(string endpoint)
		{
			if (string.IsNullOrEmpty(endpoint)) throw new ArgumentException("Cannot perform request with empty endpoint");

			var request = CreateRequest(endpoint, null, RequestTypeEnum.DELETE);

			Debug.Write("DELETE ");
			Debug.WriteLine(request.RequestUri);

			return GetResponse(request);
		}

        /// <summary>
        /// Delete entity: Perform a DELETE Request on API
        /// </summary>
        /// <param name="endpoint">{URI}/{Division}/{Resource}/{Entity}</param>
        /// <returns>String with API Response in Json Format</returns>
        public Task<string> DoDeleteRequestAsync(string endpoint)
        {
            if(string.IsNullOrEmpty(endpoint)) throw new ArgumentException("Cannot perform request with empty endpoint");

            var request = CreateRequest(endpoint, null, RequestTypeEnum.DELETE);

            Debug.Write("DELETE ");
            Debug.WriteLine(request.RequestUri);

            return GetResponseAsync(request);
        }

        /// <summary>
        /// Request without 'Accept' Header
        /// </summary>
        /// <param name="uri"></param>
        /// <returns></returns>
        public string DoCleanRequest(string uri) // Build for doing $count function
		{
			var request = (HttpWebRequest)WebRequest.Create(uri);
			request.ServicePoint.Expect100Continue = false;
			request.Method = RequestTypeEnum.GET.ToString();
			request.ContentType = "application/json";
			request.Headers.Add("Authorization", "Bearer " + _accessTokenDelegate());
			return GetResponse(request);
		}

        /// <summary>
        /// Request without 'Accept' Header
        /// </summary>
        /// <param name="uri"></param>
        /// <returns></returns>
        public Task<string> DoCleanRequestAsync(string uri) // Build for doing $count function
        {
            var request = (HttpWebRequest)WebRequest.Create(uri);
            request.ServicePoint.Expect100Continue = false;
            request.Method = RequestTypeEnum.GET.ToString();
            request.ContentType = "application/json";
            request.Headers.Add("Authorization", "Bearer " + _accessTokenDelegate());
            return GetResponseAsync(request);
        }

        public int GetCurrentDivision(string website)
		{
			var url = website + "/api/v1/current/Me";
			const string oDataQuery = "$select=CurrentDivision";

			var request = CreateRequest(url, oDataQuery, RequestTypeEnum.GET);
			var response = GetResponse(request);
			var jsonObject = JsonConvert.DeserializeObject<dynamic>(response);

			return (int)jsonObject.d["results"][0]["CurrentDivision"].Value;
		}

        public async Task<int> GetCurrentDivisionAsync(string website)
        {
            var url = website + "/api/v1/current/Me";
            const string oDataQuery = "$select=CurrentDivision";

            var request = CreateRequest(url, oDataQuery, RequestTypeEnum.GET);
            var response = await GetResponseAsync(request).ConfigureAwait(false);
            var jsonObject = JsonConvert.DeserializeObject<dynamic>(response);

            return (int)jsonObject.d["results"][0]["CurrentDivision"].Value;
        }

        #endregion

        #region Private methods

        private HttpWebRequest CreateRequest(string url, string oDataQuery, RequestTypeEnum method, string acceptContentType = "application/json")
		{
			if (!string.IsNullOrEmpty(oDataQuery))
			{
				url += "?" + oDataQuery;
			}

			var request = (HttpWebRequest)WebRequest.Create(url);
			request.ServicePoint.Expect100Continue = false;
			request.Method = method.ToString();
			request.ContentType = "application/json";
			if (!string.IsNullOrEmpty(acceptContentType))
			{
				request.Accept = acceptContentType;
			}
			request.Headers.Add("Authorization", "Bearer " + _accessTokenDelegate());

			return request;
		}

		private string GetResponse(HttpWebRequest request)
		{
			// Grab the response
			var responseValue = string.Empty;

			Debug.WriteLine("RESPONSE");

            WebResponse response = null;

			// Get response. If this fails: Throw the correct Exception (for testability)
			try
			{
				response = request.GetResponse();
                
				using (Stream responseStream = response.GetResponseStream())
				{
					if (responseStream != null)
					{
						var reader = new StreamReader(responseStream);
						responseValue = reader.ReadToEnd();
					}
				}
			}
			catch (WebException ex)
			{
                response = ex.Response;
                ThrowSpecificException(ex);

				throw;
			}
            finally
            {
                SetEolResponseHeaders(response);
            }

			Debug.WriteLine(responseValue);
			Debug.WriteLine("");

			return responseValue;
        }

        private async Task<string> GetResponseAsync(HttpWebRequest request)
        {
            // Grab the response
            var responseValue = string.Empty;

            Debug.WriteLine("RESPONSE");

            WebResponse response = null;

            // Get response. If this fails: Throw the correct Exception (for testability)
            try
            {
                response = await request.GetResponseAsync().ConfigureAwait(false);

                using( Stream responseStream = response.GetResponseStream() )
                {
                    if(responseStream != null)
                    {
                        var reader = new StreamReader( responseStream );
                        responseValue = await reader.ReadToEndAsync().ConfigureAwait(false);
                    }
                }
            }
            catch(WebException ex)
            {
                response = ex.Response;
                ThrowSpecificException(ex);

                throw;
            }
            finally
            {
                SetEolResponseHeaders(response);
            }

            Debug.WriteLine(responseValue);
            Debug.WriteLine("");

            return responseValue;
        }

        private void SetEolResponseHeaders(WebResponse response)
        {
            if (response == null)
            {
                return;
            }

            SetRateLimitHeaders(response);
        }

        private void SetRateLimitHeaders(WebResponse response)
        {
            _client.EolResponseHeader = new Models.EolResponseHeader
            {
                RateLimit = new Models.RateLimit
                {
                    Limit = response.Headers["X-RateLimit-Limit"].ToNullableInt(),
                    Remaining = response.Headers["X-RateLimit-Remaining"].ToNullableInt(),
                    Reset = response.Headers["X-RateLimit-Reset"].ToNullableLong()
                }
            };

            
        }
        
        private Stream GetResponseFile(HttpWebRequest request)
        {
            Debug.WriteLine("RESPONSE");
            WebResponse response = null;

            // Get response. If this fails: Throw the correct Exception (for testability)
            try
            {
                response = request.GetResponse();
                SetEolResponseHeaders(response);
                return response.GetResponseStream();
            }
            catch (WebException ex)
            {
                response = ex.Response;
                ThrowSpecificException(ex);
                throw;
            }
            finally
            {
                SetEolResponseHeaders(response);
            }

        }

        private async Task<Stream> GetResponseFileAsync(HttpWebRequest request)
        {
            Debug.WriteLine("RESPONSE");
            WebResponse response = null;

            // Get response. If this fails: Throw the correct Exception (for testability)
            try
            {
                response = await request.GetResponseAsync().ConfigureAwait(false);
                SetEolResponseHeaders(response);
                return response.GetResponseStream();
            }
            catch(WebException ex)
            {
                response = ex.Response;
                ThrowSpecificException(ex);
                throw;
            }
            finally
            {
                SetEolResponseHeaders(response);
            }

        }

        private void ThrowSpecificException(WebException ex)
        {
            var statusCode = (((HttpWebResponse)ex.Response).StatusCode);
            Debug.WriteLine(ex.Message);

            var messageFromServer = new StreamReader(ex.Response.GetResponseStream()).ReadToEnd();
            Debug.WriteLine(messageFromServer);
            Debug.WriteLine("");

            switch (statusCode)
            {
                case HttpStatusCode.BadRequest: // 400
                case HttpStatusCode.MethodNotAllowed: // 405
                    throw new BadRequestException(ex.Message, ex);

                case HttpStatusCode.Unauthorized: //401
                    throw new UnauthorizedException(ex.Message, ex); // 401

                case HttpStatusCode.Forbidden:
                    throw new ForbiddenException(ex.Message, ex); // 403

                case HttpStatusCode.NotFound:
                    throw new NotFoundException(ex.Message, ex); // 404

                case HttpStatusCode.InternalServerError: // 500
                    throw new InternalServerErrorException(messageFromServer, ex);

                case (HttpStatusCode)429: // 429: too many requests
                    throw new TooManyRequestsException(ex.Message, ex);
            }
        }


        /// <summary>
        /// Request without 'Accept' Header, including parameters
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="oDataQuery"></param>
        /// <returns></returns>
        public string DoCleanRequest(string uri, string oDataQuery)
		{
			if (string.IsNullOrEmpty(uri)) throw new ArgumentException("Cannot perform request with empty endpoint");

			var request = CreateRequest(uri, oDataQuery, RequestTypeEnum.GET, null);

			Debug.WriteLine("GET ");
			Debug.WriteLine(request.RequestUri);

			return GetResponse(request);
		}

        /// <summary>
        /// Request without 'Accept' Header, including parameters
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="oDataQuery"></param>
        /// <returns></returns>
        public Task<string> DoCleanRequestAsync(string uri, string oDataQuery)
        {
            if(string.IsNullOrEmpty(uri)) throw new ArgumentException("Cannot perform request with empty endpoint");

            var request = CreateRequest(uri, oDataQuery, RequestTypeEnum.GET, null);

            Debug.WriteLine("GET ");
            Debug.WriteLine(request.RequestUri);

            return GetResponseAsync(request);
        }
        #endregion

    }
}
