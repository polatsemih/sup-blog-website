#pragma checksum "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\ContactListAdmin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1057325cc798868ebd81582de43388a85b56a1a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ContactListAdmin), @"mvc.1.0.view", @"/Views/Admin/ContactListAdmin.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1057325cc798868ebd81582de43388a85b56a1a0", @"/Views/Admin/ContactListAdmin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ced40132982272c4a2481f2958947860176807f7", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ContactListAdmin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContactAdmin>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ResultMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ContactDetailAdmin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button button-small button-theme mb-10 mr-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("User Detail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ContactDelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            DefineSection("Css", async() => {
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""/folder/css/form.css"">
    <link rel=""stylesheet"" href=""/folder/css/confirm.css"">
    <link rel=""stylesheet"" href=""/folder/css/result_message.css"">
    <link rel=""stylesheet"" href=""/folder/css/admin_panel.css"">
    <link rel=""stylesheet"" href=""/folder/css/table.css"">
");
            }
            );
            WriteLiteral("\r\n");
#nullable restore
#line 12 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\ContactListAdmin.cshtml"
 foreach (var item in Model.ContactMessages)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div");
            BeginWriteAttribute("class", " class=\"", 408, "\"", 469, 3);
            WriteAttributeValue("", 416, "confirm-container", 416, 17, true);
            WriteAttributeValue(" ", 433, "confirm-container-", 434, 19, true);
#nullable restore
#line 14 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\ContactListAdmin.cshtml"
WriteAttributeValue("", 452, item.MessageId, 452, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"confirm-content\">\r\n            <p class=\"confirm-text\">Are you sure you want to delete \"");
#nullable restore
#line 16 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\ContactListAdmin.cshtml"
                                                                 Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"?</p>\r\n            <button class=\"button button-medium button-danger mr-10\"");
            BeginWriteAttribute("id", " id=\"", 672, "\"", 708, 2);
            WriteAttributeValue("", 677, "button-cancel-", 677, 14, true);
#nullable restore
#line 17 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\ContactListAdmin.cshtml"
WriteAttributeValue("", 691, item.MessageId, 691, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Cancel</button>\r\n            <button class=\"button button-medium button-success\"");
            BeginWriteAttribute("id", " id=\"", 790, "\"", 827, 2);
            WriteAttributeValue("", 795, "button-confirm-", 795, 15, true);
#nullable restore
#line 18 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\ContactListAdmin.cshtml"
WriteAttributeValue("", 810, item.MessageId, 810, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Yes</button>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 21 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\ContactListAdmin.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 23 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\ContactListAdmin.cshtml"
 if (TempData["message"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1057325cc798868ebd81582de43388a85b56a1a09968", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 25 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\ContactListAdmin.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = (TempData.Get<AlertMessage>("message"));

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 26 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\ContactListAdmin.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"section\">\r\n    <div class=\"container\">\r\n        <h3 class=\"section-title\">Contact Message List</h3>\r\n");
#nullable restore
#line 31 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\ContactListAdmin.cshtml"
         if (Model.ContactMessages.Count() > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <table class=""table"">
                <thead>
                    <tr>
                        <th style=""width: 15%;"">Date</th>
                        <th style=""width: 30%;"">Subject</th>
                        <th style=""width: 45%;"">Message</th>
                        <th style=""width: 10%;""></th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 43 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\ContactListAdmin.cshtml"
                     foreach (var item in Model.ContactMessages)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 46 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\ContactListAdmin.cshtml"
                           Write(item.DateAdded);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 47 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\ContactListAdmin.cshtml"
                           Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 48 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\ContactListAdmin.cshtml"
                           Write(item.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n                                <div class=\"row-panel-buttons\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1057325cc798868ebd81582de43388a85b56a1a013920", async() => {
                WriteLiteral("<i class=\"fas fa-info-circle admin-panel-icon\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-UserId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 51 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\ContactListAdmin.cshtml"
                                                                                                    WriteLiteral(item.UserId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["UserId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-UserId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["UserId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1057325cc798868ebd81582de43388a85b56a1a016618", async() => {
                WriteLiteral("\r\n                                        <input type=\"hidden\" name=\"MessageId\"");
                BeginWriteAttribute("value", " value=\"", 2440, "\"", 2463, 1);
#nullable restore
#line 54 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\ContactListAdmin.cshtml"
WriteAttributeValue("", 2448, item.MessageId, 2448, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                        <button type=\"submit\" class=\"button button-small button-theme mb-10 mr-5\"");
                BeginWriteAttribute("id", " id=\"", 2580, "\"", 2614, 2);
                WriteAttributeValue("", 2585, "button-form-", 2585, 12, true);
#nullable restore
#line 55 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\ContactListAdmin.cshtml"
WriteAttributeValue("", 2597, item.MessageId, 2597, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" title=\"Delete\"><i class=\"far fa-trash-alt admin-panel-icon\"></i></button>\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2329, "form-confirm-", 2329, 13, true);
#nullable restore
#line 53 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\ContactListAdmin.cshtml"
AddHtmlAttributeValue("", 2342, item.MessageId, 2342, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 60 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\ContactListAdmin.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n");
#nullable restore
#line 63 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\ContactListAdmin.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert\">\r\n                <p class=\"alert-text text-danger\">No Contact Message Available</p>\r\n            </div>\r\n");
#nullable restore
#line 69 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\ContactListAdmin.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</section>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 75 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\ContactListAdmin.cshtml"
     if (TempData["message"] != null)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <script src=\"/folder/js/result_message.js\"></script>\r\n");
#nullable restore
#line 78 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\ContactListAdmin.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\ContactListAdmin.cshtml"
     foreach (var item in Model.ContactMessages)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <script>\r\n            document.querySelector(\'#button-form-");
#nullable restore
#line 82 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\ContactListAdmin.cshtml"
                                             Write(item.MessageId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\').addEventListener(\'click\', (e) => {\r\n                e.stopImmediatePropagation();\r\n                e.preventDefault();\r\n                document.querySelector(\'.confirm-container-");
#nullable restore
#line 85 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\ContactListAdmin.cshtml"
                                                       Write(item.MessageId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\').classList.add(\"active\");\r\n            });\r\n\r\n            document.querySelector(\'#button-confirm-");
#nullable restore
#line 88 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\ContactListAdmin.cshtml"
                                                Write(item.MessageId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\').addEventListener(\'click\', () => {\r\n                document.querySelector(\'#form-confirm-");
#nullable restore
#line 89 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\ContactListAdmin.cshtml"
                                                  Write(item.MessageId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\').submit();\r\n                document.querySelector(\'.confirm-container-");
#nullable restore
#line 90 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\ContactListAdmin.cshtml"
                                                       Write(item.MessageId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\').classList.remove(\"active\");\r\n            });\r\n\r\n            document.querySelector(\'#button-cancel-");
#nullable restore
#line 93 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\ContactListAdmin.cshtml"
                                               Write(item.MessageId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\').addEventListener(\'click\', () => {\r\n                document.querySelector(\'.confirm-container-");
#nullable restore
#line 94 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\ContactListAdmin.cshtml"
                                                       Write(item.MessageId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\').classList.remove(\"active\");\r\n            });\r\n        </script>\r\n");
#nullable restore
#line 97 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\ContactListAdmin.cshtml"
    }

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContactAdmin> Html { get; private set; }
    }
}
#pragma warning restore 1591
