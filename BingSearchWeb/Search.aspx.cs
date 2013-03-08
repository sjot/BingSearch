using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bing;
using BingSearchLib;

namespace BingSearchWeb
{
    public partial class Search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                dPager.PageSize=10;

                try
                {

                    IEnumerable<WebResult> resultSet = SearchResults.ResultSet().ToList();
                    int count = SearchResults.ResultCount(resultSet);
                    if (count == 0)
                    {
                        ltlSearchCount.Text = "No Search Results";
                    }
                    else
                    {
                        ltl.Text = "Total Search count (Restriction by Bing)";
                        ltlSearchCount.Text = count.ToString();
                    }


                    lstShowresult.DataSource = resultSet;
                    lstShowresult.DataBind();

                }

                catch (System.Net.WebException ex)
                {
                    ltlSearchCount.Text="Bing Search API is not avialable";
                }


                catch (Exception ex)
                {
                    ltlSearchCount.Text="Please try later";
                }
            }
            
           
        }
    }
}