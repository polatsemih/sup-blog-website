#pragma checksum "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\CategoryEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22f21d8ce809812c79d42fe27f0ebc489adc217e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_CategoryEdit), @"mvc.1.0.view", @"/Views/Admin/CategoryEdit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22f21d8ce809812c79d42fe27f0ebc489adc217e", @"/Views/Admin/CategoryEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ced40132982272c4a2481f2958947860176807f7", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_CategoryEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CategoryModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-label-icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Role Name"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("tabindex", new global::Microsoft.AspNetCore.Html.HtmlString("1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CategoryEdit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form-confirm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ArticleEdit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button button-small button-theme"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
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
");
            }
            );
            WriteLiteral(@"
<div class=""confirm-container"">
    <div class=""confirm-content"">
        <p class=""confirm-text"">Are you sure you want to edit the category name?</p>
        <button class=""button button-medium button-danger mr-10"" id=""button-cancel"">Cancel</button>
        <button class=""button button-medium button-success"" id=""button-confirm"">Yes</button>
    </div>
</div>

<div class=""section"">
    <div class=""admin-panel-container"">
        <div class=""admin-panel-form-container"">
            <h3 class=""section-title"">Edit Category</h3>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22f21d8ce809812c79d42fe27f0ebc489adc217e9835", async() => {
                WriteLiteral("\r\n                <div class=\"form-group\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22f21d8ce809812c79d42fe27f0ebc489adc217e10159", async() => {
                    WriteLiteral("<i class=\"fas fa-tag form-icon\"></i>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 26 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\CategoryEdit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "22f21d8ce809812c79d42fe27f0ebc489adc217e11837", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 27 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\CategoryEdit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22f21d8ce809812c79d42fe27f0ebc489adc217e13679", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 30 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\CategoryEdit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </div>

                <div class=""form-group"">
                    <button type=""submit"" class=""button button-medium button-theme flex-right"" id=""button-form"" tabindex=""2"">Edit Category Name</button>
                </div>

                <div>
");
#nullable restore
#line 38 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\CategoryEdit.cshtml"
                     for (int i = 0; i < Model.Articles.Count; i++)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 1815, "\"", 1844, 3);
                WriteAttributeValue("", 1822, "Articles[", 1822, 9, true);
#nullable restore
#line 40 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\CategoryEdit.cshtml"
WriteAttributeValue("", 1831, i, 1831, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1833, "].ArticleId", 1833, 11, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1845, "\"", 1882, 1);
#nullable restore
#line 40 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\CategoryEdit.cshtml"
WriteAttributeValue("", 1853, Model.Articles[@i].ArticleId, 1853, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 1930, "\"", 1955, 3);
                WriteAttributeValue("", 1937, "Articles[", 1937, 9, true);
#nullable restore
#line 41 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\CategoryEdit.cshtml"
WriteAttributeValue("", 1946, i, 1946, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1948, "].Title", 1948, 7, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1956, "\"", 1989, 1);
#nullable restore
#line 41 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\CategoryEdit.cshtml"
WriteAttributeValue("", 1964, Model.Articles[@i].Title, 1964, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 2037, "\"", 2068, 3);
                WriteAttributeValue("", 2044, "Articles[", 2044, 9, true);
#nullable restore
#line 42 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\CategoryEdit.cshtml"
WriteAttributeValue("", 2053, i, 2053, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2055, "].Explanation", 2055, 13, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2069, "\"", 2108, 1);
#nullable restore
#line 42 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\CategoryEdit.cshtml"
WriteAttributeValue("", 2077, Model.Articles[@i].Explanation, 2077, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 2156, "\"", 2184, 3);
                WriteAttributeValue("", 2163, "Articles[", 2163, 9, true);
#nullable restore
#line 43 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\CategoryEdit.cshtml"
WriteAttributeValue("", 2172, i, 2172, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2174, "].ImageUrl", 2174, 10, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2185, "\"", 2221, 1);
#nullable restore
#line 43 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\CategoryEdit.cshtml"
WriteAttributeValue("", 2193, Model.Articles[@i].ImageUrl, 2193, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 44 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\CategoryEdit.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n\r\n");
#nullable restore
#line 49 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\CategoryEdit.cshtml"
         if (Model.Articles.Count() > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <table class=""table"">
                <thead>
                    <tr>
                        <th style=""width: 5%;"">Id</th>
                        <th style=""width: 25%;"">Image</th>
                        <th style=""width: 25%;"">Title</th>
                        <th style=""width: 40%;"">Explanation</th>
                        <th style=""width: 5%;""></th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 62 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\CategoryEdit.cshtml"
                     foreach (var item in Model.Articles)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 65 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\CategoryEdit.cshtml"
                           Write(item.ArticleId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 3060, "\"", 3109, 2);
            WriteAttributeValue("", 3066, "/folder/images/article-image/", 3066, 29, true);
#nullable restore
#line 67 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\CategoryEdit.cshtml"
WriteAttributeValue("", 3095, item.ImageUrl, 3095, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"article-image\" class=\"img-fluid\">\r\n                            </td>\r\n                            <td>");
#nullable restore
#line 69 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\CategoryEdit.cshtml"
                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 70 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\CategoryEdit.cshtml"
                           Write(item.Explanation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td> \r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22f21d8ce809812c79d42fe27f0ebc489adc217e24248", async() => {
                WriteLiteral("<i class=\"fas fa-edit admin-panel-icon\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-articleId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 72 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\CategoryEdit.cshtml"
                                                                                            WriteLiteral(item.ArticleId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["articleId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-articleId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["articleId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 75 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\CategoryEdit.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n");
#nullable restore
#line 78 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\CategoryEdit.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert\">\r\n                <p class=\"alert-text text-danger\">No Article Available</p>\r\n            </div>\r\n");
#nullable restore
#line 84 "D:\Github_Projects\sup-blog-website\sup1\sup1.webui\Views\Admin\CategoryEdit.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script src=\"/folder/js/confirm.js\"></script>\r\n    <script src=\"/library/jquery-validation/dist/jquery.validate.min.js\"></script>\r\n    <script src=\"/library/jquery-validation-unobtrusive/dist/jquery.validate.unobtrusive.min.js\"></script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CategoryModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
