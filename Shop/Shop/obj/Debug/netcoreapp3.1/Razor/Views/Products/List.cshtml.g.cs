#pragma checksum "C:\Users\Юрий\Desktop\AlexShop\AlexandersShop\Shop\Shop\Views\Products\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20250ccd01293e2f1030278142a3c87cbae2892f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_List), @"mvc.1.0.view", @"/Views/Products/List.cshtml")]
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
#line 1 "C:\Users\Юрий\Desktop\AlexShop\AlexandersShop\Shop\Shop\Views\_ViewImports.cshtml"
using Shop.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20250ccd01293e2f1030278142a3c87cbae2892f", @"/Views/Products/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8698b1ec29562463bc33480ac52eac0346944c13", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row mt-5 mb-2\">\r\n");
#nullable restore
#line 3 "C:\Users\Юрий\Desktop\AlexShop\AlexandersShop\Shop\Shop\Views\Products\List.cshtml"
      
        foreach (var product in Model.AllProducts)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-lg-4\">\r\n                <img class=\"img-thumbnail\"");
            BeginWriteAttribute("src", " src=\"", 180, "\"", 204, 1);
#nullable restore
#line 7 "C:\Users\Юрий\Desktop\AlexShop\AlexandersShop\Shop\Shop\Views\Products\List.cshtml"
WriteAttributeValue("", 186, product.ImagePath, 186, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 205, "\"", 224, 1);
#nullable restore
#line 7 "C:\Users\Юрий\Desktop\AlexShop\AlexandersShop\Shop\Shop\Views\Products\List.cshtml"
WriteAttributeValue("", 211, product.Name, 211, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                <h2>");
#nullable restore
#line 8 "C:\Users\Юрий\Desktop\AlexShop\AlexandersShop\Shop\Shop\Views\Products\List.cshtml"
               Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            </div>\r\n");
#nullable restore
#line 10 "C:\Users\Юрий\Desktop\AlexShop\AlexandersShop\Shop\Shop\Views\Products\List.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
