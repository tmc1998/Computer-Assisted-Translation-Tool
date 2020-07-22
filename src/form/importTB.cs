using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace src.form
{
    public partial class importTB : Form
    {
        public main mainForm;
        public importTB(main main)
        {
            InitializeComponent();
            mainForm = main;
        }

        private void importTB_Load(object sender, EventArgs e)
        {
            init();
        }

        private void init()
        {
            txtLocation.Text = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            fbd.Description = "Select Folder";

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtLocation.Text = fbd.SelectedPath;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.createTBOffline(txtLocation.Text);
            this.Close();
        }
    }
}
