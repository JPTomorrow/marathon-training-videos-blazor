#pragma checksum "C:\Users\Jmorrow\Desktop\code\work-code\blazor\MarathonTutorialWebsite\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "731939b7769a80dc9378a00666c43d391a4c5d93"
// <auto-generated/>
#pragma warning disable 1591
namespace MarathonTutorialWebsite.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Jmorrow\Desktop\code\work-code\blazor\MarathonTutorialWebsite\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jmorrow\Desktop\code\work-code\blazor\MarathonTutorialWebsite\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Jmorrow\Desktop\code\work-code\blazor\MarathonTutorialWebsite\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Jmorrow\Desktop\code\work-code\blazor\MarathonTutorialWebsite\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Jmorrow\Desktop\code\work-code\blazor\MarathonTutorialWebsite\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Jmorrow\Desktop\code\work-code\blazor\MarathonTutorialWebsite\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Jmorrow\Desktop\code\work-code\blazor\MarathonTutorialWebsite\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Jmorrow\Desktop\code\work-code\blazor\MarathonTutorialWebsite\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Jmorrow\Desktop\code\work-code\blazor\MarathonTutorialWebsite\_Imports.razor"
using MarathonTutorialWebsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Jmorrow\Desktop\code\work-code\blazor\MarathonTutorialWebsite\_Imports.razor"
using MarathonTutorialWebsite.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Jmorrow\Desktop\code\work-code\blazor\MarathonTutorialWebsite\_Imports.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Jmorrow\Desktop\code\work-code\blazor\MarathonTutorialWebsite\_Imports.razor"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style b-x4x6nkc4tw>\r\n    .nav-links a {\r\n        color: orangered;\r\n    }\r\n\r\n    .nav-links a:hover {\r\n        color: maroon;\r\n        text-decoration: none;\r\n    }\r\n</style>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "page");
            __builder.AddAttribute(3, "b-x4x6nkc4tw");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "main");
            __builder.AddAttribute(6, "b-x4x6nkc4tw");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "top-row px-4");
            __builder.AddAttribute(9, "b-x4x6nkc4tw");
            __builder.AddMarkupContent(10, "<img src=\"/assets/logo.png\" alt=\"logo\" class=\"logo\" b-x4x6nkc4tw>\r\n            ");
            __builder.OpenElement(11, "ul");
            __builder.AddAttribute(12, "class", "nav-links");
            __builder.AddAttribute(13, "b-x4x6nkc4tw");
            __builder.OpenElement(14, "li");
            __builder.AddAttribute(15, "b-x4x6nkc4tw");
            __builder.OpenElement(16, "a");
            __builder.AddAttribute(17, "href", "https://docs.microsoft.com/aspnet/");
            __builder.AddAttribute(18, "target", "_blank");
            __builder.AddAttribute(19, "b-x4x6nkc4tw");
            __builder.AddContent(20, 
#nullable restore
#line 20 "C:\Users\Jmorrow\Desktop\code\work-code\blazor\MarathonTutorialWebsite\Shared\MainLayout.razor"
                                                                                  localizer["Training Videos"]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "li");
            __builder.AddAttribute(23, "b-x4x6nkc4tw");
            __builder.OpenElement(24, "a");
            __builder.AddAttribute(25, "href", "https://docs.microsoft.com/aspnet/");
            __builder.AddAttribute(26, "target", "_blank");
            __builder.AddAttribute(27, "b-x4x6nkc4tw");
            __builder.AddContent(28, 
#nullable restore
#line 21 "C:\Users\Jmorrow\Desktop\code\work-code\blazor\MarathonTutorialWebsite\Shared\MainLayout.razor"
                                                                                  localizer["About"]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.OpenComponent<MarathonTutorialWebsite.Shared.ChooseLanguage>(30);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n\r\n        ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "container-type-one");
            __builder.AddAttribute(34, "b-x4x6nkc4tw");
            __builder.AddContent(35, 
#nullable restore
#line 27 "C:\Users\Jmorrow\Desktop\code\work-code\blazor\MarathonTutorialWebsite\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStringLocalizer<App> localizer { get; set; }
    }
}
#pragma warning restore 1591
