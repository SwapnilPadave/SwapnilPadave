#pragma checksum "C:\Users\Nimap\Desktop\Details\JWTAuthentication\SwapnilPadave\CurdOperation\Views\QRCode\Booking.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60694fe2a3b744108361d13d149ca081e8daa0bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QRCode_Booking), @"mvc.1.0.view", @"/Views/QRCode/Booking.cshtml")]
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
#line 1 "C:\Users\Nimap\Desktop\Details\JWTAuthentication\SwapnilPadave\CurdOperation\Views\_ViewImports.cshtml"
using CurdOperation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nimap\Desktop\Details\JWTAuthentication\SwapnilPadave\CurdOperation\Views\_ViewImports.cshtml"
using CurdOperation.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60694fe2a3b744108361d13d149ca081e8daa0bb", @"/Views/QRCode/Booking.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"135fe0a91e235522011437baaad49a132bbe023c", @"/Views/_ViewImports.cshtml")]
    public class Views_QRCode_Booking : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Nimap\Desktop\Details\JWTAuthentication\SwapnilPadave\CurdOperation\Views\QRCode\Booking.cshtml"
  
    ViewData["Title"] = "Booking";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Booking</h1>\r\n");
#nullable restore
#line 8 "C:\Users\Nimap\Desktop\Details\JWTAuthentication\SwapnilPadave\CurdOperation\Views\QRCode\Booking.cshtml"
 if (ViewBag.QRCodeImage != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-info\">Your Booking Is Successfull..</div>\r\n");
            WriteLiteral("    <img");
            BeginWriteAttribute("src", " src=\"", 285, "\"", 311, 1);
#nullable restore
#line 12 "C:\Users\Nimap\Desktop\Details\JWTAuthentication\SwapnilPadave\CurdOperation\Views\QRCode\Booking.cshtml"
WriteAttributeValue("", 291, ViewBag.QRCodeImage, 291, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Booking QR Code\" style=\"height:200px; width:200px\" />\r\n");
#nullable restore
#line 13 "C:\Users\Nimap\Desktop\Details\JWTAuthentication\SwapnilPadave\CurdOperation\Views\QRCode\Booking.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\">Sorry, Something Went Wrong While Processing Your Request...</div>\r\n");
#nullable restore
#line 17 "C:\Users\Nimap\Desktop\Details\JWTAuthentication\SwapnilPadave\CurdOperation\Views\QRCode\Booking.cshtml"
}

#line default
#line hidden
#nullable disable
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
