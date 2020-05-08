using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using src.Files;
using src.segment;
using src.TM;

namespace src.processing
{
    public class txtProc
    {
        //private char[] delimiters = { '.', '?', '\n', ':', '\r', '\t', '\a', '\f' };
        public string readTxtFile(string path)
        {
            try
            {
                string content = File.ReadAllText(path);
                return content; 
            }
            catch (Exception)
            {
                return null; 
            }
        }
        public List<Segment> splitTxtContentToSegment(string content, char[] delimiters)
        {
            var parts = new List<Segment>();
            if (!string.IsNullOrEmpty(content))
            {
                int iFirst = 0;
                do
                {
                    int iLast = content.IndexOfAny(delimiters, iFirst);
                    if (iLast >= 0)
                    {
                        if (iLast > iFirst)
                            if (iLast != iFirst)
                            {
                                string str1 = content.Substring(iFirst, iLast - iFirst + 1).Trim();
                                tm tm1 = new tm();
                                tm1.Source = str1;
                                Segment tmp1 = new Segment();
                                tmp1.setTM(tm1); 
                                parts.Add(tmp1);
                            }
                        iFirst = iLast + 1;
                        continue;
                    }
                    string str = content.Substring(iFirst, content.Length - iFirst).Trim();
                    tm tm = new tm();
                    tm.Source = str; 
                    Segment tmp = new Segment();
                    tmp.setTM(tm); 
                    parts.Add(tmp);
                    break;

                } while (iFirst < content.Length);
            }

            return parts;
        }
        public string ReplaceFirst(string text, string search, string replace)
        {
            int pos = text.IndexOf(search);
            if (pos < 0)
            {
                return text;
            }
            return text.Substring(0, pos) + replace + text.Substring(pos + search.Length);
        }
    }
}
