using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using src.segment; 

namespace src.Files
{
    class file
    {
        private string filePath;
        private string extexsionFile = "txt files|*.txt|All files|*.*";
        private string extexsion;
        private char[] delimiters = { '.', '?', '\n',':' };
        private string content;
        private List<Segment> listSegments = new List<Segment>(); 
        public void read(string path)
        {
            filePath = path;
            extexsion = Path.GetExtension(path);
            string FileText = ""; 
            if(extexsion == ".txt")
            {
                FileText = readTxt();  
            }
            content = FileText;
            setSegmentFromFile(); 
        }
        public string getContent()
        {
            return content; 
        }
        public string readTxt() {
            string fileText = File.ReadAllText(filePath);
            return fileText;
        }
        public void setSegmentFromFile()
        {
            List<string> sentences = splitIntoSentences(this.getContent());
            foreach (string sentence in sentences)
            {
                Segment segment = new Segment();
                segment.setValue(sentence);
                listSegments.Add(segment);
            }
        }

        public List<Segment> getListSegment()
        {
            return listSegments;
        }

        public List<string> splitIntoSentences(string s)
        {
            var parts = new List<string>();
            if (!string.IsNullOrEmpty(s))
            {
                int iFirst = 0;
                do
                {
                    int iLast = s.IndexOfAny(delimiters, iFirst);
                    if (iLast >= 0)
                    {
                        if (iLast > iFirst)
                            if (s[iLast] == '\n')
                            {
                                if (s.Substring(iFirst, iLast - iFirst - 1).Trim() != "")
                                {
                                    parts.Add(s.Substring(iFirst, iLast - iFirst - 1).Trim());
                                }
                            }
                            else
                            {
                                parts.Add(s.Substring(iFirst, iLast - iFirst + 1).Trim());
                            }
                        iFirst = iLast + 1;
                        continue;
                    }
                    parts.Add(s.Substring(iFirst, s.Length - iFirst).Trim());
                    break;

                } while (iFirst < s.Length);
            }

            return parts;
        }
    }
}
