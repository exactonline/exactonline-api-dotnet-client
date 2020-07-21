namespace ExactOnline.Client.Sdk.Interfaces
{
    using System;
    using ExactOnline.Client.Sdk.Controllers;

    /// <summary>
    ///     Interface for classes that manage a collection of (linked) entities
    ///     This interface is used by the ControllerList class for 'GetEntityManager' method for fetching
    ///     the associated controller for a specific entity
    /// </summary>
    public interface IEntityManager
    {
        Boolean IsManagedEntity(object entity);

        Boolean AddEntityToManagedEntitiesCollection(object entity);

        EntityController GetEntityController(string guid);

        string GetIdentifierValue(object entity);
    }
}
