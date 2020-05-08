using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using src.TM; 

namespace src.segment
{
    public class Segment
    {
        private tm TM;
        private int page; 
        public void setTM(tm tmp)
        {
            TM = tmp; 
        }

        public void setTMSourceLang(string Lang)
        {
            TM.Source = Lang; 
        }

        public void setTMTargetLang(string Lang)
        {
            TM.Target = Lang; 
        }

        public tm getTM()
        {
            return TM; 
        }

        public string getTMSource()
        {
            return TM.Source; 
        }
        
        public string getTMTarget()
        {
            return TM.Target; 
        }

        public void setPage(int Page)
        {
            page = Page; 
        }
        public int getPage()
        {
            return page; 
        }

    }
}
