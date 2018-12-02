Namespace Project

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [CostTransaction]
		'''<summary>Account linked to the transaction</summary>
		Public Property [Account] As Guid?
		'''<summary>Name of Account</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountName] As String
		'''<summary>This property is obsolete. Use property &apos;AmountFC&apos; instead.</summary>
		Public Property [Amount] As Double?
		'''<summary>Amount of the transaction in the currency of the transaction</summary>
		Public Property [AmountFC] As Double?
		'''<summary>Attachment linked to the transaction (not mandatory)</summary>
		Public Property [Attachment] As Guid?
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<summary>User ID of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>Currency of the amount</summary>
		Public Property [Currency] As String
		'''<summary>Date</summary>
		Public Property [Date] As DateTime?
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<summary>Description of Division</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DivisionDescription] As String
		'''<summary>Employee linked to the transaction</summary>
		Public Property [Employee] As Guid?
		'''<summary>Entrynumber</summary>
		Public Property [EntryNumber] As Int32?
		'''<summary>Errortext, used for the backgroundjobs</summary>
		Public Property [ErrorText] As String
		'''<summary>Reference to ProjectWBS (work breakdown structure)</summary>
		Public Property [Expense] As Guid?
		'''<summary>Description of ProjectWBS</summary>
		Public Property [ExpenseDescription] As String
		'''<summary>Status of the transaction</summary>
		Public Property [HourStatus] As Int16?
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Item linked to the transaction. Items of type &apos;time&apos; are linked to time transactionsItems of other types are linked to costtransactions</summary>
		Public Property [Item] As Guid?
		'''<summary>Description of Item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDescription] As String
		'''<summary>Indicates if fractional quantities of the item can be used, for example quantity = 0.4</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDivisable] As Boolean?
		'''<summary>Last modified date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<summary>User ID of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Name of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>Notes linked to the transaction (not mandatory)</summary>
		Public Property [Notes] As String
		'''<summary>This property is obsolete. Use property &apos;PriceFC&apos; instead.</summary>
		Public Property [Price] As Double?
		'''<summary>PriceFC (AmountFC = Quantity * PriceFC)</summary>
		Public Property [PriceFC] As Double?
		'''<summary>Project linked to the transaction</summary>
		Public Property [Project] As Guid?
		'''<summary>Project account linked to the transaction (not mandatory)</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectAccount] As Guid?
		'''<summary>Project account code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectAccountCode] As String
		'''<summary>Project account name</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectAccountName] As String
		'''<summary>Description of Project</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectDescription] As String
		'''<summary>Quantity of the transaction</summary>
		Public Property [Quantity] As Double?
		'''<summary>Skip validation</summary>
		Public Property [SkipValidation] As Boolean
		'''<summary>Subscription linked to the transaction</summary>
		Public Property [Subscription] As Guid?
		'''<summary>Account linked to the subscription</summary>
		Public Property [SubscriptionAccount] As Guid?
		'''<summary>Subscription account code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SubscriptionAccountCode] As String
		'''<summary>Subscription account name</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SubscriptionAccountName] As String
		'''<summary>Description of the subscription</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SubscriptionDescription] As String
		'''<summary>Subscription number</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SubscriptionNumber] As Int32?
		'''<summary>Type of the transaction</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Type] As Int16?
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ItemId")>
	Public Class [HourCostType]
		'''<summary>Description of Item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDescription] As String
		'''<summary>Primary key</summary>
		Public Property [ItemId] As Guid
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [InvoiceTerm]
		'''<summary>Amount in the currency of the transaction</summary>
		Public Property [Amount] As Double?
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<summary>User ID of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>WBS&apos;s deliverable linked to invoice term</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Deliverable] As String
		'''<summary>Description of invoice term</summary>
		Public Property [Description] As String
		'''<summary>Division number</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<summary>Execution date: From</summary>
		Public Property [ExecutionFromDate] As DateTime?
		'''<summary>Execution date: To</summary>
		Public Property [ExecutionToDate] As DateTime?
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Invoice date</summary>
		Public Property [InvoiceDate] As DateTime?
		'''<summary>Reference to item</summary>
		Public Property [Item] As Guid?
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
		'''<summary>Notes</summary>
		Public Property [Notes] As String
		'''<summary>Percentage of amount per project&apos;s budgeted amount</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Percentage] As Double?
		'''<summary>Reference to project</summary>
		Public Property [Project] As Guid?
		'''<summary>Description of project</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectDescription] As String
		'''<summary>Reference to VATCode</summary>
		Public Property [VATCode] As String
		'''<summary>Description of VATCode</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VATCodeDescription] As String
		'''<summary>VATCode percentage</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VATPercentage] As Double?
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [Project]
		'''<summary>The account for this project</summary>
		Public Property [Account] As Guid?
		'''<summary>Code of Account</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountCode] As String
		'''<summary>Contact person of Account</summary>
		Public Property [AccountContact] As Guid?
		'''<summary>Name of Account</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountName] As String
		'''<summary>Is additional invoice is allowed for project</summary>
		Public Property [AllowAdditionalInvoicing] As Boolean?
		'''<summary>Block time and cost entries</summary>
		Public Property [BlockEntry] As Boolean?
		'''<summary>Block rebilling</summary>
		Public Property [BlockRebilling] As Boolean?
		'''<summary>Budgeted amount of sales in the default currency of the company</summary>
		Public Property [BudgetedAmount] As Double?
		'''<summary>Budgeted amount of costs in the default currency of the company</summary>
		Public Property [BudgetedCosts] As Double?
		'''<summary>Collection of budgeted hours</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [BudgetedHoursPerHourType] As IEnumerable(Of Models.Project.ProjectHourBudget)
		'''<summary>Budgeted amount of revenue in the default currency of the company</summary>
		Public Property [BudgetedRevenue] As Double?
		'''<summary>BudgetOverrunHours: 10-Allowed, 20-Not Allowed</summary>
		Public Property [BudgetOverrunHours] As Byte?
		'''<summary>Budget type</summary>
		Public Property [BudgetType] As Int16?
		'''<summary>Budget type description</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [BudgetTypeDescription] As String
		'''<summary>Used only for PSA to link a project classification to the project</summary>
		Public Property [Classification] As Guid?
		'''<summary>Description of Classification</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ClassificationDescription] As String
		'''<summary>Code</summary>
		Public Property [Code] As String
		'''<summary>Used only for PSA to store the budgetted costs of a project (except for project type Campaign and Non-billable). Positive quantities only</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CostsAmountFC] As Double?
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<summary>User ID of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>Used only for PSA to store the customer&apos;s PO number</summary>
		Public Property [CustomerPOnumber] As String
		'''<summary>Description of the project</summary>
		Public Property [Description] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<summary>Name of Division</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DivisionName] As String
		'''<summary>End date of the project. In combination with the start date the status is determined</summary>
		Public Property [EndDate] As DateTime?
		'''<summary>Item used for fixed price invoicing. To be defined per project. If empty the functionality relies on the setting</summary>
		Public Property [FixedPriceItem] As Guid?
		'''<summary>Description of FixedPriceItem</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [FixedPriceItemDescription] As String
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Internal notes not to be printed in invoice</summary>
		Public Property [InternalNotes] As String
		'''<summary>Is invoice as quoted</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [InvoiceAsQuoted] As Boolean
		'''<summary>Collection of invoice terms</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [InvoiceTerms] As IEnumerable(Of Models.Project.InvoiceTerm)
		'''<summary>Responsible person for this project</summary>
		Public Property [Manager] As Guid?
		'''<summary>Name of Manager</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ManagerFullname] As String
		'''<summary>Purchase markup percentage</summary>
		Public Property [MarkupPercentage] As Double?
		'''<summary>Last modified date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<summary>User ID of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Name of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>For additional information about projects</summary>
		Public Property [Notes] As String
		'''<summary>Used only for PSA. This item is used for prepaid invoicing. If left empty, the functionality relies on a setting</summary>
		Public Property [PrepaidItem] As Guid?
		'''<summary>Description of PrepaidItem</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PrepaidItemDescription] As String
		'''<summary>PrepaidType: 1-Retainer, 2-Hour type bundle</summary>
		Public Property [PrepaidType] As Int16?
		'''<summary>Description of PrepaidType</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PrepaidTypeDescription] As String
		'''<summary>Collection of employee restrictions</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectRestrictionEmployees] As IEnumerable(Of Models.Project.ProjectRestrictionEmployee)
		'''<summary>Collection of item restrictions</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectRestrictionItems] As IEnumerable(Of Models.Project.ProjectRestrictionItem)
		'''<summary>Collection of rebilling restrictions</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectRestrictionRebillings] As IEnumerable(Of Models.Project.ProjectRestrictionRebilling)
		'''<summary>Budgeted time. Total number of hours estimated for the fixed price project</summary>
		Public Property [SalesTimeQuantity] As Double?
		'''<summary>Source quotation</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SourceQuotation] As Guid?
		'''<summary>Start date of a project. In combination with the end date the status is determined</summary>
		Public Property [StartDate] As DateTime?
		'''<summary>Alert when exceeding (Hours)</summary>
		Public Property [TimeQuantityToAlert] As Double?
		'''<summary>Reference to ProjectTypes</summary>
		Public Property [Type] As Int32?
		'''<summary>Description of Type</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [TypeDescription] As String
		'''<summary>Using billing milestones</summary>
		Public Property [UseBillingMilestones] As Boolean?
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [ProjectBudgetType]
		'''<summary>Description</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Description] As String
		'''<summary>Primary key</summary>
		Public Property [ID] As Int16
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [ProjectHourBudget]
		'''<summary>Number of hours</summary>
		Public Property [Budget] As Double?
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<summary>User ID of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>Division number</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Hour type of budget</summary>
		Public Property [Item] As Guid?
		'''<summary>Code of hour type</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemCode] As String
		'''<summary>Description of hour type</summary>
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
		'''<summary>Reference to project</summary>
		Public Property [Project] As Guid
		'''<summary>Code of project</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectCode] As String
		'''<summary>Description of project</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectDescription] As String
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [ProjectPlanning]
		'''<summary>Account linked to the project planning</summary>
		Public Property [Account] As Guid?
		'''<summary>Code of Account</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountCode] As String
		'''<summary>Name of Account</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountName] As String
		'''<summary>Status of the project planning process, 1 = To be processed, 2 = Processed, 3 = Failed</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [BGTStatus] As Int16?
		'''<summary>Status of the external calendar, 0 = No error, 1 = Credentials error, 2 = Technical error, 3 = Both credentials &amp; technical errors, 4 = In progress</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CommunicationErrorStatus] As Int16?
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<summary>User ID of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>Description of project planning</summary>
		Public Property [Description] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<summary>Employee linked to the project planning</summary>
		Public Property [Employee] As Guid?
		'''<summary>Code of employee</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [EmployeeCode] As String
		'''<summary>Numeric ID of the employee</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [EmployeeHID] As Int32?
		'''<summary>End date of the project planning</summary>
		Public Property [EndDate] As DateTime?
		'''<summary>Hours of the project planning</summary>
		Public Property [Hours] As Double?
		'''<summary>The type of hour for the project planning, item with &apos;Time&apos; type</summary>
		Public Property [HourType] As Guid?
		'''<summary>Code of the hour type</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [HourTypeCode] As String
		'''<summary>Description of the hour type</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [HourTypeDescription] As String
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Indicates whether the project planning is separated from the recurring planning</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsBrokenRecurrence] As Boolean?
		'''<summary>Date modified</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<summary>Modifier user ID</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Modifier name</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>For additional information about project planning</summary>
		Public Property [Notes] As String
		'''<summary>Indicates whether the entries can have over allocated planning hours</summary>
		Public Property [OverAllocate] As Boolean?
		'''<summary>Project linked to the planning</summary>
		Public Property [Project] As Guid?
		'''<summary>Code of project</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectCode] As String
		'''<summary>Description of project</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectDescription] As String
		'''<summary>Recurring planning linked to the project planning</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectPlanningRecurring] As Guid?
		'''<summary>WBS linked to the project planning</summary>
		Public Property [ProjectWBS] As Guid?
		'''<summary>Description of WBS</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectWBSDescription] As String
		'''<summary>Start date of the project planning</summary>
		Public Property [StartDate] As DateTime?
		'''<summary>Status of the project planning, 1 = Reserved, 2 = Planned</summary>
		Public Property [Status] As Int16?
		'''<summary>Type of the project planning, it will always is 4 (employee)</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Type] As Int16?
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [ProjectPlanningRecurring]
		'''<summary>Account linked to the recurring planning</summary>
		Public Property [Account] As Guid?
		'''<summary>Code of Account</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountCode] As String
		'''<summary>Name of Account</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountName] As String
		'''<summary>Status of the project planning process, 1 = To be processed, 2 = Processed, 3 = Failed</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [BGTStatus] As Int16?
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<summary>User ID of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>Indicates whether the recurring planning is day of the month or weekday of the month</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DayOrThe] As Int32?
		'''<summary>Description of recurring planning</summary>
		Public Property [Description] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<summary>Employee linked to the recurring planning</summary>
		Public Property [Employee] As Guid?
		'''<summary>Code of employee</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [EmployeeCode] As String
		'''<summary>Numeric ID of the employee</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [EmployeeHID] As Int32?
		'''<summary>End date of the recurring planning</summary>
		Public Property [EndDate] As DateTime?
		'''<summary>Indicates whether the recurring planning is end on end date or end after number of times</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [EndDateOrAfter] As Int32?
		'''<summary>End time for the recurring planning to be active</summary>
		Public Property [EndTime] As DateTime?
		'''<summary>Number of hours for the recurring planning</summary>
		Public Property [Hours] As Double?
		'''<summary>Hour type of the recurring planning, item with &apos;Time&apos; type</summary>
		Public Property [HourType] As Guid?
		'''<summary>Code of the hour type</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [HourTypeCode] As String
		'''<summary>Description of the hour type</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [HourTypeDescription] As String
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Date modified</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<summary>Modifier user ID</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Modifier name</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>Day of the monthly recurring</summary>
		Public Property [MonthPatternDay] As Byte?
		'''<summary>Ordinal number of week day for the monthly recurring planning, 1 = first, 2 = second, 3 = third, 4 = fourth, 31 = last</summary>
		Public Property [MonthPatternOrdinalDay] As Byte?
		'''<summary>Ordinal week day of the monthly recurring planning, 1 = Monday, 2 = Tuesday, 3 = Wednesday, 4 = Thursday, 5 = Friday, 6 = Saturday, 7 = Sunday</summary>
		Public Property [MonthPatternOrdinalWeek] As Byte?
		'''<summary>For additional information about recurring planning</summary>
		Public Property [Notes] As String
		'''<summary>Number of times the planning recurs</summary>
		Public Property [NumberOfRecurrences] As Int16?
		'''<summary>Indicates whether the entries can have over allocated planning hours</summary>
		Public Property [OverAllocate] As Boolean?
		'''<summary>Number of planning times for weekly or monthly recurring planning</summary>
		Public Property [PatternFrequency] As Byte?
		'''<summary>Project linked to the recurring planning</summary>
		Public Property [Project] As Guid?
		'''<summary>Code of project</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectCode] As String
		'''<summary>Description of project</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectDescription] As String
		'''<summary>Type of the recurring planning, 1 = weekly, 2 = monthly</summary>
		Public Property [ProjectPlanningRecurringType] As Byte?
		'''<summary>WBS linked to the recurring planning</summary>
		Public Property [ProjectWBS] As Guid?
		'''<summary>Description of WBS</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectWBSDescription] As String
		'''<summary>Start date of the recurring planning</summary>
		Public Property [StartDate] As DateTime?
		'''<summary>Start time for the recurring planning to be active</summary>
		Public Property [StartTime] As DateTime?
		'''<summary>Status of the project planning, 1 = Reserved, 2 = Planned</summary>
		Public Property [Status] As Int16?
		'''<summary>Week day for the weekly recurring planning</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WeekPatternDay] As Byte?
		'''<summary>Create planning on Friday, apply to weekly pattern recurring planning only</summary>
		Public Property [WeekPatternFriday] As Boolean?
		'''<summary>Create planning on Monday, apply to weekly pattern recurring planning only</summary>
		Public Property [WeekPatternMonday] As Boolean?
		'''<summary>Create planning on Saturday, apply to weekly pattern recurring planning only</summary>
		Public Property [WeekPatternSaturday] As Boolean?
		'''<summary>Create planning on Sunday, apply to weekly pattern recurring planning only</summary>
		Public Property [WeekPatternSunday] As Boolean?
		'''<summary>Create planning on Thursday, apply to weekly pattern recurring planning only</summary>
		Public Property [WeekPatternThursday] As Boolean?
		'''<summary>Create planning on Tuesday, apply to weekly pattern recurring planning only</summary>
		Public Property [WeekPatternTuesday] As Boolean?
		'''<summary>Create planning on Wednesday, apply to weekly pattern recurring planning only</summary>
		Public Property [WeekPatternWednesday] As Boolean?
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [ProjectRestrictionEmployee]
		'''<summary>Date created</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<summary>Creator user ID</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Creator name</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<summary>Employee linked to the restriction</summary>
		Public Property [Employee] As Guid?
		'''<summary>Name of employee</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [EmployeeFullName] As String
		'''<summary>Readable ID of the employee</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [EmployeeHID] As Int32?
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Date modified</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<summary>Modifier user ID</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Modifier name</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>Project linked to the restriction</summary>
		Public Property [Project] As Guid?
		'''<summary>Project code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectCode] As String
		'''<summary>Project description</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectDescription] As String
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [ProjectRestrictionItem]
		'''<summary>Date created</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<summary>Creator user ID</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Creator name</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Item linked to the restriction</summary>
		Public Property [Item] As Guid?
		'''<summary>Item code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemCode] As String
		'''<summary>Description of the item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDescription] As String
		'''<summary>Indicates if the item is a time unit item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemIsTime] As Byte?
		'''<summary>Date modified</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<summary>Modifier user ID</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Modifier name</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>Project linked to the restriction</summary>
		Public Property [Project] As Guid?
		'''<summary>Project code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectCode] As String
		'''<summary>Project description</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectDescription] As String
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [ProjectRestrictionRebilling]
		'''<summary>Cost type reference</summary>
		Public Property [CostTypeRebill] As Guid?
		'''<summary>Cost type code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CostTypeRebillCode] As String
		'''<summary>Cost type description</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CostTypeRebillDescription] As String
		'''<summary>Date created</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<summary>Creator user ID</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Creator name</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Date modified</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<summary>Modifier user ID</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Modifier name</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>Project linked to the restriction</summary>
		Public Property [Project] As Guid?
		'''<summary>Project code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectCode] As String
		'''<summary>Project description</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectDescription] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("Id")>
	Public Class [RecentCost]
		'''<summary>Code of Account</summary>
		Public Property [AccountCode] As String
		'''<summary>Reference to Account</summary>
		Public Property [AccountId] As Guid?
		'''<summary>Name of Account</summary>
		Public Property [AccountName] As String
		'''<summary>Amount approved</summary>
		Public Property [AmountApproved] As Double
		'''<summary>Amount draft</summary>
		Public Property [AmountDraft] As Double
		'''<summary>Amount rejected</summary>
		Public Property [AmountRejected] As Double
		'''<summary>Amount submitted</summary>
		Public Property [AmountSubmitted] As Double
		'''<summary>Code of Currency</summary>
		Public Property [CurrencyCode] As String
		'''<summary>Date</summary>
		Public Property [Date] As DateTime
		'''<summary>Entry ID</summary>
		Public Property [EntryId] As Guid?
		'''<summary>Reference to Expense</summary>
		Public Property [Expense] As Guid?
		'''<summary>Description of Expense</summary>
		Public Property [ExpenseDescription] As String
		'''<summary>Primary key</summary>
		Public Property [Id] As Int32
		'''<summary>Code of Item</summary>
		Public Property [ItemCode] As String
		'''<summary>Description of Item</summary>
		Public Property [ItemDescription] As String
		'''<summary>Reference to Item</summary>
		Public Property [ItemId] As Guid?
		'''<summary>Remarks</summary>
		Public Property [Notes] As String
		'''<summary>Code of Project</summary>
		Public Property [ProjectCode] As String
		'''<summary>Description of Project</summary>
		Public Property [ProjectDescription] As String
		'''<summary>Reference to Project</summary>
		Public Property [ProjectId] As Guid?
		'''<summary>Quantity approved</summary>
		Public Property [QuantityApproved] As Double
		'''<summary>Quantity draft</summary>
		Public Property [QuantityDraft] As Double
		'''<summary>Quantity rejected</summary>
		Public Property [QuantityRejected] As Double
		'''<summary>Quantity submitted</summary>
		Public Property [QuantitySubmitted] As Double
		'''<summary>Week number</summary>
		Public Property [WeekNumber] As Int32
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("Id")>
	Public Class [RecentHour]
		'''<summary>Code of Account</summary>
		Public Property [AccountCode] As String
		'''<summary>Reference to Account</summary>
		Public Property [AccountId] As Guid?
		'''<summary>Name of Account</summary>
		Public Property [AccountName] As String
		'''<summary>Reference to Activity</summary>
		Public Property [Activity] As Guid?
		'''<summary>Description of Activity</summary>
		Public Property [ActivityDescription] As String
		'''<summary>Date</summary>
		Public Property [Date] As DateTime
		'''<summary>Entry ID</summary>
		Public Property [EntryId] As Guid?
		'''<summary>Hours approved</summary>
		Public Property [HoursApproved] As Double
		'''<summary>Billable hours approved</summary>
		Public Property [HoursApprovedBillable] As Double
		'''<summary>Hours draft</summary>
		Public Property [HoursDraft] As Double
		'''<summary>Billable hours draft</summary>
		Public Property [HoursDraftBillable] As Double
		'''<summary>Hours rejected</summary>
		Public Property [HoursRejected] As Double
		'''<summary>Billable hours rejected</summary>
		Public Property [HoursRejectedBillable] As Double
		'''<summary>Hours submitted</summary>
		Public Property [HoursSubmitted] As Double
		'''<summary>Billable hours submitted</summary>
		Public Property [HoursSubmittedBillable] As Double
		'''<summary>Primary key</summary>
		Public Property [Id] As Int32
		'''<summary>Code of Item</summary>
		Public Property [ItemCode] As String
		'''<summary>Description of Item</summary>
		Public Property [ItemDescription] As String
		'''<summary>Reference to Item</summary>
		Public Property [ItemId] As Guid?
		'''<summary>Remarks</summary>
		Public Property [Notes] As String
		'''<summary>Code of Project</summary>
		Public Property [ProjectCode] As String
		'''<summary>Description of Project</summary>
		Public Property [ProjectDescription] As String
		'''<summary>Reference to Project</summary>
		Public Property [ProjectId] As Guid?
		'''<summary>Week number</summary>
		Public Property [WeekNumber] As Int32
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [TimeAndBillingAccountDetail]
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Name</summary>
		Public Property [Name] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [TimeAndBillingActivitiesAndExpens]
		'''<summary>Description</summary>
		Public Property [Description] As String
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Description of Parent</summary>
		Public Property [ParentDescription] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("AccountId")>
	Public Class [TimeAndBillingEntryAccount]
		'''<summary>Primary key</summary>
		Public Property [AccountId] As Guid
		'''<summary>Name of account</summary>
		Public Property [AccountName] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ProjectId")>
	Public Class [TimeAndBillingEntryProject]
		'''<summary>Code</summary>
		Public Property [ProjectCode] As String
		'''<summary>Description</summary>
		Public Property [ProjectDescription] As String
		'''<summary>Primary key</summary>
		Public Property [ProjectId] As Guid
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("AccountId")>
	Public Class [TimeAndBillingEntryRecentAccount]
		'''<summary>Primary key</summary>
		Public Property [AccountId] As Guid
		'''<summary>Name of account</summary>
		Public Property [AccountName] As String
		'''<summary>Date last used</summary>
		Public Property [DateLastUsed] As DateTime
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [TimeAndBillingEntryRecentActivitiesAndExpens]
		'''<summary>Date last used</summary>
		Public Property [DateLastUsed] As DateTime
		'''<summary>Description</summary>
		Public Property [Description] As String
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Description of Parent</summary>
		Public Property [ParentDescription] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ItemId")>
	Public Class [TimeAndBillingEntryRecentHourCostType]
		'''<summary>Date last used</summary>
		Public Property [DateLastUsed] As DateTime
		'''<summary>Description of item</summary>
		Public Property [ItemDescription] As String
		'''<summary>Primary key</summary>
		Public Property [ItemId] As Guid
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ProjectId")>
	Public Class [TimeAndBillingEntryRecentProject]
		'''<summary>Date last used</summary>
		Public Property [DateLastUsed] As DateTime
		'''<summary>Code of project</summary>
		Public Property [ProjectCode] As String
		'''<summary>Description of project</summary>
		Public Property [ProjectDescription] As String
		'''<summary>Primary key</summary>
		Public Property [ProjectId] As Guid
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [TimeAndBillingItemDetail]
		'''<summary>Item code</summary>
		Public Property [Code] As String
		'''<summary>Description of the item code</summary>
		Public Property [Description] As String
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Indicates if fractions are allowed for quantities of this item</summary>
		Public Property [IsFractionAllowedItem] As Boolean
		'''<summary>Indicates if the item can be sold</summary>
		Public Property [IsSalesItem] As Boolean
		'''<summary>Sales currency code</summary>
		Public Property [SalesCurrency] As String
		'''<summary>Sales price</summary>
		Public Property [SalesPrice] As Double
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [TimeAndBillingProjectDetail]
		'''<summary>The account for this project</summary>
		Public Property [Account] As Guid?
		Public Property [AccountName] As String
		'''<summary>Code of project</summary>
		Public Property [Code] As String
		'''<summary>Description of the project</summary>
		Public Property [Description] As String
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Reference to ProjectTypes</summary>
		Public Property [Type] As Int32
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [TimeCorrection]
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
		'''<summary>Id</summary>
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
		'''<summary>Reference to the time entry that this corrects for</summary>
		Public Property [OriginalEntryId] As Guid?
		'''<summary>Quantity has to be negative value. E.g.: If original quantity is 10 and the correct quantity is 4, this quantity is -6</summary>
		Public Property [Quantity] As Double?
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [TimeTransaction]
		'''<summary>Account linked to the transaction</summary>
		Public Property [Account] As Guid?
		'''<summary>Name of Account</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountName] As String
		'''<summary>Reference to ProjectWBS (work breakdown structure)</summary>
		Public Property [Activity] As Guid?
		'''<summary>Description of ProjectWBS</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ActivityDescription] As String
		'''<summary>This property is obsolete. Use property &apos;AmountFC&apos; instead.</summary>
		Public Property [Amount] As Double?
		'''<summary>Amount in the currency of the transaction of the transaction</summary>
		Public Property [AmountFC] As Double?
		'''<summary>Attachment linked to the transaction</summary>
		Public Property [Attachment] As Guid?
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<summary>User ID of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>Currency of the amount</summary>
		Public Property [Currency] As String
		'''<summary>Date</summary>
		Public Property [Date] As DateTime?
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<summary>Description of Division</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DivisionDescription] As String
		'''<summary>Employee linked to the transaction</summary>
		Public Property [Employee] As Guid?
		'''<summary>End time of the transaction</summary>
		Public Property [EndTime] As DateTime?
		'''<summary>Entrynumber</summary>
		Public Property [EntryNumber] As Int32?
		'''<summary>Errortext, used for the backgroundjobs</summary>
		Public Property [ErrorText] As String
		'''<summary>Status of the transaction</summary>
		Public Property [HourStatus] As Int16?
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Item linked to the transaction. Items of type &apos;time&apos; are linked to time transactions. Items of other types are linked to cost transactions</summary>
		Public Property [Item] As Guid?
		'''<summary>Description of Item</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDescription] As String
		'''<summary>True if you can use decimals for item quantity</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDivisable] As Boolean?
		'''<summary>Last modified date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<summary>User ID of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Name of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>Notes linked to the transaction</summary>
		Public Property [Notes] As String
		'''<summary>This property is obsolete. Use property &apos;PriceFC&apos; instead.</summary>
		Public Property [Price] As Double?
		'''<summary>PriceFC (AmountFC = Quantity * PriceFC)</summary>
		Public Property [PriceFC] As Double?
		'''<summary>Project linked to the transaction</summary>
		Public Property [Project] As Guid?
		'''<summary>Reference to project account</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectAccount] As Guid?
		'''<summary>Project account code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectAccountCode] As String
		'''<summary>Project account name</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectAccountName] As String
		'''<summary>Code of Project</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectCode] As String
		'''<summary>Description of Project</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectDescription] As String
		'''<summary>Quantity of the transaction</summary>
		Public Property [Quantity] As Double?
		'''<summary>Skip validation</summary>
		Public Property [SkipValidation] As Boolean
		'''<summary>Start time of the transaction</summary>
		Public Property [StartTime] As DateTime?
		'''<summary>Subscription linked to the transaction</summary>
		Public Property [Subscription] As Guid?
		'''<summary>Account linked to the subscription</summary>
		Public Property [SubscriptionAccount] As Guid?
		'''<summary>Subscription account code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SubscriptionAccountCode] As String
		'''<summary>Subscription account name</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SubscriptionAccountName] As String
		'''<summary>Description of the subscription</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SubscriptionDescription] As String
		'''<summary>Subscription number</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SubscriptionNumber] As Int32?
		'''<summary>Type of the transaction</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Type] As Int16?
	End Class

End Namespace