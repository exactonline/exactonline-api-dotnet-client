Namespace PurchaseEntry

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("EntryID")>
	Public Class [PurchaseEntry]
		'''<summary>Amount in the default currency of the company</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AmountDC] As Double
		'''<summary>Amount in the currency of the transaction</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AmountFC] As Double
		'''<summary>Batch number</summary>
		Public Property [BatchNumber] As Int32?
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime
		'''<summary>User ID of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>Currency code</summary>
		Public Property [Currency] As String
		'''<summary>Description</summary>
		Public Property [Description] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32
		'''<summary>Reference to document</summary>
		Public Property [Document] As Guid?
		'''<summary>Document number</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DocumentNumber] As Int32?
		'''<summary>Document subject</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DocumentSubject] As String
		'''<summary>Date when payment should be done</summary>
		Public Property [DueDate] As DateTime?
		'''<summary>Entry date</summary>
		Public Property [EntryDate] As DateTime?
		'''<summary>Primary key</summary>
		Public Property [EntryID] As Guid
		'''<summary>Entry number</summary>
		Public Property [EntryNumber] As Int32?
		'''<summary>Description of ExternalLink</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ExternalLinkDescription] As String
		'''<summary>External link</summary>
		Public Property [ExternalLinkReference] As String
		'''<summary>A positive value of the amount indicates that the amount is to be paid to the suppliers G bank account.In case of a credit invoice the amount should have negative value when retrieved or posted to Exact.</summary>
		Public Property [GAccountAmountFC] As Double?
		'''<summary>Invoice number</summary>
		Public Property [InvoiceNumber] As Int32?
		'''<summary>Journal</summary>
		Public Property [Journal] As String
		'''<summary>Description of Journal</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [JournalDescription] As String
		'''<summary>Last modified date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime
		'''<summary>User ID of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Name of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>Order number</summary>
		Public Property [OrderNumber] As Int32?
		'''<summary>Payment condition</summary>
		Public Property [PaymentCondition] As String
		'''<summary>Description of PaymentCondition</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PaymentConditionDescription] As String
		'''<summary>The payment reference used for bank imports, VAT return and Tax reference</summary>
		Public Property [PaymentReference] As String
		Public Property [ProcessNumber] As Int32?
		'''<summary>Collection of lines</summary>
		Public Property [PurchaseEntryLines] As IEnumerable(Of Models.PurchaseEntry.PurchaseEntryLine)
		'''<summary>Currency exchange rate</summary>
		Public Property [Rate] As Double?
		'''<summary>Reporting period</summary>
		Public Property [ReportingPeriod] As Int16?
		'''<summary>Reporting year</summary>
		Public Property [ReportingYear] As Int16?
		'''<summary>Indicates that amounts are reversed</summary>
		Public Property [Reversal] As Boolean?
		'''<summary>Status: 5 = Rejected, 20 = Open, 50 = Processed</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Status] As Int16?
		'''<summary>Description of Status</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StatusDescription] As String
		'''<summary>Reference to supplier (account)</summary>
		Public Property [Supplier] As Guid?
		'''<summary>Name of supplier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SupplierName] As String
		'''<summary>Type: 30 = Purchase entry, 31 = Purchase credit note</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Type] As Int32
		'''<summary>Description of Type</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [TypeDescription] As String
		'''<summary>Vat Amount in the default currency of the company</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VATAmountDC] As Double?
		'''<summary>Vat Amount in the currency of the transaction</summary>
		Public Property [VATAmountFC] As Double?
		'''<summary>Your reference</summary>
		Public Property [YourRef] As String
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [PurchaseEntryLine]
		'''<summary>Amount in the default currency of the company</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AmountDC] As Double
		'''<summary>Amount in the currency of the transaction</summary>
		Public Property [AmountFC] As Double
		'''<summary>Reference to asset</summary>
		Public Property [Asset] As Guid?
		'''<summary>Asset description</summary>
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
		'''<summary>Description</summary>
		Public Property [Description] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32
		'''<summary>Reference to header of the purchase entry</summary>
		Public Property [EntryID] As Guid?
		'''<summary>From date for deferred revenue</summary>
		Public Property [From] As DateTime?
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
		'''<summary>IntraStat area</summary>
		Public Property [IntraStatArea] As String
		'''<summary>IntraStatCountry</summary>
		Public Property [IntraStatCountry] As String
		'''<summary>IntraStat delivery term</summary>
		Public Property [IntraStatDeliveryTerm] As String
		'''<summary>IntraStat transaction a</summary>
		Public Property [IntraStatTransactionA] As String
		'''<summary>IntraStat transport method</summary>
		Public Property [IntraStatTransportMethod] As String
		'''<summary>Line number</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [LineNumber] As Int32?
		'''<summary>Extra remarks</summary>
		Public Property [Notes] As String
		'''<summary>Percentage of re-invoice part of a cost to the owner of the company.</summary>
		Public Property [PrivateUsePercentage] As Double?
		'''<summary>Reference to project</summary>
		Public Property [Project] As Guid?
		'''<summary>Description of Project</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectDescription] As String
		'''<summary>Quantity</summary>
		Public Property [Quantity] As Double?
		'''<summary>Serial number</summary>
		Public Property [SerialNumber] As String
		'''<summary>Statistical NetWeight</summary>
		Public Property [StatisticalNetWeight] As Double?
		'''<summary>Statistical Number</summary>
		Public Property [StatisticalNumber] As String
		'''<summary>Statistical Quantity</summary>
		Public Property [StatisticalQuantity] As Double?
		'''<summary>Statistical Value</summary>
		Public Property [StatisticalValue] As Double?
		'''<summary>Reference to subscription</summary>
		Public Property [Subscription] As Guid?
		'''<summary>Description of Subscription</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SubscriptionDescription] As String
		'''<summary>To date for deferred revenue</summary>
		Public Property [To] As DateTime?
		'''<summary>Reference to tracking number</summary>
		Public Property [TrackingNumber] As Guid?
		'''<summary>Description of TrackingNumber</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [TrackingNumberDescription] As String
		'''<summary>Type: 30 = Purchase entry, 31 = Purchase credit note</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Type] As Int32?
		'''<summary>VAT amount in the default currency of the company</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VATAmountDC] As Double?
		'''<summary>VAT amount in the currency of the transaction. Use this property to specify a VAT amount that differs from the VAT amount that is automatically calculated.</summary>
		Public Property [VATAmountFC] As Double?
		'''<summary>VAT base amount in the default currency of the company</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VATBaseAmountDC] As Double?
		'''<summary>VAT base amount in the currency of the transaction</summary>
		Public Property [VATBaseAmountFC] As Double?
		'''<summary>VAT code</summary>
		Public Property [VATCode] As String
		'''<summary>Description of VATCode</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VATCodeDescription] As String
		'''<summary>If not the full amount of the VAT is deductible, you can indicate a percentage for the non decuctible part. This is used during the entry of purchase invoices.</summary>
		Public Property [VATNonDeductiblePercentage] As Double?
		'''<summary>VAT percentage</summary>
		Public Property [VATPercentage] As Double?
		'''<summary>Withholding tax amount for spanish legislation</summary>
		Public Property [WithholdingAmountDC] As Double?
		'''<summary>Withholding tax key for spanish legislation</summary>
		Public Property [WithholdingTax] As String
	End Class

End Namespace