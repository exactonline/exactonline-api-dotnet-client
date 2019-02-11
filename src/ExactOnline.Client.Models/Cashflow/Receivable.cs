namespace ExactOnline.Client.Models.Cashflow
{
    using System;

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class Receivable
    {
        /// <summary>The customer from which the receivable will come.</summary>
        public Guid? Account { get; set; }
        /// <summary>The bank account of the customer, from which the receivable will come.</summary>
        public Guid? AccountBankAccountID { get; set; }
        /// <summary>The bank account number of the customer, from which the receivable will come.</summary>
        public string AccountBankAccountNumber { get; set; }
        /// <summary>The code of the customer from which the receivable will come.</summary>
        public string AccountCode { get; set; }
        /// <summary>Contact person copied from the purchase invoice linked to the related purchase entry.</summary>
        public Guid? AccountContact { get; set; }
        /// <summary>Name of the contact person of the customer.</summary>
        public string AccountContactName { get; set; }
        /// <summary>Name of the customer.</summary>
        public string AccountName { get; set; }
        /// <summary>The amount in default currency (division currency). Receivables are matched on this amount.</summary>
        public double AmountDC { get; set; }
        /// <summary>The amount of the discount in the default currency.</summary>
        public double AmountDiscountDC { get; set; }
        /// <summary>The amount of the discount. This is in the amount of the selected currency.</summary>
        public double AmountDiscountFC { get; set; }
        /// <summary>The amount of the receivable. This is in the amount of the selected currency.</summary>
        public double AmountFC { get; set; }
        /// <summary>Own bank account to which the receivable will be done.</summary>
        public Guid? BankAccountID { get; set; }
        /// <summary>Own bank account number to which the receivable will be done.</summary>
        public string BankAccountNumber { get; set; }
        /// <summary>When processing receivables, all receivable with the same processing data are put in a batch. This field contains the code of that batch.</summary>
        public string CashflowTransactionBatchCode { get; set; }
        /// <summary>Creation date.</summary>
        public DateTime Created { get; set; }
        /// <summary>User ID of the creator.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of the creator.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>The currency of the receivable. This currency can only deviate from the division currency if the module Currency is in the license.</summary>
        public string Currency { get; set; }
        /// <summary>Description.</summary>
        public string Description { get; set; }
        /// <summary>Direct Debit Mandate used to collect the receivable.</summary>
        public Guid? DirectDebitMandate { get; set; }
        /// <summary>Description of the mandate.</summary>
        public string DirectDebitMandateDescription { get; set; }
        /// <summary>Payment type of the mandate.&lt;br&gt; 0 = One off payment&lt;br&gt; 1 = Recurrent payment.</summary>
        public Int16? DirectDebitMandatePaymentType { get; set; }
        /// <summary>Unique mandate reference.</summary>
        public string DirectDebitMandateReference { get; set; }
        /// <summary>Type of the mandate.&lt;br&gt; 0 = Core&lt;br&gt; 1 = Business-to-business.</summary>
        public Int16? DirectDebitMandateType { get; set; }
        /// <summary>Date before which the payment by the customer must be done to be eligible for discount.</summary>
        public DateTime? DiscountDueDate { get; set; }
        /// <summary>Division code.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        /// <summary>Document that is created when processing collections.  The bank export file is attached to the document.</summary>
        public Guid? Document { get; set; }
        /// <summary>Number of the document.</summary>
        public Int32? DocumentNumber { get; set; }
        /// <summary>Subject of the document.</summary>
        public string DocumentSubject { get; set; }
        /// <summary>Date before which the payment by the customer must be done.</summary>
        public DateTime? DueDate { get; set; }
        /// <summary>Date since when the receivable is no longer an outstanding item. This is the highest invoice date of all matched receivables.</summary>
        public DateTime? EndDate { get; set; }
        /// <summary>Period since when the receivable is no longer an outstanding item. This is the highest period of all matched receivables.</summary>
        public Int16? EndPeriod { get; set; }
        /// <summary>The value of the tag &apos;EndToEndID&apos; when generating a SEPA file.</summary>
        public string EndToEndID { get; set; }
        /// <summary>Year (of period) since when the receivable is no longer an outstanding item. This is the highest year of all matched receivables. Used in combination with EndPeriod.</summary>
        public Int16? EndYear { get; set; }
        /// <summary>Processing date of the receivable.</summary>
        public DateTime? EntryDate { get; set; }
        /// <summary>The unique identifier for a set of receivables. A receivable can be split so that one part is received on a different date. In that case the two records get a different EntryID.</summary>
        public Guid? EntryID { get; set; }
        /// <summary>Entry number of the linked transaction.</summary>
        public Int32? EntryNumber { get; set; }
        /// <summary>G/L account of the payment. Must be of type 20 (Accounts receivable).</summary>
        public Guid? GLAccount { get; set; }
        /// <summary>Code of the G/L account.</summary>
        public string GLAccountCode { get; set; }
        /// <summary>Description of the G/L account.</summary>
        public string GLAccountDescription { get; set; }
        /// <summary>Identifier of the receivable.</summary>
        public Guid ID { get; set; }
        /// <summary>Invoice date of the linked transaction.</summary>
        public DateTime? InvoiceDate { get; set; }
        /// <summary>Invoice number of the linked transaction.</summary>
        public Int32? InvoiceNumber { get; set; }
        /// <summary>Boolean indicating whether the receivable is part of a batch booking.</summary>
        public byte? IsBatchBooking { get; set; }
        /// <summary>Boolean indicating whether the receivable was fully paid by the customer.</summary>
        public bool IsFullyPaid { get; set; }
        /// <summary>Journal of the linked transaction.</summary>
        public string Journal { get; set; }
        /// <summary>Description of the journal.</summary>
        public string JournalDescription { get; set; }
        /// <summary>Last payment date.</summary>
        public DateTime? LastPaymentDate { get; set; }
        /// <summary>Last modified date.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        /// <summary>User ID of modifier.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>Payment condition of the linked transaction.</summary>
        public string PaymentCondition { get; set; }
        /// <summary>Description of the payment condition.</summary>
        public string PaymentConditionDescription { get; set; }
        /// <summary>Number of days between invoice date and due date.</summary>
        public Int32? PaymentDays { get; set; }
        /// <summary>Number of days between invoice date and due date of the discount.</summary>
        public Int32? PaymentDaysDiscount { get; set; }
        /// <summary>Payment discount percentage.</summary>
        public double? PaymentDiscountPercentage { get; set; }
        /// <summary>PaymentInformationID tag from the SEPA xml file.</summary>
        public string PaymentInformationID { get; set; }
        /// <summary>Method of payment.&lt;br&gt; B = On credit (default)&lt;br&gt; I = Collection&lt;br&gt; K = Cash&lt;br&gt; V = Credit card</summary>
        public string PaymentMethod { get; set; }
        /// <summary>Payment reference for the receivable that may be included In the bank export file</summary>
        public string PaymentReference { get; set; }
        /// <summary>Exchange rate from receivable currency to division currency. AmountFC * RateFC = AmountDC.</summary>
        public double? RateFC { get; set; }
        /// <summary>Number assigned during the processing of receivables.</summary>
        public Int32? ReceivableBatchNumber { get; set; }
        /// <summary>Date and time since when the receivable is selected to be collected.</summary>
        public DateTime? ReceivableSelected { get; set; }
        /// <summary>User who selected the receivable to be collected.</summary>
        public Guid? ReceivableSelector { get; set; }
        /// <summary>Name of the receivable selector.</summary>
        public string ReceivableSelectorFullName { get; set; }
        /// <summary>The source of the receivable.&lt;br&gt; 1 = manual&lt;br&gt; 2 = reconcile&lt;br&gt; 3 = match&lt;br&gt; 4 = import&lt;br&gt; 5 = process</summary>
        public Int32 Source { get; set; }
        /// <summary>The status of the receivable.&lt;br&gt; 20 = open&lt;br&gt; 30 = selected - receivable is selected to be collected&lt;br&gt; 40 = processed - collection has been done&lt;br&gt; 50 = matched - receivable is matched with one or more other outstanding items or financial statement lines</summary>
        public Int16? Status { get; set; }
        /// <summary>Total amount of the linked transaction in default currency (division currency).</summary>
        public double TransactionAmountDC { get; set; }
        /// <summary>Total amount of the linked transaction in the selected currency.</summary>
        public double TransactionAmountFC { get; set; }
        /// <summary>Due date of the linked transaction.</summary>
        public DateTime? TransactionDueDate { get; set; }
        /// <summary>Linked transaction. Use this as reference to SalesEntries.</summary>
        public Guid? TransactionEntryID { get; set; }
        /// <summary>Linked transaction line. Use this as reference to BankEntryLines and CashEntryLines.</summary>
        public Guid? TransactionID { get; set; }
        /// <summary>Indicates if the linked transaction is a reversal entry.</summary>
        public bool TransactionIsReversal { get; set; }
        /// <summary>Period of the linked transaction.</summary>
        public Int16? TransactionReportingPeriod { get; set; }
        /// <summary>Year of the linked transaction.</summary>
        public Int16? TransactionReportingYear { get; set; }
        /// <summary>Status of the linked transaction.</summary>
        public Int16? TransactionStatus { get; set; }
        /// <summary>Type of the linked transaction.</summary>
        public Int32? TransactionType { get; set; }
        /// <summary>Invoice number. In case the receivable belongs to a bank entry line and is matched with one invoice, YourRef is filled with the YourRef of this invoice.</summary>
        public string YourRef { get; set; }
    }
}