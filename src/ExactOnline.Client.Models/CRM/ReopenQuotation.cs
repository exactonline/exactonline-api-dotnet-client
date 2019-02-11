using System;

namespace ExactOnline.Client.Models.CRM
{
    [SupportedActionsSDK(true, false, false, false)]
    [DataServiceKey("QuotationID")]
    public class ReopenQuotation
    {
        /// <summary>Division code.</summary>
        public Int32 Division { get; set; }
        /// <summary>Contains the error message if an error occurred during the reopening of the quotation.</summary>
        public String ErrorMessage { get; set; }
        /// <summary>Identifier of the quotation.</summary>
        public Guid QuotationID { get; set; }
        /// <summary>Contains information if the quotation was successfully reopened.</summary>
        public String SuccessMessage { get; set; }
    }
}