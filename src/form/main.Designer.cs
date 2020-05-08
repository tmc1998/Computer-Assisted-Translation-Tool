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
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createTranslatedDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.machineTranslationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myMemoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openNMTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.CreateProjectButton = new System.Windows.Forms.ToolStripButton();
            this.SaveProjectButton = new System.Windows.Forms.ToolStripButton();
            this.OpenProjectButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ReloadFolder = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.CreateTranslationFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectToolStripMenuItem,
            this.machineTranslationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1034, 32);
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
            this.projectToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.projectToolStripMenuItem.Text = "Dự án";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.newToolStripMenuItem.Text = "Tạo dự án";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.openToolStripMenuItem.Text = "Mở dự án";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reloadToolStripMenuItem.Image")));
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.reloadToolStripMenuItem.Text = "Tải lại";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.reloadToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("SaveToolStripMenuItem.Image")));
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.SaveToolStripMenuItem.Text = "Lưu";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.lưuToolStripMenuItem_Click);
            // 
            // createTranslatedDocumentToolStripMenuItem
            // 
            this.createTranslatedDocumentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("createTranslatedDocumentToolStripMenuItem.Image")));
            this.createTranslatedDocumentToolStripMenuItem.Name = "createTranslatedDocumentToolStripMenuItem";
            this.createTranslatedDocumentToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.createTranslatedDocumentToolStripMenuItem.Text = "Tạo tập tin dịch";
            this.createTranslatedDocumentToolStripMenuItem.Click += new System.EventHandler(this.createTranslatedDocumentToolStripMenuItem_Click);
            // 
            // machineTranslationToolStripMenuItem
            // 
            this.machineTranslationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myMemoryToolStripMenuItem,
            this.openNMTToolStripMenuItem});
            this.machineTranslationToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.machineTranslationToolStripMenuItem.Name = "machineTranslationToolStripMenuItem";
            this.machineTranslationToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.machineTranslationToolStripMenuItem.Text = "Machine Translation";
            // 
            // myMemoryToolStripMenuItem
            // 
            this.myMemoryToolStripMenuItem.Name = "myMemoryToolStripMenuItem";
            this.myMemoryToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.myMemoryToolStripMenuItem.Text = "MyMemory";
            this.myMemoryToolStripMenuItem.Click += new System.EventHandler(this.myMemoryToolStripMenuItem_Click);
            // 
            // openNMTToolStripMenuItem
            // 
            this.openNMTToolStripMenuItem.Name = "openNMTToolStripMenuItem";
            this.openNMTToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.openNMTToolStripMenuItem.Text = "OpenNMT";
            this.openNMTToolStripMenuItem.Click += new System.EventHandler(this.openNMTToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateProjectButton,
            this.OpenProjectButton,
            this.SaveProjectButton,
            this.toolStripSeparator1,
            this.ReloadFolder,
            this.toolStripSeparator2,
            this.CreateTranslationFile,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 32);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1034, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // CreateProjectButton
            // 
            this.CreateProjectButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CreateProjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CreateProjectButton.Image = ((System.Drawing.Image)(resources.GetObject("CreateProjectButton.Image")));
            this.CreateProjectButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CreateProjectButton.Name = "CreateProjectButton";
            this.CreateProjectButton.Size = new System.Drawing.Size(100, 24);
            this.CreateProjectButton.Text = "Tạo dự án";
            this.CreateProjectButton.Click += new System.EventHandler(this.CreateProjectButton_Click);
            // 
            // SaveProjectButton
            // 
            this.SaveProjectButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SaveProjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SaveProjectButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveProjectButton.Image")));
            this.SaveProjectButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveProjectButton.Name = "SaveProjectButton";
            this.SaveProjectButton.Size = new System.Drawing.Size(100, 24);
            this.SaveProjectButton.Text = "Lưu dự án";
            this.SaveProjectButton.Click += new System.EventHandler(this.SaveProjectButton_Click);
            // 
            // OpenProjectButton
            // 
            this.OpenProjectButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.OpenProjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.OpenProjectButton.Image = ((System.Drawing.Image)(resources.GetObject("OpenProjectButton.Image")));
            this.OpenProjectButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenProjectButton.Name = "OpenProjectButton";
            this.OpenProjectButton.Size = new System.Drawing.Size(95, 24);
            this.OpenProjectButton.Text = "Mở dự án";
            this.OpenProjectButton.Click += new System.EventHandler(this.OpenProjectButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // ReloadFolder
            // 
            this.ReloadFolder.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ReloadFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ReloadFolder.Image = ((System.Drawing.Image)(resources.GetObject("ReloadFolder.Image")));
            this.ReloadFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ReloadFolder.Name = "ReloadFolder";
            this.ReloadFolder.Size = new System.Drawing.Size(130, 24);
            this.ReloadFolder.Text = "Tải lại thư mục";
            this.ReloadFolder.Click += new System.EventHandler(this.ReloadFolder_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // CreateTranslationFile
            // 
            this.CreateTranslationFile.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CreateTranslationFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CreateTranslationFile.Image = ((System.Drawing.Image)(resources.GetObject("CreateTranslationFile.Image")));
            this.CreateTranslationFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CreateTranslationFile.Name = "CreateTranslationFile";
            this.CreateTranslationFile.Size = new System.Drawing.Size(137, 24);
            this.CreateTranslationFile.Text = "Tạo tập tin dịch";
            this.CreateTranslationFile.Click += new System.EventHandler(this.CreateTranslationFile_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1034, 496);
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
        private System.Windows.Forms.ToolStripButton SaveProjectButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ReloadFolder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton CreateTranslationFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}