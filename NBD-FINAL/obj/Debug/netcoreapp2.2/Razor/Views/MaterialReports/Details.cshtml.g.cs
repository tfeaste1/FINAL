#pragma checksum "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\MaterialReports\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d0795c44ae52ae2f94f87d6674dfa1c84275a53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MaterialReports_Details), @"mvc.1.0.view", @"/Views/MaterialReports/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MaterialReports/Details.cshtml", typeof(AspNetCore.Views_MaterialReports_Details))]
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
#line 1 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\_ViewImports.cshtml"
using NBD;

#line default
#line hidden
#line 2 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\_ViewImports.cshtml"
using NBD.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d0795c44ae52ae2f94f87d6674dfa1c84275a53", @"/Views/MaterialReports/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"877786879ad765db0577617c19ecaf8320d35743", @"/Views/_ViewImports.cshtml")]
    public class Views_MaterialReports_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NBD.Models.MaterialReport>
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
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\MaterialReports\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(79, 22, true);
            WriteLiteral("\r\n<h4 align=\"center \">");
            EndContext();
            BeginContext(102, 44, false);
#line 7 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\MaterialReports\Details.cshtml"
               Write(Html.DisplayFor(model => model.Project.Name));

#line default
#line hidden
            EndContext();
            BeginContext(146, 294, true);
            WriteLiteral(@"  </h4>
<h3 align=""center""> Material Report Details</h3>

<div class=""card  align-content-center"" style=""width:400px; height:500px;"">
    <div class=""card-body"">
        <h4 class=""card-title"">Material Report Details</h4>
        <dl class=""card-body"">
            <dt>
                ");
            EndContext();
            BeginContext(441, 44, false);
#line 15 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\MaterialReports\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Material));

#line default
#line hidden
            EndContext();
            BeginContext(485, 56, true);
            WriteLiteral(":\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(542, 52, false);
#line 18 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\MaterialReports\Details.cshtml"
           Write(Html.DisplayFor(model => model.Material.Description));

#line default
#line hidden
            EndContext();
            BeginContext(594, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(650, 44, false);
#line 21 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\MaterialReports\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(694, 56, true);
            WriteLiteral(":\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(751, 40, false);
#line 24 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\MaterialReports\Details.cshtml"
           Write(Html.DisplayFor(model => model.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(791, 57, true);
            WriteLiteral("\r\n            </dd>\r\n\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(849, 41, false);
#line 28 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\MaterialReports\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Costs));

#line default
#line hidden
            EndContext();
            BeginContext(890, 60, true);
            WriteLiteral(" ($):\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(951, 37, false);
#line 31 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\MaterialReports\Details.cshtml"
           Write(Html.DisplayFor(model => model.Costs));

#line default
#line hidden
            EndContext();
            BeginContext(988, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(1044, 44, false);
#line 34 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\MaterialReports\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.ExtCosts));

#line default
#line hidden
            EndContext();
            BeginContext(1088, 60, true);
            WriteLiteral(" ($):\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1149, 40, false);
#line 37 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\MaterialReports\Details.cshtml"
           Write(Html.DisplayFor(model => model.ExtCosts));

#line default
#line hidden
            EndContext();
            BeginContext(1189, 144, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                Approved by:\r\n\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n\r\n                ");
            EndContext();
            BeginContext(1334, 49, false);
#line 45 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\MaterialReports\Details.cshtml"
           Write(Html.DisplayFor(model => model.Employee.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(1383, 108, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n\r\n\r\n        </dl>\r\n\r\n    </div>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1491, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d0795c44ae52ae2f94f87d6674dfa1c84275a539592", async() => {
                BeginContext(1559, 4, true);
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
#line 55 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\MaterialReports\Details.cshtml"
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
            BeginContext(1567, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1575, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d0795c44ae52ae2f94f87d6674dfa1c84275a5312028", async() => {
                BeginContext(1620, 12, true);
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
            BeginContext(1636, 16, true);
            WriteLiteral("\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NBD.Models.MaterialReport> Html { get; private set; }
    }
}
#pragma warning restore 1591
