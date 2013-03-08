using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Bing;
using BingSearchLib;
namespace BingSearch
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                IEnumerable<WebResult> resultSet = SearchResults.ResultSet().ToList();

                Console.WriteLine(SearchResults.ResultCount(resultSet) +"  (Restriction by Bing)");
                Console.WriteLine();

                foreach (var result in resultSet)
                {
                    Console.WriteLine(result.Url);
                }

                if (SearchResults.ResultCount(resultSet) == 0)
                {
                    Console.WriteLine("No Search Results");
                }
                Console.ReadLine();
            }

            catch (System.Net.WebException ex)
            {
                Console.WriteLine("Bing Search API is not avialable");
            }


            catch (Exception ex)
            {
                Console.WriteLine("Please try later");
            }
        }

    }

}
