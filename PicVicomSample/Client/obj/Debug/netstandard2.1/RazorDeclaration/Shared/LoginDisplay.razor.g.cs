#pragma checksum "F:\Blazor_Test\PicVicomGit\pickvideocommunication\PicVicomSample\Client\Shared\LoginDisplay.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1283ad696ce8d784574455de119ca2de09664a36"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PicVicomSample.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\Blazor_Test\PicVicomGit\pickvideocommunication\PicVicomSample\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Blazor_Test\PicVicomGit\pickvideocommunication\PicVicomSample\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Blazor_Test\PicVicomGit\pickvideocommunication\PicVicomSample\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Blazor_Test\PicVicomGit\pickvideocommunication\PicVicomSample\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Blazor_Test\PicVicomGit\pickvideocommunication\PicVicomSample\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\Blazor_Test\PicVicomGit\pickvideocommunication\PicVicomSample\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\Blazor_Test\PicVicomGit\pickvideocommunication\PicVicomSample\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\Blazor_Test\PicVicomGit\pickvideocommunication\PicVicomSample\Client\_Imports.razor"
using PicVicomSample.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\Blazor_Test\PicVicomGit\pickvideocommunication\PicVicomSample\Client\_Imports.razor"
using PicVicomSample.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "F:\Blazor_Test\PicVicomGit\pickvideocommunication\PicVicomSample\Client\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "F:\Blazor_Test\PicVicomGit\pickvideocommunication\PicVicomSample\Client\_Imports.razor"
using BlazorStrap;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "F:\Blazor_Test\PicVicomGit\pickvideocommunication\PicVicomSample\Client\Shared\LoginDisplay.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Blazor_Test\PicVicomGit\pickvideocommunication\PicVicomSample\Client\Shared\LoginDisplay.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
    public partial class LoginDisplay : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "F:\Blazor_Test\PicVicomGit\pickvideocommunication\PicVicomSample\Client\Shared\LoginDisplay.razor"
      
    private async Task BeginSignOut(MouseEventArgs args)
    {
        await SignOutManager.SetSignOutState();
        Navigation.NavigateTo("authentication/logout");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SignOutSessionStateManager SignOutManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
    }
}
#pragma warning restore 1591
