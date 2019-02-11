namespace ExactOnline.Client.Models.Financial
{
    using System;

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class GLAccount
    {
        /// <summary>AssimilatedVATBox (France)</summary>
        public Int16? AssimilatedVATBox { get; set; }
        /// <summary>The following values are supported: D (Debit) C (Credit)</summary>
        public string BalanceSide { get; set; }
        /// <summary>The following values are supported: B (Balance Sheet) W (Profit &amp; Loss)</summary>
        public string BalanceType { get; set; }
        /// <summary>Indentify the kind of rewarding for the G/L account. This is used in the official document for the fiscal fiches Belcotax</summary>
        public Int32? BelcotaxType { get; set; }
        /// <summary>Unique Code of the G/L account</summary>
        public string Code { get; set; }
        /// <summary>Indicate if this G/L account should be shown as compressed without the details in the CRW report of G/L history</summary>
        public bool? Compress { get; set; }
        /// <summary>Cost Center linked to the G/L account</summary>
        public string Costcenter { get; set; }
        /// <summary>Description of Costcenter</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CostcenterDescription { get; set; }
        /// <summary>Cost Unit linked to the G/L account</summary>
        public string Costunit { get; set; }
        /// <summary>Description of Costunit</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CostunitDescription { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>Name of the G/L account</summary>
        public string Description { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        /// <summary>General ledger transactions on this G/L account should not appear on the VAT listing</summary>
        public byte ExcludeVATListing { get; set; }
        /// <summary>Expenses on this G/L account can not be used to reduce the incomes</summary>
        public double? ExpenseNonDeductiblePercentage { get; set; }
        /// <summary>Primary Key</summary>
        public Guid ID { get; set; }
        /// <summary>When blocked you can&apos;t use this general ledger account anymore for new entries</summary>
        public bool? IsBlocked { get; set; }
        /// <summary>Allow entries on this general ledger account to be matched via the G/L account card</summary>
        public bool? Matching { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>If a private use percentage is defined, you need to specify the G/L account used for the re-invoice of the private use to the owner of the company</summary>
        public Guid? PrivateGLAccount { get; set; }
        /// <summary>Specify the percentage of the cost that should be re-invoiced to the owner of the company as private use of the costs</summary>
        public double? PrivatePercentage { get; set; }
        /// <summary>Used in the export of yearly report</summary>
        public string ReportingCode { get; set; }
        /// <summary>Indicates if the amounts booked on this general ledger account will be recalculated when currency revaluation is done</summary>
        public bool? RevalueCurrency { get; set; }
        /// <summary>Search Code</summary>
        public string SearchCode { get; set; }
        /// <summary>The type of the G/L account. Supported values are:&lt;br&gt;10 = Cash&lt;br&gt;12 = Bank&lt;br&gt;14 = Credit card&lt;br&gt;16 = Payment services&lt;br&gt;20 = Accounts receivable&lt;br&gt;21 = Prepayment accounts receivable&lt;br&gt;22 = Accounts payable&lt;br&gt;24 = VAT&lt;br&gt;25 = Employees payable&lt;br&gt;26 = Prepaid expenses&lt;br&gt;27 = Accrued expenses&lt;br&gt;29 = Income taxes payable&lt;br&gt;30 = Fixed assets&lt;br&gt;32 = Other assets&lt;br&gt;35 = Accumulated depreciation&lt;br&gt;40 = Inventory&lt;br&gt;50 = Capital stock&lt;br&gt;52 = Retained earnings&lt;br&gt;55 = Long term debt&lt;br&gt;60 = Current portion of debt&lt;br&gt;90 = General&lt;br&gt;100 = Tax payable&lt;br&gt;110 = Revenue&lt;br&gt;111 = Cost of goods&lt;br&gt;120 = Other costs&lt;br&gt;121 = Sales, general administrative expenses&lt;br&gt;122 = Depreciation costs&lt;br&gt;123 = Research and development&lt;br&gt;125 = Employee costs&lt;br&gt;126 = Employment costs&lt;br&gt;130 = Exceptional costs&lt;br&gt;140 = Exceptional income&lt;br&gt;150 = Income taxes&lt;br&gt;160 = Interest income&lt;br&gt;300 = Year end reflection&lt;br&gt;301 = Indirect year end costing&lt;br&gt;302 = Direct year end costing&lt;br&gt;</summary>
        public Int32? Type { get; set; }
        /// <summary>Description of Type</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string TypeDescription { get; set; }
        /// <summary>Indicates if cost centers can be used when using this general ledger account. The following values are supported: 0 (Optional) 1 (Mandatory) 2 (No)</summary>
        public byte? UseCostcenter { get; set; }
        /// <summary>Indicates if cost units can be used when using this general ledger account. The following values are supported: 0 (Optional) 1 (Mandatory) 2 (No)</summary>
        public byte? UseCostunit { get; set; }
        /// <summary>VAT Code linked to the G/L account</summary>
        public string VATCode { get; set; }
        /// <summary>Description of VAT</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string VATDescription { get; set; }
        /// <summary>Specify the kind of purchase this G/L account is used for. This is important for the Belgian VAT return to indicate in which VAT box the base amount of purchase should go</summary>
        public string VATGLAccountType { get; set; }
        /// <summary>If you use a percentage of non deductible VAT, you can specify another G/L account that will be used for the non deductible part of the VAT amount. This is used directly in the entry application of purchase invoices.</summary>
        public Guid? VATNonDeductibleGLAccount { get; set; }
        /// <summary>If not the full amount of the VAT is deductible, you can indicate a percentage for the non decuctible part. This is used during the entry of purchase invoices</summary>
        public double? VATNonDeductiblePercentage { get; set; }
        /// <summary>The following values are supported: I (Invoice) C (Cash) (France)</summary>
        public string VATSystem { get; set; }
        /// <summary>Indicates the costing account for year end calculations</summary>
        public Guid? YearEndCostGLAccount { get; set; }
        /// <summary>Indicates the reflection account that is used by year end application</summary>
        public Guid? YearEndReflectionGLAccount { get; set; }
    }
}