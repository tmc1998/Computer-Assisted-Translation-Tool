using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using src.semanticsimilarity;
using src.TM;
using src.machinetranslator;

namespace src.form
{
    public partial class fuzzymatches : Form
    {
        public main main;
        public string text = "Hiển thị các phân đoạn phù hợp về ngữ nghĩa mà bạn đã lưu trong TM";
        public string type = "TM";
        public fuzzymatches(main Main)
        {
            InitializeComponent();
            main = Main; 
        }

        private void fuzzymatches_Load(object sender, EventArgs e)
        {
            initSize();
         
        }

        public void initSize()
        {
            //init Size Form

            this.Left = main.editorForm.Width - 5;
            this.Top = 0;
            rtbFuzzyMatches.Text = text;
            resultGrid.Visible = false; 

            //Rectangle recNew = new Rectangle();
            //recNew.Width = ParentForm.ClientRectangle.Width / 2;
            //recNew.Height = ParentForm.ClientRectangle.Height / 2;
            //this.Size = recNew.Size;

            ////init Size panel Top 

            //panelTop.Width = ParentForm.ClientRectangle.Width / 2;
        }

        public Form getHandle()
        {
            return this; 
        }

        public void setText(List<tm> listResult)
        {
            if (listResult.Count > 0)
            {
                foreach (tm t in listResult)
                {
                    rtbFuzzyMatches.Text = t.Target;
                }
            }
            else
            {
                rtbFuzzyMatches.Text = ""; 
            }
        }

        public void hideRTBFuzzymatched()
        {
            rtbFuzzyMatches.Visible = false;
            resultGrid.Visible = true;
            resultGrid.ClearSelection();
        }

        public List<semanticSimilarity> getResultSemantic(string src,List<tm> data)
        {
            semanticSimilarityAPI api = new semanticSimilarityAPI();
            List<semanticSimilarity> result = new List<semanticSimilarity>();
            result = api.getResultPredict(data, src);
            return result;
        }

        public void setResultPredictSemantic(List<semanticSimilarity> resultSemantic, List<machineTranslationResult> resultMT)
        {
            this.resultGrid.DataSource = null;
            resultGrid.Rows.Add();
            int rowcount = 0;
            resultGrid.RowCount = rowcount;
            if(resultSemantic != null)
            {
                rowcount = resultSemantic.Count;
                resultGrid.RowCount = rowcount;
                for (int i = 0; i < resultSemantic.Count; i++)
                {
                    resultGrid.Rows[i].Cells["sourceColumn"].Value = resultSemantic[i].src;
                    resultGrid.Rows[i].Cells["targetColumn"].Value = resultSemantic[i].tag;
                    resultGrid.Rows[i].Cells["scoreColumn"].Value = Math.Round(resultSemantic[i].score);
                    resultGrid.Rows[i].Cells["typeColumn"].Value = type;
                }
            }
            resultGrid.RowCount += resultMT.Count;
            for (int i = 0; i < resultMT.Count; i++)
            {
                if (!resultMT[i].fail)
                {
                    resultGrid.Rows[i + rowcount].Cells["sourceColumn"].Value = resultMT[i].src;
                    resultGrid.Rows[i + rowcount].Cells["targetColumn"].Value = resultMT[i].tag;
                    resultGrid.Rows[i + rowcount].Cells["scoreColumn"].Value = resultMT[i].score;
                    resultGrid.Rows[i + rowcount].Cells["typeColumn"].Value = resultMT[i].type;
                }
            }
        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblfuzzymatches_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void resultGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.resultGrid.Rows[e.RowIndex];
                string src = row.Cells["sourceColumn"].Value.ToString();
                string tar = row.Cells["targetColumn"].Value.ToString();
                main.setTargetToGridFromFuzzyMatched(tar); 
            }
        }
    }
}
