namespace ExactOnline.Client.Models.PurchaseOrder
{
    using System;
    using System.Collections.Generic;

    [SupportedActionsSDK(true, true, false, false)]
    [DataServiceKey("ID")]
    public class GoodsReceiptLine
    {
        /// <summary>Collection of batch numbers</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public IEnumerable<Inventory.StockBatchNumber> BatchNumbers { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        /// <summary>User ID of the creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of the creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>Goods receipt line description</summary>
        public string Description { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        /// <summary>All the lines of a goods receipt have the same GoodsReceiptID</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? GoodsReceiptID { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>ID of the received item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Item { get; set; }
        /// <summary>Code of the received item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }
        /// <summary>Item description</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }
        /// <summary>Unit code of the purchase</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemUnitCode { get; set; }
        /// <summary>Line number</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 LineNumber { get; set; }
        /// <summary>ID of the storage location in the warehouse where the item is received</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Location { get; set; }
        /// <summary>Code of the storage location in the warehouse where the item is received</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string LocationCode { get; set; }
        /// <summary>Description of the storage location in the warehouse where the item is received</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string LocationDescription { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        /// <summary>User ID of the last modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of the last modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>Notes</summary>
        public string Notes { get; set; }
        /// <summary>Reference to project</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Project { get; set; }
        /// <summary>Project code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectCode { get; set; }
        /// <summary>Project description</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }
        /// <summary>Reference to purchase order</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid PurchaseOrderID { get; set; }
        /// <summary>ID of the purchase order line that is received</summary>
        public Guid? PurchaseOrderLineID { get; set; }
        /// <summary>Order number of the purchase order that is received</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 PurchaseOrderNumber { get; set; }
        /// <summary>Quantity ordered</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? QuantityOrdered { get; set; }
        /// <summary>Quantity received</summary>
        public double? QuantityReceived { get; set; }
        /// <summary>Collection of serial numbers</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public IEnumerable<Inventory.StockSerialNumber> SerialNumbers { get; set; }
        /// <summary>Supplier item code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SupplierItemCode { get; set; }
    }
}