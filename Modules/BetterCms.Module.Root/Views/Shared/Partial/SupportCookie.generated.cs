﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BetterCms.Module.Root.Views.Shared.Partial
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
    
    #line 1 "..\..\Views\Shared\Partial\SupportCookie.cshtml"
    using BetterCms.Module.Root.Content.Resources;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/Partial/SupportCookie.cshtml")]
    public partial class SupportCookie : System.Web.Mvc.WebViewPage<dynamic>
    {
        public SupportCookie()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"bcms-msg-top-page\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"bcms-msg-top-holder\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"bcms-msg-top-block\"");

WriteLiteral(">");

            
            #line 5 "..\..\Views\Shared\Partial\SupportCookie.cshtml"
                                   Write(Html.Raw(RootGlobalization.CookieSupport_MustBeEnabled_Message_FirstLine));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n        <div");

WriteLiteral(" class=\"bcms-msg-top-block\"");

WriteLiteral(">");

            
            #line 6 "..\..\Views\Shared\Partial\SupportCookie.cshtml"
                                   Write(Html.Raw(RootGlobalization.CookieSupport_MustBeEnabled_Message_SecondLine));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n        <div");

WriteLiteral(" class=\"bcms-msg-cookies\"");

WriteLiteral("></div>\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
