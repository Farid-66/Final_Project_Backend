#pragma checksum "C:\Users\HP\Desktop\Final_Project\Back_end\PreSkool_project\PreSkool_project\Views\TeacherDashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8689cc5789b4d686c6c63f5feef2f0dc89f76238"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TeacherDashboard_Index), @"mvc.1.0.view", @"/Views/TeacherDashboard/Index.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\Final_Project\Back_end\PreSkool_project\PreSkool_project\Views\_ViewImports.cshtml"
using PreSkool_project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\Final_Project\Back_end\PreSkool_project\PreSkool_project\Views\_ViewImports.cshtml"
using PreSkool_project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Desktop\Final_Project\Back_end\PreSkool_project\PreSkool_project\Views\_ViewImports.cshtml"
using PreSkool_project.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\Desktop\Final_Project\Back_end\PreSkool_project\PreSkool_project\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8689cc5789b4d686c6c63f5feef2f0dc89f76238", @"/Views/TeacherDashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3afe996cee6003cd3de766477fa7edb07bf1de9", @"/Views/_ViewImports.cshtml")]
    public class Views_TeacherDashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VmTeacherDashboard>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\HP\Desktop\Final_Project\Back_end\PreSkool_project\PreSkool_project\Views\TeacherDashboard\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_LayoutTeacher.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n <main>\r\n        <div class=\"container-fluid\">\r\n            <div class=\"row\">\r\n                <div class=\"col-12 page_title\">\r\n                    <div>\r\n                        <h2>Welcome ");
#nullable restore
#line 12 "C:\Users\HP\Desktop\Final_Project\Back_end\PreSkool_project\PreSkool_project\Views\TeacherDashboard\Index.cshtml"
                               Write(Model.Teachers.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                        <p>Dashboard</p>
                    </div>
                </div>
            </div>

            <div class=""row"">
                <div class=""col-xl-3 col-sm-6 col-12"">
                    <div class=""breadcrumb bg_three"">
                        <div class=""bd-icon"">
                            <i class=""fas fa-chalkboard""></i>
                        </div>
                        <div class=""bd-body"">

");
#nullable restore
#line 26 "C:\Users\HP\Desktop\Final_Project\Back_end\PreSkool_project\PreSkool_project\Views\TeacherDashboard\Index.cshtml"
                          
                            int i = 0;
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 30 "C:\Users\HP\Desktop\Final_Project\Back_end\PreSkool_project\PreSkool_project\Views\TeacherDashboard\Index.cshtml"
                         foreach (var item in Model.ClassToSubjects)
                        {
                            if (Model.Teachers.Subject.Id == item.SubjectId)
                            {
                                i++;
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <h3>");
#nullable restore
#line 38 "C:\Users\HP\Desktop\Final_Project\Back_end\PreSkool_project\PreSkool_project\Views\TeacherDashboard\Index.cshtml"
                           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                            <h6>Total Classes</h6>
                        </div>
                    </div>
                </div>
                <div class=""col-xl-3 col-sm-6 col-12"">
                    <div class=""breadcrumb bg_one "">
                       <div class=""bd-icon"">
                            <i class=""fa-solid fa-calendar-check""></i>
                        </div>
                        <div class=""bd-body"">
                            <h3>");
#nullable restore
#line 49 "C:\Users\HP\Desktop\Final_Project\Back_end\PreSkool_project\PreSkool_project\Views\TeacherDashboard\Index.cshtml"
                           Write(Model.Teachers.JoiningDate.ToString("dd MMM"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                            <h6>Joining Date</h6>
                        </div>
                    </div>
                </div>
                <div class=""col-xl-3 col-sm-6 col-12"">
                    <div class=""breadcrumb bg_four"">
                        <div class=""bd-icon"">
                            <i class=""fas fa-clock""></i>
                        </div>
");
#nullable restore
#line 59 "C:\Users\HP\Desktop\Final_Project\Back_end\PreSkool_project\PreSkool_project\Views\TeacherDashboard\Index.cshtml"
                          decimal h=i*((decimal)1.5);

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"bd-body\">\r\n                            <h3>");
#nullable restore
#line 61 "C:\Users\HP\Desktop\Final_Project\Back_end\PreSkool_project\PreSkool_project\Views\TeacherDashboard\Index.cshtml"
                           Write(h);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                            <h6>Total Hours</h6>
                        </div>
                    </div>
                </div>
                <div class=""col-xl-3 col-sm-6 col-12"">
                    <div class=""breadcrumb bg_tow"">
                        <div class=""bd-icon"">
                            <i class=""fas fa-file-invoice-dollar""></i>
                        </div>
                        <div class=""bd-body"">
                            <h3>");
#nullable restore
#line 72 "C:\Users\HP\Desktop\Final_Project\Back_end\PreSkool_project\PreSkool_project\Views\TeacherDashboard\Index.cshtml"
                           Write(Model.Salaries.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" $</h3>
                            <h6>Salary</h6>
                        </div>
                    </div>
                </div>
                
            </div>

            <div class=""row"">
                <div class=""col-12 my-5 subjects"">
                    
");
#nullable restore
#line 83 "C:\Users\HP\Desktop\Final_Project\Back_end\PreSkool_project\PreSkool_project\Views\TeacherDashboard\Index.cshtml"
                 foreach (var item in Model.ClassToSubjects)
                {
                    if (Model.Teachers.Subject.Id == item.SubjectId)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>");
#nullable restore
#line 87 "C:\Users\HP\Desktop\Final_Project\Back_end\PreSkool_project\PreSkool_project\Views\TeacherDashboard\Index.cshtml"
                         Write(item.Class.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 88 "C:\Users\HP\Desktop\Final_Project\Back_end\PreSkool_project\PreSkool_project\Views\TeacherDashboard\Index.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>


            <div class=""row"">
                <div class=""col-12 mt-5 "">
                    <table class=""table"">
                        <tbody>
                          <tr>
                            <th class=""p-3"" scope=""row"">Name</th>
                            <td class=""p-3"">");
#nullable restore
#line 100 "C:\Users\HP\Desktop\Final_Project\Back_end\PreSkool_project\PreSkool_project\Views\TeacherDashboard\Index.cshtml"
                                       Write(Model.Teachers.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                          </tr>\r\n                          <tr>\r\n                            <th class=\"p-3\" scope=\"row\">Surname</th>\r\n                            <td class=\"p-3\">");
#nullable restore
#line 104 "C:\Users\HP\Desktop\Final_Project\Back_end\PreSkool_project\PreSkool_project\Views\TeacherDashboard\Index.cshtml"
                                       Write(Model.Teachers.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                          </tr>\r\n                          <tr>\r\n                            <th class=\"p-3\" scope=\"row\">Email</th>\r\n                            <td class=\"p-3\">");
#nullable restore
#line 108 "C:\Users\HP\Desktop\Final_Project\Back_end\PreSkool_project\PreSkool_project\Views\TeacherDashboard\Index.cshtml"
                                       Write(Model.Teachers.CustomUser.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                          </tr>\r\n                          <tr>\r\n                            <th class=\"p-3\" scope=\"row\">Subject</th>\r\n                            <td class=\"p-3\">");
#nullable restore
#line 112 "C:\Users\HP\Desktop\Final_Project\Back_end\PreSkool_project\PreSkool_project\Views\TeacherDashboard\Index.cshtml"
                                       Write(Model.Teachers.Subject.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                          </tr>\r\n                          <tr>\r\n                            <th class=\"p-3\" scope=\"row\">Joining Date</th>\r\n                            <td class=\"p-3\">");
#nullable restore
#line 116 "C:\Users\HP\Desktop\Final_Project\Back_end\PreSkool_project\PreSkool_project\Views\TeacherDashboard\Index.cshtml"
                                       Write(Model.Teachers.JoiningDate.ToString("dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                          </tr>\r\n                        </tbody>\r\n                      </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VmTeacherDashboard> Html { get; private set; }
    }
}
#pragma warning restore 1591
