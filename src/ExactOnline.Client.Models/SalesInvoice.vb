Namespace SalesInvoice

	<SupportedActionsSDK(True, False, False, False)>
	<DataServiceKey("ID")>
	Public Class [InvoiceSalesOrder]
		'''<summary>Invoice creation mode- 0: Per customer 1: Per sales order</summary>
		Public Property [CreateMode] As Int32?
		'''<summary>Stock entries entry number.</summary>
		Public Property [DeliveryNumber] As Int32?
		'''<summary>Stock entries entry end date.</summary>
		Public Property [EndDate] As DateTime?
		'''<summary>Errors in the process.</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Errors] As String
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Invoice quantity processing mode- 0:By quantity delivered 1:By quantity ordered.</summary>
		Public Property [InvoiceMode] As Int32?
		'''<summary>Code of Journal</summary>
		Public Property [JournalCode] As String
		'''<summary>Number of invoices successfully created.</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [NumberOfCreatedInvoices] As Int32?
		'''<summary>Number of invoices failed to create.</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [NumberOfFailedInvoices] As Int32?
		'''<summary>Collection of Sales order IDs.</summary>
		Public Property [SalesOrderIDs] As IEnumerable(Of Models.SalesInvoice.SalesOrderID)
		'''<summary>Stock entries entry start date.</summary>
		Public Property [StartDate] As DateTime?
		'''<summary>Possibility to override the InvoiceDate during creation of sales invoice from sales orders. Works only for integration with Intuit QuickBooks.</summary>
		Public Property [UserInvoiceDate] As DateTime?
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [Layout]
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<summary>User ID of the creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of the creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Last modified date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<summary>User ID of the last modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Name of the last modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>Layout name</summary>
		Public Property [Subject] As String
		'''<summary>Type: 1=Layout, 2=E-mail text layout, 3=Word template</summary>
		Public Property [Type] As Int16?
	End Class

	<SupportedActionsSDK(True, False, False, False)>
	<DataServiceKey("InvoiceID")>
	Public Class [PrintedSalesInvoice]
		'''<summary>Division code</summary>
		Public Property [Division] As Int32?
		'''<summary>Contains the id of the document that was created</summary>
		Public Property [Document] As Guid?
		'''<summary>Contains the error message if an error occurred during the creation of the document</summary>
		Public Property [DocumentCreationError] As String
		'''<summary>Contains information if a document was succesfully created</summary>
		Public Property [DocumentCreationSuccess] As String
		'''<summary>Based on this layout a PDF is created and attached to an Exact Online document and an email</summary>
		Public Property [DocumentLayout] As Guid?
		'''<summary>Contains the error message if an error occurred during the creation of the email</summary>
		Public Property [EmailCreationError] As String
		'''<summary>Contains confirmation that an email was sent. If an email cannot be delivered this property will still show confirmation that the email was sent.</summary>
		Public Property [EmailCreationSuccess] As String
		'''<summary>Based on this layout the email text is produced</summary>
		Public Property [EmailLayout] As Guid?
		'''<summary>Extra text that can be added to the printed document and email</summary>
		Public Property [ExtraText] As String
		'''<summary>Date of the invoice</summary>
		Public Property [InvoiceDate] As DateTime?
		'''<summary>Primary key, Reference to EntryID of SalesInvoice</summary>
		Public Property [InvoiceID] As Guid
		'''<summary>Contains the error message if an error occurred during the sending of a postbox message</summary>
		Public Property [PostboxMessageCreationError] As String
		'''<summary>Contains information if a postbox message was succesfully sent</summary>
		Public Property [PostboxMessageCreationSuccess] As String
		'''<summary>The postbox from where the message is sent</summary>
		Public Property [PostboxSender] As Guid?
		'''<summary>Reporting period</summary>
		Public Property [ReportingPeriod] As Int32?
		'''<summary>Reporting year</summary>
		Public Property [ReportingYear] As Int32?
		'''<summary>Set to True if an email containing the invoice should be sent to the invoice customer. This option overrules SendInvoiceToCustomerPostbox.</summary>
		Public Property [SendEmailToCustomer] As Boolean?
		'''<summary>Email address from which the email will be sent. If not specified, the company email address will be used.</summary>
		Public Property [SenderEmailAddress] As String
		'''<summary>Set to True if a postbox message containing the invoice should be sent to the invoice customer</summary>
		Public Property [SendInvoiceToCustomerPostbox] As Boolean?
		'''<summary>Set to True if the output preference should be taken from the account. It will be either Document only, Email or Digital postbox. This option overrules both SendEmailToCustomer and SendInvoiceToCustomerPostbox.</summary>
		Public Property [SendOutputBasedOnAccount] As Boolean?
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("InvoiceID")>
	Public Class [SalesInvoice]
		'''<summary>For the header lines (LineNumber = 0) of an entry this is the SUM(AmountDC) of all lines</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AmountDC] As Double?
		'''<summary>Discount amount in the default currency of the company</summary>
		Public Property [AmountDiscount] As Double?
		'''<summary>Discount amount exclude VAT in the default currency of the company</summary>
		Public Property [AmountDiscountExclVat] As Double?
		'''<summary>For the header this is the sum of all lines, including VAT</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AmountFC] As Double?
		'''<summary>For the header this is the sum of all lines, excluding VAT</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AmountFCExclVat] As Double?
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<summary>User ID of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>Currency for the invoice. Default this is the currency of the administration</summary>
		Public Property [Currency] As String
		'''<summary>Delivery account for invoice</summary>
		Public Property [DeliverTo] As Guid?
		'''<summary>Address of delivery as per invoice delivery account</summary>
		Public Property [DeliverToAddress] As Guid?
		'''<summary>Delivery account person for invoice</summary>
		Public Property [DeliverToContactPerson] As Guid?
		'''<summary>Name of delivery account&apos;s contact person as per invoice</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DeliverToContactPersonFullName] As String
		'''<summary>Name of the delivery account&apos;s customer as per invoice</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DeliverToName] As String
		'''<summary>Description. Can be different for header and lines</summary>
		Public Property [Description] As String
		'''<summary>Discount percentage</summary>
		Public Property [Discount] As Double?
		'''<summary>Discount Type</summary>
		Public Property [DiscountType] As Int16?
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
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
		'''<summary>Extra duty amount in the currency of the transaction. Both extra duty amount and VAT amount need to be specified in order to differ this property from automatically calculated.</summary>
		Public Property [ExtraDutyAmountFC] As Double?
		'''<summary>A positive value of the amount indicates that the amount is to be paid by the customer to your G bank account.In case of a credit invoice the amount should have negative value when retrieved or posted to Exact.</summary>
		Public Property [GAccountAmountFC] As Double?
		'''<summary>Official date for the invoice. When the invoice is entered it&apos;s equal to the field &apos;EntryDate&apos;. During the printing process the invoice date can be entered</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [InvoiceDate] As DateTime?
		'''<summary>Primary key</summary>
		Public Property [InvoiceID] As Guid
		'''<summary>Assigned at entry or at printing depending on setting. The number assigned is based on the freenumbers as defined for the Journal. When printing the field InvoiceNumber is copied to the fields EntryNumber and InvoiceNumber of the sales entry</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [InvoiceNumber] As Int32?
		'''<summary>Reference to the Customer who will receive the invoice</summary>
		Public Property [InvoiceTo] As Guid?
		'''<summary>Reference to the Contact person of the customer who will receive the invoice</summary>
		Public Property [InvoiceToContactPerson] As Guid?
		'''<summary>Name of the contact person of the customer who will receive the invoice</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [InvoiceToContactPersonFullName] As String
		'''<summary>Name of the customer who will receive the invoice</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [InvoiceToName] As String
		'''<summary>Indicates whether the invoice has extra duty</summary>
		Public Property [IsExtraDuty] As Boolean?
		'''<summary>The journal code. Every invoice should be linked to a sales journal</summary>
		Public Property [Journal] As String
		'''<summary>Description of Journal</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [JournalDescription] As String
		'''<summary>Last modified date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<summary>User ID of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Name of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>Order date</summary>
		Public Property [OrderDate] As DateTime?
		'''<summary>Customer who ordered the invoice</summary>
		Public Property [OrderedBy] As Guid?
		'''<summary>Contact person of customer who ordered the invoice</summary>
		Public Property [OrderedByContactPerson] As Guid?
		'''<summary>Name of contact person of customer who ordered the invoice</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [OrderedByContactPersonFullName] As String
		'''<summary>Name of customer who ordered the invoice</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [OrderedByName] As String
		'''<summary>Number to identify the order. By default the number is based on a setting for the first free number, but you can post your own number.</summary>
		Public Property [OrderNumber] As Int32?
		'''<summary>The payment condition used for due date and discount calculation</summary>
		Public Property [PaymentCondition] As String
		'''<summary>Description of PaymentCondition</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PaymentConditionDescription] As String
		'''<summary>Payment reference for sales invoice</summary>
		Public Property [PaymentReference] As String
		'''<summary>Extra remarks</summary>
		Public Property [Remarks] As String
		'''<summary>Collection of lines</summary>
		Public Property [SalesInvoiceLines] As IEnumerable(Of Models.SalesInvoice.SalesInvoiceLine)
		'''<summary>Sales representative</summary>
		Public Property [Salesperson] As Guid?
		'''<summary>Name of sales representative</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SalespersonFullName] As String
		'''<summary>Starter Sales invoice status (for starter functionality)</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StarterSalesInvoiceStatus] As Int16?
		'''<summary>Description of StarterSalesInvoiceStatus</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StarterSalesInvoiceStatusDescription] As String
		'''<summary>The status of the entry. 10 = draft. During the creation of an invoice draft records occur in the draft modus if during an invoice a new page with lines is triggered. If the user leaves the invoice in an abnormal way the draft invoices can be recovered. Draft invoices are not included in financial reports, balances etc. 20 = open. Open invoices can be changed. New invoices get the status open by default. 50 = processed. Processed invoices can&apos;t be changed anymore. Processing is done via printing. Processed invoices can&apos;t be reopened</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Status] As Int16?
		'''<summary>Description of Status</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StatusDescription] As String
		'''<summary>Obsolete</summary>
		Public Property [TaxSchedule] As Guid?
		'''<summary>Obsolete</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [TaxScheduleCode] As String
		'''<summary>Obsolete</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [TaxScheduleDescription] As String
		'''<summary>Indicates the type of invoice Values: 8020 - Sales invoices, 8021 - Sales credit note</summary>
		Public Property [Type] As Int32?
		'''<summary>Description of the type</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [TypeDescription] As String
		'''<summary>Total VAT amount in the default currency of the company</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VATAmountDC] As Double?
		'''<summary>Total VAT amount in the currency of the transaction</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VATAmountFC] As Double?
		'''<summary>Withholding tax amount applied to sales invoice</summary>
		Public Property [WithholdingTaxAmountFC] As Double?
		'''<summary>Withholding tax base amount to calculate withholding amount</summary>
		Public Property [WithholdingTaxBaseAmount] As Double?
		'''<summary>Withholding tax percentage applied to sales invoice</summary>
		Public Property [WithholdingTaxPercentage] As Double?
		'''<summary>The invoice number of the customer</summary>
		Public Property [YourRef] As String
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [SalesInvoiceLine]
		'''<summary>Amount in the default currency of the company. For almost all lines this can be calculated like: AmountDC = AmountFC * RateFC</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AmountDC] As Double?
		'''<summary>For normal lines it&apos;s the amount excluding VAT</summary>
		Public Property [AmountFC] As Double?
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
		'''<summary>Delivery date of an item in a sales invoice. This is used for VAT on prepayments, only if sales order is not used in the license.</summary>
		Public Property [DeliveryDate] As DateTime?
		'''<summary>Description. Can be different for header and lines</summary>
		Public Property [Description] As String
		'''<summary>Discount given on the default price. Discount = (DefaultPrice of Item - PriceItem in line) / DefaultPrice of Item</summary>
		Public Property [Discount] As Double?
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<summary>Link to Employee originating from time and cost transactions</summary>
		Public Property [Employee] As Guid?
		'''<summary>Name of employee</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [EmployeeFullName] As String
		'''<summary>EndTime is used to store the last date of a period. EndTime is used in combination with StartTime</summary>
		Public Property [EndTime] As DateTime?
		'''<summary>Extra duty amount in the currency of the transaction. Both extra duty amount and VAT amount need to be specified in order to differ this property from automatically calculated.</summary>
		Public Property [ExtraDutyAmountFC] As Double?
		'''<summary>Extra duty percentage</summary>
		Public Property [ExtraDutyPercentage] As Double?
		'''<summary>The GL Account of the sales invoice line. This field is mandatory. This field is generated based on the revenue account of the item (or the related item group). G/L Account is also used to determine whether the costcenter / costunit is mandatory</summary>
		Public Property [GLAccount] As Guid?
		'''<summary>Description of GLAccount</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLAccountDescription] As String
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>The InvoiceID identifies the sales invoice. All the lines of a sales invoice have the same InvoiceID</summary>
		Public Property [InvoiceID] As Guid
		'''<summary>Reference to the item that is sold in this sales invoice line</summary>
		Public Property [Item] As Guid?
		'''<summary>Item code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemCode] As String
		'''<summary>Description of Item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDescription] As String
		'''<summary>Indicates the sequence of the lines within one invoice</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [LineNumber] As Int32?
		'''<summary>Net price of the sales invoice line</summary>
		Public Property [NetPrice] As Double?
		'''<summary>Extra notes</summary>
		Public Property [Notes] As String
		'''<summary>Price list</summary>
		Public Property [Pricelist] As Guid?
		'''<summary>Description of Pricelist</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PricelistDescription] As String
		'''<summary>The project to which the sales transaction line is linked. The project can be different per line. Sometimes also the project in the header is filled although this is not really used</summary>
		Public Property [Project] As Guid?
		'''<summary>Description of Project</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectDescription] As String
		'''<summary>WBS linked to the sales invoice</summary>
		Public Property [ProjectWBS] As Guid?
		'''<summary>Description of WBS</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectWBSDescription] As String
		'''<summary>The number of items sold in default units. The quantity shown in the entry screen is Quantity * UnitFactor</summary>
		Public Property [Quantity] As Double?
		'''<summary>Identifies the sales order this invoice line is based on</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SalesOrder] As Guid?
		'''<summary>Identifies the sales order line this sales invoice line is based on</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SalesOrderLine] As Guid?
		'''<summary>Then line number of the sales order line on which this invoice line is based on</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SalesOrderLineNumber] As Int32?
		'''<summary>The order number of the sales order on which this invoice line is based on</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SalesOrderNumber] As Int32?
		'''<summary>StartTime is used to store the first date of a period. StartTime is used in combination with EndTime</summary>
		Public Property [StartTime] As DateTime?
		'''<summary>When generating invoices from subscriptions, this field records the link between invoice lines and subscription lines</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Subscription] As Guid?
		'''<summary>Description of subscription line</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SubscriptionDescription] As String
		'''<summary>Obsolete</summary>
		Public Property [TaxSchedule] As Guid?
		'''<summary>Obsolete</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [TaxScheduleCode] As String
		'''<summary>Obsolete</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [TaxScheduleDescription] As String
		'''<summary>Code of Unit</summary>
		Public Property [UnitCode] As String
		'''<summary>Description of Unit</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [UnitDescription] As String
		'''<summary>Price per unit</summary>
		Public Property [UnitPrice] As Double?
		'''<summary>VAT amount in the default currency of the company</summary>
		Public Property [VATAmountDC] As Double?
		'''<summary>VAT amount in the currency of the transaction</summary>
		Public Property [VATAmountFC] As Double?
		'''<summary>The VAT code that is used when the invoice is registered</summary>
		Public Property [VATCode] As String
		'''<summary>Description of VATCode</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VATCodeDescription] As String
		'''<summary>The vat percentage of the VAT code. This is the percentage at the moment the invoice is created. It&apos;s also used for the default calculation of VAT amounts and VAT base amounts</summary>
		Public Property [VATPercentage] As Double?
	End Class

	<SupportedActionsSDK(True, False, False, False)>
	<DataServiceKey("ID")>
	Public Class [SalesOrderID]
		Public Property [ID] As Guid
	End Class

End Namespace