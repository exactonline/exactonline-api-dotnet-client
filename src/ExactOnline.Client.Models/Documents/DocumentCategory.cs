namespace ExactOnline.Client.Models.Documents
{
    using System;

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class DocumentCategory
    {
        /// <summary>Creation date</summary>
        public DateTime? Created { get; set; }
        /// <summary>Document category description</summary>
        public string Description { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Last modified date</summary>
        public DateTime? Modified { get; set; }
    }
}