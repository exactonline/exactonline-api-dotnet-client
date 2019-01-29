namespace ExactOnline.Client.Models.Project
{
    using System;

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ProjectId")]
    public class TimeAndBillingEntryProject
    {
        /// <summary>Code</summary>
        public string ProjectCode { get; set; }
        /// <summary>Description</summary>
        public string ProjectDescription { get; set; }
        /// <summary>Primary key</summary>
        public Guid ProjectId { get; set; }
    }
}