using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace src.TB
{
    public class tbProc
    {
        private string pathTB = @"TBDB\tb.txt";
        private char[] delimiterTB = { ':' };
        public string htmlStringStrong = "<strong>";
        public string htmlStringStrongEnd = "</strong>"; 
        public HashSet<tb> readTB()
        {
            HashSet<tb> dictionary = new HashSet<tb>();
            string pathRoot = (System.IO.Path.GetDirectoryName(Application.ExecutablePath));
            string path = Path.Combine(pathRoot, pathTB);
            foreach (string line in File.ReadLines(path))
            {
                tb tb = new tb();
                int iFirst = 0;
                int iLast = line.IndexOfAny(delimiterTB, iFirst);
                if (iLast >= 0)
                {
                    if (iLast > iFirst)
                        if (iLast != iFirst)
                        {
                            string str1 = line.Substring(iFirst, iLast - iFirst).Trim();
                            if (str1 != "")
                            {
                                tb.definition = str1;
                            }
                        }
                }
                string str = line.Substring(iLast + 1, line.Length - iLast - 1).Trim();
                if (str != "")
                {
                    tb.word = str;
                }
                dictionary.Add(tb);
            }
            return dictionary; 
            Console.WriteLine(dictionary.Count);
        }
        public string checkTBInSegment(HashSet<tb> dict,string source)
        {
            string word = source.ToLower();
            foreach (tb tb in dict)
            {
                string termbase = tb.word.ToLower();
                string match = String.Format(@"\b{0}\b", Regex.Escape(termbase));
                List<int> indeces = new List<int>();
                int tmp = 0;
                foreach (Match matched in Regex.Matches(word, match))
                {
                    tmp = 0; 
                    indeces.Add(matched.Index);
                }
                string check = null;
                int selectionlength = termbase.Length;
                foreach (int index in indeces)
                {
                    if (index >= 0)
                    {
                        int indx = tmp + index;
                        if (index - htmlStringStrong.Length >= 0)
                        {
                            check = source.Substring(indx - htmlStringStrong.Length, htmlStringStrong.Length);
                        }
                        if (String.Compare(check, htmlStringStrong) != 0)
                        {
                            source = source.Insert(indx, htmlStringStrong);
                            source = source.Insert(htmlStringStrong.Length + indx + selectionlength, htmlStringStrongEnd);
                            word = source.ToLower(); 
                            tmp += htmlStringStrong.Length + htmlStringStrongEnd.Length; 
                        }
                    }
                }

                //rtbDictionary.AppendText(String.Format("\n{0} : {1}", tb.word, tb.definition));

                //}
            }
            return source;
        }
    }
}
