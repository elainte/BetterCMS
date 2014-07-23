﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BetterCms.Module.Search.Views.Search
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 1 "..\..\Views\Search\SearchResultsWidget.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Search\SearchResultsWidget.cshtml"
    using BetterCms.Module.Search;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Search\SearchResultsWidget.cshtml"
    using BetterCms.Module.Search.Content.Resources;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Search/SearchResultsWidget.cshtml")]
    public partial class SearchResultsWidget : System.Web.Mvc.WebViewPage<BetterCms.Module.Search.ViewModels.SearchResultsViewModel>
    {
        public SearchResultsWidget()
        {
        }
        public override void Execute()
        {
            
            #line 6 "..\..\Views\Search\SearchResultsWidget.cshtml"
 if (Model != null)
{
    if (!string.IsNullOrWhiteSpace(Model.ErrorMessage))
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"bcms-search-results-error\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 11 "..\..\Views\Search\SearchResultsWidget.cshtml"
       Write(Model.ErrorMessage);

            
            #line default
            #line hidden
WriteLiteral(" \r\n        </div>\r\n");

            
            #line 13 "..\..\Views\Search\SearchResultsWidget.cshtml"
    } 
    else if (Model.Results != null && !string.IsNullOrWhiteSpace(Model.Results.Query) && Model.Results.Items != null)
    {
        var showTotalResults = Model.WidgetViewModel.GetOptionValue<bool>(SearchModuleConstants.WidgetOptionNames.ShowTotalResults);

        if (showTotalResults)
        {
            var message = Model.WidgetViewModel.GetOptionValue<string>(SearchModuleConstants.WidgetOptionNames.TotalCountMessage);
            if (string.IsNullOrWhiteSpace(message))
            {
                message = SearchGlobalization.SearchResults_TotalCount_Message;
            }
            message = string.Format(message, 
                Model.Results.Items.Count, 
                Model.Results.TotalResults, 
                string.Format("<span class=\"bcms-total-search-results-query\">{0}</span>", HttpUtility.HtmlEncode(Model.Results.Query)));
            

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"bcms-total-search-results\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 31 "..\..\Views\Search\SearchResultsWidget.cshtml"
           Write(Html.Raw(message));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n");

            
            #line 33 "..\..\Views\Search\SearchResultsWidget.cshtml"
        }

        foreach (var item in Model.Results.Items)
        {
            var cssClass = !item.IsDenied ? "bcms-search-result" : "bcms-search-result bcms-denied-search-result";


            
            #line default
            #line hidden
WriteLiteral("            <article");

WriteAttribute("class", Tuple.Create(" class=\"", 1601), Tuple.Create("\"", 1618)
            
            #line 39 "..\..\Views\Search\SearchResultsWidget.cshtml"
, Tuple.Create(Tuple.Create("", 1609), Tuple.Create<System.Object, System.Int32>(cssClass
            
            #line default
            #line hidden
, 1609), false)
);

WriteLiteral(">\r\n                <h3>");

            
            #line 40 "..\..\Views\Search\SearchResultsWidget.cshtml"
               Write(item.Title);

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n");

            
            #line 41 "..\..\Views\Search\SearchResultsWidget.cshtml"
                
            
            #line default
            #line hidden
            
            #line 41 "..\..\Views\Search\SearchResultsWidget.cshtml"
                 if (!item.IsDenied)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1739), Tuple.Create("\"", 1765)
            
            #line 43 "..\..\Views\Search\SearchResultsWidget.cshtml"
, Tuple.Create(Tuple.Create("", 1746), Tuple.Create<System.Object, System.Int32>(item.Link ?? "#"
            
            #line default
            #line hidden
, 1746), false)
);

WriteLiteral(">");

            
            #line 43 "..\..\Views\Search\SearchResultsWidget.cshtml"
                                             Write(item.FormattedUrl);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 44 "..\..\Views\Search\SearchResultsWidget.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                <p>");

            
            #line 45 "..\..\Views\Search\SearchResultsWidget.cshtml"
              Write(item.Snippet);

            
            #line default
            #line hidden
WriteLiteral("</p>            \r\n            </article>\r\n");

            
            #line 47 "..\..\Views\Search\SearchResultsWidget.cshtml"
        }
    }
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591