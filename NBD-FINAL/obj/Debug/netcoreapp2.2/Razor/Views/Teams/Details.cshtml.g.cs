#pragma checksum "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\Teams\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "edcde89ddb3d7a8eadcbecc15520718565c05669"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teams_Details), @"mvc.1.0.view", @"/Views/Teams/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Teams/Details.cshtml", typeof(AspNetCore.Views_Teams_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edcde89ddb3d7a8eadcbecc15520718565c05669", @"/Views/Teams/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"877786879ad765db0577617c19ecaf8320d35743", @"/Views/_ViewImports.cshtml")]
    public class Views_Teams_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NBD.Models.Team>
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
            BeginContext(24, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\Teams\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(69, 312, true);
            WriteLiteral(@"
<h1 align=""center"">Details</h1>

<div class=""card-columns"">
    <div class=""card  align-content-center "" style=""width:400px; height:500px;"">
        <div class=""card-body"">
            <h4 class=""card-title"">Team Details</h4>
            <dl class=""card-body"">
                <dt>
                    ");
            EndContext();
            BeginContext(382, 44, false);
#line 15 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\Teams\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.TeamName));

#line default
#line hidden
            EndContext();
            BeginContext(426, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(494, 40, false);
#line 18 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\Teams\Details.cshtml"
               Write(Html.DisplayFor(model => model.TeamName));

#line default
#line hidden
            EndContext();
            BeginContext(534, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(602, 41, false);
#line 21 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\Teams\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Phase));

#line default
#line hidden
            EndContext();
            BeginContext(643, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(711, 37, false);
#line 24 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\Teams\Details.cshtml"
               Write(Html.DisplayFor(model => model.Phase));

#line default
#line hidden
            EndContext();
            BeginContext(748, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(816, 44, false);
#line 27 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\Teams\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Projects));

#line default
#line hidden
            EndContext();
            BeginContext(860, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(928, 62, false);
#line 30 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\Teams\Details.cshtml"
               Write(Html.DisplayFor(model => model.Projects.FirstOrDefault().Name));

#line default
#line hidden
            EndContext();
            BeginContext(990, 233, true);
            WriteLiteral("\r\n                </dd>\r\n\r\n\r\n            </dl>\r\n\r\n        </div>\r\n\r\n    </div>\r\n\r\n\r\n    <div class=\"card  align-content-center\" style=\"width:400px; height:500px;\">\r\n        <div class=\"card-body\">\r\n            <h4 class=\"card-title\">");
            EndContext();
            BeginContext(1224, 40, false);
#line 43 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\Teams\Details.cshtml"
                              Write(Html.DisplayFor(model => model.TeamName));

#line default
#line hidden
            EndContext();
            BeginContext(1264, 24, true);
            WriteLiteral("</h4>\r\n            <p>\r\n");
            EndContext();
#line 45 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\Teams\Details.cshtml"
                 foreach (var item in Model.TeamEmployees)
                {
                    

#line default
#line hidden
            BeginContext(1388, 52, false);
#line 47 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\Teams\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Employee.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(1440, 8, true);
            WriteLiteral(" <br/>\r\n");
            EndContext();
#line 48 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\Teams\Details.cshtml"
                }

#line default
#line hidden
            BeginContext(1467, 85, true);
            WriteLiteral("\r\n\r\n            </p>\r\n\r\n\r\n        </div>\r\n\r\n\r\n    </div>\r\n\r\n\r\n</div>\r\n    \r\n\r\n<div>\r\n");
            EndContext();
            BeginContext(1552, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "edcde89ddb3d7a8eadcbecc15520718565c056699250", async() => {
                BeginContext(1620, 4, true);
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
#line 64 "C:\Users\Weird.Scar\Documents\GitHub\FINAL\NBD-FINAL\Views\Teams\Details.cshtml"
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
            BeginContext(1628, 4, true);
            WriteLiteral(" |\r\n");
            EndContext();
            BeginContext(1632, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "edcde89ddb3d7a8eadcbecc15520718565c0566911668", async() => {
                BeginContext(1677, 12, true);
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
            BeginContext(1693, 14, true);
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
            EndContext();
            BeginContext(3086, 7, true);
            WriteLiteral("     \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NBD.Models.Team> Html { get; private set; }
    }
}
#pragma warning restore 1591
