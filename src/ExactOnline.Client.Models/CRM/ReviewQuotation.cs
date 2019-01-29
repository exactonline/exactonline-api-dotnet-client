using System;

namespace ExactOnline.Client.Models.CRM
{
    [SupportedActionsSDK(true, false, false, false)]
    [DataServiceKey("QuotationID")]
    public class ReviewQuotation
    {
        /// <summary>Indicates if the item prices should be copied from the original quotation or the default item prices should be used.</summary>
        public Boolean? CopyItemPrices { get; set; }
        /// <summary>The description of the new quotation.</summary>
        public String Description { get; set; }
        /// <summary>Division code.</summary>
        public Int32 Division { get; set; }
        /// <summary>The document linked to the new quotation.</summary>
        public Guid? Document { get; set; }
        /// <summary>Contains the error message if an error occurred during the reviewing of the quotation.</summary>
        public String ErrorMessage { get; set; }
        /// <summary>Identifier of the newly created quotation.</summary>
        public Guid? NewQuotationID { get; set; }
        /// <summary>The account who made the order.</summary>
        public Guid? OrderAccount { get; set; }
        /// <summary>The contact person of the account who made the order.</summary>
        public Guid? OrderAccountContact { get; set; }
        /// <summary>The paymentcondition linked to the new quotation.</summary>
        public String PaymentCondition { get; set; }
        /// <summary>The date of the new quotation.</summary>
        public DateTime? QuotationDate { get; set; }
        /// <summary>Identifier of the quotation.</summary>
        public Guid QuotationID { get; set; }
        /// <summary>Contains information if the quotation was successfully reviewed.</summary>
        public String SuccessMessage { get; set; }
    }
}