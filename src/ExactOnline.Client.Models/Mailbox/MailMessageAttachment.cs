namespace ExactOnline.Client.Models.Mailbox
{
    using System;

    [SupportedActionsSDK(true, true, false, false)]
    [DataServiceKey("ID")]
    public class MailMessageAttachment
    {
        /// <summary>For performance reasons Attachment is Write-Only. The blob can be downloaded using the supplied Url</summary>
        public byte[] Attachment { get; set; }
        /// <summary>File extension of attachment</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AttachmentFileExtension { get; set; }
        /// <summary>File name of attachment</summary>
        public string AttachmentFileName { get; set; }
        /// <summary>File size</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int64 FileSize { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Reference to Mail message</summary>
        public Guid MailMessageID { get; set; }
        /// <summary>Reference to recipient account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? RecipientAccount { get; set; }
        /// <summary>Reference to sender account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? SenderAccount { get; set; }
        /// <summary>Type of mail message attachment</summary>
        public Int32 Type { get; set; }
        /// <summary>Description of Type</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string TypeDescription { get; set; }
        /// <summary>To get the file in its original format (xml, jpg, pdf, etc.) append &lt;b&gt;&amp;Download=1&lt;/b&gt; to the url.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Url { get; set; }
    }
}