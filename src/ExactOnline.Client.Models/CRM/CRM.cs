using System.Collections.Generic;
using System;

namespace ExactOnline.Client.Models.CRM
{
    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class Document
    {
        /// <summary>ID of the related account of this document</summary>
        public Guid? Account { get; set; }
        /// <summary>Attachments linked to the document. Binaries are not sent in the response.</summary>
        public IEnumerable<ExactOnline.Client.Models.CRM.DocumentsAttachment> Attachments { get; set; }
        /// <summary>Body of this document</summary>
        public String Body { get; set; }
        /// <summary>ID of the related contact of this document</summary>
        public Guid? Contact { get; set; }
        /// <summary>Creation date</summary>
        public DateTime Created { get; set; }
        /// <summary>User ID of creator</summary>
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        public String CreatorFullName { get; set; }
        /// <summary>Division code</summary>
        public Int32 Division { get; set; }
        /// <summary>Entry date of the incoming document</summary>
        public DateTime? DocumentDate { get; set; }
        /// <summary>Id of document folder</summary>
        public Guid? DocumentFolder { get; set; }
        /// <summary>Url to view the document</summary>
        public String DocumentViewUrl { get; set; }
        /// <summary>Indicates that the document body is empty</summary>
        public Boolean HasEmptyBody { get; set; }
        /// <summary>Human-readable ID, formatted as xx.xxx.xxx. Unique. May not be equal to zero</summary>
        public Int32 HID { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Last modified date</summary>
        public DateTime Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        public Guid? Modifier { get; set; }
        /// <summary>The opportunity linked to the document</summary>
        public Guid? Opportunity { get; set; }
        /// <summary>Purchase invoice number.</summary>
        public Int32? PurchaseInvoiceNumber { get; set; }
        /// <summary>Purchase order number.</summary>
        public Int32? PurchaseOrderNumber { get; set; }
        /// <summary>&apos;Our reference&apos; of the transaction that belongs to this document</summary>
        public Int32? SalesInvoiceNumber { get; set; }
        /// <summary>Number of the sales order</summary>
        public Int32? SalesOrderNumber { get; set; }
        /// <summary>Send Method</summary>
        public Int32? SendMethod { get; set; }
        public Int32 Share { get; set; }
        /// <summary>Subject of this document</summary>
        public String Subject { get; set; }
        /// <summary>The document type</summary>
        public Int32 Type { get; set; }
        /// <summary>Translated description of the document type. $filter and $orderby are not supported for this property.</summary>
        public String TypeDescription { get; set; }
        /// <summary>Translation id of the document type description</summary>
        public Int32 TypeDescriptionTermId { get; set; }
        /// <summary>English description of the document type</summary>
        public String UntermedTypeDescription { get; set; }
    }
}
