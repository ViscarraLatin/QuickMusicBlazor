#pragma checksum "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12ed6b5a218a432a80293d7d9a465dcf52bf1c1f"
// <auto-generated/>
#pragma warning disable 1591
namespace QuickMusic.ClienteBlazor.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\_Imports.razor"
using QuickMusic.ClienteBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\_Imports.razor"
using QuickMusic.ClienteBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudPaper>(0);
            __builder.AddAttribute(1, "Width", "250px");
            __builder.AddAttribute(2, "Class", "py-3");
            __builder.AddAttribute(3, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 1 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Shared\NavMenu.razor"
                                                0

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudNavMenu>(5);
                __builder2.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudText>(7);
                    __builder3.AddAttribute(8, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 3 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Shared\NavMenu.razor"
                       Typo.h6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(9, "Class", "px-4");
                    __builder3.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(11, "QuickMusic");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(12, "\r\n\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudDivider>(13);
                    __builder3.AddAttribute(14, "Class", "my-2");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(15, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudNavLink>(16);
                    __builder3.AddAttribute(17, "Href", "/index");
                    __builder3.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(19, "Artistas");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(20, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudNavLink>(21);
                    __builder3.AddAttribute(22, "Href", "/servers");
                    __builder3.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(24, "Genero");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(25, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudNavLink>(26);
                    __builder3.AddAttribute(27, "Href", "/servers");
                    __builder3.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(29, "Canciones");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
