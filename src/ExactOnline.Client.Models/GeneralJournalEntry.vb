Namespace GeneralJournalEntry

	<SupportedActionsSDK(True, True, False, False)>
	<DataServiceKey("EntryID")>
	Public Class [GeneralJournalEntry]
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<summary>Currency code</summary>
		Public Property [Currency] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<summary>Primary key</summary>
		Public Property [EntryID] As Guid
		'''<summary>Entry number</summary>
		Public Property [EntryNumber] As Int32?
		'''<summary>Exchange rate</summary>
		Public Property [ExchangeRate] As Double?
		'''<summary>Financial period</summary>
		Public Property [FinancialPeriod] As Int16?
		'''<summary>Financial year</summary>
		Public Property [FinancialYear] As Int16?
		'''<summary>Collection of lines</summary>
		Public Property [GeneralJournalEntryLines] As IEnumerable(Of Models.GeneralJournalEntry.GeneralJournalEntryLine)
		'''<summary>Code of Journal</summary>
		Public Property [JournalCode] As String
		'''<summary>Description of Journal</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [JournalDescription] As String
		'''<summary>Last modified date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<summary>Indicates that amounts are reversed</summary>
		Public Property [Reversal] As Boolean?
		'''<summary>Status: 5 = Rejected, 20 = Open, 50 = Processed</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Status] As Int16?
		'''<summary>Description of Status</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StatusDescription] As String
		'''<summary>Type: 10 = Opening balance, 90 = Other</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Type] As Int32?
		'''<summary>Description of Type</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [TypeDescription] As String
	End Class

	<SupportedActionsSDK(True, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [GeneralJournalEntryLine]
		'''<summary>Reference to account</summary>
		Public Property [Account] As Guid?
		'''<summary>Code of Account</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountCode] As String
		'''<summary>Name of Account</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountName] As String
		'''<summary>Amount in the default currency of the company, If an &apos;Including&apos; VAT code is used this amount includes the VAT amount.</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AmountDC] As Double?
		'''<summary>Amount in the currency of the transaction. If an &apos;Including&apos; VAT code is used this amount includes the VAT amount.</summary>
		Public Property [AmountFC] As Double?
		'''<summary>Vat amount in the default currency of the company.</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AmountVATDC] As Double?
		'''<summary>Vat amount in the currency of the transaction. If you want to set this in a POST you have to specify VATCode as well.</summary>
		Public Property [AmountVATFC] As Double?
		'''<summary>Reference to asset</summary>
		Public Property [Asset] As Guid?
		'''<summary>Code of Asset</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AssetCode] As String
		'''<summary>Description of Asset</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AssetDescription] As String
		'''<summary>Reference to cost center</summary>
		Public Property [CostCenter] As String
		'''<summary>Description of CostCenter</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CostCenterDescription] As String
		'''<summary>Reference to cost unit</summary>
		Public Property [CostUnit] As String
		'''<summary>Description of CostUnit</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CostUnitDescription] As String
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<summary>User ID of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>Entry date</summary>
		Public Property [Date] As DateTime?
		'''<summary>Description</summary>
		Public Property [Description] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<summary>Reference to document</summary>
		Public Property [Document] As Guid?
		'''<summary>Document number</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DocumentNumber] As Int32?
		'''<summary>Document subject</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DocumentSubject] As String
		'''<summary>Reference to header of the entry</summary>
		Public Property [EntryID] As Guid?
		'''<summary>Entry number of the header</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [EntryNumber] As Int32?
		'''<summary>General ledger account</summary>
		Public Property [GLAccount] As Guid?
		'''<summary>Code of GLAccount</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLAccountCode] As String
		'''<summary>Description of GLAccount</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLAccountDescription] As String
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Line number</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [LineNumber] As Int32?
		'''<summary>Last modified date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<summary>User ID of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Name of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>Extra remarks</summary>
		Public Property [Notes] As String
		'''<summary>OffsetID</summary>
		Public Property [OffsetID] As Guid?
		'''<summary>Our ref of general journal entry</summary>
		Public Property [OurRef] As Int32?
		'''<summary>Reference to project</summary>
		Public Property [Project] As Guid?
		'''<summary>Code of Project</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectCode] As String
		'''<summary>Description of Project</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectDescription] As String
		'''<summary>Quantity</summary>
		Public Property [Quantity] As Double?
		'''<summary>VAT base amount in the default currency of the company</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VATBaseAmountDC] As Double?
		'''<summary>VAT base amount in the currency of the transaction</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VATBaseAmountFC] As Double?
		'''<summary>VATCode can only be used if the general journal has VAT enabled. VAT Lines will be automatically created if the VATCode is specified when creating a new general journal entry.</summary>
		Public Property [VATCode] As String
		'''<summary>Description of VATCode</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VATCodeDescription] As String
		'''<summary>Vat percentage</summary>
		Public Property [VATPercentage] As Double?
		'''<summary>The VAT type determines what the values are in relation to VAT returns. The following values are supported:&lt;br&gt;A Sales VAT to pay,&lt;br&gt;D Credit note extra duty to claim,&lt;br&gt;I Purchase basis,&lt;br&gt;M Credit note purchase non-deductible,&lt;br&gt;N Purchase non-deductible,&lt;br&gt;O Purchase VAT to claim,&lt;br&gt;P Purchase VAT to pay,&lt;br&gt;Q Credit note purchase VAT to claim,&lt;br&gt;R Extra duty to pay,&lt;br&gt;S No VAT,&lt;br&gt;V Sales basis,&lt;br&gt;W Credit note purchase basis,&lt;br&gt;X Credit note sales basis,&lt;br&gt;Y Credit note purchase VAT to pay,&lt;br&gt;Z Credit note sales VAT to claim</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VATType] As String
	End Class

End Namespace