#pragma checksum "D:\GIT\AdminLTE.NETCore\src\AdminLTE.NETCore\Views\Calendar\Calendar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "331c76a6d37d37fc709568b9eb41327342f4ba2d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Calendar_Calendar), @"mvc.1.0.view", @"/Views/Calendar/Calendar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Calendar/Calendar.cshtml", typeof(AspNetCore.Views_Calendar_Calendar))]
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
#line 1 "D:\GIT\AdminLTE.NETCore\src\AdminLTE.NETCore\Views\_ViewImports.cshtml"
using AdminLTE.NETCore;

#line default
#line hidden
#line 2 "D:\GIT\AdminLTE.NETCore\src\AdminLTE.NETCore\Views\_ViewImports.cshtml"
using AdminLTE.NETCore.ViewComponents;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"331c76a6d37d37fc709568b9eb41327342f4ba2d", @"/Views/Calendar/Calendar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82ddd25cc976a50b58c7f3689f76c7cb30ff55d5", @"/Views/_ViewImports.cshtml")]
    public class Views_Calendar_Calendar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Calendar.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.CacheTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_CacheTagHelper;
        private global::AdminLTE.NETCore.TagHelpers.HtmlExtractionTagHelper __AdminLTE_NETCore_TagHelpers_HtmlExtractionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(78, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(80, 202, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("cache", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "331c76a6d37d37fc709568b9eb41327342f4ba2d3851", async() => {
                BeginContext(130, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(136, 136, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("html-extraction", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "331c76a6d37d37fc709568b9eb41327342f4ba2d4238", async() => {
                }
                );
                __AdminLTE_NETCore_TagHelpers_HtmlExtractionTagHelper = CreateTagHelper<global::AdminLTE.NETCore.TagHelpers.HtmlExtractionTagHelper>();
                __tagHelperExecutionContext.Add(__AdminLTE_NETCore_TagHelpers_HtmlExtractionTagHelper);
                BeginWriteTagHelperAttribute();
#line 3 "D:\GIT\AdminLTE.NETCore\src\AdminLTE.NETCore\Views\Calendar\Calendar.cshtml"
                          WriteLiteral(System.IO.Path.Combine("wwwroot","lib","AdminLTE-2.3.11","pages","calendar.html"));

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __AdminLTE_NETCore_TagHelpers_HtmlExtractionTagHelper.HtmlLocalPath = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("html-local-path", __AdminLTE_NETCore_TagHelpers_HtmlExtractionTagHelper.HtmlLocalPath, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(272, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_CacheTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.CacheTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_CacheTagHelper);
#line 2 "D:\GIT\AdminLTE.NETCore\src\AdminLTE.NETCore\Views\Calendar\Calendar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_CacheTagHelper.ExpiresSliding = TimeSpan.FromMinutes(5);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("expires-sliding", __Microsoft_AspNetCore_Mvc_TagHelpers_CacheTagHelper.ExpiresSliding, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(282, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(302, 90, true);
                WriteLiteral("\r\n    <!-- This is needed for non partial rendering -->\r\n    <!-- fullCalendar 2.2.5 -->\r\n");
                EndContext();
                BeginContext(591, 39, true);
                WriteLiteral("    <!-- Page specific script -->\r\n    ");
                EndContext();
                BeginContext(630, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "331c76a6d37d37fc709568b9eb41327342f4ba2d7750", async() => {
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
                EndContext();
                BeginContext(670, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
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