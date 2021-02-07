using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        [HttpPost("{roomid}/{owner}")]
        public async Task<IActionResult> Single(IFormFile file, int roomid, string owner)
        {
            try
            {
                var f = new UploadFIle(file);
                if (f.CheckIfExcelFile())
                {
                    await f.WriteFile();
                }

                var streaminginfo = new StreamingInfo { FileName = f.Name, Owner = owner, RoomID = roomid };

                if (!Streaming.Instance.StreamingQue.ContainsKey(streaminginfo.RoomID))
                {
                    await Streaming.Instance.AddRoom(streaminginfo.RoomID);
                }

                Streaming.Instance.EnQue(streaminginfo.RoomID, streaminginfo);

                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
