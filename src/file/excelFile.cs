using src.processing;
using src.XML;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.Files
{
    public class excelFile : file
    {
        public override void readContent(string path)
        {
            excelProc exproc = new excelProc();
            listSegments = exproc.readExcelFile(path); 
        }
        public override void createFileTranslateDocument(string path)
        {
            string sourceFile = this.filePath;
            string desFile = path;
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            File.Copy(sourceFile, desFile);
            //string destinationFile = this.file
            replaceContent(path);
        }
        public override void convertToWord(string path, string tempFolder)
        {
            throw new NotImplementedException();
        }
        public override void loadFileSave(string path)
        {
            if (File.Exists(path))
            {
                readwriteXML txt = new readwriteXML();
                this.listSegmentsFromSave = txt.readSegmentFromFileSave(path);
            }
        }
        public void replaceContent(string path)
        {
            excelProc exproc = new excelProc();
            exproc.replaceContent(listSegments, path); 
        }
    }
}
