using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TestUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            List<VideoSubtitler.SubtitleClass> subs = new List<VideoSubtitler.SubtitleClass>();
            for (double i = 0; i < 100; i++) {
                subs.Add(new VideoSubtitler.SubtitleClass { Content = i.ToString(), BeginTime = TimeSpan.FromSeconds(i), EndTime = TimeSpan.FromSeconds(i + 0.9) });
            }

            string json=JsonConvert.SerializeObject(subs);
            Console.WriteLine(json);
            Console.ReadLine();

            var des = JsonConvert.DeserializeObject<List<VideoSubtitler.SubtitleClass>>(json);
            foreach (VideoSubtitler.SubtitleClass sub in des) {
                Console.WriteLine(JsonConvert.SerializeObject(sub));
            }

            Console.ReadLine();
        }
    }
}
