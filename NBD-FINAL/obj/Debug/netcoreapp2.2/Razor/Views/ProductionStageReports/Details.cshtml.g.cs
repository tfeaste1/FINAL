#pragma checksum "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\ProductionStageReports\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bdb24cc24e0635c2552c4621d829baac38261725"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductionStageReports_Details), @"mvc.1.0.view", @"/Views/ProductionStageReports/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ProductionStageReports/Details.cshtml", typeof(AspNetCore.Views_ProductionStageReports_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdb24cc24e0635c2552c4621d829baac38261725", @"/Views/ProductionStageReports/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"877786879ad765db0577617c19ecaf8320d35743", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductionStageReports_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NBD.Models.ProductionStageReport>
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
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\ProductionStageReports\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(86, 357, true);
            WriteLiteral(@"
<h1 align=""center"">Details</h1>

<div class=""card-columns align-content-center"">
    <div class=""card  align-content-center"" style=""width:400px; height:500px;"">
        <div class=""card-body"">
            <h4 class=""card-title"">Production Plan Details - Predicted</h4>

            <dl class=""card-body"">
                <dt>
                    ");
            EndContext();
            BeginContext(444, 39, false);
#line 16 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\ProductionStageReports\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Bid));

#line default
#line hidden
            EndContext();
            BeginContext(483, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(551, 35, false);
#line 19 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\ProductionStageReports\Details.cshtml"
               Write(Html.DisplayFor(model => model.Bid));

#line default
#line hidden
            EndContext();
            BeginContext(586, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(654, 47, false);
#line 22 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\ProductionStageReports\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.EstProdPlan));

#line default
#line hidden
            EndContext();
            BeginContext(701, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(769, 43, false);
#line 25 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\ProductionStageReports\Details.cshtml"
               Write(Html.DisplayFor(model => model.EstProdPlan));

#line default
#line hidden
            EndContext();
            BeginContext(812, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(880, 55, false);
#line 28 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\ProductionStageReports\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.EstimatedDesingCost));

#line default
#line hidden
            EndContext();
            BeginContext(935, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(1003, 51, false);
#line 31 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\ProductionStageReports\Details.cshtml"
               Write(Html.DisplayFor(model => model.EstimatedDesingCost));

#line default
#line hidden
            EndContext();
            BeginContext(1054, 85, true);
            WriteLiteral("\r\n                </dd>\r\n                \r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(1140, 52, false);
#line 35 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\ProductionStageReports\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.EstLaborProdCost));

#line default
#line hidden
            EndContext();
            BeginContext(1192, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(1260, 48, false);
#line 38 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\ProductionStageReports\Details.cshtml"
               Write(Html.DisplayFor(model => model.EstLaborProdCost));

#line default
#line hidden
            EndContext();
            BeginContext(1308, 83, true);
            WriteLiteral("\r\n                </dd>\r\n              \r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(1392, 54, false);
#line 42 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\ProductionStageReports\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.EstLaborDesingCost));

#line default
#line hidden
            EndContext();
            BeginContext(1446, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(1514, 50, false);
#line 45 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\ProductionStageReports\Details.cshtml"
               Write(Html.DisplayFor(model => model.EstLaborDesingCost));

#line default
#line hidden
            EndContext();
            BeginContext(1564, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(1632, 43, false);
#line 48 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\ProductionStageReports\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Project));

#line default
#line hidden
            EndContext();
            BeginContext(1675, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(1743, 44, false);
#line 51 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\ProductionStageReports\Details.cshtml"
               Write(Html.DisplayFor(model => model.Project.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1787, 345, true);
            WriteLiteral(@"
                </dd>

            </dl>
        </div>
    </div>

    <div class=""card  align-content-center"" style=""width:400px; height:500px;"">
        <div class=""card-body"">
            <h4 class=""card-title"">Production Plan Details - Confirmed</h4>
            <dl class=""card-body"">
                <dt>
                    ");
            EndContext();
            BeginContext(2133, 45, false);
#line 63 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\ProductionStageReports\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.ActualMtl));

#line default
#line hidden
            EndContext();
            BeginContext(2178, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(2246, 41, false);
#line 66 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\ProductionStageReports\Details.cshtml"
               Write(Html.DisplayFor(model => model.ActualMtl));

#line default
#line hidden
            EndContext();
            BeginContext(2287, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(2355, 48, false);
#line 69 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\ProductionStageReports\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.ActuLaborPro));

#line default
#line hidden
            EndContext();
            BeginContext(2403, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(2471, 44, false);
#line 72 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\ProductionStageReports\Details.cshtml"
               Write(Html.DisplayFor(model => model.ActuLaborPro));

#line default
#line hidden
            EndContext();
            BeginContext(2515, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(2583, 55, false);
#line 75 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\ProductionStageReports\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.ActuLaborDesingCost));

#line default
#line hidden
            EndContext();
            BeginContext(2638, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(2706, 51, false);
#line 78 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\ProductionStageReports\Details.cshtml"
               Write(Html.DisplayFor(model => model.ActuLaborDesingCost));

#line default
#line hidden
            EndContext();
            BeginContext(2757, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(2825, 51, false);
#line 81 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\ProductionStageReports\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.TotalCosttoDate));

#line default
#line hidden
            EndContext();
            BeginContext(2876, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(2944, 47, false);
#line 84 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\ProductionStageReports\Details.cshtml"
               Write(Html.DisplayFor(model => model.TotalCosttoDate));

#line default
#line hidden
            EndContext();
            BeginContext(2991, 93, true);
            WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(3084, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bdb24cc24e0635c2552c4621d829baac3826172514764", async() => {
                BeginContext(3152, 4, true);
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
#line 92 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\ProductionStageReports\Details.cshtml"
                                                 WriteLiteral(Model.Id);

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
            BeginContext(3160, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(3168, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bdb24cc24e0635c2552c4621d829baac3826172517208", async() => {
                BeginContext(3213, 12, true);
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
            BeginContext(3229, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NBD.Models.ProductionStageReport> Html { get; private set; }
    }
}
#pragma warning restore 1591
