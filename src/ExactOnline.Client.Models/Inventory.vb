Namespace Inventory

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [AssemblyOrder]
		'''<summary>Planned date for assembly of the item</summary>
		Public Property [AssemblyDate] As DateTime?
		'''<summary>Description of assembly order</summary>
		Public Property [Description] As String
		'''<summary>Division code</summary>
		Public Property [Division] As Int32
		'''<summary>Quantity of items that have actually been assembled</summary>
		Public Property [FinishedQuantity] As Double
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Reference to item</summary>
		Public Property [Item] As Guid
		'''<summary>Item code</summary>
		Public Property [ItemCode] As String
		'''<summary>Description of item</summary>
		Public Property [ItemDescription] As String
		'''<summary>Notes of the assembly order</summary>
		Public Property [Notes] As String
		'''<summary>Date of the assembly order is initiated</summary>
		Public Property [OrderDate] As DateTime?
		'''<summary>Assembly order number </summary>
		Public Property [OrderNumber] As Int32
		'''<summary>Assembly order status: 20 = Open, 30 = Partial, 50 = Complete</summary>
		Public Property [OrderStatus] As Int32
        '''<summary>Planned quantity of the item to be assembled</summary>
        Public Property [PlannedQuantity] As Double
		'''<summary>Reference to storage location</summary>
		Public Property [StorageLocation] As Guid?
		'''<summary>Storage location code</summary>
		Public Property [StorageLocationCode] As String
		'''<summary>Storage location description</summary>
		Public Property [StorageLocationDescription] As String
		'''<summary>Warehouse</summary>
		Public Property [Warehouse] As Guid?
		'''<summary>Code of Warehouse</summary>
		Public Property [WarehouseCode] As String
		'''<summary>Description of Warehouse</summary>
		Public Property [WarehouseDescription] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [BatchNumber]
		'''<summary>Available quantity of this batch number</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AvailableQuantity] As Double?
		'''<summary>Human readable batch number</summary>
		Public Property [BatchNumber] As String
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
		'''<summary>Expiry date of effective period for batch number</summary>
		Public Property [ExpiryDate] As DateTime?
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Boolean value indicating whether or not the batch number is blocked</summary>
		Public Property [IsBlocked] As Byte?
		'''<summary>Item</summary>
		Public Property [Item] As Guid?
		'''<summary>Item code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemCode] As String
		'''<summary>Description of item</summary>
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
		'''<summary>Remarks</summary>
		Public Property [Remarks] As String
		'''<summary>Total quantity available per location</summary>
		Public Property [StorageLocations] As IEnumerable(Of Models.Inventory.BatchQuantitiesPerLocation)
		'''<summary>Total quantity available per warehouse</summary>
		Public Property [Warehouses] As IEnumerable(Of Models.Inventory.BatchQuantitiesPerWarehouse)
	End Class

	<SupportedActionsSDK(False, False, False, False)>
	<DataServiceKey("BatchNumberId")>
	Public Class [BatchQuantitiesPerLocation]
		Public Property [AvailableQuantity] As Double
		Public Property [BatchNumberId] As Guid
		Public Property [StorageLocation] As Guid?
		Public Property [StorageLocationCode] As String
		Public Property [StorageLocationDescription] As String
		Public Property [Warehouse] As Guid?
		Public Property [WarehouseCode] As String
		Public Property [WarehouseDescription] As String
	End Class

	<SupportedActionsSDK(False, False, False, False)>
	<DataServiceKey("BatchNumberId")>
	Public Class [BatchQuantitiesPerWarehouse]
		Public Property [AvailableQuantity] As Double
		Public Property [BatchNumberId] As Guid
		Public Property [Warehouse] As Guid?
		Public Property [WarehouseCode] As String
		Public Property [WarehouseDescription] As String
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [ItemWarehous]
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<summary>User ID of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>Quantity that is currently on stock, sales/purchase orders excluded</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CurrentStock] As Double?
		'''<summary>This is a default storage location</summary>
		Public Property [DefaultStorageLocation] As Guid?
		'''<summary>Default storage location&apos;s code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DefaultStorageLocationCode] As String
		'''<summary>Default storage location&apos;s description</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DefaultStorageLocationDescription] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Item ID</summary>
		Public Property [Item] As Guid?
		'''<summary>Code of item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemCode] As String
		'''<summary>Description of item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDescription] As String
		'''<summary>Indicates if fractions (for example 0.35) are allowed for quantities of this item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemIsFractionAllowedItem] As Boolean?
		'''<summary>The standard unit code of this item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemUnit] As String
		'''<summary>Description of item&apos;s unit</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemUnitDescription] As String
		'''<summary>Maximum number of stock could enter warehouse</summary>
		Public Property [MaximumStock] As Double?
		'''<summary>Last modified date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<summary>User ID of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Name of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>The quantity still open to be received based on i.e. purchase orders and assembly orders.</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PlannedStockIn] As Double?
		'''<summary>The quantity still open to be delivered based on i.e. sales orders and assembly orders.</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PlannedStockOut] As Double?
		'''<summary>URL of the stock planning details of this record</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PlanningDetailsUrl] As String
		'''<summary>The quantity of stock projected given all planned future stock changes</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectedStock] As Double?
		'''<summary>Reorder point when stock depletes</summary>
		Public Property [ReorderPoint] As Double?
		'''<summary>The quantity in a back to back order process which is already received from the purchase order, but not yet delivered for the sales order.</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ReservedStock] As Double?
		'''<summary>Safety stock</summary>
		Public Property [SafetyStock] As Double?
		'''<summary>URL pointing to details of which storage locations this ItemWarehouse&apos;s stock is located</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StorageLocationUrl] As String
		'''<summary>Warehouse ID</summary>
		Public Property [Warehouse] As Guid?
		'''<summary>Code of warehouse</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseCode] As String
		'''<summary>Description of warehouse</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseDescription] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("Item")>
	Public Class [ItemWarehousePlanningDetail]
		'''<summary>ID of item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Item] As Guid
		'''<summary>Code of item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemCode] As String
		'''<summary>Description of item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDescription] As String
		'''<summary>Date which quantity in stock is planned to change</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PlannedDate] As DateTime
		'''<summary>Amount by which quantity in stock is planned to change</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PlannedQuantity] As Double
		'''<summary>Human readable description of the PlanningSource (translated to user&apos;s language) - Examples: Purchase Order, Sales Order, Shop Order, etc.</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PlanningSourceDescription] As String
		'''<summary>ID of the PlanningSource</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PlanningSourceID] As Guid?
		'''<summary>Line number of the PlanningSource if the PlanningSourceType supports line numbers</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PlanningSourceLineNumber] As Int32?
		'''<summary>Human readable number of the PlanningSource - Examples: Shop order number &apos;201600001&apos; or Sales order number &apos;2016020001&apos;</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PlanningSourceNumber] As Int32?
		'''<summary>REST API URL of this specific PlanningSource and PlanningSourceID (Assembly orders and warehouse transfers not supported over REST)</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PlanningSourceUrl] As String
		'''<summary>Type of the PlanningSource - 120=GoodsDelivery, 124=WarehouseTransferDelivery, 130=GoodsReceipt, 134=WarehouseTransferReceipt, 140=ShopOrderStockReceipt, 147=ShopOrderByProductReceipt, 150=ShopOrderRequirement, 160=AssemblyOrderReceipt, 165=AssemblyOrderIssue</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PlanningType] As Int32?
		'''<summary>Human readable description of the PlanningSourceType (translated to user&apos;s language) - Examples: &apos;Shop order stock receipt&apos; or &apos;Goods delivery&apos;</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PlanningTypeDescription] As String
		'''<summary>ID of warehouse</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Warehouse] As Guid
		'''<summary>Code of warehouse</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseCode] As String
		'''<summary>Description of warehouse</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseDescription] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [ItemWarehouseStorageLocation]
		'''<summary>Uniquely identifies the item, warehouse, storage location combination</summary>
		Public Property [ID] As Guid
		'''<summary>Does the item allow partial quantities (1.75 meters)</summary>
		Public Property [IsFractionAllowedItem] As Byte
		'''<summary>Item</summary>
		Public Property [Item] As Guid
		'''<summary>Code of the item of this stock quantity</summary>
		Public Property [ItemCode] As String
		'''<summary>Description of the item of this stock quantity</summary>
		Public Property [ItemDescription] As String
		'''<summary>Unit of the item</summary>
		Public Property [ItemUnit] As String
		'''<summary>Unit description of the item</summary>
		Public Property [ItemUnitDescription] As String
		'''<summary>Number of items in stock</summary>
		Public Property [Stock] As Double?
		'''<summary>Storage location of this stock</summary>
		Public Property [StorageLocation] As Guid?
		'''<summary>Code of the storage location of this stock quantity</summary>
		Public Property [StorageLocationCode] As String
		'''<summary>Description of the storage location of this stock quantity</summary>
		Public Property [StorageLocationDescription] As String
		'''<summary>ID of Warehouse</summary>
		Public Property [Warehouse] As Guid?
		'''<summary>Code of the warehouse of this stock quantity</summary>
		Public Property [WarehouseCode] As String
		'''<summary>Description of the warehouse of this stock quantity</summary>
		Public Property [WarehouseDescription] As String
	End Class

	<SupportedActionsSDK(True, False, False, False)>
	<DataServiceKey("StockCountID")>
	Public Class [ProcessStockCount]
		'''<summary>Division code</summary>
		Public Property [Division] As Int32?
		'''<summary>Contains the error message if an error occurred during the processing of the stock count.</summary>
		Public Property [ErrorMessage] As String
		'''<summary>Primary key</summary>
		Public Property [StockCountID] As Guid
		'''<summary>Contains information if the stock count was successfully processed.</summary>
		Public Property [SuccessMessage] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [SerialNumber]
		'''<summary>Availability of this serial number</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Available] As Byte?
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
		'''<summary>End date of effective period for serial number</summary>
		Public Property [EndDate] As DateTime?
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Boolean value indicating whether or not the serial number is blocked</summary>
		Public Property [IsBlocked] As Byte?
		'''<summary>Item</summary>
		Public Property [Item] As Guid?
		'''<summary>Item code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemCode] As String
		'''<summary>Description of item</summary>
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
		'''<summary>Remarks</summary>
		Public Property [Remarks] As String
		'''<summary>Human readable serial number</summary>
		Public Property [SerialNumber] As String
		'''<summary>Start date of effective period for serial number</summary>
		Public Property [StartDate] As DateTime?
		'''<summary>ID of storage location where serial number is available</summary>
		Public Property [StorageLocation] As Guid?
		'''<summary>Code of storage location where serial number is available</summary>
		Public Property [StorageLocationCode] As String
		'''<summary>Description of storage location where serial number is available</summary>
		Public Property [StorageLocationDescription] As String
		'''<summary>ID of warehouse where serial number is available</summary>
		Public Property [Warehouse] As Guid?
		'''<summary>Code of warehouse where serial number is available</summary>
		Public Property [WarehouseCode] As String
		'''<summary>Description of warehouse where serial number is available</summary>
		Public Property [WarehouseDescription] As String
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [StockBatchNumber]
		'''<summary>Human readable batch number</summary>
		Public Property [BatchNumber] As String
		'''<summary>Batch number ID</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [BatchNumberID] As Guid?
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
		'''<summary>ID representing a group of batch numbers being reserved for use in a subsequent stock transaction</summary>
		Public Property [DraftStockTransactionID] As Guid?
		'''<summary>End date of effective period for batch number</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [EndDate] As DateTime?
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Boolean value indicating whether or not the batch number is blocked</summary>
		Public Property [IsBlocked] As Byte?
		'''<summary>Boolean value indicating if this batch number is being reserved</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsDraft] As Byte?
		'''<summary>Item</summary>
		Public Property [Item] As Guid?
		'''<summary>Item code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemCode] As String
		'''<summary>Description of item</summary>
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
		'''<summary>Quantity of this batch number entering or leaving inventory</summary>
		Public Property [Quantity] As Double?
		'''<summary>Remarks</summary>
		Public Property [Remarks] As String
		'''<summary>ID of stock count entry</summary>
		Public Property [StockCountLine] As Guid?
		'''<summary>ID of the stock transaction in which this batch number was used</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StockTransactionID] As Guid?
		'''<summary>Type of stock transaction associated with this batch number.&lt;br&gt;&lt;br&gt;Available values:&lt;br&gt;10 = Opening balance&lt;br&gt;120 = Goods delivery&lt;br&gt;121 = Sales return&lt;br&gt;122 = Stock out (Drop shipment)&lt;br&gt;123 = Stock in (Drop shipment return)&lt;br&gt;124 = Warehouse transfer delivery&lt;br&gt;125 = Location Transfer Delivery&lt;br&gt;130 = Goods receipt&lt;br&gt;131 = Purchase return&lt;br&gt;132 = Stock in (Drop shipment)&lt;br&gt;133 = Stock out (Drop shipment return)&lt;br&gt;134 = Warehouse transfer receipt&lt;br&gt;135 = Location Transfer Receipt&lt;br&gt;140 = Shop order stock receipt&lt;br&gt;141 = Shop order stock reversal&lt;br&gt;147 = Shop order by-product receipt&lt;br&gt;148 = Shop order by-product reversal&lt;br&gt;150 = Requirement issue&lt;br&gt;151 = Requirement reversal&lt;br&gt;155 = Subcontract issue&lt;br&gt;156 = Subcontract return&lt;br&gt;160 = Receipt (Assembly)&lt;br&gt;161 = Return receipt (Disassembly)&lt;br&gt;165 = Issue (Assembly)&lt;br&gt;166 = Return issue (Disassembly)&lt;br&gt;180 = Stock revaluation&lt;br&gt;181 = Financial revaluation&lt;br&gt;195 = Stock count&lt;br&gt;196 = Adjust stock - out&lt;br&gt;197 = Adjust stock - in&lt;br&gt;</summary>
		Public Property [StockTransactionType] As Int32?
		'''<summary>Storage location which this batch number is entering or leaving</summary>
		Public Property [StorageLocation] As Guid?
		'''<summary>Code of the storage location which this batch number is entering or leaving</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StorageLocationCode] As String
		'''<summary>Description of the storage location which this batch number is entering or leaving</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StorageLocationDescription] As String
		'''<summary>Warehouse which this batch number is entering or leaving</summary>
		Public Property [Warehouse] As Guid?
		'''<summary>Code of the warehouse which this batch number is entering or leaving</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseCode] As String
		'''<summary>Description of the warehouse which this batch number is entering or leaving</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseDescription] As String
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("StockCountID")>
	Public Class [StockCount]
		'''<summary>Stock count user</summary>
		Public Property [CountedBy] As Guid?
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<summary>User ID of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>Description of the stock count</summary>
		Public Property [Description] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<summary>Entry number of the stock transaction</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [EntryNumber] As Int32?
		'''<summary>Last modified date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<summary>User ID of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Name of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>Offset GL account of inventory</summary>
		Public Property [OffsetGLInventory] As Guid?
		'''<summary>GLAccount code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [OffsetGLInventoryCode] As String
		'''<summary>GLAccount description</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [OffsetGLInventoryDescription] As String
		'''<summary>Source of stock count entry: 1-Manual entry, 2-Import, 3-Stock count, 4-Web service</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Source] As Int16?
		'''<summary>Stock count status: 12-Draft, 21-Processed</summary>
		Public Property [Status] As Int16?
		'''<summary>Stock count date</summary>
		Public Property [StockCountDate] As DateTime?
		'''<summary>Primary key</summary>
		Public Property [StockCountID] As Guid
		'''<summary>Collection of stock count lines</summary>
		Public Property [StockCountLines] As IEnumerable(Of Models.Inventory.StockCountLine)
		'''<summary>Human readable id of the stock count</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StockCountNumber] As Int32?
		'''<summary>Warehouse</summary>
		Public Property [Warehouse] As Guid?
		'''<summary>Code of Warehouse</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseCode] As String
		'''<summary>Description of Warehouse</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseDescription] As String
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [StockCountLine]
		'''<summary>The collection of batch numbers that belong to the items included in this stock count</summary>
		Public Property [BatchNumbers] As IEnumerable(Of Models.Inventory.StockBatchNumber)
		'''<summary>Cost price of the item that is used to create the stock count</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CostPrice] As Double?
		'''<summary>Counted by</summary>
		Public Property [CountedBy] As Guid?
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
		'''<summary>Reference to the item for which the stock is counted</summary>
		Public Property [Item] As Guid?
		'''<summary>Item code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemCode] As String
		'''<summary>Current standard/actual item cost price</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemCostPrice] As Double?
		'''<summary>Description of item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDescription] As String
		'''<summary>Indicates if fractional quantities of the item can be used, for example quantity = 0.4</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDivisable] As Boolean?
		'''<summary>Line number</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [LineNumber] As Int32?
		'''<summary>Last modified date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<summary>User ID of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Name of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>The difference between the current quantity in stock and the new quantity in stock. For example specify -1 for this field to correct the quantity if one item in stock is broken.</summary>
		Public Property [QuantityDifference] As Double?
		'''<summary>The current quantity available in stock</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [QuantityInStock] As Double?
		'''<summary>The new quantity in stock. Use this field to correct the quantity when the items in stock are physically counted.</summary>
		Public Property [QuantityNew] As Double?
		'''<summary>The collection of serial numbers that belong to the items included in this stock count</summary>
		Public Property [SerialNumbers] As IEnumerable(Of Models.Inventory.StockSerialNumber)
		'''<summary>Identifies the stock count. All the lines of a stock count have the same StockCountID</summary>
		Public Property [StockCountID] As Guid?
		'''<summary>Stock item&apos;s unit description</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StockKeepingUnit] As String
		'''<summary>This property is package specific (Stock count can have multiple lines for the same item only if it is for multiple storage locations).</summary>
		Public Property [StorageLocation] As Guid?
		'''<summary>Storage location code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StorageLocationCode] As String
		'''<summary>Storage location description</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StorageLocationDescription] As String
	End Class

	<SupportedActionsSDK(True, True, False, True)>
	<DataServiceKey("ID")>
	Public Class [StockSerialNumber]
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
		'''<summary>ID representing a group of serial numbers being reserved for use in a subsequent stock transaction</summary>
		Public Property [DraftStockTransactionID] As Guid?
		'''<summary>End date of effective period for serial number</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [EndDate] As DateTime?
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Boolean value indicating whether or not the serial number is blocked</summary>
		Public Property [IsBlocked] As Byte?
		'''<summary>Boolean value indicating if this serial number is being reserved</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsDraft] As Byte?
		'''<summary>Item</summary>
		Public Property [Item] As Guid?
		'''<summary>Item code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemCode] As String
		'''<summary>Description of item</summary>
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
		'''<summary>Remarks</summary>
		Public Property [Remarks] As String
		'''<summary>Human readable serial number</summary>
		Public Property [SerialNumber] As String
		'''<summary>Serial number ID</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SerialNumberID] As Guid?
		'''<summary>Start date of effective period for serial number</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StartDate] As DateTime?
		'''<summary>ID of stock count entry</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StockCountLine] As Guid?
		'''<summary>ID of the stock transaction in which this serial number was used</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StockTransactionID] As Guid?
		'''<summary>Type of stock transaction associated with this serial number.&lt;br&gt;&lt;br&gt;Available values:&lt;br&gt;10 = Opening balance&lt;br&gt;120 = Goods delivery&lt;br&gt;121 = Sales return&lt;br&gt;122 = Stock out (Drop shipment)&lt;br&gt;123 = Stock in (Drop shipment return)&lt;br&gt;124 = Warehouse transfer delivery&lt;br&gt;125 = Location Transfer Delivery&lt;br&gt;130 = Goods receipt&lt;br&gt;131 = Purchase return&lt;br&gt;132 = Stock in (Drop shipment)&lt;br&gt;133 = Stock out (Drop shipment return)&lt;br&gt;134 = Warehouse transfer receipt&lt;br&gt;135 = Location Transfer Receipt&lt;br&gt;140 = Shop order stock receipt&lt;br&gt;141 = Shop order stock reversal&lt;br&gt;147 = Shop order by-product receipt&lt;br&gt;148 = Shop order by-product reversal&lt;br&gt;150 = Requirement issue&lt;br&gt;151 = Requirement reversal&lt;br&gt;155 = Subcontract issue&lt;br&gt;156 = Subcontract return&lt;br&gt;160 = Receipt (Assembly)&lt;br&gt;161 = Return receipt (Disassembly)&lt;br&gt;165 = Issue (Assembly)&lt;br&gt;166 = Return issue (Disassembly)&lt;br&gt;180 = Stock revaluation&lt;br&gt;181 = Financial revaluation&lt;br&gt;195 = Stock count&lt;br&gt;196 = Adjust stock - out&lt;br&gt;197 = Adjust stock - in&lt;br&gt;</summary>
		Public Property [StockTransactionType] As Int32?
		'''<summary>Storage location which this serial number is entering or leaving</summary>
		Public Property [StorageLocation] As Guid?
		'''<summary>Code of the storage location which this serial number is entering or leaving</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StorageLocationCode] As String
		'''<summary>Description of the storage location which this serial number is entering or leaving</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StorageLocationDescription] As String
		'''<summary>Warehouse which this serial number is entering or leaving</summary>
		Public Property [Warehouse] As Guid?
		'''<summary>Code of the warehouse which this serial number is entering or leaving</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseCode] As String
		'''<summary>Description of the warehouse which this serial number is entering or leaving</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseDescription] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [StorageLocation]
		'''<summary>Code of the storage location</summary>
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
		'''<summary>Description of the storage location</summary>
		Public Property [Description] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Indicates if this is the main storage location. There&apos;s always exactly one main storage location per warehouse</summary>
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
		'''<summary>Warehouse ID</summary>
		Public Property [Warehouse] As Guid?
		'''<summary>Warehouse Code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseCode] As String
		'''<summary>Description of warehouse</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseDescription] As String
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [Warehouse]
		'''<summary>Code of the warehouse</summary>
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
		'''<summary>The default storage location of this warehouse. Warehouses can have a default storage location in packages Manufacturing Premium or Wholesale Premium</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DefaultStorageLocation] As Guid?
		'''<summary>Default storage location&apos;s code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DefaultStorageLocationCode] As String
		'''<summary>Default storage location&apos;s description</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DefaultStorageLocationDescription] As String
		'''<summary>The description of the warehouse</summary>
		Public Property [Description] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<summary>Email address</summary>
		Public Property [EMail] As String
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Indicates if this is the main warehouse. There&apos;s always exactly one main warehouse per administration</summary>
		Public Property [Main] As Byte
		'''<summary>User reponsible for the warehouse</summary>
		Public Property [ManagerUser] As Guid?
		'''<summary>Last modified date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<summary>User ID of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Name of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>Indicates if this warehouse is using storage locations. The storage locations will not be removed when when this is deactivated</summary>
		Public Property [UseStorageLocations] As Byte
	End Class

End Namespace