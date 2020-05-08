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
            mainForm.closeCreateProjectForm(); 
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            TextOfMessageBox a = new TextOfMessageBox();
            if (txtLocation.Text != "" && txtProjectName.Text != "")
            {
                string root = Path.Combine(txtLocation.Text,txtProjectName.Text);
                if (Directory.Exists(root))
                {
                    MessageBox.Show(a.FOLDER_EXISTING_MESAGEBOX, "Cảnh báo", MessageBoxButtons.YesNo);
                }
                else
                {
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
                    mainForm.setProject(project);
                    mainForm.createNewProject();
                    //mainForm.creatNewProjectForm = null; 
                    closeForm(); 
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
    }
}
