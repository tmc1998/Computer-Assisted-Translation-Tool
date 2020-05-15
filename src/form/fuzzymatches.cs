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

namespace src.form
{
    public partial class fuzzymatches : Form
    {
        public main main;
        public string text = "Hiển thị các phân đoạn phù hợp về ngữ nghĩa mà bạn đã lưu trong TM";
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

            this.Left = main.editorForm.Width + 2;
            this.Top = 0;
            rtbFuzzyMatches.Text = text; 

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

        public void setResultPredictSemantic(List<tm> data,string srcText)
        {
            text = "";
            if (data.Count != 0)
            {
                semanticSimilarityAPI api = new semanticSimilarityAPI();
                List<semanticSimilarity> results = api.getResultPredict(data, srcText);
                Console.WriteLine(results.Count);
                if (results.Count == 0)
                {
                        text = "Không có kết quả";
                }
                else
                {
                    foreach (semanticSimilarity result in results)
                    {
                        text += result.src + "\n" + result.tag + "\n" + "Độ tương đồng : " + result.score.ToString() + "\n";
                    }
                }
            }
            else
            {
                text = "Không có kết quả";
            }

            rtbFuzzyMatches.Text = text; 
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
    }
}
