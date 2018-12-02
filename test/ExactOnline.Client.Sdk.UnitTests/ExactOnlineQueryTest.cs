using ExactOnline.Client.Models.CRM;
using ExactOnline.Client.Sdk.Controllers;
using ExactOnline.Client.Sdk.Helpers;
using ExactOnline.Client.Sdk.UnitTests.MockObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;

namespace ExactOnline.Client.Sdk.UnitTests
{
	[TestClass]
	public class ExactOnlineQueryTest
	{
		Controller<Account> _acccountController;
		ControllerMock<Account> _controllerMock;
		ApiConnectionMock _conn;

		[TestInitialize]
		public void Setup()
		{
			_conn = new ApiConnectionMock();
			_controllerMock = new ControllerMock<Account>();
			_acccountController = new Controller<Account>(_conn);
		}

		[TestMethod]
		[TestCategory("Unit Test")]
		public void ExactOnlineQuery_TestAnd_WithCorrectString_Succeeds()
		{
			new ExactOnlineQuery<Account>(_controllerMock)
				.Select(new[] { "Code", "Name" })
				.Where("Name+eq+'Test Testname'")
				.And("Code+eq+'123'")
				.And("Code+eq+'456'")
				.Get();
			
			Assert.AreEqual("$filter=Name+eq+'Test Testname'+and+Code+eq+'123'+and+Code+eq+'456'&$select=Code,Name", _controllerMock.ODataQuery);
		}

        [TestMethod]
        [TestCategory("Unit Test")]
        public async Task ExactOnlineQuery_TestAnd_WithCorrectString_SucceedsAsync()
        {
            await new ExactOnlineQuery<Account>(_controllerMock)
                .Select(new[] { "Code", "Name" })
                .Where("Name+eq+'Test Testname'")
                .And("Code+eq+'123'")
                .And("Code+eq+'456'")
                .GetAsync().ConfigureAwait(false);

            Assert.AreEqual("$filter=Name+eq+'Test Testname'+and+Code+eq+'123'+and+Code+eq+'456'&$select=Code,Name", _controllerMock.ODataQuery);
        }

        [TestMethod]
		[TestCategory("Unit Test"), ExpectedException(typeof(ArgumentException))]
		public void ExactOnlineQuery_TestAnd_WithNoWhereClause_Fails()
		{
			_controllerMock = new ControllerMock<Account>();
			new ExactOnlineQuery<Account>(_controllerMock)
				.Select(new[] { "Code", "Name" })
				.And("Code+eq+'123'")
				.Get();
		}

        [TestMethod]
        [TestCategory("Unit Test"), ExpectedException(typeof(ArgumentException))]
        public async Task ExactOnlineQuery_TestAnd_WithNoWhereClause_FailsAsync()
        {
            _controllerMock = new ControllerMock<Account>();
            await new ExactOnlineQuery<Account>(_controllerMock)
                .Select(new[] { "Code", "Name" })
                .And("Code+eq+'123'")
                .GetAsync().ConfigureAwait(false);
        }

        [TestMethod]
		[TestCategory("Unit Test"), ExpectedException(typeof(ArgumentException))]
		public void ExactOnlineQuery_TestAnd_WithEmptyString_Fails()
		{
			new ExactOnlineQuery<Account>(_controllerMock)
				.Select(new[] { "Code", "Name" })
				.Where("Name+eq+'Test Testname'")
				.And(string.Empty)
				.Get();
		}

        [TestMethod]
        [TestCategory("Unit Test"), ExpectedException(typeof(ArgumentException))]
        public async Task ExactOnlineQuery_TestAnd_WithEmptyString_FailsAsync()
        {
            await new ExactOnlineQuery<Account>(_controllerMock)
                .Select(new[] { "Code", "Name" })
                .Where("Name+eq+'Test Testname'")
                .And(string.Empty)
                .GetAsync().ConfigureAwait(false);
        }

        [TestMethod]
		[TestCategory("Unit Test")]
		public void ExactOnlineQuery_Delete_WithEntity_Succeeds()
		{
			var query = new ExactOnlineQuery<Account>(_controllerMock);
			Assert.IsTrue(query.Delete(new Account()));
		}

        [TestMethod]
        [TestCategory("Unit Test")]
        public async Task ExactOnlineQuery_Delete_WithEntity_SucceedsAsync()
        {
            var query = new ExactOnlineQuery<Account>(_controllerMock);
            Assert.IsTrue(await query.DeleteAsync(new Account()).ConfigureAwait(false));
        }

        [TestMethod]
		[TestCategory("Unit Test"), ExpectedException(typeof(ArgumentException))]
		public void ExactOnlineQueryDelete_WithNullEntity_Fails()
		{
			var query = new ExactOnlineQuery<Account>(_controllerMock);
			Assert.IsTrue(query.Delete(null));
		}

        [TestMethod]
        [TestCategory("Unit Test"), ExpectedException( typeof( ArgumentException ) )]
        public async Task ExactOnlineQueryDelete_WithNullEntity_FailsAsync()
        {
            var query = new ExactOnlineQuery<Account>(_controllerMock);
            Assert.IsTrue(await query.DeleteAsync(null).ConfigureAwait(false));
        }

        [TestMethod]
		[TestCategory("Unit Test")]
		public void ExactOnlineQueryFor_WithExistingEntity_Succeeds()
		{
			new ExactOnlineQuery<Account>(_controllerMock).Select("Code").Get();
		}

        [TestMethod]
        [TestCategory("Unit Test")]
        public async Task ExactOnlineQueryFor_WithExistingEntity_SucceedsAsync()
        {
            await new ExactOnlineQuery<Account>(_controllerMock).Select("Code").GetAsync().ConfigureAwait(false);
        }

        [TestMethod]
		[TestCategory("Unit Test"), ExpectedException(typeof(ArgumentException))]
		public void ExactOnlineQueryFor_WithEmptyController_Fails()
		{
			new ExactOnlineQuery<Account>(null).Get();
		}

        [TestMethod]
        [TestCategory("Unit Test"), ExpectedException(typeof(ArgumentException))]
        public async Task ExactOnlineQueryFor_WithEmptyController_FailsAsync()
        {
            await new ExactOnlineQuery<Account>( null ).GetAsync().ConfigureAwait(false);
        }

        [TestMethod]
		[TestCategory("Unit Test"), ExpectedException(typeof(Exception))]
		public void ExactOnlineQuery_Get_WithoutSelect_Fails()
		{
			new ExactOnlineQuery<Account>(_controllerMock).Get();
		}

        [TestMethod]
        [TestCategory("Unit Test"), ExpectedException(typeof(Exception))]
        public async Task ExactOnlineQuery_Get_WithoutSelect_FailsAsync()
        {
            await new ExactOnlineQuery<Account>(_controllerMock).GetAsync().ConfigureAwait(false);
        }

        [TestMethod]
		[TestCategory("Unit Test")]
		public void ExactOnlineQuery_Get_WithSelect_Succeeds()
		{
			new ExactOnlineQuery<Account>(_controllerMock).Select("Code").Get();
		}

        [TestMethod]
        [TestCategory("Unit Test")]
        public async Task ExactOnlineQuery_Get_WithSelect_SucceedsAsync()
        {
            await new ExactOnlineQuery<Account>(_controllerMock).Select("Code").GetAsync().ConfigureAwait(false);
        }

        [TestMethod]
		[TestCategory("Unit Test")]
		public void ExactOnlineQuery_GetEntity_WithIdentifier_Succeeds()
		{
			new ExactOnlineQuery<Account>(_acccountController).GetEntity("asdfasdfasdfadf");
		}

        [TestMethod]
        [TestCategory("Unit Test")]
        public async Task ExactOnlineQuery_GetEntity_WithIdentifier_SucceedsAsync()
        {
            await new ExactOnlineQuery<Account>(_acccountController).GetEntityAsync("asdfasdfasdfadf").ConfigureAwait(false);
        }

        [TestMethod]
		[TestCategory("Unit Test"), ExpectedException(typeof(ArgumentException))]
		public void ExactOnlineQuery_GetEntity_WithoutIdentifier_Fails()
		{
			new ExactOnlineQuery<Account>(_acccountController).GetEntity(string.Empty);
		}

        [TestMethod]
        [TestCategory("Unit Test"), ExpectedException(typeof(ArgumentException))]
        public async Task ExactOnlineQuery_GetEntity_WithoutIdentifier_FailsAsync()
        {
            await new ExactOnlineQuery<Account>(_acccountController).GetEntityAsync(string.Empty).ConfigureAwait(false);
        }

        [TestMethod]
		[TestCategory("Unit Test")]
		public void ExactOnlineQuery_Insert_WithObject_Succeeds()
		{
			var newAccount = new Account();
			new ExactOnlineQuery<Account>(_controllerMock).Insert(ref newAccount);
		}

        [TestMethod]
        [TestCategory("Unit Test")]
        public async Task ExactOnlineQuery_Insert_WithObject_SucceedsAsync()
        {
            var newAccount = new Account();
            var insertedAccount = await new ExactOnlineQuery<Account>(_controllerMock).InsertAsync(newAccount).ConfigureAwait(false);
            Assert.IsNotNull(insertedAccount);
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
		[TestCategory("Unit Test")]
		public void ExactOnlineQuery_Insert_WithNullObject_Fails()
		{
			Account newAccount = null;
			new ExactOnlineQuery<Account>(_controllerMock).Insert(ref newAccount);
		}

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        [TestCategory( "Unit Test" )]
        public async Task ExactOnlineQuery_Insert_WithNullObject_FailsAsync()
        {
            Account newAccount = null;
            await new ExactOnlineQuery<Account>(_controllerMock).InsertAsync(newAccount).ConfigureAwait(false);
        }

        [TestMethod]
		[TestCategory("Unit Test"), ExpectedException(typeof(ArgumentException))]
		public void ExactOnlineQuery_Update_WithNullObject_Fails()
		{
			new ExactOnlineQuery<Account>(_controllerMock).Update(null);
		}

        [TestMethod]
        [TestCategory("Unit Test"), ExpectedException(typeof(ArgumentException))]
        public async Task ExactOnlineQuery_Update_WithNullObject_FailsAsync()
        {
            await new ExactOnlineQuery<Account>(_controllerMock).UpdateAsync(null).ConfigureAwait(false);
        }

        [TestMethod]
		[TestCategory("Unit Test")]
		public void ExactOnlineQuery_Update_WithObject_Succeeds()
		{
			new ExactOnlineQuery<Account>(_controllerMock).Update(new Account());
		}

        [TestMethod]
        [TestCategory("Unit Test")]
        public async Task ExactOnlineQuery_Update_WithObject_SucceedsAsync()
        {
            await new ExactOnlineQuery<Account>(_controllerMock).UpdateAsync(new Account()).ConfigureAwait(false);
        }

        [TestMethod]
		[TestCategory("Unit Test")]
		public void ExactOnlineQuery_Where_WithString_Succeeds()
		{
			new ExactOnlineQuery<Account>(_controllerMock)
			.Select(new[] { "Code", "Name" })
			.Where("Name+eq+'Test Testname'")
			.Get();
		}

        [TestMethod]
        [TestCategory("Unit Test")]
        public async Task ExactOnlineQuery_Where_WithString_SucceedsAsync()
        {
            await new ExactOnlineQuery<Account>(_controllerMock)
            .Select(new[] { "Code", "Name" })
            .Where("Name+eq+'Test Testname'")
            .GetAsync().ConfigureAwait(false);
        }

        [TestMethod]
		[TestCategory("Unit Test"), ExpectedException(typeof(ArgumentException))]
		public void ExactOnlineQuery_Where_WithEmptyString_Fails()
		{
			new ExactOnlineQuery<Account>(_controllerMock)
			.Where(string.Empty)
			.Get();
		}

        [TestMethod]
        [TestCategory("Unit Test"), ExpectedException(typeof(ArgumentException))]
        public async Task ExactOnlineQuery_Where_WithEmptyString_FailsAsync()
        {
            await new ExactOnlineQuery<Account>(_controllerMock)
            .Where(string.Empty)
            .GetAsync().ConfigureAwait(false);
        }

        [TestMethod]
		[TestCategory("Unit Test")]
		public void ExactOnlineQuery_SingleSelect_Succeeds()
		{
			new ExactOnlineQuery<Account>(_controllerMock).Select("Description").Get();
			const string expected = "$select=Description";
			var query = _controllerMock.ODataQuery;
			Assert.AreEqual(expected, query);
		}

        [TestMethod]
        [TestCategory("Unit Test")]
        public async Task ExactOnlineQuery_SingleSelect_SucceedsAsync()
        {
            await new ExactOnlineQuery<Account>(_controllerMock).Select("Description").GetAsync().ConfigureAwait(false);
            const string expected = "$select=Description";
            var query = _controllerMock.ODataQuery;
            Assert.AreEqual(expected, query);
        }

        [TestMethod]
		[TestCategory("Unit Test")]
		public void ExactOnlineQuery_MultipleSelect_Succeeds()
		{
			var query = new ExactOnlineQuery<Account>(_controllerMock).Select(new[] { "Description", "Name" });
			var list = query.Get();

			const string expected = "$select=Description,Name";
			var result = _controllerMock.ODataQuery;
			Assert.AreEqual(expected, result);
		}

        [TestMethod]
        [TestCategory("Unit Test")]
        public async Task ExactOnlineQuery_MultipleSelect_SucceedsAsync()
        {
            var query = new ExactOnlineQuery<Account>(_controllerMock).Select(new[] { "Description", "Name" });
            var list = await query.GetAsync().ConfigureAwait(false);

            const string expected = "$select=Description,Name";
            var result = _controllerMock.ODataQuery;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
		[TestCategory("Unit Test")]
		public void ExactOnlineQuery_Top_Succeeds()
		{
			new ExactOnlineQuery<Account>(_controllerMock).Top(10).Select(new[] { "Code", "Name" }).Get();
			const string expected = "$select=Code,Name&$top=10";
			var query = _controllerMock.ODataQuery;
			Assert.AreEqual(expected, query);
		}

        [TestMethod]
        [TestCategory("Unit Test")]
        public async Task ExactOnlineQuery_Top_SucceedsAsync()
        {
            await new ExactOnlineQuery<Account>(_controllerMock).Top(10).Select(new[] { "Code", "Name" }).GetAsync().ConfigureAwait(false);
            const string expected = "$select=Code,Name&$top=10";
            var query = _controllerMock.ODataQuery;
            Assert.AreEqual(expected, query);
        }

        [TestMethod]
		[TestCategory("Unit Test")]
		public void ExactOnlineQuery_WithAllOptions_Succeeds()
		{
			var query = new ExactOnlineQuery<Account>(_controllerMock)
				.Where("Name+eq+'Test'")
				.And("Name+eq+'Test2'")
				.Select(new[] { "Description", "Name" })
				.Expand("BankAccounts")
				.Skip(10)
				.Top(10).Get();
				
			const string expected = "$filter=Name+eq+'Test'+and+Name+eq+'Test2'&$select=Description,Name&$skip=10&$expand=BankAccounts&$top=10";
			var data = _controllerMock.ODataQuery;
			Assert.AreEqual(expected, data);
		}

        [TestMethod]
        [TestCategory("Unit Test")]
        public async Task ExactOnlineQuery_WithAllOptions_SucceedsAsync()
        {
            var query = await new ExactOnlineQuery<Account>(_controllerMock)
                .Where("Name+eq+'Test'")
                .And("Name+eq+'Test2'")
                .Select(new[] { "Description", "Name" })
                .Expand("BankAccounts")
                .Skip(10)
                .Top(10).GetAsync("mySkiptoken").ConfigureAwait(false);

            const string expected = "$filter=Name+eq+'Test'+and+Name+eq+'Test2'&$select=Description,Name&$skip=10&$expand=BankAccounts&$top=10&$skiptoken=mySkiptoken";
            var data = _controllerMock.ODataQuery;
            Assert.AreEqual(expected, data);
        }
    }
}
