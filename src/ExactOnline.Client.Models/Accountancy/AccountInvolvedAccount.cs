using System;

namespace ExactOnline.Client.Models.Accountancy
{
    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class AccountInvolvedAccount
    {
        /// <summary>ID of account</summary>
        public Guid? Account { get; set; }
        /// <summary>Name of account</summary>
        public string AccountName { get; set; }
        /// <summary>Creation date</summary>
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        public string CreatorFullName { get; set; }
        /// <summary>Division code</summary>
        public Int32? Division { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>ID of involved account</summary>
        public Guid? InvolvedAccount { get; set; }
        /// <summary>Description of relation type</summary>
        public string InvolvedAccountRelationTypeDescription { get; set; }
        /// <summary>TermId of description of relation type</summary>
        public Int32? InvolvedAccountRelationTypeDescriptionTermId { get; set; }
        /// <summary>ID of relation type</summary>
        public Int16? InvolvedAccountRelationTypeId { get; set; }
        /// <summary>Last modified date</summary>
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        public string ModifierFullName { get; set; }
        /// <summary>Use to record details of important information</summary>
        public string Notes { get; set; }
    }
}
