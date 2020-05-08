using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using src.Files;
using src.processing;
using src.XML;
using src.segment;
using src.TM; 

namespace src.Files
{
    public class txtFile : file 
    {
        public override void readContent(string path)
        {            
            txtProc txtProc = new txtProc();
            this.content = txtProc.readTxtFile(path);
            this.listSegments = txtProc.splitTxtContentToSegment(this.content,delimiters);
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
            replaceContent();
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            File.WriteAllText(path, this.content);
        }
        public void replaceContent()
        {
            txtProc txtProc = new txtProc();
            if (this.content.Length > 0)
            {
                foreach (Segment a in listSegments)
                {
                    tm tmp = a.getTM();
                    if (tmp.Target != null)
                    {
                        if (tmp.Target.Trim() != "")
                        {
                            this.content = txtProc.ReplaceFirst(this.content, tmp.Source, tmp.Target);
                        }
                    }
                }
            }
        }
        public override void convertToWord(string path,string tempFolder)
        {
            throw new NotImplementedException();
        }

    }
}
