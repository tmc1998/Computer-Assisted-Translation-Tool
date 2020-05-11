using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.machinetranslator
{
    public class urlAPI
    {
        public class Mymemory
        {
            public string urlTranslatorMymemory = @"https://api.mymemory.translated.net/get?q={0}&langpair={1}|{2}";
            public string urlSetMymemory = @"https://api.mymemory.translated.net/set?seg={0}!&tra={1}!&langpair={2}|{3}";
        }
        public class openNMT
        {
            public string urlTranslatorOpenNMT = "http://127.0.0.1:5000/translator/";
        }
        public class semanticSimilarity
        {
            public string urlSemanticSimilarity = "http://127.0.0.1:3000/";
        }
    }
}
