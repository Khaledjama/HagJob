#pragma checksum "C:\Users\khaled Gamal\Desktop\FirstApplication\FirstApplication\Areas\Genral\Views\ApplyJobs\Apply.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8945bca411675904e68d724b3e76d86e99e6295f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Genral_Views_ApplyJobs_Apply), @"mvc.1.0.view", @"/Areas/Genral/Views/ApplyJobs/Apply.cshtml")]
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
#line 1 "C:\Users\khaled Gamal\Desktop\FirstApplication\FirstApplication\Areas\Genral\Views\_ViewImports.cshtml"
using FirstApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\khaled Gamal\Desktop\FirstApplication\FirstApplication\Areas\Genral\Views\_ViewImports.cshtml"
using FirstApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8945bca411675904e68d724b3e76d86e99e6295f", @"/Areas/Genral/Views/ApplyJobs/Apply.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad9d8ae0c68307f7f957ada2b9392bc28a7e6680", @"/Areas/Genral/Views/_ViewImports.cshtml")]
    public class Areas_Genral_Views_ApplyJobs_Apply : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FirstApplication.Models.QuestionJobVm>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Change", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "sdfjk", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Answer..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("oninput", new global::Microsoft.AspNetCore.Html.HtmlString("this.className = \'\'"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("exampleInputFirstName"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "idjob", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("regForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ApplyToJob", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ApplyJobs", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Genral", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<style>
    /* Style the form */
    #regForm {
        background-color: #ffffff;
        margin: 100px auto;
        padding: 40px;
        width: 70%;
        min-width: 300px;
    }

    /* Style the input fields */
    input {
        padding: 10px;
        width: 100%;
        font-size: 17px;
        font-family: Raleway;
        border: 1px solid #aaaaaa;
    }

        /* Mark input boxes that gets an error on validation: */
        input.invalid {
            background-color: #ffdddd;
        }

    /* Hide all steps by default: */
    .tab {
        display: none;
    }

    /* Make circles that indicate the steps of the form: */
    .step {
        height: 15px;
        width: 15px;
        margin: 0 2px;
        background-color: #bbbbbb;
        border: none;
        border-radius: 50%;
        display: inline-block;
        opacity: 0.5;
    }

        /* Mark the active step: */
        .step.active {
            opacity: 1;
        }

        /");
            WriteLiteral("* Mark the steps that are finished and valid: */\r\n        .step.finish {\r\n            background-color: #3f56d2;\r\n        }\r\n</style>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8945bca411675904e68d724b3e76d86e99e6295f9185", async() => {
                WriteLiteral("\r\n    <h1 style=\"text-align:center\">Apply Job:</h1>\r\n    <div class=\"tab\">\r\n        <label>First Name : </label>\r\n        <p><input placeholder=\"First Name...\"");
                BeginWriteAttribute("value", " value=\"", 1484, "\"", 1519, 1);
#nullable restore
#line 59 "C:\Users\khaled Gamal\Desktop\FirstApplication\FirstApplication\Areas\Genral\Views\ApplyJobs\Apply.cshtml"
WriteAttributeValue("", 1492, ViewBag.UserInfo.FirstName, 1492, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" id=\"exampleInputFirstName\" oninput=\"this.className = \'\'\"></p>\r\n        <label>Last Name : </label>\r\n        <p><input placeholder=\"Last Name...\"");
                BeginWriteAttribute("value", " value=\"", 1686, "\"", 1720, 1);
#nullable restore
#line 61 "C:\Users\khaled Gamal\Desktop\FirstApplication\FirstApplication\Areas\Genral\Views\ApplyJobs\Apply.cshtml"
WriteAttributeValue("", 1694, ViewBag.UserInfo.LastName, 1694, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" id=\"exampleInputFirstName\" oninput=\"this.className = \'\'\"></p>\r\n        <label>Phone Number : </label>\r\n        <p><input placeholder=\"Phone...\"");
                BeginWriteAttribute("value", " value=\"", 1886, "\"", 1917, 1);
#nullable restore
#line 63 "C:\Users\khaled Gamal\Desktop\FirstApplication\FirstApplication\Areas\Genral\Views\ApplyJobs\Apply.cshtml"
WriteAttributeValue("", 1894, ViewBag.UserInfo.Phone, 1894, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control"" id=""exampleInputFirstName"" oninput=""this.className = ''""></p>
        <label>My Cv : </label>
        <div class=""my-2""></div>
        <a href=""#"" class=""btn btn-primary btn-icon-split btn-lg"">
            <span class=""icon text-white-50"">
                <i class=""fas fa-flag""></i>
            </span>
            <span class=""text"">");
#nullable restore
#line 70 "C:\Users\khaled Gamal\Desktop\FirstApplication\FirstApplication\Areas\Genral\Views\ApplyJobs\Apply.cshtml"
                          Write(ViewBag.UserInfo.CV);

#line default
#line hidden
#nullable disable
                WriteLiteral("  </span>\r\n        </a>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8945bca411675904e68d724b3e76d86e99e6295f11917", async() => {
                    WriteLiteral("Change Cv");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8945bca411675904e68d724b3e76d86e99e6295f13449", async() => {
                    WriteLiteral("View My Cv");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </div>\r\n    <div class=\"tab\">\r\n        <label>Country : </label>\r\n        <p><input placeholder=\"First Name...\"");
                BeginWriteAttribute("value", " value=\"", 2645, "\"", 2680, 1);
#nullable restore
#line 77 "C:\Users\khaled Gamal\Desktop\FirstApplication\FirstApplication\Areas\Genral\Views\ApplyJobs\Apply.cshtml"
WriteAttributeValue("", 2653, ViewBag.UserAdress.Country, 2653, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" id=\"exampleInputFirstName\" oninput=\"this.className = \'\'\"></p>\r\n        <label>City : </label>\r\n        <p><input placeholder=\"Last Name...\"");
                BeginWriteAttribute("value", " value=\"", 2842, "\"", 2874, 1);
#nullable restore
#line 79 "C:\Users\khaled Gamal\Desktop\FirstApplication\FirstApplication\Areas\Genral\Views\ApplyJobs\Apply.cshtml"
WriteAttributeValue("", 2850, ViewBag.UserAdress.City, 2850, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" id=\"exampleInputFirstName\" oninput=\"this.className = \'\'\"></p>\r\n        <label>Street : </label>\r\n        <p><input placeholder=\"Phone...\"");
                BeginWriteAttribute("value", " value=\"", 3034, "\"", 3068, 1);
#nullable restore
#line 81 "C:\Users\khaled Gamal\Desktop\FirstApplication\FirstApplication\Areas\Genral\Views\ApplyJobs\Apply.cshtml"
WriteAttributeValue("", 3042, ViewBag.UserAdress.Street, 3042, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" id=\"exampleInputFirstName\" oninput=\"this.className = \'\'\"></p>\r\n        <label>Zip Code : </label>\r\n        <p><input placeholder=\"Phone...\"");
                BeginWriteAttribute("value", " value=\"", 3230, "\"", 3265, 1);
#nullable restore
#line 83 "C:\Users\khaled Gamal\Desktop\FirstApplication\FirstApplication\Areas\Genral\Views\ApplyJobs\Apply.cshtml"
WriteAttributeValue("", 3238, ViewBag.UserAdress.ZipCode, 3238, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" id=\"exampleInputFirstName\" oninput=\"this.className = \'\'\"></p>\r\n    </div>\r\n");
#nullable restore
#line 85 "C:\Users\khaled Gamal\Desktop\FirstApplication\FirstApplication\Areas\Genral\Views\ApplyJobs\Apply.cshtml"
     if (ViewBag.mm != null)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"tab\" id=\"QusetionsJob\">\r\n            <label id=\"q1\">");
#nullable restore
#line 88 "C:\Users\khaled Gamal\Desktop\FirstApplication\FirstApplication\Areas\Genral\Views\ApplyJobs\Apply.cshtml"
                      Write(ViewBag.mm.Question1);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n            <p id=\"R1\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8945bca411675904e68d724b3e76d86e99e6295f18049", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#nullable restore
#line 89 "C:\Users\khaled Gamal\Desktop\FirstApplication\FirstApplication\Areas\Genral\Views\ApplyJobs\Apply.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Question1);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</p>\r\n            <label id=\"q2\">");
#nullable restore
#line 90 "C:\Users\khaled Gamal\Desktop\FirstApplication\FirstApplication\Areas\Genral\Views\ApplyJobs\Apply.cshtml"
                      Write(ViewBag.mm.Question2);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n            <p id=\"R2\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8945bca411675904e68d724b3e76d86e99e6295f20170", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#nullable restore
#line 91 "C:\Users\khaled Gamal\Desktop\FirstApplication\FirstApplication\Areas\Genral\Views\ApplyJobs\Apply.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Question2);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</p>\r\n            <label id=\"q3\">");
#nullable restore
#line 92 "C:\Users\khaled Gamal\Desktop\FirstApplication\FirstApplication\Areas\Genral\Views\ApplyJobs\Apply.cshtml"
                      Write(ViewBag.mm.Question3);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n            <p id=\"R3\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8945bca411675904e68d724b3e76d86e99e6295f22378", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#nullable restore
#line 93 "C:\Users\khaled Gamal\Desktop\FirstApplication\FirstApplication\Areas\Genral\Views\ApplyJobs\Apply.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Question3);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</p>\r\n            <label id=\"q4\">");
#nullable restore
#line 94 "C:\Users\khaled Gamal\Desktop\FirstApplication\FirstApplication\Areas\Genral\Views\ApplyJobs\Apply.cshtml"
                      Write(ViewBag.mm.Question4);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n            <p id=\"R4\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8945bca411675904e68d724b3e76d86e99e6295f24586", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#nullable restore
#line 95 "C:\Users\khaled Gamal\Desktop\FirstApplication\FirstApplication\Areas\Genral\Views\ApplyJobs\Apply.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Question4);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</p>\r\n            <label id=\"q5\">");
#nullable restore
#line 96 "C:\Users\khaled Gamal\Desktop\FirstApplication\FirstApplication\Areas\Genral\Views\ApplyJobs\Apply.cshtml"
                      Write(ViewBag.mm.Question5);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n            <p id=\"R5\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8945bca411675904e68d724b3e76d86e99e6295f26794", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#nullable restore
#line 97 "C:\Users\khaled Gamal\Desktop\FirstApplication\FirstApplication\Areas\Genral\Views\ApplyJobs\Apply.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Question5);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</p>\r\n            <p style=\"display:none\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8945bca411675904e68d724b3e76d86e99e6295f28700", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
#nullable restore
#line 98 "C:\Users\khaled Gamal\Desktop\FirstApplication\FirstApplication\Areas\Genral\Views\ApplyJobs\Apply.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Job_Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 98 "C:\Users\khaled Gamal\Desktop\FirstApplication\FirstApplication\Areas\Genral\Views\ApplyJobs\Apply.cshtml"
                                                                                                   WriteLiteral(ViewBag.mm.jobs.Job_Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</p>\r\n        </div>\r\n");
#nullable restore
#line 100 "C:\Users\khaled Gamal\Desktop\FirstApplication\FirstApplication\Areas\Genral\Views\ApplyJobs\Apply.cshtml"
        // Special Script For This class = "Tabb"

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
        <script>
            var q1 = document.getElementById(""q1"").innerHTML;
            if (q1 == ""null"" || q1 == ""NULL"" || q1 == """") {
                $(""#R1"").remove();
            }

            var q2 = document.getElementById(""q2"").innerHTML;
            if (q2 == ""null"" || q2 == ""NULL"" || q2 == """") {
                $(""#R2"").remove();
            }
            var q3 = document.getElementById(""q3"").innerHTML;
            if (q3 == ""null"" || q3 == ""NULL"" || q3 == """") {
                $(""#R3"").remove();
            }
            var q4 = document.getElementById(""q4"").innerHTML;
            if (q4 == ""null"" || q4 == ""NULL"" || q4 == """") {
                $(""#R4"").remove();
            }
            var q5 = document.getElementById(""q5"").innerHTML;
            if (q5 == ""null"" || q5 == ""NULL"" || q5 == """") {
                $(""#R5"").remove();
            }


        </script>
");
#nullable restore
#line 127 "C:\Users\khaled Gamal\Desktop\FirstApplication\FirstApplication\Areas\Genral\Views\ApplyJobs\Apply.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    <div class=""tab"">
        <h3> Do You Want To Send This Form</h3>
    </div>
    <div style=""overflow:auto;"">
        <div style=""float:right;"">
            <button type=""button"" id=""prevBtn"" class=""btn btn-outline-primary btn"" onclick=""nextPrev(-1)"">Previous</button>
            <button type=""button"" id=""nextBtn"" class=""btn btn-primary btn"" onclick=""nextPrev(1)"">Next</button>
        </div>
    </div>
    <div style=""text-align:center;margin-top:40px;"" id=""Second"">
        <span class=""step""></span>
        <span class=""step""></span>
        <span class=""step""></span>
        <span class=""step"" id=""f""></span>
    </div>

    <!-- Circles which indicates the steps of the form: -->
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>

<script>


    //////////////////////////////////
    var currentTab = 0; // Current tab is set to be the first tab (0)
    showTab(currentTab); // Display the current tab

    function showTab(n) {
        // This function will display the specified tab of the form ...
        var x = document.getElementsByClassName(""tab"");
        x[n].style.display = ""block"";
        // ... and fix the Previous/Next buttons:
        if (n == 0) {
            document.getElementById(""prevBtn"").style.display = ""none"";
        } else {
            document.getElementById(""prevBtn"").style.display = ""inline"";
        }
        if (n == (x.length - 1)) {
            document.getElementById(""nextBtn"").innerHTML = ""Submit"";
        } else {
            document.getElementById(""nextBtn"").innerHTML = ""Next"";
        }
        // ... and run a function that displays the correct step indicator:
        fixStepIndicator(");
            WriteLiteral(@"n)
    }

    function nextPrev(n) {
        // This function will figure out which tab to display
        var x = document.getElementsByClassName(""tab"");
        // Exit the function if any field in the current tab is invalid:
        if (n == 1 && !validateForm()) return false;
        // Hide the current tab:
        x[currentTab].style.display = ""none"";
        // Increase or decrease the current tab by 1:
        currentTab = currentTab + n;
        // if you have reached the end of the form... :
        if (currentTab >= x.length) {
            //...the form gets submitted:
            document.getElementById(""regForm"").submit();
            return false;
        }
        // Otherwise, display the correct tab:
        showTab(currentTab);
    }

    function validateForm() {
        // This function deals with validation of the form fields
        var x, y, i, valid = true;
        x = document.getElementsByClassName(""tab"");
        y = x[currentTab].getElementsByTagName(""inpu");
            WriteLiteral(@"t"");
        // A loop that checks every input field in the current tab:
        for (i = 0; i < y.length; i++) {
            // If a field is empty...
            if (y[i].value == """") {
                // add an ""invalid"" class to the field:
                y[i].className += "" invalid"";
                // and set the current valid status to false:
                valid = false;
            }
        }
        // If the valid status is true, mark the step as finished and valid:
        if (valid) {
            document.getElementsByClassName(""step"")[currentTab].className += "" finish"";
        }
        return valid; // return the valid status
    }

    function fixStepIndicator(n) {
        // This function removes the ""active"" class of all steps...
        var i, x = document.getElementsByClassName(""step"");
        for (i = 0; i < x.length; i++) {
            x[i].className = x[i].className.replace("" active"", """");
        }
        //... and adds the ""active"" class to the current st");
            WriteLiteral("ep:\r\n        x[n].className += \" active\";\r\n    }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FirstApplication.Models.QuestionJobVm> Html { get; private set; }
    }
}
#pragma warning restore 1591
