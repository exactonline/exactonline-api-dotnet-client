using System;

namespace ExactOnline.Client.Models.Assets
{
    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class Asset
    {
        /// <summary>Indicates if an asset was already depreciated before registering it in Exact Online</summary>
        public byte AlreadyDepreciated { get; set; }
        /// <summary>In case of a transfer or a split, the original asset ID is saved in this field. This is done to provide tracability of the Asset</summary>
        public Guid? AssetFrom { get; set; }
        /// <summary>Description of AssetFrom</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AssetFromDescription { get; set; }
        /// <summary>Asset group identifies GLAccounts to be used for Asset transactions</summary>
        public Guid? AssetGroup { get; set; }
        /// <summary>Code of the asset group</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AssetGroupCode { get; set; }
        /// <summary>Description of the asset group</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AssetGroupDescription { get; set; }
        /// <summary>The catalogue value of the asset</summary>
        public double? CatalogueValue { get; set; }
        /// <summary>Code of the asset</summary>
        public string Code { get; set; }
        /// <summary>Assets can be linked to a cost center</summary>
        public string Costcenter { get; set; }
        /// <summary>Description of Costcenter</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CostcenterDescription { get; set; }
        /// <summary>Assets can be linked to a cost unit</summary>
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
        /// <summary>Used for Belgium legislation. Used to produce the official &apos;Investment deduction&apos; report</summary>
        public double? DeductionPercentage { get; set; }
        /// <summary>Amount that is already depreciated when adding an existing asset. Can only be filled when &apos;Alreadydepreciated&apos; is on</summary>
        public double? DepreciatedAmount { get; set; }
        /// <summary>Number of periods that already have been depreciated for the asset. Can only be filled when &apos;Alreadydepreciated&apos; is on</summary>
        public Int32? DepreciatedPeriods { get; set; }
        /// <summary>StartDate of depreciating. Can only be filled when &apos;Alreadydepreciated&apos; is on</summary>
        public DateTime? DepreciatedStartDate { get; set; }
        /// <summary>This is the description of the Asset</summary>
        public string Description { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Asset EndDate is filled when asset is Sold or Inactive</summary>
        public DateTime? EndDate { get; set; }
        /// <summary>Engine emission of the asset, needed to calculate the co² report</summary>
        public Int16? EngineEmission { get; set; }
        /// <summary>Engine type of the asset, Needed to generate a co² report</summary>
        public Int16? EngineType { get; set; }
        /// <summary>Links to the gltransactions.id. GL transaction line based on which the asset is created</summary>
        public Guid? GLTransactionLine { get; set; }
        /// <summary>Description of GLTransactionLine</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLTransactionLineDescription { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Supplier of the asset</summary>
        public Guid? InvestmentAccount { get; set; }
        /// <summary>Code of InvestmentAccount</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string InvestmentAccountCode { get; set; }
        /// <summary>Name of InvestmentAccount</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string InvestmentAccountName { get; set; }
        /// <summary>Investment amount in the default currency of the company</summary>
        public double? InvestmentAmountDC { get; set; }
        /// <summary>Investment value of the asset. Currently the field is filled with the PurchasePriceLocal. Can be status &apos;Not used&apos; after sources have been cleaned</summary>
        public double? InvestmentAmountFC { get; set; }
        /// <summary>Indicates the currency of the investment amount</summary>
        public string InvestmentCurrency { get; set; }
        /// <summary>Description of InvestmentCurrency</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string InvestmentCurrencyDescription { get; set; }
        /// <summary>Refers to the original date when the asset was bought</summary>
        public DateTime? InvestmentDate { get; set; }
        /// <summary>Belgian functionality, to determine how a local legal report regarding investment deduction must be created</summary>
        public Int16? InvestmentDeduction { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>Extra remarks for the asset</summary>
        public string Notes { get; set; }
        /// <summary>Parent asset</summary>
        public Guid? Parent { get; set; }
        /// <summary>Code of Parent</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ParentCode { get; set; }
        /// <summary>Description of Parent</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ParentDescription { get; set; }
        /// <summary>Image for an asset</summary>
        public byte[] Picture { get; set; }
        /// <summary>Filename of the image</summary>
        public string PictureFileName { get; set; }
        /// <summary>First method of depreciation. Currently, it is the only one used</summary>
        public Guid? PrimaryMethod { get; set; }
        /// <summary>Code of PrimaryMethod</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PrimaryMethodCode { get; set; }
        /// <summary>Description of PrimaryMethod</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PrimaryMethodDescription { get; set; }
        /// <summary>Indicates the residual value of the asset at the end of the depreciation</summary>
        public double? ResidualValue { get; set; }
        /// <summary>Asset Depreciation StartDate</summary>
        public DateTime? StartDate { get; set; }
        /// <summary>Identifies the status of the Asset. (see AssetStatus table to see the possibilities)</summary>
        public Int16? Status { get; set; }
        /// <summary>Reference to Transaction</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? TransactionEntryID { get; set; }
        /// <summary>Entry number of transaction</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? TransactionEntryNo { get; set; }
    }
}
