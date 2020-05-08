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

namespace src.Files
{
    public class pdfFile : file
    {
        private string pathWordFile;
        private string nameDocFile;
        private string extension = ".docx"; 
        public override void readContent(string path)
        {
            List<string> listContentPage = new List<string>();
            wordProc wordproc = new wordProc();
            listContentPage = wordproc.readDocFile(pathWordFile);

            int page = 1;
            foreach (string contentPage in listContentPage)
            {
                content = content + contentPage;
                List<Segment> tmp = new List<Segment>();
                tmp = wordproc.splitTxtContentToSegment(contentPage, delimiters, page);
                listSegments.AddRange(tmp);
                page++;
            }
        }
        public override void loadFileSave(string path)
        {
            if (File.Exists(path))
            {
                readwriteXML txt = new readwriteXML();
                this.listSegmentsFromSave = txt.readSegmentFromFileSave(path);

                //            //Set lai cac tm voi file save
            }
        }
        public override void createFileTranslateDocument(string path)
        {
            //Copy file goc
            string sourceFile = this.pathWordFile;
            string desFile = path;
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            File.Copy(sourceFile, desFile);
            //string destinationFile = this.file
            replaceContent(path);
        }

        public void replaceContent(string path)
        {
            wordProc wordproc = new wordProc();
            wordproc.replaceContent(listSegments, path);
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
