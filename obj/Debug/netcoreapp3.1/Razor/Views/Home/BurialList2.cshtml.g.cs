#pragma checksum "/Users/collinrlenon/Projects/intex/Views/Home/BurialList2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c95a385ab40f3378e7d41f447a0c9e9e764ccd8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_BurialList2), @"mvc.1.0.view", @"/Views/Home/BurialList2.cshtml")]
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
#line 1 "/Users/collinrlenon/Projects/intex/Views/_ViewImports.cshtml"
using OperationDigger;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/collinrlenon/Projects/intex/Views/_ViewImports.cshtml"
using OperationDigger.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/collinrlenon/Projects/intex/Views/_ViewImports.cshtml"
using OperationDigger.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/collinrlenon/Projects/intex/Views/_ViewImports.cshtml"
using OperationDigger.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c95a385ab40f3378e7d41f447a0c9e9e764ccd8", @"/Views/Home/BurialList2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13d35c1a2e3b8b05cdcb1063df531c55390f9572", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_BurialList2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BurialListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditBurial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BurialDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteBurial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class", "btn", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-normal", "btn-primary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-selected", "btn-warning", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-group pull-right m-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::OperationDigger.Infrastructure.PaginationTagHelper __OperationDigger_Infrastructure_PaginationTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/collinrlenon/Projects/intex/Views/Home/BurialList2.cshtml"
  
    ViewData["Title"] = "Burial List";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"mt-20\">\n    <h1>");
#nullable restore
#line 8 "/Users/collinrlenon/Projects/intex/Views/Home/BurialList2.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n    <p>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c95a385ab40f3378e7d41f447a0c9e9e764ccd86446", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </p>
    <table class=""table"">
        <thead>
            <tr>
                <th scope=""col"" class=""text-dark"">Burial ID</th>
                <th scope=""col"" class=""text-dark"">Location ID</th>
                <th scope=""col"" class=""text-dark"">South To Head</th>
                <th scope=""col"" class=""text-dark"">South To Feet</th>
                <th scope=""col"" class=""text-dark"">West to Head</th>
                <th scope=""col"" class=""text-dark"">West To Feet</th>
                <th scope=""col"" class=""text-dark"">Length</th>
                <th scope=""col"" class=""text-dark"">Burial Depth</th>
                <th scope=""col"" class=""text-dark"">Burial Goods</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 29 "/Users/collinrlenon/Projects/intex/Views/Home/BurialList2.cshtml"
             foreach (var b in Model.Burials)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td class=\"text-dark\">");
#nullable restore
#line 32 "/Users/collinrlenon/Projects/intex/Views/Home/BurialList2.cshtml"
                                     Write(b.BurialId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td class=\"text-dark\">");
#nullable restore
#line 33 "/Users/collinrlenon/Projects/intex/Views/Home/BurialList2.cshtml"
                                     Write(b.LocationId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td class=\"text-dark\">");
#nullable restore
#line 34 "/Users/collinrlenon/Projects/intex/Views/Home/BurialList2.cshtml"
                                     Write(b.SouthToHead);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td class=\"text-dark\">");
#nullable restore
#line 35 "/Users/collinrlenon/Projects/intex/Views/Home/BurialList2.cshtml"
                                     Write(b.SouthToFeet);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td class=\"text-dark\">");
#nullable restore
#line 36 "/Users/collinrlenon/Projects/intex/Views/Home/BurialList2.cshtml"
                                     Write(b.WestToHead);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td class=\"text-dark\">");
#nullable restore
#line 37 "/Users/collinrlenon/Projects/intex/Views/Home/BurialList2.cshtml"
                                     Write(b.WestToFeet);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td class=\"text-dark\">");
#nullable restore
#line 38 "/Users/collinrlenon/Projects/intex/Views/Home/BurialList2.cshtml"
                                     Write(b.Length);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td class=\"text-dark\">");
#nullable restore
#line 39 "/Users/collinrlenon/Projects/intex/Views/Home/BurialList2.cshtml"
                                     Write(b.BurialDepth);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td class=\"text-dark\">");
#nullable restore
#line 40 "/Users/collinrlenon/Projects/intex/Views/Home/BurialList2.cshtml"
                                     Write(b.AritifactFound2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c95a385ab40f3378e7d41f447a0c9e9e764ccd811189", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "/Users/collinrlenon/Projects/intex/Views/Home/BurialList2.cshtml"
                                                     WriteLiteral(b.BurialId);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" |\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c95a385ab40f3378e7d41f447a0c9e9e764ccd813332", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 43 "/Users/collinrlenon/Projects/intex/Views/Home/BurialList2.cshtml"
                                                        WriteLiteral(b.BurialId);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" |\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c95a385ab40f3378e7d41f447a0c9e9e764ccd815481", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "/Users/collinrlenon/Projects/intex/Views/Home/BurialList2.cshtml"
                                                       WriteLiteral(b.BurialId);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\n                    </td>\n                </tr>\n");
#nullable restore
#line 47 "/Users/collinrlenon/Projects/intex/Views/Home/BurialList2.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table>\n\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c95a385ab40f3378e7d41f447a0c9e9e764ccd817874", async() => {
                WriteLiteral("\n    ");
            }
            );
            __OperationDigger_Infrastructure_PaginationTagHelper = CreateTagHelper<global::OperationDigger.Infrastructure.PaginationTagHelper>();
            __tagHelperExecutionContext.Add(__OperationDigger_Infrastructure_PaginationTagHelper);
#nullable restore
#line 51 "/Users/collinrlenon/Projects/intex/Views/Home/BurialList2.cshtml"
__OperationDigger_Infrastructure_PaginationTagHelper.PageInfo = Model.PageNumbering;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-info", __OperationDigger_Infrastructure_PaginationTagHelper.PageInfo, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__OperationDigger_Infrastructure_PaginationTagHelper.KeyValuePairs == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("page-url-burialId", "OperationDigger.Infrastructure.PaginationTagHelper", "KeyValuePairs"));
            }
#nullable restore
#line 52 "/Users/collinrlenon/Projects/intex/Views/Home/BurialList2.cshtml"
__OperationDigger_Infrastructure_PaginationTagHelper.KeyValuePairs["burialId"] = Model.BurialId;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-url-burialId", __OperationDigger_Infrastructure_PaginationTagHelper.KeyValuePairs["burialId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 53 "/Users/collinrlenon/Projects/intex/Views/Home/BurialList2.cshtml"
__OperationDigger_Infrastructure_PaginationTagHelper.PageClassesEnabled = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-classes-enabled", __OperationDigger_Infrastructure_PaginationTagHelper.PageClassesEnabled, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __OperationDigger_Infrastructure_PaginationTagHelper.PageClass = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __OperationDigger_Infrastructure_PaginationTagHelper.PageClassNormal = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __OperationDigger_Infrastructure_PaginationTagHelper.PageClassSelected = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n</div>\n\n<script>\n    $(document).ready(function () {\n        $(\'.dropdown-submenu a.test\').on(\"click\", function (e) {\n            $(this).next(\'ul\').toggle();\n            e.stopPropagation();\n            e.preventDefault();\n        });\n    });\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BurialListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591