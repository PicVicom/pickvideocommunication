#pragma checksum "C:\Users\son20\pickvideocommunication\PicVicomSample\Client\Pages\Chat.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d49bacbe8775877c85059d1d6aeb9300c504442"
// <auto-generated/>
#pragma warning disable 1591
namespace PicVicomSample.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\son20\pickvideocommunication\PicVicomSample\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\son20\pickvideocommunication\PicVicomSample\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\son20\pickvideocommunication\PicVicomSample\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\son20\pickvideocommunication\PicVicomSample\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\son20\pickvideocommunication\PicVicomSample\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\son20\pickvideocommunication\PicVicomSample\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\son20\pickvideocommunication\PicVicomSample\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\son20\pickvideocommunication\PicVicomSample\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\son20\pickvideocommunication\PicVicomSample\Client\_Imports.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\son20\pickvideocommunication\PicVicomSample\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\son20\pickvideocommunication\PicVicomSample\Client\_Imports.razor"
using PicVicomSample.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\son20\pickvideocommunication\PicVicomSample\Client\_Imports.razor"
using PicVicomSample.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\son20\pickvideocommunication\PicVicomSample\Client\_Imports.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\son20\pickvideocommunication\PicVicomSample\Client\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\son20\pickvideocommunication\PicVicomSample\Client\_Imports.razor"
using BlazorStrap;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\son20\pickvideocommunication\PicVicomSample\Client\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\son20\pickvideocommunication\PicVicomSample\Client\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/chat")]
    public partial class Chat : Microsoft.AspNetCore.Components.ComponentBase, IAsyncDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "form-group");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "label");
            __builder.AddMarkupContent(4, "\r\n        ");
            __builder.AddContent(5, 
#nullable restore
#line 10 "C:\Users\son20\pickvideocommunication\PicVicomSample\Client\Pages\Chat.razor"
         UserId

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(6, " >>\r\n        ");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "size", "50");
            __builder.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "C:\Users\son20\pickvideocommunication\PicVicomSample\Client\Pages\Chat.razor"
                      messageInput

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => messageInput = __value, messageInput));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\son20\pickvideocommunication\PicVicomSample\Client\Pages\Chat.razor"
                  Send

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "disabled", 
#nullable restore
#line 14 "C:\Users\son20\pickvideocommunication\PicVicomSample\Client\Pages\Chat.razor"
                                    !IsConnected

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(17, "전송");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\r\n<hr>\r\n\r\n");
            __builder.OpenElement(19, "ul");
            __builder.AddAttribute(20, "id", "messagesList");
            __builder.AddMarkupContent(21, "\r\n");
#nullable restore
#line 19 "C:\Users\son20\pickvideocommunication\PicVicomSample\Client\Pages\Chat.razor"
     foreach (var message in messages)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(22, "        ");
            __builder.OpenElement(23, "li");
            __builder.AddContent(24, 
#nullable restore
#line 21 "C:\Users\son20\pickvideocommunication\PicVicomSample\Client\Pages\Chat.razor"
             message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n");
#nullable restore
#line 22 "C:\Users\son20\pickvideocommunication\PicVicomSample\Client\Pages\Chat.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "C:\Users\son20\pickvideocommunication\PicVicomSample\Client\Pages\Chat.razor"
        
    [Parameter]
    public int RoomID { get; set; }

    [Parameter]
    public string UserId { get; set; }

    private HubConnection hubConnection;
    private List<string> messages = new List<string>();
    private string messageInput;


    #region 채팅
    Task Send() =>
        hubConnection.SendAsync("SendMessage", UserId, messageInput);

    public bool IsConnected =>
        hubConnection.State == HubConnectionState.Connected;

    public async ValueTask DisposeAsync()
    {
        await hubConnection.DisposeAsync();
    }
    #endregion


    protected override async Task OnInitializedAsync()
    {
        hubConnection = new HubConnectionBuilder()
        .WithUrl(NavigationManager.ToAbsoluteUri("/chathub"))
        .Build();

        hubConnection.On<string, string>("ReceiveMessage", (user, message) =>
        {
            var encodedMsg = $"{user}: {message}";
            messages.Add(encodedMsg);
            StateHasChanged();
        });

        await hubConnection.StartAsync();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SignOutSessionStateManager SignOutManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
