#pragma checksum "C:\Users\BHAVIN\Source\Repos\BT-ICD\CSharpLearningSessions\WebApplicationMVC1\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bcf6a0f070d1f1677903ed05c3af8c413f24d78c"
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
#line 1 "C:\Users\BHAVIN\Source\Repos\BT-ICD\CSharpLearningSessions\WebApplicationMVC1\Views\_ViewImports.cshtml"
using WebApplicationMVC1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\BHAVIN\Source\Repos\BT-ICD\CSharpLearningSessions\WebApplicationMVC1\Views\_ViewImports.cshtml"
using WebApplicationMVC1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bcf6a0f070d1f1677903ed05c3af8c413f24d78c", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20a195155aecd5ef40fa0ff84d79da2ff819511f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\BHAVIN\Source\Repos\BT-ICD\CSharpLearningSessions\WebApplicationMVC1\Views\Product\Index.cshtml"
  
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
#line 16 "C:\Users\BHAVIN\Source\Repos\BT-ICD\CSharpLearningSessions\WebApplicationMVC1\Views\Product\Index.cshtml"
              Write(Html.ActionLink("Product List", "List", "Product"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                <p>");
#nullable restore
#line 17 "C:\Users\BHAVIN\Source\Repos\BT-ICD\CSharpLearningSessions\WebApplicationMVC1\Views\Product\Index.cshtml"
              Write(Html.ActionLink("Product cards", "ListWithImages", "Product"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                <p>");
#nullable restore
#line 18 "C:\Users\BHAVIN\Source\Repos\BT-ICD\CSharpLearningSessions\WebApplicationMVC1\Views\Product\Index.cshtml"
              Write(Html.ActionLink("Find Product","Find"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n\r\n        </div>\r\n        <div class=\"card-footer\">\r\n\r\n        </div>\r\n    </div>\r\n</div> \r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
