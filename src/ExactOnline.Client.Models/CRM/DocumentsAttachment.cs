namespace ExactOnline.Client.Models.CRM
{
    using System;

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class DocumentsAttachment
    {
        /// <summary>Filename of the attachment</summary>
        public String AttachmentFileName { get; set; }
        /// <summary>File size of the attachment</summary>
        public Double AttachmentFileSize { get; set; }
        /// <summary>Url for downloading the attachment. To get the file in its original format (xml, jpg, pdf, etc.) append &lt;b&gt;&amp;Download=1&lt;/b&gt; to the url.</summary>
        public String AttachmentUrl { get; set; }

        public Boolean CanShowInWebView { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
    }
}