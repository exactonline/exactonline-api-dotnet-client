using ExactOnline.Client.Sdk.Exceptions;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;

namespace ExactOnline.Client.Sdk.Helpers
{
	/// <summary>
	/// Class for stripping unnecessary Json tags from API Response
	/// </summary>
	public class ApiResponseCleaner
	{
		#region Public methods

		/// <summary>
		/// Fetch Json Object (Json within ['d'] name/value pair) from response
		/// </summary>
		/// <param name="response"></param>
		/// <returns></returns>
		public static string GetJsonObject(string response)
		{
			var oldCulture = Thread.CurrentThread.CurrentCulture;
			Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

			string output;
			try
			{
				var dict = (Dictionary<string, object>)JsonConvert.DeserializeObject<object>(response);
				var d = (Dictionary<string, object>)dict["d"];
				output = GetJsonFromDictionary(d);
			}
			finally
			{
				Thread.CurrentThread.CurrentCulture = oldCulture;
			}
			return output;
		}

		public static string GetSkipToken(string response)
		{
			var oldCulture = Thread.CurrentThread.CurrentCulture;
			Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
			string token = string.Empty;

			try
            {
                var dict = (Dictionary<string, object>)JsonConvert.DeserializeObject<object>(response);
                var innerPart = dict["d"];
				if (innerPart.GetType() == typeof(Dictionary<string, object>))
				{
					var d = (Dictionary<string, object>)dict["d"];
					if (d.ContainsKey("__next"))
					{
						var next = (string)d["__next"];

						// Skiptoken has format "$skiptoken=xyz" in the url and we want to extract xyz.
						var match = Regex.Match(next ?? "", @"\$skiptoken=([^&#]*)");

						// Extract the skip token
						token = match.Success ? match.Groups[1].Value : null;
					}
				}
			}
			catch (Exception e)
			{
				throw new IncorrectJsonException(e.Message);
			}
			finally
			{
				Thread.CurrentThread.CurrentCulture = oldCulture;
			}
			return token;
		}

		/// <summary>
		/// Fetch Json Array (Json within ['d']['results']) from response
		/// </summary>
		public static string GetJsonArray(string response)
		{

			var oldCulture = Thread.CurrentThread.CurrentCulture;
			Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

			try
			{
				ArrayList results;
                var dict = (Dictionary<string, object>)JsonConvert.DeserializeObject<object>(response);
                var innerPart = dict["d"];
				if (innerPart.GetType() == typeof(Dictionary<string, object>))
				{
					var d = (Dictionary<string, object>)dict["d"];
					results = (ArrayList)d["results"];
				}
				else
				{
					results = (ArrayList)innerPart;
				}
				return GetJsonFromResultDictionary(results);
			}
			catch (Exception e)
			{
				throw new IncorrectJsonException(e.Message);
			}
			finally
			{
				Thread.CurrentThread.CurrentCulture = oldCulture;
			}

		}

		#endregion

		#region Private methods

		/// <summary>
		/// Converts key/value pairs to json
		/// </summary>
		private static string GetJsonFromDictionary(Dictionary<string, object> dictionary)
		{
			string json = "{";

			foreach (var entry in dictionary)
			{
				if (entry.Value == null || entry.Value.GetType() != typeof(Dictionary<string, object>))
				{
					// Entry is of type keyvaluepair
					json += "\"" + entry.Key + "\":";
					if (entry.Value == null)
					{
						json += "null";
					}
					else
					{
						json += JsonConvert.ToString(entry.Value.ToString());
					}
					json += ",";
				}
				else
				{
					// Create linked entities json
					var subcollection = (Dictionary<string, object>)entry.Value;
					if (subcollection.Keys.Contains("results"))
					{
						var results = (ArrayList)subcollection["results"];
						string subjson = GetJsonFromResultDictionary(results);
						if (subjson.Length > 0)
						{
							json += "\"" + entry.Key + "\":";
							json += subjson;
							json += ",";
						}
					}
				}
			}

			json = json.Remove(json.Length - 1, 1); // Remove last comma
			json += "}";

			return json;
		}

		private static string GetJsonFromResultDictionary(ArrayList results)
		{
			string json = "[";
			if (results != null && results.Count > 0)
			{
				foreach (Dictionary<string, object> entity in results)
				{
					json += GetJsonFromDictionary(entity) + ",";
				}

				json = json.Remove(json.Length - 1, 1); // Remove last comma
			}
			json += "]";
			return json;
		}

		#endregion

	}
}
