Namespace CRM

	<SupportedActionsSDK(True, False, False, False)>
	<DataServiceKey("QuotationID")>
	Public Class [AcceptQuotation]
		'''<summary>0 = No action (Default), 1 = create sales order, 2 = create sales invoice, 3 = create project.</summary>
		Public Property [Action] As Int32
		'''<summary>Create a project work breakdown structure. Only needed when ProjectBudgetType = 2.</summary>
		Public Property [CreateProjectWBS] As Boolean?
		'''<summary>Division code</summary>
		Public Property [Division] As Int32
		'''<summary>Contains the error message if an error occurred during the acception of the quotation.</summary>
		Public Property [ErrorMessage] As String
		'''<summary>The journal in which the sales invoice will be booked. Mandatory for Action = 2.</summary>
		Public Property [InvoiceJournal] As Int32
		'''<summary>The budget type of the project that will be created. Default = 0.</summary>
		Public Property [ProjectBudgetType] As Int32?
		'''<summary>The code of the project that will be created. Mandatory for Action = 3.</summary>
		Public Property [ProjectCode] As String
		'''<summary>The description of the project that will be created. Mandatory for Action = 3.</summary>
		Public Property [ProjectDescription] As String
		'''<summary>The invoicing date of the project. Mandatory for ProjectInvoicingAction = 2.</summary>
		Public Property [ProjectInvoiceDate] As DateTime?
		'''<summary>The project invoicing action. 0 = None (Default), 1 = Create invoice terms, 2 = As quoted.</summary>
		Public Property [ProjectInvoicingAction] As Int32?
		'''<summary>The prepaid type. Mandatory for ProjectType = 5. 1 = Retainer, 2 = Hour type bundle.</summary>
		Public Property [ProjectPrepaindTypes] As Int32?
		'''<summary>PriceAgreement.</summary>
		Public Property [ProjectPriceAgreement] As Double?
		'''<summary>Contains information if the project was successfully created.</summary>
		Public Property [ProjectSuccess] As String
		'''<summary>The type of the project that will be created. 2 = Fixed price (Default), 3 = Time and Material, 4 = Non billable, 5 = Prepaid.</summary>
		Public Property [ProjectType] As Int32?
		'''<summary>Identifier of the quotation.</summary>
		Public Property [QuotationID] As Guid
		'''<summary>Reason why the quotation was accepted.</summary>
		Public Property [ReasonCode] As Guid?
		'''<summary>Contains information if the sales invoice was successfully created.</summary>
		Public Property [SalesInvoiceSuccess] As String
		'''<summary>Contains information if the sales order was successfully created.</summary>
		Public Property [SalesOrderSuccess] As String
		'''<summary>Contains information if the quotation was successfully accepted.</summary>
		Public Property [SuccessMessage] As String
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [Account]
		'''<summary>Reference to the accountant of the customer. Conditions: The referred accountant must have value &gt; 0 in the field IsAccountant</summary>
		Public Property [Accountant] As Guid?
		'''<summary>ID of the account manager</summary>
		Public Property [AccountManager] As Guid?
		'''<summary>Name of the account manager</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountManagerFullName] As String
		'''<summary>Number of the account manager  </summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountManagerHID] As Int32?
		'''<summary>Reference to Activity sector of the account</summary>
		Public Property [ActivitySector] As Guid?
		'''<summary>Reference to Activity sub-sector of the account</summary>
		Public Property [ActivitySubSector] As Guid?
		'''<summary>Visit address first line</summary>
		Public Property [AddressLine1] As String
		'''<summary>Visit address second line</summary>
		Public Property [AddressLine2] As String
		'''<summary>Visit address third line</summary>
		Public Property [AddressLine3] As String
		'''<summary>Collection of Bank accounts</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [BankAccounts] As IEnumerable(Of Models.CRM.BankAccount)
		'''<summary>Indicates if the account is blocked</summary>
		Public Property [Blocked] As Boolean?
		'''<summary>Obsolete</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [BRIN] As Guid?
		'''<summary>Reference to the business type of the account</summary>
		Public Property [BusinessType] As Guid?
		'''<summary>Indicates the default for the possibility to drop ship when an item is linked to a supplier</summary>
		Public Property [CanDropShip] As Boolean?
		'''<summary>Chamber of commerce number</summary>
		Public Property [ChamberOfCommerce] As String
		'''<summary>Visit address City</summary>
		Public Property [City] As String
		'''<summary>Obsolete</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Classification] As String
		'''<summary>Account classification 1</summary>
		Public Property [Classification1] As Guid?
		'''<summary>Account classification 2</summary>
		Public Property [Classification2] As Guid?
		'''<summary>Account classification 3</summary>
		Public Property [Classification3] As Guid?
		'''<summary>Account classification 4</summary>
		Public Property [Classification4] As Guid?
		'''<summary>Account classification 5</summary>
		Public Property [Classification5] As Guid?
		'''<summary>Account classification 6</summary>
		Public Property [Classification6] As Guid?
		'''<summary>Account classification 7</summary>
		Public Property [Classification7] As Guid?
		'''<summary>Account classification 8</summary>
		Public Property [Classification8] As Guid?
		'''<summary>Obsolete</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ClassificationDescription] As String
		'''<summary>Unique key, fixed length numeric string with leading spaces, length 18. IMPORTANT: When you use OData $filter on this field you have to make sure the filter parameter contains the leading spaces</summary>
		Public Property [Code] As String
		'''<summary>Code under which your own company is known at the account</summary>
		Public Property [CodeAtSupplier] As String
		'''<summary>Reference to Company size of the account</summary>
		Public Property [CompanySize] As Guid?
		'''<summary>Consolidation scenario (Time &amp; Billing). Values: 0 = No consolidation, 1 = Item, 2 = Item + Project, 3 = Item + Employee, 4 = Item + Employee + Project, 5 = Project + WBS + Item, 6 = Project + WBS + Item + Employee. Item means in this case including Unit and Price, these also have to be the same to consolidate</summary>
		Public Property [ConsolidationScenario] As Byte?
		'''<summary>Date of the latest control of account data with external web service</summary>
		Public Property [ControlledDate] As DateTime?
		'''<summary>Obsolete</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Costcenter] As String
		'''<summary>Obsolete</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CostcenterDescription] As String
		'''<summary>Obsolete</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CostPaid] As Byte
		'''<summary>Country code</summary>
		Public Property [Country] As String
		'''<summary>Country name</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CountryName] As String
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<summary>User ID of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>Maximum amount of credit for Purchase. If no value has been defined, there is no credit limit</summary>
		Public Property [CreditLinePurchase] As Double?
		'''<summary>Maximum amount of credit for sales. If no value has been defined, there is no credit limit</summary>
		Public Property [CreditLineSales] As Double?
		'''<summary>Obsolete</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Currency] As String
		'''<summary>Obsolete</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CustomerSince] As DateTime?
		'''<summary>DATEV creditor code for Germany legislation</summary>
		Public Property [DatevCreditorCode] As String
		'''<summary>DATEV debtor code for Germany legislation</summary>
		Public Property [DatevDebtorCode] As String
		'''<summary>Default discount percentage for purchase. This is stored as a fraction. ie 5.5% is stored as .055</summary>
		Public Property [DiscountPurchase] As Double?
		'''<summary>Default discount percentage for sales. This is stored as a fraction. ie 5.5% is stored as .055</summary>
		Public Property [DiscountSales] As Double?
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<summary>Obsolete</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Document] As Guid?
		'''<summary>Obsolete</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DunsNumber] As String
		'''<summary>E-Mail address of the account</summary>
		Public Property [Email] As String
		'''<summary>Determines in combination with the start date if the account is active. If the current date is &gt; end date the account is inactive</summary>
		Public Property [EndDate] As DateTime?
		'''<summary>RegistrationDate</summary>
		Public Property [EstablishedDate] As DateTime?
		'''<summary>Fax number</summary>
		Public Property [Fax] As String
		'''<summary>Default (corporate) GL offset account for purchase (cost)</summary>
		Public Property [GLAccountPurchase] As Guid?
		'''<summary>Default (corporate) GL offset account for sales (revenue)</summary>
		Public Property [GLAccountSales] As Guid?
		'''<summary>Default GL account for Accounts Payable</summary>
		Public Property [GLAP] As Guid?
		'''<summary>Default GL account for Accounts Receivable</summary>
		Public Property [GLAR] As Guid?
		'''<summary>Indicates whether a customer has withholding tax on sales</summary>
		Public Property [HasWithholdingTaxSales] As Boolean?
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Suppressed warning message when there is duplication on the DATEV code</summary>
		Public Property [IgnoreDatevWarningMessage] As Boolean
		'''<summary>Intrastat Area</summary>
		Public Property [IntraStatArea] As String
		'''<summary>Intrastat delivery method</summary>
		Public Property [IntraStatDeliveryTerm] As String
		'''<summary>System for Intrastat</summary>
		Public Property [IntraStatSystem] As String
		'''<summary>Transaction type A for Intrastat</summary>
		Public Property [IntraStatTransactionA] As String
		'''<summary>Transaction type B for Intrastat</summary>
		Public Property [IntraStatTransactionB] As String
		'''<summary>Transport method for Intrastat</summary>
		Public Property [IntraStatTransportMethod] As String
		'''<summary>ID of account to be invoiced instead of this account</summary>
		Public Property [InvoiceAccount] As Guid?
		'''<summary>Code of InvoiceAccount</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [InvoiceAccountCode] As String
		'''<summary>Name of InvoiceAccount</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [InvoiceAccountName] As String
		'''<summary>Indicates which attachment types should be sent when a sales invoice is printed. Only values in related table with Invoice=1 are allowed</summary>
		Public Property [InvoiceAttachmentType] As Int32?
		'''<summary>Method of sending for sales invoices. Values: 1: Paper, 2: EMail, 4: Mailbox (electronic exchange)</summary>
		Public Property [InvoicingMethod] As Int32?
		'''<summary>Indicates whether the account is an accountant. Values: 0 = No accountant, 1 = True, but accountant doesn&apos;t want his name to be published in the list of accountants, 2 = True, and accountant is published in the list of accountants</summary>
		Public Property [IsAccountant] As Byte
		'''<summary>Indicates whether the accounti is an agency</summary>
		Public Property [IsAgency] As Byte
		'''<summary>Indicates whtether the account is anonymised.</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsAnonymised] As Byte
		'''<summary>Obsolete</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsBank] As Boolean?
		'''<summary>Indicates whether the account is a competitor</summary>
		Public Property [IsCompetitor] As Byte
		'''<summary>Indicates whether a customer is eligible for extra duty</summary>
		Public Property [IsExtraDuty] As Boolean?
		'''<summary>Indicates if the account is excluded from mailing marketing information</summary>
		Public Property [IsMailing] As Byte
		'''<summary>Obsolete</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsMember] As Boolean?
		'''<summary>Indicates whether the account is a pilot account</summary>
		Public Property [IsPilot] As Boolean?
		'''<summary>Obsolete</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsPurchase] As Boolean?
		'''<summary>Indicates whether the account is a reseller</summary>
		Public Property [IsReseller] As Boolean?
		'''<summary>Indicates whether the account is allowed for sales</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsSales] As Boolean?
		'''<summary>Indicates whether the account is a supplier</summary>
		Public Property [IsSupplier] As Boolean?
		'''<summary>Language code</summary>
		Public Property [Language] As String
		'''<summary>Language description</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [LanguageDescription] As String
		'''<summary>Latitude (used by Google maps)</summary>
		Public Property [Latitude] As Double?
		'''<summary>Reference to Lead purpose of an account</summary>
		Public Property [LeadPurpose] As Guid?
		'''<summary>Reference to Lead source of an account</summary>
		Public Property [LeadSource] As Guid?
		'''<summary>Bytes of the logo image</summary>
		Public Property [Logo] As Byte()
		'''<summary>The file name (without path, but with extension) of the image</summary>
		Public Property [LogoFileName] As String
		'''<summary>Thumbnail url of the logo</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [LogoThumbnailUrl] As String
		'''<summary>Url to retrieve the logo</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [LogoUrl] As String
		'''<summary>Longitude (used by Google maps)</summary>
		Public Property [Longitude] As Double?
		'''<summary>Reference to main contact person</summary>
		Public Property [MainContact] As Guid?
		'''<summary>Last modified date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<summary>User ID of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Name of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>Account name</summary>
		Public Property [Name] As String
		'''<summary>Dutch government identification number</summary>
		Public Property [OINNumber] As String
		'''<summary>ID of the parent account</summary>
		Public Property [Parent] As Guid?
		'''<summary>Indicates the loan repayment plan for UK legislation</summary>
		Public Property [PayAsYouEarn] As String
		'''<summary>Code of default payment condition for purchase</summary>
		Public Property [PaymentConditionPurchase] As String
		'''<summary>Description of PaymentConditionPurchase</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PaymentConditionPurchaseDescription] As String
		'''<summary>Code of default payment condition for sales</summary>
		Public Property [PaymentConditionSales] As String
		'''<summary>Description of PaymentConditionSales</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PaymentConditionSalesDescription] As String
		'''<summary>Phone number</summary>
		Public Property [Phone] As String
		'''<summary>Phone number extention</summary>
		Public Property [PhoneExtension] As String
		'''<summary>Visit address postcode</summary>
		Public Property [Postcode] As String
		'''<summary>Default sales price list for account</summary>
		Public Property [PriceList] As Guid?
		'''<summary>Currency of purchase</summary>
		Public Property [PurchaseCurrency] As String
		'''<summary>Description of PurchaseCurrency</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PurchaseCurrencyDescription] As String
		'''<summary>Indicates number of days required to receive a purchase. Acts as a default</summary>
		Public Property [PurchaseLeadDays] As Int32?
		'''<summary>Default VAT code used for purchase entries</summary>
		Public Property [PurchaseVATCode] As String
		'''<summary>Description of PurchaseVATCode</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PurchaseVATCodeDescription] As String
		'''<summary>Define the relation that should be taken in the official document of the rewarding fiscal fiches Belcotax</summary>
		Public Property [RecepientOfCommissions] As Boolean?
		'''<summary>Remarks</summary>
		Public Property [Remarks] As String
		'''<summary>ID of the reseller account. Conditions: the target account must have the property IsReseller turned on</summary>
		Public Property [Reseller] As Guid?
		'''<summary>Code of Reseller</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ResellerCode] As String
		'''<summary>Name of Reseller</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ResellerName] As String
		'''<summary>Fiscal number for NL legislation</summary>
		Public Property [RSIN] As String
		'''<summary>Currency of Sales used for Time &amp; Billing</summary>
		Public Property [SalesCurrency] As String
		'''<summary>Description of SalesCurrency</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SalesCurrencyDescription] As String
		'''<summary>Obsolete</summary>
		Public Property [SalesTaxSchedule] As Guid?
		'''<summary>Obsolete</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SalesTaxScheduleCode] As String
		'''<summary>Obsolete</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SalesTaxScheduleDescription] As String
		'''<summary>Default VAT code for a sales entry</summary>
		Public Property [SalesVATCode] As String
		'''<summary>Description of SalesVATCode</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SalesVATCodeDescription] As String
		'''<summary>Search code</summary>
		Public Property [SearchCode] As String
		'''<summary>Security level (0 - 100)</summary>
		Public Property [SecurityLevel] As Int32?
		'''<summary>Separate invoice per project (Time &amp; Billing)</summary>
		Public Property [SeparateInvPerProject] As Byte
		'''<summary>Indicates how invoices are generated from subscriptions. 0 = subscriptions belonging to the same customer are combined in a single invoice. 1 = each subscription results in one invoice. In both cases, each individual subscription line results in one invoice line</summary>
		Public Property [SeparateInvPerSubscription] As Byte
		'''<summary>Indicates the number of days it takes to send goods to the customer. Acts as a default</summary>
		Public Property [ShippingLeadDays] As Int32?
		'''<summary>Default shipping method</summary>
		Public Property [ShippingMethod] As Guid?
		'''<summary>Indicates in combination with the end date if the account is active</summary>
		Public Property [StartDate] As DateTime?
		'''<summary>State/Province/County code When changing the Country and the State is filled, the State must be assigned with a valid value from the selected country or set to empty</summary>
		Public Property [State] As String
		'''<summary>Name of State</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StateName] As String
		'''<summary>If the status field is filled this means the account is a customer. The value indicates the customer status. Possible values: A=None, S=Suspect, P=Prospect, C=Customer</summary>
		Public Property [Status] As String
		'''<summary>Obsolete</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StatusSince] As DateTime?
		'''<summary>Trade name can be registered and shown with the client (for all legislations)</summary>
		Public Property [TradeName] As String
		'''<summary>Account type: Values: A = Relation, D = Division</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Type] As String
		'''<summary>Unique taxpayer reference for UK legislation</summary>
		Public Property [UniqueTaxpayerReference] As String
		'''<summary>Indicates the VAT status of an account to be able to identify the relation that should be selected in the VAT debtor listing in Belgium</summary>
		Public Property [VATLiability] As String
		'''<summary>The number under which the account is known at the Value Added Tax collection agency</summary>
		Public Property [VATNumber] As String
		'''<summary>Website of the account</summary>
		Public Property [Website] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [AccountClass]
		'''<summary>Classification code</summary>
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
		'''<summary>Description</summary>
		Public Property [Description] As String
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
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [AccountClassification]
		'''<summary>Reference to Account classification name</summary>
		Public Property [AccountClassificationName] As Guid?
		'''<summary>Description of AccountClassificationName</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountClassificationNameDescription] As String
		'''<summary>Account classification code</summary>
		Public Property [Code] As String
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime
		'''<summary>User ID of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>Description</summary>
		Public Property [Description] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Last modified date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime
		'''<summary>User ID of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Name of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [AccountClassificationName]
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime
		'''<summary>User ID of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>Description</summary>
		Public Property [Description] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Last modified date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime
		'''<summary>User ID of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Name of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>Sequence number</summary>
		Public Property [SequenceNumber] As Int32
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [Address]
		'''<summary>Account linked to the address</summary>
		Public Property [Account] As Guid?
		'''<summary>Indicates if the account is a supplier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountIsSupplier] As Boolean?
		'''<summary>Name of the account</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountName] As String
		'''<summary>First address line</summary>
		Public Property [AddressLine1] As String
		'''<summary>Second address line</summary>
		Public Property [AddressLine2] As String
		'''<summary>Third address line</summary>
		Public Property [AddressLine3] As String
		'''<summary>City</summary>
		Public Property [City] As String
		'''<summary>Contact linked to Address</summary>
		Public Property [Contact] As Guid?
		'''<summary>Contact name</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ContactName] As String
		'''<summary>Country code</summary>
		Public Property [Country] As String
		'''<summary>Country name</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CountryName] As String
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
		'''<summary>Fax number</summary>
		Public Property [Fax] As String
		'''<summary>Free boolean field 1</summary>
		Public Property [FreeBoolField_01] As Boolean?
		'''<summary>Free boolean field 2</summary>
		Public Property [FreeBoolField_02] As Boolean?
		'''<summary>Free boolean field 3</summary>
		Public Property [FreeBoolField_03] As Boolean?
		'''<summary>Free boolean field 4</summary>
		Public Property [FreeBoolField_04] As Boolean?
		'''<summary>Free boolean field 5</summary>
		Public Property [FreeBoolField_05] As Boolean?
		'''<summary>Free date field 1</summary>
		Public Property [FreeDateField_01] As DateTime?
		'''<summary>Free date field 2</summary>
		Public Property [FreeDateField_02] As DateTime?
		'''<summary>Free date field 3</summary>
		Public Property [FreeDateField_03] As DateTime?
		'''<summary>Free date field 4</summary>
		Public Property [FreeDateField_04] As DateTime?
		'''<summary>Free date field 5</summary>
		Public Property [FreeDateField_05] As DateTime?
		'''<summary>Free number field 1</summary>
		Public Property [FreeNumberField_01] As Double?
		'''<summary>Free number field 2</summary>
		Public Property [FreeNumberField_02] As Double?
		'''<summary>Free number field 3</summary>
		Public Property [FreeNumberField_03] As Double?
		'''<summary>Free number field 4</summary>
		Public Property [FreeNumberField_04] As Double?
		'''<summary>Free number field 5</summary>
		Public Property [FreeNumberField_05] As Double?
		'''<summary>Free text field 1</summary>
		Public Property [FreeTextField_01] As String
		'''<summary>Free text field 2</summary>
		Public Property [FreeTextField_02] As String
		'''<summary>Free text field 3</summary>
		Public Property [FreeTextField_03] As String
		'''<summary>Free text field 4</summary>
		Public Property [FreeTextField_04] As String
		'''<summary>Free text field 5</summary>
		Public Property [FreeTextField_05] As String
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Mailbox</summary>
		Public Property [Mailbox] As String
		'''<summary>Indicates if the address is the main address for this type</summary>
		Public Property [Main] As Boolean?
		'''<summary>Last modified date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<summary>User ID of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Name of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>Last 5 digits of SIRET number which is an intern sequential number of 4 digits representing the identification of the localization of the office</summary>
		Public Property [NicNumber] As String
		'''<summary>Notes for an address</summary>
		Public Property [Notes] As String
		'''<summary>Phone number</summary>
		Public Property [Phone] As String
		'''<summary>Phone extension</summary>
		Public Property [PhoneExtension] As String
		'''<summary>Postcode</summary>
		Public Property [Postcode] As String
		'''<summary>State</summary>
		Public Property [State] As String
		'''<summary>Name of the State</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StateDescription] As String
		'''<summary>The type of address. Visit=1, Postal=2, Invoice=3, Delivery=4</summary>
		Public Property [Type] As Int16?
		'''<summary>The warehouse linked to the address, if a warehouse is linked the account will be empty. Can only be filled for type=Delivery</summary>
		Public Property [Warehouse] As Guid?
		'''<summary>Code of the warehoude</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseCode] As String
		'''<summary>Description of the warehouse</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseDescription] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [AddressState]
		'''<summary>Country code</summary>
		Public Property [Country] As String
		'''<summary>Description of state prefixed with the code</summary>
		Public Property [DisplayValue] As String
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Latitude</summary>
		Public Property [Latitude] As Double?
		'''<summary>Longitude</summary>
		Public Property [Longitude] As Double?
		'''<summary>State name</summary>
		Public Property [Name] As String
		'''<summary>State code</summary>
		Public Property [State] As String
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [BankAccount]
		'''<summary>Account (customer, supplier) to which the bank account belongs</summary>
		Public Property [Account] As Guid?
		'''<summary>The name of the account</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountName] As String
		'''<summary>Obsolete</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Bank] As Guid?
		'''<summary>The bank account number</summary>
		Public Property [BankAccount] As String
		'''<summary>Name of the holder of the bank account, as known by the bank</summary>
		Public Property [BankAccountHolderName] As String
		'''<summary>Obsolete</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [BankDescription] As String
		'''<summary>Obsolete</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [BankName] As String
		'''<summary>BIC code of the bank where the bank account is held</summary>
		Public Property [BICCode] As String
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<summary>User ID of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>Description of the bank account</summary>
		Public Property [Description] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<summary>Format that belongs to the bank account number</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Format] As String
		'''<summary>Obsolete</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IBAN] As String
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Indicates if the bank account is the main bank account</summary>
		Public Property [Main] As Boolean?
		'''<summary>Last modified date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<summary>User ID of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Name of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>ID of the Payment service account. Used when Type is &apos;P&apos; (Payment service)</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PaymentServiceAccount] As Guid?
		'''<summary>The type indicates what entity the bank account is used for. A = Account (default), E = Employee, K = Cash, P = Payment service, R = Bank, S = Student, U = Unknown. Currently it&apos;s only possible to create &apos;Account&apos; type bank accounts.</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Type] As String
		'''<summary>Description of the Type</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [TypeDescription] As String
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [Contact]
		'''<summary>The account to which the contact belongs</summary>
		Public Property [Account] As Guid?
		'''<summary>Indicates if account is a customer</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountIsCustomer] As Boolean
		'''<summary>Indicates if account is a supplier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountIsSupplier] As Boolean?
		'''<summary>Reference to the main contact of the account</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountMainContact] As Guid?
		'''<summary>Name of the account</summary>
		Public Property [AccountName] As String
		'''<summary>Second address line</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AddressLine2] As String
		'''<summary>Street name of the address</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AddressStreet] As String
		'''<summary>Street number of the address</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AddressStreetNumber] As String
		'''<summary>Street number suffix of the address</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AddressStreetNumberSuffix] As String
		'''<summary>Obsolete</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AllowMailing] As Int32?
		'''<summary>Birth date</summary>
		Public Property [BirthDate] As DateTime?
		'''<summary>Obsolete. Please don&apos;t use this field anymore as it may overwrite LastName.</summary>
		Public Property [BirthName] As String
		'''<summary>Obsolete. Please don&apos;t use this field anymore as it may overwrite MiddleName.</summary>
		Public Property [BirthNamePrefix] As String
		'''<summary>Birth place</summary>
		Public Property [BirthPlace] As String
		'''<summary>Email address of the contact</summary>
		Public Property [BusinessEmail] As String
		'''<summary>Fax of the contact</summary>
		Public Property [BusinessFax] As String
		'''<summary>Mobile of the contact</summary>
		Public Property [BusinessMobile] As String
		'''<summary>Phone of the contact</summary>
		Public Property [BusinessPhone] As String
		'''<summary>Phone extension of the contact</summary>
		Public Property [BusinessPhoneExtension] As String
		'''<summary>City</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [City] As String
		'''<summary>Code of the account</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Code] As String
		'''<summary>Country code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Country] As String
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
		'''<summary>Email address of the contact</summary>
		Public Property [Email] As String
		'''<summary>End date</summary>
		Public Property [EndDate] As DateTime?
		'''<summary>First name. Provide at least first name or last name to create a new contact</summary>
		Public Property [FirstName] As String
		'''<summary>Full name (First name Middle name Last name)</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [FullName] As String
		'''<summary>Gender</summary>
		Public Property [Gender] As String
		'''<summary>Contact ID</summary>
		Public Property [HID] As Int32?
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Identification date</summary>
		Public Property [IdentificationDate] As DateTime?
		'''<summary>Reference to the identification document of the contact</summary>
		Public Property [IdentificationDocument] As Guid?
		'''<summary>Reference to the user responsible for identification</summary>
		Public Property [IdentificationUser] As Guid?
		'''<summary>Initials</summary>
		Public Property [Initials] As String
		'''<summary>Indicates whether the contact is anonymised.</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsAnonymised] As Byte
		'''<summary>Indicates whether contacts are excluded from the marketing list</summary>
		Public Property [IsMailingExcluded] As Boolean?
		'''<summary>Indicates if this is the main contact of the linked account</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsMainContact] As Boolean?
		'''<summary>Jobtitle of the contact</summary>
		Public Property [JobTitleDescription] As String
		'''<summary>Language code</summary>
		Public Property [Language] As String
		'''<summary>Last name. Provide at least first name or last name to create a new contact</summary>
		Public Property [LastName] As String
		'''<summary>Reference to purpose of an contact</summary>
		Public Property [LeadPurpose] As Guid?
		'''<summary>Reference to source of an contact</summary>
		Public Property [LeadSource] As Guid?
		'''<summary>The user should be able to do a full text search on these notes to gather contacts for a marketing campaign</summary>
		Public Property [MarketingNotes] As String
		'''<summary>Middle name</summary>
		Public Property [MiddleName] As String
		'''<summary>Business phone of the contact</summary>
		Public Property [Mobile] As String
		'''<summary>Last modified date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<summary>User ID of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Name of the last modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>Nationality</summary>
		Public Property [Nationality] As String
		'''<summary>Extra remarks</summary>
		Public Property [Notes] As String
		'''<summary>Last name of partner</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PartnerName] As String
		'''<summary>Middlename of partner</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PartnerNamePrefix] As String
		'''<summary>Reference to the personal information of this contact such as name, gender, address etc.</summary>
		Public Property [Person] As Guid?
		'''<summary>Phone of the contact</summary>
		Public Property [Phone] As String
		'''<summary>Phone extension of the contact</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PhoneExtension] As String
		'''<summary>This field is write-only. The picture can be downloaded through PictureUrl and PictureThumbnailUrl.</summary>
		Public Property [Picture] As Byte()
		'''<summary>Filename of the picture</summary>
		Public Property [PictureName] As String
		'''<summary>Url to retrieve the picture thumbnail</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PictureThumbnailUrl] As String
		'''<summary>Url to retrieve the picture</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PictureUrl] As String
		'''<summary>Postcode</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Postcode] As String
		'''<summary>Social security number</summary>
		Public Property [SocialSecurityNumber] As String
		'''<summary>Start date</summary>
		Public Property [StartDate] As DateTime?
		'''<summary>State</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [State] As String
		'''<summary>Title</summary>
		Public Property [Title] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [Document]
		'''<summary>ID of the related account of this document</summary>
		Public Property [Account] As Guid?
		'''<summary>Attachments linked to the document. Binaries are not sent in the response.</summary>
		Public Property [Attachments] As IEnumerable(Of Models.CRM.DocumentsAttachment)
		'''<summary>Body of this document</summary>
		Public Property [Body] As String
		'''<summary>ID of the related contact of this document</summary>
		Public Property [Contact] As Guid?
		'''<summary>Creation date</summary>
		Public Property [Created] As DateTime
		'''<summary>User ID of creator</summary>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator</summary>
		Public Property [CreatorFullName] As String
		'''<summary>Division code</summary>
		Public Property [Division] As Int32
		'''<summary>Entry date of the incoming document</summary>
		Public Property [DocumentDate] As DateTime?
		'''<summary>Id of document folder</summary>
		Public Property [DocumentFolder] As Guid?
		'''<summary>Url to view the document</summary>
		Public Property [DocumentViewUrl] As String
		'''<summary>Indicates that the document body is empty</summary>
		Public Property [HasEmptyBody] As Boolean
		'''<summary>Human-readable ID, formatted as xx.xxx.xxx. Unique. May not be equal to zero</summary>
		Public Property [HID] As Int32
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Last modified date</summary>
		Public Property [Modified] As DateTime
		'''<summary>User ID of modifier</summary>
		Public Property [Modifier] As Guid?
		'''<summary>The opportunity linked to the document</summary>
		Public Property [Opportunity] As Guid?
		'''<summary>Purchase invoice number.</summary>
		Public Property [PurchaseInvoiceNumber] As Int32?
		'''<summary>Purchase order number.</summary>
		Public Property [PurchaseOrderNumber] As Int32?
		'''<summary>&apos;Our reference&apos; of the transaction that belongs to this document</summary>
		Public Property [SalesInvoiceNumber] As Int32?
		'''<summary>Number of the sales order</summary>
		Public Property [SalesOrderNumber] As Int32?
		'''<summary>Send Method</summary>
		Public Property [SendMethod] As Int32?
		Public Property [Share] As Int32
		'''<summary>Subject of this document</summary>
		Public Property [Subject] As String
		'''<summary>The document type</summary>
		Public Property [Type] As Int32
		'''<summary>Translated description of the document type. $filter and $orderby are not supported for this property.</summary>
		Public Property [TypeDescription] As String
		'''<summary>Translation id of the document type description</summary>
		Public Property [TypeDescriptionTermId] As Int32
		'''<summary>English description of the document type</summary>
		Public Property [UntermedTypeDescription] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [DocumentsAttachment]
		'''<summary>Filename of the attachment</summary>
		Public Property [AttachmentFileName] As String
		'''<summary>File size of the attachment</summary>
		Public Property [AttachmentFileSize] As Double
		'''<summary>Url for downloading the attachment. To get the file in its original format (xml, jpg, pdf, etc.) append &lt;b&gt;&amp;Download=1&lt;/b&gt; to the url.</summary>
		Public Property [AttachmentUrl] As String
		Public Property [CanShowInWebView] As Boolean
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [HostingOpportunity]
		'''<summary>Lead to which the opportunity applies</summary>
		Public Property [Account] As Guid?
		'''<summary>Accountant linked to the opportunity</summary>
		Public Property [Accountant] As Guid?
		'''<summary>Code of the Accountant</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountantCode] As String
		'''<summary>Name of the Accountant</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountantName] As String
		'''<summary>Code of Account</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountCode] As String
		'''<summary>Name of Account</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountName] As String
		'''<summary>Indicates the date before/on the NextAction is supposed to be done</summary>
		Public Property [ActionDate] As DateTime?
		'''<summary>Amount in the default currency of the company. AmountDC = AmountFC * RateFC</summary>
		Public Property [AmountDC] As Double?
		'''<summary>Amount in the currency of the transaction</summary>
		Public Property [AmountFC] As Double?
		'''<summary>Indicate the date back to lead development</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [BackToLeadDevelopment] As DateTime?
		'''<summary>Reference to the campaign opportunity is related to</summary>
		Public Property [Campaign] As Guid?
		'''<summary>Description of Campaign</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CampaignDescription] As String
		'''<summary>Reference to the channel opportunity is related to</summary>
		Public Property [Channel] As Int16?
		'''<summary>Description of Channel</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ChannelDescription] As String
		'''<summary>The date when the opportunity is expected to be closed</summary>
		Public Property [CloseDate] As DateTime?
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<summary>User ID of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of the creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>Currency code</summary>
		Public Property [Currency] As String
		'''<summary>Description related to customer demand</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CustomerDemandsDescription] As String
		'''<summary>DMU fields-Unit Name</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DecisionMakingUnitName] As String
		'''<summary>DMU fields- Unit Role</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DecisionMakingUnitRole] As String
		'''<summary>Description of the time frame</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DecisionTimeframe] As String
		'''<summary>Indicate the date when dispatch to sales</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DispatchToSales] As DateTime?
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Aware of associated prices</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsAssociatedPrice] As Byte?
		'''<summary>Standard product solves customer demands</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsCustomerDemandsMeet] As Byte?
		'''<summary>Name of the lead developer</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [LeadDeveloper] As Guid?
		'''<summary>The source of the lead/opportunity</summary>
		Public Property [LeadSource] As Guid?
		'''<summary>Description of LeadSource</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [LeadSourceDescription] As String
		'''<summary>Last modified date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<summary>User ID of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Name of the last modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>Name of the opportunity</summary>
		Public Property [Name] As String
		'''<summary>Indicates what follow up action is to be undertaken to move the opportunity towards a deal. Is used in combination with ActionDate</summary>
		Public Property [NextAction] As String
		'''<summary>Notes of the opportunity</summary>
		Public Property [Notes] As String
		'''<summary>Code of Opportunity Department</summary>
		Public Property [OpportunityDepartmentCode] As Int16?
		'''<summary>Description of Opportunity Department</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [OpportunityDepartmentDescription] As String
		'''<summary>The stage of the opportunity. This is a list defined by the user</summary>
		Public Property [OpportunityStage] As Guid?
		'''<summary>Description of OpportunityStage</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [OpportunityStageDescription] As String
		'''<summary>Status: 1=Open, 2=Closed won, 3=Closed lost</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [OpportunityStatus] As Int32?
		'''<summary>Code of Opportunity Type</summary>
		Public Property [OpportunityType] As Int16?
		'''<summary>Description of Opportunity Type</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [OpportunityTypeDescription] As String
		'''<summary>The resource who owns the opportunity and is responsible to close the opportunity (either won or lost)</summary>
		Public Property [Owner] As Guid?
		'''<summary>Name of Owner</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [OwnerFullName] As String
		'''<summary>The chance that the opportunity will be closed and won. The default for the probability depends on the default from the opportunity stage</summary>
		Public Property [Probability] As Double?
		'''<summary>Reference to project</summary>
		Public Property [Project] As Guid?
		'''<summary>Code of Project</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectCode] As String
		'''<summary>Description of Project</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectDescription] As String
		'''<summary>Exchange rate from original to division currency</summary>
		Public Property [RateFC] As Double?
		'''<summary>Indicate the reason back</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ReasonBack] As String
		'''<summary>Indicates the reason why the opportunity was lost.</summary>
		Public Property [ReasonCode] As Guid?
		'''<summary>Description of ReasonCode</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ReasonCodeDescription] As String
		'''<summary>Reseller linked to the opportunity</summary>
		Public Property [Reseller] As Guid?
		'''<summary>Code of the Reseller</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ResellerCode] As String
		'''<summary>Name of the Reseller</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ResellerName] As String
		'''<summary>Reference to Sales type</summary>
		Public Property [SalesType] As Guid?
		'''<summary>Description of SalesType</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SalesTypeDescription] As String
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [Opportunity]
		'''<summary>Lead to which the opportunity applies</summary>
		Public Property [Account] As Guid?
		'''<summary>Accountant linked to the opportunity</summary>
		Public Property [Accountant] As Guid?
		'''<summary>Code of the Accountant</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountantCode] As String
		'''<summary>Name of the Accountant</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountantName] As String
		'''<summary>Code of Account</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountCode] As String
		'''<summary>Name of Account</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountName] As String
		'''<summary>Indicates the date before/on the NextAction is supposed to be done</summary>
		Public Property [ActionDate] As DateTime?
		'''<summary>Amount in the default currency of the company. AmountDC = AmountFC * RateFC</summary>
		Public Property [AmountDC] As Double?
		'''<summary>Amount in the currency of the transaction</summary>
		Public Property [AmountFC] As Double?
		'''<summary>Reference to the campaign opportunity is related to</summary>
		Public Property [Campaign] As Guid?
		'''<summary>Description of Campaign</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CampaignDescription] As String
		'''<summary>Reference to the channel opportunity is related to</summary>
		Public Property [Channel] As Int16?
		'''<summary>Description of Channel</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ChannelDescription] As String
		'''<summary>The date when the opportunity is expected to be closed</summary>
		Public Property [CloseDate] As DateTime?
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<summary>User ID of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of the creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>Currency code</summary>
		Public Property [Currency] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>The source of the lead/opportunity</summary>
		Public Property [LeadSource] As Guid?
		'''<summary>Description of LeadSource</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [LeadSourceDescription] As String
		'''<summary>Last modified date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<summary>User ID of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Name of the last modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>Name of the opportunity</summary>
		Public Property [Name] As String
		'''<summary>Indicates what follow up action is to be undertaken to move the opportunity towards a deal. Is used in combination with ActionDate</summary>
		Public Property [NextAction] As String
		'''<summary>Notes of the opportunity</summary>
		Public Property [Notes] As String
		'''<summary>Code of Opportunity Department</summary>
		Public Property [OpportunityDepartmentCode] As Int16?
		'''<summary>Description of Opportunity Department</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [OpportunityDepartmentDescription] As String
		'''<summary>The stage of the opportunity. This is a list defined by the user</summary>
		Public Property [OpportunityStage] As Guid?
		'''<summary>Description of OpportunityStage</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [OpportunityStageDescription] As String
		'''<summary>Status: 1=Open, 2=Closed won, 3=Closed lost</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [OpportunityStatus] As Int32?
		'''<summary>Code of Opportunity Type</summary>
		Public Property [OpportunityType] As Int16?
		'''<summary>Description of Opportunity Type</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [OpportunityTypeDescription] As String
		'''<summary>The resource who owns the opportunity and is responsible to close the opportunity (either won or lost)</summary>
		Public Property [Owner] As Guid?
		'''<summary>Name of Owner</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [OwnerFullName] As String
		'''<summary>The chance that the opportunity will be closed and won. The default for the probability depends on the default from the opportunity stage</summary>
		Public Property [Probability] As Double?
		'''<summary>Reference to project</summary>
		Public Property [Project] As Guid?
		'''<summary>Code of Project</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectCode] As String
		'''<summary>Description of Project</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectDescription] As String
		'''<summary>Exchange rate from original to division currency</summary>
		Public Property [RateFC] As Double?
		'''<summary>Indicates the reason why the opportunity was lost.</summary>
		Public Property [ReasonCode] As Guid?
		'''<summary>Description of ReasonCode</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ReasonCodeDescription] As String
		'''<summary>Reseller linked to the opportunity</summary>
		Public Property [Reseller] As Guid?
		'''<summary>Code of the Reseller</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ResellerCode] As String
		'''<summary>Name of the Reseller</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ResellerName] As String
		'''<summary>Reference to Sales type</summary>
		Public Property [SalesType] As Guid?
		'''<summary>Description of SalesType</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SalesTypeDescription] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [OpportunityContact]
		'''<summary>The account to which the contact belongs</summary>
		Public Property [Account] As Guid?
		'''<summary>Indicates if account is a customer</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountIsCustomer] As Boolean
		'''<summary>Indicates if account is a supplier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountIsSupplier] As Boolean?
		'''<summary>Reference to the main contact of the account</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountMainContact] As Guid?
		'''<summary>Name of the account</summary>
		Public Property [AccountName] As String
		'''<summary>Second address line</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AddressLine2] As String
		'''<summary>Street name of the address</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AddressStreet] As String
		'''<summary>Street number of the address</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AddressStreetNumber] As String
		'''<summary>Street number suffix of the address</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AddressStreetNumberSuffix] As String
		'''<summary>Obsolete</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AllowMailing] As Int32?
		'''<summary>Birth date</summary>
		Public Property [BirthDate] As DateTime?
		'''<summary>Obsolete. Please don&apos;t use this field anymore as it may overwrite LastName.</summary>
		Public Property [BirthName] As String
		'''<summary>Obsolete. Please don&apos;t use this field anymore as it may overwrite MiddleName.</summary>
		Public Property [BirthNamePrefix] As String
		'''<summary>Birth place</summary>
		Public Property [BirthPlace] As String
		'''<summary>Email address of the contact</summary>
		Public Property [BusinessEmail] As String
		'''<summary>Fax of the contact</summary>
		Public Property [BusinessFax] As String
		'''<summary>Mobile of the contact</summary>
		Public Property [BusinessMobile] As String
		'''<summary>Phone of the contact</summary>
		Public Property [BusinessPhone] As String
		'''<summary>Phone extension of the contact</summary>
		Public Property [BusinessPhoneExtension] As String
		'''<summary>City</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [City] As String
		'''<summary>Code of the account</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Code] As String
		'''<summary>Contact person that is linked to the opportunity</summary>
		Public Property [Contact] As Guid?
		'''<summary>Country code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Country] As String
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
		'''<summary>Email address of the contact</summary>
		Public Property [Email] As String
		'''<summary>End date</summary>
		Public Property [EndDate] As DateTime?
		'''<summary>First name. Provide at least first name or last name to create a new contact</summary>
		Public Property [FirstName] As String
		'''<summary>Full name (First name Middle name Last name)</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [FullName] As String
		'''<summary>Gender</summary>
		Public Property [Gender] As String
		'''<summary>Contact ID</summary>
		Public Property [HID] As Int32?
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Identification date</summary>
		Public Property [IdentificationDate] As DateTime?
		'''<summary>Reference to the identification document of the contact</summary>
		Public Property [IdentificationDocument] As Guid?
		'''<summary>Reference to the user responsible for identification</summary>
		Public Property [IdentificationUser] As Guid?
		'''<summary>Initials</summary>
		Public Property [Initials] As String
		'''<summary>Indicates whether the contact is anonymised.</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsAnonymised] As Byte
		'''<summary>Indicates whether contacts are excluded from the marketing list</summary>
		Public Property [IsMailingExcluded] As Boolean?
		'''<summary>Indicates if this is the main contact of the linked account</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsMainContact] As Boolean?
		'''<summary>Jobtitle of the contact</summary>
		Public Property [JobTitleDescription] As String
		'''<summary>Language code</summary>
		Public Property [Language] As String
		'''<summary>Last name. Provide at least first name or last name to create a new contact</summary>
		Public Property [LastName] As String
		'''<summary>The user should be able to do a full text search on these notes to gather contacts for a marketing campaign</summary>
		Public Property [MarketingNotes] As String
		'''<summary>Middle name</summary>
		Public Property [MiddleName] As String
		'''<summary>Business phone of the contact</summary>
		Public Property [Mobile] As String
		'''<summary>Last modified date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<summary>User ID of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Name of the last modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>Nationality</summary>
		Public Property [Nationality] As String
		'''<summary>Extra remarks</summary>
		Public Property [Notes] As String
		'''<summary>Opportunity that is linked to the contact person</summary>
		Public Property [Opportunity] As Guid?
		'''<summary>Last name of partner</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PartnerName] As String
		'''<summary>Middlename of partner</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PartnerNamePrefix] As String
		'''<summary>Reference to the personal information of this contact such as name, gender, address etc.</summary>
		Public Property [Person] As Guid?
		'''<summary>Phone of the contact</summary>
		Public Property [Phone] As String
		'''<summary>Phone extension of the contact</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PhoneExtension] As String
		'''<summary>This field is write-only. The picture can be downloaded through PictureUrl and PictureThumbnailUrl.</summary>
		Public Property [Picture] As Byte()
		'''<summary>Filename of the picture</summary>
		Public Property [PictureName] As String
		'''<summary>Url to retrieve the picture thumbnail</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PictureThumbnailUrl] As String
		'''<summary>Url to retrieve the picture</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PictureUrl] As String
		'''<summary>Postcode</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Postcode] As String
		'''<summary>Social security number</summary>
		Public Property [SocialSecurityNumber] As String
		'''<summary>Start date</summary>
		Public Property [StartDate] As DateTime?
		'''<summary>State</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [State] As String
		'''<summary>Title</summary>
		Public Property [Title] As String
	End Class

	<SupportedActionsSDK(True, False, False, False)>
	<DataServiceKey("QuotationID")>
	Public Class [PrintQuotation]
		'''<summary>Division code</summary>
		Public Property [Division] As Int32
		'''<summary>Contains the id of the document that was created</summary>
		Public Property [Document] As Guid?
		'''<summary>Contains the error message if an error occurred during the creation of the document</summary>
		Public Property [DocumentCreationError] As String
		'''<summary>Contains information if a document was successfully created</summary>
		Public Property [DocumentCreationSuccess] As String
		'''<summary>Based on this layout a PDF is created and attached to an Exact Online document and an email. In case it is not specified, the default layout is used.</summary>
		Public Property [DocumentLayout] As Guid?
		'''<summary>Contains the error message if an error occurred during the creation of the Email</summary>
		Public Property [EmailCreationError] As String
		'''<summary>Based on this layout the email text is produced. In case it is not specified, the default layout is used.</summary>
		Public Property [EmailLayout] As Guid?
		'''<summary>Extra text that can be added to the printed document and email</summary>
		Public Property [ExtraText] As String
		'''<summary>Date of the quotation printed</summary>
		Public Property [QuotationDate] As DateTime
		'''<summary>Identifier of the quotation</summary>
		Public Property [QuotationID] As Guid
		'''<summary>Set to True if an email containing the quotation should be sent to the customer</summary>
		Public Property [SendEmailToCustomer] As Boolean
		'''<summary>Email address from which the email will be sent. If not specified, the company email address will be used.</summary>
		Public Property [SenderEmailAddress] As String
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("QuotationID")>
	Public Class [Quotation]
		'''<summary>Amount in the default currency of the company</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AmountDC] As Double
		'''<summary>Amount in the currency of the transaction</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AmountFC] As Double
		'''<summary>Date on which the customer accepted or rejected the quotation version</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CloseDate] As DateTime?
		'''<summary>Date on which you expect to close/win the deal</summary>
		Public Property [ClosingDate] As DateTime?
		'''<summary>Date and time on which the quotation was created</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime
		'''<summary>User ID of the creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of the creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>The currency of the quotation</summary>
		Public Property [Currency] As String
		'''<summary>The account where the items should delivered</summary>
		Public Property [DeliveryAccount] As Guid?
		'''<summary>The code of the delivery account</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DeliveryAccountCode] As String
		'''<summary>The contact person of the delivery account</summary>
		Public Property [DeliveryAccountContact] As Guid?
		'''<summary>Full name of the delivery account contact person</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DeliveryAccountContactFullName] As String
		'''<summary>The name of the delivery account</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DeliveryAccountName] As String
		'''<summary>The id of the delivery address</summary>
		Public Property [DeliveryAddress] As Guid?
		'''<summary>The description of the quotation</summary>
		Public Property [Description] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32
		'''<summary>Document linked to the quotation</summary>
		Public Property [Document] As Guid?
		'''<summary>The subject of the document</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DocumentSubject] As String
		'''<summary>Date after which the quotation is no longer valid</summary>
		Public Property [DueDate] As DateTime?
		'''<summary>The account to which the invoice is sent</summary>
		Public Property [InvoiceAccount] As Guid?
		'''<summary>The code of the invoice account</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [InvoiceAccountCode] As String
		'''<summary>The contact person of the invoice account</summary>
		Public Property [InvoiceAccountContact] As Guid?
		'''<summary>Full name of the invoice account contact person</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [InvoiceAccountContactFullName] As String
		'''<summary>The name of the invoice account</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [InvoiceAccountName] As String
		'''<summary>Date and time on which the quotation was last modified</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime
		'''<summary>User ID of the modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Name of the modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>Opportunity linked to the quotation</summary>
		Public Property [Opportunity] As Guid?
		'''<summary>The name of the opportunity</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [OpportunityName] As String
		'''<summary>The account that requested the quotation</summary>
		Public Property [OrderAccount] As Guid?
		'''<summary>The code of the order account</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [OrderAccountCode] As String
		'''<summary>The contact person of the order account</summary>
		Public Property [OrderAccountContact] As Guid?
		'''<summary>Full name of the order account contact person</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [OrderAccountContactFullName] As String
		'''<summary>The name of the order account</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [OrderAccountName] As String
		'''<summary>The project linked to the quotation</summary>
		Public Property [Project] As Guid?
		'''<summary>The code of the project</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectCode] As String
		'''<summary>The description of the project</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectDescription] As String
		'''<summary>Date on which the quotation version is entered or printed. Both during entering and printing this date can be adjusted</summary>
		Public Property [QuotationDate] As DateTime?
		'''<summary>Identifier of the quotation</summary>
		Public Property [QuotationID] As Guid
		'''<summary>The collection of quotation lines</summary>
		Public Property [QuotationLines] As IEnumerable(Of Models.CRM.QuotationLine)
		'''<summary>Unique number to indentify the quotation. By default this number is based on the setting for first available number</summary>
		Public Property [QuotationNumber] As Int32
		'''<summary>Extra text that can be added to the quotation</summary>
		Public Property [Remarks] As String
		'''<summary>The user that is responsible for the quotation version</summary>
		Public Property [SalesPerson] As Guid?
		'''<summary>Full name of the sales person</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SalesPersonFullName] As String
		'''<summary>The status of the quotation version. 5 = Rejected, 6 = Reviewed and closed, 10 = Recovery, 20 = Draft, 25 = Open, 35 = Processing... , 40 = Printed, 50 = Accepted</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Status] As Int16?
		'''<summary>The description of the status</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StatusDescription] As String
		'''<summary>Total VAT amount in the currency of the transaction</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VATAmountFC] As Double?
		'''<summary>Number indicating the different reviews which are made for the quotation</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VersionNumber] As Int32
		'''<summary>The number by which this quotation is identified by the order account</summary>
		Public Property [YourRef] As String
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [QuotationLine]
		'''<summary>Amount in the default currency of the company</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AmountDC] As Double
		'''<summary>Amount in the currency of the transaction</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AmountFC] As Double
		'''<summary>By default this contains the item description</summary>
		Public Property [Description] As String
		'''<summary>Discount given on the default price. This is stored as a fraction. ie 5.5% is stored as .055</summary>
		Public Property [Discount] As Double?
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Reference to the item that is sold in this quotation line</summary>
		Public Property [Item] As Guid?
		'''<summary>Description of the item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDescription] As String
		'''<summary>Indicates the sequence of the lines within one quotation</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [LineNumber] As Int32
		'''<summary>Net price of the quotation line</summary>
		Public Property [NetPrice] As Double?
		'''<summary>Extra notes</summary>
		Public Property [Notes] As String
		'''<summary>The number of items sold in default units. The quantity shown in the entry screen is Quantity * UnitFactor</summary>
		Public Property [Quantity] As Double?
		'''<summary>Identifies the quotation. All the lines of a quotation have the same QuotationID</summary>
		Public Property [QuotationID] As Guid
		'''<summary>Unique number to indentify the quotation. By default this number is based on the setting for first available number</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [QuotationNumber] As Int32
		'''<summary>Code of the item unit</summary>
		Public Property [UnitCode] As String
		'''<summary>Description of the item unit</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [UnitDescription] As String
		'''<summary>Price per item unit</summary>
		Public Property [UnitPrice] As Double?
		'''<summary>VAT amount of the line in the currency of the transaction</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VATAmountFC] As Double?
		'''<summary>The VAT code that is used when the quotation is invoiced</summary>
		Public Property [VATCode] As String
		'''<summary>Description of the VAT code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VATDescription] As String
		'''<summary>The VAT percentage of the VAT code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VATPercentage] As Double?
		'''<summary>Number indicating the different reviews which are made for the quotation</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VersionNumber] As Int32
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [ReasonCode]
		'''<summary>Indicates if the reason code is active.</summary>
		Public Property [Active] As Byte?
		'''<summary>Code of the reason.</summary>
		Public Property [Code] As String
		'''<summary>Creation date.</summary>
		Public Property [Created] As DateTime?
		'''<summary>User ID of creator.</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator.</summary>
		Public Property [CreatorFullName] As String
		'''<summary>Description of the reason code.</summary>
		Public Property [Description] As String
		'''<summary>Division code.</summary>
		Public Property [Division] As Int32?
		'''<summary>Primary key.</summary>
		Public Property [ID] As Guid
		'''<summary>Last modified date.</summary>
		Public Property [Modified] As DateTime?
		'''<summary>User ID of modifier.</summary>
		Public Property [Modifier] As Guid?
		'''<summary>Name of modifier.</summary>
		Public Property [ModifierFullName] As String
		'''<summary>Extra notes.</summary>
		Public Property [Notes] As String
		'''<summary>Type of the reason code.</summary>
		Public Property [Type] As Int16?
		'''<summary>Description of the type of the reason code.</summary>
		Public Property [TypeDescription] As String
	End Class

	<SupportedActionsSDK(True, False, False, False)>
	<DataServiceKey("QuotationID")>
	Public Class [RejectQuotation]
		'''<summary>Division code.</summary>
		Public Property [Division] As Int32
		'''<summary>Contains the error message if an error occurred during the rejection of the quotation.</summary>
		Public Property [ErrorMessage] As String
		'''<summary>Identifier of the quotation.</summary>
		Public Property [QuotationID] As Guid
		'''<summary>Reason why the quotation was rejected.</summary>
		Public Property [ReasonCode] As Guid?
		'''<summary>Contains information if the quotation was successfully rejected.</summary>
		Public Property [SuccessMessage] As String
	End Class

	<SupportedActionsSDK(True, False, False, False)>
	<DataServiceKey("QuotationID")>
	Public Class [ReopenQuotation]
		'''<summary>Division code.</summary>
		Public Property [Division] As Int32
		'''<summary>Contains the error message if an error occurred during the reopening of the quotation.</summary>
		Public Property [ErrorMessage] As String
		'''<summary>Identifier of the quotation.</summary>
		Public Property [QuotationID] As Guid
		'''<summary>Contains information if the quotation was successfully reopened.</summary>
		Public Property [SuccessMessage] As String
	End Class

	<SupportedActionsSDK(True, False, False, False)>
	<DataServiceKey("QuotationID")>
	Public Class [ReviewQuotation]
		'''<summary>Indicates if the item prices should be copied from the original quotation or the default item prices should be used.</summary>
		Public Property [CopyItemPrices] As Boolean?
		'''<summary>The description of the new quotation.</summary>
		Public Property [Description] As String
		'''<summary>Division code.</summary>
		Public Property [Division] As Int32
		'''<summary>The document linked to the new quotation.</summary>
		Public Property [Document] As Guid?
		'''<summary>Contains the error message if an error occurred during the reviewing of the quotation.</summary>
		Public Property [ErrorMessage] As String
		'''<summary>Identifier of the newly created quotation.</summary>
		Public Property [NewQuotationID] As Guid?
		'''<summary>The account who made the order.</summary>
		Public Property [OrderAccount] As Guid?
		'''<summary>The contact person of the account who made the order.</summary>
		Public Property [OrderAccountContact] As Guid?
		'''<summary>The paymentcondition linked to the new quotation.</summary>
		Public Property [PaymentCondition] As String
		'''<summary>The date of the new quotation.</summary>
		Public Property [QuotationDate] As DateTime?
		'''<summary>Identifier of the quotation.</summary>
		Public Property [QuotationID] As Guid
		'''<summary>Contains information if the quotation was successfully reviewed.</summary>
		Public Property [SuccessMessage] As String
	End Class

End Namespace