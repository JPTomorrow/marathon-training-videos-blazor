#pragma checksum "C:\Users\Jmorrow\Desktop\code\work-code\blazor\MarathonTutorialWebsite\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "400e61add093528259be0433f8ca255363f86c01"
// <auto-generated/>
#pragma warning disable 1591
namespace MarathonTutorialWebsite.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MarathonTutorialWebsite.Pages.StandardHeaderOne>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(2, 
#nullable restore
#line 4 "C:\Users\Jmorrow\Desktop\code\work-code\blazor\MarathonTutorialWebsite\Pages\Index.razor"
                    localizer["Training Videos"]

#line default
#line hidden
#nullable disable
                );
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.OpenComponent<MarathonTutorialWebsite.Pages.YoutubeVideoList>(4);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStringLocalizer<App> localizer { get; set; }
    }
}
#pragma warning restore 1591
