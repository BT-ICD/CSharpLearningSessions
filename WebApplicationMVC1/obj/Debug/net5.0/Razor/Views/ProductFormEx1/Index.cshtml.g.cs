#pragma checksum "C:\Users\abc\source\repos\CSharpLearningSessions\WebApplicationMVC1\Views\ProductFormEx1\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc0abcebe6f5a9df5af856f619dde425bd4bff45"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductFormEx1_Index), @"mvc.1.0.view", @"/Views/ProductFormEx1/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc0abcebe6f5a9df5af856f619dde425bd4bff45", @"/Views/ProductFormEx1/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20a195155aecd5ef40fa0ff84d79da2ff819511f", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductFormEx1_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\abc\source\repos\CSharpLearningSessions\WebApplicationMVC1\Views\ProductFormEx1\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"card\">\r\n");
#nullable restore
#line 8 "C:\Users\abc\source\repos\CSharpLearningSessions\WebApplicationMVC1\Views\ProductFormEx1\Index.cshtml"
         using (Html.BeginForm())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""card-header"">
                Add new product details
            </div>
            <div class=""card-body"">
                <div class=""row"">
                    Id: <input type=""text"" name=""Id"" />
                </div>
                <div class=""row"">
                    Name: <input type=""text"" name=""Name"" />
                </div>
                <div class=""row"">
                    Category: <input type=""text"" name=""Category"" />
                </div>
                <div class=""row"">
                    Rate: <input type=""number"" name=""Rate"" />
                </div>
            </div>
            <div class=""card-footer"">
                <input type=""submit"" value=""Submit""/>            
            </div>
");
#nullable restore
#line 30 "C:\Users\abc\source\repos\CSharpLearningSessions\WebApplicationMVC1\Views\ProductFormEx1\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n</div>");
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
