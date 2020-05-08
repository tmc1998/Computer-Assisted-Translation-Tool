using src.segment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using src.TM; 
namespace src.processing
{
    public class wordProc
    {
        public List<string> readDocFile(string path)
        {
            List<string> data = new List<string>();
            try
            {
                Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
                Microsoft.Office.Interop.Word.Document doc = new Microsoft.Office.Interop.Word.Document();

                object fileName = path;
                object missing = System.Type.Missing;
                object What = Microsoft.Office.Interop.Word.WdGoToItem.wdGoToPage;
                object Which = Microsoft.Office.Interop.Word.WdGoToDirection.wdGoToAbsolute;
                object Start;
                object End;
                object CurrentPageNumber;
                object NextPageNumber;
                object Miss = System.Reflection.Missing.Value;


                doc = word.Documents.Open(ref fileName,
                        ref missing, ref missing, ref missing, ref missing,
                        ref missing, ref missing, ref missing, ref missing,
                        ref missing, ref missing, ref missing, ref missing,
                        ref missing, ref missing, ref missing);

                Microsoft.Office.Interop.Word.WdStatistic PagesCountStat = Microsoft.Office.Interop.Word.WdStatistic.wdStatisticPages;
                int PagesCount = doc.ComputeStatistics(PagesCountStat, ref missing);

                for (int Index = 1; Index <= PagesCount; Index++)
                {
                    CurrentPageNumber = (Convert.ToInt32(Index.ToString()));
                    NextPageNumber = (Convert.ToInt32((Index + 1).ToString()));

                    //Lay vi tri bat dau cua trang
                    Start = word.Selection.GoTo(ref What, ref Which, ref CurrentPageNumber, ref Miss).Start;
                    //Lay vi tri cuoi cua trang
                    End = word.Selection.GoTo(ref What, ref Which, ref NextPageNumber, ref Miss).End;
                    //Lay text ra
                    if (Convert.ToInt32(Start.ToString()) != Convert.ToInt32(End.ToString()))
                    {
                        data.Add(doc.Range(ref Start, ref End).Text); 
                    }
                    else
                    {
                        data.Add(doc.Range(ref Start).Text);
                    }
                }


                doc.Close();
                word.Quit();
            }
            catch (Exception)
            {
                data = null; 
            }

            return data; 
        }
        public List<Segment> splitTxtContentToSegment(string content, char[] delimiters,int page)
        {
            var parts = new List<Segment>();
            if (!string.IsNullOrEmpty(content))
            {
                int iFirst = 0;
                do
                {
                    int iLast = content.IndexOfAny(delimiters, iFirst);
                    if (iLast >= 0)
                    {
                        if (iLast > iFirst)
                            if (iLast != iFirst)
                            {
                                string str1 = content.Substring(iFirst, iLast - iFirst + 1).Trim();
                                if (str1 != "")
                                {
                                    tm tm1 = new tm();
                                    tm1.Source = str1;
                                    Segment tmp1 = new Segment();
                                    tmp1.setTM(tm1);
                                    tmp1.setPage(page); 
                                    parts.Add(tmp1);
                                }
                            }
                        iFirst = iLast + 1;
                        continue;
                    }
                    string str = content.Substring(iFirst, content.Length - iFirst).Trim();
                    if (str != "")
                    {
                        tm tm = new tm();
                        tm.Source = str;
                        Segment tmp = new Segment();
                        tmp.setTM(tm);
                        tmp.setPage(page); 
                        parts.Add(tmp);
                    }
                    break;

                } while (iFirst < content.Length);
            }

            return parts;
        }

        public void replaceContent(List<Segment> listSegs,string path)
        {
            try
            {
                Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
                Microsoft.Office.Interop.Word.Document doc = new Microsoft.Office.Interop.Word.Document();

                object fileName = path;
                object missing = System.Type.Missing;
                object What = Microsoft.Office.Interop.Word.WdGoToItem.wdGoToPage;
                object Which = Microsoft.Office.Interop.Word.WdGoToDirection.wdGoToAbsolute;
                object Start;
                object End;
                object CurrentPageNumber;
                object NextPageNumber;
                object Miss = System.Reflection.Missing.Value;

                doc = word.Documents.Open(ref fileName,
                        ref missing, ref missing, ref missing, ref missing,
                        ref missing, ref missing, ref missing, ref missing,
                        ref missing, ref missing, ref missing, ref missing,
                        ref missing, ref missing, ref missing);

                Microsoft.Office.Interop.Word.WdStatistic PagesCountStat = Microsoft.Office.Interop.Word.WdStatistic.wdStatisticPages;
                int PagesCount = doc.ComputeStatistics(PagesCountStat, ref missing);

                for (int Index = 1; Index <= PagesCount; Index++)
                {
                    CurrentPageNumber = (Convert.ToInt32(Index.ToString()));
                    NextPageNumber = (Convert.ToInt32((Index + 1).ToString()));
                    List<Segment> listSegInPage = new List<Segment>();
                    listSegInPage = getListSegsInPage(listSegs, Index); 

                    //Lay vi tri bat dau cua trang
                    Start = word.Selection.GoTo(ref What, ref Which, ref CurrentPageNumber, ref Miss).Start;
                    //Lay vi tri cuoi cua trang
                    End = word.Selection.GoTo(ref What, ref Which, ref NextPageNumber, ref Miss).End;
                    if (Convert.ToInt32(Start.ToString()) != Convert.ToInt32(End.ToString()))
                    {
                        foreach (Segment seg in listSegInPage)
                        {
                            tm tmp = seg.getTM();
                            if (tmp.Target != null)
                            {
                                if (tmp.Target.Trim() != "")
                                {
                                    findAndReplace(doc.Range(ref Start, ref End), tmp.Source, tmp.Target);
                                }
                            }
                        }
                    }
                    else
                    {
                        foreach (Segment seg in listSegInPage)
                        {
                            tm tmp = seg.getTM();
                            if (tmp.Target != null)
                            {
                                if (tmp.Target.Trim() != "")
                                {
                                    findAndReplace(doc.Range(ref Start), tmp.Source, tmp.Target);
                                }
                            }
                        }
                    }
                    
                    //Lay text ra
                    //if (Convert.ToInt32(Start.ToString()) != Convert.ToInt32(End.ToString()))
                    //{
                    //    data.Add(doc.Range(ref Start, ref End).Text);
                    //}
                    //else
                    //{
                    //    data.Add(doc.Range(ref Start).Text);
                    //}
                }


                doc.Close();
                word.Quit();
            }
            catch (Exception)
            {

            }
        }
        public List<Segment> getListSegsInPage(List<Segment> listSegs,int page)
        {
            List<Segment> listSegsInpage = new List<Segment>(); 
            foreach(Segment seg in listSegs)
            {
                if(seg.getPage() == page)
                {
                    listSegsInpage.Add(seg); 
                }
            }
            return listSegsInpage; 
        }
        public void findAndReplace(Microsoft.Office.Interop.Word.Range a, object findText, object replaceWithText)
        {
            //options
            object matchCase = false;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundsLike = false;
            object matchAllWordForms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiacritics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 1;
            object wrap = 1;
            object missing = System.Reflection.Missing.Value;
            //object replaceAll = .WdReplace.wdReplaceAll;
            object replaceOnce = Microsoft.Office.Interop.Word.WdReplace.wdReplaceOne;
            a.Find.Execute(ref findText, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing, ref replaceWithText,
                ref replaceOnce, ref missing, ref missing, ref missing, ref missing);
        }
    }
}
