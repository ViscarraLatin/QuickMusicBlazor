#pragma checksum "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\Cancion.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bfde57065bab4829a01fc1ad7c677ce3b4ec8ba9"
// <auto-generated/>
#pragma warning disable 1591
namespace QuickMusic.ClienteBlazor.Pages
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
#nullable restore
#line 2 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\Cancion.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\Cancion.razor"
using Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Canciones")]
    public partial class Cancion : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudText>(0);
            __builder.AddAttribute(1, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 7 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\Cancion.razor"
               Typo.h4

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Class", " pa-4 shades-text text-white ");
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(4, "Canciones");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 9 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\Cancion.razor"
 if (canciones == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "<p>Cargando...</p>");
#nullable restore
#line 12 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\Cancion.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<MudBlazor.MudGrid>(6);
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
#nullable restore
#line 16 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\Cancion.razor"
         foreach (var item in canciones)
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MudBlazor.MudItem>(8);
                __builder2.AddAttribute(9, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 18 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\Cancion.razor"
                         12

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 18 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\Cancion.razor"
                                 10

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 18 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\Cancion.razor"
                                         6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "lg", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 18 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\Cancion.razor"
                                                4

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudCard>(14);
                    __builder3.AddAttribute(15, "Class", "Grey");
                    __builder3.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudCardHeader>(17);
                        __builder4.AddAttribute(18, "Class", " pa-4 indigo  shades-text text-white ");
                        __builder4.AddAttribute(19, "CardHeaderContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudText>(20);
                            __builder5.AddAttribute(21, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 22 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\Cancion.razor"
                                           Typo.h6

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(23, 
#nullable restore
#line 22 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\Cancion.razor"
                                                     item.Titulo

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(24, "\r\n                    \r\n                    \r\n                    ");
                        __builder4.OpenComponent<MudBlazor.MudCardActions>(25);
                        __builder4.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudButton>(27);
                            __builder5.AddAttribute(28, "EndIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\Cancion.razor"
                                             Icons.Material.Filled.PlayArrow

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(29, "Link", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\Cancion.razor"
                                           $"/Reproductor/{item.Id}"

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(30, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 29 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\Cancion.razor"
                                                                                Variant.Outlined

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(31, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 29 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\Cancion.razor"
                                                                                                         Color.Success

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(33, "Reproducir");
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 33 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\Cancion.razor"
        }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 35 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\Cancion.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\Cancion.razor"
       
    IEnumerable<Canciones> canciones = new List<Canciones>();
    protected override async Task OnInitializedAsync()
    {
        canciones = await CancionesService.GetAll();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICancionesService CancionesService { get; set; }
    }
}
#pragma warning restore 1591
