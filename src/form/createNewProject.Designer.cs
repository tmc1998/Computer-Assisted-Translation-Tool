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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.lblProject = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.panelProject = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.x = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtLocation = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtProjectName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblLocation = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblProjectName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblLanguage = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.panelLanguage = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.cboTranslatedFilesLanguage = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cboSourceFilesLanguage = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lblTranslatedFilesLanguage = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblSourceFilesLanguage = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblTM = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.panel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.cboTMName = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.txtTMName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ckbCreateNewTM = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.ckbUseTMCreated = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.label2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblcreatedTM = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnOk = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelProject)).BeginInit();
            this.panelProject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelLanguage)).BeginInit();
            this.panelLanguage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboTranslatedFilesLanguage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSourceFilesLanguage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboTMName)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // lblProject
            // 
            this.lblProject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProject.Location = new System.Drawing.Point(6, 4);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(56, 23);
            this.lblProject.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProject.TabIndex = 12;
            this.lblProject.Values.Text = "Dự án";
            // 
            // panelProject
            // 
            this.panelProject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProject.Controls.Add(this.x);
            this.panelProject.Controls.Add(this.txtLocation);
            this.panelProject.Controls.Add(this.txtProjectName);
            this.panelProject.Controls.Add(this.lblLocation);
            this.panelProject.Controls.Add(this.lblProjectName);
            this.panelProject.Location = new System.Drawing.Point(6, 33);
            this.panelProject.Name = "panelProject";
            this.panelProject.Size = new System.Drawing.Size(666, 149);
            this.panelProject.TabIndex = 5;
            // 
            // x
            // 
            this.x.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.x.Location = new System.Drawing.Point(549, 102);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(110, 29);
            this.x.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x.TabIndex = 17;
            this.x.Values.Text = "...";
            this.x.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtLocation
            // 
            this.txtLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLocation.Location = new System.Drawing.Point(7, 105);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(520, 26);
            this.txtLocation.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.TabIndex = 16;
            // 
            // txtProjectName
            // 
            this.txtProjectName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProjectName.Location = new System.Drawing.Point(6, 48);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(655, 26);
            this.txtProjectName.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProjectName.TabIndex = 15;
            // 
            // lblLocation
            // 
            this.lblLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLocation.Location = new System.Drawing.Point(5, 80);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(97, 23);
            this.lblLocation.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.TabIndex = 14;
            this.lblLocation.Values.Text = "Đường dẫn:";
            // 
            // lblProjectName
            // 
            this.lblProjectName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProjectName.Location = new System.Drawing.Point(3, 18);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(90, 23);
            this.lblProjectName.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectName.TabIndex = 13;
            this.lblProjectName.Values.Text = "Tên dự án:";
            // 
            // lblLanguage
            // 
            this.lblLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLanguage.Location = new System.Drawing.Point(6, 191);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(83, 23);
            this.lblLanguage.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanguage.TabIndex = 13;
            this.lblLanguage.Values.Text = "Ngôn ngữ";
            // 
            // panelLanguage
            // 
            this.panelLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLanguage.Controls.Add(this.cboTranslatedFilesLanguage);
            this.panelLanguage.Controls.Add(this.cboSourceFilesLanguage);
            this.panelLanguage.Controls.Add(this.lblTranslatedFilesLanguage);
            this.panelLanguage.Controls.Add(this.lblSourceFilesLanguage);
            this.panelLanguage.Location = new System.Drawing.Point(6, 220);
            this.panelLanguage.Name = "panelLanguage";
            this.panelLanguage.Size = new System.Drawing.Size(666, 149);
            this.panelLanguage.TabIndex = 14;
            // 
            // cboTranslatedFilesLanguage
            // 
            this.cboTranslatedFilesLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTranslatedFilesLanguage.DropDownWidth = 636;
            this.cboTranslatedFilesLanguage.Location = new System.Drawing.Point(7, 109);
            this.cboTranslatedFilesLanguage.Name = "cboTranslatedFilesLanguage";
            this.cboTranslatedFilesLanguage.Size = new System.Drawing.Size(654, 24);
            this.cboTranslatedFilesLanguage.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTranslatedFilesLanguage.TabIndex = 16;
            // 
            // cboSourceFilesLanguage
            // 
            this.cboSourceFilesLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSourceFilesLanguage.DropDownWidth = 654;
            this.cboSourceFilesLanguage.Location = new System.Drawing.Point(7, 48);
            this.cboSourceFilesLanguage.Name = "cboSourceFilesLanguage";
            this.cboSourceFilesLanguage.Size = new System.Drawing.Size(654, 24);
            this.cboSourceFilesLanguage.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSourceFilesLanguage.TabIndex = 15;
            // 
            // lblTranslatedFilesLanguage
            // 
            this.lblTranslatedFilesLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTranslatedFilesLanguage.Location = new System.Drawing.Point(5, 80);
            this.lblTranslatedFilesLanguage.Name = "lblTranslatedFilesLanguage";
            this.lblTranslatedFilesLanguage.Size = new System.Drawing.Size(122, 23);
            this.lblTranslatedFilesLanguage.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTranslatedFilesLanguage.TabIndex = 14;
            this.lblTranslatedFilesLanguage.Values.Text = "Ngôn ngữ đích:";
            // 
            // lblSourceFilesLanguage
            // 
            this.lblSourceFilesLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSourceFilesLanguage.Location = new System.Drawing.Point(3, 18);
            this.lblSourceFilesLanguage.Name = "lblSourceFilesLanguage";
            this.lblSourceFilesLanguage.Size = new System.Drawing.Size(138, 23);
            this.lblSourceFilesLanguage.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSourceFilesLanguage.TabIndex = 13;
            this.lblSourceFilesLanguage.Values.Text = "Ngôn ngữ nguồn:";
            // 
            // lblTM
            // 
            this.lblTM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTM.Location = new System.Drawing.Point(6, 378);
            this.lblTM.Name = "lblTM";
            this.lblTM.Size = new System.Drawing.Size(98, 23);
            this.lblTM.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTM.TabIndex = 15;
            this.lblTM.Values.Text = "Dữ liệu dịch";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.cboTMName);
            this.panel1.Controls.Add(this.txtTMName);
            this.panel1.Controls.Add(this.ckbCreateNewTM);
            this.panel1.Controls.Add(this.ckbUseTMCreated);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblcreatedTM);
            this.panel1.Location = new System.Drawing.Point(6, 407);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 187);
            this.panel1.TabIndex = 16;
            // 
            // cboTMName
            // 
            this.cboTMName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTMName.DropDownWidth = 534;
            this.cboTMName.Location = new System.Drawing.Point(125, 47);
            this.cboTMName.Name = "cboTMName";
            this.cboTMName.Size = new System.Drawing.Size(534, 18);
            this.cboTMName.StateActive.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTMName.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTMName.TabIndex = 20;
            // 
            // txtTMName
            // 
            this.txtTMName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTMName.Location = new System.Drawing.Point(16, 146);
            this.txtTMName.Name = "txtTMName";
            this.txtTMName.Size = new System.Drawing.Size(643, 26);
            this.txtTMName.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTMName.TabIndex = 19;
            // 
            // ckbCreateNewTM
            // 
            this.ckbCreateNewTM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbCreateNewTM.Location = new System.Drawing.Point(16, 87);
            this.ckbCreateNewTM.Name = "ckbCreateNewTM";
            this.ckbCreateNewTM.Size = new System.Drawing.Size(172, 23);
            this.ckbCreateNewTM.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbCreateNewTM.TabIndex = 18;
            this.ckbCreateNewTM.Values.Text = "Tạo dữ liệu dịch mới ";
            this.ckbCreateNewTM.CheckedChanged += new System.EventHandler(this.ckbCreateNewTM_CheckedChanged);
            // 
            // ckbUseTMCreated
            // 
            this.ckbUseTMCreated.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbUseTMCreated.Location = new System.Drawing.Point(16, 17);
            this.ckbUseTMCreated.Name = "ckbUseTMCreated";
            this.ckbUseTMCreated.Size = new System.Drawing.Size(224, 23);
            this.ckbUseTMCreated.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbUseTMCreated.TabIndex = 17;
            this.ckbUseTMCreated.Values.Text = "Sử dụng dữ liệu dịch đã tạo";
            this.ckbUseTMCreated.CheckedChanged += new System.EventHandler(this.ckbUseTMCreated_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(7, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 23);
            this.label2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.TabIndex = 14;
            this.label2.Values.Text = "Tên dữ liệu dịch:";
            // 
            // lblcreatedTM
            // 
            this.lblcreatedTM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblcreatedTM.Location = new System.Drawing.Point(16, 48);
            this.lblcreatedTM.Name = "lblcreatedTM";
            this.lblcreatedTM.Size = new System.Drawing.Size(102, 23);
            this.lblcreatedTM.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcreatedTM.TabIndex = 13;
            this.lblcreatedTM.Values.Text = "Dữ liệu dịch:";
            this.lblcreatedTM.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonLabel3_Paint);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(448, 600);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(109, 35);
            this.btnOk.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.TabIndex = 17;
            this.btnOk.Values.Text = "Tạo mới";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(563, 600);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 35);
            this.btnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Values.Text = "Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // createNewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(682, 641);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTM);
            this.Controls.Add(this.panelLanguage);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.panelProject);
            this.Controls.Add(this.lblProject);
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
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelProject)).EndInit();
            this.panelProject.ResumeLayout(false);
            this.panelProject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelLanguage)).EndInit();
            this.panelLanguage.ResumeLayout(false);
            this.panelLanguage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboTranslatedFilesLanguage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSourceFilesLanguage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboTMName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel panelLanguage;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cboTranslatedFilesLanguage;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cboSourceFilesLanguage;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblTranslatedFilesLanguage;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblSourceFilesLanguage;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblLanguage;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel panelProject;
        private ComponentFactory.Krypton.Toolkit.KryptonButton x;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtLocation;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtProjectName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblLocation;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblProjectName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblProject;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox ckbCreateNewTM;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox ckbUseTMCreated;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel label2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblcreatedTM;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblTM;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTMName;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnOk;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cboTMName;
    }
}