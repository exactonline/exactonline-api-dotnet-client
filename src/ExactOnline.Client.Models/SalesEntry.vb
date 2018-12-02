Namespace SalesEntry

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("EntryID")>
	Public Class [SalesEntry]
		'''<summary>Amount in the default currency of the company. For the header lines (LineNumber = 0) of an entry this is the SUM(AmountDC) of all lines</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AmountDC] As Double
		'''<summary>Amount in the currency of the transaction. For the header this is the sum of all lines, including VAT</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AmountFC] As Double
		'''<summary>The number of the batch of entries. Normally a batch consists of multiple entries. Batchnumbers are filled for invoices created by: - Fixed entries - Prolongation (only available with module hosting)</summary>
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
		'''<summary>Currency for the invoice. By default this is the currency of the administration</summary>
		Public Property [Currency] As String
		'''<summary>Reference to customer (account)</summary>
		Public Property [Customer] As Guid?
		'''<summary>Name of customer</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CustomerName] As String
		'''<summary>Description. Can be different for header and lines</summary>
		Public Property [Description] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32
		'''<summary>Document that is manually linked to the invoice</summary>
		Public Property [Document] As Guid?
		'''<summary>Number of the document</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DocumentNumber] As Int32?
		'''<summary>Subject of the document</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DocumentSubject] As String
		'''<summary>The due date for payments. This date is calculated based on the EntryDate and the Paymentcondition</summary>
		Public Property [DueDate] As DateTime?
		'''<summary>The date when the invoice is entered</summary>
		Public Property [EntryDate] As DateTime?
		'''<summary>The unique ID of the entry. Via this ID all transaction lines of a single entry can be retrieved</summary>
		Public Property [EntryID] As Guid
		'''<summary>Entry number</summary>
		Public Property [EntryNumber] As Int32?
		'''<summary>Description of ExternalLink</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ExternalLinkDescription] As String
		'''<summary>Reference of ExternalLink</summary>
		Public Property [ExternalLinkReference] As String
		'''<summary>A positive value of the amount indicates that the amount is to be paid by the customer to your G bank account.In case of a credit invoice the amount should have negative value when retrieved or posted to Exact.</summary>
		Public Property [GAccountAmountFC] As Double?
		'''<summary>Assigned at entry or at printing depending on setting. The number assigned is based on the freenumbers as defined for the Journal. When printing the field InvoiceNumber is copied to the fields EntryNumber and InvoiceNumber of the sales entry</summary>
		Public Property [InvoiceNumber] As Int32?
		'''<summary>Indicates whether the invoice has extra duty</summary>
		Public Property [IsExtraDuty] As Boolean?
		'''<summary>The journal code. Every invoice should be linked to a sales journal</summary>
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
		'''<summary>Number to indentify the invoice. Order numbers are not unique. Default the number is based on a setting for the first free number</summary>
		Public Property [OrderNumber] As Int32?
		'''<summary>The payment condition used for due date and discount calculation</summary>
		Public Property [PaymentCondition] As String
		'''<summary>Description of PaymentCondition</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PaymentConditionDescription] As String
		'''<summary>The payment reference used for bank imports, VAT return and Tax reference</summary>
		Public Property [PaymentReference] As String
		Public Property [ProcessNumber] As Int32?
		'''<summary>Foreign currency rate</summary>
		Public Property [Rate] As Double?
		'''<summary>The period of the transaction lines. The period should exist in the period date table</summary>
		Public Property [ReportingPeriod] As Int16?
		'''<summary>The financial year to which the entry belongs. The financial year should exist in the period date table</summary>
		Public Property [ReportingYear] As Int16?
		'''<summary>Indicates if amounts are reversed</summary>
		Public Property [Reversal] As Boolean
		'''<summary>Collection of lines</summary>
		Public Property [SalesEntryLines] As IEnumerable(Of Models.SalesEntry.SalesEntryLine)
		'''<summary>Status: 5 = Rejected, 20 = Open, 50 = Processed</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Status] As Int16?
		'''<summary>Description of Status</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StatusDescription] As String
		'''<summary>Type: 20 = Sales entry, 21 = Sales credit note</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Type] As Int32
		'''<summary>Description of Type</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [TypeDescription] As String
		'''<summary>Vat amount in the default currency of the company</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VATAmountDC] As Double?
		'''<summary>Vat amount in the currency of the transaction</summary>
		Public Property [VATAmountFC] As Double?
		'''<summary>Withholding tax amount</summary>
		Public Property [WithholdingTaxAmountDC] As Double?
		'''<summary>Withholding tax base amount to calculate withholding amount</summary>
		Public Property [WithholdingTaxBaseAmount] As Double?
		'''<summary>Withholding tax percentage</summary>
		Public Property [WithholdingTaxPercentage] As Double?
		'''<summary>The invoice number of the customer</summary>
		Public Property [YourRef] As String
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [SalesEntryLine]
		'''<summary>Amount in the default currency of the company. For almost all lines this can be calculated like: AmountDC = AmountFC * RateFC.</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AmountDC] As Double
		'''<summary>For normal lines it&apos;s the amount excluding VAT</summary>
		Public Property [AmountFC] As Double
		'''<summary>Reference to Asset</summary>
		Public Property [Asset] As Guid?
		'''<summary>Description of Asset</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AssetDescription] As String
		'''<summary>Reference to Cost center</summary>
		Public Property [CostCenter] As String
		'''<summary>Description of CostCenter</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CostCenterDescription] As String
		'''<summary>Reference to Cost unit</summary>
		Public Property [CostUnit] As String
		'''<summary>Description of CostUnit</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CostUnitDescription] As String
		'''<summary>Description. Can be different for header and lines</summary>
		Public Property [Description] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32
		'''<summary>The unique ID of the entry. Via this ID all transaction lines of a single entry can be retrieved</summary>
		Public Property [EntryID] As Guid
		'''<summary>Extra duty amount in the currency of the transaction. Both extra duty amount and VAT amount need to be specified in order to differ this property from automatically calculated.</summary>
		Public Property [ExtraDutyAmountFC] As Double?
		'''<summary>Extra duty percentage for the item</summary>
		Public Property [ExtraDutyPercentage] As Double?
		'''<summary>From date for deferred revenue</summary>
		Public Property [From] As DateTime?
		'''<summary>The GL Account of the invoice line. This field is generated based on the revenue account of the item (or the related item group). G/L Account is also used to determine whether the costcenter / costunit is mandatory</summary>
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
		'''<summary>Indicates the sequence of the lines within one entry</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [LineNumber] As Int32?
		'''<summary>Extra notes</summary>
		Public Property [Notes] As String
		'''<summary>The project to which the sales transaction line is linked. The project can be different per line. Sometimes also the project in the header is filled although this is not really used</summary>
		Public Property [Project] As Guid?
		'''<summary>Description of Project</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectDescription] As String
		'''<summary>The number of items sold in default units. The quantity shown in the entry screen is Quantity * UnitFactor</summary>
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
		'''<summary>When generating invoices from subscriptions, this field records the link between invoice lines and subscription lines</summary>
		Public Property [Subscription] As Guid?
		'''<summary>Description of Subscription</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SubscriptionDescription] As String
		'''<summary>Obsolete</summary>
		Public Property [TaxSchedule] As Guid?
		'''<summary>To date for deferred revenue</summary>
		Public Property [To] As DateTime?
		'''<summary>Reference to TrackingNumber</summary>
		Public Property [TrackingNumber] As Guid?
		'''<summary>Description of TrackingNumber</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [TrackingNumberDescription] As String
		'''<summary>Type: 20 = Sales entry, 21 = Sales credit note</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Type] As Int32?
		'''<summary>VAT amount in the default currency of the company</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VATAmountDC] As Double?
		'''<summary>VAT amount in the currency of the transaction. Use this property to specify a VAT amount that differs from the VAT amount that is automatically calculated. However if the transaction uses extra duty, extra duty amount also needs to be specified. </summary>
		Public Property [VATAmountFC] As Double?
		'''<summary>The VAT base amount in the default currency of the company. This is calculated based on the VATBaseAmountFC</summary>
		Public Property [VATBaseAmountDC] As Double?
		'''<summary>The VAT base amount in invoice currency. This is calculated with the use of VAT codes. It&apos;s an internal value</summary>
		Public Property [VATBaseAmountFC] As Double?
		'''<summary>The VAT code used when the invoice was registered</summary>
		Public Property [VATCode] As String
		'''<summary>Description of VATCode</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VATCodeDescription] As String
		'''<summary>The VAT percentage of the VAT code. This is the percentage at the moment the invoice is created. It&apos;s also used by the default calculation of VAT amounts and VAT base amounts</summary>
		Public Property [VATPercentage] As Double?
	End Class

End Namespace