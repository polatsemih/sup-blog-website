#pragma checksum "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\RoleEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1669ef2d2ca292c79f17b033ac14bebf224f8e65"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_RoleEdit), @"mvc.1.0.view", @"/Views/Admin/RoleEdit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1669ef2d2ca292c79f17b033ac14bebf224f8e65", @"/Views/Admin/RoleEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ced40132982272c4a2481f2958947860176807f7", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_RoleEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleEditModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ResultMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-label-icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Role Name"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("tabindex", new global::Microsoft.AspNetCore.Html.HtmlString("1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RoleEdit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form-confirm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            DefineSection("Css", async() => {
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""/folder/css/article.css"">
    <link rel=""stylesheet"" href=""/folder/css/form.css"">
    <link rel=""stylesheet"" href=""/folder/css/confirm.css"">
    <link rel=""stylesheet"" href=""/folder/css/admin_panel.css"">
    <link rel=""stylesheet"" href=""/folder/css/table.css"">
    <link rel=""stylesheet"" href=""/folder/css/checkbox.css"">
    <link rel=""stylesheet"" href=""/folder/css/result_message.css"">
");
            }
            );
            WriteLiteral(@"
<div class=""confirm-container"">
    <div class=""confirm-content"">
        <p class=""confirm-text"">Are you sure you want to edit the role?</p>
        <button class=""button button-medium button-danger mr-10"" id=""button-cancel"">Cancel</button>
        <button class=""button button-medium button-success"" id=""button-confirm"">Yes</button>
    </div>
</div>

");
#nullable restore
#line 22 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\RoleEdit.cshtml"
 if (TempData["message"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1669ef2d2ca292c79f17b033ac14bebf224f8e659606", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 24 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\RoleEdit.cshtml"
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
#line 25 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\RoleEdit.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"section\">\r\n    <div class=\"admin-panel-container\">\r\n        <div class=\"admin-panel-form-container\">\r\n            <h3 class=\"section-title\">Edit Role</h3>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1669ef2d2ca292c79f17b033ac14bebf224f8e6511602", async() => {
                WriteLiteral("\r\n                <input type=\"hidden\" name=\"RoleId\"");
                BeginWriteAttribute("value", " value=\"", 1300, "\"", 1321, 1);
#nullable restore
#line 32 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\RoleEdit.cshtml"
WriteAttributeValue("", 1308, Model.RoleId, 1308, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n                <div class=\"form-group\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1669ef2d2ca292c79f17b033ac14bebf224f8e6512368", async() => {
                    WriteLiteral("<i class=\"fas fa-tag form-icon\"></i>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 35 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\RoleEdit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.RoleName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1669ef2d2ca292c79f17b033ac14bebf224f8e6514046", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 36 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\RoleEdit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.RoleName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1669ef2d2ca292c79f17b033ac14bebf224f8e6515888", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 39 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\RoleEdit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.RoleName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n\r\n                <h3 class=\"section-title\">Add user to role of <span class=\"text-theme-secondary\">");
#nullable restore
#line 42 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\RoleEdit.cshtml"
                                                                                            Write(Model.RoleName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></h3>\r\n\r\n                <table class=\"table mb-20\">\r\n");
#nullable restore
#line 45 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\RoleEdit.cshtml"
                     if (Model.NonMembers.Count() == 0)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n                            <td class=\"alert-text text-danger\">All users belong to \"");
#nullable restore
#line 48 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\RoleEdit.cshtml"
                                                                                Write(Model.RoleName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" role</td>\r\n                        </tr>\r\n");
#nullable restore
#line 50 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\RoleEdit.cshtml"
                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\RoleEdit.cshtml"
                         foreach (var user in Model.NonMembers)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr>\r\n                                <td style=\"width: 90%;\">");
#nullable restore
#line 56 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\RoleEdit.cshtml"
                                                   Write(user.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td style=\"width: 10%;\">\r\n                                    <label");
                BeginWriteAttribute("for", " for=\"", 2568, "\"", 2582, 1);
#nullable restore
#line 58 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\RoleEdit.cshtml"
WriteAttributeValue("", 2574, user.Id, 2574, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"checkbox-label\">\r\n                                        <input name=\"IdsToAdd\"");
                BeginWriteAttribute("id", " id=\"", 2671, "\"", 2684, 1);
#nullable restore
#line 59 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\RoleEdit.cshtml"
WriteAttributeValue("", 2676, user.Id, 2676, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"checkbox\" class=\"checkbox\"");
                BeginWriteAttribute("value", " value=\"", 2718, "\"", 2734, 1);
#nullable restore
#line 59 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\RoleEdit.cshtml"
WriteAttributeValue("", 2726, user.Id, 2726, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                        <span class=""checkmark""></span>
                                        <span class=""label-text"">Add</span>
                                    </label>
                                </td>
                            </tr>
");
#nullable restore
#line 65 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\RoleEdit.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\RoleEdit.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </table>\r\n\r\n                <h3 class=\"section-title\">Remove user from role of <span class=\"text-theme-secondary\">");
#nullable restore
#line 69 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\RoleEdit.cshtml"
                                                                                                 Write(Model.RoleName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></h3>\r\n                <table class=\"table mb-20\">\r\n");
#nullable restore
#line 71 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\RoleEdit.cshtml"
                     if (Model.Members.Count() == 0)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n                            <td class=\"alert-text text-danger\">No user belongs to \"");
#nullable restore
#line 74 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\RoleEdit.cshtml"
                                                                               Write(Model.RoleName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" role</td>\r\n                        </tr>\r\n");
#nullable restore
#line 76 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\RoleEdit.cshtml"
                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\RoleEdit.cshtml"
                         foreach (var user in Model.Members)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr>\r\n                                <td style=\"width: 90%;\">");
#nullable restore
#line 82 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\RoleEdit.cshtml"
                                                   Write(user.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td style=\"width: 10%;\">\r\n                                    <label");
                BeginWriteAttribute("for", " for=\"", 3885, "\"", 3899, 1);
#nullable restore
#line 84 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\RoleEdit.cshtml"
WriteAttributeValue("", 3891, user.Id, 3891, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"checkbox-label\">\r\n                                        <input name=\"IdsToDelete\"");
                BeginWriteAttribute("id", " id=\"", 3991, "\"", 4004, 1);
#nullable restore
#line 85 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\RoleEdit.cshtml"
WriteAttributeValue("", 3996, user.Id, 3996, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"checkbox\" class=\"checkbox\"");
                BeginWriteAttribute("value", " value=\"", 4038, "\"", 4054, 1);
#nullable restore
#line 85 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\RoleEdit.cshtml"
WriteAttributeValue("", 4046, user.Id, 4046, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                        <span class=""checkmark""></span>
                                        <span class=""label-text"">Remove</span>
                                    </label>
                                </td>
                            </tr>
");
#nullable restore
#line 91 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\RoleEdit.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\RoleEdit.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </table>\r\n\r\n                <div class=\"form-group\">\r\n                    <button type=\"submit\" class=\"button button-medium button-theme flex-right\" id=\"button-form\" tabindex=\"2\">Edit Role</button>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 105 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\RoleEdit.cshtml"
     if (TempData["message"] != null)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <script src=\"/folder/js/result_message.js\"></script>\r\n");
#nullable restore
#line 108 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\RoleEdit.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    <script src=\"/folder/js/confirm.js\"></script>\r\n    <script src=\"/library/jquery-validation/dist/jquery.validate.min.js\"></script>\r\n    <script src=\"/library/jquery-validation-unobtrusive/dist/jquery.validate.unobtrusive.min.js\"></script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleEditModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
