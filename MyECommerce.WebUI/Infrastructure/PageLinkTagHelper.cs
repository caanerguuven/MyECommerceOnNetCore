using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using MyECommerce.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyECommerce.WebUI.Infrastructure
{
    [HtmlTargetElement("div",Attributes ="page-model")]
    public class PageLinkTagHelper:TagHelper
    {
        private IUrlHelperFactory urlHelperFactory;
        public PageLinkTagHelper(IUrlHelperFactory _urlHelperFactory) {
            urlHelperFactory = _urlHelperFactory;
        }
        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext viewContext { get; set; }
        public PagingInfoModel PageModel { get; set; }

        public string pageAction { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var urlHelper = urlHelperFactory.GetUrlHelper(viewContext);
            var result = new TagBuilder("div");
            for (int i = 1; i <= PageModel.TotalPages; i++)
            {
                var tag = new TagBuilder("a");
                tag.Attributes["href"] = urlHelper.Action(pageAction, new { page = i });
                tag.InnerHtml.Append(i.ToString());
                if (PageModel.CurrentPage == i)
                {
                    tag.AddCssClass("btn btn-warning");
                }
                else
                {
                    tag.AddCssClass("btn btn-primary");
                }
                result.InnerHtml.AppendHtml(tag);
            }

            output.Content.AppendHtml(result.InnerHtml);
        }
    }
}
