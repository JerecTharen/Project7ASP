#pragma checksum "C:\Users\skill\Desktop\JacobsPrograms\DotNet\Project7ASP\Project7ASP\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09eed0a7e0fc08bfd60b326c3909757acdb7cc2a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Project7ASP.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(Project7ASP.Pages.Pages_Index), null)]
namespace Project7ASP.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\skill\Desktop\JacobsPrograms\DotNet\Project7ASP\Project7ASP\Pages\_ViewImports.cshtml"
using Project7ASP;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09eed0a7e0fc08bfd60b326c3909757acdb7cc2a", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c98a3130d2ca05578696526ab5d9347bfacdee9", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\skill\Desktop\JacobsPrograms\DotNet\Project7ASP\Project7ASP\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
            BeginContext(71, 59, true);
            WriteLiteral("\r\n    <div id=\"containsAll\">\r\n        <h1>Add A User</h1>\r\n");
            EndContext();
#line 9 "C:\Users\skill\Desktop\JacobsPrograms\DotNet\Project7ASP\Project7ASP\Pages\Index.cshtml"
         if (Model.ShowFail)
        {

#line default
#line hidden
            BeginContext(171, 70, true);
            WriteLiteral("            <p color=\"red\">There was an error, please try again.</p>\r\n");
            EndContext();
#line 12 "C:\Users\skill\Desktop\JacobsPrograms\DotNet\Project7ASP\Project7ASP\Pages\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(252, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 13 "C:\Users\skill\Desktop\JacobsPrograms\DotNet\Project7ASP\Project7ASP\Pages\Index.cshtml"
         if (Model.ShowSuccess)
        {

#line default
#line hidden
            BeginContext(296, 61, true);
            WriteLiteral("            <p color=\"green\">Success! You added a user.</p>\r\n");
            EndContext();
#line 16 "C:\Users\skill\Desktop\JacobsPrograms\DotNet\Project7ASP\Project7ASP\Pages\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(368, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(376, 938, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66d92506439c4dd8a7e71f2bb83d887f", async() => {
                BeginContext(396, 911, true);
                WriteLiteral(@"
            <div>
                <label for=""userName"">Username: </label>
                <input id=""userName"" name=""userName"" type=""text"" />
            </div>
            <div>
                <label for=""firstName"">First Name: </label>
                <input id=""firstName"" name=""firstName"" type=""text"" />
            </div>
            <div>
                <label for=""lastName"">Last Name: </label>
                <input id=""lastName"" name=""lastName"" type=""text"" />
            </div>
            <div>
                <label for=""age"">Age: </label>
                <input id=""age"" name=""age"" type=""number"" />
            </div>
            <div>
                <label for=""email"">Email: </label>
                <input id=""email"" name=""email"" type=""email"" />
            </div>
            <div>
                <button type=""submit"">SUBMIT</button>
            </div>
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1314, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
