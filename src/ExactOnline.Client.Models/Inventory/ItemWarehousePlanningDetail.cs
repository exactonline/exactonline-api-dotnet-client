namespace ExactOnline.Client.Models.Inventory
{
    using System;

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("Item")]
    public class ItemWarehousePlanningDetail
    {
        /// <summary>ID of item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Item { get; set; }
        /// <summary>Code of item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ItemCode { get; set; }
        /// <summary>Description of item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ItemDescription { get; set; }
        /// <summary>Date which quantity in stock is planned to change</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime PlannedDate { get; set; }
        /// <summary>Amount by which quantity in stock is planned to change</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double PlannedQuantity { get; set; }
        /// <summary>Human readable description of the PlanningSource (translated to user&apos;s language) - Examples: Purchase Order, Sales Order, Shop Order, etc.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String PlanningSourceDescription { get; set; }
        /// <summary>ID of the PlanningSource</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? PlanningSourceID { get; set; }
        /// <summary>Line number of the PlanningSource if the PlanningSourceType supports line numbers</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? PlanningSourceLineNumber { get; set; }
        /// <summary>Human readable number of the PlanningSource - Examples: Shop order number &apos;201600001&apos; or Sales order number &apos;2016020001&apos;</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? PlanningSourceNumber { get; set; }
        /// <summary>REST API URL of this specific PlanningSource and PlanningSourceID (Assembly orders and warehouse transfers not supported over REST)</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String PlanningSourceUrl { get; set; }
        /// <summary>Type of the PlanningSource - 120=GoodsDelivery, 124=WarehouseTransferDelivery, 130=GoodsReceipt, 134=WarehouseTransferReceipt, 140=ShopOrderStockReceipt, 147=ShopOrderByProductReceipt, 150=ShopOrderRequirement, 160=AssemblyOrderReceipt, 165=AssemblyOrderIssue</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? PlanningType { get; set; }
        /// <summary>Human readable description of the PlanningSourceType (translated to user&apos;s language) - Examples: &apos;Shop order stock receipt&apos; or &apos;Goods delivery&apos;</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String PlanningTypeDescription { get; set; }
        /// <summary>ID of warehouse</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Warehouse { get; set; }
        /// <summary>Code of warehouse</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String WarehouseCode { get; set; }
        /// <summary>Description of warehouse</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String WarehouseDescription { get; set; }
    }

}