#pragma checksum "D:\6308\C#\Week9\Homework\RaceTo21Interface\RaceTo21Interface\Pages\Bet.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c1242d3d2fc98f0fb8d1c110eebbb9788271b74"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Bet")]
    public partial class Bet : Microsoft.AspNetCore.Components.ComponentBase
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
            __builder.AddMarkupContent(3, "<h2 class=\"text-center mt-4\">How many chips you want to bet?</h2>\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row mt-4");
            __builder.AddAttribute(6, "style", "width: 100%");
#nullable restore
#line 24 "D:\6308\C#\Week9\Homework\RaceTo21Interface\RaceTo21Interface\Pages\Bet.razor"
         for (int i = 0; i < Game.players.Count; i++)
        {
            int playerIndex = i;
            Player player = Game.players[playerIndex];
            int maxChip = player.chip;

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-12");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "row alert alert-secondary align-items-center py-4 px-0");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-sm-auto text-sm-center");
            __builder.AddAttribute(13, "style", "width:30%");
            __builder.OpenElement(14, "h4");
            __builder.OpenElement(15, "strong");
            __builder.AddContent(16, 
#nullable restore
#line 32 "D:\6308\C#\Week9\Homework\RaceTo21Interface\RaceTo21Interface\Pages\Bet.razor"
                                     player.name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                        ");
            __builder.OpenElement(18, "h5");
            __builder.AddContent(19, "Chips: ");
            __builder.AddContent(20, 
#nullable restore
#line 33 "D:\6308\C#\Week9\Homework\RaceTo21Interface\RaceTo21Interface\Pages\Bet.razor"
                                    player.chip

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "col-sm-5");
            __builder.AddAttribute(24, "style", "width:70%");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "row align-items-center");
            __builder.OpenElement(27, "span");
            __builder.AddContent(28, "$");
            __builder.AddContent(29, 
#nullable restore
#line 37 "D:\6308\C#\Week9\Homework\RaceTo21Interface\RaceTo21Interface\Pages\Bet.razor"
                                    Game.bets[playerIndex]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                            ");
            __builder.OpenElement(31, "input");
            __builder.AddAttribute(32, "type", "range");
            __builder.AddAttribute(33, "step", "1");
            __builder.AddAttribute(34, "min", "1");
            __builder.AddAttribute(35, "max", 
#nullable restore
#line 38 "D:\6308\C#\Week9\Homework\RaceTo21Interface\RaceTo21Interface\Pages\Bet.razor"
                                                                        player.chip + Game.bets[playerIndex]

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(36, "value", 
#nullable restore
#line 38 "D:\6308\C#\Week9\Homework\RaceTo21Interface\RaceTo21Interface\Pages\Bet.razor"
                                                                                                                       Game.defaultValueOfBet

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(37, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 39 "D:\6308\C#\Week9\Homework\RaceTo21Interface\RaceTo21Interface\Pages\Bet.razor"
                                              e => UpdateBet(e, playerIndex)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 47 "D:\6308\C#\Week9\Homework\RaceTo21Interface\RaceTo21Interface\Pages\Bet.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n    ");
            __builder.AddMarkupContent(39, "<div class=\"row\"><div class=\"col\"><hr></div></div>\r\n    ");
            __builder.OpenElement(40, "h4");
            __builder.AddAttribute(41, "class", "text-center");
            __builder.AddContent(42, "Total Amount in Pot: $");
            __builder.AddContent(43, 
#nullable restore
#line 54 "D:\6308\C#\Week9\Homework\RaceTo21Interface\RaceTo21Interface\Pages\Bet.razor"
                                                    Game.pot

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n    ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "row justify-content-center");
            __builder.OpenElement(47, "button");
            __builder.AddAttribute(48, "class", "btn btn-primary mt-4 mb-lg-5");
            __builder.AddAttribute(49, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 56 "D:\6308\C#\Week9\Homework\RaceTo21Interface\RaceTo21Interface\Pages\Bet.razor"
                                                                 Play

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(50, "PLAY");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "D:\6308\C#\Week9\Homework\RaceTo21Interface\RaceTo21Interface\Pages\Bet.razor"
           
        private string DisplayAlart = "";

        private void UpdateBet(ChangeEventArgs e, int playerIndex)
        {
            int bet = int.Parse(e.Value.ToString());
            Player player = Game.players[playerIndex];
            Game.change = Game.bets[playerIndex] - bet;
            Game.bets[playerIndex] = bet;
            Game.UpdateChip(playerIndex,Game.change);
            Game.UpdatePot();

        }

        private void Play()
        {
            Game.DoNextTask();
            NavigationManager.NavigateTo("/GameTable");
        }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
