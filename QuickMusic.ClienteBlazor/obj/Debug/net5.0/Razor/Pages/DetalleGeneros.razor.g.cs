#pragma checksum "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\DetalleGeneros.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "014809266559f6e6ee0e6d7b972659d93df71ca0"
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
#line 2 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\DetalleGeneros.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\DetalleGeneros.razor"
using Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/genero/{id:int}")]
    public partial class DetalleGeneros : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::MudBlazor.MudText>(0);
            __builder.AddAttribute(1, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Typo>(
#nullable restore
#line 6 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\DetalleGeneros.razor"
               Typo.h4

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Class", "text-center pa-4 shades-text text-white ");
            __builder.AddAttribute(3, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(4, "Lista de canciones");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 8 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\DetalleGeneros.razor"
 if (Generos == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "<p>Cargando...</p>");
#nullable restore
#line 11 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\DetalleGeneros.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<global::MudBlazor.MudGrid>(6);
            __builder.AddAttribute(7, "Class", " pa-4 black  shades-text text-white");
            __builder.AddAttribute(8, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
#nullable restore
#line 15 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\DetalleGeneros.razor"
         foreach (var item in Generos)
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<global::MudBlazor.MudItem>(9);
                __builder2.AddAttribute(10, "xs", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 17 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\DetalleGeneros.razor"
                         12

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "sm", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 17 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\DetalleGeneros.razor"
                                 10

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "md", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 17 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\DetalleGeneros.razor"
                                         6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "lg", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 17 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\DetalleGeneros.razor"
                                                4

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<global::MudBlazor.MudCard>(15);
                    __builder3.AddAttribute(16, "Class", "black");
                    __builder3.AddAttribute(17, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<global::MudBlazor.MudCardHeader>(18);
                        __builder4.AddAttribute(19, "Class", " pa-4 indigo  shades-text text-white ");
                        __builder4.AddAttribute(20, "CardHeaderContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<global::MudBlazor.MudText>(21);
                            __builder5.AddAttribute(22, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Typo>(
#nullable restore
#line 21 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\DetalleGeneros.razor"
                                           Typo.h6

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(23, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
#nullable restore
#line 21 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\DetalleGeneros.razor"
__builder6.AddContent(24, item.Titulo);

#line default
#line hidden
#nullable disable
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(25, "\r\n\r\n                    ");
                        __builder4.OpenComponent<global::MudBlazor.MudCardActions>(26);
                        __builder4.AddAttribute(27, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<global::MudBlazor.MudButton>(28);
                            __builder5.AddAttribute(29, "EndIcon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 26 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\DetalleGeneros.razor"
                                             Icons.Material.Filled.PlayArrow

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(30, "Link", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 26 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\DetalleGeneros.razor"
                                                                                      $" /Reproductor/{item.Id}"

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(31, "Variant", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Variant>(
#nullable restore
#line 26 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\DetalleGeneros.razor"
                                                                                                                            Variant.Outlined

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(32, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 26 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\DetalleGeneros.razor"
                                                                                                                                                     Color.Primary

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(33, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(34, "Reproducir");
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
#line 30 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\DetalleGeneros.razor"
        }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 32 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\DetalleGeneros.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\DetalleGeneros.razor"
       
    [Parameter]
    public int id { get; set; }

    IEnumerable<Canciones>
    Generos = new List<Canciones>
        ();

    protected override async Task OnInitializedAsync()
    {
        if (id > 0)
            Generos = await CancionesService.GetByGenero(id);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICancionesService CancionesService { get; set; }
    }
}
#pragma warning restore 1591