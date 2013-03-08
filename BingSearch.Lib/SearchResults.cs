using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Bing;

namespace BingSearchLib
{
   public class SearchResults
    {


        public static IEnumerable<WebResult> ResultSet()
        {
            string bingAccountKey = ConfigurationManager.AppSettings["BingKey"].ToString();
            string address = ConfigurationManager.AppSettings["ApiUrl"].ToString();

            var bing = new BingSearchContainer(
                new Uri(address)) { Credentials = new NetworkCredential(bingAccountKey, bingAccountKey) };

            var query = bing.Web("xbox live", null, null, null, null, null, null, null);
            query = query.AddQueryOption("$top",100);
            var results = query.Execute();
            return results;
        }


       public static int ResultCount(IEnumerable<WebResult> resultSet)
       {
           int result = 0;
           using (IEnumerator<WebResult> enumerator = resultSet.GetEnumerator())
           {
               while (enumerator.MoveNext())
                   result++;
           }
           return result;

       }
    }
}
