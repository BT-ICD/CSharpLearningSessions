#pragma checksum "C:\Users\abc\source\repos\CSharpLearningSessions\WebApplicationMVC1\Views\RazorDemo\Names.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3312d73a045b30dd8b9b95c2dc4b113f0d2ae3b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RazorDemo_Names), @"mvc.1.0.view", @"/Views/RazorDemo/Names.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3312d73a045b30dd8b9b95c2dc4b113f0d2ae3b1", @"/Views/RazorDemo/Names.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20a195155aecd5ef40fa0ff84d79da2ff819511f", @"/Views/_ViewImports.cshtml")]
    public class Views_RazorDemo_Names : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\abc\source\repos\CSharpLearningSessions\WebApplicationMVC1\Views\RazorDemo\Names.cshtml"
  
    ViewData["Title"] = "Names";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Names</h1>\r\n");
#nullable restore
#line 7 "C:\Users\abc\source\repos\CSharpLearningSessions\WebApplicationMVC1\Views\RazorDemo\Names.cshtml"
  
    var i = ViewData["numTimes"] as int?;
    var name = ViewData["name"] as string;
    var address = ViewData["address"] as Address;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"card\">\r\n        <div class=\"card-header\">\r\n            ViewData Demo. To share value from a controller to view\r\n        </div>\r\n        <div class=\"card-body\">\r\n            <p>");
#nullable restore
#line 18 "C:\Users\abc\source\repos\CSharpLearningSessions\WebApplicationMVC1\Views\RazorDemo\Names.cshtml"
          Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>\r\n                Name: ");
#nullable restore
#line 20 "C:\Users\abc\source\repos\CSharpLearningSessions\WebApplicationMVC1\Views\RazorDemo\Names.cshtml"
                 Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n            <p>\r\n                Content of MessageData: ");
#nullable restore
#line 23 "C:\Users\abc\source\repos\CSharpLearningSessions\WebApplicationMVC1\Views\RazorDemo\Names.cshtml"
                                   Write(ViewData["MessageData"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n            <p>\r\n                Address\r\n            </p>\r\n            <p>Area: ");
#nullable restore
#line 28 "C:\Users\abc\source\repos\CSharpLearningSessions\WebApplicationMVC1\Views\RazorDemo\Names.cshtml"
                Write(address.Area);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>City: ");
#nullable restore
#line 29 "C:\Users\abc\source\repos\CSharpLearningSessions\WebApplicationMVC1\Views\RazorDemo\Names.cshtml"
                Write(address.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>State: ");
#nullable restore
#line 30 "C:\Users\abc\source\repos\CSharpLearningSessions\WebApplicationMVC1\Views\RazorDemo\Names.cshtml"
                 Write(address.State);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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