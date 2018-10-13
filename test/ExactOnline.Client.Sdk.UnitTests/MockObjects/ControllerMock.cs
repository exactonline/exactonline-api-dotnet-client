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

        public string ODataQuery { get; set; }

        List<T> IController<T>.Get(string query)
        {
            ODataQuery = query;
            return null;
        }
        public Task<List<T>> GetAsync(string query)
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




        #endregion

        #region IController<T> Members


        public T GetEntity(string guid, string parameters)
        {
            throw new NotImplementedException();
        }

        public void RegistrateLinkedEntityField(string fieldname)
        {
        }

        public Task<Tuple<string, List<T>>> GetAsync(string query, string skipToken)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetEntityAsync(string guid, string parameters)
        {
            throw new NotImplementedException();
        }

        public Task<Tuple<bool, T>> CreateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
