#pragma checksum "D:\фаис\ИТ-31\Курсовой проект\Data_Base_Bank\Data_Base_Bank\Views\Depositors\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25ba268efaa9ea188d7d62570ece89fad90bfe89"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Depositors_Details), @"mvc.1.0.view", @"/Views/Depositors/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Depositors/Details.cshtml", typeof(AspNetCore.Views_Depositors_Details))]
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
#line 1 "D:\фаис\ИТ-31\Курсовой проект\Data_Base_Bank\Data_Base_Bank\Views\_ViewImports.cshtml"
using Data_Base_Bank;

#line default
#line hidden
#line 2 "D:\фаис\ИТ-31\Курсовой проект\Data_Base_Bank\Data_Base_Bank\Views\_ViewImports.cshtml"
using Data_Base_Bank.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25ba268efaa9ea188d7d62570ece89fad90bfe89", @"/Views/Depositors/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bd3610628f8f281cbaf34777aae186b0f12c595", @"/Views/_ViewImports.cshtml")]
    public class Views_Depositors_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Data_Base_Bank.Models.Depositor>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Depositors", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\фаис\ИТ-31\Курсовой проект\Data_Base_Bank\Data_Base_Bank\Views\Depositors\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(84, 12, true);
            WriteLiteral("\r\n<h3>\r\n    ");
            EndContext();
            BeginContext(96, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01542e7880694686aeac3dab72320358", async() => {
                BeginContext(158, 4, true);
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
            BeginContext(166, 112, true);
            WriteLiteral("\r\n</h3>\r\n\r\n<div>\r\n    <h4>Depositor</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(279, 47, false);
#line 15 "D:\фаис\ИТ-31\Курсовой проект\Data_Base_Bank\Data_Base_Bank\Views\Depositors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DepositorID));

#line default
#line hidden
            EndContext();
            BeginContext(326, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(370, 43, false);
#line 18 "D:\фаис\ИТ-31\Курсовой проект\Data_Base_Bank\Data_Base_Bank\Views\Depositors\Details.cshtml"
       Write(Html.DisplayFor(model => model.DepositorID));

#line default
#line hidden
            EndContext();
            BeginContext(413, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(457, 43, false);
#line 21 "D:\фаис\ИТ-31\Курсовой проект\Data_Base_Bank\Data_Base_Bank\Views\Depositors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NameDep));

#line default
#line hidden
            EndContext();
            BeginContext(500, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(544, 39, false);
#line 24 "D:\фаис\ИТ-31\Курсовой проект\Data_Base_Bank\Data_Base_Bank\Views\Depositors\Details.cshtml"
       Write(Html.DisplayFor(model => model.NameDep));

#line default
#line hidden
            EndContext();
            BeginContext(583, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(627, 46, false);
#line 27 "D:\фаис\ИТ-31\Курсовой проект\Data_Base_Bank\Data_Base_Bank\Views\Depositors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SurnameDep));

#line default
#line hidden
            EndContext();
            BeginContext(673, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(717, 42, false);
#line 30 "D:\фаис\ИТ-31\Курсовой проект\Data_Base_Bank\Data_Base_Bank\Views\Depositors\Details.cshtml"
       Write(Html.DisplayFor(model => model.SurnameDep));

#line default
#line hidden
            EndContext();
            BeginContext(759, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(803, 49, false);
#line 33 "D:\фаис\ИТ-31\Курсовой проект\Data_Base_Bank\Data_Base_Bank\Views\Depositors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MiddlenameDep));

#line default
#line hidden
            EndContext();
            BeginContext(852, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(896, 45, false);
#line 36 "D:\фаис\ИТ-31\Курсовой проект\Data_Base_Bank\Data_Base_Bank\Views\Depositors\Details.cshtml"
       Write(Html.DisplayFor(model => model.MiddlenameDep));

#line default
#line hidden
            EndContext();
            BeginContext(941, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(985, 42, false);
#line 39 "D:\фаис\ИТ-31\Курсовой проект\Data_Base_Bank\Data_Base_Bank\Views\Depositors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Addres));

#line default
#line hidden
            EndContext();
            BeginContext(1027, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1071, 38, false);
#line 42 "D:\фаис\ИТ-31\Курсовой проект\Data_Base_Bank\Data_Base_Bank\Views\Depositors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Addres));

#line default
#line hidden
            EndContext();
            BeginContext(1109, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1153, 41, false);
#line 45 "D:\фаис\ИТ-31\Курсовой проект\Data_Base_Bank\Data_Base_Bank\Views\Depositors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1194, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1238, 37, false);
#line 48 "D:\фаис\ИТ-31\Курсовой проект\Data_Base_Bank\Data_Base_Bank\Views\Depositors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1275, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1319, 48, false);
#line 51 "D:\фаис\ИТ-31\Курсовой проект\Data_Base_Bank\Data_Base_Bank\Views\Depositors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Passportdata));

#line default
#line hidden
            EndContext();
            BeginContext(1367, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1411, 44, false);
#line 54 "D:\фаис\ИТ-31\Курсовой проект\Data_Base_Bank\Data_Base_Bank\Views\Depositors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Passportdata));

#line default
#line hidden
            EndContext();
            BeginContext(1455, 36, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n");
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