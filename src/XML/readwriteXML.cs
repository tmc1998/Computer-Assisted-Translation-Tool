using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using src.Files;
using src.project;
using src.segment;
using src.TB;
using src.TM;

namespace src.XML
{
    public class readwriteXML
    {
        public void writeXMLFileProject(Project a,string filename)
        {
            if (a != null)
            {
                string path = Path.Combine(a.getPathProject(), filename);
                XmlTextWriter xmlWriter = new XmlTextWriter(path, System.Text.Encoding.UTF8);
                xmlWriter.Formatting = Formatting.Indented;
                xmlWriter.WriteStartDocument();
                xmlWriter.WriteComment("Creating cat project");
                xmlWriter.WriteStartElement("CAT");
                xmlWriter.WriteElementString("Name_Project", a.getNameProject());
                xmlWriter.WriteElementString("Path_Project", a.getPathProject());
                xmlWriter.WriteElementString("Path_SourceFolder", a.getPathSourceFolder());
                xmlWriter.WriteElementString("Path_TargetFolder", a.getPathTargetFolder());
                xmlWriter.WriteElementString("Path_SaveFolder", a.getPathSaveFolder());
                xmlWriter.WriteElementString("Path_TempProject", a.getPathTempFolder()); 
                xmlWriter.WriteElementString("Source_Lang", a.getSourceLang());
                xmlWriter.WriteElementString("Target_Lang", a.getTargetLang());
                xmlWriter.WriteElementString("TM_Name", a.getTMName()); 
                xmlWriter.WriteElementString("Time_Creation", a.getCreationTime().ToString());
                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndDocument();
                xmlWriter.Flush();
                xmlWriter.Close();
            }
        }

        public void writeXMLFileSaveFile(Project project)
        {
            if(project != null)
            {
                if(project.getCurrentFile() != null)
                {
                    List<Segment> listSegs = new List<Segment>();
                    listSegs = project.getCurrentFile().getListSaveSegment(); 
                    string path = Path.Combine(project.getPathSaveFolder(), project.getCurrentFile().getFileNameSave());
                    if (File.Exists(path))
                    {
                        File.Delete(path); 
                    }
                    XmlTextWriter xmlWriter = new XmlTextWriter(path, System.Text.Encoding.UTF8);
                    xmlWriter.Formatting = Formatting.Indented;
                    xmlWriter.WriteStartDocument();
                    xmlWriter.WriteComment("Creating save file");
                    xmlWriter.WriteStartElement("Segments");
                    foreach(Segment seg in listSegs)
                    {
                        string sourceLang = seg.getTM().Source;
                        string targetLang = seg.getTM().Target;
                        bool confirm = seg.confirm;
                        xmlWriter.WriteStartElement("seg");
                        xmlWriter.WriteStartElement("Source");
                        xmlWriter.WriteAttributeString("Lang", project.getSourceLang());
                        xmlWriter.WriteElementString("Source_Text", sourceLang);
                        xmlWriter.WriteEndElement();
                        xmlWriter.WriteStartElement("Target");
                        xmlWriter.WriteAttributeString("Lang", project.getTargetLang()); 
                        xmlWriter.WriteElementString("Target_Text", targetLang);
                        xmlWriter.WriteEndElement();
                        xmlWriter.WriteStartElement("Confirm");
                        xmlWriter.WriteElementString("Value", confirm.ToString());
                        xmlWriter.WriteEndElement(); 
                        xmlWriter.WriteEndElement();
                    }
                    xmlWriter.WriteEndElement();
                    xmlWriter.WriteEndDocument();
                    xmlWriter.Flush();
                    xmlWriter.Close(); 
                }
            }
        }

        public void writeXMLTBOffline(List<Segment> segments, string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            XmlTextWriter xmlWriter = new XmlTextWriter(path, System.Text.Encoding.UTF8);
            xmlWriter.Formatting = Formatting.Indented;
            xmlWriter.WriteStartDocument();
            xmlWriter.WriteComment("Creating save file");
            xmlWriter.WriteStartElement("Segments");

            foreach(Segment seg in segments)
            {
                string sourceLang = seg.getTM().Source;
                string fileName = seg.file;
                xmlWriter.WriteStartElement("tbOffline");
                xmlWriter.WriteElementString("Source_Text", sourceLang);
                xmlWriter.WriteElementString("File_Name", fileName); 
                xmlWriter.WriteEndElement(); 
            }

            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndDocument();
            xmlWriter.Flush();
            xmlWriter.Close();
        }

        public Project readXMLFileProject(string path)
        {
            Project tmp = new Project();

            XmlTextReader xtr = new XmlTextReader(path);
            try
            {
                if (xtr.Read() != null)
                {
                    while (xtr.Read())
                    {
                        if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "Name_Project")
                        {
                            string s1 = xtr.ReadElementString();
                            tmp.setNameProject(s1);
                        }
                        if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "Path_Project")
                        {
                            string s2 = xtr.ReadElementString();
                            tmp.setPathProject(s2);
                        }
                        if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "Path_SourceFolder")
                        {
                            string s3 = xtr.ReadElementString();
                            tmp.setSourcePath(s3);
                        }
                        if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "Path_TargetFolder")
                        {
                            string s4 = xtr.ReadElementString();
                            tmp.setTargetPath(s4);
                        }
                        if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "Path_SaveFolder")
                        {
                            string s8 = xtr.ReadElementString();
                            tmp.setSavePath(s8); 
                        }
                        if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "Path_TempFolder")
                        {
                            string s9 = xtr.ReadElementString();
                            tmp.setSavePath(s9);
                        }
                        if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "Source_Lang")
                        {
                            string s5 = xtr.ReadElementString();
                            tmp.setSourceLang(s5);
                        }
                        if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "Target_Lang")
                        {
                            string s6 = xtr.ReadElementString();
                            tmp.setTargetLang(s6);
                        }
                        if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "TM_Name")
                        {
                            string s10 = xtr.ReadElementString();
                            tmp.setTMName(s10); 
                        }
                        if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "Time_Creation")
                        {
                            string s7 = xtr.ReadElementString();
                            DateTime date = DateTime.Parse(s7);
                            tmp.setCreationTime(date); 
                        }
                    }
                }
            }
            catch(Exception)
            {
                tmp = null; 
            }
            xtr.Close(); 

            return tmp;
        }
        public List<Segment> readSegmentFromFileSave(string path)
        {
            List<Segment> listSegs = new List<Segment>();
            XmlTextReader xtr = new XmlTextReader(path);
            string sourceText;
            string TargetText;
            string confirmText;
            int index = 0;
            try
            {
                if (xtr.Read() != null)
                {
                    while (xtr.Read())
                    {
                        if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "Source_Text")
                        {
                            sourceText = xtr.ReadElementString();
                            tm tm = new tm();
                            tm.Source = sourceText;
                            Segment tmp = new Segment();
                            tmp.setTM(tm);
                            listSegs.Add(tmp);
                        }
                        if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "Target_Text")
                        {
                            TargetText = xtr.ReadElementString();
                            listSegs[index].setTMTargetLang(TargetText);
                            //index++;
                        }
                        if(xtr.NodeType == XmlNodeType.Element && xtr.Name == "Value")
                        {
                            confirmText = xtr.ReadElementString();
                            listSegs[index].confirm = bool.Parse(confirmText);
                            index++;
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
            xtr.Close();
            return listSegs;
        }
        public HashSet<tbOff> readTBOff(string path)
        {
            HashSet<tbOff> results = new HashSet<tbOff>();
            XmlTextReader xtr = new XmlTextReader(path);
            string sourceText = null;
            string fileName = null; 
            try
            {
                if (xtr.Read() != null)
                {
                    while (xtr.Read())
                    {
                        tbOff tb = new tbOff();
                        if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "Source_Text")
                        {
                            sourceText = xtr.ReadElementString();
                        }
                        if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "File_Name")
                        {
                            fileName = xtr.ReadElementString();
                            tb.fileName = fileName;
                            tb.segment = sourceText;
                        }
                        if(!String.IsNullOrEmpty(tb.fileName) && !String.IsNullOrEmpty(tb.segment))
                        {
                            results.Add(tb); 
                        }
                    }
                }
            }
            catch(Exception)
            {

            }
            xtr.Close();
            return results;
        }
    }
}
