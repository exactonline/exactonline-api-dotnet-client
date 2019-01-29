using System;
using System.Collections.Generic;

namespace ExactOnline.Client.Models.Inventory
{
    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class StockCountLine
    {
        /// <summary>The collection of batch numbers that belong to the items included in this stock count</summary>
        public IEnumerable<ExactOnline.Client.Models.Inventory.StockBatchNumber> BatchNumbers { get; set; }
        /// <summary>Cost price of the item that is used to create the stock count</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? CostPrice { get; set; }
        /// <summary>Counted by</summary>
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
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Reference to the item for which the stock is counted</summary>
        public Guid? Item { get; set; }
        /// <summary>Item Barcode</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ItemBarcode { get; set; }
        /// <summary>Item code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ItemCode { get; set; }
        /// <summary>Current standard/actual item cost price</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? ItemCostPrice { get; set; }
        /// <summary>Description of item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ItemDescription { get; set; }
        /// <summary>Indicates if fractional quantities of the item can be used, for example quantity = 0.4</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Boolean? ItemDivisable { get; set; }
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
        /// <summary>The difference between the current quantity in stock and the new quantity in stock. For example specify -1 for this field to correct the quantity if one item in stock is broken.</summary>
        public Double? QuantityDifference { get; set; }
        /// <summary>The current quantity available in stock</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? QuantityInStock { get; set; }
        /// <summary>The new quantity in stock. Use this field to correct the quantity when the items in stock are physically counted.</summary>
        public Double? QuantityNew { get; set; }
        /// <summary>The collection of serial numbers that belong to the items included in this stock count</summary>
        public IEnumerable<ExactOnline.Client.Models.Inventory.StockSerialNumber> SerialNumbers { get; set; }
        /// <summary>Source of stock count entry: 1-Manual entry, 2-Import, 3-Stock count, 4-Web service</summary>
        public Int16? Source { get; set; }
        /// <summary>Stock count status: 12-Draft, 21-Processed</summary>
        public Int16? Status { get; set; }
        /// <summary>Identifies the stock count. All the lines of a stock count have the same StockCountID</summary>
        public Guid? StockCountID { get; set; }
        /// <summary>Stock item&apos;s unit description</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String StockKeepingUnit { get; set; }
        /// <summary>This property is package specific (Stock count can have multiple lines for the same item only if it is for multiple storage locations).</summary>
        public Guid? StorageLocation { get; set; }
        /// <summary>Storage location code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String StorageLocationCode { get; set; }
        /// <summary>Storage location description</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String StorageLocationDescription { get; set; }
        /// <summary>Warehouse</summary>
        public Guid? Warehouse { get; set; }
    }
}