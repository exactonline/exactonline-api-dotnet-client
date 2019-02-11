using ExactOnline.Client.Models.Assets;
using ExactOnline.Client.Models.Budget;
using ExactOnline.Client.Models.Cashflow;
using ExactOnline.Client.Models.CRM;
using ExactOnline.Client.Models.Documents;
using ExactOnline.Client.Models.Financial;
using ExactOnline.Client.Models.HRM;
using ExactOnline.Client.Models.Inventory;
using ExactOnline.Client.Models.Logistics;
using ExactOnline.Client.Models.Mailbox;
using ExactOnline.Client.Models.Manufacturing;
using ExactOnline.Client.Models.Payroll;
using ExactOnline.Client.Models.Project;
using ExactOnline.Client.Models.Sales;
using ExactOnline.Client.Models.SalesEntry;
using ExactOnline.Client.Models.SalesInvoice;
using ExactOnline.Client.Models.Users;
using ExactOnline.Client.Models.VAT;
using ExactOnline.Client.Sdk.Controllers;
using ExactOnline.Client.Sdk.TestContext;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExactOnline.Client.Sdk.UserAcceptanceTests.UserLevel
{
	[TestClass]
	public class AttributesToAllEntities
	{
		[TestMethod]
		[TestCategory("User Acceptance Tests")]
		public void ReadAllEntities()
		{
			var toc = new TestObjectsCreator();
			var client = new ExactOnlineClient(toc.EndPoint, toc.GetOAuthAuthenticationToken);

			// Not supported entities
			//var printedSalesInvoiceCollection = client.For<PrintedSalesInvoice>().Top(1); // Does only support post		
			//var salesItemPriceCollection = client.For<SalesItemPrice>().Top(1); // Is a function
			//var stockPositionCollection = client.For<StockPosition>().Top(1); // Is a function

			// Read Entities
			var agingOverviewCollection = client.For<AgingOverview>().Select("AmountPayable").Top(1);
			var accountCollection = client.For<Account>().Select("ID").Top(1);
			var accountClassCollection = client.For<AccountClass>().Select("ID").Top(1);
			var assetCollection = client.For<Asset>().Select("ID").Top(1);
			var bankAccountCollection = client.For<BankAccount>().Select("ID").Top(1);
			var budgetCollection = client.For<Budget>().Select("ID").Top(1);
			var contactCollection = client.For<Contact>().Select("ID").Top(1);
			var costcenterCollection = client.For<Costcenter>().Select("ID").Top(1);
			var costTransactionCollection = client.For<CostTransaction>().Select("ID").Top(1);
			var costunitCollection = client.For<Costunit>().Select("ID").Top(1);
			var divisionCollection = client.For<Division>().Select("HID").Top(1);
			var documentCollection = client.For<Client.Models.Documents.Document>().Select("ID").Top(1);
			var documentAttachmentCollection = client.For<DocumentAttachment>().Select("ID").Top(1);
			var documentCategoryCollection = client.For<DocumentCategory>().Select("ID").Top(1);
			var documentTypeCollection = client.For<DocumentType>().Select("ID").Top(1);
			var documentTypeCategoryCollection = client.For<DocumentTypeCategory>().Select("ID").Top(1);
			var employeeCollection = client.For<Employee>().Select("ID").Top(1);
			var exchangeRateCollection = client.For<ExchangeRate>().Select("ID").Top(1);
			var financialPeriodCollection = client.For<FinancialPeriod>().Select("ID").Top(1);
			var glAccountCollection = client.For<GLAccount>().Select("ID").Top(1);
			var glClassificationCollection = client.For<GLClassification>().Select("ID").Top(1);
			var glSchemeCollection = client.For<GLScheme>().Select("ID").Top(1);
			var itemCollection = client.For<Item>().Select("ID").Top(1);
			var itemGroupCollection = client.For<ItemGroup>().Select("ID").Top(1);
			var journalCollection = client.For<Journal>().Select("ID").Top(1);
			var layoutCollection = client.For<Layout>().Select("ID").Top(1);
			var mailboxCollection = client.For<Mailbox>().Select("ID").Top(1);
			var mailMessageCollection = client.For<MailMessagesSent>().Select("ID").Top(1);
			var mailMessageAttachmentCollection = client.For<MailMessageAttachment>().Select("ID").Top(1);
			var operationCollection = client.For<Operation>().Select("ID").Top(1);
			var operationResourceCollection = client.For<OperationResource>().Select("ID").Top(1);
			var opportunityCollection = client.For<Opportunity>().Select("ID").Top(1);
			var opportunityContactCollection = client.For<OpportunityContact>().Select("ID").Top(1);
			var outstandingInvoiceOverviewCollection = client.For<OutstandingInvoicesOverview>().Select("CurrencyCode").Top(1);
			var paymentConditionCollection = client.For<PaymentCondition>().Select("ID").Top(1);
			var priceListCollection = client.For<PriceList>().Select("ID").Top(1);
			var productionAreaCollection = client.For<ProductionArea>().Select("ID").Top(1);
			var salesEntryCollection = client.For<SalesEntry>().Select("EntryID").Top(1);
			var salesEntryLineCollection = client.For<SalesEntryLine>().Select("ID").Top(1);
			var salesInvoiceCollection = client.For<SalesInvoice>().Select("InvoiceID").Top(1);
			var salesInvoiceLineCollection = client.For<SalesInvoiceLine>().Select("ID").Top(1);
			var shopOrderCollection = client.For<ShopOrder>().Select("ID").Top(1);
			var shopOrderMaterialPlanCollection = client.For<ShopOrderMaterialPlan>().Select("ID").Top(1);
			var shopOrderRoutingStepPlanCollection = client.For<ShopOrderRoutingStepPlan>().Select("ID").Top(1);
			var taxDocumentCollection = client.For<Return>().Select("DocumentID").Top(1);
			var timeTransactionCollection = client.For<Client.Models.Project.TimeTransaction>().Select("ID").Top(1);
			var unitCollection = client.For<Unit>().Select("ID").Top(1);
			var userCollection = client.For<User>().Select("UserID").Top(1);
			var userRoleCollection = client.For<UserRole>().Select("ID").Top(1);
			var vatCodeCollection = client.For<VATCode>().Select("Code").Top(1);
			var warehouseCollection = client.For<Warehouse>().Select("ID").Top(1);
			var workcenterCollection = client.For<Workcenter>().Select("ID").Top(1);
		}
	}
}
