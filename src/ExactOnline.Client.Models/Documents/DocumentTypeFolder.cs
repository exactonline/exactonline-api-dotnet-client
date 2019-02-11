namespace ExactOnline.Client.Models.Documents
{
    using System;

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class DocumentTypeFolder
    {
        /// <summary>Date created</summary>
        public DateTime Created { get; set; }
        /// <summary>User id of creator</summary>
        public Guid? Creator { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        /// <summary>Folder to which document type is linked</summary>
        public Guid DocumentFolder { get; set; }
        /// <summary>Code of document type which is linked to folder</summary>
        public Int32 DocumentType { get; set; }
        public Guid ID { get; set; }
        /// <summary>Date Modified</summary>
        public DateTime? Modified { get; set; }
        /// <summary>User id of modifier</summary>
        public Guid? Modifier { get; set; }
    }
}