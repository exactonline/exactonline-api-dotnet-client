using System;
using System.Threading.Tasks;

namespace ExactOnline.Client.Sdk.Interfaces
{
	public interface IApiConnection
	{
		string Get(string parameters);
        Task<string> GetAsync(string parameters);

        string GetEntity(string keyname, string guid, string parameters);
        Task<string> GetEntityAsync(string keyname, string guid, string parameters);

        string Post(string data);
        Task<string> PostAsync(string data);

        Boolean Put(string keyName, string guid, string data);
        Task<Boolean> PutAsync(string keyName, string guid, string data);

        Boolean Delete(string keyName, string guid);
        Task<Boolean> DeleteAsync(string keyName, string guid);

        int Count(string parameters);
        Task<int> CountAsync(string parameters);

    }
}
