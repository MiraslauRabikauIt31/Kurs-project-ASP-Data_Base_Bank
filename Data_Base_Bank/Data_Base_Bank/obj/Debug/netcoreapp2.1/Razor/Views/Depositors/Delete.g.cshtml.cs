#pragma checksum "D:\фаис\ИТ-31\РПБДИС\Lab5\Data_Base_Bank\Data_Base_Bank\Views\Depositors\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57564447e97ff009913f3a2df11532b908f4a458"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Depositors_Delete), @"mvc.1.0.view", @"/Views/Depositors/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Depositors/Delete.cshtml", typeof(AspNetCore.Views_Depositors_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57564447e97ff009913f3a2df11532b908f4a458", @"/Views/Depositors/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bd3610628f8f281cbaf34777aae186b0f12c595", @"/Views/_ViewImports.cshtml")]
    public class Views_Depositors_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Data_Base_Bank.Models.Depositor>
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
#line 2 "D:\фаис\ИТ-31\РПБДИС\Lab5\Data_Base_Bank\Data_Base_Bank\Views\Depositors\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(129, 179, true);
            WriteLiteral("\r\n<h2>DeleteDepositor</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Depositor</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(309, 47, false);
#line 15 "D:\фаис\ИТ-31\РПБДИС\Lab5\Data_Base_Bank\Data_Base_Bank\Views\Depositors\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DepositorID));

#line default
#line hidden
            EndContext();
            BeginContext(356, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(400, 43, false);
#line 18 "D:\фаис\ИТ-31\РПБДИС\Lab5\Data_Base_Bank\Data_Base_Bank\Views\Depositors\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DepositorID));

#line default
#line hidden
            EndContext();
            BeginContext(443, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(487, 43, false);
#line 21 "D:\фаис\ИТ-31\РПБДИС\Lab5\Data_Base_Bank\Data_Base_Bank\Views\Depositors\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NameDep));

#line default
#line hidden
            EndContext();
            BeginContext(530, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(574, 39, false);
#line 24 "D:\фаис\ИТ-31\РПБДИС\Lab5\Data_Base_Bank\Data_Base_Bank\Views\Depositors\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NameDep));

#line default
#line hidden
            EndContext();
            BeginContext(613, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(657, 46, false);
#line 27 "D:\фаис\ИТ-31\РПБДИС\Lab5\Data_Base_Bank\Data_Base_Bank\Views\Depositors\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SurnameDep));

#line default
#line hidden
            EndContext();
            BeginContext(703, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(747, 42, false);
#line 30 "D:\фаис\ИТ-31\РПБДИС\Lab5\Data_Base_Bank\Data_Base_Bank\Views\Depositors\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SurnameDep));

#line default
#line hidden
            EndContext();
            BeginContext(789, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(833, 49, false);
#line 33 "D:\фаис\ИТ-31\РПБДИС\Lab5\Data_Base_Bank\Data_Base_Bank\Views\Depositors\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MiddlenameDep));

#line default
#line hidden
            EndContext();
            BeginContext(882, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(926, 45, false);
#line 36 "D:\фаис\ИТ-31\РПБДИС\Lab5\Data_Base_Bank\Data_Base_Bank\Views\Depositors\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MiddlenameDep));

#line default
#line hidden
            EndContext();
            BeginContext(971, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1015, 42, false);
#line 39 "D:\фаис\ИТ-31\РПБДИС\Lab5\Data_Base_Bank\Data_Base_Bank\Views\Depositors\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Addres));

#line default
#line hidden
            EndContext();
            BeginContext(1057, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1101, 38, false);
#line 42 "D:\фаис\ИТ-31\РПБДИС\Lab5\Data_Base_Bank\Data_Base_Bank\Views\Depositors\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Addres));

#line default
#line hidden
            EndContext();
            BeginContext(1139, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1183, 41, false);
#line 45 "D:\фаис\ИТ-31\РПБДИС\Lab5\Data_Base_Bank\Data_Base_Bank\Views\Depositors\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1224, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1268, 37, false);
#line 48 "D:\фаис\ИТ-31\РПБДИС\Lab5\Data_Base_Bank\Data_Base_Bank\Views\Depositors\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1305, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1349, 48, false);
#line 51 "D:\фаис\ИТ-31\РПБДИС\Lab5\Data_Base_Bank\Data_Base_Bank\Views\Depositors\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Passportdata));

#line default
#line hidden
            EndContext();
            BeginContext(1397, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1441, 44, false);
#line 54 "D:\фаис\ИТ-31\РПБДИС\Lab5\Data_Base_Bank\Data_Base_Bank\Views\Depositors\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Passportdata));

#line default
#line hidden
            EndContext();
            BeginContext(1485, 34, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n    ");
            EndContext();
            BeginContext(1519, 161, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95fdff7e65e243f2b1ee65fb06c98965", async() => {
                BeginContext(1545, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(1629, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5a619ff7db54b1d8de062af38d8088b", async() => {
                    BeginContext(1651, 12, true);
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
                BeginContext(1667, 6, true);
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
            BeginContext(1680, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Data_Base_Bank.Models.Depositor> Html { get; private set; }
    }
}
#pragma warning restore 1591
