#pragma checksum "D:\6308\C#\Week9\Homework\RaceTo21Interface\RaceTo21Interface\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ae79aa05f41bd6e1338546b6d2e55e292e502aa"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row mt-2");
            __builder.AddMarkupContent(4, "<div class=\"col-sm-6\">\r\n            Enter text:\r\n        </div>\r\n        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-sm-6");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "type", "text");
            __builder.AddAttribute(9, "placeholder", "Enter text");
            __builder.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 10 "D:\6308\C#\Week9\Homework\RaceTo21Interface\RaceTo21Interface\Pages\Index.razor"
                              UpdateNumberOfPlayer

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "row mt-5");
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "type", "button");
            __builder.AddAttribute(16, "class", "btn btn-primary");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "D:\6308\C#\Week9\Homework\RaceTo21Interface\RaceTo21Interface\Pages\Index.razor"
                              SetNumberOfPlayer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(18, "\r\n                Next\r\n            ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n    <div></div>\r\n    ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "row mt-5");
            __builder.OpenElement(22, "h2");
            __builder.OpenElement(23, "strong");
            __builder.AddContent(24, 
#nullable restore
#line 24 "D:\6308\C#\Week9\Homework\RaceTo21Interface\RaceTo21Interface\Pages\Index.razor"
                     DisplayAlart

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "D:\6308\C#\Week9\Homework\RaceTo21Interface\RaceTo21Interface\Pages\Index.razor"
 
    private string DisplayAlart = "";
    int players;

    private void UpdateNumberOfPlayer(ChangeEventArgs e)
    {
        if (int.TryParse(e.Value.ToString(), out int result) == false
                || result < 2 || result > 8)
        {
            //DisplayValue = e.Value.ToString();
            DisplayAlart = "Invalid number of players.";
        }
        else
        {
            DisplayAlart = "";
            players = result;
        }

    }

    void SetNumberOfPlayer()
    {
        CardTable.numberOfPlayers = players;
        NavigationManager.NavigateTo("/GetNumberOfPlayer");
        Game.DoNextTask();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
