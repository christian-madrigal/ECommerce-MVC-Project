#pragma checksum "D:\MSSA Training\ECommerce MVC Project\Views\Product\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f04e950b920ae18da57c8edf51d4817102d007bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Details), @"mvc.1.0.view", @"/Views/Product/Details.cshtml")]
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
#line 1 "D:\MSSA Training\ECommerce MVC Project\Views\_ViewImports.cshtml"
using ECommerce_MVC_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MSSA Training\ECommerce MVC Project\Views\_ViewImports.cshtml"
using ECommerce_MVC_Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f04e950b920ae18da57c8edf51d4817102d007bf", @"/Views/Product/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"babfe27b062b24a4a36571312ec432c312d9ce5b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ECommerce_MVC_Project.Models.Product>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\MSSA Training\ECommerce MVC Project\Views\Product\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n<div class=\"text-center\">\r\n    <dl class=\"align-middle\">\r\n        <dt>\r\n            ");
#nullable restore
#line 11 "D:\MSSA Training\ECommerce MVC Project\Views\Product\Details.cshtml"
       Write(Html.DisplayNameFor(model=>model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 14 "D:\MSSA Training\ECommerce MVC Project\Views\Product\Details.cshtml"
       Write(Html.DisplayFor(model=>model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 18 "D:\MSSA Training\ECommerce MVC Project\Views\Product\Details.cshtml"
       Write(Html.DisplayNameFor(model=>model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 21 "D:\MSSA Training\ECommerce MVC Project\Views\Product\Details.cshtml"
       Write(Html.DisplayFor(model=>model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 25 "D:\MSSA Training\ECommerce MVC Project\Views\Product\Details.cshtml"
       Write(Html.DisplayNameFor(model=>model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 28 "D:\MSSA Training\ECommerce MVC Project\Views\Product\Details.cshtml"
       Write(Html.DisplayFor(model=>model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 32 "D:\MSSA Training\ECommerce MVC Project\Views\Product\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsAvailable));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 35 "D:\MSSA Training\ECommerce MVC Project\Views\Product\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsAvailable));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 38 "D:\MSSA Training\ECommerce MVC Project\Views\Product\Details.cshtml"
       Write(Html.DisplayNameFor(model=>model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 41 "D:\MSSA Training\ECommerce MVC Project\Views\Product\Details.cshtml"
       Write(Html.DisplayFor(model=>model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </dd>\r\n        \r\n    </dl>\r\n    <div style=\"padding:10px;\">\r\n");
#nullable restore
#line 47 "D:\MSSA Training\ECommerce MVC Project\Views\Product\Details.cshtml"
         if(Model.ImageName!=" ")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f04e950b920ae18da57c8edf51d4817102d007bf6995", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1173, "~/images/", 1173, 9, true);
#nullable restore
#line 49 "D:\MSSA Training\ECommerce MVC Project\Views\Product\Details.cshtml"
AddHtmlAttributeValue("", 1182, Model.ImageName, 1182, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 49 "D:\MSSA Training\ECommerce MVC Project\Views\Product\Details.cshtml"
AddHtmlAttributeValue("", 1205, Model.ImageName, 1205, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 50 "D:\MSSA Training\ECommerce MVC Project\Views\Product\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n");
#nullable restore
#line 57 "D:\MSSA Training\ECommerce MVC Project\Views\Product\Details.cshtml"
Write(Html.ActionLink("Back to Product", "Index", "Product" ));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br/>\r\n");
#nullable restore
#line 59 "D:\MSSA Training\ECommerce MVC Project\Views\Product\Details.cshtml"
Write(Html.ActionLink("Back to Home", "Index", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ECommerce_MVC_Project.Models.Product> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
