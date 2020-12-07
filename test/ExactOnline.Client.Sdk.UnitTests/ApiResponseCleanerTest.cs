namespace ExactOnline.Client.Sdk.UnitTests
{
    using System.Collections.Generic;
    using ExactOnline.Client.Sdk.Exceptions;
    using ExactOnline.Client.Sdk.Helpers;
    using ExactOnline.Client.Sdk.UnitTests.Tools;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ApiResponseCleanerTest
    {
        public TestContext TestContext { get; set; }

        [TestCategory("Unit Test")]
        [TestMethod]
        public void ApiResponseCleaner_FetchJsonArray_WithCorrectValues_Succeeds()
        {
            var jsonarray =
                ApiResponseCleaner.GetJsonArray(JsonFileReader.GetJsonFromFile("ApiResponse_Json_Array.txt"));
        }

        [TestCategory("Unit Test")]
        [TestMethod]
        [ExpectedException(typeof(IncorrectJsonException))]
        public void ApiResponseCleaner_FetchJsonArray_WithOutDKeyValuePair_Fails()
        {
            ApiResponseCleaner.GetJsonArray(JsonFileReader.GetJsonFromFile("ApiResponse_Json_Array_WithoutDTag.txt"));
        }

        [TestCategory("Unit Test")]
        [TestMethod]
        [ExpectedException(typeof(IncorrectJsonException))]
        public void ApiResponseCleaner_FetchJsonArray_WithOutResultsKeyValuePair_Fails()
        {
            ApiResponseCleaner.GetJsonArray(
                JsonFileReader.GetJsonFromFile("ApiResponse_Json_Array_WithoutResultsTag.txt"));
        }

        [TestCategory("Unit Test")]
        [TestMethod]
        public void ApiResponseCleanerFetchJsonArrayWithEmptyLinkedEntitiesSucceeds()
        {
            const string expected = @"[{""BankAccounts"":[]}]";
            var clean = ApiResponseCleaner.GetJsonArray(
                JsonFileReader.GetJsonFromFile("ApiResponse_Json_Array_WithEmptyLinkedEntities.txt"));
            Assert.AreEqual(expected, clean);
        }

        [TestCategory("Unit Test")]
        [TestMethod]
        public void ApiResponseCleaner_FetchJsonObject_WithCorrectValues_Succeeds()
        {
            ApiResponseCleaner.GetJsonObject(JsonFileReader.GetJsonFromFile("ApiResponse_Json_Object.txt"));
        }

        [TestCategory("Unit Test")]
        [TestMethod]
        public void ApiResponseCleaner_FetchJsonObject_WithEscapeCharacter_Succeeds()
        {
            const string sampleJsonResponse = @"{ ""d"": { ""Remarks"": ""\\escape test"" }}";

            var cleanedJson = ApiResponseCleaner.GetJsonObject(sampleJsonResponse);

            const string expectedCleanedJson = @"{""Remarks"":""\\escape test""}";
            Assert.AreEqual(expectedCleanedJson, cleanedJson);
        }

        [TestCategory("Unit Test")]
        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void ApiResponseCleaner_FetchJsonObject_WithoutDKeyValuePair_Fails()
        {
            ApiResponseCleaner.GetJsonObject(JsonFileReader.GetJsonFromFile("ApiResponse_Json_Object_WithoutD.txt"));
        }
    }
}
