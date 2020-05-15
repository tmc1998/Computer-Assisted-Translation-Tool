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
            this.lblTM = new System.Windows.Forms.Label();
            this.cboTMName = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckbCreateNewTM = new System.Windows.Forms.CheckBox();
            this.ckbUseTMCreated = new System.Windows.Forms.CheckBox();
            this.txtTMName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblcreatedTM = new System.Windows.Forms.Label();
            this.panelProject.SuspendLayout();
            this.panelLanguage.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.txtProjectName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProjectName.Location = new System.Drawing.Point(4, 38);
            this.txtProjectName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(656, 19);
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
            this.txtLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLocation.Location = new System.Drawing.Point(4, 98);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(542, 19);
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
            this.panelLanguage.Size = new System.Drawing.Size(670, 147);
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
            this.btnOk.Location = new System.Drawing.Point(444, 602);
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
            this.btnCancel.Location = new System.Drawing.Point(564, 602);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 35);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblTM
            // 
            this.lblTM.AutoSize = true;
            this.lblTM.Location = new System.Drawing.Point(7, 384);
            this.lblTM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTM.Name = "lblTM";
            this.lblTM.Size = new System.Drawing.Size(147, 20);
            this.lblTM.TabIndex = 4;
            this.lblTM.Text = "Translation Memory";
            // 
            // cboTMName
            // 
            this.cboTMName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboTMName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboTMName.FormattingEnabled = true;
            this.cboTMName.Location = new System.Drawing.Point(3, 57);
            this.cboTMName.Name = "cboTMName";
            this.cboTMName.Size = new System.Drawing.Size(657, 28);
            this.cboTMName.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ckbCreateNewTM);
            this.panel1.Controls.Add(this.ckbUseTMCreated);
            this.panel1.Controls.Add(this.txtTMName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblcreatedTM);
            this.panel1.Controls.Add(this.cboTMName);
            this.panel1.Location = new System.Drawing.Point(6, 407);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 187);
            this.panel1.TabIndex = 11;
            // 
            // ckbCreateNewTM
            // 
            this.ckbCreateNewTM.AutoSize = true;
            this.ckbCreateNewTM.Location = new System.Drawing.Point(5, 106);
            this.ckbCreateNewTM.Name = "ckbCreateNewTM";
            this.ckbCreateNewTM.Size = new System.Drawing.Size(114, 24);
            this.ckbCreateNewTM.TabIndex = 10;
            this.ckbCreateNewTM.Text = "Tạo TM mới ";
            this.ckbCreateNewTM.UseVisualStyleBackColor = true;
            this.ckbCreateNewTM.CheckedChanged += new System.EventHandler(this.ckbCreateNewTM_CheckedChanged);
            // 
            // ckbUseTMCreated
            // 
            this.ckbUseTMCreated.AutoSize = true;
            this.ckbUseTMCreated.Location = new System.Drawing.Point(5, 7);
            this.ckbUseTMCreated.Name = "ckbUseTMCreated";
            this.ckbUseTMCreated.Size = new System.Drawing.Size(167, 24);
            this.ckbUseTMCreated.TabIndex = 9;
            this.ckbUseTMCreated.Text = "Sử dụng TM đã tạo ";
            this.ckbUseTMCreated.UseVisualStyleBackColor = true;
            this.ckbUseTMCreated.CheckedChanged += new System.EventHandler(this.ckbUseTMCreated_CheckedChanged);
            // 
            // txtTMName
            // 
            this.txtTMName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTMName.Location = new System.Drawing.Point(3, 156);
            this.txtTMName.Name = "txtTMName";
            this.txtTMName.Size = new System.Drawing.Size(659, 19);
            this.txtTMName.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên TM :";
            // 
            // lblcreatedTM
            // 
            this.lblcreatedTM.AutoSize = true;
            this.lblcreatedTM.Location = new System.Drawing.Point(0, 34);
            this.lblcreatedTM.Name = "lblcreatedTM";
            this.lblcreatedTM.Size = new System.Drawing.Size(88, 20);
            this.lblcreatedTM.TabIndex = 6;
            this.lblcreatedTM.Text = "TM đã tạo :";
            // 
            // createNewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(682, 641);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTM);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.panelLanguage);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.panelProject);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.ComboBox cboTMName;
        private System.Windows.Forms.Label lblTM;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblcreatedTM;
        private System.Windows.Forms.TextBox txtTMName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckbUseTMCreated;
        private System.Windows.Forms.CheckBox ckbCreateNewTM;
    }
}