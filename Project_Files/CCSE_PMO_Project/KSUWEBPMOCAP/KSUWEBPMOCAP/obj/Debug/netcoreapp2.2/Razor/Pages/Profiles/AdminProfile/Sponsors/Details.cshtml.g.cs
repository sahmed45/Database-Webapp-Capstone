#pragma checksum "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\AdminProfile\Sponsors\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "931a3fa17209cdcf9af462b3a2b186ba8eaf2041"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(KSUWEBPMOCAP.Pages.Profiles.AdminProfile.Sponsors.Pages_Profiles_AdminProfile_Sponsors_Details), @"mvc.1.0.razor-page", @"/Pages/Profiles/AdminProfile/Sponsors/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Profiles/AdminProfile/Sponsors/Details.cshtml", typeof(KSUWEBPMOCAP.Pages.Profiles.AdminProfile.Sponsors.Pages_Profiles_AdminProfile_Sponsors_Details), null)]
namespace KSUWEBPMOCAP.Pages.Profiles.AdminProfile.Sponsors
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"931a3fa17209cdcf9af462b3a2b186ba8eaf2041", @"/Pages/Profiles/AdminProfile/Sponsors/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c35a3e43e5e27c9e72d83a6001b2811d955a673", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Profiles_AdminProfile_Sponsors_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
            BeginContext(78, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\AdminProfile\Sponsors\Details.cshtml"
  
    Layout = "/Pages/Shared/_Layout1.cshtml";
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(170, 128, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Sponsor</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(299, 56, false);
#line 16 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\AdminProfile\Sponsors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Sponsor.Sponsor_Name));

#line default
#line hidden
            EndContext();
            BeginContext(355, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(417, 52, false);
#line 19 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\AdminProfile\Sponsors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Sponsor.Sponsor_Name));

#line default
#line hidden
            EndContext();
            BeginContext(469, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(530, 57, false);
#line 22 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\AdminProfile\Sponsors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Sponsor.Sponsor_Title));

#line default
#line hidden
            EndContext();
            BeginContext(587, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(649, 53, false);
#line 25 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\AdminProfile\Sponsors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Sponsor.Sponsor_Title));

#line default
#line hidden
            EndContext();
            BeginContext(702, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(763, 55, false);
#line 28 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\AdminProfile\Sponsors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Sponsor.Sponsor_Org));

#line default
#line hidden
            EndContext();
            BeginContext(818, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(880, 51, false);
#line 31 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\AdminProfile\Sponsors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Sponsor.Sponsor_Org));

#line default
#line hidden
            EndContext();
            BeginContext(931, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(992, 57, false);
#line 34 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\AdminProfile\Sponsors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Sponsor.Sponsor_Email));

#line default
#line hidden
            EndContext();
            BeginContext(1049, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1111, 53, false);
#line 37 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\AdminProfile\Sponsors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Sponsor.Sponsor_Email));

#line default
#line hidden
            EndContext();
            BeginContext(1164, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1225, 57, false);
#line 40 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\AdminProfile\Sponsors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Sponsor.Sponsor_Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1282, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1344, 53, false);
#line 43 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\AdminProfile\Sponsors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Sponsor.Sponsor_Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1397, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1458, 59, false);
#line 46 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\AdminProfile\Sponsors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Sponsor.Sponsor_Address));

#line default
#line hidden
            EndContext();
            BeginContext(1517, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1579, 55, false);
#line 49 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\AdminProfile\Sponsors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Sponsor.Sponsor_Address));

#line default
#line hidden
            EndContext();
            BeginContext(1634, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1695, 59, false);
#line 52 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\AdminProfile\Sponsors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Sponsor.Sponsor_Website));

#line default
#line hidden
            EndContext();
            BeginContext(1754, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1816, 55, false);
#line 55 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\AdminProfile\Sponsors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Sponsor.Sponsor_Website));

#line default
#line hidden
            EndContext();
            BeginContext(1871, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1918, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "931a3fa17209cdcf9af462b3a2b186ba8eaf204111344", async() => {
                BeginContext(1980, 4, true);
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
#line 60 "C:\Users\frKin\Desktop\C#Projects\PORTAL&GUI\PORTAL&GUI\KSUWEBPMOCAP\KSUWEBPMOCAP\Pages\Profiles\AdminProfile\Sponsors\Details.cshtml"
                           WriteLiteral(Model.Sponsor.Sponsor_ID);

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
            BeginContext(1988, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1996, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "931a3fa17209cdcf9af462b3a2b186ba8eaf204113734", async() => {
                BeginContext(2018, 12, true);
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
            BeginContext(2034, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KSUWEBPMOCAP.Pages.Profiles.AdminProfile.Sponsors.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<KSUWEBPMOCAP.Pages.Profiles.AdminProfile.Sponsors.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<KSUWEBPMOCAP.Pages.Profiles.AdminProfile.Sponsors.DetailsModel>)PageContext?.ViewData;
        public KSUWEBPMOCAP.Pages.Profiles.AdminProfile.Sponsors.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
