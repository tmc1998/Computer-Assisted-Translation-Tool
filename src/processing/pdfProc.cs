using src.segment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using src.TM;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser; 

namespace src.processing
{
    public class pdfProc
    {
        private char[] delimitersPDF = { '.', '?', ':', '\r', '\t', '\a', '\f' };
        public List<string> readPdfFile(string path)
        {
            List<string> result = new List<string>(); 
            try
            {
                using (PdfReader reader = new PdfReader(path))
                {
                    for (int i = 1; i <= reader.NumberOfPages; i++)
                    {
                        string content; 
                        content = PdfTextExtractor.GetTextFromPage(reader, i);
                        result.Add(content); 
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Open file fail"); 
            }
            return result; 
        }
        public List<Segment> splitTxtContentToSegment(string content, char[] delimiters, int page,string filename)
        {
            var parts = new List<Segment>();
            if (!string.IsNullOrEmpty(content))
            {
                int iFirst = 0;
                do
                {
                    int iLast = content.IndexOfAny(delimitersPDF, iFirst);
                    if (iLast >= 0)
                    {
                        if (iLast > iFirst)
                            if (iLast != iFirst)
                            {
                                string str1 = content.Substring(iFirst, iLast - iFirst + 1).Trim();
                                if (str1 != "")
                                {
                                    tm tm1 = new tm();
                                    tm1.Source = str1;
                                    Segment tmp1 = new Segment();
                                    tmp1.setTM(tm1);
                                    tmp1.setPage(page);
                                    tmp1.file = filename;
                                    parts.Add(tmp1);
                                }
                            }
                        iFirst = iLast + 1;
                        continue;
                    }
                    string str = content.Substring(iFirst, content.Length - iFirst).Trim();
                    if (str != "")
                    {
                        tm tm = new tm();
                        tm.Source = str;
                        Segment tmp = new Segment();
                        tmp.setTM(tm);
                        tmp.setPage(page);
                        tmp.file = filename;
                        parts.Add(tmp);
                    }
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
