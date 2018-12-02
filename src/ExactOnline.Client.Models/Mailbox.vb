Namespace Mailbox

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [DefaultMailbox]
		'''<summary>Creation date</summary>
		Public Property [Created] As DateTime
		'''<summary>User ID of creator</summary>
		Public Property [Creator] As Guid?
		'''<summary>Extra description of the mailbox</summary>
		Public Property [Description] As String
		'''<summary>Only used when this mailbox is used for one specific administration, for example invoices to this mailbox will only be booked in this administration</summary>
		Public Property [ForDivision] As Int32?
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Indicates whether this service is used for messages returned by the scanning service</summary>
		Public Property [IsScanServiceMailbox] As Boolean
		'''<summary>E-mail address-like format, for example johndoe@exactonline.nl</summary>
		Public Property [Mailbox] As String
		'''<summary>Last modified date</summary>
		Public Property [Modified] As DateTime
		'''<summary>User ID of modifier</summary>
		Public Property [Modifier] As Guid?
		'''<summary>Date that this mailbox became valid</summary>
		Public Property [ValidFrom] As DateTime?
		'''<summary>Date that this mailbox will not be valid anymore</summary>
		Public Property [ValidTo] As DateTime?
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [Mailbox]
		'''<summary>The account this mailbox belongs to. Can be empty if the owner of the mailbox isn&apos;t an Exact Online customer yet</summary>
		Public Property [Account] As Guid?
		'''<summary>Name of Account</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountName] As String
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<summary>User ID of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>Extra description of the mailbox</summary>
		Public Property [Description] As String
		'''<summary>Only used when this mailbox is used for one specific administration, for example invoices to this mailbox will only be booked in this administration</summary>
		Public Property [ForDivision] As Int32?
		'''<summary>Description of ForDivision</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ForDivisionDescription] As String
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>E-mail address-like format, for example johndoe@exactonline.nl</summary>
		Public Property [Mailbox] As String
		'''<summary>Last modified date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<summary>User ID of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<summary>Name of modifier</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<summary>Customers can decide if they want this mailbox to be visible by all. i.e. some other customer can see this in address maintenance for digital postbox of type Exact</summary>
		Public Property [Publish] As Byte
		'''<summary>Type of mailbox. Exact / Government / Manual</summary>
		Public Property [Type] As Int16?
		'''<summary>Date that this mailbox became valid</summary>
		Public Property [ValidFrom] As DateTime?
		'''<summary>Date that this mailbox will not be valid anymore</summary>
		Public Property [ValidTo] As DateTime?
	End Class

	<SupportedActionsSDK(True, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [MailMessageAttachment]
		'''<summary>For performance reasons Attachment is Write-Only. The blob can be downloaded using the supplied Url</summary>
		Public Property [Attachment] As Byte()
		'''<summary>File extension of attachment</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AttachmentFileExtension] As String
		'''<summary>File name of attachment</summary>
		Public Property [AttachmentFileName] As String
		'''<summary>File size</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [FileSize] As Int64
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Reference to Mail message</summary>
		Public Property [MailMessageID] As Guid
		'''<summary>Reference to recipient account</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [RecipientAccount] As Guid?
		'''<summary>Reference to sender account</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SenderAccount] As Guid?
		'''<summary>Type of mail message attachment</summary>
		Public Property [Type] As Int32
		'''<summary>Description of Type</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [TypeDescription] As String
		'''<summary>To get the file in its original format (xml, jpg, pdf, etc.) append &lt;b&gt;&amp;Download=1&lt;/b&gt; to the url.</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Url] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [MailMessagesReceived]
		'''<summary>Bank to/from which the mail message is sent/received. This is used for mail messages of type Bank only. It has an attachment containing the bank file. When used for a mail message of type bank, the value is reserved for internal use and will then be ignored.</summary>
		Public Property [Bank] As Guid?
		'''<summary>Bank account for which the mail message is sent. This is used for mail messages of type Bank only. It has an attachment containing the bank export file. When used for a mail message of type bank, the value is reserved for internal use and will then be ignored.</summary>
		Public Property [BankAccount] As String
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<summary>User ID of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>Indicates that the scanning service must be done in (1) Europe or (0) both (inside or outside Europe)</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [EuropeProcessing] As Byte
		'''<summary>Administration from which the mail message is sent. This is used for mail messages of type Bank only. When used for a mail message of type bank, the value is reserved for internal use and will then be ignored.</summary>
		Public Property [ForDivision] As Int32?
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
		'''<summary>Specifies the operation upon dealing with the mailmessage (Kirean scan service)</summary>
		Public Property [Operation] As Int16?
		'''<summary>Provides a link to another MailMessage (Kirean scan service)</summary>
		Public Property [OriginalMessage] As Guid?
		'''<summary>Subject of the OriginalMessage</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [OriginalMessageSubject] As String
		'''<summary>The partner key that was used: this refers to the application from which the message is originating. It is filled with a fixed partnerkey when created from within Exact Online</summary>
		Public Property [PartnerKey] As Guid?
		'''<summary>Specifies the number of lines of the returned MailMessage attachment (Kirean scan service)</summary>
		Public Property [Quantity] As Double?
		'''<summary>Reference to the account that is receiving this mailmessage</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [RecipientAccount] As Guid?
		'''<summary>Indiciates if the recipient deleted this message. If this is the case the recipient can&apos;t see it anymore and the sender can actually delete it</summary>
		Public Property [RecipientDeleted] As Byte
		'''<summary>Mailbox of recipient</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [RecipientMailbox] As String
		'''<summary>Mailbox description of recipient</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [RecipientMailboxDescription] As String
		'''<summary>Mailbox ID of the recipient. The owner of this mailbox will see the message in the inbox</summary>
		Public Property [RecipientMailboxID] As Guid?
		'''<summary>Status of the mail message, only the recipient can update this</summary>
		Public Property [RecipientStatus] As Int16?
		'''<summary>Description of RecipientStatus</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [RecipientStatusDescription] As String
		'''<summary>Reference to Account of Sender</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SenderAccount] As Guid?
		'''<summary>Date the message was sent. Default the date the message is created, can be an earlier date when imported from xml (the date the xml was sent)</summary>
		Public Property [SenderDateSent] As DateTime?
		'''<summary>Indicates if the sender deleted the message. This means the sender can&apos;t see it anymore and the recipient can actually delete it</summary>
		Public Property [SenderDeleted] As Byte
		'''<summary>IP address of the sender</summary>
		Public Property [SenderIPAddress] As String
		'''<summary>Mailbox of sender</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SenderMailbox] As String
		'''<summary>Description of SenderMailbox</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SenderMailboxDescription] As String
		'''<summary>Mailbox ID of the sender. The owner of this mailbox will see the message in the sent items</summary>
		Public Property [SenderMailboxID] As Guid?
		'''<summary>Subject of the mail message</summary>
		Public Property [Subject] As String
		'''<summary>Provides a link between Exact Online and the banks</summary>
		Public Property [SynchronizationCode] As String
		'''<summary>Type of the mail message</summary>
		Public Property [Type] As Int32?
	End Class

	<SupportedActionsSDK(True, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [MailMessagesSent]
		'''<summary>Bank to/from which the mail message is sent/received. This is used for mail messages of type Bank only. It has an attachment containing the bank file. When used for a mail message of type bank, the value is reserved for internal use and will then be ignored.</summary>
		Public Property [Bank] As Guid?
		'''<summary>Bank account for which the mail message is sent. This is used for mail messages of type Bank only. It has an attachment containing the bank export file. When used for a mail message of type bank, the value is reserved for internal use and will then be ignored.</summary>
		Public Property [BankAccount] As String
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<summary>User ID of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>Administration from which the mail message is sent. This is used for mail messages of type Bank only. When used for a mail message of type bank, the value is reserved for internal use and will then be ignored.</summary>
		Public Property [ForDivision] As Int32?
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
		'''<summary>Specifies the operation upon dealing with the mailmessage (Kirean scan service)</summary>
		Public Property [Operation] As Int16?
		'''<summary>Provides a link to another MailMessage (Kirean scan service)</summary>
		Public Property [OriginalMessage] As Guid?
		'''<summary>Subject of the OriginalMessage</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [OriginalMessageSubject] As String
		'''<summary>The partner key that was used: this refers to the application from which the message is originating. It is filled with a fixed partnerkey when created from within Exact Online</summary>
		Public Property [PartnerKey] As Guid?
		'''<summary>Specifies the number of lines of the returned MailMessage attachment (Kirean scan service)</summary>
		Public Property [Quantity] As Double?
		'''<summary>Reference to the account that is receiving this mailmessage</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [RecipientAccount] As Guid?
		'''<summary>Indiciates if the recipient deleted this message. If this is the case the recipient can&apos;t see it anymore and the sender can actually delete it</summary>
		Public Property [RecipientDeleted] As Byte
		'''<summary>Mailbox of recipient</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [RecipientMailbox] As String
		'''<summary>Mailbox description of recipient</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [RecipientMailboxDescription] As String
		'''<summary>Mailbox ID of the recipient. The owner of this mailbox will see the message in the inbox</summary>
		Public Property [RecipientMailboxID] As Guid?
		'''<summary>Status of the mail message, only the recipient can update this</summary>
		Public Property [RecipientStatus] As Int16?
		'''<summary>Description of RecipientStatus</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [RecipientStatusDescription] As String
		'''<summary>Reference to Account of Sender</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SenderAccount] As Guid?
		'''<summary>Date the message was sent. Default the date the message is created, can be an earlier date when imported from xml (the date the xml was sent)</summary>
		Public Property [SenderDateSent] As DateTime?
		'''<summary>Indicates if the sender deleted the message. This means the sender can&apos;t see it anymore and the recipient can actually delete it</summary>
		Public Property [SenderDeleted] As Byte
		'''<summary>IP address of the sender</summary>
		Public Property [SenderIPAddress] As String
		'''<summary>Mailbox of sender</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SenderMailbox] As String
		'''<summary>Description of SenderMailbox</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SenderMailboxDescription] As String
		'''<summary>Mailbox ID of the sender. The owner of this mailbox will see the message in the sent items</summary>
		Public Property [SenderMailboxID] As Guid?
		'''<summary>Subject of the mail message</summary>
		Public Property [Subject] As String
		'''<summary>Provides a link between Exact Online and the banks</summary>
		Public Property [SynchronizationCode] As String
		'''<summary>Type of the mail message</summary>
		Public Property [Type] As Int32?
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [PreferredMailbox]
		'''<summary>Creation date</summary>
		Public Property [Created] As DateTime
		'''<summary>User ID of creator</summary>
		Public Property [Creator] As Guid?
		'''<summary>Extra description of the mailbox</summary>
		Public Property [Description] As String
		'''<summary>Only used when this mailbox is used for one specific administration, for example invoices to this mailbox will only be booked in this administration</summary>
		Public Property [ForDivision] As Int32?
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Indicates whether this service is used for messages returned by the scanning service</summary>
		Public Property [IsScanServiceMailbox] As Boolean
		'''<summary>E-mail address-like format, for example johndoe@exactonline.nl</summary>
		Public Property [Mailbox] As String
		'''<summary>Last modified date</summary>
		Public Property [Modified] As DateTime
		'''<summary>User ID of modifier</summary>
		Public Property [Modifier] As Guid?
		'''<summary>Date that this mailbox became valid</summary>
		Public Property [ValidFrom] As DateTime?
		'''<summary>Date that this mailbox will not be valid anymore</summary>
		Public Property [ValidTo] As DateTime?
	End Class

End Namespace