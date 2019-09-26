using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoSubtitler
{
    public class SubtitleClass
    {
        public SubtitleClass(string content, TimeSpan beginTime, TimeSpan endTime)
        {
            Content = content;
            BeginTime = beginTime;
            EndTime = endTime;
        }

        public string Content { get; set; }
        public TimeSpan BeginTime { get ;set; }
        public TimeSpan EndTime { get; set; }
    }
}
