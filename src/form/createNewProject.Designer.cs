namespace src.form
{
    partial class createNewProject
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(createNewProject));
            this.lblProjectName = new System.Windows.Forms.Label();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.panelProject = new System.Windows.Forms.Panel();
            this.lblProject = new System.Windows.Forms.Label();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.panelLanguage = new System.Windows.Forms.Panel();
            this.cboTranslatedFilesLanguage = new System.Windows.Forms.ComboBox();
            this.lblTranslatedFilesLanguage = new System.Windows.Forms.Label();
            this.cboSourceFilesLanguage = new System.Windows.Forms.ComboBox();
            this.lblSourceFilesLanguage = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelProject.SuspendLayout();
            this.panelLanguage.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Location = new System.Drawing.Point(0, 14);
            this.lblProjectName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(88, 20);
            this.lblProjectName.TabIndex = 0;
            this.lblProjectName.Text = "Tên dự án :";
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(4, 38);
            this.txtProjectName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(656, 26);
            this.txtProjectName.TabIndex = 1;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(0, 74);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(96, 20);
            this.lblLocation.TabIndex = 2;
            this.lblLocation.Text = "Đường dẫn :";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(4, 98);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(542, 26);
            this.txtLocation.TabIndex = 3;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBrowse.Location = new System.Drawing.Point(550, 95);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(112, 35);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // panelProject
            // 
            this.panelProject.BackColor = System.Drawing.SystemColors.Control;
            this.panelProject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProject.Controls.Add(this.txtLocation);
            this.panelProject.Controls.Add(this.btnBrowse);
            this.panelProject.Controls.Add(this.lblLocation);
            this.panelProject.Controls.Add(this.txtProjectName);
            this.panelProject.Controls.Add(this.lblProjectName);
            this.panelProject.Location = new System.Drawing.Point(6, 35);
            this.panelProject.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelProject.Name = "panelProject";
            this.panelProject.Size = new System.Drawing.Size(670, 148);
            this.panelProject.TabIndex = 5;
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Location = new System.Drawing.Point(8, 10);
            this.lblProject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(52, 20);
            this.lblProject.TabIndex = 6;
            this.lblProject.Text = "Dự án";
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(8, 197);
            this.lblLanguage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(82, 20);
            this.lblLanguage.TabIndex = 7;
            this.lblLanguage.Text = "Ngôn ngữ ";
            // 
            // panelLanguage
            // 
            this.panelLanguage.BackColor = System.Drawing.SystemColors.Control;
            this.panelLanguage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLanguage.Controls.Add(this.cboTranslatedFilesLanguage);
            this.panelLanguage.Controls.Add(this.lblTranslatedFilesLanguage);
            this.panelLanguage.Controls.Add(this.cboSourceFilesLanguage);
            this.panelLanguage.Controls.Add(this.lblSourceFilesLanguage);
            this.panelLanguage.Location = new System.Drawing.Point(6, 222);
            this.panelLanguage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelLanguage.Name = "panelLanguage";
            this.panelLanguage.Size = new System.Drawing.Size(670, 172);
            this.panelLanguage.TabIndex = 8;
            // 
            // cboTranslatedFilesLanguage
            // 
            this.cboTranslatedFilesLanguage.FormattingEnabled = true;
            this.cboTranslatedFilesLanguage.Location = new System.Drawing.Point(4, 102);
            this.cboTranslatedFilesLanguage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboTranslatedFilesLanguage.Name = "cboTranslatedFilesLanguage";
            this.cboTranslatedFilesLanguage.Size = new System.Drawing.Size(656, 28);
            this.cboTranslatedFilesLanguage.TabIndex = 3;
            // 
            // lblTranslatedFilesLanguage
            // 
            this.lblTranslatedFilesLanguage.AutoSize = true;
            this.lblTranslatedFilesLanguage.Location = new System.Drawing.Point(0, 77);
            this.lblTranslatedFilesLanguage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTranslatedFilesLanguage.Name = "lblTranslatedFilesLanguage";
            this.lblTranslatedFilesLanguage.Size = new System.Drawing.Size(167, 20);
            this.lblTranslatedFilesLanguage.TabIndex = 2;
            this.lblTranslatedFilesLanguage.Text = "Ngôn ngữ tập tin dịch :";
            // 
            // cboSourceFilesLanguage
            // 
            this.cboSourceFilesLanguage.FormattingEnabled = true;
            this.cboSourceFilesLanguage.Location = new System.Drawing.Point(4, 40);
            this.cboSourceFilesLanguage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboSourceFilesLanguage.Name = "cboSourceFilesLanguage";
            this.cboSourceFilesLanguage.Size = new System.Drawing.Size(656, 28);
            this.cboSourceFilesLanguage.TabIndex = 1;
            // 
            // lblSourceFilesLanguage
            // 
            this.lblSourceFilesLanguage.AutoSize = true;
            this.lblSourceFilesLanguage.Location = new System.Drawing.Point(0, 15);
            this.lblSourceFilesLanguage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSourceFilesLanguage.Name = "lblSourceFilesLanguage";
            this.lblSourceFilesLanguage.Size = new System.Drawing.Size(183, 20);
            this.lblSourceFilesLanguage.TabIndex = 0;
            this.lblSourceFilesLanguage.Text = "Ngôn ngữ tập tin nguồn :";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOk.Location = new System.Drawing.Point(428, 417);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(112, 35);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "Tạo mới ";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(558, 417);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 35);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // createNewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(682, 470);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.panelLanguage);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.panelProject);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "createNewProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo dự án mới";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.createNewProject_FormClosing);
            this.Load += new System.EventHandler(this.createNewProject_Load);
            this.panelProject.ResumeLayout(false);
            this.panelProject.PerformLayout();
            this.panelLanguage.ResumeLayout(false);
            this.panelLanguage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Panel panelProject;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Panel panelLanguage;
        private System.Windows.Forms.ComboBox cboTranslatedFilesLanguage;
        private System.Windows.Forms.Label lblTranslatedFilesLanguage;
        private System.Windows.Forms.ComboBox cboSourceFilesLanguage;
        private System.Windows.Forms.Label lblSourceFilesLanguage;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}