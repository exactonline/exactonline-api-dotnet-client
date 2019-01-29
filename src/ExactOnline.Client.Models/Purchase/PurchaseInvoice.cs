using System.Collections.Generic;
using System;

namespace ExactOnline.Client.Models.Purchase
{
    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class PurchaseInvoice
    {
        /// <summary>The amount including VAT in the currency of the invoice.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double Amount { get; set; }
        /// <summary>Guid identifying the contact person of the supplier.</summary>
        public Guid? ContactPerson { get; set; }
        /// <summary>The code of the currency of the invoiced amount.</summary>
        public string Currency { get; set; }
        /// <summary>The description of the invoice.</summary>
        public string Description { get; set; }
        /// <summary>Guid identifying a document that is attached to the invoice.</summary>
        public Guid? Document { get; set; }
        /// <summary>The date before which the invoice has to be paid.</summary>
        public DateTime? DueDate { get; set; }
        /// <summary>The unique number of the purchase invoice. The entry number is based on a setting in the purchase journal and incremented for each new purchase invoice.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? EntryNumber { get; set; }
        /// <summary>The exchange rate between the invoice currency and the default currency of the division.</summary>
        public double? ExchangeRate { get; set; }
        /// <summary>The financial period in which the invoice is entered.</summary>
        public Int16? FinancialPeriod { get; set; }
        /// <summary>The financial year in which the invoice is entered.</summary>
        public Int16? FinancialYear { get; set; }
        /// <summary>A guid that is the unique identifier of the purchase invoice.</summary>
        public Guid ID { get; set; }
        /// <summary>The date on which the supplier entered the invoice.</summary>
        public DateTime? InvoiceDate { get; set; }
        /// <summary>The code of the purchase journal in which the invoice is entered.</summary>
        public string Journal { get; set; }
        /// <summary>The date and time the invoice was last modified.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        /// <summary>The code of the payment condition that is used to calculate the due date and discount.</summary>
        public string PaymentCondition { get; set; }
        /// <summary>Unique reference to match payments and invoices.</summary>
        public string PaymentReference { get; set; }
        /// <summary>The collection of lines that belong to the purchase invoice.</summary>
        public IEnumerable<Purchase.PurchaseInvoiceLine> PurchaseInvoiceLines { get; set; }
        /// <summary>The user can enter remarks related to the invoice here.</summary>
        public string Remarks { get; set; }
        /// <summary>Indicates the origin of the invoice. 1 Manual entry, 3 Purchase invoice, 4 Purchase order, 5 Web service.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int16 Source { get; set; }
        /// <summary>The status of the invoice. 10 Draft, 20 Open, 50 Processed.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int16 Status { get; set; }
        /// <summary>Guid that identifies the supplier.</summary>
        public Guid? Supplier { get; set; }
        /// <summary>Indicates the type of the purchase invoice. 8030 Direct purchase invoice, 8031 Direct purchase invoice (Credit), 8033 Purchase invoice, 8034 Purchase invoice (Credit)</summary>
        public Int16 Type { get; set; }
        /// <summary>The total VAT amount of the purchase invoice.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? VATAmount { get; set; }
        /// <summary>Guid that identifies the warehouse that will receive the purchased goods. This is mandatory for creating a direct purchase invoice. </summary>
        public Guid? Warehouse { get; set; }
        /// <summary>The invoice number provided by the supplier.</summary>
        public string YourRef { get; set; }
    }
}
