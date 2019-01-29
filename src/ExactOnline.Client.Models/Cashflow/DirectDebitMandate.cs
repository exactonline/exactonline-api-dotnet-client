namespace ExactOnline.Client.Models.Cashflow
{
    using System;

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class DirectDebitMandate
    {
        /// <summary>Account to which the mandate belongs.</summary>
        public Guid? Account { get; set; }
        /// <summary>Bank account to which the mandate belongs.</summary>
        public Guid? BankAccount { get; set; }
        /// <summary>Date that the mandate is cancelled. Used to check the validity of the mandate.</summary>
        public DateTime? CancellationDate { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>Displays the description of the mandate.</summary>
        public string Description { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Indicates the first collection hasn&apos;t been sent/confirmed with this mandate.</summary>
        public byte? FirstSend { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Indicates if the mandate is the main, you can have only one main mandate</summary>
        public byte? Main { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>Depending on the payment type, a different bank file will be generated. 0 = One-off payment, 1 = Recurrent payment, 2 = AdHoc (UK only)</summary>
        public Int16? PaymentType { get; set; }
        /// <summary>Displays a reference number for the mandate. It is a unique reference number that you can assign to each mandate.</summary>
        public string Reference { get; set; }
        /// <summary>Date that the mandate is signed. The collection must take place after the signature date of the mandate. The date is used to check the validity of the mandate.</summary>
        public DateTime? SignatureDate { get; set; }
        /// <summary>Depending on the type, a different bank file will be generated. 0 = Core, 1 = B2B and 2 = bottomline (UK only)</summary>
        public Int16? Type { get; set; }
    }
}