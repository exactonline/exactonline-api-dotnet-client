namespace ExactOnline.Client.Models.Project
{
    using System;

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ProjectId")]
    public class TimeAndBillingEntryRecentProject
    {
        /// <summary>Date last used</summary>
        public DateTime DateLastUsed { get; set; }
        /// <summary>Code of project</summary>
        public string ProjectCode { get; set; }
        /// <summary>Description of project</summary>
        public string ProjectDescription { get; set; }
        /// <summary>Primary key</summary>
        public Guid ProjectId { get; set; }
    }
}