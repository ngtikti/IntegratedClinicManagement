#pragma checksum "C:\Users\ngtik\Dropbox\dotnet Work\IntegratedClinicManagement\Views\Doctor\ViewDoctor_Schedule.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1962426c2c964e187628dd9262616ddbefdd76d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Doctor_ViewDoctor_Schedule), @"mvc.1.0.view", @"/Views/Doctor/ViewDoctor_Schedule.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1962426c2c964e187628dd9262616ddbefdd76d5", @"/Views/Doctor/ViewDoctor_Schedule.cshtml")]
    public class Views_Doctor_ViewDoctor_Schedule : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ClinicManagementProject.Models.DoctorSchedule>>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\ngtik\Dropbox\dotnet Work\IntegratedClinicManagement\Views\Doctor\ViewDoctor_Schedule.cshtml"
  Layout = "~/views/Doctor/_DoctorLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1962426c2c964e187628dd9262616ddbefdd76d52943", async() => {
                WriteLiteral(@"
    <p>
        <br /><br />
        <b>Available bookings for you</b>
    </p>
    <form method=""get"" name=""frmViewDoctorSchedule"">
        <table class=""table"" width=""50%"" align=""center"">
            <thead>
                <tr>

                    <th>
                        ");
#nullable restore
#line 16 "C:\Users\ngtik\Dropbox\dotnet Work\IntegratedClinicManagement\Views\Doctor\ViewDoctor_Schedule.cshtml"
                   Write(Html.DisplayNameFor(model => model.Time));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </th>\n\n                    <th>\n                        ");
#nullable restore
#line 20 "C:\Users\ngtik\Dropbox\dotnet Work\IntegratedClinicManagement\Views\Doctor\ViewDoctor_Schedule.cshtml"
                   Write(Html.DisplayNameFor(model => model.Patient.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </th>\n\n                    <th>\n                        Click to Start Consultation\n                    </th>\n\n                </tr>\n            </thead>\n            <tbody>\n");
#nullable restore
#line 30 "C:\Users\ngtik\Dropbox\dotnet Work\IntegratedClinicManagement\Views\Doctor\ViewDoctor_Schedule.cshtml"
                 if (Model != null)
                {
                    foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("    <tr>\n        <td>\n            ");
#nullable restore
#line 36 "C:\Users\ngtik\Dropbox\dotnet Work\IntegratedClinicManagement\Views\Doctor\ViewDoctor_Schedule.cshtml"
       Write(Html.DisplayFor(modelItem => item.Time));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        </td>\n\n        <td>\n            ");
#nullable restore
#line 40 "C:\Users\ngtik\Dropbox\dotnet Work\IntegratedClinicManagement\Views\Doctor\ViewDoctor_Schedule.cshtml"
       Write(Html.DisplayFor(modelItem => item.Patient.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        </td>\n\n        <td>\n");
#nullable restore
#line 44 "C:\Users\ngtik\Dropbox\dotnet Work\IntegratedClinicManagement\Views\Doctor\ViewDoctor_Schedule.cshtml"
               if (item.Patient_Id != null)
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\ngtik\Dropbox\dotnet Work\IntegratedClinicManagement\Views\Doctor\ViewDoctor_Schedule.cshtml"
               Write(Html.ActionLink("Doctor Consultations", "ConsultationUpdate", new { timeSlotId = item.Timeslot_Id, patId = item.Patient_Id, docId = item.Doctor_Id }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\ngtik\Dropbox\dotnet Work\IntegratedClinicManagement\Views\Doctor\ViewDoctor_Schedule.cshtml"
                                                                                                                                                                           
               else
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\ngtik\Dropbox\dotnet Work\IntegratedClinicManagement\Views\Doctor\ViewDoctor_Schedule.cshtml"
       Write(Html.DisplayName("No bookings Done"));

#line default
#line hidden
#nullable disable
                WriteLiteral("        </td>\n    </tr> ");
#nullable restore
#line 50 "C:\Users\ngtik\Dropbox\dotnet Work\IntegratedClinicManagement\Views\Doctor\ViewDoctor_Schedule.cshtml"
          }
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("    <tr>\n        <td colspan=\"2\">\n            No Consultation slot booked for you\n        </td>\n    </tr>\n");
#nullable restore
#line 59 "C:\Users\ngtik\Dropbox\dotnet Work\IntegratedClinicManagement\Views\Doctor\ViewDoctor_Schedule.cshtml"
}

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tbody>\n        </table>\n    </form>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ClinicManagementProject.Models.DoctorSchedule>> Html { get; private set; }
    }
}
#pragma warning restore 1591
