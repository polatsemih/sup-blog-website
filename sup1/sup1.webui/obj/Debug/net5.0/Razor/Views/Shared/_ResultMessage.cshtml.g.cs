#pragma checksum "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Shared\_ResultMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "847fcd99b95445a5ab3be06864cd675e40fe1959"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ResultMessage), @"mvc.1.0.view", @"/Views/Shared/_ResultMessage.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\_ViewImports.cshtml"
using sup1.webui.Models.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\_ViewImports.cshtml"
using sup1.webui.Models.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\_ViewImports.cshtml"
using sup1.webui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\_ViewImports.cshtml"
using sup1.webui.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\_ViewImports.cshtml"
using sup1.webui.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\_ViewImports.cshtml"
using sup1.entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"847fcd99b95445a5ab3be06864cd675e40fe1959", @"/Views/Shared/_ResultMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ced40132982272c4a2481f2958947860176807f7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ResultMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AlertMessage>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div");
            BeginWriteAttribute("class", " class=\"", 27, "\"", 78, 3);
            WriteAttributeValue("", 35, "alert-container", 35, 15, true);
            WriteAttributeValue(" ", 50, "background-", 51, 12, true);
#nullable restore
#line 3 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Shared\_ResultMessage.cshtml"
WriteAttributeValue("", 62, Model.AlertType, 62, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"row-alert\">\r\n        <div class=\"col-1\">\r\n            <i class=\"far fa-times-circle alert-close-icon\"></i>\r\n        </div>\r\n        <div class=\"col-11\">\r\n            <h4 class=\"alert-title\">");
#nullable restore
#line 9 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Shared\_ResultMessage.cshtml"
                               Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            <p class=\"alert-text alert-text-light\">");
#nullable restore
#line 10 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Shared\_ResultMessage.cshtml"
                                              Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AlertMessage> Html { get; private set; }
    }
}
#pragma warning restore 1591