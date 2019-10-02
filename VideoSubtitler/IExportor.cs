using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoSubtitler
{
    public interface IExportor
    {
        void Export(IEnumerable<SubtitleClass> subs,string path);
    }
}
