namespace ExactOnline.Client.Models.Bulk
{
    using System;

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class DocumentAttachment
    {
        /// <summary>Contains the attachment</summary>
        public byte[] Attachment { get; set; }
        /// <summary>Reference to the Document</summary>
        public Guid Document { get; set; }
        /// <summary>Filename of the attachment</summary>
        public string FileName { get; set; }
        /// <summary>File size of the attachment</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double FileSize { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Url of the attachment. To get the file in its original format (xml, jpg, pdf, etc.) append &lt;b&gt;&amp;Download=1&lt;/b&gt; to the url.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Url { get; set; }
    }
}