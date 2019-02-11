using System;

namespace ExactOnline.Client.Models.CRM
{
    [SupportedActionsSDK(true, false, false, false)]
    [DataServiceKey("QuotationID")]
    public class PrintQuotation
    {
        /// <summary>Division code</summary>
        public Int32 Division { get; set; }
        /// <summary>Contains the id of the document that was created</summary>
        public Guid? Document { get; set; }
        /// <summary>Contains the error message if an error occurred during the creation of the document</summary>
        public String DocumentCreationError { get; set; }
        /// <summary>Contains information if a document was successfully created</summary>
        public String DocumentCreationSuccess { get; set; }
        /// <summary>Based on this layout a PDF is created and attached to an Exact Online document and an email. In case it is not specified, the default layout is used.</summary>
        public Guid? DocumentLayout { get; set; }
        /// <summary>Contains the error message if an error occurred during the creation of the Email</summary>
        public String EmailCreationError { get; set; }
        /// <summary>Based on this layout the email text is produced. In case it is not specified, the default layout is used.</summary>
        public Guid? EmailLayout { get; set; }
        /// <summary>Extra text that can be added to the printed document and email</summary>
        public String ExtraText { get; set; }
        /// <summary>Date of the quotation printed</summary>
        public DateTime QuotationDate { get; set; }
        /// <summary>Identifier of the quotation</summary>
        public Guid QuotationID { get; set; }
        /// <summary>Set to True if an email containing the quotation should be sent to the customer</summary>
        public Boolean SendEmailToCustomer { get; set; }
        /// <summary>Email address from which the email will be sent. If not specified, the company email address will be used.</summary>
        public String SenderEmailAddress { get; set; }
    }
}