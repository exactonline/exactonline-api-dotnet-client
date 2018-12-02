Namespace SalesOrder

	<SupportedActionsSDK(True, True, True, False)>
	<DataServiceKey("EntryID")>
	Public Class [GoodsDelivery]
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<summary>User ID of the creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of the creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
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
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DeliveryAddress] As Guid?
		'''<summary>Reference to contact for delivery</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DeliveryContact] As Guid?
		'''<summary>Name of the contact person of the customer who will receive delivered goods</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DeliveryContactPersonFullName] As String
		'''<summary>Date of goods delivery</summary>
		Public Property [DeliveryDate] As DateTime?
		'''<summary>Delivery number</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DeliveryNumber] As Int32?
		'''<summary>Header description</summary>
		Public Property [Description] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<summary>Document that is manually linked to the sales order delivery</summary>
		Public Property [Document] As Guid?
		'''<summary>Document Subject</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DocumentSubject] As String
		'''<summary>Primary key</summary>
		Public Property [EntryID] As Guid
		'''<summary>Entry number</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [EntryNumber] As Int32?
		'''<summary>Collection of lines</summary>
		Public Property [GoodsDeliveryLines] As IEnumerable(Of Models.SalesOrder.GoodsDeliveryLine)
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
		'''<summary>Reference to shipping method</summary>
		Public Property [ShippingMethod] As Guid?
		'''<summary>Code of shipping method</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ShippingMethodCode] As String
		'''<summary>Description of shipping method</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ShippingMethodDescription] As String
		'''<summary>Reference to header tracking number</summary>
		Public Property [TrackingNumber] As String
		'''<summary>Warehouse</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Warehouse] As Guid?
		'''<summary>Code of Warehouse</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseCode] As String
		'''<summary>Description of Warehouse</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseDescription] As String
	End Class

	<SupportedActionsSDK(True, True, True, False)>
	<DataServiceKey("ID")>
	Public Class [GoodsDeliveryLine]
		'''<summary>Collection of batch numbers</summary>
		Public Property [BatchNumbers] As IEnumerable(Of Models.Inventory.StockBatchNumber)
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<summary>User ID of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>Date of goods delivery</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DeliveryDate] As DateTime?
		'''<summary>Description of sales order delivery</summary>
		Public Property [Description] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<summary>The EntryID identifies the goods delivery. All the lines of a goods delivery have the same EntryID</summary>
		Public Property [EntryID] As Guid?
		'''<summary>The unique identifier of a stock transaction for a goods delivery line. A goods delivery line can be split into multiple storage locations. In this case, multiple storage locations will have the same stock transaction ID.</summary>
		Public Property [ID] As Guid
		'''<summary>Reference to item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Item] As Guid?
		'''<summary>Item code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemCode] As String
		'''<summary>Description of item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDescription] As String
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
		'''<summary>Notes</summary>
		Public Property [Notes] As String
		'''<summary>Quantity delivered</summary>
		Public Property [QuantityDelivered] As Double?
		'''<summary>Quantity ordered</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [QuantityOrdered] As Double?
		'''<summary>Reference to sales order</summary>
		Public Property [SalesOrderLineID] As Guid?
		'''<summary>Sales order line number</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SalesOrderLineNumber] As Int32?
		'''<summary>Sales order number</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SalesOrderNumber] As Int32?
		'''<summary>Collection of serial numbers</summary>
		Public Property [SerialNumbers] As IEnumerable(Of Models.Inventory.StockSerialNumber)
		'''<summary>Reference to storage location</summary>
		Public Property [StorageLocation] As Guid?
		'''<summary>Storage location code</summary>
		Public Property [StorageLocationCode] As String
		'''<summary>Storage location description</summary>
		Public Property [StorageLocationDescription] As String
		'''<summary>Reference to tracking number</summary>
		Public Property [TrackingNumber] As String
		'''<summary>Code of item unit</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Unitcode] As String
	End Class

	<SupportedActionsSDK(True, False, False, False)>
	<DataServiceKey("OrderId")>
	Public Class [PrintedSalesOrder]
		'''<summary>Division code</summary>
		Public Property [Division] As Int32?
		'''<summary>Contains the id of the document that was created</summary>
		Public Property [Document] As Guid?
		'''<summary>Contains the error message if an error occurred during the creation of the document</summary>
		Public Property [DocumentCreationError] As String
		'''<summary>Contains information if a document was succesfully created</summary>
		Public Property [DocumentCreationSuccess] As String
		'''<summary>Based on this layout a PDF is created and attached to an Exact Online document and an email</summary>
		Public Property [DocumentLayout] As Guid?
		'''<summary>Contains the error message if an error occurred during the creation of the email</summary>
		Public Property [EmailCreationError] As String
		'''<summary>Contains confirmation that an email was sent. If an email cannot be delivered this property will still show confirmation that the email was sent.</summary>
		Public Property [EmailCreationSuccess] As String
		'''<summary>Based on this layout the email text is produced</summary>
		Public Property [EmailLayout] As Guid?
		'''<summary>Extra text that can be added to the printed document and email</summary>
		Public Property [ExtraText] As String
		'''<summary>Primary key, Reference to OrderID of SalesOrder</summary>
		Public Property [OrderId] As Guid
		'''<summary>Set to True if an email containing the sales order should be sent to the customer</summary>
		Public Property [SendEmailToCustomer] As Boolean?
		'''<summary>Email address from which the email will be sent. If not specified, the company email address will be used.</summary>
		Public Property [SenderEmailAddress] As String
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("OrderID")>
	Public Class [SalesOrder]
		'''<summary>Amount in the default currency of the company</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AmountDC] As Double
		'''<summary>Discount amount in the default currency of the company</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AmountDiscount] As Double?
		'''<summary>Discount amount excluding VAT in the default currency of the company</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AmountDiscountExclVat] As Double?
		'''<summary>Amount in the currency of the transaction</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AmountFC] As Double
		'''<summary>Amount exclude VAT in the currency of the transaction</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AmountFCExclVat] As Double?
		'''<summary>Shows if this sales order is approved</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ApprovalStatus] As Int16
		'''<summary>Description of ApprovalStatus</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ApprovalStatusDescription] As String
		'''<summary>Approval datetime</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Approved] As DateTime?
		'''<summary>User who approved the sales order</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Approver] As Guid?
		'''<summary>Name of approver</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ApproverFullName] As String
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime
		'''<summary>User ID of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>Currency code</summary>
		Public Property [Currency] As String
		'''<summary>Reference to the delivery customer. For an existing sales order this value can not be changed.</summary>
		Public Property [DeliverTo] As Guid?
		'''<summary>Reference to contact person of delivery customer</summary>
		Public Property [DeliverToContactPerson] As Guid?
		'''<summary>Name of contact person of delivery customer</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DeliverToContactPersonFullName] As String
		'''<summary>Name of delivery customer</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DeliverToName] As String
		'''<summary>Delivery address</summary>
		Public Property [DeliveryAddress] As Guid?
		'''<summary>Delivery date</summary>
		Public Property [DeliveryDate] As DateTime?
		'''<summary>Shipping status</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DeliveryStatus] As Int16?
		'''<summary>Description of DeliveryStatus</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DeliveryStatusDescription] As String
		'''<summary>Description</summary>
		Public Property [Description] As String
		'''<summary>Discount percentage</summary>
		Public Property [Discount] As Double?
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32
		'''<summary>Document that is manually linked to the sales order</summary>
		Public Property [Document] As Guid?
		'''<summary>Number of the document</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DocumentNumber] As Int32?
		'''<summary>Subject of the document</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DocumentSubject] As String
		'''<summary>Invoice status</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [InvoiceStatus] As Int16?
		'''<summary>Description of InvoiceStatus</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [InvoiceStatusDescription] As String
		'''<summary>Reference to the customer who will receive the invoice. For an existing sales order this value can not be changed.</summary>
		Public Property [InvoiceTo] As Guid?
		'''<summary>Reference to the contact person of the customer who will receive the invoice</summary>
		Public Property [InvoiceToContactPerson] As Guid?
		'''<summary>Name of the contact person of the customer who will receive the invoice</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [InvoiceToContactPersonFullName] As String
		'''<summary>Name of the customer who will receive the invoice</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [InvoiceToName] As String
		'''<summary>Last modified date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime
		'''<summary>User ID of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Name of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>Order date</summary>
		Public Property [OrderDate] As DateTime?
		'''<summary>Customer who ordered the sales order. For an existing sales order this value can not be changed.</summary>
		Public Property [OrderedBy] As Guid?
		'''<summary>Contact person of the customer who ordered the sales order</summary>
		Public Property [OrderedByContactPerson] As Guid?
		'''<summary>Name of contact person of the customer who ordered the sales order</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [OrderedByContactPersonFullName] As String
		'''<summary>Name of the customer who ordered the sales order</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [OrderedByName] As String
		'''<summary>Primary key</summary>
		Public Property [OrderID] As Guid
		'''<summary>Number of sales order</summary>
		Public Property [OrderNumber] As Int32
		'''<summary>The payment condition used for due date and discount calculation</summary>
		Public Property [PaymentCondition] As String
		'''<summary>Description of PaymentCondition</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PaymentConditionDescription] As String
		'''<summary>Payment reference for sales order</summary>
		Public Property [PaymentReference] As String
		'''<summary>Extra remarks</summary>
		Public Property [Remarks] As String
		'''<summary>Collection of lines</summary>
		Public Property [SalesOrderLines] As IEnumerable(Of Models.SalesOrder.SalesOrderLine)
		'''<summary>Sales representative</summary>
		Public Property [Salesperson] As Guid?
		'''<summary>Name of sales representative</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SalespersonFullName] As String
		'''<summary>ShippingMethod</summary>
		Public Property [ShippingMethod] As Guid?
		'''<summary>Description of ShippingMethod</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ShippingMethodDescription] As String
		'''<summary>The status of the sales order. 12 = Open, 20 = Partial, 21 = Complete, 45 = Cancelled.</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Status] As Int16?
		'''<summary>Description of Status</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StatusDescription] As String
		'''<summary>Obsolete</summary>
		Public Property [TaxSchedule] As Guid?
		'''<summary>Obsolete</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [TaxScheduleCode] As String
		'''<summary>Obsolete</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [TaxScheduleDescription] As String
		'''<summary>Code of Warehouse</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseCode] As String
		'''<summary>Description of Warehouse</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseDescription] As String
		'''<summary>Warehouse</summary>
		Public Property [WarehouseID] As Guid?
		'''<summary>The reference number of the customer</summary>
		Public Property [YourRef] As String
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [SalesOrderLine]
		'''<summary>Amount in the default currency of the company</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AmountDC] As Double
		'''<summary>Amount in the currency of the transaction</summary>
		Public Property [AmountFC] As Double
		'''<summary>Reference to Cost center</summary>
		Public Property [CostCenter] As String
		'''<summary>Description of CostCenter</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CostCenterDescription] As String
		'''<summary>Item cost price</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CostPriceFC] As Double?
		'''<summary>Reference to Cost unit</summary>
		Public Property [CostUnit] As String
		'''<summary>Description of CostUnit</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CostUnitDescription] As String
		'''<summary>Delivery date of this line</summary>
		Public Property [DeliveryDate] As DateTime?
		'''<summary>Description</summary>
		Public Property [Description] As String
		'''<summary>Discount given on the default price. Discount = (DefaultPrice of Item - PriceItem in line) / DefaultPrice of Item</summary>
		Public Property [Discount] As Double?
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Reference to the item that is sold in this sales order line</summary>
		Public Property [Item] As Guid?
		'''<summary>Code of Item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemCode] As String
		'''<summary>Description of Item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDescription] As String
		'''<summary>Item Version</summary>
		Public Property [ItemVersion] As Guid?
		'''<summary>Description of Item Version</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemVersionDescription] As String
		'''<summary>Line number</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [LineNumber] As Int32
		'''<summary>Sales margin of the sales order line</summary>
		Public Property [Margin] As Double?
		'''<summary>Net price of the sales order line</summary>
		Public Property [NetPrice] As Double?
		'''<summary>Extra notes</summary>
		Public Property [Notes] As String
		'''<summary>The OrderID identifies the sales order. All the lines of a sales order have the same OrderID</summary>
		Public Property [OrderID] As Guid
		'''<summary>Number of sales order</summary>
		Public Property [OrderNumber] As Int32
		'''<summary>Price list</summary>
		Public Property [Pricelist] As Guid?
		'''<summary>Description of Pricelist</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PricelistDescription] As String
		'''<summary>The project to which the sales order line is linked. The project can be different per line. Sometimes also the project in the header is filled although this is not really used</summary>
		Public Property [Project] As Guid?
		'''<summary>Description of Project</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectDescription] As String
		'''<summary>Purchase order that is linked to the sales order</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PurchaseOrder] As Guid?
		'''<summary>Purchase order line of the purchase order that is linked to the sales order</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PurchaseOrderLine] As Guid?
		'''<summary>Number of the purchase order line</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PurchaseOrderLineNumber] As Int32?
		'''<summary>Number of the purchase order</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PurchaseOrderNumber] As Int32?
		'''<summary>The number of items sold in default units. The quantity shown in the entry screen is Quantity * UnitFactor</summary>
		Public Property [Quantity] As Double?
		'''<summary>The number of items delivered</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [QuantityDelivered] As Double?
		'''<summary>The number of items invoiced</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [QuantityInvoiced] As Double?
		'''<summary>Reference to ShopOrder</summary>
		Public Property [ShopOrder] As Guid?
		'''<summary>Obsolete</summary>
		Public Property [TaxSchedule] As Guid?
		'''<summary>Obsolete</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [TaxScheduleCode] As String
		'''<summary>Obsolete</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [TaxScheduleDescription] As String
		'''<summary>Code of item unit</summary>
		Public Property [UnitCode] As String
		'''<summary>Description of Unit</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [UnitDescription] As String
		'''<summary>Price per unit in the currency of the transaction</summary>
		Public Property [UnitPrice] As Double?
		'''<summary>Indicates if drop shipment is used (delivery directly to customer, invoice to wholesaler)</summary>
		Public Property [UseDropShipment] As Byte
		'''<summary>VAT amount in the currency of the transaction</summary>
		Public Property [VATAmount] As Double?
		'''<summary>VAT code</summary>
		Public Property [VATCode] As String
		'''<summary>Description of VATCode</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VATCodeDescription] As String
		'''<summary>The vat percentage of the VAT code. This is the percentage at the moment the sales order is created. It&apos;s also used for the default calculation of VAT amounts and VAT base amounts</summary>
		Public Property [VATPercentage] As Double?
	End Class

End Namespace