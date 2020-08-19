using src.processing;
using src.segment;
using src.XML;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.Files
{
    class pptxFile : file
    {
        public override void readContent(string path)
        {
            pptxProc pptxProc = new pptxProc();
            listSegments = pptxProc.redPPTXFile(path, delimiters); 
        }
        public override void loadFileSave(string path)
        {
            pathSaveFolder = path;
            if (File.Exists(path))
            {
                readwriteXML txt = new readwriteXML();
                this.listSegmentsFromSave = txt.readSegmentFromFileSave(path);
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
        public override void convertToWord(string path, string tempFolder)
        {
            throw new NotImplementedException();
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
        public void replaceContent(string path)
        {
            pptxProc pptxProc = new pptxProc();
            pptxProc.replaceContent(listSegments, path); 
        }
    }
}
