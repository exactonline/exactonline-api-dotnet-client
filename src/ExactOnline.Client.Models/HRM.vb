Namespace HRM

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [AbsenceRegistration]
		'''<summary>Collection of absence registration transactions</summary>
		Public Property [AbsenceRegistrationTransactions] As IEnumerable(Of Models.HRM.AbsenceRegistrationTransaction)
		'''<summary>Absence cause, only supported for the Netherland legislation</summary>
		Public Property [Cause] As Int16?
		'''<summary>Code for the absence cause, only supported for the Netherland legislation</summary>
		Public Property [CauseCode] As String
		'''<summary>Description for the absence cause, only supported for the Netherland legislation</summary>
		Public Property [CauseDescription] As String
		'''<summary>Creation date</summary>
		Public Property [Created] As DateTime
		'''<summary>User ID of creator</summary>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator</summary>
		Public Property [CreatorFullName] As String
		'''<summary>Division code</summary>
		Public Property [Division] As Int32
		'''<summary>Employee linked to the absence</summary>
		Public Property [Employee] As Guid
		'''<summary>Employee full name</summary>
		Public Property [EmployeeFullName] As String
		'''<summary>Numeric ID of the employee</summary>
		Public Property [EmployeeHID] As Int32
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Absence kind, only supported for the Netherland legislation</summary>
		Public Property [Kind] As Int16?
		'''<summary>Code for the absence kind, only supported for the Netherland legislation</summary>
		Public Property [KindCode] As String
		'''<summary>Description for the absence kind, only supported for the Netherland legislation</summary>
		Public Property [KindDescription] As String
		'''<summary>Last modified date</summary>
		Public Property [Modified] As DateTime
		'''<summary>User ID of modifier</summary>
		Public Property [Modifier] As Guid?
		'''<summary>Name of modifier</summary>
		Public Property [ModifierFullName] As String
		'''<summary>Extra information for absence</summary>
		Public Property [Notes] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [AbsenceRegistrationTransaction]
		'''<summary>Reference key to Absence Registration</summary>
		Public Property [AbsenceRegistration] As Guid
		'''<summary>Creation date</summary>
		Public Property [Created] As DateTime
		'''<summary>User ID of creator</summary>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator</summary>
		Public Property [CreatorFullName] As String
		'''<summary>Division code</summary>
		Public Property [Division] As Int32
		'''<summary>End time on the last day of absence stored as DateTime, and the date should be ignored</summary>
		Public Property [EndTime] As DateTime?
		'''<summary>Expected end date of absence</summary>
		Public Property [ExpectedEndDate] As DateTime?
		'''<summary>Total number of absence hours</summary>
		Public Property [Hours] As Double
		'''<summary>Hours of absence on the first day</summary>
		Public Property [HoursFirstDay] As Double?
		'''<summary>Hours of absence on the last day</summary>
		Public Property [HoursLastDay] As Double?
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Last modified date</summary>
		Public Property [Modified] As DateTime
		'''<summary>User ID of modifier</summary>
		Public Property [Modifier] As Guid?
		'''<summary>Name of modifier</summary>
		Public Property [ModifierFullName] As String
		'''<summary>Extra information for absence</summary>
		Public Property [Notes] As String
		'''<summary>Notification moment of absence</summary>
		Public Property [NotificationMoment] As DateTime
		'''<summary>Percentage disablement</summary>
		Public Property [PercentageDisablement] As Double
		'''<summary>Start date of absence</summary>
		Public Property [StartDate] As DateTime
		'''<summary>Start time on the first day of absence stored as DateTime, and the date should be ignored</summary>
		Public Property [StartTime] As DateTime?
		'''<summary>Status of absence, 0 = Open, 1 = Recovered</summary>
		Public Property [Status] As Int16
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [Costcenter]
		'''<summary>Indicates if the cost center is active: 0 = inactive 1 = active</summary>
		Public Property [Active] As Boolean?
		'''<summary>Code (user-defined ID)</summary>
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
		'''<summary>Description (text)</summary>
		Public Property [Description] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<summary>The end date by which the cost center has to be inactive</summary>
		Public Property [EndDate] As DateTime?
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
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [Costunit]
		'''<summary>Code (user-defined)</summary>
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
		'''<summary>Description (text)</summary>
		Public Property [Description] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<summary>The end date by which the cost unit has to be inactive</summary>
		Public Property [EndDate] As DateTime?
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
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [Department]
		'''<summary>Department Code</summary>
		Public Property [Code] As String
		'''<summary>Cost center Code</summary>
		Public Property [Costcenter] As String
		'''<summary>Cost center description</summary>
		Public Property [CostcenterDescription] As String
		'''<summary>Creation date</summary>
		Public Property [Created] As DateTime?
		'''<summary>User ID of creator</summary>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator</summary>
		Public Property [CreatorFullName] As String
		'''<summary>Department description</summary>
		Public Property [Description] As String
		'''<summary>Division code</summary>
		Public Property [Division] As Int32?
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Last modified date</summary>
		Public Property [Modified] As DateTime?
		'''<summary>User ID of modifier</summary>
		Public Property [Modifier] As Guid?
		'''<summary>Name of modifier</summary>
		Public Property [ModifierFullName] As String
		'''<summary>Explanation or extra information can be stored in the notes</summary>
		Public Property [Notes] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("Code")>
	Public Class [Division]
		'''<summary>Values: 0 = Not blocked 1 = Backup 2 = Conversion busy 3 = Conversion shadow 4 = Conversion waiting 5 = Copy data waiting 6 = Copy data buzy 100 = Wait for deletion 101 = Deleted 102 = Deletion failed</summary>
		Public Property [BlockingStatus] As Int32?
		'''<summary>First division classification. User should have access rights to view division classifications.</summary>
		Public Property [Class_01] As DivisionClass
		'''<summary>Second division classification. User should have access rights to view division classifications.</summary>
		Public Property [Class_02] As DivisionClass
		'''<summary>Third division classification. User should have access rights to view division classifications.</summary>
		Public Property [Class_03] As DivisionClass
		'''<summary>Fourth division classification. User should have access rights to view division classifications.</summary>
		Public Property [Class_04] As DivisionClass
		'''<summary>Fifth division classification. User should have access rights to view division classifications.</summary>
		Public Property [Class_05] As DivisionClass
		'''<summary>Primary key</summary>
		Public Property [Code] As Int32
		'''<summary>Country of the division. Is used for determination of legislation</summary>
		Public Property [Country] As String
		'''<summary>Description of Country</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CountryDescription] As String
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<summary>User ID of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of the creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>Default currency of the division</summary>
		Public Property [Currency] As String
		'''<summary>Description of Currency</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CurrencyDescription] As String
		'''<summary>Owner account of the division</summary>
		Public Property [Customer] As Guid?
		'''<summary>Owner account code of the division</summary>
		Public Property [CustomerCode] As String
		'''<summary>Owner account name of the division</summary>
		Public Property [CustomerName] As String
		'''<summary>Description</summary>
		Public Property [Description] As String
		'''<summary>Number that customers give to the division</summary>
		Public Property [HID] As Int64?
		'''<summary>True for the main (hosting) division</summary>
		Public Property [Main] As Boolean?
		'''<summary>Last modified date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<summary>User ID of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Name of the last modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>Siret Number of the division (France)</summary>
		Public Property [SiretNumber] As String
		'''<summary>Date on which the division becomes active</summary>
		Public Property [StartDate] As DateTime?
		'''<summary>Regular administrations will have status 0.  Currently, the only other possibility is &apos;archived&apos; (1), which means the administration is not actively used, but still needs to be accessible for the customer/accountant to meet legal obligations</summary>
		Public Property [Status] As Int16?
		'''<summary>Number of your local tax authority (Germany)</summary>
		Public Property [TaxOfficeNumber] As String
		'''<summary>Local tax reference number (Germany)</summary>
		Public Property [TaxReferenceNumber] As String
		'''<summary>VAT number</summary>
		Public Property [VATNumber] As String
		'''<summary>Customer value, hyperlink to external website</summary>
		Public Property [Website] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [DivisionClass]
		'''<summary>Classification customer ID</summary>
		Public Property [ClassNameCustomer] As Guid
		'''<summary>Related classification description</summary>
		Public Property [ClassNameDescription] As String
		'''<summary>Related classification ID</summary>
		Public Property [ClassNameID] As Guid
		'''<summary>Property code</summary>
		Public Property [Code] As String
		'''<summary>Creation date</summary>
		Public Property [Created] As DateTime
		'''<summary>User ID of creator</summary>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator</summary>
		Public Property [CreatorFullName] As String
		'''<summary>Property description</summary>
		Public Property [Description] As String
		'''<summary>Property description term ID</summary>
		Public Property [DescriptionTermID] As Int32?
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Last modified date</summary>
		Public Property [Modified] As DateTime
		'''<summary>User ID of modifier</summary>
		Public Property [Modifier] As Guid?
		'''<summary>Name of modifier</summary>
		Public Property [ModifierFullName] As String
		'''<summary>Related classification sequence number </summary>
		Public Property [SequenceNr] As Int32
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [DivisionClassName]
		'''<summary>Creation date</summary>
		Public Property [Created] As DateTime
		'''<summary>User ID of creator</summary>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator</summary>
		Public Property [CreatorFullName] As String
		'''<summary>ID of customer</summary>
		Public Property [Customer] As Guid
		'''<summary>Description of classification</summary>
		Public Property [Description] As String
		'''<summary>Term ID of the classification</summary>
		Public Property [DescriptionTermID] As Int32?
		'''<summary>Collection of classification properties</summary>
		Public Property [DivisionClasses] As IEnumerable(Of Models.HRM.DivisionClass)
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Last modified date</summary>
		Public Property [Modified] As DateTime
		'''<summary>User ID of modifier</summary>
		Public Property [Modifier] As Guid?
		'''<summary>Name of modifier</summary>
		Public Property [ModifierFullName] As String
		'''<summary>Sequence number</summary>
		Public Property [SequenceNr] As Int32
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [DivisionClassValue]
		'''<summary>First classification</summary>
		Public Property [Class_01] As DivisionClass
		'''<summary>First classification ID</summary>
		Public Property [Class_01_ID] As Guid?
		'''<summary>Second classification</summary>
		Public Property [Class_02] As DivisionClass
		'''<summary>Second classification ID</summary>
		Public Property [Class_02_ID] As Guid?
		'''<summary>Third classification</summary>
		Public Property [Class_03] As DivisionClass
		'''<summary>Third classification ID</summary>
		Public Property [Class_03_ID] As Guid?
		'''<summary>Fourth classification</summary>
		Public Property [Class_04] As DivisionClass
		'''<summary>Fourth classification ID</summary>
		Public Property [Class_04_ID] As Guid?
		'''<summary>Fifth classification</summary>
		Public Property [Class_05] As DivisionClass
		'''<summary>Fifth classification ID</summary>
		Public Property [Class_05_ID] As Guid?
		'''<summary>Creation date</summary>
		Public Property [Created] As DateTime
		'''<summary>User ID of creator</summary>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator</summary>
		Public Property [CreatorFullName] As String
		'''<summary>ID of customer</summary>
		Public Property [Customer] As Guid
		'''<summary>Division code</summary>
		Public Property [Division] As Int32
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Last modified date</summary>
		Public Property [Modified] As DateTime
		'''<summary>User ID of modifier</summary>
		Public Property [Modifier] As Guid?
		'''<summary>Name of modifier</summary>
		Public Property [ModifierFullName] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [JobGroup]
		'''<summary>Job group code</summary>
		Public Property [Code] As String
		'''<summary>Creation date</summary>
		Public Property [Created] As DateTime?
		'''<summary>User ID of creator</summary>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator</summary>
		Public Property [CreatorFullName] As String
		'''<summary>Job group description</summary>
		Public Property [Description] As String
		'''<summary>Division code</summary>
		Public Property [Division] As Int32?
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Last modified date</summary>
		Public Property [Modified] As DateTime?
		'''<summary>User ID of modifier</summary>
		Public Property [Modifier] As Guid?
		'''<summary>Name of modifier</summary>
		Public Property [ModifierFullName] As String
		'''<summary>Explanation or extra information can be stored in the notes</summary>
		Public Property [Notes] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [JobTitle]
		'''<summary>Job title code</summary>
		Public Property [Code] As String
		'''<summary>Creation date</summary>
		Public Property [Created] As DateTime?
		'''<summary>User ID of creator</summary>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator</summary>
		Public Property [CreatorFullName] As String
		'''<summary>Job title description</summary>
		Public Property [Description] As String
		'''<summary>Division code</summary>
		Public Property [Division] As Int32?
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Reference job code</summary>
		Public Property [JobCode] As String
		'''<summary>Group this job title belongs to</summary>
		Public Property [JobGroup] As Guid?
		'''<summary>Job group code</summary>
		Public Property [JobGroupCode] As String
		'''<summary>Job group description</summary>
		Public Property [JobGroupDescription] As String
		'''<summary>Job title represents job level from</summary>
		Public Property [JobLevelFrom] As Int32?
		'''<summary>Job title represents job level to</summary>
		Public Property [JobLevelTo] As Int32?
		'''<summary>Last modified date</summary>
		Public Property [Modified] As DateTime?
		'''<summary>User ID of modifier</summary>
		Public Property [Modifier] As Guid?
		'''<summary>Name of modifier</summary>
		Public Property [ModifierFullName] As String
		'''<summary>Explanation or extra information can be stored in the notes</summary>
		Public Property [Notes] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [LeaveBuildUpRegistration]
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime
		'''<summary>User ID of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>Date of leave build up</summary>
		Public Property [Date] As DateTime
		'''<summary>Description of leave build up</summary>
		Public Property [Description] As String
		'''<summary>Division code</summary>
		Public Property [Division] As Int32?
		'''<summary>Employee linked to the leave build up</summary>
		Public Property [Employee] As Guid
		'''<summary>Employee full name</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [EmployeeFullName] As String
		'''<summary>Numeric ID of the employee</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [EmployeeHID] As Int32
		'''<summary>Total number of leave build up hours</summary>
		Public Property [Hours] As Double
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Type of leave</summary>
		Public Property [LeaveType] As Guid
		'''<summary>Code for type of leave</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [LeaveTypeCode] As String
		'''<summary>Description for type of leave</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [LeaveTypeDescription] As String
		'''<summary>Last modified date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime
		'''<summary>User ID of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Name of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>Extra information for leave build up</summary>
		Public Property [Notes] As String
		'''<summary>Status of leave build up, 1 = Submitted, 2 = Approved, 3 = Rejected</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Status] As Int16
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [LeaveRegistration]
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime
		'''<summary>User ID of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>Description of leave</summary>
		Public Property [Description] As String
		'''<summary>Division code</summary>
		Public Property [Division] As Int32?
		'''<summary>Employee linked to the leave registration</summary>
		Public Property [Employee] As Guid
		'''<summary>Employee full name</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [EmployeeFullName] As String
		'''<summary>Numeric ID of the employee</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [EmployeeHID] As Int32
		'''<summary>End date of leave</summary>
		Public Property [EndDate] As DateTime
		'''<summary>End time on the last day of leave stored as DateTime, and the date should be ignored</summary>
		Public Property [EndTime] As DateTime?
		'''<summary>Total number of leave hours</summary>
		Public Property [Hours] As Double
		'''<summary>Hours of leave on the first day</summary>
		Public Property [HoursFirstDay] As Double?
		'''<summary>Hours of leave on the last day</summary>
		Public Property [HoursLastDay] As Double?
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Type of leave</summary>
		Public Property [LeaveType] As Guid
		'''<summary>Code for type of leave</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [LeaveTypeCode] As String
		'''<summary>Description for type of leave</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [LeaveTypeDescription] As String
		'''<summary>Last modified date</summary>
		Public Property [Modified] As DateTime
		'''<summary>User ID of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Name of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>Extra information for leave</summary>
		Public Property [Notes] As String
		'''<summary>Start date of leave</summary>
		Public Property [StartDate] As DateTime
		'''<summary>Start time on the first day of leave stored as DateTime, and the date should be ignored</summary>
		Public Property [StartTime] As DateTime?
		'''<summary>Status of leave, 1 = Submitted, 2 = Approved, 3 = Rejected</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Status] As Int16
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [Schedule]
		'''<summary>Obsolete</summary>
		Public Property [Active] As Byte?
		'''<summary>Average hours per week in a schedule</summary>
		Public Property [AverageHours] As Double?
		'''<summary>Schedule code</summary>
		Public Property [Code] As String
		'''<summary>Creation date</summary>
		Public Property [Created] As DateTime?
		'''<summary>ID of creator</summary>
		Public Property [Creator] As Guid?
		'''<summary>Name of the creator</summary>
		Public Property [CreatorFullName] As String
		'''<summary>Average days per week in the schedule</summary>
		Public Property [Days] As Double?
		'''<summary>Description of the schedule</summary>
		Public Property [Description] As String
		'''<summary>Division code</summary>
		Public Property [Division] As Int32?
		'''<summary>Employment ID for schedule</summary>
		Public Property [Employment] As Guid?
		'''<summary>Employment number</summary>
		Public Property [EmploymentHID] As Int32?
		'''<summary>End date of the schedule</summary>
		Public Property [EndDate] As DateTime?
		'''<summary>Number of hours per week in a CLA for which the schedule is built</summary>
		Public Property [Hours] As Double?
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Number of hours which are built up each week for later leave</summary>
		Public Property [LeaveHoursCompensation] As Double?
		'''<summary>Indication if the schedule is a main schedule for a CLA. 1 = Yes, 0 = No</summary>
		Public Property [Main] As Byte?
		'''<summary>Last modified date</summary>
		Public Property [Modified] As DateTime?
		'''<summary>ID of modifier</summary>
		Public Property [Modifier] As Guid?
		'''<summary>Name of the modifier</summary>
		Public Property [ModifierFullName] As String
		'''<summary>Part-time factor for payroll calculation. Value between 0 and 1</summary>
		Public Property [PaymentParttimeFactor] As Double?
		'''<summary>Type of schedule. 1 = Hours and average days, 2 = Hours and specific days, 3 = Hours per day, 4 = Time frames per day</summary>
		Public Property [ScheduleType] As Int32?
		'''<summary>Description of the schedule type</summary>
		Public Property [ScheduleTypeDescription] As String
		'''<summary>Week in the schedule which is used to start with. By default the number will be 1.</summary>
		Public Property [StartDate] As DateTime?
		'''<summary>Week to start the schedule from for an employee</summary>
		Public Property [StartWeek] As Int32?
	End Class

End Namespace