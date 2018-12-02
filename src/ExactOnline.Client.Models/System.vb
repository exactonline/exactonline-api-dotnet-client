Namespace System

    <SupportedActionsSDK(False, True, False, False)>
    <DataServiceKey("ID")>
    Public Class [AccountantInfo]
        '''<summary>First address line.</summary>
        Public Property [AddressLine1] As String
        '''<summary>Second address line.</summary>
        Public Property [AddressLine2] As String
        '''<summary>Third address line.</summary>
        Public Property [AddressLine3] As String
        '''<summary>City.</summary>
        Public Property [City] As String
        '''<summary>Email.</summary>
        Public Property [Email] As String
        '''<summary>The account ID of the accountant.</summary>
        Public Property [ID] As Guid
        '''<summary>Indicates if the customer is an accountant himself.</summary>
        Public Property [IsAccountant] As Boolean
        '''<summary>Logo.</summary>
        Public Property [Logo] As Byte()
        '''<summary>Url to retrieve the logo of the accountant.</summary>
        Public Property [MenuLogoUrl] As String
        '''<summary>The name of the accountant.</summary>
        Public Property [Name] As String
        '''<summary>Phone.</summary>
        Public Property [Phone] As String
        '''<summary>Postcode.</summary>
        Public Property [Postcode] As String
        '''<summary>Website.</summary>
        Public Property [Website] As String
    End Class

    <SupportedActionsSDK(False, True, False, False)>
    <DataServiceKey("ID")>
    Public Class [AvailableFeature]
        '''<summary>The description of the feature.</summary>
        Public Property [Description] As String
        '''<summary>The ID of the feature.</summary>
        Public Property [ID] As Int32
    End Class

    <SupportedActionsSDK(False, True, False, False)>
    <DataServiceKey("Code")>
    Public Class [Division]
        '''<summary>Address line 1</summary>
        Public Property [AddressLine1] As String
        '''<summary>Address line 2</summary>
        Public Property [AddressLine2] As String
        '''<summary>Address line 3</summary>
        Public Property [AddressLine3] As String
        '''<summary>Values: 0 = Not blocked, 1 = Backup, 2 = Conversion busy, 3 = Conversion shadow, 4 = Conversion waiting, 5 = Copy data waiting, 6 = Copy data buzy, 100 = Wait for deletion, 101 = Deleted, 102 = Deletion failed</summary>
        Public Property [BlockingStatus] As Int32
        '''<summary>Business Type Code</summary>
        Public Property [BusinessTypeCode] As String
        '''<summary>Business Type Description</summary>
        Public Property [BusinessTypeDescription] As String
        '''<summary>Chamber of commerce establishment</summary>
        Public Property [ChamberOfCommerceEstablishment] As String
        '''<summary>Chamber of commerce number</summary>
        Public Property [ChamberOfCommerceNumber] As String
        '''<summary>City</summary>
        Public Property [City] As String
        '''<summary>First division classification. User should have access rights to view division classifications.</summary>
        Public Property [Class_01] As HRM.DivisionClass
        '''<summary>Second division classification. User should have access rights to view division classifications.</summary>
        Public Property [Class_02] As HRM.DivisionClass
        '''<summary>Third division classification. User should have access rights to view division classifications.</summary>
        Public Property [Class_03] As HRM.DivisionClass
        '''<summary>Fourth division classification. User should have access rights to view division classifications.</summary>
        Public Property [Class_04] As HRM.DivisionClass
        '''<summary>Fifth division classification. User should have access rights to view division classifications.</summary>
        Public Property [Class_05] As HRM.DivisionClass
        '''<summary>Primary key</summary>
        Public Property [Code] As Int32
        '''<summary>Company Size Code</summary>
        Public Property [CompanySizeCode] As String
        '''<summary>Company Size Description</summary>
        Public Property [CompanySizeDescription] As String
        '''<summary>Country of the division. Is used for determination of legislation</summary>
        Public Property [Country] As String
        '''<summary>Creation date</summary>
        <SDKFieldType(FieldType.ReadOnly)>
        Public Property [Created] As DateTime
        '''<summary>User ID of creator</summary>
        <SDKFieldType(FieldType.ReadOnly)>
        Public Property [Creator] As Guid?
        '''<summary>Name of the creator</summary>
        <SDKFieldType(FieldType.ReadOnly)>
        Public Property [CreatorFullName] As String
        '''<summary>Default currency</summary>
        Public Property [Currency] As String
        '''<summary>True when this division is most recently used by the API</summary>
        Public Property [Current] As Boolean
        '''<summary>Owner account of the division</summary>
        Public Property [Customer] As Guid?
        '''<summary>Owner account code of the division</summary>
        Public Property [CustomerCode] As String
        '''<summary>Owner account name of the division</summary>
        Public Property [CustomerName] As String
        '''<summary>Accountant number DATEV (Germany)</summary>
        Public Property [DatevAccountantNumber] As String
        '''<summary>Client number DATEV (Germany)</summary>
        Public Property [DatevClientNumber] As String
        '''<summary>Description</summary>
        Public Property [Description] As String
        '''<summary>Email address</summary>
        Public Property [Email] As String
        '''<summary>Fax number</summary>
        Public Property [Fax] As String
        '''<summary>Company number that is assigned by the customer</summary>
        Public Property [Hid] As Int64
        '''<summary>True if the division is the main division</summary>
        Public Property [IsMainDivision] As Boolean
        '''<summary>Legislation</summary>
        <SDKFieldType(FieldType.ReadOnly)>
        Public Property [Legislation] As String
        '''<summary>Last modified date</summary>
        <SDKFieldType(FieldType.ReadOnly)>
        Public Property [Modified] As DateTime
        '''<summary>User ID of modifier</summary>
        <SDKFieldType(FieldType.ReadOnly)>
        Public Property [Modifier] As Guid?
        '''<summary>Name of the last modifier</summary>
        <SDKFieldType(FieldType.ReadOnly)>
        Public Property [ModifierFullName] As String
        '''<summary>Phone number</summary>
        Public Property [Phone] As String
        '''<summary>Postcode</summary>
        Public Property [Postcode] As String
        '''<summary>SBI Code</summary>
        Public Property [SbiCode] As String
        '''<summary>SBI Description</summary>
        Public Property [SbiDescription] As String
        '''<summary>Sector Code</summary>
        Public Property [SectorCode] As String
        '''<summary>Sector Description</summary>
        Public Property [SectorDescription] As String
        '''<summary>the part of the capital of a company that comes from the issue of shares (France)</summary>
        Public Property [ShareCapital] As Double?
        '''<summary>An INSEE code which allows the geographic identification of the company. (France)</summary>
        Public Property [SiretNumber] As String
        '''<summary>Date on which the division becomes active</summary>
        Public Property [StartDate] As DateTime?
        '''<summary>State/Province code</summary>
        Public Property [State] As String
        '''<summary>Follow the Division Status 0 for Inactive, 1 for Active and 2 for Archived Divisions</summary>
        Public Property [Status] As Int32
        '''<summary>Subsector Code</summary>
        Public Property [SubsectorCode] As String
        '''<summary>Subsector Description</summary>
        Public Property [SubsectorDescription] As String
        '''<summary>Number of your local tax authority (Germany)</summary>
        Public Property [TaxOfficeNumber] As String
        '''<summary>Local tax reference number (Germany)</summary>
        Public Property [TaxReferenceNumber] As String
        '''<summary>The number under which the account is known at the Value Added Tax collection agency</summary>
        Public Property [VATNumber] As String
        '''<summary>Customer value, hyperlink to external website</summary>
        Public Property [Website] As String
    End Class

End Namespace