#pragma checksum "C:\Users\abc\source\repos\CSharpLearningSessions\WebApplicationMVC1\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3de5f5567aed7150c5d0953bd6e3657a470c755f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3de5f5567aed7150c5d0953bd6e3657a470c755f", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20a195155aecd5ef40fa0ff84d79da2ff819511f", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Employee>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\abc\source\repos\CSharpLearningSessions\WebApplicationMVC1\Views\Employee\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n");
#nullable restore
#line 11 "C:\Users\abc\source\repos\CSharpLearningSessions\WebApplicationMVC1\Views\Employee\Index.cshtml"
     using (Html.BeginForm())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card\">\r\n            <div class=\"card-header\">\r\n                Add New Employee\r\n            </div>\r\n            <div class=\"card-body\">\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 19 "C:\Users\abc\source\repos\CSharpLearningSessions\WebApplicationMVC1\Views\Employee\Index.cshtml"
               Write(Html.LabelFor(m => m.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 20 "C:\Users\abc\source\repos\CSharpLearningSessions\WebApplicationMVC1\Views\Employee\Index.cshtml"
               Write(Html.TextBoxFor(m => m.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 23 "C:\Users\abc\source\repos\CSharpLearningSessions\WebApplicationMVC1\Views\Employee\Index.cshtml"
               Write(Html.LabelFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 24 "C:\Users\abc\source\repos\CSharpLearningSessions\WebApplicationMVC1\Views\Employee\Index.cshtml"
               Write(Html.TextBoxFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 27 "C:\Users\abc\source\repos\CSharpLearningSessions\WebApplicationMVC1\Views\Employee\Index.cshtml"
               Write(Html.LabelFor(m => m.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 28 "C:\Users\abc\source\repos\CSharpLearningSessions\WebApplicationMVC1\Views\Employee\Index.cshtml"
               Write(Html.RadioButtonFor(m => m.Gender, "Male"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Male\r\n                    ");
#nullable restore
#line 29 "C:\Users\abc\source\repos\CSharpLearningSessions\WebApplicationMVC1\Views\Employee\Index.cshtml"
               Write(Html.RadioButtonFor(m => m.Gender, "Female"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Female\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 32 "C:\Users\abc\source\repos\CSharpLearningSessions\WebApplicationMVC1\Views\Employee\Index.cshtml"
               Write(Html.LabelFor(m => m.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 33 "C:\Users\abc\source\repos\CSharpLearningSessions\WebApplicationMVC1\Views\Employee\Index.cshtml"
               Write(Html.CheckBoxFor(m => m.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    Demo for Html.CheckBox\r\n                    <span> | Is new: </span> ");
#nullable restore
#line 37 "C:\Users\abc\source\repos\CSharpLearningSessions\WebApplicationMVC1\Views\Employee\Index.cshtml"
                                        Write(Html.CheckBox("IsNew", true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    Demo for Dropdown\r\n                    Department: ");
#nullable restore
#line 41 "C:\Users\abc\source\repos\CSharpLearningSessions\WebApplicationMVC1\Views\Employee\Index.cshtml"
                           Write(Html.DropDownListFor(m => m.Department, new SelectList(Enum.GetValues(typeof(DepartmentEnum))), "Select Department"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    Designation: ");
#nullable restore
#line 44 "C:\Users\abc\source\repos\CSharpLearningSessions\WebApplicationMVC1\Views\Employee\Index.cshtml"
                            Write(Html.DropDownListFor(m => m.Designation, new List<SelectListItem> {
                   new SelectListItem(){Text="Manager", Value="101"},
                   new SelectListItem(){Text="Project Manager", Value="201"},
                   new SelectListItem(){Text="Team Leader", Value="301"}
               }, "Select Designation", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
            WriteLiteral("                <div class=\"form-group\">\r\n                    Suffix: ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3de5f5567aed7150c5d0953bd6e3657a470c755f8520", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 54 "C:\Users\abc\source\repos\CSharpLearningSessions\WebApplicationMVC1\Views\Employee\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Suffix);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 54 "C:\Users\abc\source\repos\CSharpLearningSessions\WebApplicationMVC1\Views\Employee\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.suffixListItems;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"card-footer\">\r\n                <input type=\"submit\" value=\"Submit\" />\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 61 "C:\Users\abc\source\repos\CSharpLearningSessions\WebApplicationMVC1\Views\Employee\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591