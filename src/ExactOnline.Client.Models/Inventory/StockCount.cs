using global::System;
using global::System.Collections.Generic;

namespace ExactOnline.Client.Models.Inventory
{
    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("StockCountID")]
    public class StockCount
    {
        /// <summary>Stock count user</summary>
        public Guid? CountedBy { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String CreatorFullName { get; set; }
        /// <summary>Description of the stock count</summary>
        public String Description { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Entry number of the stock transaction</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? EntryNumber { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ModifierFullName { get; set; }
        /// <summary>Offset GL account of inventory</summary>
        public Guid? OffsetGLInventory { get; set; }
        /// <summary>GLAccount code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String OffsetGLInventoryCode { get; set; }
        /// <summary>GLAccount description</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String OffsetGLInventoryDescription { get; set; }
        /// <summary>Source of stock count entry: 1-Manual entry, 2-Import, 3-Stock count, 4-Web service</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int16? Source { get; set; }
        /// <summary>Stock count status: 12-Draft, 21-Processed</summary>
        public Int16? Status { get; set; }
        /// <summary>Stock count date</summary>
        public DateTime? StockCountDate { get; set; }
        /// <summary>Primary key</summary>
        public Guid StockCountID { get; set; }
        /// <summary>Collection of stock count lines</summary>
        public IEnumerable<ExactOnline.Client.Models.Inventory.StockCountLine> StockCountLines { get; set; }
        /// <summary>Human readable id of the stock count</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? StockCountNumber { get; set; }
        /// <summary>Warehouse</summary>
        public Guid? Warehouse { get; set; }
        /// <summary>Code of Warehouse</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String WarehouseCode { get; set; }
        /// <summary>Description of Warehouse</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String WarehouseDescription { get; set; }
    }
}