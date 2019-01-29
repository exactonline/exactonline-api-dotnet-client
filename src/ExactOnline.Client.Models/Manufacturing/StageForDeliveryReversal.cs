namespace ExactOnline.Client.Models.Manufacturing
{
    using System;

    [SupportedActionsSDK(true, true, false, false)]
    [DataServiceKey("Id")]
    public class StageForDeliveryReversal
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
        /// <summary>ID of this StageForDeliveryReversal</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Id { get; set; }
        /// <summary>Does the shop order receipt&apos;s item use batch numbers</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Byte IsBatch { get; set; }
        /// <summary>Indicates if fractions (for example 0.35) are allowed for quantities of the StageForDeliveryReversal&apos;s item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Byte IsFractionAllowedItem { get; set; }
        /// <summary>Does the shop order receipt&apos;s item use serial numbers</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Byte IsSerial { get; set; }
        /// <summary>Item reversed</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Item { get; set; }
        /// <summary>Code of item reversed</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ItemCode { get; set; }
        /// <summary>Description of item reversed</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ItemDescription { get; set; }
        /// <summary>Picture url of by-product item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ItemPictureUrl { get; set; }
        /// <summary>Quantity reversed</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? Quantity { get; set; }
        /// <summary>ID of the original stage for delivery entry, which is being reversed</summary>
        public Guid? RelatedId { get; set; }
        /// <summary>Shop order being reversed to</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? ShopOrder { get; set; }
        /// <summary>Number of shop order being reversed to</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? ShopOrderNumber { get; set; }
        /// <summary>Effective date of this StageForDeliveryReversal</summary>
        public DateTime? TransactionDate { get; set; }
        /// <summary>Unit of measurement abbreviation of item reversed</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String Unit { get; set; }
        /// <summary>Unit of measurement of item reversed</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String UnitDescription { get; set; }
        /// <summary>ID of the shop order warehouse</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Warehouse { get; set; }
        /// <summary>Code of the shop order warehouse</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String WarehouseCode { get; set; }
        /// <summary>Description of the shop order warehouse</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String WarehouseDescription { get; set; }
    }
}