#pragma checksum "E:\Project\VisualStudio\Core\LotManagementASP.NETCore\MVCCoreLoginRegister\MVCCoreLoginRegister\Views\ProductSetup\LineClearance.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72d51e7eafa99c765f5e3d90b9113dd8a573d299"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductSetup_LineClearance), @"mvc.1.0.view", @"/Views/ProductSetup/LineClearance.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72d51e7eafa99c765f5e3d90b9113dd8a573d299", @"/Views/ProductSetup/LineClearance.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa81fb597f0312d1dc6fa9eddf073d33a4a0fee5", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductSetup_LineClearance : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\Project\VisualStudio\Core\LotManagementASP.NETCore\MVCCoreLoginRegister\MVCCoreLoginRegister\Views\ProductSetup\LineClearance.cshtml"
  
    ViewData["Title"] = "Line Clearance";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-center\">Line Clearance</h1>\r\n<br />\r\n<div class=\"row\">\r\n    <div class=\"col-md-1\">\r\n        <label class=\"col-form-label\">Lot</label>\r\n    </div>\r\n    <div class=\"col-md-2\">\r\n        <input type=\"text\" id=\"Lot\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 348, "\"", 356, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
    </div>
</div>
<br />
<div class=""row"">
    <div class=""col-lg-4"">
        <iframe src=""/pdf/test.pdf#zoom=40"" type=""application/pdf"" style=""width: 100%;height: 800px;""></iframe>
    </div>
    <div class=""col-lg-8"">
        <table class=""table table-borderless table-sm"">
            <thead>
                <tr>
                    <th scope=""col"">Log</th>
                    <th scope=""col"">Date/Act. Time</th>
                    <th scope=""col"">Tech RFID</th>
                    <th scope=""col"">Username</th>
                    <th scope=""col"">QC RFID</th>
                    <th scope=""col"">Username</th>
                    <th scope=""col"">Save</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td><input type=""checkbox"" class=""form-control log""");
            BeginWriteAttribute("value", " value=\"", 1203, "\"", 1211, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"text\" class=\"form-control date-time\"");
            BeginWriteAttribute("value", " value=\"", 1294, "\"", 1302, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"password\" class=\"form-control tech-rfid\"");
            BeginWriteAttribute("value", " value=\"", 1389, "\"", 1397, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"text\" class=\"form-control username\"");
            BeginWriteAttribute("value", " value=\"", 1479, "\"", 1487, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"password\" class=\"form-control qc-rfid\"");
            BeginWriteAttribute("value", " value=\"", 1572, "\"", 1580, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"text\" class=\"form-control username1\"");
            BeginWriteAttribute("value", " value=\"", 1663, "\"", 1671, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"button\" class=\"form-control save btn btn-primary\" value=\"Save\" /></td>\r\n                </tr>\r\n                <tr>\r\n                    <td><input type=\"checkbox\" class=\"form-control log\"");
            BeginWriteAttribute("value", " value=\"", 1906, "\"", 1914, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"text\" class=\"form-control date-time\"");
            BeginWriteAttribute("value", " value=\"", 1997, "\"", 2005, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"password\" class=\"form-control tech-rfid\"");
            BeginWriteAttribute("value", " value=\"", 2092, "\"", 2100, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"text\" class=\"form-control username\"");
            BeginWriteAttribute("value", " value=\"", 2182, "\"", 2190, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"password\" class=\"form-control qc-rfid\"");
            BeginWriteAttribute("value", " value=\"", 2275, "\"", 2283, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"text\" class=\"form-control username1\"");
            BeginWriteAttribute("value", " value=\"", 2366, "\"", 2374, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"button\" class=\"form-control save btn btn-primary\" value=\"Save\" /></td>\r\n                </tr>\r\n                <tr>\r\n                    <td><input type=\"checkbox\" class=\"form-control log\"");
            BeginWriteAttribute("value", " value=\"", 2609, "\"", 2617, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"text\" class=\"form-control date-time\"");
            BeginWriteAttribute("value", " value=\"", 2700, "\"", 2708, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"password\" class=\"form-control tech-rfid\"");
            BeginWriteAttribute("value", " value=\"", 2795, "\"", 2803, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"text\" class=\"form-control username\"");
            BeginWriteAttribute("value", " value=\"", 2885, "\"", 2893, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"password\" class=\"form-control qc-rfid\"");
            BeginWriteAttribute("value", " value=\"", 2978, "\"", 2986, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"text\" class=\"form-control username1\"");
            BeginWriteAttribute("value", " value=\"", 3069, "\"", 3077, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"button\" class=\"form-control save btn btn-primary\" value=\"Save\" /></td>\r\n                </tr>\r\n                <tr>\r\n                    <td><input type=\"checkbox\" class=\"form-control log\"");
            BeginWriteAttribute("value", " value=\"", 3312, "\"", 3320, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"text\" class=\"form-control date-time\"");
            BeginWriteAttribute("value", " value=\"", 3403, "\"", 3411, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"password\" class=\"form-control tech-rfid\"");
            BeginWriteAttribute("value", " value=\"", 3498, "\"", 3506, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"text\" class=\"form-control username\"");
            BeginWriteAttribute("value", " value=\"", 3588, "\"", 3596, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"password\" class=\"form-control qc-rfid\"");
            BeginWriteAttribute("value", " value=\"", 3681, "\"", 3689, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"text\" class=\"form-control username1\"");
            BeginWriteAttribute("value", " value=\"", 3772, "\"", 3780, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"button\" class=\"form-control save btn btn-primary\" value=\"Save\" /></td>\r\n                </tr>\r\n                <tr>\r\n                    <td><input type=\"checkbox\" class=\"form-control log\"");
            BeginWriteAttribute("value", " value=\"", 4015, "\"", 4023, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"text\" class=\"form-control date-time\"");
            BeginWriteAttribute("value", " value=\"", 4106, "\"", 4114, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"password\" class=\"form-control tech-rfid\"");
            BeginWriteAttribute("value", " value=\"", 4201, "\"", 4209, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"text\" class=\"form-control username\"");
            BeginWriteAttribute("value", " value=\"", 4291, "\"", 4299, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"password\" class=\"form-control qc-rfid\"");
            BeginWriteAttribute("value", " value=\"", 4384, "\"", 4392, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"text\" class=\"form-control username1\"");
            BeginWriteAttribute("value", " value=\"", 4475, "\"", 4483, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"button\" class=\"form-control save btn btn-primary\" value=\"Save\" /></td>\r\n                </tr>\r\n                <tr>\r\n                    <td><input type=\"checkbox\" class=\"form-control log\"");
            BeginWriteAttribute("value", " value=\"", 4718, "\"", 4726, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"text\" class=\"form-control date-time\"");
            BeginWriteAttribute("value", " value=\"", 4809, "\"", 4817, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"password\" class=\"form-control tech-rfid\"");
            BeginWriteAttribute("value", " value=\"", 4904, "\"", 4912, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"text\" class=\"form-control username\"");
            BeginWriteAttribute("value", " value=\"", 4994, "\"", 5002, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"password\" class=\"form-control qc-rfid\"");
            BeginWriteAttribute("value", " value=\"", 5087, "\"", 5095, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"text\" class=\"form-control username1\"");
            BeginWriteAttribute("value", " value=\"", 5178, "\"", 5186, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"button\" class=\"form-control save btn btn-primary\" value=\"Save\" /></td>\r\n                </tr>\r\n                <tr>\r\n                    <td><input type=\"checkbox\" class=\"form-control log\"");
            BeginWriteAttribute("value", " value=\"", 5421, "\"", 5429, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"text\" class=\"form-control date-time\"");
            BeginWriteAttribute("value", " value=\"", 5512, "\"", 5520, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"password\" class=\"form-control tech-rfid\"");
            BeginWriteAttribute("value", " value=\"", 5607, "\"", 5615, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"text\" class=\"form-control username\"");
            BeginWriteAttribute("value", " value=\"", 5697, "\"", 5705, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"password\" class=\"form-control qc-rfid\"");
            BeginWriteAttribute("value", " value=\"", 5790, "\"", 5798, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"text\" class=\"form-control username1\"");
            BeginWriteAttribute("value", " value=\"", 5881, "\"", 5889, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"button\" class=\"form-control save btn btn-primary\" value=\"Save\" /></td>\r\n                </tr>\r\n                <tr>\r\n                    <td><input type=\"checkbox\" class=\"form-control log\"");
            BeginWriteAttribute("value", " value=\"", 6124, "\"", 6132, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"text\" class=\"form-control date-time\"");
            BeginWriteAttribute("value", " value=\"", 6215, "\"", 6223, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"password\" class=\"form-control tech-rfid\"");
            BeginWriteAttribute("value", " value=\"", 6310, "\"", 6318, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"text\" class=\"form-control username\"");
            BeginWriteAttribute("value", " value=\"", 6400, "\"", 6408, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"password\" class=\"form-control qc-rfid\"");
            BeginWriteAttribute("value", " value=\"", 6493, "\"", 6501, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"text\" class=\"form-control username1\"");
            BeginWriteAttribute("value", " value=\"", 6584, "\"", 6592, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"button\" class=\"form-control save btn btn-primary\" value=\"Save\" /></td>\r\n                </tr>\r\n                <tr>\r\n                    <td><input type=\"checkbox\" class=\"form-control log\"");
            BeginWriteAttribute("value", " value=\"", 6827, "\"", 6835, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"text\" class=\"form-control date-time\"");
            BeginWriteAttribute("value", " value=\"", 6918, "\"", 6926, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"password\" class=\"form-control tech-rfid\"");
            BeginWriteAttribute("value", " value=\"", 7013, "\"", 7021, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"text\" class=\"form-control username\"");
            BeginWriteAttribute("value", " value=\"", 7103, "\"", 7111, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"password\" class=\"form-control qc-rfid\"");
            BeginWriteAttribute("value", " value=\"", 7196, "\"", 7204, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"text\" class=\"form-control username1\"");
            BeginWriteAttribute("value", " value=\"", 7287, "\"", 7295, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"button\" class=\"form-control save btn btn-primary\" value=\"Save\" /></td>\r\n                </tr>\r\n                <tr>\r\n                    <td><input type=\"checkbox\" class=\"form-control log\"");
            BeginWriteAttribute("value", " value=\"", 7530, "\"", 7538, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"text\" class=\"form-control date-time\"");
            BeginWriteAttribute("value", " value=\"", 7621, "\"", 7629, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"password\" class=\"form-control tech-rfid\"");
            BeginWriteAttribute("value", " value=\"", 7716, "\"", 7724, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"text\" class=\"form-control username\"");
            BeginWriteAttribute("value", " value=\"", 7806, "\"", 7814, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"password\" class=\"form-control qc-rfid\"");
            BeginWriteAttribute("value", " value=\"", 7899, "\"", 7907, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"text\" class=\"form-control username1\"");
            BeginWriteAttribute("value", " value=\"", 7990, "\"", 7998, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"button\" class=\"form-control save btn btn-primary\" value=\"Save\" /></td>\r\n                </tr>\r\n                <tr>\r\n                    <td><input type=\"checkbox\" class=\"form-control log\"");
            BeginWriteAttribute("value", " value=\"", 8233, "\"", 8241, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"text\" class=\"form-control date-time\"");
            BeginWriteAttribute("value", " value=\"", 8324, "\"", 8332, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"password\" class=\"form-control tech-rfid\"");
            BeginWriteAttribute("value", " value=\"", 8419, "\"", 8427, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"text\" class=\"form-control username\"");
            BeginWriteAttribute("value", " value=\"", 8509, "\"", 8517, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"password\" class=\"form-control qc-rfid\"");
            BeginWriteAttribute("value", " value=\"", 8602, "\"", 8610, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"text\" class=\"form-control username1\"");
            BeginWriteAttribute("value", " value=\"", 8693, "\"", 8701, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"button\" class=\"form-control save btn btn-primary\" value=\"Save\" /></td>\r\n                </tr>\r\n                <tr>\r\n                    <td><input type=\"checkbox\" class=\"form-control log\"");
            BeginWriteAttribute("value", " value=\"", 8936, "\"", 8944, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"text\" class=\"form-control date-time\"");
            BeginWriteAttribute("value", " value=\"", 9027, "\"", 9035, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"password\" class=\"form-control tech-rfid\"");
            BeginWriteAttribute("value", " value=\"", 9122, "\"", 9130, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"text\" class=\"form-control username\"");
            BeginWriteAttribute("value", " value=\"", 9212, "\"", 9220, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"password\" class=\"form-control qc-rfid\"");
            BeginWriteAttribute("value", " value=\"", 9305, "\"", 9313, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"text\" class=\"form-control username1\"");
            BeginWriteAttribute("value", " value=\"", 9396, "\"", 9404, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"button\" class=\"form-control save btn btn-primary\" value=\"Save\" /></td>\r\n                </tr>\r\n                <tr>\r\n                    <td><input type=\"checkbox\" class=\"form-control log\"");
            BeginWriteAttribute("value", " value=\"", 9639, "\"", 9647, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"text\" class=\"form-control date-time\"");
            BeginWriteAttribute("value", " value=\"", 9730, "\"", 9738, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"password\" class=\"form-control tech-rfid\"");
            BeginWriteAttribute("value", " value=\"", 9825, "\"", 9833, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"text\" class=\"form-control username\"");
            BeginWriteAttribute("value", " value=\"", 9915, "\"", 9923, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"password\" class=\"form-control qc-rfid\"");
            BeginWriteAttribute("value", " value=\"", 10008, "\"", 10016, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"text\" class=\"form-control username1\"");
            BeginWriteAttribute("value", " value=\"", 10099, "\"", 10107, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"button\" class=\"form-control save btn btn-primary\" value=\"Save\" /></td>\r\n                </tr>\r\n                <tr>\r\n                    <td><input type=\"checkbox\" class=\"form-control log\"");
            BeginWriteAttribute("value", " value=\"", 10342, "\"", 10350, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"text\" class=\"form-control date-time\"");
            BeginWriteAttribute("value", " value=\"", 10433, "\"", 10441, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"password\" class=\"form-control tech-rfid\"");
            BeginWriteAttribute("value", " value=\"", 10528, "\"", 10536, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"text\" class=\"form-control username\"");
            BeginWriteAttribute("value", " value=\"", 10618, "\"", 10626, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"password\" class=\"form-control qc-rfid\"");
            BeginWriteAttribute("value", " value=\"", 10711, "\"", 10719, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"text\" class=\"form-control username1\"");
            BeginWriteAttribute("value", " value=\"", 10802, "\"", 10810, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"button\" class=\"form-control save btn btn-primary\" value=\"Save\" /></td>\r\n                </tr>\r\n                <tr>\r\n                    <td><input type=\"checkbox\" class=\"form-control log\"");
            BeginWriteAttribute("value", " value=\"", 11045, "\"", 11053, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"text\" class=\"form-control date-time\"");
            BeginWriteAttribute("value", " value=\"", 11136, "\"", 11144, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"password\" class=\"form-control tech-rfid\"");
            BeginWriteAttribute("value", " value=\"", 11231, "\"", 11239, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"text\" class=\"form-control username\"");
            BeginWriteAttribute("value", " value=\"", 11321, "\"", 11329, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"password\" class=\"form-control qc-rfid\"");
            BeginWriteAttribute("value", " value=\"", 11414, "\"", 11422, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"text\" class=\"form-control username1\"");
            BeginWriteAttribute("value", " value=\"", 11505, "\"", 11513, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"button\" class=\"form-control save btn btn-primary\" value=\"Save\" /></td>\r\n                </tr>\r\n                <tr>\r\n                    <td><input type=\"checkbox\" class=\"form-control log\"");
            BeginWriteAttribute("value", " value=\"", 11748, "\"", 11756, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"text\" class=\"form-control date-time\"");
            BeginWriteAttribute("value", " value=\"", 11839, "\"", 11847, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"password\" class=\"form-control tech-rfid\"");
            BeginWriteAttribute("value", " value=\"", 11934, "\"", 11942, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"text\" class=\"form-control username\"");
            BeginWriteAttribute("value", " value=\"", 12024, "\"", 12032, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"password\" class=\"form-control qc-rfid\"");
            BeginWriteAttribute("value", " value=\"", 12117, "\"", 12125, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"text\" class=\"form-control username1\"");
            BeginWriteAttribute("value", " value=\"", 12208, "\"", 12216, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"button\" class=\"form-control save btn btn-primary\" value=\"Save\" /></td>\r\n                </tr>\r\n                <tr>\r\n                    <td><input type=\"checkbox\" class=\"form-control log\"");
            BeginWriteAttribute("value", " value=\"", 12451, "\"", 12459, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"text\" class=\"form-control date-time\"");
            BeginWriteAttribute("value", " value=\"", 12542, "\"", 12550, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"password\" class=\"form-control tech-rfid\"");
            BeginWriteAttribute("value", " value=\"", 12637, "\"", 12645, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"text\" class=\"form-control username\"");
            BeginWriteAttribute("value", " value=\"", 12727, "\"", 12735, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"password\" class=\"form-control qc-rfid\"");
            BeginWriteAttribute("value", " value=\"", 12820, "\"", 12828, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"text\" class=\"form-control username1\"");
            BeginWriteAttribute("value", " value=\"", 12911, "\"", 12919, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                    <td><input type=\"button\" class=\"form-control save btn btn-primary\" value=\"Save\" /></td>\r\n                </tr>\r\n\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            let LotID = getCookie('LotID');
            let Machine = getCookie('Machine');
            let Lot = getCookie('Lot');
            $('#Lot').val(Lot);
            
            $.ajax({
                    type: ""POST"",
                    url: ""/ProductSetup/LineClearance"",
                    data: { 'Lot': Lot },
                    success: function (response) {
                        if (response != 'Failed') {
                            let trs = $('tbody tr');
                            for (var i = 0; i < response.length; i++) {
                                var em = response[i];
                                let tr = trs[i];
                                $($(tr).find('.date-time')).val(em.lctimeStamp);
                                $($(tr).find('.date-time')).prop(""disabled"", true);
                                $($(tr).find('.tech-rfid')).val(em.techRfid);
                                $($(tr).find(");
                WriteLiteral(@"'.tech-rfid')).prop(""disabled"", true);
                                $($(tr).find('.username')).val(em.techUsername);
                                $($(tr).find('.username')).prop(""disabled"", true);
                                $($(tr).find('.qc-rfid')).val(em.qcrfid);
                                $($(tr).find('.qc-rfid')).prop(""disabled"", true);
                                $($(tr).find('.username1')).val(em.qcusername);
                                $($(tr).find('.username1')).prop(""disabled"", true);
                                $($(tr).find('.log')).prop(""disabled"", true);
                                $($(tr).find('.save')).prop(""disabled"", true);
                            }
                            toastr.success(""Success for LineClearance"");
                        }
                        else toastr.error(response);
                    }
                });

            $('input.log').click(function () {
                if ($(this).prop('checked')) {
       ");
                WriteLiteral(@"             var now = new Date();
                    let log = now.toLocaleString();
                    $(this).closest('tr').find('input.date-time').val(log);
                    $(this).closest('tr').find('input.tech-rfid').focus();
                }
                else {
                    $(this).closest('tr').find('input.date-time').val('');
                    
                }
            });
            $('input.tech-rfid').on('input', function () {
                var tr = $(this).closest('tr');
                var techUser = $(tr).find('.username');
                $.ajax({
                    type: ""POST"",
                    url: ""/Account/GetUser"",
                    data: { 'TechRfid': $(this).val() },
                    success: function (response) {
                        if (response != 'Failed') {
                            $(techUser).val(response.username);
                            var qcrfid = $(tr).find('.qc-rfid');
                            $(qcrfid).");
                WriteLiteral(@"focus();
                        }
                        else toastr.error('RFID not recognised, please try again');
                    }
                })
            });
            $('input.qc-rfid').on('input', function () {
                var tr = $(this).closest('tr');
                var techUser = $(tr).find('.username1');
                $.ajax({
                    type: ""POST"",
                    url: ""/Account/GetUser"",
                    data: { 'TechRfid': $(this).val() },
                    success: function (response) {
                        if (response != 'Failed') {
                            $(techUser).val(response.username);
                            var qcrfid = $(tr).find('.qc-rfid');
                        }
                        else toastr.error('RFID not recognised, please try again');
                    }
                })
            });
            $('input.save').click(function () {
                let tr = $(this).closest('tr');
      ");
                WriteLiteral(@"          var LCTimeStamp = $(tr).find('input.date-time').val();
                var TechRFID = $(tr).find('input.tech-rfid').val();
                var TechUsername = $(tr).find('input.username').val();
                var QCRFID = $(tr).find('input.qc-rfid').val();
                var QCUsername = $(tr).find('input.username1').val();

                if (LCTimeStamp == '') {
                    toastr.warning('Date/Cat. Time is empty.');
                    return;
                }
                if (TechRFID == '') {
                    toastr.warning('Tech RFID is empty.');
                    return;
                }
                if (TechUsername == '') {
                    toastr.warning('First Username is empty.');
                    return;
                }
                if (QCRFID == '') {
                    toastr.warning('QC RFID is empty.');
                    return;
                }
                if (QCUsername == '') {
                    toastr.warning('S");
                WriteLiteral(@"econd Username is empty.');
                    return;
                }
                $.ajax({
                    type: ""POST"",
                    url: ""/ProductSetup/SaveLineClearance"",
                    data: {
                        'Lot': $('#Lot').val(),
                        'LCTimeStamp': LCTimeStamp,
                        'TechRFID': TechRFID,
                        'TechUsername': TechUsername,
                        'QCRFID': QCRFID,
                        'QCUsername': QCUsername
                    },
                    success: function (response) {
                        if (response != 'Failed') {
                            window.location.href = ""/Home/JobBagOverview"";
                        }
                        else toastr.error(response);
                    }
                })

            });
            var timer2 = ""5:00"";
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
