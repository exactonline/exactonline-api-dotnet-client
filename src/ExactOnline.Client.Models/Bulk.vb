Namespace Bulk

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [Document]
		'''<summary>ID of the related account of this document</summary>
		Public Property [Account] As Guid?
		'''<summary>Code of Account</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountCode] As String
		'''<summary>Name of Account</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountName] As String
		'''<summary>Amount in the currency of the transaction</summary>
		Public Property [AmountFC] As Double?
		'''<summary>Body of this document</summary>
		Public Property [Body] As String
		'''<summary>ID of the category of this document</summary>
		Public Property [Category] As Guid?
		'''<summary>Description of Category</summary>
		Public Property [CategoryDescription] As String
		'''<summary>ID of the related contact of this document</summary>
		Public Property [Contact] As Guid?
		'''<summary>Contact full name</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ContactFullName] As String
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<summary>User ID of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator</summary>
		Public Property [CreatorFullName] As String
		'''<summary>Currency code</summary>
		Public Property [Currency] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32
		'''<summary>Entry date of the incoming document</summary>
		Public Property [DocumentDate] As DateTime?
		'''<summary>The Id of document folder</summary>
		Public Property [DocumentFolder] As Guid?
		'''<summary>The Code of document folder</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DocumentFolderCode] As String
		'''<summary>The Decsription of document folder</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DocumentFolderDescription] As String
		'''<summary>Url to view the document</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DocumentViewUrl] As String
		'''<summary>Reference to the transaction lines that make up the financial entry</summary>
		Public Property [FinancialTransactionEntryID] As Guid?
		'''<summary>Indicates that the document body is empty</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [HasEmptyBody] As Boolean
		'''<summary>Human-readable ID, formatted as xx.xxx.xxx. Unique. May not be equal to zero</summary>
		Public Property [HID] As Int32?
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>The language code of the document</summary>
		Public Property [Language] As String
		'''<summary>Last modified date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<summary>User ID of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Name of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>The opportunity linked to the document</summary>
		Public Property [Opportunity] As Guid?
		'''<summary>The project linked to the document</summary>
		Public Property [Project] As Guid?
		'''<summary>Code of project</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectCode] As String
		'''<summary>Description of project</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectDescription] As String
		'''<summary>&apos;Our reference&apos; of the transaction that belongs to this document</summary>
		Public Property [SalesInvoiceNumber] As Int32?
		'''<summary>Number of the sales order</summary>
		Public Property [SalesOrderNumber] As Int32?
		'''<summary>Send method</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SendMethod] As Int32?
		'''<summary>Number of the shop order</summary>
		Public Property [ShopOrderNumber] As Int32?
		'''<summary>Subject of this document</summary>
		Public Property [Subject] As String
		'''<summary>ID of the type of this document</summary>
		Public Property [Type] As Int32?
		'''<summary>Description of Type</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [TypeDescription] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [DocumentAttachment]
		'''<summary>Contains the attachment</summary>
		Public Property [Attachment] As Byte()
		'''<summary>Reference to the Document</summary>
		Public Property [Document] As Guid
		'''<summary>Filename of the attachment</summary>
		Public Property [FileName] As String
		'''<summary>File size of the attachment</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [FileSize] As Double
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Url of the attachment. To get the file in its original format (xml, jpg, pdf, etc.) append &lt;b&gt;&amp;Download=1&lt;/b&gt; to the url.</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Url] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [FinancialTransactionLine]
		'''<summary>Reference to account</summary>
		Public Property [Account] As Guid?
		'''<summary>Code of the Account</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountCode] As String
		'''<summary>Name of the Account</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountName] As String
		'''<summary>Amount in the default currency of the company</summary>
		Public Property [AmountDC] As Double
		'''<summary>Amount in the currency of the transaction</summary>
		Public Property [AmountFC] As Double
		'''<summary>Vat base amount in the currency of the transaction</summary>
		Public Property [AmountVATBaseFC] As Double?
		'''<summary>Vat amount in the currency of the transaction</summary>
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
		Public Property [Created] As DateTime
		'''<summary>User ID of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>Currency</summary>
		Public Property [Currency] As String
		'''<summary>Date</summary>
		Public Property [Date] As DateTime?
		'''<summary>Description</summary>
		Public Property [Description] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32
		'''<summary>Reference to document</summary>
		Public Property [Document] As Guid?
		'''<summary>Number of the document</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DocumentNumber] As Int32?
		'''<summary>Subject of the document</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DocumentSubject] As String
		'''<summary>Date that payment should be done</summary>
		Public Property [DueDate] As DateTime?
		'''<summary>The transaction lines that make up a financial entry share the same EntryID</summary>
		Public Property [EntryID] As Guid?
		'''<summary>Entry number of the header</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [EntryNumber] As Int32?
		'''<summary>Exchange rate</summary>
		Public Property [ExchangeRate] As Double?
		'''<summary>Extra duty amount</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ExtraDutyAmountFC] As Double?
		'''<summary>Extra duty percentage</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ExtraDutyPercentage] As Double?
		'''<summary>Financial period</summary>
		Public Property [FinancialPeriod] As Int16?
		'''<summary>Financial year</summary>
		Public Property [FinancialYear] As Int16?
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
		'''<summary>Invoice number</summary>
		Public Property [InvoiceNumber] As Int32?
		'''<summary>Reference to item</summary>
		Public Property [Item] As Guid?
		'''<summary>Code of Item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemCode] As String
		'''<summary>Description of Item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDescription] As String
		'''<summary>The journal code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [JournalCode] As String
		'''<summary>The journal description</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [JournalDescription] As String
		'''<summary>Line number</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [LineNumber] As Int32?
		'''<summary>Line type</summary>
		Public Property [LineType] As Int16
		'''<summary>Last modified date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime
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
		'''<summary>Order number</summary>
		Public Property [OrderNumber] As Int32?
		'''<summary>Discount amount when paid in time</summary>
		Public Property [PaymentDiscountAmount] As Double?
		'''<summary>Payment reference</summary>
		Public Property [PaymentReference] As String
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
		'''<summary>Serial number of item</summary>
		Public Property [SerialNumber] As String
		'''<summary>20 = Open, 50 = Processed</summary>
		Public Property [Status] As Int16?
		'''<summary>Reference to subscription line</summary>
		Public Property [Subscription] As Guid?
		'''<summary>Description of subscription line</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SubscriptionDescription] As String
		'''<summary>Tracking number of item</summary>
		Public Property [TrackingNumber] As String
		'''<summary>Tracking number description</summary>
		Public Property [TrackingNumberDescription] As String
		'''<summary>The transaction type.&lt;/br&gt;&lt;table class=&quot;enum&quot;&gt;&lt;tr&gt;&lt;td&gt;10 = Opening balance&lt;/td&gt;&lt;td&gt;142 = Issue to parent&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;20 = Sales entry&lt;/td&gt;&lt;td&gt;145 = Shop order time entry&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;21 = Sales credit note&lt;/td&gt;&lt;td&gt;146 = Shop order time entry reversal&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;30 = Purchase entry&lt;/td&gt;&lt;td&gt;147 = Shop order by-product receipt&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;31 = Purchase credit note&lt;/td&gt;&lt;td&gt;148 = Shop order by-product reversal&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;40 = Cash flow&lt;/td&gt;&lt;td&gt;150 = Requirement issue&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;50 = VAT return&lt;/td&gt;&lt;td&gt;151 = Requirement reversal&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;70 = Asset - Depreciation&lt;/td&gt;&lt;td&gt;152 = Returned from parent&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;71 = Asset - Investment&lt;/td&gt;&lt;td&gt;155 = Subcontract Issue&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;72 = Asset - Revaluation&lt;/td&gt;&lt;td&gt;156 = Subcontract reversal&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;73 = Asset - Transfer&lt;/td&gt;&lt;td&gt;158 = Shop order completed&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;74 = Asset - Split&lt;/td&gt;&lt;td&gt;162 = Finish assembly&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;75 = Asset - Discontinue&lt;/td&gt;&lt;td&gt;170 = Payroll&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;76 = Asset - Sales&lt;/td&gt;&lt;td&gt;180 = Stock revaluation&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;80 = Revaluation&lt;/td&gt;&lt;td&gt;181 = Financial revaluation&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;82 = Exchange rate difference&lt;/td&gt;&lt;td&gt;195 = Stock count&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;83 = Payment difference&lt;/td&gt;&lt;td&gt;290 = Correction entry&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;84 = Deferred revenue&lt;/td&gt;&lt;td&gt;310 = Period closing&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;85 = Tracking number:Revaluation&lt;/td&gt;&lt;td&gt;320 = Year end reflection&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;86 = Deferred cost&lt;/td&gt;&lt;td&gt;321 = Year end costing&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;87 = VAT on prepayment&lt;/td&gt;&lt;td&gt;322 = Year end profits to gross profit&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;90 = Other&lt;/td&gt;&lt;td&gt;323 = Year end costs to gross profit&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;120 = Delivery&lt;/td&gt;&lt;td&gt;324 = Year end tax&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;121 = Sales return&lt;/td&gt;&lt;td&gt;325 = Year end gross profit to net p/l&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;130 = Receipt&lt;/td&gt;&lt;td&gt;326 = Year end net p/l to balance sheet&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;131 = Purchase return&lt;/td&gt;&lt;td&gt;327 = Year end closing balance&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;140 = Shop order stock receipt&lt;/td&gt;&lt;td&gt;328 = Year start opening balance&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;141 = Shop order stock reversal&lt;/td&gt;&lt;td&gt;3000 = Budget&lt;/td&gt;&lt;/tr&gt;&lt;/table&gt;</summary>
		Public Property [Type] As Int32
		'''<summary>Vat code</summary>
		Public Property [VATCode] As String
		'''<summary>Description of VATCode</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VATCodeDescription] As String
		'''<summary>Vat percentage</summary>
		Public Property [VATPercentage] As Double?
		'''<summary>Vat type</summary>
		Public Property [VATType] As String
		'''<summary>Your reference (of customer)</summary>
		Public Property [YourRef] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [SalesOrderLine]
		'''<summary>Amount in the default currency of the company</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AmountDC] As Double
		'''<summary>Amount in the currency of the transaction</summary>
		Public Property [AmountFC] As Double
		'''<summary>Reference to Cost center</summary>
		Public Property [CostCenter] As String
		'''<summary>Description of CostCenter</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CostCenterDescription] As String
		'''<summary>Item cost price</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CostPriceFC] As Double?
		'''<summary>Reference to Cost unit</summary>
		Public Property [CostUnit] As String
		'''<summary>Description of CostUnit</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CostUnitDescription] As String
		'''<summary>Delivery date of this line</summary>
		Public Property [DeliveryDate] As DateTime?
		'''<summary>Description</summary>
		Public Property [Description] As String
		'''<summary>Discount given on the default price. Discount = (DefaultPrice of Item - PriceItem in line) / DefaultPrice of Item</summary>
		Public Property [Discount] As Double
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Reference to the item that is sold in this sales order line</summary>
		Public Property [Item] As Guid?
		'''<summary>Code of Item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemCode] As String
		'''<summary>Description of Item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDescription] As String
		'''<summary>Item Version</summary>
		Public Property [ItemVersion] As Guid?
		'''<summary>Description of Item Version</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemVersionDescription] As String
		'''<summary>Line number</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [LineNumber] As Int32
		'''<summary>Net price of the sales order line</summary>
		Public Property [NetPrice] As Double?
		'''<summary>Extra notes</summary>
		Public Property [Notes] As String
		'''<summary>The OrderID identifies the sales order. All the lines of a sales order have the same OrderID</summary>
		Public Property [OrderID] As Guid
		'''<summary>Number of sales order</summary>
		Public Property [OrderNumber] As Int32
		'''<summary>Price list</summary>
		Public Property [Pricelist] As Guid?
		'''<summary>Description of Pricelist</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PricelistDescription] As String
		'''<summary>The project to which the sales order line is linked. The project can be different per line. Sometimes also the project in the header is filled although this is not really used</summary>
		Public Property [Project] As Guid?
		'''<summary>Description of Project</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectDescription] As String
		'''<summary>Purchase order that is linked to the sales order</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PurchaseOrder] As Guid?
		'''<summary>Purchase order line of the purchase order that is linked to the sales order</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PurchaseOrderLine] As Guid?
		'''<summary>Number of the purchase order line</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PurchaseOrderLineNumber] As Int32?
		'''<summary>Number of the purchase order</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PurchaseOrderNumber] As Int32?
		'''<summary>The number of items sold in default units. The quantity shown in the entry screen is Quantity * UnitFactor</summary>
		Public Property [Quantity] As Double?
		'''<summary>Reference to ShopOrder</summary>
		Public Property [ShopOrder] As Guid?
		'''<summary>Code of item unit</summary>
		Public Property [UnitCode] As String
		'''<summary>Description of Unit</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [UnitDescription] As String
		'''<summary>Price per unit in the currency of the transaction</summary>
		Public Property [UnitPrice] As Double?
		'''<summary>Indicates if drop shipment is used (delivery directly to customer, invoice to wholesaler)</summary>
		Public Property [UseDropShipment] As Byte
		'''<summary>VAT amount in the currency of the transaction</summary>
		Public Property [VATAmount] As Double?
		'''<summary>VAT code</summary>
		Public Property [VATCode] As String
		'''<summary>Description of VATCode</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VATCodeDescription] As String
		'''<summary>The vat percentage of the VAT code. This is the percentage at the moment the sales order is created. It&apos;s also used for the default calculation of VAT amounts and VAT base amounts</summary>
		Public Property [VATPercentage] As Double?
	End Class

End Namespace