#pragma checksum "D:\GIT\AdminLTE.NETCore\src\AdminLTE.NETCore\Views\MailBox\InBox.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68c0282f0469fbcc63aa1ad026a45ab346064f0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MailBox_InBox), @"mvc.1.0.view", @"/Views/MailBox/InBox.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MailBox/InBox.cshtml", typeof(AspNetCore.Views_MailBox_InBox))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68c0282f0469fbcc63aa1ad026a45ab346064f0b", @"/Views/MailBox/InBox.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82ddd25cc976a50b58c7f3689f76c7cb30ff55d5", @"/Views/_ViewImports.cshtml")]
    public class Views_MailBox_InBox : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(78, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(80, 211, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("cache", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68c0282f0469fbcc63aa1ad026a45ab346064f0b3311", async() => {
                BeginContext(130, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(136, 145, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("html-extraction", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68c0282f0469fbcc63aa1ad026a45ab346064f0b3698", async() => {
                }
                );
                __AdminLTE_NETCore_TagHelpers_HtmlExtractionTagHelper = CreateTagHelper<global::AdminLTE.NETCore.TagHelpers.HtmlExtractionTagHelper>();
                __tagHelperExecutionContext.Add(__AdminLTE_NETCore_TagHelpers_HtmlExtractionTagHelper);
                BeginWriteTagHelperAttribute();
#line 3 "D:\GIT\AdminLTE.NETCore\src\AdminLTE.NETCore\Views\MailBox\InBox.cshtml"
                          WriteLiteral(System.IO.Path.Combine("wwwroot","lib","AdminLTE-2.3.11","pages","mailbox","mailbox.html"));

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
                BeginContext(281, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_CacheTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.CacheTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_CacheTagHelper);
#line 2 "D:\GIT\AdminLTE.NETCore\src\AdminLTE.NETCore\Views\MailBox\InBox.cshtml"
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
            BeginContext(291, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(313, 57, true);
                WriteLiteral("\r\n    <!-- This is needed for non partial rendering -->\r\n");
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
