#pragma checksum "/home/yeghon/Documents/projects/c#/blazerApp1/Pages/Sample.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2e4a1ee51fbd6f971606fdb892ecd56d48cf6b1"
// <auto-generated/>
#pragma warning disable 1591
namespace blazerApp1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/yeghon/Documents/projects/c#/blazerApp1/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/yeghon/Documents/projects/c#/blazerApp1/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/yeghon/Documents/projects/c#/blazerApp1/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/yeghon/Documents/projects/c#/blazerApp1/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/yeghon/Documents/projects/c#/blazerApp1/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/yeghon/Documents/projects/c#/blazerApp1/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/yeghon/Documents/projects/c#/blazerApp1/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/yeghon/Documents/projects/c#/blazerApp1/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/yeghon/Documents/projects/c#/blazerApp1/_Imports.razor"
using blazerApp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/yeghon/Documents/projects/c#/blazerApp1/_Imports.razor"
using blazerApp1.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/sample")]
    public partial class Sample : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Counter</h1>\n\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Current count: ");
            __builder.AddContent(3, 
#nullable restore
#line 5 "/home/yeghon/Documents/projects/c#/blazerApp1/Pages/Sample.razor"
                   currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\n\n");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "btn btn-warn");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "/home/yeghon/Documents/projects/c#/blazerApp1/Pages/Sample.razor"
                                       IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "Click us");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "/home/yeghon/Documents/projects/c#/blazerApp1/Pages/Sample.razor"
       
    private int currentCount = 0;

    private void IncrementCount()
    {
        currentCount++;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
