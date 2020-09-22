#pragma checksum "E:\Project\VisualStudio\Core\LotManagementASP.NETCore\MVCCoreLoginRegister\MVCCoreLoginRegister\Views\DataArchive\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "810c8f2e7e4530a0998fc05dadd67c69c420b82d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DataArchive_Index), @"mvc.1.0.view", @"/Views/DataArchive/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"810c8f2e7e4530a0998fc05dadd67c69c420b82d", @"/Views/DataArchive/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa81fb597f0312d1dc6fa9eddf073d33a4a0fee5", @"/Views/_ViewImports.cshtml")]
    public class Views_DataArchive_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\Project\VisualStudio\Core\LotManagementASP.NETCore\MVCCoreLoginRegister\MVCCoreLoginRegister\Views\DataArchive\Index.cshtml"
  
    ViewData["Title"] = "Data Archive";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1 class=""text-center"">Data Archive</h1>
<br />
<div class=""row"">
    <div class=""col-md-2 text-right"">
        <label class=""col-form-label font-weight-bold"">Lot</label>
    </div>
    <div class=""col-md-2"">
        <select class=""form-control"" id=""Lot"">
        </select>
    </div>
    <div class=""col-md-2 text-right"">
        <label class=""col-form-label font-weight-bold"">Product Description</label>
    </div>
    <div class=""col-md-2"">
        <input type=""text"" id=""DES""");
            BeginWriteAttribute("value", " value=\"", 593, "\"", 601, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" />
    </div>
    <div class=""col-md-2 text-right"">
        <label class=""col-form-label font-weight-bold"">Data Query</label>
    </div>
    <div class=""col-md-2"">
        <select class=""form-control"" id=""data-query"">
        </select>
    </div>
</div>
<br />
<div class=""row"">
    <h3 id=""title""></h3>
    <br />
    <table class=""table table-bordered table-hover"">
        <thead>
        </thead>
        <tbody>
        </tbody>
    </table>
</div>
");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $.ajax({
                type: ""POST"",
                url: ""/DataArchive/GetLot"",
                success: function (response) {
                    if (response != 'Failed') {
                        var items = '<option>Select Lot</option>';
                        $(""#Lot"").empty();
                        for (var i = 0; i < response.length; i++) {
                            var em = response[i];
                            items += ""<option value='"" + em.lotId + ""'>"" + em.lotName + ""</option>"";
                        }
                        $('#Lot').html(items);
                    }
                }
            });
            $.ajax({
                type: ""POST"",
                url: ""/DataArchive/GetDataArchiveQuery"",
                success: function (response) {
                    if (response != 'Failed') {
                        var items = '<option>Select Data Query</option>';
                     ");
                WriteLiteral(@"   $(""#data-query"").empty();
                        for (var i = 0; i < response.length; i++) {
                            var em = response[i];
                            items += ""<option value='"" + em.dataArchiveQueryId + ""'>"" + em.dataArchiveQuery + ""</option>"";
                        }
                        $('#data-query').html(items);
                    }
                }
            });
            $('#Lot').change(function () {
                $.ajax({
                    type: ""POST"",
                    url: ""/DataArchive/QryLot"",
                    data: {'LotID': $('#Lot').val()},
                    success: function (response) {
                        if (response != 'Failed') {
                            $('#DES').val(response.productName);
                        }
                    }
                });
            });
            $('#data-query').change(function () {
                if ($('#Lot').val() == 'Select Lot') {
                    toastr.error('");
                WriteLiteral(@"Please select a Lot');
                    return;
                }
                $.ajax({
                    type: ""POST"",
                    url: ""/DataArchive/DataQuery"",
                    data: {
                        'Query': $('#data-query').val(),
                        'Lot': $('#Lot option:selected').text()
                    },
                    success: function (response) {
                        if (response != 'Failed') {
                            $('#title').text($('#data-query option:selected').text());
                            $('thead').empty();
                            var header = '';
                            if (response.length > 0) {
                                var em = response[0];
                                var keys = Object.keys(em);
                                for (var i = 0; i < keys.length; i++) {
                                    header += '<th>' + keys[i] + '</th>';
                                }
                    ");
                WriteLiteral(@"            $('thead').html(header);
                            }
                            $('tbody').empty();
                            var tbody = '';
                            for (var i = 0; i < response.length; i++) {
                                var em = response[i];
                                var tr = '<tr>';
                                var vals = Object.values(em);
                                for (var j = 0; j < vals.length; j++) {
                                    tr += '<td>' + vals[j] + '</td>';
                                }
                                tr += '</tr>';
                                tbody += tr;
                            }
                            $('tbody').html(tbody);
                        }
                    }
                });
            });
            var timer2 = ""0:30"";
            timerDown(timer2, ""/Home/JobBagOverview"");
        });
    </script>
");
            }
            );
            WriteLiteral("\r\n\r\n\r\n");
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
