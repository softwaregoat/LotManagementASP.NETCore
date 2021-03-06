#pragma checksum "E:\Project\VisualStudio\Core\LotManagementASP.NETCore\MVCCoreLoginRegister\MVCCoreLoginRegister\Views\SupportingDoc\PackingSpec.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e31a3b16244800b6ab86bc18f0a513dca74ecabb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SupportingDoc_PackingSpec), @"mvc.1.0.view", @"/Views/SupportingDoc/PackingSpec.cshtml")]
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
#line 1 "E:\Project\VisualStudio\Core\LotManagementASP.NETCore\MVCCoreLoginRegister\MVCCoreLoginRegister\Views\_ViewImports.cshtml"
using MVCCoreLoginRegister;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Project\VisualStudio\Core\LotManagementASP.NETCore\MVCCoreLoginRegister\MVCCoreLoginRegister\Views\_ViewImports.cshtml"
using MVCCoreLoginRegister.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e31a3b16244800b6ab86bc18f0a513dca74ecabb", @"/Views/SupportingDoc/PackingSpec.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa81fb597f0312d1dc6fa9eddf073d33a4a0fee5", @"/Views/_ViewImports.cshtml")]
    public class Views_SupportingDoc_PackingSpec : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\Project\VisualStudio\Core\LotManagementASP.NETCore\MVCCoreLoginRegister\MVCCoreLoginRegister\Views\SupportingDoc\PackingSpec.cshtml"
  
    ViewData["Title"] = "Packing Specification";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Packing Specification</h1>\r\n<br />\r\n<div class=\"row\">\r\n    <div class=\"col-lg-1\">\r\n        <label class=\"col-form-label\">Product</label>\r\n    </div>\r\n    <div class=\"col-lg-2\">\r\n        <input type=\"text\" id=\"product\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 348, "\"", 356, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n</div>\r\n<br />\r\n<div class=\"row\">\r\n    <iframe");
            BeginWriteAttribute("src", " src=\"", 420, "\"", 426, 0);
            EndWriteAttribute();
            WriteLiteral(" type=\"application/pdf\" style=\"width: 100%;height: 600px;\"></iframe>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            let product = getCookie('ProductName');
            $('#product').val(product);
            $.ajax({
                type: ""POST"",
                url: ""/SupportingDoc/ProductDrawing"",
                data: {
                    Product: ProductName
                },
                success: function (response) {
                    if (response != 'Failed') {
                        var pdf = response.ps;
                        $('iframe').attr('src', '/pdf/PS/' + pdf + '#zoom=100');
                    }
                }
            });
            var timer2 = ""0:30"";
            timerDown(timer2, ""/Home/JobBagOverview"");
        });
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
