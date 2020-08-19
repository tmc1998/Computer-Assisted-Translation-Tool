using src.segment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.PowerPoint;
using src.TM;
using System.IO;

namespace src.processing
{
    public class pptxProc
    {
        public List<Segment> redPPTXFile(string path, char[] delimiters)
        {
            string filename = Path.GetFileName(path); 
            List<Segment> result = new List<Segment>();
            try
            {
                Microsoft.Office.Interop.PowerPoint.Application application = new Microsoft.Office.Interop.PowerPoint.Application();
                Microsoft.Office.Interop.PowerPoint.Application pwpApp = new Microsoft.Office.Interop.PowerPoint.Application();
                Microsoft.Office.Interop.PowerPoint.Presentations multi_presentations = pwpApp.Presentations;
                Microsoft.Office.Interop.PowerPoint.Presentation presentation = multi_presentations.Open(path, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoFalse);
                foreach (Slide slide in presentation.Slides)
                {
                    int indexShape = 1;
                    foreach (Microsoft.Office.Interop.PowerPoint.Shape shape in slide.Shapes)
                    {
                        if (shape.HasTextFrame == Microsoft.Office.Core.MsoTriState.msoTrue)
                        {
                            var textFrame = shape.TextFrame;
                            if (textFrame.HasText == Microsoft.Office.Core.MsoTriState.msoTrue)
                            {
                                var textRange = textFrame.TextRange;
                                string text = textRange.Text.ToString();
                                List<string> tmp = splitTxtContentToSegment(text, delimiters); 
                                foreach(string str in tmp)
                                {
                                    tm tm = new tm();
                                    tm.Source = str;
                                    int indexSlide = slide.SlideIndex;
                                    Segment segment = new Segment();
                                    segment.slide = indexSlide;
                                    segment.shape = indexShape;
                                    segment.file = filename;
                                    segment.setTM(tm);
                                    result.Add(segment); 
                                }
                            }
                        }
                        indexShape++;
                    }
                }

                presentation.Save();
                presentation.Close();
                pwpApp.Quit();
            }
            catch (Exception ex)
            {

            }
            return result;
        }
        public List<string> splitTxtContentToSegment(string content, char[] delimiters)
        {
            var parts = new List<string>();
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
                                if (!String.IsNullOrEmpty(str1))
                                {
                                    parts.Add(str1); 
                                }
                            }
                        iFirst = iLast + 1;
                        continue;
                    }
                    string str = content.Substring(iFirst, content.Length - iFirst).Trim();
                    if (!String.IsNullOrEmpty(str))
                    {
                        parts.Add(str); 
                        break;
                    }
                    else
                    {
                        break;
                    }

                } while (iFirst < content.Length);
            }

            return parts;
        }
        public void replaceContent(List<Segment> segments, string path)
        {
            Microsoft.Office.Interop.PowerPoint.Application application = new Microsoft.Office.Interop.PowerPoint.Application();
            Microsoft.Office.Interop.PowerPoint.Application pwpApp = new Microsoft.Office.Interop.PowerPoint.Application();
            Microsoft.Office.Interop.PowerPoint.Presentations multi_presentations = pwpApp.Presentations;
            Microsoft.Office.Interop.PowerPoint.Presentation presentation = multi_presentations.Open(path, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoFalse);
            try
            {
                foreach (Segment segment in segments)
                {
                    int shape = segment.shape;
                    int slide = segment.slide;
                    string source = segment.getTMSource();
                    string target = segment.getTMTarget();
                    if (!string.IsNullOrEmpty(target))
                    {
                        Microsoft.Office.Interop.PowerPoint.TextRange textRange = presentation.Slides[slide].Shapes[shape].TextFrame.TextRange;
                        textRange.Replace(source, target, 0, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoFalse);
                    }
                }
                presentation.Save();
                presentation.Close();
                pwpApp.Quit();
            }
            catch (Exception ex)
            {
                presentation.Save();
                presentation.Close();
                pwpApp.Quit();
                File.Delete(path);
            }
        }
    }
}
