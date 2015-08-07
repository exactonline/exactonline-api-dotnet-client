using System;
using System.Collections;
using ExactOnline.Client.Sdk.Controllers;
using ExactOnline.Client.Sdk.Interfaces;

namespace ExactOnline.Client.Sdk.Helpers
{
	/// <summary>
	/// Manages instances of controllers
	/// </summary>
	public class ControllerList
	{
		private readonly IApiConnector _connector;
		private readonly string _apiEndpoint;
		private readonly Hashtable _controllers;

		public ControllerList(IApiConnector connector, string apiEndpoint)
		{
			_apiEndpoint = apiEndpoint;
			_connector = connector;
			_controllers = new Hashtable();
		}

		/// <summary>
		/// Gets the name of the generic type
		/// </summary>
		private static string GetTypename<T>()
		{
			// Get entity name from type
			var entity = typeof(T).ToString();
			var split = entity.Split('.');
			entity = split[split.Length - 1];
			return entity;
		}

		/// <summary>
		/// Method for getting the correct EntityManager. This method is used as a Delegate
		/// </summary>
		public IEntityManager GetEntityManager(Type type)
		{
			var method = typeof(ControllerList).GetMethod("GetController");
			var genericMethod = method.MakeGenericMethod(new[] { type });
			var controller = (IEntityManager)genericMethod.Invoke(this, null);
			return controller;
		}

		/// <summary>
		/// Returns an instance of Controller with the specified type
		/// </summary>
		public IController<T> GetController<T>() where T : class
		{
			var typename = GetTypename<T>();
			var returncontroller = (Controller<T>)_controllers[typename];

			// If not exists: create
			if (returncontroller == null)
			{
				ApiConnection conn;

				switch (typename)
				{
					case "Me": conn = new ApiConnection(_connector, _apiEndpoint + "system/Me"); break;
					case "Account": conn = new ApiConnection(_connector, _apiEndpoint + "crm/Accounts"); break;
					case "AccountClass": conn = new ApiConnection(_connector, _apiEndpoint + "crm/AccountClasses"); break;
					case "AccountClassification": conn = new ApiConnection(_connector, _apiEndpoint + "crm/AccountClassificationNames"); break;
					case "AccountClassificationName": conn = new ApiConnection(_connector, _apiEndpoint + "crm/AccountClassifications"); break;
					case "Address": conn = new ApiConnection(_connector, _apiEndpoint + "crm/Addresses"); break;
					case "AddressState": conn = new ApiConnection(_connector, _apiEndpoint + "crm/AddressStates"); break;
					case "AgingOverview": conn = new ApiConnection(_connector, _apiEndpoint + "read/financial/AgingOverview"); break;
					case "Asset": conn = new ApiConnection(_connector, _apiEndpoint + "assets/Assets"); break;
					case "Bank": conn = new ApiConnection(_connector, _apiEndpoint + "cashflow/Banks"); break;
					case "BankAccount": conn = new ApiConnection(_connector, _apiEndpoint + "crm/BankAccounts"); break;
					case "BankEntry": conn = new ApiConnection(_connector, _apiEndpoint + "financialtransaction/BankEntries"); break;
					case "BankEntryLine": conn = new ApiConnection(_connector, _apiEndpoint + "financialtransaction/BankEntryLines"); break;
					case "Budget": conn = new ApiConnection(_connector, _apiEndpoint + "budget/Budgets"); break;
					case "CashEntry": conn = new ApiConnection(_connector, _apiEndpoint + "financialtransaction/CashEntries"); break;
					case "CashEntryLine": conn = new ApiConnection(_connector, _apiEndpoint + "financialtransaction/CashEntryLines"); break;
					case "Contact": conn = new ApiConnection(_connector, _apiEndpoint + "crm/Contacts"); break;
					case "Costcenter": conn = new ApiConnection(_connector, _apiEndpoint + "hrm/Costcenters"); break;
					case "CostTransaction": conn = new ApiConnection(_connector, _apiEndpoint + "project/CostTransactions"); break;
					case "Costunit": conn = new ApiConnection(_connector, _apiEndpoint + "hrm/Costunits"); break;
					case "Currency": conn = new ApiConnection(_connector, _apiEndpoint + "general/Currencies"); break;
					case "DepreciationMethod": conn = new ApiConnection(_connector, _apiEndpoint + "assets/DepreciationMethods"); break;
					case "DirectDebitMandate": conn = new ApiConnection(_connector, _apiEndpoint + "cashflow/DirectDebitMandates"); break;
					case "Division": conn = new ApiConnection(_connector, _apiEndpoint + "hrm/Divisions"); break;
					case "Document": conn = new ApiConnection(_connector, _apiEndpoint + "documents/Documents"); break;
					case "DocumentAttachment": conn = new ApiConnection(_connector, _apiEndpoint + "documents/DocumentAttachments"); break;
					case "DocumentCategory": conn = new ApiConnection(_connector, _apiEndpoint + "documents/DocumentCategories"); break;
					case "DocumentType": conn = new ApiConnection(_connector, _apiEndpoint + "documents/DocumentTypes"); break;
					case "DocumentTypeCategory": conn = new ApiConnection(_connector, _apiEndpoint + "documents/DocumentTypeCategories"); break;
					case "Employee": conn = new ApiConnection(_connector, _apiEndpoint + "payroll/Employees"); break;
					case "ExchangeRate": conn = new ApiConnection(_connector, _apiEndpoint + "financial/ExchangeRates"); break;
					case "FinancialPeriod": conn = new ApiConnection(_connector, _apiEndpoint + "financial/FinancialPeriods"); break;
					case "GeneralJournalEntry": conn = new ApiConnection(_connector, _apiEndpoint + "generaljournalentry/GeneralJournalEntries"); break;
					case "GeneralJournalEntryLine": conn = new ApiConnection(_connector, _apiEndpoint + "generaljournalentry/GeneralJournalEntryLines"); break;
					case "GLAccount": conn = new ApiConnection(_connector, _apiEndpoint + "financial/GLAccounts"); break;
					case "GLClassification": conn = new ApiConnection(_connector, _apiEndpoint + "financial/GLClassifications"); break;
					case "GLScheme": conn = new ApiConnection(_connector, _apiEndpoint + "financial/GLSchemes"); break;
					case "GLTransactionType": conn = new ApiConnection(_connector, _apiEndpoint + "financial/GLTransactionTypes"); break;
					case "HourCostType": conn = new ApiConnection(_connector, _apiEndpoint + "read/project/HourCostTypes"); break;
					case "Item": conn = new ApiConnection(_connector, _apiEndpoint + "logistics/Items"); break;
					case "ItemGroup": conn = new ApiConnection(_connector, _apiEndpoint + "logistics/ItemGroups"); break;
					case "ItemVersion": conn = new ApiConnection(_connector, _apiEndpoint + "logistics/ItemVersions"); break;
					case "Journal": conn = new ApiConnection(_connector, _apiEndpoint + "financial/Journals"); break;
					case "JournalStatus": conn = new ApiConnection(_connector, _apiEndpoint + "read/financial/JournalStatusByFinancialPeriod"); break;
					case "Layout": conn = new ApiConnection(_connector, _apiEndpoint + "salesinvoice/Layouts"); break;
					case "Mailbox": conn = new ApiConnection(_connector, _apiEndpoint + "mailbox/Mailboxes"); break;
					case "MailMessage": conn = new ApiConnection(_connector, _apiEndpoint + "mailbox/MailMessages"); break;
					case "MailMessageAttachment": conn = new ApiConnection(_connector, _apiEndpoint + "mailbox/MailMessageAttachments"); break;
					case "ManufacturingTimeTransaction": conn = new ApiConnection(_connector, _apiEndpoint + "manufacturing/TimeTransactions"); break;
					case "OpeningBalanceAfterEntry": conn = new ApiConnection(_connector, _apiEndpoint + "openingbalance/CurrentYear/AfterEntry"); break;
					case "OpeningBalanceProcessed": conn = new ApiConnection(_connector, _apiEndpoint + "openingbalance/CurrentYear/Processed"); break;
					case "Operation": conn = new ApiConnection(_connector, _apiEndpoint + "manufacturing/Operations"); break;
					case "OperationResource": conn = new ApiConnection(_connector, _apiEndpoint + "manufacturing/OperationResources"); break;
					case "Opportunity": conn = new ApiConnection(_connector, _apiEndpoint + "read/crm/Opportunities"); break;
					case "OpportunityContact": conn = new ApiConnection(_connector, _apiEndpoint + "read/crm/OpportunityContacts"); break;
					case "OutstandingInvoiceOverview": conn = new ApiConnection(_connector, _apiEndpoint + "read/financial/OutstandingInvoicesOverview"); break;
					case "PaymentCondition": conn = new ApiConnection(_connector, _apiEndpoint + "cashflow/PaymentConditions"); break;
					case "PeriodRevenue": conn = new ApiConnection(_connector, _apiEndpoint + "read/financial/RevenueList"); break;
					case "PriceList": conn = new ApiConnection(_connector, _apiEndpoint + "sales/PriceLists"); break;
					case "PrintedSalesInvoice": conn = new ApiConnection(_connector, _apiEndpoint + "salesinvoice/PrintedSalesInvoices"); break;
					case "PrintedSalesOrder": conn = new ApiConnection(_connector, _apiEndpoint + "salesorder/PrintedSalesOrders"); break;
					case "ProductionArea": conn = new ApiConnection(_connector, _apiEndpoint + "manufacturing/ProductionAreas"); break;
					case "Project": conn = new ApiConnection(_connector, _apiEndpoint + "project/Projects"); break;
					case "PurchaseEntry": conn = new ApiConnection(_connector, _apiEndpoint + "purchaseentry/PurchaseEntries"); break;
					case "PurchaseEntryLine": conn = new ApiConnection(_connector, _apiEndpoint + "purchaseentry/PurchaseEntryLines"); break;
					case "RecentCosts": conn = new ApiConnection(_connector, _apiEndpoint + "read/project/RecentCosts"); break;
					case "RecentHours": conn = new ApiConnection(_connector, _apiEndpoint + "read/project/RecentHours"); break;
					case "ReportingBalance": conn = new ApiConnection(_connector, _apiEndpoint + "financial/ReportingBalance"); break;
					case "SalesEntry": conn = new ApiConnection(_connector, _apiEndpoint + "salesentry/SalesEntries"); break;
					case "SalesEntryLine": conn = new ApiConnection(_connector, _apiEndpoint + "salesentry/SalesEntryLines"); break;
					case "SalesInvoice": conn = new ApiConnection(_connector, _apiEndpoint + "salesinvoice/SalesInvoices"); break;
					case "SalesInvoiceLine": conn = new ApiConnection(_connector, _apiEndpoint + "salesinvoice/SalesInvoiceLines"); break;
					case "SalesOrder": conn = new ApiConnection(_connector, _apiEndpoint + "salesorder/SalesOrders"); break;
					case "SalesOrderLine": conn = new ApiConnection(_connector, _apiEndpoint + "salesorder/SalesOrderLines"); break;
					case "ShopOrder": conn = new ApiConnection(_connector, _apiEndpoint + "manufacturing/ShopOrders"); break;
					case "ShopOrderMaterialPlan": conn = new ApiConnection(_connector, _apiEndpoint + "manufacturing/ShopOrderMaterialPlans"); break;
					case "ShopOrderRoutingStepPlan": conn = new ApiConnection(_connector, _apiEndpoint + "manufacturing/ShopOrderRoutingStepPlans"); break;
					case "Subscription": conn = new ApiConnection(_connector, _apiEndpoint + "subscription/Subscriptions"); break;
					case "SubscriptionLine": conn = new ApiConnection(_connector, _apiEndpoint + "subscription/SubscriptionLines"); break;
					case "SubscriptionReasonCode": conn = new ApiConnection(_connector, _apiEndpoint + "subscription/SubscriptionReasonCodes"); break;
					case "SubscriptionRestrictionEmployee": conn = new ApiConnection(_connector, _apiEndpoint + "subscription/SubscriptionRestrictionEmployees"); break;
					case "SubscriptionRestrictionItem": conn = new ApiConnection(_connector, _apiEndpoint + "subscription/SubscriptionRestrictionItems"); break;
					case "SubscriptionType": conn = new ApiConnection(_connector, _apiEndpoint + "subscription/SubscriptionTypes"); break;
					case "TaxDocument": conn = new ApiConnection(_connector, _apiEndpoint + "read/financial/Returns"); break;
					case "TaxSchedule": conn = new ApiConnection(_connector, _apiEndpoint + "vat/TaxSchedules"); break;
					case "TaxScheduleComponent": conn = new ApiConnection(_connector, _apiEndpoint + "vat/TaxScheduleComponents"); break;
					case "TimeTransaction": conn = new ApiConnection(_connector, _apiEndpoint + "project/TimeTransactions"); break;
					case "Transaction": conn = new ApiConnection(_connector, _apiEndpoint + "financialtransaction/Transactions"); break;
					case "TransactionLine": conn = new ApiConnection(_connector, _apiEndpoint + "financialtransaction/TransactionLines"); break;
					case "Unit": conn = new ApiConnection(_connector, _apiEndpoint + "logistics/Units"); break;
					case "User": conn = new ApiConnection(_connector, _apiEndpoint + "users/Users"); break;
					case "UserRole": conn = new ApiConnection(_connector, _apiEndpoint + "users/UserRoles"); break;
					case "VATCode": conn = new ApiConnection(_connector, _apiEndpoint + "vat/VATCodes"); break;
					case "VatPercentage": conn = new ApiConnection(_connector, _apiEndpoint + "vat/VatPercentages"); break;
					case "Warehouse": conn = new ApiConnection(_connector, _apiEndpoint + "inventory/Warehouses"); break;
					case "Workcenter": conn = new ApiConnection(_connector, _apiEndpoint + "manufacturing/Workcenters"); break;


					default:
						throw new Exception("Specified entity is not known in Exact Online. Please check the reference documentation");
				}

				returncontroller = new Controller<T>(conn)
				{
					GetManagerForEntity = GetEntityManager
				};
				_controllers.Add(typename, returncontroller);
			}

			return returncontroller;
		}

	}
}
