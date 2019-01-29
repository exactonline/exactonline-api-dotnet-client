namespace ExactOnline.Client.Models.Logistics
{
    using System;

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class ItemGroup
    {
        /// <summary>Code of the item group</summary>
        public String Code { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String CreatorFullName { get; set; }
        /// <summary>Description of the item group</summary>
        public String Description { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>GL account on which the costs of items of this group will be booked</summary>
        public Guid? GLCosts { get; set; }
        /// <summary>Code of GLCosts</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String GLCostsCode { get; set; }
        /// <summary>Description of GLCosts</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String GLCostsDescription { get; set; }
        /// <summary>GL Purchase account for purchase invoicing according to (non-) perpetual inventory method</summary>
        public Guid? GLPurchaseAccount { get; set; }
        /// <summary>Code of GLPurchase</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String GLPurchaseAccountCode { get; set; }
        /// <summary>Description of GLPurchaseAccount</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String GLPurchaseAccountDescription { get; set; }
        /// <summary>GL account that will be used for the &apos;Standard cost price&apos; valuation method to balance the difference between purchase price and cost price</summary>
        public Guid? GLPurchasePriceDifference { get; set; }
        /// <summary>Code of GLPurchasePriceDifference</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String GLPurchasePriceDifferenceCode { get; set; }
        /// <summary>Description of GLPurchasePriceDifference</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String GLPurchasePriceDifferenceDescr { get; set; }
        /// <summary>GL account on which the revenue for items of this group will be booked</summary>
        public Guid? GLRevenue { get; set; }
        /// <summary>Code of GLRevenue</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String GLRevenueCode { get; set; }
        /// <summary>Description of GLRevenue</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String GLRevenueDescription { get; set; }
        /// <summary>GL account on which stock entries will be booked for items of this group</summary>
        public Guid? GLStock { get; set; }
        /// <summary>Code of GLStock</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String GLStockCode { get; set; }
        /// <summary>Description of GLStock</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String GLStockDescription { get; set; }
        /// <summary>GL stock variance account for perpetual inventory</summary>
        public Guid? GLStockVariance { get; set; }
        /// <summary>Code of GLStockVariance</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String GLStockVarianceCode { get; set; }
        /// <summary>Description of GLStockVariance</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String GLStockVarianceDescription { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Indicates if this is the default item group that will be assigned when a new item is created</summary>
        public Byte IsDefault { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ModifierFullName { get; set; }
        /// <summary>Notes</summary>
        public String Notes { get; set; }
    }
}