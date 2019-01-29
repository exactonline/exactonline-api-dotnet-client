using System;

namespace ExactOnline.Client.Models.Inventory
{
    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class StorageLocation
    {
        /// <summary>Code of the storage location</summary>
        public String Code { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String CreatorFullName { get; set; }
        /// <summary>Description of the storage location</summary>
        public String Description { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Indicates if this is the main storage location. There&apos;s always exactly one main storage location per warehouse</summary>
        public Byte? Main { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ModifierFullName { get; set; }
        /// <summary>Warehouse ID</summary>
        public Guid? Warehouse { get; set; }
        /// <summary>Warehouse Code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String WarehouseCode { get; set; }
        /// <summary>Description of warehouse</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String WarehouseDescription { get; set; }
    }
}