' Last generated on 2016-07-06 07:30:03Z

<SupportedActionsSDK(True, False, False, False)>
<DataServiceKey("QuotationID")>
Public Class AcceptedQuotation
	'''<![CDATA[0 = No action, 1 = create sales order, 2 = create sales invoice, 3 = create project.]]>
	Public Property [Action] As Int32
	'''<![CDATA[Create a project work breakdown structure. Only needed when ProjectBudgetType = 2.]]>
	Public Property [CreateProjectWBS] As Boolean?
	'''<![CDATA[Division code]]>
	Public Property [Division] As Int32
	'''<![CDATA[Contains the error message if an error occurred during the acception of the quotation.]]>
	Public Property [ErrorMessage] As String
	'''<![CDATA[The journal in which the sales invoice will be booked. Only needed for Action = 2.]]>
	Public Property [InvoiceJournal] As Int32
	'''<![CDATA[The budget type of the project that will be created.]]>
	Public Property [ProjectBudgetType] As Int32?
	'''<![CDATA[The code of the project that will be created.]]>
	Public Property [ProjectCode] As String
	'''<![CDATA[The description of the project that will be created.]]>
	Public Property [ProjectDescription] As String
	'''<![CDATA[The invoicing date of the project. Only needed for ProjectInvoicingAction = 2.]]>
	Public Property [ProjectInvoiceDate] As DateTime?
	'''<![CDATA[The project invoicing action. 1 = Create invoice terms, 2 = As quoted.]]>
	Public Property [ProjectInvoicingAction] As Int32?
	'''<![CDATA[The prepaid type. Only needed for ProjectType = 5. 1 = Retainer, 2 = Hour type bundle.]]>
	Public Property [ProjectPrepaindTypes] As Int32?
	'''<![CDATA[PriceAgreement.]]>
	Public Property [ProjectPriceAgreement] As Double?
	'''<![CDATA[Contains information if the project was successfully created.]]>
	Public Property [ProjectSuccess] As String
	'''<![CDATA[The type of the project that will be created. 2 = Fixed price, 3 = Time and Material, 4 = Non billable, 5 = Prepaid.]]>
	Public Property [ProjectType] As Int32?
	'''<![CDATA[Identifier of the quotation.]]>
	Public Property [QuotationID] As Guid
	'''<![CDATA[Reason why the quotation was accepted.]]>
	Public Property [ReasonCode] As Guid?
	'''<![CDATA[Contains information if the sales invoice was successfully created.]]>
	Public Property [SalesInvoiceSuccess] As String
	'''<![CDATA[Contains information if the sales order was successfully created.]]>
	Public Property [SalesOrderSuccess] As String
	'''<![CDATA[Contains information if the quotation was successfully accepted.]]>
	Public Property [SuccessMessage] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class Account
	'''<![CDATA[Reference to the accountant of the customer. Conditions: The referred accountant must have value > 0 in the field IsAccountant]]>
	Public Property [Accountant] As Guid?
	'''<![CDATA[ID of the account manager]]>
	Public Property [AccountManager] As Guid?
	'''<![CDATA[Name of the account manager]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountManagerFullName] As String
	'''<![CDATA[Number of the account manager  ]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountManagerHID] As Int32?
	'''<![CDATA[Reference to Activity sector of the account]]>
	Public Property [ActivitySector] As Guid?
	'''<![CDATA[Reference to Activity sub-sector of the account]]>
	Public Property [ActivitySubSector] As Guid?
	'''<![CDATA[Visit address first line]]>
	Public Property [AddressLine1] As String
	'''<![CDATA[Visit address second line]]>
	Public Property [AddressLine2] As String
	'''<![CDATA[Visit address third line]]>
	Public Property [AddressLine3] As String
	'''<![CDATA[Collection of Bank accounts]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [BankAccounts] As IEnumerable(Of BankAccount)
	'''<![CDATA[Indicates if the account is blocked]]>
	Public Property [Blocked] As Boolean?
	'''<![CDATA[Obsolete]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [BRIN] As Guid?
	'''<![CDATA[Reference to the business type of the account]]>
	Public Property [BusinessType] As Guid?
	'''<![CDATA[Indicates the default for the possibility to drop ship when an item is linked to a supplier]]>
	Public Property [CanDropShip] As Boolean?
	'''<![CDATA[Chamber of commerce number]]>
	Public Property [ChamberOfCommerce] As String
	'''<![CDATA[Visit address City]]>
	Public Property [City] As String
	'''<![CDATA[Obsolete]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Classification] As String
	'''<![CDATA[Account classification 1]]>
	Public Property [Classification1] As Guid?
	'''<![CDATA[Account classification 2]]>
	Public Property [Classification2] As Guid?
	'''<![CDATA[Account classification 3]]>
	Public Property [Classification3] As Guid?
	'''<![CDATA[Account classification 4]]>
	Public Property [Classification4] As Guid?
	'''<![CDATA[Account classification 5]]>
	Public Property [Classification5] As Guid?
	'''<![CDATA[Account classification 6]]>
	Public Property [Classification6] As Guid?
	'''<![CDATA[Account classification 7]]>
	Public Property [Classification7] As Guid?
	'''<![CDATA[Account classification 8]]>
	Public Property [Classification8] As Guid?
	'''<![CDATA[Obsolete]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ClassificationDescription] As String
	'''<![CDATA[Unique key, fixed length numeric string with leading spaces, length 18. IMPORTANT: When you use OData $filter on this field you have to make sure the filter parameter contains the leading spaces]]>
	Public Property [Code] As String
	'''<![CDATA[Code under which your own company is known at the account]]>
	Public Property [CodeAtSupplier] As String
	'''<![CDATA[Reference to Company size of the account]]>
	Public Property [CompanySize] As Guid?
	'''<![CDATA[Consolidation scenario (Time & Billing). Values: 0 = No consolidation, 1 = Item, 2 = Item + Project, 3 = Item + Employee, 4 = Item + Employee + Project. Item means in this case including Unit and Price, these also have to be the same to consolidate]]>
	Public Property [ConsolidationScenario] As Byte?
	'''<![CDATA[Date of the latest control of account data with external web service]]>
	Public Property [ControlledDate] As DateTime?
	'''<![CDATA[Obsolete]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Costcenter] As String
	'''<![CDATA[Obsolete]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostcenterDescription] As String
	'''<![CDATA[Obsolete]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostPaid] As Byte
	'''<![CDATA[Country code]]>
	Public Property [Country] As String
	'''<![CDATA[Country name]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CountryName] As String
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Maximum amount of credit for Purchase. If no value has been defined, there is no credit limit]]>
	Public Property [CreditLinePurchase] As Double?
	'''<![CDATA[Maximum amount of credit for sales. If no value has been defined, there is no credit limit]]>
	Public Property [CreditLineSales] As Double?
	'''<![CDATA[Obsolete]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Currency] As String
	'''<![CDATA[Obsolete]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CustomerSince] As DateTime?
	'''<![CDATA[DATEV creditor code for Germany legislation]]>
	Public Property [DatevCreditorCode] As String
	'''<![CDATA[DATEV debtor code for Germany legislation]]>
	Public Property [DatevDebtorCode] As String
	'''<![CDATA[Default discount percentage for purchase. This is stored as a fraction. ie 5.5% is stored as .055]]>
	Public Property [DiscountPurchase] As Double?
	'''<![CDATA[Default discount percentage for sales. This is stored as a fraction. ie 5.5% is stored as .055]]>
	Public Property [DiscountSales] As Double?
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Obsolete]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Document] As Guid?
	'''<![CDATA[Obsolete]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DunsNumber] As String
	'''<![CDATA[E-Mail address of the account]]>
	Public Property [Email] As String
	'''<![CDATA[Determines in combination with the start date if the account is active. If the current date is > end date the account is inactive]]>
	Public Property [EndDate] As DateTime?
	'''<![CDATA[RegistrationDate]]>
	Public Property [EstablishedDate] As DateTime?
	'''<![CDATA[Fax number]]>
	Public Property [Fax] As String
	'''<![CDATA[Default (corporate) GL offset account for purchase (cost)]]>
	Public Property [GLAccountPurchase] As Guid?
	'''<![CDATA[Default (corporate) GL offset account for sales (revenue)]]>
	Public Property [GLAccountSales] As Guid?
	'''<![CDATA[Default GL account for Accounts Payable]]>
	Public Property [GLAP] As Guid?
	'''<![CDATA[Default GL account for Accounts Receivable]]>
	Public Property [GLAR] As Guid?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Suppressed warning message when there is duplication on the DATEV code]]>
	Public Property [IgnoreDatevWarningMessage] As Boolean
	'''<![CDATA[Intrastat Area]]>
	Public Property [IntraStatArea] As String
	'''<![CDATA[Intrastat delivery method]]>
	Public Property [IntraStatDeliveryTerm] As String
	'''<![CDATA[System for Intrastat]]>
	Public Property [IntraStatSystem] As String
	'''<![CDATA[Transaction type A for Intrastat]]>
	Public Property [IntraStatTransactionA] As String
	'''<![CDATA[Transaction type B for Intrastat]]>
	Public Property [IntraStatTransactionB] As String
	'''<![CDATA[Transport method for Intrastat]]>
	Public Property [IntraStatTransportMethod] As String
	'''<![CDATA[ID of account to be invoiced instead of this account]]>
	Public Property [InvoiceAccount] As Guid?
	'''<![CDATA[Code of InvoiceAccount]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [InvoiceAccountCode] As String
	'''<![CDATA[Name of InvoiceAccount]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [InvoiceAccountName] As String
	'''<![CDATA[Indicates which attachment types should be sent when a sales invoice is printed. Only values in related table with Invoice=1 are allowed]]>
	Public Property [InvoiceAttachmentType] As Int32?
	'''<![CDATA[Method of sending for sales invoices. Values: 1: Paper, 2: EMail, 4: Mailbox (electronic exchange)]]>
	Public Property [InvoicingMethod] As Int32?
	'''<![CDATA[Indicates whether the account is an accountant. Values: 0 = No accountant, 1 = True, but accountant doesn't want his name to be published in the list of accountants, 2 = True, and accountant is published in the list of accountants]]>
	Public Property [IsAccountant] As Byte
	'''<![CDATA[Indicates whether the accounti is an agency]]>
	Public Property [IsAgency] As Byte
	'''<![CDATA[Obsolete]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [IsBank] As Boolean?
	'''<![CDATA[Indicates whether the account is a competitor]]>
	Public Property [IsCompetitor] As Byte
	'''<![CDATA[Indicates whether a customer is eligible for extra duty]]>
	Public Property [IsExtraDuty] As Boolean?
	'''<![CDATA[Indicates if the account is excluded from mailing marketing information]]>
	Public Property [IsMailing] As Byte
	'''<![CDATA[Obsolete]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [IsMember] As Boolean?
	'''<![CDATA[Indicates whether the account is a pilot account]]>
	Public Property [IsPilot] As Boolean?
	'''<![CDATA[Obsolete]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [IsPurchase] As Boolean?
	'''<![CDATA[Indicates whether the account is a reseller]]>
	Public Property [IsReseller] As Boolean?
	'''<![CDATA[Indicates whether the account is allowed for sales]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [IsSales] As Boolean?
	'''<![CDATA[Indicates whether the account is a supplier]]>
	Public Property [IsSupplier] As Boolean?
	'''<![CDATA[Language code]]>
	Public Property [Language] As String
	'''<![CDATA[Language description]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [LanguageDescription] As String
	'''<![CDATA[Latitude (used by Google maps)]]>
	Public Property [Latitude] As Double?
	'''<![CDATA[Reference to Lead source of an account]]>
	Public Property [LeadSource] As Guid?
	'''<![CDATA[Bytes of the logo image]]>
	Public Property [Logo] As Byte()
	'''<![CDATA[The file name (without path, but with extension) of the image]]>
	Public Property [LogoFileName] As String
	'''<![CDATA[Thumbnail url of the logo]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [LogoThumbnailUrl] As String
	'''<![CDATA[Url to retrieve the logo]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [LogoUrl] As String
	'''<![CDATA[Longitude (used by Google maps)]]>
	Public Property [Longitude] As Double?
	'''<![CDATA[Reference to main contact person]]>
	Public Property [MainContact] As Guid?
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Account name]]>
	Public Property [Name] As String
	'''<![CDATA[ID of the parent account]]>
	Public Property [Parent] As Guid?
	'''<![CDATA[Indicates the loan repayment plan for UK legislation]]>
	Public Property [PayAsYouEarn] As String
	'''<![CDATA[Code of default payment condition for purchase]]>
	Public Property [PaymentConditionPurchase] As String
	'''<![CDATA[Description of PaymentConditionPurchase]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PaymentConditionPurchaseDescription] As String
	'''<![CDATA[Code of default payment condition for sales]]>
	Public Property [PaymentConditionSales] As String
	'''<![CDATA[Description of PaymentConditionSales]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PaymentConditionSalesDescription] As String
	'''<![CDATA[Phone number]]>
	Public Property [Phone] As String
	'''<![CDATA[Phone number extention]]>
	Public Property [PhoneExtension] As String
	'''<![CDATA[Visit address postcode]]>
	Public Property [Postcode] As String
	'''<![CDATA[Default sales price list for account]]>
	Public Property [PriceList] As Guid?
	'''<![CDATA[Currency of purchase]]>
	Public Property [PurchaseCurrency] As String
	'''<![CDATA[Description of PurchaseCurrency]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PurchaseCurrencyDescription] As String
	'''<![CDATA[Indicates number of days required to receive a purchase. Acts as a default]]>
	Public Property [PurchaseLeadDays] As Int32?
	'''<![CDATA[Default VAT code used for purchase entries]]>
	Public Property [PurchaseVATCode] As String
	'''<![CDATA[Description of PurchaseVATCode]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PurchaseVATCodeDescription] As String
	'''<![CDATA[Define the relation that should be taken in the official document of the rewarding fiscal fiches Belcotax]]>
	Public Property [RecepientOfCommissions] As Boolean?
	'''<![CDATA[Remarks]]>
	Public Property [Remarks] As String
	'''<![CDATA[ID of the reseller account. Conditions: the target account must have the property IsReseller turned on]]>
	Public Property [Reseller] As Guid?
	'''<![CDATA[Code of Reseller]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ResellerCode] As String
	'''<![CDATA[Name of Reseller]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ResellerName] As String
	'''<![CDATA[Fiscal number for NL legislation]]>
	Public Property [RSIN] As String
	'''<![CDATA[Currency of Sales used for Time & Billing]]>
	Public Property [SalesCurrency] As String
	'''<![CDATA[Description of SalesCurrency]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SalesCurrencyDescription] As String
	'''<![CDATA[Default tax schedule when creating sales orders or sales invoices]]>
	Public Property [SalesTaxSchedule] As Guid?
	'''<![CDATA[Code of the tax schedule]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SalesTaxScheduleCode] As String
	'''<![CDATA[Description of the tax schedule]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SalesTaxScheduleDescription] As String
	'''<![CDATA[Default VAT code for a sales entry]]>
	Public Property [SalesVATCode] As String
	'''<![CDATA[Description of SalesVATCode]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SalesVATCodeDescription] As String
	'''<![CDATA[Search code]]>
	Public Property [SearchCode] As String
	'''<![CDATA[Security level (0 - 100)]]>
	Public Property [SecurityLevel] As Int32?
	'''<![CDATA[Separate invoice per project (Time & Billing)]]>
	Public Property [SeparateInvPerProject] As Byte
	'''<![CDATA[Indicates how invoices are generated from subscriptions. 0 = subscriptions belonging to the same customer are combined in a single invoice. 1 = each subscription results in one invoice. In both cases, each individual subscription line results in one invoice line]]>
	Public Property [SeparateInvPerSubscription] As Byte
	'''<![CDATA[Indicates the number of days it takes to send goods to the customer. Acts as a default]]>
	Public Property [ShippingLeadDays] As Int32?
	'''<![CDATA[Default shipping method]]>
	Public Property [ShippingMethod] As Guid?
	'''<![CDATA[Indicates in combination with the end date if the account is active]]>
	Public Property [StartDate] As DateTime?
	'''<![CDATA[State/Province code]]>
	Public Property [State] As String
	'''<![CDATA[Name of State]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [StateName] As String
	'''<![CDATA[If the status field is filled this means the account is a customer. The value indicates the customer status. Possible values: A=None, S=Suspect, P=Prospect, C=Customer]]>
	Public Property [Status] As String
	'''<![CDATA[Obsolete]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [StatusSince] As DateTime?
	'''<![CDATA[Trade name can be registered and shown with the client (for all legislations)]]>
	Public Property [TradeName] As String
	'''<![CDATA[Account type: Values: A = Relation, D = Division]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Type] As String
	'''<![CDATA[Unique taxpayer reference for UK legislation]]>
	Public Property [UniqueTaxpayerReference] As String
	'''<![CDATA[Indicates the VAT status of an account to be able to identify the relation that should be selected in the VAT debtor listing in Belgium]]>
	Public Property [VATLiability] As String
	'''<![CDATA[The number under which the account is known at the Value Added Tax collection agency]]>
	Public Property [VATNumber] As String
	'''<![CDATA[Website of the account]]>
	Public Property [Website] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class AccountClass
	'''<![CDATA[Classification code]]>
	Public Property [Code] As String
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Default credit management scenario to be used for new payment terms]]>
	Public Property [CreditManagementScenario] As Guid?
	'''<![CDATA[Description]]>
	Public Property [Description] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class AccountClassification
	'''<![CDATA[Reference to Account classification name]]>
	Public Property [AccountClassificationName] As Guid?
	'''<![CDATA[Description of AccountClassificationName]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountClassificationNameDescription] As String
	'''<![CDATA[Account classification code]]>
	Public Property [Code] As String
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Description]]>
	Public Property [Description] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class AccountClassificationName
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Description]]>
	Public Property [Description] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Sequence number]]>
	Public Property [SequenceNumber] As Int32
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class AccountInvolvedAccount
	'''<![CDATA[ID of account]]>
	Public Property [Account] As Guid?
	'''<![CDATA[Name of account]]>
	Public Property [AccountName] As String
	'''<![CDATA[Creation date]]>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Division code]]>
	Public Property [Division] As Int32?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[ID of involved account]]>
	Public Property [InvolvedAccount] As Guid?
	'''<![CDATA[Description of relation type]]>
	Public Property [InvolvedAccountRelationTypeDescription] As String
	'''<![CDATA[TermId of description of relation type]]>
	Public Property [InvolvedAccountRelationTypeDescriptionTermId] As Int32?
	'''<![CDATA[ID of relation type]]>
	Public Property [InvolvedAccountRelationTypeId] As Int16?
	'''<![CDATA[Last modified date]]>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Use to record details of important information]]>
	Public Property [Notes] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class AccountOwner
	'''<![CDATA[ID of the account that is owned]]>
	Public Property [Account] As Guid?
	'''<![CDATA[Code of the account that is owned]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountCode] As String
	'''<![CDATA[Name of the account that is owned]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountName] As String
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of the creator]]>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of the creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Division code]]>
	Public Property [Division] As Int32?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of the modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of the modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[ID of the account who owns specified account]]>
	Public Property [OwnerAccount] As Guid?
	'''<![CDATA[Code of the account who owns specified account]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [OwnerAccountCode] As String
	'''<![CDATA[Name of the account who owns specified account]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [OwnerAccountName] As String
	'''<![CDATA[Percentage of shares that is owned. 1 is 100%, 0.5 is 50%]]>
	Public Property [Shares] As Double?
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class ActiveEmployment
	'''<![CDATA[The average number of contract days that an employee works per week]]>
	Public Property [AverageDaysPerWeek] As Double?
	'''<![CDATA[The average number of contract hours that an employee works per week]]>
	Public Property [AverageHoursPerWeek] As Double?
	'''<![CDATA[Employment contract ID]]>
	Public Property [Contract] As Guid?
	'''<![CDATA[Document ID of the employment contract]]>
	Public Property [ContractDocument] As Guid?
	'''<![CDATA[End date of employment contract]]>
	Public Property [ContractEndDate] As DateTime?
	'''<![CDATA[Employment probation end date]]>
	Public Property [ContractProbationEndDate] As DateTime?
	'''<![CDATA[Employment probation period]]>
	Public Property [ContractProbationPeriod] As Int32?
	'''<![CDATA[Start date of employment contract]]>
	Public Property [ContractStartDate] As DateTime?
	'''<![CDATA[Type of employment contract. 1 - Definite, 2 - Indefinite, 3 - External]]>
	Public Property [ContractType] As Int32?
	'''<![CDATA[Description of employment contract type]]>
	Public Property [ContractTypeDescription] As String
	'''<![CDATA[Creation date]]>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Department of employee]]>
	Public Property [Department] As Guid?
	'''<![CDATA[Department code of employee]]>
	Public Property [DepartmentCode] As String
	'''<![CDATA[Description of department]]>
	Public Property [DepartmentDescription] As String
	'''<![CDATA[Division code]]>
	Public Property [Division] As Int32?
	'''<![CDATA[Employee ID]]>
	Public Property [Employee] As Guid?
	'''<![CDATA[Name of employee]]>
	Public Property [EmployeeFullName] As String
	'''<![CDATA[Numeric number of Employee]]>
	Public Property [EmployeeHID] As Int32?
	'''<![CDATA[Organization of employment]]>
	Public Property [EmploymentOrganization] As Guid?
	'''<![CDATA[End date of employment]]>
	Public Property [EndDate] As DateTime?
	'''<![CDATA[Numeric ID of the employment]]>
	Public Property [HID] As Int32?
	'''<![CDATA[Hourly wage]]>
	Public Property [HourlyWage] As Double?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Internal rate for time & billing or professional service user]]>
	Public Property [InternalRate] As Double?
	'''<![CDATA[Job title of employee]]>
	Public Property [Jobtitle] As Guid?
	'''<![CDATA[Description of job title]]>
	Public Property [JobtitleDescription] As String
	'''<![CDATA[Last modified date]]>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	Public Property [ModifierFullName] As String
	'''<![CDATA[ID of employment ended]]>
	Public Property [ReasonEnd] As Int32?
	'''<![CDATA[Reason of end of employment]]>
	Public Property [ReasonEndDescription] As String
	'''<![CDATA[Reason of ended flexible employment]]>
	Public Property [ReasonEndFlex] As Int32?
	'''<![CDATA[Other reason for end of employment]]>
	Public Property [ReasonEndFlexDescription] As String
	'''<![CDATA[Employment salary]]>
	Public Property [Salary] As Guid?
	'''<![CDATA[Work schedule]]>
	Public Property [Schedule] As Guid?
	'''<![CDATA[Average hours per week in a schedule.]]>
	Public Property [ScheduleAverageHours] As Double?
	'''<![CDATA[Work schedule code]]>
	Public Property [ScheduleCode] As String
	'''<![CDATA[Number of days of work per week]]>
	Public Property [ScheduleDays] As Double?
	'''<![CDATA[Description of work schedule]]>
	Public Property [ScheduleDescription] As String
	'''<![CDATA[Number of work hours per week.]]>
	Public Property [ScheduleHours] As Double?
	'''<![CDATA[Start date of employment]]>
	Public Property [StartDate] As DateTime?
	'''<![CDATA[Start date of the employee in the organization. This field is used to count the years in service.]]>
	Public Property [StartDateOrganization] As DateTime?
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class Address
	'''<![CDATA[Account linked to the address]]>
	Public Property [Account] As Guid?
	'''<![CDATA[Indicates if the account is a supplier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountIsSupplier] As Boolean?
	'''<![CDATA[Name of the account]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountName] As String
	'''<![CDATA[First address line]]>
	Public Property [AddressLine1] As String
	'''<![CDATA[Second address line]]>
	Public Property [AddressLine2] As String
	'''<![CDATA[Third address line]]>
	Public Property [AddressLine3] As String
	'''<![CDATA[City]]>
	Public Property [City] As String
	'''<![CDATA[Contact linked to Address]]>
	Public Property [Contact] As Guid?
	'''<![CDATA[Contact name]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ContactName] As String
	'''<![CDATA[Country code]]>
	Public Property [Country] As String
	'''<![CDATA[Country name]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CountryName] As String
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Fax number]]>
	Public Property [Fax] As String
	'''<![CDATA[Free boolean field 1]]>
	Public Property [FreeBoolField_01] As Boolean?
	'''<![CDATA[Free boolean field 2]]>
	Public Property [FreeBoolField_02] As Boolean?
	'''<![CDATA[Free boolean field 3]]>
	Public Property [FreeBoolField_03] As Boolean?
	'''<![CDATA[Free boolean field 4]]>
	Public Property [FreeBoolField_04] As Boolean?
	'''<![CDATA[Free boolean field 5]]>
	Public Property [FreeBoolField_05] As Boolean?
	'''<![CDATA[Free date field 1]]>
	Public Property [FreeDateField_01] As DateTime?
	'''<![CDATA[Free date field 2]]>
	Public Property [FreeDateField_02] As DateTime?
	'''<![CDATA[Free date field 3]]>
	Public Property [FreeDateField_03] As DateTime?
	'''<![CDATA[Free date field 4]]>
	Public Property [FreeDateField_04] As DateTime?
	'''<![CDATA[Free date field 5]]>
	Public Property [FreeDateField_05] As DateTime?
	'''<![CDATA[Free number field 1]]>
	Public Property [FreeNumberField_01] As Double?
	'''<![CDATA[Free number field 2]]>
	Public Property [FreeNumberField_02] As Double?
	'''<![CDATA[Free number field 3]]>
	Public Property [FreeNumberField_03] As Double?
	'''<![CDATA[Free number field 4]]>
	Public Property [FreeNumberField_04] As Double?
	'''<![CDATA[Free number field 5]]>
	Public Property [FreeNumberField_05] As Double?
	'''<![CDATA[Free text field 1]]>
	Public Property [FreeTextField_01] As String
	'''<![CDATA[Free text field 2]]>
	Public Property [FreeTextField_02] As String
	'''<![CDATA[Free text field 3]]>
	Public Property [FreeTextField_03] As String
	'''<![CDATA[Free text field 4]]>
	Public Property [FreeTextField_04] As String
	'''<![CDATA[Free text field 5]]>
	Public Property [FreeTextField_05] As String
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Mailbox]]>
	Public Property [Mailbox] As String
	'''<![CDATA[Indicates if the address is the main address for this type]]>
	Public Property [Main] As Boolean?
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Last 5 digits of SIRET number which is an intern sequential number of 4 digits representing the identification of the localization of the office]]>
	Public Property [NicNumber] As String
	'''<![CDATA[Notes for an address]]>
	Public Property [Notes] As String
	'''<![CDATA[Phone number]]>
	Public Property [Phone] As String
	'''<![CDATA[Phone extension]]>
	Public Property [PhoneExtension] As String
	'''<![CDATA[Postcode]]>
	Public Property [Postcode] As String
	'''<![CDATA[State]]>
	Public Property [State] As String
	'''<![CDATA[Name of the State]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [StateDescription] As String
	'''<![CDATA[The type of address. Visit=1, Postal=2, Invoice=3, Delivery=4]]>
	Public Property [Type] As Int16?
	'''<![CDATA[The warehouse linked to the address, if a warehouse is linked the account will be empty. Can only be filled for type=Delivery]]>
	Public Property [Warehouse] As Guid?
	'''<![CDATA[Code of the warehoude]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [WarehouseCode] As String
	'''<![CDATA[Description of the warehouse]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [WarehouseDescription] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class AddressState
	'''<![CDATA[Country code]]>
	Public Property [Country] As String
	'''<![CDATA[Description of state prefixed with the code]]>
	Public Property [DisplayValue] As String
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Latitude]]>
	Public Property [Latitude] As Double?
	'''<![CDATA[Longitude]]>
	Public Property [Longitude] As Double?
	'''<![CDATA[State name]]>
	Public Property [Name] As String
	'''<![CDATA[State code]]>
	Public Property [State] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("AccountId")>
Public Class AgingAmountsPayable
	'''<![CDATA[Code of Account]]>
	Public Property [AccountCode] As String
	'''<![CDATA[Primary key]]>
	Public Property [AccountId] As Guid
	'''<![CDATA[Name of Account]]>
	Public Property [AccountName] As String
	'''<![CDATA[Age group 1]]>
	Public Property [AgeGroup1] As Int32
	'''<![CDATA[Amount of age group 1]]>
	Public Property [AgeGroup1Amount] As Double
	'''<![CDATA[Description of AgeGroup1]]>
	Public Property [AgeGroup1Description] As String
	'''<![CDATA[Age group 2]]>
	Public Property [AgeGroup2] As Int32
	'''<![CDATA[Amount of age group 2]]>
	Public Property [AgeGroup2Amount] As Double
	'''<![CDATA[Description of AgeGroup2]]>
	Public Property [AgeGroup2Description] As String
	'''<![CDATA[Age group 3]]>
	Public Property [AgeGroup3] As Int32
	'''<![CDATA[Amount of age group 3]]>
	Public Property [AgeGroup3Amount] As Double
	'''<![CDATA[Description of AgeGroup3]]>
	Public Property [AgeGroup3Description] As String
	'''<![CDATA[Age group 4]]>
	Public Property [AgeGroup4] As Int32
	'''<![CDATA[Amount of age group 4]]>
	Public Property [AgeGroup4Amount] As Double
	'''<![CDATA[Description of AgeGroup4]]>
	Public Property [AgeGroup4Description] As String
	'''<![CDATA[Code of Currency]]>
	Public Property [CurrencyCode] As String
	'''<![CDATA[Total amount of all age groups]]>
	Public Property [TotalAmount] As Double
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("AccountId")>
Public Class AgingAmountsReceivable
	'''<![CDATA[Code of Account]]>
	Public Property [AccountCode] As String
	'''<![CDATA[Primary key]]>
	Public Property [AccountId] As Guid
	'''<![CDATA[Name of Account]]>
	Public Property [AccountName] As String
	'''<![CDATA[Age group 1]]>
	Public Property [AgeGroup1] As Int32
	'''<![CDATA[Amount of age group 1]]>
	Public Property [AgeGroup1Amount] As Double
	'''<![CDATA[Description of AgeGroup1]]>
	Public Property [AgeGroup1Description] As String
	'''<![CDATA[Age group 2]]>
	Public Property [AgeGroup2] As Int32
	'''<![CDATA[Amount of age group 2]]>
	Public Property [AgeGroup2Amount] As Double
	'''<![CDATA[Description of AgeGroup2]]>
	Public Property [AgeGroup2Description] As String
	'''<![CDATA[Age group 3]]>
	Public Property [AgeGroup3] As Int32
	'''<![CDATA[Amount of age group 3]]>
	Public Property [AgeGroup3Amount] As Double
	'''<![CDATA[Description of AgeGroup3]]>
	Public Property [AgeGroup3Description] As String
	'''<![CDATA[Age group 4]]>
	Public Property [AgeGroup4] As Int32
	'''<![CDATA[Amount of age group 4]]>
	Public Property [AgeGroup4Amount] As Double
	'''<![CDATA[Description of AgeGroup4]]>
	Public Property [AgeGroup4Description] As String
	'''<![CDATA[Code of Currency]]>
	Public Property [CurrencyCode] As String
	'''<![CDATA[Total amount of all age groups]]>
	Public Property [TotalAmount] As Double
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("AgeGroup")>
Public Class AgingOverview
	'''<![CDATA[Primary key]]>
	Public Property [AgeGroup] As Int32
	'''<![CDATA[Description of AgeGroup]]>
	Public Property [AgeGroupDescription] As String
	'''<![CDATA[Amount payable]]>
	Public Property [AmountPayable] As Double
	'''<![CDATA[Amount receivable]]>
	Public Property [AmountReceivable] As Double
	'''<![CDATA[Code of Currency]]>
	Public Property [CurrencyCode] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class Asset
	'''<![CDATA[Indicates if an asset was already depreciated before registering it in Exact Online]]>
	Public Property [AlreadyDepreciated] As Byte
	'''<![CDATA[In case of a transfer or a split, the original asset ID is saved in this field. This is done to provide tracability of the Asset]]>
	Public Property [AssetFrom] As Guid?
	'''<![CDATA[Description of AssetFrom]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AssetFromDescription] As String
	'''<![CDATA[Asset group identifies GLAccounts to be used for Asset transactions]]>
	Public Property [AssetGroup] As Guid?
	'''<![CDATA[Description of AssetGroup]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AssetGroupDescription] As String
	'''<![CDATA[The catalogue value of the asset]]>
	Public Property [CatalogueValue] As Double?
	'''<![CDATA[This is the code of the asset]]>
	Public Property [Code] As String
	'''<![CDATA[Assets can be linked to a cost center]]>
	Public Property [Costcenter] As String
	'''<![CDATA[Description of Costcenter]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostcenterDescription] As String
	'''<![CDATA[Assets can be linked to a cost unit]]>
	Public Property [Costunit] As String
	'''<![CDATA[Description of Costunit]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostunitDescription] As String
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Used for Belgium legislation. Used to produce the official 'Investment deduction' report]]>
	Public Property [DeductionPercentage] As Double?
	'''<![CDATA[Amount that is already depreciated when adding an existing asset. Can only be filled when 'Alreadydepreciated' is on]]>
	Public Property [DepreciatedAmount] As Double?
	'''<![CDATA[Number of periods that already have been depreciated for the asset. Can only be filled when 'Alreadydepreciated' is on]]>
	Public Property [DepreciatedPeriods] As Int32?
	'''<![CDATA[StartDate of depreciating. Can only be filled when 'Alreadydepreciated' is on]]>
	Public Property [DepreciatedStartDate] As DateTime?
	'''<![CDATA[This is the description of the Asset]]>
	Public Property [Description] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Asset EndDate is filled when asset is Sold or Inactive]]>
	Public Property [EndDate] As DateTime?
	'''<![CDATA[Engine emission of the asset, needed to calculate the co² report]]>
	Public Property [EngineEmission] As Int16?
	'''<![CDATA[Engine type of the asset, Needed to generate a co² report]]>
	Public Property [EngineType] As Int16?
	'''<![CDATA[Links to the gltransactions.id. GL transaction line based on which the asset is created]]>
	Public Property [GLTransactionLine] As Guid?
	'''<![CDATA[Description of GLTransactionLine]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLTransactionLineDescription] As String
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Supplier of the asset]]>
	Public Property [InvestmentAccount] As Guid?
	'''<![CDATA[Code of InvestmentAccount]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [InvestmentAccountCode] As String
	'''<![CDATA[Name of InvestmentAccount]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [InvestmentAccountName] As String
	'''<![CDATA[Investment amount in the default currency of the company]]>
	Public Property [InvestmentAmountDC] As Double?
	'''<![CDATA[Investment value of the asset. Currently the field is filled with the PurchasePriceLocal. Can be status 'Not used' after sources have been cleaned]]>
	Public Property [InvestmentAmountFC] As Double?
	'''<![CDATA[Indicates the currency of the investment amount]]>
	Public Property [InvestmentCurrency] As String
	'''<![CDATA[Description of InvestmentCurrency]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [InvestmentCurrencyDescription] As String
	'''<![CDATA[Refers to the original date when the asset was bought]]>
	Public Property [InvestmentDate] As DateTime?
	'''<![CDATA[Belgian functionality, to determine how a local legal report regarding investment deduction must be created]]>
	Public Property [InvestmentDeduction] As Int16?
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Extra remarks for the asset]]>
	Public Property [Notes] As String
	'''<![CDATA[Parent asset]]>
	Public Property [Parent] As Guid?
	'''<![CDATA[Code of Parent]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ParentCode] As String
	'''<![CDATA[Description of Parent]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ParentDescription] As String
	'''<![CDATA[Image for an asset]]>
	Public Property [Picture] As Byte()
	'''<![CDATA[Filename of the image]]>
	Public Property [PictureFileName] As String
	'''<![CDATA[First method of depreciation. Currently, it is the only one used]]>
	Public Property [PrimaryMethod] As Guid?
	'''<![CDATA[Code of PrimaryMethod]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PrimaryMethodCode] As String
	'''<![CDATA[Description of PrimaryMethod]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PrimaryMethodDescription] As String
	'''<![CDATA[Indicates the residual value of the asset at the end of the depreciation]]>
	Public Property [ResidualValue] As Double?
	'''<![CDATA[Asset Depreciation StartDate]]>
	Public Property [StartDate] As DateTime?
	'''<![CDATA[Identifies the status of the Asset. (see AssetStatus table to see the possibilities)]]>
	Public Property [Status] As Int16?
	'''<![CDATA[Reference to Transaction]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [TransactionEntryID] As Guid?
	'''<![CDATA[Entry number of transaction]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [TransactionEntryNo] As Int32?
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class Bank
	'''<![CDATA[The name of the bank]]>
	Public Property [BankName] As String
	'''<![CDATA[The bank identification code of the bank]]>
	Public Property [BICCode] As String
	'''<![CDATA[The country in which the bank is based]]>
	Public Property [Country] As String
	'''<![CDATA[Creation date]]>
	Public Property [Created] As DateTime?
	'''<![CDATA[The extended description of the bank]]>
	Public Property [Description] As String
	'''<![CDATA[The account format used by the bank]]>
	Public Property [Format] As String
	'''<![CDATA[The website of the bank]]>
	Public Property [HomePageAddress] As String
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[The status of the bank. A = Active, P = Passive]]>
	Public Property [Status] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class BankAccount
	'''<![CDATA[Account (customer, supplier) to which the bank account belongs]]>
	Public Property [Account] As Guid?
	'''<![CDATA[The name of the account]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountName] As String
	'''<![CDATA[Obsolete]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Bank] As Guid?
	'''<![CDATA[The bank account number]]>
	Public Property [BankAccount] As String
	'''<![CDATA[Name of the holder of the bank account, as known by the bank]]>
	Public Property [BankAccountHolderName] As String
	'''<![CDATA[Obsolete]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [BankDescription] As String
	'''<![CDATA[Obsolete]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [BankName] As String
	'''<![CDATA[BIC code of the bank where the bank account is held]]>
	Public Property [BICCode] As String
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Description of the bank account]]>
	Public Property [Description] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Format that belongs to the bank account number]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Format] As String
	'''<![CDATA[Obsolete]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [IBAN] As String
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Indicates if the bank account is the main bank account]]>
	Public Property [Main] As Boolean?
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[ID of the Payment service account. Used when Type is 'P' (Payment service)]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PaymentServiceAccount] As Guid?
	'''<![CDATA[The type indicates what entity the bank account is used for. A = Account (default), E = Employee, K = Cash, P = Payment service, R = Bank, S = Student, U = Unknown. Currently it's only possible to create 'Account' type bank accounts.]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Type] As String
	'''<![CDATA[Description of the Type]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [TypeDescription] As String
End Class

<SupportedActionsSDK(True, True, False, False)>
<DataServiceKey("EntryID")>
Public Class BankEntry
	'''<![CDATA[Collection of lines]]>
	Public Property [BankEntryLines] As IEnumerable(Of BankEntryLine)
	'''<![CDATA[Reference to document with bank statement]]>
	Public Property [BankStatementDocument] As Guid?
	'''<![CDATA[Document number of document with bank statement]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [BankStatementDocumentNumber] As Int32?
	'''<![CDATA[Subject of document with bank statement]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [BankStatementDocumentSubject] As String
	'''<![CDATA[Closing balance in the currency of the transaction]]>
	Public Property [ClosingBalanceFC] As Double?
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[Currency code]]>
	Public Property [Currency] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Primary key]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [EntryID] As Guid
	'''<![CDATA[Entry number]]>
	Public Property [EntryNumber] As Int32?
	'''<![CDATA[Fiancial period]]>
	Public Property [FinancialPeriod] As Int16?
	'''<![CDATA[Fiancial year]]>
	Public Property [FinancialYear] As Int16?
	'''<![CDATA[Code of Journal]]>
	Public Property [JournalCode] As String
	'''<![CDATA[Description of Journal]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [JournalDescription] As String
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[Opening balance in the currency of the transaction]]>
	Public Property [OpeningBalanceFC] As Double?
	'''<![CDATA[Status: 5 = Rejected, 20 = Open, 50 = Processed]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Status] As Int16?
	'''<![CDATA[Description of Status]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [StatusDescription] As String
End Class

<SupportedActionsSDK(True, True, False, False)>
<DataServiceKey("ID")>
Public Class BankEntryLine
	'''<![CDATA[Reference to Account]]>
	Public Property [Account] As Guid?
	'''<![CDATA[Code of Account]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountCode] As String
	'''<![CDATA[Name of Account]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountName] As String
	'''<![CDATA[Amount in the default currency of the company]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AmountDC] As Double?
	'''<![CDATA[Amount in the currency of the transaction]]>
	Public Property [AmountFC] As Double?
	'''<![CDATA[Vat amount in the currency of the transaction]]>
	Public Property [AmountVATFC] As Double?
	'''<![CDATA[Reference to an asset]]>
	Public Property [Asset] As Guid?
	'''<![CDATA[Code of Asset]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AssetCode] As String
	'''<![CDATA[Description of Asset]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AssetDescription] As String
	'''<![CDATA[Reference to a cost center]]>
	Public Property [CostCenter] As String
	'''<![CDATA[Description of CostCenter]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostCenterDescription] As String
	'''<![CDATA[Reference to a cost unit]]>
	Public Property [CostUnit] As String
	'''<![CDATA[Description of CostUnit]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostUnitDescription] As String
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	Public Property [Date] As DateTime?
	'''<![CDATA[Description]]>
	Public Property [Description] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Reference to a document]]>
	Public Property [Document] As Guid?
	'''<![CDATA[Number of Document]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DocumentNumber] As Int32?
	'''<![CDATA[Subject of Document]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DocumentSubject] As String
	'''<![CDATA[Reference to the header]]>
	Public Property [EntryID] As Guid?
	'''<![CDATA[Entry number of the header]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [EntryNumber] As Int32?
	'''<![CDATA[Exchange rate]]>
	Public Property [ExchangeRate] As Double?
	'''<![CDATA[General ledger account]]>
	Public Property [GLAccount] As Guid?
	'''<![CDATA[Code of GLAccount]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLAccountCode] As String
	'''<![CDATA[Description of GLAccount]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLAccountDescription] As String
	'''<![CDATA[Primary key]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ID] As Guid
	'''<![CDATA[Line number]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [LineNumber] As Int32?
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Extra remarks]]>
	Public Property [Notes] As String
	'''<![CDATA[Reference to offset line]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [OffsetID] As Guid?
	Public Property [OurRef] As Int32?
	'''<![CDATA[Reference to a project]]>
	Public Property [Project] As Guid?
	'''<![CDATA[Code of Project]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectCode] As String
	'''<![CDATA[Description of Project]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectDescription] As String
	'''<![CDATA[Quantity]]>
	Public Property [Quantity] As Double?
	'''<![CDATA[Reference to vat code]]>
	Public Property [VATCode] As String
	'''<![CDATA[Description of VATCode]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [VATCodeDescription] As String
	'''<![CDATA[Vat code percentage]]>
	Public Property [VATPercentage] As Double?
	'''<![CDATA[Type of vat code]]>
	Public Property [VATType] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class BatchNumber
	'''<![CDATA[Available quantity of this batch number]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AvailableQuantity] As Double?
	'''<![CDATA[Human readable batch number]]>
	Public Property [BatchNumber] As String
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Expiry date of effective period for batch number]]>
	Public Property [ExpiryDate] As DateTime?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Blocking state]]>
	Public Property [IsBlocked] As Byte?
	'''<![CDATA[Item]]>
	Public Property [Item] As Guid?
	'''<![CDATA[Item code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemCode] As String
	'''<![CDATA[Description of item]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemDescription] As String
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Remarks]]>
	Public Property [Remarks] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class Budget
	'''<![CDATA[Budget amount (always in the default currency of the company)]]>
	Public Property [AmountDC] As Double?
	'''<![CDATA[Budget scenario]]>
	Public Property [BudgetScenario] As Guid?
	'''<![CDATA[Code of BudgetScenario]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [BudgetScenarioCode] As String
	'''<![CDATA[Description of BudgetScenario]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [BudgetScenarioDescription] As String
	'''<![CDATA[Used for cost center-specific budgets - NULL otherwise]]>
	Public Property [Costcenter] As String
	'''<![CDATA[Description of Costcenter]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostcenterDescription] As String
	'''<![CDATA[Used for cost unit-specific budgets - NULL otherwise]]>
	Public Property [Costunit] As String
	'''<![CDATA[Description of Costunit]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostunitDescription] As String
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[G/L account]]>
	Public Property [GLAccount] As Guid?
	'''<![CDATA[Code of GLAccount]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLAccountCode] As String
	'''<![CDATA[Description of GLAccount]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLAccountDescription] As String
	'''<![CDATA[Numerical ID. Never displayed to the user, but it may have its use for performance reasons]]>
	Public Property [HID] As Int64?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Used for item-specific budgets - NULL otherwise]]>
	Public Property [Item] As Guid?
	'''<![CDATA[Code of Item]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemCode] As String
	'''<![CDATA[Description of Item]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemDescription] As String
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Period (combined with financial year)]]>
	Public Property [ReportingPeriod] As Int16?
	'''<![CDATA[Financial year]]>
	Public Property [ReportingYear] As Int16?
End Class

<SupportedActionsSDK(True, True, False, False)>
<DataServiceKey("EntryID")>
Public Class CashEntry
	'''<![CDATA[Collection of lines]]>
	Public Property [CashEntryLines] As IEnumerable(Of CashEntryLine)
	'''<![CDATA[Closing balance in the currency of the transaction]]>
	Public Property [ClosingBalanceFC] As Double?
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[Currency code]]>
	Public Property [Currency] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Primary key]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [EntryID] As Guid
	'''<![CDATA[Entry number]]>
	Public Property [EntryNumber] As Int32?
	'''<![CDATA[Fiancial period]]>
	Public Property [FinancialPeriod] As Int16?
	'''<![CDATA[Fiancial year]]>
	Public Property [FinancialYear] As Int16?
	'''<![CDATA[Code of Journal]]>
	Public Property [JournalCode] As String
	'''<![CDATA[Description of Journal]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [JournalDescription] As String
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[Opening balance in the currency of the transaction]]>
	Public Property [OpeningBalanceFC] As Double?
	'''<![CDATA[Status: 5 = Rejected, 20 = Open, 50 = Processed]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Status] As Int16?
	'''<![CDATA[Description of Status]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [StatusDescription] As String
End Class

<SupportedActionsSDK(True, True, False, False)>
<DataServiceKey("ID")>
Public Class CashEntryLine
	'''<![CDATA[Reference to Account]]>
	Public Property [Account] As Guid?
	'''<![CDATA[Code of Account]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountCode] As String
	'''<![CDATA[Name of Account]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountName] As String
	'''<![CDATA[Amount in the default currency of the company]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AmountDC] As Double?
	'''<![CDATA[Amount in the currency of the transaction]]>
	Public Property [AmountFC] As Double?
	'''<![CDATA[Vat amount in the currency of the transaction]]>
	Public Property [AmountVATFC] As Double?
	'''<![CDATA[Reference to an asset]]>
	Public Property [Asset] As Guid?
	'''<![CDATA[Code of Asset]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AssetCode] As String
	'''<![CDATA[Description of Asset]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AssetDescription] As String
	'''<![CDATA[Reference to a cost center]]>
	Public Property [CostCenter] As String
	'''<![CDATA[Description of CostCenter]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostCenterDescription] As String
	'''<![CDATA[Reference to a cost unit]]>
	Public Property [CostUnit] As String
	'''<![CDATA[Description of CostUnit]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostUnitDescription] As String
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	Public Property [Date] As DateTime?
	'''<![CDATA[Description]]>
	Public Property [Description] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Reference to a document]]>
	Public Property [Document] As Guid?
	'''<![CDATA[Number of Document]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DocumentNumber] As Int32?
	'''<![CDATA[Subject of Document]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DocumentSubject] As String
	'''<![CDATA[Reference to the header]]>
	Public Property [EntryID] As Guid?
	'''<![CDATA[Entry number of the header]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [EntryNumber] As Int32?
	'''<![CDATA[Exchange rate]]>
	Public Property [ExchangeRate] As Double?
	'''<![CDATA[General ledger account]]>
	Public Property [GLAccount] As Guid?
	'''<![CDATA[Code of GLAccount]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLAccountCode] As String
	'''<![CDATA[Description of GLAccount]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLAccountDescription] As String
	'''<![CDATA[Primary key]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ID] As Guid
	'''<![CDATA[Line number]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [LineNumber] As Int32?
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Extra remarks]]>
	Public Property [Notes] As String
	'''<![CDATA[Reference to offset line]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [OffsetID] As Guid?
	Public Property [OurRef] As Int32?
	'''<![CDATA[Reference to a project]]>
	Public Property [Project] As Guid?
	'''<![CDATA[Code of Project]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectCode] As String
	'''<![CDATA[Description of Project]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectDescription] As String
	'''<![CDATA[Quantity]]>
	Public Property [Quantity] As Double?
	'''<![CDATA[Reference to vat code]]>
	Public Property [VATCode] As String
	'''<![CDATA[Description of VATCode]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [VATCodeDescription] As String
	'''<![CDATA[Vat code percentage]]>
	Public Property [VATPercentage] As Double?
	'''<![CDATA[Type of vat code]]>
	Public Property [VATType] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class Contact
	'''<![CDATA[The account to which the contact belongs]]>
	Public Property [Account] As Guid?
	'''<![CDATA[Indicates if account is a customer]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountIsCustomer] As Boolean
	'''<![CDATA[Indicates if account is a supplier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountIsSupplier] As Boolean?
	'''<![CDATA[Reference to the main contact of the account]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountMainContact] As Guid?
	'''<![CDATA[Name of the account]]>
	Public Property [AccountName] As String
	'''<![CDATA[Second address line]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AddressLine2] As String
	'''<![CDATA[Street name of the address]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AddressStreet] As String
	'''<![CDATA[Street number of the address]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AddressStreetNumber] As String
	'''<![CDATA[Street number suffix of the address]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AddressStreetNumberSuffix] As String
	'''<![CDATA[Obsolete]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AllowMailing] As Int32?
	'''<![CDATA[Birth date]]>
	Public Property [BirthDate] As DateTime?
	'''<![CDATA[Last birth name]]>
	Public Property [BirthName] As String
	'''<![CDATA[Middle birth name]]>
	Public Property [BirthNamePrefix] As String
	'''<![CDATA[Birth place]]>
	Public Property [BirthPlace] As String
	'''<![CDATA[Email address of the contact]]>
	Public Property [BusinessEmail] As String
	'''<![CDATA[Fax of the contact]]>
	Public Property [BusinessFax] As String
	'''<![CDATA[Mobile of the contact]]>
	Public Property [BusinessMobile] As String
	'''<![CDATA[Phone of the contact]]>
	Public Property [BusinessPhone] As String
	'''<![CDATA[Phone extension of the contact]]>
	Public Property [BusinessPhoneExtension] As String
	'''<![CDATA[City]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [City] As String
	'''<![CDATA[Code of the account]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Code] As String
	'''<![CDATA[Country code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Country] As String
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of the creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of the creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Email address of the contact]]>
	Public Property [Email] As String
	'''<![CDATA[End date]]>
	Public Property [EndDate] As DateTime?
	'''<![CDATA[First name. Provide at least first name or last name to create a new contact]]>
	Public Property [FirstName] As String
	'''<![CDATA[Full name (First name Middle name Last name)]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [FullName] As String
	'''<![CDATA[Gender]]>
	Public Property [Gender] As String
	'''<![CDATA[Contact ID]]>
	Public Property [HID] As Int32?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Identification date]]>
	Public Property [IdentificationDate] As DateTime?
	'''<![CDATA[Reference to the identification document of the contact]]>
	Public Property [IdentificationDocument] As Guid?
	'''<![CDATA[Reference to the user responsible for identification]]>
	Public Property [IdentificationUser] As Guid?
	'''<![CDATA[Initials]]>
	Public Property [Initials] As String
	'''<![CDATA[Indicates whether contacts are excluded from the marketing list]]>
	Public Property [IsMailingExcluded] As Boolean?
	'''<![CDATA[Indicates if this is the main contact of the linked account]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [IsMainContact] As Boolean?
	'''<![CDATA[Jobtitle of the contact]]>
	Public Property [JobTitleDescription] As String
	'''<![CDATA[Language code]]>
	Public Property [Language] As String
	'''<![CDATA[Last name. Provide at least first name or last name to create a new contact]]>
	Public Property [LastName] As String
	'''<![CDATA[The user should be able to do a full text search on these notes to gather contacts for a marketing campaign]]>
	Public Property [MarketingNotes] As String
	'''<![CDATA[Middle name]]>
	Public Property [MiddleName] As String
	'''<![CDATA[Business phone of the contact]]>
	Public Property [Mobile] As String
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of the last modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Nationality]]>
	Public Property [Nationality] As String
	'''<![CDATA[Extra remarks]]>
	Public Property [Notes] As String
	'''<![CDATA[Last name of partner]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PartnerName] As String
	'''<![CDATA[Middlename of partner]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PartnerNamePrefix] As String
	'''<![CDATA[Reference to the personal information of this contact such as name, gender, address etc.]]>
	Public Property [Person] As Guid?
	'''<![CDATA[Phone of the contact]]>
	Public Property [Phone] As String
	'''<![CDATA[Phone extension of the contact]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PhoneExtension] As String
	'''<![CDATA[This field is write-only. The picture can be downloaded through PictureUrl and PictureThumbnailUrl.]]>
	Public Property [Picture] As Byte()
	'''<![CDATA[Filename of the picture]]>
	Public Property [PictureName] As String
	'''<![CDATA[Url to retrieve the picture thumbnail]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PictureThumbnailUrl] As String
	'''<![CDATA[Url to retrieve the picture]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PictureUrl] As String
	'''<![CDATA[Postcode]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Postcode] As String
	'''<![CDATA[Social security number]]>
	Public Property [SocialSecurityNumber] As String
	'''<![CDATA[Start date]]>
	Public Property [StartDate] As DateTime?
	'''<![CDATA[State]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [State] As String
	'''<![CDATA[Title]]>
	Public Property [Title] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class Costcenter
	'''<![CDATA[Indicates if the cost center is active: 0 = inactive 1 = active]]>
	Public Property [Active] As Boolean?
	'''<![CDATA[Code (user-defined ID)]]>
	Public Property [Code] As String
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Description (text)]]>
	Public Property [Description] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class CostTransaction
	'''<![CDATA[Account linked to the transaction]]>
	Public Property [Account] As Guid?
	'''<![CDATA[Name of Account]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountName] As String
	'''<![CDATA[Amount in the currency of the transaction]]>
	Public Property [Amount] As Double?
	'''<![CDATA[Amount of the transaction in the currency of the transaction]]>
	Public Property [AmountFC] As Double?
	'''<![CDATA[Attachment linked to the transaction (not mandatory)]]>
	Public Property [Attachment] As Guid?
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Currency of the amount]]>
	Public Property [Currency] As String
	'''<![CDATA[Date]]>
	Public Property [Date] As DateTime?
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Description of Division]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DivisionDescription] As String
	'''<![CDATA[Employee linked to the transaction]]>
	Public Property [Employee] As Guid?
	'''<![CDATA[Entrynumber]]>
	Public Property [EntryNumber] As Int32?
	'''<![CDATA[Errortext, used for the backgroundjobs]]>
	Public Property [ErrorText] As String
	Public Property [Expense] As Guid?
	'''<![CDATA[Description of ProjectWBS]]>
	Public Property [ExpenseDescription] As String
	'''<![CDATA[Status of the transaction]]>
	Public Property [HourStatus] As Int16?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Item linked to the transaction. Items of type 'time' are linked to time transactionsItems of other types are linked to costtransactions]]>
	Public Property [Item] As Guid?
	'''<![CDATA[Description of Item]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemDescription] As String
	'''<![CDATA[Indicates if fractional quantities of the item can be used, for example quantity = 0.4]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemDivisable] As Boolean?
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Notes linked to the transaction (not mandatory)]]>
	Public Property [Notes] As String
	'''<![CDATA[Price in the currency of the transaction]]>
	Public Property [Price] As Double?
	'''<![CDATA[PriceFC (AmountFC = Quantity * PriceFC)]]>
	Public Property [PriceFC] As Double?
	'''<![CDATA[Project linked to the transaction]]>
	Public Property [Project] As Guid?
	'''<![CDATA[Project account linked to the transaction (not mandatory)]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectAccount] As Guid?
	'''<![CDATA[Project account code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectAccountCode] As String
	'''<![CDATA[Project account name]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectAccountName] As String
	'''<![CDATA[Description of Project]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectDescription] As String
	'''<![CDATA[Quantity of the transaction]]>
	Public Property [Quantity] As Double?
	'''<![CDATA[Subscription linked to the transaction]]>
	Public Property [Subscription] As Guid?
	'''<![CDATA[Account linked to the subscription]]>
	Public Property [SubscriptionAccount] As Guid?
	'''<![CDATA[Subscription account code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SubscriptionAccountCode] As String
	'''<![CDATA[Subscription account name]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SubscriptionAccountName] As String
	'''<![CDATA[Description of the subscription]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SubscriptionDescription] As String
	'''<![CDATA[Subscription number]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SubscriptionNumber] As Int32?
	'''<![CDATA[Type of the transaction]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Type] As Int16?
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class Costunit
	'''<![CDATA[Code (user-defined)]]>
	Public Property [Code] As String
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Description (text)]]>
	Public Property [Description] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("Code")>
Public Class Currency
	'''<![CDATA[Amount precision]]>
	Public Property [AmountPrecision] As Double
	'''<![CDATA[Primary key]]>
	Public Property [Code] As String
	'''<![CDATA[Creation date]]>
	Public Property [Created] As DateTime?
	'''<![CDATA[Description of the currency]]>
	Public Property [Description] As String
	'''<![CDATA[Last modified date]]>
	Public Property [Modified] As DateTime?
	'''<![CDATA[Price precision]]>
	Public Property [PricePrecision] As Double
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class Department
	'''<![CDATA[Department Code]]>
	Public Property [Code] As String
	'''<![CDATA[Cost center Code]]>
	Public Property [Costcenter] As String
	'''<![CDATA[Cost center description]]>
	Public Property [CostcenterDescription] As String
	'''<![CDATA[Creation date]]>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Department description]]>
	Public Property [Description] As String
	'''<![CDATA[Division code]]>
	Public Property [Division] As Int32?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Last modified date]]>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Explanation or extra information can be stored in the notes]]>
	Public Property [Notes] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class DepreciationMethod
	'''<![CDATA[When the method is fixed amount, this is the periodic depreciation amount]]>
	Public Property [Amount] As Double?
	'''<![CDATA[Code of the depreciation method]]>
	Public Property [Code] As String
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Describes the periodic interval]]>
	Public Property [DepreciationInterval] As String
	'''<![CDATA[Description of the method]]>
	Public Property [Description] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Indicates the maximum value when using depreciation type degressive to linear]]>
	Public Property [MaxPercentage] As Double?
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Degressive percentage for methods: 10 - Degressive to linear, 11 - Degressive (fixed perc. of book value), 12 - Degressive to linear (Belgium & Luxembourg only). And interest percentage for method: 40 - Normal annuity method. On import: Can not be modified if depreciation method is already linked to an asset. For Belgium & Luxembourg the degressive percentage is calculated as double of the linear percentage]]>
	Public Property [Percentage] As Double?
	'''<![CDATA[Linear percentage for methods: 10 - Degressive to linear, 3 - Linear depreciation (Belgium & Luxembourg only), 12 - Degressive to linear (Belgium & Luxembourg only). On import: Can not be modified if depreciation method is already linked to an asset]]>
	Public Property [Percentage2] As Double?
	'''<![CDATA[The total number of periods for the depreciation method. Used in combination with depreciation interval: only used when interval is periodic]]>
	Public Property [Periods] As Int16?
	'''<![CDATA[The actual type of deprecation, such as lineair or degressive. The periodic amounts are based on this type, in combination with other fields, such as the interval and the periods]]>
	Public Property [Type] As Int32?
	'''<![CDATA[Description of Type]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [TypeDescription] As String
	'''<![CDATA[Determines the total number of years for the depreciation method. Used in combination with depreciation interval: only used when interval is yearly]]>
	Public Property [Years] As Int16?
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class DirectDebitMandate
	'''<![CDATA[Account the mandate belongs to]]>
	Public Property [Account] As Guid?
	'''<![CDATA[Bank account the mandate applies to]]>
	Public Property [BankAccount] As Guid?
	'''<![CDATA[Cancellation date]]>
	Public Property [CancellationDate] As DateTime?
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Description]]>
	Public Property [Description] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Indicates the first collection hasn't been sent/confirmed with this mandate.]]>
	Public Property [FirstSend] As Byte?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Payment type. 0 = one-off payment, 1 = recurrent payment, 2 = AdHoc (UK only)]]>
	Public Property [PaymentType] As Int16?
	'''<![CDATA[Reference]]>
	Public Property [Reference] As String
	'''<![CDATA[Signature date]]>
	Public Property [SignatureDate] As DateTime?
	'''<![CDATA[Type. 0 = core, 1 = B2B and 2 = bottomline (UK only)]]>
	Public Property [Type] As Int16?
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("Code")>
Public Class Division
	'''<![CDATA[Values: 0 = Not blocked 1 = Backup 2 = Conversion busy 3 = Conversion shadow 4 = Conversion waiting 5 = Copy data waiting 6 = Copy data buzy 100 = Wait for deletion 101 = Deleted 102 = Deletion failed]]>
	Public Property [BlockingStatus] As Int32?
	'''<![CDATA[Primary key]]>
	Public Property [Code] As Int32
	'''<![CDATA[Country of the division. Is used for determination of legislation]]>
	Public Property [Country] As String
	'''<![CDATA[Description of Country]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CountryDescription] As String
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of the creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Default currency of the division]]>
	Public Property [Currency] As String
	'''<![CDATA[Description of Currency]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CurrencyDescription] As String
	'''<![CDATA[Owner account of the division]]>
	Public Property [Customer] As Guid?
	'''<![CDATA[Owner account code of the division]]>
	Public Property [CustomerCode] As String
	'''<![CDATA[Owner account name of the division]]>
	Public Property [CustomerName] As String
	'''<![CDATA[Description]]>
	Public Property [Description] As String
	'''<![CDATA[Number that customers give to the division]]>
	Public Property [HID] As Int64?
	'''<![CDATA[True for the main (hosting) division]]>
	Public Property [Main] As Boolean?
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of the last modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Siret Number of the division (France)]]>
	Public Property [SiretNumber] As String
	'''<![CDATA[Date on which the division becomes active]]>
	Public Property [StartDate] As DateTime?
	'''<![CDATA[Regular administrations will have status 0.  Currently, the only other possibility is 'archived' (1), which means the administration is not actively used, but still needs to be accessible for the customer/accountant to meet legal obligations]]>
	Public Property [Status] As Int16?
	'''<![CDATA[Number of your local tax authority (Germany)]]>
	Public Property [TaxOfficeNumber] As String
	'''<![CDATA[Local tax reference number (Germany)]]>
	Public Property [TaxReferenceNumber] As String
	'''<![CDATA[VAT number]]>
	Public Property [VATNumber] As String
	'''<![CDATA[Customer value, hyperlink to external website]]>
	Public Property [Website] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class Document
	'''<![CDATA[ID of the related account of this document]]>
	Public Property [Account] As Guid?
	'''<![CDATA[Code of Account]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountCode] As String
	'''<![CDATA[Name of Account]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountName] As String
	'''<![CDATA[Amount in the currency of the transaction]]>
	Public Property [AmountFC] As Double?
	'''<![CDATA[Body of this document]]>
	Public Property [Body] As String
	'''<![CDATA[ID of the category of this document]]>
	Public Property [Category] As Guid?
	'''<![CDATA[Description of Category]]>
	Public Property [CategoryDescription] As String
	'''<![CDATA[ID of the related contact of this document]]>
	Public Property [Contact] As Guid?
	'''<![CDATA[Contact full name]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ContactFullName] As String
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Currency code]]>
	Public Property [Currency] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32
	'''<![CDATA[Entry date of the incoming document]]>
	Public Property [DocumentDate] As DateTime?
	'''<![CDATA[The Id of document folder]]>
	Public Property [DocumentFolder] As Guid?
	'''<![CDATA[The Code of document folder]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DocumentFolderCode] As String
	'''<![CDATA[The Decsription of document folder]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DocumentFolderDescription] As String
	'''<![CDATA[Url to view the document]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DocumentViewUrl] As String
	'''<![CDATA[Reference to the financial transaction]]>
	Public Property [FinancialTransactionEntryID] As Guid?
	'''<![CDATA[Indicates that the document body is empty]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [HasEmptyBody] As Boolean
	'''<![CDATA[Human-readable ID, formatted as xx.xxx.xxx. Unique. May not be equal to zero]]>
	Public Property [HID] As Int32?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[The language code of the document]]>
	Public Property [Language] As String
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[The opportunity linked to the document]]>
	Public Property [Opportunity] As Guid?
	'''<![CDATA[The project linked to the document]]>
	Public Property [Project] As Guid?
	'''<![CDATA[Code of project]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectCode] As String
	'''<![CDATA[Description of project]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectDescription] As String
	'''<![CDATA['Our reference' of the transaction that belongs to this document]]>
	Public Property [SalesInvoiceNumber] As Int32?
	'''<![CDATA[Number of the sales order]]>
	Public Property [SalesOrderNumber] As Int32?
	'''<![CDATA[Number of the shop order]]>
	Public Property [ShopOrderNumber] As Int32?
	'''<![CDATA[Subject of this document]]>
	Public Property [Subject] As String
	'''<![CDATA[ID of the type of this document]]>
	Public Property [Type] As Int32?
	'''<![CDATA[Description of Type]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [TypeDescription] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class CRMDocument
	'''<![CDATA[Primary key]]>cd
	Public Property [ID] As Guid

	'''<![CDATA[ID of the related account of this document]]>
	Public Property [Account] As Guid?

	'''<![CDATA[Attachments linked to the document]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Attachments] As IEnumerable(Of DocumentAttachment)

	'''<![CDATA[Creation date]]>
	Public Property [Created] As DateTime?

	'''<![CDATA[User ID of creator]]>
	Public Property [Creator] As Guid?

	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String

	'''<![CDATA[Division code]]>
	Public Property [Division] As Int32?

	'''<![CDATA[Entry date of the incoming document]]>
	Public Property [DocumentDate] As DateTime?

	'''<![CDATA[Id of document folder]]>
	Public Property [DocumentFolder] As Guid?

	'''<![CDATA[Url to view the document]]>
	Public Property [DocumentViewUrl] As String

	'''<![CDATA[Indicates that the document body is empty]]>
	Public Property [HasEmptyBody] As Boolean?

	'''<![CDATA[Human-readable ID, formatted as xx.xxx.xxx. Unique. May not be equal to zero]]>
	Public Property [HID] As Int32?

	'''<![CDATA[Last modified date]]>
	Public Property [Modified] As DateTime?

	'''<![CDATA[User ID of modifier]]>
	Public Property [Modifier] As Guid?

	'''<![CDATA[The opportunity linked to the document]]>
	Public Property [Opportunity] As Guid?

	'''<![CDATA[Purchase invoice number.]]>
	Public Property [PurchaseInvoiceNumber] As Int32?

	'''<![CDATA[Purchase order number.]]>
	Public Property [PurchaseOrderNumber] As Int32?

	'''<![CDATA['Our reference' of the transaction that belongs to this document]]>
	Public Property [SalesInvoiceNumber] As Int32?

	'''<![CDATA[Number of the sales order]]>
	Public Property [SalesOrderNumber] As Int32?

	'''<![CDATA[Send Method]]>
	Public Property [SendMethod] As Int32?

	'''<![CDATA[Subject of this document]]>
	Public Property [Subject] As String

	'''<![CDATA[The document type]]>
	Public Property [Type] As Int32?

	'''<![CDATA[Translated description of the document type. $filter and $orderby are not supported for this property.]]>
	Public Property [TypeDescription] As String

End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class DocumentAttachment
	'''<![CDATA[Contains the attachment]]>
	Public Property [Attachment] As Byte()
	'''<![CDATA[Reference to the Document]]>
	Public Property [Document] As Guid
	'''<![CDATA[Filename of the attachment]]>
	Public Property [FileName] As String
	'''<![CDATA[File size of the attachment]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [FileSize] As Double
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Url of the attachment]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Url] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class DocumentCategory
	'''<![CDATA[Creation date]]>
	Public Property [Created] As DateTime?
	'''<![CDATA[Document category description]]>
	Public Property [Description] As String
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Last modified date]]>
	Public Property [Modified] As DateTime?
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class DocumentFolder
	'''<![CDATA[Document folder code]]>
	Public Property [Code] As String
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Document folder description]]>
	Public Property [Description] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Document folder parent folder ID]]>
	Public Property [ParentFolder] As Guid?
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class DocumentType
	'''<![CDATA[Creation date]]>
	Public Property [Created] As DateTime?
	'''<![CDATA[Document type description]]>
	Public Property [Description] As String
	'''<![CDATA[Indicates if documents of this type can be created]]>
	Public Property [DocumentIsCreatable] As Boolean
	'''<![CDATA[Indicates if documents of this type can be deleted]]>
	Public Property [DocumentIsDeletable] As Boolean
	'''<![CDATA[Indicates if documents of this type can be updated]]>
	Public Property [DocumentIsUpdatable] As Boolean
	'''<![CDATA[Indicates if documents of this type can be retrieved]]>
	Public Property [DocumentIsViewable] As Boolean
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Int32
	'''<![CDATA[Last modified date]]>
	Public Property [Modified] As DateTime?
	'''<![CDATA[ID of the document type category]]>
	Public Property [TypeCategory] As Int32?
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class DocumentTypeCategory
	'''<![CDATA[Creation date]]>
	Public Property [Created] As DateTime?
	'''<![CDATA[Document category type description]]>
	Public Property [Description] As String
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Int32
	'''<![CDATA[Last modified date]]>
	Public Property [Modified] As DateTime?
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class DocumentTypeFolder
	'''<![CDATA[Date created]]>
	Public Property [Created] As DateTime
	'''<![CDATA[User id of creator]]>
	Public Property [Creator] As Guid?
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32
	'''<![CDATA[Folder to which document type is linked]]>
	Public Property [DocumentFolder] As Guid
	'''<![CDATA[Code of document type which is linked to folder]]>
	Public Property [DocumentType] As Int32
	Public Property [ID] As Guid
	'''<![CDATA[Date Modified]]>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User id of modifier]]>
	Public Property [Modifier] As Guid?
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class Employee
	'''<![CDATA[Obsolete]]>
	Public Property [ActiveEmployment] As Byte?
	'''<![CDATA[Second address line]]>
	Public Property [AddressLine2] As String
	'''<![CDATA[Third address line]]>
	Public Property [AddressLine3] As String
	'''<![CDATA[Street of address]]>
	Public Property [AddressStreet] As String
	'''<![CDATA[Street number of address]]>
	Public Property [AddressStreetNumber] As String
	'''<![CDATA[Street number suffix of address]]>
	Public Property [AddressStreetNumberSuffix] As String
	'''<![CDATA[Birth date]]>
	Public Property [BirthDate] As DateTime?
	'''<![CDATA[Birth name]]>
	Public Property [BirthName] As String
	'''<![CDATA[Birth middle name]]>
	Public Property [BirthNamePrefix] As String
	'''<![CDATA[Birth place]]>
	Public Property [BirthPlace] As String
	'''<![CDATA[Email of the employee at the office]]>
	Public Property [BusinessEmail] As String
	'''<![CDATA[Fax number of the employee at the office]]>
	Public Property [BusinessFax] As String
	'''<![CDATA[Office mobile number of the employee]]>
	Public Property [BusinessMobile] As String
	'''<![CDATA[Phone number of the employee at the office]]>
	Public Property [BusinessPhone] As String
	'''<![CDATA[Phone extension of the employee at the office]]>
	Public Property [BusinessPhoneExtension] As String
	'''<![CDATA[Obsolete]]>
	Public Property [CASONumber] As String
	'''<![CDATA[City]]>
	Public Property [City] As String
	'''<![CDATA[Code of the employee]]>
	Public Property [Code] As String
	'''<![CDATA[Country code]]>
	Public Property [Country] As String
	'''<![CDATA[Creation date]]>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Customer ID]]>
	Public Property [Customer] As Guid?
	'''<![CDATA[Division code]]>
	Public Property [Division] As Int32?
	'''<![CDATA[Email address]]>
	Public Property [Email] As String
	'''<![CDATA[Employee number]]>
	Public Property [EmployeeHID] As Int32?
	'''<![CDATA[End date of the employee]]>
	Public Property [EndDate] As DateTime?
	'''<![CDATA[First name of the employee]]>
	Public Property [FirstName] As String
	'''<![CDATA[Full name of the employee]]>
	Public Property [FullName] As String
	'''<![CDATA[Gender]]>
	Public Property [Gender] As String
	'''<![CDATA[Numeric ID of the employee]]>
	Public Property [HID] As Int32?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Initials]]>
	Public Property [Initials] As String
	'''<![CDATA[IsActive]]>
	Public Property [IsActive] As Boolean
	'''<![CDATA[Language code]]>
	Public Property [Language] As String
	'''<![CDATA[Last name]]>
	Public Property [LastName] As String
	'''<![CDATA[Description of the location of the employee (where am I?)]]>
	Public Property [LocationDescription] As String
	'''<![CDATA[Direct manager of the employee]]>
	Public Property [Manager] As Guid?
	'''<![CDATA[Date of marriage]]>
	Public Property [MaritalDate] As DateTime?
	'''<![CDATA[Marital status]]>
	Public Property [MaritalStatus] As Int16?
	'''<![CDATA[Middle name]]>
	Public Property [MiddleName] As String
	'''<![CDATA[Mobile phone]]>
	Public Property [Mobile] As String
	'''<![CDATA[Last modified date]]>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Municipality]]>
	Public Property [Municipality] As String
	Public Property [NameComposition] As Int16?
	'''<![CDATA[Nationality]]>
	Public Property [Nationality] As String
	'''<![CDATA[Nick name]]>
	Public Property [NickName] As String
	'''<![CDATA[Additional notes]]>
	Public Property [Notes] As String
	'''<![CDATA[Name of partner]]>
	Public Property [PartnerName] As String
	'''<![CDATA[Middle name of partner]]>
	Public Property [PartnerNamePrefix] As String
	'''<![CDATA[Reference to the persons table in which the personal data of the employee is stored]]>
	Public Property [Person] As Guid?
	'''<![CDATA[Phone number]]>
	Public Property [Phone] As String
	'''<![CDATA[Phone number extension]]>
	Public Property [PhoneExtension] As String
	'''<![CDATA[Filename of picture]]>
	Public Property [PictureFileName] As String
	'''<![CDATA[Url of picture]]>
	Public Property [PictureUrl] As String
	'''<![CDATA[Postcode]]>
	Public Property [Postcode] As String
	'''<![CDATA[Private email address]]>
	Public Property [PrivateEmail] As String
	'''<![CDATA[Social security number]]>
	Public Property [SocialSecurityNumber] As String
	'''<![CDATA[Start date of the employee]]>
	Public Property [StartDate] As DateTime?
	'''<![CDATA[State]]>
	Public Property [State] As String
	'''<![CDATA[Title]]>
	Public Property [Title] As String
	'''<![CDATA[User ID of employee]]>
	Public Property [User] As Guid?
	'''<![CDATA[Name of user]]>
	Public Property [UserFullName] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class Employment
	'''<![CDATA[Creation date]]>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Division code]]>
	Public Property [Division] As Int32?
	'''<![CDATA[Employee ID]]>
	Public Property [Employee] As Guid?
	'''<![CDATA[Name of employee]]>
	Public Property [EmployeeFullName] As String
	'''<![CDATA[Numeric number of Employee]]>
	Public Property [EmployeeHID] As Int32?
	'''<![CDATA[End date of employment]]>
	Public Property [EndDate] As DateTime?
	'''<![CDATA[Numeric ID of the employment]]>
	Public Property [HID] As Int32?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Last modified date]]>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	Public Property [ModifierFullName] As String
	'''<![CDATA[ID of employment ended]]>
	Public Property [ReasonEnd] As Int32?
	'''<![CDATA[Reason of end of employment]]>
	Public Property [ReasonEndDescription] As String
	'''<![CDATA[Reason of ended flexible employment]]>
	Public Property [ReasonEndFlex] As Int32?
	'''<![CDATA[Other reason for end of employment]]>
	Public Property [ReasonEndFlexDescription] As String
	'''<![CDATA[Start date of employment]]>
	Public Property [StartDate] As DateTime?
	'''<![CDATA[Start date of the employee in the organization. This field is used to count the years in service.]]>
	Public Property [StartDateOrganization] As DateTime?
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class EmploymentContract
	'''<![CDATA[Flexible employment contract phase]]>
	Public Property [ContractFlexPhase] As Int32?
	'''<![CDATA[Flexible employment contract phase description.]]>
	Public Property [ContractFlexPhaseDescription] As String
	'''<![CDATA[Creation date]]>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Division code]]>
	Public Property [Division] As Int32?
	'''<![CDATA[Document ID of the employment contract]]>
	Public Property [Document] As Guid?
	'''<![CDATA[ID of employee]]>
	Public Property [Employee] As Guid?
	'''<![CDATA[Name of employee]]>
	Public Property [EmployeeFullName] As String
	'''<![CDATA[Numeric ID of the employee]]>
	Public Property [EmployeeHID] As Int32?
	'''<![CDATA[Type of employee. 1 - Employee, 2 - Contractor, 3 - Temporary, 4 - Student, 5 - Flexworker]]>
	Public Property [EmployeeType] As Int32?
	'''<![CDATA[Employee type description]]>
	Public Property [EmployeeTypeDescription] As String
	'''<![CDATA[Employment ID]]>
	Public Property [Employment] As Guid?
	'''<![CDATA[Numeric ID of the employment]]>
	Public Property [EmploymentHID] As Int32?
	'''<![CDATA[End date of employment contract]]>
	Public Property [EndDate] As DateTime?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Last modified date]]>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Notes of employment contract]]>
	Public Property [Notes] As String
	'''<![CDATA[Employment probation end date]]>
	Public Property [ProbationEndDate] As DateTime?
	'''<![CDATA[Employment probation period]]>
	Public Property [ProbationPeriod] As Int32?
	'''<![CDATA[Employment contract reason code. 1 - New employment, 2 - Employment change, 3 - New legal employer, 4 - Acquisition 5 - Previous contract expired, 6 - Other]]>
	Public Property [ReasonContract] As Int32?
	'''<![CDATA[Employment contract reason description]]>
	Public Property [ReasonContractDescription] As String
	'''<![CDATA[Sequence number]]>
	Public Property [Sequence] As Int32?
	'''<![CDATA[Start date of employment contract]]>
	Public Property [StartDate] As DateTime?
	'''<![CDATA[Type of employment contract. 1 - Definite, 2 - Indefinite, 3 - External]]>
	Public Property [Type] As Int32?
	'''<![CDATA[Description of employment contract type]]>
	Public Property [TypeDescription] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class EmploymentContractFlexPhase
	'''<![CDATA[Flexible employment contract phase description]]>
	Public Property [Description] As String
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Int32
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class EmploymentEndReason
	'''<![CDATA[Employment end reason description]]>
	Public Property [Description] As String
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Int32
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class EmploymentOrganization
	'''<![CDATA[Cost center code]]>
	Public Property [CostCenter] As String
	'''<![CDATA[Description of cost center]]>
	Public Property [CostCenterDescription] As String
	'''<![CDATA[Cost unit code]]>
	Public Property [CostUnit] As String
	'''<![CDATA[Description of cost unit]]>
	Public Property [CostUnitDescription] As String
	'''<![CDATA[Creation date]]>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	Public Property [CreatorFullName] As String
	'''<![CDATA[ID of department]]>
	Public Property [Department] As Guid?
	'''<![CDATA[Department code]]>
	Public Property [DepartmentCode] As String
	'''<![CDATA[Department description for organization]]>
	Public Property [DepartmentDescription] As String
	'''<![CDATA[Division code]]>
	Public Property [Division] As Int32?
	'''<![CDATA[ID of employee]]>
	Public Property [Employee] As Guid?
	'''<![CDATA[Name of employee]]>
	Public Property [EmployeeFullName] As String
	'''<![CDATA[Numeric ID of the employee]]>
	Public Property [EmployeeHID] As Int32?
	'''<![CDATA[Employement ID]]>
	Public Property [Employment] As Guid?
	'''<![CDATA[Numeric ID of the employment]]>
	Public Property [EmploymentHID] As Int32?
	'''<![CDATA[Organization end date]]>
	Public Property [EndDate] As DateTime?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[ID of job title]]>
	Public Property [JobTitle] As Guid?
	'''<![CDATA[Job title code]]>
	Public Property [JobTitleCode] As String
	'''<![CDATA[Job title description]]>
	Public Property [JobTitleDescription] As String
	'''<![CDATA[Last modified date]]>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Explanation or extra information can be stored in the notes]]>
	Public Property [Notes] As String
	'''<![CDATA[Organization start date]]>
	Public Property [StartDate] As DateTime?
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class EmploymentSalary
	'''<![CDATA[The average number of contract days that an employee works per week]]>
	Public Property [AverageDaysPerWeek] As Double?
	'''<![CDATA[The average number of contract hours that an employee works per week]]>
	Public Property [AverageHoursPerWeek] As Double?
	'''<![CDATA[Creation date]]>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Division code]]>
	Public Property [Division] As Int32?
	'''<![CDATA[Employee ID]]>
	Public Property [Employee] As Guid?
	'''<![CDATA[Name of employee]]>
	Public Property [EmployeeFullName] As String
	'''<![CDATA[Employee number]]>
	Public Property [EmployeeHID] As Int32?
	'''<![CDATA[Employment]]>
	Public Property [Employment] As Guid?
	'''<![CDATA[Employment number]]>
	Public Property [EmploymentHID] As Int32?
	'''<![CDATA[Salary type of employment. 1 - Periodical (fixed), 2 - Per hour (variable)]]>
	Public Property [EmploymentSalaryType] As Int32?
	'''<![CDATA[Salary type description]]>
	Public Property [EmploymentSalaryTypeDescription] As String
	'''<![CDATA[Salary record end date]]>
	Public Property [EndDate] As DateTime?
	'''<![CDATA[Salary when working fulltime]]>
	Public Property [FulltimeAmount] As Double?
	'''<![CDATA[Hourly wage]]>
	Public Property [HourlyWage] As Double?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Internal rate for time & billing or professional service user]]>
	Public Property [InternalRate] As Double?
	'''<![CDATA[Employee job level in context of a wage scale]]>
	Public Property [JobLevel] As Int32?
	'''<![CDATA[Last modified date]]>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Salary when working parttime]]>
	Public Property [ParttimeAmount] As Double?
	'''<![CDATA[Contract hours / Fulltime contract hours]]>
	Public Property [ParttimeFactor] As Double?
	'''<![CDATA[Employee wage scale]]>
	Public Property [Scale] As String
	'''<![CDATA[Employment schedule]]>
	Public Property [Schedule] As Guid?
	'''<![CDATA[Employment schedule code]]>
	Public Property [ScheduleCode] As String
	'''<![CDATA[Description of employment schedule]]>
	Public Property [ScheduleDescription] As String
	'''<![CDATA[Salary record start date]]>
	Public Property [StartDate] As DateTime?
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class ExchangeRate
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[The exchange rate is stored as 1 TARGET CURRENCY = x SOURCE CURRENCY]]>
	Public Property [Rate] As Double?
	'''<![CDATA[The foreign currency]]>
	Public Property [SourceCurrency] As String
	'''<![CDATA[Description of SourceCurrency]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SourceCurrencyDescription] As String
	'''<![CDATA[The date as of which the rate is valid. The rate is valid until a next rate is defined]]>
	Public Property [StartDate] As DateTime?
	'''<![CDATA[The default currency of the division]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [TargetCurrency] As String
	'''<![CDATA[Description of TargetCurrency]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [TargetCurrencyDescription] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class FinancialPeriod
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[The end date of the period]]>
	Public Property [EndDate] As DateTime?
	'''<![CDATA[The financial period. Usually the period is a month or quarter with period 1 starting on the first of January.]]>
	Public Property [FinPeriod] As Int16?
	'''<![CDATA[The financial year. The financial year and calendar year are not always aligned.]]>
	Public Property [FinYear] As Int16?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[The start date of a period. A start date should always succeed a previous end date. Except for the first year/period combination]]>
	Public Property [StartDate] As DateTime?
End Class

<SupportedActionsSDK(True, True, False, False)>
<DataServiceKey("EntryID")>
Public Class GeneralJournalEntry
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[Currency code]]>
	Public Property [Currency] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Primary key]]>
	Public Property [EntryID] As Guid
	'''<![CDATA[Entry number]]>
	Public Property [EntryNumber] As Int32?
	'''<![CDATA[Exchange rate]]>
	Public Property [ExchangeRate] As Double?
	'''<![CDATA[Financial period]]>
	Public Property [FinancialPeriod] As Int16?
	'''<![CDATA[Financial year]]>
	Public Property [FinancialYear] As Int16?
	'''<![CDATA[Collection of lines]]>
	Public Property [GeneralJournalEntryLines] As IEnumerable(Of GeneralJournalEntryLine)
	'''<![CDATA[Code of Journal]]>
	Public Property [JournalCode] As String
	'''<![CDATA[Description of Journal]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [JournalDescription] As String
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[Indicates that amounts are reversed]]>
	Public Property [Reversal] As Boolean?
	'''<![CDATA[Status: 5 = Rejected, 20 = Open, 50 = Processed]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Status] As Int16?
	'''<![CDATA[Description of Status]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [StatusDescription] As String
	'''<![CDATA[Type: 10 = Opening balance, 90 = Other]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Type] As Int32?
	'''<![CDATA[Description of Type]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [TypeDescription] As String
End Class

<SupportedActionsSDK(True, True, False, False)>
<DataServiceKey("ID")>
Public Class GeneralJournalEntryLine
	'''<![CDATA[Reference to account]]>
	Public Property [Account] As Guid?
	'''<![CDATA[Code of Account]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountCode] As String
	'''<![CDATA[Name of Account]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountName] As String
	'''<![CDATA[Amount in the default currency of the company, If an 'Including' VAT code is used this amount includes the VAT amount.]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AmountDC] As Double?
	'''<![CDATA[Amount in the currency of the transaction. If an 'Including' VAT code is used this amount includes the VAT amount.]]>
	Public Property [AmountFC] As Double?
	'''<![CDATA[Vat amount in the default currency of the company.]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AmountVATDC] As Double?
	'''<![CDATA[Vat amount in the currency of the transaction. If you want to set this in a POST you have to specify VATCode as well.]]>
	Public Property [AmountVATFC] As Double?
	'''<![CDATA[Reference to asset]]>
	Public Property [Asset] As Guid?
	'''<![CDATA[Code of Asset]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AssetCode] As String
	'''<![CDATA[Description of Asset]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AssetDescription] As String
	'''<![CDATA[Reference to cost center]]>
	Public Property [CostCenter] As String
	'''<![CDATA[Description of CostCenter]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostCenterDescription] As String
	'''<![CDATA[Reference to cost unit]]>
	Public Property [CostUnit] As String
	'''<![CDATA[Description of CostUnit]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostUnitDescription] As String
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Entry date]]>
	Public Property [Date] As DateTime?
	'''<![CDATA[Description]]>
	Public Property [Description] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Reference to document]]>
	Public Property [Document] As Guid?
	'''<![CDATA[Document number]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DocumentNumber] As Int32?
	'''<![CDATA[Document subject]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DocumentSubject] As String
	'''<![CDATA[Reference to header of the entry]]>
	Public Property [EntryID] As Guid?
	'''<![CDATA[Entry number of the header]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [EntryNumber] As Int32?
	'''<![CDATA[General ledger account]]>
	Public Property [GLAccount] As Guid?
	'''<![CDATA[Code of GLAccount]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLAccountCode] As String
	'''<![CDATA[Description of GLAccount]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLAccountDescription] As String
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Line number]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [LineNumber] As Int32?
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Extra remarks]]>
	Public Property [Notes] As String
	Public Property [OffsetID] As Guid?
	'''<![CDATA[Our ref of general journal entry]]>
	Public Property [OurRef] As Int32?
	'''<![CDATA[Reference to project]]>
	Public Property [Project] As Guid?
	'''<![CDATA[Code of Project]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectCode] As String
	'''<![CDATA[Description of Project]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectDescription] As String
	'''<![CDATA[Quantity]]>
	Public Property [Quantity] As Double?
	'''<![CDATA[VAT base amount in the default currency of the company]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [VATBaseAmountDC] As Double?
	'''<![CDATA[VAT base amount in the currency of the transaction]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [VATBaseAmountFC] As Double?
	'''<![CDATA[VATCode can only be used if the general journal has VAT enabled. VAT Lines will be automatically created if the VATCode is specified when creating a new general journal entry.]]>
	Public Property [VATCode] As String
	'''<![CDATA[Description of VATCode]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [VATCodeDescription] As String
	'''<![CDATA[Vat percentage]]>
	Public Property [VATPercentage] As Double?
	'''<![CDATA[The VAT type determines what the values are in relation to VAT returns. The following values are supported:<br>A Sales VAT to pay,<br>D Credit note extra duty to claim,<br>I Purchase basis,<br>M Credit note purchase non-deductible,<br>N Purchase non-deductible,<br>O Purchase VAT to claim,<br>P Purchase VAT to pay,<br>Q Credit note purchase VAT to claim,<br>R Extra duty to pay,<br>S No VAT,<br>V Sales basis,<br>W Credit note purchase basis,<br>X Credit note sales basis,<br>Y Credit note purchase VAT to pay,<br>Z Credit note sales VAT to claim]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [VATType] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class GLAccount
	'''<![CDATA[AssimilatedVATBox (France)]]>
	Public Property [AssimilatedVATBox] As Int16?
	'''<![CDATA[The following values are supported: D (Debit) C (Credit)]]>
	Public Property [BalanceSide] As String
	'''<![CDATA[The following values are supported: B (Balance Sheet) W (Profit & Loss)]]>
	Public Property [BalanceType] As String
	'''<![CDATA[Indentify the kind of rewarding for the GL account. This is used in the official document for the fiscal fiches Belcotax]]>
	Public Property [BelcotaxType] As Int32?
	'''<![CDATA[Unique Code of the G/L Account]]>
	Public Property [Code] As String
	'''<![CDATA[Indicate if this GL account should be shown as compressed without the details in the CRW report of GL history]]>
	Public Property [Compress] As Boolean?
	'''<![CDATA[Cost Center linked to the G/L Account]]>
	Public Property [Costcenter] As String
	'''<![CDATA[Description of Costcenter]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostcenterDescription] As String
	'''<![CDATA[Cost Unit linked to the G/L Account]]>
	Public Property [Costunit] As String
	'''<![CDATA[Description of Costunit]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostunitDescription] As String
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Name of the G/L Account]]>
	Public Property [Description] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32
	'''<![CDATA[GLTransactions on this GLAccount should not appear on the VAT listing]]>
	Public Property [ExcludeVATListing] As Byte
	'''<![CDATA[Expenses on this GLAccount can not be used to reduce the incomes]]>
	Public Property [ExpenseNonDeductiblePercentage] As Double?
	'''<![CDATA[Primary Key]]>
	Public Property [ID] As Guid
	'''<![CDATA[When blocked you can't use this general ledger account anymore for new entries]]>
	Public Property [IsBlocked] As Boolean?
	'''<![CDATA[Allow entries on this general ledger account to be matched via the GL Account card]]>
	Public Property [Matching] As Boolean?
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[If a private use percentage is defined, you need to specify the GL used for the re-invoice of the private use to the owner of the company]]>
	Public Property [PrivateGLAccount] As Guid?
	'''<![CDATA[Specify the percentage of the cost that should be re-invoiced to the owner of the company as private use of the costs]]>
	Public Property [PrivatePercentage] As Double?
	'''<![CDATA[Used in the export of yearly report]]>
	Public Property [ReportingCode] As String
	'''<![CDATA[Indicates if the amounts booked on this general ledger account will be recalculated when currency revaluation is done]]>
	Public Property [RevalueCurrency] As Boolean?
	'''<![CDATA[Search Code]]>
	Public Property [SearchCode] As String
	'''<![CDATA[Type of G/L Account (for example, 110 = Revenue)]]>
	Public Property [Type] As Int32?
	'''<![CDATA[Description of Type]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [TypeDescription] As String
	'''<![CDATA[Indicates if cost centers can be used when using this general ledger account. The following values are supported: 0 (Optional) 1 (Mandatory) 2 (No)]]>
	Public Property [UseCostcenter] As Byte?
	'''<![CDATA[Indicates if cost units can be used when using this general ledger account. The following values are supported: 0 (Optional) 1 (Mandatory) 2 (No)]]>
	Public Property [UseCostunit] As Byte?
	'''<![CDATA[VAT Code linked to the G/L Account (for example, 2 or 4)]]>
	Public Property [VATCode] As String
	'''<![CDATA[Description of VAT]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [VATDescription] As String
	'''<![CDATA[Specify the kind of purchase this GL account is used for. This is important for the Belgian VAT return to indicate in which VAT box the base amount of purchase should go]]>
	Public Property [VATGLAccountType] As String
	'''<![CDATA[If you use a percentage of non deductible VAT, you can specify another GL account that will be used for the non deductible part of the VAT amount. This is used directly in the entry application of purchase invoices.]]>
	Public Property [VATNonDeductibleGLAccount] As Guid?
	'''<![CDATA[If not the full amount of the VAT is deductible, you can indicate a percentage for the non decuctible part. This is used during the entry of purchase invoices]]>
	Public Property [VATNonDeductiblePercentage] As Double?
	'''<![CDATA[The following values are supported: I (Invoice) C (Cash) (France)]]>
	Public Property [VATSystem] As String
	'''<![CDATA[Indicates the costing account for year end calculations]]>
	Public Property [YearEndCostGLAccount] As Guid?
	'''<![CDATA[Indicates the reflection account that is used by year end application]]>
	Public Property [YearEndReflectionGLAccount] As Guid?
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class GLClassification
	'''<![CDATA[Abstract elements are only used in presentation linkbases to group other elements. They are not supposed to be used in instance documents]]>
	Public Property [Abstract] As Boolean?
	'''<![CDATA[Only used for amount concepts: in that case either 'debit' or 'credit']]>
	Public Property [Balance] As String
	'''<![CDATA[The Code is unique]]>
	Public Property [Code] As String
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Description of the element. Note that this description is only used for division-specific taxonomies (or reporting schemes). For general taxonomies, the descriptions are stored in the TaxonomyLabels table]]>
	Public Property [Description] As String
	'''<![CDATA[Division is optional. For taxonomies of Taxonomies.Type = 0 (general taxonomies), the Division is empty. For division specific taxonomies it is mandatory]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Obsolete]]>
	Public Property [IsTupleSubElement] As Boolean?
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[The Name is unique in the namespace]]>
	Public Property [Name] As String
	'''<![CDATA[Determines whether usage of the element is mandatory in an instance document]]>
	Public Property [Nillable] As Boolean?
	'''<![CDATA[Parent element for reporting schemes. In a reporting scheme, an element can have only one parent. This column is only used for reporting schemes. Note that in a real taxonomy, elements can have multiple parents.]]>
	Public Property [Parent] As Guid?
	'''<![CDATA[Only used for item concepts: either 'instant' or 'duration'. 'instant' is used for balance types of concepts, 'duration' is used for P&L types of concepts]]>
	Public Property [PeriodType] As String
	'''<![CDATA[Mostly import sutstitutiongroup is xbrli:tuple, which makes the element a tuple concept. The default substitutiongroup for item concepts is xbrli:item]]>
	Public Property [SubstitutionGroup] As String
	'''<![CDATA[Namespace of the element]]>
	Public Property [TaxonomyNamespace] As Guid?
	'''<![CDATA[Description of TaxonomyNamespace]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [TaxonomyNamespaceDescription] As String
	'''<![CDATA[Type of the element]]>
	Public Property [Type] As Guid?
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class GLScheme
	Public Property [Code] As String
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Description text]]>
	Public Property [Description] As String
	'''<![CDATA[Division is optional for this table. For taxonomies of Taxonomies.Type = 0 (general taxonomies), the Division is empty. For division specific taxonomies it is mandatory]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Only used for reporting schemes = division specific taxonomynamespaces. In this case, main = 1 denotes the main or default reporting scheme]]>
	Public Property [Main] As Byte
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[URI, which is the unique identifier of the namespace]]>
	Public Property [TargetNamespace] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class GLTransactionType
	Public Property [Description] As String
	Public Property [DescriptionSuffix] As String
	Public Property [ID] As Int32
End Class

<SupportedActionsSDK(True, True, True, False)>
<DataServiceKey("EntryID")>
Public Class GoodsDelivery
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Reference to account for delivery]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DeliveryAccount] As Guid?
	'''<![CDATA[Delivery account code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DeliveryAccountCode] As String
	'''<![CDATA[Account name]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DeliveryAccountName] As String
	'''<![CDATA[Reference to shipping address]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DeliveryAddress] As Guid?
	'''<![CDATA[Reference to contact for delivery]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DeliveryContact] As Guid?
	'''<![CDATA[Name of the contact person of the customer who will receive delivered goods]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DeliveryContactPersonFullName] As String
	'''<![CDATA[Date of goods delivery]]>
	Public Property [DeliveryDate] As DateTime?
	'''<![CDATA[Delivery number]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DeliveryNumber] As Int32?
	'''<![CDATA[Header description]]>
	Public Property [Description] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Document that is manually linked to the sales order delivery]]>
	Public Property [Document] As Guid?
	'''<![CDATA[Document Subject]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DocumentSubject] As String
	'''<![CDATA[Primary key]]>
	Public Property [EntryID] As Guid
	'''<![CDATA[Entry number]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [EntryNumber] As Int32?
	'''<![CDATA[Collection of lines]]>
	Public Property [GoodsDeliveryLines] As IEnumerable(Of GoodsDeliveryLine)
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Remarks]]>
	Public Property [Remarks] As String
	'''<![CDATA[Reference to shipping method]]>
	Public Property [ShippingMethod] As Guid?
	'''<![CDATA[Code of shipping method]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ShippingMethodCode] As String
	'''<![CDATA[Description of shipping method]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ShippingMethodDescription] As String
	'''<![CDATA[Reference to header tracking number]]>
	Public Property [TrackingNumber] As String
	'''<![CDATA[Warehouse]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Warehouse] As Guid?
	'''<![CDATA[Code of Warehouse]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [WarehouseCode] As String
	'''<![CDATA[Description of Warehouse]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [WarehouseDescription] As String
End Class

<SupportedActionsSDK(True, True, True, False)>
<DataServiceKey("ID")>
Public Class GoodsDeliveryLine
	'''<![CDATA[Collection of batch numbers]]>
	Public Property [BatchNumbers] As IEnumerable(Of StockBatchNumber)
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Date of goods delivery]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DeliveryDate] As DateTime?
	'''<![CDATA[Description of sales order delivery]]>
	Public Property [Description] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[The EntryID identifies the goods delivery. All the lines of a goods delivery have the same EntryID]]>
	Public Property [EntryID] As Guid?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Reference to item]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Item] As Guid?
	'''<![CDATA[Item code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemCode] As String
	'''<![CDATA[Description of item]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemDescription] As String
	'''<![CDATA[Line number]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [LineNumber] As Int32?
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Notes]]>
	Public Property [Notes] As String
	'''<![CDATA[Quantity delivered]]>
	Public Property [QuantityDelivered] As Double?
	'''<![CDATA[Quantity ordered]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [QuantityOrdered] As Double?
	'''<![CDATA[Reference to sales order]]>
	Public Property [SalesOrderLineID] As Guid?
	'''<![CDATA[Sales order line number]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SalesOrderLineNumber] As Int32?
	'''<![CDATA[Sales order number]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SalesOrderNumber] As Int32?
	'''<![CDATA[Collection of serial numbers]]>
	Public Property [SerialNumbers] As IEnumerable(Of StockSerialNumber)
	'''<![CDATA[Reference to storage location for warehouse]]>
	Public Property [StorageLocation] As Guid?
	'''<![CDATA[Reference to tracking number]]>
	Public Property [TrackingNumber] As String
	'''<![CDATA[Code of item unit]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Unitcode] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ItemId")>
Public Class HourCostType
	'''<![CDATA[Description of Item]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemDescription] As String
	'''<![CDATA[Primary key]]>
	Public Property [ItemId] As Guid
End Class

<SupportedActionsSDK(True, False, False, False)>
<DataServiceKey("ID")>
Public Class InvoiceSalesOrders
	'''<![CDATA[Invoice creation mode- 0: Per customer 1: Per sales order]]>
	Public Property [CreateMode] As Int32?
	'''<![CDATA[Stock entries entry number.]]>
	Public Property [DeliveryNumber] As Int32?
	'''<![CDATA[Stock entries entry end date.]]>
	Public Property [EndDate] As DateTime?
	'''<![CDATA[Errors in the process.]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Errors] As String
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Invoice quantity processing mode- 0:By quantity delivered 1:By quantity ordered.]]>
	Public Property [InvoiceMode] As Int32?
	'''<![CDATA[Code of Journal]]>
	Public Property [JournalCode] As String
	'''<![CDATA[Number of invoices successfully created.]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [NumberOfCreatedInvoices] As Int32?
	'''<![CDATA[Number of invoices failed to create.]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [NumberOfFailedInvoices] As Int32?
	'''<![CDATA[Collection of Sales order IDs.]]>
	Public Property [SalesOrderIDs] As IEnumerable(Of SalesOrderID)
	'''<![CDATA[Stock entries entry start date.]]>
	Public Property [StartDate] As DateTime?
	'''<![CDATA[Possibility to override the InvoiceDate during creation of sales invoice from sales orders. Works only for integration with Intuit QuickBooks.]]>
	Public Property [UserInvoiceDate] As DateTime?
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class InvolvedUser
	'''<![CDATA[ID of the account the user is involved with]]>
	Public Property [Account] As Guid?
	'''<![CDATA[City of the account]]>
	Public Property [AccountCity] As String
	'''<![CDATA[Code of the account]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountCode] As String
	'''<![CDATA[Supplier flag of the account]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountIsSupplier] As Boolean?
	'''<![CDATA[Logo thumbnail url of the account]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountLogoThumbnailUrl] As String
	'''<![CDATA[Name of the account]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountName] As String
	'''<![CDATA[Status of the account]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountStatus] As String
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[ID of the user role]]>
	Public Property [InvolvedUserRole] As Guid?
	'''<![CDATA[Description of the user role]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [InvolvedUserRoleDescription] As String
	'''<![CDATA[Main contact flag of the involved user]]>
	Public Property [IsMainContact] As Boolean?
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Email of a person]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PersonEmail] As String
	'''<![CDATA[Phone of a person]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PersonPhone] As String
	'''<![CDATA[Phone extension of a person]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PersonPhoneExtension] As String
	'''<![CDATA[Picture thumbnail url of a person]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PersonPictureThumbnailUrl] As String
	'''<![CDATA[ID of the involved user]]>
	Public Property [User] As Guid?
	'''<![CDATA[User name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [UserFullName] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class InvolvedUserRole
	'''<![CDATA[Code of the involved user role]]>
	Public Property [Code] As String
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Description of role]]>
	Public Property [Description] As String
	'''<![CDATA[Description term code of role]]>
	Public Property [DescriptionTermID] As Int32?
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class Item
	'''<![CDATA[Barcode of the item (numeric string)]]>
	Public Property [Barcode] As String
	'''<![CDATA[Item class code referring to ItemClasses with ClassID 1]]>
	Public Property [Class_01] As String
	'''<![CDATA[Item class code referring to ItemClasses with ClassID 2]]>
	Public Property [Class_02] As String
	'''<![CDATA[Item class code referring to ItemClasses with ClassID 3]]>
	Public Property [Class_03] As String
	'''<![CDATA[Item class code referring to ItemClasses with ClassID 4]]>
	Public Property [Class_04] As String
	'''<![CDATA[Item class code referring to ItemClasses with ClassID 5]]>
	Public Property [Class_05] As String
	'''<![CDATA[Item code]]>
	Public Property [Code] As String
	'''<![CDATA[Copy remarks to sales lines]]>
	Public Property [CopyRemarks] As Byte
	'''<![CDATA[The currency of the current and proposed cost price]]>
	Public Property [CostPriceCurrency] As String
	'''<![CDATA[Proposed cost price]]>
	Public Property [CostPriceNew] As Double?
	'''<![CDATA[The current standard cost price]]>
	Public Property [CostPriceStandard] As Double?
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Description of the item]]>
	Public Property [Description] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Together with StartDate this determines if the item is active]]>
	Public Property [EndDate] As DateTime?
	'''<![CDATA[Extra description text, slightly longer than the regular description (255 instead of 60)]]>
	Public Property [ExtraDescription] As String
	'''<![CDATA[Free boolean field 1]]>
	Public Property [FreeBoolField_01] As Boolean?
	'''<![CDATA[Free boolean field 2]]>
	Public Property [FreeBoolField_02] As Boolean?
	'''<![CDATA[Free boolean field 3]]>
	Public Property [FreeBoolField_03] As Boolean?
	'''<![CDATA[Free boolean field 4]]>
	Public Property [FreeBoolField_04] As Boolean?
	'''<![CDATA[Free boolean field 5]]>
	Public Property [FreeBoolField_05] As Boolean?
	'''<![CDATA[Free date field 1]]>
	Public Property [FreeDateField_01] As DateTime?
	'''<![CDATA[Free date field 2]]>
	Public Property [FreeDateField_02] As DateTime?
	'''<![CDATA[Free date field 3]]>
	Public Property [FreeDateField_03] As DateTime?
	'''<![CDATA[Free date field 4]]>
	Public Property [FreeDateField_04] As DateTime?
	'''<![CDATA[Free date field 5]]>
	Public Property [FreeDateField_05] As DateTime?
	'''<![CDATA[Free numeric field 1]]>
	Public Property [FreeNumberField_01] As Double?
	'''<![CDATA[Free numeric field 2]]>
	Public Property [FreeNumberField_02] As Double?
	'''<![CDATA[Free numeric field 3]]>
	Public Property [FreeNumberField_03] As Double?
	'''<![CDATA[Free numeric field 4]]>
	Public Property [FreeNumberField_04] As Double?
	'''<![CDATA[Free numeric field 5]]>
	Public Property [FreeNumberField_05] As Double?
	'''<![CDATA[Free numeric field 6]]>
	Public Property [FreeNumberField_06] As Double?
	'''<![CDATA[Free numeric field 7]]>
	Public Property [FreeNumberField_07] As Double?
	'''<![CDATA[Free numeric field 8]]>
	Public Property [FreeNumberField_08] As Double?
	'''<![CDATA[Free text field 1]]>
	Public Property [FreeTextField_01] As String
	'''<![CDATA[Free text field 2]]>
	Public Property [FreeTextField_02] As String
	'''<![CDATA[Free text field 3]]>
	Public Property [FreeTextField_03] As String
	'''<![CDATA[Free text field 4]]>
	Public Property [FreeTextField_04] As String
	'''<![CDATA[Free text field 5]]>
	Public Property [FreeTextField_05] As String
	'''<![CDATA[Free text field 6]]>
	Public Property [FreeTextField_06] As String
	'''<![CDATA[Free text field 7]]>
	Public Property [FreeTextField_07] As String
	'''<![CDATA[Free text field 8]]>
	Public Property [FreeTextField_08] As String
	'''<![CDATA[Free text field 9]]>
	Public Property [FreeTextField_09] As String
	'''<![CDATA[Free text field 10]]>
	Public Property [FreeTextField_10] As String
	'''<![CDATA[GL account the cost entries will be booked on. This overrules the GL account from the item group. If the license contains 'Intuit integration' this property overrides the value in Settings, not the item group.]]>
	Public Property [GLCosts] As Guid?
	'''<![CDATA[Code of GL account for costs]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLCostsCode] As String
	'''<![CDATA[Description of GLCosts]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLCostsDescription] As String
	'''<![CDATA[GL account the revenue will be booked on. This overrules the GL account from the item group. If the license contains 'Intuit integration' this property overrides the value in Settings, not the item group.]]>
	Public Property [GLRevenue] As Guid?
	'''<![CDATA[Code of GLRevenue]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLRevenueCode] As String
	'''<![CDATA[Description of GLRevenue]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLRevenueDescription] As String
	'''<![CDATA[GL account the stock entries will be booked on. This overrules the GL account from the item group. If the license contains 'Intuit integration' this property overrides the value in Settings, not the item group.]]>
	Public Property [GLStock] As Guid?
	'''<![CDATA[Code of GL account for stock]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLStockCode] As String
	'''<![CDATA[Description of GLStock]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLStockDescription] As String
	'''<![CDATA[Gross weight for international goods shipments]]>
	Public Property [GrossWeight] As Double?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Indicates if batches are used for this item]]>
	Public Property [IsBatchItem] As Byte
	'''<![CDATA[Used with Batch number feature. Indicates if the item can have a batch number]]>
	Public Property [IsBatchNumberItem] As Byte
	'''<![CDATA[Indicates if fractions (for example 0.35) are allowed for quantities of this item]]>
	Public Property [IsFractionAllowedItem] As Boolean?
	'''<![CDATA[Indicates that an Item is produced to Inventory, not purchased]]>
	Public Property [IsMakeItem] As Byte
	'''<![CDATA[Only used for packages (IsPackageItem=1). To indicate if this package is a new contract type package]]>
	Public Property [IsNewContract] As Byte
	'''<![CDATA[Is On demand Item]]>
	Public Property [IsOnDemandItem] As Byte
	'''<![CDATA[Indicates if the item is a package item. Can only be created in the hosting administration]]>
	Public Property [IsPackageItem] As Boolean?
	'''<![CDATA[Indicates if the item can be purchased]]>
	Public Property [IsPurchaseItem] As Boolean?
	'''<![CDATA[Indicated if the item is used in voucher functionality]]>
	Public Property [IsRegistrationCodeItem] As Byte
	'''<![CDATA[Indicates if the item can be sold]]>
	Public Property [IsSalesItem] As Boolean?
	'''<![CDATA[Indicates that serial numbers are used for this item]]>
	Public Property [IsSerialItem] As Boolean?
	'''<![CDATA[Used with Serial number feature. Indicates if the item can have a serial number]]>
	Public Property [IsSerialNumberItem] As Boolean?
	'''<![CDATA[If you have the Trade or Manufacturing license and you check this property the item will be shown in the stock positions overview, stock counts and transaction lists. If you have the Invoice module and you check this property you will get a general journal entry based on the Stock and Costs G/L accounts of the item group. If you don’t want the general journal entry to be created you should change the Stock/Costs G/L account on the Item group page to the type Costs instead of Inventory.]]>
	Public Property [IsStockItem] As Boolean?
	'''<![CDATA[Indicates if the item is provided by an outside supplier]]>
	Public Property [IsSubcontractedItem] As Boolean?
	'''<![CDATA[Indicates if tax needs to be calculated for this item]]>
	Public Property [IsTaxableItem] As Byte?
	'''<![CDATA[Indicates if the item is a time unit item (for example a labor hour item)]]>
	Public Property [IsTime] As Byte
	'''<![CDATA[Indicates if the item can be exported to a web shop]]>
	Public Property [IsWebshopItem] As Byte
	'''<![CDATA[GUID of Item group of the item]]>
	Public Property [ItemGroup] As Guid?
	'''<![CDATA[Code of ItemGroup]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemGroupCode] As String
	'''<![CDATA[Description of ItemGroup]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemGroupDescription] As String
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Net weight for international goods shipments]]>
	Public Property [NetWeight] As Double?
	'''<![CDATA[Notes]]>
	Public Property [Notes] As String
	'''<![CDATA[File name of picture]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PictureName] As String
	'''<![CDATA[Url where thumbnail picture can be retrieved]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PictureThumbnailUrl] As String
	'''<![CDATA[Url where picture can be retrieved]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PictureUrl] As String
	'''<![CDATA[Code of SalesVat]]>
	Public Property [SalesVatCode] As String
	'''<![CDATA[Description of SalesVatCode]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SalesVatCodeDescription] As String
	'''<![CDATA[Search code of the item]]>
	Public Property [SearchCode] As String
	'''<![CDATA[Security level (0 - 100)]]>
	Public Property [SecurityLevel] As Int32?
	'''<![CDATA[Together with EndDate this determines if the item is active]]>
	Public Property [StartDate] As DateTime?
	'''<![CDATA[Quantity that is in stock]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Stock] As Double?
	'''<![CDATA[The standard unit of this item]]>
	Public Property [Unit] As String
	'''<![CDATA[Description of Unit]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [UnitDescription] As String
	'''<![CDATA[Type of unit: A=Area, L=Length, O=Other, T=Time, V=Volume, W=Weight]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [UnitType] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class ItemGroup
	'''<![CDATA[Code of the item group]]>
	Public Property [Code] As String
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Description of the item group]]>
	Public Property [Description] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[GL account on which the costs of items of this group will be booked]]>
	Public Property [GLCosts] As Guid?
	'''<![CDATA[Code of GLCosts]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLCostsCode] As String
	'''<![CDATA[Description of GLCosts]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLCostsDescription] As String
	'''<![CDATA[GL Purchase account for purchase invoicing according to (non-) perpetual inventory method]]>
	Public Property [GLPurchaseAccount] As Guid?
	'''<![CDATA[Code of GLPurchase]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLPurchaseAccountCode] As String
	'''<![CDATA[Description of GLPurchaseAccount]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLPurchaseAccountDescription] As String
	'''<![CDATA[GL account that will be used for the 'Standard cost price' valuation method to balance the difference between purchase price and cost price]]>
	Public Property [GLPurchasePriceDifference] As Guid?
	'''<![CDATA[Code of GLPurchasePriceDifference]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLPurchasePriceDifferenceCode] As String
	'''<![CDATA[Description of GLPurchasePriceDifference]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLPurchasePriceDifferenceDescr] As String
	'''<![CDATA[GL account on which the revenue for items of this group will be booked]]>
	Public Property [GLRevenue] As Guid?
	'''<![CDATA[Code of GLRevenue]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLRevenueCode] As String
	'''<![CDATA[Description of GLRevenue]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLRevenueDescription] As String
	'''<![CDATA[GL account on which stock entries will be booked for items of this group]]>
	Public Property [GLStock] As Guid?
	'''<![CDATA[Code of GLStock]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLStockCode] As String
	'''<![CDATA[Description of GLStock]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLStockDescription] As String
	'''<![CDATA[GL stock variance account for perpetual inventory]]>
	Public Property [GLStockVariance] As Guid?
	'''<![CDATA[Code of GLStockVariance]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLStockVarianceCode] As String
	'''<![CDATA[Description of GLStockVariance]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLStockVarianceDescription] As String
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Indicates if this is the default item group that will be assigned when a new item is created]]>
	Public Property [IsDefault] As Byte
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Notes]]>
	Public Property [Notes] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class ItemVersion
	'''<![CDATA[Batch Quantity of Item Version]]>
	Public Property [BatchQuantity] As Double?
	'''<![CDATA[Calculated Cost Price of Item Version]]>
	Public Property [CalculatedCostPrice] As Double?
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Description of the item version]]>
	Public Property [Description] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Indicates if this is the default item version that will be assigned when a item is selected]]>
	Public Property [IsDefault] As Byte
	'''<![CDATA[Reference to Items table]]>
	Public Property [Item] As Guid
	'''<![CDATA[Description of Item]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemDescription] As String
	'''<![CDATA[Lead time of Item version]]>
	Public Property [LeadTime] As Int32?
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Line notes]]>
	Public Property [Notes] As String
	'''<![CDATA[Statuses of Item version: 10-Engineering change pending, 20-Engineering change approved, 30-Active & 40-Historic]]>
	Public Property [Status] As Int16?
	'''<![CDATA[Description of Status]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [StatusDescription] As String
	'''<![CDATA[Type of Item version: 10-Sales bill of material, 20-Manufacturing recipe]]>
	Public Property [Type] As Int16?
	'''<![CDATA[Description of Type]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [TypeDescription] As String
	'''<![CDATA[Version Number]]>
	Public Property [VersionNumber] As Int32?
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class ItemWarehouse
	'''<![CDATA[Creation date]]>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	Public Property [CreatorFullName] As String
	'''<![CDATA[This is a default storage location]]>
	Public Property [DefaultStorageLocation] As Guid?
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Item ID]]>
	Public Property [Item] As Guid?
	'''<![CDATA[Description of item]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemDescription] As String
	'''<![CDATA[Indicates if fractions (for example 0.35) are allowed for quantities of this item]]>
	Public Property [ItemIsFractionAllowedItem] As Boolean?
	'''<![CDATA[The standard unit code of this item]]>
	Public Property [ItemUnit] As String
	'''<![CDATA[Description of item's unit]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemUnitDescription] As String
	'''<![CDATA[Maximum number of stock could enter warehouse]]>
	Public Property [MaximumStock] As Double?
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Reorder point when stock depletes]]>
	Public Property [ReorderPoint] As Double?
	'''<![CDATA[Safety stock]]>
	Public Property [SafetyStock] As Double?
	'''<![CDATA[Warehouse ID]]>
	Public Property [Warehouse] As Guid?
	'''<![CDATA[Description of warehouse]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [WarehouseDescription] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class JobGroup
	'''<![CDATA[Job group code]]>
	Public Property [Code] As String
	'''<![CDATA[Creation date]]>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Job group description]]>
	Public Property [Description] As String
	'''<![CDATA[Division code]]>
	Public Property [Division] As Int32?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Last modified date]]>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Explanation or extra information can be stored in the notes]]>
	Public Property [Notes] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class JobTitle
	'''<![CDATA[Job title code]]>
	Public Property [Code] As String
	'''<![CDATA[Creation date]]>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Job title description]]>
	Public Property [Description] As String
	'''<![CDATA[Division code]]>
	Public Property [Division] As Int32?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Reference job code]]>
	Public Property [JobCode] As String
	'''<![CDATA[Group this job title belongs to]]>
	Public Property [JobGroup] As Guid?
	'''<![CDATA[Job group code]]>
	Public Property [JobGroupCode] As String
	'''<![CDATA[Job group description]]>
	Public Property [JobGroupDescription] As String
	'''<![CDATA[Job title represents job level from]]>
	Public Property [JobLevelFrom] As Int32?
	'''<![CDATA[Job title represents job level to]]>
	Public Property [JobLevelTo] As Int32?
	'''<![CDATA[Last modified date]]>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Explanation or extra information can be stored in the notes]]>
	Public Property [Notes] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class Journal
	'''<![CDATA[Indicates if the journal allows variable currency]]>
	Public Property [AllowVariableCurrency] As Boolean?
	'''<![CDATA[Indicates if the journal allows the exchange rate of the currency of the amounts in the journal entry to be changed]]>
	Public Property [AllowVariableExchangeRate] As Boolean?
	'''<![CDATA[Indicates if the journal allows the use of VAT in the financial entry. Especially true for general journals]]>
	Public Property [AllowVAT] As Boolean?
	'''<![CDATA[Indicates if the journal automatically saves the entries when the amount is in balance with the entry lines]]>
	Public Property [AutoSave] As Boolean?
	'''<![CDATA[Reference to bank account]]>
	Public Property [Bank] As Guid?
	'''<![CDATA[BIC code of the bank where the bank account is held]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [BankAccountBICCode] As String
	'''<![CDATA[Country of bank account]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [BankAccountCountry] As String
	'''<![CDATA[Description of BankAccount]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [BankAccountDescription] As String
	'''<![CDATA[IBAN of the bank account]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [BankAccountIBAN] As String
	'''<![CDATA[Reference to the Bank Account linked to the Journal]]>
	Public Property [BankAccountID] As Guid?
	'''<![CDATA[Bank account number. Is mandatory for Journals that have Type = Bank]]>
	Public Property [BankAccountIncludingMask] As String
	'''<![CDATA[Obsolete. Whether or not use SEPA for the bank account]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [BankAccountUseSEPA] As Boolean?
	'''<![CDATA[Obsolete. Whether or not use SEPA direct debit for the bank account]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [BankAccountUseSepaDirectDebit] As Boolean?
	'''<![CDATA[Name of bank account]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [BankName] As String
	'''<![CDATA[Primary key]]>
	Public Property [Code] As String
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Default Currency of the Journal. If AllowVariableCurrency is false this is the only currency that can be used]]>
	Public Property [Currency] As String
	'''<![CDATA[Description of Currency]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CurrencyDescription] As String
	'''<![CDATA[Name of the Journal]]>
	Public Property [Description] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Suspense general ledger account]]>
	Public Property [GLAccount] As Guid?
	'''<![CDATA[Code of GLAccount]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLAccountCode] As String
	'''<![CDATA[Description of GLAccount]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLAccountDescription] As String
	'''<![CDATA[Type of GLAccount]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLAccountType] As Int32?
	'''<![CDATA[Primary Key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[General ledger account for payment in transit]]>
	Public Property [PaymentInTransitAccount] As Guid?
	'''<![CDATA[Identifier detail of the Payment service account. Ex. EmailID for Paypal type of Payment service account]]>
	Public Property [PaymentServiceAccountIdentifier] As String
	'''<![CDATA[Type of Payment service provider. The following values are supported: 1 (Adyen), 2 (Paypal), 3 (Stripe). Is mandatory for Journals of Type 16 (Payment service)]]>
	Public Property [PaymentServiceProvider] As Int32?
	'''<![CDATA[Name of the Payment service provider]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PaymentServiceProviderName] As String
	'''<![CDATA[Type of Journal. The following values are supported: 10 (Cash) 12 (Bank) 16 (Payment service) 20 (Sales) 21 (Return invoice) 22 (Purchase) 23 (Received return invoice) 90 (General journal)]]>
	Public Property [Type] As Int32?
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("Year,Period,Journal")>
Public Class JournalStatus
	'''<![CDATA[Reference to Journal]]>
	Public Property [Journal] As String
	'''<![CDATA[Description of Journal]]>
	Public Property [JournalDescription] As String
	'''<![CDATA[Type of Journal 10=Cash, 12=Bank, 20=Sales, 21=Return invoice, 22=Purchase, 23=Received return invoice, 90=General journal]]>
	Public Property [JournalType] As Int32
	'''<![CDATA[Description of JournalType]]>
	Public Property [JournalTypeDescription] As String
	'''<![CDATA[Financial period]]>
	Public Property [Period] As Int32
	'''<![CDATA[Journal status for this year and period 0=open, 1=closed]]>
	Public Property [Status] As Int32
	'''<![CDATA[Description of Status]]>
	Public Property [StatusDescription] As String
	'''<![CDATA[Financial year]]>
	Public Property [Year] As Int32
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class Layout
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of the creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of the creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of the last modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of the last modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Layout name]]>
	Public Property [Subject] As String
	'''<![CDATA[Type: 1=Layout, 2=E-mail text layout, 3=Word template]]>
	Public Property [Type] As Int16?
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class Mailbox
	'''<![CDATA[The account this mailbox belongs to. Can be empty if the owner of the mailbox isn't an Exact Online customer yet]]>
	Public Property [Account] As Guid?
	'''<![CDATA[Name of Account]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountName] As String
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Extra description of the mailbox]]>
	Public Property [Description] As String
	'''<![CDATA[Only used when this mailbox is used for one specific administration, for example invoices to this mailbox will only be booked in this administration]]>
	Public Property [ForDivision] As Int32?
	'''<![CDATA[Description of ForDivision]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ForDivisionDescription] As String
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[E-mail address-like format, for example johndoe@exactonline.nl]]>
	Public Property [Mailbox] As String
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Customers can decide if they want this mailbox to be visible by all. i.e. some other customer can see this in address maintenance for digital postbox of type Exact]]>
	Public Property [Publish] As Byte
	'''<![CDATA[Type of mailbox. Exact / Government / Manual]]>
	Public Property [Type] As Int16?
	'''<![CDATA[Date that this mailbox became valid]]>
	Public Property [ValidFrom] As DateTime?
	'''<![CDATA[Date that this mailbox will not be valid anymore]]>
	Public Property [ValidTo] As DateTime?
End Class

<SupportedActionsSDK(True, True, False, False)>
<DataServiceKey("ID")>
Public Class MailMessage
	'''<![CDATA[Bank to/from which the mail message is sent/received. This is used for mail messages of type Bank only. It has an attachment containing the bank file. When used for a mail message of type bank, the value is reserved for internal use and will then be ignored.]]>
	Public Property [Bank] As Guid?
	'''<![CDATA[Bank account for which the mail message is sent. This is used for mail messages of type Bank only. It has an attachment containing the bank export file. When used for a mail message of type bank, the value is reserved for internal use and will then be ignored.]]>
	Public Property [BankAccount] As String
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Administration from which the mail message is sent. This is used for mail messages of type Bank only. When used for a mail message of type bank, the value is reserved for internal use and will then be ignored.]]>
	Public Property [ForDivision] As Int32?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Specifies the operation upon dealing with the mailmessage (Kirean scan service)]]>
	Public Property [Operation] As Int16?
	'''<![CDATA[Provides a link to another MailMessage (Kirean scan service)]]>
	Public Property [OriginalMessage] As Guid?
	'''<![CDATA[Subject of the OriginalMessage]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [OriginalMessageSubject] As String
	'''<![CDATA[The partner key that was used: this refers to the application from which the message is originating. It is filled with a fixed partnerkey when created from within Exact Online]]>
	Public Property [PartnerKey] As Guid?
	'''<![CDATA[Specifies the number of lines of the returned MailMessage attachment (Kirean scan service)]]>
	Public Property [Quantity] As Double?
	'''<![CDATA[Reference to the account that is receiving this mailmessage]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [RecipientAccount] As Guid?
	'''<![CDATA[Indiciates if the recipient deleted this message. If this is the case the recipient can't see it anymore and the sender can actually delete it]]>
	Public Property [RecipientDeleted] As Byte
	'''<![CDATA[Mailbox of recipient]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [RecipientMailbox] As String
	'''<![CDATA[Mailbox description of recipient]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [RecipientMailboxDescription] As String
	'''<![CDATA[Mailbox ID of the recipient. The owner of this mailbox will see the message in the inbox]]>
	Public Property [RecipientMailboxID] As Guid?
	'''<![CDATA[Status of the mail message, only the recipient can update this]]>
	Public Property [RecipientStatus] As Int16?
	'''<![CDATA[Description of RecipientStatus]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [RecipientStatusDescription] As String
	'''<![CDATA[Reference to Account of Sender]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SenderAccount] As Guid?
	'''<![CDATA[Date the message was sent. Default the date the message is created, can be an earlier date when imported from xml (the date the xml was sent)]]>
	Public Property [SenderDateSent] As DateTime?
	'''<![CDATA[Indicates if the sender deleted the message. This means the sender can't see it anymore and the recipient can actually delete it]]>
	Public Property [SenderDeleted] As Byte
	'''<![CDATA[IP address of the sender]]>
	Public Property [SenderIPAddress] As String
	'''<![CDATA[Mailbox of sender]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SenderMailbox] As String
	'''<![CDATA[Description of SenderMailbox]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SenderMailboxDescription] As String
	'''<![CDATA[Mailbox ID of the sender. The owner of this mailbox will see the message in the sent items]]>
	Public Property [SenderMailboxID] As Guid?
	'''<![CDATA[Subject of the mail message]]>
	Public Property [Subject] As String
	'''<![CDATA[Provides a link between Exact Online and the banks]]>
	Public Property [SynchronizationCode] As String
	'''<![CDATA[Type of the mail message]]>
	Public Property [Type] As Int32?
End Class

<SupportedActionsSDK(True, True, False, False)>
<DataServiceKey("ID")>
Public Class MailMessageAttachment
	'''<![CDATA[For performance reasons Attachment is Write-Only. The blob can be downloaded using the supplied Url]]>
	Public Property [Attachment] As Byte()
	'''<![CDATA[File extension of attachment]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AttachmentFileExtension] As String
	'''<![CDATA[File name of attachment]]>
	Public Property [AttachmentFileName] As String
	'''<![CDATA[File size]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [FileSize] As Int64
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Reference to Mail message]]>
	Public Property [MailMessageID] As Guid
	'''<![CDATA[Reference to recepient account]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [RecipientAccount] As Guid?
	'''<![CDATA[Reference to sender account]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SenderAccount] As Guid?
	'''<![CDATA[Type of mail message attachment]]>
	Public Property [Type] As Int32
	'''<![CDATA[Description of Type]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [TypeDescription] As String
	'''<![CDATA[The blob can be downloaded through this url]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Url] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class ManufacturingTimeTransaction
	'''<![CDATA[Manufacturing time type: Setup = 10, Run = 20]]>
	Public Property [Activity] As Int16?
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Date]]>
	Public Property [Date] As DateTime?
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Employee linked to the transaction]]>
	Public Property [Employee] As Guid?
	'''<![CDATA[Machine hours]]>
	Public Property [Hours] As Double?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Is the operation finished?]]>
	Public Property [IsOperationFinished] As Byte?
	'''<![CDATA[Labor Hours on the operation]]>
	Public Property [LaborHours] As Double?
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Notes linked to the time transaction]]>
	Public Property [Notes] As String
	'''<![CDATA[Percentage of the operation that is complete]]>
	Public Property [PercentComplete] As Double?
	'''<![CDATA[Quantity]]>
	Public Property [Quantity] As Double?
	'''<![CDATA[Routing step linked to the transaction]]>
	Public Property [RoutingStepPlan] As Guid?
	'''<![CDATA[Shop order linked to the transaction]]>
	Public Property [ShopOrder] As Guid?
	'''<![CDATA[Status of the transaction: Draft = 1, Submitted = 10]]>
	Public Property [Status] As Int16?
	'''<![CDATA[Timed time transaction linked to the transaction]]>
	Public Property [TimedTimeTransaction] As Guid?
	'''<![CDATA[Workcenter linked to the transaction]]>
	Public Property [WorkCenter] As Guid?
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("Division,ReportingYear,GLAccount")>
Public Class OpeningBalanceAfterEntry
	'''<![CDATA[The opening balance amount of the G/L account.]]>
	Public Property [Amount] As Double?
	'''<![CDATA[Indicates whether the G/L account is a debit or credit account. D = Debit, C = Credit.]]>
	Public Property [BalanceSide] As String
	'''<![CDATA[Division code.]]>
	Public Property [Division] As Int32
	'''<![CDATA[The balance sheet account.]]>
	Public Property [GLAccount] As Guid
	'''<![CDATA[The code of the G/L account.]]>
	Public Property [GLAccountCode] As String
	'''<![CDATA[The description of the G/L account.]]>
	Public Property [GLAccountDescription] As String
	'''<![CDATA[The reporting year of the opening balance.]]>
	Public Property [ReportingYear] As Int32
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("Division,ReportingYear,GLAccount")>
Public Class OpeningBalancePreviousYearAfterEntry
	'''<![CDATA[The opening balance amount of the G/L account.]]>
	Public Property [Amount] As Double?
	'''<![CDATA[Indicates whether the G/L account is a debit or credit account. D = Debit, C = Credit.]]>
	Public Property [BalanceSide] As String
	'''<![CDATA[Division code.]]>
	Public Property [Division] As Int32
	'''<![CDATA[The balance sheet account.]]>
	Public Property [GLAccount] As Guid
	'''<![CDATA[The code of the G/L account.]]>
	Public Property [GLAccountCode] As String
	'''<![CDATA[The description of the G/L account.]]>
	Public Property [GLAccountDescription] As String
	'''<![CDATA[The reporting year of the opening balance.]]>
	Public Property [ReportingYear] As Int32
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("Division,ReportingYear,GLAccount")>
Public Class OpeningBalanceProcessed
	'''<![CDATA[The opening balance amount of the G/L account.]]>
	Public Property [Amount] As Double?
	'''<![CDATA[Indicates whether the G/L account is a debit or credit account. D = Debit, C = Credit.]]>
	Public Property [BalanceSide] As String
	'''<![CDATA[Division code.]]>
	Public Property [Division] As Int32
	'''<![CDATA[The balance sheet account.]]>
	Public Property [GLAccount] As Guid
	'''<![CDATA[The code of the G/L account.]]>
	Public Property [GLAccountCode] As String
	'''<![CDATA[The description of the G/L account.]]>
	Public Property [GLAccountDescription] As String
	'''<![CDATA[The reporting year of the opening balance.]]>
	Public Property [ReportingYear] As Int32
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("Division,ReportingYear,GLAccount")>
Public Class OpeningBalancePreviousYearProcessed
	'''<![CDATA[The opening balance amount of the G/L account.]]>
	Public Property [Amount] As Double?
	'''<![CDATA[Indicates whether the G/L account is a debit or credit account. D = Debit, C = Credit.]]>
	Public Property [BalanceSide] As String
	'''<![CDATA[Division code.]]>
	Public Property [Division] As Int32
	'''<![CDATA[The balance sheet account.]]>
	Public Property [GLAccount] As Guid
	'''<![CDATA[The code of the G/L account.]]>
	Public Property [GLAccountCode] As String
	'''<![CDATA[The description of the G/L account.]]>
	Public Property [GLAccountDescription] As String
	'''<![CDATA[The reporting year of the opening balance.]]>
	Public Property [ReportingYear] As Int32
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class Operation
	'''<![CDATA[Code of the operation]]>
	Public Property [Code] As String
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Description of the operation]]>
	Public Property [Description] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Indicates if the operation has suppliers associated with it]]>
	Public Property [HasSuppliers] As Byte?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Reference to Items table]]>
	Public Property [Item] As Guid?
	'''<![CDATA[Description of Item]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemDescription] As String
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Extra remarks]]>
	Public Property [Notes] As String
	'''<![CDATA[Search code for the operation]]>
	Public Property [Searchcode] As String
	'''<![CDATA[Status of the operation]]>
	Public Property [Status] As Int16?
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class OperationResource
	'''<![CDATA[Reference to Accounts]]>
	Public Property [Account] As Guid?
	'''<![CDATA[Attended percentage]]>
	Public Property [AttendedPercentage] As Double?
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Reference to Currencies]]>
	Public Property [Currency] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Efficiency percentage]]>
	Public Property [EfficiencyPercentage] As Double?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Indicates if this is the primary operation of the workcenter]]>
	Public Property [IsPrimary] As Byte?
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Reference to Operations]]>
	Public Property [Operation] As Guid?
	'''<![CDATA[Description of Operation]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [OperationDescription] As String
	'''<![CDATA[Lead days from purchase]]>
	Public Property [PurchaseLeadDays] As Int32?
	'''<![CDATA[Unit of purchased item from supplier]]>
	Public Property [PurchaseUnit] As String
	'''<![CDATA[VAT code used for purchased item from supplier]]>
	Public Property [PurchaseVATCode] As String
	'''<![CDATA[Used in conjuction with RunMethod and EfficiencyPercentage to determine PlannedRunHours]]>
	Public Property [Run] As Double?
	'''<![CDATA[Reference to OperationRunMethods]]>
	Public Property [RunMethod] As Int16?
	'''<![CDATA[Used in conjunction with SetupCount and SetupUnit to determine PlannedSetupHours]]>
	Public Property [Setup] As Double?
	'''<![CDATA[Reference to TimeUnits]]>
	Public Property [SetupUnit] As String
	'''<![CDATA[Reference to RoutingStepTypes]]>
	Public Property [Type] As Int16?
	'''<![CDATA[Reference to Workcenter]]>
	Public Property [Workcenter] As Guid?
	'''<![CDATA[Description of Workcenter]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [WorkcenterDescription] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class Opportunity
	'''<![CDATA[Lead to which the opportunity applies]]>
	Public Property [Account] As Guid?
	'''<![CDATA[Code of Account]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountCode] As String
	'''<![CDATA[Name of Account]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountName] As String
	'''<![CDATA[Indicates the date before/on the NextAction is supposed to be done]]>
	Public Property [ActionDate] As DateTime?
	'''<![CDATA[Amount in the default currency of the company. AmountDC = AmountFC * RateFC]]>
	Public Property [AmountDC] As Double?
	'''<![CDATA[Amount in the currency of the transaction]]>
	Public Property [AmountFC] As Double?
	'''<![CDATA[Reference to the campaign opportunity is related to]]>
	Public Property [Campaign] As Guid?
	'''<![CDATA[Description of Campaign]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CampaignDescription] As String
	'''<![CDATA[The date when the opportunity is expected to be closed]]>
	Public Property [CloseDate] As DateTime?
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of the creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Currency code]]>
	Public Property [Currency] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[The source of the lead/opportunity]]>
	Public Property [LeadSource] As Guid?
	'''<![CDATA[Description of LeadSource]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [LeadSourceDescription] As String
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of the last modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Name of the opportunity]]>
	Public Property [Name] As String
	'''<![CDATA[Indicates what follow up action is to be undertaken to move the opportunity towards a deal. Is used in combination with ActionDate]]>
	Public Property [NextAction] As String
	'''<![CDATA[Notes of the opportunity]]>
	Public Property [Notes] As String
	'''<![CDATA[The stage of the opportunity. This is a list defined by the user]]>
	Public Property [OpportunityStage] As Guid?
	'''<![CDATA[Description of OpportunityStage]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [OpportunityStageDescription] As String
	'''<![CDATA[Status: 1=Open, 2=Closed won, 3=Closed lost]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [OpportunityStatus] As Int32?
	'''<![CDATA[The resource who owns the opportunity and is responsible to close the opportunity (either won or lost)]]>
	Public Property [Owner] As Guid?
	'''<![CDATA[Name of Owner]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [OwnerFullName] As String
	'''<![CDATA[The chance that the opportunity will be closed and won. The default for the probability depends on the default from the opportunity stage]]>
	Public Property [Probability] As Double?
	'''<![CDATA[Reference to project]]>
	Public Property [Project] As Guid?
	'''<![CDATA[Code of Project]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectCode] As String
	'''<![CDATA[Description of Project]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectDescription] As String
	'''<![CDATA[Exchange rate from original to division currency]]>
	Public Property [RateFC] As Double?
	'''<![CDATA[Indicates the reason why the opportunity was lost.]]>
	Public Property [ReasonCode] As Guid?
	'''<![CDATA[Description of ReasonCode]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ReasonCodeDescription] As String
	'''<![CDATA[Reference to Sales type]]>
	Public Property [SalesType] As Guid?
	'''<![CDATA[Description of SalesType]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SalesTypeDescription] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class OpportunityContact
	'''<![CDATA[The account to which the contact belongs]]>
	Public Property [Account] As Guid?
	'''<![CDATA[Indicates if account is a customer]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountIsCustomer] As Boolean
	'''<![CDATA[Indicates if account is a supplier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountIsSupplier] As Boolean?
	'''<![CDATA[Reference to the main contact of the account]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountMainContact] As Guid?
	'''<![CDATA[Name of the account]]>
	Public Property [AccountName] As String
	'''<![CDATA[Second address line]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AddressLine2] As String
	'''<![CDATA[Street name of the address]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AddressStreet] As String
	'''<![CDATA[Street number of the address]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AddressStreetNumber] As String
	'''<![CDATA[Street number suffix of the address]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AddressStreetNumberSuffix] As String
	'''<![CDATA[Obsolete]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AllowMailing] As Int32?
	'''<![CDATA[Birth date]]>
	Public Property [BirthDate] As DateTime?
	'''<![CDATA[Last birth name]]>
	Public Property [BirthName] As String
	'''<![CDATA[Middle birth name]]>
	Public Property [BirthNamePrefix] As String
	'''<![CDATA[Birth place]]>
	Public Property [BirthPlace] As String
	'''<![CDATA[Email address of the contact]]>
	Public Property [BusinessEmail] As String
	'''<![CDATA[Fax of the contact]]>
	Public Property [BusinessFax] As String
	'''<![CDATA[Mobile of the contact]]>
	Public Property [BusinessMobile] As String
	'''<![CDATA[Phone of the contact]]>
	Public Property [BusinessPhone] As String
	'''<![CDATA[Phone extension of the contact]]>
	Public Property [BusinessPhoneExtension] As String
	'''<![CDATA[City]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [City] As String
	'''<![CDATA[Code of the account]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Code] As String
	'''<![CDATA[Contact person that is linked to the opportunity]]>
	Public Property [Contact] As Guid?
	'''<![CDATA[Country code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Country] As String
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of the creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of the creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Email address of the contact]]>
	Public Property [Email] As String
	'''<![CDATA[End date]]>
	Public Property [EndDate] As DateTime?
	'''<![CDATA[First name. Provide at least first name or last name to create a new contact]]>
	Public Property [FirstName] As String
	'''<![CDATA[Full name (First name Middle name Last name)]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [FullName] As String
	'''<![CDATA[Gender]]>
	Public Property [Gender] As String
	'''<![CDATA[Contact ID]]>
	Public Property [HID] As Int32?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Identification date]]>
	Public Property [IdentificationDate] As DateTime?
	'''<![CDATA[Reference to the identification document of the contact]]>
	Public Property [IdentificationDocument] As Guid?
	'''<![CDATA[Reference to the user responsible for identification]]>
	Public Property [IdentificationUser] As Guid?
	'''<![CDATA[Initials]]>
	Public Property [Initials] As String
	'''<![CDATA[Indicates whether contacts are excluded from the marketing list]]>
	Public Property [IsMailingExcluded] As Boolean?
	'''<![CDATA[Indicates if this is the main contact of the linked account]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [IsMainContact] As Boolean?
	'''<![CDATA[Jobtitle of the contact]]>
	Public Property [JobTitleDescription] As String
	'''<![CDATA[Language code]]>
	Public Property [Language] As String
	'''<![CDATA[Last name. Provide at least first name or last name to create a new contact]]>
	Public Property [LastName] As String
	'''<![CDATA[The user should be able to do a full text search on these notes to gather contacts for a marketing campaign]]>
	Public Property [MarketingNotes] As String
	'''<![CDATA[Middle name]]>
	Public Property [MiddleName] As String
	'''<![CDATA[Business phone of the contact]]>
	Public Property [Mobile] As String
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of the last modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Nationality]]>
	Public Property [Nationality] As String
	'''<![CDATA[Extra remarks]]>
	Public Property [Notes] As String
	'''<![CDATA[Opportunity that is linked to the contact person]]>
	Public Property [Opportunity] As Guid?
	'''<![CDATA[Last name of partner]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PartnerName] As String
	'''<![CDATA[Middlename of partner]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PartnerNamePrefix] As String
	'''<![CDATA[Reference to the personal information of this contact such as name, gender, address etc.]]>
	Public Property [Person] As Guid?
	'''<![CDATA[Phone of the contact]]>
	Public Property [Phone] As String
	'''<![CDATA[Phone extension of the contact]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PhoneExtension] As String
	'''<![CDATA[This field is write-only. The picture can be downloaded through PictureUrl and PictureThumbnailUrl.]]>
	Public Property [Picture] As Byte()
	'''<![CDATA[Filename of the picture]]>
	Public Property [PictureName] As String
	'''<![CDATA[Url to retrieve the picture thumbnail]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PictureThumbnailUrl] As String
	'''<![CDATA[Url to retrieve the picture]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PictureUrl] As String
	'''<![CDATA[Postcode]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Postcode] As String
	'''<![CDATA[Social security number]]>
	Public Property [SocialSecurityNumber] As String
	'''<![CDATA[Start date]]>
	Public Property [StartDate] As DateTime?
	'''<![CDATA[State]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [State] As String
	'''<![CDATA[Title]]>
	Public Property [Title] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("CurrencyCode")>
Public Class OutstandingInvoiceOverview
	'''<![CDATA[Primary key]]>
	Public Property [CurrencyCode] As String
	'''<![CDATA[Total invoice amount to be paid]]>
	Public Property [OutstandingPayableInvoiceAmount] As Double
	'''<![CDATA[Number of invoices to be paid]]>
	Public Property [OutstandingPayableInvoiceCount] As Double
	'''<![CDATA[Total invoice amount to be received]]>
	Public Property [OutstandingReceivableInvoiceAmount] As Double
	'''<![CDATA[Number of invoices to be received]]>
	Public Property [OutstandingReceivableInvoiceCount] As Double
	'''<![CDATA[Total payable invoice amount that is overdue]]>
	Public Property [OverduePayableInvoiceAmount] As Double
	'''<![CDATA[Number of payable invoices that are overdue]]>
	Public Property [OverduePayableInvoiceCount] As Double
	'''<![CDATA[Total receivable invoice amount that is overdue]]>
	Public Property [OverdueReceivableInvoiceAmount] As Double
	'''<![CDATA[Number of receivable invoices that are overdue]]>
	Public Property [OverdueReceivableInvoiceCount] As Double
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("HID")>
Public Class Payable
	'''<![CDATA[Code of Account]]>
	Public Property [AccountCode] As String
	'''<![CDATA[Reference to the account]]>
	Public Property [AccountId] As Guid
	'''<![CDATA[Name of Account]]>
	Public Property [AccountName] As String
	'''<![CDATA[Amount]]>
	Public Property [Amount] As Double
	'''<![CDATA[Amount in transit]]>
	Public Property [AmountInTransit] As Double
	'''<![CDATA[Code of Currency]]>
	Public Property [CurrencyCode] As String
	'''<![CDATA[Description]]>
	Public Property [Description] As String
	'''<![CDATA[Date the invoice should be paid]]>
	Public Property [DueDate] As DateTime
	'''<![CDATA[Entry number]]>
	Public Property [EntryNumber] As Int32
	'''<![CDATA[Primary key, human readable ID]]>
	Public Property [HID] As Int64
	'''<![CDATA[Obsolete]]>
	Public Property [Id] As Guid
	'''<![CDATA[Invoice date]]>
	Public Property [InvoiceDate] As DateTime
	'''<![CDATA[Invoice number]]>
	Public Property [InvoiceNumber] As Int32
	'''<![CDATA[Code of Journal]]>
	Public Property [JournalCode] As String
	'''<![CDATA[Description of Journal]]>
	Public Property [JournalDescription] As String
	'''<![CDATA[Your reference]]>
	Public Property [YourRef] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class PaymentCondition
	'''<![CDATA[Code of the payment condition]]>
	Public Property [Code] As String
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Default credit management scenario to be used for new payment terms]]>
	Public Property [CreditManagementScenario] As Guid?
	'''<![CDATA[Code of CreditManagementScenario]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreditManagementScenarioCode] As String
	'''<![CDATA[Description of CreditManagementScenario]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreditManagementScenarioDescription] As String
	'''<![CDATA[Description of the payment condition]]>
	Public Property [Description] As String
	'''<![CDATA[Indicates how the discount amount is calculated. Values: E = Excluding VAT, I = Including VAT]]>
	Public Property [DiscountCalculation] As String
	'''<![CDATA[Number of days to pay within, to have the right to take the discount]]>
	Public Property [DiscountPaymentDays] As Int32?
	'''<![CDATA[Discount percentage]]>
	Public Property [DiscountPercentage] As Double?
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Number of days to be included in the due date calculation. Example: invoice date = 17/01 PaymentEndOfMonths = 2 => 31/03 PaymentDays = 15 => 15/04]]>
	Public Property [PaymentDays] As Int32?
	'''<![CDATA[Type of payment discount. Values: B = Settlement discount, K = Credit surcharge]]>
	Public Property [PaymentDiscountType] As String
	'''<![CDATA[Number of month endings to be included in the due date calculation]]>
	Public Property [PaymentEndOfMonths] As Int32?
	'''<![CDATA[Method of payment. Values: B = On credit, I = Collection, K = Cash]]>
	Public Property [PaymentMethod] As String
	'''<![CDATA[Percentage (stored as fraction) of total invoice amount]]>
	Public Property [Percentage] As Double?
	'''<![CDATA[Indicates how the VAT amount is calculated Values: E = Excluding discount, I = Including discount]]>
	Public Property [VATCalculation] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("Year,Period")>
Public Class PeriodRevenue
	'''<![CDATA[Total amount in the default currency of the company]]>
	Public Property [Amount] As Double
	'''<![CDATA[Reporting period]]>
	Public Property [Period] As Int32
	'''<![CDATA[Reporting year]]>
	Public Property [Year] As Int32
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class PriceList
	'''<![CDATA[Code to indicate the price list]]>
	Public Property [Code] As String
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[All prices in the price list are stored in this currency]]>
	Public Property [Currency] As String
	'''<![CDATA[Description]]>
	Public Property [Description] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Description of Division]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DivisionDescription] As String
	'''<![CDATA[Indicates the entity (Item, Item group, ..) on which this price list is based]]>
	Public Property [Entity] As Int16?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Explanation or extra information can be stored in the notes]]>
	Public Property [Notes] As String
End Class

<SupportedActionsSDK(True, False, False, False)>
<DataServiceKey("QuotationID")>
Public Class PrintedQuotation
	'''<![CDATA[Division code]]>
	Public Property [Division] As Int32
	'''<![CDATA[Contains the id of the document that was created]]>
	Public Property [Document] As Guid?
	'''<![CDATA[Contains the error message if an error occurred during the creation of the document]]>
	Public Property [DocumentCreationError] As String
	'''<![CDATA[Contains information if a document was successfully created]]>
	Public Property [DocumentCreationSuccess] As String
	'''<![CDATA[Based on this layout a PDF is created and attached to an Exact Online document and an email. In case it is not specified, the default layout is used.]]>
	Public Property [DocumentLayout] As Guid?
	'''<![CDATA[Contains the error message if an error occurred during the creation of the Email]]>
	Public Property [EmailCreationError] As String
	'''<![CDATA[Based on this layout the email text is produced. In case it is not specified, the default layout is used.]]>
	Public Property [EmailLayout] As Guid?
	'''<![CDATA[Extra text that can be added to the printed document and email]]>
	Public Property [ExtraText] As String
	'''<![CDATA[Date of the quotation printed]]>
	Public Property [QuotationDate] As DateTime
	'''<![CDATA[Identifier of the quotation]]>
	Public Property [QuotationID] As Guid
	'''<![CDATA[Set to True if an email containing the quotation should be sent to the customer]]>
	Public Property [SendEmailToCustomer] As Boolean
	'''<![CDATA[Email address from which the email will be sent. If not specified, the company email address will be used.]]>
	Public Property [SenderEmailAddress] As String
End Class

<SupportedActionsSDK(True, False, False, False)>
<DataServiceKey("InvoiceID")>
Public Class PrintedSalesInvoice
	'''<![CDATA[Division code]]>
	Public Property [Division] As Int32?
	'''<![CDATA[Contains the id of the document that was created]]>
	Public Property [Document] As Guid?
	'''<![CDATA[Contains the error message if an error occurred during the creation of the document]]>
	Public Property [DocumentCreationError] As String
	'''<![CDATA[Contains information if a document was succesfully created]]>
	Public Property [DocumentCreationSuccess] As String
	'''<![CDATA[Based on this layout a PDF is created and attached to an Exact Online document and an email]]>
	Public Property [DocumentLayout] As Guid?
	'''<![CDATA[Contains the error message if an error occurred during the creation of the email]]>
	Public Property [EmailCreationError] As String
	'''<![CDATA[Contains confirmation that an email was sent. If an email cannot be delivered this property will still show confirmation that the email was sent.]]>
	Public Property [EmailCreationSuccess] As String
	'''<![CDATA[Based on this layout the email text is produced]]>
	Public Property [EmailLayout] As Guid?
	'''<![CDATA[Extra text that can be added to the printed document and email]]>
	Public Property [ExtraText] As String
	'''<![CDATA[Date of the invoice]]>
	Public Property [InvoiceDate] As DateTime?
	'''<![CDATA[Primary key, Reference to EntryID of SalesInvoice]]>
	Public Property [InvoiceID] As Guid
	'''<![CDATA[Contains the error message if an error occurred during the sending of a postbox message]]>
	Public Property [PostboxMessageCreationError] As String
	'''<![CDATA[Contains information if a postbox message was succesfully sent]]>
	Public Property [PostboxMessageCreationSuccess] As String
	'''<![CDATA[The postbox from where the message is sent]]>
	Public Property [PostboxSender] As Guid?
	'''<![CDATA[Reporting period]]>
	Public Property [ReportingPeriod] As Int32?
	'''<![CDATA[Reporting year]]>
	Public Property [ReportingYear] As Int32?
	'''<![CDATA[Set to True if an email containing the invoice should be sent to the invoice customer]]>
	Public Property [SendEmailToCustomer] As Boolean?
	'''<![CDATA[Email address from which the email will be sent. If not specified, the company email address will be used.]]>
	Public Property [SenderEmailAddress] As String
	'''<![CDATA[Set to True if a postbox message containing the invoice should be sent to the invoice customer]]>
	Public Property [SendInvoiceToCustomerPostbox] As Boolean?
	'''<![CDATA[Set to True if the output preference should be taken from the account. It will be either Paper, Email, Digital postbox. This option overrules both SendEmailToCustomer and SendInvoiceToCustomerPostbox.]]>
	Public Property [SendOutputBasedOnAccount] As Boolean?
End Class

<SupportedActionsSDK(True, False, False, False)>
<DataServiceKey("OrderId")>
Public Class PrintedSalesOrder
	'''<![CDATA[Division code]]>
	Public Property [Division] As Int32?
	'''<![CDATA[Contains the id of the document that was created]]>
	Public Property [Document] As Guid?
	'''<![CDATA[Contains the error message if an error occurred during the creation of the document]]>
	Public Property [DocumentCreationError] As String
	'''<![CDATA[Contains information if a document was succesfully created]]>
	Public Property [DocumentCreationSuccess] As String
	'''<![CDATA[Based on this layout a PDF is created and attached to an Exact Online document and an email]]>
	Public Property [DocumentLayout] As Guid?
	'''<![CDATA[Contains the error message if an error occurred during the creation of the email]]>
	Public Property [EmailCreationError] As String
	'''<![CDATA[Contains confirmation that an email was sent. If an email cannot be delivered this property will still show confirmation that the email was sent.]]>
	Public Property [EmailCreationSuccess] As String
	'''<![CDATA[Based on this layout the email text is produced]]>
	Public Property [EmailLayout] As Guid?
	'''<![CDATA[Extra text that can be added to the printed document and email]]>
	Public Property [ExtraText] As String
	'''<![CDATA[Primary key, Reference to OrderID of SalesOrder]]>
	Public Property [OrderId] As Guid
	'''<![CDATA[Set to True if an email containing the sales order should be sent to the customer]]>
	Public Property [SendEmailToCustomer] As Boolean?
	'''<![CDATA[Email address from which the email will be sent. If not specified, the company email address will be used.]]>
	Public Property [SenderEmailAddress] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class ProductionArea
	'''<![CDATA[Code of the production area group]]>
	Public Property [Code] As String
	'''<![CDATA[Reference to Cost center]]>
	Public Property [Costcenter] As String
	'''<![CDATA[Description of Costcenter]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostcenterDescription] As String
	'''<![CDATA[Reference to Cost unit]]>
	Public Property [Costunit] As String
	'''<![CDATA[Description of Costunit]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostunitDescription] As String
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Description of the production area]]>
	Public Property [Description] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Indicates if this is the default production area. This will be used when creating a new production area]]>
	Public Property [IsDefault] As Byte
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Production area notes]]>
	Public Property [Notes] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("CurrentYear")>
Public Class ProfitLossOverview
	'''<![CDATA[Costs in current period]]>
	Public Property [CostsCurrentPeriod] As Double
	'''<![CDATA[Costs in current year]]>
	Public Property [CostsCurrentYear] As Double
	'''<![CDATA[Costs in previous year]]>
	Public Property [CostsPreviousYear] As Double
	'''<![CDATA[Costs in period of previous year]]>
	Public Property [CostsPreviousYearPeriod] As Double
	'''<![CDATA[Currency code]]>
	Public Property [CurrencyCode] As String
	'''<![CDATA[Current period]]>
	Public Property [CurrentPeriod] As Int32
	'''<![CDATA[Primary key, Current year]]>
	Public Property [CurrentYear] As Int32
	'''<![CDATA[Previous year]]>
	Public Property [PreviousYear] As Int32
	'''<![CDATA[Period in previous year]]>
	Public Property [PreviousYearPeriod] As Int32
	'''<![CDATA[Results of current period]]>
	Public Property [ResultCurrentPeriod] As Double
	Public Property [ResultCurrentYear] As Double
	Public Property [ResultPreviousYear] As Double
	'''<![CDATA[Results of period in previous year]]>
	Public Property [ResultPreviousYearPeriod] As Double
	'''<![CDATA[Revenue in current period]]>
	Public Property [RevenueCurrentPeriod] As Double
	'''<![CDATA[Revenue in current year]]>
	Public Property [RevenueCurrentYear] As Double
	'''<![CDATA[Revenue in previous year]]>
	Public Property [RevenuePreviousYear] As Double
	'''<![CDATA[Revenue in period of previous year]]>
	Public Property [RevenuePreviousYearPeriod] As Double
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class Project
	'''<![CDATA[The account for this project]]>
	Public Property [Account] As Guid?
	'''<![CDATA[Code of Account]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountCode] As String
	'''<![CDATA[Contact person of Account]]>
	Public Property [AccountContact] As Guid?
	'''<![CDATA[Name of Account]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountName] As String
	'''<![CDATA[Is additional invoice is allowed for project]]>
	Public Property [AllowAdditionalInvoicing] As Boolean?
	'''<![CDATA[Block time and cost entries]]>
	Public Property [BlockEntry] As Boolean?
	'''<![CDATA[Block rebilling]]>
	Public Property [BlockRebilling] As Boolean?
	'''<![CDATA[Budgeted amount of sales in the default currency of the company]]>
	Public Property [BudgetedAmount] As Double?
	'''<![CDATA[Budgeted amount of costs in the default currency of the company]]>
	Public Property [BudgetedCosts] As Double?
	'''<![CDATA[Collection of budgeted hours]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [BudgetedHoursPerHourType] As IEnumerable(Of ProjectHourBudget)
	'''<![CDATA[Budgeted amount of revenue in the default currency of the company]]>
	Public Property [BudgetedRevenue] As Double?
	'''<![CDATA[Budget type]]>
	Public Property [BudgetType] As Int16?
	'''<![CDATA[Budget type description]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [BudgetTypeDescription] As String
	'''<![CDATA[Used only for PSA to link a project classification to the project]]>
	Public Property [Classification] As Guid?
	'''<![CDATA[Description of Classification]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ClassificationDescription] As String
	'''<![CDATA[Code]]>
	Public Property [Code] As String
	'''<![CDATA[Used only for PSA to store the budgetted costs of a project (except for project type Campaign and Non-billable). Positive quantities only]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostsAmountFC] As Double?
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Used only for PSA to store the customer's PO number]]>
	Public Property [CustomerPOnumber] As String
	'''<![CDATA[Description of the project]]>
	Public Property [Description] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Name of Division]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DivisionName] As String
	'''<![CDATA[End date of the project. In combination with the start date the status is determined]]>
	Public Property [EndDate] As DateTime?
	'''<![CDATA[Item used for fixed price invoicing. To be defined per project. If empty the functionality relies on the setting]]>
	Public Property [FixedPriceItem] As Guid?
	'''<![CDATA[Description of FixedPriceItem]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [FixedPriceItemDescription] As String
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Is invoice as quoted]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [InvoiceAsQuoted] As Boolean
	'''<![CDATA[Collection of invoice terms]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [InvoiceTerms] As IEnumerable(Of ProjectTerm)
	'''<![CDATA[Responsible person for this project]]>
	Public Property [Manager] As Guid?
	'''<![CDATA[Name of Manager]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ManagerFullname] As String
	'''<![CDATA[Purchase markup percentage]]>
	Public Property [MarkupPercentage] As Double?
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[For additional information about projects]]>
	Public Property [Notes] As String
	'''<![CDATA[Used only for PSA. This item is used for prepaid invoicing. If left empty, the functionality relies on a setting]]>
	Public Property [PrepaidItem] As Guid?
	'''<![CDATA[Description of PrepaidItem]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PrepaidItemDescription] As String
	'''<![CDATA[Reference to ProjectPrepaidTypes]]>
	Public Property [PrepaidType] As Int16?
	'''<![CDATA[Description of PrepaidType]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PrepaidTypeDescription] As String
	'''<![CDATA[Collection of employee restrictions]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectRestrictionEmployees] As IEnumerable(Of ProjectRestrictionEmployee)
	'''<![CDATA[Collection of item restrictions]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectRestrictionItems] As IEnumerable(Of ProjectRestrictionItem)
	'''<![CDATA[Collection of rebilling restrictions]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectRestrictionRebillings] As IEnumerable(Of ProjectRestrictionRebilling)
	'''<![CDATA[Budgeted time. Total number of hours estimated for the fixed price project]]>
	Public Property [SalesTimeQuantity] As Double?
	'''<![CDATA[Source quotation]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SourceQuotation] As Guid?
	'''<![CDATA[Start date of a project. In combination with the end date the status is determined]]>
	Public Property [StartDate] As DateTime?
	Public Property [TimeQuantityToAlert] As Double?
	'''<![CDATA[Reference to ProjectTypes]]>
	Public Property [Type] As Int32?
	'''<![CDATA[Description of Type]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [TypeDescription] As String
	'''<![CDATA[Using billing milestones]]>
	Public Property [UseBillingMilestones] As Boolean?
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class ProjectBudgetType
	'''<![CDATA[Description]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Description] As String
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Int16
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class ProjectHourBudget
	'''<![CDATA[Number of hours]]>
	Public Property [Budget] As Double?
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Division number]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Hour type of budget]]>
	Public Property [Item] As Guid?
	'''<![CDATA[Code of hour type]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemCode] As String
	'''<![CDATA[Description of hour type]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemDescription] As String
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Reference to project]]>
	Public Property [Project] As Guid
	'''<![CDATA[Code of project]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectCode] As String
	'''<![CDATA[Description of project]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectDescription] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class ProjectRestrictionEmployee
	'''<![CDATA[Date created]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[Creator user ID]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Creator name]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Employee linked to the restriction]]>
	Public Property [Employee] As Guid?
	'''<![CDATA[Name of employee]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [EmployeeFullName] As String
	'''<![CDATA[Readable ID of the employee]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [EmployeeHID] As Int32?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Date modified]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[Modifier user ID]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Modifier name]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Project linked to the restriction]]>
	Public Property [Project] As Guid?
	'''<![CDATA[Project code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectCode] As String
	'''<![CDATA[Project description]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectDescription] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class ProjectRestrictionItem
	'''<![CDATA[Date created]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[Creator user ID]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Creator name]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Item linked to the restriction]]>
	Public Property [Item] As Guid?
	'''<![CDATA[Item code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemCode] As String
	'''<![CDATA[Description of the item]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemDescription] As String
	'''<![CDATA[Indicates if the item is a time unit item]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemIsTime] As Byte?
	'''<![CDATA[Date modified]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[Modifier user ID]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Modifier name]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Project linked to the restriction]]>
	Public Property [Project] As Guid?
	'''<![CDATA[Project code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectCode] As String
	'''<![CDATA[Project description]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectDescription] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class ProjectRestrictionRebilling
	'''<![CDATA[Cost type reference]]>
	Public Property [CostTypeRebill] As Guid?
	'''<![CDATA[Cost type code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostTypeRebillCode] As String
	'''<![CDATA[Cost type description]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostTypeRebillDescription] As String
	'''<![CDATA[Date created]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[Creator user ID]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Creator name]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Date modified]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[Modifier user ID]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Modifier name]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Project linked to the restriction]]>
	Public Property [Project] As Guid?
	'''<![CDATA[Project code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectCode] As String
	'''<![CDATA[Project description]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectDescription] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class ProjectTerm
	'''<![CDATA[Amount in the currency of the transaction]]>
	Public Property [Amount] As Double?
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[WBS's deliverable linked to invoice term]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Deliverable] As String
	'''<![CDATA[Description of invoice term]]>
	Public Property [Description] As String
	'''<![CDATA[Division number]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Invoice date]]>
	Public Property [InvoiceDate] As DateTime?
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Notes]]>
	Public Property [Notes] As String
	'''<![CDATA[Percentage of amount per project's budgeted amount]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Percentage] As Double?
	'''<![CDATA[Reference to project]]>
	Public Property [Project] As Guid?
	'''<![CDATA[Description of project]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectDescription] As String
	'''<![CDATA[Reference to VATCode]]>
	Public Property [VATCode] As String
	'''<![CDATA[Description of VATCode]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [VATCodeDescription] As String
	'''<![CDATA[VATCode percentage]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [VATPercentage] As Double?
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("EntryID")>
Public Class PurchaseEntry
	'''<![CDATA[Amount in the default currency of the company]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AmountDC] As Double?
	'''<![CDATA[Amount in the currency of the transaction]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AmountFC] As Double?
	'''<![CDATA[Batch number]]>
	Public Property [BatchNumber] As Int32?
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Currency code]]>
	Public Property [Currency] As String
	'''<![CDATA[Description]]>
	Public Property [Description] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Reference to document]]>
	Public Property [Document] As Guid?
	'''<![CDATA[Document number]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DocumentNumber] As Int32?
	'''<![CDATA[Document subject]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DocumentSubject] As String
	'''<![CDATA[Date when payment should be done]]>
	Public Property [DueDate] As DateTime?
	'''<![CDATA[Entry date]]>
	Public Property [EntryDate] As DateTime?
	'''<![CDATA[Primary key]]>
	Public Property [EntryID] As Guid
	'''<![CDATA[Entry number]]>
	Public Property [EntryNumber] As Int32?
	'''<![CDATA[Description of ExternalLink]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ExternalLinkDescription] As String
	Public Property [ExternalLinkReference] As String
	'''<![CDATA[Invoice number]]>
	Public Property [InvoiceNumber] As Int32?
	'''<![CDATA[Journal]]>
	Public Property [Journal] As String
	'''<![CDATA[Description of Journal]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [JournalDescription] As String
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Order number]]>
	Public Property [OrderNumber] As Int32?
	'''<![CDATA[Payment condition]]>
	Public Property [PaymentCondition] As String
	'''<![CDATA[Description of PaymentCondition]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PaymentConditionDescription] As String
	Public Property [ProcessNumber] As Int32?
	'''<![CDATA[Collection of lines]]>
	Public Property [PurchaseEntryLines] As IEnumerable(Of PurchaseEntryLine)
	'''<![CDATA[Currency exchange rate]]>
	Public Property [Rate] As Double?
	'''<![CDATA[Reporting period]]>
	Public Property [ReportingPeriod] As Int16?
	'''<![CDATA[Reporting year]]>
	Public Property [ReportingYear] As Int16?
	'''<![CDATA[Indicates that amounts are reversed]]>
	Public Property [Reversal] As Boolean?
	'''<![CDATA[Status: 5 = Rejected, 20 = Open, 50 = Processed]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Status] As Int16?
	'''<![CDATA[Description of Status]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [StatusDescription] As String
	'''<![CDATA[Reference to supplier (account)]]>
	Public Property [Supplier] As Guid?
	'''<![CDATA[Name of supplier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SupplierName] As String
	'''<![CDATA[Type: 30 = Purchase entry, 31 = Purchase credit note]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Type] As Int32?
	'''<![CDATA[Description of Type]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [TypeDescription] As String
	'''<![CDATA[Vat Amount in the default currency of the company]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [VATAmountDC] As Double?
	'''<![CDATA[Vat Amount in the currency of the transaction]]>
	Public Property [VATAmountFC] As Double?
	'''<![CDATA[Your reference]]>
	Public Property [YourRef] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class PurchaseEntryLine
	'''<![CDATA[Amount in the default currency of the company]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AmountDC] As Double?
	'''<![CDATA[Amount in the currency of the transaction]]>
	Public Property [AmountFC] As Double?
	'''<![CDATA[Reference to asset]]>
	Public Property [Asset] As Guid?
	'''<![CDATA[Asset description]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AssetDescription] As String
	'''<![CDATA[Reference to cost center]]>
	Public Property [CostCenter] As String
	'''<![CDATA[Description of CostCenter]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostCenterDescription] As String
	'''<![CDATA[Reference to cost unit]]>
	Public Property [CostUnit] As String
	'''<![CDATA[Description of CostUnit]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostUnitDescription] As String
	'''<![CDATA[Description]]>
	Public Property [Description] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Reference to header of the purchase entry]]>
	Public Property [EntryID] As Guid
	'''<![CDATA[General ledger account]]>
	Public Property [GLAccount] As Guid?
	'''<![CDATA[Code of GLAccount]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLAccountCode] As String
	'''<![CDATA[Description of GLAccount]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLAccountDescription] As String
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Line number]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [LineNumber] As Int32?
	'''<![CDATA[Extra remarks]]>
	Public Property [Notes] As String
	'''<![CDATA[Reference to project]]>
	Public Property [Project] As Guid?
	'''<![CDATA[Description of Project]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectDescription] As String
	'''<![CDATA[Quantity]]>
	Public Property [Quantity] As Double?
	'''<![CDATA[Serial number]]>
	Public Property [SerialNumber] As String
	'''<![CDATA[Reference to subscription]]>
	Public Property [Subscription] As Guid?
	'''<![CDATA[Description of Subscription]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SubscriptionDescription] As String
	'''<![CDATA[Reference to tracking number]]>
	Public Property [TrackingNumber] As Guid?
	'''<![CDATA[Description of TrackingNumber]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [TrackingNumberDescription] As String
	'''<![CDATA[Type: 30 = Purchase entry, 31 = Purchase credit note]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Type] As Int32?
	'''<![CDATA[VAT amount in the default currency of the company]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [VATAmountDC] As Double?
	'''<![CDATA[VAT amount in the currency of the transaction. Use this property to specify a VAT amount that differs from the VAT amount that is automatically calculated.]]>
	Public Property [VATAmountFC] As Double?
	'''<![CDATA[VAT base amount in the default currency of the company]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [VATBaseAmountDC] As Double?
	'''<![CDATA[VAT base amount in the currency of the transaction]]>
	Public Property [VATBaseAmountFC] As Double?
	'''<![CDATA[VAT code]]>
	Public Property [VATCode] As String
	'''<![CDATA[Description of VATCode]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [VATCodeDescription] As String
	'''<![CDATA[VAT percentage]]>
	Public Property [VATPercentage] As Double?
	'''<![CDATA[Withholding tax amount for spanish legislation]]>
	Public Property [WithholdingAmountDC] As Double?
	'''<![CDATA[Withholding tax key for spanish legislation]]>
	Public Property [WithholdingTax] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("PurchaseOrderID")>
Public Class PurchaseOrder
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Currency code]]>
	Public Property [Currency] As String
	'''<![CDATA[Reference to account for delivery]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DeliveryAccount] As Guid?
	'''<![CDATA[Delivery account code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DeliveryAccountCode] As String
	'''<![CDATA[Account name]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DeliveryAccountName] As String
	'''<![CDATA[Reference to shipping address]]>
	Public Property [DeliveryAddress] As Guid?
	'''<![CDATA[Reference to contact for delivery]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DeliveryContact] As Guid?
	'''<![CDATA[Name of the contact person of the customer who will receive delivered goods]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DeliveryContactPersonFullName] As String
	'''<![CDATA[Description of the purchase order]]>
	Public Property [Description] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Document that is manually linked to the purchase order]]>
	Public Property [Document] As Guid?
	'''<![CDATA[Subject of the document]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DocumentSubject] As String
	'''<![CDATA[Shows if it is a drop shipment purchase order]]>
	Public Property [DropShipment] As Boolean?
	'''<![CDATA[Allows you to set the currency for the invoice. You can only do this if you have checked the Variable: Currency and Variable: Exchange rate fields in the sales journal settings. Once a line has been created in the invoice, the currency can no longer be changed.]]>
	Public Property [ExchangeRate] As Double?
	'''<![CDATA[Invoice status of purchase order: 10-Open, 20-Partial, 30-Complete, 40-Canceled]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [InvoiceStatus] As Int32?
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Order date]]>
	Public Property [OrderDate] As DateTime?
	'''<![CDATA[Human readable id of the purchase order]]>
	Public Property [OrderNumber] As Int32?
	'''<![CDATA[Purchase order status: 10-Open, 20-Partial, 30-Complete, 40-Canceled]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [OrderStatus] As Int32?
	'''<![CDATA[The payment condition code used for due date and discount calculation]]>
	Public Property [PaymentCondition] As String
	'''<![CDATA[Description of payment condition]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PaymentConditionDescription] As String
	'''<![CDATA[Primary key]]>
	Public Property [PurchaseOrderID] As Guid
	'''<![CDATA[Collection of lines]]>
	Public Property [PurchaseOrderLines] As IEnumerable(Of PurchaseOrderLine)
	'''<![CDATA[This field shows the date the goods are expected to be received.]]>
	Public Property [ReceiptDate] As DateTime?
	'''<![CDATA[Receipt status of purchase order: 10-Open, 20-Partial, 30-Complete, 40-Canceled]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ReceiptStatus] As Int32?
	'''<![CDATA[Include any relevant remarks regarding the purchase order.]]>
	Public Property [Remarks] As String
	'''<![CDATA[Reference to sales order when purchase order generated via back to back sales order]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SalesOrder] As Guid?
	'''<![CDATA[Number of sales order]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SalesOrderNumber] As Int32?
	'''<![CDATA[This shows how the purchase order was created: 1-Manual entry, 2-Import, 3-Other, 4-Purchase order, 5-Sales order, 6-Supplier's items, 7-Subcontract, 8-Purchase order advice, 9-Shop order, 10-MRP calculation]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Source] As Int16?
	'''<![CDATA[Reference to supplier account]]>
	Public Property [Supplier] As Guid?
	'''<![CDATA[Code of supplier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SupplierCode] As String
	'''<![CDATA[Contact of supplier]]>
	Public Property [SupplierContact] As Guid?
	'''<![CDATA[Contact person full name of supplier]]>
	Public Property [SupplierContactPersonFullName] As String
	'''<![CDATA[Name of supplier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SupplierName] As String
	'''<![CDATA[Warehouse]]>
	Public Property [Warehouse] As Guid?
	'''<![CDATA[Code of Warehouse]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [WarehouseCode] As String
	'''<![CDATA[Description of Warehouse]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [WarehouseDescription] As String
	'''<![CDATA[Shows the reference number associated with the purchase order. Enter a description and reference to make the purchase order easier to identify.]]>
	Public Property [YourRef] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class PurchaseOrderLine
	'''<![CDATA[Amount in the default currency of the company]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AmountDC] As Double?
	'''<![CDATA[Amount in the currency of the transaction]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AmountFC] As Double?
	'''<![CDATA[Reference to Cost center]]>
	Public Property [CostCenter] As String
	'''<![CDATA[Description of CostCenter]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostCenterDescription] As String
	'''<![CDATA[Reference to Cost unit]]>
	Public Property [CostUnit] As String
	'''<![CDATA[Description of CostUnit]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostUnitDescription] As String
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Description of sales order delivery]]>
	Public Property [Description] As String
	'''<![CDATA[Discount in percentage for item]]>
	Public Property [Discount] As Double?
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[The current stock level of items shown in stock unit. The information is displayed only for items with the stock property selected.]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [InStock] As Double?
	'''<![CDATA[Quantity of item that has been invoiced]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [InvoicedQuantity] As Double?
	'''<![CDATA[Reference to the item for purchase order]]>
	Public Property [Item] As Guid?
	'''<![CDATA[Item code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemCode] As String
	'''<![CDATA[Description of item]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemDescription] As String
	'''<![CDATA[Indicates if fractional quantities of the item can be used, for example quantity = 0.4]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemDivisable] As Boolean?
	'''<![CDATA[Line number]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [LineNumber] As Int32?
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[The net price is the unit price (VAT code taken into account) with any discount applied]]>
	Public Property [NetPrice] As Double?
	'''<![CDATA[Notes]]>
	Public Property [Notes] As String
	'''<![CDATA[The current stock level + the planned quantity to be received - the planned quantity to deliver shown in stock unit.]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectedStock] As Double?
	'''<![CDATA[Identifies the purchase order. All the lines of a purchase order have the same PurchaseOrderID]]>
	Public Property [PurchaseOrderID] As Guid
	'''<![CDATA[Quantity for the item that needs to be invoiced]]>
	Public Property [Quantity] As Double?
	'''<![CDATA[Date the goods are expected to be received]]>
	Public Property [ReceiptDate] As DateTime?
	'''<![CDATA[Quantity of goods received]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ReceivedQuantity] As Double?
	'''<![CDATA[Sales order that is linked to a back to back sales order in purchase order]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SalesOrder] As Guid?
	'''<![CDATA[Number of sales order]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SalesOrderNumber] As Int32?
	'''<![CDATA[Code the supplier uses for this item]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SupplierItemCode] As String
	'''<![CDATA[Code of item unit]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Unit] As String
	'''<![CDATA[Description of unit]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [UnitDescription] As String
	'''<![CDATA[Item price per unit]]>
	Public Property [UnitPrice] As Double?
	'''<![CDATA[Amount of VAT charges calculated from total amount and vat percentage]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [VATAmount] As Double?
	'''<![CDATA[The VAT code used when the invoice was registered]]>
	Public Property [VATCode] As String
	'''<![CDATA[Description of vat code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [VATDescription] As String
	'''<![CDATA[The VAT percentage of the VAT code. This is the percentage at the moment the invoice is created. It's also used by the default calculation of VAT amounts and VAT base amounts]]>
	Public Property [VATPercentage] As Double?
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("QuotationID")>
Public Class Quotation
	'''<![CDATA[Amount in the default currency of the company]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AmountDC] As Double
	'''<![CDATA[Amount in the currency of the transaction]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AmountFC] As Double
	'''<![CDATA[Date on which the customer accepted or rejected the quotation version]]>
	Public Property [CloseDate] As DateTime?
	'''<![CDATA[Date and time on which the quotation was created]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime
	'''<![CDATA[User ID of the creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of the creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[The currency of the quotation]]>
	Public Property [Currency] As String
	'''<![CDATA[The account where the items should delivered]]>
	Public Property [DeliveryAccount] As Guid?
	'''<![CDATA[The code of the delivery account]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DeliveryAccountCode] As String
	'''<![CDATA[The contact person of the delivery account]]>
	Public Property [DeliveryAccountContact] As Guid?
	'''<![CDATA[Full name of the delivery account contact person]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DeliveryAccountContactFullName] As String
	'''<![CDATA[The name of the delivery account]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DeliveryAccountName] As String
	'''<![CDATA[The id of the delivery address]]>
	Public Property [DeliveryAddress] As Guid?
	'''<![CDATA[The description of the quotation]]>
	Public Property [Description] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32
	'''<![CDATA[The account to which the invoice is sent]]>
	Public Property [InvoiceAccount] As Guid?
	'''<![CDATA[The code of the invoice account]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [InvoiceAccountCode] As String
	'''<![CDATA[The contact person of the invoice account]]>
	Public Property [InvoiceAccountContact] As Guid?
	'''<![CDATA[Full name of the invoice account contact person]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [InvoiceAccountContactFullName] As String
	'''<![CDATA[The name of the invoice account]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [InvoiceAccountName] As String
	'''<![CDATA[Date and time on which the quotation was last modified]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime
	'''<![CDATA[User ID of the modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of the modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[The account that requested the quotation]]>
	Public Property [OrderAccount] As Guid?
	'''<![CDATA[The code of the order account]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [OrderAccountCode] As String
	'''<![CDATA[The contact person of the order account]]>
	Public Property [OrderAccountContact] As Guid?
	'''<![CDATA[Full name of the order account contact person]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [OrderAccountContactFullName] As String
	'''<![CDATA[The name of the order account]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [OrderAccountName] As String
	'''<![CDATA[Date on which the quotation version is entered or printed. Both during entering and printing this date can be adjusted]]>
	Public Property [QuotationDate] As DateTime?
	'''<![CDATA[Identifier of the quotation]]>
	Public Property [QuotationID] As Guid
	'''<![CDATA[The collection of quotation lines]]>
	Public Property [QuotationLines] As IEnumerable(Of QuotationLine)
	'''<![CDATA[Unique number to indentify the quotation. By default this number is based on the setting for first available number]]>
	Public Property [QuotationNumber] As Int32
	'''<![CDATA[Extra text that can be added to the quotation]]>
	Public Property [Remarks] As String
	'''<![CDATA[The user that is responsible for the quotation version]]>
	Public Property [SalesPerson] As Guid?
	'''<![CDATA[Full name of the sales person]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SalesPersonFullName] As String
	'''<![CDATA[The status of the quotation version. 5 = Rejected, 6 = Reviewed and closed, 10 = Recovery, 20 = Draft, 25 = Open, 35 = Processing... , 40 = Printed, 50 = Accepted]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Status] As Int16?
	'''<![CDATA[The description of the status]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [StatusDescription] As String
	'''<![CDATA[Total VAT amount in the currency of the transaction]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [VATAmountFC] As Double?
	'''<![CDATA[Number indicating the different reviews which are made for the quotation]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [VersionNumber] As Int32
	'''<![CDATA[The number by which this quotation is identified by the order account]]>
	Public Property [YourRef] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class QuotationLine
	'''<![CDATA[Amount in the default currency of the company]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AmountDC] As Double
	'''<![CDATA[Amount in the currency of the transaction]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AmountFC] As Double
	'''<![CDATA[By default this contains the item description]]>
	Public Property [Description] As String
	'''<![CDATA[Discount given on the default price]]>
	Public Property [Discount] As Double?
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Reference to the item that is sold in this quotation line]]>
	Public Property [Item] As Guid?
	'''<![CDATA[Description of the item]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemDescription] As String
	'''<![CDATA[Indicates the sequence of the lines within one quotation]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [LineNumber] As Int32
	'''<![CDATA[Net price of the quotation line]]>
	Public Property [NetPrice] As Double?
	'''<![CDATA[Extra notes]]>
	Public Property [Notes] As String
	'''<![CDATA[The number of items sold in default units. The quantity shown in the entry screen is Quantity * UnitFactor]]>
	Public Property [Quantity] As Double?
	'''<![CDATA[Identifies the quotation. All the lines of a quotation have the same QuotationID]]>
	Public Property [QuotationID] As Guid
	'''<![CDATA[Unique number to indentify the quotation. By default this number is based on the setting for first available number]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [QuotationNumber] As Int32
	'''<![CDATA[Code of the item unit]]>
	Public Property [UnitCode] As String
	'''<![CDATA[Description of the item unit]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [UnitDescription] As String
	'''<![CDATA[Price per item unit]]>
	Public Property [UnitPrice] As Double?
	'''<![CDATA[VAT amount of the line in the currency of the transaction]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [VATAmountFC] As Double?
	'''<![CDATA[The VAT code that is used when the quotation is invoiced]]>
	Public Property [VATCode] As String
	'''<![CDATA[Description of the VAT code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [VATDescription] As String
	'''<![CDATA[The VAT percentage of the VAT code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [VATPercentage] As Double?
	'''<![CDATA[Number indicating the different reviews which are made for the quotation]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [VersionNumber] As Int32
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class ReasonCode
	'''<![CDATA[Indicates if the reason code is active.]]>
	Public Property [Active] As Byte?
	'''<![CDATA[Code of the reason.]]>
	Public Property [Code] As String
	'''<![CDATA[Creation date.]]>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator.]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator.]]>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Description of the reason code.]]>
	Public Property [Description] As String
	'''<![CDATA[Division code.]]>
	Public Property [Division] As Int32?
	'''<![CDATA[Primary key.]]>
	Public Property [ID] As Guid
	'''<![CDATA[Last modified date.]]>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier.]]>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier.]]>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Extra notes.]]>
	Public Property [Notes] As String
	'''<![CDATA[Type of the reason code.]]>
	Public Property [Type] As Int16?
	'''<![CDATA[Description of the type of the reason code.]]>
	Public Property [TypeDescription] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("HID")>
Public Class Receivable
	'''<![CDATA[Code of Account]]>
	Public Property [AccountCode] As String
	'''<![CDATA[Reference to the account]]>
	Public Property [AccountId] As Guid
	'''<![CDATA[Name of Account]]>
	Public Property [AccountName] As String
	'''<![CDATA[Amount]]>
	Public Property [Amount] As Double
	'''<![CDATA[Amount in transit]]>
	Public Property [AmountInTransit] As Double
	'''<![CDATA[Code of Currency]]>
	Public Property [CurrencyCode] As String
	'''<![CDATA[Description]]>
	Public Property [Description] As String
	'''<![CDATA[Date the invoice should be paid]]>
	Public Property [DueDate] As DateTime
	'''<![CDATA[Entry number]]>
	Public Property [EntryNumber] As Int32
	'''<![CDATA[Primary key, human readable ID]]>
	Public Property [HID] As Int64
	'''<![CDATA[Obsolete]]>
	Public Property [Id] As Guid
	'''<![CDATA[Invoice date]]>
	Public Property [InvoiceDate] As DateTime
	'''<![CDATA[Invoice number]]>
	Public Property [InvoiceNumber] As Int32
	'''<![CDATA[Code of Journal]]>
	Public Property [JournalCode] As String
	'''<![CDATA[Description of Journal]]>
	Public Property [JournalDescription] As String
	'''<![CDATA[Your reference]]>
	Public Property [YourRef] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("Id")>
Public Class RecentCosts
	'''<![CDATA[Code of Account]]>
	Public Property [AccountCode] As String
	'''<![CDATA[Reference to Account]]>
	Public Property [AccountId] As Guid?
	'''<![CDATA[Name of Account]]>
	Public Property [AccountName] As String
	'''<![CDATA[Amount approved]]>
	Public Property [AmountApproved] As Double
	'''<![CDATA[Amount draft]]>
	Public Property [AmountDraft] As Double
	'''<![CDATA[Amount rejected]]>
	Public Property [AmountRejected] As Double
	'''<![CDATA[Amount submitted]]>
	Public Property [AmountSubmitted] As Double
	'''<![CDATA[Code of Currency]]>
	Public Property [CurrencyCode] As String
	'''<![CDATA[Date]]>
	Public Property [Date] As DateTime
	'''<![CDATA[Entry ID]]>
	Public Property [EntryId] As Guid?
	'''<![CDATA[Reference to Expense]]>
	Public Property [Expense] As Guid?
	'''<![CDATA[Description of Expense]]>
	Public Property [ExpenseDescription] As String
	'''<![CDATA[Primary key]]>
	Public Property [Id] As Int32
	'''<![CDATA[Code of Item]]>
	Public Property [ItemCode] As String
	'''<![CDATA[Description of Item]]>
	Public Property [ItemDescription] As String
	'''<![CDATA[Reference to Item]]>
	Public Property [ItemId] As Guid?
	'''<![CDATA[Remarks]]>
	Public Property [Notes] As String
	'''<![CDATA[Code of Project]]>
	Public Property [ProjectCode] As String
	'''<![CDATA[Description of Project]]>
	Public Property [ProjectDescription] As String
	'''<![CDATA[Reference to Project]]>
	Public Property [ProjectId] As Guid?
	'''<![CDATA[Quantity approved]]>
	Public Property [QuantityApproved] As Double
	'''<![CDATA[Quantity draft]]>
	Public Property [QuantityDraft] As Double
	'''<![CDATA[Quantity rejected]]>
	Public Property [QuantityRejected] As Double
	'''<![CDATA[Quantity submitted]]>
	Public Property [QuantitySubmitted] As Double
	'''<![CDATA[Week number]]>
	Public Property [WeekNumber] As Int32
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("Id")>
Public Class RecentHours
	'''<![CDATA[Code of Account]]>
	Public Property [AccountCode] As String
	'''<![CDATA[Reference to Account]]>
	Public Property [AccountId] As Guid?
	'''<![CDATA[Name of Account]]>
	Public Property [AccountName] As String
	'''<![CDATA[Reference to Activity]]>
	Public Property [Activity] As Guid?
	'''<![CDATA[Description of Activity]]>
	Public Property [ActivityDescription] As String
	'''<![CDATA[Date]]>
	Public Property [Date] As DateTime
	'''<![CDATA[Entry ID]]>
	Public Property [EntryId] As Guid?
	'''<![CDATA[Hours approved]]>
	Public Property [HoursApproved] As Double
	'''<![CDATA[Billable hours approved]]>
	Public Property [HoursApprovedBillable] As Double
	'''<![CDATA[Hours draft]]>
	Public Property [HoursDraft] As Double
	'''<![CDATA[Billable hours draft]]>
	Public Property [HoursDraftBillable] As Double
	'''<![CDATA[Hours rejected]]>
	Public Property [HoursRejected] As Double
	'''<![CDATA[Billable hours rejected]]>
	Public Property [HoursRejectedBillable] As Double
	'''<![CDATA[Hours submitted]]>
	Public Property [HoursSubmitted] As Double
	'''<![CDATA[Billable hours submitted]]>
	Public Property [HoursSubmittedBillable] As Double
	'''<![CDATA[Primary key]]>
	Public Property [Id] As Int32
	'''<![CDATA[Code of Item]]>
	Public Property [ItemCode] As String
	'''<![CDATA[Description of Item]]>
	Public Property [ItemDescription] As String
	'''<![CDATA[Reference to Item]]>
	Public Property [ItemId] As Guid?
	'''<![CDATA[Remarks]]>
	Public Property [Notes] As String
	'''<![CDATA[Code of Project]]>
	Public Property [ProjectCode] As String
	'''<![CDATA[Description of Project]]>
	Public Property [ProjectDescription] As String
	'''<![CDATA[Reference to Project]]>
	Public Property [ProjectId] As Guid?
	'''<![CDATA[Week number]]>
	Public Property [WeekNumber] As Int32
End Class

<SupportedActionsSDK(True, False, False, False)>
<DataServiceKey("QuotationID")>
Public Class RejectedQuotation
	'''<![CDATA[Division code.]]>
	Public Property [Division] As Int32
	'''<![CDATA[Contains the error message if an error occurred during the rejection of the quotation.]]>
	Public Property [ErrorMessage] As String
	'''<![CDATA[Identifier of the quotation.]]>
	Public Property [QuotationID] As Guid
	'''<![CDATA[Reason why the quotation was rejected.]]>
	Public Property [ReasonCode] As Guid?
	'''<![CDATA[Contains information if the quotation was successfully rejected.]]>
	Public Property [SuccessMessage] As String
End Class

<SupportedActionsSDK(True, False, False, False)>
<DataServiceKey("QuotationID")>
Public Class ReopenedQuotation
	'''<![CDATA[Division code.]]>
	Public Property [Division] As Int32
	'''<![CDATA[Contains the error message if an error occurred during the reopening of the quotation.]]>
	Public Property [ErrorMessage] As String
	'''<![CDATA[Identifier of the quotation.]]>
	Public Property [QuotationID] As Guid
	'''<![CDATA[Contains information if the quotation was successfully reopened.]]>
	Public Property [SuccessMessage] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class ReportingBalance
	'''<![CDATA[The sum of the amounts of all transactions in the grouping.]]>
	Public Property [Amount] As Double?
	'''<![CDATA[The sum of the amounts of all credit transactions in the grouping.]]>
	Public Property [AmountCredit] As Double?
	'''<![CDATA[The sum of the amounts of all debit transactions in the grouping.]]>
	Public Property [AmountDebit] As Double?
	'''<![CDATA[Balance type of the G/L account: B = Balance Sheet, W = Profit & Loss.]]>
	Public Property [BalanceType] As String
	'''<![CDATA[The code of the cost center.]]>
	Public Property [CostCenterCode] As String
	'''<![CDATA[The description of the cost center.]]>
	Public Property [CostCenterDescription] As String
	'''<![CDATA[The code of the cost unit.]]>
	Public Property [CostUnitCode] As String
	'''<![CDATA[The description of the cost unit.]]>
	Public Property [CostUnitDescription] As String
	'''<![CDATA[The number of transactions in the grouping.]]>
	Public Property [Count] As Int32?
	'''<![CDATA[Division code]]>
	Public Property [Division] As Int32?
	'''<![CDATA[G/L account]]>
	Public Property [GLAccount] As Guid?
	'''<![CDATA[The code of the G/L account.]]>
	Public Property [GLAccountCode] As String
	'''<![CDATA[The description of the G/L account.]]>
	Public Property [GLAccountDescription] As String
	'''<![CDATA[Record ID]]>
	Public Property [ID] As Int64
	'''<![CDATA[The reporting period of the transactions in the grouping.]]>
	Public Property [ReportingPeriod] As Int32?
	'''<![CDATA[The reporting year of the transactions in the grouping.]]>
	Public Property [ReportingYear] As Int32?
	'''<![CDATA[Status: 20 = Open, 50 = Processed. To get 'after entry' results, both Open and Processed amounts have to be included. This is by default, so it requires no extra filtering.]]>
	Public Property [Status] As Int32?
	'''<![CDATA[The type of the transactions in the grouping.]]>
	Public Property [Type] As Int32?
End Class

<SupportedActionsSDK(True, False, False, False)>
<DataServiceKey("QuotationID")>
Public Class ReviewedQuotation
	'''<![CDATA[Indicates if the item prices should be copied from the original quotation or the default item prices should be used.]]>
	Public Property [CopyItemPrices] As Boolean?
	'''<![CDATA[The description of the new quotation.]]>
	Public Property [Description] As String
	'''<![CDATA[Division code.]]>
	Public Property [Division] As Int32
	'''<![CDATA[The document linked to the new quotation.]]>
	Public Property [Document] As Guid?
	'''<![CDATA[Contains the error message if an error occurred during the reviewing of the quotation.]]>
	Public Property [ErrorMessage] As String
	'''<![CDATA[Identifier of the newly created quotation.]]>
	Public Property [NewQuotationID] As Guid?
	'''<![CDATA[The account who made the order.]]>
	Public Property [OrderAccount] As Guid?
	'''<![CDATA[The contact person of the account who made the order.]]>
	Public Property [OrderAccountContact] As Guid?
	'''<![CDATA[The paymentcondition linked to the new quotation.]]>
	Public Property [PaymentCondition] As String
	'''<![CDATA[The date of the new quotation.]]>
	Public Property [QuotationDate] As DateTime?
	'''<![CDATA[Identifier of the quotation.]]>
	Public Property [QuotationID] As Guid
	'''<![CDATA[Contains information if the quotation was successfully reviewed.]]>
	Public Property [SuccessMessage] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("EntryID")>
Public Class SalesEntry
	'''<![CDATA[Amount in the default currency of the company. For the header lines (LineNumber = 0) of an entry this is the SUM(AmountDC) of all lines]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AmountDC] As Double?
	'''<![CDATA[Amount in the currency of the transaction. For the header this is the sum of all lines, including VAT]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AmountFC] As Double?
	'''<![CDATA[The number of the batch of entries. Normally a batch consists of multiple entries. Batchnumbers are filled for invoices created by: - Fixed entries - Prolongation (only available with module hosting)]]>
	Public Property [BatchNumber] As Int32?
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Currency for the invoice. By default this is the currency of the administration]]>
	Public Property [Currency] As String
	'''<![CDATA[Reference to customer (account)]]>
	Public Property [Customer] As Guid?
	'''<![CDATA[Name of customer]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CustomerName] As String
	'''<![CDATA[Description. Can be different for header and lines]]>
	Public Property [Description] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Document that is manually linked to the invoice]]>
	Public Property [Document] As Guid?
	'''<![CDATA[Number of the document]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DocumentNumber] As Int32?
	'''<![CDATA[Subject of the document]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DocumentSubject] As String
	'''<![CDATA[The due date for payments. This date is calculated based on the EntryDate and the Paymentcondition]]>
	Public Property [DueDate] As DateTime?
	'''<![CDATA[The date when the invoice is entered]]>
	Public Property [EntryDate] As DateTime?
	'''<![CDATA[The unique ID of the entry. Via this ID all transaction lines of a single entry can be retrieved]]>
	Public Property [EntryID] As Guid
	'''<![CDATA[Entry number]]>
	Public Property [EntryNumber] As Int32?
	'''<![CDATA[Description of ExternalLink]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ExternalLinkDescription] As String
	'''<![CDATA[Reference of ExternalLink]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ExternalLinkReference] As String
	'''<![CDATA[Assigned at entry or at printing depending on setting. The number assigned is based on the freenumbers as defined for the Journal. When printing the field InvoiceNumber is copied to the fields EntryNumber and InvoiceNumber of the sales entry]]>
	Public Property [InvoiceNumber] As Int32?
	'''<![CDATA[Indicates whether the invoice has extra duty]]>
	Public Property [IsExtraDuty] As Boolean?
	'''<![CDATA[The journal code. Every invoice should be linked to a sales journal]]>
	Public Property [Journal] As String
	'''<![CDATA[Description of Journal]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [JournalDescription] As String
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Number to indentify the invoice. Order numbers are not unique. Default the number is based on a setting for the first free number]]>
	Public Property [OrderNumber] As Int32?
	'''<![CDATA[The payment condition used for due date and discount calculation]]>
	Public Property [PaymentCondition] As String
	'''<![CDATA[Description of PaymentCondition]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PaymentConditionDescription] As String
	'''<![CDATA[The payment reference used for bank imports, VAT return and Tax reference]]>
	Public Property [PaymentReference] As String
	Public Property [ProcessNumber] As Int32?
	'''<![CDATA[Foreign currency rate]]>
	Public Property [Rate] As Double?
	'''<![CDATA[The period of the transaction lines. The period should exist in the period date table]]>
	Public Property [ReportingPeriod] As Int16?
	'''<![CDATA[The financial year to which the entry belongs. The financial year should exist in the period date table]]>
	Public Property [ReportingYear] As Int16?
	'''<![CDATA[Indicates if amounts are reversed]]>
	Public Property [Reversal] As Boolean?
	'''<![CDATA[Collection of lines]]>
	Public Property [SalesEntryLines] As IEnumerable(Of SalesEntryLine)
	'''<![CDATA[Status: 5 = Rejected, 20 = Open, 50 = Processed]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Status] As Int16?
	'''<![CDATA[Description of Status]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [StatusDescription] As String
	'''<![CDATA[Type: 20 = Sales entry, 21 = Sales credit note]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Type] As Int32?
	'''<![CDATA[Description of Type]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [TypeDescription] As String
	'''<![CDATA[Vat amount in the default currency of the company]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [VATAmountDC] As Double?
	'''<![CDATA[Vat amount in the currency of the transaction]]>
	Public Property [VATAmountFC] As Double?
	'''<![CDATA[The invoice number of the customer]]>
	Public Property [YourRef] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class SalesEntryLine
	'''<![CDATA[Amount in the default currency of the company. For almost all lines this can be calculated like: AmountDC = AmountFC * RateFC.]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AmountDC] As Double?
	'''<![CDATA[For normal lines it's the amount excluding VAT]]>
	Public Property [AmountFC] As Double?
	'''<![CDATA[Reference to Asset]]>
	Public Property [Asset] As Guid?
	'''<![CDATA[Description of Asset]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AssetDescription] As String
	'''<![CDATA[Reference to Cost center]]>
	Public Property [CostCenter] As String
	'''<![CDATA[Description of CostCenter]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostCenterDescription] As String
	'''<![CDATA[Reference to Cost unit]]>
	Public Property [CostUnit] As String
	'''<![CDATA[Description of CostUnit]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostUnitDescription] As String
	'''<![CDATA[Description. Can be different for header and lines]]>
	Public Property [Description] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[The unique ID of the entry. Via this ID all transaction lines of a single entry can be retrieved]]>
	Public Property [EntryID] As Guid
	'''<![CDATA[Extra duty amount in the currency of the transaction. Both extra duty amount and VAT amount need to be specified in order to differ this property from automatically calculated.]]>
	Public Property [ExtraDutyAmountFC] As Double?
	'''<![CDATA[Extra duty percentage for the item]]>
	Public Property [ExtraDutyPercentage] As Double?
	'''<![CDATA[The GL Account of the invoice line. This field is generated based on the revenue account of the item (or the related item group). G/L Account is also used to determine whether the costcenter / costunit is mandatory]]>
	Public Property [GLAccount] As Guid?
	'''<![CDATA[Code of GLAccount]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLAccountCode] As String
	'''<![CDATA[Description of GLAccount]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLAccountDescription] As String
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Indicates the sequence of the lines within one entry]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [LineNumber] As Int32?
	'''<![CDATA[Extra notes]]>
	Public Property [Notes] As String
	'''<![CDATA[The project to which the sales transaction line is linked. The project can be different per line. Sometimes also the project in the header is filled although this is not really used]]>
	Public Property [Project] As Guid?
	'''<![CDATA[Description of Project]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectDescription] As String
	'''<![CDATA[The number of items sold in default units. The quantity shown in the entry screen is Quantity * UnitFactor]]>
	Public Property [Quantity] As Double?
	'''<![CDATA[Serial number]]>
	Public Property [SerialNumber] As String
	'''<![CDATA[When generating invoices from subscriptions, this field records the link between invoice lines and subscription lines]]>
	Public Property [Subscription] As Guid?
	'''<![CDATA[Description of Subscription]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SubscriptionDescription] As String
	'''<![CDATA[Reference to TrackingNumber]]>
	Public Property [TrackingNumber] As Guid?
	'''<![CDATA[Description of TrackingNumber]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [TrackingNumberDescription] As String
	'''<![CDATA[Type: 20 = Sales entry, 21 = Sales credit note]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Type] As Int32?
	'''<![CDATA[VAT amount in the default currency of the company]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [VATAmountDC] As Double?
	'''<![CDATA[VAT amount in the currency of the transaction. Use this property to specify a VAT amount that differs from the VAT amount that is automatically calculated. However if the transaction uses extra duty, extra duty amount also needs to be specified. ]]>
	Public Property [VATAmountFC] As Double?
	'''<![CDATA[The VAT base amount in the default currency of the company. This is calculated based on the VATBaseAmountFC]]>
	Public Property [VATBaseAmountDC] As Double?
	'''<![CDATA[The VAT base amount in invoice currency. This is calculated with the use of VAT codes. It's an internal value]]>
	Public Property [VATBaseAmountFC] As Double?
	'''<![CDATA[The VAT code used when the invoice was registered]]>
	Public Property [VATCode] As String
	'''<![CDATA[Description of VATCode]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [VATCodeDescription] As String
	'''<![CDATA[The VAT percentage of the VAT code. This is the percentage at the moment the invoice is created. It's also used by the default calculation of VAT amounts and VAT base amounts]]>
	Public Property [VATPercentage] As Double?
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("InvoiceID")>
Public Class SalesInvoice
	'''<![CDATA[For the header lines (LineNumber = 0) of an entry this is the SUM(AmountDC) of all lines]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AmountDC] As Double?
	'''<![CDATA[For the header this is the sum of all lines, including VAT]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AmountFC] As Double?
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Currency for the invoice. Default this is the currency of the administration]]>
	Public Property [Currency] As String
	'''<![CDATA[Description. Can be different for header and lines]]>
	Public Property [Description] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Document that is manually linked to the invoice]]>
	Public Property [Document] As Guid?
	'''<![CDATA[Number of the document]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DocumentNumber] As Int32?
	'''<![CDATA[Subject of the document]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DocumentSubject] As String
	'''<![CDATA[The due date for payments. This date is calculated based on the EntryDate and the Paymentcondition]]>
	Public Property [DueDate] As DateTime?
	'''<![CDATA[Official date for the invoice. When the invoice is entered it's equal to the field 'EntryDate'. During the printing process the invoice date can be entered]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [InvoiceDate] As DateTime?
	'''<![CDATA[Primary key]]>
	Public Property [InvoiceID] As Guid
	'''<![CDATA[Assigned at entry or at printing depending on setting. The number assigned is based on the freenumbers as defined for the Journal. When printing the field InvoiceNumber is copied to the fields EntryNumber and InvoiceNumber of the sales entry]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [InvoiceNumber] As Int32?
	'''<![CDATA[Reference to the Customer who will receive the invoice]]>
	Public Property [InvoiceTo] As Guid?
	'''<![CDATA[Reference to the Contact person of the customer who will receive the invoice]]>
	Public Property [InvoiceToContactPerson] As Guid?
	'''<![CDATA[Name of the contact person of the customer who will receive the invoice]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [InvoiceToContactPersonFullName] As String
	'''<![CDATA[Name of the customer who will receive the invoice]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [InvoiceToName] As String
	'''<![CDATA[The journal code. Every invoice should be linked to a sales journal]]>
	Public Property [Journal] As String
	'''<![CDATA[Description of Journal]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [JournalDescription] As String
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Order date]]>
	Public Property [OrderDate] As DateTime?
	'''<![CDATA[Customer who ordered the invoice]]>
	Public Property [OrderedBy] As Guid?
	'''<![CDATA[Contact person of customer who ordered the invoice]]>
	Public Property [OrderedByContactPerson] As Guid?
	'''<![CDATA[Name of contact person of customer who ordered the invoice]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [OrderedByContactPersonFullName] As String
	'''<![CDATA[Name of customer who ordered the invoice]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [OrderedByName] As String
	'''<![CDATA[Number to identify the order. By default the number is based on a setting for the first free number, but you can post your own number.]]>
	Public Property [OrderNumber] As Int32?
	'''<![CDATA[The payment condition used for due date and discount calculation]]>
	Public Property [PaymentCondition] As String
	'''<![CDATA[Description of PaymentCondition]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PaymentConditionDescription] As String
	'''<![CDATA[Payment reference for sales invoice]]>
	Public Property [PaymentReference] As String
	'''<![CDATA[Extra remarks]]>
	Public Property [Remarks] As String
	'''<![CDATA[Collection of lines]]>
	Public Property [SalesInvoiceLines] As IEnumerable(Of SalesInvoiceLine)
	'''<![CDATA[Sales representative]]>
	Public Property [Salesperson] As Guid?
	'''<![CDATA[Name of sales representative]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SalespersonFullName] As String
	'''<![CDATA[Starter Sales invoice status (for starter functionality)]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [StarterSalesInvoiceStatus] As Int16?
	'''<![CDATA[Description of StarterSalesInvoiceStatus]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [StarterSalesInvoiceStatusDescription] As String
	'''<![CDATA[The status of the entry. 10 = draft. During the creation of an invoice draft records occur in the draft modus if during an invoice a new page with lines is triggered. If the user leaves the invoice in an abnormal way the draft invoices can be recovered. Draft invoices are not included in financial reports, balances etc. 20 = open. Open invoices can be changed. New invoices get the status open by default. 50 = processed. Processed invoices can't be changed anymore. Processing is done via printing. Processed invoices can't be reopened]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Status] As Int16?
	'''<![CDATA[Description of Status]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [StatusDescription] As String
	'''<![CDATA[Tax schedule linked]]>
	Public Property [TaxSchedule] As Guid?
	'''<![CDATA[Code of the tax schedule]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [TaxScheduleCode] As String
	'''<![CDATA[Description of the tax schedule]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [TaxScheduleDescription] As String
	'''<![CDATA[Indicates the type of invoice Values: 8020 - Sales invoices, 8021 - Sales credit note]]>
	Public Property [Type] As Int32?
	'''<![CDATA[Description of the type]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [TypeDescription] As String
	'''<![CDATA[Total VAT amount in the default currency of the company]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [VATAmountDC] As Double?
	'''<![CDATA[Total VAT amount in the currency of the transaction]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [VATAmountFC] As Double?
	'''<![CDATA[The invoice number of the customer]]>
	Public Property [YourRef] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class SalesInvoiceLine
	'''<![CDATA[Amount in the default currency of the company. For almost all lines this can be calculated like: AmountDC = AmountFC * RateFC]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AmountDC] As Double?
	'''<![CDATA[For normal lines it's the amount excluding VAT]]>
	Public Property [AmountFC] As Double?
	'''<![CDATA[Reference to Cost center]]>
	Public Property [CostCenter] As String
	'''<![CDATA[Description of CostCenter]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostCenterDescription] As String
	'''<![CDATA[Reference to Cost unit]]>
	Public Property [CostUnit] As String
	'''<![CDATA[Description of CostUnit]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostUnitDescription] As String
	'''<![CDATA[Delivery date of an item in a sales invoice. This is used for VAT on prepayments, only if sales order is not used in the license.]]>
	Public Property [DeliveryDate] As DateTime?
	'''<![CDATA[Description. Can be different for header and lines]]>
	Public Property [Description] As String
	'''<![CDATA[Discount given on the default price. Discount = (DefaultPrice of Item - PriceItem in line) / DefaultPrice of Item]]>
	Public Property [Discount] As Double?
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Link to Employee originating from time and cost transactions]]>
	Public Property [Employee] As Guid?
	'''<![CDATA[Name of employee]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [EmployeeFullName] As String
	'''<![CDATA[EndTime is used to store the last date of a period. EndTime is used in combination with StartTime]]>
	Public Property [EndTime] As DateTime?
	'''<![CDATA[The GL Account of the sales invoice line. This field is mandatory. This field is generated based on the revenue account of the item (or the related item group). G/L Account is also used to determine whether the costcenter / costunit is mandatory]]>
	Public Property [GLAccount] As Guid?
	'''<![CDATA[Description of GLAccount]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLAccountDescription] As String
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[The InvoiceID identifies the sales invoice. All the lines of a sales invoice have the same InvoiceID]]>
	Public Property [InvoiceID] As Guid
	'''<![CDATA[Reference to the item that is sold in this sales invoice line]]>
	Public Property [Item] As Guid?
	'''<![CDATA[Item code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemCode] As String
	'''<![CDATA[Description of Item]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemDescription] As String
	'''<![CDATA[Indicates the sequence of the lines within one invoice]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [LineNumber] As Int32?
	'''<![CDATA[Net price of the sales invoice line]]>
	Public Property [NetPrice] As Double?
	'''<![CDATA[Extra notes]]>
	Public Property [Notes] As String
	'''<![CDATA[Price list]]>
	Public Property [Pricelist] As Guid?
	'''<![CDATA[Description of Pricelist]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PricelistDescription] As String
	'''<![CDATA[The project to which the sales transaction line is linked. The project can be different per line. Sometimes also the project in the header is filled although this is not really used]]>
	Public Property [Project] As Guid?
	'''<![CDATA[Description of Project]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectDescription] As String
	'''<![CDATA[The number of items sold in default units. The quantity shown in the entry screen is Quantity * UnitFactor]]>
	Public Property [Quantity] As Double?
	'''<![CDATA[Identifies the sales order this invoice line is based on]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SalesOrder] As Guid?
	'''<![CDATA[Identifies the sales order line this sales invoice line is based on]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SalesOrderLine] As Guid?
	'''<![CDATA[Then line number of the sales order line on which this invoice line is based on]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SalesOrderLineNumber] As Int32?
	'''<![CDATA[The order number of the sales order on which this invoice line is based on]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SalesOrderNumber] As Int32?
	'''<![CDATA[StartTime is used to store the first date of a period. StartTime is used in combination with EndTime]]>
	Public Property [StartTime] As DateTime?
	'''<![CDATA[Obsolete. When generating invoices from subscriptions, this field records the link between invoice lines and subscription lines]]>
	Public Property [Subscription] As Guid?
	'''<![CDATA[Description of Subscription]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SubscriptionDescription] As String
	'''<![CDATA[Tax schedule linked]]>
	Public Property [TaxSchedule] As Guid?
	'''<![CDATA[Code of the tax schedule]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [TaxScheduleCode] As String
	'''<![CDATA[Description of the tax schedule]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [TaxScheduleDescription] As String
	'''<![CDATA[Code of Unit]]>
	Public Property [UnitCode] As String
	'''<![CDATA[Description of Unit]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [UnitDescription] As String
	'''<![CDATA[Price per unit]]>
	Public Property [UnitPrice] As Double?
	'''<![CDATA[VAT amount in the default currency of the company]]>
	Public Property [VATAmountDC] As Double?
	'''<![CDATA[VAT amount in the currency of the transaction]]>
	Public Property [VATAmountFC] As Double?
	'''<![CDATA[The VAT code that is used when the invoice is registered]]>
	Public Property [VATCode] As String
	'''<![CDATA[Description of VATCode]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [VATCodeDescription] As String
	'''<![CDATA[The vat percentage of the VAT code. This is the percentage at the moment the invoice is created. It's also used for the default calculation of VAT amounts and VAT base amounts]]>
	Public Property [VATPercentage] As Double?
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class SalesItemPrice
	'''<![CDATA[ID of the customer]]>
	Public Property [Account] As Guid?
	'''<![CDATA[Name of the customer account]]>
	Public Property [AccountName] As String
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[The currency of the price]]>
	Public Property [Currency] As String
	'''<![CDATA[The default unit of the item]]>
	Public Property [DefaultItemUnit] As String
	'''<![CDATA[The description of the default item unit]]>
	Public Property [DefaultItemUnitDescription] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Together with StartDate this determines whether the price is active]]>
	Public Property [EndDate] As DateTime?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Item ID]]>
	Public Property [Item] As Guid?
	'''<![CDATA[Code of Item]]>
	Public Property [ItemCode] As String
	'''<![CDATA[Description of Item]]>
	Public Property [ItemDescription] As String
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[This is the multiplication factor when going from default item unit to the unit of this price.For example if the default item unit is 'gram' and the price unit is 'kilogram' then the value of this property is 1000.]]>
	Public Property [NumberOfItemsPerUnit] As Double?
	'''<![CDATA[The actual price of this sales item]]>
	Public Property [Price] As Double?
	'''<![CDATA[Minimum quantity to which the price is applicable]]>
	Public Property [Quantity] As Double?
	'''<![CDATA[Together with EndDate this determines whether the price is active]]>
	Public Property [StartDate] As DateTime
	'''<![CDATA[The unit code of the price]]>
	Public Property [Unit] As String
	'''<![CDATA[Description of the price unit]]>
	Public Property [UnitDescription] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("OrderID")>
Public Class SalesOrder
	'''<![CDATA[Amount in the default currency of the company]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AmountDC] As Double?
	'''<![CDATA[Amount in the currency of the transaction]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AmountFC] As Double?
	'''<![CDATA[Shows if this sales order is approved]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ApprovalStatus] As Int16?
	'''<![CDATA[Description of ApprovalStatus]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ApprovalStatusDescription] As String
	'''<![CDATA[Approval datetime]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Approved] As DateTime?
	'''<![CDATA[User who approved the sales order]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Approver] As Guid?
	'''<![CDATA[Name of approver]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ApproverFullName] As String
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Currency code]]>
	Public Property [Currency] As String
	'''<![CDATA[Reference to delivery customer]]>
	Public Property [DeliverTo] As Guid?
	'''<![CDATA[Reference to contact person of delivery customer]]>
	Public Property [DeliverToContactPerson] As Guid?
	'''<![CDATA[Name of contact person of delivery customer]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DeliverToContactPersonFullName] As String
	'''<![CDATA[Name of delivery customer]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DeliverToName] As String
	'''<![CDATA[Delivery address]]>
	Public Property [DeliveryAddress] As Guid?
	'''<![CDATA[Delivery date]]>
	Public Property [DeliveryDate] As DateTime?
	'''<![CDATA[Shipping status]]>
	Public Property [DeliveryStatus] As Int16?
	'''<![CDATA[Description of DeliveryStatus]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DeliveryStatusDescription] As String
	'''<![CDATA[Description]]>
	Public Property [Description] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Document that is manually linked to the sales order]]>
	Public Property [Document] As Guid?
	'''<![CDATA[Number of the document]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DocumentNumber] As Int32?
	'''<![CDATA[Subject of the document]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DocumentSubject] As String
	'''<![CDATA[Invoice status]]>
	Public Property [InvoiceStatus] As Int16?
	'''<![CDATA[Description of InvoiceStatus]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [InvoiceStatusDescription] As String
	'''<![CDATA[Reference to the Customer who will receive the invoice]]>
	Public Property [InvoiceTo] As Guid?
	'''<![CDATA[Reference to the Contact person of the customer who will receive the invoice]]>
	Public Property [InvoiceToContactPerson] As Guid?
	'''<![CDATA[Name of the contact person of the customer who will receive the invoice]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [InvoiceToContactPersonFullName] As String
	'''<![CDATA[Name of the customer who will receive the invoice]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [InvoiceToName] As String
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Order date]]>
	Public Property [OrderDate] As DateTime?
	'''<![CDATA[Customer who ordered the sales order]]>
	Public Property [OrderedBy] As Guid?
	'''<![CDATA[Contact person of the customer who ordered the sales order]]>
	Public Property [OrderedByContactPerson] As Guid?
	'''<![CDATA[Name of contact person of the customer who ordered the sales order]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [OrderedByContactPersonFullName] As String
	'''<![CDATA[Name of the customer who ordered the sales order]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [OrderedByName] As String
	'''<![CDATA[Primary key]]>
	Public Property [OrderID] As Guid
	'''<![CDATA[Number of sales order]]>
	Public Property [OrderNumber] As Int32?
	'''<![CDATA[The payment condition used for due date and discount calculation]]>
	Public Property [PaymentCondition] As String
	'''<![CDATA[Description of PaymentCondition]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PaymentConditionDescription] As String
	'''<![CDATA[Payment reference for sales order]]>
	Public Property [PaymentReference] As String
	'''<![CDATA[Extra remarks]]>
	Public Property [Remarks] As String
	'''<![CDATA[Collection of lines]]>
	Public Property [SalesOrderLines] As IEnumerable(Of SalesOrderLine)
	'''<![CDATA[Sales representative]]>
	Public Property [Salesperson] As Guid?
	'''<![CDATA[Name of sales representative]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SalespersonFullName] As String
	'''<![CDATA[ShippingMethod]]>
	Public Property [ShippingMethod] As Guid?
	'''<![CDATA[Description of ShippingMethod]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ShippingMethodDescription] As String
	'''<![CDATA[The status of the sales order. 12 = Open, 20 = Partial, 21 = Complete, 45 = Cancelled.]]>
	Public Property [Status] As Int16?
	'''<![CDATA[Description of Status]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [StatusDescription] As String
	'''<![CDATA[Tax schedule linked]]>
	Public Property [TaxSchedule] As Guid?
	'''<![CDATA[Code of the tax schedule]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [TaxScheduleCode] As String
	'''<![CDATA[Description of the tax schedule]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [TaxScheduleDescription] As String
	'''<![CDATA[Code of Warehouse]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [WarehouseCode] As String
	'''<![CDATA[Description of Warehouse]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [WarehouseDescription] As String
	'''<![CDATA[Warehouse]]>
	Public Property [WarehouseID] As Guid?
	'''<![CDATA[The reference number of the customer]]>
	Public Property [YourRef] As String
End Class

<SupportedActionsSDK(True, False, False, False)>
<DataServiceKey("ID")>
Public Class SalesOrderID
	Public Property [ID] As Guid
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class SalesOrderLine
	'''<![CDATA[Amount in the default currency of the company]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AmountDC] As Double?
	'''<![CDATA[Amount in the currency of the transaction]]>
	Public Property [AmountFC] As Double?
	'''<![CDATA[Reference to Cost center]]>
	Public Property [CostCenter] As String
	'''<![CDATA[Description of CostCenter]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostCenterDescription] As String
	'''<![CDATA[Item cost price]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostPriceFC] As Double?
	'''<![CDATA[Reference to Cost unit]]>
	Public Property [CostUnit] As String
	'''<![CDATA[Description of CostUnit]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostUnitDescription] As String
	'''<![CDATA[Delivery date of this line]]>
	Public Property [DeliveryDate] As DateTime?
	'''<![CDATA[Description]]>
	Public Property [Description] As String
	'''<![CDATA[Discount given on the default price. Discount = (DefaultPrice of Item - PriceItem in line) / DefaultPrice of Item]]>
	Public Property [Discount] As Double?
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Reference to the item that is sold in this sales order line]]>
	Public Property [Item] As Guid?
	'''<![CDATA[Code of Item]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemCode] As String
	'''<![CDATA[Description of Item]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemDescription] As String
	'''<![CDATA[Item Version]]>
	Public Property [ItemVersion] As Guid?
	'''<![CDATA[Description of Item Version]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemVersionDescription] As String
	'''<![CDATA[Line number]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [LineNumber] As Int32?
	'''<![CDATA[Sales margin of the sales order line]]>
	Public Property [Margin] As Double?
	'''<![CDATA[Net price of the sales order line]]>
	Public Property [NetPrice] As Double?
	'''<![CDATA[Extra notes]]>
	Public Property [Notes] As String
	'''<![CDATA[The OrderID identifies the sales order. All the lines of a sales order have the same OrderID]]>
	Public Property [OrderID] As Guid
	'''<![CDATA[Number of sales order]]>
	Public Property [OrderNumber] As Int32?
	'''<![CDATA[Price list]]>
	Public Property [Pricelist] As Guid?
	'''<![CDATA[Description of Pricelist]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PricelistDescription] As String
	'''<![CDATA[The project to which the sales order line is linked. The project can be different per line. Sometimes also the project in the header is filled although this is not really used]]>
	Public Property [Project] As Guid?
	'''<![CDATA[Description of Project]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectDescription] As String
	'''<![CDATA[The number of items sold in default units. The quantity shown in the entry screen is Quantity * UnitFactor]]>
	Public Property [Quantity] As Double?
	'''<![CDATA[The number of items delivered]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [QuantityDelivered] As Double?
	'''<![CDATA[The number of items invoiced]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [QuantityInvoiced] As Double?
	'''<![CDATA[Reference to ShopOrder]]>
	Public Property [ShopOrder] As Guid?
	'''<![CDATA[Tax schedule linked]]>
	Public Property [TaxSchedule] As Guid?
	'''<![CDATA[Code of the tax schedule]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [TaxScheduleCode] As String
	'''<![CDATA[Description of the tax schedule]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [TaxScheduleDescription] As String
	'''<![CDATA[Code of item unit]]>
	Public Property [UnitCode] As String
	'''<![CDATA[Description of Unit]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [UnitDescription] As String
	'''<![CDATA[Price per unit in the currency of the transaction]]>
	Public Property [UnitPrice] As Double?
	'''<![CDATA[Indicates if drop shipment is used (delivery directly to customer, invoice to wholesaler)]]>
	Public Property [UseDropShipment] As Byte
	'''<![CDATA[VAT amount in the currency of the transaction]]>
	Public Property [VATAmount] As Double?
	'''<![CDATA[VAT code]]>
	Public Property [VATCode] As String
	'''<![CDATA[Description of VATCode]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [VATCodeDescription] As String
	'''<![CDATA[The vat percentage of the VAT code. This is the percentage at the moment the sales order is created. It's also used for the default calculation of VAT amounts and VAT base amounts]]>
	Public Property [VATPercentage] As Double?
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class SalesPriceListDetail
	'''<![CDATA[Customer account Id]]>
	Public Property [Account] As Guid?
	'''<![CDATA[Customer account name]]>
	Public Property [AccountName] As String
	'''<![CDATA[Standard price]]>
	Public Property [BasePrice] As Guid?
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Currency]]>
	Public Property [Currency] As String
	'''<![CDATA[Discount]]>
	Public Property [Discount] As Double?
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[End date]]>
	Public Property [EndDate] As DateTime?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Item]]>
	Public Property [Item] As Guid?
	'''<![CDATA[Description of the item]]>
	Public Property [ItemDescription] As String
	'''<![CDATA[ItemGroup]]>
	Public Property [ItemGroup] As Guid?
	'''<![CDATA[Default sales unit of the item]]>
	Public Property [ItemUnit] As String
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[New price after discount]]>
	Public Property [NewPrice] As Double?
	'''<![CDATA[Number of the item per unit]]>
	Public Property [NumberOfItemsPerUnit] As Double?
	'''<![CDATA[Code of the PriceList]]>
	Public Property [PriceListCode] As String
	'''<![CDATA[Id of the PriceList]]>
	Public Property [PriceListId] As Guid?
	'''<![CDATA[Quantity]]>
	Public Property [Quantity] As Double?
	'''<![CDATA[Start date]]>
	Public Property [StartDate] As DateTime?
	'''<![CDATA[Unit]]>
	Public Property [Unit] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class Schedule
	'''<![CDATA[Indicates if the schedule is active. 0 = Inactive, 1 = Active]]>
	Public Property [Active] As Byte?
	'''<![CDATA[Average hours per week in a schedule]]>
	Public Property [AverageHours] As Double?
	'''<![CDATA[Schedule code]]>
	Public Property [Code] As String
	'''<![CDATA[Creation date]]>
	Public Property [Created] As DateTime?
	'''<![CDATA[ID of creator]]>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of the creator]]>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Average days per week in the schedule]]>
	Public Property [Days] As Double?
	'''<![CDATA[Description of the schedule]]>
	Public Property [Description] As String
	'''<![CDATA[Division code]]>
	Public Property [Division] As Int32?
	'''<![CDATA[Employment ID for schedule]]>
	Public Property [Employment] As Guid?
	'''<![CDATA[Employment number]]>
	Public Property [EmploymentHID] As Int32?
	'''<![CDATA[End date of the schedule]]>
	Public Property [EndDate] As DateTime?
	'''<![CDATA[Number of hours per week in a CLA for which the schedule is built]]>
	Public Property [Hours] As Double?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Number of hours which are built up each week for later leave]]>
	Public Property [LeaveHoursCompensation] As Double?
	'''<![CDATA[Indication if the schedule is a main schedule for a CLA. 1 = Yes, 0 = No]]>
	Public Property [Main] As Byte?
	'''<![CDATA[Last modified date]]>
	Public Property [Modified] As DateTime?
	'''<![CDATA[ID of modifier]]>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of the modifier]]>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Part-time factor for payroll calculation. Value between 0 and 1]]>
	Public Property [PaymentParttimeFactor] As Double?
	'''<![CDATA[Type of schedule. 1 = Hours and average days, 2 = Hours and specific days, 3 = Hours per day, 4 = Time frames per day]]>
	Public Property [ScheduleType] As Int32?
	'''<![CDATA[Description of the schedule type]]>
	Public Property [ScheduleTypeDescription] As String
	'''<![CDATA[Week in the schedule which is used to start with. By default the number will be 1.]]>
	Public Property [StartDate] As DateTime?
	'''<![CDATA[Week to start the schedule from for an employee]]>
	Public Property [StartWeek] As Int32?
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class SerialNumber
	'''<![CDATA[Availability of this serial number]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Available] As Byte?
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[End date of effective period for serial number]]>
	Public Property [EndDate] As DateTime?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Blocking state]]>
	Public Property [IsBlocked] As Byte?
	'''<![CDATA[Item]]>
	Public Property [Item] As Guid?
	'''<![CDATA[Item code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemCode] As String
	'''<![CDATA[Description of item]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemDescription] As String
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Remarks]]>
	Public Property [Remarks] As String
	'''<![CDATA[Human readable serial number]]>
	Public Property [SerialNumber] As String
	'''<![CDATA[Start date of effective period for serial number]]>
	Public Property [StartDate] As DateTime?
	'''<![CDATA[Storage Location Code]]>
	Public Property [StorageLocationCode] As String
	'''<![CDATA[Warehouse Code]]>
	Public Property [WarehouseCode] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class ShippingMethod
	'''<![CDATA[Active]]>
	Public Property [Active] As Boolean?
	'''<![CDATA[Code of the shipping method]]>
	Public Property [Code] As String
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Description of shipping method]]>
	Public Property [Description] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Notes]]>
	Public Property [Notes] As String
	'''<![CDATA[Shipping method rates URL]]>
	Public Property [ShippingRatesURL] As String
	'''<![CDATA[Tracking URL]]>
	Public Property [TrackingURL] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class ShopOrder
	'''<![CDATA[The cost center linked to the shop order]]>
	Public Property [Costcenter] As String
	'''<![CDATA[Description of Costcenter]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostcenterDescription] As String
	'''<![CDATA[The cost unit linked to the shop order]]>
	Public Property [Costunit] As String
	'''<![CDATA[Description of Costunit]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostunitDescription] As String
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Description]]>
	Public Property [Description] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Date on which the shop order was placed]]>
	Public Property [EntryDate] As DateTime?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Indicator that Shop order is in planning]]>
	Public Property [IsInPlanning] As Byte
	'''<![CDATA[Indicator if the Shop order is on hold]]>
	Public Property [IsOnHold] As Byte
	'''<![CDATA[Indicator that the Shop order has been released to production]]>
	Public Property [IsReleased] As Byte
	'''<![CDATA[Reference to the item]]>
	Public Property [Item] As Guid?
	'''<![CDATA[Reference to ItemVersion]]>
	Public Property [ItemVersion] As Guid?
	'''<![CDATA[Description of Item Version]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemVersionDescription] As String
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Notes - only viewed internally]]>
	Public Property [Notes] As String
	'''<![CDATA[Planned date]]>
	Public Property [PlannedDate] As DateTime?
	'''<![CDATA[Planned quantity]]>
	Public Property [PlannedQuantity] As Double?
	'''<![CDATA[Planned end date]]>
	Public Property [PlannedStartDate] As DateTime?
	'''<![CDATA[Produced quantity]]>
	Public Property [ProducedQuantity] As Double?
	'''<![CDATA[Reference to Project]]>
	Public Property [Project] As Guid?
	'''<![CDATA[Description of Project]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectDescription] As String
	'''<![CDATA[Quantity ready to ship]]>
	Public Property [ReadyToShipQuantity] As Double?
	'''<![CDATA[Collection of Sales order lines]]>
	Public Property [SalesOrderLines] As IEnumerable(Of SalesOrderLine)
	'''<![CDATA[Shop order main]]>
	Public Property [ShopOrderMain] As Guid?
	'''<![CDATA[Shop order main number]]>
	Public Property [ShopOrderMainNumber] As Int32?
	'''<![CDATA[Collection of Shop order Material plans]]>
	Public Property [ShopOrderMaterialPlans] As IEnumerable(Of ShopOrderMaterialPlan)
	'''<![CDATA[Unique number to indentify the shop order]]>
	Public Property [ShopOrderNumber] As Int32?
	'''<![CDATA[Shop order parent]]>
	Public Property [ShopOrderParent] As Guid?
	'''<![CDATA[Shop order parent number]]>
	Public Property [ShopOrderParentNumber] As Int32?
	'''<![CDATA[Collection of Shop order Routing step plans]]>
	Public Property [ShopOrderRoutingStepPlans] As IEnumerable(Of ShopOrderRoutingStepPlan)
	'''<![CDATA[Indicates the type of Shop Order: 10 Open, 20 In process, 30 Finished, 40 Completed]]>
	Public Property [Status] As Int16?
	'''<![CDATA[Overall status of the line: 9040 Regular]]>
	Public Property [Type] As Int16?
	'''<![CDATA[Reference to the Warehouse associated with the Shop order]]>
	Public Property [Warehouse] As Guid?
	'''<![CDATA[Your reference (of the customer)]]>
	Public Property [YourRef] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class ShopOrderMaterialPlan
	'''<![CDATA[Indicates if this is a backflush step]]>
	Public Property [Backflush] As Byte?
	'''<![CDATA[Calculator type]]>
	Public Property [CalculatorType] As Int16?
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Description of the material]]>
	Public Property [Description] As String
	'''<![CDATA[Detail drawing reference]]>
	Public Property [DetailDrawing] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Reference to Items table]]>
	Public Property [Item] As Guid?
	'''<![CDATA[Item Code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemCode] As String
	'''<![CDATA[Description of Item]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemDescription] As String
	'''<![CDATA[Line number]]>
	Public Property [LineNumber] As Int32?
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Line notes]]>
	Public Property [Notes] As String
	'''<![CDATA[Planned amount in the currency of the transaction]]>
	Public Property [PlannedAmountFC] As Double?
	'''<![CDATA[Date that the material is required.]]>
	Public Property [PlannedDate] As DateTime?
	'''<![CDATA[Planned price of the material]]>
	Public Property [PlannedPriceFC] As Double?
	'''<![CDATA[Intended quantity]]>
	Public Property [PlannedQuantity] As Double?
	'''<![CDATA[Intended quantity unit factor]]>
	Public Property [PlannedQuantityFactor] As Double?
	'''<![CDATA[Reference to ShopOrders table]]>
	Public Property [ShopOrder] As Guid?
	'''<![CDATA[Line status]]>
	Public Property [Status] As Int16?
	'''<![CDATA[Description of Status]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [StatusDescription] As String
	'''<![CDATA[Type]]>
	Public Property [Type] As Int16?
	'''<![CDATA[Unit]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Unit] As String
	'''<![CDATA[Unit description]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [UnitDescription] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class ShopOrderRoutingStepPlan
	'''<![CDATA[Reference to Account providing the Outsourced item]]>
	Public Property [Account] As Guid?
	'''<![CDATA[Account name]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountName] As String
	'''<![CDATA[Account number]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountNumber] As String
	'''<![CDATA[Attended Percentage]]>
	Public Property [AttendedPercentage] As Double?
	'''<![CDATA[Indicates if this is a backflush step]]>
	Public Property [Backflush] As Byte?
	'''<![CDATA[Total cost / Shop order planned quantity]]>
	Public Property [CostPerItem] As Double?
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Description of the operation]]>
	Public Property [Description] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Efficiency Percentage]]>
	Public Property [EfficiencyPercentage] As Double?
	'''<![CDATA[Conversion factor type between Shop order Item and Subcontract purchase Unit]]>
	Public Property [FactorType] As Int16?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Sequential order of the operation]]>
	Public Property [LineNumber] As Int32?
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Notes]]>
	Public Property [Notes] As String
	'''<![CDATA[Reference to Operations]]>
	Public Property [Operation] As Guid?
	'''<![CDATA[Code of the routing step operation]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [OperationCode] As String
	'''<![CDATA[Description of the operation step]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [OperationDescription] As String
	'''<![CDATA[Reference to OperationResources]]>
	Public Property [OperationResource] As Guid?
	'''<![CDATA[Planned end date]]>
	Public Property [PlannedEndDate] As DateTime?
	'''<![CDATA[Planned run hours]]>
	Public Property [PlannedRunHours] As Double?
	'''<![CDATA[Planned setup hours]]>
	Public Property [PlannedSetupHours] As Double?
	'''<![CDATA[Planned start date]]>
	Public Property [PlannedStartDate] As DateTime?
	'''<![CDATA[Setup hours + Run hours]]>
	Public Property [PlannedTotalHours] As Double?
	'''<![CDATA[Reference to Units]]>
	Public Property [PurchaseUnit] As String
	'''<![CDATA[Purchase Unit Factor]]>
	Public Property [PurchaseUnitFactor] As Double?
	'''<![CDATA[Purchase Unit Price in the currency of the transaction]]>
	Public Property [PurchaseUnitPriceFC] As Double?
	'''<![CDATA[Purchase unit quantity of the plan]]>
	Public Property [PurchaseUnitQuantity] As Double?
	'''<![CDATA[Reference to RoutingStepTypes]]>
	Public Property [RoutingStepType] As Int16?
	'''<![CDATA[Used in conjunction with RunMethod, and EfficiencyPercentage to determine PlannedRunHours]]>
	Public Property [Run] As Double?
	'''<![CDATA[Reference to OperationMethod]]>
	Public Property [RunMethod] As Int16?
	'''<![CDATA[Description of RunMethod]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [RunMethodDescription] As String
	'''<![CDATA[Used in conjunction with SetupCount and Setup Unit to determine PlannedSetupHours]]>
	Public Property [Setup] As Double?
	'''<![CDATA[Reference to TimeUnits]]>
	Public Property [SetupUnit] As String
	'''<![CDATA[Reference to Shop orders]]>
	Public Property [ShopOrder] As Guid?
	'''<![CDATA[Reference to OperationStatus]]>
	Public Property [Status] As Int16?
	'''<![CDATA[Description of Status]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [StatusDescription] As String
	'''<![CDATA[Subcontracted lead days]]>
	Public Property [SubcontractedLeadDays] As Int32?
	'''<![CDATA[Collection of TimeTransactions]]>
	Public Property [TimeTransactions] As IEnumerable(Of ManufacturingTimeTransaction)
	'''<![CDATA[Total cost of the routing line]]>
	Public Property [TotalCostDC] As Double?
	'''<![CDATA[Reference to Workcenters]]>
	Public Property [Workcenter] As Guid?
	'''<![CDATA[Workcenter code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [WorkcenterCode] As String
	'''<![CDATA[Workcenter description]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [WorkcenterDescription] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class SolutionLink
	'''<![CDATA[ID of account to which solution is linked]]>
	Public Property [Account] As Guid
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Accountant main division]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32
	'''<![CDATA[If type is external predefined, represents ID of PracticeManagementExternalSolutions (mandatory for External solution)]]>
	Public Property [ExternalSolutionCode] As Int32?
	'''<![CDATA[Name of the external solution]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ExternalSolutionName] As String
	'''<![CDATA[Customer URl in external solution, like solution.com/id123 (mandatory for External and ExternalOther solution)]]>
	Public Property [ExternalSolutionUrl] As String
	'''<![CDATA[Primary key]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ID] As Guid
	'''<![CDATA[Division code of linked internal solution (mandatory for Internal solution)]]>
	Public Property [InternalSolutionDivision] As Int32?
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of the solution link]]>
	Public Property [Name] As String
	'''<![CDATA[Name of the custom external solution (mandatory for ExternalOther solution)]]>
	Public Property [OtherExternalSolutionName] As String
	'''<![CDATA[Type of solution: 0 - Internal(EOL), 1 - External(Wellknown solution), 2 - ExternalOther]]>
	Public Property [SolutionType] As Int32
	'''<![CDATA[Link status: 0 - Active, 1 - Inactive, 2 -Archived]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Status] As Int32
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class StockBatchNumber
	'''<![CDATA[Human readable batch number]]>
	Public Property [BatchNumber] As String
	'''<![CDATA[Batch number ID]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [BatchNumberID] As Guid?
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[End date of effective period for batch number]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [EndDate] As DateTime?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Blocking state]]>
	Public Property [IsBlocked] As Byte?
	'''<![CDATA[Item]]>
	Public Property [Item] As Guid?
	'''<![CDATA[Item code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemCode] As String
	'''<![CDATA[Description of item]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemDescription] As String
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Quantity of batch number]]>
	Public Property [Quantity] As Double?
	'''<![CDATA[Remarks]]>
	Public Property [Remarks] As String
	'''<![CDATA[ID of stock count entry]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [StockCountLine] As Guid?
	Public Property [StockTransactionID] As Guid?
End Class

<SupportedActionsSDK(True, True, False, False)>
<DataServiceKey("StockCountID")>
Public Class StockCount
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Description of the stock count]]>
	Public Property [Description] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Entry number of the stock transactions]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [EntryNumber] As Int32?
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Offset GL account of inventory]]>
	Public Property [OffsetGLInventory] As Guid?
	'''<![CDATA[GLAccount code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [OffsetGLInventoryCode] As String
	'''<![CDATA[GLAccount description]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [OffsetGLInventoryDescription] As String
	'''<![CDATA[Source of stock count entry: 1-Manual entry, 2-Import, 3-Stock count, 4-Web service]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Source] As Int16?
	'''<![CDATA[Stock count status: 12-Draft, 21-Processed]]>
	Public Property [Status] As Int16?
	'''<![CDATA[Stock count date]]>
	Public Property [StockCountDate] As DateTime?
	'''<![CDATA[Primary key]]>
	Public Property [StockCountID] As Guid
	'''<![CDATA[Collection of stock count lines]]>
	Public Property [StockCountLines] As IEnumerable(Of StockCountLine)
	'''<![CDATA[Human readable id of the stock count]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [StockCountNumber] As Int32?
	'''<![CDATA[Warehouse]]>
	Public Property [Warehouse] As Guid?
	'''<![CDATA[Code of Warehouse]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [WarehouseCode] As String
	'''<![CDATA[Description of Warehouse]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [WarehouseDescription] As String
End Class

<SupportedActionsSDK(True, True, False, False)>
<DataServiceKey("ID")>
Public Class StockCountLine
	'''<![CDATA[The collection of batch numbers that belong to the items included in this stock count]]>
	Public Property [BatchNumbers] As IEnumerable(Of StockBatchNumber)
	'''<![CDATA[Cost price of the item that is used to create the stock count]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostPrice] As Double?
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Reference to the item for which the stock is counted]]>
	Public Property [Item] As Guid?
	'''<![CDATA[Item code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemCode] As String
	'''<![CDATA[Current standard/actual item cost price]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemCostPrice] As Double?
	'''<![CDATA[Description of item]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemDescription] As String
	'''<![CDATA[Indicates if fractional quantities of the item can be used, for example quantity = 0.4]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemDivisable] As Boolean?
	'''<![CDATA[Line number]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [LineNumber] As Int32?
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Shows quantity difference between current and new stock]]>
	Public Property [QuantityDifference] As Double?
	'''<![CDATA[Shows current quantity available in stock]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [QuantityInStock] As Double?
	'''<![CDATA[Shows new amended quantity in stock]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [QuantityNew] As Double?
	'''<![CDATA[The collection of serial numbers that belong to the items included in this stock count]]>
	Public Property [SerialNumbers] As IEnumerable(Of StockSerialNumber)
	'''<![CDATA[Identifies the stock count. All the lines of a stock count have the same StockCountID]]>
	Public Property [StockCountID] As Guid?
	'''<![CDATA[Stock item's unit description]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [StockKeepingUnit] As String
	'''<![CDATA[Storage location]]>
	Public Property [StorageLocation] As Guid?
	'''<![CDATA[Storage location code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [StorageLocationCode] As String
	'''<![CDATA[Storage location description]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [StorageLocationDescription] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class StockSerialNumber
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[End date of effective period for serial number]]>
	Public Property [EndDate] As DateTime?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Blocking state]]>
	Public Property [IsBlocked] As Byte?
	'''<![CDATA[Item]]>
	Public Property [Item] As Guid?
	'''<![CDATA[Item code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemCode] As String
	'''<![CDATA[Description of item]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemDescription] As String
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Remarks]]>
	Public Property [Remarks] As String
	'''<![CDATA[Human readable serial number]]>
	Public Property [SerialNumber] As String
	'''<![CDATA[Serial number ID]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SerialNumberID] As Guid?
	'''<![CDATA[Start date of effective period for serial number]]>
	Public Property [StartDate] As DateTime?
	'''<![CDATA[ID of stock count entry]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [StockCountLine] As Guid?
	Public Property [StockTransactionID] As Guid?
	'''<![CDATA[Storage Location Code]]>
	Public Property [StorageLocationCode] As String
	'''<![CDATA[Warehouse Code]]>
	Public Property [WarehouseCode] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class StorageLocation
	'''<![CDATA[Code of the storage location]]>
	Public Property [Code] As String
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Description of the storage location]]>
	Public Property [Description] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Indicates if this is the main storage location. There's always exactly one main storage location per warehouse]]>
	Public Property [Main] As Byte?
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Warehouse ID]]>
	Public Property [Warehouse] As Guid?
	'''<![CDATA[Warehouse Code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [WarehouseCode] As String
	'''<![CDATA[Description of warehouse]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [WarehouseDescription] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("EntryID")>
Public Class Subscription
	'''<![CDATA[Indicates if subscription is blocked for time cost entry]]>
	Public Property [BlockEntry] As Boolean?
	'''<![CDATA[Date of cancellation]]>
	Public Property [CancellationDate] As DateTime?
	'''<![CDATA[Reference to Classification]]>
	Public Property [Classification] As Guid?
	'''<![CDATA[Code of Classification]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ClassificationCode] As String
	'''<![CDATA[Description of Classification]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ClassificationDescription] As String
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Currency code]]>
	Public Property [Currency] As String
	'''<![CDATA[Purchase order number of customer]]>
	Public Property [CustomerPONumber] As String
	'''<![CDATA[Description]]>
	Public Property [Description] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32
	'''<![CDATA[End date]]>
	Public Property [EndDate] As DateTime?
	'''<![CDATA[Primary key]]>
	Public Property [EntryID] As Guid
	'''<![CDATA[Invoice Day]]>
	Public Property [InvoiceDay] As Byte?
	'''<![CDATA[Invoice date]]>
	Public Property [InvoicedTo] As DateTime?
	'''<![CDATA[Reference to invoice account]]>
	Public Property [InvoiceTo] As Guid?
	'''<![CDATA[Reference to contact person of invoice account]]>
	Public Property [InvoiceToContactPerson] As Guid?
	'''<![CDATA[Name of contact person of invoice account]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [InvoiceToContactPersonFullName] As String
	'''<![CDATA[Name of invoice account]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [InvoiceToName] As String
	'''<![CDATA[Invoicing start date]]>
	Public Property [InvoicingStartDate] As DateTime?
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Remarks]]>
	Public Property [Notes] As String
	'''<![CDATA[Number]]>
	Public Property [Number] As Int32
	'''<![CDATA[Reference to order account]]>
	Public Property [OrderedBy] As Guid?
	'''<![CDATA[Reference of contact person of order account]]>
	Public Property [OrderedByContactPerson] As Guid?
	'''<![CDATA[Name of contact person of order account]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [OrderedByContactPersonFullName] As String
	'''<![CDATA[Name of order account]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [OrderedByName] As String
	'''<![CDATA[Payment condition]]>
	Public Property [PaymentCondition] As String
	'''<![CDATA[Description of PaymentCondition]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PaymentConditionDescription] As String
	'''<![CDATA[Indicates if subscription is printed]]>
	Public Property [Printed] As Boolean
	'''<![CDATA[Reference to reason cancelled]]>
	Public Property [ReasonCancelled] As Guid?
	'''<![CDATA[Code of ReasonCancelled]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ReasonCancelledCode] As String
	'''<![CDATA[Description of ReasonCancelled]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ReasonCancelledDescription] As String
	'''<![CDATA[Start date]]>
	Public Property [StartDate] As DateTime
	'''<![CDATA[Collection of subscription lines]]>
	Public Property [SubscriptionLines] As IEnumerable(Of SubscriptionLine)
	'''<![CDATA[Collection of restriction employees]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SubscriptionRestrictionEmployees] As IEnumerable(Of SubscriptionRestrictionEmployee)
	'''<![CDATA[Collection of restriction items]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SubscriptionRestrictionItems] As IEnumerable(Of SubscriptionRestrictionItem)
	'''<![CDATA[Reference to subscription type]]>
	Public Property [SubscriptionType] As Guid
	'''<![CDATA[Code of SubscriptionType]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SubscriptionTypeCode] As String
	'''<![CDATA[Description of SubscriptionType]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SubscriptionTypeDescription] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class SubscriptionChargeType
	'''<![CDATA[Description]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Description] As String
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Int16
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class SubscriptionLine
	'''<![CDATA[Amount in the default currency of the company]]>
	Public Property [AmountDC] As Double
	'''<![CDATA[Amount in the currency of the transaction]]>
	Public Property [AmountFC] As Double
	'''<![CDATA[Cost center]]>
	Public Property [Costcenter] As String
	'''<![CDATA[Cost unit]]>
	Public Property [Costunit] As String
	'''<![CDATA[Description]]>
	Public Property [Description] As String
	'''<![CDATA[Discount percentage]]>
	Public Property [Discount] As Double?
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32
	'''<![CDATA[Entry ID]]>
	Public Property [EntryID] As Guid
	'''<![CDATA[From date]]>
	Public Property [FromDate] As DateTime
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Reference to Item]]>
	Public Property [Item] As Guid
	'''<![CDATA[Description of Item]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemDescription] As String
	'''<![CDATA[Line number]]>
	Public Property [LineNumber] As Int32
	'''<![CDATA[Reference to LineType]]>
	Public Property [LineType] As Int16?
	'''<![CDATA[Description of LineType]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [LineTypeDescription] As String
	'''<![CDATA[Net price in the currency of the transaction]]>
	Public Property [NetPrice] As Double
	'''<![CDATA[Remarks]]>
	Public Property [Notes] As String
	'''<![CDATA[Quantity]]>
	Public Property [Quantity] As Double
	'''<![CDATA[To date]]>
	Public Property [ToDate] As DateTime?
	'''<![CDATA[Unit code]]>
	Public Property [UnitCode] As String
	'''<![CDATA[Description of Unit]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [UnitDescription] As String
	'''<![CDATA[Unit price in the currency of the transaction (price * unit factor)]]>
	Public Property [UnitPrice] As Double
	'''<![CDATA[Vat Amount in the currency of the transaction]]>
	Public Property [VATAmountFC] As Double?
	'''<![CDATA[VATCode]]>
	Public Property [VATCode] As String
	'''<![CDATA[Description of VATCode]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [VATCodeDescription] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class SubscriptionReasonCode
	'''<![CDATA[Indicates if the reason code is active]]>
	Public Property [Active] As Boolean
	'''<![CDATA[Subscription reason code]]>
	Public Property [Code] As String
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Description]]>
	Public Property [Description] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Remarks]]>
	Public Property [Notes] As String
End Class

<SupportedActionsSDK(True, True, False, True)>
<DataServiceKey("ID")>
Public Class SubscriptionRestrictionEmployee
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of the creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of the creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32
	'''<![CDATA[Employee linked to the restriction]]>
	Public Property [Employee] As Guid?
	'''<![CDATA[Name of employee]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [EmployeeFullName] As String
	'''<![CDATA[Readable ID of employee]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [EmployeeHID] As Int32?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of the last modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of the last modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Reference to subscription]]>
	Public Property [Subscription] As Guid
	'''<![CDATA[Description of subscription]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SubscriptionDescription] As String
	'''<![CDATA[Number of subscription]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SubscriptionNumber] As Int32
End Class

<SupportedActionsSDK(True, True, False, True)>
<DataServiceKey("ID")>
Public Class SubscriptionRestrictionItem
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of the creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of the creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Item linked to the restriction]]>
	Public Property [Item] As Guid?
	'''<![CDATA[Code of item]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemCode] As String
	'''<![CDATA[Description of item]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemDescription] As String
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of the last modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of the last modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Reference to subscription]]>
	Public Property [Subscription] As Guid
	'''<![CDATA[Description of subscription]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SubscriptionDescription] As String
	'''<![CDATA[Number of subscription]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SubscriptionNumber] As Int32
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class SubscriptionType
	'''<![CDATA[Code]]>
	Public Property [Code] As String
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of the creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of the creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Description]]>
	Public Property [Description] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of the last modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of the last modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class TaxComponentRate
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Division]]>
	Public Property [Division] As Int32
	'''<![CDATA[The date untill the rate for this component is valid]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [EndDate] As DateTime?
	'''<![CDATA[Primary Key]]>
	Public Property [ID] As Guid
	'''<![CDATA[The sequence in which the tax rates are ordered]]>
	Public Property [LineNumber] As Int32
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Rate]]>
	Public Property [Rate] As Double
	'''<![CDATA[The date from which the rate is active]]>
	Public Property [StartDate] As DateTime?
	'''<![CDATA[Tax component to which this tax rate is linked]]>
	Public Property [TaxComponent] As Guid
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("DocumentID")>
Public Class TaxDocument
	'''<![CDATA[Amount in the currency of the transaction]]>
	Public Property [Amount] As Double?
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime
	'''<![CDATA[Currency]]>
	Public Property [Currency] As String
	'''<![CDATA[Description]]>
	Public Property [Description] As String
	'''<![CDATA[Primary key, document ID]]>
	Public Property [DocumentID] As Guid
	'''<![CDATA[Url to view the document]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DocumentViewUrl] As String
	'''<![CDATA[Due date]]>
	Public Property [DueDate] As DateTime?
	'''<![CDATA[Frequency]]>
	Public Property [Frequency] As String
	'''<![CDATA[Payroll declaration type]]>
	Public Property [PayrollDeclarationType] As String
	'''<![CDATA[Period]]>
	Public Property [Period] As Int32
	'''<![CDATA[Description of Period]]>
	Public Property [PeriodDescription] As String
	'''<![CDATA[Reference to request]]>
	Public Property [Request] As Guid?
	'''<![CDATA[Status]]>
	Public Property [Status] As Int32
	'''<![CDATA[Type]]>
	Public Property [Type] As Int32
	'''<![CDATA[Year]]>
	Public Property [Year] As Int32
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class TaxEmploymentEndFlexCode
	'''<![CDATA[Code of flexible employment contract phase]]>
	Public Property [Code] As String
	'''<![CDATA[Creation date]]>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Description of flexible employment contract phase]]>
	Public Property [Description] As String
	'''<![CDATA[End date of flexible employment contract]]>
	Public Property [EndDate] As DateTime?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Last modified date]]>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Start date of flexible employment contract phase]]>
	Public Property [StartDate] As DateTime?
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class TaxSchedule
	'''<![CDATA[Tax schedule code]]>
	Public Property [Code] As String
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Tax schedule description]]>
	Public Property [Description] As String
	'''<![CDATA[Division]]>
	Public Property [Division] As Int32
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Indicates if the tax schedule is blocked, 0 = not blocked, 1 = blocked]]>
	Public Property [IsBlocked] As Byte
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Notes for the tax schedule]]>
	Public Property [Notes] As String
	'''<![CDATA[The type of tax schedule, 10=Single, 20=Combined]]>
	Public Property [Type] As Int16
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class TaxScheduleComponent
	'''<![CDATA[Account linked to the tax schedule]]>
	Public Property [Account] As Guid?
	'''<![CDATA[Tax schedule code]]>
	Public Property [Code] As String
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Tax schedule description]]>
	Public Property [Description] As String
	'''<![CDATA[Division]]>
	Public Property [Division] As Int32
	'''<![CDATA[GLAccount linked to the tax component]]>
	Public Property [GLAccount] As Guid?
	'''<![CDATA[Primary Key]]>
	Public Property [ID] As Guid
	'''<![CDATA[The sequence in which the tax components are ordered]]>
	Public Property [LineNumber] As Int32
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Notes]]>
	Public Property [Notes] As String
	'''<![CDATA[Id of the tax component]]>
	Public Property [TaxComponent] As Guid
	'''<![CDATA[Collection of Rates for this tax component]]>
	Public Property [TaxComponentRates] As IEnumerable(Of TaxComponentRate)
	'''<![CDATA[Tax schedule to which the tax component is linked]]>
	Public Property [TaxSchedule] As Guid
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("AccountId")>
Public Class TimeAndBillingAccount
	'''<![CDATA[Primary key]]>
	Public Property [AccountId] As Guid
	'''<![CDATA[Name of account]]>
	Public Property [AccountName] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class TimeAndBillingAccountDetails
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Name]]>
	Public Property [Name] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class TimeAndBillingActivitiesAndExpenses
	'''<![CDATA[Description]]>
	Public Property [Description] As String
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Description of Parent]]>
	Public Property [ParentDescription] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class TimeAndBillingItemDetails
	'''<![CDATA[Item code]]>
	Public Property [Code] As String
	'''<![CDATA[Description of the item code]]>
	Public Property [Description] As String
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Indicates if fractions are allowed for quantities of this item]]>
	Public Property [IsFractionAllowedItem] As Boolean
	'''<![CDATA[Indicates if the item can be sold]]>
	Public Property [IsSalesItem] As Boolean
	'''<![CDATA[Sales currency code]]>
	Public Property [SalesCurrency] As String
	'''<![CDATA[Sales price]]>
	Public Property [SalesPrice] As Double
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ProjectId")>
Public Class TimeAndBillingProject
	'''<![CDATA[Code]]>
	Public Property [ProjectCode] As String
	'''<![CDATA[Description]]>
	Public Property [ProjectDescription] As String
	'''<![CDATA[Primary key]]>
	Public Property [ProjectId] As Guid
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class TimeAndBillingProjectDetails
	'''<![CDATA[The account for this project]]>
	Public Property [Account] As Guid?
	Public Property [AccountName] As String
	'''<![CDATA[Code of project]]>
	Public Property [Code] As String
	'''<![CDATA[Description of the project]]>
	Public Property [Description] As String
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Reference to ProjectTypes]]>
	Public Property [Type] As Int32
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("AccountId")>
Public Class TimeAndBillingRecentAccount
	'''<![CDATA[Primary key]]>
	Public Property [AccountId] As Guid
	'''<![CDATA[Name of account]]>
	Public Property [AccountName] As String
	'''<![CDATA[Date last used]]>
	Public Property [DateLastUsed] As DateTime
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class TimeAndBillingRecentActivitiesAndExpenses
	'''<![CDATA[Date last used]]>
	Public Property [DateLastUsed] As DateTime
	'''<![CDATA[Description]]>
	Public Property [Description] As String
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Description of Parent]]>
	Public Property [ParentDescription] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ItemId")>
Public Class TimeAndBillingRecentHourCostType
	'''<![CDATA[Date last used]]>
	Public Property [DateLastUsed] As DateTime
	'''<![CDATA[Description of item]]>
	Public Property [ItemDescription] As String
	'''<![CDATA[Primary key]]>
	Public Property [ItemId] As Guid
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ProjectId")>
Public Class TimeAndBillingRecentProject
	'''<![CDATA[Date last used]]>
	Public Property [DateLastUsed] As DateTime
	'''<![CDATA[Code of project]]>
	Public Property [ProjectCode] As String
	'''<![CDATA[Description of project]]>
	Public Property [ProjectDescription] As String
	'''<![CDATA[Primary key]]>
	Public Property [ProjectId] As Guid
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class TimeCorrection
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Id]]>
	Public Property [ID] As Guid
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Notes]]>
	Public Property [Notes] As String
	'''<![CDATA[Reference to the time entry that this corrects for]]>
	Public Property [OriginalEntryId] As Guid?
	'''<![CDATA[Quantity has to be negative value. E.g.: If original quantity is 10 and the correct quantity is 4, this quantity is -6]]>
	Public Property [Quantity] As Double?
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class TimeTransaction
	'''<![CDATA[Account linked to the transaction]]>
	Public Property [Account] As Guid?
	'''<![CDATA[Name of Account]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountName] As String
	'''<![CDATA[Reference to ProjectWBS (work breakdown structure)]]>
	Public Property [Activity] As Guid?
	'''<![CDATA[Description of ProjectWBS]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ActivityDescription] As String
	'''<![CDATA[Amount in the currency of the transaction]]>
	Public Property [Amount] As Double?
	'''<![CDATA[Amount in the currency of the transaction of the transaction]]>
	Public Property [AmountFC] As Double?
	'''<![CDATA[Attachment linked to the transaction]]>
	Public Property [Attachment] As Guid?
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Currency of the amount]]>
	Public Property [Currency] As String
	'''<![CDATA[Date]]>
	Public Property [Date] As DateTime?
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Description of Division]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DivisionDescription] As String
	'''<![CDATA[Employee linked to the transaction]]>
	Public Property [Employee] As Guid?
	'''<![CDATA[End time of the transaction]]>
	Public Property [EndTime] As DateTime?
	'''<![CDATA[Entrynumber]]>
	Public Property [EntryNumber] As Int32?
	'''<![CDATA[Errortext, used for the backgroundjobs]]>
	Public Property [ErrorText] As String
	'''<![CDATA[Status of the transaction]]>
	Public Property [HourStatus] As Int16?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Item linked to the transaction. Items of type 'time' are linked to time transactions. Items of other types are linked to cost transactions]]>
	Public Property [Item] As Guid?
	'''<![CDATA[Description of Item]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemDescription] As String
	'''<![CDATA[True if you can use decimals for item quantity]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemDivisable] As Boolean?
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Notes linked to the transaction]]>
	Public Property [Notes] As String
	'''<![CDATA[Price in the currency of the transaction]]>
	Public Property [Price] As Double?
	'''<![CDATA[PriceFC (AmountFC = Quantity * PriceFC)]]>
	Public Property [PriceFC] As Double?
	'''<![CDATA[Project linked to the transaction]]>
	Public Property [Project] As Guid?
	'''<![CDATA[Reference to project account]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectAccount] As Guid?
	'''<![CDATA[Project account code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectAccountCode] As String
	'''<![CDATA[Project account name]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectAccountName] As String
	'''<![CDATA[Description of Project]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectDescription] As String
	'''<![CDATA[Quantity of the transaction]]>
	Public Property [Quantity] As Double?
	'''<![CDATA[Start time of the transaction]]>
	Public Property [StartTime] As DateTime?
	'''<![CDATA[Subscription linked to the transaction]]>
	Public Property [Subscription] As Guid?
	'''<![CDATA[Account linked to the subscription]]>
	Public Property [SubscriptionAccount] As Guid?
	'''<![CDATA[Subscription account code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SubscriptionAccountCode] As String
	'''<![CDATA[Subscription account name]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SubscriptionAccountName] As String
	'''<![CDATA[Description of the subscription]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SubscriptionDescription] As String
	'''<![CDATA[Subscription number]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SubscriptionNumber] As Int32?
	'''<![CDATA[Type of the transaction]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Type] As Int16?
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("EntryID")>
Public Class Transaction
	'''<![CDATA[Closing balance in the currency of the transaction]]>
	Public Property [ClosingBalanceFC] As Double?
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[Date]]>
	Public Property [Date] As DateTime?
	'''<![CDATA[Description]]>
	Public Property [Description] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32
	'''<![CDATA[Primary key]]>
	Public Property [EntryID] As Guid
	'''<![CDATA[Entry number]]>
	Public Property [EntryNumber] As Int32?
	'''<![CDATA[Financial period]]>
	Public Property [FinancialPeriod] As Int16?
	'''<![CDATA[Financial year]]>
	Public Property [FinancialYear] As Int16?
	'''<![CDATA[0 =  Financial entry without extra duty, 1 = Financial entry with extra duty]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [IsExtraDuty] As Boolean?
	'''<![CDATA[Code of Journal]]>
	Public Property [JournalCode] As String
	'''<![CDATA[Description of Journal]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [JournalDescription] As String
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[Opening balance in the currency of the transaction]]>
	Public Property [OpeningBalanceFC] As Double?
	'''<![CDATA[Code of PaymentCondition]]>
	Public Property [PaymentConditionCode] As String
	'''<![CDATA[Description of PaymentCondition]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PaymentConditionDescription] As String
	'''<![CDATA[Status: 5 = Rejected, 20 = Open, 50 = Processed]]>
	Public Property [Status] As Int16?
	'''<![CDATA[Description of Status]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [StatusDescription] As String
	'''<![CDATA[Collection of lines]]>
	Public Property [TransactionLines] As IEnumerable(Of TransactionLine)
	'''<![CDATA[The transaction type. 10 = Opening balance, 20 = Sales entry, 21 = Sales credit note, 22 = Return invoice sent, 30 = Purchase entry, 31 = Purchase credit note, 32 = Return invoice received, 40 = Cash flow, 50 = VAT return, 70 = Asset depreciation, 71 = Asset investment, 72 = Asset revaluation, 73 = Asset transfer, 74 = Asset split, 75 = Asset discontinue, 76 = Asset sales, 80 = Revaluation, 82 = Exchange rate difference, 83 = Payment difference, 84 = Deferred revenue, 85 = Tracking number:Revaluation, 86 = Deferred cost, 90 = Other, 120 = Delivery, 121 = Sales return, 130 = Receipt, 131 = Purchase return, 140 = Shop order stock receipt, 141 = Shop order stock reversal, 142 = Issue to parent, 145 = Shop order time entry, 146 = Shop order time entry reversal, 150 = Requirement issue, 151 = Requirement reversal, 152 = Returned from parent, 155 = Subcontract Issue, 156 = Subcontract reversal, 158 = Shop order completed, 162 = Finish assembly, 170 = Payroll, 180 = Stock revaluation, 195 = Stock count, 290 = Correction entry, 310 = Period closing, 320 = Year end reflection, 321 = Year end costing, 322 = Year end profits to gross profit, 323 = Year end costs to gross profit, 324 = Year end tax, 325 = Year end gross profit to net p/l, 326 = Year end net p/l to balance sheet, 327 = Year end closing balance, 328 = Year start opening balance, 3000 = Budget]]>
	Public Property [Type] As Int32
	'''<![CDATA[The description of the transaction type]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [TypeDescription] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class TransactionLine
	'''<![CDATA[Reference to account]]>
	Public Property [Account] As Guid?
	'''<![CDATA[Code of the Account]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountCode] As String
	'''<![CDATA[Name of the Account]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountName] As String
	'''<![CDATA[Amount in the default currency of the company]]>
	Public Property [AmountDC] As Double
	'''<![CDATA[Amount in the currency of the transaction]]>
	Public Property [AmountFC] As Double
	'''<![CDATA[Vat base amount in the currency of the transaction]]>
	Public Property [AmountVATBaseFC] As Double?
	'''<![CDATA[Vat amount in the currency of the transaction]]>
	Public Property [AmountVATFC] As Double?
	'''<![CDATA[Reference to asset]]>
	Public Property [Asset] As Guid?
	'''<![CDATA[Code of Asset]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AssetCode] As String
	'''<![CDATA[Description of Asset]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AssetDescription] As String
	'''<![CDATA[Reference to cost center]]>
	Public Property [CostCenter] As String
	'''<![CDATA[Description of CostCenter]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostCenterDescription] As String
	'''<![CDATA[Reference to cost unit]]>
	Public Property [CostUnit] As String
	'''<![CDATA[Description of CostUnit]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostUnitDescription] As String
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Currency]]>
	Public Property [Currency] As String
	'''<![CDATA[Date]]>
	Public Property [Date] As DateTime?
	'''<![CDATA[Description]]>
	Public Property [Description] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32
	'''<![CDATA[Reference to document]]>
	Public Property [Document] As Guid?
	'''<![CDATA[Number of the document]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DocumentNumber] As Int32?
	'''<![CDATA[Subject of the document]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DocumentSubject] As String
	'''<![CDATA[Date that payment should be done]]>
	Public Property [DueDate] As DateTime?
	'''<![CDATA[Reference to header of the entry]]>
	Public Property [EntryID] As Guid?
	'''<![CDATA[Entry number of the header]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [EntryNumber] As Int32?
	'''<![CDATA[Exchange rate]]>
	Public Property [ExchangeRate] As Double?
	'''<![CDATA[Extra duty amount]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ExtraDutyAmountFC] As Double?
	'''<![CDATA[Extra duty percentage]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ExtraDutyPercentage] As Double?
	'''<![CDATA[Financial period]]>
	Public Property [FinancialPeriod] As Int16?
	'''<![CDATA[Financial year]]>
	Public Property [FinancialYear] As Int16?
	'''<![CDATA[General ledger account]]>
	Public Property [GLAccount] As Guid?
	'''<![CDATA[Code of GLAccount]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLAccountCode] As String
	'''<![CDATA[Description of GLAccount]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLAccountDescription] As String
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Invoice number]]>
	Public Property [InvoiceNumber] As Int32?
	'''<![CDATA[Reference to item]]>
	Public Property [Item] As Guid?
	'''<![CDATA[Code of Item]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemCode] As String
	'''<![CDATA[Description of Item]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemDescription] As String
	'''<![CDATA[The journal code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [JournalCode] As String
	'''<![CDATA[The journal description]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [JournalDescription] As String
	'''<![CDATA[Line number]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [LineNumber] As Int32?
	'''<![CDATA[Line type]]>
	Public Property [LineType] As Int16
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Extra remarks]]>
	Public Property [Notes] As String
	'''<![CDATA[OffsetID]]>
	Public Property [OffsetID] As Guid?
	'''<![CDATA[Order number]]>
	Public Property [OrderNumber] As Int32?
	'''<![CDATA[Discount amount when paid in time]]>
	Public Property [PaymentDiscountAmount] As Double?
	'''<![CDATA[Payment reference]]>
	Public Property [PaymentReference] As String
	'''<![CDATA[Reference to project]]>
	Public Property [Project] As Guid?
	'''<![CDATA[Code of Project]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectCode] As String
	'''<![CDATA[Description of Project]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectDescription] As String
	'''<![CDATA[Quantity]]>
	Public Property [Quantity] As Double?
	'''<![CDATA[Serial number of item]]>
	Public Property [SerialNumber] As String
	'''<![CDATA[Reference to subscription]]>
	Public Property [Subscription] As Guid?
	'''<![CDATA[Description of Subscription]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SubscriptionDescription] As String
	'''<![CDATA[Tracking number of item]]>
	Public Property [TrackingNumber] As String
	'''<![CDATA[Tracking number description]]>
	Public Property [TrackingNumberDescription] As String
	'''<![CDATA[Vat code]]>
	Public Property [VATCode] As String
	'''<![CDATA[Description of VATCode]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [VATCodeDescription] As String
	'''<![CDATA[Vat percentage]]>
	Public Property [VATPercentage] As Double?
	'''<![CDATA[Vat type]]>
	Public Property [VATType] As String
	'''<![CDATA[Your reference (of customer)]]>
	Public Property [YourRef] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class Unit
	'''<![CDATA[Indicates whether a unit is in use]]>
	Public Property [Active] As Boolean?
	'''<![CDATA[Unique code for the unit]]>
	Public Property [Code] As String
	'''<![CDATA[Description]]>
	Public Property [Description] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Indicates the main unit per division. Will be used when creating new item]]>
	Public Property [Main] As Byte?
	'''<![CDATA[If Type = 'T' (time) then this fields indicates the type of time frame. yy = Year, mm = Month, wk = Week, dd = Day, hh = Hour, mi = Minute, ss = Second]]>
	Public Property [TimeUnit] As String
	'''<![CDATA[Type of unit. Type 'Time' is especially important for contracts.]]>
	Public Property [Type] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("UserID")>
Public Class User
	'''<![CDATA[Birth date]]>
	Public Property [BirthDate] As DateTime?
	'''<![CDATA[Birth name]]>
	Public Property [BirthName] As String
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of the creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of the creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Customer the user belongs to]]>
	Public Property [Customer] As Guid
	'''<![CDATA[Name of Customer]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CustomerName] As String
	'''<![CDATA[Email address of the user]]>
	Public Property [Email] As String
	'''<![CDATA[Date after which the user login is disabled. NULL means no enddate]]>
	Public Property [EndDate] As DateTime?
	'''<![CDATA[First name]]>
	Public Property [FirstName] As String
	'''<![CDATA[Full name of the user]]>
	Public Property [FullName] As String
	'''<![CDATA[Gender: M=Male, V=Female, O=Unknown]]>
	Public Property [Gender] As String
	'''<![CDATA[Initials]]>
	Public Property [Initials] As String
	'''<![CDATA[Language (culture) that is used in Exact Online]]>
	Public Property [Language] As String
	'''<![CDATA[The last time this user logged in]]>
	Public Property [LastLogin] As DateTime?
	'''<![CDATA[Last name]]>
	Public Property [LastName] As String
	'''<![CDATA[Middle name]]>
	Public Property [MiddleName] As String
	'''<![CDATA[Mobile phone]]>
	Public Property [Mobile] As String
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of the last modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of the last modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Nationality]]>
	Public Property [Nationality] As String
	'''<![CDATA[Remarks]]>
	Public Property [Notes] As String
	'''<![CDATA[Phone number]]>
	Public Property [Phone] As String
	'''<![CDATA[Phone number extension]]>
	Public Property [PhoneExtension] As String
	'''<![CDATA[Profile code]]>
	Public Property [ProfileCode] As String
	'''<![CDATA[Startdate after which the login is allowed. If the start date is NULL the login is allowed as well]]>
	Public Property [StartDate] As DateTime?
	'''<![CDATA[Start Division]]>
	Public Property [StartDivision] As Int32
	'''<![CDATA[Title]]>
	Public Property [Title] As String
	'''<![CDATA[Primary key]]>
	Public Property [UserID] As Guid
	'''<![CDATA[Login name of the user]]>
	Public Property [UserName] As String
	'''<![CDATA[Collection of user roles]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [UserRoles] As IEnumerable(Of UserRole)
	'''<![CDATA[Collection of user roles per division]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [UserRolesPerDivision] As IEnumerable(Of UserRolePerDivision)
	'''<![CDATA[Obsolete]]>
	Public Property [UserTypesList] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class UserRole
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of the creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of the creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Description]]>
	Public Property [Description] As String
	'''<![CDATA[Indicates the date and time when te role becomes inactive for the user]]>
	Public Property [EndDate] As DateTime?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of the last modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of the last modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[The role that the user is linked to]]>
	Public Property [Role] As Int32
	'''<![CDATA[Rolelevel sets the level on which a role for a user is active. This can be: 1 = Database, 2 = Customer, 3 = Division, 100 = Transferred to accountant]]>
	Public Property [RoleLevel] As Int32
	'''<![CDATA[Indicates the date when the role becomes active for the user]]>
	Public Property [StartDate] As DateTime
	'''<![CDATA[The user that is linked to the role]]>
	Public Property [UserID] As Guid?
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class UserRolePerDivision
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of the creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of the creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Description]]>
	Public Property [Description] As String
	'''<![CDATA[Division code]]>
	Public Property [Division] As Int32
	'''<![CDATA[Indicates the date and time when te role becomes inactive for the user]]>
	Public Property [EndDate] As DateTime?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of the last modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of the last modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[The role that the user is linked to]]>
	Public Property [Role] As Int32
	'''<![CDATA[Rolelevel sets the level on which a role for a user is active. This can be: 1 = Database, 2 = Customer, 3 = Division, 100 = Transferred to accountant]]>
	Public Property [RoleLevel] As Int32
	'''<![CDATA[Indicates the date when the role becomes active for the user]]>
	Public Property [StartDate] As DateTime
	'''<![CDATA[The user that is linked to the role]]>
	Public Property [UserID] As Guid?
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class VATCode
	'''<![CDATA[Tax account]]>
	Public Property [Account] As Guid?
	'''<![CDATA[Code of Account]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountCode] As String
	'''<![CDATA[Name of Account]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountName] As String
	'''<![CDATA[Indicates how to calculate the tax. 0 = based on the gross amount, 1 = based on the gross amount + another tax]]>
	Public Property [CalculationBasis] As Byte?
	'''<![CDATA[Indicates if transactions using the VAT code are transactions of the domestic VAT charging regulation (such as those for subcontractors) or transactions that are registered within the EU. If Charged=1 and linked to a purchase invoice, both a line for the VAT to pay and a line for the VAT to claim are being created]]>
	Public Property [Charged] As Boolean?
	'''<![CDATA[VAT code]]>
	Public Property [Code] As String
	'''<![CDATA[Obsolete]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Country] As String
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Description of the VAT code]]>
	Public Property [Description] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Indicates if and how transactions using the VAT code appear on the ICT return (EU sales list). L = Listing goods, N = No listing, S = Listing services, T = Triangulation]]>
	Public Property [EUSalesListing] As String
	'''<![CDATA[Indicates the purchase discount GL account linked to the VAT codes for German legislation]]>
	Public Property [GLDiscountPurchase] As Guid?
	'''<![CDATA[Code of GLDiscountPurchase]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLDiscountPurchaseCode] As String
	'''<![CDATA[Description of GLDiscountPurchase]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLDiscountPurchaseDescription] As String
	'''<![CDATA[Indicates the sales discount GL account linked to the VAT codes for German legislation]]>
	Public Property [GLDiscountSales] As Guid?
	'''<![CDATA[Code of GLDiscountSales]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLDiscountSalesCode] As String
	'''<![CDATA[Description of GLDiscountSales]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLDiscountSalesDescription] As String
	'''<![CDATA[G/L account that is used to book the VAT to claim. If you enter purchases with a VAT code, the VAT amount to be claimed is entered to this VAT account. Must be of type VAT]]>
	Public Property [GLToClaim] As Guid?
	'''<![CDATA[Code of GLToClaim]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLToClaimCode] As String
	'''<![CDATA[Description of GLToClaim]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLToClaimDescription] As String
	'''<![CDATA[G/L account that is used to book the VAT to pay. If you enter sales with a VAT code, the VAT amount to be paid is entered to this VAT account. Must be of type VAT]]>
	Public Property [GLToPay] As Guid?
	'''<![CDATA[Code of GLToPay]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLToPayCode] As String
	'''<![CDATA[Description of GLToPay]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLToPayDescription] As String
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Indicates if intrastat is used]]>
	Public Property [IntraStat] As Boolean?
	'''<![CDATA[Indicates if the VAT code may still be used]]>
	Public Property [IsBlocked] As Boolean?
	'''<![CDATA[Legal description for VAT code to print in the total block of the invoice]]>
	Public Property [LegalText] As String
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[User name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Percentage of the VAT code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Percentage] As Double?
	'''<![CDATA[Indicates what type of Taxcode it is: can be VAT, IncomeTax]]>
	Public Property [TaxReturnType] As Int16?
	'''<![CDATA[Indicates how the VAT amount should be calculated in relation to the invoice amount. B = VAT 0% (Only base amount), E = Excluding, I = Including, N = No VAT]]>
	Public Property [Type] As String
	'''<![CDATA[Field in VAT code maintenance to calculate different VATs depending on the selected document type. P = purchase invoice, F = freelance invoice, E = expense voucher. The field is valid for witholding tax type]]>
	Public Property [VatDocType] As String
	'''<![CDATA[The VAT margin scheme is used for the trade of secondhand goods which are purchased without VAT (for example when a company buys a secondhand good from a private person). In the VAT margin scheme, the VAT is not calculated based on the sales price. Instead of that, the VAT is calculated based on the margin (gross sales price minus the gross purchase price)]]>
	Public Property [VatMargin] As Byte
	'''<![CDATA[Partial ratio explains which part of the VAT the company has to pay. Used in some branches where the sellers have a bad reputation, so the buyers have to take over the VAT-liability]]>
	Public Property [VATPartialRatio] As Int16?
	'''<![CDATA[VAT percentages. You can have several VAT percentages, with start and end dates]]>
	Public Property [VATPercentages] As IEnumerable(Of VatPercentage)
	'''<![CDATA[Indicates the type of transactions for which the VAT code may be used. B = Both, P = Purchase, S = Sales]]>
	Public Property [VATTransactionType] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class VatPercentage
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[End date of the date range during which this percentage is valid]]>
	Public Property [EndDate] As DateTime?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Line number]]>
	Public Property [LineNumber] As Int32?
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Percentage]]>
	Public Property [Percentage] As Double?
	'''<![CDATA[Start date of the date range during which this percentage is valid]]>
	Public Property [StartDate] As DateTime?
	'''<![CDATA[0 = Normal, 1 = Extra duty]]>
	Public Property [Type] As Int16
	'''<![CDATA[VAT code]]>
	Public Property [VATCodeID] As Guid
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class Warehouse
	'''<![CDATA[Code of the warehouse]]>
	Public Property [Code] As String
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[The description of the warehouse]]>
	Public Property [Description] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[Email address]]>
	Public Property [EMail] As String
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Indicates if this is the main warehouse. There's always exactly one main warehouse per administration]]>
	Public Property [Main] As Byte
	'''<![CDATA[User reponsible for the warehouse]]>
	Public Property [ManagerUser] As Guid?
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Indicates if this warehouse is using storage locations. The storage locations will not be removed when when this is deactivated]]>
	Public Property [UseStorageLocations] As Byte
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class Workcenter
	'''<![CDATA[Code of the work center]]>
	Public Property [Code] As String
	'''<![CDATA[Reference to CostCenters]]>
	Public Property [Costcenter] As String
	'''<![CDATA[Description of Costcenter]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostcenterDescription] As String
	'''<![CDATA[Reference to CostUnits]]>
	Public Property [Costunit] As String
	'''<![CDATA[Description of Costunit]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostunitDescription] As String
	'''<![CDATA[Creation date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<![CDATA[User ID of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<![CDATA[Name of creator]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<![CDATA[Description of the work center]]>
	Public Property [Description] As String
	'''<![CDATA[Division code]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<![CDATA[General burden rate]]>
	Public Property [GeneralBurdenRate] As Double?
	'''<![CDATA[Primary key]]>
	Public Property [ID] As Guid
	'''<![CDATA[Indicates if labor burden is calculated as a percentage or amount]]>
	Public Property [IsLaborBurdenPercent] As Byte
	'''<![CDATA[Labor burden rate]]>
	Public Property [LaborBurdenRate] As Double?
	'''<![CDATA[Machine burden rate]]>
	Public Property [MachineBurdenRate] As Double?
	'''<![CDATA[Last modified date]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<![CDATA[User ID of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<![CDATA[Name of modifier]]>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<![CDATA[Remarks]]>
	Public Property [Notes] As String
	'''<![CDATA[Area to which the work center belongs.]]>
	Public Property [ProductionArea] As Guid?
	'''<![CDATA[Run labor rate]]>
	Public Property [RunLaborRate] As Double?
	'''<![CDATA[Search code of the work center]]>
	Public Property [SearchCode] As String
	'''<![CDATA[Setup labor rate]]>
	Public Property [SetupLaborRate] As Double?
	'''<![CDATA[Reference to WorkcenterStatus]]>
	Public Property [Status] As Int16?
	'''<![CDATA[Reference to WorkcenterTypes]]>
	Public Property [Type] As Int16?
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class WebhookSubscription
	Public Property [ID] As Guid
	Public Property [CallbackURL] As String
	Public Property [Topic] As String
End Class

