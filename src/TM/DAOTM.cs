using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using src.segment; 

namespace src.TM
{
    class DAOTM
    {
        public List<tablename> GetTablenames()
        {
            TMDATA tmdata = new TMDATA();
            return tmdata.getTableName(); 
        }
        public int createTable(string tableTMName)
        {
            string query = string.Format(@"CREATE TABLE IF NOT EXISTS '{0}'('Source' TEXT NOT NULL,'Target' TEXT NOT NULL)", tableTMName); 
            TMDATA tmdata = new TMDATA();
            return tmdata.excuteNonQuery(query); 
        }
        public int addSegmentToTM(Segment segment,string tableTMName)
        {
            TMDATA tmdata = new TMDATA();
            List<tm> listTM = new List<tm>();
            listTM = tmdata.LoadTM(tableTMName);
            if (checkExistsSegment(segment, listTM))
            {
                return updateSegmentToTM(segment,tableTMName);
            }
            else
            {
                return insertSegmentToTM(segment, tableTMName); 
            }
        }
        public int insertSegmentToTM(Segment segment,string tableTMName)
        {
     
            string Source = segment.getTMSource();
            string Target = segment.getTMTarget();

            TMDATA tmdata = new TMDATA();
            string query = string.Format(@"INSERT INTO '{0}' (Source,Target) values ({1},{2})", tableTMName, Source, Target);
            //return tmdata.excuteNonQuery(query);
            return tmdata.insertToTM(segment, tableTMName); 
            //return tmdata.excuteNonQuery(segment, tableTMName); 
        }
        public int updateSegmentToTM(Segment segment, string tableTMName)
        {
            string Source = segment.getTMSource();
            string Target = segment.getTMTarget();

            TMDATA tmdata = new TMDATA();
            string query = string.Format(@"UPDATE '{0}' SET Target = '{1}' WHERE Source = '{2}'", tableTMName, Target, Source);
            //return tmdata.excuteNonQuery(query); 
            return tmdata.updateSegment(segment, tableTMName); 
        }
        public bool checkExistsSegment(Segment segment,List<tm> listTM)
        {
            string Target = segment.getTMTarget();
            string Source = segment.getTMSource(); 
            foreach(tm tm in listTM)
            {
                if (Source.Trim().Equals(tm.Source.Trim()))
                {
                    return true;
                }
            }
            return false; 
        }
    }
}
