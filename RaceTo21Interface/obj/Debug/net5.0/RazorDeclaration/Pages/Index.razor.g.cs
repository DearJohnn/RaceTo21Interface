// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace RaceTo21Interface.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\6308\C#\Week9\Homework\RaceTo21Interface\RaceTo21Interface\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\6308\C#\Week9\Homework\RaceTo21Interface\RaceTo21Interface\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\6308\C#\Week9\Homework\RaceTo21Interface\RaceTo21Interface\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\6308\C#\Week9\Homework\RaceTo21Interface\RaceTo21Interface\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\6308\C#\Week9\Homework\RaceTo21Interface\RaceTo21Interface\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\6308\C#\Week9\Homework\RaceTo21Interface\RaceTo21Interface\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\6308\C#\Week9\Homework\RaceTo21Interface\RaceTo21Interface\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\6308\C#\Week9\Homework\RaceTo21Interface\RaceTo21Interface\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\6308\C#\Week9\Homework\RaceTo21Interface\RaceTo21Interface\_Imports.razor"
using RaceTo21Interface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\6308\C#\Week9\Homework\RaceTo21Interface\RaceTo21Interface\_Imports.razor"
using RaceTo21Interface.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "D:\6308\C#\Week9\Homework\RaceTo21Interface\RaceTo21Interface\Pages\Index.razor"
 
    public static CardTable cardTable = new CardTable();

    public static void SetUpGame()
    {
        Game game = new Game(cardTable);
        Game.players = new List<Player>();
    }

    void SetNumberOfPlayer()
    {
        NavigationManager.NavigateTo("/GetNumberOfPlayer");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
