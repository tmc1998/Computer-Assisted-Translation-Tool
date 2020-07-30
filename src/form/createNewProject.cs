using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using src.language;
using src.messagebox;
using src.project;
using src.TM; 

namespace src.form
{
    public partial class createNewProject : Form
    {
        public main mainForm; 
        public createNewProject(main main)
        {
            InitializeComponent();
            mainForm = main; 
        }

        private void createNewProject_Load(object sender, EventArgs e)
        {
            LanguageList listLanguage1 = new LanguageList();
            LanguageList listLanguage2 = new LanguageList(); 
    
            cboSourceFilesLanguage.DataSource = listLanguage1.getListLanguage();
            cboSourceFilesLanguage.DisplayMember = "name";

            cboTranslatedFilesLanguage.DataSource = listLanguage2.getListLanguage();
            cboTranslatedFilesLanguage.DisplayMember = "name";

            DAOTM daoTM = new DAOTM();
            cboTMName.Items.Insert(0, string.Empty);
            cboTMName.DataSource = daoTM.GetTablenames();
            cboTMName.DisplayMember = "name";

            txtLocation.Text = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);


        }


        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            fbd.Description = "Select Folder"; 
            
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                txtLocation.Text = fbd.SelectedPath; 
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            closeForm(); 
        }

        private void closeForm()
        {
            this.Close();
            this.Hide(); 
            //mainForm.closeCreateProjectForm(); 
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            TextOfMessageBox a = new TextOfMessageBox();
            DAOTM daoTM = new DAOTM();
            List<tablename> tmnames = daoTM.GetTablenames(); 
            if (txtLocation.Text != "" && txtProjectName.Text != "" && ((ckbCreateNewTM.Checked && txtTMName.Text  != "") || (ckbUseTMCreated.Checked && cboTMName.SelectedValue != null)))
            {
                if (checkExistsTM(tmnames,txtTMName.Text))
                {
                    string root = Path.Combine(txtLocation.Text, txtProjectName.Text);
                    if (Directory.Exists(root))
                    {
                        MessageBox.Show(a.FOLDER_EXISTING_MESAGEBOX, "Cảnh báo", MessageBoxButtons.YesNo);
                    }
                    else
                    {
                        createProject(); 
                    }
                }
                else
                {
                    MessageBox.Show(a.EXISTS_TM, "Cảnh báo", MessageBoxButtons.YesNo); 
                }
            }
            else
            {
                MessageBox.Show(a.CREATE_NEW_PROJECT_MESSAGEBOX, "Cảnh báo", MessageBoxButtons.YesNo); 
            }
        }

        private void createNewProject_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.closeCreateProjectForm(); 
        }

        private void createProject()
        {
            DAOTM tmdao = new DAOTM();
            TextOfMessageBox a = new TextOfMessageBox();
            string name = txtProjectName.Text;
            string sourceFileLanguge = cboSourceFilesLanguage.Text;
            string translatedFileLanguge = cboTranslatedFilesLanguage.Text;
            //string locationFolder = txtLocation.Text + "\\" + txtProjectName.Text;
            string locationFolder = Path.Combine(txtLocation.Text, txtProjectName.Text);
            DateTime now = new DateTime();
            now = DateTime.Now;
            Project project = new Project();
            project.setLanguage(sourceFileLanguge, translatedFileLanguge);
            project.setNameProject(name);
            project.setPathProject(locationFolder);
            project.setCreationTime(now);
            if (ckbUseTMCreated.Checked)
            {
                tablename tbn = cboTMName.SelectedItem as tablename;
                project.setTMName(tbn.name);

                mainForm.setProject(project);
                closeForm();
                mainForm.createNewProject();
                //mainForm.creatNewProjectForm = null; 
                //closeForm();
            }
            if (ckbCreateNewTM.Checked)
            {
                string tmname = txtTMName.Text;
                project.setTMName(tmname);
                int result = tmdao.createTable(project.getTMName());
                if (result == 0)
                {
                    mainForm.setProject(project);
                    closeForm();
                    mainForm.createNewProject();
                    //mainForm.creatNewProjectForm = null; 
                    closeForm();
                }
                else
                {
                    MessageBox.Show(a.CREATE_TM_FAILED, "Cảnh báo", MessageBoxButtons.YesNo);
                }
            }
          
        }

        private void ckbUseTMCreated_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbUseTMCreated.Checked)
            {
                ckbCreateNewTM.Enabled = false;
                txtTMName.Enabled = false;
            }
            else
            {
                ckbCreateNewTM.Enabled = true;
                txtTMName.Enabled = true; 
            }
        }

        bool checkExistsTM(List<tablename> tmnames, string tm)
        {
            foreach(tablename tbname in tmnames)
            {
                if(tbname.name == tm)
                {
                    return false; 
                }
            }
            return true; 
        }

        private void ckbCreateNewTM_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbCreateNewTM.Checked)
            {
                ckbUseTMCreated.Enabled = false;
                cboTMName.Enabled = false;
                tablename tb = cboTMName.SelectedItem as tablename;
                Console.WriteLine(tb.name); 
            }
            else
            {
                ckbUseTMCreated.Enabled = true;
                cboTMName.Enabled = true;
            }
        }

        private void kryptonLabel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
