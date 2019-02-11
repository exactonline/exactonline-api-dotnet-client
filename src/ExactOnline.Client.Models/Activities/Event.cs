namespace ExactOnline.Client.Models.Activities
{
    using System;
    using System.Collections.Generic;

    [SupportedActionsSDK(true, true, false, false)]
    [DataServiceKey("ID")]
    public class Event
    {
        /// <summary>The account that is related to the event</summary>
        public Guid? Account { get; set; }
        /// <summary>The name of the account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }
        /// <summary>Attachments linked to the event</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public IEnumerable<Workflow.RequestAttachment> Attachments { get; set; }
        /// <summary>The campaign linked to the event</summary>
        public Guid? Campaign { get; set; }
        /// <summary>Description of the campaign</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CampaignDescription { get; set; }
        /// <summary>The contact person that is related to the event</summary>
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
        /// <summary>The document that is linked to the event</summary>
        public Guid? Document { get; set; }
        /// <summary>The subject of the document</summary>
        public string DocumentSubject { get; set; }
        /// <summary>The end date and time</summary>
        public DateTime? EndDate { get; set; }
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
        /// <summary>The notes of the event</summary>
        public string Notes { get; set; }
        /// <summary>The opportunity linked to the event</summary>
        public Guid? Opportunity { get; set; }
        /// <summary>The name of the opportunity</summary>
        public string OpportunityName { get; set; }
        /// <summary>The project linked to the event</summary>
        public Guid? Project { get; set; }
        /// <summary>The description of the project</summary>
        public string ProjectDescription { get; set; }
        /// <summary>The start date and time</summary>
        public DateTime? StartDate { get; set; }
        /// <summary>Status: 0 = Void, 5 = Rejected, 10 = Draft, 20 = Open, 30 = Approved, 40 = Realized, 50 = Processed </summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Status { get; set; }
        /// <summary>The description of the status</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string StatusDescription { get; set; }
        /// <summary>The user that has the event</summary>
        public Guid? User { get; set; }
        /// <summary>The user name</summary>
        public string UserFullName { get; set; }
    }
}