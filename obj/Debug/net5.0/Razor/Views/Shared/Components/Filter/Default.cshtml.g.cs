#pragma checksum "C:\Users\hayde\Source\Repos\collinrlenon\intex\Views\Shared\Components\Filter\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a32e42bb25700de3a9acc0c3a0ab433de9b86593"
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
#line 1 "C:\Users\hayde\Source\Repos\collinrlenon\intex\Views\_ViewImports.cshtml"
using OperationDigger;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hayde\Source\Repos\collinrlenon\intex\Views\_ViewImports.cshtml"
using OperationDigger.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hayde\Source\Repos\collinrlenon\intex\Views\_ViewImports.cshtml"
using OperationDigger.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hayde\Source\Repos\collinrlenon\intex\Views\_ViewImports.cshtml"
using OperationDigger.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a32e42bb25700de3a9acc0c3a0ab433de9b86593", @"/Views/Shared/Components/Filter/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c434166eff85864aa69b36ac472c98333321b85", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Filter_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Burial>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BurialList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<br />
<div id=""accordion"">
    <div class=""card"">
        <div class=""card-header"" id=""headingOne"">
            <h5 class=""mb-0"">
                <button class=""btn btn-link btn-lg"" data-toggle=""collapse"" data-target=""#collapseOne"" aria-expanded=""false"" aria-controls=""collapseOne"">
                    Filter
                </button>
            </h5>
        </div>

        <div id=""collapseOne"" class=""collapse"" aria-labelledby=""headingOne"" data-parent=""#accordion"">
            <div class=""card-body"">
");
#nullable restore
#line 16 "C:\Users\hayde\Source\Repos\collinrlenon\intex\Views\Shared\Components\Filter\Default.cshtml"
                 using (Html.BeginForm("BurialList", "Home", FormMethod.Get))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"row\">\r\n                        <div class=\"col-2\">\r\n                            <text>Gender</text>");
#nullable restore
#line 20 "C:\Users\hayde\Source\Repos\collinrlenon\intex\Views\Shared\Components\Filter\Default.cshtml"
                                          Write(Html.DropDownList("gender", new SelectList(ViewBag.Gender), "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <text>Hair Color:</text>");
#nullable restore
#line 21 "C:\Users\hayde\Source\Repos\collinrlenon\intex\Views\Shared\Components\Filter\Default.cshtml"
                                               Write(Html.DropDownList("hairColor", new SelectList(ViewBag.HairColor), "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <text>Year Excavated:</text>");
#nullable restore
#line 22 "C:\Users\hayde\Source\Repos\collinrlenon\intex\Views\Shared\Components\Filter\Default.cshtml"
                                                   Write(Html.DropDownList("yearExc", new SelectList(ViewBag.YearExc), "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <text>Month Excavated:</text>");
#nullable restore
#line 23 "C:\Users\hayde\Source\Repos\collinrlenon\intex\Views\Shared\Components\Filter\Default.cshtml"
                                                    Write(Html.DropDownList("monthExc", new SelectList(ViewBag.MonthExc), "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-2\">\r\n                            <text>Head Direction:</text>");
#nullable restore
#line 26 "C:\Users\hayde\Source\Repos\collinrlenon\intex\Views\Shared\Components\Filter\Default.cshtml"
                                                   Write(Html.DropDownList("headDir", new SelectList(ViewBag.HeadDir), "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <text>Field Book:</text>");
#nullable restore
#line 27 "C:\Users\hayde\Source\Repos\collinrlenon\intex\Views\Shared\Components\Filter\Default.cshtml"
                                               Write(Html.DropDownList("fieldBook", new SelectList(ViewBag.FieldBook), "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <text>BYU Sample:</text>");
#nullable restore
#line 28 "C:\Users\hayde\Source\Repos\collinrlenon\intex\Views\Shared\Components\Filter\Default.cshtml"
                                               Write(Html.DropDownList("byuSamp", new SelectList(ViewBag.ByuSample), "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <text>Skull Magazine:</text>");
#nullable restore
#line 29 "C:\Users\hayde\Source\Repos\collinrlenon\intex\Views\Shared\Components\Filter\Default.cshtml"
                                                   Write(Html.DropDownList("skullMag", new SelectList(ViewBag.SkullMag), "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-2\">\r\n                            <text>Sex Determined by Skull:</text>");
#nullable restore
#line 32 "C:\Users\hayde\Source\Repos\collinrlenon\intex\Views\Shared\Components\Filter\Default.cshtml"
                                                            Write(Html.DropDownList("sexSkull", new SelectList(ViewBag.SexSkull), "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <text>Age Determined by Skull:</text>");
#nullable restore
#line 33 "C:\Users\hayde\Source\Repos\collinrlenon\intex\Views\Shared\Components\Filter\Default.cshtml"
                                                            Write(Html.DropDownList("ageSkull", new SelectList(ViewBag.AgeSkull), "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <text>West to Head:</text>");
#nullable restore
#line 34 "C:\Users\hayde\Source\Repos\collinrlenon\intex\Views\Shared\Components\Filter\Default.cshtml"
                                                 Write(Html.DropDownList("wtHead", new SelectList(ViewBag.WtHead), "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <text>West to Feet:</text>");
#nullable restore
#line 35 "C:\Users\hayde\Source\Repos\collinrlenon\intex\Views\Shared\Components\Filter\Default.cshtml"
                                                 Write(Html.DropDownList("wtFeet", new SelectList(ViewBag.WtFeet), "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-2\">\r\n                            <text>Burial Preservation:</text>");
#nullable restore
#line 38 "C:\Users\hayde\Source\Repos\collinrlenon\intex\Views\Shared\Components\Filter\Default.cshtml"
                                                        Write(Html.DropDownList("burialPres", new SelectList(ViewBag.BurialPres), "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <text>Burial Wrapping:</text>");
#nullable restore
#line 39 "C:\Users\hayde\Source\Repos\collinrlenon\intex\Views\Shared\Components\Filter\Default.cshtml"
                                                    Write(Html.DropDownList("burialWrap", new SelectList(ViewBag.BurialWrap), "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <text>Face Bundle:</text>");
#nullable restore
#line 40 "C:\Users\hayde\Source\Repos\collinrlenon\intex\Views\Shared\Components\Filter\Default.cshtml"
                                                Write(Html.DropDownList("faceBundle", new SelectList(ViewBag.FaceBundle), "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <text>Age Code:</text>");
#nullable restore
#line 41 "C:\Users\hayde\Source\Repos\collinrlenon\intex\Views\Shared\Components\Filter\Default.cshtml"
                                             Write(Html.DropDownList("ageCode", new SelectList(ViewBag.AgeCode), "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-2\">\r\n                            <text>Burial Depth:</text>");
#nullable restore
#line 44 "C:\Users\hayde\Source\Repos\collinrlenon\intex\Views\Shared\Components\Filter\Default.cshtml"
                                                 Write(Html.DropDownList("burDepth", new SelectList(ViewBag.BurDepth), "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <text>Length:</text>");
#nullable restore
#line 45 "C:\Users\hayde\Source\Repos\collinrlenon\intex\Views\Shared\Components\Filter\Default.cshtml"
                                           Write(Html.DropDownList("Length", new SelectList(ViewBag.Length), "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <text>Gender Determination Method:</text>");
#nullable restore
#line 46 "C:\Users\hayde\Source\Repos\collinrlenon\intex\Views\Shared\Components\Filter\Default.cshtml"
                                                                Write(Html.DropDownList("gendMeth", new SelectList(ViewBag.GendMeth), "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-2\">\r\n                            <text>South to Head:</text>");
#nullable restore
#line 49 "C:\Users\hayde\Source\Repos\collinrlenon\intex\Views\Shared\Components\Filter\Default.cshtml"
                                                  Write(Html.DropDownList("stHead", new SelectList(ViewBag.StHead), "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <text>South to Feet:</text>");
#nullable restore
#line 50 "C:\Users\hayde\Source\Repos\collinrlenon\intex\Views\Shared\Components\Filter\Default.cshtml"
                                                  Write(Html.DropDownList("stFeet", new SelectList(ViewBag.StFeet), "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <text>Gender Giles/Elliott Function:</text>");
#nullable restore
#line 51 "C:\Users\hayde\Source\Repos\collinrlenon\intex\Views\Shared\Components\Filter\Default.cshtml"
                                                                  Write(Html.DropDownList("genGe", new SelectList(ViewBag.GenGe), "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <br />\r\n                    <input type=\"submit\" value=\"Filter\" class=\"btn btn-primary\" />\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a32e42bb25700de3a9acc0c3a0ab433de9b8659315449", async() => {
                WriteLiteral("Clear");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 57 "C:\Users\hayde\Source\Repos\collinrlenon\intex\Views\Shared\Components\Filter\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
    <div class=""card"">
        <div class=""card-header"" id=""headingTwo"">
            <h5 class=""mb-0"">
                <button class=""btn btn-link btn-lg collapsed"" data-toggle=""collapse"" data-target=""#collapseTwo"" aria-expanded=""false"" aria-controls=""collapseTwo"">
                    Search
                </button>
            </h5>
        </div>
        <div id=""collapseTwo"" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordion"">
            <div class=""card-body"">
");
#nullable restore
#line 71 "C:\Users\hayde\Source\Repos\collinrlenon\intex\Views\Shared\Components\Filter\Default.cshtml"
                 using (Html.BeginForm("BurialList", "Home", new { pageNum = 1 }, FormMethod.Get))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"row\">\r\n                        <div class=\"form-group\">\r\n                            ");
#nullable restore
#line 75 "C:\Users\hayde\Source\Repos\collinrlenon\intex\Views\Shared\Components\Filter\Default.cshtml"
                       Write(Html.TextBox("searchBox", "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <button class=\"btn btn-fill btn-md btn-success\" type=\"submit\">Search</button>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a32e42bb25700de3a9acc0c3a0ab433de9b8659318940", async() => {
                WriteLiteral("Clear");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 80 "C:\Users\hayde\Source\Repos\collinrlenon\intex\Views\Shared\Components\Filter\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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