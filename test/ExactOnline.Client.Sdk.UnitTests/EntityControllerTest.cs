using ExactOnline.Client.Models.SalesInvoice;
using ExactOnline.Client.Sdk.Controllers;
using ExactOnline.Client.Sdk.Helpers;
using ExactOnline.Client.Sdk.UnitTests.MockObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExactOnline.Client.Sdk.UnitTests
{

	[TestClass]
	public class EntityControllerTest
	{
		#region Update

		[TestMethod]
		[TestCategory("Unit Test")]
		public void EntityController_Update_WithNewLinkedEntity_Succeeds()
		{
			var controllerMock = new ApiConnectionEntityControllerMock();
			var apiConnectorMock = new ApiConnectorMock();
			var controllerList = new ControllerList(apiConnectorMock, "https://start.exactonline.nl/api/v1/");

			var controller = (Controller<SalesInvoice>)controllerList.GetController<SalesInvoice>();
			var invoice = new SalesInvoice { Description = "New Description" };
			var entityController = new EntityController(invoice, "ID", invoice.InvoiceID.ToString(), controllerMock, controller.GetEntityController);

			// Change State
			invoice.Description = "Description2";
			var line = new SalesInvoiceLine { Description = "InvoiceLine2" };
			invoice.SalesInvoiceLines = new List<SalesInvoiceLine> { line };

			entityController.Update(invoice);

			string data = controllerMock.Data;
			Assert.IsTrue(data.Contains(@"""Description"":""Description2"""));
			Assert.IsTrue(data.Contains(@"""Description"":""InvoiceLine2"""));
		}

        [TestMethod]
        [TestCategory("Unit Test")]
        public async Task EntityController_Update_WithNewLinkedEntity_SucceedsAsync()
        {
            var controllerMock = new ApiConnectionEntityControllerMock();
            var apiConnectorMock = new ApiConnectorMock();
            var controllerList = new ControllerList(apiConnectorMock, "https://start.exactonline.nl/api/v1/");

            var controller = (Controller<SalesInvoice>)controllerList.GetController<SalesInvoice>();
            var invoice = new SalesInvoice { Description = "New Description" };
            var entityController = new EntityController(invoice, "ID", invoice.InvoiceID.ToString(), controllerMock, controller.GetEntityController);

            // Change State
            invoice.Description = "Description2";
            var line = new SalesInvoiceLine { Description = "InvoiceLine2" };
            invoice.SalesInvoiceLines = new List<SalesInvoiceLine> { line };

            await entityController.UpdateAsync(invoice).ConfigureAwait(false);

            string data = controllerMock.Data;
            Assert.IsTrue(data.Contains(@"""Description"":""Description2"""));
            Assert.IsTrue(data.Contains(@"""Description"":""InvoiceLine2"""));
        }

        [TestMethod]
		[TestCategory("Unit Test")]
		public void EntityController_Update_WithExistingLinkedEntity_Succeeds()
		{
			var controllerMock = new ApiConnectionEntityControllerMock();
			var connector = new ApiConnectorMock();
			var controllerList = new ControllerList(connector, "https://start.exactonline.nl/api/v1/");

			var invoice = new SalesInvoice { Description = "New Description" };
			var line = new SalesInvoiceLine { Description = "InvoiceLine" };
			invoice.SalesInvoiceLines = new List<SalesInvoiceLine> { line };

			var controller = (Controller<SalesInvoice>)controllerList.GetController<SalesInvoice>();
			var entityController = new EntityController(invoice, "ID", invoice.InvoiceID.ToString(), controllerMock, controller.GetEntityController);
			Assert.IsTrue(controller.AddEntityToManagedEntitiesCollection(invoice));

			// Change State
			invoice.Description = "Description2";
			line.Description = "InvoiceLine2";

			entityController.Update(invoice);
			string data = controllerMock.Data;
			Assert.AreEqual(@"{""Description"":""Description2"",""SalesInvoiceLines"":[{""Description"":""InvoiceLine2""}]}", data);
		}

        [TestMethod]
        [TestCategory("Unit Test")]
        public async Task EntityController_Update_WithExistingLinkedEntity_SucceedsAsync()
        {
            var controllerMock = new ApiConnectionEntityControllerMock();
            var connector = new ApiConnectorMock();
            var controllerList = new ControllerList(connector, "https://start.exactonline.nl/api/v1/");

            var invoice = new SalesInvoice { Description = "New Description" };
            var line = new SalesInvoiceLine { Description = "InvoiceLine" };
            invoice.SalesInvoiceLines = new List<SalesInvoiceLine> { line };

            var controller = (Controller<SalesInvoice>)controllerList.GetController<SalesInvoice>();
            var entityController = new EntityController(invoice, "ID", invoice.InvoiceID.ToString(), controllerMock, controller.GetEntityController);
            Assert.IsTrue(controller.AddEntityToManagedEntitiesCollection(invoice));

            // Change State
            invoice.Description = "Description2";
            line.Description = "InvoiceLine2";

            await entityController.UpdateAsync( invoice ).ConfigureAwait(false);
            string data = controllerMock.Data;
            Assert.AreEqual(@"{""Description"":""Description2"",""SalesInvoiceLines"":[{""Description"":""InvoiceLine2""}]}", data);
        }

        [TestMethod]
		[TestCategory("Unit Test")]
		public void EntityController_Update_WithNoFieldsAltered_Succeeds()
		{
			var controllerMock = new ApiConnectionEntityControllerMock();
			var connector = new ApiConnectorMock();
			var controllerList = new ControllerList(connector, "https://start.exactonline.nl/api/v1/");

			var invoice = new SalesInvoice { Description = "New Description" };
			var line = new SalesInvoiceLine { Description = "Invoice Line" };
			invoice.SalesInvoiceLines = new List<SalesInvoiceLine> { line };

			var controller = (Controller<SalesInvoice>)controllerList.GetController<SalesInvoice>();
			var entityController = new EntityController(invoice, "ID", invoice.InvoiceID.ToString(), controllerMock, controller.GetEntityController);
			var returnValue = controller.AddEntityToManagedEntitiesCollection(invoice);

			Assert.IsTrue(returnValue);

			entityController.Update(invoice);
			string data = controllerMock.Data;
			Assert.IsNull(data);
		}

        [TestMethod]
        [TestCategory("Unit Test")]
        public async Task EntityController_Update_WithNoFieldsAltered_SucceedsAsync()
        {
            var controllerMock = new ApiConnectionEntityControllerMock();
            var connector = new ApiConnectorMock();
            var controllerList = new ControllerList(connector, "https://start.exactonline.nl/api/v1/");

            var invoice = new SalesInvoice { Description = "New Description" };
            var line = new SalesInvoiceLine { Description = "Invoice Line" };
            invoice.SalesInvoiceLines = new List<SalesInvoiceLine> { line };

            var controller = (Controller<SalesInvoice>)controllerList.GetController<SalesInvoice>();
            var entityController = new EntityController(invoice, "ID", invoice.InvoiceID.ToString(), controllerMock, controller.GetEntityController);
            var returnValue = controller.AddEntityToManagedEntitiesCollection(invoice);

            Assert.IsTrue(returnValue);

            await entityController.UpdateAsync(invoice).ConfigureAwait(false);
            string data = controllerMock.Data;
            Assert.IsNull(data);
        }

        [TestMethod]
		[TestCategory("Unit Test")]
		public void EntityController_Update_WithOnlyLinkedEntityFieldsAltered_Succeeds()
		{
			var controllerMock = new ApiConnectionEntityControllerMock();
			var connector = new ApiConnectorMock();
			var controllerList = new ControllerList(connector, "https://start.exactonline.nl/api/v1/");

			var invoice = new SalesInvoice { Description = "New Description" };
			var line = new SalesInvoiceLine { Description = "InvoiceLine" };
			invoice.SalesInvoiceLines = new List<SalesInvoiceLine> { line };

			var controller = (Controller<SalesInvoice>)controllerList.GetController<SalesInvoice>();
			var ec = new EntityController(invoice, "ID", invoice.InvoiceID.ToString(), controllerMock, controller.GetEntityController);
			Assert.IsTrue(controller.AddEntityToManagedEntitiesCollection(invoice));

			// Change State
			line.Description = "InvoiceLine2";
			ec.Update(invoice);

			string result = controllerMock.Data;
			const string expected = "{\"SalesInvoiceLines\":[{\"Description\":\"InvoiceLine2\"}]}";
			Assert.AreEqual(expected, result);
		}

        [TestMethod]
        [TestCategory("Unit Test")]
        public async Task EntityController_Update_WithOnlyLinkedEntityFieldsAltered_SucceedsAsync()
        {
            var controllerMock = new ApiConnectionEntityControllerMock();
            var connector = new ApiConnectorMock();
            var controllerList = new ControllerList(connector, "https://start.exactonline.nl/api/v1/");

            var invoice = new SalesInvoice { Description = "New Description" };
            var line = new SalesInvoiceLine { Description = "InvoiceLine" };
            invoice.SalesInvoiceLines = new List<SalesInvoiceLine> { line };

            var controller = (Controller<SalesInvoice>)controllerList.GetController<SalesInvoice>();
            var ec = new EntityController(invoice, "ID", invoice.InvoiceID.ToString(), controllerMock, controller.GetEntityController);
            Assert.IsTrue(controller.AddEntityToManagedEntitiesCollection(invoice));

            // Change State
            line.Description = "InvoiceLine2";
            await ec.UpdateAsync(invoice).ConfigureAwait(false);

            string result = controllerMock.Data;
            const string expected = "{\"SalesInvoiceLines\":[{\"Description\":\"InvoiceLine2\"}]}";
            Assert.AreEqual(expected, result);
        }

        #endregion
    }
}