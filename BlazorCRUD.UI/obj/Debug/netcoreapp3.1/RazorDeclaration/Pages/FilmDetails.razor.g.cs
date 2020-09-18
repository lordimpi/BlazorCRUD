#pragma checksum "C:\Users\snt-2\Desktop\S2\BlazorCRUD\BlazorCRUD.UI\Pages\FilmDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9fb0ac5620668a706d285da6a266d3733c3c68d0"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorCRUD.UI.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\snt-2\Desktop\S2\BlazorCRUD\BlazorCRUD.UI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\snt-2\Desktop\S2\BlazorCRUD\BlazorCRUD.UI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\snt-2\Desktop\S2\BlazorCRUD\BlazorCRUD.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\snt-2\Desktop\S2\BlazorCRUD\BlazorCRUD.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\snt-2\Desktop\S2\BlazorCRUD\BlazorCRUD.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\snt-2\Desktop\S2\BlazorCRUD\BlazorCRUD.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\snt-2\Desktop\S2\BlazorCRUD\BlazorCRUD.UI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\snt-2\Desktop\S2\BlazorCRUD\BlazorCRUD.UI\_Imports.razor"
using BlazorCRUD.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\snt-2\Desktop\S2\BlazorCRUD\BlazorCRUD.UI\_Imports.razor"
using BlazorCRUD.UI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\snt-2\Desktop\S2\BlazorCRUD\BlazorCRUD.UI\_Imports.razor"
using Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\snt-2\Desktop\S2\BlazorCRUD\BlazorCRUD.UI\_Imports.razor"
using BlazorCRUD.UI.Interfaces;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/filmdetails")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/filmdetails/{id:int}")]
    public partial class FilmDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\snt-2\Desktop\S2\BlazorCRUD\BlazorCRUD.UI\Pages\FilmDetails.razor"
       

    [Parameter]
    public int id { get; set; }

    Film film = new Film();

    protected void CancelFilm()
    {
        NavigationManager.NavigateTo("/filmlist");
    }

    protected async Task SaveFilm()
    {
        await FilmService.SaveFilm(film);

        NavigationManager.NavigateTo("/filmlist");
    }

    protected override async Task OnInitializedAsync()
    {
        if (id == 0)
        {
            film.ReleaseDate = DateTime.Now;
        }
        else
        {
            film = await FilmService.GetDetails(id);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFilmService FilmService { get; set; }
    }
}
#pragma warning restore 1591
