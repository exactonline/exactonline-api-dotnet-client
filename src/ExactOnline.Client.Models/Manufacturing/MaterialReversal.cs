namespace ExactOnline.Client.Models.Manufacturing
{
    using System;

    [SupportedActionsSDK(true, true, false, false)]
    [DataServiceKey("ReversalStockTransactionId")]
    public class MaterialReversal
    {
        /// <summary>ID of creating user</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? CreatedBy { get; set; }
        /// <summary>Name of the creating user</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String CreatedByFullName { get; set; }
        /// <summary>Date this reversal was created</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? CreatedDate { get; set; }
        /// <summary>Boolean indicating if this reversal was the result of shop order backflushing, processed during a ShopOrderReversal</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Boolean IsBackflush { get; set; }
        /// <summary>Does the issue reversal&apos;s item use batch numbers</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Byte? IsBatch { get; set; }
        /// <summary>Indicates if fractions (for example 0.35) are allowed for quantities of the material reversal&apos;s item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Byte? IsFractionAllowedItem { get; set; }
        /// <summary>Does the issue reversal&apos;s item use serial numbers</summary>
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
        /// <summary>Picture url of item issued</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ItemPictureUrl { get; set; }
        /// <summary>Notes logged with this reversal</summary>
        public String Note { get; set; }
        /// <summary>ID of the original stock transaction, which was reversed</summary>
        public Guid? OriginalStockTransactionId { get; set; }
        /// <summary>Quantity of this reversal</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? Quantity { get; set; }
        /// <summary>ID of stock transaction related to this material issue</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid ReversalStockTransactionId { get; set; }
        /// <summary>ID of shop order reversed from</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? ShopOrder { get; set; }
        /// <summary>ID of shop order material plan</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? ShopOrderMaterialPlan { get; set; }
        /// <summary>Number of shop order reversed from</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? ShopOrderNumber { get; set; }
        /// <summary>ID of storage location reversed to</summary>
        public Guid? StorageLocation { get; set; }
        /// <summary>Code of storage location reversed to</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String StorageLocationCode { get; set; }
        /// <summary>Description of storage location reversed to</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String StorageLocationDescription { get; set; }
        /// <summary>Effective date of this reversal</summary>
        public DateTime? TransactionDate { get; set; }
        /// <summary>Unit of measurement abbreviation of item reversed</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String Unit { get; set; }
        /// <summary>Unit of measurement of item reversed</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String UnitDescription { get; set; }
        /// <summary>ID of warehouse reversed to</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Warehouse { get; set; }
        /// <summary>Code of warehouse reversed to</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String WarehouseCode { get; set; }
        /// <summary>Description of warehouse reversed to</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String WarehouseDescription { get; set; }
    }
}