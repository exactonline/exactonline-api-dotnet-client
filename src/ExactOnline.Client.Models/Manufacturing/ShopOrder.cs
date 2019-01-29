namespace ExactOnline.Client.Models.Manufacturing
{
    using System;
    using System.Collections.Generic;

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class ShopOrder
    {
        /// <summary>URL to CAD Drawing Specified on Manufacturing Bill of Material</summary>
        public String CADDrawingURL { get; set; }
        /// <summary>The cost center linked to the shop order</summary>
        public String Costcenter { get; set; }
        /// <summary>Description of Costcenter</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String CostcenterDescription { get; set; }
        /// <summary>The cost unit linked to the shop order</summary>
        public String Costunit { get; set; }
        /// <summary>Description of Costunit</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String CostunitDescription { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String CreatorFullName { get; set; }
        /// <summary>Description of the shop order</summary>
        public String Description { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Date on which the shop order was placed</summary>
        public DateTime? EntryDate { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Does the material plan&apos;s item use batch numbers</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Byte IsBatch { get; set; }
        /// <summary>Indicates if fractions (for example 0.35) are allowed for quantities of the material plan&apos;s item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Byte IsFractionAllowedItem { get; set; }
        /// <summary>Indicator that Shop order is in planning</summary>
        public Byte IsInPlanning { get; set; }
        /// <summary>Indicator if the Shop order is on hold</summary>
        public Byte IsOnHold { get; set; }
        /// <summary>Indicator that the Shop order has been released to production</summary>
        public Byte IsReleased { get; set; }
        /// <summary>Does the material plan&apos;s item use serial numbers</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Byte IsSerial { get; set; }
        /// <summary>Reference to the item</summary>
        public Guid? Item { get; set; }
        /// <summary>Code of the item created by this shop order</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ItemCode { get; set; }
        /// <summary>Description of the item created by this shop order</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ItemDescription { get; set; }
        /// <summary>URL of the item created by this shop order</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ItemPictureUrl { get; set; }
        /// <summary>Reference to ItemVersion</summary>
        public Guid? ItemVersion { get; set; }
        /// <summary>Description of Item Version</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ItemVersionDescription { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ModifierFullName { get; set; }
        /// <summary>Notes - only viewed internally</summary>
        public String Notes { get; set; }
        /// <summary>Planned end date of this shop order</summary>
        public DateTime? PlannedDate { get; set; }
        /// <summary>Planned quantity</summary>
        public Double? PlannedQuantity { get; set; }
        /// <summary>Planned start date of this shop order</summary>
        public DateTime? PlannedStartDate { get; set; }
        /// <summary>Produced quantity</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? ProducedQuantity { get; set; }
        /// <summary>Production lead days</summary>
        public Int32 ProductionLeadDays { get; set; }
        /// <summary>Reference to Project</summary>
        public Guid? Project { get; set; }
        /// <summary>Description of Project</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ProjectDescription { get; set; }
        /// <summary>Quantity ready to ship</summary>
        public Double? ReadyToShipQuantity { get; set; }
        /// <summary>Number of sales orders linked to this shop order</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 SalesOrderLineCount { get; set; }
        /// <summary>Collection of Sales order lines</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public IEnumerable<ExactOnline.Client.Models.SalesOrder.SalesOrderLine> SalesOrderLines { get; set; }
        /// <summary>Number of shop order by-product plans, which are backflushed, for this shop order</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 ShopOrderByProductPlanBackflushCount { get; set; }
        /// <summary>Number of shop order by-product plans for this shop order</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 ShopOrderByProductPlanCount { get; set; }
        /// <summary>Shop order main</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? ShopOrderMain { get; set; }
        /// <summary>Shop order main number</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? ShopOrderMainNumber { get; set; }
        /// <summary>Number of shop order material plans, which are backflushed, for this shop order</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 ShopOrderMaterialPlanBackflushCount { get; set; }
        /// <summary>Number of shop order material plans for this shop order</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 ShopOrderMaterialPlanCount { get; set; }
        /// <summary>Collection of Shop order Material plans</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public IEnumerable<ExactOnline.Client.Models.Manufacturing.ShopOrderMaterialPlan> ShopOrderMaterialPlans { get; set; }
        /// <summary>Unique number to indentify the shop order</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? ShopOrderNumber { get; set; }
        /// <summary>Unique number to indentify the shop order (as a string to allow OData filtering, e.g. $filter=substringof(&apos;123&apos;,ShopOrderNumberString) eq true</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ShopOrderNumberString { get; set; }
        /// <summary>Shop order parent</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? ShopOrderParent { get; set; }
        /// <summary>Shop order parent number</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? ShopOrderParentNumber { get; set; }
        /// <summary>Number of shop order routing step plans for this shop order</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 ShopOrderRoutingStepPlanCount { get; set; }
        /// <summary>Collection of Shop order Routing step plans</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public IEnumerable<ExactOnline.Client.Models.Manufacturing.ShopOrderRoutingStepPlan> ShopOrderRoutingStepPlans { get; set; }
        /// <summary>Indicates the type of Shop Order: 10 Open, 20 In process, 30 Finished, 40 Completed</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Status { get; set; }
        /// <summary>The count of material lines of this shop order, which have been linked to a sub order</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 SubShopOrderCount { get; set; }
        /// <summary>Overall status of the line: 9040 Regular</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Type { get; set; }
        /// <summary>Unit of the item created by this shop order</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String Unit { get; set; }
        /// <summary>Unit description of the unit of the item created by this shop order</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String UnitDescription { get; set; }
        /// <summary>Reference to the Warehouse associated with the Shop order</summary>
        public Guid? Warehouse { get; set; }
        /// <summary>Your reference (of the customer)</summary>
        public String YourRef { get; set; }
    }
}