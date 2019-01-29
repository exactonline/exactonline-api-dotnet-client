namespace ExactOnline.Client.Models.Project
{
    using System;

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ItemId")]
    public class TimeAndBillingEntryRecentHourCostType
    {
        /// <summary>Date last used</summary>
        public DateTime DateLastUsed { get; set; }
        /// <summary>Description of item</summary>
        public string ItemDescription { get; set; }
        /// <summary>Primary key</summary>
        public Guid ItemId { get; set; }
    }
}