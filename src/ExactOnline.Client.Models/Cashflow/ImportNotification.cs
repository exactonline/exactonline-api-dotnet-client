using System;

namespace ExactOnline.Client.Models.Cashflow
{
    [SupportedActionsSDK(false, true, true, false)]
    [DataServiceKey("ID")]
    public class ImportNotification
    {
        /// <summary>Number of the bank account related to the notification.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String BankAccount { get; set; }
        /// <summary>ID of the bank account related to the notification.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? BankAccountID { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>ID of the document related to the notification.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Document { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Code of the import result</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int16? Result { get; set; }
        /// <summary>Description of the import result</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ResultDescription { get; set; }
        /// <summary>ID of the user that requested a retry of the import.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? RetriedBy { get; set; }
        /// <summary>Date when the retry was requested.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? RetriedOn { get; set; }
    }
}
