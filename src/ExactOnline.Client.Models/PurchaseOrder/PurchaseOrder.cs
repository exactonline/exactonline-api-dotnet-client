using System.Collections.Generic;
using System;

namespace ExactOnline.Client.Models.PurchaseOrder
{
    [SupportedActionsSDK(true, true, false, true)]
    [DataServiceKey("PurchaseOrderID")]
    public class PurchaseOrder
    {
        /// <summary>Total amount in the default currency of the company</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? AmountDC { get; set; }
        /// <summary>Total amount in the currency of the transaction</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? AmountFC { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>Currency code</summary>
        public string Currency { get; set; }
        /// <summary>Reference to account for delivery</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? DeliveryAccount { get; set; }
        /// <summary>Delivery account code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DeliveryAccountCode { get; set; }
        /// <summary>Account name</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DeliveryAccountName { get; set; }
        /// <summary>Reference to shipping address</summary>
        public Guid? DeliveryAddress { get; set; }
        /// <summary>Reference to contact for delivery</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? DeliveryContact { get; set; }
        /// <summary>Name of the contact person of the customer who will receive delivered goods</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DeliveryContactPersonFullName { get; set; }
        /// <summary>Description of the purchase order</summary>
        public string Description { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Document that is manually linked to the purchase order</summary>
        public Guid? Document { get; set; }
        /// <summary>Subject of the document</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DocumentSubject { get; set; }
        /// <summary>Shows if it is a drop shipment purchase order</summary>
        public bool? DropShipment { get; set; }
        /// <summary>Allows you to set the currency for the invoice. You can only do this if you have checked the Variable: Currency and Variable: Exchange rate fields in the sales journal settings. Once a line has been created in the invoice, the currency can no longer be changed.</summary>
        public double? ExchangeRate { get; set; }
        /// <summary>Invoice status of purchase order: 10-Open, 20-Partial, 30-Complete, 40-Canceled</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? InvoiceStatus { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>Order date</summary>
        public DateTime? OrderDate { get; set; }
        /// <summary>Human readable id of the purchase order</summary>
        public Int32? OrderNumber { get; set; }
        /// <summary>Purchase order status: 10-Open, 20-Partial, 30-Complete, 40-Canceled</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? OrderStatus { get; set; }
        /// <summary>The payment condition code used for due date and discount calculation</summary>
        public string PaymentCondition { get; set; }
        /// <summary>Description of payment condition</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PaymentConditionDescription { get; set; }
        /// <summary>Purchase agent</summary>
        public Guid? PurchaseAgent { get; set; }
        /// <summary>Name of purchase agent</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PurchaseAgentFullName { get; set; }
        /// <summary>Primary key</summary>
        public Guid PurchaseOrderID { get; set; }
        /// <summary>Collection of lines</summary>
        public IEnumerable<PurchaseOrderLine> PurchaseOrderLines { get; set; }
        /// <summary>This field shows the date the goods are expected to be received.</summary>
        public DateTime? ReceiptDate { get; set; }
        /// <summary>Receipt status of purchase order: 10-Open, 20-Partial, 30-Complete, 40-Canceled</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? ReceiptStatus { get; set; }
        /// <summary>Include any relevant remarks regarding the purchase order.</summary>
        public string Remarks { get; set; }
        /// <summary>Reference to sales order when purchase order generated via back to back sales order</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? SalesOrder { get; set; }
        /// <summary>Number of the sales order</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? SalesOrderNumber { get; set; }
        /// <summary>ShippingMethod</summary>
        public Guid? ShippingMethod { get; set; }
        /// <summary>Description of ShippingMethod</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ShippingMethodDescription { get; set; }
        /// <summary>This shows how the purchase order was created: 1-Manual entry, 2-Import, 3-Other, 4-Purchase order, 5-Sales order, 6-Supplier&apos;s items, 7-Subcontract, 8-Purchase order advice, 9-Shop order, 10-MRP calculation</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int16? Source { get; set; }
        /// <summary>Reference to supplier account</summary>
        public Guid? Supplier { get; set; }
        /// <summary>Code of supplier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SupplierCode { get; set; }
        /// <summary>Contact of supplier</summary>
        public Guid? SupplierContact { get; set; }
        /// <summary>Contact person full name of supplier</summary>
        public string SupplierContactPersonFullName { get; set; }
        /// <summary>Name of supplier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SupplierName { get; set; }
        /// <summary>Total VAT amount in the currency of the transaction</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? VATAmount { get; set; }
        /// <summary>Warehouse</summary>
        public Guid? Warehouse { get; set; }
        /// <summary>Code of Warehouse</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseCode { get; set; }
        /// <summary>Description of Warehouse</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseDescription { get; set; }
        /// <summary>Shows the reference number associated with the purchase order. Enter a description and reference to make the purchase order easier to identify.</summary>
        public string YourRef { get; set; }
    }
}
