using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using src.TB;
using System.Text.RegularExpressions;
using ComponentFactory.Krypton.Toolkit;

namespace src.form
{
    public partial class dictionary : Form
    {
        public main mainForm;
        public dictionary(main main)
        {
            InitializeComponent();
            mainForm = main;
        }

        private void dictionary_Load(object sender, EventArgs e)
        {
            initSize();
        }

        public void initSize()
        {
            tbGrid.ClearSelection();
            this.Left = mainForm.editorForm.Width + 5;
            this.Top = ParentForm.ClientRectangle.Height / 2 - 50;
        }

        public void getgetSourceToDictForm(string source)
        {
            rtbDictionary.Text = source;
            HashSet<tb> dict = mainForm.project.GetTbs();
            string word = source.ToLower();
            int count = 0;
            tbGrid.Rows.Add();
            tbGrid.RowCount = 1;
            foreach(tb tb in dict)
            {
                string Word = tb.word.ToLower();
                string match = String.Format(@"\b{0}\b", Regex.Escape(Word));
                if (Regex.IsMatch(word, match, RegexOptions.IgnoreCase))
                {
                    int index = Regex.Match(word,match).Index;
                    int selectionlength = Word.Length;
                    //rtbDictionary.AppendText(String.Format("\n{0} : {1}", tb.word, tb.definition));
                    tbGrid.RowCount += 1;
                    tbGrid.Rows[count].Cells["wordColumn"].Value = tb.word;
                    tbGrid.Rows[count].Cells["definitionColumn"].Value = tb.definition;
                    count++;
                    rtbDictionary.AppendText(word,index,selectionlength);
                }
            }
        }

        private void tbGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.tbGrid.Rows[e.RowIndex];
                string src = row.Cells["wordColumn"].Value.ToString();
                string tar = row.Cells["definitionColumn"].Value.ToString();
                mainForm.findTermbaseOnline(src,tar); 
            }
        }
    }
    public static class RichTextBoxExtensions
    {
        public static void AppendText(this KryptonRichTextBox box, string text, int index, int length)
        {
            box.SelectionStart = index;
            box.SelectionLength = length;

            box.SelectionBackColor = Color.Black;
            box.SelectionColor = Color.White;
        }
    }
}
