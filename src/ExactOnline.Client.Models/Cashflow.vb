Namespace Cashflow

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [Bank]
		'''<summary>The name of the bank</summary>
		Public Property [BankName] As String
		'''<summary>The bank identification code of the bank</summary>
		Public Property [BICCode] As String
		'''<summary>The country in which the bank is based</summary>
		Public Property [Country] As String
		'''<summary>Creation date</summary>
		Public Property [Created] As DateTime?
		'''<summary>The extended description of the bank</summary>
		Public Property [Description] As String
		'''<summary>The account format used by the bank</summary>
		Public Property [Format] As String
		'''<summary>The website of the bank</summary>
		Public Property [HomePageAddress] As String
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Last modified date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<summary>The status of the bank. A = Active, P = Passive</summary>
		Public Property [Status] As String
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [DirectDebitMandate]
		'''<summary>Account to which the mandate belongs.</summary>
		Public Property [Account] As Guid?
		'''<summary>Bank account to which the mandate belongs.</summary>
		Public Property [BankAccount] As Guid?
		'''<summary>Date that the mandate is cancelled. Used to check the validity of the mandate.</summary>
		Public Property [CancellationDate] As DateTime?
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<summary>User ID of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>Displays the description of the mandate.</summary>
		Public Property [Description] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<summary>Indicates the first collection hasn&apos;t been sent/confirmed with this mandate.</summary>
		Public Property [FirstSend] As Byte?
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Indicates if the mandate is the main, you can have only one main mandate</summary>
		Public Property [Main] As Byte?
		'''<summary>Last modified date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<summary>User ID of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Name of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>Depending on the payment type, a different bank file will be generated. 0 = One-off payment, 1 = Recurrent payment, 2 = AdHoc (UK only)</summary>
		Public Property [PaymentType] As Int16?
		'''<summary>Displays a reference number for the mandate. It is a unique reference number that you can assign to each mandate.</summary>
		Public Property [Reference] As String
		'''<summary>Date that the mandate is signed. The collection must take place after the signature date of the mandate. The date is used to check the validity of the mandate.</summary>
		Public Property [SignatureDate] As DateTime?
		'''<summary>Depending on the type, a different bank file will be generated. 0 = Core, 1 = B2B and 2 = bottomline (UK only)</summary>
		Public Property [Type] As Int16?
	End Class

	<SupportedActionsSDK(False, True, True, False)>
	<DataServiceKey("ID")>
	Public Class [ImportNotification]
		'''<summary>Number of the bank account related to the notification.</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [BankAccount] As String
		'''<summary>ID of the bank account related to the notification.</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [BankAccountID] As Guid?
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<summary>ID of the document related to the notification.</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Document] As Guid?
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Code of the import result</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Result] As Int16?
		'''<summary>Description of the import result</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ResultDescription] As String
		'''<summary>ID of the user that requested a retry of the import.</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [RetriedBy] As Guid?
		'''<summary>Date when the retry was requested.</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [RetriedOn] As DateTime?
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [ImportNotificationDetail]
		'''<summary>ID of the notification these details belong to.</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CashflowImportNotification] As Guid
		'''<summary>ID of the cashflow transaction feed related to this notification.</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CashflowTransactionFeed] As Guid?
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Termed message</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Message] As String
		'''<summary>Response code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ResponseCode] As Int16
		'''<summary>Additional information about the response</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ResponseCodeArguments] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [Payment]
		'''<summary>The supplier to which the payment has to be done.</summary>
		Public Property [Account] As Guid?
		'''<summary>The bank account of the supplier, to which the payment has to be done.</summary>
		Public Property [AccountBankAccountID] As Guid?
		'''<summary>The bank account number of the supplier, to which the payment has to be done.</summary>
		Public Property [AccountBankAccountNumber] As String
		'''<summary>The code of the supplier to which the payment has to be done.</summary>
		Public Property [AccountCode] As String
		'''<summary>Contact person copied from the purchase invoice linked to the related purchase entry. Used as prefered contact when sending reminders.</summary>
		Public Property [AccountContact] As Guid?
		'''<summary>Name of the contact person of the supplier.</summary>
		Public Property [AccountContactName] As String
		'''<summary>Name of the supplier.</summary>
		Public Property [AccountName] As String
		'''<summary>The amount in default currency (division currency). Payments are matched on this amount.</summary>
		Public Property [AmountDC] As Double
		'''<summary>The amount of the discount in the default currency.</summary>
		Public Property [AmountDiscountDC] As Double
		'''<summary>The amount of the discount. This is in the amount of the selected currency.</summary>
		Public Property [AmountDiscountFC] As Double
		'''<summary>The amount of the payment. This is in the amount of the selected currency.</summary>
		Public Property [AmountFC] As Double
		'''<summary>Own bank account from which the payment must be done.</summary>
		Public Property [BankAccountID] As Guid?
		'''<summary>Own bank account number from which the payment must be done.</summary>
		Public Property [BankAccountNumber] As String
		'''<summary>When processing payments, all payments with the same processing data are put in a batch. This field contains the code of that batch.</summary>
		Public Property [CashflowTransactionBatchCode] As String
		'''<summary>Creation date.</summary>
		Public Property [Created] As DateTime
		'''<summary>User ID of the creator.</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of the creator.</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>The currency of the payment. This currency can only deviate from the division currency if the module Currency is in the license.</summary>
		Public Property [Currency] As String
		'''<summary>Extra description for the payment that may be included in the bank export file.</summary>
		Public Property [Description] As String
		'''<summary>Date before which the payment must be done to be eligible for discount.</summary>
		Public Property [DiscountDueDate] As DateTime?
		'''<summary>Division code.</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32
		'''<summary>Document that is created when processing payments.  The bank export file is attached to the document.</summary>
		Public Property [Document] As Guid?
		'''<summary>Number of the document.</summary>
		Public Property [DocumentNumber] As Int32?
		'''<summary>Subject of the document.</summary>
		Public Property [DocumentSubject] As String
		'''<summary>Date before which the payment must be done.</summary>
		Public Property [DueDate] As DateTime?
		'''<summary>Date since when the payment is no longer an outstanding item. This is the highest invoice date of all matched payments.</summary>
		Public Property [EndDate] As DateTime?
		'''<summary>Period since when the payment is no longer an outstanding item. This is the highest period of all matched payments.</summary>
		Public Property [EndPeriod] As Int16?
		'''<summary>Year (of period) since when the payment is no longer an outstanding item. This is the highest year of all matched payments. Used in combination with EndPeriod.</summary>
		Public Property [EndYear] As Int16?
		'''<summary>Processing date of the payment.</summary>
		Public Property [EntryDate] As DateTime?
		'''<summary>The unique identifier for a set of payments. A payment can be split so that one part is paid on a different date. In that case the two records get a different EntryID.</summary>
		Public Property [EntryID] As Guid?
		'''<summary>Entry number of the linked transaction.</summary>
		Public Property [EntryNumber] As Int32?
		'''<summary>G/L account of the payment. Must be of type 22 (Accounts payable).</summary>
		Public Property [GLAccount] As Guid?
		'''<summary>Code of the G/L account.</summary>
		Public Property [GLAccountCode] As String
		'''<summary>Description of the G/L account.</summary>
		Public Property [GLAccountDescription] As String
		'''<summary>Identifier of the payment.</summary>
		Public Property [ID] As Guid
		'''<summary>Invoice date of the linked transaction.</summary>
		Public Property [InvoiceDate] As DateTime?
		'''<summary>Invoice number of the linked transaction.</summary>
		Public Property [InvoiceNumber] As Int32?
		'''<summary>Boolean indicating whether the payment is part of a batch booking.</summary>
		Public Property [IsBatchBooking] As Byte?
		'''<summary>Journal of the linked transaction.</summary>
		Public Property [Journal] As String
		'''<summary>Description of the journal.</summary>
		Public Property [JournalDescription] As String
		'''<summary>Last modified date.</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime
		'''<summary>User ID of modifier.</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Name of modifier.</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>Number assigned during the of processing payments. When payments are processed a bank export file is created. This file contains one or more batches that contain one or more payments. Each batch gets a sequence number that is stored for each payment in that batch.</summary>
		Public Property [PaymentBatchNumber] As Int32?
		'''<summary>Payment condition of the linked transaction.</summary>
		Public Property [PaymentCondition] As String
		'''<summary>Description of the payment condition.</summary>
		Public Property [PaymentConditionDescription] As String
		'''<summary>Number of days between invoice date and due date.</summary>
		Public Property [PaymentDays] As Int32?
		'''<summary>Number of days between invoice date and due date of the discount.</summary>
		Public Property [PaymentDaysDiscount] As Int32?
		'''<summary>Payment discount percentage.</summary>
		Public Property [PaymentDiscountPercentage] As Double?
		'''<summary>Method of payment.&lt;br&gt; B = On credit (default)&lt;br&gt; I = Collection&lt;br&gt; K = Cash&lt;br&gt; V = Credit card.</summary>
		Public Property [PaymentMethod] As String
		'''<summary>Payment reference for the payment that may be included in the bank export file.</summary>
		Public Property [PaymentReference] As String
		'''<summary>Date and time since when the payment is selected to be paid.</summary>
		Public Property [PaymentSelected] As DateTime?
		'''<summary>User who selected the payment to be paid.</summary>
		Public Property [PaymentSelector] As Guid?
		'''<summary>Name of the payment selector.</summary>
		Public Property [PaymentSelectorFullName] As String
		'''<summary>Exchange rate from payment currency to division currency. AmountFC * RateFC = AmountDC.</summary>
		Public Property [RateFC] As Double?
		'''<summary>The source of the payment.&lt;br&gt; 1 = manual&lt;br&gt; 2 = reconcile&lt;br&gt; 3 = match&lt;br&gt; 4 = import&lt;br&gt; 5 = process</summary>
		Public Property [Source] As Int32
		'''<summary>The status of the payment.&lt;br&gt; 20 = open&lt;br&gt; 30 = selected - payment is selected to be paid&lt;br&gt; 40 = processed - payment has been done&lt;br&gt; 50 = matched - payment is matched with one or more other outstanding items or financial statement lines</summary>
		Public Property [Status] As Int16?
		'''<summary>Total amount of the linked transaction in default currency (division currency).</summary>
		Public Property [TransactionAmountDC] As Double
		'''<summary>Total amount of the linked transaction in the selected currency.</summary>
		Public Property [TransactionAmountFC] As Double
		'''<summary>Due date of the linked transaction.</summary>
		Public Property [TransactionDueDate] As DateTime?
		'''<summary>Linked transaction. Use this as reference to PurchaseEntries.</summary>
		Public Property [TransactionEntryID] As Guid?
		'''<summary>Linked transaction line. Use this as reference to BankEntryLines and CashEntryLines.</summary>
		Public Property [TransactionID] As Guid?
		'''<summary>Indicates if the linked transaction is a reversal entry.</summary>
		Public Property [TransactionIsReversal] As Boolean
		'''<summary>Period of the linked transaction.</summary>
		Public Property [TransactionReportingPeriod] As Int16?
		'''<summary>Year of the linked transaction.</summary>
		Public Property [TransactionReportingYear] As Int16?
		'''<summary>Status of the linked transaction.</summary>
		Public Property [TransactionStatus] As Int16?
		'''<summary>Type of the linked transaction.</summary>
		Public Property [TransactionType] As Int32?
		'''<summary>Invoice number of the supplier. In case the payment belongs to a bank entry line and is matched with one invoice, YourRef is filled with the YourRef of this invoice.</summary>
		Public Property [YourRef] As String
	End Class

	<SupportedActionsSDK(True, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [PaymentCondition]
		'''<summary>Code of the payment condition</summary>
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
		'''<summary>Default credit management scenario to be used for new payment terms</summary>
		Public Property [CreditManagementScenario] As Guid?
		'''<summary>Code of CreditManagementScenario</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreditManagementScenarioCode] As String
		'''<summary>Description of CreditManagementScenario</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreditManagementScenarioDescription] As String
		'''<summary>Description of the payment condition</summary>
		Public Property [Description] As String
		'''<summary>Indicates how the discount amount is calculated. Values: E = Excluding VAT, I = Including VAT</summary>
		Public Property [DiscountCalculation] As String
		'''<summary>Number of days to pay within, to have the right to take the discount</summary>
		Public Property [DiscountPaymentDays] As Int32?
		'''<summary>Discount percentage</summary>
		Public Property [DiscountPercentage] As Double?
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
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
		'''<summary>Number of days to be included in the due date calculation. Example: invoice date = 17/01 PaymentEndOfMonths = 2 =&gt; 31/03 PaymentDays = 15 =&gt; 15/04</summary>
		Public Property [PaymentDays] As Int32?
		'''<summary>Type of payment discount. Values: B = Settlement discount, K = Credit surcharge</summary>
		Public Property [PaymentDiscountType] As String
		'''<summary>Number of month endings to be included in the due date calculation</summary>
		Public Property [PaymentEndOfMonths] As Int32?
		'''<summary>Method of payment. Values: B = On credit, I = Collection, K = Cash</summary>
		Public Property [PaymentMethod] As String
		'''<summary>Percentage (stored as fraction) of total invoice amount</summary>
		Public Property [Percentage] As Double?
		'''<summary>Indicates how the VAT amount is calculated Values: E = Excluding discount, I = Including discount</summary>
		Public Property [VATCalculation] As String
	End Class

	<SupportedActionsSDK(True, False, False, False)>
	<DataServiceKey("ID")>
	Public Class [PaymentID]
		'''<summary>ID of the payment to be processed.</summary>
		Public Property [ID] As Guid
	End Class

	<SupportedActionsSDK(True, False, False, False)>
	<DataServiceKey("ID")>
	Public Class [ProcessPayment]
		'''<summary>This is a URL to get the documents that were created after the payments were successfully processed. These documents have to be sent to the bank in order to do the payments.</summary>
		Public Property [BankExportDocumentsUrl] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32
		'''<summary>Contains the error message if an error occurred during the processing of the payment(s).</summary>
		Public Property [ErrorMessage] As String
		'''<summary>Primary key.</summary>
		Public Property [ID] As Guid
		'''<summary>Use this field to pass a collection of GUIDs representing the IDs of the payments that have to be processed.</summary>
		Public Property [PaymentIDs] As IEnumerable(Of Models.Cashflow.PaymentID)
		'''<summary>Contains information if the payments were successfully processed.</summary>
		Public Property [SuccessMessage] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [Receivable]
		'''<summary>The customer from which the receivable will come.</summary>
		Public Property [Account] As Guid?
		'''<summary>The bank account of the customer, from which the receivable will come.</summary>
		Public Property [AccountBankAccountID] As Guid?
		'''<summary>The bank account number of the customer, from which the receivable will come.</summary>
		Public Property [AccountBankAccountNumber] As String
		'''<summary>The code of the customer from which the receivable will come.</summary>
		Public Property [AccountCode] As String
		'''<summary>Contact person copied from the purchase invoice linked to the related purchase entry.</summary>
		Public Property [AccountContact] As Guid?
		'''<summary>Name of the contact person of the customer.</summary>
		Public Property [AccountContactName] As String
		'''<summary>Country code of the customer.</summary>
		Public Property [AccountCountry] As String
		'''<summary>Name of the customer.</summary>
		Public Property [AccountName] As String
		'''<summary>The amount in default currency (division currency). Receivables are matched on this amount.</summary>
		Public Property [AmountDC] As Double
		'''<summary>The amount of the discount in the default currency.</summary>
		Public Property [AmountDiscountDC] As Double
		'''<summary>The amount of the discount. This is in the amount of the selected currency.</summary>
		Public Property [AmountDiscountFC] As Double
		'''<summary>The amount of the receivable. This is in the amount of the selected currency.</summary>
		Public Property [AmountFC] As Double
		'''<summary>Own bank account to which the receivable will be done.</summary>
		Public Property [BankAccountID] As Guid?
		'''<summary>Own bank account number to which the receivable will be done.</summary>
		Public Property [BankAccountNumber] As String
		'''<summary>When processing receivables, all receivable with the same processing data are put in a batch. This field contains the code of that batch.</summary>
		Public Property [CashflowTransactionBatchCode] As String
		'''<summary>Creation date.</summary>
		Public Property [Created] As DateTime
		'''<summary>User ID of the creator.</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of the creator.</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>The currency of the receivable. This currency can only deviate from the division currency if the module Currency is in the license.</summary>
		Public Property [Currency] As String
		'''<summary>Description.</summary>
		Public Property [Description] As String
		'''<summary>Direct Debit Mandate used to collect the receivable.</summary>
		Public Property [DirectDebitMandate] As Guid?
		'''<summary>Description of the mandate.</summary>
		Public Property [DirectDebitMandateDescription] As String
		'''<summary>Payment type of the mandate.&lt;br&gt; 0 = One off payment&lt;br&gt; 1 = Recurrent payment.</summary>
		Public Property [DirectDebitMandatePaymentType] As Int16?
		'''<summary>Unique mandate reference.</summary>
		Public Property [DirectDebitMandateReference] As String
		'''<summary>Type of the mandate.&lt;br&gt; 0 = Core&lt;br&gt; 1 = Business-to-business.</summary>
		Public Property [DirectDebitMandateType] As Int16?
		'''<summary>Date before which the payment by the customer must be done to be eligible for discount.</summary>
		Public Property [DiscountDueDate] As DateTime?
		'''<summary>Division code.</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32
		'''<summary>Document that is created when processing collections.  The bank export file is attached to the document.</summary>
		Public Property [Document] As Guid?
		'''<summary>Number of the document.</summary>
		Public Property [DocumentNumber] As Int32?
		'''<summary>Subject of the document.</summary>
		Public Property [DocumentSubject] As String
		'''<summary>Date before which the payment by the customer must be done.</summary>
		Public Property [DueDate] As DateTime?
		'''<summary>Date since when the receivable is no longer an outstanding item. This is the highest invoice date of all matched receivables.</summary>
		Public Property [EndDate] As DateTime?
		'''<summary>Period since when the receivable is no longer an outstanding item. This is the highest period of all matched receivables.</summary>
		Public Property [EndPeriod] As Int16?
		'''<summary>The value of the tag &apos;EndToEndID&apos; when generating a SEPA file.</summary>
		Public Property [EndToEndID] As String
		'''<summary>Year (of period) since when the receivable is no longer an outstanding item. This is the highest year of all matched receivables. Used in combination with EndPeriod.</summary>
		Public Property [EndYear] As Int16?
		'''<summary>Processing date of the receivable.</summary>
		Public Property [EntryDate] As DateTime?
		'''<summary>The unique identifier for a set of receivables. A receivable can be split so that one part is received on a different date. In that case the two records get a different EntryID.</summary>
		Public Property [EntryID] As Guid?
		'''<summary>Entry number of the linked transaction.</summary>
		Public Property [EntryNumber] As Int32?
		'''<summary>G/L account of the payment. Must be of type 20 (Accounts receivable).</summary>
		Public Property [GLAccount] As Guid?
		'''<summary>Code of the G/L account.</summary>
		Public Property [GLAccountCode] As String
		'''<summary>Description of the G/L account.</summary>
		Public Property [GLAccountDescription] As String
		'''<summary>Identifier of the receivable.</summary>
		Public Property [ID] As Guid
		'''<summary>Invoice date of the linked transaction.</summary>
		Public Property [InvoiceDate] As DateTime?
		'''<summary>Invoice number of the linked transaction.</summary>
		Public Property [InvoiceNumber] As Int32?
		'''<summary>Boolean indicating whether the receivable is part of a batch booking.</summary>
		Public Property [IsBatchBooking] As Byte?
		'''<summary>Boolean indicating whether the receivable was fully paid by the customer.</summary>
		Public Property [IsFullyPaid] As Boolean
		'''<summary>Journal of the linked transaction.</summary>
		Public Property [Journal] As String
		'''<summary>Description of the journal.</summary>
		Public Property [JournalDescription] As String
		'''<summary>Last payment date.</summary>
		Public Property [LastPaymentDate] As DateTime?
		'''<summary>Last modified date.</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime
		'''<summary>User ID of modifier.</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Name of modifier.</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>Payment condition of the linked transaction.</summary>
		Public Property [PaymentCondition] As String
		'''<summary>Description of the payment condition.</summary>
		Public Property [PaymentConditionDescription] As String
		'''<summary>Number of days between invoice date and due date.</summary>
		Public Property [PaymentDays] As Int32?
		'''<summary>Number of days between invoice date and due date of the discount.</summary>
		Public Property [PaymentDaysDiscount] As Int32?
		'''<summary>Payment discount percentage.</summary>
		Public Property [PaymentDiscountPercentage] As Double?
		'''<summary>PaymentInformationID tag from the SEPA xml file.</summary>
		Public Property [PaymentInformationID] As String
		'''<summary>Method of payment.&lt;br&gt; B = On credit (default)&lt;br&gt; I = Collection&lt;br&gt; K = Cash&lt;br&gt; V = Credit card</summary>
		Public Property [PaymentMethod] As String
		'''<summary>Payment reference for the receivable that may be included In the bank export file</summary>
		Public Property [PaymentReference] As String
		'''<summary>Exchange rate from receivable currency to division currency. AmountFC * RateFC = AmountDC.</summary>
		Public Property [RateFC] As Double?
		'''<summary>Number assigned during the processing of receivables.</summary>
		Public Property [ReceivableBatchNumber] As Int32?
		'''<summary>Date and time since when the receivable is selected to be collected.</summary>
		Public Property [ReceivableSelected] As DateTime?
		'''<summary>User who selected the receivable to be collected.</summary>
		Public Property [ReceivableSelector] As Guid?
		'''<summary>Name of the receivable selector.</summary>
		Public Property [ReceivableSelectorFullName] As String
		'''<summary>The source of the receivable.&lt;br&gt; 1 = manual&lt;br&gt; 2 = reconcile&lt;br&gt; 3 = match&lt;br&gt; 4 = import&lt;br&gt; 5 = process</summary>
		Public Property [Source] As Int32
		'''<summary>The status of the receivable.&lt;br&gt; 20 = open&lt;br&gt; 30 = selected - receivable is selected to be collected&lt;br&gt; 40 = processed - collection has been done&lt;br&gt; 50 = matched - receivable is matched with one or more other outstanding items or financial statement lines</summary>
		Public Property [Status] As Int16?
		'''<summary>Total amount of the linked transaction in default currency (division currency).</summary>
		Public Property [TransactionAmountDC] As Double
		'''<summary>Total amount of the linked transaction in the selected currency.</summary>
		Public Property [TransactionAmountFC] As Double
		'''<summary>Due date of the linked transaction.</summary>
		Public Property [TransactionDueDate] As DateTime?
		'''<summary>Linked transaction. Use this as reference to SalesEntries.</summary>
		Public Property [TransactionEntryID] As Guid?
		'''<summary>Linked transaction line. Use this as reference to BankEntryLines and CashEntryLines.</summary>
		Public Property [TransactionID] As Guid?
		'''<summary>Indicates if the linked transaction is a reversal entry.</summary>
		Public Property [TransactionIsReversal] As Boolean
		'''<summary>Period of the linked transaction.</summary>
		Public Property [TransactionReportingPeriod] As Int16?
		'''<summary>Year of the linked transaction.</summary>
		Public Property [TransactionReportingYear] As Int16?
		'''<summary>Status of the linked transaction.</summary>
		Public Property [TransactionStatus] As Int16?
		'''<summary>Type of the linked transaction.</summary>
		Public Property [TransactionType] As Int32?
		'''<summary>Invoice number. In case the receivable belongs to a bank entry line and is matched with one invoice, YourRef is filled with the YourRef of this invoice.</summary>
		Public Property [YourRef] As String
	End Class

End Namespace