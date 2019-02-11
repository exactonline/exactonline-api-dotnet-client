namespace ExactOnline.Client.Models.SalesOrder
{
    using System;

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class SalesOrderLine
    {
        /// <summary>Amount in the default currency of the company</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double AmountDC { get; set; }
        /// <summary>Amount in the currency of the transaction</summary>
        public double AmountFC { get; set; }
        /// <summary>Reference to Cost center</summary>
        public string CostCenter { get; set; }
        /// <summary>Description of CostCenter</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CostCenterDescription { get; set; }
        /// <summary>Item cost price</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? CostPriceFC { get; set; }
        /// <summary>Reference to Cost unit</summary>
        public string CostUnit { get; set; }
        /// <summary>Description of CostUnit</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CostUnitDescription { get; set; }
        /// <summary>Delivery date of this line</summary>
        public DateTime? DeliveryDate { get; set; }
        /// <summary>Description</summary>
        public string Description { get; set; }
        /// <summary>Discount given on the default price. Discount = (DefaultPrice of Item - PriceItem in line) / DefaultPrice of Item</summary>
        public double? Discount { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Reference to the item that is sold in this sales order line</summary>
        public Guid? Item { get; set; }
        /// <summary>Code of Item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }
        /// <summary>Description of Item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }
        /// <summary>Item Version</summary>
        public Guid? ItemVersion { get; set; }
        /// <summary>Description of Item Version</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemVersionDescription { get; set; }
        /// <summary>Line number</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 LineNumber { get; set; }
        /// <summary>Sales margin of the sales order line</summary>
        public double? Margin { get; set; }
        /// <summary>Net price of the sales order line</summary>
        public double? NetPrice { get; set; }
        /// <summary>Extra notes</summary>
        public string Notes { get; set; }
        /// <summary>The OrderID identifies the sales order. All the lines of a sales order have the same OrderID</summary>
        public Guid OrderID { get; set; }
        /// <summary>Number of sales order</summary>
        public Int32 OrderNumber { get; set; }
        /// <summary>Price list</summary>
        public Guid? Pricelist { get; set; }
        /// <summary>Description of Pricelist</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PricelistDescription { get; set; }
        /// <summary>The project to which the sales order line is linked. The project can be different per line. Sometimes also the project in the header is filled although this is not really used</summary>
        public Guid? Project { get; set; }
        /// <summary>Description of Project</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }
        /// <summary>Purchase order that is linked to the sales order</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? PurchaseOrder { get; set; }
        /// <summary>Purchase order line of the purchase order that is linked to the sales order</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? PurchaseOrderLine { get; set; }
        /// <summary>Number of the purchase order line</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? PurchaseOrderLineNumber { get; set; }
        /// <summary>Number of the purchase order</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? PurchaseOrderNumber { get; set; }
        /// <summary>The number of items sold in default units. The quantity shown in the entry screen is Quantity * UnitFactor</summary>
        public double? Quantity { get; set; }
        /// <summary>The number of items delivered</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? QuantityDelivered { get; set; }
        /// <summary>The number of items invoiced</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? QuantityInvoiced { get; set; }
        /// <summary>Reference to ShopOrder</summary>
        public Guid? ShopOrder { get; set; }
        /// <summary>Obsolete</summary>
        public Guid? TaxSchedule { get; set; }
        /// <summary>Obsolete</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string TaxScheduleCode { get; set; }
        /// <summary>Obsolete</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string TaxScheduleDescription { get; set; }
        /// <summary>Code of item unit</summary>
        public string UnitCode { get; set; }
        /// <summary>Description of Unit</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string UnitDescription { get; set; }
        /// <summary>Price per unit in the currency of the transaction</summary>
        public double? UnitPrice { get; set; }
        /// <summary>Indicates if drop shipment is used (delivery directly to customer, invoice to wholesaler)</summary>
        public byte UseDropShipment { get; set; }
        /// <summary>VAT amount in the currency of the transaction</summary>
        public double? VATAmount { get; set; }
        /// <summary>VAT code</summary>
        public string VATCode { get; set; }
        /// <summary>Description of VATCode</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string VATCodeDescription { get; set; }
        /// <summary>The vat percentage of the VAT code. This is the percentage at the moment the sales order is created. It&apos;s also used for the default calculation of VAT amounts and VAT base amounts</summary>
        public double? VATPercentage { get; set; }
    }
}