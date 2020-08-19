using src.processing;
using src.segment;
using src.XML;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SautinSoft;
using src.TM;

namespace src.Files
{
    public class pdfFile : file
    {
        private string pathWordFile;
        private string nameDocFile;
        private string extension = ".docx"; 
        public override void readContent(string path)
        {
            pdfProc pdf = new pdfProc();
            //List<string> listContentPage = new List<string>();
            //wordProc wordproc = new wordProc();
            //listContentPage = wordproc.readDocFile(pathWordFile);

            //int page = 1;
            //foreach (string contentPage in listContentPage)
            //{
            //    content = content + contentPage;
            //    List<Segment> tmp = new List<Segment>();
            //    tmp = wordproc.splitTxtContentToSegment(contentPage, delimiters, page);
            //    listSegments.AddRange(tmp);
            //    page++;
            //}
            List<string> listContentPage = new List<string>();
            listContentPage = pdf.readPdfFile(path);
            if (listContentPage != null)
            {
                int page = 1;
                foreach (string contentPage in listContentPage)
                {
                    content = content + contentPage;
                    List<Segment> tmp = new List<Segment>();
                    tmp = pdf.splitTxtContentToSegment(contentPage, delimiters, page,this.fileName);
                    listSegments.AddRange(tmp);
                    page++;
                }
            }

        }
        public override void loadFileSave(string path)
        {
            pathSaveFolder = path;
            if (File.Exists(path))
            {
                readwriteXML txt = new readwriteXML();
                this.listSegmentsFromSave = txt.readSegmentFromFileSave(path);

                //            //Set lai cac tm voi file save
            }
            if (listSegmentsFromSave.Count == 0)
            {
                progress = 0;
            }
            else
            {
                int count = 0;
                foreach (Segment segment in listSegmentsFromSave)
                {
                    if (!string.IsNullOrEmpty(segment.getTMTarget()))
                    {
                        count++;
                    }
                }

                progress = (double)count / listSegmentsFromSave.Count;
            }
        }
        public override void createFileTranslateDocument(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            File.WriteAllText(path, replaceContent());
        }
        public string replaceContent()
        {
            txtProc txtProc = new txtProc();
            string contentReplace = this.content;
            if (this.content.Length > 0)
            {
                foreach (Segment a in listSegments)
                {
                    tm tmp = a.getTM();
                    if (tmp.Target != null)
                    {
                        if (tmp.Target.Trim() != "")
                        {
                            contentReplace = txtProc.ReplaceFirst(contentReplace, tmp.Source, tmp.Target);
                        }
                    }
                }
            }
            return contentReplace;
        }
        public override void convertToWord(string path,string tempFolder)
        {
            nameDocFile = Path.GetFileNameWithoutExtension(path) + extension;
            convertFileName = nameDocFile; 
            string pathDocFile = Path.Combine(tempFolder, nameDocFile);
            pathWordFile = pathDocFile;
            SautinSoft.PdfFocus f = new SautinSoft.PdfFocus();
            if (File.Exists(pathDocFile))
            {
                File.Delete(pathDocFile);
            }
            f.OpenPdf(path);
            if (f.PageCount > 0)
            {
                f.WordOptions.Format = SautinSoft.PdfFocus.CWordOptions.eWordDocument.Docx; 
                f.ToWord(pathDocFile);
            }
        }
    }
}
