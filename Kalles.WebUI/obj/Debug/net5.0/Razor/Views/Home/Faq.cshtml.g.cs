#pragma checksum "C:\Users\Hp\Desktop\Kalles\Kalles.WebUI\Views\Home\Faq.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc273cbe9b570909bce383a8cdc45d640ed94974"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Faq), @"mvc.1.0.view", @"/Views/Home/Faq.cshtml")]
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
#line 3 "C:\Users\Hp\Desktop\Kalles\Kalles.WebUI\Views\_ViewImports.cshtml"
using Kalles.Domain.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Hp\Desktop\Kalles\Kalles.WebUI\Views\_ViewImports.cshtml"
using Kalles.Domain.Models.FormModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Hp\Desktop\Kalles\Kalles.WebUI\Views\_ViewImports.cshtml"
using Kalles.Application.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Hp\Desktop\Kalles\Kalles.WebUI\Views\_ViewImports.cshtml"
using Kalles.Application.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc273cbe9b570909bce383a8cdc45d640ed94974", @"/Views/Home/Faq.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09da619775bce39acaf82e14e290047d9a5d42f8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Faq : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Faq>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Hp\Desktop\Kalles\Kalles.WebUI\Views\Home\Faq.cshtml"
  
    ViewData["Title"] = "Faq";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Begin Li\'s Breadcrumb Area -->\r\n<div class=\"breadcrumb-area\">\r\n    <div class=\"container\">\r\n        <div class=\"breadcrumb-content\">\r\n            <ul>\r\n                <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc273cbe9b570909bce383a8cdc45d640ed949744479", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                <li class=""active"">Faq</li>
            </ul>
        </div>
    </div>
</div>
<!-- Li's Breadcrumb Area End Here -->
<!-- Begin Frequently Area -->
<div class=""frequently-area pt-60 pb-50"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""frequently-content"">
                    <div class=""frequently-desc"">
                        <h3>Below are frequently asked questions, you may find the answer for yourself</h3>
                        <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec id erat sagittis, faucibus metus malesuada, eleifend turpis. Mauris semper augue id nisl aliquet, a porta lectus mattis. Nulla at tortor augue. In eget enim diam. Donec gravida tortor sem, ac fermentum nibh rutrum sit amet. Nulla convallis mauris vitae congue consequat. Donec interdum nunc purus, vitae vulputate arcu fringilla quis. Vivamus iaculis euismod dui.</p>
                    </div>
            ");
            WriteLiteral("    </div>\r\n                <!-- Begin Frequently Accordin -->\r\n                <div class=\"frequently-accordion\">\r\n                    <div id=\"accordion\">\r\n");
#nullable restore
#line 33 "C:\Users\Hp\Desktop\Kalles\Kalles.WebUI\Views\Home\Faq.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"card actives\">\r\n                                <div class=\"card-header\" id=\"headingOne\">\r\n                                    <h5 class=\"mb-0\">\r\n                                        <a");
            BeginWriteAttribute("class", " class=\"", 1788, "\"", 1796, 0);
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"collapse\" data-target=\"#collapseOne-");
#nullable restore
#line 38 "C:\Users\Hp\Desktop\Kalles\Kalles.WebUI\Views\Home\Faq.cshtml"
                                                                                                Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" aria-expanded=\"true\" aria-controls=\"collapseOne\">\r\n                                            ");
#nullable restore
#line 39 "C:\Users\Hp\Desktop\Kalles\Kalles.WebUI\Views\Home\Faq.cshtml"
                                       Write(item.Question);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </a>\r\n                                    </h5>\r\n                                </div>\r\n                                <div");
            BeginWriteAttribute("id", " id=\"", 2133, "\"", 2158, 2);
            WriteAttributeValue("", 2138, "collapseOne-", 2138, 12, true);
#nullable restore
#line 43 "C:\Users\Hp\Desktop\Kalles\Kalles.WebUI\Views\Home\Faq.cshtml"
WriteAttributeValue("", 2150, item.Id, 2150, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"collapse\" aria-labelledby=\"headingOne\" data-parent=\"#accordion\">\r\n                                    <div class=\"card-body\">\r\n                                        ");
#nullable restore
#line 45 "C:\Users\Hp\Desktop\Kalles\Kalles.WebUI\Views\Home\Faq.cshtml"
                                   Write(Html.Raw(item.Answer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 49 "C:\Users\Hp\Desktop\Kalles\Kalles.WebUI\Views\Home\Faq.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n                <!--Frequently Accordin End Here -->\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!--Frequently Area End Here -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Faq>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
