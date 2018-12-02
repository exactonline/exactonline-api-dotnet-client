using System.IO;
using System.Threading.Tasks;
using ExactOnline.Client.Sdk.Interfaces;

namespace ExactOnline.Client.Sdk.UnitTests.MockObjects
{
	class ApiConnectorControllerMock : IApiConnector
	{
		public int Count()
		{
			return 0;
		}

        Task<int> CountAsync()
        {
            return Task.FromResult(Count());
        }

        public string DoCleanRequest(string uri)
		{
			return "";
		}

        public Task<string> DoCleanRequestAsync(string uri)
        {
            return Task.FromResult(DoCleanRequest(uri));
        }

        public string DoCleanRequest(string uri, string oDataQuery)
		{
			return "";
		}

        public Task<string> DoCleanRequestAsync(string uri, string oDataQuery)
        {
            return Task.FromResult(DoCleanRequest(uri,oDataQuery));
        }

        public string DoGetRequest(string endpoint, string parameters)
		{
			return @"{
	""d"": {
		""results"": [
			{
				""__metadata"": {
					""uri"": ""https://start.exactonline.nl/api/v1/499156/salesinvoice/SalesInvoices(guid'c00ee12c-2b39-4e84-b332-54a3c722e5dd')"",
					""type"": ""Exact.Web.Api.Models.SalesInvoice""
				},
				""AmountFC"": 9075,
				""AmountDC"": 9075,
				""Created"": ""/Date(1382667906263)/"",
				""Creator"": ""99d87844-e4ef-4ac5-968c-fb863eaced16"",
				""CreatorFullName"": null,
				""Currency"": ""EUR"",
				""Description"": ""Levering diverse artikelen"",
				""Division"": 499156,
				""Document"": null,
				""DocumentNumber"": null,
				""DocumentSubject"": null,
				""DueDate"": ""/Date(1351209600000)/"",
				""InvoiceDate"": ""/Date(1351209600000)/"",
				""InvoiceID"": ""c00ee12c-2b39-4e84-b332-54a3c722e5dd"",
				""InvoiceTo"": ""3734121e-1544-4b77-9ae2-7203e9bd6046"",
				""InvoiceToContactPerson"": ""e893e6e6-6eeb-4420-a5b2-378618ba9f27"",
				""InvoiceToContactPersonFullName"": ""Karin Jansen"",
				""InvoiceToName"": ""Test ABC Producten & Diensten B.V."",
				""InvoiceNumber"": null,
				""Journal"": ""50"",
				""JournalDescription"": ""Verkoopboek"",
				""Modified"": ""/Date(1382667906263)/"",
				""Modifier"": ""99d87844-e4ef-4ac5-968c-fb863eaced16"",
				""ModifierFullName"": null,
				""OrderDate"": ""/Date(1351209600000)/"",
				""OrderedBy"": ""3734121e-1544-4b77-9ae2-7203e9bd6046"",
				""OrderedByContactPerson"": ""e893e6e6-6eeb-4420-a5b2-378618ba9f27"",
				""OrderedByContactPersonFullName"": ""Karin Jansen"",
				""OrderedByName"": ""Test ABC Producten & Diensten B.V."",
				""OrderNumber"": 1,
				""PaymentCondition"": ""21"",
				""PaymentConditionDescription"": ""21 dagen"",
				""Remarks"": null,
				""Salesperson"": null,
				""SalespersonFullName"": null,
				""Status"": 20,
				""StatusDescription"": ""Open"",
				""Type"": 8020,
				""TypeDescription"": ""Normal"",
				""VATAmountFC"": 1575,
				""VATAmountDC"": 1575,
				""YourRef"": null,
				""SalesInvoiceLines"": {
					""results"": [
						{
							""__metadata"": {
								""uri"": ""https://start.exactonline.nl/api/v1/499156/salesinvoice/SalesInvoiceLines(guid'ea799352-5da3-4b16-acc0-20dcfe4d02fc')"",
								""type"": ""Exact.Web.Api.Models.SalesInvoiceLine""
							},
							""AmountFC"": 7500,
							""AmountDC"": 7500,
							""CostCenter"": null,
							""CostCenterDescription"": null,
							""CostUnit"": null,
							""CostUnitDescription"": null,
							""Description"": ""Standaard artikel"",
							""Discount"": 0,
							""Division"": 499156,
							""Employee"": null,
							""EmployeeFullName"": null,
							""EndTime"": null,
							""GLAccount"": ""4eae751d-fc91-4c99-b1e6-646fe3401a12"",
							""GLAccountDescription"": ""This is a Test"",
							""ID"": ""ea799352-5da3-4b16-acc0-20dcfe4d02fc"",
							""InvoiceID"": ""c00ee12c-2b39-4e84-b332-54a3c722e5dd"",
							""Item"": ""4f68481a-7a2c-4fbc-a3a0-0c494df3fa0d"",
							""ItemDescription"": ""Standaard artikel"",
							""LineNumber"": 1,
							""NetPrice"": 25,
							""Notes"": null,
							""Pricelist"": null,
							""PricelistDescription"": null,
							""Project"": null,
							""ProjectDescription"": null,
							""Quantity"": 300,
							""StartTime"": null,
							""Subscription"": null,
							""SubscriptionDescription"": null,
							""UnitCode"": ""pc"",
							""UnitDescription"": ""Piece"",
							""UnitPrice"": 25,
							""VATAmountFC"": 1575,
							""VATAmountDC"": 1575,
							""VATCode"": ""02 "",
							""VATCodeDescription"": ""Af te dragen BTW hoog tarief, exclusief"",
							""VATPercentage"": 0.21
						}
					]
				}
			}
		]
	}
}";
		}

        public Task<string> DoGetRequestAsync(string endpoint, string parameters)
        {
            return Task.FromResult(DoGetRequest(endpoint, parameters));
        }

        public string DoPostRequest(string endpoint, string postdata)
		{
			return string.Empty;
		}

        public Task<string> DoPostRequestAsync(string endpoint, string postdata)
        {
            return Task.FromResult(DoPostRequest(endpoint, postdata));
        }

        public string DoPutRequest(string endpoint, string putData)
		{
			return string.Empty;
		}

        public Task<string> DoPutRequestAsync(string endpoint, string putData)
        {
            return Task.FromResult(DoPutRequest(endpoint, putData));
        }

        public string DoDeleteRequest(string endpoint)
		{
			return string.Empty;
		}

        public Task<string> DoDeleteRequestAsync(string endpoint)
        {
            return Task.FromResult(DoDeleteRequest(endpoint));
        }

        public int GetCurrentDivision(string website)
		{
			return -1;
		}

        public Task<int> GetCurrentDivisionAsync(string website)
        {
            return Task.FromResult(GetCurrentDivision(website));
        }

        public Stream DoGetFileRequest(string endpoint)
	    {
	        return Stream.Null;
	    }

        public Task<Stream> DoGetFileRequestAsync(string endpoint)
        {
            return Task.FromResult(DoGetFileRequest(endpoint));
        }
    }
}
