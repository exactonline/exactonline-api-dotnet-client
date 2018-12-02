Namespace Sales

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [PriceList]
		'''<summary>Code to indicate the price list</summary>
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
		'''<summary>All prices in the price list are stored in this currency</summary>
		Public Property [Currency] As String
		'''<summary>Description</summary>
		Public Property [Description] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<summary>Description of Division</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DivisionDescription] As String
		'''<summary>Indicates the entity (Item, Item group, ..) on which this price list is based</summary>
		Public Property [Entity] As Int16?
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
		'''<summary>Explanation or extra information can be stored in the notes</summary>
		Public Property [Notes] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [SalesPriceListDetail]
		'''<summary>Customer account Id</summary>
		Public Property [Account] As Guid?
		'''<summary>Customer account name</summary>
		Public Property [AccountName] As String
		'''<summary>ID of the base price. &lt;br&gt;&lt;br&gt; If base price = use the standard sales price, it shows null. &lt;br&gt;&lt;br&gt; If base price = set sales price, it shows ID of the sales price within this volume discount.</summary>
		Public Property [BasePrice] As Guid?
		'''<summary>Amount of the base price. &lt;br&gt;&lt;br&gt; If base price = use the standard sales price, it shows the latest item sales price.&lt;br&gt;&lt;br&gt; If base price = set sales price, it shows the base price which defined in price list.</summary>
		Public Property [BasePriceAmount] As Double
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<summary>User ID of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>Currency</summary>
		Public Property [Currency] As String
		'''<summary>Discount</summary>
		Public Property [Discount] As Double?
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<summary>End date</summary>
		Public Property [EndDate] As DateTime?
		'''<summary>Indicates whether discount or the new price is leading : 1-Discount, 2-New price. &lt;br&gt;&lt;br&gt; Scenario &lt;br&gt;&lt;br&gt; 1. When entry method is Discount and use base price, Discounted price = (1 - SalesPriceListDetails.Discount) * SalesPriceListDetails.BasePriceAmount &lt;br&gt;&lt;br&gt; 2. When entry method is Discount and use Item&apos;s standard sales price, Discounted price = (1 - SalesPriceListDetails.Discount) * SalesItemPrices.Price &lt;br&gt;&lt;br&gt; 3. When entry method is New price, Discounted price = SalesPriceListDetails.NewPrice</summary>
		Public Property [EntryMethod] As Int16
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Item</summary>
		Public Property [Item] As Guid?
		'''<summary>Description of the item</summary>
		Public Property [ItemDescription] As String
		'''<summary>ItemGroup</summary>
		Public Property [ItemGroup] As Guid?
		'''<summary>Default sales unit of the item</summary>
		Public Property [ItemUnit] As String
		'''<summary>Last modified date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<summary>User ID of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Name of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>New price after discount</summary>
		Public Property [NewPrice] As Double?
		'''<summary>Number of the item per unit</summary>
		Public Property [NumberOfItemsPerUnit] As Double?
		'''<summary>Code of the PriceList</summary>
		Public Property [PriceListCode] As String
		'''<summary>Id of the PriceList</summary>
		Public Property [PriceListId] As Guid?
		'''<summary>Quantity</summary>
		Public Property [Quantity] As Double?
		'''<summary>Start date</summary>
		Public Property [StartDate] As DateTime?
		'''<summary>Unit</summary>
		Public Property [Unit] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [ShippingMethod]
		'''<summary>Active</summary>
		Public Property [Active] As Boolean?
		'''<summary>Code of the shipping method</summary>
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
		'''<summary>Description of shipping method</summary>
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
		'''<summary>Notes</summary>
		Public Property [Notes] As String
		'''<summary>Shipping method rates URL</summary>
		Public Property [ShippingRatesURL] As String
		'''<summary>Tracking URL</summary>
		Public Property [TrackingURL] As String
	End Class

End Namespace