using System.IO;
using System.Threading.Tasks;

namespace ExactOnline.Client.Sdk.Interfaces
{
    public interface IApiConnector
    {
        string DoGetRequest(string endpoint, string parameters);
        Task<string> DoGetRequestAsync(string endpoint, string parameters);
        Stream DoGetFileRequest(string endpoint);
        Task<Stream> DoGetFileRequestAsync(string endpoint);


        string DoPostRequest(string endpoint, string postdata);
        Task<string> DoPostRequestAsync(string endpoint, string postdata);

        string DoPutRequest(string endpoint, string putData);
        Task<string> DoPutRequestAsync(string endpoint, string putData);

        string DoDeleteRequest(string endpoint);
        Task<string> DoDeleteRequestAsync(string endpoint);

        string DoCleanRequest(string uri); // Request without Content-Type for $count function
        Task<string> DoCleanRequestAsync(string uri); // Request without Content-Type for $count function
        string DoCleanRequest(string uri, string oDataQuery); // Request without Content-Type for $count function, including parameters
        Task<string> DoCleanRequestAsync(string uri, string oDataQuery); // Request without Content-Type for $count function, including parameters

        int GetCurrentDivision(string website);
        Task<int> GetCurrentDivisionAsync(string website);
    }
}
