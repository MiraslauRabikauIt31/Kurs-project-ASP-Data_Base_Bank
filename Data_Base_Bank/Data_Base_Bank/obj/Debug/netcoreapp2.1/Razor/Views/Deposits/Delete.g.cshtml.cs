#pragma checksum "D:\фаис\ИТ-31\РПБДИС\Lab5\Data_Base_Bank\Data_Base_Bank\Views\Deposits\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32ce59a1906d066a73605930fe7fb738caadd29b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Deposits_Delete), @"mvc.1.0.view", @"/Views/Deposits/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Deposits/Delete.cshtml", typeof(AspNetCore.Views_Deposits_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32ce59a1906d066a73605930fe7fb738caadd29b", @"/Views/Deposits/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bd3610628f8f281cbaf34777aae186b0f12c595", @"/Views/_ViewImports.cshtml")]
    public class Views_Deposits_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Data_Base_Bank.ViewModels.DepositsViewModel.DepositsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\фаис\ИТ-31\РПБДИС\Lab5\Data_Base_Bank\Data_Base_Bank\Views\Deposits\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(159, 187, true);
            WriteLiteral("\r\n<h2>Delete Deposit</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n\r\n<div>\r\n    <h4>DepositViewModel</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(347, 63, false);
#line 16 "D:\фаис\ИТ-31\РПБДИС\Lab5\Data_Base_Bank\Data_Base_Bank\Views\Deposits\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Deposits.First().DespositID));

#line default
#line hidden
            EndContext();
            BeginContext(410, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(454, 59, false);
#line 19 "D:\фаис\ИТ-31\РПБДИС\Lab5\Data_Base_Bank\Data_Base_Bank\Views\Deposits\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Deposits.First().DespositID));

#line default
#line hidden
            EndContext();
            BeginContext(513, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(557, 65, false);
#line 22 "D:\фаис\ИТ-31\РПБДИС\Lab5\Data_Base_Bank\Data_Base_Bank\Views\Deposits\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DepositViewModel.NameCurrency));

#line default
#line hidden
            EndContext();
            BeginContext(622, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(666, 70, false);
#line 25 "D:\фаис\ИТ-31\РПБДИС\Lab5\Data_Base_Bank\Data_Base_Bank\Views\Deposits\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Deposits.First().Currency.NameCurrency));

#line default
#line hidden
            EndContext();
            BeginContext(736, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(780, 60, false);
#line 28 "D:\фаис\ИТ-31\РПБДИС\Lab5\Data_Base_Bank\Data_Base_Bank\Views\Deposits\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DepositViewModel.NameDep));

#line default
#line hidden
            EndContext();
            BeginContext(840, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(884, 66, false);
#line 31 "D:\фаис\ИТ-31\РПБДИС\Lab5\Data_Base_Bank\Data_Base_Bank\Views\Deposits\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Deposits.First().Depositor.NameDep));

#line default
#line hidden
            EndContext();
            BeginContext(950, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(994, 61, false);
#line 34 "D:\фаис\ИТ-31\РПБДИС\Lab5\Data_Base_Bank\Data_Base_Bank\Views\Deposits\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DepositViewModel.NameType));

#line default
#line hidden
            EndContext();
            BeginContext(1055, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1099, 69, false);
#line 37 "D:\фаис\ИТ-31\РПБДИС\Lab5\Data_Base_Bank\Data_Base_Bank\Views\Deposits\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Deposits.First().Typedeposit.NameType));

#line default
#line hidden
            EndContext();
            BeginContext(1168, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1212, 61, false);
#line 40 "D:\фаис\ИТ-31\РПБДИС\Lab5\Data_Base_Bank\Data_Base_Bank\Views\Deposits\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DepositViewModel.NameEmpl));

#line default
#line hidden
            EndContext();
            BeginContext(1273, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1317, 66, false);
#line 43 "D:\фаис\ИТ-31\РПБДИС\Lab5\Data_Base_Bank\Data_Base_Bank\Views\Deposits\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Deposits.First().Employee.NameEmpl));

#line default
#line hidden
            EndContext();
            BeginContext(1383, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1427, 63, false);
#line 46 "D:\фаис\ИТ-31\РПБДИС\Lab5\Data_Base_Bank\Data_Base_Bank\Views\Deposits\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Deposits.First().Depositsum));

#line default
#line hidden
            EndContext();
            BeginContext(1490, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1534, 59, false);
#line 49 "D:\фаис\ИТ-31\РПБДИС\Lab5\Data_Base_Bank\Data_Base_Bank\Views\Deposits\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Deposits.First().Depositsum));

#line default
#line hidden
            EndContext();
            BeginContext(1593, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1637, 64, false);
#line 52 "D:\фаис\ИТ-31\РПБДИС\Lab5\Data_Base_Bank\Data_Base_Bank\Views\Deposits\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Deposits.First().Datedeposit));

#line default
#line hidden
            EndContext();
            BeginContext(1701, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1745, 60, false);
#line 55 "D:\фаис\ИТ-31\РПБДИС\Lab5\Data_Base_Bank\Data_Base_Bank\Views\Deposits\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Deposits.First().Datedeposit));

#line default
#line hidden
            EndContext();
            BeginContext(1805, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1849, 65, false);
#line 58 "D:\фаис\ИТ-31\РПБДИС\Lab5\Data_Base_Bank\Data_Base_Bank\Views\Deposits\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Deposits.First().Refundamount));

#line default
#line hidden
            EndContext();
            BeginContext(1914, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1958, 61, false);
#line 61 "D:\фаис\ИТ-31\РПБДИС\Lab5\Data_Base_Bank\Data_Base_Bank\Views\Deposits\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Deposits.First().Refundamount));

#line default
#line hidden
            EndContext();
            BeginContext(2019, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2063, 63, false);
#line 64 "D:\фаис\ИТ-31\РПБДИС\Lab5\Data_Base_Bank\Data_Base_Bank\Views\Deposits\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Deposits.First().Datereturn));

#line default
#line hidden
            EndContext();
            BeginContext(2126, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2170, 59, false);
#line 67 "D:\фаис\ИТ-31\РПБДИС\Lab5\Data_Base_Bank\Data_Base_Bank\Views\Deposits\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Deposits.First().Datereturn));

#line default
#line hidden
            EndContext();
            BeginContext(2229, 34, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n    ");
            EndContext();
            BeginContext(2263, 161, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3fd9d253ae6248a5aa4e2d380ee177e2", async() => {
                BeginContext(2289, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(2373, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da6e1c80f2ce4297afc7f42725b6098c", async() => {
                    BeginContext(2395, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2411, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2424, 8, true);
            WriteLiteral("\r\n</div>");
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
