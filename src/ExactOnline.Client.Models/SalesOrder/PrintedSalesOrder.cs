namespace ExactOnline.Client.Models.SalesOrder
{
    using System;

    [SupportedActionsSDK(true, false, false, false)]
    [DataServiceKey("OrderId")]
    public class PrintedSalesOrder
    {
        /// <summary>Division code</summary>
        public Int32? Division { get; set; }
        /// <summary>Contains the id of the document that was created</summary>
        public Guid? Document { get; set; }
        /// <summary>Contains the error message if an error occurred during the creation of the document</summary>
        public string DocumentCreationError { get; set; }
        /// <summary>Contains information if a document was succesfully created</summary>
        public string DocumentCreationSuccess { get; set; }
        /// <summary>Based on this layout a PDF is created and attached to an Exact Online document and an email</summary>
        public Guid? DocumentLayout { get; set; }
        /// <summary>Contains the error message if an error occurred during the creation of the email</summary>
        public string EmailCreationError { get; set; }
        /// <summary>Contains confirmation that an email was sent. If an email cannot be delivered this property will still show confirmation that the email was sent.</summary>
        public string EmailCreationSuccess { get; set; }
        /// <summary>Based on this layout the email text is produced</summary>
        public Guid? EmailLayout { get; set; }
        /// <summary>Extra text that can be added to the printed document and email</summary>
        public string ExtraText { get; set; }
        /// <summary>Primary key, Reference to OrderID of SalesOrder</summary>
        public Guid OrderId { get; set; }
        /// <summary>Set to True if an email containing the sales order should be sent to the customer</summary>
        public bool? SendEmailToCustomer { get; set; }
        /// <summary>Email address from which the email will be sent. If not specified, the company email address will be used.</summary>
        public string SenderEmailAddress { get; set; }
    }
}