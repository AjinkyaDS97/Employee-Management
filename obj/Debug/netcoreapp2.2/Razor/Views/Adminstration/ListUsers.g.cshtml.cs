#pragma checksum "C:\Users\AJINKYA\Desktop\Asp .Net Core\EmployeeMangment\EmployeeMangment\Views\Adminstration\ListUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24f290aa6762f0f55ed0771799ac3d1498fbb211"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Adminstration_ListUsers), @"mvc.1.0.view", @"/Views/Adminstration/ListUsers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Adminstration/ListUsers.cshtml", typeof(AspNetCore.Views_Adminstration_ListUsers))]
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
#line 1 "C:\Users\AJINKYA\Desktop\Asp .Net Core\EmployeeMangment\EmployeeMangment\Views\_ViewImports.cshtml"
using EmployeeMangment.Models;

#line default
#line hidden
#line 2 "C:\Users\AJINKYA\Desktop\Asp .Net Core\EmployeeMangment\EmployeeMangment\Views\_ViewImports.cshtml"
using EmployeeMangment.ViewModels;

#line default
#line hidden
#line 3 "C:\Users\AJINKYA\Desktop\Asp .Net Core\EmployeeMangment\EmployeeMangment\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24f290aa6762f0f55ed0771799ac3d1498fbb211", @"/Views/Adminstration/ListUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea3a888dee5dfeecd53c351562117e815267f0d4", @"/Views/_ViewImports.cshtml")]
    public class Views_Adminstration_ListUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ApplicationUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Adminstration", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\AJINKYA\Desktop\Asp .Net Core\EmployeeMangment\EmployeeMangment\Views\Adminstration\ListUsers.cshtml"
  
    ViewBag.Title = "All User";

#line default
#line hidden
            BeginContext(79, 24, true);
            WriteLiteral("\r\n<h1>All Users</h1>\r\n\r\n");
            EndContext();
#line 9 "C:\Users\AJINKYA\Desktop\Asp .Net Core\EmployeeMangment\EmployeeMangment\Views\Adminstration\ListUsers.cshtml"
 if (Model.Any())
{

#line default
#line hidden
            BeginContext(125, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(129, 133, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24f290aa6762f0f55ed0771799ac3d1498fbb2116945", async() => {
                BeginContext(230, 28, true);
                WriteLiteral("\r\n        Add New user\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(262, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 15 "C:\Users\AJINKYA\Desktop\Asp .Net Core\EmployeeMangment\EmployeeMangment\Views\Adminstration\ListUsers.cshtml"


    foreach (var user in Model)
    {

#line default
#line hidden
            BeginContext(308, 96, true);
            WriteLiteral("        <div class=\"card mb-3\">\r\n            <div class=\"card-header\">\r\n                User Id=");
            EndContext();
            BeginContext(405, 7, false);
#line 21 "C:\Users\AJINKYA\Desktop\Asp .Net Core\EmployeeMangment\EmployeeMangment\Views\Adminstration\ListUsers.cshtml"
                   Write(user.Id);

#line default
#line hidden
            EndContext();
            BeginContext(412, 98, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">");
            EndContext();
            BeginContext(511, 13, false);
#line 24 "C:\Users\AJINKYA\Desktop\Asp .Net Core\EmployeeMangment\EmployeeMangment\Views\Adminstration\ListUsers.cshtml"
                                  Write(user.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(524, 82, true);
            WriteLiteral("</h5>\r\n            </div>\r\n            <div class=\"card-footer\">\r\n                ");
            EndContext();
            BeginContext(606, 821, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24f290aa6762f0f55ed0771799ac3d1498fbb21110051", async() => {
                BeginContext(674, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(696, 136, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24f290aa6762f0f55ed0771799ac3d1498fbb21110455", async() => {
                    BeginContext(824, 4, true);
                    WriteLiteral("Edit");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 28 "C:\Users\AJINKYA\Desktop\Asp .Net Core\EmployeeMangment\EmployeeMangment\Views\Adminstration\ListUsers.cshtml"
                                                                              WriteLiteral(user.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(832, 29, true);
                WriteLiteral("\r\n\r\n                    <span");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 861, "\"", 892, 2);
                WriteAttributeValue("", 866, "confirmDeleteSpan_", 866, 18, true);
#line 31 "C:\Users\AJINKYA\Desktop\Asp .Net Core\EmployeeMangment\EmployeeMangment\Views\Adminstration\ListUsers.cshtml"
WriteAttributeValue("", 884, user.Id, 884, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(893, 234, true);
                WriteLiteral(" style=\"display:none\">\r\n                        <span>Are You Sure Want To Delete ?</span>\r\n                        <button type=\"submit\" class=\"btn btn-danger\">Yes</button>\r\n                        <a href=\"#\" class=\"btn btn-primary\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 1127, "\"", 1168, 3);
                WriteAttributeValue("", 1137, "confirmDelete(\'", 1137, 15, true);
#line 34 "C:\Users\AJINKYA\Desktop\Asp .Net Core\EmployeeMangment\EmployeeMangment\Views\Adminstration\ListUsers.cshtml"
WriteAttributeValue("", 1152, user.Id, 1152, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 1160, "\',false)", 1160, 8, true);
                EndWriteAttribute();
                BeginContext(1169, 65, true);
                WriteLiteral(">No</a>\r\n                    </span>\r\n\r\n                    <span");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 1234, "\"", 1258, 2);
                WriteAttributeValue("", 1239, "deleteSpan_", 1239, 11, true);
#line 37 "C:\Users\AJINKYA\Desktop\Asp .Net Core\EmployeeMangment\EmployeeMangment\Views\Adminstration\ListUsers.cshtml"
WriteAttributeValue("", 1250, user.Id, 1250, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1259, 61, true);
                WriteLiteral(">\r\n                        <a href=\"#\" class=\"btn btn-danger\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 1320, "\"", 1360, 3);
                WriteAttributeValue("", 1330, "confirmDelete(\'", 1330, 15, true);
#line 38 "C:\Users\AJINKYA\Desktop\Asp .Net Core\EmployeeMangment\EmployeeMangment\Views\Adminstration\ListUsers.cshtml"
WriteAttributeValue("", 1345, user.Id, 1345, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 1353, "\',true)", 1353, 7, true);
                EndWriteAttribute();
                BeginContext(1361, 59, true);
                WriteLiteral(">Delete</a>\r\n                    </span> \r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 27 "C:\Users\AJINKYA\Desktop\Asp .Net Core\EmployeeMangment\EmployeeMangment\Views\Adminstration\ListUsers.cshtml"
                                                WriteLiteral(user.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1427, 38, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 43 "C:\Users\AJINKYA\Desktop\Asp .Net Core\EmployeeMangment\EmployeeMangment\Views\Adminstration\ListUsers.cshtml"
    }


}
else
{


#line default
#line hidden
            BeginContext(1490, 266, true);
            WriteLiteral(@"    <div class=""card"">
        <div class=""card-header"">
            No User Created Yet
        </div>

        <div class=""card-body"">
            <h5 class=""card-title"">
                Use the button below to create a user
            </h5>
            ");
            EndContext();
            BeginContext(1756, 157, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24f290aa6762f0f55ed0771799ac3d1498fbb21119042", async() => {
                BeginContext(1865, 44, true);
                WriteLiteral("\r\n                Add New user\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1913, 30, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 65 "C:\Users\AJINKYA\Desktop\Asp .Net Core\EmployeeMangment\EmployeeMangment\Views\Adminstration\ListUsers.cshtml"




}

#line default
#line hidden
            BeginContext(1954, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1973, 546, true);
                WriteLiteral(@"
    

        <script>
            function confirmDelete(uniqueId, isTrue) {
                var deleteSpan = 'deleteSpan_' + uniqueId;
                var confirmDeleteSpan = 'confirmDeleteSpan_' + uniqueId;

                if (isTrue) {
                    $('#' + deleteSpan).hide();
                    $('#' + confirmDeleteSpan).show();
                } else {
                    $('#' + deleteSpan).show();
                    $('#' + confirmDeleteSpan).hide();
                }
            }
        </script>
    
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ApplicationUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
