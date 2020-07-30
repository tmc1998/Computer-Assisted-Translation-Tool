using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.TM
{
    public class tmonline
    {
        public bool is_success { get; set; }
        public string err_msg { get; set; }
        public List<resultTMOnline> result { get; set; }
    }
    public class resultTMOnline
    {
        public string src_sentence { get; set; }
        public string tar_sentence { get; set; }
        public float similarity { get; set; }
    }
}
