#pragma checksum "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Product\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1da6ce226968846f9404de468cef3782e5617b83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Details), @"mvc.1.0.view", @"/Views/Product/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Details.cshtml", typeof(AspNetCore.Views_Product_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1da6ce226968846f9404de468cef3782e5617b83", @"/Views/Product/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6588d8bdaf067552ad5f49150aeb66310aa38c40", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductDetailModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Product\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(72, 346, true);
            WriteLiteral(@"
<section id=""content"">
    <!-- shop section start -->
    <section id=""shop"" class=""container"">
        <!-- row start -->
        <div class=""row"">
            <!-- sidebar start -->
            <div id=""sidebar"" class=""col-md-3"">
                <!-- search widget start -->
                <div class=""widget"">
                    ");
            EndContext();
            BeginContext(418, 462, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a106f3935a3542e5ae14b321174d1450", async() => {
                BeginContext(444, 429, true);
                WriteLiteral(@"
                        <div class=""input-group"">
                            <input type=""text"" class=""form-control input-lg"" placeholder=""Search..."">
                            <span class=""input-group-btn"">
                                <button class=""btn btn-default btn-lg"" type=""submit""><i class=""fa fa-search""></i></button>
                            </span>
                        </div>
                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(880, 42, true);
            WriteLiteral("\r\n                </div>\r\n                ");
            EndContext();
            BeginContext(923, 43, false);
#line 25 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Product\Details.cshtml"
           Write(await Component.InvokeAsync("CategoryMenu"));

#line default
#line hidden
            EndContext();
            BeginContext(966, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(985, 47, false);
#line 26 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Product\Details.cshtml"
           Write(await Component.InvokeAsync("FeaturedProducts"));

#line default
#line hidden
            EndContext();
            BeginContext(1032, 466, true);
            WriteLiteral(@"
            </div>
            <!-- sidebar end -->
            <!-- main column start -->
            <div class=""col-md-9"">
                <div class=""row"">

                    <!-- product page top info start -->
                    <div class=""col-md-12 product"">
                        <div class=""row"">
                            <div class=""col-md-6"">
                                <div id=""product-gallery"" class=""owl-carousel owl-theme"">
");
            EndContext();
#line 38 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Product\Details.cshtml"
                                     if (Model.ProductImages.Count == 0)
                                    {

#line default
#line hidden
            BeginContext(1611, 104, true);
            WriteLiteral("                                        <div class=\"item\">\r\n                                            ");
            EndContext();
            BeginContext(1715, 92, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "62933f021b0b4bd5acbc9688bdeff728", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1755, "~/images/products/", 1755, 18, true);
#line 41 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Product\Details.cshtml"
AddHtmlAttributeValue("", 1773, Model.Product.ProductImageUrl, 1773, 30, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1807, 50, true);
            WriteLiteral("\r\n                                        </div>\r\n");
            EndContext();
#line 43 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Product\Details.cshtml"
                                    }
                                    else
                                    {
                                        

#line default
#line hidden
#line 46 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Product\Details.cshtml"
                                         foreach (var image in Model.ProductImages)
                                        {

#line default
#line hidden
            BeginContext(2105, 112, true);
            WriteLiteral("                                            <div class=\"item\">\r\n                                                ");
            EndContext();
            BeginContext(2217, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2ae1bf3dbdd8471b99cc65589b1dcc65", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2257, "~/images/products/", 2257, 18, true);
#line 49 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Product\Details.cshtml"
AddHtmlAttributeValue("", 2275, image.ProductImageName, 2275, 23, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2302, 54, true);
            WriteLiteral("\r\n                                            </div>\r\n");
            EndContext();
#line 51 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Product\Details.cshtml"
                                        }

#line default
#line hidden
#line 51 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Product\Details.cshtml"
                                         
                                    }

#line default
#line hidden
            BeginContext(2438, 252, true);
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"col-md-6\">\r\n                                <div class=\"padding15\">\r\n                                    <h2 class=\"product-title\"><b>");
            EndContext();
            BeginContext(2691, 25, false);
#line 58 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Product\Details.cshtml"
                                                            Write(Model.Product.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(2716, 379, true);
            WriteLiteral(@"</b></h2>
                                    <p>
                                        <i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i>
                                        3 Reviews
                                    </p>
                                    <p class=""product-price"">$");
            EndContext();
            BeginContext(3096, 26, false);
#line 63 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Product\Details.cshtml"
                                                         Write(Model.Product.ProductPrice);

#line default
#line hidden
            EndContext();
            BeginContext(3122, 81, true);
            WriteLiteral("</p>\r\n                                </div>\r\n                                <p>");
            EndContext();
            BeginContext(3204, 25, false);
#line 65 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Product\Details.cshtml"
                              Write(Model.Product.Description);

#line default
#line hidden
            EndContext();
            BeginContext(3229, 101, true);
            WriteLiteral("</p>\r\n\r\n                                <div class=\"padding15\">\r\n                                    ");
            EndContext();
            BeginContext(3330, 868, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a4568921c37431a86d8468af12067be", async() => {
                BeginContext(3415, 79, true);
                WriteLiteral("\r\n                                        <input type=\"hidden\" name=\"productId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3494, "\"", 3526, 1);
#line 69 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Product\Details.cshtml"
WriteAttributeValue("", 3502, Model.Product.ProductId, 3502, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3527, 664, true);
                WriteLiteral(@" />
                                        <div class=""form-group qty"">
                                            <div class=""input-group"">
                                                <span class=""input-group-addon"">Qty</span>
                                                <input type=""number"" size=""4"" class=""form-control"" name=""quantity"" value=""1"" min=""1"" step=""1"">
                                            </div>
                                        </div>
                                        <button type=""submit"" class=""btn btn-primary""><i class=""fa fa-cart-plus fa-fw""></i> Add to cart</button>
                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4198, 133, true);
            WriteLiteral("\r\n                                </div>\r\n                                <p>\r\n                                    <b>Category:</b>\r\n");
            EndContext();
#line 81 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Product\Details.cshtml"
                                     foreach (var category in Model.Categories)
                                    {

#line default
#line hidden
            BeginContext(4451, 52, true);
            WriteLiteral("                                        <a href=\"#\">");
            EndContext();
            BeginContext(4504, 21, false);
#line 83 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Product\Details.cshtml"
                                               Write(category.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(4525, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 84 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Product\Details.cshtml"
                                    }

#line default
#line hidden
            BeginContext(4570, 820, true);
            WriteLiteral(@"                                </p>
                            </div>
                        </div>
                    </div>
                    <!-- product page top info end -->
                    <!-- product page middle info start -->
                    <div class=""col-md-12 padding25"">

                        <ul class=""nav nav-tabs"">
                            <li class=""active""><a data-toggle=""tab"" href=""#description"">Description</a></li>
                            <li><a data-toggle=""tab"" href=""#spec"">Specifications</a></li>
                        </ul>

                        <div class=""tab-content"">
                            <!-- description tab start -->
                            <div id=""description"" class=""tab-pane fade in active"">
                                ");
            EndContext();
            BeginContext(5391, 35, false);
#line 101 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Product\Details.cshtml"
                           Write(Html.Raw(Model.Product.HtmlContent));

#line default
#line hidden
            EndContext();
            BeginContext(5426, 375, true);
            WriteLiteral(@"
                            </div>
                            <!-- description tab end -->
                            <!-- Specifications tab start -->
                            <div id=""spec"" class=""tab-pane fade"">
                                <div class=""table-responsive"">
                                    <table class=""table table-striped table-hover"">
");
            EndContext();
#line 108 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Product\Details.cshtml"
                                         foreach (var attribute in Model.ProductAttributes)
                                        {

#line default
#line hidden
            BeginContext(5937, 105, true);
            WriteLiteral("                                            <tr>\r\n                                                <td><b>");
            EndContext();
            BeginContext(6043, 30, false);
#line 111 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Product\Details.cshtml"
                                                  Write(attribute.ProductAttributeName);

#line default
#line hidden
            EndContext();
            BeginContext(6073, 63, true);
            WriteLiteral("</b></td>\r\n                                                <td>");
            EndContext();
            BeginContext(6137, 31, false);
#line 112 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Product\Details.cshtml"
                                               Write(attribute.ProductAttributeValue);

#line default
#line hidden
            EndContext();
            BeginContext(6168, 58, true);
            WriteLiteral("</td>\r\n                                            </tr>\r\n");
            EndContext();
#line 114 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Product\Details.cshtml"
                                        }

#line default
#line hidden
            BeginContext(6269, 620, true);
            WriteLiteral(@"                                    </table>
                                </div>
                            </div>
                            <!-- Specifications tab end -->
                        </div>
                    </div>
                    <!-- product page middle info end -->
                    <!-- related products start -->
                    <div class=""col-md-12"">
                        <div class=""text-center"">
                            <h3>RELATED <b>PRODUCTS</b></h3>
                        </div>
                        <div id=""products-carousel"" class=""owl-carousel"">
");
            EndContext();
#line 128 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Product\Details.cshtml"
                             foreach (var rProduct in Model.RelatedProducts)
                            {

#line default
#line hidden
            BeginContext(6998, 231, true);
            WriteLiteral("                                <div>\r\n                                    <div class=\"text-center product-item\">\r\n                                        <div class=\"product-item-top\">\r\n                                            ");
            EndContext();
            BeginContext(7229, 92, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "41dd6c33a19749648342cec6f24f1683", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 7269, "~/images/products/thumbs/", 7269, 25, true);
#line 133 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Product\Details.cshtml"
AddHtmlAttributeValue("", 7294, rProduct.ProductImageUrl, 7294, 25, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7321, 630, true);
            WriteLiteral(@"
                                            <div class=""mask""></div>
                                            <ul class=""list-unstyled list-inline"">
                                                <li><a href=""#""><i class=""fa fa-link fa-fw""></i></a></li>
                                                <li><a href=""#""><i class=""fa fa-cart-plus fa-fw""></i></a></li>
                                            </ul>
                                        </div>
                                        <div class=""product-item-inner"">
                                            <h3 class=""product-title""><a href=""#"">");
            EndContext();
            BeginContext(7952, 20, false);
#line 141 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Product\Details.cshtml"
                                                                             Write(rProduct.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(7972, 81, true);
            WriteLiteral("</a></h3>\r\n                                            <p class=\"product-price\">$");
            EndContext();
            BeginContext(8054, 21, false);
#line 142 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Product\Details.cshtml"
                                                                 Write(rProduct.ProductPrice);

#line default
#line hidden
            EndContext();
            BeginContext(8075, 138, true);
            WriteLiteral("</p>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n");
            EndContext();
#line 146 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Product\Details.cshtml"
                            }

#line default
#line hidden
            BeginContext(8244, 375, true);
            WriteLiteral(@"                        </div>
                        <!-- carousel end -->
                    </div>
                    <!-- related products end -->
                </div>
                <!-- row end -->
            </div>
            <!-- main column end -->
        </div>
        <!-- row end -->
    </section>
    <!-- shop section end -->
</section>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductDetailModel> Html { get; private set; }
    }
}
#pragma warning restore 1591