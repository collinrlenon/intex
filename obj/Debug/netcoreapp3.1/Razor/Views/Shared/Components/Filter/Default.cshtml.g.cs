#pragma checksum "/Users/haydenthomas/Projects/intex/Views/Shared/Components/Filter/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddafd89a07243ba3952ad6abf26165a816e94bd4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Filter_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Filter/Default.cshtml")]
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
#line 1 "/Users/haydenthomas/Projects/intex/Views/_ViewImports.cshtml"
using OperationDigger;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/haydenthomas/Projects/intex/Views/_ViewImports.cshtml"
using OperationDigger.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/haydenthomas/Projects/intex/Views/_ViewImports.cshtml"
using OperationDigger.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/haydenthomas/Projects/intex/Views/_ViewImports.cshtml"
using OperationDigger.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddafd89a07243ba3952ad6abf26165a816e94bd4", @"/Views/Shared/Components/Filter/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13d35c1a2e3b8b05cdcb1063df531c55390f9572", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Filter_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Burial>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n");
            WriteLiteral(@"
<ul class=""nav nav-pills"">
    <li class=""nav-item dropdown"">
        <a class=""nav-link dropdown-toggle"" data-toggle=""dropdown"" href=""#"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">Burials</a>
    <li class=""dropdown-submenu"">
        <a class=""test"" tabindex=""-1"" href=""#"">Age Code <span class=""caret""></span></a>
        <ul>
");
#nullable restore
#line 22 "/Users/haydenthomas/Projects/intex/Views/Shared/Components/Filter/Default.cshtml"
                 foreach (var x in Model.Select(x => x.AgeCode).Distinct())
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button class=\"dropdown-item\" type=\"button\">");
#nullable restore
#line 24 "/Users/haydenthomas/Projects/intex/Views/Shared/Components/Filter/Default.cshtml"
                                                           Write(x);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\n");
#nullable restore
#line 25 "/Users/haydenthomas/Projects/intex/Views/Shared/Components/Filter/Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            
        </ul>
    </li>
    <li class=""nav-item dropdown"">
        <a class=""nav-link dropdown-toggle"" data-toggle=""dropdown"" href=""#"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">Cranial</a>
        <ul>
            <div class=""dropdown-menu"">
                <a class=""dropdown-item"" href=""#"">Action</a>
                <a class=""dropdown-item"" href=""#"">Another action</a>
                <a class=""dropdown-item"" href=""#"">Something else here</a>
            </div>
        </ul>
    </li>
</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Burial>> Html { get; private set; }
    }
}
#pragma warning restore 1591
