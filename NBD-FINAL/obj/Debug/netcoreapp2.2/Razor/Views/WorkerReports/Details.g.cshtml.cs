#pragma checksum "C:\Users\Administrator\Desktop\NBD-FINAL\Views\WorkerReports\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99c59191bc44327ca39c9b69feb5567a04887797"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WorkerReports_Details), @"mvc.1.0.view", @"/Views/WorkerReports/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/WorkerReports/Details.cshtml", typeof(AspNetCore.Views_WorkerReports_Details))]
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
#line 1 "C:\Users\Administrator\Desktop\NBD-FINAL\Views\_ViewImports.cshtml"
using NBD;

#line default
#line hidden
#line 2 "C:\Users\Administrator\Desktop\NBD-FINAL\Views\_ViewImports.cshtml"
using NBD.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99c59191bc44327ca39c9b69feb5567a04887797", @"/Views/WorkerReports/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"877786879ad765db0577617c19ecaf8320d35743", @"/Views/_ViewImports.cshtml")]
    public class Views_WorkerReports_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NBD.Models.WorkerReport>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Administrator\Desktop\NBD-FINAL\Views\WorkerReports\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(77, 287, true);
            WriteLiteral(@"
    <h1 align=""center""> Worker Report Details</h1>

<div class=""card  align-content-center"" style=""width:400px; height:500px;"">
    <div class=""card-body"">
        <h4 class=""card-title"">Worker Report Details</h4>
        <dl class=""card-body"">
            <dt>
                ");
            EndContext();
            BeginContext(365, 44, false);
#line 14 "C:\Users\Administrator\Desktop\NBD-FINAL\Views\WorkerReports\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Employee));

#line default
#line hidden
            EndContext();
            BeginContext(409, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(465, 49, false);
#line 17 "C:\Users\Administrator\Desktop\NBD-FINAL\Views\WorkerReports\Details.cshtml"
           Write(Html.DisplayFor(model => model.Employee.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(514, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(570, 41, false);
#line 20 "C:\Users\Administrator\Desktop\NBD-FINAL\Views\WorkerReports\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Hours));

#line default
#line hidden
            EndContext();
            BeginContext(611, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(667, 37, false);
#line 23 "C:\Users\Administrator\Desktop\NBD-FINAL\Views\WorkerReports\Details.cshtml"
           Write(Html.DisplayFor(model => model.Hours));

#line default
#line hidden
            EndContext();
            BeginContext(704, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(760, 41, false);
#line 26 "C:\Users\Administrator\Desktop\NBD-FINAL\Views\WorkerReports\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Costs));

#line default
#line hidden
            EndContext();
            BeginContext(801, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(857, 37, false);
#line 29 "C:\Users\Administrator\Desktop\NBD-FINAL\Views\WorkerReports\Details.cshtml"
           Write(Html.DisplayFor(model => model.Costs));

#line default
#line hidden
            EndContext();
            BeginContext(894, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(950, 44, false);
#line 32 "C:\Users\Administrator\Desktop\NBD-FINAL\Views\WorkerReports\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.ExtCosts));

#line default
#line hidden
            EndContext();
            BeginContext(994, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1050, 40, false);
#line 35 "C:\Users\Administrator\Desktop\NBD-FINAL\Views\WorkerReports\Details.cshtml"
           Write(Html.DisplayFor(model => model.ExtCosts));

#line default
#line hidden
            EndContext();
            BeginContext(1090, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(1146, 40, false);
#line 38 "C:\Users\Administrator\Desktop\NBD-FINAL\Views\WorkerReports\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1186, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1242, 36, false);
#line 41 "C:\Users\Administrator\Desktop\NBD-FINAL\Views\WorkerReports\Details.cshtml"
           Write(Html.DisplayFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1278, 57, true);
            WriteLiteral("\r\n            </dd>\r\n\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(1336, 43, false);
#line 45 "C:\Users\Administrator\Desktop\NBD-FINAL\Views\WorkerReports\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Project));

#line default
#line hidden
            EndContext();
            BeginContext(1379, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1435, 44, false);
#line 48 "C:\Users\Administrator\Desktop\NBD-FINAL\Views\WorkerReports\Details.cshtml"
           Write(Html.DisplayFor(model => model.Project.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1479, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(1535, 40, false);
#line 51 "C:\Users\Administrator\Desktop\NBD-FINAL\Views\WorkerReports\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Task));

#line default
#line hidden
            EndContext();
            BeginContext(1575, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1631, 48, false);
#line 54 "C:\Users\Administrator\Desktop\NBD-FINAL\Views\WorkerReports\Details.cshtml"
           Write(Html.DisplayFor(model => model.Task.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1679, 80, true);
            WriteLiteral("\r\n            </dd>\r\n\r\n\r\n        </dl>\r\n\r\n    </div>\r\n</div>\r\n<br/>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1759, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99c59191bc44327ca39c9b69feb5567a0488779710907", async() => {
                BeginContext(1827, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 64 "C:\Users\Administrator\Desktop\NBD-FINAL\Views\WorkerReports\Details.cshtml"
                                                 WriteLiteral(Model.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1835, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1843, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99c59191bc44327ca39c9b69feb5567a0488779713330", async() => {
                BeginContext(1888, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1904, 14, true);
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NBD.Models.WorkerReport> Html { get; private set; }
    }
}
#pragma warning restore 1591
