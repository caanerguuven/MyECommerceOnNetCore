#pragma checksum "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "002f1c6832547e9d26b5c9444781e3c586c469b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"002f1c6832547e9d26b5c9444781e3c586c469b7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6588d8bdaf067552ad5f49150aeb66310aa38c40", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductPageModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(25, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(68, 215, true);
            WriteLiteral("\r\n    <section id=\"shop\" class=\"container\">\r\n        <div class=\"row\">\r\n            <!-- sidebar start -->\r\n            <div id=\"sidebar\" class=\"col-md-3\">\r\n                <div class=\"widget\">\r\n                    ");
            EndContext();
            BeginContext(283, 462, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81d8286db75e4a1aab8992a3d6a3de46", async() => {
                BeginContext(309, 429, true);
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
            BeginContext(745, 44, true);
            WriteLiteral("\r\n                </div>\r\n\r\n                ");
            EndContext();
            BeginContext(790, 43, false);
#line 22 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Home\Index.cshtml"
           Write(await Component.InvokeAsync("CategoryMenu"));

#line default
#line hidden
            EndContext();
            BeginContext(833, 20, true);
            WriteLiteral("\r\n\r\n                ");
            EndContext();
            BeginContext(854, 47, false);
#line 24 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Home\Index.cshtml"
           Write(await Component.InvokeAsync("FeaturedProducts"));

#line default
#line hidden
            EndContext();
            BeginContext(901, 482, true);
            WriteLiteral(@"

            </div>
            <!-- sidebar end -->
            <!-- right column start -->
            <div class=""col-md-9"">
                <div class=""row"">
                    <div class=""col-md-12 wow fadeIn"">
                        <div class=""row product-results"">
                            <div class=""product-results"">
                                <div class=""col-xs-8"">
                                    <p class=""woocommerce-result-count"">There are ");
            EndContext();
            BeginContext(1384, 26, false);
#line 35 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Home\Index.cshtml"
                                                                             Write(Model.PageModel.TotalItems);

#line default
#line hidden
            EndContext();
            BeginContext(1410, 169, true);
            WriteLiteral(" products in the system. </p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n\r\n");
            EndContext();
#line 41 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Home\Index.cshtml"
                     foreach (var product in Model.Products)
                    {
                        

#line default
#line hidden
            BeginContext(1689, 37, false);
#line 43 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Home\Index.cshtml"
                   Write(Html.Partial("_ProductItem", product));

#line default
#line hidden
            EndContext();
#line 43 "D:\DeveloperSide\MyEducationProjects\MyECommerce\MyECommerce\MyECommerce.WebUI\Views\Home\Index.cshtml"
                                                              
                    }

#line default
#line hidden
            BeginContext(1751, 44, true);
            WriteLiteral("                </div>\r\n            </div>\r\n");
            EndContext();
            BeginContext(1898, 73, true);
            WriteLiteral("            <!-- right column end -->\r\n        </div>\r\n\r\n    </section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductPageModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
