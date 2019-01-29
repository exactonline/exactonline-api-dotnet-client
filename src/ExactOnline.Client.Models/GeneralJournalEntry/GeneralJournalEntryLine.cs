namespace ExactOnline.Client.Models.GeneralJournalEntry
{
    using System;

    [SupportedActionsSDK(true, true, false, false)]
    [DataServiceKey("ID")]
    public class GeneralJournalEntryLine
    {
        /// <summary>Reference to account</summary>
        public Guid? Account { get; set; }
        /// <summary>Code of Account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountCode { get; set; }
        /// <summary>Name of Account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }
        /// <summary>Amount in the default currency of the company, If an &apos;Including&apos; VAT code is used this amount includes the VAT amount.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? AmountDC { get; set; }
        /// <summary>Amount in the currency of the transaction. If an &apos;Including&apos; VAT code is used this amount includes the VAT amount.</summary>
        public double? AmountFC { get; set; }
        /// <summary>Vat amount in the default currency of the company.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? AmountVATDC { get; set; }
        /// <summary>Vat amount in the currency of the transaction. If you want to set this in a POST you have to specify VATCode as well.</summary>
        public double? AmountVATFC { get; set; }
        /// <summary>Reference to asset</summary>
        public Guid? Asset { get; set; }
        /// <summary>Code of Asset</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AssetCode { get; set; }
        /// <summary>Description of Asset</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AssetDescription { get; set; }
        /// <summary>Reference to cost center</summary>
        public string CostCenter { get; set; }
        /// <summary>Description of CostCenter</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CostCenterDescription { get; set; }
        /// <summary>Reference to cost unit</summary>
        public string CostUnit { get; set; }
        /// <summary>Description of CostUnit</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CostUnitDescription { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>Entry date</summary>
        public DateTime? Date { get; set; }
        /// <summary>Description</summary>
        public string Description { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Reference to document</summary>
        public Guid? Document { get; set; }
        /// <summary>Document number</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? DocumentNumber { get; set; }
        /// <summary>Document subject</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DocumentSubject { get; set; }
        /// <summary>Reference to header of the entry</summary>
        public Guid? EntryID { get; set; }
        /// <summary>Entry number of the header</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? EntryNumber { get; set; }
        /// <summary>General ledger account</summary>
        public Guid? GLAccount { get; set; }
        /// <summary>Code of GLAccount</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLAccountCode { get; set; }
        /// <summary>Description of GLAccount</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLAccountDescription { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Line number</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? LineNumber { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>Extra remarks</summary>
        public string Notes { get; set; }
        public Guid? OffsetID { get; set; }
        /// <summary>Our ref of general journal entry</summary>
        public Int32? OurRef { get; set; }
        /// <summary>Reference to project</summary>
        public Guid? Project { get; set; }
        /// <summary>Code of Project</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectCode { get; set; }
        /// <summary>Description of Project</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }
        /// <summary>Quantity</summary>
        public double? Quantity { get; set; }
        /// <summary>VAT base amount in the default currency of the company</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? VATBaseAmountDC { get; set; }
        /// <summary>VAT base amount in the currency of the transaction</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? VATBaseAmountFC { get; set; }
        /// <summary>VATCode can only be used if the general journal has VAT enabled. VAT Lines will be automatically created if the VATCode is specified when creating a new general journal entry.</summary>
        public string VATCode { get; set; }
        /// <summary>Description of VATCode</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string VATCodeDescription { get; set; }
        /// <summary>Vat percentage</summary>
        public double? VATPercentage { get; set; }
        /// <summary>The VAT type determines what the values are in relation to VAT returns. The following values are supported:&lt;br&gt;A Sales VAT to pay,&lt;br&gt;D Credit note extra duty to claim,&lt;br&gt;I Purchase basis,&lt;br&gt;M Credit note purchase non-deductible,&lt;br&gt;N Purchase non-deductible,&lt;br&gt;O Purchase VAT to claim,&lt;br&gt;P Purchase VAT to pay,&lt;br&gt;Q Credit note purchase VAT to claim,&lt;br&gt;R Extra duty to pay,&lt;br&gt;S No VAT,&lt;br&gt;V Sales basis,&lt;br&gt;W Credit note purchase basis,&lt;br&gt;X Credit note sales basis,&lt;br&gt;Y Credit note purchase VAT to pay,&lt;br&gt;Z Credit note sales VAT to claim</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string VATType { get; set; }
    }
}