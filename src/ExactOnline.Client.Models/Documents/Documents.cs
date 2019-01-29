using System;

namespace ExactOnline.Client.Models.Documents
{
    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class Document
    {
        /// <summary>ID of the related account of this document</summary>
        public Guid? Account { get; set; }
        /// <summary>Code of Account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountCode { get; set; }
        /// <summary>Name of Account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }
        /// <summary>Amount in the currency of the transaction</summary>
        public double? AmountFC { get; set; }
        /// <summary>Body of this document</summary>
        public string Body { get; set; }
        /// <summary>ID of the category of this document</summary>
        public Guid? Category { get; set; }
        /// <summary>Description of Category</summary>
        public string CategoryDescription { get; set; }
        /// <summary>ID of the related contact of this document</summary>
        public Guid? Contact { get; set; }
        /// <summary>Contact full name</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ContactFullName { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        public string CreatorFullName { get; set; }
        /// <summary>Currency code</summary>
        public string Currency { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        /// <summary>Entry date of the incoming document</summary>
        public DateTime? DocumentDate { get; set; }
        /// <summary>The Id of document folder</summary>
        public Guid? DocumentFolder { get; set; }
        /// <summary>The Code of document folder</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DocumentFolderCode { get; set; }
        /// <summary>The Decsription of document folder</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DocumentFolderDescription { get; set; }
        /// <summary>Url to view the document</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DocumentViewUrl { get; set; }
        /// <summary>Reference to the financial transaction</summary>
        public Guid? FinancialTransactionEntryID { get; set; }
        /// <summary>Indicates that the document body is empty</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public bool HasEmptyBody { get; set; }
        /// <summary>Human-readable ID, formatted as xx.xxx.xxx. Unique. May not be equal to zero</summary>
        public Int32? HID { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>The language code of the document</summary>
        public string Language { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>The opportunity linked to the document</summary>
        public Guid? Opportunity { get; set; }
        /// <summary>The project linked to the document</summary>
        public Guid? Project { get; set; }
        /// <summary>Code of project</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectCode { get; set; }
        /// <summary>Description of project</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }
        /// <summary>&apos;Our reference&apos; of the transaction that belongs to this document</summary>
        public Int32? SalesInvoiceNumber { get; set; }
        /// <summary>Number of the sales order</summary>
        public Int32? SalesOrderNumber { get; set; }
        /// <summary>Send method</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? SendMethod { get; set; }
        /// <summary>Number of the shop order</summary>
        public Int32? ShopOrderNumber { get; set; }
        /// <summary>Subject of this document</summary>
        public string Subject { get; set; }
        /// <summary>ID of the type of this document</summary>
        public Int32? Type { get; set; }
        /// <summary>Description of Type</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string TypeDescription { get; set; }
    }

}
