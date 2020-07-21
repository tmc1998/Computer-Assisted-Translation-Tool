using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.machinetranslator
{
    public class machineTranslationResult
    {
        public string src { get; set; }
        public string tag { get; set; }
        public bool fail { get; set; } 
        public string failText { get; set; }
        public string type { get; set; }
        public float score { get; set; }

    }
}
