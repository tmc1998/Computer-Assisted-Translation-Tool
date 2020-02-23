using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.segment
{
    public class Segment
    {
        private string value; 
        public void setValue(string str)
        {
            value = str; 
        }
        public string getValue()
        {
            return value; 
        }
    }
}
