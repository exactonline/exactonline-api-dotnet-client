namespace ExactOnline.Client.Models.Subscription
{
    using System;

    [SupportedActionsSDK(true, true, false, true)]
    [DataServiceKey("ID")]
    public class SubscriptionRestrictionEmployee
    {
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of the creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of the creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        /// <summary>Employee linked to the restriction</summary>
        public Guid? Employee { get; set; }
        /// <summary>Name of employee</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string EmployeeFullName { get; set; }
        /// <summary>Readable ID of employee</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? EmployeeHID { get; set; }
        /// <summary>Primary key</summary>
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
        /// <summary>Reference to subscription</summary>
        public Guid Subscription { get; set; }
        /// <summary>Description of subscription</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SubscriptionDescription { get; set; }
        /// <summary>Number of subscription</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 SubscriptionNumber { get; set; }
    }
}