#pragma checksum "C:\Users\hiroyay\source\repos\hiroyay-ms\Azure-App-Service-Workshop\ASPNET_SAMPLE\Views\HelloWorld\Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b60bc4c76d1383e26b703d0f65ed0c6e86feca8f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HelloWorld_Result), @"mvc.1.0.view", @"/Views/HelloWorld/Result.cshtml")]
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
#line 1 "C:\Users\hiroyay\source\repos\hiroyay-ms\Azure-App-Service-Workshop\ASPNET_SAMPLE\Views\_ViewImports.cshtml"
using ASPNET_SAMPLE;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hiroyay\source\repos\hiroyay-ms\Azure-App-Service-Workshop\ASPNET_SAMPLE\Views\_ViewImports.cshtml"
using ASPNET_SAMPLE.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b60bc4c76d1383e26b703d0f65ed0c6e86feca8f", @"/Views/HelloWorld/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e082a17d735c27acef92e64ed6ab10c26c8433bc", @"/Views/_ViewImports.cshtml")]
    public class Views_HelloWorld_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ASPNET_SAMPLE.Models.Student>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\hiroyay\source\repos\hiroyay-ms\Azure-App-Service-Workshop\ASPNET_SAMPLE\Views\HelloWorld\Result.cshtml"
  
    ViewData["Title"] = "Result";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"display-4\">Result</h1>\r\n\r\n<p>Hello ");
#nullable restore
#line 9 "C:\Users\hiroyay\source\repos\hiroyay-ms\Azure-App-Service-Workshop\ASPNET_SAMPLE\Views\HelloWorld\Result.cshtml"
    Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ID is: ");
#nullable restore
#line 9 "C:\Users\hiroyay\source\repos\hiroyay-ms\Azure-App-Service-Workshop\ASPNET_SAMPLE\Views\HelloWorld\Result.cshtml"
                        Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ASPNET_SAMPLE.Models.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591