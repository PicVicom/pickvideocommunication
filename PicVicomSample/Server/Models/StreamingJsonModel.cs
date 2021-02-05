using PicVicomSample.Server.StreamingClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PicVicomSample.Server.Models
{
    public class StreamingQueInfo
    {
        public StreamingQueInfo(Queue<StreamingInfo> que)
        {
            Count = que.Count;
            Infos = que.ToArray();
        }

        public int Count { get; set; }
        public IEnumerable<StreamingInfo> Infos { get; set; }
    }
}
