namespace ExactOnline.Client.Models.Project
{
    using System;

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class TimeAndBillingEntryRecentActivitiesAndExpense
    {
        /// <summary>Date last used</summary>
        public DateTime DateLastUsed { get; set; }
        /// <summary>Description</summary>
        public string Description { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Description of Parent</summary>
        public string ParentDescription { get; set; }
    }
}