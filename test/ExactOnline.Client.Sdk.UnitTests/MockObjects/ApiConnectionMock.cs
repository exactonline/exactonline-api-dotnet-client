using ExactOnline.Client.Sdk.Interfaces;
using System.Threading.Tasks;

namespace ExactOnline.Client.Sdk.UnitTests.MockObjects
{
	public sealed class ApiConnectionMock : IApiConnection
	{
		#region IApiConnection Members

		int IApiConnection.Count(string parameters)
		{
			return 0;
		}

        Task<int> IApiConnection.CountAsync(string parameters)
        {
            return Task.FromResult((this as IApiConnection).Count(parameters));
        }

        string IApiConnection.Get(string parameters)
		{
			const string correctJsonArray = @"{
			""d"": {
				""results"": [
					{
						""__metadata"": {
							""uri"": ""https://start.exactonline.nl/api/v1/499156/crm/Accounts(guid'71b961de-b9f3-49fe-883d-0f46c7e0e89b')"",
							""type"": ""Exact.Web.Api.Models.Account""
						},
						""Accountant"": null,
						""AccountManager"": null,
						""AccountManagerFullName"": null,
						""AccountManagerHID"": null,
						""ActivitySector"": null,
						""ActivitySubSector"": null,
						""AddressLine1"": ""Voorveste 9"",
						""AddressLine2"": null,
						""AddressLine3"": null,
						""BankAccounts"": {
							""__deferred"": {
								""uri"": ""https://start.exactonline.nl/api/v1/499156/crm/Accounts(guid'71b961de-b9f3-49fe-883d-0f46c7e0e89b')/BankAccounts""
							}
						},
						""Blocked"": false,
						""BRIN"": null,
						""BusinessType"": null,
						""CanDropShip"": false,
						""ChamberOfCommerce"": null,
						""City"": ""Houten"",
						""Classification"": null,
						""ClassificationDescription"": null,
						""Code"": ""                 8"",
						""CodeAtSupplier"": null,
						""CompanySize"": null,
						""ConsolidationScenario"": 2,
						""ControlledDate"": null,
						""Costcenter"": null,
						""CostcenterDescription"": null,
						""CostPaid"": 0,
						""Country"": ""NL "",
						""Created"": ""/Date(1382667872203)/"",
						""Creator"": ""99d87844-e4ef-4ac5-968c-fb863eaced16"",
						""CreatorFullName"": null,
						""CreditLinePurchase"": 0,
						""CreditLineSales"": 0,
						""Currency"": null,
						""CustomerSince"": null,
						""DiscountPurchase"": 0,
						""DiscountSales"": 0,
						""Division"": 499156,
						""Document"": null,
						""DunsNumber"": null,
						""Email"": null,
						""EndDate"": null,
						""Fax"": null,
						""GLAccountPurchase"": ""3d8f75a8-ef72-4ef0-b868-e88d44e8115f"",
						""GLAccountSales"": null,
						""GLAP"": ""686a70b6-0033-4e7b-bb3b-bbcf7f9954a2"",
						""GLAR"": null,
						""ID"": ""71b961de-b9f3-49fe-883d-0f46c7e0e89b"",
						""IntraStatArea"": null,
						""IntraStatDeliveryTerm"": null,
						""IntraStatSystem"": null,
						""IntraStatTransactionA"": null,
						""IntraStatTransactionB"": null,
						""IntraStatTransportMethod"": null,
						""InvoiceAccount"": null,
						""InvoiceAccountCode"": null,
						""InvoiceAccountName"": null,
						""InvoiceAttachmentType"": 1,
						""InvoicingMethod"": 0,
						""IsAccountant"": 0,
						""IsAgency"": 0,
						""IsBank"": false,
						""IsCompetitor"": 0,
						""IsMailing"": 0,
						""IsMember"": false,
						""IsPilot"": false,
						""IsPurchase"": false,
						""IsReseller"": false,
						""IsSales"": false,
						""IsSupplier"": true,
						""Language"": ""NL        "",
						""LanguageDescription"": ""Dutch"",
						""Latitude"": null,
						""LeadSource"": null,
						""LogoFileName"": null,
						""LogoThumbnailUrl"": ""https://start.exactonline.nl//docs/images/placeholder_account_myeol.png"",
						""LogoUrl"": ""https://start.exactonline.nl//docs/images/placeholder_account_myeol.png"",
						""Logo"": null,
						""Longitude"": null,
						""MainContact"": null,
						""Modified"": ""/Date(1382667872203)/"",
						""Modifier"": ""99d87844-e4ef-4ac5-968c-fb863eaced16"",
						""ModifierFullName"": null,
						""Name"": ""Albex Winkelinrichting B.V."",
						""Parent"": null,
						""PaymentConditionPurchase"": null,
						""PaymentConditionPurchaseDescription"": null,
						""PaymentConditionSales"": null,
						""PaymentConditionSalesDescription"": null,
						""Phone"": null,
						""PhoneExtension"": null,
						""Postcode"": ""3995"",
						""PriceList"": null,
						""PurchaseCurrency"": ""EUR"",
						""PurchaseCurrencyDescription"": ""Euro"",
						""PurchaseLeadDays"": 0,
						""PurchaseVATCode"": null,
						""PurchaseVATCodeDescription"": null,
						""Remarks"": null,
						""RecepientOfCommissions"": false,
						""Reseller"": null,
						""ResellerCode"": null,
						""ResellerName"": null,
						""SalesCurrency"": ""EUR"",
						""SalesCurrencyDescription"": ""Euro"",
						""SalesVATCode"": null,
						""SalesVATCodeDescription"": null,
						""SearchCode"": ""ALBEX    "",
						""SecurityLevel"": 10,
						""SeparateInvPerProject"": 0,
						""SeparateInvPerSubscription"": 0,
						""ShippingLeadDays"": 0,
						""ShippingMethod"": null,
						""StartDate"": ""/Date(1267747200000)/"",
						""State"": ""UT "",
						""StateName"": ""Utrecht"",
						""Status"": ""A"",
						""StatusSince"": ""/Date(1382659200000)/"",
						""Type"": ""A"",
						""VATLiability"": null,
						""VATNumber"": null,
						""Website"": null
					},
					{
						""__metadata"": {
							""uri"": ""https://start.exactonline.nl/api/v1/499156/crm/Accounts(guid'0ebc3ef9-752d-4a3e-b54e-10dea7ba54e6')"",
							""type"": ""Exact.Web.Api.Models.Account""
						},
						""Accountant"": null,
						""AccountManager"": null,
						""AccountManagerFullName"": null,
						""AccountManagerHID"": null,
						""ActivitySector"": null,
						""ActivitySubSector"": null,
						""AddressLine1"": ""Postbus 9"",
						""AddressLine2"": null,
						""AddressLine3"": null,
						""BankAccounts"": {
							""__deferred"": {
								""uri"": ""https://start.exactonline.nl/api/v1/499156/crm/Accounts(guid'0ebc3ef9-752d-4a3e-b54e-10dea7ba54e6')/BankAccounts""
							}
						},
						""Blocked"": false,
						""BRIN"": null,
						""BusinessType"": null,
						""CanDropShip"": false,
						""ChamberOfCommerce"": null,
						""City"": ""Gouderak"",
						""Classification"": null,
						""ClassificationDescription"": null,
						""Code"": ""                 3"",
						""CodeAtSupplier"": null,
						""CompanySize"": null,
						""ConsolidationScenario"": 2,
						""ControlledDate"": null,
						""Costcenter"": null,
						""CostcenterDescription"": null,
						""CostPaid"": 0,
						""Country"": ""NL "",
						""Created"": ""/Date(1382667871673)/"",
						""Creator"": ""99d87844-e4ef-4ac5-968c-fb863eaced16"",
						""CreatorFullName"": null,
						""CreditLinePurchase"": 0,
						""CreditLineSales"": 0,
						""Currency"": null,
						""CustomerSince"": null,
						""DiscountPurchase"": 0,
						""DiscountSales"": 0,
						""Division"": 499156,
						""Document"": null,
						""DunsNumber"": null,
						""Email"": null,
						""EndDate"": null,
						""Fax"": null,
						""GLAccountPurchase"": ""5aa8a800-294b-4aae-8e8b-ce3152d667c3"",
						""GLAccountSales"": null,
						""GLAP"": ""686a70b6-0033-4e7b-bb3b-bbcf7f9954a2"",
						""GLAR"": null,
						""ID"": ""0ebc3ef9-752d-4a3e-b54e-10dea7ba54e6"",
						""IntraStatArea"": null,
						""IntraStatDeliveryTerm"": null,
						""IntraStatSystem"": null,
						""IntraStatTransactionA"": null,
						""IntraStatTransactionB"": null,
						""IntraStatTransportMethod"": null,
						""InvoiceAccount"": null,
						""InvoiceAccountCode"": null,
						""InvoiceAccountName"": null,
						""InvoiceAttachmentType"": 1,
						""InvoicingMethod"": 0,
						""IsAccountant"": 0,
						""IsAgency"": 0,
						""IsBank"": false,
						""IsCompetitor"": 0,
						""IsMailing"": 0,
						""IsMember"": false,
						""IsPilot"": false,
						""IsPurchase"": false,
						""IsReseller"": false,
						""IsSales"": false,
						""IsSupplier"": true,
						""Language"": ""NL        "",
						""LanguageDescription"": ""Dutch"",
						""Latitude"": null,
						""LeadSource"": null,
						""LogoFileName"": null,
						""LogoThumbnailUrl"": ""https://start.exactonline.nl//docs/images/placeholder_account_myeol.png"",
						""LogoUrl"": ""https://start.exactonline.nl//docs/images/placeholder_account_myeol.png"",
						""Logo"": null,
						""Longitude"": null,
						""MainContact"": null,
						""Modified"": ""/Date(1382667871673)/"",
						""Modifier"": ""99d87844-e4ef-4ac5-968c-fb863eaced16"",
						""ModifierFullName"": null,
						""Name"": ""Groothandel  sportfietsen"",
						""Parent"": null,
						""PaymentConditionPurchase"": null,
						""PaymentConditionPurchaseDescription"": null,
						""PaymentConditionSales"": null,
						""PaymentConditionSalesDescription"": null,
						""Phone"": null,
						""PhoneExtension"": null,
						""Postcode"": ""2831AA"",
						""PriceList"": null,
						""PurchaseCurrency"": ""EUR"",
						""PurchaseCurrencyDescription"": ""Euro"",
						""PurchaseLeadDays"": 0,
						""PurchaseVATCode"": ""03 "",
						""PurchaseVATCodeDescription"": ""BTW voorheffing"",
						""Remarks"": null,
						""RecepientOfCommissions"": false,
						""Reseller"": null,
						""ResellerCode"": null,
						""ResellerName"": null,
						""SalesCurrency"": ""EUR"",
						""SalesCurrencyDescription"": ""Euro"",
						""SalesVATCode"": null,
						""SalesVATCodeDescription"": null,
						""SearchCode"": ""SPORTFIET"",
						""SecurityLevel"": 10,
						""SeparateInvPerProject"": 0,
						""SeparateInvPerSubscription"": 0,
						""ShippingLeadDays"": 0,
						""ShippingMethod"": null,
						""StartDate"": ""/Date(1267660800000)/"",
						""State"": ""ZH "",
						""StateName"": ""Zuid-Holland"",
						""Status"": ""A"",
						""StatusSince"": ""/Date(1382659200000)/"",
						""Type"": ""A"",
						""VATLiability"": null,
						""VATNumber"": null,
						""Website"": null
					}
				]
			}
		}";

			return correctJsonArray;
		}

        Task<string> IApiConnection.GetAsync(string parameters)
        {
            return Task.FromResult((this as IApiConnection).Get(parameters));
        }

        string IApiConnection.GetEntity(string keyname, string guid, string parameters)
		{
			const string correctJsonObject = @"{
	""d"": {
		""__metadata"": {
			""uri"": ""https://start.exactonline.nl/api/v1/499156/crm/Accounts(guid'71b961de-b9f3-49fe-883d-0f46c7e0e89b')"",
			""type"": ""Exact.Web.Api.Models.Account""
		},
		""Accountant"": null,
		""AccountManager"": null,
		""AccountManagerFullName"": null,
		""AccountManagerHID"": null,
		""ActivitySector"": null,
		""ActivitySubSector"": null,
		""AddressLine1"": ""Voorveste 9"",
		""AddressLine2"": null,
		""AddressLine3"": null,
		""BankAccounts"": {
			""__deferred"": {
				""uri"": ""https://start.exactonline.nl/api/v1/499156/crm/Accounts(guid'71b961de-b9f3-49fe-883d-0f46c7e0e89b')/BankAccounts""
			}
		},
		""Blocked"": false,
		""BRIN"": null,
		""BusinessType"": null,
		""CanDropShip"": false,
		""ChamberOfCommerce"": null,
		""City"": ""Houten"",
		""Classification"": null,
		""ClassificationDescription"": null,
		""Code"": ""                 8"",
		""CodeAtSupplier"": null,
		""CompanySize"": null,
		""ConsolidationScenario"": 2,
		""ControlledDate"": null,
		""Costcenter"": null,
		""CostcenterDescription"": null,
		""CostPaid"": 0,
		""Country"": ""NL "",
		""Created"": ""/Date(1382667872203)/"",
		""Creator"": ""99d87844-e4ef-4ac5-968c-fb863eaced16"",
		""CreatorFullName"": null,
		""CreditLinePurchase"": 0,
		""CreditLineSales"": 0,
		""Currency"": null,
		""CustomerSince"": null,
		""DiscountPurchase"": 0,
		""DiscountSales"": 0,
		""Division"": 499156,
		""Document"": null,
		""DunsNumber"": null,
		""Email"": null,
		""EndDate"": null,
		""Fax"": null,
		""GLAccountPurchase"": ""3d8f75a8-ef72-4ef0-b868-e88d44e8115f"",
		""GLAccountSales"": null,
		""GLAP"": ""686a70b6-0033-4e7b-bb3b-bbcf7f9954a2"",
		""GLAR"": null,
		""ID"": ""71b961de-b9f3-49fe-883d-0f46c7e0e89b"",
		""IntraStatArea"": null,
		""IntraStatDeliveryTerm"": null,
		""IntraStatSystem"": null,
		""IntraStatTransactionA"": null,
		""IntraStatTransactionB"": null,
		""IntraStatTransportMethod"": null,
		""InvoiceAccount"": null,
		""InvoiceAccountCode"": null,
		""InvoiceAccountName"": null,
		""InvoiceAttachmentType"": 1,
		""InvoicingMethod"": 0,
		""IsAccountant"": 0,
		""IsAgency"": 0,
		""IsBank"": false,
		""IsCompetitor"": 0,
		""IsMailing"": 0,
		""IsMember"": false,
		""IsPilot"": false,
		""IsPurchase"": false,
		""IsReseller"": false,
		""IsSales"": false,
		""IsSupplier"": true,
		""Language"": ""NL        "",
		""LanguageDescription"": ""Dutch"",
		""Latitude"": null,
		""LeadSource"": null,
		""LogoFileName"": null,
		""LogoThumbnailUrl"": ""https://start.exactonline.nl//docs/images/placeholder_account_myeol.png"",
		""LogoUrl"": ""https://start.exactonline.nl//docs/images/placeholder_account_myeol.png"",
		""Logo"": null,
		""Longitude"": null,
		""MainContact"": null,
		""Modified"": ""/Date(1382667872203)/"",
		""Modifier"": ""99d87844-e4ef-4ac5-968c-fb863eaced16"",
		""ModifierFullName"": null,
		""Name"": ""Albex Winkelinrichting B.V."",
		""Parent"": null,
		""PaymentConditionPurchase"": null,
		""PaymentConditionPurchaseDescription"": null,
		""PaymentConditionSales"": null,
		""PaymentConditionSalesDescription"": null,
		""Phone"": null,
		""PhoneExtension"": null,
		""Postcode"": ""3995"",
		""PriceList"": null,
		""PurchaseCurrency"": ""EUR"",
		""PurchaseCurrencyDescription"": ""Euro"",
		""PurchaseLeadDays"": 0,
		""PurchaseVATCode"": null,
		""PurchaseVATCodeDescription"": null,
		""Remarks"": null,
		""RecepientOfCommissions"": false,
		""Reseller"": null,
		""ResellerCode"": null,
		""ResellerName"": null,
		""SalesCurrency"": ""EUR"",
		""SalesCurrencyDescription"": ""Euro"",
		""SalesVATCode"": null,
		""SalesVATCodeDescription"": null,
		""SearchCode"": ""ALBEX    "",
		""SecurityLevel"": 10,
		""SeparateInvPerProject"": 0,
		""SeparateInvPerSubscription"": 0,
		""ShippingLeadDays"": 0,
		""ShippingMethod"": null,
		""StartDate"": ""/Date(1267747200000)/"",
		""State"": ""UT "",
		""StateName"": ""Utrecht"",
		""Status"": ""A"",
		""StatusSince"": ""/Date(1382659200000)/"",
		""Type"": ""A"",
		""VATLiability"": null,
		""VATNumber"": null,
		""Website"": null
	}
}";
			return correctJsonObject;
		}

        Task<string> IApiConnection.GetEntityAsync(string keyname, string guid, string parameters)
        {
            return Task.FromResult((this as IApiConnection).GetEntity(keyname, guid, parameters));
        }

        string IApiConnection.Post(string data)
		{
            return "";
		}

        Task<string> IApiConnection.PostAsync(string data)
        {
            return Task.FromResult((this as IApiConnection).Post(data));
        }

        bool IApiConnection.Put(string keyName, string guid, string data)
		{
			return true;
		}

        Task<bool> IApiConnection.PutAsync(string keyName, string guid, string data)
        {
            return Task.FromResult((this as IApiConnection).Put(keyName, guid,data));
        }

        bool IApiConnection.Delete(string keyName, string guid)
		{
			return true;
		}

        Task<bool> IApiConnection.DeleteAsync(string keyName, string guid)
        {
            return Task.FromResult((this as IApiConnection).Delete(keyName, guid));
        }

        #endregion

    }
}
