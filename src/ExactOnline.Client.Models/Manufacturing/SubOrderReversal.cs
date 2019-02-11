namespace ExactOnline.Client.Models.Manufacturing
{
    using System;

    [SupportedActionsSDK(true, true, false, false)]
    [DataServiceKey("MaterialReversalStockTransactionId")]
    public class SubOrderReversal
    {
        /// <summary>ID of creating user</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? CreatedBy { get; set; }
        /// <summary>Name of the creating user</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String CreatedByFullName { get; set; }
        /// <summary>Creation date of this SubOrderReversal</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? CreatedDate { get; set; }
        /// <summary>Does the SubOrderReversal&apos;s item use batch numbers</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Byte? IsBatch { get; set; }
        /// <summary>Indicates if fractions (for example 0.35) are allowed for quantities of the SubOrderReversal&apos;s item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Byte? IsFractionAllowedItem { get; set; }
        /// <summary>Does the SubOrderReversal&apos;s item use serial numbers</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Byte? IsSerial { get; set; }
        /// <summary>Item reversed</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Item { get; set; }
        /// <summary>Code of item reversed</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ItemCode { get; set; }
        /// <summary>Description of item reversed</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ItemDescription { get; set; }
        /// <summary>Picture url of shop order item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ItemPictureUrl { get; set; }
        /// <summary>MaterialReversal.StockTransactionId related to this SubOrderReversal&apos;s MaterialReversal</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid MaterialReversalStockTransactionId { get; set; }
        /// <summary>Notes logged with this reversal</summary>
        public String Note { get; set; }
        /// <summary>MaterialIssue.StockTransactionId related to this SubOrderReceipt&apos;s original MaterialIssue</summary>
        public Guid? OriginalMaterialIssueStockTransactionId { get; set; }
        /// <summary>ShopOrderReceipt.StockTransactionId related to this SubOrderReceipt&apos;s original ShopOrderReceipt</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? OriginalShopOrderReceiptStockTransactionId { get; set; }
        /// <summary>Shop order reversed from</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? ParentShopOrder { get; set; }
        /// <summary>Number of shop order reversed from</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? ParentShopOrderNumber { get; set; }
        /// <summary>Quantity of this SubOrderReversal</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? Quantity { get; set; }
        /// <summary>ShopOrderReversal.StockTransactionId related to this SubOrderReversal&apos;s ShopOrderReversal</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? ShopOrderReversalStockTransactionId { get; set; }
        /// <summary>Shop order reversed to</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? SubShopOrder { get; set; }
        /// <summary>Number of shop order reversed to</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? SubShopOrderNumber { get; set; }
        /// <summary>Effective date of this SubOrderReversal</summary>
        public DateTime? TransactionDate { get; set; }
        /// <summary>Unit of measurement abbreviation of this SubOrderReversal&apos;s item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String Unit { get; set; }
        /// <summary>Unit of measurement of this SubOrderReversal&apos;s item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String UnitDescription { get; set; }
        /// <summary>ID of warehouse of this SubOrderReversal</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Warehouse { get; set; }
        /// <summary>Code of warehouse of this SubOrderReversal</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String WarehouseCode { get; set; }
        /// <summary>Description of warehouse of this SubOrderReversal</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String WarehouseDescription { get; set; }
    }
}