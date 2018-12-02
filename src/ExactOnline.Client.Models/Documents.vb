Namespace Documents

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [Document]
		'''<summary>ID of the related account of this document</summary>
		Public Property [Account] As Guid?
		'''<summary>Code of Account</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountCode] As String
		'''<summary>Name of Account</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountName] As String
		'''<summary>Amount in the currency of the transaction</summary>
		Public Property [AmountFC] As Double?
		'''<summary>Body of this document</summary>
		Public Property [Body] As String
		'''<summary>ID of the category of this document</summary>
		Public Property [Category] As Guid?
		'''<summary>Description of Category</summary>
		Public Property [CategoryDescription] As String
		'''<summary>ID of the related contact of this document</summary>
		Public Property [Contact] As Guid?
		'''<summary>Contact full name</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ContactFullName] As String
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<summary>User ID of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator</summary>
		Public Property [CreatorFullName] As String
		'''<summary>Currency code</summary>
		Public Property [Currency] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32
		'''<summary>Entry date of the incoming document</summary>
		Public Property [DocumentDate] As DateTime?
		'''<summary>The Id of document folder</summary>
		Public Property [DocumentFolder] As Guid?
		'''<summary>The Code of document folder</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DocumentFolderCode] As String
		'''<summary>The Decsription of document folder</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DocumentFolderDescription] As String
		'''<summary>Url to view the document</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DocumentViewUrl] As String
		'''<summary>Reference to the transaction lines that make up the financial entry</summary>
		Public Property [FinancialTransactionEntryID] As Guid?
		'''<summary>Indicates that the document body is empty</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [HasEmptyBody] As Boolean
		'''<summary>Human-readable ID, formatted as xx.xxx.xxx. Unique. May not be equal to zero</summary>
		Public Property [HID] As Int32?
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>The language code of the document</summary>
		Public Property [Language] As String
		'''<summary>Last modified date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<summary>User ID of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Name of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>The opportunity linked to the document</summary>
		Public Property [Opportunity] As Guid?
		'''<summary>The project linked to the document</summary>
		Public Property [Project] As Guid?
		'''<summary>Code of project</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectCode] As String
		'''<summary>Description of project</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectDescription] As String
		'''<summary>&apos;Our reference&apos; of the transaction that belongs to this document</summary>
		Public Property [SalesInvoiceNumber] As Int32?
		'''<summary>Number of the sales order</summary>
		Public Property [SalesOrderNumber] As Int32?
		'''<summary>Send method</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SendMethod] As Int32?
		'''<summary>Number of the shop order</summary>
		Public Property [ShopOrderNumber] As Int32?
		'''<summary>Subject of this document</summary>
		Public Property [Subject] As String
		'''<summary>ID of the type of this document</summary>
		Public Property [Type] As Int32?
		'''<summary>Description of Type</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [TypeDescription] As String
	End Class

	<SupportedActionsSDK(True, True, False, True)>
	<DataServiceKey("ID")>
	Public Class [DocumentAttachment]
		'''<summary>Contains the attachment</summary>
		Public Property [Attachment] As Byte()
		'''<summary>Reference to the Document</summary>
		Public Property [Document] As Guid
		'''<summary>Filename of the attachment</summary>
		Public Property [FileName] As String
		'''<summary>File size of the attachment</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [FileSize] As Double
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Url of the attachment. To get the file in its original format (xml, jpg, pdf, etc.) append &lt;b&gt;&amp;Download=1&lt;/b&gt; to the url.</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Url] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [DocumentCategory]
		'''<summary>Creation date</summary>
		Public Property [Created] As DateTime?
		'''<summary>Document category description</summary>
		Public Property [Description] As String
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Last modified date</summary>
		Public Property [Modified] As DateTime?
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [DocumentFolder]
		'''<summary>Document folder code</summary>
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
		'''<summary>Document folder description</summary>
		Public Property [Description] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32
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
		'''<summary>Document folder parent folder ID</summary>
		Public Property [ParentFolder] As Guid?
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [DocumentType]
		'''<summary>Creation date</summary>
		Public Property [Created] As DateTime?
		'''<summary>Document type description</summary>
		Public Property [Description] As String
		'''<summary>Indicates if documents of this type can be created</summary>
		Public Property [DocumentIsCreatable] As Boolean
		'''<summary>Indicates if documents of this type can be deleted</summary>
		Public Property [DocumentIsDeletable] As Boolean
		'''<summary>Indicates if documents of this type can be updated</summary>
		Public Property [DocumentIsUpdatable] As Boolean
		'''<summary>Indicates if documents of this type can be retrieved</summary>
		Public Property [DocumentIsViewable] As Boolean
		'''<summary>Primary key</summary>
		Public Property [ID] As Int32
		'''<summary>Last modified date</summary>
		Public Property [Modified] As DateTime?
		'''<summary>ID of the document type category</summary>
		Public Property [TypeCategory] As Int32?
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [DocumentTypeCategory]
		'''<summary>Creation date</summary>
		Public Property [Created] As DateTime?
		'''<summary>Document category type description</summary>
		Public Property [Description] As String
		'''<summary>Primary key</summary>
		Public Property [ID] As Int32
		'''<summary>Last modified date</summary>
		Public Property [Modified] As DateTime?
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [DocumentTypeFolder]
		'''<summary>Date created</summary>
		Public Property [Created] As DateTime
		'''<summary>User id of creator</summary>
		Public Property [Creator] As Guid?
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32
		'''<summary>Folder to which document type is linked</summary>
		Public Property [DocumentFolder] As Guid
		'''<summary>Code of document type which is linked to folder</summary>
		Public Property [DocumentType] As Int32
		Public Property [ID] As Guid
		'''<summary>Date Modified</summary>
		Public Property [Modified] As DateTime?
		'''<summary>User id of modifier</summary>
		Public Property [Modifier] As Guid?
	End Class

End Namespace