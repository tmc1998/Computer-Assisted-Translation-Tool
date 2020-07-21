using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using src.segment;
using src.TM;

namespace src.Files
{
    public abstract class file
    {
        public string filePath;
        public string fileName;
        public string fileNameSave;
        public string pathSaveFolder; 
        public string extexsionFile = "txt files|*.txt|All files|*.*";
        public string extexsion;
        public char[] delimiters;
        public string content;
        public string convertFileName; 
        public List<Segment> listSegments = new List<Segment>();
        public List<Segment> listSegmentsFromSave = new List<Segment>();


        public abstract void readContent(string path);
        public abstract void loadFileSave(string path);
        public abstract void convertToWord(string path,string tempFolder); 

        public abstract void createFileTranslateDocument(string path); 

        public void setFileName(string path)
        {
            this.filePath = path;
            this.fileName = Path.GetFileName(path);
            this.extexsion = Path.GetExtension(path);
            this.fileNameSave = Path.GetFileNameWithoutExtension(path) + ".save";
        }

        public void setTargetToListSegment(tm tm,bool confirm)
        {
            if(tm != null)
            {
                for(int i = 0; i < listSegments.Count; i++)
                {
                    tm tmp = listSegments[i].getTM(); 
                    if(tmp.Source == tm.Source)
                    {
                        listSegments[i].setTMTargetLang(tm.Target);
                        listSegments[i].confirm = confirm;
                    }
                }
            }
        }

        public void reWriteListSegmentSave(List<Segment> listSegs)
        {
            listSegmentsFromSave.Clear();
            listSegmentsFromSave = listSegs; 
        }

        public void reWriteListSegment(List<Segment> listSegs)
        {
            //listSegments.Clear();
            for(int i = 0; i < listSegments.Count; i++)
            {
                tm tmp = new tm();
                tmp = listSegs[i].getTM();
                listSegments[i].setTM(tmp); 
            }
        }

        public void setListSegmentsFormFileSave()
        {
            if (listSegmentsFromSave.Count > 0)
            {
                foreach (Segment tmp in listSegmentsFromSave)
                {
                    tm tm = tmp.getTM();
                    setTargetToListSegment(tm,tmp.confirm);
                }
            }
        }

        public string getPath()
        {
            return filePath; 
        }
        public string getFileName()
        {
            return fileName; 
        }

        public string getFileNameSave()
        {
            return fileNameSave; 
        }

        public List<Segment> getListSegments()
        {
            return listSegments; 
        }
        public List<Segment> getListSaveSegment()
        {
            return listSegmentsFromSave; 
        }
        public void addSegmentToListSaveSegment(Segment tmp)
        {
            listSegmentsFromSave.Add(tmp); 
        }
        public void readSaveFile(string path)
        {

        }
        public void setdelimiters(char[] Delemiters)
        {
            delimiters = Delemiters; 
        }
        public string getConvertFileName()
        {
            return convertFileName; 
        }
         
    }
}
