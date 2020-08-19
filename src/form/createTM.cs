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
    public partial class createTM : Form
    {
        public main mainForm; 
        public createTM(main main)
        {
            InitializeComponent();
            mainForm = main;
        }

        private void createTM_Load(object sender, EventArgs e)
        {
            initForm(); 
        }

        public void initForm()
        {
            kryptonGroupBox1.Text = "Hãy nhập mật khẩu";
            txtPassword.PasswordChar = '*'; 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            exit(); 
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            string password = txtPassword.Text;
            mainForm.createTM(password);
            exit(); 
        }

        private void exit()
        {
            mainForm.nullCreateTMForm();
            this.Close();
        }
    }
}
