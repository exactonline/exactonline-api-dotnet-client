Namespace Current

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("UserID")>
	Public Class [Me]
		'''<summary>Division number that is currently used in the API. You should use a division number in the url</summary>
		Public Property [CurrentDivision] As Int32
		'''<summary>Owner account of the division</summary>
		Public Property [DivisionCustomer] As Guid?
		'''<summary>Owner account code of the division</summary>
		Public Property [DivisionCustomerCode] As String
		'''<summary>Owner account name of the division</summary>
		Public Property [DivisionCustomerName] As String
		'''<summary>Owner account SIRET Number of the division for French legislation</summary>
		Public Property [DivisionCustomerSiretNumber] As String
		'''<summary>Owner account VAT Number of the division</summary>
		Public Property [DivisionCustomerVatNumber] As String
		'''<summary>Email address of the user</summary>
		Public Property [Email] As String
		'''<summary>Employee ID</summary>
		Public Property [EmployeeID] As Guid
		'''<summary>First name</summary>
		Public Property [FirstName] As String
		'''<summary>Full name of the user</summary>
		Public Property [FullName] As String
		'''<summary>Gender: M=Male, V=Female, O=Unknown</summary>
		Public Property [Gender] As String
		'''<summary>Initials</summary>
		Public Property [Initials] As String
		'''<summary>Language spoken by this user</summary>
		Public Property [Language] As String
		'''<summary>Language (culture) that is used in Exact Online</summary>
		Public Property [LanguageCode] As String
		'''<summary>Last name</summary>
		Public Property [LastName] As String
		'''<summary>Legislation</summary>
		Public Property [Legislation] As Int64
		'''<summary>Middle name</summary>
		Public Property [MiddleName] As String
		'''<summary>Mobile phone</summary>
		Public Property [Mobile] As String
		'''<summary>Nationality</summary>
		Public Property [Nationality] As String
		'''<summary>Phone number</summary>
		Public Property [Phone] As String
		'''<summary>Phone number extension</summary>
		Public Property [PhoneExtension] As String
		'''<summary>Url that can be used to retrieve the picture of the user</summary>
		Public Property [PictureUrl] As String
		'''<summary>The current date and time in Exact Online</summary>
		Public Property [ServerTime] As String
		'''<summary>The time difference with UTC in seconds</summary>
		Public Property [ServerUtcOffset] As Double
		'''<summary>Binary thumbnail picture of this user</summary>
		Public Property [ThumbnailPicture] As Byte()
		'''<summary>File type of the picture</summary>
		Public Property [ThumbnailPictureFormat] As String
		'''<summary>Title</summary>
		Public Property [Title] As String
		'''<summary>Primary key</summary>
		Public Property [UserID] As Guid
		'''<summary>Login name of the user</summary>
		Public Property [UserName] As String
	End Class

End Namespace