#pragma checksum "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\Artistas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "708ae3a5e94532ecf10a0d7cd7ccf2c808ab5d65"
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
#line 2 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\Artistas.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\Artistas.razor"
using Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/Artista")]
    public partial class Artistas : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::MudBlazor.MudText>(0);
            __builder.AddAttribute(1, "Class", "text-center pa-4 shades-text text-white ");
            __builder.AddAttribute(2, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Typo>(
#nullable restore
#line 6 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\Artistas.razor"
                                                                    Typo.h3

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(4, "ARTISTA");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenComponent<global::MudBlazor.MudGrid>(6);
            __builder.AddAttribute(7, "Class", "");
            __builder.AddAttribute(8, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
#nullable restore
#line 8 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\Artistas.razor"
         foreach (var item in deptos)
        {
            string Artista = "";

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<global::MudBlazor.MudItem>(9);
                __builder2.AddAttribute(10, "xs", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 11 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\Artistas.razor"
                         12

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "sm", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 11 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\Artistas.razor"
                                 10

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "md", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 11 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\Artistas.razor"
                                         6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "lg", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 11 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\Artistas.razor"
                                                4

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<global::MudBlazor.MudCard>(15);
                    __builder3.AddAttribute(16, "Class", "Grey");
                    __builder3.AddAttribute(17, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<global::MudBlazor.MudCardHeader>(18);
                        __builder4.AddAttribute(19, "Class", " pa-4 indigo  shades-text text-white ");
                        __builder4.AddAttribute(20, "CardHeaderContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<global::MudBlazor.MudText>(21);
                            __builder5.AddAttribute(22, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Typo>(
#nullable restore
#line 15 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\Artistas.razor"
                                           Typo.h6

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(23, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
#nullable restore
#line 15 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\Artistas.razor"
__builder6.AddContent(24, item.Nombre);

#line default
#line hidden
#nullable disable
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(25, "\r\n                    ");
                        __builder4.OpenComponent<global::MudBlazor.MudCardContent>(26);
                        __builder4.AddAttribute(27, "Class", "pa-4  indigo shades-text text-white ");
                        __builder4.AddAttribute(28, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
#nullable restore
#line 19 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\Artistas.razor"
                         switch (item.Id)
                        {
                            case 1:
                                Artista = "Artista";
                                break;
                        }

#line default
#line hidden
#nullable disable
                            __builder5.OpenComponent<global::MudBlazor.MudText>(29);
                            __builder5.AddAttribute(30, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Typo>(
#nullable restore
#line 25 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\Artistas.razor"
                                       Typo.body2

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(31, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(32, "Artista ");
#nullable restore
#line 25 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\Artistas.razor"
__builder6.AddContent(33, Artista);

#line default
#line hidden
#nullable disable
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(34, "\r\n                    ");
                        __builder4.OpenComponent<global::MudBlazor.MudCardActions>(35);
                        __builder4.AddAttribute(36, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<global::MudBlazor.MudButton>(37);
                            __builder5.AddAttribute(38, "EndIcon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 28 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\Artistas.razor"
                                             Icons.Filled.PlaylistPlay

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(39, "Link", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 28 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\Artistas.razor"
                                                                                $"/vercanciones/{item.Id}"

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(40, "Variant", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Variant>(
#nullable restore
#line 29 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\Artistas.razor"
                                            Variant.Text

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(41, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 29 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\Artistas.razor"
                                                                 Color.Primary

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(42, "Class", "oi-align-center");
                            __builder5.AddAttribute(43, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(44, "Escucha la musica ");
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
#line 33 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\Artistas.razor"
        }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\Artistas.razor"
           
        IEnumerable<Artista> deptos = new List<Artista>();
        protected override async Task OnInitializedAsync()
        {
            deptos = await ArtistaService.GetAll();
        }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IArtistaService ArtistaService { get; set; }
    }
}
#pragma warning restore 1591