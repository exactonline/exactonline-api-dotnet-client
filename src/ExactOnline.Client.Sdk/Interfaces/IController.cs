using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExactOnline.Client.Sdk.Interfaces
{
	public interface IController<T>
	{
		List<T> Get(string query);

		List<T> Get(string query, out string token);

		T GetEntity(string guid, string parameters);

		Boolean Create(ref T entity);

		Boolean Update(T entity);

		Boolean Delete(T entity);

		int Count(string query); // For $count function API

		void RegistrateLinkedEntityField(string fieldname);
	}
}
