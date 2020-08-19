using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using src.segment;
using Microsoft.Office.Interop.Excel;
using src.TM;
using System.IO;

namespace src.processing
{
    public class excelProc
    {
        public List<Segment> readExcelFile(string path)
        {
            string filename = Path.GetFileName(path); 
            List<Segment> results = new List<Segment>();
            try
            {
                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                Workbook xlWorkbook = xlApp.Workbooks.Open(path, Type.Missing, true);
                int countSheet = xlWorkbook.Sheets.Count;
                 for (int i = 1; i <= countSheet; i++)
                {
                    _Worksheet xlWorksheet = (_Worksheet)xlWorkbook.Sheets[i];
                    Range xlRange = xlWorksheet.UsedRange;
                    foreach (Range c in xlRange.Rows.Cells)
                    {
                        if (c.Value2 != null)
                        {
                            string text;
                            if (c.Value2 is string)
                            {
                                text = c.Value2;
                            }
                            else
                            {
                                text = c.Value2.ToString();
                            }
                            tm tm = new tm();
                            tm.Source = text;
                            Segment tmp = new Segment();
                            tmp.row = c.Row;
                            tmp.col = c.Column;
                            tmp.sheet = i;
                            tmp.file = filename;
                            tmp.setTM(tm);
                            results.Add(tmp); 
                            //Console.WriteLine("row: " + c.Row + "Column " + c.Column + "value" + c.Value2 + "Sheet :" + i);
                        }
                    }
                }
                xlWorkbook.Close();
                xlApp.Quit();
                xlApp = null; 
                //System.Runtime.InteropServices.Marshal.FinalReleaseComObject(xlWorkbook);
                //System.Runtime.InteropServices.Marshal.FinalReleaseComObject(xlApp);
            }
            catch(Exception ex)
            {

            }
            return results;
        }
        public void replaceContent(List<Segment> listSegs,string path)
        {
            object m = Type.Missing;
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Workbook xlWorkbook = xlApp.Workbooks.Open(path, m, false, m, m, m, m, m, m, m, m, m, m, m, m);
            try
            {
                int countSheet = xlWorkbook.Sheets.Count;
                for(int i = 1; i <= countSheet; i++)
                {
                    _Worksheet xlWorksheet = (_Worksheet)xlWorkbook.Sheets[i];
                    //Range xlRange = xlWorksheet.UsedRange;
                    List<Segment> listSegsInSheet = getListSegsInSheet(listSegs, i); 
                    foreach(Segment segment in listSegsInSheet)
                    {
                        int col = segment.col;
                        int row = segment.row;
                        string source = segment.getTMSource();
                        string target = segment.getTMTarget();
                        if (!string.IsNullOrEmpty(target))
                        {
                            xlWorksheet.Cells[row, col] = target;
                        }
                    }
                }
                xlWorkbook.Save();
                xlWorkbook.Close();
                xlApp.Quit();
                xlApp = null;
             }
            catch (Exception ex)
            {
                xlWorkbook.Close();
                xlApp.Quit();
                xlApp = null;
                File.Delete(path);
            }
        }
        public List<Segment> getListSegsInSheet(List<Segment> listSegs,int sheet)
        {
            List<Segment> results = new List<Segment>();
            foreach(Segment segment in listSegs)
            {
                if(segment.sheet == sheet)
                {
                    results.Add(segment);
                }
            }
            return results;
        }
    }
}
