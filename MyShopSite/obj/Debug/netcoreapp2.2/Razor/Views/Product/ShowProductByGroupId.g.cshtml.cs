#pragma checksum "C:\Users\mohammad\Documents\Visual Studio 2010\Projects\MyShopSite\MyShopSite\Views\Product\ShowProductByGroupId.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f796789c90974367a3f5a75dacd52c0812b38dea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ShowProductByGroupId), @"mvc.1.0.view", @"/Views/Product/ShowProductByGroupId.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/ShowProductByGroupId.cshtml", typeof(AspNetCore.Views_Product_ShowProductByGroupId))]
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
#line 1 "C:\Users\mohammad\Documents\Visual Studio 2010\Projects\MyShopSite\MyShopSite\Views\_ViewImports.cshtml"
using MyShopSite;

#line default
#line hidden
#line 2 "C:\Users\mohammad\Documents\Visual Studio 2010\Projects\MyShopSite\MyShopSite\Views\_ViewImports.cshtml"
using MyShopSite.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f796789c90974367a3f5a75dacd52c0812b38dea", @"/Views/Product/ShowProductByGroupId.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e4f54c5326a557f63fbf10bebc5e157db0b5fba", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ShowProductByGroupId : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_BoxProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\mohammad\Documents\Visual Studio 2010\Projects\MyShopSite\MyShopSite\Views\Product\ShowProductByGroupId.cshtml"
  
    ViewData["Title"] = ViewData["GroupName"];

#line default
#line hidden
            BeginContext(86, 19, true);
            WriteLiteral("\r\n<h1>محصولات گروه ");
            EndContext();
            BeginContext(106, 21, false);
#line 7 "C:\Users\mohammad\Documents\Visual Studio 2010\Projects\MyShopSite\MyShopSite\Views\Product\ShowProductByGroupId.cshtml"
            Write(ViewData["GroupName"]);

#line default
#line hidden
            EndContext();
            BeginContext(127, 34, true);
            WriteLiteral("</h1>\r\n<hr />\r\n<div class=\"row\">\r\n");
            EndContext();
#line 10 "C:\Users\mohammad\Documents\Visual Studio 2010\Projects\MyShopSite\MyShopSite\Views\Product\ShowProductByGroupId.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(202, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(210, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f796789c90974367a3f5a75dacd52c0812b38dea4742", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 12 "C:\Users\mohammad\Documents\Visual Studio 2010\Projects\MyShopSite\MyShopSite\Views\Product\ShowProductByGroupId.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(254, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 13 "C:\Users\mohammad\Documents\Visual Studio 2010\Projects\MyShopSite\MyShopSite\Views\Product\ShowProductByGroupId.cshtml"
    }

#line default
#line hidden
            BeginContext(263, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
