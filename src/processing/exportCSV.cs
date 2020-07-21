using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using src.TM;
using System.IO; 

namespace src.processing
{
    public class exportCSV
    {
        public void exportTM(string path,List<tm> tmData,string srcLang,string srcTag)
        {
            StringBuilder csvcontent = new StringBuilder();
            var firstLine = string.Format("{0},{1}", srcLang, srcTag);
            csvcontent.AppendLine(firstLine);
            foreach (var tm in tmData)
            {
                var newLine = string.Format("{0},{1}", "\"" + tm.Source + "\"", "\"" + tm.Target + "\"");
                csvcontent.AppendLine(newLine);
            }
            File.AppendAllText(path, csvcontent.ToString(), Encoding.UTF8); 
        }
    }
}
