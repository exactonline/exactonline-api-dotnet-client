using System;

namespace ExactOnline.Client.Models.Inventory
{
    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class WarehouseTransferLine
    {
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String CreatorFullName { get; set; }
        /// <summary>Description</summary>
        public String Description { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Item ID</summary>
        public Guid? Item { get; set; }
        /// <summary>Code of item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ItemCode { get; set; }
        /// <summary>Description of item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ItemDescription { get; set; }
        /// <summary>Line number</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? LineNumber { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ModifierFullName { get; set; }
        /// <summary>Quantity of transfer</summary>
        public Double? Quantity { get; set; }
        /// <summary>ID of storage location to transfer item from (Premium Only)</summary>
        public Guid? StorageLocationFrom { get; set; }
        /// <summary>Code of storage location to transfer item from</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String StorageLocationFromCode { get; set; }
        /// <summary>Description of storage location to transfer item from</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String StorageLocationFromDescription { get; set; }
        /// <summary>ID of storage location to transfer item to (Premium Only)</summary>
        public Guid? StorageLocationTo { get; set; }
        /// <summary>Code of storage location to transfer item to</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String StorageLocationToCode { get; set; }
        /// <summary>Description of storage location to transfer item to</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String StorageLocationToDescription { get; set; }
        /// <summary>Entry number of the stock transaction</summary>
        public Guid? TransferID { get; set; }
        /// <summary>The standard unit code of this item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String UnitCode { get; set; }
        /// <summary>Description of item&apos;s unit</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String UnitDescription { get; set; }
    }
}
