namespace ExactOnline.Client.Models.Project
{
    using System;

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("AccountId")]
    public class TimeAndBillingEntryRecentAccount
    {
        /// <summary>Primary key</summary>
        public Guid AccountId { get; set; }
        /// <summary>Name of account</summary>
        public string AccountName { get; set; }
        /// <summary>Date last used</summary>
        public DateTime DateLastUsed { get; set; }
    }
}