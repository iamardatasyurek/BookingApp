#pragma checksum "D:\Codes\BookingApp\TraversalBooking\TraversalBooking\Views\Shared\Components\_Testimonial\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa6e039eedcb0bd32bb69f3cdfb172feaf6ca7c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__Testimonial_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_Testimonial/Default.cshtml")]
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
#line 1 "D:\Codes\BookingApp\TraversalBooking\TraversalBooking\Views\_ViewImports.cshtml"
using TraversalBooking;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Codes\BookingApp\TraversalBooking\TraversalBooking\Views\_ViewImports.cshtml"
using TraversalBooking.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Codes\BookingApp\TraversalBooking\TraversalBooking\Views\Shared\Components\_Testimonial\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa6e039eedcb0bd32bb69f3cdfb172feaf6ca7c2", @"/Views/Shared/Components/_Testimonial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"839ceef4081d85918dcd2725d19476715b30a03e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__Testimonial_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Testimonial>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<section class=""w3l-clients"" id=""clients"">
    <div class=""cusrtomer-layout py-5"">
        <div class=""container py-lg-4 py-md-3 pb-lg-0"">
            <div class=""heading text-center mx-auto"">
                <h6 class=""sub-title text-center"">Here’s what they have to say</h6>
                <h3 class=""hny-title mb-md-5 mb-4"">our clients do the talking</h3>
            </div>
            <div class=""testimonial-width"">
                <div id=""owl-demo1"" class=""owl-two owl-carousel owl-theme"">
");
#nullable restore
#line 13 "D:\Codes\BookingApp\TraversalBooking\TraversalBooking\Views\Shared\Components\_Testimonial\Default.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""item"">
                            <div class=""testimonial-content"">
                                <div class=""testimonial"">
                                    <blockquote>
                                        <span class=""fa fa-quote-left"" aria-hidden=""true""></span>
                                        ");
#nullable restore
#line 20 "D:\Codes\BookingApp\TraversalBooking\TraversalBooking\Views\Shared\Components\_Testimonial\Default.cshtml"
                                   Write(item.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </blockquote>\r\n                                    <div class=\"testi-des\">\r\n                                        <div class=\"test-img\">\r\n                                            <img");
            BeginWriteAttribute("src", " src=\"", 1231, "\"", 1254, 1);
#nullable restore
#line 24 "D:\Codes\BookingApp\TraversalBooking\TraversalBooking\Views\Shared\Components\_Testimonial\Default.cshtml"
WriteAttributeValue("", 1237, item.ClientImage, 1237, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\" alt=\"client-img\">\r\n                                        </div>\r\n                                        <div class=\"peopl align-self\">\r\n                                            <h3>");
#nullable restore
#line 27 "D:\Codes\BookingApp\TraversalBooking\TraversalBooking\Views\Shared\Components\_Testimonial\Default.cshtml"
                                           Write(item.Client);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                                            <p class=""indentity"">Example City</p>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
");
#nullable restore
#line 34 "D:\Codes\BookingApp\TraversalBooking\TraversalBooking\Views\Shared\Components\_Testimonial\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Testimonial>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
