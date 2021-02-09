using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using PicVicomSample.Server.Hubs;
using PicVicomSample.Server.Models;
using PicVicomSample.Server.StreamingClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PicVicomSample.Server.Controllers
{
    [Route("upload")]
    [ApiController]
    public class UploadFileController : ControllerBase
    {
        private readonly IHubContext<QueinfoHub> _hubContext;

        public UploadFileController(IHubContext<QueinfoHub> hubContext)
        {
            _hubContext = hubContext;
        }
        [HttpPost("video/{roomid}/{owner}")]
        public async Task<IActionResult> Video(IFormFile file, int roomid, string owner)
        {
            var ismusic = false;
            try
            {
                var f = new UploadFIle(file, ismusic);
                if (f.CheckIfExcelFile())
                {
                    await f.WriteFile();
                }

                var streaminginfo = new StreamingInfo { FileName = f.Name, Owner = owner, RoomID = roomid, FileOgName = f.OriginalName };

                if (!Streaming.Instance.StreamingQue.ContainsKey(streaminginfo.RoomID))
                {
                    await Streaming.Instance.AddRoom(streaminginfo.RoomID);
                }

                Streaming.Instance.EnQue(streaminginfo.RoomID, streaminginfo, ismusic);

                var info = new StreamingQueInfo(Streaming.Instance.StreamingQue[roomid]);
                await _hubContext.Clients.Group($"{roomid}").SendAsync("StreamingQueInfo", info);

                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost("music/{roomid}/{owner}")]
        public async Task<IActionResult> Music(IFormFile file, int roomid, string owner)
        {
            var ismusic = true;
            try
            {
                var f = new UploadFIle(file, ismusic);
                if (f.CheckIfExcelFile())
                {
                    await f.WriteFile();
                }

                var streaminginfo = new StreamingInfo { FileName = f.Name, Owner = owner, RoomID = roomid, FileOgName = f.OriginalName };

                if (!Streaming.Instance.StreamingQue.ContainsKey(streaminginfo.RoomID))
                {
                    await Streaming.Instance.AddRoom(streaminginfo.RoomID);
                }

                Streaming.Instance.EnQue(streaminginfo.RoomID, streaminginfo, ismusic);

                var info = new StreamingQueInfo(Streaming.Instance.StreamingQue[roomid]);
                await _hubContext.Clients.Group($"{roomid}").SendAsync("StreamingQueInfo", info);

                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
