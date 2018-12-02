using ExactOnline.Client.Sdk.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExactOnline.Client.Sdk.UnitTests.MockObjects
{
	public sealed class ControllerMock<T> : IController<T>
	{

		public int Count(string query)
		{
			return 0;
		}

        public Task<int> CountAsync(string query)
        {
            return Task.FromResult(Count(query));
        }

        public string ODataQuery { get; set; }

		List<T> IController<T>.Get(string query)
		{
			ODataQuery = query;
			return null;
		}

		public List<T> Get(string query, ref string skipToken)
		{
			skipToken = null;
			ODataQuery = query;
			return null;
		}

        public Task<Models.ApiList<T>> GetAsync(string query)
        {
            ODataQuery = query;
            return Task.FromResult(new Models.ApiList<T>(null,null));
        }

        T IController<T>.GetEntity(string guid, string parameters)
		{

			throw new NotImplementedException();
		}

        public Task<T> GetEntityAsync(string guid, string parameters)
        {
            return Task.FromResult(GetEntity(guid,parameters));
        }

        bool IController<T>.Create(ref T entity)
		{
			return true;
		}

        Task<T> IController<T>.CreateAsync(T entity)
        {
            return Task.FromResult(entity);
        }

        bool IController<T>.Update(T entity)
		{
			return true;
		}

        Task<bool> IController<T>.UpdateAsync(T entity)
        {
            return Task.FromResult((this as IController<T>).Update(entity));
        }

        bool IController<T>.Delete(T entity)
		{
			return true;
		}

        Task<bool> IController<T>.DeleteAsync(T entity)
        {
            return Task.FromResult((this as IController<T>).Delete(entity));
        }

        #region IController<T> Members


        public bool IsManagedEntity(T entity)
		{
			return true;
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
