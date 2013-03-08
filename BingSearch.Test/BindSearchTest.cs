using System;
using NUnit.Framework;
using BingSearch;
using System.Collections.Generic;
using Bing;
using System.Net.Http;
using System.Net;
using System.Configuration;
using BingSearchLib;
 
namespace BingSearch.Test
{
    [TestFixture]
    public class BingSearchTest
    {
        [TestCase]
        public void TestResultCount()
        {
            var resultSet = SearchResults.ResultSet();
            var count = SearchResults.ResultCount(resultSet);
            Console.WriteLine(count);
            Assert.IsTrue(count == 100, "Ahh the required search count (100) got mismatched");

        }
       
        [TestCase]
        public void TestGetSomeResult()
        {
            var resultSet = SearchResults.ResultSet();
            var count = SearchResults.ResultCount(resultSet);

            Assert.IsTrue(count > 1, "No Search results");

        }

        [TestCase]
        public void TestGetResponseIsSuccess()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response;

            string address = System.Configuration.ConfigurationManager.AppSettings["ApiUrl"].ToString();
            response = client.GetAsync(address).Result;

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
           
        }
    }
}
