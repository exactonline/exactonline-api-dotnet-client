namespace ExactOnline.Client.Sdk.PerformanceTests
{
    using System;
    using System.Collections.Generic;
    using ExactOnline.Client.Models.CRM;
    using ExactOnline.Client.Models.SalesInvoice;
    using ExactOnline.Client.Sdk.Helpers;
    using ExactOnline.Client.Sdk.PerformanceTests.Helpers;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class JsonToObjectTest
    {
        private const string LinkedEntities = @"{
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
			},
			{
				""__metadata"": {
					""uri"": ""https://start.exactonline.nl/api/v1/499156/salesinvoice/SalesInvoices(guid'b1f67a3c-c377-41ca-809d-763d3e1e83c2')"",
					""type"": ""Exact.Web.Api.Models.SalesInvoice""
				},
				""AmountFC"": 6352.5,
				""AmountDC"": 6352.5,
				""Created"": ""/Date(1382667906407)/"",
				""Creator"": ""99d87844-e4ef-4ac5-968c-fb863eaced16"",
				""CreatorFullName"": null,
				""Currency"": ""EUR"",
				""Description"": ""Ontwikkelen nieuw concept"",
				""Division"": 499156,
				""Document"": null,
				""DocumentNumber"": null,
				""DocumentSubject"": null,
				""DueDate"": ""/Date(1351209600000)/"",
				""InvoiceDate"": ""/Date(1351209600000)/"",
				""InvoiceID"": ""b1f67a3c-c377-41ca-809d-763d3e1e83c2"",
				""InvoiceTo"": ""3734121e-1544-4b77-9ae2-7203e9bd6046"",
				""InvoiceToContactPerson"": ""48d2d6d0-1fc8-4eb9-be31-87ca27931fca"",
				""InvoiceToContactPersonFullName"": ""Piet Mulder"",
				""InvoiceToName"": ""Test ABC Producten & Diensten B.V."",
				""InvoiceNumber"": null,
				""Journal"": ""50"",
				""JournalDescription"": ""Verkoopboek"",
				""Modified"": ""/Date(1382667906407)/"",
				""Modifier"": ""99d87844-e4ef-4ac5-968c-fb863eaced16"",
				""ModifierFullName"": null,
				""OrderDate"": ""/Date(1351209600000)/"",
				""OrderedBy"": ""3734121e-1544-4b77-9ae2-7203e9bd6046"",
				""OrderedByContactPerson"": ""e893e6e6-6eeb-4420-a5b2-378618ba9f27"",
				""OrderedByContactPersonFullName"": ""Karin Jansen"",
				""OrderedByName"": ""Test ABC Producten & Diensten B.V."",
				""OrderNumber"": 2,
				""PaymentCondition"": ""21"",
				""PaymentConditionDescription"": ""21 dagen"",
				""Remarks"": null,
				""Salesperson"": null,
				""SalespersonFullName"": null,
				""Status"": 20,
				""StatusDescription"": ""Open"",
				""Type"": 8020,
				""TypeDescription"": ""Normal"",
				""VATAmountFC"": 1102.5,
				""VATAmountDC"": 1102.5,
				""YourRef"": null,
				""SalesInvoiceLines"": {
					""results"": [
						{
							""__metadata"": {
								""uri"": ""https://start.exactonline.nl/api/v1/499156/salesinvoice/SalesInvoiceLines(guid'983eb99f-3ef5-4c58-80fb-5302038e94be')"",
								""type"": ""Exact.Web.Api.Models.SalesInvoiceLine""
							},
							""AmountFC"": 5250,
							""AmountDC"": 5250,
							""CostCenter"": null,
							""CostCenterDescription"": null,
							""CostUnit"": null,
							""CostUnitDescription"": null,
							""Description"": ""Consultancy per uur"",
							""Discount"": 0,
							""Division"": 499156,
							""Employee"": null,
							""EmployeeFullName"": null,
							""EndTime"": null,
							""GLAccount"": ""4eae751d-fc91-4c99-b1e6-646fe3401a12"",
							""GLAccountDescription"": ""This is a Test"",
							""ID"": ""983eb99f-3ef5-4c58-80fb-5302038e94be"",
							""InvoiceID"": ""b1f67a3c-c377-41ca-809d-763d3e1e83c2"",
							""Item"": ""3970056b-1efd-4b67-a0f8-9684411b6e42"",
							""ItemDescription"": ""Consultancy per uur"",
							""LineNumber"": 1,
							""NetPrice"": 75,
							""Notes"": null,
							""Pricelist"": null,
							""PricelistDescription"": null,
							""Project"": null,
							""ProjectDescription"": null,
							""Quantity"": 70,
							""StartTime"": null,
							""Subscription"": null,
							""SubscriptionDescription"": null,
							""UnitCode"": ""hour"",
							""UnitDescription"": ""Hour"",
							""UnitPrice"": 75,
							""VATAmountFC"": 1102.5,
							""VATAmountDC"": 1102.5,
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

        private const string JsonArray = @"{
	""d"": {
		""results"": [
			{
				""__metadata"": {
					""uri"": ""https://start.exactonline.nl/api/v1/499156/crm/Accounts(guid'4792a639-3840-4d8a-b086-017acd738a52')"",
					""type"": ""Exact.Web.Api.Models.Account""
				},
				""Accountant"": null,
				""AccountManager"": null,
				""AccountManagerFullName"": null,
				""AccountManagerHID"": null,
				""ActivitySector"": null,
				""ActivitySubSector"": null,
				""AddressLine1"": null,
				""AddressLine2"": null,
				""AddressLine3"": null,
				""BankAccounts"": {
					""results"": []
				},
				""Blocked"": false,
				""BRIN"": null,
				""BusinessType"": null,
				""CanDropShip"": false,
				""ChamberOfCommerce"": null,
				""City"": null,
				""Classification"": null,
				""ClassificationDescription"": null,
				""Code"": ""              1237"",
				""CodeAtSupplier"": null,
				""CompanySize"": null,
				""ConsolidationScenario"": 2,
				""ControlledDate"": null,
				""Costcenter"": null,
				""CostcenterDescription"": null,
				""CostPaid"": 0,
				""Country"": ""NL "",
				""Created"": ""/Date(1390409299137)/"",
				""Creator"": ""10091f1b-4661-4854-9fd0-cf5f5f668cbd"",
				""CreatorFullName"": ""Edward Jackson"",
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
				""GLAccountPurchase"": null,
				""GLAccountSales"": null,
				""GLAP"": null,
				""GLAR"": null,
				""ID"": ""4792a639-3840-4d8a-b086-017acd738a52"",
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
				""IsSupplier"": false,
				""Language"": null,
				""LanguageDescription"": null,
				""Latitude"": null,
				""LeadSource"": null,
				""LogoFileName"": null,
				""LogoThumbnailUrl"": ""https://start.exactonline.nl//docs/images/placeholder_account_myeol.png"",
				""LogoUrl"": ""https://start.exactonline.nl//docs/images/placeholder_account_myeol.png"",
				""Logo"": null,
				""Longitude"": null,
				""MainContact"": null,
				""Modified"": ""/Date(1390409299137)/"",
				""Modifier"": ""10091f1b-4661-4854-9fd0-cf5f5f668cbd"",
				""ModifierFullName"": ""Edward Jackson"",
				""Name"": ""Account for deleting test"",
				""Parent"": null,
				""PaymentConditionPurchase"": null,
				""PaymentConditionPurchaseDescription"": null,
				""PaymentConditionSales"": null,
				""PaymentConditionSalesDescription"": null,
				""Phone"": null,
				""PhoneExtension"": null,
				""Postcode"": null,
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
				""SearchCode"": null,
				""SecurityLevel"": 10,
				""SeparateInvPerProject"": 0,
				""SeparateInvPerSubscription"": 0,
				""ShippingLeadDays"": 0,
				""ShippingMethod"": null,
				""StartDate"": ""/Date(1390348800000)/"",
				""State"": null,
				""StateName"": null,
				""Status"": ""A"",
				""StatusSince"": ""/Date(1390348800000)/"",
				""Type"": ""A"",
				""VATLiability"": null,
				""VATNumber"": null,
				""Website"": null
			},
			{
				""__metadata"": {
					""uri"": ""https://start.exactonline.nl/api/v1/499156/crm/Accounts(guid'1bd85628-1c7f-4251-aa19-ffcacc1fa8be')"",
					""type"": ""Exact.Web.Api.Models.Account""
				},
				""Accountant"": null,
				""AccountManager"": null,
				""AccountManagerFullName"": null,
				""AccountManagerHID"": null,
				""ActivitySector"": null,
				""ActivitySubSector"": null,
				""AddressLine1"": null,
				""AddressLine2"": null,
				""AddressLine3"": null,
				""Blocked"": false,
				""BRIN"": null,
				""BusinessType"": null,
				""CanDropShip"": false,
				""ChamberOfCommerce"": null,
				""City"": ""Apeldoorn"",
				""Classification"": null,
				""ClassificationDescription"": null,
				""Code"": ""                 6"",
				""CodeAtSupplier"": null,
				""CompanySize"": null,
				""ConsolidationScenario"": 2,
				""ControlledDate"": null,
				""Costcenter"": null,
				""CostcenterDescription"": null,
				""CostPaid"": 0,
				""Country"": ""NL "",
				""Created"": ""/Date(1382667868827)/"",
				""Creator"": ""99d87844-e4ef-4ac5-968c-fb863eaced16"",
				""CreatorFullName"": null,
				""CreditLinePurchase"": 0,
				""CreditLineSales"": 0,
				""Currency"": null,
				""CustomerSince"": ""/Date(1382659200000)/"",
				""DiscountPurchase"": 0,
				""DiscountSales"": 0,
				""Division"": 499156,
				""Document"": null,
				""DunsNumber"": null,
				""Email"": null,
				""EndDate"": null,
				""Fax"": null,
				""GLAccountPurchase"": null,
				""GLAccountSales"": null,
				""GLAP"": ""686a70b6-0033-4e7b-bb3b-bbcf7f9954a2"",
				""GLAR"": ""1fc30060-4de3-492b-8a7b-012f6b507284"",
				""ID"": ""1bd85628-1c7f-4251-aa19-ffcacc1fa8be"",
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
				""IsPurchase"": true,
				""IsReseller"": false,
				""IsSales"": true,
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
				""Modified"": ""/Date(1387812609447)/"",
				""Modifier"": ""10091f1b-4661-4854-9fd0-cf5f5f668cbd"",
				""ModifierFullName"": ""Edward Jackson"",
				""Name"": ""Test Belastingdienst"",
				""Parent"": null,
				""PaymentConditionPurchase"": null,
				""PaymentConditionPurchaseDescription"": null,
				""PaymentConditionSales"": null,
				""PaymentConditionSalesDescription"": null,
				""Phone"": null,
				""PhoneExtension"": null,
				""Postcode"": null,
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
				""SearchCode"": ""BELASTING"",
				""SecurityLevel"": 10,
				""SeparateInvPerProject"": 0,
				""SeparateInvPerSubscription"": 0,
				""ShippingLeadDays"": 0,
				""ShippingMethod"": null,
				""StartDate"": ""/Date(1351123200000)/"",
				""State"": null,
				""StateName"": null,
				""Status"": ""C"",
				""StatusSince"": ""/Date(1382659200000)/"",
				""Type"": ""A"",
				""VATLiability"": null,
				""VATNumber"": null,
				""Website"": ""www.belastingdienst.nl""
			}
		]
	}
}";

        [TestCategory("Performance Test")]
        [TestMethod]
        public void TestPerformance_JsonArray_ToObject()
        {
            var originalprocesstime = TimeSpan.FromSeconds(1.3);
            var currentprocesstime = TestTimer.Time(ParseObjectList);
            Assert.IsTrue(currentprocesstime < originalprocesstime);
        }

        [TestCategory("Performance Test")]
        [TestMethod]
        public void TestPerformance_JsonArray_LinkedEntities_ToObject()
        {
            var originalprocesstime = TimeSpan.FromSeconds(1.16);
            var currentprocesstime = TestTimer.Time(ParseObjectList_LinkedEntities);
            Assert.IsTrue(currentprocesstime < originalprocesstime);
        }

        private void ParseObjectList()
        {
            var converter = new EntityConverter();

            for (var i = 0; i < 100; i++)
            {
                var json = ApiResponseCleaner.GetJsonArray(JsonArray);
                var accounts = converter.ConvertJsonArrayToObjectList<Account>(json);
                if (accounts.Count != 2)
                {
                    throw new Exception("The count of the list isn't equal to the actual list");
                }
            }
        }

        [TestCategory("Performance Test")]
        [TestMethod]
        public void ParseObjectList_LinkedEntities()
        {
            var converter = new EntityConverter();

            for (var i = 0; i < 100; i++)
            {
                var json = ApiResponseCleaner.GetJsonArray(LinkedEntities);
                var invoices = converter.ConvertJsonArrayToObjectList<SalesInvoice>(json);

                foreach (var invoice in invoices)
                {
                    var sil = (List<SalesInvoiceLine>)invoice.SalesInvoiceLines;
                    Assert.IsTrue(sil.Count > 0);
                }
            }
        }
    }
}
