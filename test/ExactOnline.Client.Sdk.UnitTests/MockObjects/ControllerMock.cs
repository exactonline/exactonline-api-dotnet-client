using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ExactOnline.Client.Sdk.Interfaces;

namespace ExactOnline.Client.Sdk.UnitTests.MockObjects
{
	public sealed class ControllerMock<T> : IController<T>
	{

		public int Count(string query)
		{
			return 0;
		}

		public string ODataQuery { get; set; }

		List<T> IController<T>.Get(string query)
		{
			ODataQuery = query;
			return null;
		}
		
		List<T> IController<T>.Get(string query, out Guid skipToken)
		{
			skipToken = Guid.Empty;
			ODataQuery = query;
			return null;
		}

		T IController<T>.GetEntity(string guid, string parameters)
		{

			throw new NotImplementedException();
		}

		bool IController<T>.Create(ref T entity)
		{
			return true;
		}

		bool IController<T>.Update(T entity)
		{
			return true;
		}

		bool IController<T>.Delete(T entity)
		{
			return true;
		}

		#region IController<T> Members


		public bool IsManagedEntity(T entity)
		{
			return true;
		}

		#endregion

		#region IController<T> Members


		public Task<List<T>> GetAsync(string query)
		{
			throw new NotImplementedException();
		}

		#endregion

		#region IController<T> Members


		public T GetEntity(string guid, string parameters)
		{
			throw new NotImplementedException();
		}

		public void RegistrateLinkedEntityField(string fieldname)
		{
		}

		#endregion
	}
}
