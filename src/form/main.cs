using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using src.form;
using src.project; 
using System.IO; 

namespace src.form
{
    public partial class main : Form
    {
        Project project = new Project();
        fuzzymatches fuzzymatchesForm; 
        editor editorForm;
        public System.Windows.Forms.Form ParentForm { get; }

        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            //openChildForm();
            setBackColor();
            openChildForm(); 
        }


        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                project.newProject(fileDialog.FileName); 
            }
            openEditorForm(); 
        }

        public void openChildForm()
        {
            fuzzymatchesForm = new fuzzymatches();
            fuzzymatchesForm.MdiParent = this;
            fuzzymatchesForm.Show(); 

        }

        public void openEditorForm()
        {
            editorForm = new editor(project, fuzzymatchesForm);
            editorForm.MdiParent = this;
            editorForm.Show();
        }

       public Form GetForm()
        {
            return fuzzymatchesForm;
        }

        public void setBackColor()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MdiClient)
                {
                    ctrl.BackColor = Color.Gray;
                }
            }
        }
    }
}
