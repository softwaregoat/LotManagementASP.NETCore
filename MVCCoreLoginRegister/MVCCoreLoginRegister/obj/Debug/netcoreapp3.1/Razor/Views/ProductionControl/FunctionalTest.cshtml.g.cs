#pragma checksum "E:\Project\VisualStudio\Core\LotManagementASP.NETCore\MVCCoreLoginRegister\MVCCoreLoginRegister\Views\ProductionControl\FunctionalTest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2dd82b6e7bcebc5339df7dab63fcf8c1cdb91e30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductionControl_FunctionalTest), @"mvc.1.0.view", @"/Views/ProductionControl/FunctionalTest.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2dd82b6e7bcebc5339df7dab63fcf8c1cdb91e30", @"/Views/ProductionControl/FunctionalTest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa81fb597f0312d1dc6fa9eddf073d33a4a0fee5", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductionControl_FunctionalTest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\Project\VisualStudio\Core\LotManagementASP.NETCore\MVCCoreLoginRegister\MVCCoreLoginRegister\Views\ProductionControl\FunctionalTest.cshtml"
  
    ViewData["Title"] = "Functional Test";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1 class=""text-center"">Functional Test</h1>
<br />
<div class=""row"">
    <div class=""col-md-2"">
        <label class=""col-form-label"">Product</label>
    </div>
    <div class=""col-md-4"">
        <input type=""text"" class=""form-control"" id=""product""");
            BeginWriteAttribute("value", " value=\"", 358, "\"", 366, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n</div>\r\n<br />\r\n<div class=\"row\">\r\n    <div class=\"col-md-2\">\r\n        <label class=\"col-form-label\">Description</label>\r\n    </div>\r\n    <div class=\"col-md-4\">\r\n        <input type=\"text\" class=\"form-control\" id=\"des\"");
            BeginWriteAttribute("value", " value=\"", 602, "\"", 610, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n</div>\r\n<br />\r\n<div class=\"row\">\r\n    <div class=\"col-md-2\">\r\n        <label class=\"col-form-label\">Lot</label>\r\n    </div>\r\n    <div class=\"col-md-4\">\r\n        <input type=\"text\" class=\"form-control\" id=\"Lot\"");
            BeginWriteAttribute("value", " value=\"", 838, "\"", 846, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n</div>\r\n<br />\r\n<div class=\"row\">\r\n    <div class=\"col-md-2\">\r\n        <label class=\"col-form-label\">Date</label>\r\n    </div>\r\n    <div class=\"col-md-4\">\r\n        <input type=\"text\" class=\"form-control\" id=\"date\"");
            BeginWriteAttribute("value", " value=\"", 1076, "\"", 1084, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
    </div>
</div>
<br />
<div class=""row"">
    <table class=""table table-borderless table-sm"">
        <thead>
            <tr>
                <th scope=""col"">Log</th>
                <th scope=""col"">Date/Act. Time</th>
                <th scope=""col"">Carton No</th>
                <th scope=""col"">Sample Size</th>
                <th scope=""col"">Test Type</th>
                <th scope=""col"">Result</th>
                <th scope=""col"">Comment</th>
                <th scope=""col"">Save</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td><input type=""checkbox"" class=""form-control log""");
            BeginWriteAttribute("value", " value=\"", 1739, "\"", 1747, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control date-time\"");
            BeginWriteAttribute("value", " value=\"", 1827, "\"", 1835, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control carton-no\"");
            BeginWriteAttribute("value", " value=\"", 1915, "\"", 1923, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control sample-size\"");
            BeginWriteAttribute("value", " value=\"", 2005, "\"", 2013, 0);
            EndWriteAttribute();
            WriteLiteral(@" /></td>
                <td>
                    <select class=""form-control test-type"">
                        
                    </select>
                </td>
                <td>
                    <select class=""form-control result"">
                        
                    </select>
                </td>
                <td><textarea class=""form-text comment""></textarea></td>
                <td><input type=""button"" class=""form-control save btn btn-primary"" value=""Save"" /></td>
            </tr>
            <tr>
                <td><input type=""checkbox"" class=""form-control log""");
            BeginWriteAttribute("value", " value=\"", 2630, "\"", 2638, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control date-time\"");
            BeginWriteAttribute("value", " value=\"", 2718, "\"", 2726, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control carton-no\"");
            BeginWriteAttribute("value", " value=\"", 2806, "\"", 2814, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control sample-size\"");
            BeginWriteAttribute("value", " value=\"", 2896, "\"", 2904, 0);
            EndWriteAttribute();
            WriteLiteral(@" /></td>
                <td>
                    <select class=""form-control test-type"">
                        
                    </select>
                </td>
                <td>
                    <select class=""form-control result"">
                        
                    </select>
                </td>
                <td><textarea class=""form-text comment""></textarea></td>
                <td><input type=""button"" class=""form-control save btn btn-primary"" value=""Save"" /></td>
            </tr>


            <tr>
                <td><input type=""checkbox"" class=""form-control log""");
            BeginWriteAttribute("value", " value=\"", 3525, "\"", 3533, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control date-time\"");
            BeginWriteAttribute("value", " value=\"", 3613, "\"", 3621, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control carton-no\"");
            BeginWriteAttribute("value", " value=\"", 3701, "\"", 3709, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control sample-size\"");
            BeginWriteAttribute("value", " value=\"", 3791, "\"", 3799, 0);
            EndWriteAttribute();
            WriteLiteral(@" /></td>
                <td>
                    <select class=""form-control test-type"">
                        
                    </select>
                </td>
                <td>
                    <select class=""form-control result"">
                        
                    </select>
                </td>
                <td><textarea class=""form-text comment""></textarea></td>
                <td><input type=""button"" class=""form-control save btn btn-primary"" value=""Save"" /></td>
            </tr>
            <tr>
                <td><input type=""checkbox"" class=""form-control log""");
            BeginWriteAttribute("value", " value=\"", 4416, "\"", 4424, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control date-time\"");
            BeginWriteAttribute("value", " value=\"", 4504, "\"", 4512, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control carton-no\"");
            BeginWriteAttribute("value", " value=\"", 4592, "\"", 4600, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control sample-size\"");
            BeginWriteAttribute("value", " value=\"", 4682, "\"", 4690, 0);
            EndWriteAttribute();
            WriteLiteral(@" /></td>
                <td>
                    <select class=""form-control test-type"">
                        
                    </select>
                </td>
                <td>
                    <select class=""form-control result"">
                        
                    </select>
                </td>
                <td><textarea class=""form-text comment""></textarea></td>
                <td><input type=""button"" class=""form-control save btn btn-primary"" value=""Save"" /></td>
            </tr>
            <tr>
                <td><input type=""checkbox"" class=""form-control log""");
            BeginWriteAttribute("value", " value=\"", 5307, "\"", 5315, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control date-time\"");
            BeginWriteAttribute("value", " value=\"", 5395, "\"", 5403, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control carton-no\"");
            BeginWriteAttribute("value", " value=\"", 5483, "\"", 5491, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control sample-size\"");
            BeginWriteAttribute("value", " value=\"", 5573, "\"", 5581, 0);
            EndWriteAttribute();
            WriteLiteral(@" /></td>
                <td>
                    <select class=""form-control test-type"">
                        
                    </select>
                </td>
                <td>
                    <select class=""form-control result"">
                        
                    </select>
                </td>
                <td><textarea class=""form-text comment""></textarea></td>
                <td><input type=""button"" class=""form-control save btn btn-primary"" value=""Save"" /></td>
            </tr>
            <tr>
                <td><input type=""checkbox"" class=""form-control log""");
            BeginWriteAttribute("value", " value=\"", 6198, "\"", 6206, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control date-time\"");
            BeginWriteAttribute("value", " value=\"", 6286, "\"", 6294, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control carton-no\"");
            BeginWriteAttribute("value", " value=\"", 6374, "\"", 6382, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control sample-size\"");
            BeginWriteAttribute("value", " value=\"", 6464, "\"", 6472, 0);
            EndWriteAttribute();
            WriteLiteral(@" /></td>
                <td>
                    <select class=""form-control test-type"">
                        
                    </select>
                </td>
                <td>
                    <select class=""form-control result"">
                        
                    </select>
                </td>
                <td><textarea class=""form-text comment""></textarea></td>
                <td><input type=""button"" class=""form-control save btn btn-primary"" value=""Save"" /></td>
            </tr>
            <tr>
                <td><input type=""checkbox"" class=""form-control log""");
            BeginWriteAttribute("value", " value=\"", 7089, "\"", 7097, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control date-time\"");
            BeginWriteAttribute("value", " value=\"", 7177, "\"", 7185, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control carton-no\"");
            BeginWriteAttribute("value", " value=\"", 7265, "\"", 7273, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control sample-size\"");
            BeginWriteAttribute("value", " value=\"", 7355, "\"", 7363, 0);
            EndWriteAttribute();
            WriteLiteral(@" /></td>
                <td>
                    <select class=""form-control test-type"">
                        
                    </select>
                </td>
                <td>
                    <select class=""form-control result"">
                        
                    </select>
                </td>
                <td><textarea class=""form-text comment""></textarea></td>
                <td><input type=""button"" class=""form-control save btn btn-primary"" value=""Save"" /></td>
            </tr>
            <tr>
                <td><input type=""checkbox"" class=""form-control log""");
            BeginWriteAttribute("value", " value=\"", 7980, "\"", 7988, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control date-time\"");
            BeginWriteAttribute("value", " value=\"", 8068, "\"", 8076, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control carton-no\"");
            BeginWriteAttribute("value", " value=\"", 8156, "\"", 8164, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control sample-size\"");
            BeginWriteAttribute("value", " value=\"", 8246, "\"", 8254, 0);
            EndWriteAttribute();
            WriteLiteral(@" /></td>
                <td>
                    <select class=""form-control test-type"">
                        
                    </select>
                </td>
                <td>
                    <select class=""form-control result"">
                        
                    </select>
                </td>
                <td><textarea class=""form-text comment""></textarea></td>
                <td><input type=""button"" class=""form-control save btn btn-primary"" value=""Save"" /></td>
            </tr>
            <tr>
                <td><input type=""checkbox"" class=""form-control log""");
            BeginWriteAttribute("value", " value=\"", 8871, "\"", 8879, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control date-time\"");
            BeginWriteAttribute("value", " value=\"", 8959, "\"", 8967, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control carton-no\"");
            BeginWriteAttribute("value", " value=\"", 9047, "\"", 9055, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control sample-size\"");
            BeginWriteAttribute("value", " value=\"", 9137, "\"", 9145, 0);
            EndWriteAttribute();
            WriteLiteral(@" /></td>
                <td>
                    <select class=""form-control test-type"">
                        
                    </select>
                </td>
                <td>
                    <select class=""form-control result"">
                        
                    </select>
                </td>
                <td><textarea class=""form-text comment""></textarea></td>
                <td><input type=""button"" class=""form-control save btn btn-primary"" value=""Save"" /></td>
            </tr>
            <tr>
                <td><input type=""checkbox"" class=""form-control log""");
            BeginWriteAttribute("value", " value=\"", 9762, "\"", 9770, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control date-time\"");
            BeginWriteAttribute("value", " value=\"", 9850, "\"", 9858, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control carton-no\"");
            BeginWriteAttribute("value", " value=\"", 9938, "\"", 9946, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control sample-size\"");
            BeginWriteAttribute("value", " value=\"", 10028, "\"", 10036, 0);
            EndWriteAttribute();
            WriteLiteral(@" /></td>
                <td>
                    <select class=""form-control test-type"">
                        
                    </select>
                </td>
                <td>
                    <select class=""form-control result"">
                        
                    </select>
                </td>
                <td><textarea class=""form-text comment""></textarea></td>
                <td><input type=""button"" class=""form-control save btn btn-primary"" value=""Save"" /></td>
            </tr>
            <tr>
                <td><input type=""checkbox"" class=""form-control log""");
            BeginWriteAttribute("value", " value=\"", 10653, "\"", 10661, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control date-time\"");
            BeginWriteAttribute("value", " value=\"", 10741, "\"", 10749, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control carton-no\"");
            BeginWriteAttribute("value", " value=\"", 10829, "\"", 10837, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control sample-size\"");
            BeginWriteAttribute("value", " value=\"", 10919, "\"", 10927, 0);
            EndWriteAttribute();
            WriteLiteral(@" /></td>
                <td>
                    <select class=""form-control test-type"">
                        
                    </select>
                </td>
                <td>
                    <select class=""form-control result"">
                        
                    </select>
                </td>
                <td><textarea class=""form-text comment""></textarea></td>
                <td><input type=""button"" class=""form-control save btn btn-primary"" value=""Save"" /></td>
            </tr>
            <tr>
                <td><input type=""checkbox"" class=""form-control log""");
            BeginWriteAttribute("value", " value=\"", 11544, "\"", 11552, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control date-time\"");
            BeginWriteAttribute("value", " value=\"", 11632, "\"", 11640, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control carton-no\"");
            BeginWriteAttribute("value", " value=\"", 11720, "\"", 11728, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td><input type=\"text\" class=\"form-control sample-size\"");
            BeginWriteAttribute("value", " value=\"", 11810, "\"", 11818, 0);
            EndWriteAttribute();
            WriteLiteral(@" /></td>
                <td>
                    <select class=""form-control test-type"">
                        
                    </select>
                </td>
                <td>
                    <select class=""form-control result"">
                        
                    </select>
                </td>
                <td><textarea class=""form-text comment""></textarea></td>
                <td><input type=""button"" class=""form-control save btn btn-primary"" value=""Save"" /></td>
            </tr>
        </tbody>
    </table>
</div>
");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            let ProductName = getCookie('ProductName');
            let Des = getCookie('Des');
            $('#product').val(ProductName);
            $('#des').val(Des);
            var now = new Date();
            let log = now.toLocaleDateString(""en-US"");
            $('#date').val(log);
            let Lot = getCookie('Lot');
            $('#Lot').val(Lot);
            $.ajax({
                type: ""POST"",
                url: ""/ProductionControl/FunctionalTestResult"",
                success: function (response) {
                    if (response != 'Failed') {
                        var items = '<option></option>';
                        for (var i = 0; i < response.length; i++) {
                            var em = response[i];
                            items += ""<option value='"" + em.functionalTestResultId + ""'>"" + em.testResult + ""</option>"";
                        }
                        $('tbody tr').each(functio");
                WriteLiteral(@"n (i, em) {
                            var test = $(this).find('.result');
                            $(test).empty();
                            $(test).html(items);
                        });
                        toastr.success('Success to load TestResult');
                    }
                    else {
                        toastr.error(response);
                    }
                }
            }).done(function () {
                $.ajax({
                    type: ""POST"",
                    url: ""/ProductionControl/FunctionalTestType"",
                    success: function (response) {
                        if (response != 'Failed') {
                            var items = '<option></option>';
                            for (var i = 0; i < response.length; i++) {
                                var em = response[i];
                                items += ""<option value='"" + em.functionalTestTypeId + ""'>"" + em.testType + ""</option>"";
                            ");
                WriteLiteral(@"}
                            $('tbody tr').each(function (i, em) {
                                var test_type = $(this).find('.test-type');
                                $(test_type).empty();
                                $(test_type).html(items);
                            });
                        }
                        
                    }
                }).done(function () {
                    $.ajax({
                        type: ""POST"",
                        url: ""/ProductionControl/FunctionalTest"",
                        data: { 'Lot': Lot },
                        success: function (response) {
                            if (response != 'Failed') {
                                let trs = $('tbody tr');
                                for (var i = 0; i < response.length; i++) {
                                    var em = response[i];
                                    let tr = trs[i];

                                    $($(tr).find('.log')).prop('check");
                WriteLiteral(@"ed', em.logFile);
                                    $($(tr).find('.log')).prop(""disabled"", true);

                                    $($(tr).find('.date-time')).val(em.fttimeStamp);
                                    $($(tr).find('.date-time')).prop(""disabled"", true);

                                    $($(tr).find('.carton-no')).val(em.cartonNo);
                                    $($(tr).find('.carton-no')).prop(""disabled"", true);

                                    $($(tr).find('.sample-size')).val(em.sampleSize);
                                    $($(tr).find('.sample-size')).prop(""disabled"", true);

                                    $($(tr).find('.test-type')).html('<option>' + em.testType + '</option>');
                                    $($(tr).find('.test-type')).prop(""disabled"", true);

                                    $($(tr).find('.result')).html('<option>' + em.result + '</option>');
                                    $($(tr).find('.result')).prop(""disabled"", tru");
                WriteLiteral(@"e);

                                    $($(tr).find('.comment')).val(em.comment);
                                    $($(tr).find('.comment')).prop(""disabled"", true);

                                    $($(tr).find('.save')).prop(""disabled"", true);
                                    $($(tr).find('.log')).prop(""disabled"", true);
                                }
                            }
                        }
                    });
                });
            });
            
            

            $('input.log').click(function () {
                if ($(this).prop('checked')) {
                    var now = new Date();
                    let log = now.toLocaleString();
                    $(this).closest('tr').find('input.date-time').val(log);
                }
                else {
                    $(this).closest('tr').find('input.date-time').val('');
                    window.location.href = ""/ProductSetup/Authorisation"";
                }
            }");
                WriteLiteral(@");
            $('input.save').click(function () {
                let tr = $(this).closest('tr');
                
                let CartonNo = $(tr).find('.carton-no').val();
                let Comment = $(tr).find('.comment').val();
                let FttimeStamp = $(tr).find('.date-time').val();
                let Result = $(tr).find('.result option:selected').text();
                let SampleSize = $(tr).find('.sample-size').val();
                let TestType = $(tr).find('.test-type option:selected').text();

                if (FttimeStamp == '' || FttimeStamp == undefined) {
                    toastr.warning('Date/Cat. Time is empty.');
                    return;
                }
                if (CartonNo == '' || CartonNo == undefined) {
                    toastr.warning('Carton No is empty.');
                    return;
                }
                if (SampleSize == '' || SampleSize == undefined) {
                    toastr.warning('Sample Size is empty.');
");
                WriteLiteral(@"                    return;
                }
                if (TestType == '' || TestType == undefined) {
                    toastr.warning('Test Type is empty.');
                    return;
                }
                if (Result == '' || Result == undefined) {
                    toastr.warning('Result is empty.');
                    return;
                }
                if (Comment == '' || Comment == undefined) {
                    toastr.warning('Comment is empty.');
                    return;
                }
                $.ajax({
                    type: ""POST"",
                    url: ""/ProductionControl/SaveFunctionalTest"",
                    data: {
                        'CartonNo': CartonNo,
                        'Comment': Comment,
                        'Des': Des,
                        'FttimeStamp': FttimeStamp,
                        'LotName': Lot,
                        'Product': ProductName,
                        'Result': Result,");
                WriteLiteral(@"
                        'SampleSize': SampleSize,
                        'TestType': TestType
                    },
                    success: function (response) {
                        if (response != 'Failed') {
                            window.location.href = ""/Home/JobBagOverview"";
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
