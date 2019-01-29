namespace ExactOnline.Client.Models.Manufacturing
{
    using System;

    [SupportedActionsSDK(true, true, false, false)]
    [DataServiceKey("ShopOrderReceiptStockTransactionId")]
    public class SubOrderReceipt
    {
        /// <summary>ID of creating user</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? CreatedBy { get; set; }
        /// <summary>Name of the creating user</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String CreatedByFullName { get; set; }
        /// <summary>Creation date of this SubOrderReceipt</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? CreatedDate { get; set; }
        /// <summary>Serial or batch numbers are reserved prior to a POST to SubOrderReceipt. This DraftStockTransactionID represents the group of serial or batch numbers to be used in this transaction.</summary>
        public Guid? DraftStockTransactionID { get; set; }
        /// <summary>Indicates if this SubOrderReceipt has a quantity eligible to be reversed via SubOrderReversals</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Boolean HasReversibleQuantity { get; set; }
        /// <summary>Does the SubOrderReceipt&apos;s item use batch numbers</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Byte? IsBatch { get; set; }
        /// <summary>Indicates if fractions (for example 0.35) are allowed for quantities of the SubOrderReceipt&apos;s item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Byte? IsFractionAllowedItem { get; set; }
        /// <summary>Does the SubOrderReceipt&apos;s item use serial numbers</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Byte? IsSerial { get; set; }
        /// <summary>Item of this SubOrderReceipt</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Item { get; set; }
        /// <summary>Code of this SubOrderReceipt&apos;s item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ItemCode { get; set; }
        /// <summary>Description of this SubOrderReceipt&apos;s item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ItemDescription { get; set; }
        /// <summary>Picture url of shop order item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ItemPictureUrl { get; set; }
        /// <summary>MaterialIssue.StockTransactionId related to this SubOrderReceipt</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? MaterialIssueStockTransactionId { get; set; }
        /// <summary>Shop order issued to</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? ParentShopOrder { get; set; }
        /// <summary>Shop order material plan issued to</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? ParentShopOrderMaterialPlan { get; set; }
        /// <summary>Number of shop order issued to</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? ParentShopOrderNumber { get; set; }
        /// <summary>Quantity of this SubOrderReceipt</summary>
        public Double? Quantity { get; set; }
        /// <summary>ShopOrderReceipt.StockTransactionId related to this SubOrderReceipt</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid ShopOrderReceiptStockTransactionId { get; set; }
        /// <summary>Shop order issued from</summary>
        public Guid? SubShopOrder { get; set; }
        /// <summary>Number of shop order issued from</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? SubShopOrderNumber { get; set; }
        /// <summary>Effective date of this SubOrderReceipt</summary>
        public DateTime? TransactionDate { get; set; }
        /// <summary>Unit of measurement abbreviation of this SubOrderReceipt&apos;s item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String Unit { get; set; }
        /// <summary>Unit of measurement of this SubOrderReceipt&apos;s item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String UnitDescription { get; set; }
        /// <summary>ID of warehouse SubOrderReceipt</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Warehouse { get; set; }
        /// <summary>Code of warehouse SubOrderReceipt</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String WarehouseCode { get; set; }
        /// <summary>Description of warehouse SubOrderReceipt</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String WarehouseDescription { get; set; }
    }
}