using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace BlazorSignalRApp.Server.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(int RoomId, string user, string message)
        {
            var rid = $"{RoomId}";
            await Clients.Group(rid).SendAsync("ReceiveMessage", user, message);
        }

        public async Task AddToGroup(int RoomId, string user)
        {
            var rid = $"{RoomId}";
            await Groups.AddToGroupAsync(Context.ConnectionId, rid);

            await Clients.Group(rid).SendAsync("Send", $"{user} has joined the group {RoomId}.");
        }
    }
}