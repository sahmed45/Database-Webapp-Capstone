#pragma checksum "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\UserProfile\Projects\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3efb1241f35b19032f71b3228406fbfbc9d503e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(KSUWEBPMOCAP.Pages.Profiles.UserProfile.Projects.Pages_Profiles_UserProfile_Projects_Details), @"mvc.1.0.razor-page", @"/Pages/Profiles/UserProfile/Projects/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Profiles/UserProfile/Projects/Details.cshtml", typeof(KSUWEBPMOCAP.Pages.Profiles.UserProfile.Projects.Pages_Profiles_UserProfile_Projects_Details), null)]
namespace KSUWEBPMOCAP.Pages.Profiles.UserProfile.Projects
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\_ViewImports.cshtml"
using KSUWEBPMOCAP;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3efb1241f35b19032f71b3228406fbfbc9d503e", @"/Pages/Profiles/UserProfile/Projects/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c35a3e43e5e27c9e72d83a6001b2811d955a673", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Profiles_UserProfile_Projects_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(77, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\UserProfile\Projects\Details.cshtml"
  
    Layout = "/Pages/Shared/_Layout2.cshtml";
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(169, 128, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Project</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(298, 55, false);
#line 16 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\UserProfile\Projects\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Project.Project_Num));

#line default
#line hidden
            EndContext();
            BeginContext(353, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(415, 51, false);
#line 19 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\UserProfile\Projects\Details.cshtml"
       Write(Html.DisplayFor(model => model.Project.Project_Num));

#line default
#line hidden
            EndContext();
            BeginContext(466, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(527, 53, false);
#line 22 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\UserProfile\Projects\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Project.Proj_Type));

#line default
#line hidden
            EndContext();
            BeginContext(580, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(642, 49, false);
#line 25 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\UserProfile\Projects\Details.cshtml"
       Write(Html.DisplayFor(model => model.Project.Proj_Type));

#line default
#line hidden
            EndContext();
            BeginContext(691, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(752, 63, false);
#line 28 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\UserProfile\Projects\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Project.Num_Teams_Sponsored));

#line default
#line hidden
            EndContext();
            BeginContext(815, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(877, 59, false);
#line 31 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\UserProfile\Projects\Details.cshtml"
       Write(Html.DisplayFor(model => model.Project.Num_Teams_Sponsored));

#line default
#line hidden
            EndContext();
            BeginContext(936, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(997, 63, false);
#line 34 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\UserProfile\Projects\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Project.Project_Description));

#line default
#line hidden
            EndContext();
            BeginContext(1060, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1122, 59, false);
#line 37 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\UserProfile\Projects\Details.cshtml"
       Write(Html.DisplayFor(model => model.Project.Project_Description));

#line default
#line hidden
            EndContext();
            BeginContext(1181, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1242, 64, false);
#line 40 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\UserProfile\Projects\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Project.Proj_Sponsor_Benefit));

#line default
#line hidden
            EndContext();
            BeginContext(1306, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1368, 60, false);
#line 43 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\UserProfile\Projects\Details.cshtml"
       Write(Html.DisplayFor(model => model.Project.Proj_Sponsor_Benefit));

#line default
#line hidden
            EndContext();
            BeginContext(1428, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1489, 64, false);
#line 46 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\UserProfile\Projects\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Project.Proj_Student_Benefit));

#line default
#line hidden
            EndContext();
            BeginContext(1553, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1615, 60, false);
#line 49 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\UserProfile\Projects\Details.cshtml"
       Write(Html.DisplayFor(model => model.Project.Proj_Student_Benefit));

#line default
#line hidden
            EndContext();
            BeginContext(1675, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1736, 55, false);
#line 52 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\UserProfile\Projects\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Project.Proj_hasNDA));

#line default
#line hidden
            EndContext();
            BeginContext(1791, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1853, 51, false);
#line 55 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\UserProfile\Projects\Details.cshtml"
       Write(Html.DisplayFor(model => model.Project.Proj_hasNDA));

#line default
#line hidden
            EndContext();
            BeginContext(1904, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1965, 53, false);
#line 58 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\UserProfile\Projects\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Project.StartDate));

#line default
#line hidden
            EndContext();
            BeginContext(2018, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2080, 49, false);
#line 61 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\UserProfile\Projects\Details.cshtml"
       Write(Html.DisplayFor(model => model.Project.StartDate));

#line default
#line hidden
            EndContext();
            BeginContext(2129, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2190, 51, false);
#line 64 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\UserProfile\Projects\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Project.EndDate));

#line default
#line hidden
            EndContext();
            BeginContext(2241, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2303, 47, false);
#line 67 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\UserProfile\Projects\Details.cshtml"
       Write(Html.DisplayFor(model => model.Project.EndDate));

#line default
#line hidden
            EndContext();
            BeginContext(2350, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2411, 56, false);
#line 70 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\UserProfile\Projects\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Project.Sponsor_Name));

#line default
#line hidden
            EndContext();
            BeginContext(2467, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2529, 52, false);
#line 73 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\UserProfile\Projects\Details.cshtml"
       Write(Html.DisplayFor(model => model.Project.Sponsor_Name));

#line default
#line hidden
            EndContext();
            BeginContext(2581, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2642, 60, false);
#line 76 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\UserProfile\Projects\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Project.Faculty_LastName));

#line default
#line hidden
            EndContext();
            BeginContext(2702, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2764, 56, false);
#line 79 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\UserProfile\Projects\Details.cshtml"
       Write(Html.DisplayFor(model => model.Project.Faculty_LastName));

#line default
#line hidden
            EndContext();
            BeginContext(2820, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2881, 53, false);
#line 82 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\UserProfile\Projects\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Project.Dept_Name));

#line default
#line hidden
            EndContext();
            BeginContext(2934, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2996, 49, false);
#line 85 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\UserProfile\Projects\Details.cshtml"
       Write(Html.DisplayFor(model => model.Project.Dept_Name));

#line default
#line hidden
            EndContext();
            BeginContext(3045, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(3092, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3efb1241f35b19032f71b3228406fbfbc9d503e16214", async() => {
                BeginContext(3154, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 90 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\UserProfile\Projects\Details.cshtml"
                           WriteLiteral(Model.Project.Project_ID);

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
            BeginContext(3162, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(3170, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3efb1241f35b19032f71b3228406fbfbc9d503e18603", async() => {
                BeginContext(3192, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3208, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KSUWEBPMOCAP.Pages.Profiles.UserProfile.Projects.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<KSUWEBPMOCAP.Pages.Profiles.UserProfile.Projects.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<KSUWEBPMOCAP.Pages.Profiles.UserProfile.Projects.DetailsModel>)PageContext?.ViewData;
        public KSUWEBPMOCAP.Pages.Profiles.UserProfile.Projects.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
