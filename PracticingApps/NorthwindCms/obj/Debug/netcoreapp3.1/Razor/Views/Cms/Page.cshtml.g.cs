#pragma checksum "C:\Users\hirok\Codes\cs8.0-and-.netcore3.0\PracticingApps\NorthwindCms\Views\Cms\Page.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b11993e2e9a3f9602eb06bf7efce2c290915bca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cms_Page), @"mvc.1.0.view", @"/Views/Cms/Page.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b11993e2e9a3f9602eb06bf7efce2c290915bca", @"/Views/Cms/Page.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca5b93007b6e082af5cc813bafde1a14cdc102f6", @"/Views/_ViewImports.cshtml")]
    public class Views_Cms_Page : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NorthwindCms.Models.StandardPage>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\hirok\Codes\cs8.0-and-.netcore3.0\PracticingApps\NorthwindCms\Views\Cms\Page.cshtml"
  
    ViewBag.Title = Model.Title;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <h1>");
#nullable restore
#line 7 "C:\Users\hirok\Codes\cs8.0-and-.netcore3.0\PracticingApps\NorthwindCms\Views\Cms\Page.cshtml"
   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n    ");
#nullable restore
#line 9 "C:\Users\hirok\Codes\cs8.0-and-.netcore3.0\PracticingApps\NorthwindCms\Views\Cms\Page.cshtml"
Write(Html.DisplayFor(m => m.Blocks));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NorthwindCms.Models.StandardPage> Html { get; private set; }
    }
}
#pragma warning restore 1591