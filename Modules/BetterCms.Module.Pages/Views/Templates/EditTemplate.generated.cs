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

namespace BetterCms.Module.Pages.Views.Templates
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
    
    #line 1 "..\..\Views\Templates\EditTemplate.cshtml"
    using BetterCms.Module.Pages;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Templates\EditTemplate.cshtml"
    using BetterCms.Module.Pages.Content.Resources;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Templates\EditTemplate.cshtml"
    using BetterCms.Module.Pages.Controllers;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\Templates\EditTemplate.cshtml"
    using BetterCms.Module.Pages.ViewModels.Templates;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Views\Templates\EditTemplate.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Views\Templates\EditTemplate.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Templates/EditTemplate.cshtml")]
    public partial class EditTemplate : System.Web.Mvc.WebViewPage<TemplateEditViewModel>
    {
        public EditTemplate()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 9 "..\..\Views\Templates\EditTemplate.cshtml"
 if (Model == null)
{
    return;
}

            
            #line default
            #line hidden
WriteLiteral("<div");

WriteLiteral(" class=\"bcms-tab-header\"");

WriteLiteral(">\r\n    <a");

WriteLiteral(" class=\"bcms-tab bcms-tab-active\"");

WriteLiteral(" data-name=\"#bcms-tab-1\"");

WriteLiteral(">");

            
            #line 14 "..\..\Views\Templates\EditTemplate.cshtml"
                                                           Write(PagesGlobalization.EditTemplate_BasicPropertiesTab_Title);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n    <a");

WriteLiteral(" class=\"bcms-tab\"");

WriteLiteral(" data-name=\"#bcms-tab-2\"");

WriteLiteral(">");

            
            #line 15 "..\..\Views\Templates\EditTemplate.cshtml"
                                           Write(PagesGlobalization.EditTemplate_RegionsTab_Title);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n    <a");

WriteLiteral(" class=\"bcms-tab\"");

WriteLiteral(" data-name=\"#bcms-tab-3\"");

WriteLiteral(">");

            
            #line 16 "..\..\Views\Templates\EditTemplate.cshtml"
                                           Write(PagesGlobalization.EditTemplate_OptionsTab_Title);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n</div>\r\n\r\n<div");

WriteLiteral(" class=\"bcms-scroll-window\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 20 "..\..\Views\Templates\EditTemplate.cshtml"
Write(Html.TabbedContentMessagesBox("bcms-edit-template-messages"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 21 "..\..\Views\Templates\EditTemplate.cshtml"
    
            
            #line default
            #line hidden
            
            #line 21 "..\..\Views\Templates\EditTemplate.cshtml"
     using (Html.BeginForm<TemplatesController>(c => c.RegisterTemplate((TemplateEditViewModel)null), FormMethod.Post, new { @id = "bcms-template-form", @class = "bcms-ajax-form" }))
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" id=\"bcms-tab-1\"");

WriteLiteral(" class=\"bcms-tab-single\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"bcms-padded-content\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 26 "..\..\Views\Templates\EditTemplate.cshtml"
               Write(Html.Tooltip(PagesGlobalization.Template_Title_Tooltip_Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 27 "..\..\Views\Templates\EditTemplate.cshtml"
                                                Write(PagesGlobalization.Template_Title_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    <div");

WriteLiteral(" class=\"bcms-input-box\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 29 "..\..\Views\Templates\EditTemplate.cshtml"
                   Write(Html.TextBoxFor(model => model.Name, new { @class = "bcms-editor-field-box" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                        ");

            
            #line 30 "..\..\Views\Templates\EditTemplate.cshtml"
                   Write(Html.BcmsValidationMessageFor(m => m.Name));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 35 "..\..\Views\Templates\EditTemplate.cshtml"
               Write(Html.Tooltip(PagesGlobalization.Template_Url_Tooltip_Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 36 "..\..\Views\Templates\EditTemplate.cshtml"
                                                Write(PagesGlobalization.Template_Url_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    <div");

WriteLiteral(" class=\"bcms-input-box\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 38 "..\..\Views\Templates\EditTemplate.cshtml"
                   Write(Html.TextBoxFor(model => model.Url, new { @class = "bcms-editor-field-box" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                        ");

            
            #line 39 "..\..\Views\Templates\EditTemplate.cshtml"
                   Write(Html.BcmsValidationMessageFor(m => m.Url));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 44 "..\..\Views\Templates\EditTemplate.cshtml"
               Write(Html.Tooltip(PagesGlobalization.TemplatePreviewImageUrl_Tooltip_Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 45 "..\..\Views\Templates\EditTemplate.cshtml"
                                                Write(PagesGlobalization.TemplatePreviewImageUrl_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    <div");

WriteLiteral(" class=\"bcms-input-box\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 47 "..\..\Views\Templates\EditTemplate.cshtml"
                   Write(Html.TextBoxFor(model => model.PreviewImageUrl, new { @class = "bcms-editor-field-box" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                        ");

            
            #line 48 "..\..\Views\Templates\EditTemplate.cshtml"
                   Write(Html.BcmsValidationMessageFor(m => m.PreviewImageUrl));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 53 "..\..\Views\Templates\EditTemplate.cshtml"
               Write(Html.Tooltip(PagesGlobalization.TemplateImagePreview_Tooltip_Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 54 "..\..\Views\Templates\EditTemplate.cshtml"
                                                Write(PagesGlobalization.TemplatePreviewImage_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\r\n                    <div");

WriteLiteral(" class=\"bcms-preview-module-image\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral(">\r\n                            <img");

WriteLiteral(" id=\"bcms-template-preview-image\"");

WriteAttribute("src", Tuple.Create(" src=\"", 3125), Tuple.Create("\"", 3153)
            
            #line 58 "..\..\Views\Templates\EditTemplate.cshtml"
, Tuple.Create(Tuple.Create("", 3131), Tuple.Create<System.Object, System.Int32>(Model.PreviewImageUrl
            
            #line default
            #line hidden
, 3131), false)
);

WriteLiteral(" alt=\"\"");

WriteLiteral(" />\r\n                        </div>\r\n                    </div>\r\n\r\n              " +
"  </div>\r\n            </div>\r\n        </div>\r\n");

            
            #line 65 "..\..\Views\Templates\EditTemplate.cshtml"
              

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" id=\"bcms-tab-2\"");

WriteLiteral(" class=\"bcms-tab-single\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 67 "..\..\Views\Templates\EditTemplate.cshtml"
       Write(Html.Partial("Partial/EditTemplateRegions"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n");

            
            #line 69 "..\..\Views\Templates\EditTemplate.cshtml"
        

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" id=\"bcms-tab-3\"");

WriteLiteral(" class=\"bcms-tab-single\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 71 "..\..\Views\Templates\EditTemplate.cshtml"
       Write(Html.Partial(PagesConstants.OptionsGridTemplate));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n");

            
            #line 73 "..\..\Views\Templates\EditTemplate.cshtml"
            
        
            
            #line default
            #line hidden
            
            #line 74 "..\..\Views\Templates\EditTemplate.cshtml"
   Write(Html.HiddenFor(model => model.Id));

            
            #line default
            #line hidden
            
            #line 74 "..\..\Views\Templates\EditTemplate.cshtml"
                                          
        
            
            #line default
            #line hidden
            
            #line 75 "..\..\Views\Templates\EditTemplate.cshtml"
   Write(Html.HiddenFor(model => model.Version));

            
            #line default
            #line hidden
            
            #line 75 "..\..\Views\Templates\EditTemplate.cshtml"
                                               
        
            
            #line default
            #line hidden
            
            #line 76 "..\..\Views\Templates\EditTemplate.cshtml"
   Write(Html.HiddenSubmit());

            
            #line default
            #line hidden
            
            #line 76 "..\..\Views\Templates\EditTemplate.cshtml"
                            
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

        }
    }
}
#pragma warning restore 1591
