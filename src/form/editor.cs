using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using src.project;
using src.segment;
using src.TM;
using src.Text;
using src.Files;
using src.machinetranslator;

namespace src.form
{
    
    public partial class editor : Form
    {
        Project Project;
        List<Segment> listSegments = new List<Segment>();
        List<tm> lstTM = new List<tm>();
        fuzzymatches fuzzymatchesForm;
        main mainForm; 
        public editor(main MainForm)
        {
            InitializeComponent();
            mainForm = MainForm;  
        }

        private void editor_Load(object sender, EventArgs e)
        {
            initSize();
            editorGrid.ClearSelection();
            openIntroduction(); 
        }

        public void initSize()
        {
            //init Size Form
        

            ////init Size panel Top 

            //panelTop.Width = ParentForm.ClientRectangle.Width / 2;

            ////init Size Grid view 
            //editorGrid.Left = 0;  
            //editorGrid.Width = recNew.Width;
            //editorGrid.Height = recNew.Height;

            //rtbTutorial.Left = 0;
            //rtbTutorial.Width = recNew.Width;
            //rtbTutorial.Height = recNew.Height; 
            //editorGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

        }
        public void setSentencesToGridview()
        {
            editorGrid.Rows.Clear();
            if(mainForm.project != null)
            {
                file a = mainForm.project.getCurrentFile();
                List<Segment> listSegs = new List<Segment>();
                listSegs = a.getListSegments();
                editorGrid.Rows.Add();
                editorGrid.RowCount = listSegs.Count;
                for (int i = 0;i < listSegs.Count; i++)
                {
                    editorGrid.Rows[i].Cells["sourceColumn"].Value = listSegs[i].getTMSource();
                    editorGrid.Rows[i].Cells["targetColumn"].Value = listSegs[i].getTMTarget(); 
                }
            }
        }

        private void editorGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void editorGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Index = e.RowIndex;
            if (Index >= 0)
            {
                string source = editorGrid.Rows[Index].Cells["sourceColumn"].Value.ToString();
                mainForm.resetTextMachineTranslationForm(); 
                mainForm.translationMachine(source); 
            }
        }

        public void openTutorial()
        {
            editorGrid.Visible = false;
            rtbTutorial.Visible = true; 
            txt txt = new txt(); 
            rtbTutorial.Text = txt.TUTORIAL_PROJECT;
            lblEditor.Text = txt.EMPTY_PROJECT;
        }

        public void openIntroduction()
        {
            txt txt = new txt(); 
            editorGrid.Visible = false;
            lblEditor.Text = txt.CAT_INTRODUCTION_LABEL; 
            rtbTutorial.Text = txt.CAT_INTRODUCTION; 
        }

        public void openEditor()
        {
            txt txt = new txt();
            rtbTutorial.Visible = false;
            editorGrid.Visible = true;
            //UpdateFont(); 
            if(mainForm != null)
            {
                file a = mainForm.project.getCurrentFile();
                groupBox1.Text = mainForm.project.getCurrentFile().getFileName(); 
            }
            setSentencesToGridview(); 
        }

        private void editorGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int Index = e.RowIndex;
            string SourceText = editorGrid.Rows[Index].Cells["sourceColumn"].Value.ToString();
            string TargetText = null; 
            tm tm = new tm();
            Segment tmp = new Segment();
            tm.Source = SourceText;
            if (editorGrid.Rows[Index].Cells["targetColumn"].Value != null)
            {
                TargetText = editorGrid.Rows[Index].Cells["targetColumn"].Value.ToString();
                if (mainForm.project != null)
                {
                    tm.Target = TargetText;   
                }
            }
            tmp.setTM(tm);
            mainForm.project.setTargetLangToCurrentFileListSegment(Index, TargetText);
            mainForm.project.addSegmentToListSaveSegment(tmp);
        }
        private void UpdateFont()
        {
            //Change cell font
            foreach (DataGridViewColumn c in editorGrid.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 14F, GraphicsUnit.Pixel);
            }
        }
    }

}
