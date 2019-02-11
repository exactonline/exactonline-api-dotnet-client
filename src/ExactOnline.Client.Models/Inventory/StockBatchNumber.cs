namespace ExactOnline.Client.Models.Inventory
{
    using System;

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class StockBatchNumber
    {
        /// <summary>Human readable batch number</summary>
        public String BatchNumber { get; set; }
        /// <summary>Batch number ID</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? BatchNumberID { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String CreatorFullName { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>ID representing a group of batch numbers being reserved for use in a subsequent stock transaction</summary>
        public Guid? DraftStockTransactionID { get; set; }
        /// <summary>End date of effective period for batch number</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? EndDate { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Boolean value indicating whether or not the batch number is blocked</summary>
        public Byte? IsBlocked { get; set; }
        /// <summary>Boolean value indicating if this batch number is being reserved</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Byte? IsDraft { get; set; }
        /// <summary>Item</summary>
        public Guid? Item { get; set; }
        /// <summary>Item code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ItemCode { get; set; }
        /// <summary>Description of item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ItemDescription { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ModifierFullName { get; set; }
        /// <summary>Quantity of this batch number entering or leaving inventory</summary>
        public Double? Quantity { get; set; }
        /// <summary>Remarks</summary>
        public String Remarks { get; set; }
        /// <summary>ID of stock count entry</summary>
        public Guid? StockCountLine { get; set; }
        /// <summary>ID of the stock transaction in which this batch number was used</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? StockTransactionID { get; set; }
        /// <summary>Type of stock transaction associated with this batch number.&lt;br&gt;&lt;br&gt;Available values:&lt;br&gt;10 = Opening balance&lt;br&gt;120 = Goods delivery&lt;br&gt;121 = Sales return&lt;br&gt;122 = Stock out (Drop shipment)&lt;br&gt;123 = Stock in (Drop shipment return)&lt;br&gt;124 = Warehouse transfer delivery&lt;br&gt;125 = Location Transfer Delivery&lt;br&gt;130 = Goods receipt&lt;br&gt;131 = Purchase return&lt;br&gt;132 = Stock in (Drop shipment)&lt;br&gt;133 = Stock out (Drop shipment return)&lt;br&gt;134 = Warehouse transfer receipt&lt;br&gt;135 = Location Transfer Receipt&lt;br&gt;140 = Shop order stock receipt&lt;br&gt;141 = Shop order stock reversal&lt;br&gt;147 = Shop order by-product receipt&lt;br&gt;148 = Shop order by-product reversal&lt;br&gt;150 = Requirement issue&lt;br&gt;151 = Requirement reversal&lt;br&gt;155 = Subcontract issue&lt;br&gt;156 = Subcontract return&lt;br&gt;160 = Receipt (Assembly)&lt;br&gt;161 = Return receipt (Disassembly)&lt;br&gt;165 = Issue (Assembly)&lt;br&gt;166 = Return issue (Disassembly)&lt;br&gt;180 = Stock revaluation&lt;br&gt;181 = Financial revaluation&lt;br&gt;195 = Stock count&lt;br&gt;196 = Adjust stock - out&lt;br&gt;197 = Adjust stock - in&lt;br&gt;</summary>
        public Int32? StockTransactionType { get; set; }
        /// <summary>Storage location which this batch number is entering or leaving</summary>
        public Guid? StorageLocation { get; set; }
        /// <summary>Code of the storage location which this batch number is entering or leaving</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String StorageLocationCode { get; set; }
        /// <summary>Description of the storage location which this batch number is entering or leaving</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String StorageLocationDescription { get; set; }
        /// <summary>Warehouse which this batch number is entering or leaving</summary>
        public Guid? Warehouse { get; set; }
        /// <summary>Code of the warehouse which this batch number is entering or leaving</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String WarehouseCode { get; set; }
        /// <summary>Description of the warehouse which this batch number is entering or leaving</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String WarehouseDescription { get; set; }
    }

}