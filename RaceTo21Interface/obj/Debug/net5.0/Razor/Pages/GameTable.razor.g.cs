#pragma checksum "D:\6308\C#\Week9\Homework\RaceTo21Interface\RaceTo21Interface\Pages\GameTable.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81a10e0e6a8c5a8473ab3ba6d0056a105355c3e7"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/GameTable")]
    public partial class GameTable : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
        body {
            font-family: 'Lilita One', cursive;
        }

        .container {
            width: 50%;
            padding-top: 10%;
            display: flex;
            flex-direction: column;
            align-items: center;
            justify-content: center;
        }
    </style>

    <link rel=""preconnect"" href=""https://fonts.googleapis.com"">
    <link rel=""preconnect"" href=""https://fonts.gstatic.com"" crossorigin>
    <link href=""https://fonts.googleapis.com/css2?family=Lilita+One&display=swap"" rel=""stylesheet"">
    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.OpenElement(3, "h2");
            __builder.AddAttribute(4, "class", "text-center mt-4");
            __builder.AddContent(5, "Total Amount in Pot: $");
            __builder.AddContent(6, 
#nullable restore
#line 21 "D:\6308\C#\Week9\Homework\RaceTo21Interface\RaceTo21Interface\Pages\GameTable.razor"
                                                             Game.pot

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591