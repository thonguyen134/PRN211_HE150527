#pragma checksum "E:\StudyFPT Kì 5\PRN211\test\PRN211_HE150527\Assignment\Assignment_3_Nguyễn Đình Thọ_HE150527\eStore\eStore\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f9be8f71354527554dd45c5bcd77ed95cb68322"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#nullable restore
#line 1 "E:\StudyFPT Kì 5\PRN211\test\PRN211_HE150527\Assignment\Assignment_3_Nguyễn Đình Thọ_HE150527\eStore\eStore\Views\_ViewImports.cshtml"
using eStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\StudyFPT Kì 5\PRN211\test\PRN211_HE150527\Assignment\Assignment_3_Nguyễn Đình Thọ_HE150527\eStore\eStore\Views\_ViewImports.cshtml"
using eStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f9be8f71354527554dd45c5bcd77ed95cb68322", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56a326c9856d6b769aa8d0630ceb1b56b0595277", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DataAccess.DataAccess.Product>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\n");
#nullable restore
#line 3 "E:\StudyFPT Kì 5\PRN211\test\PRN211_HE150527\Assignment\Assignment_3_Nguyễn Đình Thọ_HE150527\eStore\eStore\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Product List</h1>\n\n<p>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f9be8f71354527554dd45c5bcd77ed95cb683223974", async() => {
                WriteLiteral("Create New");
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
            WriteLiteral("\n</p>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 17 "E:\StudyFPT Kì 5\PRN211\test\PRN211_HE150527\Assignment\Assignment_3_Nguyễn Đình Thọ_HE150527\eStore\eStore\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 20 "E:\StudyFPT Kì 5\PRN211\test\PRN211_HE150527\Assignment\Assignment_3_Nguyễn Đình Thọ_HE150527\eStore\eStore\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CategoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 23 "E:\StudyFPT Kì 5\PRN211\test\PRN211_HE150527\Assignment\Assignment_3_Nguyễn Đình Thọ_HE150527\eStore\eStore\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 26 "E:\StudyFPT Kì 5\PRN211\test\PRN211_HE150527\Assignment\Assignment_3_Nguyễn Đình Thọ_HE150527\eStore\eStore\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Weight));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 29 "E:\StudyFPT Kì 5\PRN211\test\PRN211_HE150527\Assignment\Assignment_3_Nguyễn Đình Thọ_HE150527\eStore\eStore\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UnitPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 32 "E:\StudyFPT Kì 5\PRN211\test\PRN211_HE150527\Assignment\Assignment_3_Nguyễn Đình Thọ_HE150527\eStore\eStore\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UnitInStock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 38 "E:\StudyFPT Kì 5\PRN211\test\PRN211_HE150527\Assignment\Assignment_3_Nguyễn Đình Thọ_HE150527\eStore\eStore\Views\Product\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 41 "E:\StudyFPT Kì 5\PRN211\test\PRN211_HE150527\Assignment\Assignment_3_Nguyễn Đình Thọ_HE150527\eStore\eStore\Views\Product\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProductId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 44 "E:\StudyFPT Kì 5\PRN211\test\PRN211_HE150527\Assignment\Assignment_3_Nguyễn Đình Thọ_HE150527\eStore\eStore\Views\Product\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CategoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 47 "E:\StudyFPT Kì 5\PRN211\test\PRN211_HE150527\Assignment\Assignment_3_Nguyễn Đình Thọ_HE150527\eStore\eStore\Views\Product\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 50 "E:\StudyFPT Kì 5\PRN211\test\PRN211_HE150527\Assignment\Assignment_3_Nguyễn Đình Thọ_HE150527\eStore\eStore\Views\Product\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Weight));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 53 "E:\StudyFPT Kì 5\PRN211\test\PRN211_HE150527\Assignment\Assignment_3_Nguyễn Đình Thọ_HE150527\eStore\eStore\Views\Product\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.UnitPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 56 "E:\StudyFPT Kì 5\PRN211\test\PRN211_HE150527\Assignment\Assignment_3_Nguyễn Đình Thọ_HE150527\eStore\eStore\Views\Product\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.UnitInStock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 59 "E:\StudyFPT Kì 5\PRN211\test\PRN211_HE150527\Assignment\Assignment_3_Nguyễn Đình Thọ_HE150527\eStore\eStore\Views\Product\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id = item.ProductId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n                ");
#nullable restore
#line 60 "E:\StudyFPT Kì 5\PRN211\test\PRN211_HE150527\Assignment\Assignment_3_Nguyễn Đình Thọ_HE150527\eStore\eStore\Views\Product\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id = item.ProductId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n                ");
#nullable restore
#line 61 "E:\StudyFPT Kì 5\PRN211\test\PRN211_HE150527\Assignment\Assignment_3_Nguyễn Đình Thọ_HE150527\eStore\eStore\Views\Product\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id = item.ProductId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n        </tr>\n");
#nullable restore
#line 64 "E:\StudyFPT Kì 5\PRN211\test\PRN211_HE150527\Assignment\Assignment_3_Nguyễn Đình Thọ_HE150527\eStore\eStore\Views\Product\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DataAccess.DataAccess.Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
