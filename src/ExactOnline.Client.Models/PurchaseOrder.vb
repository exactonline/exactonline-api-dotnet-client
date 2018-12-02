Namespace PurchaseOrder

	<SupportedActionsSDK(True, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [GoodsReceipt]
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime
		'''<summary>User ID of the creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of the creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>Description of the goods receipt</summary>
		Public Property [Description] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32
		'''<summary>Document that is linked to the goods receipt</summary>
		Public Property [Document] As Guid?
		'''<summary>Document subject</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DocumentSubject] As String
		'''<summary>Entry number of the resulting stock entry</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [EntryNumber] As Int32?
		'''<summary>Collection of receipt lines</summary>
		Public Property [GoodsReceiptLines] As IEnumerable(Of Models.PurchaseOrder.GoodsReceiptLine)
		'''<summary>Primary key</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ID] As Guid
		'''<summary>Last modified date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime
		'''<summary>User ID of the last modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Name of the last modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>Date of the goods receipt</summary>
		Public Property [ReceiptDate] As DateTime?
		'''<summary>Receipt number</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ReceiptNumber] As Int32?
		'''<summary>Receipt note</summary>
		Public Property [Remarks] As String
		'''<summary>Account ID of the supplier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Supplier] As Guid?
		'''<summary>Supplier code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SupplierCode] As String
		'''<summary>ID of the contact person at the supplier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SupplierContact] As Guid?
		'''<summary>Name of the contact person at the supplier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SupplierContactFullName] As String
		'''<summary>Supplier name</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SupplierName] As String
		'''<summary>Warehouse ID</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Warehouse] As Guid?
		'''<summary>Warehouse code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseCode] As String
		'''<summary>Description of the warehouse</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseDescription] As String
		'''<summary>The purchase invoice number provided by the supplier</summary>
		Public Property [YourRef] As String
	End Class

	<SupportedActionsSDK(True, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [GoodsReceiptLine]
		'''<summary>Collection of batch numbers</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [BatchNumbers] As IEnumerable(Of Models.Inventory.StockBatchNumber)
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime
		'''<summary>User ID of the creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of the creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>Goods receipt line description</summary>
		Public Property [Description] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32
		'''<summary>All the lines of a goods receipt have the same GoodsReceiptID</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GoodsReceiptID] As Guid?
		'''<summary>The unique identifier of a stock transaction for a goods receipt line. A goods receipt line can be split into multiple storage locations. In this case, multiple storage locations will have the same stock transaction ID.</summary>
		Public Property [ID] As Guid
		'''<summary>ID of the received item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Item] As Guid?
		'''<summary>Code of the received item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemCode] As String
		'''<summary>Item description</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDescription] As String
		'''<summary>Unit code of the purchase</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemUnitCode] As String
		'''<summary>Line number</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [LineNumber] As Int32
		'''<summary>ID of the storage location in the warehouse where the item is received</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Location] As Guid?
		'''<summary>Code of the storage location in the warehouse where the item is received</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [LocationCode] As String
		'''<summary>Description of the storage location in the warehouse where the item is received</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [LocationDescription] As String
		'''<summary>Last modified date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime
		'''<summary>User ID of the last modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Name of the last modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>Notes</summary>
		Public Property [Notes] As String
		'''<summary>Reference to project</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Project] As Guid?
		'''<summary>Project code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectCode] As String
		'''<summary>Project description</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectDescription] As String
		'''<summary>Reference to purchase order</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PurchaseOrderID] As Guid
		'''<summary>ID of the purchase order line that is received</summary>
		Public Property [PurchaseOrderLineID] As Guid?
		'''<summary>Order number of the purchase order that is received</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PurchaseOrderNumber] As Int32
		'''<summary>Quantity ordered</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [QuantityOrdered] As Double?
		'''<summary>Quantity received</summary>
		Public Property [QuantityReceived] As Double?
		'''<summary>Collection of serial numbers</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SerialNumbers] As IEnumerable(Of Models.Inventory.StockSerialNumber)
		'''<summary>Supplier item code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SupplierItemCode] As String
	End Class

	<SupportedActionsSDK(True, True, False, True)>
	<DataServiceKey("PurchaseOrderID")>
	Public Class [PurchaseOrder]
		'''<summary>Total amount in the default currency of the company</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AmountDC] As Double?
		'''<summary>Total amount in the currency of the transaction</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AmountFC] As Double?
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<summary>User ID of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>Currency code</summary>
		Public Property [Currency] As String
		'''<summary>Reference to account for delivery</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DeliveryAccount] As Guid?
		'''<summary>Delivery account code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DeliveryAccountCode] As String
		'''<summary>Account name</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DeliveryAccountName] As String
		'''<summary>Reference to shipping address</summary>
		Public Property [DeliveryAddress] As Guid?
		'''<summary>Reference to contact for delivery</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DeliveryContact] As Guid?
		'''<summary>Name of the contact person of the customer who will receive delivered goods</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DeliveryContactPersonFullName] As String
		'''<summary>Description of the purchase order</summary>
		Public Property [Description] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<summary>Document that is manually linked to the purchase order</summary>
		Public Property [Document] As Guid?
		'''<summary>Subject of the document</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DocumentSubject] As String
		'''<summary>Shows if it is a drop shipment purchase order</summary>
		Public Property [DropShipment] As Boolean?
		'''<summary>Allows you to set the currency for the invoice. You can only do this if you have checked the Variable: Currency and Variable: Exchange rate fields in the sales journal settings. Once a line has been created in the invoice, the currency can no longer be changed.</summary>
		Public Property [ExchangeRate] As Double?
		'''<summary>Invoice status of purchase order: 10-Open, 20-Partial, 30-Complete, 40-Canceled</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [InvoiceStatus] As Int32?
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
		'''<summary>Human readable id of the purchase order</summary>
		Public Property [OrderNumber] As Int32?
		'''<summary>Purchase order status: 10-Open, 20-Partial, 30-Complete, 40-Canceled</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [OrderStatus] As Int32?
		'''<summary>The payment condition code used for due date and discount calculation</summary>
		Public Property [PaymentCondition] As String
		'''<summary>Description of payment condition</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PaymentConditionDescription] As String
		'''<summary>Purchase agent</summary>
		Public Property [PurchaseAgent] As Guid?
		'''<summary>Name of purchase agent</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PurchaseAgentFullName] As String
		'''<summary>Primary key</summary>
		Public Property [PurchaseOrderID] As Guid
		'''<summary>Collection of lines</summary>
		Public Property [PurchaseOrderLines] As IEnumerable(Of Models.PurchaseOrder.PurchaseOrderLine)
		'''<summary>This field shows the date the goods are expected to be received.</summary>
		Public Property [ReceiptDate] As DateTime?
		'''<summary>Receipt status of purchase order: 10-Open, 20-Partial, 30-Complete, 40-Canceled</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ReceiptStatus] As Int32?
		'''<summary>Include any relevant remarks regarding the purchase order.</summary>
		Public Property [Remarks] As String
		'''<summary>Reference to sales order when purchase order generated via back to back sales order</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SalesOrder] As Guid?
		'''<summary>Number of the sales order</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SalesOrderNumber] As Int32?
		'''<summary>ShippingMethod</summary>
		Public Property [ShippingMethod] As Guid?
		'''<summary>Description of ShippingMethod</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ShippingMethodDescription] As String
		'''<summary>This shows how the purchase order was created: 1-Manual entry, 2-Import, 3-Other, 4-Purchase order, 5-Sales order, 6-Supplier&apos;s items, 7-Subcontract, 8-Purchase order advice, 9-Shop order, 10-MRP calculation</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Source] As Int16?
		'''<summary>Reference to supplier account</summary>
		Public Property [Supplier] As Guid?
		'''<summary>Code of supplier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SupplierCode] As String
		'''<summary>Contact of supplier</summary>
		Public Property [SupplierContact] As Guid?
		'''<summary>Contact person full name of supplier</summary>
		Public Property [SupplierContactPersonFullName] As String
		'''<summary>Name of supplier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SupplierName] As String
		'''<summary>Total VAT amount in the currency of the transaction</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VATAmount] As Double?
		'''<summary>Warehouse</summary>
		Public Property [Warehouse] As Guid?
		'''<summary>Code of Warehouse</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseCode] As String
		'''<summary>Description of Warehouse</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseDescription] As String
		'''<summary>Shows the reference number associated with the purchase order. Enter a description and reference to make the purchase order easier to identify.</summary>
		Public Property [YourRef] As String
	End Class

	<SupportedActionsSDK(True, True, False, True)>
	<DataServiceKey("ID")>
	Public Class [PurchaseOrderLine]
		'''<summary>Amount in the default currency of the company</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AmountDC] As Double?
		'''<summary>Amount in the currency of the transaction</summary>
		<SDKFieldType(FieldType.ReadOnly)>
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
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<summary>User ID of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>Description of the purchase order line</summary>
		Public Property [Description] As String
		'''<summary>Discount in percentage for item</summary>
		Public Property [Discount] As Double?
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<summary>Expense related to the Work Breakdown Structure of the selected project. Only available with a professional service license</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Expense] As Guid?
		'''<summary>Description of expense. Only available with a professional service license</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ExpenseDescription] As String
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>The current stock level of items shown in stock unit. The information is displayed only for items with the stock property selected.</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [InStock] As Double?
		'''<summary>Quantity of item that has been invoiced</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [InvoicedQuantity] As Double?
		'''<summary>Reference to the item for purchase order</summary>
		Public Property [Item] As Guid?
		'''<summary>Item code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemCode] As String
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
		'''<summary>The net price is the unit price (VAT code taken into account) with any discount applied</summary>
		Public Property [NetPrice] As Double?
		'''<summary>Notes</summary>
		Public Property [Notes] As String
		'''<summary>Reference to project. Only available with a professional service license</summary>
		Public Property [Project] As Guid?
		'''<summary>Project code. Only available with a professional service license</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectCode] As String
		'''<summary>Description of the project. Only available with a professional service license</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectDescription] As String
		'''<summary>The current stock level + the planned quantity to be received - the planned quantity to deliver shown in stock unit.</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectedStock] As Double?
		'''<summary>Identifies the purchase order. All the lines of a purchase order have the same PurchaseOrderID</summary>
		Public Property [PurchaseOrderID] As Guid
		'''<summary>Quantity in item units</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Quantity] As Double?
		'''<summary>Quantity in purchase units. Use this field when creating a purchase order</summary>
		Public Property [QuantityInPurchaseUnits] As Double?
		'''<summary>Indicates whether the purchase order line needs to be rebilled. Only available with a professional service license</summary>
		Public Property [Rebill] As Boolean?
		'''<summary>Date the goods are expected to be received</summary>
		Public Property [ReceiptDate] As DateTime?
		'''<summary>Quantity of goods received</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ReceivedQuantity] As Double?
		'''<summary>Sales order that is linked to a back to back sales order in purchase order</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SalesOrder] As Guid?
		'''<summary>Sales order line of the sales order that is linked to a back to back sales order in purchase order</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SalesOrderLine] As Guid?
		'''<summary>Number of the sales order line</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SalesOrderLineNumber] As Int32?
		'''<summary>Number of the sales order</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SalesOrderNumber] As Int32?
		'''<summary>Code the supplier uses for this item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SupplierItemCode] As String
		'''<summary>Indicate if the notes content should be copied from SupplierItem&apos;s remarks. The default follows the CopyRemarks value from SupplierItem. Values: 0 = Do not copy remark, 1 = Copy remark</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SupplierItemCopyRemarks] As Byte
		'''<summary>Code of item unit</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Unit] As String
		'''<summary>Description of unit</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [UnitDescription] As String
		'''<summary>Item price per purchase unit</summary>
		Public Property [UnitPrice] As Double?
		'''<summary>Amount of VAT charges calculated from total amount and vat percentage</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VATAmount] As Double?
		'''<summary>The VAT code used when the invoice was registered</summary>
		Public Property [VATCode] As String
		'''<summary>Description of vat code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VATDescription] As String
		'''<summary>The VAT percentage of the VAT code. This is the percentage at the moment the invoice is created. It&apos;s also used by the default calculation of VAT amounts and VAT base amounts</summary>
		Public Property [VATPercentage] As Double?
	End Class

End Namespace