#pragma checksum "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\Components\Slides\StartView\RecordPlaceholder\AverageTemperatureComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6bcf0509f1a9a35ecd63c6c3e872f7d176857abd"
// <auto-generated/>
#pragma warning disable 1591
namespace TemperatureModule.Server.Components.Slides.StartView.RecordPlaceholder
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\_Imports.razor"
using TemperatureModule.Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\_Imports.razor"
using TemperatureModule.Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\Components\Slides\StartView\RecordPlaceholder\AverageTemperatureComponent.razor"
using TemperatureModule.Webpage.Models;

#line default
#line hidden
#nullable disable
    public partial class AverageTemperatureComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "style", "padding-top: 6px;padding-bottom: 6px;padding-left: 20px; display:flex; flex-direction:row; justify-content: center");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "p");
            __builder.AddAttribute(4, "class", "order-1");
            __builder.AddContent(5, "Average ");
            __builder.AddContent(6, 
#nullable restore
#line 4 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\Components\Slides\StartView\RecordPlaceholder\AverageTemperatureComponent.razor"
                                _medium

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(7, " temperature: ");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "p");
            __builder.AddAttribute(10, "class", "order-2");
            __builder.AddAttribute(11, "style", "margin-left:5px");
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.OpenElement(13, "strong");
            __builder.AddContent(14, " ");
            __builder.AddContent(15, 
#nullable restore
#line 6 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\Components\Slides\StartView\RecordPlaceholder\AverageTemperatureComponent.razor"
                  Average

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(16, " °C");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "&nbsp;\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\Components\Slides\StartView\RecordPlaceholder\AverageTemperatureComponent.razor"
       
    [Parameter]
    public double Average { get; set; }

    [Parameter]
    public PTIndex PTIndex { get; set; }

    private string _medium { get { return PTIndex == PTIndex.Water ? "water" : "air"; } }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
