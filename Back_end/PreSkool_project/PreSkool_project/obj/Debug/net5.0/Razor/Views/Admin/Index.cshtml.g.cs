#pragma checksum "C:\Users\HP\Desktop\Final_Project\Back_end\PreSkool_project\PreSkool_project\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c95205c42fcad41a9a425748987aa44f43ed05a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c95205c42fcad41a9a425748987aa44f43ed05a", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3afe996cee6003cd3de766477fa7edb07bf1de9", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VmAdmin>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "student", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "teacher", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\HP\Desktop\Final_Project\Back_end\PreSkool_project\PreSkool_project\Views\Admin\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<main>\r\n        <div class=\"container-fluid\">\r\n            <div class=\"row\">\r\n                <div class=\"col-12 page_title\">\r\n                    <div>\r\n                        <h2>Welcome ");
#nullable restore
#line 12 "C:\Users\HP\Desktop\Final_Project\Back_end\PreSkool_project\PreSkool_project\Views\Admin\Index.cshtml"
                               Write(Model.CustomUsers.Name);

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
                    <div class=""breadcrumb bg_one"">
                        <div class=""bd-icon"">
                            <i class=""fas fa-user-graduate""></i>
                        </div>
                        <div class=""bd-body"">
                            <h3>");
#nullable restore
#line 25 "C:\Users\HP\Desktop\Final_Project\Back_end\PreSkool_project\PreSkool_project\Views\Admin\Index.cshtml"
                           Write(Model.Students.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                            <h6>Students</h6>
                        </div>
                    </div>
                </div>
                <div class=""col-xl-3 col-sm-6 col-12"">
                    <div class=""breadcrumb bg_tow"">
                        <div class=""bd-icon"">
                            <i class=""fas fa-chalkboard-teacher""></i>
                        </div>
                        <div class=""bd-body"">
                            <h3>");
#nullable restore
#line 36 "C:\Users\HP\Desktop\Final_Project\Back_end\PreSkool_project\PreSkool_project\Views\Admin\Index.cshtml"
                           Write(Model.Teachers.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                            <h6>Teachers</h6>
                        </div>
                    </div>
                </div>
                <div class=""col-xl-3 col-sm-6 col-12"">
                    <div class=""breadcrumb bg_three"">
                        <div class=""bd-icon"">
                            <i class=""fas fa-building""></i>
                        </div>
                        <div class=""bd-body"">
                            <h3>");
#nullable restore
#line 47 "C:\Users\HP\Desktop\Final_Project\Back_end\PreSkool_project\PreSkool_project\Views\Admin\Index.cshtml"
                           Write(Model.Departments.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                            <h6>Department</h6>
                        </div>
                    </div>
                </div>
                <div class=""col-xl-3 col-sm-6 col-12"">
                    <div class=""breadcrumb bg_four"">
                        <div class=""bd-icon"">
                            <i class=""fas fa-file-invoice-dollar""></i>
                        </div>
                        <div class=""bd-body"">

");
#nullable restore
#line 59 "C:\Users\HP\Desktop\Final_Project\Back_end\PreSkool_project\PreSkool_project\Views\Admin\Index.cshtml"
                          
                            decimal annuals = 0;
                            decimal salaries = 0;
                            decimal expeses = 0;
                            decimal revenue = 0;
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 66 "C:\Users\HP\Desktop\Final_Project\Back_end\PreSkool_project\PreSkool_project\Views\Admin\Index.cshtml"
                         foreach (var item in Model.Annuals)
                        {
                            decimal fees= Convert.ToDecimal(@item.Fees);

                            annuals = annuals + fees;
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 73 "C:\Users\HP\Desktop\Final_Project\Back_end\PreSkool_project\PreSkool_project\Views\Admin\Index.cshtml"
                         foreach (var item in Model.Salaries)
                        {
                            decimal amount= Convert.ToDecimal(@item.Amount);

                            salaries = salaries + amount;
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 80 "C:\Users\HP\Desktop\Final_Project\Back_end\PreSkool_project\PreSkool_project\Views\Admin\Index.cshtml"
                         foreach (var item in Model.Expenses)
                        {
                            decimal amount= Convert.ToDecimal(@item.Amount);

                            expeses = expeses + amount;
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 87 "C:\Users\HP\Desktop\Final_Project\Back_end\PreSkool_project\PreSkool_project\Views\Admin\Index.cshtml"
                          
                            revenue = annuals - (expeses + salaries);
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <h3>");
#nullable restore
#line 91 "C:\Users\HP\Desktop\Final_Project\Back_end\PreSkool_project\PreSkool_project\Views\Admin\Index.cshtml"
                       Write(revenue);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" $</h3>
                        <h6>Revenue</h6>
                        </div>
                    </div>
                </div>
            </div>

            <div class=""row my-4"">
                <div class=""col-12"">
                    <div class=""row"">
                <div class=""col-12"">
                    <div class=""card_body"">
                        <div id=""table"">
                            <div class=""row"">
                                <div class=""col-12"">
                                     <span class=""showList"">Student List</span>
                                </div>
                            </div>

                            <div class=""row"">
                                <div class=""col-12"">
                                    <table class=""table"" id=""StudentTable"">
                                        <thead>
                                            <tr>
                                                <th scope=""col"">#</th>
                    ");
            WriteLiteral(@"                            <th scope=""col"">Full Name</th>
                                                <th scope=""col"">Class</th>
                                                <th scope=""col"">DOB</th>
                                                <th scope=""col"">Mobil Number</th>
                                                <th scope=""col"">Joining Date</th>
                                                <th scope=""col"">Address</th>
                                            </tr>
                                        </thead>
                                        <tbody>
");
#nullable restore
#line 125 "C:\Users\HP\Desktop\Final_Project\Back_end\PreSkool_project\PreSkool_project\Views\Admin\Index.cshtml"
                                          
                                            int s = 0;
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 128 "C:\Users\HP\Desktop\Final_Project\Back_end\PreSkool_project\PreSkool_project\Views\Admin\Index.cshtml"
                                         foreach (var item in Model.Students)
                                        {
                                            s++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\r\n                                                <th scope=\"row\">");
#nullable restore
#line 132 "C:\Users\HP\Desktop\Final_Project\Back_end\PreSkool_project\PreSkool_project\Views\Admin\Index.cshtml"
                                                           Write(s);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9c95205c42fcad41a9a425748987aa44f43ed05a13877", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5579, "~/Uploads/", 5579, 10, true);
#nullable restore
#line 133 "C:\Users\HP\Desktop\Final_Project\Back_end\PreSkool_project\PreSkool_project\Views\Admin\Index.cshtml"
AddHtmlAttributeValue("", 5589, item.StudentImage, 5589, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c95205c42fcad41a9a425748987aa44f43ed05a15470", async() => {
                WriteLiteral(" ");
#nullable restore
#line 133 "C:\Users\HP\Desktop\Final_Project\Back_end\PreSkool_project\PreSkool_project\Views\Admin\Index.cshtml"
                                                                                                                                                                         Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 133 "C:\Users\HP\Desktop\Final_Project\Back_end\PreSkool_project\PreSkool_project\Views\Admin\Index.cshtml"
                                                                                                                                                                                    Write(item.Surname);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 133 "C:\Users\HP\Desktop\Final_Project\Back_end\PreSkool_project\PreSkool_project\Views\Admin\Index.cshtml"
                                                                                                                                                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 134 "C:\Users\HP\Desktop\Final_Project\Back_end\PreSkool_project\PreSkool_project\Views\Admin\Index.cshtml"
                                               Write(item.Class.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 135 "C:\Users\HP\Desktop\Final_Project\Back_end\PreSkool_project\PreSkool_project\Views\Admin\Index.cshtml"
                                               Write(item.Section.Department.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 136 "C:\Users\HP\Desktop\Final_Project\Back_end\PreSkool_project\PreSkool_project\Views\Admin\Index.cshtml"
                                               Write(item.MobilNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 137 "C:\Users\HP\Desktop\Final_Project\Back_end\PreSkool_project\PreSkool_project\Views\Admin\Index.cshtml"
                                               Write(item.JoiningDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 138 "C:\Users\HP\Desktop\Final_Project\Back_end\PreSkool_project\PreSkool_project\Views\Admin\Index.cshtml"
                                               Write(item.PresentAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            </tr>\r\n");
#nullable restore
#line 140 "C:\Users\HP\Desktop\Final_Project\Back_end\PreSkool_project\PreSkool_project\Views\Admin\Index.cshtml"
                                           }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
                </div>

                <div class=""col-12 my-4"">
                    <div class=""row"">
                <div class=""col-12"">
                    <div class=""card_body"">
                        <div id=""table"">
                            <div class=""row"">
                                <div class=""col-12"">
                                    <span class=""showList"">Teacher List</span>
                                </div>
                            </div>

                            <div class=""row"">
                                <div class=""col-12"">
                                    <table class=""table"" id=""TeachersTable"">
                                        <thead>
                            ");
            WriteLiteral(@"                <tr>
                                                <th scope=""col"">#</th>
                                                <th scope=""col"">Full Name</th>
                                                <th scope=""col"">Subject</th>
                                                <th scope=""col"">Mobil Number</th>
                                                <th scope=""col"">Joining Date</th>
                                                <th scope=""col"">Address</th>
                                            </tr>
                                        </thead>
                                        <tbody>
");
#nullable restore
#line 176 "C:\Users\HP\Desktop\Final_Project\Back_end\PreSkool_project\PreSkool_project\Views\Admin\Index.cshtml"
                                          
                                            int t = 0;
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 179 "C:\Users\HP\Desktop\Final_Project\Back_end\PreSkool_project\PreSkool_project\Views\Admin\Index.cshtml"
                                         foreach (var item in Model.Teachers)
                                        {
                                            t++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\r\n                                                <th scope=\"row\">");
#nullable restore
#line 183 "C:\Users\HP\Desktop\Final_Project\Back_end\PreSkool_project\PreSkool_project\Views\Admin\Index.cshtml"
                                                           Write(t);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9c95205c42fcad41a9a425748987aa44f43ed05a23767", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 8410, "~/Uploads/", 8410, 10, true);
#nullable restore
#line 184 "C:\Users\HP\Desktop\Final_Project\Back_end\PreSkool_project\PreSkool_project\Views\Admin\Index.cshtml"
AddHtmlAttributeValue("", 8420, item.TeacherImage, 8420, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c95205c42fcad41a9a425748987aa44f43ed05a25360", async() => {
                WriteLiteral(" ");
#nullable restore
#line 184 "C:\Users\HP\Desktop\Final_Project\Back_end\PreSkool_project\PreSkool_project\Views\Admin\Index.cshtml"
                                                                                                                                                                         Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 184 "C:\Users\HP\Desktop\Final_Project\Back_end\PreSkool_project\PreSkool_project\Views\Admin\Index.cshtml"
                                                                                                                                                                                    Write(item.Surname);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 184 "C:\Users\HP\Desktop\Final_Project\Back_end\PreSkool_project\PreSkool_project\Views\Admin\Index.cshtml"
                                                                                                                                                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 185 "C:\Users\HP\Desktop\Final_Project\Back_end\PreSkool_project\PreSkool_project\Views\Admin\Index.cshtml"
                                               Write(item.Subject.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 186 "C:\Users\HP\Desktop\Final_Project\Back_end\PreSkool_project\PreSkool_project\Views\Admin\Index.cshtml"
                                               Write(item.MobilNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 187 "C:\Users\HP\Desktop\Final_Project\Back_end\PreSkool_project\PreSkool_project\Views\Admin\Index.cshtml"
                                               Write(item.JoiningDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 188 "C:\Users\HP\Desktop\Final_Project\Back_end\PreSkool_project\PreSkool_project\Views\Admin\Index.cshtml"
                                               Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            </tr>\r\n");
#nullable restore
#line 190 "C:\Users\HP\Desktop\Final_Project\Back_end\PreSkool_project\PreSkool_project\Views\Admin\Index.cshtml"
                                           }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
                </div>
            </div>

        </div>
    </main>



    
    <script src=""https://code.jquery.com/jquery-3.6.0.min.js""
        integrity=""sha256-/xUj+3OJU5yExlq6GSYGSHk7tPXikynS7ogEvDej/m4="" crossorigin=""anonymous""></script>
    <script src=""https://cdn.datatables.net/1.11.5/js/jquery.dataTables.min.js""></script>

    <script>
        $(document).ready(function () {
            $('#StudentTable').DataTable({
                ""pagingType"": ""full_numbers""
            });
            $('#TeachersTable').DataTable({
                ""pagingType"": ""full_numbers""
            });
        });
    </script>
    
    <style>

        .dataTables_length {
            display: inline-block;
            m");
            WriteLiteral(@"argin-bottom: 30px;
            font-family: 'Poppins', sans-serif;
            font-weight: 500;
        }

        .dataTables_filter {
            float: right;
            font-family: 'Poppins', sans-serif;
            font-weight: 500;
        }

        .dataTables_filter label input {
            margin-left: 5px;
            border: 1px solid rgba(0, 0, 0, 0.1);
            border-radius: 50px;
            padding: 5px 10px;
            outline-offset: unset;
        }

        .dataTables_filter label input:focus-visible {
            outline: none;
        }

        .dataTables_paginate {
            float: right;
        }

        .dataTables_paginate a {
            display: inline-block;
            text-decoration: none;
            padding: 8px;
            border: 1px solid rgba(0, 0, 0, 0.3);
            color: #ffbc53;
            margin: 3px;
            border-radius: 4px;
            cursor: pointer;
            transition: all .4s ease-in-out;
    ");
            WriteLiteral(@"    }

        .dataTables_paginate a:hover {
            background-color: #ffbc53;
            color: white;
            border-color: #ffbc53;
        }

        .dataTables_info {
            display: inline-block;
            margin: 15px 0px;
            font-family: 'Poppins', sans-serif;
            font-weight: 500;
        }

        .sorting{
            position: relative;
        }

        .sorting::before {
            right: 1em;
            content: ""\2191"";
            position: absolute;
            left: -7px;
            opacity: 0.4;
        }
        .sorting::after{
            right: 0.5em;
            content: ""\2193"";
            position: absolute;
            left: 0px;
            opacity: 0.4;
        }
        .sorting_desc::after {
            opacity: 1;
         }

         .sorting_desc::before {
            opacity: 1;
         }
    </style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VmAdmin> Html { get; private set; }
    }
}
#pragma warning restore 1591
