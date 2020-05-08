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
using src.form;
using src.Files; 

namespace src.form
{
    public partial class projectfiles : Form
    {
        public main mainForm;
        public List<string> listFilesName = new List<string>();
        public List<string> listExtensionFile = new List<string>(); 
        public projectfiles(main mainform)
        {
            InitializeComponent();
            this.mainForm = mainform; 
        }

        private void projectfiles_Load(object sender, EventArgs e)
        {
            initListView();
            initText(); 
            listExtensionFile = mainForm.project.getlistfileextension();
            loadAllFile();
        }


        private void initListView()
        {
            listViewFiles.Scrollable = true;
            listViewFiles.View = View.Details;

            ColumnHeader header1 = new ColumnHeader();
            header1.Text = "Tên tập tin";
            header1.Name = "colNameFile";
            header1.Width = 300;
            listViewFiles.Columns.Add(header1);

            ColumnHeader header2 = new ColumnHeader();
            header2.Text = "Loại tập tin";
            header2.Name = "colNameFilter";
            header2.Width = 100;
            listViewFiles.Columns.Add(header2);
        }

        private void loadAllFile()
        {
            listFilesName.Clear(); 
            listViewFiles.Items.Clear(); 
            if(mainForm.project != null)
            {
                try
                {
                    string path = mainForm.project.getPathSourceFolder();
                    foreach (string item in Directory.GetFiles(path))
                    {
                        FileInfo fi = new FileInfo(item);
                        string extension = fi.Extension;
                        if (listExtensionFile.Contains(extension))
                        {
                            imageListIcon.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(fi.FullName));
                            listFilesName.Add(fi.FullName);
                            ListViewItem Item = new ListViewItem(new[] { fi.Name,fi.Extension });
                            Item.ImageIndex = imageListIcon.Images.Count - 1; 
                            listViewFiles.Items.Add(Item);
                        }
                    }
                }
                catch (Exception) { }
            }
        }

        private void initText()
        {
            if(mainForm.project != null)
            {
                lblNameProject.Text = mainForm.project.getNameProject();
                lbltimecreation.Text = mainForm.project.getCreationTime().ToString();
                lblLocationFile.Text = "Đường dẫn"; 
            }
        }

        private void closeForm()
        {
            this.Close(); 
            mainForm.closeProjectFilesForm(); 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            closeForm(); 
        }

        private void btnHorizontal_Click(object sender, EventArgs e)
        {
            listViewFiles.View = View.LargeIcon; 
        }

        private void btnVertical_Click(object sender, EventArgs e)
        {
            listViewFiles.View = View.Details; 
        }

        private void listViewFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lsv = sender as ListView; 
            if(lsv.SelectedItems.Count > 0)
            {
                
                if(mainForm.project != null)
                {
                    lblLocationFile.Text = Path.Combine(mainForm.project.getPathSourceFolder(),lsv.SelectedItems[0].SubItems[0].Text); 
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(listViewFiles.SelectedItems.Count > 0)
            {
                if(mainForm.project != null)
                {
                    string path = Path.Combine(Path.Combine(mainForm.project.getPathSourceFolder(), listViewFiles.SelectedItems[0].SubItems[0].Text));
                    string extension = Path.GetExtension(path);
                    string nameFile = Path.GetFileName(path);
                    foreach(file a in mainForm.project.getListFileOfSourceProject())
                    {
                        if (a.getFileName().Equals(nameFile))
                        {
                            //mainForm.setAndReadCurrentFileProject(a);
                            ////closeForm();
                            //using (frmWaitForm frm = new frmWaitForm(mainForm.readContentFile))
                            //{
                            //    //mainForm.readContentFile();
                            //    frm.ShowDialog(this); 
                            //}
                            //this.Close(); 
                            //mainForm.openEditorForm();
                            openFile(a);
                            //closeForm();
                            break; 
                        }
                    }
                }
            }
        }

        private void projectfiles_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.closeProjectFilesForm(); 
        }
        private void openFile(file a)
        {
            mainForm.setAndReadCurrentFileProject(a);
            this.Hide(); 
            using (frmWaitForm frm = new frmWaitForm(mainForm.readContentFile))
            {
                //mainForm.readContentFile();
                frm.ShowDialog(this);
            }
            closeForm(); 
            mainForm.openEditorForm(); 
        }
    }
}
