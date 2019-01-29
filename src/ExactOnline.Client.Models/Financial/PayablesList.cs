namespace ExactOnline.Client.Models.Financial
{
    using System;

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("HID")]
    public class PayablesList
    {
        /// <summary>Code of Account</summary>
        public string AccountCode { get; set; }
        /// <summary>Reference to the account</summary>
        public Guid AccountId { get; set; }
        /// <summary>Name of Account</summary>
        public string AccountName { get; set; }
        /// <summary>Amount</summary>
        public double Amount { get; set; }
        /// <summary>Amount in transit</summary>
        public double AmountInTransit { get; set; }
        /// <summary>Code of Currency</summary>
        public string CurrencyCode { get; set; }
        /// <summary>Description</summary>
        public string Description { get; set; }
        /// <summary>Date the invoice should be paid</summary>
        public DateTime DueDate { get; set; }
        /// <summary>Entry number</summary>
        public Int32 EntryNumber { get; set; }
        /// <summary>Primary key, human readable ID</summary>
        public Int64 HID { get; set; }
        /// <summary>Obsolete</summary>
        public Guid Id { get; set; }
        /// <summary>Invoice date</summary>
        public DateTime InvoiceDate { get; set; }
        /// <summary>Invoice number. The value is 0 when the invoice number of the linked transaction is empty.</summary>
        public Int32 InvoiceNumber { get; set; }
        /// <summary>Code of Journal</summary>
        public string JournalCode { get; set; }
        /// <summary>Description of Journal</summary>
        public string JournalDescription { get; set; }
        /// <summary>Your reference</summary>
        public string YourRef { get; set; }
    }
}