using System;
using System.Collections.Generic;
using ExactOnline.Client.Models.SalesInvoice;
using ExactOnline.Client.Sdk.Controllers;
using ExactOnline.Client.Sdk.PerformanceTests.Helpers;
using ExactOnline.Client.Sdk.UnitTests.MockObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExactOnline.Client.Sdk.PerformanceTests
{
	[TestClass]
	public class ObjectToJsonTest
	{

		[TestCategory("Performance Test")]
		[TestMethod, Ignore]
		public void TestPerformanceLinkedObjectCreateSequence()
		{
			var originalProcessTime = TimeSpan.FromSeconds(1.3);
			var currentProcessTime = TestTimer.Time(CreateLinkedObjects);
			Assert.IsTrue(currentProcessTime < originalProcessTime);
		}

		[TestCategory("Performance Test")]
		[TestMethod, Ignore]
		public void TestPerformanceEmptyLinkedObjectCreateSequence()
		{
			var originalProcessTime = TimeSpan.FromSeconds(1.1);
			var currentProcessTime = TestTimer.Time(CreateEmptyLinkedEntities);
			Assert.IsTrue(currentProcessTime < originalProcessTime);
		}

		private static void CreateLinkedObjects()
		{
			for (int i = 0; i < 100; i++)
			{
				// Create Object
				var newInvoice = new SalesInvoice
				{
					Currency = "EUR",
					OrderDate = new DateTime(2012, 10, 26),
					InvoiceTo = new Guid("3734121e-1544-4b77-9ae2-7203e9bd6046"),
					Journal = "50",
					OrderedBy = new Guid("3734121e-1544-4b77-9ae2-7203e9bd6046"),
					Description = "New invoice for Entity With Collection"
				};

				var newInvoiceLine = new SalesInvoiceLine
				{
					Description = "New invoice line for Entity With Collection",
					Item = new Guid("4f68481a-7a2c-4fbc-a3a0-0c494df3fa0d")
				};

				var invoicelines = new List<SalesInvoiceLine> { newInvoiceLine };
				newInvoice.SalesInvoiceLines = invoicelines;

				// Set Mock Connection and Create object
				var controllerMock = new ApiConnectionEntityControllerMock();
				var controller = new Controller<SalesInvoice>(controllerMock);
				controller.Create(ref newInvoice, true);
			}
		}

		private static void CreateEmptyLinkedEntities()
		{
			for (int i = 0; i < 100; i++)
			{
				// Create Object
				var newInvoice = new SalesInvoice
				{
					Currency = "EUR",
					OrderDate = new DateTime(2012, 10, 26),
					InvoiceTo = new Guid("3734121e-1544-4b77-9ae2-7203e9bd6046"),
					Journal = "50",
					OrderedBy = new Guid("3734121e-1544-4b77-9ae2-7203e9bd6046"),
					Description = "New invoice for Entity With Collection"
				};

				// Set Mock Connection and Create object
				var controllerMock = new ApiConnectionEntityControllerMock();
				var controller = new Controller<SalesInvoice>(controllerMock);
				controller.Create(ref newInvoice, true);
			}
		}
	}
}
