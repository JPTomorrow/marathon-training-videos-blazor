#pragma checksum "C:\Users\Jmorrow\Desktop\code\work-code\blazor\MarathonTutorialWebsite\Shared\ChooseLanguage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db026dbc628cee312d7a26c9183ddbd7779b9e61"
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
    public partial class ChooseLanguage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
    #site-lang {
        width: auto;
        margin: 0;
        padding: 0;
        color: grey;
        float: left;
        padding-right: 15px;
        font-size: 10pt;
    }

    #language-selection-container {
        width: auto;
        vertical-align: middle;
        margin-left: auto;
    }

    #select-language-form {
        float: right;
    }

    #cl-submit-btn {
        background-color: transparent;
        border: 1px solid orangered;
        color: orangered;
    }

    #cl-submit-btn:hover {
        background-color: orangered;
        color: ghostwhite;
    }
</style>");
#nullable restore
#line 38 "C:\Users\Jmorrow\Desktop\code\work-code\blazor\MarathonTutorialWebsite\Shared\ChooseLanguage.razor"
 if (cultures != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "id", "language-selection-container");
            __builder.AddMarkupContent(3, "<span id=\"site-lang\">Site Language<br>Idioma del sitio</span>\r\n        ");
            __builder.OpenElement(4, "form");
            __builder.AddAttribute(5, "id", "select-language-form");
            __builder.AddAttribute(6, "class", "form-inline");
            __builder.OpenElement(7, "select");
            __builder.AddAttribute(8, "class", "form-control mr-2");
            __builder.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 43 "C:\Users\Jmorrow\Desktop\code\work-code\blazor\MarathonTutorialWebsite\Shared\ChooseLanguage.razor"
                                                     selectedCulture

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => selectedCulture = __value, selectedCulture));
            __builder.SetUpdatesAttributeName("value");
#nullable restore
#line 44 "C:\Users\Jmorrow\Desktop\code\work-code\blazor\MarathonTutorialWebsite\Shared\ChooseLanguage.razor"
                 foreach (var culture in cultures)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "option");
            __builder.AddAttribute(12, "value", 
#nullable restore
#line 46 "C:\Users\Jmorrow\Desktop\code\work-code\blazor\MarathonTutorialWebsite\Shared\ChooseLanguage.razor"
                                    culture.Key

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(13, 
#nullable restore
#line 46 "C:\Users\Jmorrow\Desktop\code\work-code\blazor\MarathonTutorialWebsite\Shared\ChooseLanguage.razor"
                                                  culture.Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 47 "C:\Users\Jmorrow\Desktop\code\work-code\blazor\MarathonTutorialWebsite\Shared\ChooseLanguage.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "id", "cl-submit-btn");
            __builder.AddAttribute(17, "type", "button");
            __builder.AddAttribute(18, "class", "btn btn-outline-primary");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "C:\Users\Jmorrow\Desktop\code\work-code\blazor\MarathonTutorialWebsite\Shared\ChooseLanguage.razor"
                                                                                               RequestCultureChange

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(20, "Change\r\n                Language");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 53 "C:\Users\Jmorrow\Desktop\code\work-code\blazor\MarathonTutorialWebsite\Shared\ChooseLanguage.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "C:\Users\Jmorrow\Desktop\code\work-code\blazor\MarathonTutorialWebsite\Shared\ChooseLanguage.razor"
       
    private string selectedCulture = System.Threading.Thread.CurrentThread.CurrentCulture.Name;
    private Dictionary<string, string> cultures;
    protected override void OnInitialized()
    {
        cultures = Configuration.GetSection("Cultures")
        .GetChildren().ToDictionary(x => x.Key, x => x.Value);
    }

    private void RequestCultureChange()
    {

        if (string.IsNullOrWhiteSpace(selectedCulture)) return;

        var uri = new Uri(NavigationManager.Uri)
        .GetComponents(UriComponents.PathAndQuery, UriFormat.Unescaped);

        var query = $"?culture={Uri.EscapeDataString(selectedCulture)}&" +
        $"redirectUri={Uri.EscapeDataString(uri)}";

        /* var prompt = "URI: " + uri + "\n\n" + Uri.EscapeDataString(uri) + "\n\n" + "QUERY: " + query;
        JSRuntime.InvokeVoidAsync("alert", prompt); */

        NavigationManager.NavigateTo("/Culture/SetCulture" + query, forceLoad: true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration Configuration { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
