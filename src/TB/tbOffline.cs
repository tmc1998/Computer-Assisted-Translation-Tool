using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using src.segment;
using src.Files;
using src.XML;
using System.Text.RegularExpressions;

namespace src.TB
{
    public class tbOffline
    {
        public string path { get; set; }
        public string pathFolder { get; set; }
        private List<string> listfileextension = new List<string>() { ".txt", ".doc", ".docx", ".pdf", ".xls", ".xlsx",".pptx"};
        private char[] delimiters = { '.', '?', '\n', ':', '\r', '\t', '\a', '\f' };
        public HashSet<tbOff> listSeg = new HashSet<tbOff>(); 
        private string tbOfflineFolder = "tbCat";
        private string tbOfflineName = "tbCat.tb";
        private string tbOfflinePath;
        private string fullName; 

        public tbOffline()
        {
           tbOfflinePath =  Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), tbOfflineFolder);
           fullName = Path.Combine(tbOfflinePath, tbOfflineName);
           createFolderTBOffline();
        }
        public void createTBOfflines()
        {
            List<Segment> segments = new List<Segment>(); 
            if (!String.IsNullOrEmpty(path))
            {
                try
                {
                    foreach (string item in Directory.GetFiles(path))
                    {
                        FileInfo fi = new FileInfo(item);
                        string extension = fi.Extension;
                        if (listfileextension.Contains(extension))
                        {
                            if(extension == ".txt")
                            {
                                file a = new txtFile();
                                a.setFileName(fi.FullName);
                                a.setdelimiters(delimiters); 
                                a.readContent(fi.FullName);
                                segments.AddRange(a.getListSegments()); 
                            }
                            if(extension == ".pdf")
                            {
                                file a = new pdfFile();
                                a.setFileName(fi.FullName);
                                a.setdelimiters(delimiters);
                                a.readContent(fi.FullName);
                                segments.AddRange(a.getListSegments()); 
                            }
                           if(extension == ".doc" || extension == ".docx")
                            {
                                file a = new wordFile();
                                a.setFileName(fi.FullName);
                                a.setdelimiters(delimiters);
                                a.readContent(fi.FullName);
                                segments.AddRange(a.getListSegments());
                            }
                           if(extension == ".pptx")
                            {
                                file a = new pptxFile();
                                a.setFileName(fi.FullName);
                                a.setdelimiters(delimiters);
                                a.readContent(fi.FullName);
                                segments.AddRange(a.getListSegments()); 
                            }
                           if(extension == ".xlsx")
                            {
                                file a = new excelFile();
                                a.setFileName(fi.FullName);
                                a.setdelimiters(delimiters);
                                a.readContent(fi.FullName);
                                segments.AddRange(a.getListSegments()); 
                            }
                        }
                    }
                }
                catch (Exception) { }
                writeToTxt(segments); 
            }
        }

        public void createFolderTBOffline()
        {
            if (!Directory.Exists(this.tbOfflinePath))
            {
                Directory.CreateDirectory(this.tbOfflinePath); 
            }
        }

        public void writeToTxt(List<Segment> segments)
        {
            readwriteXML xml = new readwriteXML();
            xml.writeXMLTBOffline(segments,this.fullName); 
            //try
            //{
            //    if (File.Exists(this.fullName))
            //    {
            //        File.Delete(this.fullName);
            //    }

            //    using (var sw = new StreamWriter(this.fullName))
            //    {
            //        foreach (Segment seg in segments)
            //        {
            //            string text = seg.getTMSource().Replace("\n", ""); 
            //            sw.WriteLine(text);
            //        }
            //    }
            //}
            //catch {}
        }
        public void readTBOff()
        {
            readwriteXML xml = new readwriteXML();
            listSeg =  xml.readTBOff(this.fullName); 
        }

        public HashSet<tbOff> findTermbaseOffline(string termbase)
        {
            HashSet<tbOff> results = new HashSet<tbOff>();

            foreach(tbOff tb in this.listSeg)
            {
                string Termbase = termbase.ToLower();
                string word = tb.segment.ToLower();
                string match = String.Format(@"\b{0}\b", Regex.Escape(Termbase));
                if(Regex.IsMatch(word,match, RegexOptions.IgnoreCase))
                {
                    results.Add(tb); 
                }
            }

            return results;
        }
    }
}
