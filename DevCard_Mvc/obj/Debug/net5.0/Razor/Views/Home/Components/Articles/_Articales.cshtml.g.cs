#pragma checksum "G:\Asp.netTest\DevCard\DevCard_Mvc\Views\Home\Components\Articles\_Articales.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7305149f0e031d20c361fec57901fded7d5e1d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Components_Articles__Articales), @"mvc.1.0.view", @"/Views/Home/Components/Articles/_Articales.cshtml")]
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
#line 1 "G:\Asp.netTest\DevCard\DevCard_Mvc\Views\_ViewImports.cshtml"
using DevCard_Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Asp.netTest\DevCard\DevCard_Mvc\Views\_ViewImports.cshtml"
using DevCard_Mvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7305149f0e031d20c361fec57901fded7d5e1d1", @"/Views/Home/Components/Articles/_Articales.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3de1a09574fcca7cc0cd1ac5dfb072ded2fb18c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Components_Articles__Articales : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Article>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<section class=\"latest-blog-section p-3 p-lg-5\">\r\n    <div class=\"container\">\r\n        <h2 class=\"section-title font-weight-bold mb-5\">آخرین مقالات</h2>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 6 "G:\Asp.netTest\DevCard\DevCard_Mvc\Views\Home\Components\Articles\_Articales.cshtml"
             foreach (var a in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-4 mb-5\">\r\n                    <div class=\"card blog-post-card\">\r\n                        <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 406, "\"", 440, 2);
            WriteAttributeValue("", 412, "/images/Articles/", 412, 17, true);
#nullable restore
#line 10 "G:\Asp.netTest\DevCard\DevCard_Mvc\Views\Home\Components\Articles\_Articales.cshtml"
WriteAttributeValue("", 429, a.ImageUrl, 429, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"image\">\r\n                        <div class=\"card-body\">\r\n                            <h5 class=\"card-title\">\r\n                                <a class=\"theme-link\" href=\"blog-post.html\">\r\n                                   ");
#nullable restore
#line 14 "G:\Asp.netTest\DevCard\DevCard_Mvc\Views\Home\Components\Articles\_Articales.cshtml"
                              Write(a.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </a>\r\n                            </h5>\r\n                            <p class=\"card-text\">\r\n                                ");
#nullable restore
#line 18 "G:\Asp.netTest\DevCard\DevCard_Mvc\Views\Home\Components\Articles\_Articales.cshtml"
                           Write(a.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </p>
                            <p class=""mb-0"">
                                <a class=""more-link"" href=""blog-post.html"">ادامه مطلب</a>
                            </p>

                        </div>
                    </div>
                </div>
");
#nullable restore
#line 27 "G:\Asp.netTest\DevCard\DevCard_Mvc\Views\Home\Components\Articles\_Articales.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Article>> Html { get; private set; }
    }
}
#pragma warning restore 1591