#pragma checksum "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\ViewerProfile\Departments\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "157060c9b7268e903de4c7de404cd2e15241e8a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(KSUWEBPMOCAP.Pages.Profiles.ViewerProfile.Departments.Pages_Profiles_ViewerProfile_Departments_Index), @"mvc.1.0.razor-page", @"/Pages/Profiles/ViewerProfile/Departments/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Profiles/ViewerProfile/Departments/Index.cshtml", typeof(KSUWEBPMOCAP.Pages.Profiles.ViewerProfile.Departments.Pages_Profiles_ViewerProfile_Departments_Index), null)]
namespace KSUWEBPMOCAP.Pages.Profiles.ViewerProfile.Departments
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"157060c9b7268e903de4c7de404cd2e15241e8a9", @"/Pages/Profiles/ViewerProfile/Departments/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c35a3e43e5e27c9e72d83a6001b2811d955a673", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Profiles_ViewerProfile_Departments_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(80, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\ViewerProfile\Departments\Index.cshtml"
  
    Layout = "/Pages/Shared/_Layout3.cshtml";
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(170, 34, true);
            WriteLiteral("\r\n<h1>Deparments</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(204, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "157060c9b7268e903de4c7de404cd2e15241e8a95033", async() => {
                BeginContext(225, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(239, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(332, 58, false);
#line 18 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\ViewerProfile\Departments\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Department[0].Dept_Num));

#line default
#line hidden
            EndContext();
            BeginContext(390, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(446, 59, false);
#line 21 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\ViewerProfile\Departments\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Department[0].Dept_Name));

#line default
#line hidden
            EndContext();
            BeginContext(505, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(561, 66, false);
#line 24 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\ViewerProfile\Departments\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Department[0].Faculty_LastName));

#line default
#line hidden
            EndContext();
            BeginContext(627, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 30 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\ViewerProfile\Departments\Index.cshtml"
 foreach (var item in Model.Department) {

#line default
#line hidden
            BeginContext(756, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(805, 43, false);
#line 33 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\ViewerProfile\Departments\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Dept_Num));

#line default
#line hidden
            EndContext();
            BeginContext(848, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(904, 44, false);
#line 36 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\ViewerProfile\Departments\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Dept_Name));

#line default
#line hidden
            EndContext();
            BeginContext(948, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1004, 51, false);
#line 39 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\ViewerProfile\Departments\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Faculty_LastName));

#line default
#line hidden
            EndContext();
            BeginContext(1055, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1110, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "157060c9b7268e903de4c7de404cd2e15241e8a99829", async() => {
                BeginContext(1160, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 42 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\ViewerProfile\Departments\Index.cshtml"
                                       WriteLiteral(item.Dept_ID);

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
            BeginContext(1168, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1188, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "157060c9b7268e903de4c7de404cd2e15241e8a912233", async() => {
                BeginContext(1241, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 43 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\ViewerProfile\Departments\Index.cshtml"
                                          WriteLiteral(item.Dept_ID);

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
            BeginContext(1252, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1272, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "157060c9b7268e903de4c7de404cd2e15241e8a914644", async() => {
                BeginContext(1324, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 44 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\ViewerProfile\Departments\Index.cshtml"
                                         WriteLiteral(item.Dept_ID);

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
            BeginContext(1334, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 47 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\ViewerProfile\Departments\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1373, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KSUWEBPMOCAP.Pages.Profiles.ViewerProfile.Departments.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<KSUWEBPMOCAP.Pages.Profiles.ViewerProfile.Departments.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<KSUWEBPMOCAP.Pages.Profiles.ViewerProfile.Departments.IndexModel>)PageContext?.ViewData;
        public KSUWEBPMOCAP.Pages.Profiles.ViewerProfile.Departments.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591