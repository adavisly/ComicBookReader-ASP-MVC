#pragma checksum "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\Home\ComicChapter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c48427c0e7bd2c24db26af1d718d969925a68de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ComicChapter), @"mvc.1.0.view", @"/Views/Home/ComicChapter.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c48427c0e7bd2c24db26af1d718d969925a68de", @"/Views/Home/ComicChapter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"458e8edccf0d83bd6204cd4f1b390da15013b10f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_ComicChapter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ComicBookReader.Models.Chapter>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/ComicChapter.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/settings_icon.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("ch-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("cb-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("pageForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\Home\ComicChapter.cshtml"
  
    ViewData["Title"] = "Читать главу";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c48427c0e7bd2c24db26af1d718d969925a68de6169", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1c48427c0e7bd2c24db26af1d718d969925a68de6435", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c48427c0e7bd2c24db26af1d718d969925a68de8325", async() => {
                WriteLiteral("\r\n        <div class=\"nav-reader\">\r\n            \r\n         </div>\r\n            <div class=\"chapters-nav\">\r\n                <a class=\"settings-icon\" onclick=\"showSettings()\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1c48427c0e7bd2c24db26af1d718d969925a68de8770", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</a>\r\n");
#nullable restore
#line 18 "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\Home\ComicChapter.cshtml"
                  int prevCh = @Model.ChapterId - 1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\Home\ComicChapter.cshtml"
                  int nextCh = @Model.ChapterId + 1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\Home\ComicChapter.cshtml"
                 if (@prevCh >= @ViewBag.FirstChapter)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c48427c0e7bd2c24db26af1d718d969925a68de10632", async() => {
                    WriteLiteral("Предыдущая глава");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 662, "~/Home/ComicChapter/", 662, 20, true);
#nullable restore
#line 22 "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\Home\ComicChapter.cshtml"
AddHtmlAttributeValue("", 682, prevCh, 682, 7, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 23 "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\Home\ComicChapter.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <a class=\"ch-link\" style=\"background-color: #ccc;\">Предыдущая глава</a>\r\n");
#nullable restore
#line 27 "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\Home\ComicChapter.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c48427c0e7bd2c24db26af1d718d969925a68de12963", async() => {
#nullable restore
#line 28 "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\Home\ComicChapter.cshtml"
                                                                         Write(Model.ChapterName);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 926, "~/Home/ComicBook/", 926, 17, true);
#nullable restore
#line 28 "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\Home\ComicChapter.cshtml"
AddHtmlAttributeValue("", 943, Model.ComicBookId, 943, 18, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 29 "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\Home\ComicChapter.cshtml"
                 if (@nextCh <= @ViewBag.ChapterCount)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c48427c0e7bd2c24db26af1d718d969925a68de15214", async() => {
                    WriteLiteral("Следующая глава");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1107, "~/Home/ComicChapter/", 1107, 20, true);
#nullable restore
#line 31 "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\Home\ComicChapter.cshtml"
AddHtmlAttributeValue("", 1127, nextCh, 1127, 7, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 32 "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\Home\ComicChapter.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <a class=\"ch-link\" style=\"background-color: #ccc;\">Следующая глава</a>\r\n");
#nullable restore
#line 36 "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\Home\ComicChapter.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            </div>
           
            
        
        
        <section class=""page-content"">
            <div class=""slide-img"" style=""display: flex;"">
            <!-- Вперед и назад кнопки -->
          <a class=""prev"" onclick=""plusSlides(-1)"">&#10094;</a>
            <!-- Контейнер для галереи изображений -->
        <div class=""containerr"">
            
          <!-- Полноразмерные изображения с числовым текстом -->
");
#nullable restore
#line 50 "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\Home\ComicChapter.cshtml"
            int i;

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\Home\ComicChapter.cshtml"
           for (i = 0; i < @Model.ComicPages.Count; i++)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("              <div class=\"mySlides\">\r\n                  <img class=\"img-page\"");
                BeginWriteAttribute("src", " src=\"", 1945, "\"", 1991, 1);
#nullable restore
#line 54 "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\Home\ComicChapter.cshtml"
WriteAttributeValue("", 1951, Model.ComicPages.ElementAt(i).PageImage, 1951, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                  <div class=\"numbertext\"><p>");
#nullable restore
#line 55 "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\Home\ComicChapter.cshtml"
                                        Write(Model.ComicPages.ElementAt(i).PageNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral(" / ");
#nullable restore
#line 55 "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\Home\ComicChapter.cshtml"
                                                                                    Write(Model.ComicPages.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p></div>\r\n              </div>\r\n");
#nullable restore
#line 57 "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\Home\ComicChapter.cshtml"
              
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"slidecontainer\">\r\n              <input  type=\"range\" min=\"1\"");
                BeginWriteAttribute("max", " max=\"", 2256, "\"", 2285, 1);
#nullable restore
#line 60 "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\Home\ComicChapter.cshtml"
WriteAttributeValue("", 2262, Model.ComicPages.Count, 2262, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" value=\"1\" class=\"slider-page\" id=\"myRangePage\">\r\n            </div>\r\n\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c48427c0e7bd2c24db26af1d718d969925a68de20533", async() => {
                    WriteLiteral(@"
                Перейти на страницу
                <input name=""enter"" class=""enter-page"" type=""text"" style=""width: 50px; border-radius: 10px;"" />
                <input name=""submit"" onclick=""Complete();"" class=""submit-page"" type=""button"" value=""ok""/>
            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n          </div>\r\n\r\n          <a class=\"next\" onclick=\"plusSlides(1)\">&#10095;</a>\r\n        </div>\r\n        \r\n        <div class=\"vertical-pages\" style=\"display: none;\">\r\n");
#nullable restore
#line 74 "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\Home\ComicChapter.cshtml"
             for (int j = 0; j < @Model.ComicPages.Count; j++)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("              <div>\r\n                  <img class=\"img-page\"");
                BeginWriteAttribute("src", " src=\"", 2982, "\"", 3028, 1);
#nullable restore
#line 77 "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\Home\ComicChapter.cshtml"
WriteAttributeValue("", 2988, Model.ComicPages.ElementAt(j).PageImage, 2988, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n              </div>\r\n");
#nullable restore
#line 79 "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\Home\ComicChapter.cshtml"
              
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        </div>

        <div class=""settings"" style=""display: none;"">
            <div class=""slidecontainer"">
                <h5>Размер изображения</h5>
              <input type=""range"" min=""400"" max=""1200"" value=""500"" class=""slider"" id=""myRange"">
            </div>

            <div class=""reader-mode"">
                <h5>Режим чтения</h5>
                <div class=""reader-mode-btns"">
                    <a id=""vert"" class=""reader-mode-btn"" onclick=""vertical();"">Вертикальный</a>
                    <a id=""hor"" class=""reader-mode-btn"" onclick=""horizontal();"">Горизонтальный</a>
                </div>
            </div>
        </div>
        </section>
        
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
            WriteLiteral(@"
</html>
<script>
    var slideIndex = 1;
    showSlides(slideIndex);

    var sliderPage = document.getElementById(""myRangePage"");

    var cont = document.getElementsByClassName(""containerr"")[0];
    document.addEventListener(""keydown"", function (event) {
        if (event.keyCode == 39) {
            console.log(""ar"");
            plusSlides(1);
        }
        else if (event.keyCode == 37) {
            console.log(""al"");
            plusSlides(-1);
        }
    });
    
    // Вперед/назад элементы управления
    function plusSlides(n) {
      showSlides(slideIndex += n);
      sliderPage.value = slideIndex;
    }

    // Элементы управления миниатюрами изображений
    function currentSlide(n) {
      showSlides(slideIndex = n);
    }

    function showSlides(n) {
      var i;
      var slides = document.getElementsByClassName(""mySlides"");
      if (n > slides.length) {slideIndex = 1}
      if (n < 1) {slideIndex = slides.length}
      for (i = 0; i < slides.length;");
            WriteLiteral(@" i++) {
        slides[i].style.display = ""none"";
      }
      slides[slideIndex-1].style.display = ""block"";
    }

    function Complete() {
        var pageNum = document.getElementsByClassName(""enter-page"")[0].value;
        currentSlide(Number(pageNum));
        sliderPage.value = slideIndex;
    }

    sliderPage.addEventListener(""mouseup"", function() {
        currentSlide(Number(this.value));
    });
    
    
</script>

<script>
    var slider = document.getElementById(""myRange"");
    var sliderPage = document.getElementById(""myRangePage"");
    var pages = document.getElementsByClassName(""img-page"");
    pages.innerHTML = slider.value; // Отображение значения ползунка по умолчанию
    
    slider.addEventListener(""mouseup"", function() {
        sliderPage.style.width = this.value + ""px"";
        for (i = 0; i < pages.length; i++) {
            pages[i].style.width = this.value + ""px"";
    }});
</script>

<script>
    var settingsIcon = document.getElementsByClassName(");
            WriteLiteral(@"""settings-icon"")[0];
    var settings = document.getElementsByClassName(""settings"")[0];
    var sl = document.getElementsByClassName(""slide-img"")[0];
    var vp = document.getElementsByClassName(""vertical-pages"")[0];

    function showSettings() {
        if (settings.style.display == 'none') settings.style.display = 'block';
        else settings.style.display = 'none';
    }

    sl.addEventListener (""click"", e => {
        settings.style.display = 'none';
    });

    vp.addEventListener (""click"", e => {
        settings.style.display = 'none';
    });
</script>

<script>
    alert(""s"");
    var verticalMode = document.getElementById(""vert"");
    var horizontalMode = document.getElementById(""hor"");
    var verticalPages = document.getElementsByClassName(""vertical-pages"")[0];
    var horizontalPages = document.getElementsByClassName(""slide-img"")[0];

    function vertical() {
        horizontalPages.style.display = 'none';
        verticalPages.style.display = 'block';
    }

");
            WriteLiteral("    function horizontal() {\r\n        verticalPages.style.display = \'none\';\r\n        horizontalPages.style.display = \'flex\';\r\n    }\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ComicBookReader.Models.Chapter> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
