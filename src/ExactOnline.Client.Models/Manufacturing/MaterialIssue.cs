namespace ExactOnline.Client.Models.Manufacturing
{
    using System;

    [SupportedActionsSDK(true, true, false, false)]
    [DataServiceKey("StockTransactionId")]
    public class MaterialIssue
    {
        /// <summary>ID of creating user</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? CreatedBy { get; set; }
        /// <summary>Name of the creating user</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String CreatedByFullName { get; set; }
        /// <summary>Date this material issue was created</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? CreatedDate { get; set; }
        /// <summary>Serial or batch numbers are reserved prior to a POST to MaterialIssues. This DraftStockTransactionID represents the group of serial or batch numbers to be used in this transaction.</summary>
        public Guid? DraftStockTransactionID { get; set; }
        /// <summary>Indicates if this MaterialIssue has a quantity eligible to be reversed via MaterialReversals</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Boolean HasReversibleQuantity { get; set; }
        /// <summary>Boolean indicating if this material issue was the result of shop order backflushing</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Byte? IsBackflush { get; set; }
        /// <summary>Does the material issue&apos;s item use batch numbers</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Byte? IsBatch { get; set; }
        /// <summary>Indicates if fractions (for example 0.35) are allowed for quantities of the material issue&apos;s item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Byte? IsFractionAllowedItem { get; set; }
        /// <summary>Boolean indicating if this material issue was an issue to a parent shop order</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Byte? IsIssueFromChild { get; set; }
        /// <summary>Does the material issue&apos;s item use serial numbers</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Byte? IsSerial { get; set; }
        /// <summary>Item issued</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Item { get; set; }
        /// <summary>Code of item issued</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ItemCode { get; set; }
        /// <summary>Description of item issued</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ItemDescription { get; set; }
        /// <summary>Picture url of item issued</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ItemPictureUrl { get; set; }
        /// <summary>Notes logged with this material issue</summary>
        public String Note { get; set; }
        /// <summary>Quantity of this material issue</summary>
        public Double? Quantity { get; set; }
        /// <summary>If this transaction was part of a SubOrderReceipt, this ID is the related ShopOrderReceipt.StockTransactionID.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? RelatedStockTransaction { get; set; }
        /// <summary>ID of shop order issued to</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? ShopOrder { get; set; }
        /// <summary>ID of shop order material plan</summary>
        public Guid? ShopOrderMaterialPlan { get; set; }
        /// <summary>Number of shop order issued to</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? ShopOrderNumber { get; set; }
        /// <summary>ID of stock transaction related to this material issue</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid StockTransactionId { get; set; }
        /// <summary>ID of storage location issued from</summary>
        public Guid? StorageLocation { get; set; }
        /// <summary>Code of storage location issued from</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String StorageLocationCode { get; set; }
        /// <summary>Description of storage location issued from</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String StorageLocationDescription { get; set; }
        /// <summary>Effective date of this material issue</summary>
        public DateTime? TransactionDate { get; set; }
        /// <summary>Unit of measurement abbreviation of item issued</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String Unit { get; set; }
        /// <summary>Unit of measurement of item issued</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String UnitDescription { get; set; }
        /// <summary>ID of warehouse issued from</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Warehouse { get; set; }
        /// <summary>Code of warehouse issued from</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String WarehouseCode { get; set; }
        /// <summary>Description of warehouse issued from</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String WarehouseDescription { get; set; }
    }
}