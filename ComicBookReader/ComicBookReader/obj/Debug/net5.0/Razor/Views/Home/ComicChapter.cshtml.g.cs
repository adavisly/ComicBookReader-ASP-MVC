#pragma checksum "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\Home\ComicChapter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44b79e5251cbe41627baa2b9765c24bb78dda2e3"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44b79e5251cbe41627baa2b9765c24bb78dda2e3", @"/Views/Home/ComicChapter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"458e8edccf0d83bd6204cd4f1b390da15013b10f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_ComicChapter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ComicBookReader.Models.Chapter>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/settings_icon.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("pageForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\Home\ComicChapter.cshtml"
  
    ViewData["Title"] = "Список страниц";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44b79e5251cbe41627baa2b9765c24bb78dda2e34768", async() => {
                WriteLiteral(@"
        <title>ComicBookReader</title>
        <style>
            .img-page {
                width: 500px;
                display: block;
                margin-right: auto;
                margin-left: auto;
            }

            * {
              box-sizing: border-box;
            }

            .slide-img {
                display: flex;
                justify-content: center;
                align-items: center;
            }

            /* Расположите контейнер изображения (необходимо расположить стрелки влево и вправо) */
            .containerr {
              position: relative;
              display: block;
              margin-left: 0px;
              margin-right: 0px;
            }

            /* Скрыть изображения по умолчанию */
            .mySlides {
              display: none;
            }

            /* Добавить указатель при наведении на миниатюры изображений */
            .cursor {
              cursor: pointer;
            }

        ");
                WriteLiteral(@"    /* Вперед и предыдущие кнопки */
            .prev,
            .next {
              cursor: pointer;
              width: auto;
              padding-top: 100px;
              padding-bottom: 100px;
              padding-left: 40px;
              padding-right: 40px;
              color: #555;
              font-weight: bold;
              font-size: 20px;
              border-radius: 0 3px 3px 0;
              user-select: none;
              -webkit-user-select: none;
            }

            /* Позиция ""next кнопка"" на право */
            .next {
              right: 0;
              border-radius: 3px 0 0 3px;
            }

            /* При наведении курсора добавьте черный цвет фона с небольшим количеством прозрачного */
            .prev:hover,
            .next:hover {
              background-color: #ccc;
              color: #fff;
            }

            /* Номера текст (1/3 и т.д.) */
            .numbertext {
              text-align: center;
        ");
                WriteLiteral(@"      color: #000;
              margin-top: 20px;
            }


            .slider {
              margin-top: 20px;
              -webkit-appearance: none;
              width: 250px;
              height: 3px;
              margin-left: 25px;
              border-radius: 5px;  
              background: #fff;
              outline: none;
              opacity: 0.7;
              -webkit-transition: .2s;
              transition: opacity .2s;
            }

            .slider::-webkit-slider-thumb {
              -webkit-appearance: none;
              appearance: none;
              width: 25px;
              height: 25px;
              border-radius: 50%; 
              background: #fff;
              cursor: pointer;
            }

            .slider-page {
              margin-top: 20px;
              -webkit-appearance: none;
              width: 500px;
              height: 5px;
              border-radius: 5px;  
              background: #555;
              o");
                WriteLiteral(@"utline: none;
              opacity: 0.7;
              -webkit-transition: .2s;
              transition: opacity .2s;
            }

            .slider-page::-webkit-slider-thumb {
              -webkit-appearance: none;
              appearance: none;
              width: 25px;
              height: 25px;
              border-radius: 50%; 
              background: #555;
              cursor: pointer;
            }

            .page-content {
                position: relative;
            }

             .settings {
                display: none;
                position: absolute;
                top: 20px;
                left: 20px;
                float: right;
                height: 400px;
                width: 300px;
                background-color: #aaa;
                border-radius: 20px;
            }

            .settings h5 {
                color: #fff;
                text-align: center;
            }

            .slidecontainer {
                ");
                WriteLiteral(@"margin-top: 20px;
            }

            .settings-icon {
                cursor: pointer;
                margin-top: 20px;
                margin-left: 20px;
            }

            .settings-icon img {
                width: 50px;
                margin-top: 5px;
            }

            .nav-reader {
                height: 60px;
                width: 100%;
                background-color: #aaa;
            }
        </style>
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
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44b79e5251cbe41627baa2b9765c24bb78dda2e310446", async() => {
                WriteLiteral("\r\n        <div class=\"nav-reader\">\r\n            <a class=\"settings-icon\" onclick=\"showSettings()\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "44b79e5251cbe41627baa2b9765c24bb78dda2e310809", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"</a>
        </div>
        
        <section class=""page-content"">
            <div class=""slide-img"">
            <!-- Вперед и назад кнопки -->
          <a class=""prev"" onclick=""plusSlides(-1)"">&#10094;</a>
            <!-- Контейнер для галереи изображений -->
        <div class=""containerr"">
            
          <!-- Полноразмерные изображения с числовым текстом -->
");
#nullable restore
#line 188 "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\Home\ComicChapter.cshtml"
            int i;

#line default
#line hidden
#nullable disable
#nullable restore
#line 189 "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\Home\ComicChapter.cshtml"
           for (i = 0; i < @Model.ComicPages.Count; i++)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("              <div class=\"mySlides\">\r\n                  <img class=\"img-page\"");
                BeginWriteAttribute("src", " src=\"", 5406, "\"", 5452, 1);
#nullable restore
#line 192 "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\Home\ComicChapter.cshtml"
WriteAttributeValue("", 5412, Model.ComicPages.ElementAt(i).PageImage, 5412, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                  <div class=\"numbertext\"><p>");
#nullable restore
#line 193 "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\Home\ComicChapter.cshtml"
                                        Write(Model.ComicPages.ElementAt(i).PageNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral(" / ");
#nullable restore
#line 193 "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\Home\ComicChapter.cshtml"
                                                                                    Write(Model.ComicPages.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p></div>\r\n              </div>\r\n");
#nullable restore
#line 195 "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\Home\ComicChapter.cshtml"
              
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44b79e5251cbe41627baa2b9765c24bb78dda2e314263", async() => {
                    WriteLiteral("\r\n                <input name=\"enter\" class=\"enter-page\" type=\"text\" />\r\n                <input name=\"submit\" onclick=\"Complete();\" class=\"submit-page\" type=\"button\" value=\"ok\"/>\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            \r\n            <div class=\"slidecontainer\">\r\n              <input  type=\"range\" min=\"1\"");
                BeginWriteAttribute("max", " max=\"", 5966, "\"", 5995, 1);
#nullable restore
#line 203 "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\Home\ComicChapter.cshtml"
WriteAttributeValue("", 5972, Model.ComicPages.Count, 5972, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" value=""1"" class=""slider-page"" id=""myRangePage"">
            </div>
          </div>

          <a class=""next"" onclick=""plusSlides(1)"">&#10095;</a>
        </div>
        
        <div class=""settings"">
            <div class=""slidecontainer"">
                <h5>Размер изображения</h5>
              <input type=""range"" min=""400"" max=""1200"" value=""500"" class=""slider"" id=""myRange"">
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
      for (i = 0; i < slides.length; i++) {
        slides[i].style.display = ""none"";
      }
      slides[slideIndex-1].style.display ");
            WriteLiteral(@"= ""block"";
    }

    function Complete() {
        var pageNum = document.getElementsByClassName(""enter-page"")[0].value;
        currentSlide(pageNum);
        //alert(pageNum);
    }
    
    function changePage() {
    
    }

    var sliderPage = document.getElementById(""myRangePage"");
    
    sliderPage.addEventListener(""mouseup"", function() {
        currentSlide(this.value);
    });
    
    
</script>

<script>
    var slider = document.getElementById(""myRange"");
    var pages = document.getElementsByClassName(""img-page"");
    pages.innerHTML = slider.value; // Отображение значения ползунка по умолчанию
    
    slider.addEventListener(""mouseup"", function() {
        for (i = 0; i < pages.length; i++) {
            pages[i].style.width = this.value + ""px"";
    }});
</script>

<script>
    var settingsIcon = document.getElementsByClassName(""settings-icon"")[0];
    var settings = document.getElementsByClassName(""settings"")[0];

    /*settingsIcon.addEventListener(""c");
            WriteLiteral(@"lick"", function() {
        if (settings.style.display == 'none') settings.style.display = 'block';
        else settings.style.display = 'none';
    })*/

    function showSettings() {
        if (settings.style.display == 'none') settings.style.display = 'block';
        else settings.style.display = 'none';
    }
</script>
");
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
