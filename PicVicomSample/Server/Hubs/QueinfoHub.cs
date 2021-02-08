using Microsoft.AspNetCore.SignalR;
using PicVicomSample.Server.Models;
using PicVicomSample.Server.StreamingClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PicVicomSample.Server.Hubs
{
    public class QueinfoHub : Hub
    {
        public async Task SendQueInfo(int roomId)
        {
            if (!Streaming.Instance.StreamingQue.ContainsKey(roomId))
            {
                await Streaming.Instance.AddRoom(roomId);
            }
        }
    }
}
