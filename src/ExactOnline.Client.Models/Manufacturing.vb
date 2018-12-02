Namespace Manufacturing

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [BillOfMaterialMaterial]
		'''<summary>Item average cost available when average cost method is used</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AverageCost] As Double?
		'''<summary>Indicates if this is a backflush item</summary>
		Public Property [Backflush] As Byte?
		'''<summary>Calculator type</summary>
		Public Property [CalculatorType] As Int32?
		'''<summary>Cost batch</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CostBatch] As Double?
		'''<summary>Cost center</summary>
		Public Property [CostCenter] As String
		'''<summary>Cost center description</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CostCenterDescription] As String
		'''<summary>Cost unit</summary>
		Public Property [CostUnit] As String
		'''<summary>Cost unit description</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CostUnitDescription] As String
		'''<summary>Name of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>Description of the material</summary>
		Public Property [Description] As String
		'''<summary>Detail drawing reference</summary>
		Public Property [DetailDrawing] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<summary>Primary key</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ID] As Guid
		'''<summary>Key of item version</summary>
		Public Property [ItemVersion] As Guid?
		'''<summary>Line number</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [LineNumber] As Int32?
		'''<summary>Net weight</summary>
		Public Property [NetWeight] As Double?
		'''<summary>Net weight unit of measure</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [NetWeightUnit] As String
		'''<summary>Notes</summary>
		Public Property [Notes] As String
		'''<summary>Key of part item</summary>
		Public Property [PartItem] As Guid?
		'''<summary>Part item code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PartItemCode] As String
		'''<summary>Item standard cost available when standard cost method is used</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PartItemCostPriceStandard] As Double?
		'''<summary>Part item description</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PartItemDescription] As String
		'''<summary>Quantity</summary>
		Public Property [Quantity] As Double?
		'''<summary>Quantity batch</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [QuantityBatch] As Double?
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [syscreated] As DateTime?
		'''<summary>User ID of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [syscreator] As Guid?
		'''<summary>Modified date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [sysmodified] As DateTime?
		'''<summary>User ID of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [sysmodifier] As Guid?
		'''<summary>Material type 1 indicates material, 2 indicates byproduct</summary>
		Public Property [Type] As Int32?
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [BillOfMaterialVersion]
		'''<summary>Batch Quantity of Item Version</summary>
		Public Property [BatchQuantity] As Double?
		'''<summary>Cad drawing URL</summary>
		Public Property [CadDrawingUrl] As String
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
		'''<summary>Order lead days for item</summary>
		Public Property [OrderLeadDays] As Int32?
		'''<summary>Production lead time in days of Item version</summary>
		Public Property [ProductionLeadDays] As Int32?
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
		'''<summary>Version date</summary>
		Public Property [VersionDate] As DateTime?
		'''<summary>Version Number</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VersionNumber] As Int32?
	End Class

	<SupportedActionsSDK(True, True, False, False)>
	<DataServiceKey("StockTransactionId")>
	Public Class [ByProductReceipt]
		'''<summary>ID of creating user</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatedBy] As Guid?
		'''<summary>Name of the creating user</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatedByFullName] As String
		'''<summary>Date this by-product finish was created</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatedDate] As DateTime?
		'''<summary>Serial or batch numbers are reserved prior to a POST to ByProductReceipts. This DraftStockTransactionID represents the group of serial or batch numbers to be used in this transaction.</summary>
		Public Property [DraftStockTransactionID] As Guid?
		'''<summary>Indicates if this ByProductReceipt has a quantity eligible to be reversed via ByProductReversals</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [HasReversibleQuantity] As Boolean
		'''<summary>Boolean indicating if this by-product finish was the result of shop order backflushing</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsBackflush] As Boolean
		'''<summary>Does the ByProductReceipt&apos;s item use batch numbers</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsBatch] As Byte?
		'''<summary>Indicates if fractions (for example 0.35) are allowed for quantities of the ByProductReceipt&apos;s item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsFractionAllowedItem] As Byte?
		'''<summary>Does the ByProductReceipt&apos;s item use serial numbers</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsSerial] As Byte?
		'''<summary>ID of by-product item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Item] As Guid?
		'''<summary>Code of by-product item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemCode] As String
		'''<summary>Description of by-product item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDescription] As String
		'''<summary>Picture url of by-product item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemPictureUrl] As String
		'''<summary>Quantity of this by-product finish</summary>
		Public Property [Quantity] As Double?
		'''<summary>ID of shop order, which produced the by-product</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ShopOrder] As Guid?
		'''<summary>ID of the shop order material plan for this by-product</summary>
		Public Property [ShopOrderMaterialPlan] As Guid?
		'''<summary>Number of shop order, which produced the by-product</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ShopOrderNumber] As Int32?
		'''<summary>ID of stock transaction related to this by-product finish</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StockTransactionId] As Guid
		'''<summary>ID of storage location finished to</summary>
		Public Property [StorageLocation] As Guid?
		'''<summary>Code of storage location finished to</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StorageLocationCode] As String
		'''<summary>Description of storage location finished to</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StorageLocationDescription] As String
		'''<summary>Effective date of this by-product finish</summary>
		Public Property [TransactionDate] As DateTime?
		'''<summary>Unit of measurement abbreviation of by-product item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Unit] As String
		'''<summary>Unit of measurement of by-product item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [UnitDescription] As String
		'''<summary>ID of warehouse finished to</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Warehouse] As Guid?
		'''<summary>Code of warehouse finished to</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseCode] As String
		'''<summary>Description of warehouse finished to</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseDescription] As String
	End Class

	<SupportedActionsSDK(True, True, False, False)>
	<DataServiceKey("ReversalStockTransactionId")>
	Public Class [ByProductReversal]
		'''<summary>ID of creating user</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatedBy] As Guid?
		'''<summary>Name of the creating user</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatedByFullName] As String
		'''<summary>Date of this reversal</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatedDate] As DateTime?
		'''<summary>Boolean indicating if this reversal was the result of shop order backflushing, processed during a ShopOrderReversal</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsBackflush] As Boolean
		'''<summary>Does the ByProductReversal&apos;s item use batch numbers</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsBatch] As Byte?
		'''<summary>Indicates if fractions (for example 0.35) are allowed for quantities of the ByProductReversal&apos;s item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsFractionAllowedItem] As Byte?
		'''<summary>Does the ByProductReversal&apos;s item use serial numbers</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsSerial] As Byte?
		'''<summary>Item reversed</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Item] As Guid?
		'''<summary>Code of item reversed</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemCode] As String
		'''<summary>Description of item reversed</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDescription] As String
		'''<summary>Picture url of by-product item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemPictureUrl] As String
		'''<summary>Notes associated with this reversal</summary>
		Public Property [Note] As String
		'''<summary>ID of the original stock transaction, which was reversed</summary>
		Public Property [OriginalStockTransactionId] As Guid?
		'''<summary>Quantity reversed</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Quantity] As Double?
		'''<summary>ID of stock transaction related to this ByProductReversal</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ReversalStockTransactionId] As Guid
		'''<summary>Shop order being reversed to</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ShopOrder] As Guid?
		'''<summary>ID of shop order material plan</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ShopOrderMaterialPlan] As Guid?
		'''<summary>Number of shop order being reversed to</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ShopOrderNumber] As Int32?
		'''<summary>ID of storage location reversed from</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StorageLocation] As Guid?
		'''<summary>Code of storage location reversed from</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StorageLocationCode] As String
		'''<summary>Description of storage location reversed from</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StorageLocationDescription] As String
		'''<summary>Effective date of this ByProductReversal</summary>
		Public Property [TransactionDate] As DateTime?
		'''<summary>Unit of measurement abbreviation of item reversed</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Unit] As String
		'''<summary>Unit of measurement of item reversed</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [UnitDescription] As String
		'''<summary>ID of warehouse reversed from</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Warehouse] As Guid?
		'''<summary>Code of warehouse reversed from</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseCode] As String
		'''<summary>Description of warehouse reversed from</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseDescription] As String
	End Class

	<SupportedActionsSDK(True, True, False, False)>
	<DataServiceKey("StockTransactionId")>
	Public Class [MaterialIssue]
		'''<summary>ID of creating user</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatedBy] As Guid?
		'''<summary>Name of the creating user</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatedByFullName] As String
		'''<summary>Date this material issue was created</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatedDate] As DateTime?
		'''<summary>Serial or batch numbers are reserved prior to a POST to MaterialIssues. This DraftStockTransactionID represents the group of serial or batch numbers to be used in this transaction.</summary>
		Public Property [DraftStockTransactionID] As Guid?
		'''<summary>Indicates if this MaterialIssue has a quantity eligible to be reversed via MaterialReversals</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [HasReversibleQuantity] As Boolean
		'''<summary>Boolean indicating if this material issue was the result of shop order backflushing</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsBackflush] As Byte?
		'''<summary>Does the material issue&apos;s item use batch numbers</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsBatch] As Byte?
		'''<summary>Indicates if fractions (for example 0.35) are allowed for quantities of the material issue&apos;s item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsFractionAllowedItem] As Byte?
		'''<summary>Boolean indicating if this material issue was an issue to a parent shop order</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsIssueFromChild] As Byte?
		'''<summary>Does the material issue&apos;s item use serial numbers</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsSerial] As Byte?
		'''<summary>Item issued</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Item] As Guid?
		'''<summary>Code of item issued</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemCode] As String
		'''<summary>Description of item issued</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDescription] As String
		'''<summary>Picture url of item issued</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemPictureUrl] As String
		'''<summary>Notes logged with this material issue</summary>
		Public Property [Note] As String
		'''<summary>Quantity of this material issue</summary>
		Public Property [Quantity] As Double?
		'''<summary>If this transaction was part of a SubOrderReceipt, this ID is the related ShopOrderReceipt.StockTransactionID.</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [RelatedStockTransaction] As Guid?
		'''<summary>ID of shop order issued to</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ShopOrder] As Guid?
		'''<summary>ID of shop order material plan</summary>
		Public Property [ShopOrderMaterialPlan] As Guid?
		'''<summary>Number of shop order issued to</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ShopOrderNumber] As Int32?
		'''<summary>ID of stock transaction related to this material issue</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StockTransactionId] As Guid
		'''<summary>ID of storage location issued from</summary>
		Public Property [StorageLocation] As Guid?
		'''<summary>Code of storage location issued from</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StorageLocationCode] As String
		'''<summary>Description of storage location issued from</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StorageLocationDescription] As String
		'''<summary>Effective date of this material issue</summary>
		Public Property [TransactionDate] As DateTime?
		'''<summary>Unit of measurement abbreviation of item issued</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Unit] As String
		'''<summary>Unit of measurement of item issued</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [UnitDescription] As String
		'''<summary>ID of warehouse issued from</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Warehouse] As Guid?
		'''<summary>Code of warehouse issued from</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseCode] As String
		'''<summary>Description of warehouse issued from</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseDescription] As String
	End Class

	<SupportedActionsSDK(True, True, False, False)>
	<DataServiceKey("ReversalStockTransactionId")>
	Public Class [MaterialReversal]
		'''<summary>ID of creating user</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatedBy] As Guid?
		'''<summary>Name of the creating user</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatedByFullName] As String
		'''<summary>Date this reversal was created</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatedDate] As DateTime?
		'''<summary>Boolean indicating if this reversal was the result of shop order backflushing, processed during a ShopOrderReversal</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsBackflush] As Boolean
		'''<summary>Does the issue reversal&apos;s item use batch numbers</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsBatch] As Byte?
		'''<summary>Indicates if fractions (for example 0.35) are allowed for quantities of the material reversal&apos;s item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsFractionAllowedItem] As Byte?
		'''<summary>Does the issue reversal&apos;s item use serial numbers</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsSerial] As Byte?
		'''<summary>Item reversed</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Item] As Guid?
		'''<summary>Code of item reversed</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemCode] As String
		'''<summary>Description of item reversed</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDescription] As String
		'''<summary>Picture url of item issued</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemPictureUrl] As String
		'''<summary>Notes logged with this reversal</summary>
		Public Property [Note] As String
		'''<summary>ID of the original stock transaction, which was reversed</summary>
		Public Property [OriginalStockTransactionId] As Guid?
		'''<summary>Quantity of this reversal</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Quantity] As Double?
		'''<summary>ID of stock transaction related to this material issue</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ReversalStockTransactionId] As Guid
		'''<summary>ID of shop order reversed from</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ShopOrder] As Guid?
		'''<summary>ID of shop order material plan</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ShopOrderMaterialPlan] As Guid?
		'''<summary>Number of shop order reversed from</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ShopOrderNumber] As Int32?
		'''<summary>ID of storage location reversed to</summary>
		Public Property [StorageLocation] As Guid?
		'''<summary>Code of storage location reversed to</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StorageLocationCode] As String
		'''<summary>Description of storage location reversed to</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StorageLocationDescription] As String
		'''<summary>Effective date of this reversal</summary>
		Public Property [TransactionDate] As DateTime?
		'''<summary>Unit of measurement abbreviation of item reversed</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Unit] As String
		'''<summary>Unit of measurement of item reversed</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [UnitDescription] As String
		'''<summary>ID of warehouse reversed to</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Warehouse] As Guid?
		'''<summary>Code of warehouse reversed to</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseCode] As String
		'''<summary>Description of warehouse reversed to</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseDescription] As String
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [Operation]
		'''<summary>Code of the operation</summary>
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
		'''<summary>Description of the operation</summary>
		Public Property [Description] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<summary>Indicates if the operation has suppliers associated with it</summary>
		Public Property [HasSuppliers] As Byte?
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Reference to Items table</summary>
		Public Property [Item] As Guid?
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
		'''<summary>Extra remarks</summary>
		Public Property [Notes] As String
		'''<summary>Search code for the operation</summary>
		Public Property [Searchcode] As String
		'''<summary>Status of the operation</summary>
		Public Property [Status] As Int32?
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [OperationResource]
		'''<summary>Reference to Accounts</summary>
		Public Property [Account] As Guid?
		'''<summary>Attended percentage</summary>
		Public Property [AttendedPercentage] As Double?
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<summary>User ID of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>Reference to Currencies</summary>
		Public Property [Currency] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<summary>Efficiency percentage</summary>
		Public Property [EfficiencyPercentage] As Double?
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Indicates if this is the primary operation of the workcenter</summary>
		Public Property [IsPrimary] As Byte?
		'''<summary>Last modified date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<summary>User ID of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Name of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>Reference to Operations</summary>
		Public Property [Operation] As Guid?
		'''<summary>Description of Operation</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [OperationDescription] As String
		'''<summary>Lead days from purchase</summary>
		Public Property [PurchaseLeadDays] As Int32?
		'''<summary>Unit of purchased item from supplier</summary>
		Public Property [PurchaseUnit] As String
		'''<summary>VAT code used for purchased item from supplier</summary>
		Public Property [PurchaseVATCode] As String
		'''<summary>Used in conjuction with RunMethod and EfficiencyPercentage to determine PlannedRunHours</summary>
		Public Property [Run] As Double?
		'''<summary>Reference to OperationRunMethods</summary>
		Public Property [RunMethod] As Int32?
		'''<summary>Used in conjunction with SetupCount and SetupUnit to determine PlannedSetupHours</summary>
		Public Property [Setup] As Double?
		'''<summary>Reference to TimeUnits</summary>
		Public Property [SetupUnit] As String
		'''<summary>Reference to RoutingStepTypes</summary>
		Public Property [Type] As Int32?
		'''<summary>Reference to Workcenter</summary>
		Public Property [Workcenter] As Guid?
		'''<summary>Description of Workcenter</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WorkcenterDescription] As String
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [ProductionArea]
		'''<summary>Code of the production area group</summary>
		Public Property [Code] As String
		'''<summary>Reference to Cost center</summary>
		Public Property [Costcenter] As String
		'''<summary>Description of Costcenter</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CostcenterDescription] As String
		'''<summary>Reference to Cost unit</summary>
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
		'''<summary>Description of the production area</summary>
		Public Property [Description] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Indicates if this is the default production area. This will be used when creating a new production area</summary>
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
		'''<summary>Production area notes</summary>
		Public Property [Notes] As String
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [ShopOrder]
		'''<summary>URL to CAD Drawing Specified on Manufacturing Bill of Material</summary>
		Public Property [CADDrawingURL] As String
		'''<summary>The cost center linked to the shop order</summary>
		Public Property [Costcenter] As String
		'''<summary>Description of Costcenter</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CostcenterDescription] As String
		'''<summary>The cost unit linked to the shop order</summary>
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
		'''<summary>Description of the shop order</summary>
		Public Property [Description] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<summary>Date on which the shop order was placed</summary>
		Public Property [EntryDate] As DateTime?
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Does the material plan&apos;s item use batch numbers</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsBatch] As Byte
		'''<summary>Indicates if fractions (for example 0.35) are allowed for quantities of the material plan&apos;s item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsFractionAllowedItem] As Byte
		'''<summary>Indicator that Shop order is in planning</summary>
		Public Property [IsInPlanning] As Byte
		'''<summary>Indicator if the Shop order is on hold</summary>
		Public Property [IsOnHold] As Byte
		'''<summary>Indicator that the Shop order has been released to production</summary>
		Public Property [IsReleased] As Byte
		'''<summary>Does the material plan&apos;s item use serial numbers</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsSerial] As Byte
		'''<summary>Reference to the item</summary>
		Public Property [Item] As Guid?
		'''<summary>Code of the item created by this shop order</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemCode] As String
		'''<summary>Description of the item created by this shop order</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDescription] As String
		'''<summary>URL of the item created by this shop order</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemPictureUrl] As String
		'''<summary>Reference to ItemVersion</summary>
		Public Property [ItemVersion] As Guid?
		'''<summary>Description of Item Version</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemVersionDescription] As String
		'''<summary>Last modified date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<summary>User ID of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Name of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>Notes - only viewed internally</summary>
		Public Property [Notes] As String
		'''<summary>Planned end date of this shop order</summary>
		Public Property [PlannedDate] As DateTime?
		'''<summary>Planned quantity</summary>
		Public Property [PlannedQuantity] As Double?
		'''<summary>Planned start date of this shop order</summary>
		Public Property [PlannedStartDate] As DateTime?
		'''<summary>Produced quantity</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProducedQuantity] As Double?
		'''<summary>Production lead days</summary>
		Public Property [ProductionLeadDays] As Int32
		'''<summary>Reference to Project</summary>
		Public Property [Project] As Guid?
		'''<summary>Description of Project</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectDescription] As String
		'''<summary>Quantity ready to ship</summary>
		Public Property [ReadyToShipQuantity] As Double?
		'''<summary>Number of sales orders linked to this shop order</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SalesOrderLineCount] As Int32
		'''<summary>Collection of Sales order lines</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SalesOrderLines] As IEnumerable(Of Models.SalesOrder.SalesOrderLine)
		'''<summary>Number of shop order by-product plans, which are backflushed, for this shop order</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ShopOrderByProductPlanBackflushCount] As Int32
		'''<summary>Number of shop order by-product plans for this shop order</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ShopOrderByProductPlanCount] As Int32
		'''<summary>Shop order main</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ShopOrderMain] As Guid?
		'''<summary>Shop order main number</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ShopOrderMainNumber] As Int32?
		'''<summary>Number of shop order material plans, which are backflushed, for this shop order</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ShopOrderMaterialPlanBackflushCount] As Int32
		'''<summary>Number of shop order material plans for this shop order</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ShopOrderMaterialPlanCount] As Int32
		'''<summary>Collection of Shop order Material plans</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ShopOrderMaterialPlans] As IEnumerable(Of Models.Manufacturing.ShopOrderMaterialPlan)
		'''<summary>Unique number to indentify the shop order</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ShopOrderNumber] As Int32?
		'''<summary>Unique number to indentify the shop order (as a string to allow OData filtering, e.g. $filter=substringof(&apos;123&apos;,ShopOrderNumberString) eq true</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ShopOrderNumberString] As String
		'''<summary>Shop order parent</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ShopOrderParent] As Guid?
		'''<summary>Shop order parent number</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ShopOrderParentNumber] As Int32?
		'''<summary>Number of shop order routing step plans for this shop order</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ShopOrderRoutingStepPlanCount] As Int32
		'''<summary>Collection of Shop order Routing step plans</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ShopOrderRoutingStepPlans] As IEnumerable(Of Models.Manufacturing.ShopOrderRoutingStepPlan)
		'''<summary>Indicates the type of Shop Order: 10 Open, 20 In process, 30 Finished, 40 Completed</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Status] As Int32?
		'''<summary>The count of material lines of this shop order, which have been linked to a sub order</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SubShopOrderCount] As Int32
		'''<summary>Overall status of the line: 9040 Regular</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Type] As Int32?
		'''<summary>Unit of the item created by this shop order</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Unit] As String
		'''<summary>Unit description of the unit of the item created by this shop order</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [UnitDescription] As String
		'''<summary>Reference to the Warehouse associated with the Shop order</summary>
		Public Property [Warehouse] As Guid?
		'''<summary>Your reference (of the customer)</summary>
		Public Property [YourRef] As String
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [ShopOrderMaterialPlan]
		'''<summary>Indicates if this is a backflush step</summary>
		Public Property [Backflush] As Byte?
		'''<summary>Calculator type</summary>
		Public Property [CalculatorType] As Int32?
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<summary>User ID of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>Description of the material</summary>
		Public Property [Description] As String
		'''<summary>Detail drawing reference</summary>
		Public Property [DetailDrawing] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Reference to Items table</summary>
		Public Property [Item] As Guid?
		'''<summary>Item Code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemCode] As String
		'''<summary>Description of Item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDescription] As String
		'''<summary>URL of the material item&apos;s picture</summary>
		Public Property [ItemPictureUrl] As String
		'''<summary>Line number</summary>
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
		'''<summary>Line notes</summary>
		Public Property [Notes] As String
		'''<summary>Planned amount in the currency of the transaction</summary>
		Public Property [PlannedAmountFC] As Double?
		'''<summary>Date that the material is required.</summary>
		Public Property [PlannedDate] As DateTime?
		'''<summary>Planned price of the material</summary>
		Public Property [PlannedPriceFC] As Double?
		'''<summary>Intended quantity</summary>
		Public Property [PlannedQuantity] As Double?
		'''<summary>Intended quantity unit factor</summary>
		Public Property [PlannedQuantityFactor] As Double?
		'''<summary>Reference to ShopOrders table</summary>
		Public Property [ShopOrder] As Guid?
		'''<summary>Line status</summary>
		Public Property [Status] As Int32?
		'''<summary>Description of Status</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StatusDescription] As String
		'''<summary>Type</summary>
		Public Property [Type] As Int32?
		'''<summary>Unit</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Unit] As String
		'''<summary>Unit description</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [UnitDescription] As String
	End Class

	<SupportedActionsSDK(True, True, False, False)>
	<DataServiceKey("StockTransactionId")>
	Public Class [ShopOrderReceipt]
		'''<summary>ID of creating user</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatedBy] As Guid?
		'''<summary>Name of the creating user</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatedByFullName] As String
		'''<summary>Date of this ShopOrderReceipt</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatedDate] As DateTime?
		'''<summary>Serial or batch numbers are reserved prior to a POST to ShopOrderReceipts. This DraftStockTransactionID represents the group of serial or batch numbers to be used in this transaction.</summary>
		Public Property [DraftStockTransactionID] As Guid?
		'''<summary>Indicates if this ShopOrderReceipt has a quantity eligible to be reversed via ShopOrderReversals</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [HasReversibleQuantity] As Boolean
		'''<summary>Does the shop order receipt&apos;s item use batch numbers</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsBatch] As Byte?
		'''<summary>Indicates if fractions (for example 0.35) are allowed for quantities of the shop order receipt&apos;s item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsFractionAllowedItem] As Byte?
		'''<summary>Boolean indicating if this ShopOrderReceipt was part of an SubOrderReceipt</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsIssueToParent] As Boolean
		'''<summary>Does the shop order receipt&apos;s item use serial numbers</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsSerial] As Byte?
		'''<summary>Item finished</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Item] As Guid?
		'''<summary>Code of item finished</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemCode] As String
		'''<summary>Description of item finished</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDescription] As String
		'''<summary>Picture url of shop order item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemPictureUrl] As String
		'''<summary>Parent shop order if this ShopOrderReceipt is part of a SubOrderReceipt</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ParentShopOrder] As Guid?
		'''<summary>Parent shop order number if this ShopOrderReceipt is part of a SubOrderReceipt</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ParentShopOrderNumber] As Int32?
		'''<summary>Quantity of this ShopOrderReceipt</summary>
		Public Property [Quantity] As Double?
		'''<summary>If this transaction was part of a SubOrderReceipt, this ID is the related MaterialIssue.StockTransactionID.</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [RelatedStockTransaction] As Guid?
		'''<summary>Shop order finished</summary>
		Public Property [ShopOrder] As Guid?
		'''<summary>Number of shop order finished</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ShopOrderNumber] As Int32?
		'''<summary>ID of stock transaction of this ShopOrderReceipt</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StockTransactionId] As Guid
		'''<summary>ID of storage location finished to</summary>
		Public Property [StorageLocation] As Guid?
		'''<summary>Code of storage location finished to</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StorageLocationCode] As String
		'''<summary>Description of storage location finished to</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StorageLocationDescription] As String
		'''<summary>Effective date of this ShopOrderReceipt</summary>
		Public Property [TransactionDate] As DateTime?
		'''<summary>Unit of measurement abbreviation of item finished</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Unit] As String
		'''<summary>Unit of measurement of item finished</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [UnitDescription] As String
		'''<summary>ID of warehouse finished to</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Warehouse] As Guid?
		'''<summary>Code of warehouse finished to</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseCode] As String
		'''<summary>Description of warehouse finished to</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseDescription] As String
	End Class

	<SupportedActionsSDK(True, True, False, False)>
	<DataServiceKey("ReversalStockTransactionId")>
	Public Class [ShopOrderReversal]
		'''<summary>ID of creating user</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatedBy] As Guid?
		'''<summary>Name of the creating user</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatedByFullName] As String
		'''<summary>Date of this reversal</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatedDate] As DateTime?
		'''<summary>Does the ShopOrderReversal&apos;s item use batch numbers</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsBatch] As Byte?
		'''<summary>Indicates if fractions (for example 0.35) are allowed for quantities of the ShopOrderReversal&apos;s item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsFractionAllowedItem] As Byte?
		'''<summary>Does the ShopOrderReversal&apos;s item use serial numbers</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsSerial] As Byte?
		'''<summary>Item reversed</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Item] As Guid?
		'''<summary>Code of item reversed</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemCode] As String
		'''<summary>Description of item reversed</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDescription] As String
		'''<summary>Picture url of shop order item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemPictureUrl] As String
		'''<summary>Notes associated with this reversal</summary>
		Public Property [Note] As String
		'''<summary>ID of the original stock transaction, which was reversed</summary>
		Public Property [OriginalStockTransactionId] As Guid?
		'''<summary>Quantity reversed</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Quantity] As Double?
		'''<summary>ID of stock transaction related to this ShopOrderReversal</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ReversalStockTransactionId] As Guid
		'''<summary>Shop order being reversed</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ShopOrder] As Guid?
		'''<summary>Number of shop order being reversed</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ShopOrderNumber] As Int32?
		'''<summary>ID of storage location reversed from</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StorageLocation] As Guid?
		'''<summary>Code of storage location reversed from</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StorageLocationCode] As String
		'''<summary>Description of storage location reversed from</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StorageLocationDescription] As String
		'''<summary>Effective date of this ShopOrderReversal</summary>
		Public Property [TransactionDate] As DateTime?
		'''<summary>Unit of measurement abbreviation of item reversed</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Unit] As String
		'''<summary>Unit of measurement of item reversed</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [UnitDescription] As String
		'''<summary>ID of warehouse reversed from</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Warehouse] As Guid?
		'''<summary>Code of warehouse reversed from</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseCode] As String
		'''<summary>Description of warehouse reversed from</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseDescription] As String
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [ShopOrderRoutingStepPlan]
		'''<summary>Reference to Account providing the Outsourced item</summary>
		Public Property [Account] As Guid?
		'''<summary>Account name</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountName] As String
		'''<summary>Account number</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountNumber] As String
		'''<summary>Attended Percentage</summary>
		Public Property [AttendedPercentage] As Double?
		'''<summary>Indicates if this is a backflush step</summary>
		Public Property [Backflush] As Byte?
		'''<summary>Total cost / Shop order planned quantity</summary>
		Public Property [CostPerItem] As Double?
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<summary>User ID of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>Description of the operation</summary>
		Public Property [Description] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<summary>Efficiency Percentage</summary>
		Public Property [EfficiencyPercentage] As Double?
		'''<summary>Conversion factor type between Shop order Item and Subcontract purchase Unit</summary>
		Public Property [FactorType] As Int32?
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Sequential order of the operation</summary>
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
		'''<summary>Notes</summary>
		Public Property [Notes] As String
		'''<summary>Reference to Operations</summary>
		Public Property [Operation] As Guid?
		'''<summary>Code of the routing step operation</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [OperationCode] As String
		'''<summary>Description of the operation step</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [OperationDescription] As String
		'''<summary>Reference to OperationResources</summary>
		Public Property [OperationResource] As Guid?
		'''<summary>Planned end date</summary>
		Public Property [PlannedEndDate] As DateTime?
		'''<summary>Planned run hours</summary>
		Public Property [PlannedRunHours] As Double?
		'''<summary>Planned setup hours</summary>
		Public Property [PlannedSetupHours] As Double?
		'''<summary>Planned start date</summary>
		Public Property [PlannedStartDate] As DateTime?
		'''<summary>Setup hours + Run hours</summary>
		Public Property [PlannedTotalHours] As Double?
		'''<summary>Reference to Units</summary>
		Public Property [PurchaseUnit] As String
		'''<summary>Purchase Unit Factor</summary>
		Public Property [PurchaseUnitFactor] As Double?
		'''<summary>Purchase Unit Price in the currency of the transaction</summary>
		Public Property [PurchaseUnitPriceFC] As Double?
		'''<summary>Purchase unit quantity of the plan</summary>
		Public Property [PurchaseUnitQuantity] As Double?
		'''<summary>Reference to RoutingStepTypes</summary>
		Public Property [RoutingStepType] As Int32?
		'''<summary>Used in conjunction with RunMethod, and EfficiencyPercentage to determine PlannedRunHours</summary>
		Public Property [Run] As Double?
		'''<summary>Reference to OperationMethod</summary>
		Public Property [RunMethod] As Int32?
		'''<summary>Description of RunMethod</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [RunMethodDescription] As String
		'''<summary>Used in conjunction with SetupCount and Setup Unit to determine PlannedSetupHours</summary>
		Public Property [Setup] As Double?
		'''<summary>Reference to TimeUnits</summary>
		Public Property [SetupUnit] As String
		'''<summary>Reference to Shop orders</summary>
		Public Property [ShopOrder] As Guid?
		'''<summary>Reference to OperationStatus</summary>
		Public Property [Status] As Int32?
		'''<summary>Description of Status</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StatusDescription] As String
		'''<summary>Subcontracted lead days</summary>
		Public Property [SubcontractedLeadDays] As Int32?
		'''<summary>Collection of TimeTransactions</summary>
		Public Property [TimeTransactions] As IEnumerable(Of Models.Manufacturing.TimeTransaction)
		'''<summary>Total cost of the routing line</summary>
		Public Property [TotalCostDC] As Double?
		'''<summary>Reference to Workcenters</summary>
		Public Property [Workcenter] As Guid?
		'''<summary>Workcenter code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WorkcenterCode] As String
		'''<summary>Workcenter description</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WorkcenterDescription] As String
	End Class

	<SupportedActionsSDK(True, True, False, False)>
	<DataServiceKey("Id")>
	Public Class [StageForDeliveryReceipt]
		'''<summary>ID of creating user</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatedBy] As Guid?
		'''<summary>Name of the creating user</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatedByFullName] As String
		'''<summary>Date this Stage for delivery wa created</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatedDate] As DateTime?
		'''<summary>Indicates if this StageForDeliveryReceipt has a quantity eligible to be reversed via StageForDeliveryReversals</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [HasReversibleQuantity] As Boolean
		'''<summary>ID of staged for delivery entry</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Id] As Guid
		'''<summary>Does the shop order receipt&apos;s item use batch numbers</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsBatch] As Byte
		'''<summary>Indicates if fractions (for example 0.35) are allowed for quantities of the stage for delivery receipt&apos;s item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsFractionAllowedItem] As Byte
		'''<summary>Does the shop order receipt&apos;s item use serial numbers</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsSerial] As Byte
		'''<summary>Item staged for delivery</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Item] As Guid?
		'''<summary>Code of item staged for delivery</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemCode] As String
		'''<summary>Description of item staged for delivery</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDescription] As String
		'''<summary>Picture url of shop order item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemPictureUrl] As String
		'''<summary>Quantity of this StageForDeliveryReceipt</summary>
		Public Property [Quantity] As Double?
		'''<summary>ID of the original stage for delivery entry</summary>
		Public Property [RelatedId] As Guid?
		'''<summary>Shop order staged for delivery</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ShopOrder] As Guid
		'''<summary>Number of shop order staged for delivery</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ShopOrderNumber] As Int32?
		'''<summary>Effective date of this stage for delivery receipt</summary>
		Public Property [TransactionDate] As DateTime?
		'''<summary>Unit of measurement abbreviation of item finished</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Unit] As String
		'''<summary>Unit of measurement of item finished</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [UnitDescription] As String
		'''<summary>ID of the shop order warehouse</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Warehouse] As Guid?
		'''<summary>Code of the shop order warehouse</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseCode] As String
		'''<summary>Description of the shop order warehouse</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseDescription] As String
	End Class

	<SupportedActionsSDK(True, True, False, False)>
	<DataServiceKey("Id")>
	Public Class [StageForDeliveryReversal]
		'''<summary>ID of creating user</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatedBy] As Guid?
		'''<summary>Name of the creating user</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatedByFullName] As String
		'''<summary>Date of this reversal</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatedDate] As DateTime?
		'''<summary>ID of this StageForDeliveryReversal</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Id] As Guid
		'''<summary>Does the shop order receipt&apos;s item use batch numbers</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsBatch] As Byte
		'''<summary>Indicates if fractions (for example 0.35) are allowed for quantities of the StageForDeliveryReversal&apos;s item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsFractionAllowedItem] As Byte
		'''<summary>Does the shop order receipt&apos;s item use serial numbers</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsSerial] As Byte
		'''<summary>Item reversed</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Item] As Guid?
		'''<summary>Code of item reversed</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemCode] As String
		'''<summary>Description of item reversed</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDescription] As String
		'''<summary>Picture url of by-product item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemPictureUrl] As String
		'''<summary>Quantity reversed</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Quantity] As Double?
		'''<summary>ID of the original stage for delivery entry, which is being reversed</summary>
		Public Property [RelatedId] As Guid?
		'''<summary>Shop order being reversed to</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ShopOrder] As Guid?
		'''<summary>Number of shop order being reversed to</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ShopOrderNumber] As Int32?
		'''<summary>Effective date of this StageForDeliveryReversal</summary>
		Public Property [TransactionDate] As DateTime?
		'''<summary>Unit of measurement abbreviation of item reversed</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Unit] As String
		'''<summary>Unit of measurement of item reversed</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [UnitDescription] As String
		'''<summary>ID of the shop order warehouse</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Warehouse] As Guid?
		'''<summary>Code of the shop order warehouse</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseCode] As String
		'''<summary>Description of the shop order warehouse</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseDescription] As String
	End Class

	<SupportedActionsSDK(True, True, False, False)>
	<DataServiceKey("ShopOrderReceiptStockTransactionId")>
	Public Class [SubOrderReceipt]
		'''<summary>ID of creating user</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatedBy] As Guid?
		'''<summary>Name of the creating user</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatedByFullName] As String
		'''<summary>Creation date of this SubOrderReceipt</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatedDate] As DateTime?
		'''<summary>Serial or batch numbers are reserved prior to a POST to SubOrderReceipt. This DraftStockTransactionID represents the group of serial or batch numbers to be used in this transaction.</summary>
		Public Property [DraftStockTransactionID] As Guid?
		'''<summary>Indicates if this SubOrderReceipt has a quantity eligible to be reversed via SubOrderReversals</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [HasReversibleQuantity] As Boolean
		'''<summary>Does the SubOrderReceipt&apos;s item use batch numbers</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsBatch] As Byte?
		'''<summary>Indicates if fractions (for example 0.35) are allowed for quantities of the SubOrderReceipt&apos;s item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsFractionAllowedItem] As Byte?
		'''<summary>Does the SubOrderReceipt&apos;s item use serial numbers</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsSerial] As Byte?
		'''<summary>Item of this SubOrderReceipt</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Item] As Guid?
		'''<summary>Code of this SubOrderReceipt&apos;s item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemCode] As String
		'''<summary>Description of this SubOrderReceipt&apos;s item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDescription] As String
		'''<summary>Picture url of shop order item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemPictureUrl] As String
		'''<summary>MaterialIssue.StockTransactionId related to this SubOrderReceipt</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [MaterialIssueStockTransactionId] As Guid?
		'''<summary>Shop order issued to</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ParentShopOrder] As Guid?
		'''<summary>Shop order material plan issued to</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ParentShopOrderMaterialPlan] As Guid?
		'''<summary>Number of shop order issued to</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ParentShopOrderNumber] As Int32?
		'''<summary>Quantity of this SubOrderReceipt</summary>
		Public Property [Quantity] As Double?
		'''<summary>ShopOrderReceipt.StockTransactionId related to this SubOrderReceipt</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ShopOrderReceiptStockTransactionId] As Guid
		'''<summary>Shop order issued from</summary>
		Public Property [SubShopOrder] As Guid?
		'''<summary>Number of shop order issued from</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SubShopOrderNumber] As Int32?
		'''<summary>Effective date of this SubOrderReceipt</summary>
		Public Property [TransactionDate] As DateTime?
		'''<summary>Unit of measurement abbreviation of this SubOrderReceipt&apos;s item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Unit] As String
		'''<summary>Unit of measurement of this SubOrderReceipt&apos;s item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [UnitDescription] As String
		'''<summary>ID of warehouse SubOrderReceipt</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Warehouse] As Guid?
		'''<summary>Code of warehouse SubOrderReceipt</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseCode] As String
		'''<summary>Description of warehouse SubOrderReceipt</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseDescription] As String
	End Class

	<SupportedActionsSDK(True, True, False, False)>
	<DataServiceKey("MaterialReversalStockTransactionId")>
	Public Class [SubOrderReversal]
		'''<summary>ID of creating user</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatedBy] As Guid?
		'''<summary>Name of the creating user</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatedByFullName] As String
		'''<summary>Creation date of this SubOrderReversal</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatedDate] As DateTime?
		'''<summary>Does the SubOrderReversal&apos;s item use batch numbers</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsBatch] As Byte?
		'''<summary>Indicates if fractions (for example 0.35) are allowed for quantities of the SubOrderReversal&apos;s item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsFractionAllowedItem] As Byte?
		'''<summary>Does the SubOrderReversal&apos;s item use serial numbers</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsSerial] As Byte?
		'''<summary>Item reversed</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Item] As Guid?
		'''<summary>Code of item reversed</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemCode] As String
		'''<summary>Description of item reversed</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDescription] As String
		'''<summary>Picture url of shop order item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemPictureUrl] As String
		'''<summary>MaterialReversal.StockTransactionId related to this SubOrderReversal&apos;s MaterialReversal</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [MaterialReversalStockTransactionId] As Guid
		'''<summary>Notes logged with this reversal</summary>
		Public Property [Note] As String
		'''<summary>MaterialIssue.StockTransactionId related to this SubOrderReceipt&apos;s original MaterialIssue</summary>
		Public Property [OriginalMaterialIssueStockTransactionId] As Guid?
		'''<summary>ShopOrderReceipt.StockTransactionId related to this SubOrderReceipt&apos;s original ShopOrderReceipt</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [OriginalShopOrderReceiptStockTransactionId] As Guid?
		'''<summary>Shop order reversed from</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ParentShopOrder] As Guid?
		'''<summary>Number of shop order reversed from</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ParentShopOrderNumber] As Int32?
		'''<summary>Quantity of this SubOrderReversal</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Quantity] As Double?
		'''<summary>ShopOrderReversal.StockTransactionId related to this SubOrderReversal&apos;s ShopOrderReversal</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ShopOrderReversalStockTransactionId] As Guid?
		'''<summary>Shop order reversed to</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SubShopOrder] As Guid?
		'''<summary>Number of shop order reversed to</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SubShopOrderNumber] As Int32?
		'''<summary>Effective date of this SubOrderReversal</summary>
		Public Property [TransactionDate] As DateTime?
		'''<summary>Unit of measurement abbreviation of this SubOrderReversal&apos;s item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Unit] As String
		'''<summary>Unit of measurement of this SubOrderReversal&apos;s item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [UnitDescription] As String
		'''<summary>ID of warehouse of this SubOrderReversal</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Warehouse] As Guid?
		'''<summary>Code of warehouse of this SubOrderReversal</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseCode] As String
		'''<summary>Description of warehouse of this SubOrderReversal</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseDescription] As String
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [TimeTransaction]
		'''<summary>Manufacturing time type: Setup = 10, Run = 20</summary>
		Public Property [Activity] As Int32?
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<summary>User ID of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>Date</summary>
		Public Property [Date] As DateTime?
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<summary>Employee linked to the transaction</summary>
		Public Property [Employee] As Guid?
		'''<summary>Machine hours</summary>
		Public Property [Hours] As Double?
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Is the operation finished?</summary>
		Public Property [IsOperationFinished] As Byte?
		'''<summary>Labor Hours on the operation</summary>
		Public Property [LaborHours] As Double?
		'''<summary>Last modified date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<summary>User ID of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Name of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>Notes linked to the time transaction</summary>
		Public Property [Notes] As String
		'''<summary>Percentage of the operation that is complete</summary>
		Public Property [PercentComplete] As Double?
		'''<summary>Quantity</summary>
		Public Property [Quantity] As Double?
		'''<summary>Routing step linked to the transaction</summary>
		Public Property [RoutingStepPlan] As Guid?
		'''<summary>Shop order linked to the transaction</summary>
		Public Property [ShopOrder] As Guid?
		'''<summary>Status of the transaction: Draft = 1, Rejected = 2, Submitted = 10, Final = 20</summary>
		Public Property [Status] As Int32?
		'''<summary>Timed time transaction linked to the transaction</summary>
		Public Property [TimedTimeTransaction] As Guid?
		'''<summary>Workcenter linked to the transaction</summary>
		Public Property [WorkCenter] As Guid?
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [Workcenter]
		'''<summary>Capacity of the work center</summary>
		Public Property [Capacity] As Int32?
		'''<summary>Code of the work center</summary>
		Public Property [Code] As String
		'''<summary>Reference to CostCenters</summary>
		Public Property [Costcenter] As String
		'''<summary>Description of Costcenter</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CostcenterDescription] As String
		'''<summary>Reference to CostUnits</summary>
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
		'''<summary>Description of the work center</summary>
		Public Property [Description] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<summary>General burden rate</summary>
		Public Property [GeneralBurdenRate] As Double?
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Indicates if labor burden is calculated as a percentage or amount</summary>
		Public Property [IsLaborBurdenPercent] As Byte
		'''<summary>Labor burden rate</summary>
		Public Property [LaborBurdenRate] As Double?
		'''<summary>Machine burden rate</summary>
		Public Property [MachineBurdenRate] As Double?
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
		Public Property [Notes] As String
		'''<summary>Area to which the work center belongs.</summary>
		Public Property [ProductionArea] As Guid?
		'''<summary>Run labor rate</summary>
		Public Property [RunLaborRate] As Double?
		'''<summary>Search code of the work center</summary>
		Public Property [SearchCode] As String
		'''<summary>Setup labor rate</summary>
		Public Property [SetupLaborRate] As Double?
		'''<summary>Reference to WorkcenterStatus</summary>
		Public Property [Status] As Int32?
		'''<summary>Reference to WorkcenterTypes</summary>
		Public Property [Type] As Int32?
	End Class

End Namespace