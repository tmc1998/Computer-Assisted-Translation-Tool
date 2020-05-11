using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.semanticsimilarity
{
    class semanticSimilarityPost
    {
        public string text { get; set; }
        public List<segment> data { get; set; }
        public class segment
        {
            public string src { get; set; }
            public string tag { get; set; }
        }
    }
}
