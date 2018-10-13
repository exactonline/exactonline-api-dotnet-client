using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExactOnline.Client.Sdk.Delegates;
using ExactOnline.Client.Sdk.Exceptions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ExactOnline.Client.Sdk.Helpers
{
    /// <summary>
    /// Convert entities from json to Exact Online object and vice versa
    /// </summary>
    public class EntityConverter
    {
        /// <summary>
        /// Convert single object to Dynamic object
        /// </summary>
        public dynamic ConvertJsonToDynamicObject(string json)
        {
            try
            {
                var dynamicObject = JsonConvert.DeserializeObject<dynamic>(json);
                return dynamicObject;
            }
            catch
            {
                throw new IncorrectJsonException();
            }
        }

        /// <summary>
        /// Convert multiple objects to List of Dynamic objects
        /// </summary>
        public List<dynamic> ConvertJsonToDynamicObjectList(string json)
        {
            try
            {
                JArray x = JsonConvert.DeserializeObject<dynamic>(json);
                List<dynamic> list = x.ToList<dynamic>();
                return list;
            }
            catch
            {
                throw new IncorrectJsonException();
            }
        }

        /// <summary>
        /// Converts Dynamic Object to Json String
        /// </summary>
        /// <param name="obj">Dynamic Object to Convert</param>
        /// <returns>Json String</returns>
        public string ConvertDynamicObjectToJson(dynamic obj)
        {
            string json = JsonConvert.SerializeObject(obj);
            return json;
        }

        /// <summary>
        /// Converts an Exact Online Object to Json
        /// </summary>
        /// <typeparam name="T">Type of Exact.Web.Api.Models</typeparam>
        /// <param name="entity">entity</param>
        /// <param name="entityControllerDelegate">Delegate for entitycontroller</param>
        /// <returns>Json String</returns>
        public string ConvertObjectToJson<T>(T entity, GetEntityController entityControllerDelegate)
        {
            var converter = new ExactOnlineJsonConverter();
            var converters = new JsonConverter[1];
            converters[0] = converter;

            return JsonConvert.SerializeObject(entity, converters);
        }

        /// <summary>
        /// Converts an Object to Json for Updating
        /// The method creates Json using the original entity 
        /// and the current entity to create Json only for altered fields
        /// </summary>
        /// <typeparam name="T">Type of Exact.Web.Api.Models</typeparam>
        /// <param name="originalEntity">Original State of the Entity</param>
        /// <param name="entity">Current State of the Entity</param>
        /// <param name="entityControllerDelegate">Delegate for entitycontroller</param>
        /// <returns>Json String</returns>
        public string ConvertObjectToJson<T>(T originalEntity, T entity, GetEntityController entityControllerDelegate)
        {
            var converter = new ExactOnlineJsonConverter(originalEntity, entityControllerDelegate);
            var converters = new JsonConverter[1];
            converters[0] = converter;

            return JsonConvert.SerializeObject(entity, converters);
        }

        /// <summary>
        /// Convert Json to Exact Online Object
        /// </summary>
        /// <typeparam name="T">Type of Exact.Web.Api.Models</typeparam>
        /// <param name="json">Json String</param>
        /// <returns>Exact Online Object</returns>
        public T ConvertJsonToObject<T>(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(json);
            }
            catch (Exception)
            {
                throw new IncorrectJsonException();
            }
        }
        /// <summary>
		/// Convert Json Array To Object List in asynchronous way
		/// </summary>
		/// <typeparam name="T">Specifies the type</typeparam>
		/// <param name="json">Json Array</param>
		/// <returns>List of specified type</returns>
		public async Task<List<T>> ConvertJsonArrayToObjectListAsync<T>(string json)
        {
            try
            {
                var returnList = await Task.Factory.StartNew(() => JsonConvert.DeserializeObject<List<T>>(json));
                return returnList;
            }
            catch (Exception)
            {
                throw new IncorrectJsonException("An error occurred while processing the json string. Possibly the result is too big. Please make a more specific query.");
            }
        }
        /// <summary>
        /// Convert Json Array To Object List
        /// </summary>
        /// <typeparam name="T">Specifies the type</typeparam>
        /// <param name="json">Json Array</param>
        /// <returns>List of specified type</returns>
        public List<T> ConvertJsonArrayToObjectList<T>(string json)
        {
            try
            {
                var returnList = JsonConvert.DeserializeObject<List<T>>(json);
                return returnList;
            }
            catch (Exception)
            {
                throw new IncorrectJsonException("An error occurred while processing the json string. Possibly the result is too big. Please make a more specific query.");
            }
        }

    }

}
