namespace ExactOnline.Client.Models.Documents
{
    using System;

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class DocumentTypeCategory
    {
        /// <summary>Creation date</summary>
        public DateTime? Created { get; set; }
        /// <summary>Document category type description</summary>
        public string Description { get; set; }
        /// <summary>Primary key</summary>
        public Int32 ID { get; set; }
        /// <summary>Last modified date</summary>
        public DateTime? Modified { get; set; }
    }
}