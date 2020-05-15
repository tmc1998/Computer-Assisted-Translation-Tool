using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using src.Files;
using src.segment;
using src.TM;
using System.Text.RegularExpressions;
using System.Xml;
using src.XML; 

namespace src.project
{
    public class Project
    {
        //file file = new file();
        List<tm> tm = new List<tm>();
        private string nameFileProject = "project.cat";
        private string sourceFolderName = "source";
        private string targetFolderName = "target";
        private string saveFolderName = "save";
        private string tempFolderName = "temp"; 
        private string pathProject;
        private string pathSourceFolder;
        private string pathTargetFolder;
        private string pathSaveFolder;
        private string pathTempFolder; 
        private string languageSource;
        private string languageTarget;
        private string projectName;
        private string tmName; 
        private List<string> listfileextension = new List<string>() { ".txt", ".doc" , ".docx" , ".pdf" , ".xls",".xlsx" };
        private char[] delimiters = { '.', '?', '\n', ':', '\r', '\t', '\a', '\f' };
        private List<file> listFileOfSourceProject = new List<file>();
        private file currentFile; 
        private DateTime creationtime; 


        public void setPathProject(string path)
        {
            pathProject = path;
            pathSourceFolder = Path.Combine(path,this.sourceFolderName);
            pathTargetFolder = Path.Combine(path,this.targetFolderName);
            pathSaveFolder = Path.Combine(path, this.saveFolderName);
            pathTempFolder = Path.Combine(path, this.tempFolderName); 
        }

        public void setNameProject(string name)
        {
            projectName = name; 
        }

        public void setTMName(string tmname)
        {
            tmName = tmname; 
        }

        public void setLanguage(string source, string target)
        {
            languageSource = source;
            languageTarget = target; 
        }

        public void setSourcePath(string path)
        {
            this.pathSourceFolder = path; 
        }
        public void setTargetPath(string path)
        {
            this.pathTargetFolder = path; 
        }
        public void setSavePath(string path)
        {
            this.pathSaveFolder = path;
        }
        public void setTempPath(string path)
        {
            this.pathTempFolder = path; 
        }
        public void setSourceLang(string language)
        {
            this.languageSource = language; 
        }
        public void setTargetLang(string language)
        {
            this.languageTarget = language;
        }

        public void setCreationTime(DateTime time)
        {
            creationtime = time; 
        }

        public void setCurrentFile(file tmp)
        {
            currentFile = tmp;
        }

        public void setTargetLangToCurrentFileListSegment(int index, string strLang)
        {
            currentFile.listSegments[index].setTMTargetLang(strLang);
        }

        public void addSegmentToListSaveSegment(Segment segment)
        {
            currentFile.addSegmentToListSaveSegment(segment); 
        }

        public string getTMName()
        {
            return tmName; 
        }

        public DateTime getCreationTime()
        {
            return creationtime; 
        }


        public string getPathProject()
        {
            return this.pathProject;
        }

        public string getPathSourceFolder()
        {
            return this.pathSourceFolder; 
        }

        public string getPathTargetFolder()
        {
            return this.pathTargetFolder; 
        }

        public string getPathSaveFolder()
        {
            return this.pathSaveFolder; 
        }

        public string getPathTempFolder()
        {
            return this.pathTempFolder; 
        }

        public string getNameProject()
        {
            return this.projectName; 
        }

        public string getSourceLang()
        {
            return this.languageSource;
        }

        public string getTargetLang()
        {
            return this.languageTarget; 
        }
        public string getNameFileProject()
        {
            return this.nameFileProject;
        }
        public List<string> getlistfileextension()
        {
            return listfileextension; 
        }
        public file getCurrentFile()
        {
            return currentFile; 
        }
        public List<file> getListFileOfSourceProject()
        {
            return listFileOfSourceProject;
        }
        public void createXMLFileProject()
        {
            readwriteXML writeXML = new readwriteXML();
            writeXML.writeXMLFileProject(this, this.nameFileProject);
        }

        public bool isEmptySourceFolder()
        {
            //var count = Directory.EnumerateFiles(
            //            path, "*.txt", SearchOption.TopDirectoryOnly)
            //            .Count();
            //return count;
            if(this != null)
            {
                int count = 0; 
                foreach(string extension in listfileextension)
                {
                    count += Directory.EnumerateFiles(this.pathSourceFolder, "*" + extension, SearchOption.TopDirectoryOnly).Count();
                }
                if(count == 0)
                {
                    return true; 
                }
            }
            return false; 
        }

        public bool readProject(string path)
        {
            Project tmp = new Project();
            readwriteXML readXML = new readwriteXML();
            tmp = readXML.readXMLFileProject(path);
            if (tmp != null)
            {
                this.projectName = tmp.projectName;
                this.pathProject = tmp.pathProject;
                this.pathSourceFolder = tmp.pathSourceFolder;
                this.pathTargetFolder = tmp.pathTargetFolder;
                this.languageSource = tmp.languageSource;
                this.languageTarget = tmp.languageTarget;
                this.creationtime = tmp.creationtime;
                this.tmName = tmp.tmName; 
                this.pathSaveFolder = tmp.pathSaveFolder;
                this.pathTempFolder = tmp.pathTempFolder; 
                setListFile(); 

                return true; 
            }
            //Set list file trong source folder 

            return false; 
        }

        public void createProject()
        {
            Directory.CreateDirectory(this.pathProject);
            Directory.CreateDirectory(this.pathSourceFolder);
            Directory.CreateDirectory(this.pathTargetFolder);
            Directory.CreateDirectory(this.pathSaveFolder);
            Directory.CreateDirectory(this.pathTempFolder); 
            //Tạo file xml của project 
            this.createXMLFileProject(); 
        }

        public void saveProject()
        {
            readwriteXML readXML = new readwriteXML();
            readXML.writeXMLFileSaveFile(this); 
        }

        public void setListFile()
        {
            listFileOfSourceProject.Clear();
            if (this != null) {
                try
                {
                    string path = this.pathSourceFolder; 
                    foreach (string item in Directory.GetFiles(path))
                    {
                        FileInfo fi = new FileInfo(item);
                        string extension = fi.Extension;
                        if (listfileextension.Contains(extension))
                        {
                            if (extension == ".txt")
                            {
                                file a = new txtFile();
                                a.setFileName(fi.FullName);
                                //a.readContent(a.filePath);
                                string pathFile = Path.Combine(pathSaveFolder, a.getFileNameSave());
                                a.loadFileSave(pathFile);
                                listFileOfSourceProject.Add(a); 
                            }
                            if(extension == ".docx" || extension == ".doc")
                            {
                                file a = new wordFile();
                                a.setFileName(fi.FullName);
                                string pathFile = Path.Combine(pathSaveFolder, a.getFileNameSave());
                                a.loadFileSave(pathFile);
                                listFileOfSourceProject.Add(a); 
                            }
                            if(extension == ".pdf")
                            {
                                file a = new pdfFile();
                                a.setFileName(fi.FullName);
                                string pathFileSave = Path.Combine(pathSaveFolder, a.getFileNameSave());
                                a.loadFileSave(pathFileSave);
                                //a.copy(); 
                                string pathFile = Path.Combine(pathSourceFolder, fi.FullName); 
                                //a.convertToWord(pathFile,pathTempFolder); 
                                listFileOfSourceProject.Add(a); 
                            }
                        }
                    }
                }
                catch (Exception) { }
            }
        }

        public void readContentCurrentFile()
        {
            if(currentFile != null)
            {
                string path = currentFile.getPath();
                currentFile.setdelimiters(delimiters); 
                currentFile.readContent(path);
                currentFile.setListSegmentsFormFileSave(); 
            }
            
        }

        public void createTranslatedDocument()
        {
            if (currentFile != null) {
                if (currentFile is pdfFile)
                {
                    string path = Path.Combine(pathTargetFolder, currentFile.getConvertFileName());
                    currentFile.createFileTranslateDocument(path); 
                }
                else
                {
                    string path = Path.Combine(pathTargetFolder, currentFile.getFileName());
                    currentFile.createFileTranslateDocument(path);
                }
            }
        }
    }

}
