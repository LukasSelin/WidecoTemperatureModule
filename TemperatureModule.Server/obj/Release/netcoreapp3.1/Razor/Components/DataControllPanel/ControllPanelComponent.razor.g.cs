#pragma checksum "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\Components\DataControllPanel\ControllPanelComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "daf5ff344bd3001926ecc327554be4d92cda71a9"
// <auto-generated/>
#pragma warning disable 1591
namespace TemperatureModule.Webpage.Components.DataControllPanel
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
#line 2 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\Components\DataControllPanel\ControllPanelComponent.razor"
using TemperatureModule.Webpage.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\Components\DataControllPanel\ControllPanelComponent.razor"
using BlazorDateRangePicker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\Components\DataControllPanel\ControllPanelComponent.razor"
using TemperatureModule.Webpage.HelpClasses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\Components\DataControllPanel\ControllPanelComponent.razor"
using TemperatureModule.Webpage.Components.DataControllPanel.Dropdown;

#line default
#line hidden
#nullable disable
    public partial class ControllPanelComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link rel=\"stylesheet\" href=\"/css/myown/ControllPanel.css\">\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "controlPanel");
            __builder.AddMarkupContent(3, "\r\n\r\n    ");
            __builder.AddMarkupContent(4, "<h1>Lövekulle badplats</h1>\r\n\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "filter");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenComponent<BlazorDateRangePicker.DateRangePicker>(8);
            __builder.AddAttribute(9, "class", "dateRangePicker");
            __builder.AddAttribute(10, "placeholder", 
#nullable restore
#line 15 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\Components\DataControllPanel\ControllPanelComponent.razor"
                                                               StartDate.GetValueOrDefault().DateTime.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(11, "ShowOnlyOneCalendar", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean?>(
#nullable restore
#line 16 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\Components\DataControllPanel\ControllPanelComponent.razor"
                                              true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "StartDate", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTimeOffset?>(
#nullable restore
#line 16 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\Components\DataControllPanel\ControllPanelComponent.razor"
                                                               StartDate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "EndDate", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTimeOffset?>(
#nullable restore
#line 16 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\Components\DataControllPanel\ControllPanelComponent.razor"
                                                                                   EndDate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "OnRangeSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorDateRangePicker.DateRange>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorDateRangePicker.DateRange>(this, 
#nullable restore
#line 16 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\Components\DataControllPanel\ControllPanelComponent.razor"
                                                                                                           DateRangeUpdated

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "dropdown");
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenComponent<TemperatureModule.Webpage.Components.DataControllPanel.Dropdown.DropdownFilterComponent>(19);
            __builder.AddAttribute(20, "Tip", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\Components\DataControllPanel\ControllPanelComponent.razor"
                                           dropdownTip

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "Filters", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<System.String>>(
#nullable restore
#line 18 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\Components\DataControllPanel\ControllPanelComponent.razor"
                                                                 filterList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "SelectUpdated", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<TemperatureModule.Webpage.Models.FilterEnum>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<TemperatureModule.Webpage.Models.FilterEnum>(this, 
#nullable restore
#line 18 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\Components\DataControllPanel\ControllPanelComponent.razor"
                                                                                            FilterUpdated

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\Components\DataControllPanel\ControllPanelComponent.razor"
       

    [Parameter]
    public EventCallback<DateRange> DateUpdated { get; set; }

    public DateTimeOffset? StartDate { get; set; } = DateTime.Now;

    public DateTimeOffset? EndDate { get; set; }

    private List<string> filterList = new List<string> { "Today", "Yesterday", "3 days", "1 week", "2 weeks", "1 month", "3 months", "1 year" };

    private string dropdownTip { get; set; }

    public async Task FilterUpdated(FilterEnum filter)
    {
        dropdownTip = filterList[(int)filter];

        var range = FilterEnumHelper.GetDateRange(filter);
        StartDate = range.Start;
        EndDate = range.End;

        await DateUpdated.InvokeAsync(range);
    }

    public async Task DateRangeUpdated(DateRange range)
    {
        dropdownTip = "Custom date";
        StartDate = range.Start;
        EndDate = range.End;

        await DateUpdated.InvokeAsync(range);
    }

    protected override void OnInitialized()
    {
        dropdownTip = filterList[0];
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
