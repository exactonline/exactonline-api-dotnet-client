namespace ExactOnline.Client.Models.HRM
{
    using System;

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class JobTitle
    {
        /// <summary>Job title code</summary>
        public string Code { get; set; }
        /// <summary>Creation date</summary>
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        public string CreatorFullName { get; set; }
        /// <summary>Job title description</summary>
        public string Description { get; set; }
        /// <summary>Division code</summary>
        public Int32? Division { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Reference job code</summary>
        public string JobCode { get; set; }
        /// <summary>Group this job title belongs to</summary>
        public Guid? JobGroup { get; set; }
        /// <summary>Job group code</summary>
        public string JobGroupCode { get; set; }
        /// <summary>Job group description</summary>
        public string JobGroupDescription { get; set; }
        /// <summary>Job title represents job level from</summary>
        public Int32? JobLevelFrom { get; set; }
        /// <summary>Job title represents job level to</summary>
        public Int32? JobLevelTo { get; set; }
        /// <summary>Last modified date</summary>
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        public string ModifierFullName { get; set; }
        /// <summary>Explanation or extra information can be stored in the notes</summary>
        public string Notes { get; set; }
    }
}