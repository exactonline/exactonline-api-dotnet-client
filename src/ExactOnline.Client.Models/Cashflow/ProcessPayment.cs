namespace ExactOnline.Client.Models.Cashflow
{
    using System;
    using System.Collections.Generic;

    [SupportedActionsSDK(true, false, false, false)]
    [DataServiceKey("ID")]
    public class ProcessPayment
    {
        /// <summary>This is a URL to get the documents that were created after the payments were successfully processed. These documents have to be sent to the bank in order to do the payments.</summary>
        public string BankExportDocumentsUrl { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        /// <summary>Contains the error message if an error occurred during the processing of the payment(s).</summary>
        public string ErrorMessage { get; set; }
        /// <summary>Primary key.</summary>
        public Guid ID { get; set; }
        /// <summary>Use this field to pass a collection of GUIDs representing the IDs of the payments that have to be processed.</summary>
        public IEnumerable<Cashflow.PaymentID> PaymentIDs { get; set; }
        /// <summary>Contains information if the payments were successfully processed.</summary>
        public string SuccessMessage { get; set; }
    }
}