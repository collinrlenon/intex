#pragma checksum "/Users/collinrlenon/Desktop/GitHub/intex/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "162a59c14a76fba2c48f0d0c5f9e84d4ca0aea4e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/Users/collinrlenon/Desktop/GitHub/intex/Views/_ViewImports.cshtml"
using OperationDigger;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/collinrlenon/Desktop/GitHub/intex/Views/_ViewImports.cshtml"
using OperationDigger.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"162a59c14a76fba2c48f0d0c5f9e84d4ca0aea4e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbb910eb0ad56092f9ba39f6923a1468f7846348", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-cta btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Burial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/collinrlenon/Desktop/GitHub/intex/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<!DOCTYPE html>\n<html lang=\"en\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "162a59c14a76fba2c48f0d0c5f9e84d4ca0aea4e4161", async() => {
                WriteLiteral("\n    <title>Home</title>\n    <!-- Meta -->\n    <meta charset=\"utf-8\">\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 427, "\"", 437, 0);
                EndWriteAttribute();
                WriteLiteral(">\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 463, "\"", 473, 0);
                EndWriteAttribute();
                WriteLiteral(@">
    <link rel=""shortcut icon"" href=""favicon.ico"">
    <link href='https://fonts.googleapis.com/css?family=Roboto:400,300,500,300italic,400italic,500italic,700,700italic' rel='stylesheet' type='text/css'>
    <link href='https://fonts.googleapis.com/css?family=Noto+Sans:400,400italic,700,700italic' rel='stylesheet' type='text/css'>
    <!-- FontAwesome JS -->
    <script defer src=""assets/fontawesome/js/all.js""></script>
    <!-- Global CSS -->
    <link rel=""stylesheet"" href=""assets/plugins/bootstrap/css/bootstrap.min.css"">
    <!-- Plugins CSS -->
    <link rel=""stylesheet"" href=""https://fonts.googleapis.com/icon?family=Material+Icons"">

    <!-- Theme CSS -->
    <link id=""theme-style"" rel=""stylesheet"" href=""assets/css/theme-1.css"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "162a59c14a76fba2c48f0d0c5f9e84d4ca0aea4e6460", async() => {
                WriteLiteral(@"
    <section class=""promo-section section section-on-bg"">
        <div class=""hero-slider-wrapper"">
            <div id=""hero-carousel"" class=""hero-carousel carousel slide carousel-fade"" data-ride=""carousel"" data-interval=""5000"">
                <div class=""carousel-inner"">
                    <div class=""carousel-item active slide slide-1""></div>
                    <div class=""carousel-item slide slide-2""></div>
                    <div class=""carousel-item slide slide-3""></div>
                </div>
            </div><!--//hero-carousel-->
            <div class=""hero-slider-mask""></div>
        </div><!--//hero-slider-wrapper-->
        <div class=""container promo-content"">
            <h2 class=""headline"">Fag el-Gamous Cemetery Database <br> BYU Egypt Excavation Project</h2>
            <p class=""tagline"">Good databasing is good research, check out our data!</p>
            <div class=""actions"">
                <!-- <a class=""btn btn-cta btn-primary"" href=""#"" data-bs-toggle=""modal"" data-bs-target=""#sig");
                WriteLiteral("nup\">Burial Summary List & Records</a>-->\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "162a59c14a76fba2c48f0d0c5f9e84d4ca0aea4e7868", async() => {
                    WriteLiteral("Burial Summary List & Records");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                <br class=\"d-sm-inline-block d-md-none\">\n                <a href=\"#\" class=\"video-play-trigger\" data-bs-toggle=\"modal\" data-bs-target=\"#modal-video\"><img class=\"play-icon\" src=\"assets/images/play-icon.svg\"");
                BeginWriteAttribute("alt", " alt=\"", 2628, "\"", 2634, 0);
                EndWriteAttribute();
                WriteLiteral(@">See mummification in action!</a>
            </div>
        </div><!--//container-->
    </section><!--//promo-section-->

    <div class=""sections-wrapper"">

        <section id=""overview-section"" class=""overview-section section"">
            <h2 class=""section-title"">
                Why We Research:
            </h2>
            <div class=""section-intro"">
                The purpose of this research is...
            </div><!--//section-intro-->
            <div class=""figures-wrapper"">
                <div class=""container text-center"">
                    <figure class=""macbook-screen""><img class=""img-fluid"" src=""assets/images/macbook-screen.png""");
                BeginWriteAttribute("alt", " alt=\"", 3296, "\"", 3302, 0);
                EndWriteAttribute();
                WriteLiteral("></figure>\n                    <figure class=\"ipad-screen\"><img class=\"img-fluid\" src=\"assets/images/ipad-screen.png\"");
                BeginWriteAttribute("alt", " alt=\"", 3420, "\"", 3426, 0);
                EndWriteAttribute();
                WriteLiteral("></figure>\n                    <figure class=\"iphone-screen\"><img class=\"img-fluid\" src=\"assets/images/iphone-screen.png\"");
                BeginWriteAttribute("alt", " alt=\"", 3548, "\"", 3554, 0);
                EndWriteAttribute();
                WriteLiteral("></figure>\n                    <a href=\"#\" class=\"play-icon video-play-trigger\" data-bs-toggle=\"modal\" data-bs-target=\"#modal-video\"><img src=\"assets/images/play-icon-md.svg\"");
                BeginWriteAttribute("alt", " alt=\"", 3729, "\"", 3735, 0);
                EndWriteAttribute();
                WriteLiteral(@"></a>
                </div><!--//container-->
            </div><!--//figures-wrapper-->
            <div class=""benefits-wrapper"">
                <div class=""container text-center"">
                    <div class=""row"">
                        <div class=""item col-12 col-md-4"">
                            <div class=""item-inner"">
                                <img class=""item-icon"" src=""assets/images/icons/clock-white.svg""");
                BeginWriteAttribute("alt", " alt=\"", 4167, "\"", 4173, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                <h3 class=""item-title"">10X Faster Database Management</h3>
                                <div class=""item-desc"">
                                    Not having to write everything on a peice of paper has it's benefits.
                                </div>
                            </div><!--//item-inner-->
                        </div><!--//item-->
                        <div class=""item col-12 col-md-4"">
                            <div class=""item-inner"">
                                <img class=""item-icon"" src=""assets/images/icons/presenter-white.svg""");
                BeginWriteAttribute("alt", " alt=\"", 4778, "\"", 4784, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                <h3 class=""item-title"">Increase Productivity</h3>
                                <div class=""item-desc"">
                                    With better tools for understanding, creating, and managing research, comes better productivity.
                                </div>
                            </div><!--//item-inner-->
                        </div><!--//item-->
                        <div class=""item col-12 col-md-4"">
                            <div class=""item-inner"">
                                <img class=""item-icon"" src=""assets/images/icons/chat-white.svg""");
                BeginWriteAttribute("alt", " alt=\"", 5402, "\"", 5408, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                <h3 class=""item-title"">Better Collabration</h3>
                                <div class=""item-desc"">
                                    Better communication equals better research. And better research means a better learning experience.
                                </div>
                            </div><!--//item-inner-->
                        </div><!--//item-->
                    </div><!--//row-->
                </div><!--//container-->
            </div><!--//benefits-->
            <div class=""press-wrapper"">
                <div class=""container"">
                    <div class=""logos row"">
                        <div class=""logo col-6 col-md-3""><img class=""img-fluid"" src=""assets/images/logos/logo-1.svg"" alt=""BYU Logo""></div>
                        <div class=""logo col-6 col-md-3""><img class=""img-fluid"" src=""assets/images/logos/logo-2.svg"" alt=""BYU Marriott School Logo""></div>
                        <div class=""logo col-6 col-md-3""><img class=""img-fluid");
                WriteLiteral(@""" src=""assets/images/logos/logo-3.svg"" alt=""BYU Humanities""></div>
                    </div>
                </div><!--//container-->
            </div><!--//press-wrapper-->
        </section><!--//overview-section-->

        <section id=""features-section"" class=""features-section section"">
            <h2 class=""section-title"">
                Key Features
            </h2>
            <div class=""container"">
                <div class=""row"">
                    <div class=""features-content-wrapper col-12 col-md-7 com-lg-7"">
                        <div class=""intro"">
                            Our database offers many great things for BYU researchers whether it be for collecting data on mummies or any other endeavour.
                        </div><!--//intro-->
                        <ul class=""feature-list list-unstyled"">
                            <li><img class=""tick-icon"" src=""assets/images/tick.svg""");
                BeginWriteAttribute("alt", " alt=\"", 7358, "\"", 7364, 0);
                EndWriteAttribute();
                WriteLiteral("> Feature one lorem ipsum dolor sit amet.</li>\n                            <li><img class=\"tick-icon\" src=\"assets/images/tick.svg\"");
                BeginWriteAttribute("alt", " alt=\"", 7495, "\"", 7501, 0);
                EndWriteAttribute();
                WriteLiteral("> Feature two lorem ipsum dolor sit amet.</li>\n                            <li><img class=\"tick-icon\" src=\"assets/images/tick.svg\"");
                BeginWriteAttribute("alt", " alt=\"", 7632, "\"", 7638, 0);
                EndWriteAttribute();
                WriteLiteral("> Feature three lorem ipsum dolor sit amet.</li>\n                            <li><img class=\"tick-icon\" src=\"assets/images/tick.svg\"");
                BeginWriteAttribute("alt", " alt=\"", 7771, "\"", 7777, 0);
                EndWriteAttribute();
                WriteLiteral("> Feature four lorem ipsum dolor sit amet.</li>\n                            <li><img class=\"tick-icon\" src=\"assets/images/tick.svg\"");
                BeginWriteAttribute("alt", " alt=\"", 7909, "\"", 7915, 0);
                EndWriteAttribute();
                WriteLiteral("> Feature five lorem ipsum dolor sit amet.</li>\n                            <li><img class=\"tick-icon\" src=\"assets/images/tick.svg\"");
                BeginWriteAttribute("alt", " alt=\"", 8047, "\"", 8053, 0);
                EndWriteAttribute();
                WriteLiteral(@"> Feature six lorem ipsum dolor sit amet.</li>
                        </ul><!--//feature-list-->

                        <div id=""reviews-carousel"" class=""reviews-carousel carousel slide"" data-ride=""carousel"">
                            <!--//wrapper for slides -->
                            <div class=""carousel-inner"" role=""listbox"">
                                <div class=""carousel-item item active"">
                                    <blockquote class=""review center-block"">
                                        <i class=""fas fa-quote-left""></i>
                                        <p>A great way to Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.</p>
                                    </blockquote><!--//review-->
                                    <div class=""source"">
                                        <div class=""rating"">
                       ");
                WriteLiteral(@"                     <i class=""fas fa-star""></i>
                                            <i class=""fas fa-star""></i>
                                            <i class=""fas fa-star""></i>
                                            <i class=""fas fa-star""></i>
                                            <i class=""fas fa-star""></i>
                                        </div><!--//rating-->
                                        <img class=""profile"" src=""assets/images/users/user-1.png""");
                BeginWriteAttribute("alt", " alt=\"", 9574, "\"", 9580, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                                        <div class=""name"">Theresa Wood, Product Hunt</div>
                                    </div><!--//source-->
                                </div><!--//item-->

                                <div class=""carousel-item item"">
                                    <blockquote class=""review center-block"">
                                        <i class=""fas fa-quote-left""></i>
                                        <p>A great way to Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.</p>
                                    </blockquote><!--//review-->
                                    <div class=""source"">
                                        <div class=""rating"">
                                            <i class=""fas fa-star""></i>
                                            <i class=""fas fa-star""></i>
                     ");
                WriteLiteral(@"                       <i class=""fas fa-star""></i>
                                            <i class=""fas fa-star""></i>
                                            <i class=""fas fa-star""></i>
                                        </div><!--//rating-->
                                        <img class=""profile"" src=""assets/images/users/user-2.png""");
                BeginWriteAttribute("alt", " alt=\"", 10959, "\"", 10965, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                                        <div class=""name"">Rob Kim, Mashable</div>
                                    </div><!--//source-->
                                </div><!--//item-->

                                <div class=""carousel-item item"">
                                    <blockquote class=""review center-block"">
                                        <i class=""fas fa-quote-left""></i>
                                        <p>A great way to Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.</p>
                                    </blockquote><!--//review-->
                                    <div class=""source"">
                                        <div class=""rating"">
                                            <i class=""fas fa-star""></i>
                                            <i class=""fas fa-star""></i>
                              ");
                WriteLiteral(@"              <i class=""fas fa-star""></i>
                                            <i class=""fas fa-star""></i>
                                            <i class=""fas fa-star""></i>
                                        </div><!--//rating-->
                                        <img class=""profile"" src=""assets/images/users/user-3.png""");
                BeginWriteAttribute("alt", " alt=\"", 12335, "\"", 12341, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                                        <div class=""name"">Kevin Howell, Wired</div>
                                    </div><!--//source-->
                                </div><!--//item-->

                            </div><!--//carousel-inner-->
                            <!--//Indicators-->
                            <ol class=""carousel-indicators"">
                                <li data-bs-target=""#reviews-carousel"" data-bs-slide-to=""0"" class=""active""></li>
                                <li data-bs-target=""#reviews-carousel"" data-bs-slide-to=""1""></li>
                                <li data-bs-target=""#reviews-carousel"" data-bs-slide-to=""2""></li>
                            </ol>

                        </div><!--//reviews-carousel-->
                    </div><!--//features-content-wrapper-->
                </div><!--//row-->
            </div><!--//container-->

            <div class=""features-figure-wrapper"">
                <img class=""img-fluid"" src=""assets/images/imac-screen.png""");
                BeginWriteAttribute("alt", " alt=\"", 13365, "\"", 13371, 0);
                EndWriteAttribute();
                WriteLiteral(@">
            </div><!--//features-figure-wrapper-->

            <div class=""action-wrapper text-center"">
                <a href=""features.html"" class=""btn btn-secondary"">View all features</a>
            </div>

        </section><!--//features-section-->


        <section id=""support-section"" class=""support-section section text-center"">
            <h2 class=""section-title"">24/7 Customer Support</h2>
            <div class=""section-intro"">Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes</div>
            <a class=""btn btn-secondary"" href=""support.html"">Our Support Center</a>
            <div class=""team-figure"">
                <img class=""img-fluid support-team"" src=""assets/images/team.png""");
                BeginWriteAttribute("alt", " alt=\"", 14195, "\"", 14201, 0);
                EndWriteAttribute();
                WriteLiteral(@">
            </div><!--//team-figure-->
        </section><!--//support-section-->

        <section class=""apps-section section text-center"">
            <h2 class=""section-title"">Download Our Apps</h2>
            <div class=""container"">
                <ul class=""apps-list list-inline"">
                    <li class=""list-inline-item""><a class=""btn btn-download-app btn-apple-download"" href=""#""><i class=""fab fa-apple""></i> <span class=""btn-text""><span class=""intro-text"">Download on the</span><span class=""main-text"">App Store</span></span></a></li>
                    <li class=""list-inline-item""><a class=""btn btn-download-app btn-andriod-download"" href=""#""><i class=""fab fa-android""></i> <span class=""btn-text""><span class=""intro-text"">Get it on</span><span class=""main-text"">Google Play</span></span></a></li>
                    <li class=""list-inline-item""><a class=""btn btn-download-app btn-windows-download"" href=""#""><i class=""fab fa-windows""></i> <span class=""btn-text""><span class=""intro-text"">Download fro");
                WriteLiteral(@"m</span><span class=""main-text"">Windows Phone Store</span></span></a></li>
                </ul><!--//apps-list-->
            </div><!--//container-->
        </section><!--//apps-section-->

    </div><!--//section-wrapper-->
    <!-- Javascript -->
    <script src=""assets/plugins/popper.min.js""></script>
    <script src=""assets/plugins/bootstrap/js/bootstrap.min.js""></script>
    <script src=""assets/plugins/vanilla-back-to-top.min.js""></script>
    <script src=""assets/plugins/smoothscroll.min.js""></script>

    <script src=""assets/js/main.js""></script>

    <!--//Page Specific JS -->
    <script src=""assets/js/video.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
