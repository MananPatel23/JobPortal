#pragma checksum "D:\Projects\JobSearch\Views\Recruiter\Candidates.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab86140fa1e019bb70b666dd3883ae40b7deee23"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recruiter_Candidates), @"mvc.1.0.view", @"/Views/Recruiter/Candidates.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Recruiter/Candidates.cshtml", typeof(AspNetCore.Views_Recruiter_Candidates))]
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
#line 1 "D:\Projects\JobSearch\Views\_ViewImports.cshtml"
using JobSearch;

#line default
#line hidden
#line 2 "D:\Projects\JobSearch\Views\_ViewImports.cshtml"
using JobSearch.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab86140fa1e019bb70b666dd3883ae40b7deee23", @"/Views/Recruiter/Candidates.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdf5bc95cb5e82e85e2334780f4af49ff03ee4a8", @"/Views/_ViewImports.cshtml")]
    public class Views_Recruiter_Candidates : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JsAccount>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Projects\JobSearch\Views\Recruiter\Candidates.cshtml"
  
    ViewData["Title"] = "Candidates";
    Layout = "~/Views/Shared/_RLayout.cshtml";

#line default
#line hidden
            BeginContext(112, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(114, 212, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09689e2c0cdf4b479b9881a2eb975a50", async() => {
                BeginContext(120, 199, true);
                WriteLiteral("\r\n    <style>\r\n\r\n\r\n\r\n\r\n        table {\r\n            -webkit-box-shadow: 2px 5px 11px 2px rgba(0,0,0,0.75);\r\n            box-shadow: 2px 5px 11px 2px rgba(0,0,0,0.75);\r\n        }\r\n    </style>\r\n\r\n\r\n\r\n");
                EndContext();
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
            EndContext();
            BeginContext(326, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(330, 2336, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32255e28c0d84803ad43c7e985b6bfa4", async() => {
                BeginContext(336, 293, true);
                WriteLiteral(@"
    <div style=""margin-top:140px;"">
        <h1 style=""font-size:35px;font-family:Calibri;margin-left:450px;color:white;"">Candidates details</h1>
    </div>
    <font size=""5px"" style=""font-family:Calibri"">
        <div style=""margin-top:12px;width:60%;margin-left:250px;"" id=""card"">

");
                EndContext();
#line 30 "D:\Projects\JobSearch\Views\Recruiter\Candidates.cshtml"
             foreach (var item in Model.js)
            {

#line default
#line hidden
                BeginContext(689, 162, true);
                WriteLiteral("            <table style=\"margin-top:15px;width:100%;background-color:white;\">\r\n                <tr>\r\n                    <td>Name:</td>\r\n                    <td>");
                EndContext();
                BeginContext(852, 11, false);
#line 35 "D:\Projects\JobSearch\Views\Recruiter\Candidates.cshtml"
                   Write(item.JsName);

#line default
#line hidden
                EndContext();
                BeginContext(863, 119, true);
                WriteLiteral("</td>\r\n                </tr>\r\n\r\n                <tr>\r\n                    <td>Job Title:</td>\r\n                    <td>");
                EndContext();
                BeginContext(983, 14, false);
#line 40 "D:\Projects\JobSearch\Views\Recruiter\Candidates.cshtml"
                   Write(item.Job_Title);

#line default
#line hidden
                EndContext();
                BeginContext(997, 114, true);
                WriteLiteral("</td>\r\n                </tr>\r\n\r\n                <tr>\r\n                    <td>Name:</td>\r\n                    <td>");
                EndContext();
                BeginContext(1112, 10, false);
#line 45 "D:\Projects\JobSearch\Views\Recruiter\Candidates.cshtml"
                   Write(item.Skill);

#line default
#line hidden
                EndContext();
                BeginContext(1122, 113, true);
                WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Email:</td>\r\n                    <td>");
                EndContext();
                BeginContext(1236, 10, false);
#line 49 "D:\Projects\JobSearch\Views\Recruiter\Candidates.cshtml"
                   Write(item.Email);

#line default
#line hidden
                EndContext();
                BeginContext(1246, 112, true);
                WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>City:</td>\r\n                    <td>");
                EndContext();
                BeginContext(1359, 9, false);
#line 53 "D:\Projects\JobSearch\Views\Recruiter\Candidates.cshtml"
                   Write(item.City);

#line default
#line hidden
                EndContext();
                BeginContext(1368, 120, true);
                WriteLiteral("</td>\r\n                </tr>\r\n\r\n\r\n\r\n                <tr>\r\n                    <td>Mobile:</td>\r\n                    <td>");
                EndContext();
                BeginContext(1489, 11, false);
#line 60 "D:\Projects\JobSearch\Views\Recruiter\Candidates.cshtml"
                   Write(item.Mobile);

#line default
#line hidden
                EndContext();
                BeginContext(1500, 122, true);
                WriteLiteral("</td>\r\n                </tr>\r\n\r\n                <tr>\r\n                    <td>College Name:</td>\r\n                    <td>");
                EndContext();
                BeginContext(1623, 16, false);
#line 65 "D:\Projects\JobSearch\Views\Recruiter\Candidates.cshtml"
                   Write(item.CollegeName);

#line default
#line hidden
                EndContext();
                BeginContext(1639, 114, true);
                WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Degree:</td>\r\n                    <td>");
                EndContext();
                BeginContext(1754, 11, false);
#line 69 "D:\Projects\JobSearch\Views\Recruiter\Candidates.cshtml"
                   Write(item.Degree);

#line default
#line hidden
                EndContext();
                BeginContext(1765, 118, true);
                WriteLiteral("</td>\r\n                </tr>\r\n\r\n                <tr>\r\n                    <td>Category:</td>\r\n                    <td>");
                EndContext();
                BeginContext(1884, 13, false);
#line 74 "D:\Projects\JobSearch\Views\Recruiter\Candidates.cshtml"
                   Write(item.Category);

#line default
#line hidden
                EndContext();
                BeginContext(1897, 120, true);
                WriteLiteral("</td>\r\n                </tr>\r\n\r\n                <tr>\r\n                    <td>Experiance:</td>\r\n                    <td>");
                EndContext();
                BeginContext(2018, 15, false);
#line 79 "D:\Projects\JobSearch\Views\Recruiter\Candidates.cshtml"
                   Write(item.Experiance);

#line default
#line hidden
                EndContext();
                BeginContext(2033, 114, true);
                WriteLiteral("</td>\r\n                </tr>\r\n\r\n                <tr>\r\n                    <td>CGPA:</td>\r\n                    <td>");
                EndContext();
                BeginContext(2148, 9, false);
#line 84 "D:\Projects\JobSearch\Views\Recruiter\Candidates.cshtml"
                   Write(item.CGPA);

#line default
#line hidden
                EndContext();
                BeginContext(2157, 122, true);
                WriteLiteral("</td>\r\n                </tr>\r\n\r\n                <tr>\r\n                    <td>Passing Year:</td>\r\n                    <td>");
                EndContext();
                BeginContext(2280, 16, false);
#line 89 "D:\Projects\JobSearch\Views\Recruiter\Candidates.cshtml"
                   Write(item.PassingYear);

#line default
#line hidden
                EndContext();
                BeginContext(2296, 119, true);
                WriteLiteral("</td>\r\n                </tr>\r\n\r\n                <tr>\r\n                    <td>Job Title:</td>\r\n                    <td>");
                EndContext();
                BeginContext(2416, 14, false);
#line 94 "D:\Projects\JobSearch\Views\Recruiter\Candidates.cshtml"
                   Write(item.Job_Title);

#line default
#line hidden
                EndContext();
                BeginContext(2430, 120, true);
                WriteLiteral("</td>\r\n                </tr>\r\n\r\n                <tr>\r\n                    <td>Applied On:</td>\r\n                    <td>");
                EndContext();
                BeginContext(2551, 10, false);
#line 99 "D:\Projects\JobSearch\Views\Recruiter\Candidates.cshtml"
                   Write(item.AppOn);

#line default
#line hidden
                EndContext();
                BeginContext(2561, 52, true);
                WriteLiteral("</td>\r\n                </tr>\r\n            </table>\r\n");
                EndContext();
#line 102 "D:\Projects\JobSearch\Views\Recruiter\Candidates.cshtml"
            }

#line default
#line hidden
                BeginContext(2628, 31, true);
                WriteLiteral("\r\n        </div>\r\n    </font>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(2666, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JsAccount> Html { get; private set; }
    }
}
#pragma warning restore 1591
