#pragma checksum "C:\Users\user\Desktop\BackEnd\FirtsTask\WebApplication1\WebApplication1\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7653b0102373b7dfaec181ebe2f3d837053cc9c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\user\Desktop\BackEnd\FirtsTask\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Desktop\BackEnd\FirtsTask\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7653b0102373b7dfaec181ebe2f3d837053cc9c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4dbb86164f0c4e5801c4dfbd771eb2e1647b022e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 5 "C:\Users\user\Desktop\BackEnd\FirtsTask\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
 using (Html.BeginForm("Logout", "Home", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <p>User Info</p>
    <hr />
    <table class=""table"">
        <thead>
            <tr>
                <th scope=""col"">Id</th>
                <th scope=""col"">Name</th>
                <th scope=""col"">Age</th>
                <th scope=""col"">GroupId</th>
                <th scope=""col"">GroupName</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 20 "C:\Users\user\Desktop\BackEnd\FirtsTask\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                 foreach (var item in Model.Students)
                {
                   

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n");
            WriteLiteral("                        <td>");
#nullable restore
#line 25 "C:\Users\user\Desktop\BackEnd\FirtsTask\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                       Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 26 "C:\Users\user\Desktop\BackEnd\FirtsTask\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 27 "C:\Users\user\Desktop\BackEnd\FirtsTask\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                       Write(item.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 28 "C:\Users\user\Desktop\BackEnd\FirtsTask\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                       Write(item.GroupId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 29 "C:\Users\user\Desktop\BackEnd\FirtsTask\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                       Write(Model.Group.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 31 "C:\Users\user\Desktop\BackEnd\FirtsTask\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n    <p>");
#nullable restore
#line 34 "C:\Users\user\Desktop\BackEnd\FirtsTask\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
  Write(ViewBag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>");
#nullable restore
#line 35 "C:\Users\user\Desktop\BackEnd\FirtsTask\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
  Write(ViewData["Name"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>");
#nullable restore
#line 36 "C:\Users\user\Desktop\BackEnd\FirtsTask\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
  Write(TempData["Name"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <a href=\"/home/index2\"> Go to Home 2</a>\r\n    <hr />\r\n    <button type=\"submit\">LogOut</button>\r\n");
#nullable restore
#line 40 "C:\Users\user\Desktop\BackEnd\FirtsTask\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
