using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xabe.FFmpeg;

namespace PicVicomSample.Server.StreamingClass
{
    public class StreamingFFmpeg
    {
        public StreamingInfo Info { get; set; }
        public bool IsStreaming { get; private set; } = false;
        public string FFmpegCommand { get; private set; } = string.Empty;
        public CancellationTokenSource CancelToken { get; private set; } = new CancellationTokenSource();

        public async Task DoStreaming()
        {
            IsStreaming = true;
            if (CancelToken == null)
            {
                CancelToken = new CancellationTokenSource();
            }

            try
            {
                var con = FFmpeg.Conversions.New();

                //StreamingCommand = @$"-re -i C:\samplevideo/{filename} -map 0 -c:v copy -c:a copy -f flv rtmp://pickvideocommunication.icu:1935/{roomid}/stream";

                //테스트용 코드
                FFmpegCommand = @$"-re -i C:\samplevideo/{Info.FileName} -map 0 -c:v copy -c:a copy -f flv rtmp://pickvideocommunication.icu:1935/test/stream";

                await con.Start(FFmpegCommand, CancelToken.Token);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                IsStreaming = false;
                Info = null;
            }
        }
        public async Task<bool> StopStreaming()
        {
            if (!IsStreaming)
            {
                return false;
            }
            CancelToken.Cancel();
            IsStreaming = false;
            return true;
        }
        
    }
}
