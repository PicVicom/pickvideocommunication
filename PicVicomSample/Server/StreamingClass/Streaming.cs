using PicVicomSample.Server.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PicVicomSample.Server.StreamingClass
{
    public class Streaming
    {
        #region 싱글톤
        //private 생성자 
        private Streaming() { httpclient.BaseAddress = baseurl; }
        //private static 인스턴스 객체
        private static readonly Lazy<Streaming> _instance = new Lazy<Streaming>(() => new Streaming());
        //public static 의 객체반환 함수
        public static Streaming Instance { get { return _instance.Value; } }
        #endregion

        public Dictionary<int, Queue<StreamingInfo>> StreamingQue { get; private set; } = new Dictionary<int, Queue<StreamingInfo>>();
        public Dictionary<int, StreamingFFmpeg> RoomFFmpeg { get; private set; } = new Dictionary<int, StreamingFFmpeg>();
        private HttpClient httpclient = new HttpClient();
        private Uri baseurl = new Uri("https://localhost:5001/");

        public bool IsStreaming(int roomID)
        {
            return RoomFFmpeg[roomID].IsStreaming;
        }

        public async Task AddRoom(int roomID)
        {
            StreamingQue.Add(roomID, new Queue<StreamingInfo>());
            RoomFFmpeg.Add(roomID, new StreamingFFmpeg());
        }
        public async Task EnQue(int roomID, StreamingInfo info, bool isMusic)
        {
            StreamingQue[roomID].Enqueue(info);
            DoStreaming(roomID, isMusic);
        }

        public StreamingInfo DeQue (int roomID)
        {
            StreamingInfo f;
            if (StreamingQue[roomID].TryDequeue(out f))
            {
                return f;
            }
            return null;
        }

        public async Task DoStreaming(int roomId, bool ismusic)
        {
            var s = RoomFFmpeg[roomId];
            if (s.IsStreaming)
            {
                return;
            }
            s.IsStreaming = true;
            while (true)
            {
                StreamingInfo info = DeQue(roomId);
                if (info == null)
                {
                    s.IsStreaming = false;
                    return;
                }
                s.Info = info;
                await httpclient.PostAsync(@$"streaming/{roomId}", null);
                if (ismusic)
                    await s.DoStreaming("musicstreaming");
                else
                    await s.DoStreaming("videostreaming");
                await Task.Delay(10);
            }
        }

        public bool StopStreaming(int roomID)
        {
            return RoomFFmpeg[roomID].StopStreaming();
        }
    }
}
