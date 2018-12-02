Namespace Payroll

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [ActiveEmployment]
		'''<summary>The average number of contract days that an employee works per week</summary>
		Public Property [AverageDaysPerWeek] As Double?
		'''<summary>The average number of contract hours that an employee works per week</summary>
		Public Property [AverageHoursPerWeek] As Double?
		'''<summary>Employment contract ID</summary>
		Public Property [Contract] As Guid?
		'''<summary>Document ID of the employment contract</summary>
		Public Property [ContractDocument] As Guid?
		'''<summary>End date of employment contract</summary>
		Public Property [ContractEndDate] As DateTime?
		'''<summary>Employment probation end date</summary>
		Public Property [ContractProbationEndDate] As DateTime?
		'''<summary>Employment probation period</summary>
		Public Property [ContractProbationPeriod] As Int32?
		'''<summary>Start date of employment contract</summary>
		Public Property [ContractStartDate] As DateTime?
		'''<summary>Type of employment contract. 1 - Definite, 2 - Indefinite, 3 - External</summary>
		Public Property [ContractType] As Int32?
		'''<summary>Description of employment contract type</summary>
		Public Property [ContractTypeDescription] As String
		'''<summary>Creation date</summary>
		Public Property [Created] As DateTime?
		'''<summary>User ID of creator</summary>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator</summary>
		Public Property [CreatorFullName] As String
		'''<summary>Department of employee</summary>
		Public Property [Department] As Guid?
		'''<summary>Department code of employee</summary>
		Public Property [DepartmentCode] As String
		'''<summary>Description of department</summary>
		Public Property [DepartmentDescription] As String
		'''<summary>Division code</summary>
		Public Property [Division] As Int32?
		'''<summary>Employee ID</summary>
		Public Property [Employee] As Guid?
		'''<summary>Name of employee</summary>
		Public Property [EmployeeFullName] As String
		'''<summary>Numeric number of Employee</summary>
		Public Property [EmployeeHID] As Int32?
		'''<summary>Organization of employment</summary>
		Public Property [EmploymentOrganization] As Guid?
		'''<summary>End date of employment</summary>
		Public Property [EndDate] As DateTime?
		'''<summary>Numeric ID of the employment</summary>
		Public Property [HID] As Int32?
		'''<summary>Hourly wage</summary>
		Public Property [HourlyWage] As Double?
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Internal rate for time &amp; billing or professional service user</summary>
		Public Property [InternalRate] As Double?
		'''<summary>Job title of employee</summary>
		Public Property [Jobtitle] As Guid?
		'''<summary>Description of job title</summary>
		Public Property [JobtitleDescription] As String
		'''<summary>Last modified date</summary>
		Public Property [Modified] As DateTime?
		'''<summary>User ID of modifier</summary>
		Public Property [Modifier] As Guid?
		'''<summary>Name of modifier</summary>
		Public Property [ModifierFullName] As String
		'''<summary>ID of employment ended</summary>
		Public Property [ReasonEnd] As Int32?
		'''<summary>Reason of end of employment</summary>
		Public Property [ReasonEndDescription] As String
		'''<summary>Reason of ended flexible employment</summary>
		Public Property [ReasonEndFlex] As Int32?
		'''<summary>Other reason for end of employment</summary>
		Public Property [ReasonEndFlexDescription] As String
		'''<summary>Employment salary</summary>
		Public Property [Salary] As Guid?
		'''<summary>Work schedule</summary>
		Public Property [Schedule] As Guid?
		'''<summary>Average hours per week in a schedule.</summary>
		Public Property [ScheduleAverageHours] As Double?
		'''<summary>Work schedule code</summary>
		Public Property [ScheduleCode] As String
		'''<summary>Number of days of work per week</summary>
		Public Property [ScheduleDays] As Double?
		'''<summary>Description of work schedule</summary>
		Public Property [ScheduleDescription] As String
		'''<summary>Number of work hours per week.</summary>
		Public Property [ScheduleHours] As Double?
		'''<summary>Start date of employment</summary>
		Public Property [StartDate] As DateTime?
		'''<summary>Start date of the employee in the organization. This field is used to count the years in service.</summary>
		Public Property [StartDateOrganization] As DateTime?
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [Employee]
		'''<summary>Obsolete</summary>
		Public Property [ActiveEmployment] As Byte?
		'''<summary>Second address line</summary>
		Public Property [AddressLine2] As String
		'''<summary>Third address line</summary>
		Public Property [AddressLine3] As String
		'''<summary>Street of address</summary>
		Public Property [AddressStreet] As String
		'''<summary>Street number of address</summary>
		Public Property [AddressStreetNumber] As String
		'''<summary>Street number suffix of address</summary>
		Public Property [AddressStreetNumberSuffix] As String
		'''<summary>Birth date</summary>
		Public Property [BirthDate] As DateTime?
		'''<summary>Birth name</summary>
		Public Property [BirthName] As String
		'''<summary>Birth middle name</summary>
		Public Property [BirthNamePrefix] As String
		'''<summary>Birth place</summary>
		Public Property [BirthPlace] As String
		'''<summary>Email of the employee at the office</summary>
		Public Property [BusinessEmail] As String
		'''<summary>Fax number of the employee at the office</summary>
		Public Property [BusinessFax] As String
		'''<summary>Office mobile number of the employee</summary>
		Public Property [BusinessMobile] As String
		'''<summary>Phone number of the employee at the office</summary>
		Public Property [BusinessPhone] As String
		'''<summary>Phone extension of the employee at the office</summary>
		Public Property [BusinessPhoneExtension] As String
		'''<summary>Obsolete</summary>
		Public Property [CASONumber] As String
		'''<summary>City</summary>
		Public Property [City] As String
		'''<summary>Code of the employee</summary>
		Public Property [Code] As String
		'''<summary>Country code</summary>
		Public Property [Country] As String
		'''<summary>Creation date</summary>
		Public Property [Created] As DateTime?
		'''<summary>User ID of creator</summary>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator</summary>
		Public Property [CreatorFullName] As String
		'''<summary>Customer ID</summary>
		Public Property [Customer] As Guid?
		'''<summary>Division code</summary>
		Public Property [Division] As Int32?
		'''<summary>Email address</summary>
		Public Property [Email] As String
		'''<summary>Employee number</summary>
		Public Property [EmployeeHID] As Int32?
		'''<summary>End date of the employee</summary>
		Public Property [EndDate] As DateTime?
		'''<summary>First name of the employee</summary>
		Public Property [FirstName] As String
		'''<summary>Full name of the employee</summary>
		Public Property [FullName] As String
		'''<summary>Gender</summary>
		Public Property [Gender] As String
		'''<summary>Numeric ID of the employee</summary>
		Public Property [HID] As Int32?
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Initials</summary>
		Public Property [Initials] As String
		'''<summary>IsActive</summary>
		Public Property [IsActive] As Boolean
		'''<summary>Indicates whether the employee is anonymised.</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsAnonymised] As Byte
		'''<summary>Language code</summary>
		Public Property [Language] As String
		'''<summary>Last name</summary>
		Public Property [LastName] As String
		'''<summary>Description of the location of the employee (where am I?)</summary>
		Public Property [LocationDescription] As String
		'''<summary>Direct manager of the employee</summary>
		Public Property [Manager] As Guid?
		'''<summary>Date of marriage</summary>
		Public Property [MaritalDate] As DateTime?
		'''<summary>Marital status</summary>
		Public Property [MaritalStatus] As Int16?
		'''<summary>Middle name</summary>
		Public Property [MiddleName] As String
		'''<summary>Mobile phone</summary>
		Public Property [Mobile] As String
		'''<summary>Last modified date</summary>
		Public Property [Modified] As DateTime?
		'''<summary>User ID of modifier</summary>
		Public Property [Modifier] As Guid?
		'''<summary>Name of modifier</summary>
		Public Property [ModifierFullName] As String
		'''<summary>Municipality</summary>
		Public Property [Municipality] As String
		Public Property [NameComposition] As Int16?
		'''<summary>Nationality</summary>
		Public Property [Nationality] As String
		'''<summary>Nick name</summary>
		Public Property [NickName] As String
		'''<summary>Additional notes</summary>
		Public Property [Notes] As String
		'''<summary>Name of partner</summary>
		Public Property [PartnerName] As String
		'''<summary>Middle name of partner</summary>
		Public Property [PartnerNamePrefix] As String
		'''<summary>Reference to the persons table in which the personal data of the employee is stored</summary>
		Public Property [Person] As Guid?
		'''<summary>Phone number</summary>
		Public Property [Phone] As String
		'''<summary>Phone number extension</summary>
		Public Property [PhoneExtension] As String
		'''<summary>Filename of picture</summary>
		Public Property [PictureFileName] As String
		'''<summary>Url of picture</summary>
		Public Property [PictureUrl] As String
		'''<summary>Postcode</summary>
		Public Property [Postcode] As String
		'''<summary>Private email address</summary>
		Public Property [PrivateEmail] As String
		'''<summary>Social security number</summary>
		Public Property [SocialSecurityNumber] As String
		'''<summary>Start date of the employee</summary>
		Public Property [StartDate] As DateTime?
		'''<summary>State</summary>
		Public Property [State] As String
		'''<summary>Title</summary>
		Public Property [Title] As String
		'''<summary>User ID of employee</summary>
		Public Property [User] As Guid?
		'''<summary>Name of user</summary>
		Public Property [UserFullName] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [Employment]
		'''<summary>Creation date</summary>
		Public Property [Created] As DateTime?
		'''<summary>User ID of creator</summary>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator</summary>
		Public Property [CreatorFullName] As String
		'''<summary>Division code</summary>
		Public Property [Division] As Int32?
		'''<summary>Employee ID</summary>
		Public Property [Employee] As Guid?
		'''<summary>Name of employee</summary>
		Public Property [EmployeeFullName] As String
		'''<summary>Numeric number of Employee</summary>
		Public Property [EmployeeHID] As Int32?
		'''<summary>End date of employment</summary>
		Public Property [EndDate] As DateTime?
		'''<summary>Numeric ID of the employment</summary>
		Public Property [HID] As Int32?
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Last modified date</summary>
		Public Property [Modified] As DateTime?
		'''<summary>User ID of modifier</summary>
		Public Property [Modifier] As Guid?
		'''<summary>Name of modifier</summary>
		Public Property [ModifierFullName] As String
		'''<summary>ID of employment ended</summary>
		Public Property [ReasonEnd] As Int32?
		'''<summary>Reason of end of employment</summary>
		Public Property [ReasonEndDescription] As String
		'''<summary>Reason of ended flexible employment</summary>
		Public Property [ReasonEndFlex] As Int32?
		'''<summary>Other reason for end of employment</summary>
		Public Property [ReasonEndFlexDescription] As String
		'''<summary>Start date of employment</summary>
		Public Property [StartDate] As DateTime?
		'''<summary>Start date of the employee in the organization. This field is used to count the years in service.</summary>
		Public Property [StartDateOrganization] As DateTime?
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [EmploymentContract]
		'''<summary>Flexible employment contract phase</summary>
		Public Property [ContractFlexPhase] As Int32?
		'''<summary>Flexible employment contract phase description.</summary>
		Public Property [ContractFlexPhaseDescription] As String
		'''<summary>Creation date</summary>
		Public Property [Created] As DateTime?
		'''<summary>User ID of creator</summary>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator</summary>
		Public Property [CreatorFullName] As String
		'''<summary>Division code</summary>
		Public Property [Division] As Int32?
		'''<summary>Document ID of the employment contract</summary>
		Public Property [Document] As Guid?
		'''<summary>ID of employee</summary>
		Public Property [Employee] As Guid?
		'''<summary>Name of employee</summary>
		Public Property [EmployeeFullName] As String
		'''<summary>Numeric ID of the employee</summary>
		Public Property [EmployeeHID] As Int32?
		'''<summary>Type of employee. 1 - Employee, 2 - Contractor, 3 - Temporary, 4 - Student, 5 - Flexworker</summary>
		Public Property [EmployeeType] As Int32?
		'''<summary>Employee type description</summary>
		Public Property [EmployeeTypeDescription] As String
		'''<summary>Employment ID</summary>
		Public Property [Employment] As Guid?
		'''<summary>Numeric ID of the employment</summary>
		Public Property [EmploymentHID] As Int32?
		'''<summary>End date of employment contract</summary>
		Public Property [EndDate] As DateTime?
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Last modified date</summary>
		Public Property [Modified] As DateTime?
		'''<summary>User ID of modifier</summary>
		Public Property [Modifier] As Guid?
		'''<summary>Name of modifier</summary>
		Public Property [ModifierFullName] As String
		'''<summary>Notes of employment contract</summary>
		Public Property [Notes] As String
		'''<summary>Employment probation end date</summary>
		Public Property [ProbationEndDate] As DateTime?
		'''<summary>Employment probation period</summary>
		Public Property [ProbationPeriod] As Int32?
		'''<summary>Employment contract reason code. 1 - New employment, 2 - Employment change, 3 - New legal employer, 4 - Acquisition 5 - Previous contract expired, 6 - Other</summary>
		Public Property [ReasonContract] As Int32?
		'''<summary>Employment contract reason description</summary>
		Public Property [ReasonContractDescription] As String
		'''<summary>Sequence number</summary>
		Public Property [Sequence] As Int32?
		'''<summary>Start date of employment contract</summary>
		Public Property [StartDate] As DateTime?
		'''<summary>Type of employment contract. 1 - Definite, 2 - Indefinite, 3 - External</summary>
		Public Property [Type] As Int32?
		'''<summary>Description of employment contract type</summary>
		Public Property [TypeDescription] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [EmploymentContractFlexPhas]
		'''<summary>Flexible employment contract phase description</summary>
		Public Property [Description] As String
		'''<summary>Primary key</summary>
		Public Property [ID] As Int32
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [EmploymentEndReason]
		'''<summary>Employment end reason description</summary>
		Public Property [Description] As String
		'''<summary>Primary key</summary>
		Public Property [ID] As Int32
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [EmploymentOrganization]
		'''<summary>Cost center code</summary>
		Public Property [CostCenter] As String
		'''<summary>Description of cost center</summary>
		Public Property [CostCenterDescription] As String
		'''<summary>Cost unit code</summary>
		Public Property [CostUnit] As String
		'''<summary>Description of cost unit</summary>
		Public Property [CostUnitDescription] As String
		'''<summary>Creation date</summary>
		Public Property [Created] As DateTime?
		'''<summary>User ID of creator</summary>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator</summary>
		Public Property [CreatorFullName] As String
		'''<summary>ID of department</summary>
		Public Property [Department] As Guid?
		'''<summary>Department code</summary>
		Public Property [DepartmentCode] As String
		'''<summary>Department description for organization</summary>
		Public Property [DepartmentDescription] As String
		'''<summary>Division code</summary>
		Public Property [Division] As Int32?
		'''<summary>ID of employee</summary>
		Public Property [Employee] As Guid?
		'''<summary>Name of employee</summary>
		Public Property [EmployeeFullName] As String
		'''<summary>Numeric ID of the employee</summary>
		Public Property [EmployeeHID] As Int32?
		'''<summary>Employement ID</summary>
		Public Property [Employment] As Guid?
		'''<summary>Numeric ID of the employment</summary>
		Public Property [EmploymentHID] As Int32?
		'''<summary>Organization end date</summary>
		Public Property [EndDate] As DateTime?
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>ID of job title</summary>
		Public Property [JobTitle] As Guid?
		'''<summary>Job title code</summary>
		Public Property [JobTitleCode] As String
		'''<summary>Job title description</summary>
		Public Property [JobTitleDescription] As String
		'''<summary>Last modified date</summary>
		Public Property [Modified] As DateTime?
		'''<summary>User ID of modifier</summary>
		Public Property [Modifier] As Guid?
		'''<summary>Name of modifier</summary>
		Public Property [ModifierFullName] As String
		'''<summary>Explanation or extra information can be stored in the notes</summary>
		Public Property [Notes] As String
		'''<summary>Organization start date</summary>
		Public Property [StartDate] As DateTime?
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [EmploymentSalary]
		'''<summary>The average number of contract days that an employee works per week</summary>
		Public Property [AverageDaysPerWeek] As Double?
		'''<summary>The average number of contract hours that an employee works per week</summary>
		Public Property [AverageHoursPerWeek] As Double?
		'''<summary>Creation date</summary>
		Public Property [Created] As DateTime?
		'''<summary>User ID of creator</summary>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator</summary>
		Public Property [CreatorFullName] As String
		'''<summary>Division code</summary>
		Public Property [Division] As Int32?
		'''<summary>Employee ID</summary>
		Public Property [Employee] As Guid?
		'''<summary>Name of employee</summary>
		Public Property [EmployeeFullName] As String
		'''<summary>Employee number</summary>
		Public Property [EmployeeHID] As Int32?
		'''<summary>Employment</summary>
		Public Property [Employment] As Guid?
		'''<summary>Employment number</summary>
		Public Property [EmploymentHID] As Int32?
		'''<summary>Salary type of employment. 1 - Periodical (fixed), 2 - Per hour (variable)</summary>
		Public Property [EmploymentSalaryType] As Int32?
		'''<summary>Salary type description</summary>
		Public Property [EmploymentSalaryTypeDescription] As String
		'''<summary>Salary record end date</summary>
		Public Property [EndDate] As DateTime?
		'''<summary>Salary when working fulltime</summary>
		Public Property [FulltimeAmount] As Double?
		'''<summary>Hourly wage</summary>
		Public Property [HourlyWage] As Double?
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Internal rate for time &amp; billing or professional service user</summary>
		Public Property [InternalRate] As Double?
		'''<summary>Employee job level in context of a wage scale</summary>
		Public Property [JobLevel] As Int32?
		'''<summary>Last modified date</summary>
		Public Property [Modified] As DateTime?
		'''<summary>User ID of modifier</summary>
		Public Property [Modifier] As Guid?
		'''<summary>Name of modifier</summary>
		Public Property [ModifierFullName] As String
		'''<summary>Salary when working parttime</summary>
		Public Property [ParttimeAmount] As Double?
		'''<summary>Contract hours / Fulltime contract hours</summary>
		Public Property [ParttimeFactor] As Double?
		'''<summary>Employee wage scale</summary>
		Public Property [Scale] As String
		'''<summary>Employment schedule</summary>
		Public Property [Schedule] As Guid?
		'''<summary>Employment schedule code</summary>
		Public Property [ScheduleCode] As String
		'''<summary>Description of employment schedule</summary>
		Public Property [ScheduleDescription] As String
		'''<summary>Salary record start date</summary>
		Public Property [StartDate] As DateTime?
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [TaxEmploymentEndFlexCode]
		'''<summary>Code of flexible employment contract phase</summary>
		Public Property [Code] As String
		'''<summary>Creation date</summary>
		Public Property [Created] As DateTime?
		'''<summary>User ID of creator</summary>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator</summary>
		Public Property [CreatorFullName] As String
		'''<summary>Description of flexible employment contract phase</summary>
		Public Property [Description] As String
		'''<summary>End date of flexible employment contract</summary>
		Public Property [EndDate] As DateTime?
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Last modified date</summary>
		Public Property [Modified] As DateTime?
		'''<summary>User ID of modifier</summary>
		Public Property [Modifier] As Guid?
		'''<summary>Name of modifier</summary>
		Public Property [ModifierFullName] As String
		'''<summary>Start date of flexible employment contract phase</summary>
		Public Property [StartDate] As DateTime?
	End Class

End Namespace