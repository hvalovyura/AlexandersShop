#pragma checksum "C:\Users\Юрий\OneDrive\Desktop\AlexShop\AlexandersShop\Shop\Shop\Views\Home\ProductPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72d48a68651a1d02ab9c5beb5c6e92bc1f96a0ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ProductPage), @"mvc.1.0.view", @"/Views/Home/ProductPage.cshtml")]
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
#line 1 "C:\Users\Юрий\OneDrive\Desktop\AlexShop\AlexandersShop\Shop\Shop\Views\_ViewImports.cshtml"
using Shop.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Юрий\OneDrive\Desktop\AlexShop\AlexandersShop\Shop\Shop\Views\_ViewImports.cshtml"
using Shop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72d48a68651a1d02ab9c5beb5c6e92bc1f96a0ce", @"/Views/Home/ProductPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"456e1b25da505bb8b19af1a050b535d007413a5b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ProductPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 3 "C:\Users\Юрий\OneDrive\Desktop\AlexShop\AlexandersShop\Shop\Shop\Views\Home\ProductPage.cshtml"
 foreach (var el in Model.AllProducts)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <h2>");
#nullable restore
#line 6 "C:\Users\Юрий\OneDrive\Desktop\AlexShop\AlexandersShop\Shop\Shop\Views\Home\ProductPage.cshtml"
       Write(el.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <img class=\"img-thumbnail\"");
            BeginWriteAttribute("src", " src=\"", 119, "\"", 138, 1);
#nullable restore
#line 7 "C:\Users\Юрий\OneDrive\Desktop\AlexShop\AlexandersShop\Shop\Shop\Views\Home\ProductPage.cshtml"
WriteAttributeValue("", 125, el.ImagePath, 125, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <h1>");
#nullable restore
#line 8 "C:\Users\Юрий\OneDrive\Desktop\AlexShop\AlexandersShop\Shop\Shop\Views\Home\ProductPage.cshtml"
       Write(el.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    </div>\r\n");
#nullable restore
#line 10 "C:\Users\Юрий\OneDrive\Desktop\AlexShop\AlexandersShop\Shop\Shop\Views\Home\ProductPage.cshtml"
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
