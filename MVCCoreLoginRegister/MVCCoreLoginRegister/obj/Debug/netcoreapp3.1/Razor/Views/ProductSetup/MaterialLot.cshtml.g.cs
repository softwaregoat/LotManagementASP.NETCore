#pragma checksum "E:\Project\VisualStudio\Core\LotManagementASP.NETCore\MVCCoreLoginRegister\MVCCoreLoginRegister\Views\ProductSetup\MaterialLot.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d10013893ad29ac77b6cbe3113e3ed7355e209a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductSetup_MaterialLot), @"mvc.1.0.view", @"/Views/ProductSetup/MaterialLot.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d10013893ad29ac77b6cbe3113e3ed7355e209a3", @"/Views/ProductSetup/MaterialLot.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa81fb597f0312d1dc6fa9eddf073d33a4a0fee5", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductSetup_MaterialLot : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\Project\VisualStudio\Core\LotManagementASP.NETCore\MVCCoreLoginRegister\MVCCoreLoginRegister\Views\ProductSetup\MaterialLot.cshtml"
  
    ViewData["Title"] = "Material Lot Control";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1 class=""text-center"">Material Lot Control</h1>
<br />
<div class=""row"">
    <div class=""col-md-2"">
        <label class=""col-form-label"">Product</label>
    </div>
    <div class=""col-md-2"">
        <input type=""text"" class=""form-control"" id=""product""");
            BeginWriteAttribute("value", " value=\"", 368, "\"", 376, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n</div>\r\n<br />\r\n<div class=\"row\">\r\n    <div class=\"col-md-2\">\r\n        <label class=\"col-form-label\">Description</label>\r\n    </div>\r\n    <div class=\"col-md-2\">\r\n        <input type=\"text\" class=\"form-control\" id=\"des\"");
            BeginWriteAttribute("value", " value=\"", 612, "\"", 620, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n</div>\r\n<br />\r\n<div class=\"row\">\r\n    <div class=\"col-md-2\">\r\n        <label class=\"col-form-label\">Lot</label>\r\n    </div>\r\n    <div class=\"col-md-2\">\r\n        <input type=\"text\" class=\"form-control\" id=\"Lot\"");
            BeginWriteAttribute("value", " value=\"", 848, "\"", 856, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n</div>\r\n<br />\r\n<div class=\"row\">\r\n    <div class=\"col-md-2\">\r\n        <label class=\"col-form-label\">Date</label>\r\n    </div>\r\n    <div class=\"col-md-2\">\r\n        <input type=\"text\" class=\"form-control\" id=\"date\"");
            BeginWriteAttribute("value", " value=\"", 1086, "\"", 1094, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
    </div>
</div>
<br />
<div class=""row"">
    <table class=""table table-borderless table-sm"">
        <thead>
            <tr>
                <th scope=""col"">Lot Update</th>
                <th scope=""col"">Date/Act. Time</th>
                <th scope=""col"">Carton No</th>
                <th scope=""col"">Polymer 1</th>
                <th scope=""col"">Polymer 2</th>
                <th scope=""col"">Masterbatch</th>
                <th scope=""col"">Slip Additive</th>
                <th scope=""col"">Save</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td><input type=""checkbox"" class=""form-control lot-update""");
            BeginWriteAttribute("value", " value=\"", 1772, "\"", 1780, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control date-time\"");
            BeginWriteAttribute("value", " value=\"", 1860, "\"", 1868, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control carton-no\"");
            BeginWriteAttribute("value", " value=\"", 1948, "\"", 1956, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control polymer1\"");
            BeginWriteAttribute("value", " value=\"", 2035, "\"", 2043, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control polymer2\"");
            BeginWriteAttribute("value", " value=\"", 2122, "\"", 2130, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control masterbatch\"");
            BeginWriteAttribute("value", " value=\"", 2212, "\"", 2220, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control slip\"");
            BeginWriteAttribute("value", " value=\"", 2295, "\"", 2303, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"button\" class=\"form-control save btn btn-primary\" value=\"Save\" /></td>\r\n            </tr>\r\n            <tr>\r\n                <td><input type=\"checkbox\" class=\"form-control lot-update\"");
            BeginWriteAttribute("value", " value=\"", 2530, "\"", 2538, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control date-time\"");
            BeginWriteAttribute("value", " value=\"", 2618, "\"", 2626, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control carton-no\"");
            BeginWriteAttribute("value", " value=\"", 2706, "\"", 2714, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control polymer1\"");
            BeginWriteAttribute("value", " value=\"", 2793, "\"", 2801, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control polymer2\"");
            BeginWriteAttribute("value", " value=\"", 2880, "\"", 2888, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control masterbatch\"");
            BeginWriteAttribute("value", " value=\"", 2970, "\"", 2978, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control slip\"");
            BeginWriteAttribute("value", " value=\"", 3053, "\"", 3061, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"button\" class=\"form-control save btn btn-primary\" value=\"Save\" /></td>\r\n            </tr>\r\n            <tr>\r\n                <td><input type=\"checkbox\" class=\"form-control lot-update\"");
            BeginWriteAttribute("value", " value=\"", 3288, "\"", 3296, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control date-time\"");
            BeginWriteAttribute("value", " value=\"", 3376, "\"", 3384, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control carton-no\"");
            BeginWriteAttribute("value", " value=\"", 3464, "\"", 3472, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control polymer1\"");
            BeginWriteAttribute("value", " value=\"", 3551, "\"", 3559, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control polymer2\"");
            BeginWriteAttribute("value", " value=\"", 3638, "\"", 3646, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control masterbatch\"");
            BeginWriteAttribute("value", " value=\"", 3728, "\"", 3736, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control slip\"");
            BeginWriteAttribute("value", " value=\"", 3811, "\"", 3819, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"button\" class=\"form-control save btn btn-primary\" value=\"Save\" /></td>\r\n            </tr>\r\n            <tr>\r\n                <td><input type=\"checkbox\" class=\"form-control lot-update\"");
            BeginWriteAttribute("value", " value=\"", 4046, "\"", 4054, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control date-time\"");
            BeginWriteAttribute("value", " value=\"", 4134, "\"", 4142, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control carton-no\"");
            BeginWriteAttribute("value", " value=\"", 4222, "\"", 4230, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control polymer1\"");
            BeginWriteAttribute("value", " value=\"", 4309, "\"", 4317, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control polymer2\"");
            BeginWriteAttribute("value", " value=\"", 4396, "\"", 4404, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control masterbatch\"");
            BeginWriteAttribute("value", " value=\"", 4486, "\"", 4494, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control slip\"");
            BeginWriteAttribute("value", " value=\"", 4569, "\"", 4577, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"button\" class=\"form-control save btn btn-primary\" value=\"Save\" /></td>\r\n            </tr>\r\n            <tr>\r\n                <td><input type=\"checkbox\" class=\"form-control lot-update\"");
            BeginWriteAttribute("value", " value=\"", 4804, "\"", 4812, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control date-time\"");
            BeginWriteAttribute("value", " value=\"", 4892, "\"", 4900, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control carton-no\"");
            BeginWriteAttribute("value", " value=\"", 4980, "\"", 4988, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control polymer1\"");
            BeginWriteAttribute("value", " value=\"", 5067, "\"", 5075, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control polymer2\"");
            BeginWriteAttribute("value", " value=\"", 5154, "\"", 5162, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control masterbatch\"");
            BeginWriteAttribute("value", " value=\"", 5244, "\"", 5252, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control slip\"");
            BeginWriteAttribute("value", " value=\"", 5327, "\"", 5335, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"button\" class=\"form-control save btn btn-primary\" value=\"Save\" /></td>\r\n            </tr>\r\n            <tr>\r\n                <td><input type=\"checkbox\" class=\"form-control lot-update\"");
            BeginWriteAttribute("value", " value=\"", 5562, "\"", 5570, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control date-time\"");
            BeginWriteAttribute("value", " value=\"", 5650, "\"", 5658, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control carton-no\"");
            BeginWriteAttribute("value", " value=\"", 5738, "\"", 5746, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control polymer1\"");
            BeginWriteAttribute("value", " value=\"", 5825, "\"", 5833, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control polymer2\"");
            BeginWriteAttribute("value", " value=\"", 5912, "\"", 5920, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control masterbatch\"");
            BeginWriteAttribute("value", " value=\"", 6002, "\"", 6010, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control slip\"");
            BeginWriteAttribute("value", " value=\"", 6085, "\"", 6093, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"button\" class=\"form-control save btn btn-primary\" value=\"Save\" /></td>\r\n            </tr>\r\n            <tr>\r\n                <td><input type=\"checkbox\" class=\"form-control lot-update\"");
            BeginWriteAttribute("value", " value=\"", 6320, "\"", 6328, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control date-time\"");
            BeginWriteAttribute("value", " value=\"", 6408, "\"", 6416, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control carton-no\"");
            BeginWriteAttribute("value", " value=\"", 6496, "\"", 6504, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control polymer1\"");
            BeginWriteAttribute("value", " value=\"", 6583, "\"", 6591, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control polymer2\"");
            BeginWriteAttribute("value", " value=\"", 6670, "\"", 6678, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control masterbatch\"");
            BeginWriteAttribute("value", " value=\"", 6760, "\"", 6768, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control slip\"");
            BeginWriteAttribute("value", " value=\"", 6843, "\"", 6851, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"button\" class=\"form-control save btn btn-primary\" value=\"Save\" /></td>\r\n            </tr>\r\n            <tr>\r\n                <td><input type=\"checkbox\" class=\"form-control lot-update\"");
            BeginWriteAttribute("value", " value=\"", 7078, "\"", 7086, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control date-time\"");
            BeginWriteAttribute("value", " value=\"", 7166, "\"", 7174, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control carton-no\"");
            BeginWriteAttribute("value", " value=\"", 7254, "\"", 7262, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control polymer1\"");
            BeginWriteAttribute("value", " value=\"", 7341, "\"", 7349, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control polymer2\"");
            BeginWriteAttribute("value", " value=\"", 7428, "\"", 7436, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control masterbatch\"");
            BeginWriteAttribute("value", " value=\"", 7518, "\"", 7526, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control slip\"");
            BeginWriteAttribute("value", " value=\"", 7601, "\"", 7609, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"button\" class=\"form-control save btn btn-primary\" value=\"Save\" /></td>\r\n            </tr>\r\n            <tr>\r\n                <td><input type=\"checkbox\" class=\"form-control lot-update\"");
            BeginWriteAttribute("value", " value=\"", 7836, "\"", 7844, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control date-time\"");
            BeginWriteAttribute("value", " value=\"", 7924, "\"", 7932, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control carton-no\"");
            BeginWriteAttribute("value", " value=\"", 8012, "\"", 8020, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control polymer1\"");
            BeginWriteAttribute("value", " value=\"", 8099, "\"", 8107, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control polymer2\"");
            BeginWriteAttribute("value", " value=\"", 8186, "\"", 8194, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control masterbatch\"");
            BeginWriteAttribute("value", " value=\"", 8276, "\"", 8284, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control slip\"");
            BeginWriteAttribute("value", " value=\"", 8359, "\"", 8367, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"button\" class=\"form-control save btn btn-primary\" value=\"Save\" /></td>\r\n            </tr>\r\n            <tr>\r\n                <td><input type=\"checkbox\" class=\"form-control lot-update\"");
            BeginWriteAttribute("value", " value=\"", 8594, "\"", 8602, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control date-time\"");
            BeginWriteAttribute("value", " value=\"", 8682, "\"", 8690, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control carton-no\"");
            BeginWriteAttribute("value", " value=\"", 8770, "\"", 8778, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control polymer1\"");
            BeginWriteAttribute("value", " value=\"", 8857, "\"", 8865, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control polymer2\"");
            BeginWriteAttribute("value", " value=\"", 8944, "\"", 8952, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control masterbatch\"");
            BeginWriteAttribute("value", " value=\"", 9034, "\"", 9042, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control slip\"");
            BeginWriteAttribute("value", " value=\"", 9117, "\"", 9125, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"button\" class=\"form-control save btn btn-primary\" value=\"Save\" /></td>\r\n            </tr>\r\n            <tr>\r\n                <td><input type=\"checkbox\" class=\"form-control lot-update\"");
            BeginWriteAttribute("value", " value=\"", 9352, "\"", 9360, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control date-time\"");
            BeginWriteAttribute("value", " value=\"", 9440, "\"", 9448, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control carton-no\"");
            BeginWriteAttribute("value", " value=\"", 9528, "\"", 9536, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control polymer1\"");
            BeginWriteAttribute("value", " value=\"", 9615, "\"", 9623, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control polymer2\"");
            BeginWriteAttribute("value", " value=\"", 9702, "\"", 9710, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control masterbatch\"");
            BeginWriteAttribute("value", " value=\"", 9792, "\"", 9800, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control slip\"");
            BeginWriteAttribute("value", " value=\"", 9875, "\"", 9883, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"button\" class=\"form-control save btn btn-primary\" value=\"Save\" /></td>\r\n            </tr>\r\n            <tr>\r\n                <td><input type=\"checkbox\" class=\"form-control lot-update\"");
            BeginWriteAttribute("value", " value=\"", 10110, "\"", 10118, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control date-time\"");
            BeginWriteAttribute("value", " value=\"", 10198, "\"", 10206, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control carton-no\"");
            BeginWriteAttribute("value", " value=\"", 10286, "\"", 10294, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control polymer1\"");
            BeginWriteAttribute("value", " value=\"", 10373, "\"", 10381, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control polymer2\"");
            BeginWriteAttribute("value", " value=\"", 10460, "\"", 10468, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control masterbatch\"");
            BeginWriteAttribute("value", " value=\"", 10550, "\"", 10558, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control slip\"");
            BeginWriteAttribute("value", " value=\"", 10633, "\"", 10641, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"button\" class=\"form-control save btn btn-primary\" value=\"Save\" /></td>\r\n            </tr>\r\n        </tbody>\r\n    </table>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            let ProductName = getCookie('ProductName');
            let Des = getCookie('Des');
            let LotID = getCookie('LotID');
            let Machine = getCookie('Machine');
            $('#product').val(ProductName);
            $('#des').val(Des);
            var now = new Date();
            let log = now.toLocaleDateString(""en-us"");
            $('#date').val(log);
            let Lot = getCookie('Lot');
            $('#Lot').val(Lot);
                $.ajax({
                    type: ""POST"",
                    url: ""/ProductSetup/MaterialLot"",
                    data: { 'Lot': Lot },
                    success: function (response) {
                        if (response != 'Failed') {
                            let trs = $('tbody tr');
                            for (var i = 0; i < response.length; i++) {
                                var em = response[i];
                                let tr = trs[i];

");
                WriteLiteral(@"                                $($(tr).find('.lot-update')).prop('checked', em.logFile);
                                $($(tr).find('.lot-update')).prop(""disabled"", true);

                                $($(tr).find('.date-time')).val(em.mlctimeStamp);
                                $($(tr).find('.date-time')).prop(""disabled"", true);
                                $($(tr).find('.carton-no')).val(em.cartonNo);
                                $($(tr).find('.carton-no')).prop(""disabled"", true);
                                $($(tr).find('.polymer1')).val(em.p1lot);
                                $($(tr).find('.polymer1')).prop(""disabled"", true);
                                $($(tr).find('.polymer2')).val(em.p2lot);
                                $($(tr).find('.polymer2')).prop(""disabled"", true);
                                $($(tr).find('.masterbatch')).val(em.mblot);
                                $($(tr).find('.masterbatch')).prop(""disabled"", true);
                              ");
                WriteLiteral(@"  $($(tr).find('.slip')).val(em.salot);
                                $($(tr).find('.slip')).prop(""disabled"", true);

                                $($(tr).find('.lot-update')).prop(""disabled"", true);
                                $($(tr).find('.save')).prop(""disabled"", true);
                            }
                        }
                    }
                });
            $('input.lot-update').click(function () {
                if ($(this).prop('checked')) {
                    var now = new Date();
                    let log = now.toLocaleString();
                    $(this).closest('tr').find('input.date-time').val(log);
                }
                else {
                    $(this).closest('tr').find('input.date-time').val('');
                    window.location.href = ""/ProductSetup/LineClearance"";
                }
            });
            $('input.save').click(function () {
                let tr = $(this).closest('tr');

                let time = ");
                WriteLiteral(@"$(tr).find('input.date-time').val();
                let carton = $(tr).find('input.carton-no').val();
                let polymer1 = $(tr).find('input.polymer1').val();
                let polymer2 = $(tr).find('input.polymer2').val();
                let masterbatch = $(tr).find('input.masterbatch').val();
                let slip = $(tr).find('input.slip').val();

                if (time == '' || time == undefined) {
                    toastr.warning('Date/Cat. Time is empty.');
                    return;
                }
                if (carton == '' || carton == undefined) {
                    toastr.warning('Carton No is empty.');
                    return;
                }
                if (polymer1 == '' || polymer1 == undefined) {
                    toastr.warning('Polymer 1 is empty.');
                    return;
                }
               
                $.ajax({
                    type: ""POST"",
                    url: ""/ProductSetup/SaveMaterialLot"",
 ");
                WriteLiteral(@"                   data: {
                        'CartonNo': carton,
                        'P1lot': polymer1,
                        'P2lot': polymer2,
                        'Mblot': masterbatch,
                        'Salot': slip,
                        'Mlctimestamp': time,
                        'LotName': Lot,
                        'Des': Des
                    },
                    success: function (response) {
                        if (response != 'Failed') {
                            toastr.success(""Success to save MaterialLot"");
                            window.location.href = ""/Home/JobBagOverview"";
                        }
                    }
                });
            });

            var timer2 = ""5:00"";
            timerDown(timer2, ""/Home/JobBagOverview"");
        });
    </script>
");
            }
            );
            WriteLiteral("\r\n");
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
