#pragma checksum "C:\Users\Natali\Documents\GitHub\ECommerce-MVC-Project\ECommerce MVC Project\Views\Customer\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bcbe0d6b391f78df12ef9a3b68c31fe02b9686f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Details), @"mvc.1.0.view", @"/Views/Customer/Details.cshtml")]
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
#line 1 "C:\Users\Natali\Documents\GitHub\ECommerce-MVC-Project\ECommerce MVC Project\Views\_ViewImports.cshtml"
using ECommerce_MVC_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Natali\Documents\GitHub\ECommerce-MVC-Project\ECommerce MVC Project\Views\_ViewImports.cshtml"
using ECommerce_MVC_Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bcbe0d6b391f78df12ef9a3b68c31fe02b9686f6", @"/Views/Customer/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"babfe27b062b24a4a36571312ec432c312d9ce5b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Customer_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ECommerce_MVC_Project.Models.Customer>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Natali\Documents\GitHub\ECommerce-MVC-Project\ECommerce MVC Project\Views\Customer\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/SiteManager.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n<div class=\"text-center\">\r\n    <dl class=\"align-middle\">\r\n        <dt>\r\n            ");
#nullable restore
#line 11 "C:\Users\Natali\Documents\GitHub\ECommerce-MVC-Project\ECommerce MVC Project\Views\Customer\Details.cshtml"
       Write(Html.DisplayNameFor(model=>model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 14 "C:\Users\Natali\Documents\GitHub\ECommerce-MVC-Project\ECommerce MVC Project\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model=>model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 18 "C:\Users\Natali\Documents\GitHub\ECommerce-MVC-Project\ECommerce MVC Project\Views\Customer\Details.cshtml"
       Write(Html.DisplayNameFor(model=>model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 21 "C:\Users\Natali\Documents\GitHub\ECommerce-MVC-Project\ECommerce MVC Project\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model=>model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 25 "C:\Users\Natali\Documents\GitHub\ECommerce-MVC-Project\ECommerce MVC Project\Views\Customer\Details.cshtml"
       Write(Html.DisplayNameFor(model=>model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 28 "C:\Users\Natali\Documents\GitHub\ECommerce-MVC-Project\ECommerce MVC Project\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model=>model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 32 "C:\Users\Natali\Documents\GitHub\ECommerce-MVC-Project\ECommerce MVC Project\Views\Customer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 35 "C:\Users\Natali\Documents\GitHub\ECommerce-MVC-Project\ECommerce MVC Project\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 38 "C:\Users\Natali\Documents\GitHub\ECommerce-MVC-Project\ECommerce MVC Project\Views\Customer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 41 "C:\Users\Natali\Documents\GitHub\ECommerce-MVC-Project\ECommerce MVC Project\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n                <dt>\r\n            ");
#nullable restore
#line 44 "C:\Users\Natali\Documents\GitHub\ECommerce-MVC-Project\ECommerce MVC Project\Views\Customer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PasswordHash));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 47 "C:\Users\Natali\Documents\GitHub\ECommerce-MVC-Project\ECommerce MVC Project\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model => model.PasswordHash));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        \r\n    </dl>\r\n\r\n\r\n</div>\r\n\r\n\r\n");
#nullable restore
#line 57 "C:\Users\Natali\Documents\GitHub\ECommerce-MVC-Project\ECommerce MVC Project\Views\Customer\Details.cshtml"
Write(Html.ActionLink("Back to Customer", "Users", "Customer" ));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br/>\r\n");
#nullable restore
#line 59 "C:\Users\Natali\Documents\GitHub\ECommerce-MVC-Project\ECommerce MVC Project\Views\Customer\Details.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ECommerce_MVC_Project.Models.Customer> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
