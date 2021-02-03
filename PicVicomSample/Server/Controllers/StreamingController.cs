using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PicVicomSample.Server.StreamingClass;
using PicVicomSample.Server.Models;

namespace PicVicomSample.Server.Controllers
{
    [Route("streaming")]
    [ApiController]
    public class StreamingController : ControllerBase
    {
        [HttpGet("{roomId}")]
        public async Task<StreamingQueInfo> GetStreamingQueInfo(int roomId)
        {
            if (!Streaming.Instance.StreamingQue.ContainsKey(roomId))
            {
                await Streaming.Instance.AddRoom(roomId);
            }
            return new StreamingQueInfo(Streaming.Instance.StreamingQue[roomId]);
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

        [HttpPost("enque")]
        public async Task EnQue(StreamingInfo f)
        {
            if (!Streaming.Instance.StreamingQue.ContainsKey(f.RoomID))
            {
                await Streaming.Instance.AddRoom(f.RoomID);
            }
            Streaming.Instance.EnQue(f.RoomID, f);
        }

        [HttpPost("dostreaming/{roomId}")]
        public async Task<IActionResult> DoStreaming(int roomId)
        {
            if (Streaming.Instance.IsStreaming(roomId))
            {
                return BadRequest();
            }

            var info = Streaming.Instance.DeQue(roomId);
            if (info == null)
            {
                return NotFound();
            }

            Streaming.Instance.DoStreaming(roomId, info);
            return Ok();
        }

    }
}
