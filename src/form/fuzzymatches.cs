using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using src.TM;

namespace src.form
{
    public partial class fuzzymatches : Form
    {
        public fuzzymatches()
        {
            InitializeComponent();
        }

        private void fuzzymatches_Load(object sender, EventArgs e)
        {
            initSize();
         
        }

        public void initSize()
        {
            //init Size Form
            this.Left = ParentForm.ClientRectangle.Width / 2 + 2;
            this.Top = 0;
            Rectangle recNew = new Rectangle();
            recNew.Width = ParentForm.ClientRectangle.Width / 2;
            recNew.Height = ParentForm.ClientRectangle.Height / 2;
            this.Size = recNew.Size;

            //init Size panel Top 

            panelTop.Width = ParentForm.ClientRectangle.Width / 2;
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

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
