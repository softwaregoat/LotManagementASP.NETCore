#pragma checksum "E:\Project\VisualStudio\Core\alansweetingncl\MVCCoreLoginRegister\MVCCoreLoginRegister\Views\Home\JobBagOverview.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01494865a9286ca2dcbcbc58e0eaaaa2dbf13113"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_JobBagOverview), @"mvc.1.0.view", @"/Views/Home/JobBagOverview.cshtml")]
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
#line 1 "E:\Project\VisualStudio\Core\alansweetingncl\MVCCoreLoginRegister\MVCCoreLoginRegister\Views\_ViewImports.cshtml"
using MVCCoreLoginRegister;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Project\VisualStudio\Core\alansweetingncl\MVCCoreLoginRegister\MVCCoreLoginRegister\Views\_ViewImports.cshtml"
using MVCCoreLoginRegister.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01494865a9286ca2dcbcbc58e0eaaaa2dbf13113", @"/Views/Home/JobBagOverview.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa81fb597f0312d1dc6fa9eddf073d33a4a0fee5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_JobBagOverview : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JobBagOverview>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Project\VisualStudio\Core\alansweetingncl\MVCCoreLoginRegister\MVCCoreLoginRegister\Views\Home\JobBagOverview.cshtml"
  
    ViewData["Title"] = "JobBagOverview";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-center\">Job Bag Overviewy</h1>\r\n<div class=\"row\" style=\"margin:50px;\">\r\n    <div class=\"col-md-2\">\r\n        <select class=\"form-control\" id=\"Technology\" name=\"Technology\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01494865a9286ca2dcbcbc58e0eaaaa2dbf131133749", async() => {
                WriteLiteral("Select Technology");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 12 "E:\Project\VisualStudio\Core\alansweetingncl\MVCCoreLoginRegister\MVCCoreLoginRegister\Views\Home\JobBagOverview.cshtml"
             if (Model.Technologies != null)
            {
                foreach (var item in Model.Technologies)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01494865a9286ca2dcbcbc58e0eaaaa2dbf131135108", async() => {
#nullable restore
#line 16 "E:\Project\VisualStudio\Core\alansweetingncl\MVCCoreLoginRegister\MVCCoreLoginRegister\Views\Home\JobBagOverview.cshtml"
                                                  Write(item.TechnologyName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 16 "E:\Project\VisualStudio\Core\alansweetingncl\MVCCoreLoginRegister\MVCCoreLoginRegister\Views\Home\JobBagOverview.cshtml"
                       WriteLiteral(item.TechnologyId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 17 "E:\Project\VisualStudio\Core\alansweetingncl\MVCCoreLoginRegister\MVCCoreLoginRegister\Views\Home\JobBagOverview.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </select>\r\n    </div>\r\n    <div class=\"col-md-2\">\r\n    </div>\r\n    <div class=\"col-md-2\">\r\n        <select class=\"form-control\" id=\"Machine\" name=\"Machine\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01494865a9286ca2dcbcbc58e0eaaaa2dbf131137471", async() => {
                WriteLiteral("Select Machine");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 26 "E:\Project\VisualStudio\Core\alansweetingncl\MVCCoreLoginRegister\MVCCoreLoginRegister\Views\Home\JobBagOverview.cshtml"
             if (Model.Technologies != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "E:\Project\VisualStudio\Core\alansweetingncl\MVCCoreLoginRegister\MVCCoreLoginRegister\Views\Home\JobBagOverview.cshtml"
                 foreach (var item in Model.Machines)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01494865a9286ca2dcbcbc58e0eaaaa2dbf131139043", async() => {
#nullable restore
#line 30 "E:\Project\VisualStudio\Core\alansweetingncl\MVCCoreLoginRegister\MVCCoreLoginRegister\Views\Home\JobBagOverview.cshtml"
                                               Write(item.MachineName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "E:\Project\VisualStudio\Core\alansweetingncl\MVCCoreLoginRegister\MVCCoreLoginRegister\Views\Home\JobBagOverview.cshtml"
                       WriteLiteral(item.MachineId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 31 "E:\Project\VisualStudio\Core\alansweetingncl\MVCCoreLoginRegister\MVCCoreLoginRegister\Views\Home\JobBagOverview.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "E:\Project\VisualStudio\Core\alansweetingncl\MVCCoreLoginRegister\MVCCoreLoginRegister\Views\Home\JobBagOverview.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </select>\r\n    </div>\r\n    <div class=\"col-md-2\">\r\n    </div>\r\n    <div class=\"col-md-2\">\r\n        <select class=\"form-control\" id=\"Lot\" name=\"Lot\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01494865a9286ca2dcbcbc58e0eaaaa2dbf1311311609", async() => {
                WriteLiteral("Select Lot");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 40 "E:\Project\VisualStudio\Core\alansweetingncl\MVCCoreLoginRegister\MVCCoreLoginRegister\Views\Home\JobBagOverview.cshtml"
             if (Model.Technologies != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "E:\Project\VisualStudio\Core\alansweetingncl\MVCCoreLoginRegister\MVCCoreLoginRegister\Views\Home\JobBagOverview.cshtml"
                 foreach (var item in Model.Lots)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01494865a9286ca2dcbcbc58e0eaaaa2dbf1311313174", async() => {
#nullable restore
#line 44 "E:\Project\VisualStudio\Core\alansweetingncl\MVCCoreLoginRegister\MVCCoreLoginRegister\Views\Home\JobBagOverview.cshtml"
                                           Write(item.LotName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "E:\Project\VisualStudio\Core\alansweetingncl\MVCCoreLoginRegister\MVCCoreLoginRegister\Views\Home\JobBagOverview.cshtml"
                       WriteLiteral(item.LotId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 45 "E:\Project\VisualStudio\Core\alansweetingncl\MVCCoreLoginRegister\MVCCoreLoginRegister\Views\Home\JobBagOverview.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "E:\Project\VisualStudio\Core\alansweetingncl\MVCCoreLoginRegister\MVCCoreLoginRegister\Views\Home\JobBagOverview.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </select>
    </div>
    <div class=""col-md-2"">
    </div>
</div>
<br />
<div class=""row"">
    <div class=""col-md-4"">
        <h3>Master Data</h3>
    </div>
    <div class=""col-md-4"">
        <h3>Additional Information</h3>
    </div>
    <div class=""col-md-4"">
        <h3>Primary Materials</h3>
    </div>
</div>
<br />
    <div class=""row"">
        <div class=""col-md-4"">
            <div class=""form-group"">
                <div class=""row"">
                    <div class=""col-sm-3"">
                        <label for=""ProductName"" class=""control-label"">ProductName</label>
                    </div>
                    <div class=""col-sm-6"">
                        <input id=""ProductName"" type=""text"" class=""form-control"" />
                    </div>
                </div>


            </div>
            <div class=""form-group"">
                <div class=""row"">
                    <div class=""col-sm-3"">
                        <label for=""Des"" class=""control-label");
            WriteLiteral(@""">Description</label>
                    </div>
                    <div class=""col-sm-6"">
                        <input id=""Des"" type=""text"" class=""form-control"" />
                    </div>
                </div>


            </div>
            <div class=""form-group"">
                <div class=""row"">
                    <div class=""col-sm-3"">
                        <label for=""Tol"" class=""control-label"">Tool</label>
                    </div>
                    <div class=""col-sm-6"">
                        <input id=""Tol"" type=""text"" class=""form-control"" />
                    </div>
                </div>


            </div>
            <div class=""form-group"">
                <div class=""row"">
                    <div class=""col-sm-3"">
                        <label for=""Cav"" class=""control-label"">Cavities</label>
                    </div>
                    <div class=""col-sm-6"">
                        <input id=""Cav"" type=""number"" class=""form-control"" />
        ");
            WriteLiteral(@"            </div>
                </div>


            </div>
        </div>
        <div class=""col-md-4"">
            <div class=""form-group"">
                <div class=""row"">
                    <div class=""col-sm-4"">
                        <label for=""Rtq"" class=""control-label"">Run To Quarantine</label>
                    </div>
                    <div class=""col-sm-2"">
                        <input id=""Rtq"" type=""checkbox"" class=""form-control"" />
                    </div>
                </div>

            </div>
            <div class=""form-group"">
                <div class=""row"">
                    <div class=""col-sm-4"">
                        <label for=""Fut"" class=""control-label"">Functional Testing</label>
                    </div>
                    <div class=""col-sm-2"">
                        <input id=""Fut"" type=""checkbox"" class=""form-control"" />
                    </div>
                </div>


            </div>
            <div class=""form-group"">");
            WriteLiteral(@"
                <div class=""row"">
                    <div class=""col-sm-4"">
                        <label for=""Sts"" class=""control-label"">Stratified Samples</label>
                    </div>
                    <div class=""col-sm-2"">
                        <input id=""Sts"" type=""checkbox"" class=""form-control"" />
                    </div>
                </div>


            </div>
            <div class=""form-group"">
                <div class=""row"">
                    <div class=""col-sm-4"">
                        <label for=""Ens"" class=""control-label"">Enhanced Sampling</label>
                    </div>
                    <div class=""col-sm-2"">
                        <input id=""Ens"" type=""checkbox"" class=""form-control"" />
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-md-4"">
            <div class=""form-group"">
                <div class=""row"">
                    <div class=""col-sm-4"">
                        <la");
            WriteLiteral(@"bel for=""P1"" class=""control-label"">Polymer 1</label>
                    </div>
                    <div class=""col-sm-4"">
                        <input id=""P1"" type=""text"" class=""form-control"" />
                    </div>
                    <div class=""col-sm-4"">
                        <input id=""P1q"" type=""number"" class=""form-control"" />
                    </div>
                </div>
            </div>
            <div class=""form-group"">
                <div class=""row"">
                    <div class=""col-sm-4"">
                        <label for=""P2"" class=""control-label"">Polymer 2</label>
                    </div>
                    <div class=""col-sm-4"">
                        <input id=""P2"" type=""text"" class=""form-control"" />
                    </div>
                    <div class=""col-sm-4"">
                        <input id=""P2q"" type=""number"" class=""form-control"" />
                    </div>
                </div>
            </div>
            <div class=""form-g");
            WriteLiteral(@"roup"">
                <div class=""row"">
                    <div class=""col-sm-4"">
                        <label for=""Mb"" class=""control-label"">Masterbatch</label>
                    </div>
                    <div class=""col-sm-4"">
                        <input id=""Mb"" type=""text"" class=""form-control"" />
                    </div>
                    <div class=""col-sm-4"">
                        <input id=""Mbq"" type=""number"" class=""form-control"" />
                    </div>
                </div>
            </div>
            <div class=""form-group"">
                <div class=""row"">
                    <div class=""col-sm-4"">
                        <label for=""Sa"" class=""control-label"">Slip Additive</label>
                    </div>
                    <div class=""col-sm-4"">
                        <input id=""Sa"" type=""text"" class=""form-control"" />
                    </div>
                    <div class=""col-sm-4"">
                        <input id=""Saq"" type=""number"" class=""");
            WriteLiteral(@"form-control"" />
                    </div>
                </div>
            </div>
        </div>
    </div>
    <br />
    <div class=""row"">
        <div class=""col-md-4"">
            <h3>Run Data</h3>
        </div>
        <div class=""col-md-4"">
        </div>
        <div class=""col-md-4"">
            <h3>Packaging Materials</h3>
        </div>
    </div>
    <br />
    <div class=""row"">
        <div class=""col-md-4"">

            <div class=""form-group"">
                <div class=""row"">
                    <div class=""col-sm-3"">
                        <label for=""Loq"" class=""control-label"">Lot Size</label>
                    </div>
                    <div class=""col-sm-6"">
                        <input id=""Loq"" type=""number"" class=""form-control"" />
                    </div>
                </div>


            </div>
            <div class=""form-group"">
                <div class=""row"">
                    <div class=""col-sm-3"">
                        <label ");
            WriteLiteral(@"for=""Cph"" class=""control-label"">Cartons / Hour</label>
                    </div>
                    <div class=""col-sm-6"">
                        <input id=""Cph"" type=""number"" class=""form-control"" />
                    </div>
                </div>


            </div>
            <div class=""form-group"">
                <div class=""row"">
                    <div class=""col-sm-3"">
                        <label for=""Pps"" class=""control-label"">Pallets / Shift</label>
                    </div>
                    <div class=""col-sm-6"">
                        <input id=""Pps"" type=""number"" class=""form-control"" />
                    </div>
                </div>


            </div>
            <div class=""form-group"">
                <div class=""row"">
                    <div class=""col-sm-3"">
                        <label for=""Loh"" class=""control-label"">Lot Duration</label>
                    </div>
                    <div class=""col-sm-6"">
                        <input id=""");
            WriteLiteral(@"Loh"" type=""number"" class=""form-control"" />
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-md-4"">
            <div class=""form-group"">
                <div class=""row"">
                    <div class=""col-sm-4"">
                        <label for=""Coc"" class=""control-label"">C of C</label>
                    </div>
                    <div class=""col-sm-2"">
                        <input id=""Coc"" type=""checkbox"" class=""form-control"" />
                    </div>
                </div>
            </div>
            <div class=""form-group"">
                <div class=""row"">
                    <div class=""col-sm-4"">
                        <label for=""Coa"" class=""control-label"">C of A</label>
                    </div>
                    <div class=""col-sm-2"">
                        <input id=""Coa"" type=""checkbox"" class=""form-control"" />
                    </div>
                </div>

            </div>
            <div");
            WriteLiteral(@" class=""form-group"">
                <div class=""row"">
                    <div class=""col-sm-4"">
                        <label for=""Spc"" class=""control-label"">SPC</label>
                    </div>
                    <div class=""col-sm-2"">
                        <input id=""Spc"" type=""checkbox"" class=""form-control"" />
                    </div>
                </div>


            </div>
            <div class=""form-group"">
                <div class=""row"">
                    <div class=""col-sm-4"">
                        <label for=""Por"" class=""control-label"">Positive Release</label>
                    </div>
                    <div class=""col-sm-2"">
                        <input id=""Por"" type=""checkbox"" class=""form-control"" />
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-md-4"">

            <div class=""form-group"">
                <div class=""row"">
                    <div class=""col-sm-4"">
                    ");
            WriteLiteral(@"    <label for=""Pa"" class=""control-label"">Pallet</label>
                    </div>
                    <div class=""col-sm-4"">
                        <input id=""Pa"" type=""text"" class=""form-control"" />
                    </div>
                    <div class=""col-sm-4"">
                        <input id=""Paq"" type=""number"" class=""form-control"" />
                    </div>
                </div>
            </div>
            <div class=""form-group"">
                <div class=""row"">
                    <div class=""col-sm-4"">
                        <label for=""Ca"" class=""control-label"">Carton</label>
                    </div>
                    <div class=""col-sm-4"">
                        <input id=""Ca"" type=""text"" class=""form-control"" />
                    </div>
                    <div class=""col-sm-4"">
                        <input id=""Caq"" type=""number"" class=""form-control"" />
                    </div>
                </div>
            </div>
            <div class=""form-");
            WriteLiteral(@"group"">
                <div class=""row"">
                    <div class=""col-sm-4"">
                        <label for=""Cl"" class=""control-label"">Carton Liner</label>
                    </div>
                    <div class=""col-sm-4"">
                        <input id=""Cl"" type=""text"" class=""form-control"" />
                    </div>
                    <div class=""col-sm-4"">
                        <input id=""Clq"" type=""number"" class=""form-control"" />
                    </div>
                </div>
            </div>
            <div class=""form-group"">
                <div class=""row"">
                    <div class=""col-sm-4"">
                        <label for=""lb"" class=""control-label"">Inner Bag</label>
                    </div>
                    <div class=""col-sm-4"">
                        <input id=""lb"" type=""text"" class=""form-control"" />
                    </div>
                    <div class=""col-sm-4"">
                        <input id=""lbq"" type=""number"" class=""fo");
            WriteLiteral("rm-control\" />\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
        <script>
            $(document).ready(function () {
                let Technology = getCookie('Technology');
                let Machine = getCookie('Machine');
                let Lot = getCookie('Lot');

                if (Technology != null && Machine != null && Lot != null) {
                    getQryLot(Technology, Machine, Lot);
                }
                
                $('select').change(function () {
                    let Technology = $(""#Technology option:selected"").text();
                    if (Technology.includes('Select')) {
                        toastr.error('Please select Technology');
                        return;
                    }
                    let Machine = $(""#Machine option:selected"").text();
                    if (Machine.includes('Select')) {
                        toastr.error('Please select Machine');
                        return;
                    }
                    let Lot = $(""#Lot option:selected"").text();
     ");
                WriteLiteral(@"               if (Lot.includes('Select')) {
                        toastr.error('Please select Lot');
                        return;
                    }
                    setCookie('Technology', Technology, 1);
                    setCookie('Machine', Machine, 1);
                    setCookie('Lot', Lot, 1);
                    getQryLot(Technology, Machine, Lot);
                });
            });
            function getQryLot(Technology, Machine, Lot) {
                $.ajax({
                    type: ""POST"",
                    url: ""/Home/QryLot"",
                    data: { 'Technology': Technology, 'Machine': Machine, 'Lot': Lot },
                    success: function (response) {
                        if (response != 'Failed') {
                            $('#ProductName').val(response.productName);
                            $('#Des').val(response.des);
                            $('#Tol').val(response.tol);
                            $('#Cav').val(response.cav);");
                WriteLiteral(@"
                            $('#Loq').val(response.loq);
                            $('#Cph').val(response.cph);
                            $('#Pps').val(response.pps);
                            $('#Loh').val(response.loh);
                            $('#P1').val(response.p1);
                            $('#P1q').val(response.p1q);
                            $('#P2').val(response.p2);
                            $('#P2q').val(response.p2q);
                            $('#Mb').val(response.mb);
                            $('#Mbq').val(response.mbq);
                            $('#Sa').val(response.sa);
                            $('#Saq').val(response.saq);
                            $('#Pa').val(response.pa);
                            $('#Paq').val(response.paq);
                            $('#Ca').val(response.ca);
                            $('#Caq').val(response.caq);
                            $('#Cl').val(response.cl);
                            $('#Clq').val(response");
                WriteLiteral(@".clq);
                            $('#lb').val(response.lb);
                            $('#lbq').val(response.lbq);
                            if (response.rtq) {
                                $('#Rtq').prop('checked', true);
                            } else {
                                $('#Rtq').prop('checked', false);
                            }
                            if (response.fut) {
                                $('#Fut').prop('checked', true);
                            } else {
                                $('#Fut').prop('checked', false);
                            }
                            if (response.sts) {
                                $('#Sts').prop('checked', true);
                            } else {
                                $('#Sts').prop('checked', false);
                            }
                            if (response.ens) {
                                $('#Ens').prop('checked', true);
                            } else");
                WriteLiteral(@" {
                                $('#Ens').prop('checked', false);
                            }
                            if (response.coc) {
                                $('#Coc').prop('checked', true);
                            } else {
                                $('#Coc').prop('checked', false);
                            }
                            if (response.coa) {
                                $('#Coa').prop('checked', true);
                            } else {
                                $('#Coa').prop('checked', false);
                            }
                            if (response.spc) {
                                $('#Spc').prop('checked', true);
                            } else {
                                $('#Spc').prop('checked', false);
                            }
                            if (response.por) {
                                $('#Por').prop('checked', true);
                            } else {
                ");
                WriteLiteral(@"                $('#Por').prop('checked', false);
                            }
                            toastr.success('Success!');
                        } else {
                            toastr.error('There is no QryLot');
                        }
                    },
                    failure: function (response) {
                        toastr.error(response.responseText);
                    },
                    error: function (response) {
                        toastr.error(response.responseText);
                    }
                });
            }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JobBagOverview> Html { get; private set; }
    }
}
#pragma warning restore 1591
