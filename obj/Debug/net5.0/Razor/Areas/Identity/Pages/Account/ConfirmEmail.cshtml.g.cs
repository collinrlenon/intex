#pragma checksum "/Users/collinrlenon/Projects/intex/Areas/Identity/Pages/Account/ConfirmEmail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8493d7fb66e7ef16242a55ce30754ca5f24d0236"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_ConfirmEmail), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/ConfirmEmail.cshtml")]
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
#line 1 "/Users/collinrlenon/Projects/intex/Areas/Identity/Pages/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/collinrlenon/Projects/intex/Areas/Identity/Pages/_ViewImports.cshtml"
using OperationDigger.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/collinrlenon/Projects/intex/Areas/Identity/Pages/_ViewImports.cshtml"
using OperationDigger.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/collinrlenon/Projects/intex/Areas/Identity/Pages/_ViewImports.cshtml"
using OperationDigger.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/collinrlenon/Projects/intex/Areas/Identity/Pages/Account/_ViewImports.cshtml"
using OperationDigger.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8493d7fb66e7ef16242a55ce30754ca5f24d0236", @"/Areas/Identity/Pages/Account/ConfirmEmail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e6c86766e10e6785ef4fa61dc2a634e16563d0d", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27930d19b1d3e4ffcacf61bda1d118606de364e8", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_ConfirmEmail : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/collinrlenon/Projects/intex/Areas/Identity/Pages/Account/ConfirmEmail.cshtml"
  
    ViewData["Title"] = "Confirm email";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""heading-section section section-on-bg"">
    <div class=""hero-wrapper"">
        <div class=""list-hero-holder""></div>
        <div class=""hero-mask-gradient""></div>
    </div><!--//hero-wrapper-->
    <div class=""container heading-content"">
        <h2 class=""headline"">");
#nullable restore
#line 12 "/Users/collinrlenon/Projects/intex/Areas/Identity/Pages/Account/ConfirmEmail.cshtml"
                        Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n        <div class=\"meta\">See details below</div>\n    </div><!--//container-->\n</section><!--//heading-section-->\n<h1>");
#nullable restore
#line 16 "/Users/collinrlenon/Projects/intex/Areas/Identity/Pages/Account/ConfirmEmail.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConfirmEmailModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ConfirmEmailModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ConfirmEmailModel>)PageContext?.ViewData;
        public ConfirmEmailModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
