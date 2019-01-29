namespace ExactOnline.Client.Models.Manufacturing
{
    using System;

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class ShopOrderMaterialPlan
    {
        /// <summary>Indicates if this is a backflush step</summary>
        public Byte? Backflush { get; set; }
        /// <summary>Calculator type</summary>
        public Int32? CalculatorType { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String CreatorFullName { get; set; }
        /// <summary>Description of the material</summary>
        public String Description { get; set; }
        /// <summary>Detail drawing reference</summary>
        public String DetailDrawing { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Reference to Items table</summary>
        public Guid? Item { get; set; }
        /// <summary>Item Code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ItemCode { get; set; }
        /// <summary>Description of Item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ItemDescription { get; set; }
        /// <summary>URL of the material item&apos;s picture</summary>
        public String ItemPictureUrl { get; set; }
        /// <summary>Line number</summary>
        public Int32? LineNumber { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ModifierFullName { get; set; }
        /// <summary>Line notes</summary>
        public String Notes { get; set; }
        /// <summary>Planned amount in the currency of the transaction</summary>
        public Double? PlannedAmountFC { get; set; }
        /// <summary>Date that the material is required.</summary>
        public DateTime? PlannedDate { get; set; }
        /// <summary>Planned price of the material</summary>
        public Double? PlannedPriceFC { get; set; }
        /// <summary>Intended quantity</summary>
        public Double? PlannedQuantity { get; set; }
        /// <summary>Intended quantity unit factor</summary>
        public Double? PlannedQuantityFactor { get; set; }
        /// <summary>Reference to ShopOrders table</summary>
        public Guid? ShopOrder { get; set; }
        /// <summary>Line status</summary>
        public Int32? Status { get; set; }
        /// <summary>Description of Status</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String StatusDescription { get; set; }
        /// <summary>Type</summary>
        public Int32? Type { get; set; }
        /// <summary>Unit</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String Unit { get; set; }
        /// <summary>Unit description</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String UnitDescription { get; set; }
    }
}