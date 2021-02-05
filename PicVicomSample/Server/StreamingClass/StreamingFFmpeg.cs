﻿using System;
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

        public async Task DoStreaming()
        {
            try
            {
                CancelToken = new CancellationTokenSource();
                var con = FFmpeg.Conversions.New();

                //StreamingCommand = @$"-re -i {FileBaseFolder}/{filename} -map 0 -c:v copy -c:a copy -f flv rtmp://pickvideocommunication.icu:1935/{roomid}/stream";

                //테스트용 코드
                FFmpegCommand = @$"-re -i {FileBaseFolder}/{Info.FileName} -map 0 -c:v copy -c:a copy -f flv rtmp://pickvideocommunication.icu:1935/test/stream";

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
        public async Task<bool> StopStreaming()
        {
            if (!IsStreaming)
            {
                return false;
            }
            CancelToken.Cancel();
            return true;
        }
        
    }
}