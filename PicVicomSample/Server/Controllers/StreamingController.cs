using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PicVicomSample.Server.StreamingClass;
using PicVicomSample.Server.Models;
using PicVicomSample.Server.Hubs;
using Microsoft.AspNetCore.SignalR;

namespace PicVicomSample.Server.Controllers
{
    [Route("streaming")]
    [ApiController]
    public class StreamingController : ControllerBase
    {
        private readonly IHubContext<QueinfoHub> _hubContext;

        public StreamingController(IHubContext<QueinfoHub> hubContext)
        {
            _hubContext = hubContext;
        }

        [HttpPost("{roomId}")]
        public async Task GetStreamingQueInfo(int roomId)
        {
            if (!Streaming.Instance.StreamingQue.ContainsKey(roomId))
            {
                await Streaming.Instance.AddRoom(roomId);
            }
            await _hubContext.Clients.All.SendAsync("StreamingQueInfo", new StreamingQueInfo(Streaming.Instance.StreamingQue[roomId]));
        }

        [HttpGet("isstreaming/{roomId}")]
        public bool IsStreaming(int roomId)
        {
            if (!Streaming.Instance.StreamingQue.ContainsKey(roomId))
            {
                return false;
            }
            return Streaming.Instance.IsStreaming(roomId);
        }

        [HttpGet("streaminginfo/{roomId}")]
        public StreamingInfo GetStreamingInfo(int roomId)
        {
            if (!Streaming.Instance.RoomFFmpeg.ContainsKey(roomId))
            {
                return null;
            }
            return Streaming.Instance.RoomFFmpeg[roomId].Info;
        }

    }
}
