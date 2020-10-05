#pragma checksum "/home/dcox/Documents/ClCalc/Pages/CompondInterest.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e8a9abac23523f7d88389e0e01a055a0d38eacb"
// <auto-generated/>
#pragma warning disable 1591
namespace ClCalc.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/dcox/Documents/ClCalc/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/dcox/Documents/ClCalc/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/dcox/Documents/ClCalc/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/dcox/Documents/ClCalc/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/dcox/Documents/ClCalc/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/dcox/Documents/ClCalc/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/dcox/Documents/ClCalc/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/dcox/Documents/ClCalc/_Imports.razor"
using ClCalc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/dcox/Documents/ClCalc/_Imports.razor"
using ClCalc.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/compoundinterest")]
    public partial class CompondInterest : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Compound Interest</h1>\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table");
            __builder.AddMarkupContent(3, "\n");
            __builder.OpenElement(4, "tr");
            __builder.AddMarkupContent(5, "\n    ");
            __builder.AddMarkupContent(6, "<th>Initial Principal</th>\n    ");
            __builder.OpenElement(7, "th");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 6 "/home/dcox/Documents/ClCalc/Pages/CompondInterest.razor"
                      Principal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Principal = __value, Principal));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n");
            __builder.OpenElement(13, "tr");
            __builder.AddMarkupContent(14, "\n    ");
            __builder.AddMarkupContent(15, "<th>Years</th>\n    ");
            __builder.OpenElement(16, "th");
            __builder.OpenElement(17, "input");
            __builder.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "/home/dcox/Documents/ClCalc/Pages/CompondInterest.razor"
                      Years

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Years = __value, Years));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n");
            __builder.OpenElement(22, "tr");
            __builder.AddMarkupContent(23, "\n    ");
            __builder.AddMarkupContent(24, "<th>Annual Interest Rate (%)</th>\n    ");
            __builder.OpenElement(25, "th");
            __builder.OpenElement(26, "input");
            __builder.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "/home/dcox/Documents/ClCalc/Pages/CompondInterest.razor"
                      InterestRate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => InterestRate = __value, InterestRate));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n");
            __builder.OpenElement(31, "tr");
            __builder.AddMarkupContent(32, "\n    ");
            __builder.AddMarkupContent(33, "<th>Total:</th>\n    ");
            __builder.OpenElement(34, "th");
            __builder.AddContent(35, 
#nullable restore
#line 18 "/home/dcox/Documents/ClCalc/Pages/CompondInterest.razor"
         Total

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\n");
            __builder.OpenElement(38, "button");
            __builder.AddAttribute(39, "class", "btn btn-primary");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "/home/dcox/Documents/ClCalc/Pages/CompondInterest.razor"
                                          Calculate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(41, "Calculate");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "/home/dcox/Documents/ClCalc/Pages/CompondInterest.razor"
 
    private double Principal { get; set; } = 5000;
    private double InterestRate { get; set; } = 5;
    private int Years { get; set; } = 10;
    private double total { get; set; } = 0;
    private string Total { get; set; }

    private void Calculate()
    {
        var total = Principal * Math.Pow(1 + InterestRate / (1200.0), Years * 12);
        Total = "a" + total.ToString("C");

    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
