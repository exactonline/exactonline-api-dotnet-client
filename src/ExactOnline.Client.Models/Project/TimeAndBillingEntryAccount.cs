namespace ExactOnline.Client.Models.Project
{
    using System;

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("AccountId")]
    public class TimeAndBillingEntryAccount
    {
        /// <summary>Primary key</summary>
        public Guid AccountId { get; set; }
        /// <summary>Name of account</summary>
        public string AccountName { get; set; }
    }
}