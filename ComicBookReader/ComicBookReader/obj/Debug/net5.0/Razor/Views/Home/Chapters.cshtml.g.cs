#pragma checksum "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\Home\Chapters.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b33e6979abf4818616857708e46c6d9b0ffee0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Chapters), @"mvc.1.0.view", @"/Views/Home/Chapters.cshtml")]
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
#line 1 "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\_ViewImports.cshtml"
using ComicBookReader;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\_ViewImports.cshtml"
using ComicBookReader.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b33e6979abf4818616857708e46c6d9b0ffee0a", @"/Views/Home/Chapters.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"458e8edccf0d83bd6204cd4f1b390da15013b10f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Chapters : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ComicBookReader.Models.Chapter>>
    #nullable disable
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\Home\Chapters.cshtml"
  
    ViewData["Title"] = "Список глав";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b33e6979abf4818616857708e46c6d9b0ffee0a3606", async() => {
                WriteLiteral("\r\n        <title>ComicBookReader</title>\r\n    ");
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
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b33e6979abf4818616857708e46c6d9b0ffee0a4622", async() => {
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 14 "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\Home\Chapters.cshtml"
         foreach (var chapter in Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <p>");
#nullable restore
#line 16 "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\Home\Chapters.cshtml"
          Write(chapter.ChapterName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            <p>");
#nullable restore
#line 17 "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\Home\Chapters.cshtml"
          Write(chapter.ComicPages.First());

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 18 "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\Home\Chapters.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"text-center\">\r\n            <h1 class=\"display-4\">Welcome</h1>\r\n            <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n        </div>\r\n    ");
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
            WriteLiteral("\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ComicBookReader.Models.Chapter>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591