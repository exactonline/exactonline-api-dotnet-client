![Logo](https://apps.exactonline.com/content/css/images/exact-logo-red.png)

[![](https://img.shields.io/nuget/v/ExactOnline.Client.Sdk.svg)](https://www.nuget.org/packages/ExactOnline.Client.Sdk)

C# client SDK for the Exact Online RESTFul API
===============
<h3>Not supported anymore by Exact</h3>


<h3>Quick Guide</h3>

The Exact Online Client SDK provides a rich application framework and simplifies the interconnection with the Exact Online RESTful API. The Exact Online API can help you to quickly integrate with Exact Online and build innovative apps within the .NET environment. This document describes how to get started using the Exact Online Client SDK. The sample code in this document is in C#

You can open sample console application solution that recommends you how to use ExactOnline.Client.Sdk

```
ConsoleApplication.sln
```

<h4>1.	Reference Libraries</h4>

Include following references in your web project:
- ExactOnline.Client.Models.dll
- ExactOnline.Client.Sdk

Add following namespaces in your code file:
```
using ExactOnline.Client.Models;
using ExactOnline.Client.Sdk;
```

<h4>2.  OAuth</h4>
We have added an ExactOnline.Client.OAuth module, which takes care of the authentication. In this way you can easily execute the integration tests and user acceptance tests. When you want to use this you need to fill in your own client ID, client secret and callback url in the ExactOnline.Client.Sdk.TestContext in the TestObjectsCreator class. Of course you also can use your own OAuth implementation. 

<h4>3.	Initializing Exact Client </h4>

ExactOnline Client only supports the OAuth authentication for the API calls. To know more about OAuth please refer to <a href="https://developers.exactonline.com/#Getting started.html%3FTocPath%3DAuthorization%2520(OAuth2)%7C_____0">Getting started - OAuth</a>. To initialize the ExactOnlineClient object you need to provide the “apiEndPoint” & “AccessTokenDelegate”:
```
ExactOnlineClient client = new ExactOnlineClient (apiEndPoint, AccessTokenDelegate);
```

For multiple administrations you can also specify the division

```
ExactOnlineClient client = 
        new ExactOnlineClient (apiEndPoint, division, AccessTokenDelegate);
```

<u>apiEndPoint:</u> Exact Online URL for your country. For Netherlands: “https://start.exactonline.nl”

<u>AccessTokenDelegate:</u> Delegate that will be responsible to retrieve and refresh the OAuth access token. See the example application to see how it is used <a href="https://github.com/exactonline/exactonline-api-dotnet-client/blob/master/src/ConsoleApplication/Program.cs">Example OAuth.</a>

<h4>4.	Insert Record Using ExactOnline Client </h4>
To insert a record using the ExactOnlineClient instance for a specific entity, you first need to initialize the object for that entity and provide all the required values.

E-g: To insert a new “Document” record, first create a new object for “Document”:
```
Document document = new Document
		   {
			Subject = "User Acceptance Test Document",
			Body = "User Acceptance Test Document",
			Category = GetCategoryId (client),
			Type = 55, //Miscellaneous
			DocumentDate = DateTime.Now.Date
		   };
```

Use the ExactOnlineClient instance to insert the record:
```
bool created = client.For<Document>().Insert(ref document);
```

“Insert” method takes entity object as reference and returns “true” if the insertion is successful.
After successful insertion, the document ID can be retrieved as:

<i>document.ID</i>

<h4>5.	Retrieve Data Using Exact Client </h4>

To retrieve the entity based on ID you can use the “GetEntity” function. E-g: Retrieve document by ID: 
```
client.For<Document>().GetEntity(documentID);
```

To retrieve specific fields of the entity based on filter use “select” and “where” functions. E-g: Retrieve document with specific fields for subject “User Acceptance Test Document”
```
var fields = new[] { "ID, Subject, Type, Category" };
var documents = client.For<Document>().Select(fields).Top(5).Where("Subject+eq+'User Acceptance Test Document'").Get();
```
If  “Select(fields)” is not specified you will get an exception. You always need to specify which fields you need, to limit the data traffic.
Paging: For paging use “Skip” and “Top” functions
```
var documents = client.For<Document>().Select(fields).Skip(2).Top(5)
.Where("Subject+eq+'User Acceptance Test Document'").Get();
```

<h4>6.	Update Record Using Exact Client</h4>

Update the fields in the entity object and pass this object to “Update” function of the ExactOnlineClient instance, which will return “true” if update is successful.
```
document.Subject = "User Acceptance Test Document Updated";
document.DocumentDate = DateTime.Now.Date;
var updated = client.For<Document>().Update(document);
```

<h4>7.	Delete Record</h4>
To delete a record you need to provide the entity object to the “Delete” method of the ExactOnlineClient instance, which will return “true” if the operation is successful.
```
var deleted = client.For<Document>().Delete(document);
```

<h4>8.	Exceptions</h4>
<table>
<tr><td><b>Exception</b></td>		<td><b>Description</b></td></tr>
<tr><td>UnauthorizedException</td>	<td>When access token is null or invalid while making a request</td></tr>
<tr><td>BadRequestException</td>	<td>When composed request is not in a correct format</td></tr>
<tr><td>ForbiddenException</td>	<td>When some specific operation is not allowed to be performed.</td></tr>
<tr><td>NotFoundException</td>	<td>When trying to retrieve a record which does not exist in the database.</td></tr>
<tr><td>InternalServerError</td>	<td>Please find the validation errors in the error message.</td></tr>
</table>
