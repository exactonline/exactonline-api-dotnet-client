using System;

namespace ExactOnline.Client.Models.CRM
{
    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class Opportunity
    {
        /// <summary>Lead to which the opportunity applies</summary>
        public Guid? Account { get; set; }
        /// <summary>Accountant linked to the opportunity</summary>
        public Guid? Accountant { get; set; }
        /// <summary>Code of the Accountant</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String AccountantCode { get; set; }
        /// <summary>Name of the Accountant</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String AccountantName { get; set; }
        /// <summary>Code of Account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String AccountCode { get; set; }
        /// <summary>Name of Account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String AccountName { get; set; }
        /// <summary>Indicates the date before/on the NextAction is supposed to be done</summary>
        public DateTime? ActionDate { get; set; }
        /// <summary>Amount in the default currency of the company. AmountDC = AmountFC * RateFC</summary>
        public Double? AmountDC { get; set; }
        /// <summary>Amount in the currency of the transaction</summary>
        public Double? AmountFC { get; set; }
        /// <summary>Reference to the campaign opportunity is related to</summary>
        public Guid? Campaign { get; set; }
        /// <summary>Description of Campaign</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String CampaignDescription { get; set; }
        /// <summary>Reference to the channel opportunity is related to</summary>
        public Int16? Channel { get; set; }
        /// <summary>Description of Channel</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ChannelDescription { get; set; }
        /// <summary>The date when the opportunity is expected to be closed</summary>
        public DateTime? CloseDate { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of the creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String CreatorFullName { get; set; }
        /// <summary>Currency code</summary>
        public String Currency { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>The source of the lead/opportunity</summary>
        public Guid? LeadSource { get; set; }
        /// <summary>Description of LeadSource</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String LeadSourceDescription { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of the last modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ModifierFullName { get; set; }
        /// <summary>Name of the opportunity</summary>
        public String Name { get; set; }
        /// <summary>Indicates what follow up action is to be undertaken to move the opportunity towards a deal. Is used in combination with ActionDate</summary>
        public String NextAction { get; set; }
        /// <summary>Notes of the opportunity</summary>
        public String Notes { get; set; }
        /// <summary>Code of Opportunity Department</summary>
        public Int16? OpportunityDepartmentCode { get; set; }
        /// <summary>Description of Opportunity Department</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String OpportunityDepartmentDescription { get; set; }
        /// <summary>The stage of the opportunity. This is a list defined by the user</summary>
        public Guid? OpportunityStage { get; set; }
        /// <summary>Description of OpportunityStage</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String OpportunityStageDescription { get; set; }
        /// <summary>Status: 1=Open, 2=Closed won, 3=Closed lost</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? OpportunityStatus { get; set; }
        /// <summary>Code of Opportunity Type</summary>
        public Int16? OpportunityType { get; set; }
        /// <summary>Description of Opportunity Type</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String OpportunityTypeDescription { get; set; }
        /// <summary>The resource who owns the opportunity and is responsible to close the opportunity (either won or lost)</summary>
        public Guid? Owner { get; set; }
        /// <summary>Name of Owner</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String OwnerFullName { get; set; }
        /// <summary>The chance that the opportunity will be closed and won. The default for the probability depends on the default from the opportunity stage</summary>
        public Double? Probability { get; set; }
        /// <summary>Reference to project</summary>
        public Guid? Project { get; set; }
        /// <summary>Code of Project</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ProjectCode { get; set; }
        /// <summary>Description of Project</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ProjectDescription { get; set; }
        /// <summary>Exchange rate from original to division currency</summary>
        public Double? RateFC { get; set; }
        /// <summary>Indicates the reason why the opportunity was lost.</summary>
        public Guid? ReasonCode { get; set; }
        /// <summary>Description of ReasonCode</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ReasonCodeDescription { get; set; }
        /// <summary>Reseller linked to the opportunity</summary>
        public Guid? Reseller { get; set; }
        /// <summary>Code of the Reseller</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ResellerCode { get; set; }
        /// <summary>Name of the Reseller</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ResellerName { get; set; }
        /// <summary>Reference to Sales type</summary>
        public Guid? SalesType { get; set; }
        /// <summary>Description of SalesType</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String SalesTypeDescription { get; set; }
    }
}