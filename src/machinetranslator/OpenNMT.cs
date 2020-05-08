using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.machinetranslator
{
    public class OpenNMT
    {
        public string n_best { get; set; }
        public string pred_score { get; set; }
        public string src { get; set; }
        public string tgt { get; set; }
    }
}
