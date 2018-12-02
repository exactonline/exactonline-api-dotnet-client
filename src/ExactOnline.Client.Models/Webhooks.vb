Namespace Webhooks

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [WebhookSubscription]
		'''<summary>Callback URL endpoint</summary>
		Public Property [CallbackURL] As String
		'''<summary>OAuth client Id</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ClientID] As Guid?
		'''<summary>Creation date</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<summary>User ID of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<summary>Name of creator</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<summary>Description of the OAuth Client</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Description] As String
		'''<summary>Division code</summary>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<summary>Primary key</summary>
		Public Property [ID] As Guid
		'''<summary>Webhook subscription topic, e.g.: FinancialTransactions, Items, StockPositions</summary>
		Public Property [Topic] As String
	End Class

End Namespace