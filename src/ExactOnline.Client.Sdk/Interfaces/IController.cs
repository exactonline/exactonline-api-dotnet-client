using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExactOnline.Client.Sdk.Interfaces
{
	public interface IController<T>
	{
        Task<Tuple<string, List<T>>> GetAsync(string query, string skipToken);
        List<T> Get(string query);

        Task<T> GetEntityAsync(string guid, string parameters);
        T GetEntity(string guid, string parameters);

        Task<Tuple<Boolean, T>> CreateAsync(T entity);
        Boolean Create(ref T entity);

        Task<Boolean> UpdateAsync(T entity);
        Boolean Update(T entity);

        Task<Boolean> DeleteAsync(T entity);
        Boolean Delete(T entity);

		int Count(string query); // For $count function API

		void RegistrateLinkedEntityField(string fieldname);

		List<T> Get(string query, ref string skipToken);
	}
}
