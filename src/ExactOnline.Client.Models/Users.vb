Namespace Users

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("UserID")>
	Public Class [User]
		'''<summary>Birth date</summary>
		Public Property [BirthDate] As DateTime?
		'''<summary>Birth name</summary>
		Public Property [BirthName] As String
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<summary>User ID of the creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of the creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>Customer the user belongs to</summary>
		Public Property [Customer] As Guid
		'''<summary>Name of Customer</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CustomerName] As String
		'''<summary>Email address of the user</summary>
		Public Property [Email] As String
		'''<summary>Date after which the user login is disabled. NULL means no enddate</summary>
		Public Property [EndDate] As DateTime?
		'''<summary>First name</summary>
		Public Property [FirstName] As String
		'''<summary>Full name of the user</summary>
		Public Property [FullName] As String
		'''<summary>Gender: M=Male, V=Female, O=Unknown</summary>
		Public Property [Gender] As String
		'''<summary>User has completed registration of Two-Step verification</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [HasRegisteredForTwoStepVerification] As Boolean
		'''<summary>User must use Two-Step verification to log in</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [HasTwoStepVerification] As Boolean
		'''<summary>Initials</summary>
		Public Property [Initials] As String
		'''<summary>Indicates whether the user is anonymised.</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsAnonymised] As Byte
		'''<summary>Language (culture) that is used in Exact Online</summary>
		Public Property [Language] As String
		'''<summary>The last time this user logged in</summary>
		Public Property [LastLogin] As DateTime?
		'''<summary>Last name</summary>
		Public Property [LastName] As String
		'''<summary>Middle name</summary>
		Public Property [MiddleName] As String
		'''<summary>Mobile phone</summary>
		Public Property [Mobile] As String
		'''<summary>Last modified date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<summary>User ID of the last modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Name of the last modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>Nationality</summary>
		Public Property [Nationality] As String
		'''<summary>Remarks</summary>
		Public Property [Notes] As String
		'''<summary>Phone number</summary>
		Public Property [Phone] As String
		'''<summary>Phone number extension</summary>
		Public Property [PhoneExtension] As String
		'''<summary>Profile code</summary>
		Public Property [ProfileCode] As String
		'''<summary>Startdate after which the login is allowed. If the start date is NULL the login is allowed as well</summary>
		Public Property [StartDate] As DateTime?
		'''<summary>Start Division</summary>
		Public Property [StartDivision] As Int32
		'''<summary>Title</summary>
		Public Property [Title] As String
		'''<summary>Primary key</summary>
		Public Property [UserID] As Guid
		'''<summary>Login name of the user</summary>
		Public Property [UserName] As String
		'''<summary>Collection of user roles</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [UserRoles] As IEnumerable(Of Models.Accountancy.InvolvedUserRole)
		'''<summary>Collection of user roles per division</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [UserRolesPerDivision] As IEnumerable(Of Models.Users.UserRolesPerDivision)
		'''<summary>Obsolete</summary>
		Public Property [UserTypesList] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [UserRole]
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<summary>User ID of the creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of the creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>Description</summary>
		Public Property [Description] As String
		'''<summary>Indicates the date and time when te role becomes inactive for the user</summary>
		Public Property [EndDate] As DateTime?
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Last modified date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<summary>User ID of the last modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Name of the last modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>The role that the user is linked to</summary>
		Public Property [Role] As Int32
		'''<summary>Rolelevel sets the level on which a role for a user is active. This can be: 1 = Database, 2 = Customer, 3 = Division, 100 = Transferred to accountant</summary>
		Public Property [RoleLevel] As Int32
		'''<summary>Indicates the date when the role becomes active for the user</summary>
		Public Property [StartDate] As DateTime
		'''<summary>The user that is linked to the role</summary>
		Public Property [UserID] As Guid?
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [UserRolesPerDivision]
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<summary>User ID of the creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of the creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>Description</summary>
		Public Property [Description] As String
		'''<summary>Division code</summary>
		Public Property [Division] As Int32
		'''<summary>Indicates the date and time when te role becomes inactive for the user</summary>
		Public Property [EndDate] As DateTime?
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Last modified date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<summary>User ID of the last modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Name of the last modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>The role that the user is linked to</summary>
		Public Property [Role] As Int32
		'''<summary>Rolelevel sets the level on which a role for a user is active. This can be: 1 = Database, 2 = Customer, 3 = Division, 100 = Transferred to accountant</summary>
		Public Property [RoleLevel] As Int32
		'''<summary>Indicates the date when the role becomes active for the user</summary>
		Public Property [StartDate] As DateTime
		'''<summary>The user that is linked to the role</summary>
		Public Property [UserID] As Guid?
	End Class

End Namespace