using System.IO;
using System.Threading.Tasks;

namespace ExactOnline.Client.Sdk.Interfaces
{
    public interface IApiConnector
    {
        Task<string> DoGetRequestAsync(string endpoint, string parameters);
        string DoGetRequest(string endpoint, string parameters);

        Task<Stream> DoGetFileRequestAsync(string endpoint);
        Stream DoGetFileRequest(string endpoint);

        Task<string> DoPostRequestAsync(string endpoint, string postdata);
        string DoPostRequest(string endpoint, string postdata);

        Task<string> DoPutRequestAsync(string endpoint, string putData);
        string DoPutRequest(string endpoint, string putData);

        Task<string> DoDeleteRequestAsync(string endpoint);
        string DoDeleteRequest(string endpoint);

        Task<string> DoCleanRequestAsync(string uri); // Request without Content-Type for $count function
        string DoCleanRequest(string uri); // Request without Content-Type for $count function

        Task<string> DoCleanRequestAsync(string uri, string oDataQuery); // Request without Content-Type for $count function, including parameters
        string DoCleanRequest(string uri, string oDataQuery); // Request without Content-Type for $count function, including parameters

        int GetCurrentDivision(string website);
    }
}
