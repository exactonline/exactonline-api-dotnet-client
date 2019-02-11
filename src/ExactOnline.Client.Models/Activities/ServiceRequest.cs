namespace ExactOnline.Client.Models.Activities
{
    using System;
    using System.Collections.Generic;

    [SupportedActionsSDK(true, true, false, false)]
    [DataServiceKey("ID")]
    public class ServiceRequest
    {
        /// <summary>The account that is related to the service request</summary>
        public Guid? Account { get; set; }
        /// <summary>The name of the account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }
        /// <summary>The user that the service request is assigned to</summary>
        public Guid? AssignedTo { get; set; }
        /// <summary>The user name</summary>
        public string AssignedToFullName { get; set; }
        /// <summary>Attachments linked to the service request</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public IEnumerable<Workflow.RequestAttachment> Attachments { get; set; }
        /// <summary>The contact person that is related to the service request</summary>
        public Guid? Contact { get; set; }
        /// <summary>The name of the contact person</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ContactFullName { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of the creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of the creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>The description</summary>
        public string Description { get; set; }
        /// <summary>The division</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>The document that is linked to the service request</summary>
        public Guid? Document { get; set; }
        /// <summary>The subject of the document</summary>
        public string DocumentSubject { get; set; }
        /// <summary>The human readable key</summary>
        public Int32? HID { get; set; }
        /// <summary>The Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of the last modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of the last modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>The date indicating by when the next action has to be taken</summary>
        public DateTime? NextAction { get; set; }
        /// <summary>The notes of the service request</summary>
        public string Notes { get; set; }
        /// <summary>The date the service request was received</summary>
        public DateTime? ReceiptDate { get; set; }
        /// <summary>Status: 0 = Void, 5 = Rejected, 10 = Draft, 20 = Open, 30 = Approved, 40 = Realized, 50 = Processed </summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Status { get; set; }
        /// <summary>The description of the status</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string StatusDescription { get; set; }
    }
}