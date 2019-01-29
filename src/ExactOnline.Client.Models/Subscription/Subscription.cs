namespace ExactOnline.Client.Models.Subscription
{
    using global::System;
    using global::System.Collections.Generic;

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("EntryID")]
    public class Subscription
    {
        /// <summary>Indicates if subscription is blocked for time cost entry</summary>
        public bool? BlockEntry { get; set; }
        /// <summary>Date of cancellation</summary>
        public DateTime? CancellationDate { get; set; }
        /// <summary>Reference to Classification</summary>
        public Guid? Classification { get; set; }
        /// <summary>Code of Classification</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ClassificationCode { get; set; }
        /// <summary>Description of Classification</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ClassificationDescription { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>Currency code</summary>
        public string Currency { get; set; }
        /// <summary>Purchase order number of customer</summary>
        public string CustomerPONumber { get; set; }
        /// <summary>Description</summary>
        public string Description { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        /// <summary>End date</summary>
        public DateTime? EndDate { get; set; }
        /// <summary>Primary key</summary>
        public Guid EntryID { get; set; }
        /// <summary>Invoice Day</summary>
        public byte? InvoiceDay { get; set; }
        /// <summary>Invoice date</summary>
        public DateTime? InvoicedTo { get; set; }
        /// <summary>Reference to invoice account</summary>
        public Guid? InvoiceTo { get; set; }
        /// <summary>Reference to contact person of invoice account</summary>
        public Guid? InvoiceToContactPerson { get; set; }
        /// <summary>Name of contact person of invoice account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string InvoiceToContactPersonFullName { get; set; }
        /// <summary>Name of invoice account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string InvoiceToName { get; set; }
        /// <summary>Invoicing start date</summary>
        public DateTime? InvoicingStartDate { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>Remarks</summary>
        public string Notes { get; set; }
        /// <summary>Number</summary>
        public Int32 Number { get; set; }
        /// <summary>Reference to order account</summary>
        public Guid? OrderedBy { get; set; }
        /// <summary>Reference of contact person of order account</summary>
        public Guid? OrderedByContactPerson { get; set; }
        /// <summary>Name of contact person of order account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string OrderedByContactPersonFullName { get; set; }
        /// <summary>Name of order account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string OrderedByName { get; set; }
        /// <summary>Payment condition</summary>
        public string PaymentCondition { get; set; }
        /// <summary>Description of PaymentCondition</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PaymentConditionDescription { get; set; }
        /// <summary>Indicates if subscription is printed</summary>
        public bool Printed { get; set; }
        /// <summary>Reference to reason cancelled</summary>
        public Guid? ReasonCancelled { get; set; }
        /// <summary>Code of ReasonCancelled</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ReasonCancelledCode { get; set; }
        /// <summary>Description of ReasonCancelled</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ReasonCancelledDescription { get; set; }
        /// <summary>Start date</summary>
        public DateTime StartDate { get; set; }
        /// <summary>Collection of subscription lines</summary>
        public IEnumerable<SubscriptionLine> SubscriptionLines { get; set; }
        /// <summary>Collection of restriction employees</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public IEnumerable<SubscriptionRestrictionEmployee> SubscriptionRestrictionEmployees { get; set; }
        /// <summary>Collection of restriction items</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public IEnumerable<SubscriptionRestrictionItem> SubscriptionRestrictionItems { get; set; }
        /// <summary>Reference to subscription type</summary>
        public Guid SubscriptionType { get; set; }
        /// <summary>Code of SubscriptionType</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SubscriptionTypeCode { get; set; }
        /// <summary>Description of SubscriptionType</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SubscriptionTypeDescription { get; set; }
    }
}
