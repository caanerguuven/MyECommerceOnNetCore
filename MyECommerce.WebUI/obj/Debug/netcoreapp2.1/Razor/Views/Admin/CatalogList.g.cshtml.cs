#pragma checksum "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Admin\CatalogList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c20ec377ec9a4da01a533017c5a798d4810cd56"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_CatalogList), @"mvc.1.0.view", @"/Views/Admin/CatalogList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/CatalogList.cshtml", typeof(AspNetCore.Views_Admin_CatalogList))]
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
#line 1 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\_ViewImports.cshtml"
using MyECommerce.WebUI.Models;

#line default
#line hidden
#line 2 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\_ViewImports.cshtml"
using MyECommerce.Entity;

#line default
#line hidden
#line 3 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\_ViewImports.cshtml"
using MyECommerce.Entity.Model;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c20ec377ec9a4da01a533017c5a798d4810cd56", @"/Views/Admin/CatalogList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6588d8bdaf067552ad5f49150aeb66310aa38c40", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_CatalogList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CatalogListModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("60"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Admin\CatalogList.cshtml"
  
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(84, 645, true);
            WriteLiteral(@"

<div class=""d-flex justify-content-between flex-wrap flex-md-nowrap align-items-center pb-2 mb-3 border-bottom"">
    <h1 class=""h2"">Catalog List</h1>
</div>


<div class=""table-responsive"">

    <div class=""card"">
        <div class=""card-header"">
            Categories
        </div>
        <table class=""table table-bordered"">
            <thead>
                <tr>
                    <th>#</th>
                    <th>Category Name</th>
                    <th>Is Active</th>
                    <th style=""width:130px;"">...</th>
                </tr>
            </thead>
            <tbody id=""categoryBody"">
");
            EndContext();
#line 28 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Admin\CatalogList.cshtml"
                 foreach (var category in Model.Categories)
                {

#line default
#line hidden
            BeginContext(809, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(864, 19, false);
#line 31 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Admin\CatalogList.cshtml"
                       Write(category.CategoryId);

#line default
#line hidden
            EndContext();
            BeginContext(883, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(919, 21, false);
#line 32 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Admin\CatalogList.cshtml"
                       Write(category.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(940, 37, true);
            WriteLiteral("</td>\r\n                        <td>\r\n");
            EndContext();
#line 34 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Admin\CatalogList.cshtml"
                             if (category.IsActive)
                            {

#line default
#line hidden
            BeginContext(1061, 75, true);
            WriteLiteral("                                <span data-feather=\"check-square\"></span>\r\n");
            EndContext();
#line 37 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Admin\CatalogList.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(1232, 71, true);
            WriteLiteral("                                <span data-feather=\"x-square\"></span>\r\n");
            EndContext();
#line 41 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Admin\CatalogList.cshtml"
                            }

#line default
#line hidden
            BeginContext(1334, 91, true);
            WriteLiteral("                        </td>\r\n                        <td>\r\n\r\n                            ");
            EndContext();
            BeginContext(1425, 129, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c04c195fe70240e29edefbce47bae028", async() => {
                BeginContext(1544, 6, true);
                WriteLiteral(" Edit ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 45 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Admin\CatalogList.cshtml"
                                                                                                                 WriteLiteral(category.CategoryId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1554, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1584, 132, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a838724f1bf845639347f830a85373ac", async() => {
                BeginContext(1704, 8, true);
                WriteLiteral(" Delete ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 46 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Admin\CatalogList.cshtml"
                                                                                                                  WriteLiteral(category.CategoryId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1716, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 49 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Admin\CatalogList.cshtml"
                }

#line default
#line hidden
            BeginContext(1795, 217, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n        <div class=\"card-footer\">\r\n            <input type=\"button\" class=\"btn btn-primary\" data-toggle=\"modal\" data-target=\"#addCategoryModal\" value=\"Create\" />\r\n\r\n            ");
            EndContext();
            BeginContext(2013, 44, false);
#line 55 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Admin\CatalogList.cshtml"
       Write(Html.Partial("_addCategory", new Category()));

#line default
#line hidden
            EndContext();
            BeginContext(2057, 664, true);
            WriteLiteral(@"


        </div>
    </div>

    <div class=""card"">
        <div class=""card-header"">
            Products
        </div>
        <table class=""table table-bordered"">
            <thead>
                <tr>
                    <th>#</th>
                    <th>Product Image</th>
                    <th>Product Name</th>
                    <th>Product Price</th>
                    <th>IsApproved</th>
                    <th>IsFeatured</th>
                    <th>IsHome</th>
                    <th>IsActive</th>
                    <th style=""width:130px;"">...</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 80 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Admin\CatalogList.cshtml"
                 foreach (var product in Model.Products)
                {

#line default
#line hidden
            BeginContext(2798, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(2853, 17, false);
#line 83 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Admin\CatalogList.cshtml"
                       Write(product.ProductId);

#line default
#line hidden
            EndContext();
            BeginContext(2870, 65, true);
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2935, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2c7c2327a45c4ebfb17f7ffd0ba30d31", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2945, "~/images/products/thumbs/", 2945, 25, true);
#line 85 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Admin\CatalogList.cshtml"
AddHtmlAttributeValue("", 2970, product.ProductImageUrl, 2970, 24, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3009, 61, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>");
            EndContext();
            BeginContext(3071, 19, false);
#line 87 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Admin\CatalogList.cshtml"
                       Write(product.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(3090, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(3126, 20, false);
#line 88 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Admin\CatalogList.cshtml"
                       Write(product.ProductPrice);

#line default
#line hidden
            EndContext();
            BeginContext(3146, 37, true);
            WriteLiteral("</td>\r\n                        <td>\r\n");
            EndContext();
#line 90 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Admin\CatalogList.cshtml"
                             if (product.IsApproved)
                            {

#line default
#line hidden
            BeginContext(3268, 75, true);
            WriteLiteral("                                <span data-feather=\"check-square\"></span>\r\n");
            EndContext();
#line 93 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Admin\CatalogList.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(3439, 71, true);
            WriteLiteral("                                <span data-feather=\"x-square\"></span>\r\n");
            EndContext();
#line 97 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Admin\CatalogList.cshtml"
                            }

#line default
#line hidden
            BeginContext(3541, 61, true);
            WriteLiteral("                        </td>\r\n                        <td>\r\n");
            EndContext();
#line 100 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Admin\CatalogList.cshtml"
                             if (product.IsFeatured)
                            {

#line default
#line hidden
            BeginContext(3687, 75, true);
            WriteLiteral("                                <span data-feather=\"check-square\"></span>\r\n");
            EndContext();
#line 103 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Admin\CatalogList.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(3858, 71, true);
            WriteLiteral("                                <span data-feather=\"x-square\"></span>\r\n");
            EndContext();
#line 107 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Admin\CatalogList.cshtml"
                            }

#line default
#line hidden
            BeginContext(3960, 61, true);
            WriteLiteral("                        </td>\r\n                        <td>\r\n");
            EndContext();
#line 110 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Admin\CatalogList.cshtml"
                             if (product.IsHome)
                            {

#line default
#line hidden
            BeginContext(4102, 75, true);
            WriteLiteral("                                <span data-feather=\"check-square\"></span>\r\n");
            EndContext();
#line 113 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Admin\CatalogList.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(4273, 71, true);
            WriteLiteral("                                <span data-feather=\"x-square\"></span>\r\n");
            EndContext();
#line 117 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Admin\CatalogList.cshtml"
                            }

#line default
#line hidden
            BeginContext(4375, 61, true);
            WriteLiteral("                        </td>\r\n                        <td>\r\n");
            EndContext();
#line 120 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Admin\CatalogList.cshtml"
                             if (product.IsActive)
                            {

#line default
#line hidden
            BeginContext(4519, 75, true);
            WriteLiteral("                                <span data-feather=\"check-square\"></span>\r\n");
            EndContext();
#line 123 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Admin\CatalogList.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(4690, 71, true);
            WriteLiteral("                                <span data-feather=\"x-square\"></span>\r\n");
            EndContext();
#line 127 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Admin\CatalogList.cshtml"
                            }

#line default
#line hidden
            BeginContext(4792, 89, true);
            WriteLiteral("                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(4881, 188, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19431b794377448086d73dfca7fc250c", async() => {
                BeginContext(4997, 68, true);
                WriteLiteral("\r\n                                Edit\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 130 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Admin\CatalogList.cshtml"
                                                                                                                WriteLiteral(product.ProductId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5069, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(5099, 192, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4eb48ab7622945a7af7fc087156b8f21", async() => {
                BeginContext(5217, 70, true);
                WriteLiteral("\r\n                                Delete\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 133 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Admin\CatalogList.cshtml"
                                                                                                                  WriteLiteral(product.ProductId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5291, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 138 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Admin\CatalogList.cshtml"
                }

#line default
#line hidden
            BeginContext(5370, 87, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n        <div class=\"card-footer\">\r\n            ");
            EndContext();
            BeginContext(5457, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6de4f7572df44aefa68f7302f874d2ea", async() => {
                BeginContext(5534, 6, true);
                WriteLiteral("Create");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5544, 58, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n\r\n    <hr />\r\n\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(5619, 1640, true);
                WriteLiteral(@"
    <script>
        $('#addCategoryForm').submit(function (event) {
            event.preventDefault();
            var form = $(this);
            var token = $('input[name=""__RequestVerificationToken""]', form).val();
            var data = { 'categoryName': $('#CategoryName').val() }
            var dataWithToken = $.extend(data, { '__RequestVerificationToken': token });

            $.ajax({
                url: form.attr('action'),
                type: 'POST',
                data: dataWithToken,
                beforeSend: function () {
                    $('#imgAjaxLoading').show();
                },
                complete: function () {
                    $('#imgAjaxLoading').hide();
                },
                success: function (data) {
                    var trStr = '<tr><td>' + data.categoryId.toString() + '</td><td>' + data.categoryName + '</td><td><span data-feather=""' + (data.isActive == true ? ""check-square"" : ""x-square"") + '""></span></td><td><a class=""btn btn");
                WriteLiteral(@"-primary btn-sm"" asp-controller=""Admin"" asp-action=""EditCategory"" asp-route-id=""' + data.categoryId.toString() + '""> Edit </a><a class=""btn btn-danger btn-sm"" asp-controller=""Admin"" asp-action=""DeleteCategory"" asp-route-id=""' + data.categoryId.toString() + '""> Delete </a></td></tr>';
                    console.log(trStr);
                    $('#categoryBody').append(trStr);

                    $('#addCategoryModal').modal('hide');
                },
                error: function () {
                    console.log('Error Occured');
                }
            });
        });
    </script>
");
                EndContext();
            }
            );
            BeginContext(7262, 2, true);
            WriteLiteral("\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CatalogListModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
