// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\DetallesDeArtista.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\DetallesDeArtista.razor"
using Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/vercanciones/{id:int}")]
    public partial class DetallesDeArtista : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Users\KATHYA VISCARRA\OneDrive\Escritorio\QuickMusic.ClienteBlazor\QuickMusic.ClienteBlazor\Pages\DetallesDeArtista.razor"
       
    [Parameter]
    public int id { get; set; }

    IEnumerable<Canciones> Cancioness = new List<Canciones>();

    protected override async Task OnInitializedAsync()
    {
        if (id > 0)
            Cancioness = await CancionesService.GetByCanciones(id);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICancionesService CancionesService { get; set; }
    }
}
#pragma warning restore 1591
