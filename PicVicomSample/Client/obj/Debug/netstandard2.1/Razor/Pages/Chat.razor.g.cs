#pragma checksum "F:\Blazor_Test\PicVicomGit\pickvideocommunication\PicVicomSample\Client\Pages\Chat.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61f4ed995133c9ec4ea53d14f35d36515a142ecc"
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
#line 3 "F:\Blazor_Test\PicVicomGit\pickvideocommunication\PicVicomSample\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

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
#line 2 "F:\Blazor_Test\PicVicomGit\pickvideocommunication\PicVicomSample\Client\Pages\Chat.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Chat")]
    public partial class Chat : Microsoft.AspNetCore.Components.ComponentBase, IAsyncDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "form-group");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "label");
            __builder.AddMarkupContent(4, "\r\n        User:\r\n        ");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "F:\Blazor_Test\PicVicomGit\pickvideocommunication\PicVicomSample\Client\Pages\Chat.razor"
                      userInput

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => userInput = __value, userInput));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "form-group");
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "label");
            __builder.AddMarkupContent(15, "\r\n        Message:\r\n        ");
            __builder.OpenElement(16, "input");
            __builder.AddAttribute(17, "size", "50");
            __builder.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "F:\Blazor_Test\PicVicomGit\pickvideocommunication\PicVicomSample\Client\Pages\Chat.razor"
                      messageInput

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => messageInput = __value, messageInput));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
            __builder.OpenElement(23, "button");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "F:\Blazor_Test\PicVicomGit\pickvideocommunication\PicVicomSample\Client\Pages\Chat.razor"
                  Send

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "disabled", 
#nullable restore
#line 18 "F:\Blazor_Test\PicVicomGit\pickvideocommunication\PicVicomSample\Client\Pages\Chat.razor"
                                    !IsConnected

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(26, "Send");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n\r\n<hr>\r\n\r\n");
            __builder.OpenElement(28, "ul");
            __builder.AddAttribute(29, "id", "messagesList");
            __builder.AddMarkupContent(30, "\r\n");
#nullable restore
#line 23 "F:\Blazor_Test\PicVicomGit\pickvideocommunication\PicVicomSample\Client\Pages\Chat.razor"
     foreach (var message in messages)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(31, "        ");
            __builder.OpenElement(32, "li");
            __builder.AddContent(33, 
#nullable restore
#line 25 "F:\Blazor_Test\PicVicomGit\pickvideocommunication\PicVicomSample\Client\Pages\Chat.razor"
             message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
#nullable restore
#line 26 "F:\Blazor_Test\PicVicomGit\pickvideocommunication\PicVicomSample\Client\Pages\Chat.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "F:\Blazor_Test\PicVicomGit\pickvideocommunication\PicVicomSample\Client\Pages\Chat.razor"
       
    private HubConnection hubConnection;
    private List<string> messages = new List<string>();
    private string userInput;
    private string messageInput;

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

    Task Send() =>
        hubConnection.SendAsync("SendMessage", userInput, messageInput);

    public bool IsConnected =>
        hubConnection.State == HubConnectionState.Connected;

    public async ValueTask DisposeAsync()
    {
        await hubConnection.DisposeAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
