#pragma checksum "C:\Users\lukse\source\repos\TempraturModul\Temperature_Webmodule\Components\Slides\StartView\RecordPlaceholder\Termometers\TermometerComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a6261b58e7d4d36b9da66d8758d9344ef9b2197"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TemperatureModule.Webpage.Components.Slides.StartView.RecordPlaceholder.Termometers
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\lukse\source\repos\TempraturModul\Temperature_Webmodule\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lukse\source\repos\TempraturModul\Temperature_Webmodule\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lukse\source\repos\TempraturModul\Temperature_Webmodule\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lukse\source\repos\TempraturModul\Temperature_Webmodule\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\lukse\source\repos\TempraturModul\Temperature_Webmodule\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\lukse\source\repos\TempraturModul\Temperature_Webmodule\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\lukse\source\repos\TempraturModul\Temperature_Webmodule\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\lukse\source\repos\TempraturModul\Temperature_Webmodule\_Imports.razor"
using Temperature_Webmodule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\lukse\source\repos\TempraturModul\Temperature_Webmodule\_Imports.razor"
using TemperatureModule.Webpage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\lukse\source\repos\TempraturModul\Temperature_Webmodule\_Imports.razor"
using TemperatureModule.Webpage.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\lukse\source\repos\TempraturModul\Temperature_Webmodule\_Imports.razor"
using ChartJs.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\lukse\source\repos\TempraturModul\Temperature_Webmodule\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\lukse\source\repos\TempraturModul\Temperature_Webmodule\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lukse\source\repos\TempraturModul\Temperature_Webmodule\Components\Slides\StartView\RecordPlaceholder\Termometers\TermometerComponent.razor"
using TemperatureModule.Webpage.Models;

#line default
#line hidden
#nullable disable
    public partial class TermometerComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Users\lukse\source\repos\TempraturModul\Temperature_Webmodule\Components\Slides\StartView\RecordPlaceholder\Termometers\TermometerComponent.razor"
       
    [Parameter]
    public LatestTemperatureUnit temperatureUnit { get; set; }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await jsRuntime.InvokeAsync<object>("airTemperature",
            temperatureUnit.Latest.DataPTValue, temperatureUnit.Highest.DataPTValue, temperatureUnit.Lowest.DataPTValue);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
    }
}
#pragma warning restore 1591
