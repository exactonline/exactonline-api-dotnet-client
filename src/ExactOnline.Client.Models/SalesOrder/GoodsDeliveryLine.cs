namespace ExactOnline.Client.Models.SalesOrder
{
    using System;
    using System.Collections.Generic;

    [SupportedActionsSDK(true, true, true, false)]
    [DataServiceKey("ID")]
    public class GoodsDeliveryLine
    {
        /// <summary>Collection of batch numbers</summary>
        public IEnumerable<Inventory.StockBatchNumber> BatchNumbers { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>Date of goods delivery</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? DeliveryDate { get; set; }
        /// <summary>Description of sales order delivery</summary>
        public string Description { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>The EntryID identifies the goods delivery. All the lines of a goods delivery have the same EntryID</summary>
        public Guid? EntryID { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Reference to item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Item { get; set; }
        /// <summary>Item code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }
        /// <summary>Description of item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }
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
        public string ModifierFullName { get; set; }
        /// <summary>Notes</summary>
        public string Notes { get; set; }
        /// <summary>Quantity delivered</summary>
        public double? QuantityDelivered { get; set; }
        /// <summary>Quantity ordered</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? QuantityOrdered { get; set; }
        /// <summary>Reference to sales order</summary>
        public Guid? SalesOrderLineID { get; set; }
        /// <summary>Sales order line number</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? SalesOrderLineNumber { get; set; }
        /// <summary>Sales order number</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? SalesOrderNumber { get; set; }
        /// <summary>Collection of serial numbers</summary>
        public IEnumerable<Inventory.StockSerialNumber> SerialNumbers { get; set; }
        /// <summary>Reference to storage location</summary>
        public Guid? StorageLocation { get; set; }
        /// <summary>Storage location code</summary>
        public string StorageLocationCode { get; set; }
        /// <summary>Storage location description</summary>
        public string StorageLocationDescription { get; set; }
        /// <summary>Reference to tracking number</summary>
        public string TrackingNumber { get; set; }
        /// <summary>Code of item unit</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Unitcode { get; set; }
    }
}