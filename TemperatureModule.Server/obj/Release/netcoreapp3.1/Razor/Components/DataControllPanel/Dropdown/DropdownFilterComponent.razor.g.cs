#pragma checksum "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\Components\DataControllPanel\Dropdown\DropdownFilterComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd03f6fee94c4b530eec86f5047b900cce1c26bf"
// <auto-generated/>
#pragma warning disable 1591
namespace TemperatureModule.Webpage.Components.DataControllPanel.Dropdown
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
#line 3 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\Components\DataControllPanel\Dropdown\DropdownFilterComponent.razor"
using TemperatureModule.Webpage.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\Components\DataControllPanel\Dropdown\DropdownFilterComponent.razor"
using TemperatureModule.Webpage.HelpClasses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\Components\DataControllPanel\Dropdown\DropdownFilterComponent.razor"
using BlazorDateRangePicker;

#line default
#line hidden
#nullable disable
    public partial class DropdownFilterComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<TemperatureModule.Webpage.Components.DataControllPanel.Dropdown.Dropdown<string>>(0);
            __builder.AddAttribute(1, "OnSelected", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, 
#nullable restore
#line 8 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\Components\DataControllPanel\Dropdown\DropdownFilterComponent.razor"
                                      OnSelected

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(2, "Tip", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(3, 
#nullable restore
#line 9 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\Components\DataControllPanel\Dropdown\DropdownFilterComponent.razor"
          Tip

#line default
#line hidden
#nullable disable
                );
            }
            ));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n");
#nullable restore
#line 11 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\Components\DataControllPanel\Dropdown\DropdownFilterComponent.razor"
         foreach (var label in Filters)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(6, "            ");
                __Blazor.TemperatureModule.Webpage.Components.DataControllPanel.Dropdown.DropdownFilterComponent.TypeInference.CreateDropdownListItem_0(__builder2, 7, 8, 
#nullable restore
#line 13 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\Components\DataControllPanel\Dropdown\DropdownFilterComponent.razor"
                                     label

#line default
#line hidden
#nullable disable
                , 9, (context) => (__builder3) => {
                    __builder3.AddContent(10, 
#nullable restore
#line 13 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\Components\DataControllPanel\Dropdown\DropdownFilterComponent.razor"
                                             label

#line default
#line hidden
#nullable disable
                    );
                }
                );
                __builder2.AddMarkupContent(11, "\r\n");
#nullable restore
#line 14 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\Components\DataControllPanel\Dropdown\DropdownFilterComponent.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(12, "    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\Components\DataControllPanel\Dropdown\DropdownFilterComponent.razor"
       
    [Parameter]
    public List<string> Filters { get; set; }

    [Parameter]
    public string Tip { get; set; }

    [Parameter]
    public EventCallback<FilterEnum> SelectUpdated { get; set; }

    public async Task OnSelected(string selection)
    {
        var filterEnum = FilterEnumHelper.GetFilterEnum(selection);

        await SelectUpdated.InvokeAsync(filterEnum);
        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.TemperatureModule.Webpage.Components.DataControllPanel.Dropdown.DropdownFilterComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateDropdownListItem_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TItem __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg1)
        {
        __builder.OpenComponent<global::TemperatureModule.Webpage.Components.DataControllPanel.Dropdown.DropdownListItem<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Item", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
