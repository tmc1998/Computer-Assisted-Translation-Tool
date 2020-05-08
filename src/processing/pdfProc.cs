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
        public List<Segment> splitTxtContentToSegment(string content, char[] delimiters, int page)
        {
            var parts = new List<Segment>();
            if (!string.IsNullOrEmpty(content))
            {
                int iFirst = 0;
                do
                {
                    int iLast = content.IndexOfAny(delimiters, iFirst);
                    if (content[iLast] != '\n' && content[iLast + 1] != '\n')
                    {
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
                                        parts.Add(tmp1);
                                    }
                                }
                            iFirst = iLast + 1;
                            continue;
                        }
                    }
                    string str = content.Substring(iFirst, content.Length - iFirst).Trim();
                    if (str != "")
                    {
                        tm tm = new tm();
                        tm.Source = str;
                        Segment tmp = new Segment();
                        tmp.setTM(tm);
                        tmp.setPage(page);
                        parts.Add(tmp);
                    }
                    break;

                } while (iFirst < content.Length);
            }

            return parts;
        }
    }
}
