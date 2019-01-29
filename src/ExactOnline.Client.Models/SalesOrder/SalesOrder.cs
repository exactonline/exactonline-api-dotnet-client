using System.Collections.Generic;
using System;

namespace ExactOnline.Client.Models.SalesOrder
{
    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("OrderID")]
    public class SalesOrder
    {
        /// <summary>Amount in the default currency of the company</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double AmountDC { get; set; }
        /// <summary>Discount amount in the default currency of the company</summary>
        public double? AmountDiscount { get; set; }
        /// <summary>Discount amount exclude VAT in the default currency of the company</summary>
        public double? AmountDiscountExclVat { get; set; }
        /// <summary>Amount in the currency of the transaction</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double AmountFC { get; set; }
        /// <summary>Amount exclude VAT in the currency of the transaction</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? AmountFCExclVat { get; set; }
        /// <summary>Shows if this sales order is approved</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int16 ApprovalStatus { get; set; }
        /// <summary>Description of ApprovalStatus</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ApprovalStatusDescription { get; set; }
        /// <summary>Approval datetime</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Approved { get; set; }
        /// <summary>User who approved the sales order</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Approver { get; set; }
        /// <summary>Name of approver</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ApproverFullName { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>Currency code</summary>
        public string Currency { get; set; }
        /// <summary>Reference to delivery customer</summary>
        public Guid? DeliverTo { get; set; }
        /// <summary>Reference to contact person of delivery customer</summary>
        public Guid? DeliverToContactPerson { get; set; }
        /// <summary>Name of contact person of delivery customer</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DeliverToContactPersonFullName { get; set; }
        /// <summary>Name of delivery customer</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DeliverToName { get; set; }
        /// <summary>Delivery address</summary>
        public Guid? DeliveryAddress { get; set; }
        /// <summary>Delivery date</summary>
        public DateTime? DeliveryDate { get; set; }
        /// <summary>Shipping status</summary>
        public Int16? DeliveryStatus { get; set; }
        /// <summary>Description of DeliveryStatus</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DeliveryStatusDescription { get; set; }
        /// <summary>Description</summary>
        public string Description { get; set; }
        /// <summary>Discount percentage</summary>
        public double? Discount { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        /// <summary>Document that is manually linked to the sales order</summary>
        public Guid? Document { get; set; }
        /// <summary>Number of the document</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? DocumentNumber { get; set; }
        /// <summary>Subject of the document</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DocumentSubject { get; set; }
        /// <summary>Invoice status</summary>
        public Int16? InvoiceStatus { get; set; }
        /// <summary>Description of InvoiceStatus</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string InvoiceStatusDescription { get; set; }
        /// <summary>Reference to the Customer who will receive the invoice</summary>
        public Guid? InvoiceTo { get; set; }
        /// <summary>Reference to the Contact person of the customer who will receive the invoice</summary>
        public Guid? InvoiceToContactPerson { get; set; }
        /// <summary>Name of the contact person of the customer who will receive the invoice</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string InvoiceToContactPersonFullName { get; set; }
        /// <summary>Name of the customer who will receive the invoice</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string InvoiceToName { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>Order date</summary>
        public DateTime? OrderDate { get; set; }
        /// <summary>Customer who ordered the sales order</summary>
        public Guid? OrderedBy { get; set; }
        /// <summary>Contact person of the customer who ordered the sales order</summary>
        public Guid? OrderedByContactPerson { get; set; }
        /// <summary>Name of contact person of the customer who ordered the sales order</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string OrderedByContactPersonFullName { get; set; }
        /// <summary>Name of the customer who ordered the sales order</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string OrderedByName { get; set; }
        /// <summary>Primary key</summary>
        public Guid OrderID { get; set; }
        /// <summary>Number of sales order</summary>
        public Int32 OrderNumber { get; set; }
        /// <summary>The payment condition used for due date and discount calculation</summary>
        public string PaymentCondition { get; set; }
        /// <summary>Description of PaymentCondition</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PaymentConditionDescription { get; set; }
        /// <summary>Payment reference for sales order</summary>
        public string PaymentReference { get; set; }
        /// <summary>Extra remarks</summary>
        public string Remarks { get; set; }
        /// <summary>Collection of lines</summary>
        public IEnumerable<SalesOrderLine> SalesOrderLines { get; set; }
        /// <summary>Sales representative</summary>
        public Guid? Salesperson { get; set; }
        /// <summary>Name of sales representative</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SalespersonFullName { get; set; }
        /// <summary>ShippingMethod</summary>
        public Guid? ShippingMethod { get; set; }
        /// <summary>Description of ShippingMethod</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ShippingMethodDescription { get; set; }
        /// <summary>The status of the sales order. 12 = Open, 20 = Partial, 21 = Complete, 45 = Cancelled.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int16? Status { get; set; }
        /// <summary>Description of Status</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string StatusDescription { get; set; }
        /// <summary>Obsolete</summary>
        public Guid? TaxSchedule { get; set; }
        /// <summary>Obsolete</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string TaxScheduleCode { get; set; }
        /// <summary>Obsolete</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string TaxScheduleDescription { get; set; }
        /// <summary>Code of Warehouse</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseCode { get; set; }
        /// <summary>Description of Warehouse</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseDescription { get; set; }
        /// <summary>Warehouse</summary>
        public Guid? WarehouseID { get; set; }
        /// <summary>The reference number of the customer</summary>
        public string YourRef { get; set; }
    }
}
