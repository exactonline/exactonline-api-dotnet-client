namespace ExactOnline.Client.Models.Manufacturing
{
    using System;

    [SupportedActionsSDK(true, true, false, false)]
    [DataServiceKey("ReversalStockTransactionId")]
    public class ShopOrderReversal
    {
        /// <summary>ID of creating user</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? CreatedBy { get; set; }
        /// <summary>Name of the creating user</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String CreatedByFullName { get; set; }
        /// <summary>Date of this reversal</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? CreatedDate { get; set; }
        /// <summary>Does the ShopOrderReversal&apos;s item use batch numbers</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Byte? IsBatch { get; set; }
        /// <summary>Indicates if fractions (for example 0.35) are allowed for quantities of the ShopOrderReversal&apos;s item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Byte? IsFractionAllowedItem { get; set; }
        /// <summary>Does the ShopOrderReversal&apos;s item use serial numbers</summary>
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
        /// <summary>Notes associated with this reversal</summary>
        public String Note { get; set; }
        /// <summary>ID of the original stock transaction, which was reversed</summary>
        public Guid? OriginalStockTransactionId { get; set; }
        /// <summary>Quantity reversed</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? Quantity { get; set; }
        /// <summary>ID of stock transaction related to this ShopOrderReversal</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid ReversalStockTransactionId { get; set; }
        /// <summary>Shop order being reversed</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? ShopOrder { get; set; }
        /// <summary>Number of shop order being reversed</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? ShopOrderNumber { get; set; }
        /// <summary>ID of storage location reversed from</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? StorageLocation { get; set; }
        /// <summary>Code of storage location reversed from</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String StorageLocationCode { get; set; }
        /// <summary>Description of storage location reversed from</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String StorageLocationDescription { get; set; }
        /// <summary>Effective date of this ShopOrderReversal</summary>
        public DateTime? TransactionDate { get; set; }
        /// <summary>Unit of measurement abbreviation of item reversed</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String Unit { get; set; }
        /// <summary>Unit of measurement of item reversed</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String UnitDescription { get; set; }
        /// <summary>ID of warehouse reversed from</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Warehouse { get; set; }
        /// <summary>Code of warehouse reversed from</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String WarehouseCode { get; set; }
        /// <summary>Description of warehouse reversed from</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String WarehouseDescription { get; set; }
    }
}