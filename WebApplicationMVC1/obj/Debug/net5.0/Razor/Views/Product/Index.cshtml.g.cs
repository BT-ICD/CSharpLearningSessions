#pragma checksum "C:\Users\abc\source\repos\CSharpLearningSessions\WebApplicationMVC1\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8371e3f8370aaca797cb9caa94ded7ad65b795a"
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
#line 1 "C:\Users\abc\source\repos\CSharpLearningSessions\WebApplicationMVC1\Views\_ViewImports.cshtml"
using WebApplicationMVC1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\abc\source\repos\CSharpLearningSessions\WebApplicationMVC1\Views\_ViewImports.cshtml"
using WebApplicationMVC1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8371e3f8370aaca797cb9caa94ded7ad65b795a", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20a195155aecd5ef40fa0ff84d79da2ff819511f", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\abc\source\repos\CSharpLearningSessions\WebApplicationMVC1\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""card"">
        <div class=""card-header"">
            Product Index
        </div>
        <div class=""card-body"">
            <div class=""card-title"">
                Allows user to access product list with details of product
            </div>
            <div class=""card-body"">
                <p>");
#nullable restore
#line 16 "C:\Users\abc\source\repos\CSharpLearningSessions\WebApplicationMVC1\Views\Product\Index.cshtml"
              Write(Html.ActionLink("Product List", "List", "Product"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                <p>");
#nullable restore
#line 17 "C:\Users\abc\source\repos\CSharpLearningSessions\WebApplicationMVC1\Views\Product\Index.cshtml"
              Write(Html.ActionLink("Product cards", "ListWithImages", "Product"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n            </div>\r\n\r\n        </div>\r\n        <div class=\"card-footer\">\r\n\r\n        </div>\r\n    </div>\r\n</div> \r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
