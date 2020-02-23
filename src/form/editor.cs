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

namespace src.form
{
    
    public partial class editor : Form
    {
        Project Project; 
        List<Segment> listSegments = new List<Segment>();
        List<tm> lstTM = new List<tm>();
        fuzzymatches fuzzymatchesForm;
        public editor(Project project, fuzzymatches fuzzyForm)
        {
            InitializeComponent();
            Project = project;
            fuzzymatchesForm = new fuzzymatches();
            fuzzymatchesForm = fuzzyForm; 
        }

        private void editor_Load(object sender, EventArgs e)
        {
            initSize();
            //getThenSentences();
            setListSegment();
            setTM(); 
            setSentencesToGridview();
            editorGrid.ClearSelection();
        }

        public void initSize()
        {
            //init Size Form
            this.Left = 0;
            this.Top = 0;
            Rectangle recNew = new Rectangle();
            recNew.Width = ParentForm.ClientRectangle.Width / 2;
            recNew.Height = ParentForm.ClientRectangle.Height * 7/8; 
            this.Size = recNew.Size;

            //init Size panel Top 

            panelTop.Width = ParentForm.ClientRectangle.Width / 2;

            //init Size Grid view 
            editorGrid.Left = 0;  
            editorGrid.Width = recNew.Width;
            editorGrid.Height = recNew.Height; 
        }
        public void setListSegment()
        {
            listSegments = Project.setSegmentFromFile();
        }

        public void setTM()
        {
            lstTM = Project.getTM(); 
        }

        public void setSentencesToGridview()
        {
            editorGrid.Rows.Add();
            editorGrid.RowCount = listSegments.Count;
            for(int i = 0; i < listSegments.Count; i++)
            {
                editorGrid.Rows[i].Cells["sourceColumn"].Value = listSegments[i].getValue(); 
            }
        }

        private void editorGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void editorGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                List<tm> listResult = new List<tm>();
                listResult = map(listSegments[index], lstTM);
                fuzzymatchesForm.setText(listResult);
            }
        }

        public List<tm> map(Segment a,List<tm> lst)
        {
            List<tm> listResult = new List<tm>();
            foreach(tm t in lst)
            {
                if (a.getValue() == t.Source.Trim())
                {
                    listResult.Add(t);
                }
            }
            return listResult;
        }
    }

}
