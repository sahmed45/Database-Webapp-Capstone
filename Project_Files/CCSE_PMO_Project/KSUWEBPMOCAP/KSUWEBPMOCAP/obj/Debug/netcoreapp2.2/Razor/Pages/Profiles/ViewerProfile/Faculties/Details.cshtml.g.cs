#pragma checksum "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\ViewerProfile\Faculties\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56284d26cae21e754f39f458ca440f48e3395de8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(KSUWEBPMOCAP.Pages.Profiles.ViewerProfile.Faculties.Pages_Profiles_ViewerProfile_Faculties_Details), @"mvc.1.0.razor-page", @"/Pages/Profiles/ViewerProfile/Faculties/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Profiles/ViewerProfile/Faculties/Details.cshtml", typeof(KSUWEBPMOCAP.Pages.Profiles.ViewerProfile.Faculties.Pages_Profiles_ViewerProfile_Faculties_Details), null)]
namespace KSUWEBPMOCAP.Pages.Profiles.ViewerProfile.Faculties
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56284d26cae21e754f39f458ca440f48e3395de8", @"/Pages/Profiles/ViewerProfile/Faculties/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c35a3e43e5e27c9e72d83a6001b2811d955a673", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Profiles_ViewerProfile_Faculties_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
            BeginContext(80, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\ViewerProfile\Faculties\Details.cshtml"
  
    Layout = "/Pages/Shared/_Layout3.cshtml";
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(172, 128, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Faculty</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(301, 50, false);
#line 16 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\ViewerProfile\Faculties\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Faculty.Net_ID));

#line default
#line hidden
            EndContext();
            BeginContext(351, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(413, 46, false);
#line 19 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\ViewerProfile\Faculties\Details.cshtml"
       Write(Html.DisplayFor(model => model.Faculty.Net_ID));

#line default
#line hidden
            EndContext();
            BeginContext(459, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(520, 60, false);
#line 22 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\ViewerProfile\Faculties\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Faculty.Faculty_LastName));

#line default
#line hidden
            EndContext();
            BeginContext(580, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(642, 56, false);
#line 25 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\ViewerProfile\Faculties\Details.cshtml"
       Write(Html.DisplayFor(model => model.Faculty.Faculty_LastName));

#line default
#line hidden
            EndContext();
            BeginContext(698, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(759, 61, false);
#line 28 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\ViewerProfile\Faculties\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Faculty.Faculty_FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(820, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(882, 57, false);
#line 31 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\ViewerProfile\Faculties\Details.cshtml"
       Write(Html.DisplayFor(model => model.Faculty.Faculty_FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(939, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1000, 57, false);
#line 34 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\ViewerProfile\Faculties\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Faculty.Faculty_Email));

#line default
#line hidden
            EndContext();
            BeginContext(1057, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1119, 53, false);
#line 37 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\ViewerProfile\Faculties\Details.cshtml"
       Write(Html.DisplayFor(model => model.Faculty.Faculty_Email));

#line default
#line hidden
            EndContext();
            BeginContext(1172, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1233, 53, false);
#line 40 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\ViewerProfile\Faculties\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Faculty.Dept_Name));

#line default
#line hidden
            EndContext();
            BeginContext(1286, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1348, 49, false);
#line 43 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\ViewerProfile\Faculties\Details.cshtml"
       Write(Html.DisplayFor(model => model.Faculty.Dept_Name));

#line default
#line hidden
            EndContext();
            BeginContext(1397, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1444, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56284d26cae21e754f39f458ca440f48e3395de89419", async() => {
                BeginContext(1506, 4, true);
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
#line 48 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\ViewerProfile\Faculties\Details.cshtml"
                           WriteLiteral(Model.Faculty.Faculty_ID);

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
            BeginContext(1514, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1522, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56284d26cae21e754f39f458ca440f48e3395de811810", async() => {
                BeginContext(1544, 12, true);
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
            BeginContext(1560, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KSUWEBPMOCAP.Pages.Profiles.ViewerProfile.Faculties.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<KSUWEBPMOCAP.Pages.Profiles.ViewerProfile.Faculties.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<KSUWEBPMOCAP.Pages.Profiles.ViewerProfile.Faculties.DetailsModel>)PageContext?.ViewData;
        public KSUWEBPMOCAP.Pages.Profiles.ViewerProfile.Faculties.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
