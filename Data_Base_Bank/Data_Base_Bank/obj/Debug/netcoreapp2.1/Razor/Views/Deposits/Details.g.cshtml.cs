#pragma checksum "D:\фаис\ИТ-31\РПБДИС\Lab5\Data_Base_Bank\Data_Base_Bank\Views\Deposits\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a041365a77e31792e9f8daeec739c87419247f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Deposits_Details), @"mvc.1.0.view", @"/Views/Deposits/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Deposits/Details.cshtml", typeof(AspNetCore.Views_Deposits_Details))]
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
#line 1 "D:\фаис\ИТ-31\РПБДИС\Lab5\Data_Base_Bank\Data_Base_Bank\Views\_ViewImports.cshtml"
using Data_Base_Bank;

#line default
#line hidden
#line 2 "D:\фаис\ИТ-31\РПБДИС\Lab5\Data_Base_Bank\Data_Base_Bank\Views\_ViewImports.cshtml"
using Data_Base_Bank.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a041365a77e31792e9f8daeec739c87419247f2", @"/Views/Deposits/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bd3610628f8f281cbaf34777aae186b0f12c595", @"/Views/_ViewImports.cshtml")]
    public class Views_Deposits_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Data_Base_Bank.ViewModels.DepositsViewModel.DepositsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Deposits", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\фаис\ИТ-31\РПБДИС\Lab5\Data_Base_Bank\Data_Base_Bank\Views\Deposits\Details.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(159, 12, true);
            WriteLiteral("\r\n<h3>\r\n    ");
            EndContext();
            BeginContext(171, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94cc40c6702b448b89cdee26f34f06f3", async() => {
                BeginContext(231, 4, true);
                WriteLiteral("Back");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(239, 119, true);
            WriteLiteral("\r\n</h3>\r\n\r\n<div>\r\n    <h4>DepositViewModel</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(359, 63, false);
#line 16 "D:\фаис\ИТ-31\РПБДИС\Lab5\Data_Base_Bank\Data_Base_Bank\Views\Deposits\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Deposits.First().DespositID));

#line default
#line hidden
            EndContext();
            BeginContext(422, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(466, 59, false);
#line 19 "D:\фаис\ИТ-31\РПБДИС\Lab5\Data_Base_Bank\Data_Base_Bank\Views\Deposits\Details.cshtml"
       Write(Html.DisplayFor(model => model.Deposits.First().DespositID));

#line default
#line hidden
            EndContext();
            BeginContext(525, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(569, 65, false);
#line 22 "D:\фаис\ИТ-31\РПБДИС\Lab5\Data_Base_Bank\Data_Base_Bank\Views\Deposits\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DepositViewModel.NameCurrency));

#line default
#line hidden
            EndContext();
            BeginContext(634, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(678, 70, false);
#line 25 "D:\фаис\ИТ-31\РПБДИС\Lab5\Data_Base_Bank\Data_Base_Bank\Views\Deposits\Details.cshtml"
       Write(Html.DisplayFor(model => model.Deposits.First().Currency.NameCurrency));

#line default
#line hidden
            EndContext();
            BeginContext(748, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(792, 60, false);
#line 28 "D:\фаис\ИТ-31\РПБДИС\Lab5\Data_Base_Bank\Data_Base_Bank\Views\Deposits\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DepositViewModel.NameDep));

#line default
#line hidden
            EndContext();
            BeginContext(852, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(896, 66, false);
#line 31 "D:\фаис\ИТ-31\РПБДИС\Lab5\Data_Base_Bank\Data_Base_Bank\Views\Deposits\Details.cshtml"
       Write(Html.DisplayFor(model => model.Deposits.First().Depositor.NameDep));

#line default
#line hidden
            EndContext();
            BeginContext(962, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1006, 61, false);
#line 34 "D:\фаис\ИТ-31\РПБДИС\Lab5\Data_Base_Bank\Data_Base_Bank\Views\Deposits\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DepositViewModel.NameType));

#line default
#line hidden
            EndContext();
            BeginContext(1067, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1111, 69, false);
#line 37 "D:\фаис\ИТ-31\РПБДИС\Lab5\Data_Base_Bank\Data_Base_Bank\Views\Deposits\Details.cshtml"
       Write(Html.DisplayFor(model => model.Deposits.First().Typedeposit.NameType));

#line default
#line hidden
            EndContext();
            BeginContext(1180, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1224, 61, false);
#line 40 "D:\фаис\ИТ-31\РПБДИС\Lab5\Data_Base_Bank\Data_Base_Bank\Views\Deposits\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DepositViewModel.NameEmpl));

#line default
#line hidden
            EndContext();
            BeginContext(1285, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1329, 66, false);
#line 43 "D:\фаис\ИТ-31\РПБДИС\Lab5\Data_Base_Bank\Data_Base_Bank\Views\Deposits\Details.cshtml"
       Write(Html.DisplayFor(model => model.Deposits.First().Employee.NameEmpl));

#line default
#line hidden
            EndContext();
            BeginContext(1395, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1439, 63, false);
#line 46 "D:\фаис\ИТ-31\РПБДИС\Lab5\Data_Base_Bank\Data_Base_Bank\Views\Deposits\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Deposits.First().Depositsum));

#line default
#line hidden
            EndContext();
            BeginContext(1502, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1546, 59, false);
#line 49 "D:\фаис\ИТ-31\РПБДИС\Lab5\Data_Base_Bank\Data_Base_Bank\Views\Deposits\Details.cshtml"
       Write(Html.DisplayFor(model => model.Deposits.First().Depositsum));

#line default
#line hidden
            EndContext();
            BeginContext(1605, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1649, 64, false);
#line 52 "D:\фаис\ИТ-31\РПБДИС\Lab5\Data_Base_Bank\Data_Base_Bank\Views\Deposits\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Deposits.First().Datedeposit));

#line default
#line hidden
            EndContext();
            BeginContext(1713, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1757, 60, false);
#line 55 "D:\фаис\ИТ-31\РПБДИС\Lab5\Data_Base_Bank\Data_Base_Bank\Views\Deposits\Details.cshtml"
       Write(Html.DisplayFor(model => model.Deposits.First().Datedeposit));

#line default
#line hidden
            EndContext();
            BeginContext(1817, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1861, 65, false);
#line 58 "D:\фаис\ИТ-31\РПБДИС\Lab5\Data_Base_Bank\Data_Base_Bank\Views\Deposits\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Deposits.First().Refundamount));

#line default
#line hidden
            EndContext();
            BeginContext(1926, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1970, 61, false);
#line 61 "D:\фаис\ИТ-31\РПБДИС\Lab5\Data_Base_Bank\Data_Base_Bank\Views\Deposits\Details.cshtml"
       Write(Html.DisplayFor(model => model.Deposits.First().Refundamount));

#line default
#line hidden
            EndContext();
            BeginContext(2031, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2075, 63, false);
#line 64 "D:\фаис\ИТ-31\РПБДИС\Lab5\Data_Base_Bank\Data_Base_Bank\Views\Deposits\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Deposits.First().Datereturn));

#line default
#line hidden
            EndContext();
            BeginContext(2138, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2182, 59, false);
#line 67 "D:\фаис\ИТ-31\РПБДИС\Lab5\Data_Base_Bank\Data_Base_Bank\Views\Deposits\Details.cshtml"
       Write(Html.DisplayFor(model => model.Deposits.First().Datereturn));

#line default
#line hidden
            EndContext();
            BeginContext(2241, 34, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Data_Base_Bank.ViewModels.DepositsViewModel.DepositsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
