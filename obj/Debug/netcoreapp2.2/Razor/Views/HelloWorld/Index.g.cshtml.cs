#pragma checksum "d:\VsCode\MvcProject\Views\HelloWorld\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d85d5f31c6914744962f506caef3b538b9a4b452"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HelloWorld_Index), @"mvc.1.0.view", @"/Views/HelloWorld/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/HelloWorld/Index.cshtml", typeof(AspNetCore.Views_HelloWorld_Index))]
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
#line 1 "d:\VsCode\MvcProject\Views\_ViewImports.cshtml"
using MvcProject;

#line default
#line hidden
#line 2 "d:\VsCode\MvcProject\Views\_ViewImports.cshtml"
using MvcProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d85d5f31c6914744962f506caef3b538b9a4b452", @"/Views/HelloWorld/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b195e0951ebb4337c362372a52496a3462d2eef9", @"/Views/_ViewImports.cshtml")]
    public class Views_HelloWorld_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "d:\VsCode\MvcProject\Views\HelloWorld\Index.cshtml"
  
   var d= ViewData["Message"];

#line default
#line hidden
            BeginContext(39, 28, true);
            WriteLiteral("\r\n<div>\r\n    <p>Nbr bebişim ");
            EndContext();
            BeginContext(68, 1, false);
#line 6 "d:\VsCode\MvcProject\Views\HelloWorld\Index.cshtml"
              Write(d);

#line default
#line hidden
            EndContext();
            BeginContext(69, 64, true);
            WriteLiteral("</p>\r\n    <link href=\"css/bacon.css\" rel=\"stylesheet\">\r\n</div>\r\n");
            EndContext();
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
