namespace ExactOnline.Client.Models.Manufacturing
{
    using System;

    [SupportedActionsSDK(true, true, false, false)]
    [DataServiceKey("StockTransactionId")]
    public class ByProductReceipt
    {
        /// <summary>ID of creating user</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? CreatedBy { get; set; }
        /// <summary>Name of the creating user</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String CreatedByFullName { get; set; }
        /// <summary>Date this by-product finish was created</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? CreatedDate { get; set; }
        /// <summary>Serial or batch numbers are reserved prior to a POST to ByProductReceipts. This DraftStockTransactionID represents the group of serial or batch numbers to be used in this transaction.</summary>
        public Guid? DraftStockTransactionID { get; set; }
        /// <summary>Indicates if this ByProductReceipt has a quantity eligible to be reversed via ByProductReversals</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Boolean HasReversibleQuantity { get; set; }
        /// <summary>Boolean indicating if this by-product finish was the result of shop order backflushing</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Boolean IsBackflush { get; set; }
        /// <summary>Does the ByProductReceipt&apos;s item use batch numbers</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Byte? IsBatch { get; set; }
        /// <summary>Indicates if fractions (for example 0.35) are allowed for quantities of the ByProductReceipt&apos;s item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Byte? IsFractionAllowedItem { get; set; }
        /// <summary>Does the ByProductReceipt&apos;s item use serial numbers</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Byte? IsSerial { get; set; }
        /// <summary>ID of by-product item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Item { get; set; }
        /// <summary>Code of by-product item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ItemCode { get; set; }
        /// <summary>Description of by-product item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ItemDescription { get; set; }
        /// <summary>Picture url of by-product item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ItemPictureUrl { get; set; }
        /// <summary>Quantity of this by-product finish</summary>
        public Double? Quantity { get; set; }
        /// <summary>ID of shop order, which produced the by-product</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? ShopOrder { get; set; }
        /// <summary>ID of the shop order material plan for this by-product</summary>
        public Guid? ShopOrderMaterialPlan { get; set; }
        /// <summary>Number of shop order, which produced the by-product</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? ShopOrderNumber { get; set; }
        /// <summary>ID of stock transaction related to this by-product finish</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid StockTransactionId { get; set; }
        /// <summary>ID of storage location finished to</summary>
        public Guid? StorageLocation { get; set; }
        /// <summary>Code of storage location finished to</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String StorageLocationCode { get; set; }
        /// <summary>Description of storage location finished to</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String StorageLocationDescription { get; set; }
        /// <summary>Effective date of this by-product finish</summary>
        public DateTime? TransactionDate { get; set; }
        /// <summary>Unit of measurement abbreviation of by-product item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String Unit { get; set; }
        /// <summary>Unit of measurement of by-product item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String UnitDescription { get; set; }
        /// <summary>ID of warehouse finished to</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Warehouse { get; set; }
        /// <summary>Code of warehouse finished to</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String WarehouseCode { get; set; }
        /// <summary>Description of warehouse finished to</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String WarehouseDescription { get; set; }
    }
}