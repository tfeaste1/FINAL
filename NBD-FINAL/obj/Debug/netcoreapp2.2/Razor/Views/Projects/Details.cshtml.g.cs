#pragma checksum "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\Projects\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a396b1b9409cc5a713e6199bd3e0ce0f5aace86"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Projects_Details), @"mvc.1.0.view", @"/Views/Projects/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Projects/Details.cshtml", typeof(AspNetCore.Views_Projects_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a396b1b9409cc5a713e6199bd3e0ce0f5aace86", @"/Views/Projects/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"877786879ad765db0577617c19ecaf8320d35743", @"/Views/_ViewImports.cshtml")]
    public class Views_Projects_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NBD.Models.Project>
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
            BeginContext(27, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\Projects\Details.cshtml"
  
    ViewData["Title"] = "Details";
    NBD.Models.LabourRequirement labour = (NBD.Models.LabourRequirement)ViewBag.LaborRequirement;

#line default
#line hidden
            BeginContext(171, 30, true);
            WriteLiteral("\r\n    <h1 class=\"text-center\">");
            EndContext();
            BeginContext(202, 36, false);
#line 8 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\Projects\Details.cshtml"
                       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(238, 339, true);
            WriteLiteral(@"</h1>

    <div class=""card-columns align-content-center"">
        <div class=""card  align-content-center"" style=""width:400px; height:500px;"">
            <div class=""card-body"">
                <h4 class=""card-title"">Project Bid Details</h4>
                <dl class=""card-body"">
                    <dt>
                        ");
            EndContext();
            BeginContext(578, 47, false);
#line 16 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\Projects\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.ProjBidDate));

#line default
#line hidden
            EndContext();
            BeginContext(625, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(705, 43, false);
#line 19 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\Projects\Details.cshtml"
                   Write(Html.DisplayFor(model => model.ProjBidDate));

#line default
#line hidden
            EndContext();
            BeginContext(748, 79, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(828, 48, false);
#line 22 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\Projects\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.EstStartDate));

#line default
#line hidden
            EndContext();
            BeginContext(876, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(956, 44, false);
#line 25 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\Projects\Details.cshtml"
                   Write(Html.DisplayFor(model => model.EstStartDate));

#line default
#line hidden
            EndContext();
            BeginContext(1000, 79, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(1080, 46, false);
#line 28 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\Projects\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.EstEndDate));

#line default
#line hidden
            EndContext();
            BeginContext(1126, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(1206, 42, false);
#line 31 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\Projects\Details.cshtml"
                   Write(Html.DisplayFor(model => model.EstEndDate));

#line default
#line hidden
            EndContext();
            BeginContext(1248, 79, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(1328, 45, false);
#line 34 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\Projects\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.EstAmount));

#line default
#line hidden
            EndContext();
            BeginContext(1373, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(1453, 41, false);
#line 37 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\Projects\Details.cshtml"
                   Write(Html.DisplayFor(model => model.EstAmount));

#line default
#line hidden
            EndContext();
            BeginContext(1494, 367, true);
            WriteLiteral(@"
                    </dd>

                </dl>

            </div>

        </div>
        <div class=""card  align-content-center"" style=""width:400px; height:500px;"">
            <div class=""card-body"">
                <h4 class=""card-title"">Project Details</h4>
                <dl class=""card-body"">
                    <dt>
                        ");
            EndContext();
            BeginContext(1862, 40, false);
#line 50 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\Projects\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1902, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(1982, 36, false);
#line 53 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\Projects\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2018, 79, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(2098, 45, false);
#line 56 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\Projects\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.StartDate));

#line default
#line hidden
            EndContext();
            BeginContext(2143, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(2223, 41, false);
#line 59 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\Projects\Details.cshtml"
                   Write(Html.DisplayFor(model => model.StartDate));

#line default
#line hidden
            EndContext();
            BeginContext(2264, 79, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(2344, 43, false);
#line 62 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\Projects\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.EndDate));

#line default
#line hidden
            EndContext();
            BeginContext(2387, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(2467, 39, false);
#line 65 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\Projects\Details.cshtml"
                   Write(Html.DisplayFor(model => model.EndDate));

#line default
#line hidden
            EndContext();
            BeginContext(2506, 79, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(2586, 44, false);
#line 68 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\Projects\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.ProjSite));

#line default
#line hidden
            EndContext();
            BeginContext(2630, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(2710, 40, false);
#line 71 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\Projects\Details.cshtml"
                   Write(Html.DisplayFor(model => model.ProjSite));

#line default
#line hidden
            EndContext();
            BeginContext(2750, 79, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(2830, 45, false);
#line 74 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\Projects\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.ActAmount));

#line default
#line hidden
            EndContext();
            BeginContext(2875, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(2955, 41, false);
#line 77 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\Projects\Details.cshtml"
                   Write(Html.DisplayFor(model => model.ActAmount));

#line default
#line hidden
            EndContext();
            BeginContext(2996, 79, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(3076, 52, false);
#line 80 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\Projects\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.ProjCurrentPhase));

#line default
#line hidden
            EndContext();
            BeginContext(3128, 99, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"font-italic\">\r\n                        ");
            EndContext();
            BeginContext(3228, 48, false);
#line 83 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\Projects\Details.cshtml"
                   Write(Html.DisplayFor(model => model.ProjCurrentPhase));

#line default
#line hidden
            EndContext();
            BeginContext(3276, 79, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(3356, 42, false);
#line 86 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\Projects\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.TeamID));

#line default
#line hidden
            EndContext();
            BeginContext(3398, 84, true);
            WriteLiteral("\r\n                    </dt>\r\n                     <dd>\r\n                            ");
            EndContext();
            BeginContext(3483, 45, false);
#line 89 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\Projects\Details.cshtml"
                       Write(Html.DisplayFor(model => model.Team.TeamName));

#line default
#line hidden
            EndContext();
            BeginContext(3528, 284, true);
            WriteLiteral(@"
                        </dd>
                    


                </dl>

            </div>

        </div>
        <div class=""card  align-content-center "" style=""width:400px; height:500px;"">
            <div class=""card-body"">
                <h4 class=""card-title"">");
            EndContext();
            BeginContext(3813, 50, false);
#line 101 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\Projects\Details.cshtml"
                                  Write(Html.DisplayNameFor(model => model.ProjectLabours));

#line default
#line hidden
            EndContext();
            BeginContext(3863, 29, true);
            WriteLiteral("</h4>\r\n                <dl>\r\n");
            EndContext();
#line 103 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\Projects\Details.cshtml"
                   foreach (var item in Model.ProjectLabours)
                {

#line default
#line hidden
            BeginContext(3974, 50, true);
            WriteLiteral("                    <dd>\r\n                        ");
            EndContext();
            BeginContext(4025, 69, false);
#line 106 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\Projects\Details.cshtml"
                   Write(Html.DisplayFor(modelItem => item.LabourRequirement.Task.Description));

#line default
#line hidden
            EndContext();
            BeginContext(4094, 175, true);
            WriteLiteral("\r\n\r\n                    </dd>\r\n                    <dt>\r\n                        Estimated Date:\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(4270, 60, false);
#line 113 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\Projects\Details.cshtml"
                   Write(Html.DisplayFor(modelItem => item.LabourRequirement.EstDate));

#line default
#line hidden
            EndContext();
            BeginContext(4330, 174, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        Estimated Hours:\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(4505, 61, false);
#line 119 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\Projects\Details.cshtml"
                   Write(Html.DisplayFor(modelItem => item.LabourRequirement.EstHours));

#line default
#line hidden
            EndContext();
            BeginContext(4566, 29, true);
            WriteLiteral("\r\n                    </dd>\r\n");
            EndContext();
#line 121 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\Projects\Details.cshtml"



                }

#line default
#line hidden
            BeginContext(4620, 235, true);
            WriteLiteral("                        </dl>\r\n\r\n            </div>\r\n\r\n        </div>\r\n\r\n        <div class=\"card  align-content-center \" style=\"width:400px; height:500px;\">\r\n            <div class=\"card-body\">\r\n                <h4 class=\"card-title\">");
            EndContext();
            BeginContext(4856, 52, false);
#line 133 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\Projects\Details.cshtml"
                                  Write(Html.DisplayNameFor(model => model.ProjectMaterials));

#line default
#line hidden
            EndContext();
            BeginContext(4908, 48, true);
            WriteLiteral("</h4>\r\n                <dl>\r\n                  *");
            EndContext();
#line 135 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\Projects\Details.cshtml"
                    foreach (var item in Model.ProjectMaterials)
        {

#line default
#line hidden
            BeginContext(5014, 34, true);
            WriteLiteral("            <dd>\r\n                ");
            EndContext();
            BeginContext(5049, 85, false);
#line 138 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\Projects\Details.cshtml"
           Write(Html.DisplayFor(modelItem => item.MaterialRequirement.Inventory.Material.Description));

#line default
#line hidden
            EndContext();
            BeginContext(5134, 130, true);
            WriteLiteral("\r\n\r\n            </dd>\r\n            <dt>\r\n                Installation Date:\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(5265, 66, false);
#line 145 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\Projects\Details.cshtml"
           Write(Html.DisplayFor(modelItem => item.MaterialRequirement.InstallDate));

#line default
#line hidden
            EndContext();
            BeginContext(5331, 124, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                Delivery Date:\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(5456, 67, false);
#line 151 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\Projects\Details.cshtml"
           Write(Html.DisplayFor(modelItem => item.MaterialRequirement.DeliveryDate));

#line default
#line hidden
            EndContext();
            BeginContext(5523, 128, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                Estimated Quantity\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(5652, 66, false);
#line 157 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\Projects\Details.cshtml"
           Write(Html.DisplayFor(modelItem => item.MaterialRequirement.EstQuantity));

#line default
#line hidden
            EndContext();
            BeginContext(5718, 21, true);
            WriteLiteral("\r\n            </dd>\r\n");
            EndContext();
#line 159 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\Projects\Details.cshtml"

        }

#line default
#line hidden
            BeginContext(5750, 90, true);
            WriteLiteral("*\r\n                </dl>\r\n\r\n            </div>\r\n\r\n\r\n\r\n        </div>\r\n    </div>\r\n  \r\n    ");
            EndContext();
            BeginContext(5840, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a396b1b9409cc5a713e6199bd3e0ce0f5aace8622209", async() => {
                BeginContext(5908, 4, true);
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
#line 170 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\Projects\Details.cshtml"
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
            BeginContext(5916, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(5924, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a396b1b9409cc5a713e6199bd3e0ce0f5aace8624640", async() => {
                BeginContext(5969, 12, true);
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
            BeginContext(5985, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NBD.Models.Project> Html { get; private set; }
    }
}
#pragma warning restore 1591
