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
#line 1 "C:\Users\dnfls\OneDrive\바탕 화면\PicVicomSample\PicVicomSample\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dnfls\OneDrive\바탕 화면\PicVicomSample\PicVicomSample\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dnfls\OneDrive\바탕 화면\PicVicomSample\PicVicomSample\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dnfls\OneDrive\바탕 화면\PicVicomSample\PicVicomSample\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\dnfls\OneDrive\바탕 화면\PicVicomSample\PicVicomSample\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\dnfls\OneDrive\바탕 화면\PicVicomSample\PicVicomSample\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\dnfls\OneDrive\바탕 화면\PicVicomSample\PicVicomSample\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\dnfls\OneDrive\바탕 화면\PicVicomSample\PicVicomSample\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\dnfls\OneDrive\바탕 화면\PicVicomSample\PicVicomSample\Client\_Imports.razor"
using PicVicomSample.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\dnfls\OneDrive\바탕 화면\PicVicomSample\PicVicomSample\Client\_Imports.razor"
using PicVicomSample.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\dnfls\OneDrive\바탕 화면\PicVicomSample\PicVicomSample\Client\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\dnfls\OneDrive\바탕 화면\PicVicomSample\PicVicomSample\Client\_Imports.razor"
using BlazorStrap;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dnfls\OneDrive\바탕 화면\PicVicomSample\PicVicomSample\Client\Shared\RedirectToLogin.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
    public partial class RedirectToLogin : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "C:\Users\dnfls\OneDrive\바탕 화면\PicVicomSample\PicVicomSample\Client\Shared\RedirectToLogin.razor"
       
    protected override void OnInitialized()
    {
        Navigation.NavigateTo($"authentication/login?returnUrl={Uri.EscapeDataString(Navigation.Uri)}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
    }
}
#pragma warning restore 1591
