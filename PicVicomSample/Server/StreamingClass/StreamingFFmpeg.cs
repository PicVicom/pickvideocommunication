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
        public bool IsStreaming { get; set; } = false;
        public string FileBaseFolder { get; set; } = @"C:\samplevideo";
        public string FFmpegCommand { get; private set; } = string.Empty;
        public CancellationTokenSource CancelToken { get; private set; }

        public async Task DoStreaming(string streamingType)
        {
            try
            {
                CancelToken = new CancellationTokenSource();
                var con = FFmpeg.Conversions.New();
                FFmpegCommand = @$"-re -i {FileBaseFolder}/{Info.FileName} -map 0 -c:v copy -c:a copy -f flv rtmp://pickvideocommunication.icu:1935/{streamingType}/stream";

                await con.Start(FFmpegCommand, CancelToken.Token);
            }
            catch
            {
                return;
            }
            finally
            {
                Info = null;
            }
        }

        public bool StopStreaming()
        {
            if (!IsStreaming)
            {
                return false;
            }

            try
            {
                CancelToken.Cancel();
                return true;
            }
            catch
            {
                return false;
            }
        }
        
    }
}
