#pragma checksum "C:\Users\user\Desktop\BackEnd\FirtsTask\WebApplication1\WebApplication1\Views\Login\login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e30fad463944769a24dcd7ac8512c6f80ac60f4c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_login), @"mvc.1.0.view", @"/Views/Login/login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e30fad463944769a24dcd7ac8512c6f80ac60f4c", @"/Views/Login/login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4dbb86164f0c4e5801c4dfbd771eb2e1647b022e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Login_login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<section id=""login "">
    <div class=""container d-flex justify-content-center mt-4"">
        <div class=""main row col-lg-10 d-flex justify-content-between"">
            <div class=""main_login col-lg-5"">
                <div>
                    <p class=""fs-1"">Login to <span class=""fw-bold"">Account</span></p>
                    <p style=""color: grey;"">Lorem ipsum dolor sit amet consectetur adipisicing elit.</p>
                </div>
                <form action=""/Login/Login"" method=""post"" id=""form"" class=""login col-lg-12 "">
                    <div class=""mb-3"">
                        <label for=""exampleInputEmail1"" class=""form-label"">Email address</label>
                        <input type=""email"" class=""form-control"" id=""exampleInputEmail1"" aria-describedby=""emailHelp"">
                        <div style=""height: 30px; display: none;""> <span class=""span_style"">Bos Qoyma</span></div>
                        <div id=""emailHelp"" class=""form-text"">We'll never share your email with anyone els");
            WriteLiteral(@"e.</div>
                    </div>
                    <div class=""mb-3"">
                        <label for=""myInput"" class=""form-label"">Password</label>
                        <input type=""password"" class=""form-control"" id=""myInput"">
                        <input class=""checkbox"" type=""checkbox"" onclick=""myFunction()""> Show Password
                    </div>
                    <div class=""mb-3 form-check d-flex justify-content-between"">
                        <div>
                            <input type=""checkbox"" class=""checkbox form-check-input"" id=""exampleCheck1"">
                            <label class=""form-check-label"" for=""exampleCheck1"">Remember me</label>
                        </div>
                        <a style=""color: grey;""");
            BeginWriteAttribute("href", " href=\"", 1813, "\"", 1820, 0);
            EndWriteAttribute();
            WriteLiteral(@">Forget Password</a>
                    </div>
                    <button id=""btn"" class=""btn btn-warning col-lg-12"">Login</button>

                </form>
            </div>
            <div class=""image login col-lg-5"">
            </div>
        </div>
    </div>
</section>");
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
