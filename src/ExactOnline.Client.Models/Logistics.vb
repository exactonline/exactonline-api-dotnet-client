Namespace Logistics

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [Item]
		'''<summary>Barcode of the item (numeric string)</summary>
		Public Property [Barcode] As String
		'''<summary>Item class code referring to ItemClasses with ClassID 1</summary>
		Public Property [Class_01] As String
		'''<summary>Item class code referring to ItemClasses with ClassID 2</summary>
		Public Property [Class_02] As String
		'''<summary>Item class code referring to ItemClasses with ClassID 3</summary>
		Public Property [Class_03] As String
		'''<summary>Item class code referring to ItemClasses with ClassID 4</summary>
		Public Property [Class_04] As String
		'''<summary>Item class code referring to ItemClasses with ClassID 5</summary>
		Public Property [Class_05] As String
		'''<summary>Item class code referring to ItemClasses with ClassID 6</summary>
		Public Property [Class_06] As String
		'''<summary>Item class code referring to ItemClasses with ClassID 7</summary>
		Public Property [Class_07] As String
		'''<summary>Item class code referring to ItemClasses with ClassID 8</summary>
		Public Property [Class_08] As String
		'''<summary>Item class code referring to ItemClasses with ClassID 9</summary>
		Public Property [Class_09] As String
		'''<summary>Item class code referring to ItemClasses with ClassID 10</summary>
		Public Property [Class_10] As String
		'''<summary>Item code</summary>
		Public Property [Code] As String
		'''<summary>Copy sales remarks to sales lines</summary>
		Public Property [CopyRemarks] As Byte
		'''<summary>The currency of the current and proposed cost price</summary>
		Public Property [CostPriceCurrency] As String
		'''<summary>Proposed cost price</summary>
		Public Property [CostPriceNew] As Double?
		'''<summary>The current standard cost price</summary>
		Public Property [CostPriceStandard] As Double?
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<summary>User ID of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>Description of the item</summary>
		Public Property [Description] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<summary>Together with StartDate this determines if the item is active</summary>
		Public Property [EndDate] As DateTime?
		'''<summary>Extra description text, slightly longer than the regular description (255 instead of 60)</summary>
		Public Property [ExtraDescription] As String
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
		'''<summary>Free numeric field 1</summary>
		Public Property [FreeNumberField_01] As Double?
		'''<summary>Free numeric field 2</summary>
		Public Property [FreeNumberField_02] As Double?
		'''<summary>Free numeric field 3</summary>
		Public Property [FreeNumberField_03] As Double?
		'''<summary>Free numeric field 4</summary>
		Public Property [FreeNumberField_04] As Double?
		'''<summary>Free numeric field 5</summary>
		Public Property [FreeNumberField_05] As Double?
		'''<summary>Free numeric field 6</summary>
		Public Property [FreeNumberField_06] As Double?
		'''<summary>Free numeric field 7</summary>
		Public Property [FreeNumberField_07] As Double?
		'''<summary>Free numeric field 8</summary>
		Public Property [FreeNumberField_08] As Double?
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
		'''<summary>Free text field 6</summary>
		Public Property [FreeTextField_06] As String
		'''<summary>Free text field 7</summary>
		Public Property [FreeTextField_07] As String
		'''<summary>Free text field 8</summary>
		Public Property [FreeTextField_08] As String
		'''<summary>Free text field 9</summary>
		Public Property [FreeTextField_09] As String
		'''<summary>Free text field 10</summary>
		Public Property [FreeTextField_10] As String
		'''<summary>GL account the cost entries will be booked on. This overrules the GL account from the item group. If the license contains &apos;Intuit integration&apos; this property overrides the value in Settings, not the item group.</summary>
		Public Property [GLCosts] As Guid?
		'''<summary>Code of GL account for costs</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLCostsCode] As String
		'''<summary>Description of GLCosts</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLCostsDescription] As String
		'''<summary>GL account the revenue will be booked on. This overrules the GL account from the item group. If the license contains &apos;Intuit integration&apos; this property overrides the value in Settings, not the item group.</summary>
		Public Property [GLRevenue] As Guid?
		'''<summary>Code of GLRevenue</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLRevenueCode] As String
		'''<summary>Description of GLRevenue</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLRevenueDescription] As String
		'''<summary>GL account the stock entries will be booked on. This overrules the GL account from the item group. If the license contains &apos;Intuit integration&apos; this property overrides the value in Settings, not the item group.</summary>
		Public Property [GLStock] As Guid?
		'''<summary>Code of GL account for stock</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLStockCode] As String
		'''<summary>Description of GLStock</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLStockDescription] As String
		'''<summary>Gross weight for international goods shipments</summary>
		Public Property [GrossWeight] As Double?
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Indicates if batches are used for this item</summary>
		Public Property [IsBatchItem] As Byte
		'''<summary>This property is obsolete. Use property &apos;IsBatchItem&apos; instead.</summary>
		Public Property [IsBatchNumberItem] As Byte
		'''<summary>Indicates if fractions (for example 0.35) are allowed for quantities of this item</summary>
		Public Property [IsFractionAllowedItem] As Boolean?
		'''<summary>Indicates that an Item is produced to Inventory, not purchased</summary>
		Public Property [IsMakeItem] As Byte
		'''<summary>Only used for packages (IsPackageItem=1). To indicate if this package is a new contract type package</summary>
		Public Property [IsNewContract] As Byte
		'''<summary>Is On demand Item</summary>
		Public Property [IsOnDemandItem] As Byte
		'''<summary>Indicates if the item is a package item. Can only be created in the hosting administration</summary>
		Public Property [IsPackageItem] As Boolean?
		'''<summary>Indicates if the item can be purchased</summary>
		Public Property [IsPurchaseItem] As Boolean?
		'''<summary>Indicated if the item is used in voucher functionality</summary>
		Public Property [IsRegistrationCodeItem] As Byte
		'''<summary>Indicates if the item can be sold</summary>
		Public Property [IsSalesItem] As Boolean?
		'''<summary>Indicates that serial numbers are used for this item</summary>
		Public Property [IsSerialItem] As Boolean?
		'''<summary>This property is obsolete. Use property &apos;IsSerialItem&apos; instead.</summary>
		Public Property [IsSerialNumberItem] As Boolean?
		'''<summary>If you have the Trade or Manufacturing license and you check this property the item will be shown in the stock positions overview, stock counts and transaction lists. If you have the Invoice module and you check this property you will get a general journal entry based on the Stock and Costs G/L accounts of the item group. If you don’t want the general journal entry to be created you should change the Stock/Costs G/L account on the Item group page to the type Costs instead of Inventory.</summary>
		Public Property [IsStockItem] As Boolean?
		'''<summary>Indicates if the item is provided by an outside supplier</summary>
		Public Property [IsSubcontractedItem] As Boolean?
		'''<summary>Indicates if tax needs to be calculated for this item</summary>
		Public Property [IsTaxableItem] As Byte?
		'''<summary>Indicates if the item is a time unit item (for example a labor hour item)</summary>
		Public Property [IsTime] As Byte
		'''<summary>Indicates if the item can be exported to a web shop</summary>
		Public Property [IsWebshopItem] As Byte
		'''<summary>GUID of Item group of the item</summary>
		Public Property [ItemGroup] As Guid?
		'''<summary>Code of ItemGroup</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemGroupCode] As String
		'''<summary>Description of ItemGroup</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemGroupDescription] As String
		'''<summary>Last modified date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<summary>User ID of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Name of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>Net weight for international goods shipments</summary>
		Public Property [NetWeight] As Double?
		'''<summary>Net Weight unit for international goods shipment, only available in manufacturing packages</summary>
		Public Property [NetWeightUnit] As String
		'''<summary>Notes</summary>
		Public Property [Notes] As String
		'''<summary>File name of picture</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PictureName] As String
		'''<summary>Url where thumbnail picture can be retrieved</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PictureThumbnailUrl] As String
		'''<summary>Url where picture can be retrieved</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PictureUrl] As String
		'''<summary>Code of SalesVat</summary>
		Public Property [SalesVatCode] As String
		'''<summary>Description of SalesVatCode</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SalesVatCodeDescription] As String
		'''<summary>Search code of the item</summary>
		Public Property [SearchCode] As String
		'''<summary>Security level (0 - 100)</summary>
		Public Property [SecurityLevel] As Int32?
		'''<summary>Together with EndDate this determines if the item is active</summary>
		Public Property [StartDate] As DateTime?
		'''<summary>Quantity that is in stock</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Stock] As Double?
		'''<summary>The standard unit of this item</summary>
		Public Property [Unit] As String
		'''<summary>Description of Unit</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [UnitDescription] As String
		'''<summary>Type of unit: A=Area, L=Length, O=Other, T=Time, V=Volume, W=Weight</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [UnitType] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [ItemGroup]
		'''<summary>Code of the item group</summary>
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
		'''<summary>Description of the item group</summary>
		Public Property [Description] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<summary>GL account on which the costs of items of this group will be booked</summary>
		Public Property [GLCosts] As Guid?
		'''<summary>Code of GLCosts</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLCostsCode] As String
		'''<summary>Description of GLCosts</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLCostsDescription] As String
		'''<summary>GL Purchase account for purchase invoicing according to (non-) perpetual inventory method</summary>
		Public Property [GLPurchaseAccount] As Guid?
		'''<summary>Code of GLPurchase</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLPurchaseAccountCode] As String
		'''<summary>Description of GLPurchaseAccount</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLPurchaseAccountDescription] As String
		'''<summary>GL account that will be used for the &apos;Standard cost price&apos; valuation method to balance the difference between purchase price and cost price</summary>
		Public Property [GLPurchasePriceDifference] As Guid?
		'''<summary>Code of GLPurchasePriceDifference</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLPurchasePriceDifferenceCode] As String
		'''<summary>Description of GLPurchasePriceDifference</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLPurchasePriceDifferenceDescr] As String
		'''<summary>GL account on which the revenue for items of this group will be booked</summary>
		Public Property [GLRevenue] As Guid?
		'''<summary>Code of GLRevenue</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLRevenueCode] As String
		'''<summary>Description of GLRevenue</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLRevenueDescription] As String
		'''<summary>GL account on which stock entries will be booked for items of this group</summary>
		Public Property [GLStock] As Guid?
		'''<summary>Code of GLStock</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLStockCode] As String
		'''<summary>Description of GLStock</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLStockDescription] As String
		'''<summary>GL stock variance account for perpetual inventory</summary>
		Public Property [GLStockVariance] As Guid?
		'''<summary>Code of GLStockVariance</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLStockVarianceCode] As String
		'''<summary>Description of GLStockVariance</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLStockVarianceDescription] As String
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Indicates if this is the default item group that will be assigned when a new item is created</summary>
		Public Property [IsDefault] As Byte
		'''<summary>Last modified date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<summary>User ID of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Name of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>Notes</summary>
		Public Property [Notes] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [ItemVersion]
		'''<summary>Batch Quantity of Item Version</summary>
		Public Property [BatchQuantity] As Double?
		'''<summary>Calculated Cost Price of Item Version</summary>
		Public Property [CalculatedCostPrice] As Double?
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<summary>User ID of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>Description of the item version</summary>
		Public Property [Description] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Indicates if this is the default item version that will be assigned when a item is selected</summary>
		Public Property [IsDefault] As Byte
		'''<summary>Reference to Items table</summary>
		Public Property [Item] As Guid
		'''<summary>Description of Item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDescription] As String
		'''<summary>Lead time of Item version</summary>
		Public Property [LeadTime] As Int32?
		'''<summary>Last modified date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<summary>User ID of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Name of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>Line notes</summary>
		Public Property [Notes] As String
		'''<summary>Statuses of Item version: 10-Engineering change pending, 20-Engineering change approved, 30-Active &amp; 40-Historic</summary>
		Public Property [Status] As Int16?
		'''<summary>Description of Status</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StatusDescription] As String
		'''<summary>Type of Item version: 10-Sales bill of material, 20-Manufacturing recipe</summary>
		Public Property [Type] As Int16?
		'''<summary>Description of Type</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [TypeDescription] As String
		'''<summary>Version Number</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VersionNumber] As Int32?
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [SalesItemPrice]
		'''<summary>ID of the customer</summary>
		Public Property [Account] As Guid?
		'''<summary>Name of the customer account</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountName] As String
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<summary>User ID of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>The currency of the price</summary>
		Public Property [Currency] As String
		'''<summary>The default unit of the item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DefaultItemUnit] As String
		'''<summary>The description of the default item unit</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DefaultItemUnitDescription] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<summary>Together with StartDate this determines whether the price is active</summary>
		Public Property [EndDate] As DateTime?
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Item ID</summary>
		Public Property [Item] As Guid?
		'''<summary>Code of Item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemCode] As String
		'''<summary>Description of Item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDescription] As String
		'''<summary>Last modified date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<summary>User ID of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Name of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>This is the multiplication factor when going from default item unit to the unit of this price.For example if the default item unit is &apos;gram&apos; and the price unit is &apos;kilogram&apos; then the value of this property is 1000.</summary>
		Public Property [NumberOfItemsPerUnit] As Double?
		'''<summary>The actual price of this sales item</summary>
		Public Property [Price] As Double?
		'''<summary>Minimum quantity to which the price is applicable</summary>
		Public Property [Quantity] As Double?
		'''<summary>Together with EndDate this determines whether the price is active</summary>
		Public Property [StartDate] As DateTime
		'''<summary>The unit code of the price</summary>
		Public Property [Unit] As String
		'''<summary>Description of the price unit</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [UnitDescription] As String
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [SupplierItem]
		'''<summary>Country of origin code</summary>
		Public Property [CountryOfOrigin] As String
		'''<summary>Description of country of origin</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CountryOfOriginDescription] As String
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<summary>User ID of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>Currency of item price</summary>
		Public Property [Currency] As String
		'''<summary>Description of currency of item price</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CurrencyDescription] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<summary>Indicates that the supplier will deliver the item directly to customer. Values: 0 = No, 1 = Yes, 2 = Optional</summary>
		Public Property [DropShipment] As Byte?
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Item ID</summary>
		Public Property [Item] As Guid?
		'''<summary>Item code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemCode] As String
		'''<summary>Description of Item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDescription] As String
		'''<summary>Indicates this is a main supplier</summary>
		Public Property [MainSupplier] As Boolean?
		'''<summary>Minimum quantity of the item for purchase, only available for Wholesale &amp; Distribution (Premium only)</summary>
		Public Property [MinimumQuantity] As Double?
		'''<summary>Last modified date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<summary>User ID of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Name of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>The number of days between placing an order with a supplier and receiving items from the supplier</summary>
		Public Property [PurchaseLeadTime] As Int32?
		'''<summary>Purchase price</summary>
		Public Property [PurchasePrice] As Double?
		'''<summary>Unit code</summary>
		Public Property [PurchaseUnit] As String
		'''<summary>Description of unit</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PurchaseUnitDescription] As String
		'''<summary>This is the multiplication factor when going from default item unit to the unit of this price</summary>
		Public Property [PurchaseUnitFactor] As Double?
		'''<summary>VAT code</summary>
		Public Property [PurchaseVATCode] As String
		'''<summary>Description of VAT</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PurchaseVATCodeDescription] As String
		'''<summary>Supplier ID</summary>
		Public Property [Supplier] As Guid?
		'''<summary>Supplier code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SupplierCode] As String
		'''<summary>Description of supplier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SupplierDescription] As String
		'''<summary>Supplier’s item code</summary>
		Public Property [SupplierItemCode] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [Unit]
		'''<summary>Indicates whether a unit is in use</summary>
		Public Property [Active] As Boolean?
		'''<summary>Unique code for the unit</summary>
		Public Property [Code] As String
		'''<summary>Description</summary>
		Public Property [Description] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Indicates the main unit per division. Will be used when creating new item</summary>
		Public Property [Main] As Byte?
		'''<summary>If Type = &apos;T&apos; (time) then this fields indicates the type of time frame. yy = Year, mm = Month, wk = Week, dd = Day, hh = Hour, mi = Minute, ss = Second</summary>
		Public Property [TimeUnit] As String
		'''<summary>Type of unit. Type &apos;Time&apos; is especially important for contracts.</summary>
		Public Property [Type] As String
	End Class
	
	<SupportedActionsSDK(False, True, False, False)>
    <DataServiceKey("ItemID")>
    Public Class [ItemExtraField]
        '''<summary>Primary key</summary>
        Public Property [ItemID] As Guid
        '''<summary>Description of the free field</summary>
       	<SDKFieldType(FieldType.ReadOnly)>
        Public Property [Description] As String
        '''<summary>Determine the unique free field name as FreeField{Number},</summary>
       	<SDKFieldType(FieldType.ReadOnly)>
        Public Property [Number] As Int32?
        '''<summary>The value store in free field</summary>
       	<SDKFieldType(FieldType.ReadOnly)>
        Public Property [Value] As String
        '''<summary>Last modified date</summary>
       	<SDKFieldType(FieldType.ReadOnly)>
        Public Property [Modified] As DateTime?

    End Class
	

End Namespace
