namespace src.form
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createTranslatedDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.machineTranslationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myMemoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openNMTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TMLocalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TMGlobalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cơSởThuậtNgữToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findTembarseOnlineToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmCơSởThuậtNgữToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.CreateProjectButton = new System.Windows.Forms.ToolStripButton();
            this.OpenProjectButton = new System.Windows.Forms.ToolStripButton();
            this.btnStripSaveProject = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnStripReloadFolder = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnStripCreateTranslationFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnStripSaveSegment = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectToolStripMenuItem,
            this.machineTranslationToolStripMenuItem,
            this.tMToolStripMenuItem,
            this.cơSởThuậtNgữToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1029, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.reloadToolStripMenuItem,
            this.createTranslatedDocumentToolStripMenuItem});
            this.projectToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(48, 19);
            this.projectToolStripMenuItem.Text = "Dự án";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.newToolStripMenuItem.Text = "Tạo dự án";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.openToolStripMenuItem.Text = "Mở dự án";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("SaveToolStripMenuItem.Image")));
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.SaveToolStripMenuItem.Text = "Lưu";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.lưuToolStripMenuItem_Click);
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reloadToolStripMenuItem.Image")));
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.reloadToolStripMenuItem.Text = "Tải lại";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.reloadToolStripMenuItem_Click);
            // 
            // createTranslatedDocumentToolStripMenuItem
            // 
            this.createTranslatedDocumentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("createTranslatedDocumentToolStripMenuItem.Image")));
            this.createTranslatedDocumentToolStripMenuItem.Name = "createTranslatedDocumentToolStripMenuItem";
            this.createTranslatedDocumentToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.createTranslatedDocumentToolStripMenuItem.Text = "Tạo tập tin dịch";
            this.createTranslatedDocumentToolStripMenuItem.Click += new System.EventHandler(this.createTranslatedDocumentToolStripMenuItem_Click);
            // 
            // machineTranslationToolStripMenuItem
            // 
            this.machineTranslationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myMemoryToolStripMenuItem,
            this.openNMTToolStripMenuItem});
            this.machineTranslationToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machineTranslationToolStripMenuItem.Name = "machineTranslationToolStripMenuItem";
            this.machineTranslationToolStripMenuItem.Size = new System.Drawing.Size(63, 19);
            this.machineTranslationToolStripMenuItem.Text = "Dịch máy";
            // 
            // myMemoryToolStripMenuItem
            // 
            this.myMemoryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("myMemoryToolStripMenuItem.Image")));
            this.myMemoryToolStripMenuItem.Name = "myMemoryToolStripMenuItem";
            this.myMemoryToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.myMemoryToolStripMenuItem.Text = "MyMemory";
            this.myMemoryToolStripMenuItem.Click += new System.EventHandler(this.myMemoryToolStripMenuItem_Click);
            // 
            // openNMTToolStripMenuItem
            // 
            this.openNMTToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openNMTToolStripMenuItem.Image")));
            this.openNMTToolStripMenuItem.Name = "openNMTToolStripMenuItem";
            this.openNMTToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.openNMTToolStripMenuItem.Text = "OpenNMT";
            this.openNMTToolStripMenuItem.Click += new System.EventHandler(this.openNMTToolStripMenuItem_Click);
            // 
            // tMToolStripMenuItem
            // 
            this.tMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TMLocalToolStripMenuItem,
            this.TMGlobalToolStripMenuItem});
            this.tMToolStripMenuItem.Name = "tMToolStripMenuItem";
            this.tMToolStripMenuItem.Size = new System.Drawing.Size(82, 19);
            this.tMToolStripMenuItem.Text = "Dữ liệu dịch";
            // 
            // TMLocalToolStripMenuItem
            // 
            this.TMLocalToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("TMLocalToolStripMenuItem.Image")));
            this.TMLocalToolStripMenuItem.Name = "TMLocalToolStripMenuItem";
            this.TMLocalToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.TMLocalToolStripMenuItem.Text = "Dữ liệu dịch của bạn";
            this.TMLocalToolStripMenuItem.Click += new System.EventHandler(this.TMLocalToolStripMenuItem_Click);
            // 
            // TMGlobalToolStripMenuItem
            // 
            this.TMGlobalToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("TMGlobalToolStripMenuItem.Image")));
            this.TMGlobalToolStripMenuItem.Name = "TMGlobalToolStripMenuItem";
            this.TMGlobalToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.TMGlobalToolStripMenuItem.Text = "Dữ liệu dịch trực tuyến";
            this.TMGlobalToolStripMenuItem.Click += new System.EventHandler(this.TMGlobalToolStripMenuItem_Click);
            // 
            // cơSởThuậtNgữToolStripMenuItem
            // 
            this.cơSởThuậtNgữToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findTembarseOnlineToolStripMenu,
            this.thêmCơSởThuậtNgữToolStripMenuItem});
            this.cơSởThuậtNgữToolStripMenuItem.Name = "cơSởThuậtNgữToolStripMenuItem";
            this.cơSởThuậtNgữToolStripMenuItem.Size = new System.Drawing.Size(104, 19);
            this.cơSởThuậtNgữToolStripMenuItem.Text = "Cơ sở thuật ngữ";
            // 
            // findTembarseOnlineToolStripMenu
            // 
            this.findTembarseOnlineToolStripMenu.Name = "findTembarseOnlineToolStripMenu";
            this.findTembarseOnlineToolStripMenu.Size = new System.Drawing.Size(197, 22);
            this.findTembarseOnlineToolStripMenu.Text = "Tìm thuật ngữ trên wiki";
            this.findTembarseOnlineToolStripMenu.Click += new System.EventHandler(this.findTembarseOnlineToolStripMenu_Click);
            // 
            // thêmCơSởThuậtNgữToolStripMenuItem
            // 
            this.thêmCơSởThuậtNgữToolStripMenuItem.Name = "thêmCơSởThuậtNgữToolStripMenuItem";
            this.thêmCơSởThuậtNgữToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.thêmCơSởThuậtNgữToolStripMenuItem.Text = "Thêm cơ sở thuật ngữ";
            this.thêmCơSởThuậtNgữToolStripMenuItem.Click += new System.EventHandler(this.thêmCơSởThuậtNgữToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateProjectButton,
            this.OpenProjectButton,
            this.btnStripSaveProject,
            this.toolStripSeparator1,
            this.btnStripReloadFolder,
            this.toolStripSeparator2,
            this.btnStripCreateTranslationFile,
            this.toolStripSeparator3,
            this.btnStripSaveSegment,
            this.toolStripSeparator4,
            this.toolStripButton1,
            this.toolStripSeparator5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 27);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1029, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // CreateProjectButton
            // 
            this.CreateProjectButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CreateProjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateProjectButton.Image = ((System.Drawing.Image)(resources.GetObject("CreateProjectButton.Image")));
            this.CreateProjectButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CreateProjectButton.Name = "CreateProjectButton";
            this.CreateProjectButton.Size = new System.Drawing.Size(76, 22);
            this.CreateProjectButton.Text = "Tạo dự án";
            this.CreateProjectButton.ToolTipText = "Tạo dự án để bắt đầu công việc dịch thuật của bạn";
            this.CreateProjectButton.Click += new System.EventHandler(this.CreateProjectButton_Click);
            // 
            // OpenProjectButton
            // 
            this.OpenProjectButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.OpenProjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenProjectButton.Image = ((System.Drawing.Image)(resources.GetObject("OpenProjectButton.Image")));
            this.OpenProjectButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenProjectButton.Name = "OpenProjectButton";
            this.OpenProjectButton.Size = new System.Drawing.Size(72, 22);
            this.OpenProjectButton.Text = "Mở dự án";
            this.OpenProjectButton.ToolTipText = "Mở dự án bạn đã có sẵn để tiếp tục công việc dịch thuật";
            this.OpenProjectButton.Click += new System.EventHandler(this.OpenProjectButton_Click);
            // 
            // btnStripSaveProject
            // 
            this.btnStripSaveProject.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStripSaveProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStripSaveProject.Image = ((System.Drawing.Image)(resources.GetObject("btnStripSaveProject.Image")));
            this.btnStripSaveProject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStripSaveProject.Name = "btnStripSaveProject";
            this.btnStripSaveProject.Size = new System.Drawing.Size(75, 22);
            this.btnStripSaveProject.Text = "Lưu dự án";
            this.btnStripSaveProject.ToolTipText = "Lưu dự án của bạn để tiếp tục sử dụng trong lần tới";
            this.btnStripSaveProject.Click += new System.EventHandler(this.SaveProjectButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnStripReloadFolder
            // 
            this.btnStripReloadFolder.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStripReloadFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStripReloadFolder.Image = ((System.Drawing.Image)(resources.GetObject("btnStripReloadFolder.Image")));
            this.btnStripReloadFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStripReloadFolder.Name = "btnStripReloadFolder";
            this.btnStripReloadFolder.Size = new System.Drawing.Size(96, 22);
            this.btnStripReloadFolder.Text = "Tải lại thư mục";
            this.btnStripReloadFolder.ToolTipText = "Tải lại thư mục chứa tệp cần dịch";
            this.btnStripReloadFolder.Click += new System.EventHandler(this.ReloadFolder_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnStripCreateTranslationFile
            // 
            this.btnStripCreateTranslationFile.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStripCreateTranslationFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStripCreateTranslationFile.Image = ((System.Drawing.Image)(resources.GetObject("btnStripCreateTranslationFile.Image")));
            this.btnStripCreateTranslationFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStripCreateTranslationFile.Name = "btnStripCreateTranslationFile";
            this.btnStripCreateTranslationFile.Size = new System.Drawing.Size(101, 22);
            this.btnStripCreateTranslationFile.Text = "Tạo tập tin dịch";
            this.btnStripCreateTranslationFile.ToolTipText = "Tạo tập tin dịch sau quá trình dịch thuật";
            this.btnStripCreateTranslationFile.Click += new System.EventHandler(this.CreateTranslationFile_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnStripSaveSegment
            // 
            this.btnStripSaveSegment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStripSaveSegment.Image = ((System.Drawing.Image)(resources.GetObject("btnStripSaveSegment.Image")));
            this.btnStripSaveSegment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStripSaveSegment.Name = "btnStripSaveSegment";
            this.btnStripSaveSegment.Size = new System.Drawing.Size(100, 22);
            this.btnStripSaveSegment.Text = "Lưu phân đoạn";
            this.btnStripSaveSegment.ToolTipText = "Lưu phân đoạn vào Translation Memory";
            this.btnStripSaveSegment.Click += new System.EventHandler(this.btnStripSaveSegment_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(137, 22);
            this.toolStripButton1.Text = "Tạo kho dữ liệu dịch";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 470);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 26);
            this.panel1.TabIndex = 4;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1029, 496);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CAT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.main_FormClosing);
            this.Load += new System.EventHandler(this.main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createTranslatedDocumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem machineTranslationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myMemoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openNMTToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton CreateProjectButton;
        private System.Windows.Forms.ToolStripButton OpenProjectButton;
        private System.Windows.Forms.ToolStripButton btnStripSaveProject;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnStripReloadFolder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnStripCreateTranslationFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnStripSaveSegment;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem tMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TMLocalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TMGlobalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cơSởThuậtNgữToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findTembarseOnlineToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem thêmCơSởThuậtNgữToolStripMenuItem;
    }
}