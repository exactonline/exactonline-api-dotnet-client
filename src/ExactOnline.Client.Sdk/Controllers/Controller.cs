﻿namespace ExactOnline.Client.Sdk.Controllers
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Threading.Tasks;
    using ExactOnline.Client.Sdk.Delegates;
    using ExactOnline.Client.Sdk.Helpers;
    using ExactOnline.Client.Sdk.Interfaces;
    using ExactOnline.Client.Sdk.Models;

    /// <summary>
    ///     Class for managing entity Objects (Read, Get, Update & Delete)
    /// </summary>
    public class Controller<T> : IController<T>, IEntityManager where T : class
    {
        private readonly IApiConnection _conn;
        private readonly GetEntityController _entityControllerDelegate;
        private readonly Hashtable _entityControllers;
        private readonly string _keyname;
        private string _expandfield;
        public ManagerForEntity GetManagerForEntity;

        /// <summary>
        ///     Create new instance of the controller
        /// </summary>
        public Controller(IApiConnection conn)
        {
            // Instantiate the class variables
            _entityControllers = new Hashtable();
            _conn = conn ?? throw new ArgumentException("Instance of type APIConnection cannot be null");

            // Set key name of the entity (name of the field that is used to identify)
            var attributes = Attribute
                .GetCustomAttributes(typeof(T)).Where(x => x.GetType() == typeof(DataServiceKey))
                .Select(a => a); //DataServiceKey

            // Find unique value of entity
            var enumerable = attributes as IList<Attribute> ?? attributes.ToList();
            if (enumerable.Count == 0)
            {
                throw new Exception("Cannot find 'DataServiceKey' field. This entity cannot be managed by the Controller");
            }

            var key = (DataServiceKey)enumerable[0];
            _keyname = key.DataServiceKeyName;
            _entityControllerDelegate = GetEntityController;
        }

        /// <summary>
        ///     Returns the number of entities of the current type
        /// </summary>
        public int Count(string query)
        {
            return _conn.Count(query);
        }

        /// <summary>
        ///     Returns the number of entities of the current type
        /// </summary>
        public Task<int> CountAsync(string query)
        {
            return _conn.CountAsync(query);
        }

        /// <summary>
        ///     Gets specific collection of entities.
        ///     Please notice that this method will return at max 60 entities.
        /// </summary>
        /// <param name="query">oData query</param>
        /// <returns>List of entity Objects</returns>
        public List<T> Get(string query)
        {
            var skipToken = string.Empty;
            return Get(query, ref skipToken);
        }

        /// <summary>
        ///     Gets specific collection of entities and return a skipToken if there are more than
        ///     60 entities to be returned.
        /// </summary>
        /// <param name="query">oData query</param>
        /// <param name="skipToken">The skip token to be used to get the next page of data.</param>
        /// <returns>List of entity Objects</returns>
        public List<T> Get(string query, ref string skipToken)
        {
            // Get the response and convert it to a list of entities of the specific type
            var response = _conn.Get(query);

            skipToken = ApiResponseCleaner.GetSkipToken(response);
            response = ApiResponseCleaner.GetJsonArray(response);

            var rc = new EntityConverter();
            var entities = rc.ConvertJsonArrayToObjectList<T>(response);

            // If the entity isn't managed already, register to managed entity collection
            foreach (var entity in entities)
            {
                AddEntityToManagedEntitiesCollection(entity);
            }

            // Convert list
            return entities.ConvertAll(x => x);
        }

        /// <summary>
        ///     Gets specific collection of entities and return a skipToken if there are more than
        ///     60 entities to be returned.
        /// </summary>
        /// <param name="query">oData query</param>
        /// <returns>List of entity Objects</returns>
        public async Task<ApiList<T>> GetAsync(string query)
        {
            // Get the response and convert it to a list of entities of the specific type
            var response = await _conn.GetAsync(query).ConfigureAwait(false);

            var skipToken = ApiResponseCleaner.GetSkipToken(response);
            response = ApiResponseCleaner.GetJsonArray(response);

            var rc = new EntityConverter();
            var entities = rc.ConvertJsonArrayToObjectList<T>(response);

            // If the entity isn't managed already, register to managed entity collection
            foreach (var entity in entities)
            {
                AddEntityToManagedEntitiesCollection(entity);
            }

            // Convert list
            return new ApiList<T>(entities.ConvertAll(x => x), skipToken);
        }

        /// <summary>
        ///     Get entity using specific GUID
        /// </summary>
        /// <param name="guid">Global Unique Identifier of the entity</param>
        /// <param name="parameters">parameters</param>
        /// <returns>Entity if exists. Null if entity not exists.</returns>
        public T GetEntity(string guid, string parameters)
        {
            if (guid.Contains('}') || guid.Contains('{'))
            {
                throw new Exception("Bad Guid: Guid cannot contain '}' or '{'");
            }

            // Convert the response to an object of the specific type
            var response = _conn.GetEntity(_keyname, guid, parameters);
            response = ApiResponseCleaner.GetJsonObject(response);
            var ec = new EntityConverter();
            var entity = ec.ConvertJsonToObject<T>(response);

            // If entity isn't managed already, add entity to EntityController
            AddEntityToManagedEntitiesCollection(entity);
            return entity;
        }

        /// <summary>
        ///     Get entity using specific GUID
        /// </summary>
        /// <param name="guid">Global Unique Identifier of the entity</param>
        /// <param name="parameters">parameters</param>
        /// <returns>Entity if exists. Null if entity not exists.</returns>
        public async Task<T> GetEntityAsync(string guid, string parameters)
        {
            if (guid.Contains('}') || guid.Contains('{'))
            {
                throw new Exception("Bad Guid: Guid cannot contain '}' or '{'");
            }

            // Convert the response to an object of the specific type
            var response = await _conn.GetEntityAsync(_keyname, guid, parameters).ConfigureAwait(false);
            response = ApiResponseCleaner.GetJsonObject(response);
            var ec = new EntityConverter();
            var entity = ec.ConvertJsonToObject<T>(response);

            // If entity isn't managed already, add entity to EntityController
            AddEntityToManagedEntitiesCollection(entity);
            return entity;
        }

        /// <summary>
        ///     Creates an entity in Exact Online
        /// </summary>
        /// <param name="entity">Entity to create</param>
        /// <returns>True if succeed</returns>
        public Boolean Create(ref T entity)
        {
            var supportedActions = GetSupportedActions(entity);
            if (!supportedActions.CanCreate)
            {
                throw new Exception(
                    "Cannot create entity. Entity does not support creation. Please see the Reference Documentation.");
            }

            // Get Json code
            var created = false;
            var converter = new EntityConverter();
            var emptyEntity = Activator.CreateInstance<T>();
            var json = converter.ConvertObjectToJson(emptyEntity, entity, _entityControllerDelegate);

            // Send to API
            var response = _conn.Post(json);
            if (!response.Contains("error"))
            {
                created = true;

                // Set values of API in account entity (to ensure GUID is set)
                response = ApiResponseCleaner.GetJsonObject(response);
                var ec = new EntityConverter();
                entity = ec.ConvertJsonToObject<T>(response);

                // Try to add the entity to the managed entities collections
                if (!AddEntityToManagedEntitiesCollection(entity))
                {
                    throw new Exception("This entity already exists");
                }

                // Check if the endpoint supports a read action. Some endpoints such as PrintQuotation only support create (POST).
                if (supportedActions.CanRead)
                {
                    // Get entity with linked entities (API Response for creating does not return the linked entities)
                    entity = GetEntity(GetIdentifierValue(entity), _expandfield);
                }
            }

            return created;
        }

        /// <summary>
        ///     Creates an entity in Exact Online
        /// </summary>
        /// <param name="entity">Entity to create</param>
        /// <returns>The created entity if succeed</returns>
        public async Task<T> CreateAsync(T entity)
        {
            var supportedActions = GetSupportedActions(entity);
            if (!supportedActions.CanCreate)
            {
                throw new Exception(
                    "Cannot create entity. Entity does not support creation. Please see the Reference Documentation.");
            }

            // Get Json code
            var converter = new EntityConverter();
            var emptyEntity = Activator.CreateInstance<T>();
            var json = converter.ConvertObjectToJson(emptyEntity, entity, _entityControllerDelegate);

            // Send to API
            var response = await _conn.PostAsync(json).ConfigureAwait(false);
            if (!response.Contains("error"))
            {
                // Set values of API in account entity (to ensure GUID is set)
                response = ApiResponseCleaner.GetJsonObject(response);
                var ec = new EntityConverter();
                var createdEntity = ec.ConvertJsonToObject<T>(response);

                // Try to add the entity to the managed entities collections
                if (!AddEntityToManagedEntitiesCollection(createdEntity))
                {
                    throw new Exception("This entity already exists");
                }

                // Check if the endpoint supports a read action. Some endpoints such as PrintQuotation only support create (POST).
                if (supportedActions.CanRead)
                {
                    // Get entity with linked entities (API Response for creating does not return the linked entities)
                    createdEntity = await GetEntityAsync(GetIdentifierValue(createdEntity), _expandfield).ConfigureAwait(false);
                }

                return createdEntity;
            }

            throw new Exception("Response contains error.");
        }

        /// <summary>
        ///     Updates an entity in Exact Online
        /// </summary>
        /// <param name="entity">Entity to update</param>
        /// <returns>True if succeeded</returns>
        public Boolean Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentException("Controller Update: Entity cannot be null");
            }

            // Check if entity can be updated
            if (!IsUpdateable(entity))
            {
                throw new Exception(
                    "Cannot update entity. Entity is not updateable. Please see the Reference Documentation.");
            }

            var associatedController = (EntityController)_entityControllers[GetIdentifierValue(entity)];
            if (associatedController == null)
            {
                throw new Exception("Entity identifier value not found");
            }

            return associatedController.Update(entity);
        }

        /// <summary>
        ///     Updates an entity in Exact Online
        /// </summary>
        /// <param name="entity">Entity to update</param>
        /// <returns>True if succeeded</returns>
        public Task<Boolean> UpdateAsync(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentException("Controller Update: Entity cannot be null");
            }

            // Check if entity can be updated
            if (!IsUpdateable(entity))
            {
                throw new Exception(
                    "Cannot update entity. Entity is not updateable. Please see the Reference Documentation.");
            }

            var associatedController = (EntityController)_entityControllers[GetIdentifierValue(entity)];
            if (associatedController == null)
            {
                throw new Exception("Entity identifier value not found");
            }

            return associatedController.UpdateAsync(entity);
        }

        /// <summary>
        ///     Deletes an entity from Exact Online
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>True if succeeded</returns>
        public Boolean Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentException("Controller Delete: Entity cannot be null");
            }

            // Check if entity can be deleted
            if (!IsDeleteable(entity))
            {
                throw new Exception(
                    "Cannot delete entity. Entity does not support deleting. Please see the Reference Documentation.");
            }

            // Delete entity
            var entityIdentifier = GetIdentifierValue(entity);
            var associatedController = (EntityController)_entityControllers[entityIdentifier];

            var returnValue = false;
            if (associatedController.Delete())
            {
                returnValue = true;
                _entityControllers.Remove(entityIdentifier);
            }

            return returnValue;
        }

        /// <summary>
        ///     Deletes an entity from Exact Online
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>True if succeeded</returns>
        public async Task<Boolean> DeleteAsync(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentException("Controller Delete: Entity cannot be null");
            }

            // Check if entity can be deleted
            if (!IsDeleteable(entity))
            {
                throw new Exception(
                    "Cannot delete entity. Entity does not support deleting. Please see the Reference Documentation.");
            }

            // Delete entity
            var entityIdentifier = GetIdentifierValue(entity);
            var associatedController = (EntityController)_entityControllers[entityIdentifier];

            var returnValue = false;
            if (await associatedController.DeleteAsync().ConfigureAwait(false))
            {
                returnValue = true;
                _entityControllers.Remove(entityIdentifier);
            }

            return returnValue;
        }

        /// <summary>
        ///     Registers a linked entity field so the Controller knows the field to Expand
        /// </summary>
        public void RegistrateLinkedEntityField(string fieldname)
        {
            _expandfield = fieldname;
        }

        /// <summary>
        ///     Returns if the specified entity is managed by the controller
        /// </summary>
        public Boolean IsManagedEntity(object entity)
        {
            return _entityControllers.Contains(GetIdentifierValue(entity));
        }

        /// <summary>
        ///     Get the unique value of the entity
        /// </summary>
        public string GetIdentifierValue(object entity)
        {
            if (_keyname.Contains(","))
            {
                throw new Exception("Currently the SDK doesn't support entities with a compound key.");
            }

            return entity.GetType().GetProperty(_keyname)?.GetValue(entity).ToString();
        }

        /// <summary>
        ///     Adds an associated instance of the EntityController class to the _controllers if the entity is not yet managed
        /// </summary>
        public Boolean AddEntityToManagedEntitiesCollection(object entity)
        {
            var returnValue = false;
            var entityIdentifier = GetIdentifierValue(entity);
            if (!_entityControllers.Contains(entityIdentifier))
            {
                var newController = new EntityController(entity, _keyname, GetIdentifierValue(entity), _conn,
                    _entityControllerDelegate);
                _entityControllers.Add(entityIdentifier, newController);

                returnValue = true;

                // Get linked entity fields
                var linkedEntityFields = from property in entity.GetType().GetProperties()
                    let ns = property.GetValue(entity)?.GetType().Namespace
                    where ns != null && property.GetValue(entity) != null && ns.Contains("System.Collections.Generic")
                    select property.GetValue(entity);

                // Get associated controller & registers entity
                foreach (var field in linkedEntityFields)
                {
                    foreach (var linkedEntity in (IEnumerable)field)
                    {
                        if (GetManagerForEntity != null)
                        {
                            var controller = GetManagerForEntity(linkedEntity.GetType());
                            controller.AddEntityToManagedEntitiesCollection(linkedEntity);
                        }
                        else
                        {
                            throw new Exception("Cannot register linked entity: Specific delegate is not set.");
                        }
                    }
                }
            }

            return returnValue;
        }

        public EntityController GetEntityController(string guid)
        {
            return (EntityController)_entityControllers[guid];
        }

        private static Boolean IsUpdateable(T entity)
        {
            return GetSupportedActions(entity).CanUpdate;
        }

        private static Boolean IsDeleteable(T entity)
        {
            return GetSupportedActions(entity).CanDelete;
        }

        private static SupportedActionsSDK GetSupportedActions(T entity)
        {
            return (SupportedActionsSDK)entity.GetType().GetCustomAttribute(typeof(SupportedActionsSDK)) ?? new SupportedActionsSDK(false, false, false, false);
        }

        /// <summary>
        ///     Method for returning the correct EntityController
        ///     This method is used as a delegate, so that ExactOnlineJsonConverter
        ///     knows the associated EntityController of a Linked Entity so it can perform
        ///     methods on the EntityController to see if the entity is updated
        /// </summary>
        public EntityController GetEntityController(object o)
        {
            var associatedController = GetManagerForEntity(o.GetType());
            var id = associatedController.GetIdentifierValue(o);
            return associatedController.GetEntityController(id);
        }
    }
}
