Namespace Financial

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("AgeGroup")>
	Public Class [AgingOverview]
		'''<summary>Primary key</summary>
		Public Property [AgeGroup] As Int32
		'''<summary>Description of AgeGroup</summary>
		Public Property [AgeGroupDescription] As String
		'''<summary>Amount payable</summary>
		Public Property [AmountPayable] As Double
		'''<summary>Amount receivable</summary>
		Public Property [AmountReceivable] As Double
		'''<summary>Code of Currency</summary>
		Public Property [CurrencyCode] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("AccountId")>
	Public Class [AgingPayablesList]
		'''<summary>Code of Account</summary>
		Public Property [AccountCode] As String
		'''<summary>Primary key</summary>
		Public Property [AccountId] As Guid
		'''<summary>Name of Account</summary>
		Public Property [AccountName] As String
		'''<summary>Age group 1</summary>
		Public Property [AgeGroup1] As Int32
		'''<summary>Amount of age group 1</summary>
		Public Property [AgeGroup1Amount] As Double
		'''<summary>Description of AgeGroup1</summary>
		Public Property [AgeGroup1Description] As String
		'''<summary>Age group 2</summary>
		Public Property [AgeGroup2] As Int32
		'''<summary>Amount of age group 2</summary>
		Public Property [AgeGroup2Amount] As Double
		'''<summary>Description of AgeGroup2</summary>
		Public Property [AgeGroup2Description] As String
		'''<summary>Age group 3</summary>
		Public Property [AgeGroup3] As Int32
		'''<summary>Amount of age group 3</summary>
		Public Property [AgeGroup3Amount] As Double
		'''<summary>Description of AgeGroup3</summary>
		Public Property [AgeGroup3Description] As String
		'''<summary>Age group 4</summary>
		Public Property [AgeGroup4] As Int32
		'''<summary>Amount of age group 4</summary>
		Public Property [AgeGroup4Amount] As Double
		'''<summary>Description of AgeGroup4</summary>
		Public Property [AgeGroup4Description] As String
		'''<summary>Code of Currency</summary>
		Public Property [CurrencyCode] As String
		'''<summary>Total amount of all age groups</summary>
		Public Property [TotalAmount] As Double
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("AccountId")>
	Public Class [AgingReceivablesList]
		'''<summary>Code of Account</summary>
		Public Property [AccountCode] As String
		'''<summary>Primary key</summary>
		Public Property [AccountId] As Guid
		'''<summary>Name of Account</summary>
		Public Property [AccountName] As String
		'''<summary>Age group 1</summary>
		Public Property [AgeGroup1] As Int32
		'''<summary>Amount of age group 1</summary>
		Public Property [AgeGroup1Amount] As Double
		'''<summary>Description of AgeGroup1</summary>
		Public Property [AgeGroup1Description] As String
		'''<summary>Age group 2</summary>
		Public Property [AgeGroup2] As Int32
		'''<summary>Amount of age group 2</summary>
		Public Property [AgeGroup2Amount] As Double
		'''<summary>Description of AgeGroup2</summary>
		Public Property [AgeGroup2Description] As String
		'''<summary>Age group 3</summary>
		Public Property [AgeGroup3] As Int32
		'''<summary>Amount of age group 3</summary>
		Public Property [AgeGroup3Amount] As Double
		'''<summary>Description of AgeGroup3</summary>
		Public Property [AgeGroup3Description] As String
		'''<summary>Age group 4</summary>
		Public Property [AgeGroup4] As Int32
		'''<summary>Amount of age group 4</summary>
		Public Property [AgeGroup4Amount] As Double
		'''<summary>Description of AgeGroup4</summary>
		Public Property [AgeGroup4Description] As String
		'''<summary>Code of Currency</summary>
		Public Property [CurrencyCode] As String
		'''<summary>Total amount of all age groups</summary>
		Public Property [TotalAmount] As Double
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [ExchangeRate]
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<summary>User ID of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator</summary>
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
		'''<summary>User ID of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Name of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>The exchange rate is stored as 1 TARGET CURRENCY = x SOURCE CURRENCY</summary>
		Public Property [Rate] As Double?
		'''<summary>The foreign currency</summary>
		Public Property [SourceCurrency] As String
		'''<summary>Description of SourceCurrency</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SourceCurrencyDescription] As String
		'''<summary>The date as of which the rate is valid. The rate is valid until a next rate is defined</summary>
		Public Property [StartDate] As DateTime?
		'''<summary>The default currency of the division</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [TargetCurrency] As String
		'''<summary>Description of TargetCurrency</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [TargetCurrencyDescription] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [FinancialPeriod]
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<summary>User ID of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<summary>The end date of the period</summary>
		Public Property [EndDate] As DateTime?
		'''<summary>The financial period. Usually the period is a month or quarter with period 1 starting on the first of January.</summary>
		Public Property [FinPeriod] As Int16?
		'''<summary>The financial year. The financial year and calendar year are not always aligned.</summary>
		Public Property [FinYear] As Int16?
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
		'''<summary>The start date of a period. A start date should always succeed a previous end date. Except for the first year/period combination</summary>
		Public Property [StartDate] As DateTime?
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [GLAccount]
		'''<summary>AssimilatedVATBox (France)</summary>
		Public Property [AssimilatedVATBox] As Int16?
		'''<summary>The following values are supported: D (Debit) C (Credit)</summary>
		Public Property [BalanceSide] As String
		'''<summary>The following values are supported: B (Balance Sheet) W (Profit &amp; Loss)</summary>
		Public Property [BalanceType] As String
		'''<summary>Indentify the kind of rewarding for the G/L account. This is used in the official document for the fiscal fiches Belcotax</summary>
		Public Property [BelcotaxType] As Int32?
		'''<summary>Unique Code of the G/L account</summary>
		Public Property [Code] As String
		'''<summary>Indicate if this G/L account should be shown as compressed without the details in the CRW report of G/L history</summary>
		Public Property [Compress] As Boolean?
		'''<summary>Cost Center linked to the G/L account</summary>
		Public Property [Costcenter] As String
		'''<summary>Description of Costcenter</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CostcenterDescription] As String
		'''<summary>Cost Unit linked to the G/L account</summary>
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
		'''<summary>Name of the G/L account</summary>
		Public Property [Description] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32
		'''<summary>General ledger transactions on this G/L account should not appear on the VAT listing</summary>
		Public Property [ExcludeVATListing] As Byte
		'''<summary>Expenses on this G/L account can not be used to reduce the incomes</summary>
		Public Property [ExpenseNonDeductiblePercentage] As Double?
		'''<summary>Primary Key</summary>
		Public Property [ID] As Guid
		'''<summary>When blocked you can&apos;t use this general ledger account anymore for new entries</summary>
		Public Property [IsBlocked] As Boolean?
		'''<summary>Allow entries on this general ledger account to be matched via the G/L account card</summary>
		Public Property [Matching] As Boolean?
		'''<summary>Last modified date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<summary>User ID of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Name of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>If a private use percentage is defined, you need to specify the G/L account used for the re-invoice of the private use to the owner of the company</summary>
		Public Property [PrivateGLAccount] As Guid?
		'''<summary>Specify the percentage of the cost that should be re-invoiced to the owner of the company as private use of the costs</summary>
		Public Property [PrivatePercentage] As Double?
		'''<summary>Used in the export of yearly report</summary>
		Public Property [ReportingCode] As String
		'''<summary>Indicates if the amounts booked on this general ledger account will be recalculated when currency revaluation is done</summary>
		Public Property [RevalueCurrency] As Boolean?
		'''<summary>Search Code</summary>
		Public Property [SearchCode] As String
		'''<summary>The type of the G/L account. Supported values are:&lt;br&gt;10 = Cash&lt;br&gt;12 = Bank&lt;br&gt;14 = Credit card&lt;br&gt;16 = Payment services&lt;br&gt;20 = Accounts receivable&lt;br&gt;21 = Prepayment accounts receivable&lt;br&gt;22 = Accounts payable&lt;br&gt;24 = VAT&lt;br&gt;25 = Employees payable&lt;br&gt;26 = Prepaid expenses&lt;br&gt;27 = Accrued expenses&lt;br&gt;29 = Income taxes payable&lt;br&gt;30 = Fixed assets&lt;br&gt;32 = Other assets&lt;br&gt;35 = Accumulated depreciation&lt;br&gt;40 = Inventory&lt;br&gt;50 = Capital stock&lt;br&gt;52 = Retained earnings&lt;br&gt;55 = Long term debt&lt;br&gt;60 = Current portion of debt&lt;br&gt;90 = General&lt;br&gt;100 = Tax payable&lt;br&gt;110 = Revenue&lt;br&gt;111 = Cost of goods&lt;br&gt;120 = Other costs&lt;br&gt;121 = Sales, general administrative expenses&lt;br&gt;122 = Depreciation costs&lt;br&gt;123 = Research and development&lt;br&gt;125 = Employee costs&lt;br&gt;126 = Employment costs&lt;br&gt;130 = Exceptional costs&lt;br&gt;140 = Exceptional income&lt;br&gt;150 = Income taxes&lt;br&gt;160 = Interest income&lt;br&gt;300 = Year end reflection&lt;br&gt;301 = Indirect year end costing&lt;br&gt;302 = Direct year end costing&lt;br&gt;</summary>
		Public Property [Type] As Int32?
		'''<summary>Description of Type</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [TypeDescription] As String
		'''<summary>Indicates if cost centers can be used when using this general ledger account. The following values are supported: 0 (Optional) 1 (Mandatory) 2 (No)</summary>
		Public Property [UseCostcenter] As Byte?
		'''<summary>Indicates if cost units can be used when using this general ledger account. The following values are supported: 0 (Optional) 1 (Mandatory) 2 (No)</summary>
		Public Property [UseCostunit] As Byte?
		'''<summary>VAT Code linked to the G/L account</summary>
		Public Property [VATCode] As String
		'''<summary>Description of VAT</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VATDescription] As String
		'''<summary>Specify the kind of purchase this G/L account is used for. This is important for the Belgian VAT return to indicate in which VAT box the base amount of purchase should go</summary>
		Public Property [VATGLAccountType] As String
		'''<summary>If you use a percentage of non deductible VAT, you can specify another G/L account that will be used for the non deductible part of the VAT amount. This is used directly in the entry application of purchase invoices.</summary>
		Public Property [VATNonDeductibleGLAccount] As Guid?
		'''<summary>If not the full amount of the VAT is deductible, you can indicate a percentage for the non decuctible part. This is used during the entry of purchase invoices</summary>
		Public Property [VATNonDeductiblePercentage] As Double?
		'''<summary>The following values are supported: I (Invoice) C (Cash) (France)</summary>
		Public Property [VATSystem] As String
		'''<summary>Indicates the costing account for year end calculations</summary>
		Public Property [YearEndCostGLAccount] As Guid?
		'''<summary>Indicates the reflection account that is used by year end application</summary>
		Public Property [YearEndReflectionGLAccount] As Guid?
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [GLClassification]
		'''<summary>Abstract elements are only used in presentation linkbases to group other elements. They are not supposed to be used in instance documents</summary>
		Public Property [Abstract] As Boolean?
		'''<summary>Only used for amount concepts: in that case either &apos;debit&apos; or &apos;credit&apos;</summary>
		Public Property [Balance] As String
		'''<summary>The Code is unique</summary>
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
		'''<summary>Description of the element. Note that this description is only used for division-specific taxonomies (or reporting schemes).</summary>
		Public Property [Description] As String
		'''<summary>Division is optional. For taxonomies of Taxonomies.Type = 0 (general taxonomies), the Division is empty. For division specific taxonomies it is mandatory</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Obsolete</summary>
		Public Property [IsTupleSubElement] As Boolean?
		'''<summary>Last modified date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<summary>User ID of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Name of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>The Name is unique in the namespace</summary>
		Public Property [Name] As String
		'''<summary>Determines whether usage of the element is mandatory in an instance document</summary>
		Public Property [Nillable] As Boolean?
		'''<summary>Parent element for reporting schemes. In a reporting scheme, an element can have only one parent. This column is only used for reporting schemes. Note that in a real taxonomy, elements can have multiple parents.</summary>
		Public Property [Parent] As Guid?
		'''<summary>Only used for item concepts: either &apos;instant&apos; or &apos;duration&apos;. &apos;instant&apos; is used for balance types of concepts, &apos;duration&apos; is used for P&amp;L types of concepts</summary>
		Public Property [PeriodType] As String
		'''<summary>Mostly import sutstitutiongroup is xbrli:tuple, which makes the element a tuple concept. The default substitutiongroup for item concepts is xbrli:item</summary>
		Public Property [SubstitutionGroup] As String
		'''<summary>Namespace of the element</summary>
		Public Property [TaxonomyNamespace] As Guid?
		'''<summary>Description of TaxonomyNamespace</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [TaxonomyNamespaceDescription] As String
		'''<summary>Type of the element</summary>
		Public Property [Type] As Guid?
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [GLScheme]
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
		'''<summary>Description text</summary>
		Public Property [Description] As String
		'''<summary>Division is optional for this table. For taxonomies of Taxonomies.Type = 0 (general taxonomies), the Division is empty. For division specific taxonomies it is mandatory</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Only used for reporting schemes = division specific taxonomynamespaces. In this case, main = 1 denotes the main or default reporting scheme</summary>
		Public Property [Main] As Byte
		'''<summary>Last modified date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<summary>User ID of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Name of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>URI, which is the unique identifier of the namespace</summary>
		Public Property [TargetNamespace] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [GLTransactionType]
		Public Property [Description] As String
		Public Property [DescriptionSuffix] As String
		Public Property [ID] As Int32
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [Journal]
		'''<summary>Indicates if the journal allows variable currency</summary>
		Public Property [AllowVariableCurrency] As Boolean?
		'''<summary>Indicates if the journal allows the exchange rate of the currency of the amounts in the journal entry to be changed</summary>
		Public Property [AllowVariableExchangeRate] As Boolean?
		'''<summary>Indicates if the journal allows the use of VAT in the financial entry. Especially true for general journals</summary>
		Public Property [AllowVAT] As Boolean?
		'''<summary>Indicates if the journal automatically saves the entries when the amount is in balance with the entry lines</summary>
		Public Property [AutoSave] As Boolean?
		'''<summary>Reference to bank account</summary>
		Public Property [Bank] As Guid?
		'''<summary>BIC code of the bank where the bank account is held</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [BankAccountBICCode] As String
		'''<summary>Country of bank account</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [BankAccountCountry] As String
		'''<summary>Description of BankAccount</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [BankAccountDescription] As String
		'''<summary>IBAN of the bank account</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [BankAccountIBAN] As String
		'''<summary>Reference to the Bank Account linked to the Journal</summary>
		Public Property [BankAccountID] As Guid?
		'''<summary>Bank account number. Is mandatory for Journals that have Type = Bank</summary>
		Public Property [BankAccountIncludingMask] As String
		'''<summary>Obsolete. Whether or not use SEPA for the bank account</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [BankAccountUseSEPA] As Boolean?
		'''<summary>Obsolete. Whether or not use SEPA direct debit for the bank account</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [BankAccountUseSepaDirectDebit] As Boolean?
		'''<summary>Name of bank account</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [BankName] As String
		'''<summary>Primary key</summary>
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
		'''<summary>Default Currency of the Journal. If AllowVariableCurrency is false this is the only currency that can be used</summary>
		Public Property [Currency] As String
		'''<summary>Description of Currency</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CurrencyDescription] As String
		'''<summary>Name of the Journal</summary>
		Public Property [Description] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<summary>Suspense general ledger account</summary>
		Public Property [GLAccount] As Guid?
		'''<summary>Code of GLAccount</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLAccountCode] As String
		'''<summary>Description of GLAccount</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLAccountDescription] As String
		'''<summary>Type of GLAccount</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLAccountType] As Int32?
		'''<summary>Primary Key</summary>
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
		'''<summary>General ledger account for payment in transit</summary>
		Public Property [PaymentInTransitAccount] As Guid?
		'''<summary>Identifier detail of the Payment service account. Ex. EmailID for Paypal type of Payment service account</summary>
		Public Property [PaymentServiceAccountIdentifier] As String
		'''<summary>Type of Payment service provider. The following values are supported: 1 (Adyen), 2 (Paypal), 3 (Stripe). Is mandatory for Journals of Type 16 (Payment service)</summary>
		Public Property [PaymentServiceProvider] As Int32?
		'''<summary>Name of the Payment service provider</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PaymentServiceProviderName] As String
		'''<summary>Type of Journal. The following values are supported: 10 (Cash) 12 (Bank) 16 (Payment service) 20 (Sales) 21 (Return invoice) 22 (Purchase) 23 (Received return invoice) 90 (General journal)</summary>
		Public Property [Type] As Int32?
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("Year,Period,Journal")>
	Public Class [JournalStatusList]
		'''<summary>Reference to Journal</summary>
		Public Property [Journal] As String
		'''<summary>Description of Journal</summary>
		Public Property [JournalDescription] As String
		'''<summary>Type of Journal 10=Cash, 12=Bank, 20=Sales, 21=Return invoice, 22=Purchase, 23=Received return invoice, 90=General journal</summary>
		Public Property [JournalType] As Int32
		'''<summary>Description of JournalType</summary>
		Public Property [JournalTypeDescription] As String
		'''<summary>Financial period</summary>
		Public Property [Period] As Int32
		'''<summary>Journal status for this year and period 0=open, 1=closed</summary>
		Public Property [Status] As Int32
		'''<summary>Description of Status</summary>
		Public Property [StatusDescription] As String
		'''<summary>Financial year</summary>
		Public Property [Year] As Int32
	End Class

	<SupportedActionsSDK(True, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [OfficialReturn]
		'''<summary>Total liquidation amount of the official return</summary>
		Public Property [Amount] As Double?
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<summary>User ID of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>CreatorFullName</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>Description of the official return</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Description] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<summary>Document linked to the official return.</summary>
		Public Property [Document] As Guid?
		'''<summary>DocumentSubject</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DocumentSubject] As String
		'''<summary>Frequency Monthly = 10,	TwoMonthly = 20, Quarterly = 30, Yearly = 40,FinancialYearQuarter = 100</summary>
		Public Property [Frequency] As Int16?
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>IsCorrection</summary>
		Public Property [IsCorrection] As Byte?
		'''<summary>Last modified date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<summary>User ID of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Name of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>Financial period (for annual returns = 0)</summary>
		Public Property [Period] As Int16?
		'''<summary>Registration data of the presenting proof document, JSON serialized dictionary  &lt;table class=&quot;enum&quot; style=&quot;width:30%&quot;&gt;  &lt;tr&gt;&lt;td colspan=&quot;2&quot; align=&quot;center&quot;&gt;&lt;b&gt;Spanish legislation Keys:&lt;/b&gt;&lt;/td&gt;&lt;/tr&gt;  &lt;tr&gt;&lt;td&gt;registrationEntryNumber&lt;/td&gt;&lt;td&gt;Registration entry number&lt;/td&gt;&lt;/tr&gt;  &lt;tr&gt;&lt;td&gt;safeCodeVerification&lt;/td&gt;&lt;td&gt;Tax authorities CSV&lt;/td&gt;&lt;/tr&gt;  &lt;tr&gt;&lt;td&gt;vatPresenter&lt;/td&gt;&lt;td&gt;VAT number of the presenter&lt;/td&gt;&lt;/tr&gt;  &lt;tr&gt;&lt;td&gt;surnameNameCompanyName&lt;/td&gt;&lt;td&gt;Name of the presenter&lt;/td&gt;&lt;/tr&gt;  &lt;tr&gt;&lt;td&gt;capacityOf&lt;/td&gt;&lt;td&gt;COLABORADOR&lt;/td&gt;&lt;/tr&gt;  &lt;tr&gt;&lt;td&gt;receiptNumber&lt;/td&gt;&lt;td&gt;Receipt number&lt;/td&gt;&lt;/tr&gt;  &lt;/table&gt;</summary>
		Public Property [PresentationData] As String
		'''<summary>Presentation date of the official return to the tax authorities</summary>
		Public Property [PresentationDate] As DateTime?
		'''<summary>For performance reasons presentation attachment is Write-Only.</summary>
		Public Property [PresentationFile] As Byte()
		'''<summary>File name of presentation attachment.</summary>
		Public Property [PresentationFileName] As String
		'''<summary>Reference of the official return</summary>
		Public Property [Reference] As String
		'''<summary>Source of the official return : 1 - EOL, 2 - RestAPI</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Source] As Int16?
		'''<summary>Status of the official return</summary>
		Public Property [Status] As Int16?
		'''<summary>Type of the official return</summary>
		Public Property [Type] As Int16?
		'''<summary>Official return type description</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [TypeDescription] As String
		'''<summary>Financial year of the official return</summary>
		Public Property [Year] As Int16?
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("CurrencyCode")>
	Public Class [OutstandingInvoicesOverview]
		'''<summary>Primary key</summary>
		Public Property [CurrencyCode] As String
		'''<summary>Total invoice amount to be paid</summary>
		Public Property [OutstandingPayableInvoiceAmount] As Double
		'''<summary>Number of invoices to be paid</summary>
		Public Property [OutstandingPayableInvoiceCount] As Double
		'''<summary>Total invoice amount to be received</summary>
		Public Property [OutstandingReceivableInvoiceAmount] As Double
		'''<summary>Number of invoices to be received</summary>
		Public Property [OutstandingReceivableInvoiceCount] As Double
		'''<summary>Total payable invoice amount that is overdue</summary>
		Public Property [OverduePayableInvoiceAmount] As Double
		'''<summary>Number of payable invoices that are overdue</summary>
		Public Property [OverduePayableInvoiceCount] As Double
		'''<summary>Total receivable invoice amount that is overdue</summary>
		Public Property [OverdueReceivableInvoiceAmount] As Double
		'''<summary>Number of receivable invoices that are overdue</summary>
		Public Property [OverdueReceivableInvoiceCount] As Double
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("HID")>
	Public Class [PayablesList]
		'''<summary>Code of Account</summary>
		Public Property [AccountCode] As String
		'''<summary>Reference to the account</summary>
		Public Property [AccountId] As Guid
		'''<summary>Name of Account</summary>
		Public Property [AccountName] As String
		'''<summary>Amount</summary>
		Public Property [Amount] As Double
		'''<summary>Amount in transit</summary>
		Public Property [AmountInTransit] As Double
		'''<summary>Approval status:&lt;br&gt;  						null - Invoice was entered before approval functionality was activated (treated as Approved for payments)&lt;br&gt;  						1 - N/A (used for non-electronic payment methods)&lt;br&gt;  						2 - Awaiting review&lt;br&gt;  						3 - Awaiting approval&lt;br&gt;  						4 - Approved</summary>
		Public Property [ApprovalStatus] As Int16?
		'''<summary>Code of Currency</summary>
		Public Property [CurrencyCode] As String
		'''<summary>Description</summary>
		Public Property [Description] As String
		'''<summary>Date the invoice is due (This due date is not the discount due date)</summary>
		Public Property [DueDate] As DateTime
		'''<summary>Entry number</summary>
		Public Property [EntryNumber] As Int32
		'''<summary>Primary key, human readable ID</summary>
		Public Property [HID] As Int64
		'''<summary>Obsolete</summary>
		Public Property [Id] As Guid
		'''<summary>Invoice date</summary>
		Public Property [InvoiceDate] As DateTime
		'''<summary>Invoice number. The value is 0 when the invoice number of the linked transaction is empty.</summary>
		Public Property [InvoiceNumber] As Int32
		'''<summary>Code of Journal</summary>
		Public Property [JournalCode] As String
		'''<summary>Description of Journal</summary>
		Public Property [JournalDescription] As String
		'''<summary>Your reference</summary>
		Public Property [YourRef] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("CurrentYear")>
	Public Class [ProfitLossOverview]
		'''<summary>Costs in current period</summary>
		Public Property [CostsCurrentPeriod] As Double
		'''<summary>Costs in current year</summary>
		Public Property [CostsCurrentYear] As Double
		'''<summary>Costs in previous year</summary>
		Public Property [CostsPreviousYear] As Double
		'''<summary>Costs in period of previous year</summary>
		Public Property [CostsPreviousYearPeriod] As Double
		'''<summary>Currency code</summary>
		Public Property [CurrencyCode] As String
		'''<summary>Current period</summary>
		Public Property [CurrentPeriod] As Int32
		'''<summary>Primary key, Current year</summary>
		Public Property [CurrentYear] As Int32
		'''<summary>Previous year</summary>
		Public Property [PreviousYear] As Int32
		'''<summary>Period in previous year</summary>
		Public Property [PreviousYearPeriod] As Int32
		'''<summary>Results of current period</summary>
		Public Property [ResultCurrentPeriod] As Double
		Public Property [ResultCurrentYear] As Double
		Public Property [ResultPreviousYear] As Double
		'''<summary>Results of period in previous year</summary>
		Public Property [ResultPreviousYearPeriod] As Double
		'''<summary>Revenue in current period</summary>
		Public Property [RevenueCurrentPeriod] As Double
		'''<summary>Revenue in current year</summary>
		Public Property [RevenueCurrentYear] As Double
		'''<summary>Revenue in previous year</summary>
		Public Property [RevenuePreviousYear] As Double
		'''<summary>Revenue in period of previous year</summary>
		Public Property [RevenuePreviousYearPeriod] As Double
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("HID")>
	Public Class [ReceivablesList]
		'''<summary>Code of Account</summary>
		Public Property [AccountCode] As String
		'''<summary>Reference to the account</summary>
		Public Property [AccountId] As Guid
		'''<summary>Name of Account</summary>
		Public Property [AccountName] As String
		'''<summary>Amount</summary>
		Public Property [Amount] As Double
		'''<summary>Amount in transit</summary>
		Public Property [AmountInTransit] As Double
		'''<summary>Code of Currency</summary>
		Public Property [CurrencyCode] As String
		'''<summary>Description</summary>
		Public Property [Description] As String
		'''<summary>Date the invoice is due (This due date is not the discount due date)</summary>
		Public Property [DueDate] As DateTime
		'''<summary>Entry number</summary>
		Public Property [EntryNumber] As Int32
		'''<summary>Primary key, human readable ID</summary>
		Public Property [HID] As Int64
		'''<summary>Obsolete</summary>
		Public Property [Id] As Guid
		'''<summary>Invoice date</summary>
		Public Property [InvoiceDate] As DateTime
		'''<summary>Invoice number. The value is 0 when the invoice number of the linked transaction is empty.</summary>
		Public Property [InvoiceNumber] As Int32
		'''<summary>Code of Journal</summary>
		Public Property [JournalCode] As String
		'''<summary>Description of Journal</summary>
		Public Property [JournalDescription] As String
		'''<summary>Your reference</summary>
		Public Property [YourRef] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [ReportingBalance]
		'''<summary>The sum of the amounts of all transactions in the grouping.</summary>
		Public Property [Amount] As Double?
		'''<summary>The sum of the amounts of all credit transactions in the grouping.</summary>
		Public Property [AmountCredit] As Double?
		'''<summary>The sum of the amounts of all debit transactions in the grouping.</summary>
		Public Property [AmountDebit] As Double?
		'''<summary>Balance type of the G/L account: B = Balance Sheet, W = Profit &amp; Loss.</summary>
		Public Property [BalanceType] As String
		'''<summary>The code of the cost center.</summary>
		Public Property [CostCenterCode] As String
		'''<summary>The description of the cost center.</summary>
		Public Property [CostCenterDescription] As String
		'''<summary>The code of the cost unit.</summary>
		Public Property [CostUnitCode] As String
		'''<summary>The description of the cost unit.</summary>
		Public Property [CostUnitDescription] As String
		'''<summary>The number of transactions in the grouping.</summary>
		Public Property [Count] As Int32?
		'''<summary>Division code</summary>
		Public Property [Division] As Int32?
		'''<summary>G/L account</summary>
		Public Property [GLAccount] As Guid?
		'''<summary>The code of the G/L account.</summary>
		Public Property [GLAccountCode] As String
		'''<summary>The description of the G/L account.</summary>
		Public Property [GLAccountDescription] As String
		'''<summary>Record ID</summary>
		Public Property [ID] As Int64
		'''<summary>The reporting period of the transactions in the grouping.</summary>
		Public Property [ReportingPeriod] As Int32?
		'''<summary>The reporting year of the transactions in the grouping.</summary>
		Public Property [ReportingYear] As Int32?
		'''<summary>Status: 20 = Open, 50 = Processed. To get &apos;after entry&apos; results, both Open and Processed amounts have to be included. This is by default, so it requires no extra filtering.</summary>
		Public Property [Status] As Int32?
		'''<summary>The type of the transactions in the grouping.</summary>
		Public Property [Type] As Int32?
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("DocumentID")>
	Public Class [Return]
		'''<summary>Amount in the currency of the transaction</summary>
		Public Property [Amount] As Double?
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime
		'''<summary>Currency</summary>
		Public Property [Currency] As String
		'''<summary>Description</summary>
		Public Property [Description] As String
		'''<summary>Primary key, document ID</summary>
		Public Property [DocumentID] As Guid
		'''<summary>Url to view the document</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DocumentViewUrl] As String
		'''<summary>Due date</summary>
		Public Property [DueDate] As DateTime?
		'''<summary>Frequency</summary>
		Public Property [Frequency] As String
		'''<summary>Payroll declaration type</summary>
		Public Property [PayrollDeclarationType] As String
		'''<summary>Period</summary>
		Public Property [Period] As Int32
		'''<summary>Description of Period</summary>
		Public Property [PeriodDescription] As String
		'''<summary>Reference to request</summary>
		Public Property [Request] As Guid?
		'''<summary>Status</summary>
		Public Property [Status] As Int32
		'''<summary>Type</summary>
		Public Property [Type] As Int32
		'''<summary>Year</summary>
		Public Property [Year] As Int32
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("Year,Period")>
	Public Class [RevenueList]
		'''<summary>Total amount in the default currency of the company</summary>
		Public Property [Amount] As Double
		'''<summary>Reporting period</summary>
		Public Property [Period] As Int32
		'''<summary>Current Reporting year</summary>
		Public Property [Year] As Int32
	End Class

End Namespace