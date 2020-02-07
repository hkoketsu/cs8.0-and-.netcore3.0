#pragma checksum "C:\Users\hirok\Codes\cs8.0-and-.netcore3.0\PracticingApps\NorthwindCms\Views\Cms\Archive.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f76f4ebb140903bef9cd343d90f7613aef997d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cms_Archive), @"mvc.1.0.view", @"/Views/Cms/Archive.cshtml")]
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
#line 2 "C:\Users\hirok\Codes\cs8.0-and-.netcore3.0\PracticingApps\NorthwindCms\Views\Cms\Archive.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f76f4ebb140903bef9cd343d90f7613aef997d4", @"/Views/Cms/Archive.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca5b93007b6e082af5cc813bafde1a14cdc102f6", @"/Views/_ViewImports.cshtml")]
    public class Views_Cms_Archive : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NorthwindCms.Models.BlogArchive>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\hirok\Codes\cs8.0-and-.netcore3.0\PracticingApps\NorthwindCms\Views\Cms\Archive.cshtml"
  
    ViewBag.Title = Model.Title;

    Func<string> BlogLink = () => {
        return Model.Permalink
            + (Model.Archive.Category != null ? $"/category/{Model.Archive.Category.Slug}"  : "")
            + (Model.Archive.Year.HasValue ? $"/{Model.Archive.Year}" : "" )
            + (Model.Archive.Month.HasValue ? $"/{Model.Archive.Month}" : "");
    };

    Func<string> MonthName = () => {
        if (Model.Archive.Month.HasValue) {
            return new DateTime(2018, Model.Archive.Month.Value, 1) .ToString("MMMM", CultureInfo.InvariantCulture);
        }
        return "";
    };

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"container archive\">\n");
#nullable restore
#line 22 "C:\Users\hirok\Codes\cs8.0-and-.netcore3.0\PracticingApps\NorthwindCms\Views\Cms\Archive.cshtml"
     if (Model.Archive.Category != null) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\n            <div class=\"col blog-filter-header\">\n                <h1>Category: ");
#nullable restore
#line 25 "C:\Users\hirok\Codes\cs8.0-and-.netcore3.0\PracticingApps\NorthwindCms\Views\Cms\Archive.cshtml"
                         Write(Model.Archive.Category.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n            </div>\n        </div>\n");
#nullable restore
#line 28 "C:\Users\hirok\Codes\cs8.0-and-.netcore3.0\PracticingApps\NorthwindCms\Views\Cms\Archive.cshtml"
    } else if (Model.Archive.Tag != null) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\n            <div class=\"col blog-filter-header\">\n                <h1>Tag: ");
#nullable restore
#line 31 "C:\Users\hirok\Codes\cs8.0-and-.netcore3.0\PracticingApps\NorthwindCms\Views\Cms\Archive.cshtml"
                    Write(Model.Archive.Tag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n            </div>\n        </div>\n");
#nullable restore
#line 34 "C:\Users\hirok\Codes\cs8.0-and-.netcore3.0\PracticingApps\NorthwindCms\Views\Cms\Archive.cshtml"
    } else if (Model.Archive.Year.HasValue) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\n            <div class=\"col blog-filter-header\">\n                <h1>Posts from ");
#nullable restore
#line 37 "C:\Users\hirok\Codes\cs8.0-and-.netcore3.0\PracticingApps\NorthwindCms\Views\Cms\Archive.cshtml"
                          Write(MonthName());

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 37 "C:\Users\hirok\Codes\cs8.0-and-.netcore3.0\PracticingApps\NorthwindCms\Views\Cms\Archive.cshtml"
                                       Write(Model.Archive.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n            </div>\n        </div>\n");
#nullable restore
#line 40 "C:\Users\hirok\Codes\cs8.0-and-.netcore3.0\PracticingApps\NorthwindCms\Views\Cms\Archive.cshtml"
    } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\n            <div class=\"col blog-filter-header\">\n                <h1>Latest posts</h1>\n            </div>\n        </div>\n");
#nullable restore
#line 46 "C:\Users\hirok\Codes\cs8.0-and-.netcore3.0\PracticingApps\NorthwindCms\Views\Cms\Archive.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 48 "C:\Users\hirok\Codes\cs8.0-and-.netcore3.0\PracticingApps\NorthwindCms\Views\Cms\Archive.cshtml"
     foreach (var post in Model.Archive.Posts)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <article>\n            <header>\n");
#nullable restore
#line 52 "C:\Users\hirok\Codes\cs8.0-and-.netcore3.0\PracticingApps\NorthwindCms\Views\Cms\Archive.cshtml"
                 if (post.Regions.Hero.PrimaryImage.HasValue)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 1712, "\"", 1734, 1);
#nullable restore
#line 54 "C:\Users\hirok\Codes\cs8.0-and-.netcore3.0\PracticingApps\NorthwindCms\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 1719, post.Permalink, 1719, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 1740, "\"", 1819, 1);
#nullable restore
#line 54 "C:\Users\hirok\Codes\cs8.0-and-.netcore3.0\PracticingApps\NorthwindCms\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 1746, Url.Content(post.Regions.Hero.PrimaryImage.Resize(WebApp.Api, 930, 360)), 1746, 73, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></a>\n");
#nullable restore
#line 55 "C:\Users\hirok\Codes\cs8.0-and-.netcore3.0\PracticingApps\NorthwindCms\Views\Cms\Archive.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h2><a");
            BeginWriteAttribute("href", " href=\"", 1866, "\"", 1888, 1);
#nullable restore
#line 56 "C:\Users\hirok\Codes\cs8.0-and-.netcore3.0\PracticingApps\NorthwindCms\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 1873, post.Permalink, 1873, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 56 "C:\Users\hirok\Codes\cs8.0-and-.netcore3.0\PracticingApps\NorthwindCms\Views\Cms\Archive.cshtml"
                                         Write(post.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h2>\n                <p class=\"post-meta\">\n                    <strong>In</strong> <a");
            BeginWriteAttribute("href", " href=\"", 1991, "\"", 2043, 3);
#nullable restore
#line 58 "C:\Users\hirok\Codes\cs8.0-and-.netcore3.0\PracticingApps\NorthwindCms\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 1998, Model.Permalink, 1998, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2014, "/category/", 2014, 10, true);
#nullable restore
#line 58 "C:\Users\hirok\Codes\cs8.0-and-.netcore3.0\PracticingApps\NorthwindCms\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 2024, post.Category.Slug, 2024, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 58 "C:\Users\hirok\Codes\cs8.0-and-.netcore3.0\PracticingApps\NorthwindCms\Views\Cms\Archive.cshtml"
                                                                                           Write(post.Category.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                    <span class=\"sep\">&#9670;</span>\n                    <strong>Tags</strong>\n");
#nullable restore
#line 61 "C:\Users\hirok\Codes\cs8.0-and-.netcore3.0\PracticingApps\NorthwindCms\Views\Cms\Archive.cshtml"
                     foreach (var tag in post.Tags)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"tag\"><a");
            BeginWriteAttribute("href", " href=\"", 2283, "\"", 2320, 3);
#nullable restore
#line 63 "C:\Users\hirok\Codes\cs8.0-and-.netcore3.0\PracticingApps\NorthwindCms\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 2290, Model.Permalink, 2290, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2306, "/tag/", 2306, 5, true);
#nullable restore
#line 63 "C:\Users\hirok\Codes\cs8.0-and-.netcore3.0\PracticingApps\NorthwindCms\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 2311, tag.Slug, 2311, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">#");
#nullable restore
#line 63 "C:\Users\hirok\Codes\cs8.0-and-.netcore3.0\PracticingApps\NorthwindCms\Views\Cms\Archive.cshtml"
                                                                               Write(tag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></span>\n");
#nullable restore
#line 64 "C:\Users\hirok\Codes\cs8.0-and-.netcore3.0\PracticingApps\NorthwindCms\Views\Cms\Archive.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"sep\">&#9670;</span>\n                    <strong>Published</strong>\n                    ");
#nullable restore
#line 67 "C:\Users\hirok\Codes\cs8.0-and-.netcore3.0\PracticingApps\NorthwindCms\Views\Cms\Archive.cshtml"
               Write(post.Published.Value.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </p>\n            </header>\n            <div class=\"ingress\">\n                ");
#nullable restore
#line 71 "C:\Users\hirok\Codes\cs8.0-and-.netcore3.0\PracticingApps\NorthwindCms\Views\Cms\Archive.cshtml"
           Write(Html.Raw(post.Regions.Hero.Ingress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n            <p><a class=\"btn btn-link\"");
            BeginWriteAttribute("href", " href=\"", 2719, "\"", 2741, 1);
#nullable restore
#line 73 "C:\Users\hirok\Codes\cs8.0-and-.netcore3.0\PracticingApps\NorthwindCms\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 2726, post.Permalink, 2726, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Read more</a></p>\n        </article>\n");
#nullable restore
#line 75 "C:\Users\hirok\Codes\cs8.0-and-.netcore3.0\PracticingApps\NorthwindCms\Views\Cms\Archive.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "C:\Users\hirok\Codes\cs8.0-and-.netcore3.0\PracticingApps\NorthwindCms\Views\Cms\Archive.cshtml"
     if (Model.Archive.TotalPages > 1) {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""row"">
            <div class=""col"">
                <nav aria-label=""Page navigation example"">
                <ul class=""pagination justify-content-center"">
                    <li class=""page-item"">
                        <a class=""page-link""");
            BeginWriteAttribute("href", " href=\"", 3092, "\"", 3117, 2);
#nullable restore
#line 82 "C:\Users\hirok\Codes\cs8.0-and-.netcore3.0\PracticingApps\NorthwindCms\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 3099, BlogLink(), 3099, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3110, "/page/1", 3110, 7, true);
            EndWriteAttribute();
            WriteLiteral(@">
                            <span aria-hidden=""true"">&laquo;</span>
                            <span class=""sr-only"">Previous</span>
                        </a>
                    </li>
                    <li class=""page-item"">
                        <a class=""page-link""");
            BeginWriteAttribute("href", " href=\"", 3396, "\"", 3463, 3);
#nullable restore
#line 88 "C:\Users\hirok\Codes\cs8.0-and-.netcore3.0\PracticingApps\NorthwindCms\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 3403, BlogLink(), 3403, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3414, "/page/", 3414, 6, true);
#nullable restore
#line 88 "C:\Users\hirok\Codes\cs8.0-and-.netcore3.0\PracticingApps\NorthwindCms\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 3420, Math.Max(1, Model.Archive.CurrentPage - 1), 3420, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                            <span aria-hidden=\"true\">&lsaquo;</span>\n                            <span class=\"sr-only\">Previous</span>\n                        </a>\n                    </li>\n");
#nullable restore
#line 93 "C:\Users\hirok\Codes\cs8.0-and-.netcore3.0\PracticingApps\NorthwindCms\Views\Cms\Archive.cshtml"
                     for (var n = 1; n <= Model.Archive.TotalPages; n++) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li");
            BeginWriteAttribute("class", " class=\"", 3758, "\"", 3825, 2);
            WriteAttributeValue("", 3766, "page-item", 3766, 9, true);
#nullable restore
#line 94 "C:\Users\hirok\Codes\cs8.0-and-.netcore3.0\PracticingApps\NorthwindCms\Views\Cms\Archive.cshtml"
WriteAttributeValue(" ", 3775, Model.Archive.CurrentPage == n ? "active" : "", 3776, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 3847, "\"", 3873, 3);
#nullable restore
#line 94 "C:\Users\hirok\Codes\cs8.0-and-.netcore3.0\PracticingApps\NorthwindCms\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 3854, BlogLink(), 3854, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3865, "/page/", 3865, 6, true);
#nullable restore
#line 94 "C:\Users\hirok\Codes\cs8.0-and-.netcore3.0\PracticingApps\NorthwindCms\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 3871, n, 3871, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 94 "C:\Users\hirok\Codes\cs8.0-and-.netcore3.0\PracticingApps\NorthwindCms\Views\Cms\Archive.cshtml"
                                                                                                                                           Write(n);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\n");
#nullable restore
#line 95 "C:\Users\hirok\Codes\cs8.0-and-.netcore3.0\PracticingApps\NorthwindCms\Views\Cms\Archive.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"page-item\">\n                        <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 3996, "\"", 4086, 3);
#nullable restore
#line 97 "C:\Users\hirok\Codes\cs8.0-and-.netcore3.0\PracticingApps\NorthwindCms\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 4003, BlogLink(), 4003, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4014, "/page/", 4014, 6, true);
#nullable restore
#line 97 "C:\Users\hirok\Codes\cs8.0-and-.netcore3.0\PracticingApps\NorthwindCms\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 4020, Math.Min(Model.Archive.TotalPages, Model.Archive.CurrentPage + 1), 4020, 66, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            <span aria-hidden=""true"">&rsaquo;</span>
                            <span class=""sr-only"">Next</span>
                        </a>
                    </li>
                    <li class=""page-item"">
                        <a class=""page-link""");
            BeginWriteAttribute("href", " href=\"", 4362, "\"", 4411, 3);
#nullable restore
#line 103 "C:\Users\hirok\Codes\cs8.0-and-.netcore3.0\PracticingApps\NorthwindCms\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 4369, BlogLink(), 4369, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4380, "/page/", 4380, 6, true);
#nullable restore
#line 103 "C:\Users\hirok\Codes\cs8.0-and-.netcore3.0\PracticingApps\NorthwindCms\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 4386, Model.Archive.TotalPages, 4386, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            <span aria-hidden=""true"">&raquo;</span>
                            <span class=""sr-only"">Next</span>
                        </a>
                    </li>
                </ul>
                </nav>
            </div>
        </div>
");
#nullable restore
#line 112 "C:\Users\hirok\Codes\cs8.0-and-.netcore3.0\PracticingApps\NorthwindCms\Views\Cms\Archive.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Piranha.AspNetCore.Services.IApplicationService WebApp { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NorthwindCms.Models.BlogArchive> Html { get; private set; }
    }
}
#pragma warning restore 1591
