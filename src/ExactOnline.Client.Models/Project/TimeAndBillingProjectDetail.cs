namespace ExactOnline.Client.Models.Project
{
    using System;

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class TimeAndBillingProjectDetail
    {
        /// <summary>The account for this project</summary>
        public Guid? Account { get; set; }
        public string AccountName { get; set; }
        /// <summary>Code of project</summary>
        public string Code { get; set; }
        /// <summary>Description of the project</summary>
        public string Description { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Reference to ProjectTypes</summary>
        public Int32 Type { get; set; }
    }
}