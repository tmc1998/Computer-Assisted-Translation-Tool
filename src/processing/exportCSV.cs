using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using src.TM;
using System.IO;
using Microsoft.Office.Interop.Excel;

namespace src.processing
{
    public class exportCSV
    {
        public void exportTM(string path,List<tm> tmData,string srcLang,string srcTag, string password)
        {
            //StringBuilder csvcontent = new StringBuilder();
            //var firstLine = string.Format("{0},{1}", srcLang, srcTag);
            //csvcontent.AppendLine(firstLine);
            //foreach (var tm in tmData)
            //{
            //    var newLine = string.Format("{0},{1}", "\"" + tm.Source + "\"", "\"" + tm.Target + "\"");
            //    csvcontent.AppendLine(newLine);
            //}
            //File.AppendAllText(path, csvcontent.ToString(), Encoding.UTF8); 
            Microsoft.Office.Interop.Excel.Application oXL = null;
            Microsoft.Office.Interop.Excel._Workbook oWB = null;
            Microsoft.Office.Interop.Excel._Worksheet oSheet = null;
            Microsoft.Office.Interop.Excel.Range oRng = null;
            object misvalue = System.Reflection.Missing.Value;
            int row = 1;
            try
            {
                //Start Excel and get Application object.
                oXL = new Microsoft.Office.Interop.Excel.Application();
                //L.Visible = true;
                //Get a new workbook
                oWB = oXL.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
                if (!string.IsNullOrEmpty(password))
                {
                    oWB.Password = password;
                }
                oSheet = (Microsoft.Office.Interop.Excel._Worksheet)oWB.ActiveSheet;
                //Add table headers going cell by cell.
                oSheet.Cells[row, 1] = srcLang;
                oSheet.Cells[row, 2] = srcTag;
                row++;
                foreach(tm tm in tmData)
                {
                    oSheet.Cells[row, 1] = tm.Source;
                    oSheet.Cells[row, 2] = tm.Target;
                    row++;
                }
                //L.Visible = false;
                //oXL.UserControl = false;
                oWB.SaveAs(path, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing,
                false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                oWB.Close();
                oXL.Quit();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
