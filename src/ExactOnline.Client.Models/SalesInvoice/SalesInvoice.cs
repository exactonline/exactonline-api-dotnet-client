using System.Collections.Generic;
using System;

namespace ExactOnline.Client.Models.SalesInvoice
{
    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("InvoiceID")]
    public class SalesInvoice
    {
        /// <summary>For the header lines (LineNumber = 0) of an entry this is the SUM(AmountDC) of all lines</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? AmountDC { get; set; }
        /// <summary>Discount amount in the default currency of the company</summary>
        public Double? AmountDiscount { get; set; }
        /// <summary>Discount amount exclude VAT in the default currency of the company</summary>
        public Double? AmountDiscountExclVat { get; set; }
        /// <summary>For the header this is the sum of all lines, including VAT</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? AmountFC { get; set; }
        /// <summary>For the header this is the sum of all lines, excluding VAT</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? AmountFCExclVat { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String CreatorFullName { get; set; }
        /// <summary>Currency for the invoice. Default this is the currency of the administration</summary>
        public String Currency { get; set; }
        /// <summary>Delivery account for invoice</summary>
        public Guid? DeliverTo { get; set; }
        /// <summary>Address of delivery as per invoice delivery account</summary>
        public Guid? DeliverToAddress { get; set; }
        /// <summary>Delivery account person for invoice</summary>
        public Guid? DeliverToContactPerson { get; set; }
        /// <summary>Name of delivery account&apos;s contact person as per invoice</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String DeliverToContactPersonFullName { get; set; }
        /// <summary>Name of the delivery account&apos;s customer as per invoice</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String DeliverToName { get; set; }
        /// <summary>Description. Can be different for header and lines</summary>
        public String Description { get; set; }
        /// <summary>Discount percentage</summary>
        public Double? Discount { get; set; }
        /// <summary>Discount Type</summary>
        public Int16? DiscountType { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Document that is manually linked to the invoice</summary>
        public Guid? Document { get; set; }
        /// <summary>Number of the document</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? DocumentNumber { get; set; }
        /// <summary>Subject of the document</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String DocumentSubject { get; set; }
        /// <summary>The due date for payments. This date is calculated based on the EntryDate and the Paymentcondition</summary>
        public DateTime? DueDate { get; set; }
        /// <summary>Extra duty amount in the currency of the transaction. Both extra duty amount and VAT amount need to be specified in order to differ this property from automatically calculated.</summary>
        public Double? ExtraDutyAmountFC { get; set; }
        /// <summary>A positive value of the amount indicates that the amount is to be paid by the customer to your G bank account.In case of a credit invoice the amount should have negative value when retrieved or posted to Exact.</summary>
        public Double? GAccountAmountFC { get; set; }
        /// <summary>Official date for the invoice. When the invoice is entered it&apos;s equal to the field &apos;EntryDate&apos;. During the printing process the invoice date can be entered</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? InvoiceDate { get; set; }
        /// <summary>Primary key</summary>
        public Guid InvoiceID { get; set; }
        /// <summary>Assigned at entry or at printing depending on setting. The number assigned is based on the freenumbers as defined for the Journal. When printing the field InvoiceNumber is copied to the fields EntryNumber and InvoiceNumber of the sales entry</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? InvoiceNumber { get; set; }
        /// <summary>Reference to the Customer who will receive the invoice</summary>
        public Guid? InvoiceTo { get; set; }
        /// <summary>Reference to the Contact person of the customer who will receive the invoice</summary>
        public Guid? InvoiceToContactPerson { get; set; }
        /// <summary>Name of the contact person of the customer who will receive the invoice</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String InvoiceToContactPersonFullName { get; set; }
        /// <summary>Name of the customer who will receive the invoice</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String InvoiceToName { get; set; }
        /// <summary>Indicates whether the invoice has extra duty</summary>
        public Boolean? IsExtraDuty { get; set; }
        /// <summary>The journal code. Every invoice should be linked to a sales journal</summary>
        public String Journal { get; set; }
        /// <summary>Description of Journal</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String JournalDescription { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ModifierFullName { get; set; }
        /// <summary>Order date</summary>
        public DateTime? OrderDate { get; set; }
        /// <summary>Customer who ordered the invoice</summary>
        public Guid? OrderedBy { get; set; }
        /// <summary>Contact person of customer who ordered the invoice</summary>
        public Guid? OrderedByContactPerson { get; set; }
        /// <summary>Name of contact person of customer who ordered the invoice</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String OrderedByContactPersonFullName { get; set; }
        /// <summary>Name of customer who ordered the invoice</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String OrderedByName { get; set; }
        /// <summary>Number to identify the order. By default the number is based on a setting for the first free number, but you can post your own number.</summary>
        public Int32? OrderNumber { get; set; }
        /// <summary>The payment condition used for due date and discount calculation</summary>
        public String PaymentCondition { get; set; }
        /// <summary>Description of PaymentCondition</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String PaymentConditionDescription { get; set; }
        /// <summary>Payment reference for sales invoice</summary>
        public String PaymentReference { get; set; }
        /// <summary>Extra remarks</summary>
        public String Remarks { get; set; }
        /// <summary>Collection of lines</summary>
        public IEnumerable<ExactOnline.Client.Models.SalesInvoice.SalesInvoiceLine> SalesInvoiceLines { get; set; }
        /// <summary>Sales representative</summary>
        public Guid? Salesperson { get; set; }
        /// <summary>Name of sales representative</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String SalespersonFullName { get; set; }
        /// <summary>Starter Sales invoice status (for starter functionality)</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int16? StarterSalesInvoiceStatus { get; set; }
        /// <summary>Description of StarterSalesInvoiceStatus</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String StarterSalesInvoiceStatusDescription { get; set; }
        /// <summary>The status of the entry. 10 = draft. During the creation of an invoice draft records occur in the draft modus if during an invoice a new page with lines is triggered. If the user leaves the invoice in an abnormal way the draft invoices can be recovered. Draft invoices are not included in financial reports, balances etc. 20 = open. Open invoices can be changed. New invoices get the status open by default. 50 = processed. Processed invoices can&apos;t be changed anymore. Processing is done via printing. Processed invoices can&apos;t be reopened</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int16? Status { get; set; }
        /// <summary>Description of Status</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String StatusDescription { get; set; }
        /// <summary>Obsolete</summary>
        public Guid? TaxSchedule { get; set; }
        /// <summary>Obsolete</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String TaxScheduleCode { get; set; }
        /// <summary>Obsolete</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String TaxScheduleDescription { get; set; }
        /// <summary>Indicates the type of invoice Values: 8020 - Sales invoices, 8021 - Sales credit note, 8023 - Direct sales invoice, 8024 - Direct credit note</summary>
        public Int32? Type { get; set; }
        /// <summary>Description of the type</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String TypeDescription { get; set; }
        /// <summary>Total VAT amount in the default currency of the company</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? VATAmountDC { get; set; }
        /// <summary>Total VAT amount in the currency of the transaction</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? VATAmountFC { get; set; }
        /// <summary>Mandatory for direct sales invoice/credit note, cannot be set for normal sales invoice/credit note.</summary>
        public Guid? Warehouse { get; set; }
        /// <summary>Withholding tax amount applied to sales invoice</summary>
        public Double? WithholdingTaxAmountFC { get; set; }
        /// <summary>Withholding tax base amount to calculate withholding amount</summary>
        public Double? WithholdingTaxBaseAmount { get; set; }
        /// <summary>Withholding tax percentage applied to sales invoice</summary>
        public Double? WithholdingTaxPercentage { get; set; }
        /// <summary>The invoice number of the customer</summary>
        public String YourRef { get; set; }
    }
}
