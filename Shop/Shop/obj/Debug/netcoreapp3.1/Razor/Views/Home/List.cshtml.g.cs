#pragma checksum "C:\Users\Юрий\Desktop\AlexShop\AlexandersShop\Shop\Shop\Views\Home\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7cb595000864721c43987cc34e3b8da07d1423a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_List), @"mvc.1.0.view", @"/Views/Home/List.cshtml")]
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
#nullable restore
#line 2 "C:\Users\Юрий\Desktop\AlexShop\AlexandersShop\Shop\Shop\Views\_ViewImports.cshtml"
using Shop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cb595000864721c43987cc34e3b8da07d1423a3", @"/Views/Home/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"456e1b25da505bb8b19af1a050b535d007413a5b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n\r\n<div>\r\n");
#nullable restore
#line 8 "C:\Users\Юрий\Desktop\AlexShop\AlexandersShop\Shop\Shop\Views\Home\List.cshtml"
      
        foreach (var category in Model.AllCategories)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"category-item\"");
            BeginWriteAttribute("onclick", " onclick=\"", 213, "\"", 251, 3);
            WriteAttributeValue("", 223, "onClickHandler(", 223, 15, true);
#nullable restore
#line 11 "C:\Users\Юрий\Desktop\AlexShop\AlexandersShop\Shop\Shop\Views\Home\List.cshtml"
WriteAttributeValue("", 238, category.Id, 238, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 250, ")", 250, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <h3>");
#nullable restore
#line 12 "C:\Users\Юрий\Desktop\AlexShop\AlexandersShop\Shop\Shop\Views\Home\List.cshtml"
               Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 13 "C:\Users\Юрий\Desktop\AlexShop\AlexandersShop\Shop\Shop\Views\Home\List.cshtml"
                 if (User.Identity.IsAuthenticated)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7cb595000864721c43987cc34e3b8da07d1423a35831", async() => {
                WriteLiteral("\r\n                        <input type=\"text\" name=\"id\" placeholder=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 529, "\"", 549, 1);
#nullable restore
#line 16 "C:\Users\Юрий\Desktop\AlexShop\AlexandersShop\Shop\Shop\Views\Home\List.cshtml"
WriteAttributeValue("", 537, category.Id, 537, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden />\r\n                        <input type=\"submit\" value=\"Удалить\" />\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 19 "C:\Users\Юрий\Desktop\AlexShop\AlexandersShop\Shop\Shop\Views\Home\List.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"category-product-list\"");
            BeginWriteAttribute("id", " id=\"", 741, "\"", 781, 2);
            WriteAttributeValue("", 746, "category-products-list-", 746, 23, true);
#nullable restore
#line 21 "C:\Users\Юрий\Desktop\AlexShop\AlexandersShop\Shop\Shop\Views\Home\List.cshtml"
WriteAttributeValue("", 769, category.Id, 769, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"display:none\">\r\n");
#nullable restore
#line 22 "C:\Users\Юрий\Desktop\AlexShop\AlexandersShop\Shop\Shop\Views\Home\List.cshtml"
                 foreach (var product in Model.AllProducts)
                {
                    if (product.Category == category)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"row product-item\">\r\n                        <div class=\"product-item-name\">\r\n                            <h4>");
#nullable restore
#line 28 "C:\Users\Юрий\Desktop\AlexShop\AlexandersShop\Shop\Shop\Views\Home\List.cshtml"
                           Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n");
#nullable restore
#line 29 "C:\Users\Юрий\Desktop\AlexShop\AlexandersShop\Shop\Shop\Views\Home\List.cshtml"
                             if (User.Identity.IsAuthenticated)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7cb595000864721c43987cc34e3b8da07d1423a310031", async() => {
                WriteLiteral("\r\n                                    <input type=\"text\" name=\"id\" placeholder=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 1405, "\"", 1424, 1);
#nullable restore
#line 32 "C:\Users\Юрий\Desktop\AlexShop\AlexandersShop\Shop\Shop\Views\Home\List.cshtml"
WriteAttributeValue("", 1413, product.Id, 1413, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden />\r\n                                    <input type=\"submit\" value=\"Удалить\" />\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 35 "C:\Users\Юрий\Desktop\AlexShop\AlexandersShop\Shop\Shop\Views\Home\List.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                        <div class=\"product-item-description\">\r\n                            <h4>");
#nullable restore
#line 38 "C:\Users\Юрий\Desktop\AlexShop\AlexandersShop\Shop\Shop\Views\Home\List.cshtml"
                           Write(product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        </div>                        \r\n                        <div class=\"product-item-image\">\r\n                            <img class=\"img-thumbnail\"");
            BeginWriteAttribute("src", " src=\"", 1909, "\"", 1933, 1);
#nullable restore
#line 41 "C:\Users\Юрий\Desktop\AlexShop\AlexandersShop\Shop\Shop\Views\Home\List.cshtml"
WriteAttributeValue("", 1915, product.ImagePath, 1915, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1934, "\"", 1953, 1);
#nullable restore
#line 41 "C:\Users\Юрий\Desktop\AlexShop\AlexandersShop\Shop\Shop\Views\Home\List.cshtml"
WriteAttributeValue("", 1940, product.Name, 1940, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 44 "C:\Users\Юрий\Desktop\AlexShop\AlexandersShop\Shop\Shop\Views\Home\List.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n");
#nullable restore
#line 47 "C:\Users\Юрий\Desktop\AlexShop\AlexandersShop\Shop\Shop\Views\Home\List.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
