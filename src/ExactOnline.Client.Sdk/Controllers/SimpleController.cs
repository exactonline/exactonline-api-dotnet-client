namespace ExactOnline.Client.Sdk.Controllers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using ExactOnline.Client.Sdk.Helpers;

    /// <summary>
    ///     Lets the developer get dynamic objects with output from the API
    /// </summary>
    public class SimpleController
    {
        private readonly ApiConnection _conn;

        /// <summary>
        ///     Create new instance of AccountController
        /// </summary>
        public SimpleController(ApiConnection conn)
        {
            _conn = conn;
        }

        /// <summary>
        ///     Returns a list of dynamic objects
        /// </summary>
        /// <param name="query">oData query</param>
        /// <returns></returns>
        public List<dynamic> GetDynamic(string query)
        {
            var response = _conn.Get(query);
            response = ApiResponseCleaner.GetJsonArray(response);

            var converter = new EntityConverter();
            return converter.ConvertJsonToDynamicObjectList(response);
        }

        /// <summary>
        ///     Returns a list of dynamic objects
        /// </summary>
        /// <param name="query">oData query</param>
        /// <returns></returns>
        public async Task<List<dynamic>> GetDynamicAsync(string query)
        {
            var response = await _conn.GetAsync(query).ConfigureAwait(false);
            response = ApiResponseCleaner.GetJsonArray(response);

            var converter = new EntityConverter();
            return converter.ConvertJsonToDynamicObjectList(response);
        }
    }
}
