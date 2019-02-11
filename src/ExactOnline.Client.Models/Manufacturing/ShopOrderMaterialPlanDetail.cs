using System;
using System.Collections.Generic;

namespace ExactOnline.Client.Models.Manufacturing
{
    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class ShopOrderMaterialPlanDetail
    {
        /// <summary>Indicates if this is a backflush step</summary>
        public Byte? Backflush { get; set; }
        /// <summary>The calculator associated with this material plan</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public MaterialPlanCalculator Calculator { get; set; }
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
        /// <summary>Does the material plan&apos;s item use batch numbers</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Byte? IsBatch { get; set; }
        /// <summary>Indicates if fractions (for example 0.35) are allowed for quantities of this item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Byte? IsFractionAllowedItem { get; set; }
        /// <summary>Does the material plan&apos;s item use serial numbers</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Byte? IsSerial { get; set; }
        /// <summary>Material plan issued quantity</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? IssuedQuantity { get; set; }
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
        /// <summary>Number of items that are planned to come in</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? PlannedIn { get; set; }
        /// <summary>Number of items that are planned to go out</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? PlannedOut { get; set; }
        /// <summary>Planned price of the material</summary>
        public Double? PlannedPriceFC { get; set; }
        /// <summary>Intended quantity</summary>
        public Double? PlannedQuantity { get; set; }
        /// <summary>Intended quantity unit factor</summary>
        public Double? PlannedQuantityFactor { get; set; }
        /// <summary>Material plan remaining quantity</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? RemainingQuantity { get; set; }
        /// <summary>Reference to ShopOrders table</summary>
        public Guid? ShopOrder { get; set; }
        /// <summary>Shop order number</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? ShopOrderNumber { get; set; }
        /// <summary>Line status</summary>
        public Int32? Status { get; set; }
        /// <summary>Description of Status</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String StatusDescription { get; set; }
        /// <summary>Number of items in stock</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? Stock { get; set; }
        /// <summary>Collection of Manufacturing stock locations</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public IEnumerable<Inventory.ItemWarehouseStorageLocation> StockLocations { get; set; }
        /// <summary>ID of the shop order linked to this material</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? SubShopOrder { get; set; }
        /// <summary>Number of the shop order linked to this material</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? SubShopOrderNumber { get; set; }
        /// <summary>Type</summary>
        public Int32? Type { get; set; }
        /// <summary>Unit</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String Unit { get; set; }
        /// <summary>Unit description</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String UnitDescription { get; set; }
        /// <summary>Shop order warehouse</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Warehouse { get; set; }
    }
}
