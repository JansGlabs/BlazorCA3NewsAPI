#pragma checksum "C:\Users\lafaman\Desktop\lafamans\ITT\Year4\EAD\CA3\BlazorCA3NewsAPI\NewsAPI\NewsAPI\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9a59f5346f51497465da441f9d7479b231e5b5b"
// <auto-generated/>
#pragma warning disable 1591
namespace NewsAPI.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\lafaman\Desktop\lafamans\ITT\Year4\EAD\CA3\BlazorCA3NewsAPI\NewsAPI\NewsAPI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lafaman\Desktop\lafamans\ITT\Year4\EAD\CA3\BlazorCA3NewsAPI\NewsAPI\NewsAPI\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lafaman\Desktop\lafamans\ITT\Year4\EAD\CA3\BlazorCA3NewsAPI\NewsAPI\NewsAPI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lafaman\Desktop\lafamans\ITT\Year4\EAD\CA3\BlazorCA3NewsAPI\NewsAPI\NewsAPI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\lafaman\Desktop\lafamans\ITT\Year4\EAD\CA3\BlazorCA3NewsAPI\NewsAPI\NewsAPI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\lafaman\Desktop\lafamans\ITT\Year4\EAD\CA3\BlazorCA3NewsAPI\NewsAPI\NewsAPI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\lafaman\Desktop\lafamans\ITT\Year4\EAD\CA3\BlazorCA3NewsAPI\NewsAPI\NewsAPI\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\lafaman\Desktop\lafamans\ITT\Year4\EAD\CA3\BlazorCA3NewsAPI\NewsAPI\NewsAPI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\lafaman\Desktop\lafamans\ITT\Year4\EAD\CA3\BlazorCA3NewsAPI\NewsAPI\NewsAPI\_Imports.razor"
using NewsAPI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\lafaman\Desktop\lafamans\ITT\Year4\EAD\CA3\BlazorCA3NewsAPI\NewsAPI\NewsAPI\_Imports.razor"
using NewsAPI.Shared;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "class", "navbar navbar-expand-lg navbar-dark bg-secondary static-top");
            __builder.AddAttribute(2, "b-h3d1jgxi74");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container");
            __builder.AddAttribute(5, "b-h3d1jgxi74");
            __builder.AddMarkupContent(6, "<a class=\"navbar-brand text-white font-weight-bold\" b-h3d1jgxi74><h2 b-h3d1jgxi74>Blazor News App</h2></a>\r\n        ");
            __builder.OpenElement(7, "button");
            __builder.AddAttribute(8, "class", "navbar-toggler");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "C:\Users\lafaman\Desktop\lafamans\ITT\Year4\EAD\CA3\BlazorCA3NewsAPI\NewsAPI\NewsAPI\Shared\NavMenu.razor"
                                                 ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "b-h3d1jgxi74");
            __builder.AddMarkupContent(11, "<span class=\"navbar-toggler-icon\" b-h3d1jgxi74></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n\r\n        ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", 
#nullable restore
#line 10 "C:\Users\lafaman\Desktop\lafamans\ITT\Year4\EAD\CA3\BlazorCA3NewsAPI\NewsAPI\NewsAPI\Shared\NavMenu.razor"
                     NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\lafaman\Desktop\lafamans\ITT\Year4\EAD\CA3\BlazorCA3NewsAPI\NewsAPI\NewsAPI\Shared\NavMenu.razor"
                                                ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "b-h3d1jgxi74");
            __builder.OpenElement(17, "ul");
            __builder.AddAttribute(18, "class", "navbar-nav");
            __builder.AddAttribute(19, "b-h3d1jgxi74");
            __builder.OpenElement(20, "li");
            __builder.AddAttribute(21, "class", "nav-item active");
            __builder.AddAttribute(22, "b-h3d1jgxi74");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(23);
            __builder.AddAttribute(24, "class", "nav-link");
            __builder.AddAttribute(25, "href", "/");
            __builder.AddAttribute(26, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 13 "C:\Users\lafaman\Desktop\lafamans\ITT\Year4\EAD\CA3\BlazorCA3NewsAPI\NewsAPI\NewsAPI\Shared\NavMenu.razor"
                                                              NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(28, "<span class=\"oi oi-home\" aria-hidden=\"true\" b-h3d1jgxi74></span> Home\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\lafaman\Desktop\lafamans\ITT\Year4\EAD\CA3\BlazorCA3NewsAPI\NewsAPI\NewsAPI\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
