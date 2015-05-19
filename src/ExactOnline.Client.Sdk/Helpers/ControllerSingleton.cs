using System;
using System.Collections;
using ExactOnline.Client.Sdk.Controllers;
using ExactOnline.Client.Sdk.Interfaces;

namespace ExactOnline.Client.Sdk.Helpers
{
	/// <summary>
	/// Manages instances of controllers to ensure that only one instance of a specific controller exists
	/// </summary>
	public class ControllerSingleton
	{
		static ControllerSingleton _instance;

		private IApiConnector _connector;
		private string _apiEndpoint;
		private Hashtable _controllers;

		/// <summary>
		/// Returns an instance of ControllerSingleton
		/// </summary>
		public static ControllerSingleton GetInstance(IApiConnector connector, string apiEndpoint)
		{
			// This has to be created for each apiEndpoint. Otherwise it's not possible to use the SDK with multiple divisions.
			_instance = new ControllerSingleton
			{
				_apiEndpoint = apiEndpoint,
				_connector = connector,
				_controllers = new Hashtable()
			};
			return _instance;
		}

		/// <summary>
		/// Returns an instance of ControllerSingleton. This method expects that the ControllerSingleton is already set.
		/// </summary>
		/// <returns></returns>
		public static ControllerSingleton GetInstance()
		{
			if (_instance != null)
			{
				return _instance;
			}
			throw new Exception("Instance is not yet set. Use GetInstance(ApiConnector, ApiEndPoint");
		}

		/// <summary>
		/// Gets the name of the generic type
		/// </summary>
		private string GetTypename<T>()
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
			var method = typeof(ControllerSingleton).GetMethod("GetController");
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
					case "AgingOverview": conn = new ApiConnection(_connector, _apiEndpoint + "read/financial/AgingOverview"); break;
					case "Asset": conn = new ApiConnection(_connector, _apiEndpoint + "assets/Assets"); break;
					case "BankAccount": conn = new ApiConnection(_connector, _apiEndpoint + "crm/BankAccounts"); break;
					case "Budget": conn = new ApiConnection(_connector, _apiEndpoint + "budget/Budgets"); break;
					case "Contact": conn = new ApiConnection(_connector, _apiEndpoint + "crm/Contacts"); break;
					case "Costcenter": conn = new ApiConnection(_connector, _apiEndpoint + "hrm/Costcenters"); break;
					case "CostTransaction": conn = new ApiConnection(_connector, _apiEndpoint + "project/CostTransactions"); break;
					case "Costunit": conn = new ApiConnection(_connector, _apiEndpoint + "hrm/Costunits"); break;
					case "Division": conn = new ApiConnection(_connector, _apiEndpoint + "hrm/Divisions"); break;
					case "Document": conn = new ApiConnection(_connector, _apiEndpoint + "documents/Documents"); break;
					case "DocumentAttachment": conn = new ApiConnection(_connector, _apiEndpoint + "documents/DocumentAttachments"); break;
					case "DocumentCategory": conn = new ApiConnection(_connector, _apiEndpoint + "documents/DocumentCategories"); break;
					case "DocumentType": conn = new ApiConnection(_connector, _apiEndpoint + "documents/DocumentTypes"); break;
					case "DocumentTypeCategory": conn = new ApiConnection(_connector, _apiEndpoint + "documents/DocumentTypeCategories"); break;
					case "Employee": conn = new ApiConnection(_connector, _apiEndpoint + "payroll/Employees"); break;
					case "ExchangeRate": conn = new ApiConnection(_connector, _apiEndpoint + "financial/ExchangeRates"); break;
					case "FinancialPeriod": conn = new ApiConnection(_connector, _apiEndpoint + "financial/FinancialPeriods"); break;
					case "GLAccount": conn = new ApiConnection(_connector, _apiEndpoint + "financial/GLAccounts"); break;
					case "GLClassification": conn = new ApiConnection(_connector, _apiEndpoint + "financial/GLClassifications"); break;
					case "GLScheme": conn = new ApiConnection(_connector, _apiEndpoint + "financial/GLSchemes"); break;
					case "Item": conn = new ApiConnection(_connector, _apiEndpoint + "logistics/Items"); break;
					case "ItemGroup": conn = new ApiConnection(_connector, _apiEndpoint + "logistics/ItemGroups"); break;
					case "Journal": conn = new ApiConnection(_connector, _apiEndpoint + "financial/Journals"); break;
					case "JournalStatus": conn = new ApiConnection(_connector, _apiEndpoint + "read/financial/JournalStatusByFinancialPeriod"); break;
					case "Layout": conn = new ApiConnection(_connector, _apiEndpoint + "salesinvoice/Layouts"); break;
					case "Mailbox": conn = new ApiConnection(_connector, _apiEndpoint + "mailbox/Mailboxes"); break;
					case "MailMessage": conn = new ApiConnection(_connector, _apiEndpoint + "mailbox/MailMessages"); break;
					case "MailMessageAttachment": conn = new ApiConnection(_connector, _apiEndpoint + "mailbox/MailMessageAttachments"); break;
					case "Operation": conn = new ApiConnection(_connector, _apiEndpoint + "manufacturing/Operations"); break;
					case "OperationResource": conn = new ApiConnection(_connector, _apiEndpoint + "manufacturing/OperationResources"); break;
					case "Opportunity": conn = new ApiConnection(_connector, _apiEndpoint + "read/crm/Opportunities"); break;
					case "OpportunityContact": conn = new ApiConnection(_connector, _apiEndpoint + "read/crm/OpportunityContacts"); break;
					case "OutstandingInvoiceOverview": conn = new ApiConnection(_connector, _apiEndpoint + "read/financial/OutstandingInvoicesOverview"); break;
					case "PaymentCondition": conn = new ApiConnection(_connector, _apiEndpoint + "cashflow/PaymentConditions"); break;
					case "PeriodRevenue": conn = new ApiConnection(_connector, _apiEndpoint + "read/financial/RevenueList"); break;
					case "PriceList": conn = new ApiConnection(_connector, _apiEndpoint + "sales/PriceLists"); break;
					case "PrintedSalesInvoice": conn = new ApiConnection(_connector, _apiEndpoint + "salesinvoice/PrintedSalesInvoices"); break;
					case "ProductionArea": conn = new ApiConnection(_connector, _apiEndpoint + "manufacturing/ProductionAreas"); break;
					case "SalesEntry": conn = new ApiConnection(_connector, _apiEndpoint + "salesentry/SalesEntries"); break;
					case "SalesEntryLine": conn = new ApiConnection(_connector, _apiEndpoint + "salesentry/SalesEntryLines"); break;
					case "SalesInvoice": conn = new ApiConnection(_connector, _apiEndpoint + "salesinvoice/SalesInvoices"); break;
					case "SalesInvoiceLine": conn = new ApiConnection(_connector, _apiEndpoint + "salesinvoice/SalesInvoiceLines"); break;
					case "SalesItemPrice": conn = new ApiConnection(_connector, _apiEndpoint + "SalesItemPrice - Function Details"); break;
					case "ShopOrder": conn = new ApiConnection(_connector, _apiEndpoint + "manufacturing/ShopOrders"); break;
					case "ShopOrderMaterialPlan": conn = new ApiConnection(_connector, _apiEndpoint + "manufacturing/ShopOrderMaterialPlans"); break;
					case "ShopOrderRoutingStepPlan": conn = new ApiConnection(_connector, _apiEndpoint + "manufacturing/ShopOrderRoutingStepPlans"); break;
					case "StockPosition": conn = new ApiConnection(_connector, _apiEndpoint + "StockPosition - Function Details"); break;
					case "TaxDocument": conn = new ApiConnection(_connector, _apiEndpoint + "read/financial/Returns"); break;
					case "TimeTransaction": conn = new ApiConnection(_connector, _apiEndpoint + "project/TimeTransactions"); break;
					case "Transaction": conn = new ApiConnection(_connector, _apiEndpoint + "financialtransaction/Transactions"); break;
					case "Unit": conn = new ApiConnection(_connector, _apiEndpoint + "logistics/Units"); break;
					case "User": conn = new ApiConnection(_connector, _apiEndpoint + "users/Users"); break;
					case "UserRole": conn = new ApiConnection(_connector, _apiEndpoint + "users/UserRoles"); break;
					case "VATCode": conn = new ApiConnection(_connector, _apiEndpoint + "vat/VATCodes"); break;
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

		/// <summary>
		/// Deletes instance of ControllerSingleton
		/// </summary>
		public static void Clean()
		{
			_instance = null;
		}
	
	}
}
