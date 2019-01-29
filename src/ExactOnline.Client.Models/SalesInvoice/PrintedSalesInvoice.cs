namespace ExactOnline.Client.Models.SalesInvoice
{
    using System;

    [SupportedActionsSDK(true, false, false, false)]
    [DataServiceKey("InvoiceID")]
    public class PrintedSalesInvoice
    {
        /// <summary>Division code</summary>
        public Int32? Division { get; set; }
        /// <summary>Contains the id of the document that was created</summary>
        public Guid? Document { get; set; }
        /// <summary>Contains the error message if an error occurred during the creation of the document</summary>
        public String DocumentCreationError { get; set; }
        /// <summary>Contains information if a document was succesfully created</summary>
        public String DocumentCreationSuccess { get; set; }
        /// <summary>Based on this layout a PDF is created and attached to an Exact Online document and an email</summary>
        public Guid? DocumentLayout { get; set; }
        /// <summary>Contains the error message if an error occurred during the creation of the email</summary>
        public String EmailCreationError { get; set; }
        /// <summary>Contains confirmation that an email was sent. If an email cannot be delivered this property will still show confirmation that the email was sent.</summary>
        public String EmailCreationSuccess { get; set; }
        /// <summary>Based on this layout the email text is produced</summary>
        public Guid? EmailLayout { get; set; }
        /// <summary>Extra text that can be added to the printed document and email</summary>
        public String ExtraText { get; set; }
        /// <summary>Date of the invoice</summary>
        public DateTime? InvoiceDate { get; set; }
        /// <summary>Primary key, Reference to EntryID of SalesInvoice</summary>
        public Guid InvoiceID { get; set; }
        /// <summary>Contains the error message if an error occurred during the sending of a postbox message</summary>
        public String PostboxMessageCreationError { get; set; }
        /// <summary>Contains information if a postbox message was succesfully sent</summary>
        public String PostboxMessageCreationSuccess { get; set; }
        /// <summary>The postbox from where the message is sent</summary>
        public Guid? PostboxSender { get; set; }
        /// <summary>Reporting period</summary>
        public Int32? ReportingPeriod { get; set; }
        /// <summary>Reporting year</summary>
        public Int32? ReportingYear { get; set; }
        /// <summary>Set to True if an email containing the invoice should be sent to the invoice customer. This option overrules SendInvoiceToCustomerPostbox.</summary>
        public Boolean? SendEmailToCustomer { get; set; }
        /// <summary>Email address from which the email will be sent. If not specified, the company email address will be used.</summary>
        public String SenderEmailAddress { get; set; }
        /// <summary>Set to True if a postbox message containing the invoice should be sent to the invoice customer</summary>
        public Boolean? SendInvoiceToCustomerPostbox { get; set; }
        /// <summary>Set to True if the output preference should be taken from the account. It will be either Document only, Email or Digital postbox. This option overrules both SendEmailToCustomer and SendInvoiceToCustomerPostbox.</summary>
        public Boolean? SendOutputBasedOnAccount { get; set; }
    }
}