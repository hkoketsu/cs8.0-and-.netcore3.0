#pragma checksum "C:\Users\hirok\Codes\cs8.0-and-.netcore3.0\PracticingApps\NorthwindCms\Views\Cms\DisplayTemplates\QuoteBlock.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f000e24f75efbba7ef38a95cb40c0e6e4c830fcf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cms_DisplayTemplates_QuoteBlock), @"mvc.1.0.view", @"/Views/Cms/DisplayTemplates/QuoteBlock.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f000e24f75efbba7ef38a95cb40c0e6e4c830fcf", @"/Views/Cms/DisplayTemplates/QuoteBlock.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca5b93007b6e082af5cc813bafde1a14cdc102f6", @"/Views/_ViewImports.cshtml")]
    public class Views_Cms_DisplayTemplates_QuoteBlock : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Piranha.Extend.Blocks.QuoteBlock>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<blockquote>\n    ");
#nullable restore
#line 4 "C:\Users\hirok\Codes\cs8.0-and-.netcore3.0\PracticingApps\NorthwindCms\Views\Cms\DisplayTemplates\QuoteBlock.cshtml"
Write(Html.Raw(Model.Body));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</blockquote>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Piranha.Extend.Blocks.QuoteBlock> Html { get; private set; }
    }
}
#pragma warning restore 1591
