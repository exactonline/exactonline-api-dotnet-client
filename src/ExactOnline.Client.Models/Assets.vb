Namespace Assets

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [Asset]
		'''<summary>Indicates if an asset was already depreciated before registering it in Exact Online</summary>
		Public Property [AlreadyDepreciated] As Byte
		'''<summary>In case of a transfer or a split, the original asset ID is saved in this field. This is done to provide tracability of the Asset</summary>
		Public Property [AssetFrom] As Guid?
		'''<summary>Description of AssetFrom</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AssetFromDescription] As String
		'''<summary>Asset group identifies GLAccounts to be used for Asset transactions</summary>
		Public Property [AssetGroup] As Guid?
		'''<summary>Code of the asset group</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AssetGroupCode] As String
		'''<summary>Description of the asset group</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AssetGroupDescription] As String
		'''<summary>The catalogue value of the asset</summary>
		Public Property [CatalogueValue] As Double?
		'''<summary>Code of the asset</summary>
		Public Property [Code] As String
		'''<summary>Assets can be linked to a cost center</summary>
		Public Property [Costcenter] As String
		'''<summary>Description of Costcenter</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CostcenterDescription] As String
		'''<summary>Assets can be linked to a cost unit</summary>
		Public Property [Costunit] As String
		'''<summary>Description of Costunit</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CostunitDescription] As String
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<summary>User ID of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>Used for Belgium legislation. Used to produce the official &apos;Investment deduction&apos; report</summary>
		Public Property [DeductionPercentage] As Double?
		'''<summary>Amount that is already depreciated when adding an existing asset. Can only be filled when &apos;Alreadydepreciated&apos; is on</summary>
		Public Property [DepreciatedAmount] As Double?
		'''<summary>Number of periods that already have been depreciated for the asset. Can only be filled when &apos;Alreadydepreciated&apos; is on</summary>
		Public Property [DepreciatedPeriods] As Int32?
		'''<summary>StartDate of depreciating. Can only be filled when &apos;Alreadydepreciated&apos; is on</summary>
		Public Property [DepreciatedStartDate] As DateTime?
		'''<summary>This is the description of the Asset</summary>
		Public Property [Description] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<summary>Asset EndDate is filled when asset is Sold or Inactive</summary>
		Public Property [EndDate] As DateTime?
		'''<summary>Engine emission of the asset, needed to calculate the co² report</summary>
		Public Property [EngineEmission] As Int16?
		'''<summary>Engine type of the asset, Needed to generate a co² report</summary>
		Public Property [EngineType] As Int16?
		'''<summary>Links to the gltransactions.id. GL transaction line based on which the asset is created</summary>
		Public Property [GLTransactionLine] As Guid?
		'''<summary>Description of GLTransactionLine</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLTransactionLineDescription] As String
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Supplier of the asset</summary>
		Public Property [InvestmentAccount] As Guid?
		'''<summary>Code of InvestmentAccount</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [InvestmentAccountCode] As String
		'''<summary>Name of InvestmentAccount</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [InvestmentAccountName] As String
		'''<summary>Investment amount in the default currency of the company</summary>
		Public Property [InvestmentAmountDC] As Double?
		'''<summary>Investment value of the asset. Currently the field is filled with the PurchasePriceLocal. Can be status &apos;Not used&apos; after sources have been cleaned</summary>
		Public Property [InvestmentAmountFC] As Double?
		'''<summary>Indicates the currency of the investment amount</summary>
		Public Property [InvestmentCurrency] As String
		'''<summary>Description of InvestmentCurrency</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [InvestmentCurrencyDescription] As String
		'''<summary>Refers to the original date when the asset was bought</summary>
		Public Property [InvestmentDate] As DateTime?
		'''<summary>Belgian functionality, to determine how a local legal report regarding investment deduction must be created</summary>
		Public Property [InvestmentDeduction] As Int16?
		'''<summary>Last modified date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<summary>User ID of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Name of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>Extra remarks for the asset</summary>
		Public Property [Notes] As String
		'''<summary>Parent asset</summary>
		Public Property [Parent] As Guid?
		'''<summary>Code of Parent</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ParentCode] As String
		'''<summary>Description of Parent</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ParentDescription] As String
		'''<summary>Image for an asset</summary>
		Public Property [Picture] As Byte()
		'''<summary>Filename of the image</summary>
		Public Property [PictureFileName] As String
		'''<summary>First method of depreciation. Currently, it is the only one used</summary>
		Public Property [PrimaryMethod] As Guid?
		'''<summary>Code of PrimaryMethod</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PrimaryMethodCode] As String
		'''<summary>Description of PrimaryMethod</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PrimaryMethodDescription] As String
		'''<summary>Indicates the residual value of the asset at the end of the depreciation</summary>
		Public Property [ResidualValue] As Double?
		'''<summary>Asset Depreciation StartDate</summary>
		Public Property [StartDate] As DateTime?
		'''<summary>Identifies the status of the Asset. (see AssetStatus table to see the possibilities)</summary>
		Public Property [Status] As Int16?
		'''<summary>Reference to the transaction lines that make up the financial entry.</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [TransactionEntryID] As Guid?
		'''<summary>Entry number of transaction</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [TransactionEntryNo] As Int32?
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [AssetGroup]
		'''<summary>Code of the asset group</summary>
		Public Property [Code] As String
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<summary>User ID of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>Default depreciation method of the assets in this asset group</summary>
		Public Property [DepreciationMethod] As Guid?
		'''<summary>Code of the depreciation method</summary>
		Public Property [DepreciationMethodCode] As String
		'''<summary>Description of the depreciation method</summary>
		Public Property [DepreciationMethodDescription] As String
		'''<summary>Description of the asset group</summary>
		Public Property [Description] As String
		'''<summary>Division code</summary>
		Public Property [Division] As Int32?
		'''<summary>GLAccount for the assets</summary>
		Public Property [GLAccountAssets] As Guid?
		'''<summary>Code of the GLAccount for the assets</summary>
		Public Property [GLAccountAssetsCode] As String
		'''<summary>Description of the GLAccount for the assets</summary>
		Public Property [GLAccountAssetsDescription] As String
		'''<summary>GLAccount for depreciation (Balance sheet)</summary>
		Public Property [GLAccountDepreciationBS] As Guid?
		'''<summary>Code of the GLAccount for depreciation (Balance sheet)</summary>
		Public Property [GLAccountDepreciationBSCode] As String
		'''<summary>Description of the GLAccount for depreciation (Balance sheet)</summary>
		Public Property [GLAccountDepreciationBSDescription] As String
		'''<summary>GLAccount for depreciation (Profit &amp; Loss)</summary>
		Public Property [GLAccountDepreciationPL] As Guid?
		'''<summary>Code of the GLAccount for depreciation (Profit &amp; Loss)</summary>
		Public Property [GLAccountDepreciationPLCode] As String
		'''<summary>Description of the GLAccount for depreciation (Profit &amp; Loss)</summary>
		Public Property [GLAccountDepreciationPLDescription] As String
		'''<summary>GLAccount for revaluation (Balance sheet)</summary>
		Public Property [GLAccountRevaluationBS] As Guid?
		'''<summary>Code of the GLAccount for revaluation (Balance sheet)</summary>
		Public Property [GLAccountRevaluationBSCode] As String
		'''<summary>Description of the GLAccount for revaluation (Balance sheet)</summary>
		Public Property [GLAccountRevaluationBSDescription] As String
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Last modified date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<summary>User ID of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Name of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>Notes</summary>
		Public Property [Notes] As String
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [DepreciationMethod]
		'''<summary>When the method is fixed amount, this is the periodic depreciation amount</summary>
		Public Property [Amount] As Double?
		'''<summary>Code of the depreciation method</summary>
		Public Property [Code] As String
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<summary>User ID of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>Describes the periodic interval</summary>
		Public Property [DepreciationInterval] As String
		'''<summary>Description of the method</summary>
		Public Property [Description] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Indicates the maximum value when using depreciation type degressive to linear</summary>
		Public Property [MaxPercentage] As Double?
		'''<summary>Last modified date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<summary>User ID of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Name of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>Degressive percentage for methods: 10 - Degressive to linear, 11 - Degressive (fixed perc. of book value), 12 - Degressive to linear (Belgium &amp; Luxembourg only). And interest percentage for method: 40 - Normal annuity method. On import: Can not be modified if depreciation method is already linked to an asset. For Belgium &amp; Luxembourg the degressive percentage is calculated as double of the linear percentage</summary>
		Public Property [Percentage] As Double?
		'''<summary>Linear percentage for methods: 10 - Degressive to linear, 3 - Linear depreciation (Belgium &amp; Luxembourg only), 12 - Degressive to linear (Belgium &amp; Luxembourg only). On import: Can not be modified if depreciation method is already linked to an asset</summary>
		Public Property [Percentage2] As Double?
		'''<summary>The total number of periods for the depreciation method. Used in combination with depreciation interval: only used when interval is periodic</summary>
		Public Property [Periods] As Int16?
		'''<summary>The actual type of deprecation, such as lineair or degressive. The periodic amounts are based on this type, in combination with other fields, such as the interval and the periods</summary>
		Public Property [Type] As Int32?
		'''<summary>Description of Type</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [TypeDescription] As String
		'''<summary>Determines the total number of years for the depreciation method. Used in combination with depreciation interval: only used when interval is yearly</summary>
		Public Property [Years] As Int16?
	End Class

End Namespace