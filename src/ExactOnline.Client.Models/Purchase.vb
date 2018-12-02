Namespace Purchase

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [PurchaseInvoice]
		'''<summary>The amount including VAT in the currency of the invoice.</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Amount] As Double
		'''<summary>Guid identifying the contact person of the supplier.</summary>
		Public Property [ContactPerson] As Guid?
		'''<summary>The code of the currency of the invoiced amount.</summary>
		Public Property [Currency] As String
		'''<summary>The description of the invoice.</summary>
		Public Property [Description] As String
		'''<summary>Guid identifying a document that is attached to the invoice.</summary>
		Public Property [Document] As Guid?
		'''<summary>The date before which the invoice has to be paid.</summary>
		Public Property [DueDate] As DateTime?
		'''<summary>The unique number of the purchase invoice. The entry number is based on a setting in the purchase journal and incremented for each new purchase invoice.</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [EntryNumber] As Int32?
		'''<summary>The exchange rate between the invoice currency and the default currency of the division.</summary>
		Public Property [ExchangeRate] As Double?
		'''<summary>The financial period in which the invoice is entered.</summary>
		Public Property [FinancialPeriod] As Int16?
		'''<summary>The financial year in which the invoice is entered.</summary>
		Public Property [FinancialYear] As Int16?
		'''<summary>A guid that is the unique identifier of the purchase invoice.</summary>
		Public Property [ID] As Guid
		'''<summary>The date on which the supplier entered the invoice.</summary>
		Public Property [InvoiceDate] As DateTime?
		'''<summary>The code of the purchase journal in which the invoice is entered.</summary>
		Public Property [Journal] As String
		'''<summary>The date and time the invoice was last modified.</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime
		'''<summary>The code of the payment condition that is used to calculate the due date and discount.</summary>
		Public Property [PaymentCondition] As String
		'''<summary>Unique reference to match payments and invoices.</summary>
		Public Property [PaymentReference] As String
		'''<summary>The collection of lines that belong to the purchase invoice.</summary>
		Public Property [PurchaseInvoiceLines] As IEnumerable(Of Models.Purchase.PurchaseInvoiceLine)
		'''<summary>The user can enter remarks related to the invoice here.</summary>
		Public Property [Remarks] As String
		'''<summary>Indicates the origin of the invoice. 1 Manual entry, 3 Purchase invoice, 4 Purchase order, 5 Web service.</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Source] As Int16
		'''<summary>The status of the invoice. 10 Draft, 20 Open, 50 Processed.</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Status] As Int16
		'''<summary>Guid that identifies the supplier.</summary>
		Public Property [Supplier] As Guid?
		'''<summary>Indicates the type of the purchase invoice. 8030 Direct purchase invoice, 8031 Direct purchase invoice (Credit), 8033 Purchase invoice, 8034 Purchase invoice (Credit)</summary>
		Public Property [Type] As Int16
		'''<summary>The total VAT amount of the purchase invoice.</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VATAmount] As Double?
		'''<summary>Guid that identifies the warehouse that will receive the purchased goods. This is mandatory for creating a direct purchase invoice. </summary>
		Public Property [Warehouse] As Guid?
		'''<summary>The invoice number provided by the supplier.</summary>
		Public Property [YourRef] As String
	End Class

	<SupportedActionsSDK(True, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [PurchaseInvoiceLine]
		'''<summary>In a GET request the line amount is always returned excluding VAT.&lt;br&gt;&lt;br&gt;In a POST request the line amount has to be submitted either including or excluding the VAT amount. This depends on the type (including or excluding) of the VAT code.</summary>
		Public Property [Amount] As Double
		'''<summary>The code of the cost center that is linked to this invoice line.</summary>
		Public Property [CostCenter] As String
		'''<summary>The code of the cost unit that is linked to this invoice line.</summary>
		Public Property [CostUnit] As String
		'''<summary>The currency of the line amount. The total invoice amount and all individual line amounts are in the same currency.</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Currency] As String
		'''<summary>Description of the invoice line.</summary>
		Public Property [Description] As String
		'''<summary>The discount given on the default price. A value of 0.1 translates to 10% discount.</summary>
		Public Property [Discount] As Double?
		'''<summary>Expense related to the Work Breakdown Structure of the selected project. Only available with a professional service license</summary>
		Public Property [Expense] As Guid?
		'''<summary>Description of expense. Only available with a professional service license</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ExpenseDescription] As String
		'''<summary>A guid that uniqely identifies the invoice line.</summary>
		Public Property [ID] As Guid
		'''<summary>The unique identifier of the purchase invoice this line belongs to.</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [InvoiceID] As Guid?
		'''<summary>Purchase invoice type.</summary>
		Public Property [InvoiceType] As Int16
		'''<summary>Guid that identifies the purchase item. In a POST request either the Item or the PurchaseOrderLine has to be supplied.</summary>
		Public Property [Item] As Guid?
		'''<summary>The default unit of the purchased item.</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemUnit] As String
		'''<summary>The sequence number of the line.</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [LineNumber] As Int32
		'''<summary>The date and time the invoice line was last modified.</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime
		'''<summary>The net price that has to be paid per unit. NetPrice = UnitPrice * (1.0 - Discount).&lt;br&gt;Depending on the type of the VAT code the net price is including or excluding VAT.</summary>
		Public Property [NetPrice] As Double
		'''<summary>The user can enter notes related to the invoice line here.</summary>
		Public Property [Notes] As String
		'''<summary>The project linked to the purchase invoice line. This field is only applicable for Manufacturing and Professional Services.</summary>
		Public Property [Project] As Guid?
		'''<summary>Guid that identifies the purchase order line that is being invoiced. When doing a POST either the Item or the PurchaseOrderLine has to be supplied.&lt;br/&gt;The values of the purchase order line such as Quantity, Item and Amount will be copied to the purchase invoice line.</summary>
		Public Property [PurchaseOrderLine] As Guid?
		'''<summary>The number of purchased items in purchase units. The purchase unit is defined on the item card and it can also be found using the logistics/SupplierItem api endpoint.For divisible items the quantity can be a fractional number, otherwise it is an integer.</summary>
		Public Property [Quantity] As Double?
		'''<summary>The number of purchased items in default units. An item has both a default unit and a purchase unit, for example piece and box with a box containing 12 pieces. The multiplication factor (12 in this example) between the default unit and purchase unit is maintained on the item card. When you GET a purchase invoice line for 1 box of items the field Quantity = 1 and QuantityInDefaultUnits = 12. </summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [QuantityInDefaultUnits] As Double?
		'''<summary>Indicates whether the purchase invoice line needs to be rebilled. Only available with a professional service license</summary>
		Public Property [Rebill] As Boolean?
		'''<summary>The code of the unit in which the item is purchased. For example piece, box or kg. The value is taken from the purchase unit in the item card.</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Unit] As String
		'''<summary>The default purchase price per unit.&lt;br&gt;Depending on the type of the VAT code the unit price is including or excluding VAT.</summary>
		Public Property [UnitPrice] As Double?
		'''<summary>The VAT amount of the invoice line.</summary>
		Public Property [VATAmount] As Double?
		'''<summary>The VAT code used for the invoice line.</summary>
		Public Property [VATCode] As String
		'''<summary>The VAT percentage.</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VATPercentage] As Double?
	End Class

End Namespace