#pragma checksum "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\AdminProfile\ProjectReportView\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f04eb0f38546cf55e9f6f1d091b211d5f8451601"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(KSUWEBPMOCAP.Pages.Profiles.AdminProfile.ProjectReportView.Pages_Profiles_AdminProfile_ProjectReportView_Delete), @"mvc.1.0.razor-page", @"/Pages/Profiles/AdminProfile/ProjectReportView/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Profiles/AdminProfile/ProjectReportView/Delete.cshtml", typeof(KSUWEBPMOCAP.Pages.Profiles.AdminProfile.ProjectReportView.Pages_Profiles_AdminProfile_ProjectReportView_Delete), null)]
namespace KSUWEBPMOCAP.Pages.Profiles.AdminProfile.ProjectReportView
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f04eb0f38546cf55e9f6f1d091b211d5f8451601", @"/Pages/Profiles/AdminProfile/ProjectReportView/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c35a3e43e5e27c9e72d83a6001b2811d955a673", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Profiles_AdminProfile_ProjectReportView_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(60, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\AdminProfile\ProjectReportView\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(104, 175, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Project</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(280, 55, false);
#line 16 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\AdminProfile\ProjectReportView\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Project.Project_Num));

#line default
#line hidden
            EndContext();
            BeginContext(335, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(397, 51, false);
#line 19 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\AdminProfile\ProjectReportView\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Project.Project_Num));

#line default
#line hidden
            EndContext();
            BeginContext(448, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(509, 53, false);
#line 22 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\AdminProfile\ProjectReportView\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Project.Proj_Type));

#line default
#line hidden
            EndContext();
            BeginContext(562, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(624, 49, false);
#line 25 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\AdminProfile\ProjectReportView\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Project.Proj_Type));

#line default
#line hidden
            EndContext();
            BeginContext(673, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(734, 63, false);
#line 28 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\AdminProfile\ProjectReportView\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Project.Num_Teams_Sponsored));

#line default
#line hidden
            EndContext();
            BeginContext(797, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(859, 59, false);
#line 31 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\AdminProfile\ProjectReportView\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Project.Num_Teams_Sponsored));

#line default
#line hidden
            EndContext();
            BeginContext(918, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(979, 63, false);
#line 34 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\AdminProfile\ProjectReportView\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Project.Project_Description));

#line default
#line hidden
            EndContext();
            BeginContext(1042, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1104, 59, false);
#line 37 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\AdminProfile\ProjectReportView\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Project.Project_Description));

#line default
#line hidden
            EndContext();
            BeginContext(1163, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1224, 64, false);
#line 40 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\AdminProfile\ProjectReportView\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Project.Proj_Sponsor_Benefit));

#line default
#line hidden
            EndContext();
            BeginContext(1288, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1350, 60, false);
#line 43 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\AdminProfile\ProjectReportView\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Project.Proj_Sponsor_Benefit));

#line default
#line hidden
            EndContext();
            BeginContext(1410, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1471, 64, false);
#line 46 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\AdminProfile\ProjectReportView\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Project.Proj_Student_Benefit));

#line default
#line hidden
            EndContext();
            BeginContext(1535, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1597, 60, false);
#line 49 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\AdminProfile\ProjectReportView\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Project.Proj_Student_Benefit));

#line default
#line hidden
            EndContext();
            BeginContext(1657, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1718, 55, false);
#line 52 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\AdminProfile\ProjectReportView\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Project.Proj_hasNDA));

#line default
#line hidden
            EndContext();
            BeginContext(1773, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1835, 51, false);
#line 55 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\AdminProfile\ProjectReportView\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Project.Proj_hasNDA));

#line default
#line hidden
            EndContext();
            BeginContext(1886, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1947, 53, false);
#line 58 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\AdminProfile\ProjectReportView\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Project.StartDate));

#line default
#line hidden
            EndContext();
            BeginContext(2000, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2062, 49, false);
#line 61 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\AdminProfile\ProjectReportView\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Project.StartDate));

#line default
#line hidden
            EndContext();
            BeginContext(2111, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2172, 51, false);
#line 64 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\AdminProfile\ProjectReportView\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Project.EndDate));

#line default
#line hidden
            EndContext();
            BeginContext(2223, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2285, 47, false);
#line 67 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\AdminProfile\ProjectReportView\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Project.EndDate));

#line default
#line hidden
            EndContext();
            BeginContext(2332, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2393, 56, false);
#line 70 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\AdminProfile\ProjectReportView\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Project.Sponsor_Name));

#line default
#line hidden
            EndContext();
            BeginContext(2449, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2511, 52, false);
#line 73 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\AdminProfile\ProjectReportView\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Project.Sponsor_Name));

#line default
#line hidden
            EndContext();
            BeginContext(2563, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2624, 60, false);
#line 76 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\AdminProfile\ProjectReportView\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Project.Faculty_LastName));

#line default
#line hidden
            EndContext();
            BeginContext(2684, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2746, 56, false);
#line 79 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\AdminProfile\ProjectReportView\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Project.Faculty_LastName));

#line default
#line hidden
            EndContext();
            BeginContext(2802, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2863, 53, false);
#line 82 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\AdminProfile\ProjectReportView\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Project.Dept_Name));

#line default
#line hidden
            EndContext();
            BeginContext(2916, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2978, 49, false);
#line 85 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\AdminProfile\ProjectReportView\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Project.Dept_Name));

#line default
#line hidden
            EndContext();
            BeginContext(3027, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(3065, 216, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f04eb0f38546cf55e9f6f1d091b211d5f845160117226", async() => {
                BeginContext(3085, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(3095, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f04eb0f38546cf55e9f6f1d091b211d5f845160117619", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 90 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\AdminProfile\ProjectReportView\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Project.Project_ID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3147, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(3230, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f04eb0f38546cf55e9f6f1d091b211d5f845160119603", async() => {
                    BeginContext(3252, 12, true);
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
                BeginContext(3268, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3281, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KSUWEBPMOCAP.Pages.ProjectReport.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<KSUWEBPMOCAP.Pages.ProjectReport.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<KSUWEBPMOCAP.Pages.ProjectReport.DeleteModel>)PageContext?.ViewData;
        public KSUWEBPMOCAP.Pages.ProjectReport.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
