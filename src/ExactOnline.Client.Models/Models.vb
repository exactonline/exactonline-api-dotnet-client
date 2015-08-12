' Last generated on 2015-08-11 19:55:56 +02:00

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class Account
	Public Property [Accountant] As Guid?
	Public Property [AccountManager] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountManagerFullName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountManagerHID] As Int32?
	Public Property [ActivitySector] As Guid?
	Public Property [ActivitySubSector] As Guid?
	Public Property [AddressLine1] As String
	Public Property [AddressLine2] As String
	Public Property [AddressLine3] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [BankAccounts] As IEnumerable(Of BankAccount)
	Public Property [Blocked] As Boolean?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [BRIN] As Guid?
	Public Property [BusinessType] As Guid?
	Public Property [CanDropShip] As Boolean?
	Public Property [ChamberOfCommerce] As String
	Public Property [City] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Classification] As String
	Public Property [Classification1] As Guid?
	Public Property [Classification2] As Guid?
	Public Property [Classification3] As Guid?
	Public Property [Classification4] As Guid?
	Public Property [Classification5] As Guid?
	Public Property [Classification6] As Guid?
	Public Property [Classification7] As Guid?
	Public Property [Classification8] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ClassificationDescription] As String
	Public Property [Code] As String
	Public Property [CodeAtSupplier] As String
	Public Property [CompanySize] As Guid?
	Public Property [ConsolidationScenario] As Byte?
	Public Property [ControlledDate] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Costcenter] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostcenterDescription] As String
	Public Property [CostPaid] As Byte
	Public Property [Country] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CountryName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	Public Property [CreditLinePurchase] As Double?
	Public Property [CreditLineSales] As Double?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Currency] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CustomerSince] As DateTime?
	Public Property [DiscountPurchase] As Double?
	Public Property [DiscountSales] As Double?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Document] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DunsNumber] As String
	Public Property [Email] As String
	Public Property [EndDate] As DateTime?
	Public Property [Fax] As String
	Public Property [GLAccountPurchase] As Guid?
	Public Property [GLAccountSales] As Guid?
	Public Property [GLAP] As Guid?
	Public Property [GLAR] As Guid?
	Public Property [ID] As Guid
	Public Property [IntraStatArea] As String
	Public Property [IntraStatDeliveryTerm] As String
	Public Property [IntraStatSystem] As String
	Public Property [IntraStatTransactionA] As String
	Public Property [IntraStatTransactionB] As String
	Public Property [IntraStatTransportMethod] As String
	Public Property [InvoiceAccount] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [InvoiceAccountCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [InvoiceAccountName] As String
	Public Property [InvoiceAttachmentType] As Int32?
	Public Property [InvoicingMethod] As Int32?
	Public Property [IsAccountant] As Byte
	Public Property [IsAgency] As Byte
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [IsBank] As Boolean?
	Public Property [IsCompetitor] As Byte
	Public Property [IsMailing] As Byte
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [IsMember] As Boolean?
	Public Property [IsPilot] As Boolean?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [IsPurchase] As Boolean?
	Public Property [IsReseller] As Boolean?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [IsSales] As Boolean?
	Public Property [IsSupplier] As Boolean?
	Public Property [Language] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [LanguageDescription] As String
	Public Property [Latitude] As Double?
	Public Property [LeadSource] As Guid?
	Public Property [LogoFileName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [LogoThumbnailUrl] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [LogoUrl] As String
	Public Property [Logo] As Byte()
	Public Property [Longitude] As Double?
	Public Property [MainContact] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	Public Property [Name] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Parent] As Guid?
	Public Property [PaymentConditionPurchase] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PaymentConditionPurchaseDescription] As String
	Public Property [PaymentConditionSales] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PaymentConditionSalesDescription] As String
	Public Property [Phone] As String
	Public Property [PhoneExtension] As String
	Public Property [Postcode] As String
	Public Property [PriceList] As Guid?
	Public Property [PurchaseCurrency] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PurchaseCurrencyDescription] As String
	Public Property [PurchaseLeadDays] As Int32?
	Public Property [PurchaseVATCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PurchaseVATCodeDescription] As String
	Public Property [Remarks] As String
	Public Property [RecepientOfCommissions] As Boolean?
	Public Property [Reseller] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ResellerCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ResellerName] As String
	Public Property [SalesCurrency] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SalesCurrencyDescription] As String
	Public Property [SalesVATCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SalesVATCodeDescription] As String
	Public Property [SearchCode] As String
	Public Property [SecurityLevel] As Int32?
	Public Property [SeparateInvPerProject] As Byte
	Public Property [SeparateInvPerSubscription] As Byte
	Public Property [ShippingLeadDays] As Int32?
	Public Property [ShippingMethod] As Guid?
	Public Property [StartDate] As DateTime?
	Public Property [State] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [StateName] As String
	Public Property [Status] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [StatusSince] As DateTime?
	Public Property [SalesTaxSchedule] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SalesTaxScheduleCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SalesTaxScheduleDescription] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Type] As String
	Public Property [VATLiability] As String
	Public Property [VATNumber] As String
	Public Property [Website] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class AccountClass
	Public Property [Code] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	Public Property [CreditManagementScenario] As Guid?
	Public Property [Description] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	Public Property [ID] As Guid
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class AccountClassification
	Public Property [AccountClassificationName] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountClassificationNameDescription] As String
	Public Property [Code] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	Public Property [Description] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32
	Public Property [ID] As Guid
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class AccountClassificationName
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	Public Property [Description] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32
	Public Property [ID] As Guid
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	Public Property [SequenceNumber] As Int32
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class Address
	Public Property [Account] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountIsSupplier] As Boolean?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountName] As String
	Public Property [AddressLine1] As String
	Public Property [AddressLine2] As String
	Public Property [AddressLine3] As String
	Public Property [City] As String
	Public Property [Contact] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ContactName] As String
	Public Property [Country] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CountryName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	Public Property [Fax] As String
	Public Property [FreeBoolField_01] As Boolean?
	Public Property [FreeBoolField_02] As Boolean?
	Public Property [FreeBoolField_03] As Boolean?
	Public Property [FreeBoolField_04] As Boolean?
	Public Property [FreeBoolField_05] As Boolean?
	Public Property [FreeDateField_01] As DateTime?
	Public Property [FreeDateField_02] As DateTime?
	Public Property [FreeDateField_03] As DateTime?
	Public Property [FreeDateField_04] As DateTime?
	Public Property [FreeDateField_05] As DateTime?
	Public Property [FreeNumberField_01] As Double?
	Public Property [FreeNumberField_02] As Double?
	Public Property [FreeNumberField_03] As Double?
	Public Property [FreeNumberField_04] As Double?
	Public Property [FreeNumberField_05] As Double?
	Public Property [FreeTextField_01] As String
	Public Property [FreeTextField_02] As String
	Public Property [FreeTextField_03] As String
	Public Property [FreeTextField_04] As String
	Public Property [FreeTextField_05] As String
	Public Property [ID] As Guid
	Public Property [Mailbox] As String
	Public Property [Main] As Boolean?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	Public Property [NicNumber] As String
	Public Property [Notes] As String
	Public Property [Phone] As String
	Public Property [PhoneExtension] As String
	Public Property [Postcode] As String
	Public Property [State] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [StateDescription] As String
	Public Property [Type] As Int16?
	Public Property [Warehouse] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [WarehouseCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [WarehouseDescription] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class AddressState
	Public Property [Country] As String
	Public Property [DisplayValue] As String
	Public Property [Latitude] As Double?
	Public Property [Longitude] As Double?
	Public Property [ID] As Guid
	Public Property [State] As String
	Public Property [Name] As String
End Class

<DataServiceKey("AccountId")>
Public Class AgingAmounts
	Public Property [AccountId] As Guid
	Public Property [AccountCode] As String
	Public Property [AccountName] As String
	Public Property [TotalAmount] As Double
	Public Property [AgeGroup1] As Int32
	Public Property [AgeGroup1Description] As String
	Public Property [AgeGroup1Amount] As Double
	Public Property [AgeGroup2] As Int32
	Public Property [AgeGroup2Description] As String
	Public Property [AgeGroup2Amount] As Double
	Public Property [AgeGroup3] As Int32
	Public Property [AgeGroup3Description] As String
	Public Property [AgeGroup3Amount] As Double
	Public Property [AgeGroup4] As Int32
	Public Property [AgeGroup4Description] As String
	Public Property [AgeGroup4Amount] As Double
	Public Property [CurrencyCode] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("AccountId")>
Public Class AgingAmountsPayable
	Public Property [AccountId] As Guid
	Public Property [AccountCode] As String
	Public Property [AccountName] As String
	Public Property [TotalAmount] As Double
	Public Property [AgeGroup1] As Int32
	Public Property [AgeGroup1Description] As String
	Public Property [AgeGroup1Amount] As Double
	Public Property [AgeGroup2] As Int32
	Public Property [AgeGroup2Description] As String
	Public Property [AgeGroup2Amount] As Double
	Public Property [AgeGroup3] As Int32
	Public Property [AgeGroup3Description] As String
	Public Property [AgeGroup3Amount] As Double
	Public Property [AgeGroup4] As Int32
	Public Property [AgeGroup4Description] As String
	Public Property [AgeGroup4Amount] As Double
	Public Property [CurrencyCode] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("AccountId")>
Public Class AgingAmountsReceivable
	Public Property [AccountId] As Guid
	Public Property [AccountCode] As String
	Public Property [AccountName] As String
	Public Property [TotalAmount] As Double
	Public Property [AgeGroup1] As Int32
	Public Property [AgeGroup1Description] As String
	Public Property [AgeGroup1Amount] As Double
	Public Property [AgeGroup2] As Int32
	Public Property [AgeGroup2Description] As String
	Public Property [AgeGroup2Amount] As Double
	Public Property [AgeGroup3] As Int32
	Public Property [AgeGroup3Description] As String
	Public Property [AgeGroup3Amount] As Double
	Public Property [AgeGroup4] As Int32
	Public Property [AgeGroup4Description] As String
	Public Property [AgeGroup4Amount] As Double
	Public Property [CurrencyCode] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("AgeGroup")>
Public Class AgingOverview
	Public Property [AgeGroup] As Int32
	Public Property [AgeGroupDescription] As String
	Public Property [AmountReceivable] As Double
	Public Property [AmountPayable] As Double
	Public Property [CurrencyCode] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class Asset
	Public Property [AlreadyDepreciated] As Byte
	Public Property [AssetFrom] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AssetFromDescription] As String
	Public Property [AssetGroup] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AssetGroupDescription] As String
	Public Property [CatalogueValue] As Double?
	Public Property [Code] As String
	Public Property [Costcenter] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostcenterDescription] As String
	Public Property [Costunit] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostunitDescription] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	Public Property [DeductionPercentage] As Double?
	Public Property [DepreciatedAmount] As Double?
	Public Property [DepreciatedPeriods] As Int32?
	Public Property [DepreciatedStartDate] As DateTime?
	Public Property [Description] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	Public Property [EndDate] As DateTime?
	Public Property [EngineEmission] As Int16?
	Public Property [EngineType] As Int16?
	Public Property [GLTransactionLine] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLTransactionLineDescription] As String
	Public Property [ID] As Guid
	Public Property [InvestmentAccount] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [InvestmentAccountCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [InvestmentAccountName] As String
	Public Property [InvestmentAmountDC] As Double?
	Public Property [InvestmentAmountFC] As Double?
	Public Property [InvestmentCurrency] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [InvestmentCurrencyDescription] As String
	Public Property [InvestmentDate] As DateTime?
	Public Property [InvestmentDeduction] As Int16?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	Public Property [Notes] As String
	Public Property [Parent] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ParentCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ParentDescription] As String
	Public Property [Picture] As Byte()
	Public Property [PictureFileName] As String
	Public Property [PrimaryMethod] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PrimaryMethodCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PrimaryMethodDescription] As String
	Public Property [ResidualValue] As Double?
	Public Property [StartDate] As DateTime?
	Public Property [Status] As Int16?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [TransactionEntryID] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [TransactionEntryNo] As Int32?
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class Bank
	Public Property [BankName] As String
	Public Property [BICCode] As String
	Public Property [Country] As String
	Public Property [Created] As DateTime?
	Public Property [Description] As String
	Public Property [Format] As String
	Public Property [HomePageAddress] As String
	Public Property [ID] As Guid
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	Public Property [Status] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class BankAccount
	Public Property [Account] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Bank] As Guid?
	Public Property [BankAccount] As String
	Public Property [BankAccountHolderName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [BankDescription] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [BankName] As String
	Public Property [BICCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	Public Property [Description] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Format] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [IBAN] As String
	Public Property [ID] As Guid
	Public Property [Main] As Boolean?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Type] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [TypeDescription] As String
End Class

<SupportedActionsSDK(True, True, False, False)>
<DataServiceKey("EntryID")>
Public Class BankEntry
	Public Property [BankStatementDocument] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [BankStatementDocumentNumber] As Int32?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [BankStatementDocumentSubject] As String
	Public Property [BankEntryLines] As IEnumerable(Of BankEntryLine)
	Public Property [ClosingBalanceFC] As Double?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	Public Property [Currency] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [EntryID] As Guid
	Public Property [EntryNumber] As Int32?
	Public Property [FinancialPeriod] As Int16?
	Public Property [FinancialYear] As Int16?
	Public Property [JournalCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [JournalDescription] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	Public Property [OpeningBalanceFC] As Double?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Status] As Int16?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [StatusDescription] As String
End Class

<SupportedActionsSDK(True, True, False, False)>
<DataServiceKey("ID")>
Public Class BankEntryLine
	Public Property [Account] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AmountDC] As Double?
	Public Property [AmountFC] As Double?
	Public Property [AmountVATFC] As Double?
	Public Property [Asset] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AssetCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AssetDescription] As String
	Public Property [CostCenter] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostCenterDescription] As String
	Public Property [CostUnit] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostUnitDescription] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	Public Property [Date] As DateTime?
	Public Property [Description] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	Public Property [Document] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DocumentNumber] As Int32?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DocumentSubject] As String
	Public Property [EntryID] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [EntryNumber] As Int32?
	Public Property [ExchangeRate] As Double?
	Public Property [GLAccount] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLAccountCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLAccountDescription] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ID] As Guid
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [LineNumber] As Int32?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	Public Property [Notes] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [OffsetID] As Guid?
	Public Property [OurRef] As Int32?
	Public Property [Project] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectDescription] As String
	Public Property [Quantity] As Double?
	Public Property [VATCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [VATCodeDescription] As String
	Public Property [VATPercentage] As Double?
	Public Property [VATType] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class Budget
	Public Property [AmountDC] As Double?
	Public Property [BudgetScenario] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [BudgetScenarioCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [BudgetScenarioDescription] As String
	Public Property [Costcenter] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostcenterDescription] As String
	Public Property [Costunit] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostunitDescription] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	Public Property [GLAccount] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLAccountCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLAccountDescription] As String
	Public Property [HID] As Int64?
	Public Property [ID] As Guid
	Public Property [Item] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemDescription] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	Public Property [ReportingPeriod] As Int16?
	Public Property [ReportingYear] As Int16?
End Class

<SupportedActionsSDK(True, True, False, False)>
<DataServiceKey("EntryID")>
Public Class CashEntry
	Public Property [CashEntryLines] As IEnumerable(Of CashEntryLine)
	Public Property [ClosingBalanceFC] As Double?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	Public Property [Currency] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [EntryID] As Guid
	Public Property [EntryNumber] As Int32?
	Public Property [FinancialPeriod] As Int16?
	Public Property [FinancialYear] As Int16?
	Public Property [JournalCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [JournalDescription] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	Public Property [OpeningBalanceFC] As Double?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Status] As Int16?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [StatusDescription] As String
End Class

<SupportedActionsSDK(True, True, False, False)>
<DataServiceKey("ID")>
Public Class CashEntryLine
	Public Property [Account] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AmountDC] As Double?
	Public Property [AmountFC] As Double?
	Public Property [AmountVATFC] As Double?
	Public Property [Asset] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AssetCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AssetDescription] As String
	Public Property [CostCenter] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostCenterDescription] As String
	Public Property [CostUnit] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostUnitDescription] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	Public Property [Date] As DateTime?
	Public Property [Description] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	Public Property [Document] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DocumentNumber] As Int32?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DocumentSubject] As String
	Public Property [EntryID] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [EntryNumber] As Int32?
	Public Property [ExchangeRate] As Double?
	Public Property [GLAccount] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLAccountCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLAccountDescription] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ID] As Guid
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [LineNumber] As Int32?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	Public Property [Notes] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [OffsetID] As Guid?
	Public Property [OurRef] As Int32?
	Public Property [Project] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectDescription] As String
	Public Property [Quantity] As Double?
	Public Property [VATCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [VATCodeDescription] As String
	Public Property [VATPercentage] As Double?
	Public Property [VATType] As String
End Class

<DataServiceKey("EntryID")>
Public Class CashflowEntryBase
	Public Property [ClosingBalanceFC] As Double?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	Public Property [Currency] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [EntryID] As Guid
	Public Property [EntryNumber] As Int32?
	Public Property [FinancialPeriod] As Int16?
	Public Property [FinancialYear] As Int16?
	Public Property [JournalCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [JournalDescription] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	Public Property [OpeningBalanceFC] As Double?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Status] As Int16?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [StatusDescription] As String
End Class

<DataServiceKey("ID")>
Public Class CashflowEntryLineBase
	Public Property [Account] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AmountDC] As Double?
	Public Property [AmountFC] As Double?
	Public Property [AmountVATFC] As Double?
	Public Property [Asset] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AssetCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AssetDescription] As String
	Public Property [CostCenter] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostCenterDescription] As String
	Public Property [CostUnit] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostUnitDescription] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	Public Property [Date] As DateTime?
	Public Property [Description] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	Public Property [Document] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DocumentNumber] As Int32?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DocumentSubject] As String
	Public Property [EntryID] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [EntryNumber] As Int32?
	Public Property [ExchangeRate] As Double?
	Public Property [GLAccount] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLAccountCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLAccountDescription] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ID] As Guid
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [LineNumber] As Int32?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	Public Property [Notes] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [OffsetID] As Guid?
	Public Property [OurRef] As Int32?
	Public Property [Project] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectDescription] As String
	Public Property [Quantity] As Double?
	Public Property [VATCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [VATCodeDescription] As String
	Public Property [VATPercentage] As Double?
	Public Property [VATType] As String
End Class

<DataServiceKey("Id")>
Public Class CenterTag
	Public Property [Id] As Guid
	Public Property [CenterTagGroup] As Int32
	Public Property [Description] As String
End Class

<DataServiceKey("Id")>
Public Class Certification
	Public Property [Id] As Int16
	Public Property [Description] As String
End Class

<DataServiceKey("Id")>
Public Class CertificationAwarded
	Public Property [Id] As Guid
	Public Property [Customer] As Guid
	Public Property [UserId] As Guid
	Public Property [Certification] As Int16
	Public Property [Comments] As String
	Public Property [IssueDate] As DateTime
	Public Property [ExpirationDate] As DateTime
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class Contact
	Public Property [ID] As Guid
	Public Property [Person] As Guid?
	Public Property [Account] As Guid?
	Public Property [AccountName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Code] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountMainContact] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountIsCustomer] As Boolean
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountIsSupplier] As Boolean?
	Public Property [StartDate] As DateTime?
	Public Property [EndDate] As DateTime?
	Public Property [BusinessPhone] As String
	Public Property [BusinessPhoneExtension] As String
	Public Property [BusinessMobile] As String
	Public Property [BusinessEmail] As String
	Public Property [BusinessFax] As String
	Public Property [IsMailingExcluded] As Boolean?
	Public Property [MarketingNotes] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [IsMainContact] As Boolean?
	Public Property [LastName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [FullName] As String
	Public Property [FirstName] As String
	Public Property [MiddleName] As String
	Public Property [BirthNamePrefix] As String
	Public Property [BirthName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PartnerNamePrefix] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PartnerName] As String
	Public Property [Initials] As String
	Public Property [Title] As String
	Public Property [Gender] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AddressStreet] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AddressStreetNumber] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AddressStreetNumberSuffix] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AddressLine2] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [City] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [State] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Postcode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Country] As String
	Public Property [Language] As String
	Public Property [Email] As String
	Public Property [HID] As Int32?
	Public Property [Picture] As Byte()
	Public Property [Phone] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PhoneExtension] As String
	Public Property [Mobile] As String
	Public Property [SocialSecurityNumber] As String
	Public Property [JobTitleDescription] As String
	Public Property [BirthDate] As DateTime?
	Public Property [BirthPlace] As String
	Public Property [Nationality] As String
	Public Property [Notes] As String
	Public Property [PictureName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PictureUrl] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PictureThumbnailUrl] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AllowMailing] As Int32?
End Class

<DataServiceKey("ID")>
Public Class ContactBase
	Public Property [ID] As Guid
	Public Property [Person] As Guid?
	Public Property [Account] As Guid?
	Public Property [AccountName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Code] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountMainContact] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountIsCustomer] As Boolean
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountIsSupplier] As Boolean?
	Public Property [StartDate] As DateTime?
	Public Property [EndDate] As DateTime?
	Public Property [BusinessPhone] As String
	Public Property [BusinessPhoneExtension] As String
	Public Property [BusinessMobile] As String
	Public Property [BusinessEmail] As String
	Public Property [BusinessFax] As String
	Public Property [IsMailingExcluded] As Boolean?
	Public Property [MarketingNotes] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [IsMainContact] As Boolean?
	Public Property [LastName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [FullName] As String
	Public Property [FirstName] As String
	Public Property [MiddleName] As String
	Public Property [BirthNamePrefix] As String
	Public Property [BirthName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PartnerNamePrefix] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PartnerName] As String
	Public Property [Initials] As String
	Public Property [Title] As String
	Public Property [Gender] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AddressStreet] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AddressStreetNumber] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AddressStreetNumberSuffix] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AddressLine2] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [City] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [State] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Postcode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Country] As String
	Public Property [Language] As String
	Public Property [Email] As String
	Public Property [HID] As Int32?
	Public Property [Picture] As Byte()
	Public Property [Phone] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PhoneExtension] As String
	Public Property [Mobile] As String
	Public Property [SocialSecurityNumber] As String
	Public Property [JobTitleDescription] As String
	Public Property [BirthDate] As DateTime?
	Public Property [BirthPlace] As String
	Public Property [Nationality] As String
	Public Property [Notes] As String
	Public Property [PictureName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PictureUrl] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PictureThumbnailUrl] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AllowMailing] As Int32?
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class Costcenter
	Public Property [Active] As Boolean?
	Public Property [Code] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	Public Property [Description] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	Public Property [ID] As Guid
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class CostTransaction
	Public Property [Account] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountName] As String
	Public Property [AmountFC] As Double?
	Public Property [Attachment] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	Public Property [Currency] As String
	Public Property [Date] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DivisionDescription] As String
	Public Property [Employee] As Guid?
	Public Property [EntryNumber] As Int32?
	Public Property [ErrorText] As String
	Public Property [Expense] As Guid?
	Public Property [ExpenseDescription] As String
	Public Property [HourStatus] As Int16?
	Public Property [ID] As Guid
	Public Property [Item] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemDescription] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemDivisable] As Boolean?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	Public Property [Notes] As String
	Public Property [PriceFC] As Double?
	Public Property [Project] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectAccount] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectAccountCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectAccountName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectDescription] As String
	Public Property [Quantity] As Double?
	Public Property [Subscription] As Guid?
	Public Property [SubscriptionAccount] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SubscriptionAccountCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SubscriptionAccountName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SubscriptionDescription] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SubscriptionNumber] As Int32?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Type] As Int16?
	Public Property [Amount] As Double?
	Public Property [Price] As Double?
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class Costunit
	Public Property [Code] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	Public Property [Description] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	Public Property [ID] As Guid
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("Code")>
Public Class Currency
	Public Property [AmountPrecision] As Double
	Public Property [Code] As String
	Public Property [Created] As DateTime?
	Public Property [Description] As String
	Public Property [Modified] As DateTime?
	Public Property [PricePrecision] As Double
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class DepreciationMethod
	Public Property [Amount] As Double?
	Public Property [Code] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	Public Property [DepreciationInterval] As String
	Public Property [Description] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	Public Property [ID] As Guid
	Public Property [MaxPercentage] As Double?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	Public Property [Percentage] As Double?
	Public Property [Percentage2] As Double?
	Public Property [Periods] As Int16?
	Public Property [Type] As Int32?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [TypeDescription] As String
	Public Property [Years] As Int16?
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class DirectDebitMandate
	Public Property [Account] As Guid?
	Public Property [BankAccount] As Guid?
	Public Property [CancellationDate] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	Public Property [Description] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	Public Property [FirstSend] As Byte?
	Public Property [ID] As Guid
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	Public Property [PaymentType] As Int16?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Reference] As String
	Public Property [SignatureDate] As DateTime?
	Public Property [Type] As Int16?
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("Code")>
Public Class Division
	Public Property [BlockingStatus] As Int32?
	Public Property [Code] As Int32
	Public Property [Country] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CountryDescription] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	Public Property [Currency] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CurrencyDescription] As String
	Public Property [Customer] As Guid?
	Public Property [Description] As String
	Public Property [HID] As Int64?
	Public Property [Main] As Boolean?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	Public Property [SiretNumber] As String
	Public Property [StartDate] As DateTime?
	Public Property [Status] As Int16?
	Public Property [TaxOfficeNumber] As String
	Public Property [TaxReferenceNumber] As String
	Public Property [VATNumber] As String
	Public Property [Website] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class Document
	Public Property [Account] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountName] As String
	Public Property [AmountFC] As Double?
	Public Property [Body] As String
	Public Property [Category] As Guid?
	Public Property [CategoryDescription] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	Public Property [CreatorFullName] As String
	Public Property [Currency] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32
	Public Property [DocumentDate] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DocumentViewUrl] As String
	Public Property [FinancialTransactionEntryID] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [HasEmptyBody] As Boolean
	Public Property [HID] As Int32?
	Public Property [ID] As Guid
	Public Property [Language] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	Public Property [ShopOrderNumber] As Int32?
	Public Property [Subject] As String
	Public Property [Type] As Int32?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [TypeDescription] As String
	Public Property [Opportunity] As Guid?
	Public Property [SalesInvoiceNumber] As Int32?
	Public Property [SalesOrderNumber] As Int32?
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class DocumentAttachment
	Public Property [ID] As Guid
	Public Property [Attachment] As Byte()
	Public Property [FileName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [FileSize] As Double
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Url] As String
	Public Property [Document] As Guid
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class DocumentCategory
	Public Property [Created] As DateTime?
	Public Property [Description] As String
	Public Property [ID] As Guid
	Public Property [Modified] As DateTime?
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class DocumentType
	Public Property [Created] As DateTime?
	Public Property [Description] As String
	Public Property [ID] As Int32
	Public Property [Modified] As DateTime?
	Public Property [TypeCategory] As Int32?
	Public Property [DocumentIsCreatable] As Boolean
	Public Property [DocumentIsUpdatable] As Boolean
	Public Property [DocumentIsDeletable] As Boolean
	Public Property [DocumentIsViewable] As Boolean
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class DocumentTypeCategory
	Public Property [Created] As DateTime?
	Public Property [Description] As String
	Public Property [ID] As Int32
	Public Property [Modified] As DateTime?
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class Employee
	Public Property [ActiveEmployment] As Byte?
	Public Property [AddressLine2] As String
	Public Property [AddressLine3] As String
	Public Property [AddressStreet] As String
	Public Property [AddressStreetNumber] As String
	Public Property [AddressStreetNumberSuffix] As String
	Public Property [BirthDate] As DateTime?
	Public Property [BirthName] As String
	Public Property [BirthNamePrefix] As String
	Public Property [BirthPlace] As String
	Public Property [BusinessEmail] As String
	Public Property [BusinessFax] As String
	Public Property [BusinessMobile] As String
	Public Property [BusinessPhone] As String
	Public Property [BusinessPhoneExtension] As String
	Public Property [CASONumber] As String
	Public Property [City] As String
	Public Property [Code] As String
	Public Property [Country] As String
	Public Property [Created] As DateTime?
	Public Property [Creator] As Guid?
	Public Property [CreatorFullName] As String
	Public Property [Customer] As Guid?
	Public Property [Division] As Int32?
	Public Property [Email] As String
	Public Property [EmployeeHID] As Int32?
	Public Property [EndDate] As DateTime?
	Public Property [FirstName] As String
	Public Property [FullName] As String
	Public Property [Gender] As String
	Public Property [HID] As Int32?
	Public Property [ID] As Guid
	Public Property [Initials] As String
	Public Property [Language] As String
	Public Property [LastName] As String
	Public Property [LocationDescription] As String
	Public Property [Manager] As Guid?
	Public Property [MaritalDate] As DateTime?
	Public Property [MaritalStatus] As Int16?
	Public Property [MiddleName] As String
	Public Property [Mobile] As String
	Public Property [Modified] As DateTime?
	Public Property [Modifier] As Guid?
	Public Property [ModifierFullName] As String
	Public Property [Municipality] As String
	Public Property [NameComposition] As Int16?
	Public Property [Nationality] As String
	Public Property [NickName] As String
	Public Property [Notes] As String
	Public Property [PartnerName] As String
	Public Property [PartnerNamePrefix] As String
	Public Property [Person] As Guid?
	Public Property [Phone] As String
	Public Property [PhoneExtension] As String
	Public Property [PictureFileName] As String
	Public Property [PictureUrl] As String
	Public Property [Postcode] As String
	Public Property [PrivateEmail] As String
	Public Property [SocialSecurityNumber] As String
	Public Property [State] As String
	Public Property [StartDate] As DateTime?
	Public Property [Title] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class ExchangeRate
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	Public Property [ID] As Guid
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	Public Property [Rate] As Double?
	Public Property [SourceCurrency] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SourceCurrencyDescription] As String
	Public Property [StartDate] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [TargetCurrency] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [TargetCurrencyDescription] As String
End Class

<DataServiceKey("ID")>
Public Class ExternalLink
	Public Property [ID] As Guid
	Public Property [Reference] As String
	Public Property [Description] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
End Class

<DataServiceKey("Id")>
Public Class Filter
	Public Property [Id] As String
	Public Property [Type] As Int32
	Public Property [Caption] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class FinancialPeriod
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	Public Property [EndDate] As DateTime?
	Public Property [FinPeriod] As Int16?
	Public Property [FinYear] As Int16?
	Public Property [ID] As Guid
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	Public Property [StartDate] As DateTime?
End Class

<SupportedActionsSDK(True, True, False, False)>
<DataServiceKey("EntryID")>
Public Class GeneralJournalEntry
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	Public Property [Currency] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	Public Property [EntryID] As Guid
	Public Property [EntryNumber] As Int32?
	Public Property [ExchangeRate] As Double?
	Public Property [FinancialPeriod] As Int16?
	Public Property [FinancialYear] As Int16?
	Public Property [GeneralJournalEntryLines] As IEnumerable(Of GeneralJournalEntryLine)
	Public Property [JournalCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [JournalDescription] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	Public Property [Reversal] As Boolean?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Status] As Int16?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [StatusDescription] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Type] As Int32?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [TypeDescription] As String
End Class

<SupportedActionsSDK(True, True, False, False)>
<DataServiceKey("ID")>
Public Class GeneralJournalEntryLine
	Public Property [Account] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AmountDC] As Double?
	Public Property [AmountFC] As Double?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AmountVATDC] As Double?
	Public Property [AmountVATFC] As Double?
	Public Property [Asset] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AssetCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AssetDescription] As String
	Public Property [CostCenter] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostCenterDescription] As String
	Public Property [CostUnit] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostUnitDescription] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	Public Property [Date] As DateTime?
	Public Property [Description] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	Public Property [Document] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DocumentNumber] As Int32?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DocumentSubject] As String
	Public Property [EntryID] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [EntryNumber] As Int32?
	Public Property [GLAccount] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLAccountCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLAccountDescription] As String
	Public Property [ID] As Guid
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [LineNumber] As Int32?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	Public Property [Notes] As String
	Public Property [OffsetID] As Guid?
	Public Property [OurRef] As Int32?
	Public Property [Project] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectDescription] As String
	Public Property [Quantity] As Double?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [VATBaseAmountDC] As Double?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [VATBaseAmountFC] As Double?
	Public Property [VATCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [VATCodeDescription] As String
	Public Property [VATPercentage] As Double?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [VATType] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class GLAccount
	Public Property [AssimilatedVATBox] As Int16?
	Public Property [BalanceSide] As String
	Public Property [BalanceType] As String
	Public Property [BelcotaxType] As Int32?
	Public Property [Code] As String
	Public Property [Compress] As Boolean?
	Public Property [Costcenter] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostcenterDescription] As String
	Public Property [Costunit] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostunitDescription] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	Public Property [Description] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32
	Public Property [ExcludeVATListing] As Byte
	Public Property [ExpenseNonDeductiblePercentage] As Double?
	Public Property [ID] As Guid
	Public Property [IsBlocked] As Boolean?
	Public Property [Matching] As Boolean?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	Public Property [PrivateGLAccount] As Guid?
	Public Property [PrivatePercentage] As Double?
	Public Property [ReportingCode] As String
	Public Property [RevalueCurrency] As Boolean?
	Public Property [SearchCode] As String
	Public Property [Type] As Int32?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [TypeDescription] As String
	Public Property [UseCostcenter] As Byte?
	Public Property [UseCostunit] As Byte?
	Public Property [VATCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [VATDescription] As String
	Public Property [VATGLAccountType] As String
	Public Property [VATNonDeductibleGLAccount] As Guid?
	Public Property [VATNonDeductiblePercentage] As Double?
	Public Property [VATSystem] As String
	Public Property [YearEndCostGLAccount] As Guid?
	Public Property [YearEndReflectionGLAccount] As Guid?
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class GLClassification
	Public Property [Abstract] As Boolean?
	Public Property [Balance] As String
	Public Property [Code] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	Public Property [Description] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	Public Property [ID] As Guid
	Public Property [IsTupleSubElement] As Boolean?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	Public Property [Name] As String
	Public Property [Nillable] As Boolean?
	Public Property [Parent] As Guid?
	Public Property [PeriodType] As String
	Public Property [SubstitutionGroup] As String
	Public Property [TaxonomyNamespace] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [TaxonomyNamespaceDescription] As String
	Public Property [Type] As Guid?
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class GLScheme
	Public Property [Code] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	Public Property [Description] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	Public Property [ID] As Guid
	Public Property [Main] As Byte
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	Public Property [TargetNamespace] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class GLTransactionType
	Public Property [ID] As Int32
	Public Property [Description] As String
	Public Property [DescriptionSuffix] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ItemId")>
Public Class HourCostType
	Public Property [ItemId] As Guid
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemDescription] As String
End Class

<DataServiceKey("ID")>
Public Class IntraStat
	Public Property [Area] As String
	Public Property [DeliveryTerm] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	Public Property [ID] As Guid
	Public Property [NetWeight] As Double?
	Public Property [Number] As String
	Public Property [TransportMethod] As String
	Public Property [Quantity] As Double?
	Public Property [Reference] As String
	Public Property [System] As String
	Public Property [TransactionA] As String
	Public Property [TransactionB] As String
	Public Property [Value] As Double?
End Class

<DataServiceKey("ID")>
Public Class Invoice
	Public Property [AccountCode] As String
	Public Property [AccountManagerName] As String
	Public Property [AccountName] As String
	Public Property [Blocked] As Boolean?
	Public Property [Classification] As String
	Public Property [EndTime] As DateTime?
	Public Property [FinancialPeriod] As Int16?
	Public Property [FinancialYear] As Int16?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLAccountCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLAccountDescription] As String
	Public Property [HeaderDescription] As String
	Public Property [ID] As Guid
	Public Property [InvoiceDate] As DateTime?
	Public Property [InvoiceLineAmount] As Double?
	Public Property [InvoiceLineNumber] As Int32?
	Public Property [InvoiceLineQuantity] As Double?
	Public Property [InvoiceLineUnitPrice] As Double?
	Public Property [InvoiceNumber] As Int32?
	Public Property [InvoiceType] As String
	Public Property [IsAccountant] As Int32?
	Public Property [IsPackage] As Boolean?
	Public Property [IsReseller] As Boolean?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemDescription] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemGroupCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemGroupDescription] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemUnitCode] As String
	Public Property [Journal] As String
	Public Property [PackageCode] As String
	Public Property [PaymentCondition] As String
	Public Property [ResellerClassificationCode] As String
	Public Property [ResellerCode] As String
	Public Property [ResellerName] As String
	Public Property [StartTime] As DateTime?
	Public Property [YourRef] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class Item
	Public Property [IsSerialNumberItem] As Boolean?
	Public Property [IsBatchNumberItem] As Byte
	Public Property [Class_01] As String
	Public Property [Class_02] As String
	Public Property [Class_03] As String
	Public Property [Class_04] As String
	Public Property [Class_05] As String
	Public Property [Code] As String
	Public Property [CopyRemarks] As Byte
	Public Property [CostPriceCurrency] As String
	Public Property [CostPriceNew] As Double?
	Public Property [CostPriceStandard] As Double?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	Public Property [Description] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	Public Property [EndDate] As DateTime?
	Public Property [ExtraDescription] As String
	Public Property [FreeBoolField_01] As Boolean?
	Public Property [FreeBoolField_02] As Boolean?
	Public Property [FreeBoolField_03] As Boolean?
	Public Property [FreeBoolField_04] As Boolean?
	Public Property [FreeBoolField_05] As Boolean?
	Public Property [FreeDateField_01] As DateTime?
	Public Property [FreeDateField_02] As DateTime?
	Public Property [FreeDateField_03] As DateTime?
	Public Property [FreeDateField_04] As DateTime?
	Public Property [FreeDateField_05] As DateTime?
	Public Property [FreeNumberField_01] As Double?
	Public Property [FreeNumberField_02] As Double?
	Public Property [FreeNumberField_03] As Double?
	Public Property [FreeNumberField_04] As Double?
	Public Property [FreeNumberField_05] As Double?
	Public Property [FreeNumberField_06] As Double?
	Public Property [FreeNumberField_07] As Double?
	Public Property [FreeNumberField_08] As Double?
	Public Property [FreeTextField_01] As String
	Public Property [FreeTextField_02] As String
	Public Property [FreeTextField_03] As String
	Public Property [FreeTextField_04] As String
	Public Property [FreeTextField_05] As String
	Public Property [FreeTextField_06] As String
	Public Property [FreeTextField_07] As String
	Public Property [FreeTextField_08] As String
	Public Property [FreeTextField_09] As String
	Public Property [FreeTextField_10] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLCostsCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLCostsDescription] As String
	Public Property [GLCosts] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLRevenueCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLRevenueDescription] As String
	Public Property [GLRevenue] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLStockCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLStockDescription] As String
	Public Property [GLStock] As Guid?
	Public Property [ID] As Guid
	Public Property [IsBatchItem] As Byte
	Public Property [IsFractionAllowedItem] As Boolean?
	Public Property [IsMakeItem] As Byte
	Public Property [IsNewContract] As Byte
	Public Property [IsOnDemandItem] As Byte
	Public Property [IsPackageItem] As Boolean?
	Public Property [IsPurchaseItem] As Boolean?
	Public Property [IsRegistrationCodeItem] As Byte
	Public Property [IsSalesItem] As Boolean?
	Public Property [IsSerialItem] As Boolean?
	Public Property [IsStockItem] As Boolean?
	Public Property [IsSubcontractedItem] As Boolean?
	Public Property [IsTime] As Byte
	Public Property [IsWebshopItem] As Byte
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemGroupCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemGroupDescription] As String
	Public Property [ItemGroup] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	Public Property [Notes] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SalesVatCodeDescription] As String
	Public Property [SalesVatCode] As String
	Public Property [SearchCode] As String
	Public Property [SecurityLevel] As Int32?
	Public Property [StartDate] As DateTime?
	Public Property [Unit] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [UnitDescription] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class ItemGroup
	Public Property [Code] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	Public Property [Description] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	Public Property [GLCosts] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLCostsCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLCostsDescription] As String
	Public Property [GLPurchaseAccount] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLPurchaseAccountCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLPurchaseAccountDescription] As String
	Public Property [GLPurchasePriceDifference] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLPurchasePriceDifferenceCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLPurchasePriceDifferenceDescr] As String
	Public Property [GLRevenue] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLRevenueCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLRevenueDescription] As String
	Public Property [GLStock] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLStockCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLStockDescription] As String
	Public Property [GLStockVariance] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLStockVarianceCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLStockVarianceDescription] As String
	Public Property [ID] As Guid
	Public Property [IsDefault] As Byte
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	Public Property [Notes] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ItemId")>
Public Class ItemVersion
	Public Property [BatchQuantity] As Double?
	Public Property [CalculatedCostPrice] As Double?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	Public Property [Description] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	Public Property [ID] As Guid
	Public Property [IsDefault] As Byte
	Public Property [Item] As Guid
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemDescription] As String
	Public Property [LeadTime] As Int32?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	Public Property [Notes] As String
	Public Property [Status] As Int16?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [StatusDescription] As String
	Public Property [Type] As Int16?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [TypeDescription] As String
	Public Property [VersionNumber] As Int32?
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class Journal
	Public Property [AllowVariableCurrency] As Boolean?
	Public Property [AllowVariableExchangeRate] As Boolean?
	Public Property [AllowVAT] As Boolean?
	Public Property [AutoSave] As Boolean?
	Public Property [BankAccountID] As Guid?
	Public Property [Code] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	Public Property [Currency] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CurrencyDescription] As String
	Public Property [Description] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	Public Property [GLAccount] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLAccountCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLAccountDescription] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLAccountType] As Int32?
	Public Property [ID] As Guid
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	Public Property [Type] As Int32?
	Public Property [PaymentInTransitAccount] As Guid?
	Public Property [Bank] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [BankName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [BankAccountCountry] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [BankAccountBICCode] As String
	Public Property [BankAccountIncludingMask] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [BankAccountDescription] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [BankAccountIBAN] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [BankAccountUseSEPA] As Boolean?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [BankAccountUseSepaDirectDebit] As Boolean?
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("Year,Period,Journal")>
Public Class JournalStatus
	Public Property [Year] As Int32
	Public Property [Period] As Int32
	Public Property [Journal] As String
	Public Property [JournalDescription] As String
	Public Property [JournalType] As Int32
	Public Property [JournalTypeDescription] As String
	Public Property [Status] As Int32
	Public Property [StatusDescription] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class Layout
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	Public Property [ID] As Guid
	Public Property [Subject] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	Public Property [Type] As Int16?
End Class

<DataServiceKey("Id")>
Public Class LocationContact
	Public Property [Id] As Guid
	Public Property [Name] As String
	Public Property [Email] As String
	Public Property [ContactPerson] As String
	Public Property [Phone] As String
	Public Property [Website] As String
	Public Property [Longitude] As Double?
	Public Property [Latitude] As Double?
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class Mailbox
	Public Property [Account] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	Public Property [Description] As String
	Public Property [ForDivision] As Int32?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ForDivisionDescription] As String
	Public Property [ID] As Guid
	Public Property [Mailbox] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	Public Property [Publish] As Byte
	Public Property [Type] As Int16?
	Public Property [ValidFrom] As DateTime?
	Public Property [ValidTo] As DateTime?
End Class

<SupportedActionsSDK(True, True, False, False)>
<DataServiceKey("ID")>
Public Class MailMessage
	Public Property [Bank] As Guid?
	Public Property [BankAccount] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	Public Property [ForDivision] As Int32?
	Public Property [ID] As Guid
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	Public Property [Operation] As Int16?
	Public Property [OriginalMessage] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [OriginalMessageSubject] As String
	Public Property [PartnerKey] As Guid?
	Public Property [Quantity] As Double?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [RecipientAccount] As Guid?
	Public Property [RecipientDeleted] As Byte
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [RecipientMailbox] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [RecipientMailboxDescription] As String
	Public Property [RecipientMailboxID] As Guid?
	Public Property [RecipientStatus] As Int16?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [RecipientStatusDescription] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SenderAccount] As Guid?
	Public Property [SenderDateSent] As DateTime?
	Public Property [SenderDeleted] As Byte
	Public Property [SenderIPAddress] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SenderMailbox] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SenderMailboxDescription] As String
	Public Property [SenderMailboxID] As Guid?
	Public Property [Subject] As String
	Public Property [SynchronizationCode] As String
	Public Property [Type] As Int32?
End Class

<SupportedActionsSDK(True, True, False, False)>
<DataServiceKey("ID")>
Public Class MailMessageAttachment
	Public Property [Attachment] As Byte()
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AttachmentFileExtension] As String
	Public Property [AttachmentFileName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [FileSize] As Int64
	Public Property [ID] As Guid
	Public Property [MailMessageID] As Guid
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [RecipientAccount] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SenderAccount] As Guid?
	Public Property [Type] As Int32
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [TypeDescription] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Url] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class ManufacturingTimeTransaction
	Public Property [ID] As Guid
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	Public Property [Employee] As Guid?
	Public Property [Date] As DateTime?
	Public Property [Status] As Int16?
	Public Property [Hours] As Double?
	Public Property [Quantity] As Double?
	Public Property [ShopOrder] As Guid?
	Public Property [RoutingStepPlan] As Guid?
	Public Property [WorkCenter] As Guid?
	Public Property [LaborHours] As Double?
	Public Property [PercentComplete] As Double?
	Public Property [Activity] As Int16?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	Public Property [Notes] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("Division,ReportingYear,GLAccount")>
Public Class OpeningBalanceAfterEntry
	Public Property [Amount] As Double?
	Public Property [BalanceSide] As String
	Public Property [Division] As Int32
	Public Property [GLAccount] As Guid
	Public Property [GLAccountCode] As String
	Public Property [GLAccountDescription] As String
	Public Property [ReportingYear] As Int32
End Class

<DataServiceKey("Division,ReportingYear,GLAccount")>
Public Class OpeningBalanceBase
	Public Property [Amount] As Double?
	Public Property [BalanceSide] As String
	Public Property [Division] As Int32
	Public Property [GLAccount] As Guid
	Public Property [GLAccountCode] As String
	Public Property [GLAccountDescription] As String
	Public Property [ReportingYear] As Int32
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("Division,ReportingYear,GLAccount")>
Public Class OpeningBalanceProcessed
	Public Property [Amount] As Double?
	Public Property [BalanceSide] As String
	Public Property [Division] As Int32
	Public Property [GLAccount] As Guid
	Public Property [GLAccountCode] As String
	Public Property [GLAccountDescription] As String
	Public Property [ReportingYear] As Int32
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class Operation
	Public Property [Code] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	Public Property [Description] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	Public Property [HasSuppliers] As Byte
	Public Property [ID] As Guid
	Public Property [Item] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemDescription] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	Public Property [Notes] As String
	Public Property [Searchcode] As String
	Public Property [Status] As Int16?
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class OperationResource
	Public Property [Account] As Guid?
	Public Property [AttendedPercentage] As Double?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	Public Property [Currency] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	Public Property [EfficiencyPercentage] As Double?
	Public Property [ID] As Guid
	Public Property [IsPrimary] As Byte?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	Public Property [Operation] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [OperationDescription] As String
	Public Property [PurchaseLeadDays] As Int32?
	Public Property [PurchaseUnit] As String
	Public Property [PurchaseVATCode] As String
	Public Property [Run] As Double?
	Public Property [RunMethod] As Int16?
	Public Property [Setup] As Double?
	Public Property [SetupUnit] As String
	Public Property [Type] As Int16?
	Public Property [Workcenter] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [WorkcenterDescription] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class Opportunity
	Public Property [ID] As Guid
	Public Property [Account] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountCode] As String
	Public Property [ActionDate] As DateTime?
	Public Property [NextAction] As String
	Public Property [AmountFC] As Double?
	Public Property [AmountDC] As Double?
	Public Property [CloseDate] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	Public Property [Currency] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	Public Property [Name] As String
	Public Property [Notes] As String
	Public Property [OpportunityStage] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [OpportunityStageDescription] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [OpportunityStatus] As Int32?
	Public Property [Probability] As Double?
	Public Property [Owner] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [OwnerFullName] As String
	Public Property [RateFC] As Double?
	Public Property [SalesType] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SalesTypeDescription] As String
	Public Property [ReasonCode] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ReasonCodeDescription] As String
	Public Property [Project] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectDescription] As String
	Public Property [Campaign] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CampaignDescription] As String
	Public Property [LeadSource] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [LeadSourceDescription] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class OpportunityContact
	Public Property [Opportunity] As Guid?
	Public Property [Contact] As Guid?
	Public Property [ID] As Guid
	Public Property [Person] As Guid?
	Public Property [Account] As Guid?
	Public Property [AccountName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Code] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountMainContact] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountIsCustomer] As Boolean
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountIsSupplier] As Boolean?
	Public Property [StartDate] As DateTime?
	Public Property [EndDate] As DateTime?
	Public Property [BusinessPhone] As String
	Public Property [BusinessPhoneExtension] As String
	Public Property [BusinessMobile] As String
	Public Property [BusinessEmail] As String
	Public Property [BusinessFax] As String
	Public Property [IsMailingExcluded] As Boolean?
	Public Property [MarketingNotes] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [IsMainContact] As Boolean?
	Public Property [LastName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [FullName] As String
	Public Property [FirstName] As String
	Public Property [MiddleName] As String
	Public Property [BirthNamePrefix] As String
	Public Property [BirthName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PartnerNamePrefix] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PartnerName] As String
	Public Property [Initials] As String
	Public Property [Title] As String
	Public Property [Gender] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AddressStreet] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AddressStreetNumber] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AddressStreetNumberSuffix] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AddressLine2] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [City] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [State] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Postcode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Country] As String
	Public Property [Language] As String
	Public Property [Email] As String
	Public Property [HID] As Int32?
	Public Property [Picture] As Byte()
	Public Property [Phone] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PhoneExtension] As String
	Public Property [Mobile] As String
	Public Property [SocialSecurityNumber] As String
	Public Property [JobTitleDescription] As String
	Public Property [BirthDate] As DateTime?
	Public Property [BirthPlace] As String
	Public Property [Nationality] As String
	Public Property [Notes] As String
	Public Property [PictureName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PictureUrl] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PictureThumbnailUrl] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AllowMailing] As Int32?
End Class

<DataServiceKey("ID")>
Public Class OpportunityStage
	Public Property [ID] As Guid
	Public Property [Active] As Byte?
	Public Property [Code] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	Public Property [Description] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	Public Property [OpportunityStatus] As Int32?
	Public Property [Probability] As Double
	Public Property [SortOrder] As Int32
End Class

<DataServiceKey("HID")>
Public Class OutstandingInvoice
	Public Property [HID] As Int64
	Public Property [Id] As Guid
	Public Property [InvoiceNumber] As Int32
	Public Property [InvoiceDate] As DateTime
	Public Property [EntryNumber] As Int32
	Public Property [Description] As String
	Public Property [DueDate] As DateTime
	Public Property [Amount] As Double
	Public Property [CurrencyCode] As String
	Public Property [AccountId] As Guid
	Public Property [AccountCode] As String
	Public Property [AccountName] As String
	Public Property [JournalCode] As String
	Public Property [JournalDescription] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("CurrencyCode")>
Public Class OutstandingInvoiceOverview
	Public Property [CurrencyCode] As String
	Public Property [OutstandingReceivableInvoiceCount] As Double
	Public Property [OutstandingReceivableInvoiceAmount] As Double
	Public Property [OverdueReceivableInvoiceCount] As Double
	Public Property [OverdueReceivableInvoiceAmount] As Double
	Public Property [OutstandingPayableInvoiceCount] As Double
	Public Property [OutstandingPayableInvoiceAmount] As Double
	Public Property [OverduePayableInvoiceCount] As Double
	Public Property [OverduePayableInvoiceAmount] As Double
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("HID")>
Public Class Payable
	Public Property [HID] As Int64
	Public Property [Id] As Guid
	Public Property [InvoiceNumber] As Int32
	Public Property [InvoiceDate] As DateTime
	Public Property [EntryNumber] As Int32
	Public Property [Description] As String
	Public Property [DueDate] As DateTime
	Public Property [Amount] As Double
	Public Property [CurrencyCode] As String
	Public Property [AccountId] As Guid
	Public Property [AccountCode] As String
	Public Property [AccountName] As String
	Public Property [JournalCode] As String
	Public Property [JournalDescription] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class PaymentCondition
	Public Property [Code] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	Public Property [CreditManagementScenario] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreditManagementScenarioCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreditManagementScenarioDescription] As String
	Public Property [Description] As String
	Public Property [DiscountCalculation] As String
	Public Property [DiscountPaymentDays] As Int32?
	Public Property [DiscountPercentage] As Double?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	Public Property [ID] As Guid
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	Public Property [PaymentDays] As Int32?
	Public Property [PaymentDiscountType] As String
	Public Property [PaymentEndOfMonths] As Int32?
	Public Property [PaymentMethod] As String
	Public Property [Percentage] As Double?
	Public Property [VATCalculation] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("Year,Period")>
Public Class PeriodRevenue
	Public Property [Year] As Int32
	Public Property [Period] As Int32
	Public Property [Amount] As Double
End Class

<DataServiceKey("ID")>
Public Class Picture
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	Public Property [ID] As Guid
	Public Property [Picture] As Byte()
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	Public Property [FileName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class PriceList
	Public Property [Code] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	Public Property [Currency] As String
	Public Property [Description] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DivisionDescription] As String
	Public Property [Entity] As Int16?
	Public Property [ID] As Guid
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	Public Property [Notes] As String
End Class

<SupportedActionsSDK(True, False, False, False)>
<DataServiceKey("InvoiceID")>
Public Class PrintedSalesInvoice
	Public Property [InvoiceID] As Guid
	Public Property [Division] As Int32?
	Public Property [ExtraText] As String
	Public Property [InvoiceDate] As DateTime?
	Public Property [ReportingPeriod] As Int32?
	Public Property [ReportingYear] As Int32?
	Public Property [Document] As Guid?
	Public Property [DocumentCreationError] As String
	Public Property [DocumentCreationSuccess] As String
	Public Property [DocumentLayout] As Guid?
	Public Property [EmailCreationError] As String
	Public Property [EmailCreationSuccess] As String
	Public Property [EmailLayout] As Guid?
	Public Property [PostboxSender] As Guid?
	Public Property [PostboxMessageCreationError] As String
	Public Property [PostboxMessageCreationSuccess] As String
	Public Property [SendEmailToCustomer] As Boolean?
	Public Property [SendInvoiceToCustomerPostbox] As Boolean?
	Public Property [SendOutputBasedOnAccount] As Boolean?
End Class

<SupportedActionsSDK(True, False, False, False)>
<DataServiceKey("OrderId")>
Public Class PrintedSalesOrder
	Public Property [OrderId] As Guid
	Public Property [Division] As Int32?
	Public Property [ExtraText] As String
	Public Property [Document] As Guid?
	Public Property [DocumentCreationError] As String
	Public Property [DocumentCreationSuccess] As String
	Public Property [DocumentLayout] As Guid?
	Public Property [EmailCreationError] As String
	Public Property [EmailCreationSuccess] As String
	Public Property [EmailLayout] As Guid?
	Public Property [SendEmailToCustomer] As Boolean?
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class ProductionArea
	Public Property [Code] As String
	Public Property [Costcenter] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostcenterDescription] As String
	Public Property [Costunit] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostunitDescription] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	Public Property [Description] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	Public Property [ID] As Guid
	Public Property [IsDefault] As Byte
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	Public Property [Notes] As String
End Class

<DataServiceKey("Id")>
Public Class Profile
	Public Property [Id] As Guid
	Public Property [Name] As String
	Public Property [ProfileText] As String
	Public Property [LogoName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [LogoUrl] As String
	Public Property [Customer] As Guid
	Public Property [Locations] As IEnumerable(Of ProfileLocation)
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [LocationsCount] As Int32
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [LocationName] As String
	Public Property [Tags] As IEnumerable(Of CenterTag)
	Public Property [Location] As LocationContact
	Public Property [Certifications] As IEnumerable(Of Certification)
	Public Property [RowId] As Int64?
	Public Property [Distance] As Double?
	Public Property [IsCertified] As Boolean
End Class

<DataServiceKey("Id")>
Public Class ProfileLocation
	Public Property [Id] As Guid
	Public Property [ProfileId] As Guid
	Public Property [Name] As String
	Public Property [AddressLine1] As String
	Public Property [AddressLine2] As String
	Public Property [AddressLine3] As String
	Public Property [Postcode] As String
	Public Property [City] As String
	Public Property [State] As String
	Public Property [County] As String
	Public Property [Country] As String
	Public Property [Phone] As String
	Public Property [Email] As String
	Public Property [Website] As String
	Public Property [PictureUrl] As String
	Public Property [PictureName] As String
	Public Property [Longitude] As Double?
	Public Property [Latitude] As Double?
	Public Property [ContactPerson] As String
	Public Property [Main] As Byte
	Public Property [Distance] As Double?
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("CurrentYear")>
Public Class ProfitLossOverview
	Public Property [CurrentYear] As Int32
	Public Property [PreviousYear] As Int32
	Public Property [CurrentPeriod] As Int32
	Public Property [PreviousYearPeriod] As Int32
	Public Property [CurrencyCode] As String
	Public Property [ResultCurrentYear] As Double
	Public Property [ResultPreviousYear] As Double
	Public Property [RevenueCurrentYear] As Double
	Public Property [RevenuePreviousYear] As Double
	Public Property [CostsCurrentYear] As Double
	Public Property [CostsPreviousYear] As Double
	Public Property [ResultCurrentPeriod] As Double
	Public Property [ResultPreviousYearPeriod] As Double
	Public Property [RevenueCurrentPeriod] As Double
	Public Property [RevenuePreviousYearPeriod] As Double
	Public Property [CostsCurrentPeriod] As Double
	Public Property [CostsPreviousYearPeriod] As Double
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class Project
	Public Property [Account] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountName] As String
	Public Property [AccountContact] As Guid?
	Public Property [Classification] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ClassificationDescription] As String
	Public Property [Code] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostsAmountFC] As Double?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	Public Property [CustomerPOnumber] As String
	Public Property [Description] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DivisionName] As String
	Public Property [EndDate] As DateTime?
	Public Property [FixedPriceItem] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [FixedPriceItemDescription] As String
	Public Property [ID] As Guid
	Public Property [Manager] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ManagerFullname] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	Public Property [Notes] As String
	Public Property [SalesTimeQuantity] As Double?
	Public Property [StartDate] As DateTime?
	Public Property [TimeQuantityToAlert] As Double?
	Public Property [Type] As Int32?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [TypeDescription] As String
	Public Property [BudgetedAmount] As Double?
	Public Property [PrepaidType] As Int16?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PrepaidTypeDescription] As String
	Public Property [PrepaidItem] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PrepaidItemDescription] As String
	Public Property [MarkupPercentage] As Double?
	Public Property [BudgetedCosts] As Double?
	Public Property [BudgetedRevenue] As Double?
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("EntryID")>
Public Class PurchaseEntry
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AmountDC] As Double?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AmountFC] As Double?
	Public Property [BatchNumber] As Int32?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	Public Property [Currency] As String
	Public Property [Supplier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SupplierName] As String
	Public Property [Description] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	Public Property [Document] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DocumentNumber] As Int32?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DocumentSubject] As String
	Public Property [DueDate] As DateTime?
	Public Property [EntryDate] As DateTime?
	Public Property [EntryID] As Guid
	Public Property [EntryNumber] As Int32?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ExternalLinkDescription] As String
	Public Property [ExternalLinkReference] As String
	Public Property [InvoiceNumber] As Int32?
	Public Property [Journal] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [JournalDescription] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	Public Property [OrderNumber] As Int32?
	Public Property [PaymentCondition] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PaymentConditionDescription] As String
	Public Property [ProcessNumber] As Int32?
	Public Property [Rate] As Double?
	Public Property [ReportingYear] As Int16?
	Public Property [ReportingPeriod] As Int16?
	Public Property [Reversal] As Boolean?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Status] As Int16?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [StatusDescription] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Type] As Int32?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [TypeDescription] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [VATAmountDC] As Double?
	Public Property [VATAmountFC] As Double?
	Public Property [YourRef] As String
	Public Property [PurchaseEntryLines] As IEnumerable(Of PurchaseEntryLine)
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class PurchaseEntryLine
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AmountDC] As Double?
	Public Property [AmountFC] As Double?
	Public Property [Asset] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AssetDescription] As String
	Public Property [CostCenter] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostCenterDescription] As String
	Public Property [CostUnit] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostUnitDescription] As String
	Public Property [Description] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	Public Property [GLAccount] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLAccountCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLAccountDescription] As String
	Public Property [ID] As Guid
	Public Property [EntryID] As Guid
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [LineNumber] As Int32?
	Public Property [Notes] As String
	Public Property [Project] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectDescription] As String
	Public Property [Quantity] As Double?
	Public Property [SerialNumber] As String
	Public Property [Subscription] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SubscriptionDescription] As String
	Public Property [TrackingNumber] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [TrackingNumberDescription] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Type] As Int32?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [VATAmountDC] As Double?
	Public Property [VATAmountFC] As Double?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [VATBaseAmountDC] As Double?
	Public Property [VATBaseAmountFC] As Double?
	Public Property [VATCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [VATCodeDescription] As String
	Public Property [VATPercentage] As Double?
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("HID")>
Public Class Receivable
	Public Property [HID] As Int64
	Public Property [Id] As Guid
	Public Property [InvoiceNumber] As Int32
	Public Property [InvoiceDate] As DateTime
	Public Property [EntryNumber] As Int32
	Public Property [Description] As String
	Public Property [DueDate] As DateTime
	Public Property [Amount] As Double
	Public Property [CurrencyCode] As String
	Public Property [AccountId] As Guid
	Public Property [AccountCode] As String
	Public Property [AccountName] As String
	Public Property [JournalCode] As String
	Public Property [JournalDescription] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("Id")>
Public Class RecentCosts
	Public Property [Id] As Int32
	Public Property [Date] As DateTime
	Public Property [WeekNumber] As Int32
	Public Property [AccountId] As Guid?
	Public Property [AccountCode] As String
	Public Property [AccountName] As String
	Public Property [ProjectId] As Guid?
	Public Property [ProjectCode] As String
	Public Property [ProjectDescription] As String
	Public Property [ItemId] As Guid?
	Public Property [ItemCode] As String
	Public Property [ItemDescription] As String
	Public Property [QuantityDraft] As Double
	Public Property [QuantitySubmitted] As Double
	Public Property [QuantityApproved] As Double
	Public Property [QuantityRejected] As Double
	Public Property [AmountDraft] As Double
	Public Property [AmountSubmitted] As Double
	Public Property [AmountApproved] As Double
	Public Property [AmountRejected] As Double
	Public Property [CurrencyCode] As String
	Public Property [EntryId] As Guid?
	Public Property [Notes] As String
	Public Property [Expense] As Guid?
	Public Property [ExpenseDescription] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("Id")>
Public Class RecentHours
	Public Property [Id] As Int32
	Public Property [Date] As DateTime
	Public Property [WeekNumber] As Int32
	Public Property [AccountId] As Guid?
	Public Property [AccountCode] As String
	Public Property [AccountName] As String
	Public Property [ProjectId] As Guid?
	Public Property [ProjectCode] As String
	Public Property [ProjectDescription] As String
	Public Property [ItemId] As Guid?
	Public Property [ItemCode] As String
	Public Property [ItemDescription] As String
	Public Property [HoursDraft] As Double
	Public Property [HoursSubmitted] As Double
	Public Property [HoursApproved] As Double
	Public Property [HoursRejected] As Double
	Public Property [HoursDraftBillable] As Double
	Public Property [HoursSubmittedBillable] As Double
	Public Property [HoursApprovedBillable] As Double
	Public Property [HoursRejectedBillable] As Double
	Public Property [EntryId] As Guid?
	Public Property [Notes] As String
	Public Property [Activity] As Guid?
	Public Property [ActivityDescription] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class ReportingBalance
	Public Property [Amount] As Double?
	Public Property [AmountCredit] As Double?
	Public Property [AmountDebit] As Double?
	Public Property [BalanceType] As String
	Public Property [CostCenterCode] As String
	Public Property [CostCenterDescription] As String
	Public Property [CostUnitCode] As String
	Public Property [CostUnitDescription] As String
	Public Property [Count] As Int32?
	Public Property [Division] As Int32?
	Public Property [GLAccount] As Guid?
	Public Property [GLAccountCode] As String
	Public Property [GLAccountDescription] As String
	Public Property [ID] As Int64
	Public Property [ReportingPeriod] As Int32?
	Public Property [ReportingYear] As Int32?
	Public Property [Type] As Int32?
	Public Property [Status] As Int32?
End Class

<DataServiceKey("ID")>
Public Class Request
	Public Property [Account] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountCountry] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountStatus] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountType] As String
	Public Property [Amount] As Double?
	Public Property [AmountActual] As Double?
	Public Property [AmountFC] As Double?
	Public Property [AmountFCActual] As Double?
	Public Property [Approved] As DateTime?
	Public Property [Approver] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ApproverFullName] As String
	Public Property [Buildup] As Boolean?
	Public Property [Campaign] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CampaignDescription] As String
	Public Property [Contact] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ContactFullName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ContactHID] As Int32?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	Public Property [Currency] As String
	Public Property [CurrencyActual] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CurrencyDescription] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CurrencyDescriptionActual] As String
	Public Property [Days] As Double?
	Public Property [DaysActual] As Double?
	Public Property [Description] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	Public Property [Document] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DocumentCreated] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DocumentCreatorFullName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DocumentHID] As Int32?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DocumentSubject] As String
	Public Property [Employee] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [EmployeeFullName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [EmployeeHID] As Int32?
	Public Property [EndDate] As DateTime?
	Public Property [EndDateActual] As DateTime?
	Public Property [ErrorLogID] As Int32?
	Public Property [FinancialEntry] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [FinancialEntryDate] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [FinancialEntryDescription] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [FinancialEntryNumber] As Int32?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [FinancialEntryTypeDescription] As String
	Public Property [FreeBoolField_01] As Boolean?
	Public Property [FreeBoolField_02] As Boolean?
	Public Property [FreeBoolField_03] As Boolean?
	Public Property [FreeBoolField_04] As Boolean?
	Public Property [FreeBoolField_05] As Boolean?
	Public Property [FreeDateField_01] As DateTime?
	Public Property [FreeDateField_02] As DateTime?
	Public Property [FreeDateField_03] As DateTime?
	Public Property [FreeDateField_04] As DateTime?
	Public Property [FreeDateField_05] As DateTime?
	Public Property [FreeGuidField_01] As Guid?
	Public Property [FreeGuidField_02] As Guid?
	Public Property [FreeGuidField_03] As Guid?
	Public Property [FreeGuidField_04] As Guid?
	Public Property [FreeGuidField_05] As Guid?
	Public Property [FreeGuidField_06] As Guid?
	Public Property [FreeGuidField_07] As Guid?
	Public Property [FreeGuidField_08] As Guid?
	Public Property [FreeGuidField_09] As Guid?
	Public Property [FreeGuidField_10] As Guid?
	Public Property [FreeIntField_01] As Int32?
	Public Property [FreeIntField_02] As Int32?
	Public Property [FreeIntField_03] As Int32?
	Public Property [FreeIntField_04] As Int32?
	Public Property [FreeIntField_05] As Int32?
	Public Property [FreeNumberField_01] As Double?
	Public Property [FreeNumberField_02] As Double?
	Public Property [FreeNumberField_03] As Double?
	Public Property [FreeNumberField_04] As Double?
	Public Property [FreeNumberField_05] As Double?
	Public Property [FreeTextField_01] As String
	Public Property [FreeTextField_02] As String
	Public Property [FreeTextField_03] As String
	Public Property [FreeTextField_04] As String
	Public Property [FreeTextField_05] As String
	Public Property [FreeTextField_06] As String
	Public Property [FreeTextField_07] As String
	Public Property [FreeTextField_08] As String
	Public Property [FreeTextField_09] As String
	Public Property [FreeTextField_10] As String
	Public Property [FreeTextField_11] As String
	Public Property [FreeTextField_12] As String
	Public Property [FreeTextField_13] As String
	Public Property [FreeTextField_14] As String
	Public Property [FreeTextField_15] As String
	Public Property [HelpFile] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [HelpFileDescription] As String
	Public Property [HelpItem] As Guid?
	Public Property [HID] As Int32?
	Public Property [Hours] As Double?
	Public Property [HoursActual] As Double?
	Public Property [ID] As Guid
	Public Property [InWorkflow] As Boolean?
	Public Property [IsRead] As Boolean?
	Public Property [Item_1] As Guid?
	Public Property [Item_2] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemCode_1] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemCode_2] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemDescription_1] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemDescription_2] As String
	Public Property [ItemGroup_1] As Guid?
	Public Property [ItemGroup_2] As Guid?
	Public Property [ItemNumberID_1] As Guid?
	Public Property [ItemNumberID_2] As Guid?
	Public Property [Lead] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [LeadName] As String
	Public Property [Location] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	Public Property [MultipleEntryCols] As String
	Public Property [MultipleEntryID] As Guid?
	Public Property [Opportunity] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [OpportunityDescription] As String
	Public Property [PayrollComponent] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PayrollComponentDescription] As String
	Public Property [PayrollPeriod] As Int32?
	Public Property [PayrollYear] As Int32?
	Public Property [Person] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PersonFullName] As String
	Public Property [Priority] As Int32?
	Public Property [Processed] As DateTime?
	Public Property [Processor] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProcessorFullName] As String
	Public Property [Project] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectDescription] As String
	Public Property [Quantity_1] As Double?
	Public Property [Quantity_2] As Double?
	Public Property [QuantityActual_1] As Double?
	Public Property [QuantityActual_2] As Double?
	Public Property [Realized] As DateTime?
	Public Property [Realizer] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [RealizerFullName] As String
	Public Property [Reminder] As Int16?
	Public Property [RequestComments] As String
	Public Property [ResubmitStatus] As Int16?
	Public Property [SecurityLevel] As Int32?
	Public Property [StartDate] As DateTime?
	Public Property [StartDateActual] As DateTime?
	Public Property [Status] As Int16?
	Public Property [StatusChanged] As DateTime?
	Public Property [TaskSubType] As Int32
	Public Property [Type] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [TypeHID] As Int32?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [TypeDescription] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [UserFullName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [UserHID] As Int32?
	Public Property [UserID] As Guid?
	Public Property [WorkflowComments] As String
	Public Property [XBRLDocument] As Guid?
	Public Property [YourRef] As String
End Class

<DataServiceKey("ClientId")>
Public Class RevokedOAuthPermission
	Public Property [ClientId] As Guid
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("EntryID")>
Public Class SalesEntry
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AmountDC] As Double?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AmountFC] As Double?
	Public Property [BatchNumber] As Int32?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	Public Property [Currency] As String
	Public Property [Customer] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CustomerName] As String
	Public Property [Description] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	Public Property [Document] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DocumentNumber] As Int32?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DocumentSubject] As String
	Public Property [DueDate] As DateTime?
	Public Property [EntryDate] As DateTime?
	Public Property [EntryID] As Guid
	Public Property [EntryNumber] As Int32?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ExternalLinkDescription] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ExternalLinkReference] As String
	Public Property [InvoiceNumber] As Int32?
	Public Property [Journal] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [JournalDescription] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	Public Property [OrderNumber] As Int32?
	Public Property [PaymentCondition] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PaymentConditionDescription] As String
	Public Property [PaymentReference] As String
	Public Property [ProcessNumber] As Int32?
	Public Property [Rate] As Double?
	Public Property [ReportingYear] As Int16?
	Public Property [ReportingPeriod] As Int16?
	Public Property [Reversal] As Boolean?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Status] As Int16?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [StatusDescription] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Type] As Int32?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [TypeDescription] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [VATAmountDC] As Double?
	Public Property [VATAmountFC] As Double?
	Public Property [YourRef] As String
	Public Property [SalesEntryLines] As IEnumerable(Of SalesEntryLine)
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class SalesEntryLine
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AmountDC] As Double?
	Public Property [AmountFC] As Double?
	Public Property [Asset] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AssetDescription] As String
	Public Property [CostCenter] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostCenterDescription] As String
	Public Property [CostUnit] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostUnitDescription] As String
	Public Property [Description] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	Public Property [GLAccount] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLAccountCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLAccountDescription] As String
	Public Property [ID] As Guid
	Public Property [EntryID] As Guid
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [LineNumber] As Int32?
	Public Property [Notes] As String
	Public Property [Project] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectDescription] As String
	Public Property [Quantity] As Double?
	Public Property [SerialNumber] As String
	Public Property [Subscription] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SubscriptionDescription] As String
	Public Property [TrackingNumber] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [TrackingNumberDescription] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Type] As Int32?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [VATAmountDC] As Double?
	Public Property [VATAmountFC] As Double?
	Public Property [VATBaseAmountDC] As Double?
	Public Property [VATBaseAmountFC] As Double?
	Public Property [VATCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [VATCodeDescription] As String
	Public Property [VATPercentage] As Double?
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("InvoiceID")>
Public Class SalesInvoice
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AmountFC] As Double?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AmountDC] As Double?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	Public Property [Currency] As String
	Public Property [Description] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	Public Property [Document] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DocumentNumber] As Int32?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DocumentSubject] As String
	Public Property [DueDate] As DateTime?
	Public Property [InvoiceDate] As DateTime?
	Public Property [InvoiceID] As Guid
	Public Property [InvoiceTo] As Guid?
	Public Property [InvoiceToContactPerson] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [InvoiceToContactPersonFullName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [InvoiceToName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [InvoiceNumber] As Int32?
	Public Property [Journal] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [JournalDescription] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	Public Property [OrderDate] As DateTime?
	Public Property [OrderedBy] As Guid?
	Public Property [OrderedByContactPerson] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [OrderedByContactPersonFullName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [OrderedByName] As String
	Public Property [OrderNumber] As Int32?
	Public Property [PaymentCondition] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PaymentConditionDescription] As String
	Public Property [PaymentReference] As String
	Public Property [Remarks] As String
	Public Property [Salesperson] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SalespersonFullName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Status] As Int16?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [StatusDescription] As String
	Public Property [TaxSchedule] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [TaxScheduleCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [TaxScheduleDescription] As String
	Public Property [Type] As Int32?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [TypeDescription] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [VATAmountFC] As Double?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [VATAmountDC] As Double?
	Public Property [YourRef] As String
	Public Property [SalesInvoiceLines] As IEnumerable(Of SalesInvoiceLine)
	Public Property [StarterSalesInvoiceStatus] As Int16?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [StarterSalesInvoiceStatusDescription] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class SalesInvoiceLine
	Public Property [AmountFC] As Double?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AmountDC] As Double?
	Public Property [CostCenter] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostCenterDescription] As String
	Public Property [CostUnit] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostUnitDescription] As String
	Public Property [Description] As String
	Public Property [Discount] As Double?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	Public Property [Employee] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [EmployeeFullName] As String
	Public Property [EndTime] As DateTime?
	Public Property [GLAccount] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLAccountDescription] As String
	Public Property [ID] As Guid
	Public Property [InvoiceID] As Guid
	Public Property [Item] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemDescription] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemCode] As String
	Public Property [LineNumber] As Int32?
	Public Property [NetPrice] As Double?
	Public Property [Notes] As String
	Public Property [Pricelist] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PricelistDescription] As String
	Public Property [Project] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectDescription] As String
	Public Property [Quantity] As Double?
	Public Property [StartTime] As DateTime?
	Public Property [Subscription] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SubscriptionDescription] As String
	Public Property [UnitCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [UnitDescription] As String
	Public Property [UnitPrice] As Double?
	Public Property [TaxSchedule] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [TaxScheduleCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [TaxScheduleDescription] As String
	Public Property [VATAmountFC] As Double?
	Public Property [VATAmountDC] As Double?
	Public Property [VATCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [VATCodeDescription] As String
	Public Property [VATPercentage] As Double?
End Class

<DataServiceKey("ItemId")>
Public Class SalesItemPrice
	Public Property [ItemId] As Guid
	Public Property [ItemCode] As String
	Public Property [ItemDescription] As String
	Public Property [PriceExcludingVAT] As Double
	Public Property [PriceIncludingVAT] As Double
	Public Property [CurrencyCode] As String
	Public Property [UnitCode] As String
	Public Property [UnitDescription] As String
	Public Property [VATCode] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("OrderID")>
Public Class SalesOrder
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AmountDC] As Double?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AmountFC] As Double?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ApprovalStatus] As Int16?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ApprovalStatusDescription] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Approved] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Approver] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ApproverFullName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	Public Property [Currency] As String
	Public Property [DeliverTo] As Guid?
	Public Property [DeliverToContactPerson] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DeliverToContactPersonFullName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DeliverToName] As String
	Public Property [DeliveryDate] As DateTime?
	Public Property [DeliveryStatus] As Int16?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DeliveryStatusDescription] As String
	Public Property [Description] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	Public Property [Document] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DocumentNumber] As Int32?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DocumentSubject] As String
	Public Property [InvoiceStatus] As Int16?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [InvoiceStatusDescription] As String
	Public Property [InvoiceTo] As Guid?
	Public Property [InvoiceToContactPerson] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [InvoiceToContactPersonFullName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [InvoiceToName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	Public Property [OrderDate] As DateTime?
	Public Property [OrderedBy] As Guid?
	Public Property [OrderedByContactPerson] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [OrderedByContactPersonFullName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [OrderedByName] As String
	Public Property [OrderID] As Guid
	Public Property [OrderNumber] As Int32?
	Public Property [PaymentCondition] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PaymentConditionDescription] As String
	Public Property [Remarks] As String
	Public Property [Salesperson] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SalespersonFullName] As String
	Public Property [ShippingMethod] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ShippingMethodDescription] As String
	Public Property [Status] As Int16?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [StatusDescription] As String
	Public Property [TaxSchedule] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [TaxScheduleCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [TaxScheduleDescription] As String
	Public Property [WarehouseID] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [WarehouseCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [WarehouseDescription] As String
	Public Property [YourRef] As String
	Public Property [SalesOrderLines] As IEnumerable(Of SalesOrderLine)
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class SalesOrderLine
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AmountDC] As Double?
	Public Property [AmountFC] As Double?
	Public Property [CostCenter] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostCenterDescription] As String
	Public Property [CostUnit] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostUnitDescription] As String
	Public Property [DeliveryDate] As DateTime?
	Public Property [Description] As String
	Public Property [Discount] As Double?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	Public Property [ID] As Guid
	Public Property [OrderID] As Guid
	Public Property [Item] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemDescription] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemCode] As String
	Public Property [ItemVersion] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemVersionDescription] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [LineNumber] As Int32?
	Public Property [NetPrice] As Double?
	Public Property [Notes] As String
	Public Property [OrderNumber] As Int32?
	Public Property [Pricelist] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PricelistDescription] As String
	Public Property [Project] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectDescription] As String
	Public Property [Quantity] As Double?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [QuantityDelivered] As Double?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [QuantityInvoiced] As Double?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ShopOrder] As Guid?
	Public Property [TaxSchedule] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [TaxScheduleCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [TaxScheduleDescription] As String
	Public Property [UnitCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [UnitDescription] As String
	Public Property [UnitPrice] As Double?
	Public Property [UseDropShipment] As Byte
	Public Property [VATAmount] As Double?
	Public Property [VATCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [VATCodeDescription] As String
	Public Property [VATPercentage] As Double?
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class ShopOrder
	Public Property [Costcenter] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostcenterDescription] As String
	Public Property [Costunit] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostunitDescription] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	Public Property [Description] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	Public Property [EntryDate] As DateTime?
	Public Property [ID] As Guid
	Public Property [IsInPlanning] As Byte
	Public Property [IsOnHold] As Byte
	Public Property [IsReleased] As Byte
	Public Property [Item] As Guid?
	Public Property [ItemVersion] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemVersionDescription] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	Public Property [Notes] As String
	Public Property [PlannedDate] As DateTime?
	Public Property [PlannedQuantity] As Double?
	Public Property [PlannedStartDate] As DateTime?
	Public Property [ProducedQuantity] As Double?
	Public Property [Project] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectDescription] As String
	Public Property [ReadyToShipQuantity] As Double?
	Public Property [SalesOrderLines] As IEnumerable(Of SalesOrderLine)
	Public Property [ShopOrderMain] As Guid?
	Public Property [ShopOrderMainNumber] As Int32?
	Public Property [ShopOrderMaterialPlans] As IEnumerable(Of ShopOrderMaterialPlan)
	Public Property [ShopOrderNumber] As Int32?
	Public Property [ShopOrderParent] As Guid?
	Public Property [ShopOrderParentNumber] As Int32?
	Public Property [ShopOrderRoutingStepPlans] As IEnumerable(Of ShopOrderRoutingStepPlan)
	Public Property [Status] As Int16?
	Public Property [Type] As Int16?
	Public Property [Warehouse] As Guid?
	Public Property [YourRef] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class ShopOrderMaterialPlan
	Public Property [Backflush] As Byte
	Public Property [CalculatorType] As Int16?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	Public Property [Description] As String
	Public Property [DetailDrawing] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	Public Property [ID] As Guid
	Public Property [Item] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemDescription] As String
	Public Property [LineNumber] As Int32?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	Public Property [Notes] As String
	Public Property [PlannedAmountFC] As Double?
	Public Property [PlannedDate] As DateTime?
	Public Property [PlannedPriceFC] As Double?
	Public Property [PlannedQuantity] As Double?
	Public Property [PlannedQuantityFactor] As Double?
	Public Property [ShopOrder] As Guid?
	Public Property [Status] As Int16?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [StatusDescription] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class ShopOrderRoutingStepPlan
	Public Property [Account] As Guid?
	Public Property [AttendedPercentage] As Double?
	Public Property [Backflush] As Byte
	Public Property [CostPerItem] As Double?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	Public Property [Description] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	Public Property [EfficiencyPercentage] As Double?
	Public Property [FactorType] As Int16?
	Public Property [ID] As Guid
	Public Property [LineNumber] As Int32?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	Public Property [Operation] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [OperationDescription] As String
	Public Property [OperationResource] As Guid?
	Public Property [PlannedEndDate] As DateTime?
	Public Property [PlannedRunHours] As Double?
	Public Property [PlannedSetupHours] As Double?
	Public Property [PlannedStartDate] As DateTime?
	Public Property [PlannedTotalHours] As Double?
	Public Property [PurchaseUnit] As String
	Public Property [PurchaseUnitFactor] As Double?
	Public Property [PurchaseUnitPriceFC] As Double?
	Public Property [PurchaseUnitQuantity] As Double?
	Public Property [RoutingStepType] As Int16?
	Public Property [Run] As Double?
	Public Property [RunMethod] As Int16?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [RunMethodDescription] As String
	Public Property [Setup] As Double?
	Public Property [SetupUnit] As String
	Public Property [ShopOrder] As Guid?
	Public Property [Status] As Int16?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [StatusDescription] As String
	Public Property [SubcontractedLeadDays] As Int32?
	Public Property [TotalCostDC] As Double?
	Public Property [Workcenter] As Guid?
End Class

<DataServiceKey("ItemId")>
Public Class StockPosition
	Public Property [ItemId] As Guid
	Public Property [InStock] As Double
	Public Property [PlanningIn] As Double
	Public Property [PlanningOut] As Double
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("EntryID")>
Public Class Subscription
	Public Property [BlockEntry] As Boolean?
	Public Property [CancellationDate] As DateTime?
	Public Property [Classification] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ClassificationCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ClassificationDescription] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	Public Property [Currency] As String
	Public Property [CustomerPONumber] As String
	Public Property [Description] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32
	Public Property [EndDate] As DateTime?
	Public Property [EntryID] As Guid
	Public Property [InvoicedTo] As DateTime?
	Public Property [InvoiceTo] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [InvoiceToName] As String
	Public Property [InvoiceToContactPerson] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [InvoiceToContactPersonFullName] As String
	Public Property [InvoicingStartDate] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	Public Property [OrderedBy] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [OrderedByName] As String
	Public Property [OrderedByContactPerson] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [OrderedByContactPersonFullName] As String
	Public Property [Notes] As String
	Public Property [Number] As Int32
	Public Property [PaymentCondition] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PaymentConditionDescription] As String
	Public Property [Printed] As Boolean
	Public Property [ReasonCancelled] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ReasonCancelledCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ReasonCancelledDescription] As String
	Public Property [StartDate] As DateTime
	Public Property [SubscriptionType] As Guid
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SubscriptionTypeCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SubscriptionTypeDescription] As String
	Public Property [SubscriptionLines] As IEnumerable(Of SubscriptionLine)
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SubscriptionRestrictionEmployees] As IEnumerable(Of SubscriptionRestrictionEmployee)
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SubscriptionRestrictionItems] As IEnumerable(Of SubscriptionRestrictionItem)
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class SubscriptionChargeType
	Public Property [ID] As Int16
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Description] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class SubscriptionLine
	Public Property [AmountDC] As Double
	Public Property [AmountFC] As Double
	Public Property [Costcenter] As String
	Public Property [Costunit] As String
	Public Property [Description] As String
	Public Property [Discount] As Double?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32
	Public Property [EntryID] As Guid
	Public Property [FromDate] As DateTime
	Public Property [ID] As Guid
	Public Property [Item] As Guid
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemDescription] As String
	Public Property [LineNumber] As Int32
	Public Property [LineType] As Int16?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [LineTypeDescription] As String
	Public Property [NetPrice] As Double
	Public Property [Notes] As String
	Public Property [Quantity] As Double
	Public Property [ToDate] As DateTime?
	Public Property [UnitCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [UnitDescription] As String
	Public Property [UnitPrice] As Double
	Public Property [VATAmountFC] As Double?
	Public Property [VATCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [VATCodeDescription] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class SubscriptionReasonCode
	Public Property [Active] As Boolean
	Public Property [Code] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	Public Property [Description] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32
	Public Property [ID] As Guid
	Public Property [Notes] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
End Class

<DataServiceKey("ID")>
Public Class SubscriptionRestriction
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32
	Public Property [ID] As Guid
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	Public Property [Subscription] As Guid
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SubscriptionNumber] As Int32
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SubscriptionDescription] As String
End Class

<SupportedActionsSDK(True, True, False, True)>
<DataServiceKey("ID")>
Public Class SubscriptionRestrictionEmployee
	Public Property [Employee] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [EmployeeFullName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [EmployeeHID] As Int32?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32
	Public Property [ID] As Guid
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	Public Property [Subscription] As Guid
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SubscriptionNumber] As Int32
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SubscriptionDescription] As String
End Class

<SupportedActionsSDK(True, True, False, True)>
<DataServiceKey("ID")>
Public Class SubscriptionRestrictionItem
	Public Property [Item] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemDescription] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32
	Public Property [ID] As Guid
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	Public Property [Subscription] As Guid
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SubscriptionNumber] As Int32
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SubscriptionDescription] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class SubscriptionType
	Public Property [Code] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	Public Property [Description] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32
	Public Property [ID] As Guid
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class TaxComponentRate
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	Public Property [CreatorFullName] As String
	Public Property [Division] As Int32
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [EndDate] As DateTime?
	Public Property [ID] As Guid
	Public Property [LineNumber] As Int32
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	Public Property [Rate] As Double
	Public Property [StartDate] As DateTime?
	Public Property [TaxComponent] As Guid
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("DocumentID")>
Public Class TaxDocument
	Public Property [DocumentID] As Guid
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime
	Public Property [Request] As Guid?
	Public Property [Status] As Int32
	Public Property [Amount] As Double?
	Public Property [Currency] As String
	Public Property [Description] As String
	Public Property [Year] As Int32
	Public Property [Type] As Int32
	Public Property [PayrollDeclarationType] As String
	Public Property [Frequency] As String
	Public Property [Period] As Int32
	Public Property [PeriodDescription] As String
	Public Property [DueDate] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DocumentViewUrl] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class TaxSchedule
	Public Property [Code] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	Public Property [CreatorFullName] As String
	Public Property [Description] As String
	Public Property [Division] As Int32
	Public Property [ID] As Guid
	Public Property [IsBlocked] As Byte
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	Public Property [Notes] As String
	Public Property [Type] As Int16
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class TaxScheduleComponent
	Public Property [Account] As Guid?
	Public Property [Code] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	Public Property [CreatorFullName] As String
	Public Property [Description] As String
	Public Property [Division] As Int32
	Public Property [GLAccount] As Guid?
	Public Property [ID] As Guid
	Public Property [LineNumber] As Int32
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	Public Property [Notes] As String
	Public Property [TaxComponent] As Guid
	Public Property [TaxSchedule] As Guid
	Public Property [TaxComponentRates] As IEnumerable(Of TaxComponentRate)
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("AccountId")>
Public Class TimeAndBillingAccount
	Public Property [AccountId] As Guid
	Public Property [AccountName] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class TimeAndBillingAccountDetails
	Public Property [ID] As Guid
	Public Property [Name] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class TimeAndBillingActivitiesAndExpenses
	Public Property [ID] As Guid
	Public Property [Description] As String
	Public Property [ParentDescription] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class TimeAndBillingItemDetails
	Public Property [ID] As Guid
	Public Property [Code] As String
	Public Property [Description] As String
	Public Property [IsSalesItem] As Boolean
	Public Property [SalesCurrency] As String
	Public Property [SalesPrice] As Double
	Public Property [IsFractionAllowedItem] As Boolean
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ProjectId")>
Public Class TimeAndBillingProject
	Public Property [ProjectId] As Guid
	Public Property [ProjectCode] As String
	Public Property [ProjectDescription] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class TimeAndBillingProjectDetails
	Public Property [ID] As Guid
	Public Property [Code] As String
	Public Property [Description] As String
	Public Property [Account] As Guid?
	Public Property [AccountName] As String
	Public Property [Type] As Int32
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("AccountId")>
Public Class TimeAndBillingRecentAccount
	Public Property [AccountId] As Guid
	Public Property [AccountName] As String
	Public Property [DateLastUsed] As DateTime
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class TimeAndBillingRecentActivitiesAndExpenses
	Public Property [ID] As Guid
	Public Property [Description] As String
	Public Property [ParentDescription] As String
	Public Property [DateLastUsed] As DateTime
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ItemId")>
Public Class TimeAndBillingRecentHourCostType
	Public Property [ItemId] As Guid
	Public Property [ItemDescription] As String
	Public Property [DateLastUsed] As DateTime
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ProjectId")>
Public Class TimeAndBillingRecentProject
	Public Property [ProjectId] As Guid
	Public Property [ProjectCode] As String
	Public Property [ProjectDescription] As String
	Public Property [DateLastUsed] As DateTime
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class TimeTransaction
	Public Property [Amount] As Double?
	Public Property [Price] As Double?
	Public Property [Account] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountName] As String
	Public Property [Activity] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ActivityDescription] As String
	Public Property [AmountFC] As Double?
	Public Property [Attachment] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	Public Property [Currency] As String
	Public Property [Date] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DivisionDescription] As String
	Public Property [Employee] As Guid?
	Public Property [EndTime] As DateTime?
	Public Property [EntryNumber] As Int32?
	Public Property [ErrorText] As String
	Public Property [HourStatus] As Int16?
	Public Property [ID] As Guid
	Public Property [Item] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemDescription] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemDivisable] As Boolean?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	Public Property [Notes] As String
	Public Property [PriceFC] As Double?
	Public Property [Project] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectAccount] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectAccountCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectAccountName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectDescription] As String
	Public Property [Quantity] As Double?
	Public Property [StartTime] As DateTime?
	Public Property [Subscription] As Guid?
	Public Property [SubscriptionAccount] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SubscriptionAccountCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SubscriptionAccountName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SubscriptionDescription] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SubscriptionNumber] As Int32?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Type] As Int16?
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("EntryID")>
Public Class Transaction
	Public Property [ClosingBalanceFC] As Double?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	Public Property [Date] As DateTime?
	Public Property [Description] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	Public Property [EntryID] As Guid
	Public Property [EntryNumber] As Int32?
	Public Property [FinancialPeriod] As Int16?
	Public Property [FinancialYear] As Int16?
	Public Property [JournalCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [JournalDescription] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	Public Property [OpeningBalanceFC] As Double?
	Public Property [PaymentConditionCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [PaymentConditionDescription] As String
	Public Property [Status] As Int16?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [StatusDescription] As String
	Public Property [TransactionLines] As IEnumerable(Of TransactionLine)
	Public Property [Type] As Int32?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [TypeDescription] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class TransactionLine
	Public Property [Account] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountName] As String
	Public Property [AmountDC] As Double?
	Public Property [AmountFC] As Double?
	Public Property [AmountVATFC] As Double?
	Public Property [AmountVATBaseFC] As Double?
	Public Property [Asset] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AssetCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AssetDescription] As String
	Public Property [CostCenter] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostCenterDescription] As String
	Public Property [CostUnit] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostUnitDescription] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	Public Property [Currency] As String
	Public Property [Date] As DateTime?
	Public Property [Description] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	Public Property [Document] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DocumentNumber] As Int32?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [DocumentSubject] As String
	Public Property [DueDate] As DateTime?
	Public Property [EntryID] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [EntryNumber] As Int32?
	Public Property [ExchangeRate] As Double?
	Public Property [FinancialPeriod] As Int16?
	Public Property [FinancialYear] As Int16?
	Public Property [GLAccount] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLAccountCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLAccountDescription] As String
	Public Property [ID] As Guid
	Public Property [InvoiceNumber] As Int32?
	Public Property [Item] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ItemDescription] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [LineNumber] As Int32?
	Public Property [LineType] As Int16?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	Public Property [Notes] As String
	Public Property [OffsetID] As Guid?
	Public Property [OrderNumber] As Int32?
	Public Property [PaymentDiscountAmount] As Double?
	Public Property [PaymentReference] As String
	Public Property [Project] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ProjectDescription] As String
	Public Property [Quantity] As Double?
	Public Property [SerialNumber] As String
	Public Property [Subscription] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [SubscriptionDescription] As String
	Public Property [TrackingNumber] As String
	Public Property [TrackingNumberDescription] As String
	Public Property [VATCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [VATCodeDescription] As String
	Public Property [VATPercentage] As Double?
	Public Property [VATType] As String
	Public Property [YourRef] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class Unit
	Public Property [Active] As Boolean?
	Public Property [Code] As String
	Public Property [Description] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	Public Property [ID] As Guid
	Public Property [Main] As Byte?
	Public Property [TimeUnit] As String
	Public Property [Type] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("UserID")>
Public Class User
	Public Property [BirthDate] As DateTime?
	Public Property [BirthName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	Public Property [Customer] As Guid
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CustomerName] As String
	Public Property [Email] As String
	Public Property [EndDate] As DateTime?
	Public Property [FirstName] As String
	Public Property [FullName] As String
	Public Property [Gender] As String
	Public Property [Initials] As String
	Public Property [Language] As String
	Public Property [LastLogin] As DateTime?
	Public Property [LastName] As String
	Public Property [MiddleName] As String
	Public Property [Mobile] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	Public Property [Nationality] As String
	Public Property [Notes] As String
	Public Property [Phone] As String
	Public Property [PhoneExtension] As String
	Public Property [ProfileCode] As String
	Public Property [StartDate] As DateTime?
	Public Property [StartDivision] As Int32
	Public Property [Title] As String
	Public Property [UserID] As Guid
	Public Property [UserName] As String
	Public Property [UserTypesList] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [UserRoles] As IEnumerable(Of UserRole)
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class UserRole
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	Public Property [ID] As Guid
	Public Property [UserID] As Guid?
	Public Property [Description] As String
	Public Property [Role] As Int32
	Public Property [RoleLevel] As Int32
	Public Property [StartDate] As DateTime
	Public Property [EndDate] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class VATCode
	Public Property [Account] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [AccountName] As String
	Public Property [CalculationBasis] As Byte?
	Public Property [Charged] As Boolean?
	Public Property [Code] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Country] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	Public Property [Description] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	Public Property [EUSalesListing] As String
	Public Property [GLDiscountPurchase] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLDiscountPurchaseCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLDiscountPurchaseDescription] As String
	Public Property [GLDiscountSales] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLDiscountSalesCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLDiscountSalesDescription] As String
	Public Property [GLToClaim] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLToClaimCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLToClaimDescription] As String
	Public Property [GLToPay] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLToPayCode] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [GLToPayDescription] As String
	Public Property [ID] As Guid
	Public Property [IntraStat] As Boolean?
	Public Property [IsBlocked] As Boolean?
	Public Property [LegalText] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Percentage] As Double?
	Public Property [TaxReturnType] As Int16?
	Public Property [Type] As String
	Public Property [VatDocType] As String
	Public Property [VatMargin] As Byte
	Public Property [VATPartialRatio] As Int16?
	Public Property [VATPercentages] As IEnumerable(Of VatPercentage)
	Public Property [VATTransactionType] As String
End Class

<SupportedActionsSDK(False, True, False, False)>
<DataServiceKey("ID")>
Public Class VatPercentage
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	Public Property [ID] As Guid
	Public Property [LineNumber] As Int32?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	Public Property [Percentage] As Double?
	Public Property [StartDate] As DateTime?
	Public Property [EndDate] As DateTime?
	Public Property [VATCodeID] As Guid
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class Warehouse
	Public Property [Code] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	Public Property [Description] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	Public Property [EMail] As String
	Public Property [ID] As Guid
	Public Property [Main] As Byte
	Public Property [ManagerUser] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	Public Property [UseStorageLocations] As Byte
End Class

<SupportedActionsSDK(True, True, True, True)>
<DataServiceKey("ID")>
Public Class Workcenter
	Public Property [Code] As String
	Public Property [Costcenter] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostcenterDescription] As String
	Public Property [Costunit] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CostunitDescription] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Created] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Creator] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [CreatorFullName] As String
	Public Property [Description] As String
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Division] As Int32?
	Public Property [GeneralBurdenRate] As Double?
	Public Property [ID] As Guid
	Public Property [IsLaborBurdenPercent] As Byte
	Public Property [LaborBurdenRate] As Double?
	Public Property [MachineBurdenRate] As Double?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modified] As DateTime?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [Modifier] As Guid?
	'''<summary>Readonly Field</summary>
	<SDKFieldType(FieldType.ReadOnly)>
	Public Property [ModifierFullName] As String
	Public Property [Notes] As String
	Public Property [ProductionArea] As Guid?
	Public Property [RunLaborRate] As Double?
	Public Property [SearchCode] As String
	Public Property [SetupLaborRate] As Double?
	Public Property [Status] As Int16?
	Public Property [Type] As Int16?
End Class


