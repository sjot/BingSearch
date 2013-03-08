<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="BingSearchWeb.Search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

   
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
          

            <hr />
            <asp:Literal runat="server" ID="ltl" />
            <asp:Literal runat="server" ID="ltlSearchCount" />
            <asp:ListView runat="server" ID="lstShowresult">

                <LayoutTemplate>
                    <ol class="searchResults">
                        <asp:PlaceHolder
                            runat="server"
                            ID="itemPlaceholder" />
                    </ol>
                </LayoutTemplate>
                <ItemTemplate>

                    <li>
                        <ul style="list-style-type : none;" >
                            <li>
                                <asp:HyperLink ID="hypUrl" runat="server" Text='<%# Eval("Title") %>' NavigateUrl='<%# Eval("Title") %>'></asp:HyperLink></li>
                            <li>
                                <asp:Literal ID="hypTitle" runat="server" Text='<%# Eval("Description") %>' /></li>


                        </ul>
                    </li>
                </ItemTemplate>
            </asp:ListView>

          

            <div id="pager">
    <asp:DataPager ID="dPager" runat="server" PagedControlID="lstShowresult">
        <Fields>
            <asp:NextPreviousPagerField ShowNextPageButton="False" ButtonCssClass="previousNextLink" />
            <asp:NumericPagerField ButtonCount="10" ButtonType="Link" NumericButtonCssClass="numericLink" />
            <asp:NextPreviousPagerField ShowPreviousPageButton="False" ButtonCssClass="previousNextLink" />
        </Fields>
    </asp:DataPager>
</div>

        </div>
    </form>
</body>
</html>
