using ExactOnline.Client.Models.CRM;
using ExactOnline.Client.Models.SalesInvoice;
using ExactOnline.Client.Sdk.Controllers;
using ExactOnline.Client.Sdk.Delegates;
using ExactOnline.Client.Sdk.Exceptions;
using ExactOnline.Client.Sdk.Helpers;
using ExactOnline.Client.Sdk.UnitTests.Tools;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
namespace ExactOnline.Client.Sdk.UnitTests
{

	/// <summary>
	///This is a test class for APIResponseConverter intended
	///to contain all APIResponseConverter Unit Tests
	///</summary>
	[TestClass]
	public class EntityConverterTest
	{
		private EntityConverter _entityConverter;

		[TestInitialize]
		public void Setup()
		{
			_entityConverter = new EntityConverter();
		}

		#region Json To Object Test
		[TestCategory("Unit Test")]
		[TestMethod]
		public void EntityConverter_ConvertJsonToObjectList_WithCorrectInput_Succeeds()
		{
			string jsonarray = JsonFileReader.GetJsonFromFile("Response_Json_Array_Account.txt");
			List<Account> accounts = _entityConverter.ConvertJsonArrayToObjectList<Account>(jsonarray);
			if (accounts.Count != 2)
			{
				throw new Exception("The count of the list isn't equal to the actual list");
			}
		}

		[TestCategory("Unit Test")]
		[TestMethod]
		public void EntityConverter_ConvertJsonToObjectList_WithParsedJson_Succeeds()
		{
			string jsonarray = JsonFileReader.GetJsonFromFile("Response_Json_Array_Account.txt");
			List<Account> accounts = _entityConverter.ConvertJsonArrayToObjectList<Account>(jsonarray);
			if (accounts.Count != 2)
			{
				throw new Exception("The count of the list isn't equal to the actual list");
			}
		}

		// Test for manditory fields (in constructor)
		[TestCategory("Unit Test")]
		[TestMethod]
		public void EntityConverter_ConvertJsonToObjectList_WithEmptyJson_Fails()
		{
			List<Account> accounts = _entityConverter.ConvertJsonArrayToObjectList<Account>(string.Empty);
			Assert.IsNull(accounts);
		}

		#endregion

		#region Object to Json Test
		[TestCategory("Unit Test")]
		[TestMethod]
		public void EntityConverter_ConvertObjectToJson_ForCreating_Succeeds()
		{
			// Test if objects is converted to json correctly
			var dateTimeEpoc = new DateTime(1970, 1, 1, 0, 0, 0, 0);

			#region Client Object and Json

			var simpleEntity = new SimpleEntity()
			{
				Code = "123",
				Description = "FOO",
				Id = new Guid("53697fab-137f-4242-b710-0139886b50f4"),
				StartDate = dateTimeEpoc.AddMilliseconds(1387188617287),
				EndDate = null,
				Boolean = true,
				NullableBoolean = null,
				Integer = 5,
				NullableInteger = null
			};

			const string expected = "{\"Code\":\"123\",\"Description\":\"FOO\",\"Id\":\"53697fab-137f-4242-b710-0139886b50f4\",\"StartDate\":\"2013-12-16T10:10:17.287\",\"EndDate\":null,\"Boolean\":true,\"NullableBoolean\":null,\"Integer\":5,\"NullableInteger\":null}";
			#endregion

			var converter = new EntityConverter();
			string result = converter.ConvertObjectToJson(simpleEntity, null);

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		[TestCategory("Unit Test")]
		public void EntityConverter_ConvertObjectToJson_ForAlteredFields_Succeeds()
		{
			var account = new Account { Name = "New Account" };
			var entityConverter = new EntityConverter();
			const string expected = "{\"Name\":\"New Account\"}";

			var result = entityConverter.ConvertObjectToJson(new Account(), account, null);

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		[TestCategory("Unit Test")]
		public void EntityConverter_ConvertObjectToJson_ForNoAlteredFields_Succeeds()
		{
			var oldAccount = new Account { Name = "New Account" };
			var newAccount = new Account { Name = "New Account" };
			var entityConverter = new EntityConverter();
			const string expected = "";

			var result = entityConverter.ConvertObjectToJson(oldAccount, newAccount, null);

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		[TestCategory("Unit Test")]
		public void EntityConverter_ConvertObjectToJson_WithReadonlyFields_Succeeds()
		{
			var newAccount = new Account { AccountManagerHID = 10 };
			var entityConverter = new EntityConverter();
			const string expected = "";

			var result = entityConverter.ConvertObjectToJson(new Account(), newAccount, null);

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		[TestCategory("Unit Test")]
		public void EntityConverter_CreateWithGuid_Succeeds()
		{
			var newAccount = new Account { ID = new Guid("8f8b8025-90b3-4307-a8a3-a5111d048fb5") };
			var entityConverter = new EntityConverter();
			const string expected = "{\"ID\":\"8f8b8025-90b3-4307-a8a3-a5111d048fb5\"}";

			var result = entityConverter.ConvertObjectToJson(new Account(), newAccount, null);

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		[TestCategory("Unit Test")]
		public void EntityConverter_CreateWithoutGuid_Succeeds()
		{
			var newAccount = new Account { ID = new Guid() };
			var entityConverter = new EntityConverter();
			const string expected = "";

			var result = entityConverter.ConvertObjectToJson(new Account(), newAccount, null);

			Assert.AreEqual(expected, result);
		}

		#endregion

		#region Dynamic to Json Tests
		[TestCategory("Unit Test")]
		[TestMethod]
		public void EntityConverter_ConvertDynamicObjectToJson_WithCorrectDynamicObject_Succeeds()
		{
			dynamic account = new { code = "123", description = "Test" };
			const string jsonValue = @"{""code"":""123"",""description"":""Test""}";

			string json = _entityConverter.ConvertDynamicObjectToJson(account);
			Assert.AreEqual(jsonValue, json);
		}

		[TestCategory("Unit Test")]
		[TestMethod]
		public void EntityConverter_ConvertDynamicObjectToJson_WithEmptyDynamicObject_Succeeds()
		{
			dynamic account = new { };
			const string jsonValue = @"{""code"":""123"",""description"":""Test""}";

			string json = _entityConverter.ConvertDynamicObjectToJson(account);
			Assert.AreNotEqual(jsonValue, json);
		}


        [TestCategory("Unit Test")]
        [TestMethod]
        public void EntityConverter_ConvertObject_WithJsonPropertyAttributeSpecifyingDifferentPropertyToJson_SerializesToCorrectJson()
        {
            var bankaccount = new BankAccount();
            bankaccount.BankAccountName = "value";
            const string jsonValue = @"{""BankAccount"":""value""}";

            string json = _entityConverter.ConvertObjectToJson(new BankAccount(), bankaccount, null);
            Assert.AreEqual(jsonValue, json);
        }
        #endregion

        #region Json to Dynamic Tests
        [TestCategory("Unit Test")]
		[TestMethod]
		public void EntityConverter_ConvertJsonToDynamicObject_WithCorrectJson_Succeeds()
		{
			string jsonsresponse = JsonFileReader.GetJsonFromFile("Response_Json_Object_GLAccount.txt");
			string json = ApiResponseCleaner.GetJsonObject(jsonsresponse);

			dynamic glaccountObject = _entityConverter.ConvertJsonToDynamicObject(json);
			Assert.AreEqual("D", (string)glaccountObject.BalanceSide);
			Assert.AreEqual("W", (string)glaccountObject.BalanceType);
			Assert.AreEqual("4406", (string)glaccountObject.Code);
			Assert.AreEqual(false, (Boolean)glaccountObject.Compress);
			Assert.AreEqual(null, (string)glaccountObject.Costcenter);
			Assert.AreEqual(null, (string)glaccountObject.CostcenterDescription);
			Assert.AreEqual("10/25/2013 02:24:29", (string)glaccountObject.Created);
			Assert.AreEqual("99d87844-e4ef-4ac5-968c-fb863eaced16", (string)glaccountObject.Creator);
			Assert.AreEqual(null, (string)glaccountObject.CreatorFullName);
			Assert.AreEqual("Test", (string)glaccountObject.Description);
			Assert.AreEqual("499156", (string)glaccountObject.Division);
			Assert.AreEqual("0", (string)glaccountObject.ExcludeVATListing);
			Assert.AreEqual("0", (string)glaccountObject.ExpenseNonDeductiblePercentage);
			Assert.AreEqual("3c534e79-c4fe-44d2-9765-00b30573c2de", (string)glaccountObject.ID);
			Assert.AreEqual(false, (Boolean)glaccountObject.IsBlocked);
			Assert.AreEqual(false, (Boolean)glaccountObject.Matching);
			Assert.AreEqual("12/02/2013 13:44:27", (string)glaccountObject.Modified);
			Assert.AreEqual("10091f1b-4661-4854-9fd0-cf5f5f668cbd", (string)glaccountObject.Modifier);
			Assert.AreEqual("Edward Jackson", (string)glaccountObject.ModifierFullName);
			Assert.AreEqual(null, (string)glaccountObject.PrivateGLAccount);
			Assert.AreEqual("0", (string)glaccountObject.PrivatePercentage);
			Assert.AreEqual(null, (string)glaccountObject.ReportingCode);
			Assert.AreEqual(false, (Boolean)glaccountObject.RevalueCurrency);
			Assert.AreEqual("RENTE    ", (string)glaccountObject.SearchCode);
			Assert.AreEqual("120", (string)glaccountObject.Type);
			Assert.AreEqual("Other costs", (string)glaccountObject.TypeDescription);
			Assert.AreEqual("0", (string)glaccountObject.UseCostcenter);
			Assert.AreEqual("0", (string)glaccountObject.UseCostunit);
			Assert.AreEqual(null, (string)glaccountObject.VATCode);
			Assert.AreEqual(null, (string)glaccountObject.VATDescription);
			Assert.AreEqual(null, (string)glaccountObject.VATGLAccountType);
			Assert.AreEqual(null, (string)glaccountObject.VATNonDeductibleGLAccount);
			Assert.AreEqual("0", (string)glaccountObject.VATNonDeductiblePercentage);
			Assert.AreEqual(null, (string)glaccountObject.YearEndCostGLAccount);
			Assert.AreEqual(null, (string)glaccountObject.YearEndReflectionGLAccount);
		}

		[TestCategory("Unit Test")]
		[TestMethod, ExpectedException(typeof(IncorrectJsonException))]
		public void EntityConverter_ConvertJsonToDynamicObject_WithIncorrectJson_Fails()
		{
			string json = JsonFileReader.GetJsonFromFile("Response_Json_Object_GLAccount_WithCorruptJson.txt");
			dynamic glaccountObject = _entityConverter.ConvertJsonToDynamicObject(json);
			Assert.AreEqual("D", (string)glaccountObject.BalanceSide);
			Assert.AreEqual("W", (string)glaccountObject.BalanceType);
		}

		[TestCategory("Unit Test")]
		[TestMethod]
		public void EntityConverter_ConvertJsonToDynamicObjectCollection_Succeeds()
		{
			string json = JsonFileReader.GetJsonFromFile("Response_Json_Array_GLAccount.txt");
			json = ApiResponseCleaner.GetJsonArray(json);

			List<dynamic> list = _entityConverter.ConvertJsonToDynamicObjectList(json);
			if (list.Count < 2)
			{
				throw new AssertFailedException("The list list doesn't contain two entities");
			}

		}

		[TestCategory("Unit Test")]
		[TestMethod, ExpectedException(typeof(IncorrectJsonException))]
		public void EntityConverter_ConvertJsonToDynamicObjectCollection_WithEmptyJson_Fails()
		{
			const string json = "";
			List<dynamic> list = _entityConverter.ConvertJsonToDynamicObjectList(json);
		}

		[TestCategory("Unit Test")]
		[TestMethod, ExpectedException(typeof(IncorrectJsonException))]
		public void EntityConverter_ConvertJsonToDynamicObjectCollection_WithEmptyJsonEntities_Fails()
		{
			const string json = "{[{},{}]}";
			List<dynamic> list = _entityConverter.ConvertJsonToDynamicObjectList(json);
		}

		#endregion

		#region Linked Entity Json to Object
		[TestCategory("Unit Test")]
		[TestMethod]
		public void EntityConverter_ConvertLinkedEntityJsonArrayToObjects_Succeeds()
		{
			string json = ApiResponseCleaner.GetJsonArray(JsonFileReader.GetJsonFromFile("Response_Json_Array_SalesInvoice_WithLinkedEntities.txt"));
			var converter = new EntityConverter();
			List<SalesInvoice> invoices = converter.ConvertJsonArrayToObjectList<SalesInvoice>(json);

			foreach (var invoice in invoices)
			{
				var sil = (List<SalesInvoiceLine>)invoice.SalesInvoiceLines;
				Assert.IsTrue(sil.Count > 0);
			}
		}

		[TestCategory("Unit Test")]
		[TestMethod]
		public void EntityConverter_ConvertLinkedEntityJsonToObject_Succeeds()
		{
			string json = ApiResponseCleaner.GetJsonObject(JsonFileReader.GetJsonFromFile("Response_Json_Object_SalesInvoice.txt"));

			var converter = new EntityConverter();
			var invoice = converter.ConvertJsonToObject<SalesInvoice>(json);
			var lines = (List<SalesInvoiceLine>)invoice.SalesInvoiceLines;

			Assert.IsNotNull(invoice);
			Assert.IsTrue(lines.Count > 0);
		}
		#endregion

		#region Linked Entities To Json
		[TestCategory("Unit Test")]
		[TestMethod]
		public void EntityConverter_ConvertLinkedObjectToJson_Succeeds()
		{
			// Create Object
			var newInvoice = new ComplexEntity
			{
				Currency = "EUR",
				OrderDate = new DateTime(2012, 10, 26),
				InvoiceTo = new Guid("3734121e-1544-4b77-9ae2-7203e9bd6046"),
				Journal = "50",
				OrderedBy = new Guid("3734121e-1544-4b77-9ae2-7203e9bd6046"),
				Description = "NewInvoiceForEntityWithCollection"
			};

			var newInvoiceLine = new ComplexEntityLine
			{
				Description = "NewInvoiceForEntityWithCollection",
				Item = new Guid("4f68481a-7a2c-4fbc-a3a0-0c494df3fa0d")
			};

			var invoicelines = new List<ComplexEntityLine> { newInvoiceLine };
			newInvoice.Lines = invoicelines;

			var entityConverter = new EntityConverter();
			string json = entityConverter.ConvertObjectToJson(newInvoice, null);
			string expected = JsonFileReader.GetJsonFromFileWithoutWhiteSpace("Expected_Json_Object_ComplexEntity_WithLinkedEntity.txt");
			Assert.AreEqual(expected, json);
		}

		private static EntityController GetEntityController(object o)
		{
			// Create Object
			var newInvoice = new SalesInvoice { InvoiceID = new Guid("4f68481a-7a2c-4fbc-a3a0-0c494df3fa0d") };
			var newInvoiceLine = new SalesInvoiceLine { Description = "NewInvoiceForEntityWithCollection" };
			newInvoice.SalesInvoiceLines = new List<SalesInvoiceLine> { newInvoiceLine };

			var entityController = new EntityController(newInvoice, "ID", "4f68481a-7a2c-4fbc-a3a0-0c494df3fa0d", new MockObjects.ApiConnectionMock(), null);
			return entityController;
		}

		[TestCategory("Unit Test")]
		[TestMethod, Ignore]
		public void EntityConverter_ConvertExistingLinkedObjectToJson_Succeeds()
		{
			// Create Object
			var newInvoice = new SalesInvoice { InvoiceID = new Guid("4f68481a-7a2c-4fbc-a3a0-0c494df3fa0d") };
			var newInvoiceLine = new SalesInvoiceLine { Description = "NewInvoiceForEntityWithCollection" };
			newInvoice.SalesInvoiceLines = new List<SalesInvoiceLine> { newInvoiceLine };

			//ControllerSingleton.GetInstance(new MockObjects.MAPIConnector_Controller(), "www.dummy.com/");
			var entityController = new EntityController(newInvoice, "ID", "4f68481a-7a2c-4fbc-a3a0-0c494df3fa0d", new MockObjects.ApiConnectionMock(), null);
			newInvoiceLine.Description = "ChangedNewInvoiceForEntityWithCollection";

			var entityConverter = new EntityConverter();
			var controllerDelegate = new GetEntityController(GetEntityController);
			string json = entityConverter.ConvertObjectToJson((SalesInvoice)entityController.OriginalEntity, newInvoice, controllerDelegate);

			const string expected = "{\"SalesInvoiceLines\": [{\"Description\": \"ChangedNewInvoiceForEntityWithCollection\"}]}";
			Assert.AreEqual(expected, json);

			throw new NotImplementedException();
		}

		[TestCategory("Unit Test")]
		[TestMethod]
		public void EntityConverter_ConvertEmptyLinkedObjectToJson_Succeeds()
		{
			// Create Object
			var newInvoice = new ComplexEntity
			{
				Currency = "EUR",
				OrderDate = new DateTime(2012, 10, 26),
				InvoiceTo = new Guid("3734121e-1544-4b77-9ae2-7203e9bd6046"),
				Journal = "50",
				OrderedBy = new Guid("3734121e-1544-4b77-9ae2-7203e9bd6046"),
				Description = "NewInvoiceForEntityWithCollection"
			};

			var entityConverter = new EntityConverter();
			string json = entityConverter.ConvertObjectToJson(newInvoice, null);
			string expected = JsonFileReader.GetJsonFromFileWithoutWhiteSpace("Expected_Json_Object_ComplexEntity_WithEmptyLinkedEntities.txt");
			Assert.AreEqual(expected, json);
		}
		#endregion

		#region Interpreting Long Json
		[TestCategory("Unit Test")]
		[TestMethod, ExpectedException(typeof(IncorrectJsonException))]
		public void EntityConverter_ConvertLongJson_Fails()
		{
			var entityConverter = new EntityConverter();
			string json = JsonFileReader.GetJsonFromFile("Response_Json_Array_Account_Long.txt");
			var accounts = entityConverter.ConvertJsonArrayToObjectList<Account>(json);
		}
		#endregion

	}

	public class SimpleEntity
	{
		public string Code { get; set; }
		public string Description { get; set; }
		public Guid Id { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime? EndDate { get; set; }
		public bool Boolean { get; set; }
		public bool? NullableBoolean { get; set; }
		public int Integer { get; set; }
		public int? NullableInteger { get; set; }
	}

	public class ComplexEntity
	{
		public string Currency { get; set; }
		public string Description { get; set; }
		public Guid? InvoiceTo { get; set; }
		public string Journal { get; set; }
		public DateTime? OrderDate { get; set; }
		public Guid? OrderedBy { get; set; }

		public IEnumerable<ComplexEntityLine> Lines { get; set; }
	}

	public class ComplexEntityLine
	{
		public string Description { get; set; }
		public Guid? Item { get; set; }
	}

    
}
