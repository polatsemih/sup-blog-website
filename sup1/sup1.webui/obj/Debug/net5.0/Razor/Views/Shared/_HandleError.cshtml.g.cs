#pragma checksum "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Shared\_HandleError.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "062bf1dad0cbdc7378a32a755b446f6d4a540a06"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__HandleError), @"mvc.1.0.view", @"/Views/Shared/_HandleError.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"062bf1dad0cbdc7378a32a755b446f6d4a540a06", @"/Views/Shared/_HandleError.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ced40132982272c4a2481f2958947860176807f7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__HandleError : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<section class=\"section-center\">\r\n    <div class=\"container\">\r\n        <div class=\"alert text-center\">\r\n            <p class=\"alert-text text-danger\">");
#nullable restore
#line 4 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Shared\_HandleError.cshtml"
                                         Write(ViewData["ErrorMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
