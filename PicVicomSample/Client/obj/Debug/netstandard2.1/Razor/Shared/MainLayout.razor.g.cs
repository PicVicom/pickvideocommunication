#pragma checksum "C:\Users\dnfls\OneDrive\바탕 화면\새 폴더 (2)\pickvideocommunication-master\PicVicomSample\Client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d95d85665532a3b9368a72cbaf9a6105d85f7336"
// <auto-generated/>
#pragma warning disable 1591
namespace PicVicomSample.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\dnfls\OneDrive\바탕 화면\새 폴더 (2)\pickvideocommunication-master\PicVicomSample\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dnfls\OneDrive\바탕 화면\새 폴더 (2)\pickvideocommunication-master\PicVicomSample\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dnfls\OneDrive\바탕 화면\새 폴더 (2)\pickvideocommunication-master\PicVicomSample\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dnfls\OneDrive\바탕 화면\새 폴더 (2)\pickvideocommunication-master\PicVicomSample\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\dnfls\OneDrive\바탕 화면\새 폴더 (2)\pickvideocommunication-master\PicVicomSample\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\dnfls\OneDrive\바탕 화면\새 폴더 (2)\pickvideocommunication-master\PicVicomSample\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\dnfls\OneDrive\바탕 화면\새 폴더 (2)\pickvideocommunication-master\PicVicomSample\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\dnfls\OneDrive\바탕 화면\새 폴더 (2)\pickvideocommunication-master\PicVicomSample\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\dnfls\OneDrive\바탕 화면\새 폴더 (2)\pickvideocommunication-master\PicVicomSample\Client\_Imports.razor"
using PicVicomSample.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\dnfls\OneDrive\바탕 화면\새 폴더 (2)\pickvideocommunication-master\PicVicomSample\Client\_Imports.razor"
using PicVicomSample.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\dnfls\OneDrive\바탕 화면\새 폴더 (2)\pickvideocommunication-master\PicVicomSample\Client\_Imports.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\dnfls\OneDrive\바탕 화면\새 폴더 (2)\pickvideocommunication-master\PicVicomSample\Client\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\dnfls\OneDrive\바탕 화면\새 폴더 (2)\pickvideocommunication-master\PicVicomSample\Client\_Imports.razor"
using BlazorStrap;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\dnfls\OneDrive\바탕 화면\새 폴더 (2)\pickvideocommunication-master\PicVicomSample\Client\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\dnfls\OneDrive\바탕 화면\새 폴더 (2)\pickvideocommunication-master\PicVicomSample\Client\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\n    .navbar-brand{\n        color:black;\n    }\n</style>\n    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "main");
            __builder.AddMarkupContent(3, "\n        ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "top-row px-4 auth fixed-top");
            __builder.AddMarkupContent(6, "\n                ");
            __builder.AddMarkupContent(7, "<div>\n                    <a class=\"navbar-brand\" href>PicVicom</a>\n                </div>\n                ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "top-row px-4 auth");
            __builder.AddMarkupContent(10, "\n                    ");
            __builder.OpenComponent<PicVicomSample.Client.Shared.LoginDisplay>(11);
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n\n        ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "content px-4 container");
            __builder.AddMarkupContent(17, "\n            ");
            __builder.AddContent(18, 
#nullable restore
#line 19 "C:\Users\dnfls\OneDrive\바탕 화면\새 폴더 (2)\pickvideocommunication-master\PicVicomSample\Client\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(19, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
