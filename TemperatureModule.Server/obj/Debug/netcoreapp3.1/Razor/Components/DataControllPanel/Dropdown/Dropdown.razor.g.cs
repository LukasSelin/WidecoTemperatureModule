#pragma checksum "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\Components\DataControllPanel\Dropdown\Dropdown.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "293024dc96555b4ad78eaf341f4366c27470cb22"
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
    public partial class Dropdown<TItem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "dropdown");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "button");
            __builder.AddAttribute(4, "class", "btn btn-primary dropdown-toggle dropdownTest");
            __builder.AddAttribute(5, "data-toggle", "dropdown");
            __builder.AddAttribute(6, "type", "button");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\Components\DataControllPanel\Dropdown\Dropdown.razor"
                                                                                                                e => this.show=!this.show 

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "aria-haspopup", "true");
            __builder.AddAttribute(9, "aria-expanded", "false");
            __builder.AddAttribute(10, "style", "padding-top: 2px; height: 30px; background-color: #222823; border-color: #222823 ;color: #c5c6c7");
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "span");
            __builder.AddContent(13, 
#nullable restore
#line 9 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\Components\DataControllPanel\Dropdown\Dropdown.razor"
               Tip

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n    ");
            __Blazor.TemperatureModule.Webpage.Components.DataControllPanel.Dropdown.Dropdown.TypeInference.CreateCascadingValue_0(__builder, 16, 17, "Dropdown", 18, 
#nullable restore
#line 11 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\Components\DataControllPanel\Dropdown\Dropdown.razor"
                                            this

#line default
#line hidden
#nullable disable
            , 19, (__builder2) => {
                __builder2.AddMarkupContent(20, "\r\n        ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "dropdown-menu" + " " + (
#nullable restore
#line 12 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\Components\DataControllPanel\Dropdown\Dropdown.razor"
                                    show? "show":""

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(23, "\r\n            ");
                __builder2.AddContent(24, 
#nullable restore
#line 13 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\Components\DataControllPanel\Dropdown\Dropdown.razor"
             ChildContent

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(25, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n    ");
            }
            );
            __builder.AddMarkupContent(27, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\lukse\source\repos\TempraturModul\TemperatureModule.Server\Components\DataControllPanel\Dropdown\Dropdown.razor"
       
    [Parameter]
    public RenderFragment ChildContent { get; set; }

    [Parameter]
    public EventCallback<TItem> OnSelected { get; set; }

    [Parameter]
    public RenderFragment Tip { get; set; }

    private bool show = false;

    public async Task HandleSelect(TItem item, RenderFragment<TItem> contentFragment)
    {
        this.Tip = contentFragment.Invoke(item);
        this.show = false;
        StateHasChanged();
        await this.OnSelected.InvokeAsync(item);
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.TemperatureModule.Webpage.Components.DataControllPanel.Dropdown.Dropdown
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "name", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ChildContent", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
