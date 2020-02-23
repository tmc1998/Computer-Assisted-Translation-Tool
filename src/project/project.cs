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

namespace src.project
{
    public class Project
    {
        file file = new file();
        List<tm> tm = new List<tm>(); 
        public void newProject(string path)
        {
            file.read(path);
            LoadTM(); 
        }
        public List<Segment> setSegmentFromFile()
        {
            return  file.getListSegment(); 
        }

        public List<tm> getTM()
        {
            return tm; 
        }

        public void LoadTM()
        {
            TMDATA tmp = new TMDATA();
            tm = tmp.LoadTM(); 
        }
    }

}
