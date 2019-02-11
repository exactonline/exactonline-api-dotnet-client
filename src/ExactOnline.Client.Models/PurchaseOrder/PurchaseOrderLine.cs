namespace ExactOnline.Client.Models.PurchaseOrder
{
    using System;

    [SupportedActionsSDK(true, true, false, true)]
    [DataServiceKey("ID")]
    public class PurchaseOrderLine
    {
        /// <summary>Amount in the default currency of the company</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? AmountDC { get; set; }
        /// <summary>Amount in the currency of the transaction</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? AmountFC { get; set; }
        /// <summary>Reference to Cost center</summary>
        public string CostCenter { get; set; }
        /// <summary>Description of CostCenter</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CostCenterDescription { get; set; }
        /// <summary>Reference to Cost unit</summary>
        public string CostUnit { get; set; }
        /// <summary>Description of CostUnit</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CostUnitDescription { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>Description of the purchase order line</summary>
        public string Description { get; set; }
        /// <summary>Discount in percentage for item</summary>
        public double? Discount { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Expense related to the Work Breakdown Structure of the selected project. Only available with a professional service license</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Expense { get; set; }
        /// <summary>Description of expense. Only available with a professional service license</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ExpenseDescription { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>The current stock level of items shown in stock unit. The information is displayed only for items with the stock property selected.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? InStock { get; set; }
        /// <summary>Quantity of item that has been invoiced</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? InvoicedQuantity { get; set; }
        /// <summary>Reference to the item for purchase order</summary>
        public Guid? Item { get; set; }
        /// <summary>Item code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }
        /// <summary>Description of item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }
        /// <summary>Indicates if fractional quantities of the item can be used, for example quantity = 0.4</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public bool? ItemDivisable { get; set; }
        /// <summary>Line number</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? LineNumber { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>The net price is the unit price (VAT code taken into account) with any discount applied</summary>
        public double? NetPrice { get; set; }
        /// <summary>Notes</summary>
        public string Notes { get; set; }
        /// <summary>Reference to project. Only available with a professional service license</summary>
        public Guid? Project { get; set; }
        /// <summary>Project code. Only available with a professional service license</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectCode { get; set; }
        /// <summary>Description of the project. Only available with a professional service license</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }
        /// <summary>The current stock level + the planned quantity to be received - the planned quantity to deliver shown in stock unit.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? ProjectedStock { get; set; }
        /// <summary>Identifies the purchase order. All the lines of a purchase order have the same PurchaseOrderID</summary>
        public Guid PurchaseOrderID { get; set; }
        /// <summary>Quantity in item units</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? Quantity { get; set; }
        /// <summary>Quantity in purchase units. Use this field when creating a purchase order</summary>
        public double? QuantityInPurchaseUnits { get; set; }
        /// <summary>Indicates whether the purchase order line needs to be rebilled. Only available with a professional service license</summary>
        public bool? Rebill { get; set; }
        /// <summary>Date the goods are expected to be received</summary>
        public DateTime? ReceiptDate { get; set; }
        /// <summary>Quantity of goods received</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? ReceivedQuantity { get; set; }
        /// <summary>Sales order that is linked to a back to back sales order in purchase order</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? SalesOrder { get; set; }
        /// <summary>Sales order line of the sales order that is linked to a back to back sales order in purchase order</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? SalesOrderLine { get; set; }
        /// <summary>Number of the sales order line</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? SalesOrderLineNumber { get; set; }
        /// <summary>Number of the sales order</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? SalesOrderNumber { get; set; }
        /// <summary>Code the supplier uses for this item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SupplierItemCode { get; set; }
        /// <summary>Code of item unit</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Unit { get; set; }
        /// <summary>Description of unit</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string UnitDescription { get; set; }
        /// <summary>Item price per purchase unit</summary>
        public double? UnitPrice { get; set; }
        /// <summary>Amount of VAT charges calculated from total amount and vat percentage</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? VATAmount { get; set; }
        /// <summary>The VAT code used when the invoice was registered</summary>
        public string VATCode { get; set; }
        /// <summary>Description of vat code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string VATDescription { get; set; }
        /// <summary>The VAT percentage of the VAT code. This is the percentage at the moment the invoice is created. It&apos;s also used by the default calculation of VAT amounts and VAT base amounts</summary>
        public double? VATPercentage { get; set; }
    }
}