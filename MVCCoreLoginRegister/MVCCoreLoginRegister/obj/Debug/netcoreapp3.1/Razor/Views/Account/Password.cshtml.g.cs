#pragma checksum "E:\Project\VisualStudio\Core\LotManagementASP.NETCore\MVCCoreLoginRegister\MVCCoreLoginRegister\Views\Account\Password.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58147e0b2af7a08690a615acf81a8ba5dd400ad9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Password), @"mvc.1.0.view", @"/Views/Account/Password.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58147e0b2af7a08690a615acf81a8ba5dd400ad9", @"/Views/Account/Password.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa81fb597f0312d1dc6fa9eddf073d33a4a0fee5", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Password : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\Project\VisualStudio\Core\LotManagementASP.NETCore\MVCCoreLoginRegister\MVCCoreLoginRegister\Views\Account\Password.cshtml"
  
    ViewData["Title"] = "Password";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""row"">
        <div class=""col-md-4""></div>
        <div class=""col-md-4"">
            <h1>Password protected</h1>
            <hr />
            <div class=""form-group"">
                <label class=""control-label"">Password</label>
                <input type=""password"" id=""password"" class=""form-control"" />
            </div>
            <div class=""form-group"">
                <button id=""submit"" value=""Confirm"" class=""form-control btn btn-primary"" />
            </div>
        </div>
    </div>
");
            DefineSection("Scripts", async() => {
                WriteLiteral(@" 
    <script>
        $(document).ready(function () {
            $('#submit').click(function () {
                let password = $('#password').val();
                $.ajax({
                    type: ""POST"",
                    url: ""/Account/Password"",
                    data: { 'Password': password },
                    success: function (response) {
                        if (response != 'Failed') {
                            toastr.success(response);
                            window.location.href = '/Account/Register';
                        }
                        else {
                            toastr.error(response);
                        }
                    }
                });
            })
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
