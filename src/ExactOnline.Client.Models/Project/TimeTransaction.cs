using System;

namespace ExactOnline.Client.Models.Project
{
    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class TimeTransaction
    {
        /// <summary>Account linked to the transaction</summary>
        public Guid? Account { get; set; }
        /// <summary>Name of Account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String AccountName { get; set; }
        /// <summary>Reference to ProjectWBS (work breakdown structure)</summary>
        public Guid? Activity { get; set; }
        /// <summary>Description of ProjectWBS</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ActivityDescription { get; set; }
        /// <summary>This property is obsolete. Use property &apos;AmountFC&apos; instead.</summary>
        public Double? Amount { get; set; }
        /// <summary>Amount in the currency of the transaction of the transaction</summary>
        public Double? AmountFC { get; set; }
        /// <summary>Attachment linked to the transaction</summary>
        public Guid? Attachment { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String CreatorFullName { get; set; }
        /// <summary>Currency of the amount</summary>
        public String Currency { get; set; }
        /// <summary>Date</summary>
        public DateTime? Date { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Description of Division</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String DivisionDescription { get; set; }
        /// <summary>Employee linked to the transaction</summary>
        public Guid? Employee { get; set; }
        /// <summary>End time of the transaction</summary>
        public DateTime? EndTime { get; set; }
        /// <summary>Entrynumber</summary>
        public Int32? EntryNumber { get; set; }
        /// <summary>Errortext, used for the backgroundjobs</summary>
        public String ErrorText { get; set; }
        /// <summary>Status of the transaction</summary>
        public Int16? HourStatus { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Item linked to the transaction. Items of type &apos;time&apos; are linked to time transactions. Items of other types are linked to cost transactions</summary>
        public Guid? Item { get; set; }
        /// <summary>Description of Item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ItemDescription { get; set; }
        /// <summary>True if you can use decimals for item quantity</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Boolean? ItemDivisable { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ModifierFullName { get; set; }
        /// <summary>Notes linked to the transaction</summary>
        public String Notes { get; set; }
        /// <summary>This property is obsolete. Use property &apos;PriceFC&apos; instead.</summary>
        public Double? Price { get; set; }
        /// <summary>PriceFC (AmountFC = Quantity * PriceFC)</summary>
        public Double? PriceFC { get; set; }
        /// <summary>Project linked to the transaction</summary>
        public Guid? Project { get; set; }
        /// <summary>Reference to project account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? ProjectAccount { get; set; }
        /// <summary>Project account code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ProjectAccountCode { get; set; }
        /// <summary>Project account name</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ProjectAccountName { get; set; }
        /// <summary>Code of Project</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ProjectCode { get; set; }
        /// <summary>Description of Project</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ProjectDescription { get; set; }
        /// <summary>Quantity of the transaction</summary>
        public Double? Quantity { get; set; }
        /// <summary>Skip validation</summary>
        public Boolean SkipValidation { get; set; }
        /// <summary>Start time of the transaction</summary>
        public DateTime? StartTime { get; set; }
        /// <summary>Subscription linked to the transaction</summary>
        public Guid? Subscription { get; set; }
        /// <summary>Account linked to the subscription</summary>
        public Guid? SubscriptionAccount { get; set; }
        /// <summary>Subscription account code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String SubscriptionAccountCode { get; set; }
        /// <summary>Subscription account name</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String SubscriptionAccountName { get; set; }
        /// <summary>Description of the subscription</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String SubscriptionDescription { get; set; }
        /// <summary>Subscription number</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? SubscriptionNumber { get; set; }
        /// <summary>Type of the transaction</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int16? Type { get; set; }
    }
}
