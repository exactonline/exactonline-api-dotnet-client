Namespace Accountancy

    <SupportedActionsSDK(True, True, True, True)>
    <DataServiceKey("ID")>
    Public Class [AccountInvolvedAccount]
        '''<summary>ID of account</summary>
        Public Property [Account] As Guid?
        '''<summary>Name of account</summary>
        Public Property [AccountName] As String
        '''<summary>Creation date</summary>
        Public Property [Created] As DateTime?
        '''<summary>User ID of creator</summary>
        Public Property [Creator] As Guid?
        '''<summary>Name of creator</summary>
        Public Property [CreatorFullName] As String
        '''<summary>Division code</summary>
        Public Property [Division] As Int32?
        '''<summary>Primary key</summary>
        Public Property [ID] As Guid
        '''<summary>ID of involved account</summary>
        Public Property [InvolvedAccount] As Guid?
        '''<summary>Description of relation type</summary>
        Public Property [InvolvedAccountRelationTypeDescription] As String
        '''<summary>TermId of description of relation type</summary>
        Public Property [InvolvedAccountRelationTypeDescriptionTermId] As Int32?
        '''<summary>ID of relation type</summary>
        Public Property [InvolvedAccountRelationTypeId] As Int16?
        '''<summary>Last modified date</summary>
        Public Property [Modified] As DateTime?
        '''<summary>User ID of modifier</summary>
        Public Property [Modifier] As Guid?
        '''<summary>Name of modifier</summary>
        Public Property [ModifierFullName] As String
        '''<summary>Use to record details of important information</summary>
        Public Property [Notes] As String
    End Class

    <SupportedActionsSDK(True, True, True, True)>
    <DataServiceKey("ID")>
    Public Class [AccountOwner]
        '''<summary>ID of the account that is owned</summary>
        Public Property [Account] As Guid?
        '''<summary>Code of the account that is owned</summary>
        <SDKFieldType(FieldType.ReadOnly)>
        Public Property [AccountCode] As String
        '''<summary>Name of the account that is owned</summary>
        <SDKFieldType(FieldType.ReadOnly)>
        Public Property [AccountName] As String
        '''<summary>Creation date</summary>
        <SDKFieldType(FieldType.ReadOnly)>
        Public Property [Created] As DateTime?
        '''<summary>User ID of the creator</summary>
        Public Property [Creator] As Guid?
        '''<summary>Name of the creator</summary>
        <SDKFieldType(FieldType.ReadOnly)>
        Public Property [CreatorFullName] As String
        '''<summary>Division code</summary>
        Public Property [Division] As Int32?
        '''<summary>Primary key</summary>
        Public Property [ID] As Guid
        '''<summary>Last modified date</summary>
        <SDKFieldType(FieldType.ReadOnly)>
        Public Property [Modified] As DateTime?
        '''<summary>User ID of the modifier</summary>
        <SDKFieldType(FieldType.ReadOnly)>
        Public Property [Modifier] As Guid?
        '''<summary>Name of the modifier</summary>
        <SDKFieldType(FieldType.ReadOnly)>
        Public Property [ModifierFullName] As String
        '''<summary>ID of the account who owns specified account</summary>
        Public Property [OwnerAccount] As Guid?
        '''<summary>Code of the account who owns specified account</summary>
        <SDKFieldType(FieldType.ReadOnly)>
        Public Property [OwnerAccountCode] As String
        '''<summary>Name of the account who owns specified account</summary>
        <SDKFieldType(FieldType.ReadOnly)>
        Public Property [OwnerAccountName] As String
        '''<summary>Percentage of shares that is owned. 1 is 100%, 0.5 is 50%</summary>
        Public Property [Shares] As Double?
    End Class

    <SupportedActionsSDK(True, True, True, True)>
    <DataServiceKey("ID")>
    Public Class [InvolvedUser]
        '''<summary>ID of the account the user is involved with</summary>
        Public Property [Account] As Guid?
        '''<summary>City of the account</summary>
        Public Property [AccountCity] As String
        '''<summary>Code of the account</summary>
        <SDKFieldType(FieldType.ReadOnly)>
        Public Property [AccountCode] As String
        '''<summary>Supplier flag of the account</summary>
        <SDKFieldType(FieldType.ReadOnly)>
        Public Property [AccountIsSupplier] As Boolean?
        '''<summary>Logo thumbnail url of the account</summary>
        <SDKFieldType(FieldType.ReadOnly)>
        Public Property [AccountLogoThumbnailUrl] As String
        '''<summary>Name of the account</summary>
        <SDKFieldType(FieldType.ReadOnly)>
        Public Property [AccountName] As String
        '''<summary>Status of the account</summary>
        <SDKFieldType(FieldType.ReadOnly)>
        Public Property [AccountStatus] As String
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
        '''<summary>Primary key</summary>
        Public Property [ID] As Guid
        '''<summary>ID of the user role</summary>
        Public Property [InvolvedUserRole] As Guid?
        '''<summary>Description of the user role</summary>
        <SDKFieldType(FieldType.ReadOnly)>
        Public Property [InvolvedUserRoleDescription] As String
        '''<summary>Main contact flag of the involved user</summary>
        Public Property [IsMainContact] As Boolean?
        '''<summary>Last modified date</summary>
        <SDKFieldType(FieldType.ReadOnly)>
        Public Property [Modified] As DateTime?
        '''<summary>User ID of modifier</summary>
        <SDKFieldType(FieldType.ReadOnly)>
        Public Property [Modifier] As Guid?
        '''<summary>Name of modifier</summary>
        <SDKFieldType(FieldType.ReadOnly)>
        Public Property [ModifierFullName] As String
        '''<summary>Email of a person</summary>
        <SDKFieldType(FieldType.ReadOnly)>
        Public Property [PersonEmail] As String
        '''<summary>Phone of a person</summary>
        <SDKFieldType(FieldType.ReadOnly)>
        Public Property [PersonPhone] As String
        '''<summary>Phone extension of a person</summary>
        <SDKFieldType(FieldType.ReadOnly)>
        Public Property [PersonPhoneExtension] As String
        '''<summary>Picture thumbnail url of a person</summary>
        <SDKFieldType(FieldType.ReadOnly)>
        Public Property [PersonPictureThumbnailUrl] As String
        '''<summary>ID of the involved user</summary>
        Public Property [User] As Guid?
        '''<summary>User name of creator</summary>
        <SDKFieldType(FieldType.ReadOnly)>
        Public Property [UserFullName] As String
    End Class

    <SupportedActionsSDK(True, True, True, True)>
    <DataServiceKey("ID")>
    Public Class [InvolvedUserRole]
        '''<summary>Code of the involved user role</summary>
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
        '''<summary>Description of role</summary>
        Public Property [Description] As String
        '''<summary>Description term code of role</summary>
        Public Property [DescriptionTermID] As Int32?
        '''<summary>Division code</summary>
        <SDKFieldType(FieldType.ReadOnly)>
        Public Property [Division] As Int32?
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
    Public Class [SolutionLink]
        '''<summary>ID of account to which solution is linked</summary>
        Public Property [Account] As Guid
        '''<summary>Creation date</summary>
        <SDKFieldType(FieldType.ReadOnly)>
        Public Property [Created] As DateTime
        '''<summary>User ID of creator</summary>
        <SDKFieldType(FieldType.ReadOnly)>
        Public Property [Creator] As Guid?
        '''<summary>Accountant main division</summary>
        <SDKFieldType(FieldType.ReadOnly)>
        Public Property [Division] As Int32
        '''<summary>If type is external predefined, represents ID of PracticeManagementExternalSolutions (mandatory for External solution)</summary>
        Public Property [ExternalSolutionCode] As Int32?
        '''<summary>Name of the external solution</summary>
        <SDKFieldType(FieldType.ReadOnly)>
        Public Property [ExternalSolutionName] As String
        '''<summary>Customer URl in external solution, like solution.com/id123 (mandatory for External and ExternalOther solution)</summary>
        Public Property [ExternalSolutionUrl] As String
        '''<summary>Primary key</summary>
        <SDKFieldType(FieldType.ReadOnly)>
        Public Property [ID] As Guid
        '''<summary>Division code of linked internal solution (mandatory for Internal solution)</summary>
        Public Property [InternalSolutionDivision] As Int32?
        '''<summary>Last modified date</summary>
        <SDKFieldType(FieldType.ReadOnly)>
        Public Property [Modified] As DateTime
        '''<summary>User ID of modifier</summary>
        <SDKFieldType(FieldType.ReadOnly)>
        Public Property [Modifier] As Guid?
        '''<summary>Name of the solution link</summary>
        Public Property [Name] As String
        '''<summary>Name of the custom external solution (mandatory for ExternalOther solution)</summary>
        Public Property [OtherExternalSolutionName] As String
        '''<summary>Type of solution: 0 - Internal(EOL), 1 - External(Wellknown solution), 2 - ExternalOther</summary>
        Public Property [SolutionType] As Int32
        '''<summary>Link status: 0 - Active, 1 - Inactive, 2 -Archived</summary>
        <SDKFieldType(FieldType.ReadOnly)>
        Public Property [Status] As Int32
    End Class

    <SupportedActionsSDK(True, True, True, True)>
    <DataServiceKey("ID")>
    Public Class [TaskType]
        '''<summary>Creation date</summary>
        <SDKFieldType(FieldType.ReadOnly)>
        Public Property [Created] As DateTime?
        '''<summary>User ID of the creator</summary>
        Public Property [Creator] As Guid?
        '''<summary>Name of the creator</summary>
        <SDKFieldType(FieldType.ReadOnly)>
        Public Property [CreatorFullName] As String
        '''<summary>Name of the task type</summary>
        Public Property [Description] As String
        '''<summary>Term ID of the task type</summary>
        Public Property [DescriptionTermID] As Int32?
        '''<summary>Division code</summary>
        Public Property [Division] As Int32?
        '''<summary>Primary key</summary>
        Public Property [ID] As Guid
        '''<summary>Last modified date</summary>
        <SDKFieldType(FieldType.ReadOnly)>
        Public Property [Modified] As DateTime?
        '''<summary>User ID of the modifier</summary>
        <SDKFieldType(FieldType.ReadOnly)>
        Public Property [Modifier] As Guid?
        '''<summary>Name of the modifier</summary>
        <SDKFieldType(FieldType.ReadOnly)>
        Public Property [ModifierFullName] As String
    End Class

End Namespace