#pragma checksum "C:\Diogo\Cursos\ASP.NET\Dominando o ASP.NET MVC Core\MinhaAppMvc\src\DevIo.App\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "911eb40ad348b82ded39208597cdf998853fbd5b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Error.cshtml", typeof(AspNetCore.Views_Shared_Error))]
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
#line 1 "C:\Diogo\Cursos\ASP.NET\Dominando o ASP.NET MVC Core\MinhaAppMvc\src\DevIo.App\Views\_ViewImports.cshtml"
using DevIo.App;

#line default
#line hidden
#line 2 "C:\Diogo\Cursos\ASP.NET\Dominando o ASP.NET MVC Core\MinhaAppMvc\src\DevIo.App\Views\_ViewImports.cshtml"
using DevIo.App.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"911eb40ad348b82ded39208597cdf998853fbd5b", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"170b0acd6164c22347c5ccaaede3e336f4f24b05", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Diogo\Cursos\ASP.NET\Dominando o ASP.NET MVC Core\MinhaAppMvc\src\DevIo.App\Views\Shared\Error.cshtml"
  
    ViewData["Title"] = "Ocorreu um erro";

#line default
#line hidden
            BeginContext(74, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Diogo\Cursos\ASP.NET\Dominando o ASP.NET MVC Core\MinhaAppMvc\src\DevIo.App\Views\Shared\Error.cshtml"
  
    if (Model == null)
    {

#line default
#line hidden
            BeginContext(111, 150, true);
            WriteLiteral("        <div>\r\n            <h2>Ooops! Ocorreu um erro, mas não se preocupe. Nosso time será avisado e iremos corrigir em breve!</h2>\r\n        </div>\r\n");
            EndContext();
#line 12 "C:\Diogo\Cursos\ASP.NET\Dominando o ASP.NET MVC Core\MinhaAppMvc\src\DevIo.App\Views\Shared\Error.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(285, 12, true);
            WriteLiteral("        <h1>");
            EndContext();
            BeginContext(298, 22, false);
#line 15 "C:\Diogo\Cursos\ASP.NET\Dominando o ASP.NET MVC Core\MinhaAppMvc\src\DevIo.App\Views\Shared\Error.cshtml"
       Write(Html.Raw(Model.Titulo));

#line default
#line hidden
            EndContext();
            BeginContext(320, 39, true);
            WriteLiteral("</h1>\r\n        <h2 class=\"text-danger\">");
            EndContext();
            BeginContext(360, 24, false);
#line 16 "C:\Diogo\Cursos\ASP.NET\Dominando o ASP.NET MVC Core\MinhaAppMvc\src\DevIo.App\Views\Shared\Error.cshtml"
                           Write(Html.Raw(Model.Mensagem));

#line default
#line hidden
            EndContext();
            BeginContext(384, 7, true);
            WriteLiteral("</h2>\r\n");
            EndContext();
#line 17 "C:\Diogo\Cursos\ASP.NET\Dominando o ASP.NET MVC Core\MinhaAppMvc\src\DevIo.App\Views\Shared\Error.cshtml"
    }

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
